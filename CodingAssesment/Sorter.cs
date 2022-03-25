using System;
using System.Collections.Generic;
using System.Linq;

namespace CodingAssesment
{
    /**
      * Takes an unsorted list of people, and outputs a correctly sorted
      * version of that same list.
      */
    public class Sorter {
        public static List<Person> sort(List<Person> unsorted) {
            return unsorted.OrderBy(person => person.lastName)
                                 .ThenBy(person => person.firstNames)
                                 .ToList();
        }
    }
}
