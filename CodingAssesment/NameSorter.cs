using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CodingAssesment
{
    public class NameSorter
    {
        public void DoTheSort(string[] TheList)
        {
            if (TheList.Length == 0)
            {
                return;
            }
            var unsorted = NamesImporter.importNames(TheList);
            var sorted = Sorter.sort(unsorted);
            NamesExporter.exportNames(sorted);
        }
    }
}