using FizzBuzzz.Interfaces;

namespace FizzBuzzz.Services
{
    public class FizzBuzzFlow : IFizzBuzzFlow
    {
        private readonly IFizzBuzzCalculator fizzBuzzCalculator;
        private readonly ISeparator iSeparator;

        public FizzBuzzFlow(IFizzBuzzCalculator fizzBuzzCalculator, ISeparator iSeparator)
        {
            this.fizzBuzzCalculator = fizzBuzzCalculator;
            this.iSeparator = iSeparator;
        }

        public string CalculateFizzBuzz(int input)
        {
           string fizzBuzz = "";

           for(var i = 1; i <= input; i++)
           {
                fizzBuzz += fizzBuzzCalculator.Calcuate(i);

                if (input != i)
                {
                    fizzBuzz += iSeparator.CommaSeparator().ToString();
                }                
           }

            return fizzBuzz;
        }
    }
}
