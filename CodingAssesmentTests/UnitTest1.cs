using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using CodingAssesment;

namespace CodingAssesmentTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var theNames = new List<string> {
                "Janet Roi",
                "Vaughn Debugs",
                "Adonis Julius",
                "Shelby Nathan",
                "Marin Johnson",
                "London Ade",
                "Beau Tristan",
                "Leo Goal",
                "Hunter Uriah Mathew",
                "Mikayla Alexander",
                "Frankie Conner"
            };
            var theNamesArr = theNames.ToArray();
            NameSorter S = new NameSorter();
            S.DoTheSort(theNamesArr);
        }
    }
}
