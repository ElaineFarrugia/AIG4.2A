
Console.WriteLine("Till what number do you want to count?");
string inputStr = Console.ReadLine();
int input = Convert.ToInt32(inputStr);

for (int i = 1; i <= input; i++)
{
    Console.WriteLine("Hello "+i);
}

for (int i = 10; i >= 0; i--)
{
    Console.WriteLine(i);
    Thread.Sleep(1000);
}

Console.WriteLine("What number do you want the multiplication table for?");
string numStr = Console.ReadLine();
int num = Convert.ToInt32(numStr);

for (int i = 1; i <= 10; i++)
{
    Console.WriteLine(num*i);
}
