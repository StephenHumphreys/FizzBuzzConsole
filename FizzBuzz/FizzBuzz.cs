using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    public class FizzBuzz
    {
        public List<string> PlayFizzBuzz(int[] input)
        {
            List<string> fizzBuzzReturnValue = new List<string>();

            FizzClass fizz = new("Fizz");
            BuzzClass buzz = new("Buzz");

            Number[] numbers = new Number[] { fizz, buzz};
            foreach (int numberToCheck in input)
            {
                bool hasMetCritera = numbers.Any(n => n.MeetsCritera(numberToCheck));

                if (!hasMetCritera)
                {
                    fizzBuzzReturnValue.Add(numberToCheck.ToString());
                }
                else
                {
                    string outputToAdd = "";

                    foreach (Number number in numbers)
                    {
                        outputToAdd += number.MessageForNumber(numberToCheck); 
                    }

                    fizzBuzzReturnValue.Add(outputToAdd);
                }
            }

            return fizzBuzzReturnValue;
        }
    }
}
