using FizzBuzzz.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace FizzBuzzz.Services
{
    public class Separator : ISeparator
    {
        public char CommaSeparator()
        {
            return ',';
        }
    }
}
