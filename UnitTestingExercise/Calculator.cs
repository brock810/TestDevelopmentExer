using System;

namespace UnitTestingExercise
{
    public class Calculator
    { 
        public int Add(int num1, int num2, int num3)
        {
            return num1 + num2 + num3;
        }

        public int Subtract(int minuend, int subtrahend)
        {
            return minuend - subtrahend;
        }

        
        public int Multiply(int num1, int num2)
        {
            return num1 * num2;
        }

       
        public int Divide(int dividend, int divisor)
        {
            if (divisor == 0)
            {
                throw new ArgumentException("Divisor cannot be zero.");
            }

            return dividend / divisor;
        }
    }
}