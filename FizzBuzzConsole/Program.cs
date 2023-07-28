using System.Reflection;


Type fizzBuzzType = typeof(FizzBuzz.FizzBuzz);
MethodInfo method = fizzBuzzType.GetMethod("PlayFizzBuzz");
FizzBuzz.FizzBuzz fizzBuzz = new();
Console.WriteLine(method.Invoke(fizzBuzz, new[] { Enumerable.Range(1, 100).ToArray() }));