using System;
using System.Collections.Generic;
using System.Linq;

namespace StringForLoop
{
     class Program
    {
        static void Main(string[] args)
        {
            string name = "developer@example.com";
            char[] vowels = new char[] { 'A', 'E', 'I', 'O', 'U', 'a', 'e', 'i', 'o', 'u' };

            int vowelsCount = 0;
            for (int i = 0; i < name.Length; i++)
            {
                bool isMatch = false;
                for (int j = 0; j < vowels.Length; j++)
                    if (name[i] == vowels[j])
                        isMatch = true;

                if (isMatch)
                {
                    vowelsCount++; 
                }
                Console.WriteLine(name[i] + " " + isMatch);
            }
            Console.WriteLine(vowelsCount + " vowels found");

            //Another way for loop
            int vowelsCount2 = 0;
            for (int u = 0; u < name.Length; u++)
            {
                if (Array.IndexOf(vowels, name[u]) != -1)
                {
                    vowelsCount2++;
                }
            }
            Console.WriteLine(vowelsCount2 + " vowels found");

            // same using LINQ
            Console.WriteLine(name.Count(ch=>Array.IndexOf(vowels,ch)>=0));

            Console.ReadKey();
        }
    }
}
