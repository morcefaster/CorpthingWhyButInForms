using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorpthingWhyButInForms
{
    public class SudokuData
    {
        public List<List<List<int>>> SolvedSudoku { get; set; }
        public List<List<List<int>>> RawSudoku { get; set; }
    }
}
