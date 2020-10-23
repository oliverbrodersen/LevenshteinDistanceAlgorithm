using System;
using System.Collections.Generic;
using System.Linq;

namespace LevenshteinDistanceAlgorithm
{
    class Program
    {
        static void Main(string[] args)
        {
            //https://www.codeproject.com/Questions/419563/Get-the-nearest-Match-of-the-string-in-list-of-str
            
            string baseString = "Bas";
            List<string> lstStringsToCheck = new List<string>
                                            {
                                                "Bas",
                                                "Bass",
                                                "Ebas",
                                                "Basist",
                                                "Byuans",
                                                "sab",
                                                "Another string",
                                                "Baa"
                                            };
            Dictionary<string, int> resultset = new Dictionary<string, int>();
            foreach (string stringtoTest in lstStringsToCheck)
            {
                resultset.Add(stringtoTest, LevenshteinDistance.Compute(baseString, stringtoTest));
            }
            //get the minimum number of modifications needed to arrive at the basestring
            int minimumModifications = resultset.Min(c => c.Value);
            //gives you a list with all strings that need a minimum of modifications to become the
            //same as the baseString
            var closestlist = resultset.Where(c => c.Value == minimumModifications);
            foreach(var s in resultset)
            {
                Console.WriteLine(s);
            }
        }
    }
}
