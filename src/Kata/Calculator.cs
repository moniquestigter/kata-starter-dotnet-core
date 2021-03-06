using System;
using System.Linq;

namespace Kata.Spec
{
    public class Calculator
    {
        public int Add(string number="")
        {
            if(string.IsNullOrEmpty(number))
                return 0;

            string[] numbers;
            if (number.Contains("//"))
            {
                string[] elements = number.Split("\n");
            

                char[] semicolon = elements[0].ToCharArray();
            

                 numbers = elements[1].Split(new []{",","\n",semicolon[2].ToString()},StringSplitOptions.None);
                
            }
            else
            {
                numbers = number.Split(new []{",","\n"},StringSplitOptions.None);
            }

            var negatives = numbers.Where(x => int.Parse(x) < 0);
            if (negatives.Any())
            {
                string msg = "";
                for (int a = 0; a < negatives.Count(); a++)
                {
                    if (a == negatives.Count() - 1)
                    {
                        msg += negatives.ElementAt(a);
                    }
                    else
                    {
                        msg += negatives.ElementAt(a);
                        msg += ", ";
                    }
                }

                throw new Exception($"Negatives not allowed: {msg}");
            }

            int sum = 0;
            foreach (var n in numbers)
            {
                sum += Int32.Parse(n);
            }
            
            return sum;
        }
    }
}