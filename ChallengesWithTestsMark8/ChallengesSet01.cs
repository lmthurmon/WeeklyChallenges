using System;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet01
    {
        public bool AreTwoNumbersTheSame(int num1, int num2)
        {

            if (num1 == num2)
            { return true; }
            else
            {return false; }
        }

        public double Subtract(double minuend, double subtrahend)
        {
            var getSubstract = minuend - subtrahend;

            return getSubstract;

        }

        public int Add(int number1, int number2)
        {
            var addition = number1 + number2;
            return addition;
            
        }

        public int GetSmallestNumber(int number1, int number2)
        {
            if (number1 < number2)
            { return number1; }
            else
            { return number2; }
            
        }

        public long Multiply(long factor1, long factor2)
        {
            var mult = factor1 * factor2;
            return mult;
            
        }

        public string GetGreeting(string nameOfPerson)
        {
            return "Landon";
           // throw new NotImplementedException(); 
        }

        public string GetHey()
        {
            throw new NotImplementedException();
        }
    }
}
