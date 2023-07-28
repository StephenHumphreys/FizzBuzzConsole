using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    public class MysteryPrize : Number
    {
        DateTime currentDate;
        public MysteryPrize(DateTime currentDate) : base("YOU'VE WON!! PUT MONEY INTO MY BANK ACCOUNT TO RECEIVE A PRIZE!!")
        {
            this.currentDate = currentDate;
        }

        // Special prize for the gullible
        public override bool MeetsCritera(int number)
        {
            // if it's a monday and it's early in the morning
            // i don't mind if it's BST or GMT, it's just early on monday
            // you might send me money

           if (currentDate.DayOfWeek == DayOfWeek.Monday && currentDate.Hour == 9 && number == 97)
            {
                return true;
            }
            return false;
        }

    }
}
