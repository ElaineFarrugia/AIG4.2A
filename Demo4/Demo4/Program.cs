Random generator = new Random();

while (true)
{
    int num = generator.Next(1, 4);

    char computerChoice;

    if (num == 1)
        computerChoice = 'r';
    else if (num == 2)
        computerChoice = 'p';
    else
        computerChoice = 's';

    Console.WriteLine("The computer chose: " + computerChoice);

    Console.WriteLine("Choose rock(r), paper(p) or scissors(s)");
    char userInput = Console.ReadKey().KeyChar;

    if (userInput == computerChoice)
        Console.WriteLine("Tie!");
    else if ((userInput == 's' && computerChoice == 'p') ||
            (userInput == 'p' && computerChoice == 'r') ||
            (userInput == 'r' && computerChoice == 's'))
        Console.WriteLine("You Win!");
    else
        Console.WriteLine("You Lose");

    Console.WriteLine("Would you like to play again? (y/n)");
    char playAgain = Console.ReadKey().KeyChar;

    if (playAgain == 'n')
        break;
    else
        continue;
}