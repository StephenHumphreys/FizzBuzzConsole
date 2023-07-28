

namespace Unit_Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void CheckFizz()
        {
            FizzBuzz.FizzBuzz fizzBuzz = new();
            List<string> res = fizzBuzz.PlayFizzBuzz(Enumerable.Range(3, 1).ToArray());
            Assert.AreEqual(1,res.Count());
            Assert.IsTrue(string.Compare(res[0],"FIZZ",true)==0);
        }

        [TestMethod]
        public void CheckBuzz() 
        {
            FizzBuzz.FizzBuzz fizzBuzz = new();
            List<string> res = fizzBuzz.PlayFizzBuzz(Enumerable.Range(5, 1).ToArray());
            Assert.AreEqual(1, res.Count()); 
            Assert.IsTrue(string.Compare(res[0], "BUZZ", true) == 0);

        }

        [TestMethod]
        public void CheckFizzBuzz() 
        {
            FizzBuzz.FizzBuzz fizzBuzz = new();
            List<string> res = fizzBuzz.PlayFizzBuzz(Enumerable.Range(15, 1).ToArray());
            Assert.AreEqual(1, res.Count());
            Assert.IsTrue(string.Compare(res[0], "FIZZBUZZ", true) == 0);
        }


        [TestMethod]
        public void CheckNormal() 
        {
            FizzBuzz.FizzBuzz fizzBuzz = new();
            List<string> res = fizzBuzz.PlayFizzBuzz(Enumerable.Range(23, 1).ToArray());
            Assert.AreEqual(1, res.Count());
            Assert.IsTrue(string.Compare(res[0], "23", true) == 0);
        }

        [TestMethod]
        public void CheckNumberOfResults() 
        {
            FizzBuzz.FizzBuzz fizzBuzz = new();
            List<string> res = fizzBuzz.PlayFizzBuzz(Enumerable.Range(1, 100).ToArray());
            Assert.AreEqual(100, res.Count());
        }
    }
}