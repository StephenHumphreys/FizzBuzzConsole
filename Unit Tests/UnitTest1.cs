

namespace Unit_Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void CheckFizz()
        {
            FizzBuzz.FizzBuzz fizzBuzz = new();
            string res = fizzBuzz.PlayFizzBuzz(Enumerable.Range(3, 1).ToArray());
            Assert.IsTrue(string.Compare(res,"FIZZ\n",true)==0);
        }

        [TestMethod]
        public void CheckBuzz() 
        {
            FizzBuzz.FizzBuzz fizzBuzz = new();
            string res = fizzBuzz.PlayFizzBuzz(Enumerable.Range(5, 1).ToArray());
            Assert.IsTrue(string.Compare(res, "BUZZ\n", true) == 0);

        }

        [TestMethod]
        public void CheckFizzBuzz() 
        {
            FizzBuzz.FizzBuzz fizzBuzz = new();
            string res = fizzBuzz.PlayFizzBuzz(Enumerable.Range(15, 1).ToArray());
            Assert.IsTrue(string.Compare(res, "FIZZBUZZ\n", true) == 0);
        }


        [TestMethod]
        public void CheckNormal() 
        {
            FizzBuzz.FizzBuzz fizzBuzz = new();
            string res = fizzBuzz.PlayFizzBuzz(Enumerable.Range(23, 1).ToArray());
            Assert.IsTrue(string.Compare(res, "23\n", true) == 0);
        }

        [TestMethod]
        public void CheckNumberOfResults() 
        {
            FizzBuzz.FizzBuzz fizzBuzz = new();
            string res = fizzBuzz.PlayFizzBuzz(Enumerable.Range(1, 100).ToArray());
            Assert.IsTrue(res.Split("\n").Length == 101);
        }
    }
}