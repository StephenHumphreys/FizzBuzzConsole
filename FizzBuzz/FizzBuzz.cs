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

            Number fizz = new(3, "Fizz");
            Number buzz = new(5, "Buzz");
            Number overEngineered = new(99, "THIS IS TOO MUCH");
            Number birthday = new(13, "Sammy's Birthday");

            Number[] numbers = new Number[] { fizz, buzz,overEngineered, birthday };
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
