using System;
using System.IO;
using System.Collections.Generic;

namespace CodingAssesment
{
    /**
     * Reads the names in a specified file and supplies them
     * as a list of Persons.
     */
    public class NamesImporter {
        public static List<Person> importNames(string[] TheName) {
         
            // Parse the full names into people
            var people = new List<Person> { };
            for (int i = 0; i < TheName.Length; ++i) {
                var name = TheName[i];
                // If the current name is simply a trailing whitespace at the end of the file, disregard
                if (name.Trim() == "" && i == TheName.Length - 1) {
                    break;
                }
                // Split the string into first and last names at the last space character
                int lastSpace = name.LastIndexOf(' ');
              
                var firstNames = name.Substring(0, lastSpace);
                var lastName = name.Substring(lastSpace + 1);

                people.Add(new Person(firstNames, lastName));
            }
            return people;
        }
    }
}
