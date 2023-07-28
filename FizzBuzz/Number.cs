namespace FizzBuzz
{
    public class Number
    {
        private int mod;
        private string message;

        public Number(int mod, string message) {
            this.mod = mod;
            this.message = message;
        }

        public bool MeetsCritera(int number)
        {
            if (number % mod == 0)
            {
                return true;
            }
            return false;
        }

        public string MessageForNumber(int number)
        {
            if (MeetsCritera(number))
            {
                return message;
            }
            return "";
        }
    }
}