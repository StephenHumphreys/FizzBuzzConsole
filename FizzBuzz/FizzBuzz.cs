using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    public class FizzBuzz
    {
        public string PlayFizzBuzz(int[] input)
        {
            string fizzBuzzReturnValue = "";

            FizzClass fizz = new("Fizz");
            BuzzClass buzz = new("Buzz");

            Number[] numbers = new Number[] { fizz, buzz};
            foreach (int numberToCheck in input)
            {
                bool hasMetCritera = numbers.Any(n => n.MeetsCritera(numberToCheck));

                if (!hasMetCritera)
                {
                    fizzBuzzReturnValue += numberToCheck.ToString();
                }
                else
                {
                    foreach (Number number in numbers)
                    {
                        fizzBuzzReturnValue += number.MessageForNumber(numberToCheck);
                    }
                }

                fizzBuzzReturnValue += "\n";
            }

            return fizzBuzzReturnValue;
        }
    }
}
