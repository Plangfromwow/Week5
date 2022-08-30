using CalcApp;

Console.WriteLine("Welcome to the calculator!");

Console.Write("1)Factorial or 2)Factors?: ");
string choice = Console.ReadLine().ToLower();

Console.Write("Great! What number?: ");
int number = int.Parse(Console.ReadLine());

Calculator calc = new Calculator(number);

if (choice == "1")
{
    int factorial = calc.FindFactorial();
    Console.WriteLine($"The factorial of {number} is {factorial}");
}
else if (choice == "2")
{
    Console.WriteLine("Under Construction! Coming soon!");
}