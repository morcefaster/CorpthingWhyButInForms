namespace CorpthingWhyButInForms
{
    partial class CorpthingWhy
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.sheetGrid = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.sudokuPreviewGrid = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnDefault = new System.Windows.Forms.Button();
            this.maskGrid = new System.Windows.Forms.DataGridView();
            this.Inverse = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.enabledDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.sudokuNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sudokuMaskBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sheetGrid)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sudokuPreviewGrid)).BeginInit();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.maskGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sudokuMaskBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 240F));
            this.tableLayoutPanel1.Controls.Add(this.sheetGrid, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1684, 882);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // sheetGrid
            // 
            this.sheetGrid.AllowUserToAddRows = false;
            this.sheetGrid.AllowUserToDeleteRows = false;
            this.sheetGrid.AllowUserToResizeColumns = false;
            this.sheetGrid.AllowUserToResizeRows = false;
            this.sheetGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.sheetGrid.ColumnHeadersVisible = false;
            this.sheetGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sheetGrid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.sheetGrid.Location = new System.Drawing.Point(3, 3);
            this.sheetGrid.Name = "sheetGrid";
            this.sheetGrid.ReadOnly = true;
            this.sheetGrid.RowHeadersVisible = false;
            this.sheetGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.sheetGrid.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.sheetGrid.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.sheetGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.sheetGrid.ShowEditingIcon = false;
            this.sheetGrid.ShowRowErrors = false;
            this.sheetGrid.Size = new System.Drawing.Size(1438, 876);
            this.sheetGrid.TabIndex = 0;
            this.sheetGrid.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.sheetGrid_CellPainting);
            this.sheetGrid.SelectionChanged += new System.EventHandler(this.sheetGrid_SelectionChanged);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.sudokuPreviewGrid, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.maskGrid, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(1447, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 208F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(234, 876);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // sudokuPreviewGrid
            // 
            this.sudokuPreviewGrid.AllowUserToAddRows = false;
            this.sudokuPreviewGrid.AllowUserToDeleteRows = false;
            this.sudokuPreviewGrid.AllowUserToResizeColumns = false;
            this.sudokuPreviewGrid.AllowUserToResizeRows = false;
            this.sudokuPreviewGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.sudokuPreviewGrid.ColumnHeadersVisible = false;
            this.sudokuPreviewGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sudokuPreviewGrid.Location = new System.Drawing.Point(3, 3);
            this.sudokuPreviewGrid.Name = "sudokuPreviewGrid";
            this.sudokuPreviewGrid.ReadOnly = true;
            this.sudokuPreviewGrid.RowHeadersVisible = false;
            this.sudokuPreviewGrid.Size = new System.Drawing.Size(228, 202);
            this.sudokuPreviewGrid.TabIndex = 0;
            this.sudokuPreviewGrid.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.sudokuPreviewGrid_CellPainting);
            this.sudokuPreviewGrid.SelectionChanged += new System.EventHandler(this.sudokuPreviewGrid_SelectionChanged);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.btnClear, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.btnDefault, 1, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 839);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(228, 34);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // btnClear
            // 
            this.btnClear.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnClear.Location = new System.Drawing.Point(3, 3);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(108, 28);
            this.btnClear.TabIndex = 0;
            this.btnClear.Text = "Clear masks";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnDefault
            // 
            this.btnDefault.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDefault.Location = new System.Drawing.Point(117, 3);
            this.btnDefault.Name = "btnDefault";
            this.btnDefault.Size = new System.Drawing.Size(108, 28);
            this.btnDefault.TabIndex = 1;
            this.btnDefault.Text = "Reset to default";
            this.btnDefault.UseVisualStyleBackColor = true;
            this.btnDefault.Click += new System.EventHandler(this.btnDefault_Click);
            // 
            // maskGrid
            // 
            this.maskGrid.AllowUserToAddRows = false;
            this.maskGrid.AllowUserToDeleteRows = false;
            this.maskGrid.AllowUserToResizeColumns = false;
            this.maskGrid.AllowUserToResizeRows = false;
            this.maskGrid.AutoGenerateColumns = false;
            this.maskGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.maskGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.enabledDataGridViewCheckBoxColumn,
            this.sudokuNumberDataGridViewTextBoxColumn,
            this.Inverse});
            this.maskGrid.DataSource = this.sudokuMaskBindingSource;
            this.maskGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.maskGrid.Location = new System.Drawing.Point(3, 211);
            this.maskGrid.Name = "maskGrid";
            this.maskGrid.RowHeadersVisible = false;
            this.maskGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.maskGrid.Size = new System.Drawing.Size(228, 622);
            this.maskGrid.TabIndex = 2;
            this.maskGrid.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.maskGrid_CellFormatting);
            this.maskGrid.CellMouseUp += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.maskGrid_CellMouseUp);
            this.maskGrid.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.maskGrid_CellValueChanged);
            this.maskGrid.SelectionChanged += new System.EventHandler(this.maskGrid_SelectionChanged);
            // 
            // Inverse
            // 
            this.Inverse.DataPropertyName = "Inverse";
            this.Inverse.HeaderText = "Inverse";
            this.Inverse.Name = "Inverse";
            this.Inverse.Width = 60;
            // 
            // enabledDataGridViewCheckBoxColumn
            // 
            this.enabledDataGridViewCheckBoxColumn.DataPropertyName = "Enabled";
            this.enabledDataGridViewCheckBoxColumn.HeaderText = "Enabled";
            this.enabledDataGridViewCheckBoxColumn.Name = "enabledDataGridViewCheckBoxColumn";
            this.enabledDataGridViewCheckBoxColumn.Width = 60;
            // 
            // sudokuNumberDataGridViewTextBoxColumn
            // 
            this.sudokuNumberDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.sudokuNumberDataGridViewTextBoxColumn.DataPropertyName = "SudokuNumber";
            this.sudokuNumberDataGridViewTextBoxColumn.HeaderText = "SudokuNumber";
            this.sudokuNumberDataGridViewTextBoxColumn.Name = "sudokuNumberDataGridViewTextBoxColumn";
            this.sudokuNumberDataGridViewTextBoxColumn.ReadOnly = true;
            this.sudokuNumberDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.sudokuNumberDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // sudokuMaskBindingSource
            // 
            this.sudokuMaskBindingSource.DataSource = typeof(CorpthingWhyButInForms.SudokuMask);
            // 
            // CorpthingWhy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1684, 882);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MaximumSize = new System.Drawing.Size(1700, 920);
            this.MinimumSize = new System.Drawing.Size(1700, 920);
            this.Name = "CorpthingWhy";
            this.Text = "CorpthingWhy";
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.sheetGrid)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.sudokuPreviewGrid)).EndInit();
            this.tableLayoutPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.maskGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sudokuMaskBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView sheetGrid;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.DataGridView sudokuPreviewGrid;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnDefault;
        private System.Windows.Forms.DataGridView maskGrid;
        private System.Windows.Forms.BindingSource sudokuMaskBindingSource;
        private System.Windows.Forms.DataGridViewCheckBoxColumn enabledDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sudokuNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Inverse;
    }
}

