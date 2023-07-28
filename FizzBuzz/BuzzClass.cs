using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    internal class BuzzClass : Number
    {
        private readonly int mod = 5;

        public BuzzClass(string message) : base(message)
        {
        }

        // the meets criteria are essentially the same but we could have something else
        // for our criteria and for our message.
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
