public class TextHandler
{
    public void StartText()
    {
        Console.WriteLine("Welcome to The Endless Magical Dungeon");
        Console.WriteLine("You will be fighting monsters and other people for an eternety or until you die");

        Console.WriteLine("You will be using the numbers buttons to move around in the UI");
        Console.WriteLine("You will be fighting diffrent enemies with increasing stats");
        Console.WriteLine("Spells use mana and you will only be able to carry 3 spells at a time");
        Console.WriteLine("And I won't say much more because you will find out by trying/dying");
        Console.WriteLine("Now you will create your chracter");
    }


    public void SpellSelect(string name, string name1, string name2)
    {
        Console.WriteLine($"1. {name} \n2. {name1} \n 3. {name2} \n 4. Go Back");
    }

    public void PotionSelect()
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.Write("1. Health Potion");
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.Write("\n2. Mana Potion");
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("\n3. Go Back");
    }


    public void ElementInfo()
    {
        Console.WriteLine("Air > WATER > Fire");
        Console.WriteLine("Fire > EARTH > Air");
        Console.WriteLine("Water > FIRE > Earth");
        Console.WriteLine("Earth > AIR > Water");
    }
}