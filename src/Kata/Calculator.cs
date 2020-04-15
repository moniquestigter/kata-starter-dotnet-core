using System;

namespace Kata.Spec
{
    public class Calculator
    {
        public int Add(string number="")
        {
            if(string.IsNullOrEmpty(number))
                return 0;
            

            string[] numbers = number.Split(',');

            int sum = 0;
            foreach (var n in numbers)
            {
                sum += Int32.Parse(n);
            }
            
            return sum;
        }
    }
}