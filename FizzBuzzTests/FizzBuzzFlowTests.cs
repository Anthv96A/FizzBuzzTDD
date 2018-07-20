using FizzBuzzz.Interfaces;
using FizzBuzzz.Services;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace FizzBuzzTests
{
    [TestClass]
    public class FizzBuzzFlowTests
    {
        [TestMethod]
        public void Given_input_is_one_fizz_buzz_calculator_is_called_once()
        {
            //Given I have the number 1
            int input = 1;
            //And I have a fizzbuzzconverter object
            Mock<IFizzBuzzCalculator> mock = new Mock<IFizzBuzzCalculator>();
            //And I have a seperator Object 
            Mock<ISeparator> separator = new Mock<ISeparator>();
            //When I call fizzbuzzflow.cwlculatefizzbuzz
            IFizzBuzzFlow fizzBuzzFlow = new FizzBuzzFlow(mock.Object, separator.Object);
            fizzBuzzFlow.CalculateFizzBuzz(input);
            //Then I will verify that fizzbuzzconverter object is caalled once
            mock.Verify(m => m.Calcuate(input), Times.Once);
        }

        [TestMethod]
        public void Given_input_is_two_fizz_buzz_calculator_is_called_twice()
        {
            //Given I have the number 2
            int input = 2;
    
            //And I have a fizzbuzzconverter object
            Mock<IFizzBuzzCalculator> mock = new Mock<IFizzBuzzCalculator>();
            //And I have a seperator Object 
            Mock<ISeparator> separator = new Mock<ISeparator>();
            //When I call fizzbuzzflow.cwlculatefizzbuzz
            IFizzBuzzFlow fizzBuzzFlow = new FizzBuzzFlow(mock.Object, separator.Object);
            fizzBuzzFlow.CalculateFizzBuzz(input);
            //Then I will verify that fizzbuzzconverter object is called twice
            mock.Verify(m => m.Calcuate(It.IsAny<int>()), Times.Exactly(2));
        }

        [TestMethod]
        public void Given_input_is_hundred_fizz_buzz_calculator_is_called_hundred_times()
        {
            //Given I have the number 100
            int input = 100;
            //And I have a fizzbuzzconverter object
            Mock<IFizzBuzzCalculator> mock = new Mock<IFizzBuzzCalculator>();
            //And I have a seperator Object 
            Mock<ISeparator> separator = new Mock<ISeparator>();

            //When I call fizzbuzzflow.cwlculatefizzbuzz
            IFizzBuzzFlow fizzBuzzFlow = new FizzBuzzFlow(mock.Object,separator.Object);
            fizzBuzzFlow.CalculateFizzBuzz(input);
            //Then I will verify that fizzbuzzconverter object is called twice
            mock.Verify(m => m.Calcuate(It.IsAny<int>()), Times.Exactly(100));
        }


        [TestMethod]
        public void Given_input_is_one_return_one()
        {
            //Given I have the number 1
            var input = 1;
            //And I have a fizzbuzzconverter object
            Mock<IFizzBuzzCalculator> mock = new Mock<IFizzBuzzCalculator>();
            //And I have a seperator Object 
            Mock<ISeparator> separator = new Mock<ISeparator>();

            mock.Setup(fb => fb.Calcuate(1)).Returns("1");
            //When I call fizzbuzzflow.cwlculatefizzbuzz
            IFizzBuzzFlow fizzBuzzFlow = new FizzBuzzFlow(mock.Object, separator.Object);
            string result = fizzBuzzFlow.CalculateFizzBuzz(input);
            //Then I will get back 1
            Assert.AreEqual("1", result);
        }


        [TestMethod]
        public void Given_input_is_two_return_two()
        {
            //Given I have the number 2
            var input = 2;
            //And I have a fizzbuzzconverter object which returns 1 then 2
            Mock<IFizzBuzzCalculator> mock = new Mock<IFizzBuzzCalculator>();
            //And I have a seperator Object 
            Mock<ISeparator> separator = new Mock<ISeparator>();
            mock.Setup(fb => fb.Calcuate(1)).Returns("1");
            mock.Setup(fb => fb.Calcuate(2)).Returns("2");
            //When I call fizzbuzzflow.cwlculatefizzbuzz
            IFizzBuzzFlow fizzBuzzFlow = new FizzBuzzFlow(mock.Object, separator.Object);
            string result = fizzBuzzFlow.CalculateFizzBuzz(input);
            //Then I will get back 1,2
            Assert.AreEqual("1,2", result);
        }

        [TestMethod]
        public void Given_input_is_three_return_fizz()
        {
            //Given I have the number 3
            var input = 3;
            //And I have a character seperqtor as ,
 
            //And I have a fizzbuzzconverter object which returns 1 then 2 then fizz
            Mock<IFizzBuzzCalculator> mock = new Mock<IFizzBuzzCalculator>();
            //And I have a seperator Object 
            Mock<ISeparator> separator = new Mock<ISeparator>();
            mock.Setup(fb => fb.Calcuate(1)).Returns("1");
            mock.Setup(fb => fb.Calcuate(2)).Returns("2");
            mock.Setup(fb => fb.Calcuate(3)).Returns("fizz");
            //When I call fizzbuzzflow.cwlculatefizzbuzz
            IFizzBuzzFlow fizzBuzzFlow = new FizzBuzzFlow(mock.Object, separator.Object);
            string result = fizzBuzzFlow.CalculateFizzBuzz(input);
            //Then I will get back 1,2
            Assert.AreEqual("1,2,fizz", result);
        }
    }
}
