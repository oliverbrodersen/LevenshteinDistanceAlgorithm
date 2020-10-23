using System;
using System.Collections.Generic;
using System.Linq;

namespace LevenshteinDistanceAlgorithm
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> lstStringsToCheck = new List<string>
                                            {
                                                "Milk",
                                                "Mask",
                                                "Banana",
                                                "Bass",
                                                "Mouse",
                                                "Silk",
                                                "Silana"
                                            };

            while (true)
            {
                Console.WriteLine("Search:");
                string term = Console.ReadLine();
                Console.WriteLine("Did you mean: " + closestMatch(term) + "?");
            }

            string closestMatch(string baseString)
            {
                Dictionary<string, int> resultset = new Dictionary<string, int>();
                foreach (string stringtoTest in lstStringsToCheck)
                {
                    resultset.Add(stringtoTest, LevenshteinDistance.Compute(baseString, stringtoTest));
                }
                //get the minimum number of modifications needed to arrive at the basestring
                int minimumModifications = resultset.Min(c => c.Value);

                //returns key where value is equal to minimun changes
                return resultset.FirstOrDefault(x => x.Value == minimumModifications).Key;
            }
        }

        
    }
}
