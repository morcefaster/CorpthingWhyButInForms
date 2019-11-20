using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using DataGridViewTextBoxCell = System.Windows.Forms.DataGridViewTextBoxCell;

namespace CorpthingWhyButInForms
{
    public partial class CorpthingWhy : Form
    {

        public CorpSheet Sheet { get; set; }
        public SudokuData Sudoku { get; set; }
        public List<List<SudokuMask>> MaskData { get; set; }
        private bool SelectionChanging { get; set; }
        private int SelectedX { get; set; }
        private int SelectedY { get; set; }

        public CorpthingWhy()
        {
            InitializeComponent();
            typeof(DataGridView).InvokeMember("DoubleBuffered", BindingFlags.NonPublic |
                                                                BindingFlags.Instance | BindingFlags.SetProperty, null,
                sheetGrid, new object[] { true });
            typeof(DataGridView).InvokeMember("DoubleBuffered", BindingFlags.NonPublic |
                                                                BindingFlags.Instance | BindingFlags.SetProperty, null,
                sudokuPreviewGrid, new object[] { true });
            typeof(DataGridView).InvokeMember("DoubleBuffered", BindingFlags.NonPublic |
                                                                BindingFlags.Instance | BindingFlags.SetProperty, null,
                maskGrid, new object[] { true });
            Sheet = new CorpSheet()
            {
                Sheet = JObject.Parse(JsonData.Sheet)["Sheet"].ToObject<List<List<string>>>()
            };

            Sudoku = JsonConvert.DeserializeObject<SudokuData>(JsonData.Sudoku);
            MaskData = new List<List<SudokuMask>>();
            var initialMasks = JObject.Parse(JsonData.Sheet)["SudokuOrder"].ToObject<List<int>>();
            for (int i = 0; i < 24; i++)
            {
                var sudokuList = new List<SudokuMask>();
                for (int j = 0; j < Sudoku.RawSudoku.Count; j++)
                {
                    sudokuList.Add(new SudokuMask {Enabled = (initialMasks[i]-1) == j, SudokuNumber = j});
                }

                MaskData.Add(sudokuList);
            }

            InitTables();
            UpdateSheetTable();
        }

        public void InitTables()
        {
            foreach (var chr in Sheet.Sheet[0])
            {
                sheetGrid.Columns.Add(new DataGridViewColumn() { Width = 25, CellTemplate = new DataGridViewTextBoxCell() });
            }

            for (int i = 0; i < 9; i++)
            {
                sudokuPreviewGrid.Columns.Add(new DataGridViewColumn() { Width = 25, CellTemplate = new DataGridViewTextBoxCell() });
            }
        }

        public void UpdateSheetTable()
        {
            foreach (var line in Sheet.Sheet)
            {
                sheetGrid.Rows.Add(line.ToArray());
            }
        }

        public void UpdatePreviewTable(int sudokuNumber)
        {
            sudokuPreviewGrid.Rows.Clear();
            foreach (var line in Sudoku.SolvedSudoku[sudokuNumber])
            {
                sudokuPreviewGrid.Rows.Add(line.Select(t=>t.ToString()).ToArray());
            }
        }

        private void sheetGrid_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            e.Paint(e.CellBounds, DataGridViewPaintParts.All & ~DataGridViewPaintParts.Border);

            using (var p1 = new Pen(Color.Black, 4))
            using (var p2 = new Pen(Color.Gray, 2))
            using (var p3 = new Pen(Color.Transparent, 1))
            using (var p4= new Pen(Color.Green, 5))
            {
                var b = e.CellBounds;
                            
                if (IsMasked(e.ColumnIndex, e.RowIndex))
                {
                    using (var brush = new SolidBrush(Color.Black))
                    {
                        e.Graphics.FillRectangle(brush, e.CellBounds);
                    }
                }
                e.Graphics.DrawLine((e.ColumnIndex % 9 == 0 ? p1 : (e.ColumnIndex % 3 == 0 ? p2 : p3)), b.Left,
                        b.Bottom, b.Left, b.Top);
                e.Graphics.DrawLine((e.ColumnIndex % 9 == 8 ? p1 : (e.ColumnIndex % 3 == 2 ? p2 : p3)), b.Right,
                        b.Bottom, b.Right, b.Top);
                e.Graphics.DrawLine((e.RowIndex % 9 == 0 ? p1 : (e.RowIndex % 3 == 0 ? p2 : p3)), b.Left, b.Top,
                        b.Right, b.Top);
                e.Graphics.DrawLine((e.RowIndex % 9 == 8 ? p1 : (e.RowIndex % 3 == 2 ? p2 : p3)), b.Left, b.Bottom,
                        b.Right, b.Bottom);
                if ((e.ColumnIndex == sheetGrid.ColumnCount - 1) && (e.RowIndex == sheetGrid.RowCount - 1))
                {
                    var height = e.CellBounds.Height;
                    var width = e.CellBounds.Width;
                    var originX = e.CellBounds.X - width * e.ColumnIndex;
                    var originY = e.CellBounds.Y - height * e.RowIndex;
                    e.Graphics.DrawRectangle(p4, originX + ((SelectedX/9) * 9) * width, originY + ((SelectedY/9)*9) * height,
                        9 * width, 9 * height);
                }
                
                e.Handled = true;
            }
        }

        private bool IsMasked(int x, int y)
        {
            var sudokuNum = (y / 9) * 6 + x / 9;
            x = x % 9;
            y = y % 9;
            return IsMasked(sudokuNum, x, y);
        }

        private bool IsMasked(int sudokuNum, int x, int y)
        {
            var masked = false;
            foreach (var mask in MaskData[sudokuNum].Where(t => t.Enabled))
            {
                masked = masked || ((Sudoku.RawSudoku[mask.SudokuNumber][y][x] != 0) ^ mask.Inverse);
            }

            return masked;
        }

        private bool IsOGMasked(int sudokuNum, int x, int y, bool inverse)
        {
            return ((Sudoku.RawSudoku[sudokuNum][y][x] != 0) ^ inverse);
        }

        private void sheetGrid_SelectionChanged(object sender, EventArgs e)
        {
            if (SelectionChanging)
            {
                return;
            }
            var la = sheetGrid.SelectedCells[0];
            var squareX = la.ColumnIndex / 9;
            var squareY = la.RowIndex / 9;
            SelectedX = la.ColumnIndex;
            SelectedY = la.RowIndex;
            SelectionChanging = true;
            for (int i = 0; i < sheetGrid.ColumnCount; i++)
            {
                for (int j = 0; j < sheetGrid.RowCount; j++)
                {
                    sheetGrid[i, j].Selected = false;
                }

            }
            //for (int i = squareX * 9; i < squareX * 9 + 9; i++)
            //{
            //    for (int j = squareY * 9; j < squareY * 9 + 9; j++)
            //    {
            //        sheetGrid[i, j].Selected = true;
            //    }
            //}

            var sudokuNum = squareY * 6 + squareX;
            sudokuMaskBindingSource.DataSource = MaskData[sudokuNum];
            maskGrid.Invalidate();
            sheetGrid.Invalidate();
            SelectionChanging = false;
        }

        private void maskGrid_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            sheetGrid.Invalidate();
            if (maskGrid.SelectedRows.Count > 0)
            {
                var sudokuNum = (int)maskGrid.SelectedRows[0].Cells[1].Value;
                UpdatePreviewTable(sudokuNum);
            }
        }

        private void maskGrid_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            maskGrid.EndEdit();
        }

        private void maskGrid_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            foreach (DataGridViewRow row in maskGrid.Rows)
            {
                if ((bool)row.Cells[0].Value)
                {
                    row.Cells[0].Style.BackColor = Color.Green;
                    row.Cells[0].Style.SelectionBackColor = Color.Green;
                }
                else
                {
                    row.Cells[0].Style.BackColor = Color.White;
                    row.Cells[0].Style.SelectionBackColor = Color.Empty;
                }
            }
        }

        private void maskGrid_SelectionChanged(object sender, EventArgs e)
        {
            if (maskGrid.SelectedRows.Count > 0)
            {
                var sudokuNum = (int)maskGrid.SelectedRows[0].Cells[1].Value;
                UpdatePreviewTable(sudokuNum);
            }
        }

        private void sudokuPreviewGrid_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            e.Paint(e.CellBounds, DataGridViewPaintParts.All & ~DataGridViewPaintParts.Border);

            using (var p1 = new Pen(Color.Black, 4))
            using (var p2 = new Pen(Color.Gray, 2))
            using (var p3 = new Pen(Color.Transparent, 1))
            using (var p4 = new Pen(Color.Green, 5))
            {
                var b = e.CellBounds;

                if (IsOGMasked((int)maskGrid.SelectedRows[0].Cells[1].Value, e.ColumnIndex, e.RowIndex, (bool)maskGrid.SelectedRows[0].Cells[2].Value))
                {
                    sudokuPreviewGrid[e.ColumnIndex, e.RowIndex].Style.BackColor = Color.Green;
                }
                else
                {
                    sudokuPreviewGrid[e.ColumnIndex, e.RowIndex].Style.BackColor = Color.White;
                }
                e.Paint(e.CellBounds, DataGridViewPaintParts.ContentBackground);

                e.Graphics.DrawLine((e.ColumnIndex % 9 == 0 ? p1 : (e.ColumnIndex % 3 == 0 ? p2 : p3)), b.Left,
                    b.Bottom, b.Left, b.Top);
                e.Graphics.DrawLine((e.ColumnIndex % 9 == 8 ? p1 : (e.ColumnIndex % 3 == 2 ? p2 : p3)), b.Right,
                    b.Bottom, b.Right, b.Top);
                e.Graphics.DrawLine((e.RowIndex % 9 == 0 ? p1 : (e.RowIndex % 3 == 0 ? p2 : p3)), b.Left, b.Top,
                    b.Right, b.Top);
                e.Graphics.DrawLine((e.RowIndex % 9 == 8 ? p1 : (e.RowIndex % 3 == 2 ? p2 : p3)), b.Left, b.Bottom,
                    b.Right, b.Bottom);

                e.Handled = true;
            }
        }

        private void sudokuPreviewGrid_SelectionChanged(object sender, EventArgs e)
        {
            if (sudokuPreviewGrid.SelectedCells.Count > 0)
            {
                foreach (DataGridViewTextBoxCell cell in sudokuPreviewGrid.SelectedCells)
                {
                    sudokuPreviewGrid[cell.ColumnIndex, cell.RowIndex].Selected = false;
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            MaskData  = new List<List<SudokuMask>>();
            foreach (DataGridViewCell cell in maskGrid.SelectedCells)
            {
                cell.Selected = false;
            }
            for (int i = 0; i < 24; i++)
            {
                var sudokuList = new List<SudokuMask>();
                for (int j = 0; j < Sudoku.RawSudoku.Count; j++)
                {
                    sudokuList.Add(new SudokuMask { SudokuNumber = j });
                }

                MaskData.Add(sudokuList);
            }

            var sudokuNum = (SelectedY/9)*6+SelectedX;
            sudokuMaskBindingSource.DataSource = MaskData[sudokuNum];
            maskGrid.Invalidate();
            sheetGrid.Invalidate();
        }

        private void btnDefault_Click(object sender, EventArgs e)
        {
            MaskData = new List<List<SudokuMask>>();
            var initialMasks = JObject.Parse(JsonData.Sheet)["SudokuOrder"].ToObject<List<int>>();
            for (int i = 0; i < 24; i++)
            {
                var sudokuList = new List<SudokuMask>();
                for (int j = 0; j < Sudoku.RawSudoku.Count; j++)
                {
                    sudokuList.Add(new SudokuMask { Enabled = (initialMasks[i] - 1) == j, SudokuNumber = j });
                }

                MaskData.Add(sudokuList);
            }

            var sudokuNum = (SelectedY / 9) * 6 + SelectedX;
            sudokuMaskBindingSource.DataSource = MaskData[sudokuNum];
            maskGrid.Invalidate();
            sheetGrid.Invalidate();
        }
    }
}
