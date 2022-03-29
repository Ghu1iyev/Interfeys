using System;
using System.Collections.Generic;
using System.Text;

namespace Homework1
{
    internal class MainPrintFiles
    {
        public string Word { get; set; }
        public string Excel { get; set; }
        public string Pdf { get; set; }

        public MainPrintFiles(Word word, Excel excel,Pdf pdf)
        {
            Word = word.Print();
            Excel = excel.Print();
            Pdf = pdf.Print();
        }
    }
}
