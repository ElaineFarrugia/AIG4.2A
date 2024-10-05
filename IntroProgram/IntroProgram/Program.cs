//create integer variable
int generatedNumber;

//prepare the random number generator
Random generator = new Random();

//generate random no. 1-10 and save it in variable
generatedNumber = generator.Next(1, 11);

//output
//Console.WriteLine(generatedNumber);
Console.WriteLine("Enter a number 1-10");

//get user input
string input = Console.ReadLine();

//convert input to integer
int inputInt = Convert.ToInt32(input);

//if statement (either or)
if (inputInt == generatedNumber)
    Console.WriteLine("You guessed!");
else
    Console.WriteLine("You did not guess! The number was: "+generatedNumber);



