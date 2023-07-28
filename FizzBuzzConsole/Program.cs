using System.Reflection;

// Gets the type handle of the FizzBuzz class
// Then gets the method info of the PlayFizzBuzz method using that type handle
// Creates an instance of FizzBuzz
// Then uses the mthod info to invoke the method using the FizzBuzz object created earlier
// The paramters of method.Invoke are the object and an object[] of all the paramters to the method
// TODO: create the instance of FizzBuzz using reflection

Type fizzBuzzType = typeof(FizzBuzz.FizzBuzz);
MethodInfo? method = fizzBuzzType.GetMethod("PlayFizzBuzz");
if (method != null)
{
    FizzBuzz.FizzBuzz fizzBuzz = new();
    Console.WriteLine(method.Invoke(fizzBuzz, new[] { Enumerable.Range(1, 100).ToArray() }));
}