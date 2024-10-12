Console.WriteLine("Enter character name");
string name = Console.ReadLine();

Console.WriteLine("Enter strength:");
string strengthStr = Console.ReadLine();
int strength = Convert.ToInt32(strengthStr);

Console.WriteLine("Enter agility:");
string agilityStr = Console.ReadLine();
int agility = Convert.ToInt32(agilityStr);

Console.WriteLine("Enter intelligence:");
string intelligenceStr = Console.ReadLine();
int intelligence = Convert.ToInt32(intelligenceStr);

int total = strength + agility + intelligence;

if ((strength > 0) && (agility > 0)
        && (intelligence > 0) && (total == 10))
{
    Console.WriteLine("Character Created!");
    Console.WriteLine("Name: " + name);
    Console.WriteLine("Strength: " + strength);
    Console.WriteLine("Agility:" + agility);
    Console.WriteLine("Intelligence: " + intelligence);
}
else
    Console.WriteLine("Problem while creating character!");