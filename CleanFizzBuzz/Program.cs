// See https://aka.ms/new-console-template for more information

using CleanFizzBuzz.Service;

Console.WriteLine("Fizzbuzz in C#");

var numberGenerator = new NumberGenerator();

numberGenerator
    .GetFizzBuzzNumbers(1, 100)
    .ForEach(r => Console.WriteLine(r));

Console.ReadLine();
return 0;