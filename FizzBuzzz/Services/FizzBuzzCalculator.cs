using FizzBuzzz.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace FizzBuzzz.Services
{
    public class FizzBuzzCalculator : IFizzBuzzCalculator
    {
        public string Calcuate(int input)
        {
            if(input % 3 == 0 && input % 5 == 0)
            {
                return "FizzBuzz";
            }
            if(input % 3 == 0)
            {
                return "Fizz";
            }
            if (input % 5 == 0)
            {
                return "Buzz";
            }
              
            return input.ToString();
        }
    }
}
