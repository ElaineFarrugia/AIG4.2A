Console.WriteLine("Enter your theory mark.");
string theory = Console.ReadLine();

Console.WriteLine("Enter your practical mark.");
string practical = Console.ReadLine();

int theoryInt = Convert.ToInt32(theory);
int practicalInt = Convert.ToInt32(practical);

if ((theoryInt >= 50) && (practicalInt >= 50))
    Console.WriteLine("You passed!");
else
    Console.WriteLine("You did not pass");

