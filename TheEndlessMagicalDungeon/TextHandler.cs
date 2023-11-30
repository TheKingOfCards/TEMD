public class TextHandler
{
    public void SpellSelect(Spell spell1, Spell spell2, Spell spell3)
    {
        Console.ForegroundColor = spell1.color;
        Console.Write($"1. {spell1.name} ");
        Console.Write($"[{spell1.manaCost}]");

        Console.ForegroundColor = spell2.color;
        Console.Write($"\n2. {spell2.name} ");
        Console.Write($"[{spell2.manaCost}]");

        Console.ForegroundColor = spell3.color;
        Console.Write($"\n3. {spell3.name} ");
        Console.Write($"[{spell3.manaCost}]");

        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("\n4. Go Back");
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