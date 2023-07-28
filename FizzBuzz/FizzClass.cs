using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    internal class FizzClass : Number
    {
        private readonly int mod = 3;

        public FizzClass(string message) : base(message)
        {
        }

        public override bool MeetsCritera(int number)
        {
            if (number % mod == 0)
            {
                return true;
            }
            return false;
        }


    }
}
