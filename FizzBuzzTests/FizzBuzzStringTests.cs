using System;
using FizzBuzzz.Interfaces;
using FizzBuzzz.Services;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FizzBuzzTests
{
    [TestClass]
    public class FizzBuzzStringTests
    {
        [TestMethod]
        public void GivenInputIsOneReturnOne()
        {
            //given i have the number 1
            int i = 1;

            //when i pass in the number to the fizz buzz converter
            IFizzBuzzCalculator iFizzBuzzCalculator = new FizzBuzzCalculator();
            string result = iFizzBuzzCalculator.Calcuate(i);

            //then i get back 1
            Assert.AreEqual("1", result);
        }


        [TestMethod]
        public void GivenInputIsTwoReturnTwo()
        {
            //given i have the number 2
            int i = 2;

            //when i pass in the number to the fizz buzz converter
            IFizzBuzzCalculator iFizzBuzzCalculator = new FizzBuzzCalculator();
            string result = iFizzBuzzCalculator.Calcuate(i);

            //then i get back 2
            Assert.AreEqual("2", result);
        }


        [TestMethod]
        public void GivenInputIsThreeReturnFizz()
        {
            //given i have the number 3
            int i = 3;
            //when i pass in the number to the fizz buzz converter
            IFizzBuzzCalculator iFizzBuzzCalculator = new FizzBuzzCalculator();
            string result = iFizzBuzzCalculator.Calcuate(i);
            //then i get back fizz
            Assert.AreEqual("Fizz", result);
        }

        [TestMethod]
        public void GivenInputIsFourReturnFour()
        {
            //given i have the number 4
            int i = 4;
            //when i pass in the number to the fizz buzz converter
            IFizzBuzzCalculator iFizzBuzzCalculator = new FizzBuzzCalculator();
            string result = iFizzBuzzCalculator.Calcuate(i);
            //then i get back 4
            Assert.AreEqual("4", result);
        }

        [TestMethod]
        public void GivenInputIsFiveReturnBuzz()
        {
            //given i have the number 5
            int i = 5;
            //when i pass in the number to the fizz buzz converter
            IFizzBuzzCalculator iFizzBuzzCalculator = new FizzBuzzCalculator();
            string result = iFizzBuzzCalculator.Calcuate(i);
            //then i get back buzz
            Assert.AreEqual("Buzz", result);
        }

        [TestMethod]
        public void GivenInputIsSixReturnFizz()
        {
            //given i have the number 6
            int i = 6;
            //when i pass in the number to the fizz buzz converter
            IFizzBuzzCalculator iFizzBuzzCalculator = new FizzBuzzCalculator();
            string result = iFizzBuzzCalculator.Calcuate(i);
            //then i get back fizz
            Assert.AreEqual("Fizz", result);
        }


        [TestMethod]
        public void GivenInputIsSevenReturnSeven()
        {
            //given i have the number 7
            int i = 7;
            //when i pass in the number to the fizz buzz converter
            IFizzBuzzCalculator iFizzBuzzCalculator = new FizzBuzzCalculator();
            string result = iFizzBuzzCalculator.Calcuate(i);
            //then i get back 7
            Assert.AreEqual("7", result);
        }


        [TestMethod]
        public void GivenInputIsNineReturnFizz()
        {
            //given i have the number 9
            int i = 9;
            //when i pass in the number to the fizz buzz converter
            IFizzBuzzCalculator iFizzBuzzCalculator = new FizzBuzzCalculator();
            string result = iFizzBuzzCalculator.Calcuate(i);
            //then i get back fizz
            Assert.AreEqual("Fizz", result);
        }

        [TestMethod]
        public void GivenInputIsTenReturnTen()
        {
            //given i have the number 10
            int i = 10;
            //when i pass in the number to the fizz buzz converter
            IFizzBuzzCalculator iFizzBuzzCalculator = new FizzBuzzCalculator();
            string result = iFizzBuzzCalculator.Calcuate(i);
            //then i get back buzz
            Assert.AreEqual("Buzz", result);
        }


        [TestMethod]
        public void GivenInputIsElevenReturnEleven()
        {
            //given i have the number 11
            int i = 11;
            //when i pass in the number to the fizz buzz converter
            IFizzBuzzCalculator iFizzBuzzCalculator = new FizzBuzzCalculator();
            string result = iFizzBuzzCalculator.Calcuate(i);
            //then i get back 11
            Assert.AreEqual("11", result);
        }


        [TestMethod]
        public void GivenInputIsFifteenReturnFizzBuzz()
        {
            //given i have the number 15
            int i = 15;

            //when i pass in the number to the fizz buzz converter
            IFizzBuzzCalculator iFizzBuzzCalculator = new FizzBuzzCalculator();
            string result = iFizzBuzzCalculator.Calcuate(i);

            //then i get back fizzbuzz
            Assert.AreEqual("FizzBuzz", result);
        }

        [TestMethod]
        public void GivenInputIsSixteenReturnSixteen()
        {
            //given i have the number 16
            int i = 16;
            //when i pass in the number to the fizz buzz converter
            IFizzBuzzCalculator iFizzBuzzCalculator = new FizzBuzzCalculator();
            string result = iFizzBuzzCalculator.Calcuate(i);
            //then i get back 16
            Assert.AreEqual("16", result);
        }


        [TestMethod]
        public void GivenInputIsThirtyReturnFizzBuzz()
        {
            //given i have the number 30
            int i = 30;

            //when i pass in the number to the fizz buzz converter
            IFizzBuzzCalculator iFizzBuzzCalculator = new FizzBuzzCalculator();
            string result = iFizzBuzzCalculator.Calcuate(i);

            //then i get back fizzbuzz
            Assert.AreEqual("FizzBuzz", result);
        }

    }
}
