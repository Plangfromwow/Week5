using PrimeNumberLab;

Console.WriteLine("Welcome to the Prime Number Finder!");
Console.WriteLine("We can find any Prime Number between 2 - 300!!");

do
{
    Console.WriteLine("Choose a position to see what Prime Number it is!");
    int entry = int.Parse(Console.ReadLine());
    PrimeNumber magicPrime = new PrimeNumber(entry);

    if (entry < 1 || entry > 35)
    {
        Console.WriteLine("Sorry! That's out of our range.");
        Console.WriteLine();
    }
    else if (entry >= 1 && entry <= 35)
    {
        Console.WriteLine($"The Prime Number {magicPrime.getPrimeNumber()} is in position {entry}!");
    }
}while(GoAgain());


bool GoAgain()
{
    Console.WriteLine("Would you like to see another Prime Number? Y/N");
    string response = Console.ReadLine().ToLower();

    if (response == "y" || response == "yes")
    {
        return true;
    }
    else if (response == "n" || response == "no")
    {
        return false;
    }
    else
    {
        Console.WriteLine("Please put either Y/N");
        return GoAgain();
    }
}