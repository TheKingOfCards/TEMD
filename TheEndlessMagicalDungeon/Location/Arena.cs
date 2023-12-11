namespace FightingLogic;

public class Arena
{
    private Player player;
    private Enemy enemy;
    private LocaitonLogic lL;
    TextHandler tH;

    public Arena(Player p)
    {
        tH = new();
        player = p;
    }


    public void Start(Enemy e)
    {
        enemy = e; //Sets the variabel enemy to the new enemy 
        enemy.setPlayer(player);
        player.setEnemy(e);
        Fighting();
    }


    void Fighting()
    {
        while (player.GetAlive() && enemy.GetAlive()) //Checks if both entitys are alive and if its their turn
        {
            if (player.GetAlive())
            {
                PlayerTurn();
                Tick();
            }
            if (enemy.GetAlive())
            {
                EnemyTurn();
                Tick();
            }
        }

        if (player.GetAlive() == false) Player.Dead();

        if (enemy.GetAlive() == false)
        {
            player.Hp = player.maxHealth;
            player.Mana = player.maxMana;
            enemy.Dead();
        }

    }


    void PlayerTurn()
    {

        player.playerTurn = true;
        while (player.playerTurn == true)
        {
            player.playerTurn = false;
            printAllStats(player, enemy);
            player.WriteActionChoices();
            char input = Console.ReadKey().KeyChar;

            printAllStats(player, enemy);
            player.Action(input);
        }
    }


    void EnemyTurn()
    {
        printAllStats(player, enemy);
        enemy.Attack();
    }


    void Tick()
    {
        player.Tick("You");
        enemy.Tick("Enemy");
    }

    //Prints the stats of all entitys
    void printAllStats(Player player, Enemy enemy)
    {
        Console.Clear();

        //Writes player stats
        Console.ForegroundColor = ConsoleColor.White;
        Console.Write($"[{player.name}] ");
        Console.ForegroundColor = ConsoleColor.White;
        Console.Write("Hp: ");
        Console.ForegroundColor = ConsoleColor.Red;
        Console.Write($"{tH.DisplayHpOrMana(player.Hp, player.maxHealth)} ");
        Console.ForegroundColor = ConsoleColor.White;
        Console.Write("Mana: ");
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine($"{tH.DisplayHpOrMana(player.Mana, player.maxMana)}");
        Console.ForegroundColor = ConsoleColor.White;

        //Writes out potions
        Console.Write("Potions: ");
        Console.ForegroundColor = ConsoleColor.Red;
        Console.Write($"{player.healthPotions} ");
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine($"{player.manaPotions}");

        //Writes enemy stats
        Console.ForegroundColor = ConsoleColor.DarkRed;
        Console.Write($"\n[{enemy.name}] ");
        Console.ForegroundColor = GetAffiliaitonColor(enemy);
        Console.WriteLine($"[{enemy.printAffiliation}]");
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine($"{tH.DisplayHpOrMana(enemy.Hp, enemy.maxHealth)}\n");
    }

    ConsoleColor GetAffiliaitonColor(Enemy e)
    {
        ConsoleColor cC = ConsoleColor.White;

        if (e.printAffiliation == "Fire")
        {
            cC = ConsoleColor.Red;
        }
        else if (e.printAffiliation == "Water")
        {
            cC = ConsoleColor.Blue;
        }
        else if (e.printAffiliation == "Earth")
        {
            cC = ConsoleColor.DarkYellow;
        }
        else if (e.printAffiliation == "Air")
        {
            cC = ConsoleColor.White;
        }

        return cC;
    }
}