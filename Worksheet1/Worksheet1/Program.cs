string sequence = "w5Gh23pk";

Console.WriteLine("Remember this: "+sequence);
Thread.Sleep(5000);
Console.Clear();

Console.WriteLine("Enter the sequence:");
string input = Console.ReadLine();

if (input == sequence)
    Console.WriteLine("Congrats, you guessed!");
else
    Console.WriteLine("You did not guess");