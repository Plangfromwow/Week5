using PigLatin;
Console.WriteLine("Pig Latin Translator");
Console.WriteLine("Enter a word: ");
string entry = Console.ReadLine().ToLower();

Console.WriteLine(Translator.PigLatinize(entry));