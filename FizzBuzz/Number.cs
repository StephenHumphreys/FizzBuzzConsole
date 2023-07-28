namespace FizzBuzz
{
    public abstract class Number
    {
        public string message;

        public Number(string message) {
            this.message = message;
        }


        public abstract bool MeetsCritera(int number);

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