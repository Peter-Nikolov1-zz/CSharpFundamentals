using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace _06_Methods
{
    [TestClass]
    public class MethodExamples
    {
        [TestMethod]
        public void MethodExecution()
        {
            SayHello("Peter");
            int methodReturn = AddTwoNumbers(1, 2);
            Console.WriteLine(methodReturn);

            double methodDouble = 3.95;
            int methodReturnTwo = AddTwoNumbers(methodReturn, methodDouble);
            Console.WriteLine(methodReturnTwo);
        }

        //1) Access Modifier - Public or Private
        //2) Return Type - Void
        //3) Method Signature
            //Name
            //Parameters
        [TestMethod]
        public void SayHello(string name)
        {
            Console.WriteLine($"Hello World! And Hello {name}!"); //<-- Interpolated
        }

        [TestMethod]
        public int AddTwoNumbers(int numOne, int numTwo)
        {
            int sum = numOne + numTwo;
            return sum;
        }

        [TestMethod]
        public double AddTwoNumbers(double numOne, double numTwo)
        {
            double sum = numOne + numTwo;
            return sum; 
        }

        [TestMethod]
        public int CalculateAge(DateTime birthday)
        {
            TimeSpan ageSpan = DateTime.Now - birthday
                double totalAgeInYears = ageSpan.TotalDays / 365.25;
            //double floorValue = Math.Floor(totalAgeInYEars);
            int years = Convert.ToInt32(Math.FloortotalAgeInYears));
        }
    }
}
