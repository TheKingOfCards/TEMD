public class TextHandler
{
    public void SpellSelectTH(Spell spell1, Spell spell2, Spell spell3)
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


    public void PlayerInventoryTH(int xp, int level, int levelUpPoint, int coins, string weapon, List<Spell> spells)
    {
        Console.WriteLine($"Level: {level}");
        Console.WriteLine($"Xp: {xp}/{levelUpPoint}");
        Console.Write($"Coins:");
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine(coins);
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine($"\nWeapon: {weapon}");
        Console.WriteLine("\nSpells:");
        Console.WriteLine("[You can't change spells during combat]");
        for (int i = 1; i < 4; i++)
        {
            Console.ForegroundColor = spells[i].color;
            Console.Write($"\n{spells[i].name}");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine($"\n{spells[i].description}");
        }

    }


    public string DisplayHpOrMana(int currentHp, int maxHp)
    {
        string hpDisplay = "[";
        

        for (int i = 0; i < maxHp; i++)
        {
            if(i <= currentHp)
            {
                hpDisplay += "|";
            }
            else
            {
                hpDisplay += " ";
            }
        }

        hpDisplay += "]";

        return hpDisplay;
    }
}