using System;
using System.IO;
using System.Collections.Generic;

namespace CodingAssesment
{
    /**
     * Writes a list of names to sorted-names-list and to console.
     */
    public class NamesExporter {
        public static void exportNames(List<Person> people) {
            try {
                // Write to sorted-names-list.txt in the working directory
                using (System.IO.StreamWriter file = new StreamWriter("D:\\sorted-names-list.txt")) {
                    foreach (Person person in people) {
                        file.WriteLine(person);
                    }
                }
            } catch (IOException) {
            }
        }
    }
}