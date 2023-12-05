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
            }
            if (enemy.GetAlive())
            {
                EnemyTurn();
            }
        }
        
        if(player.GetAlive() == false) Player.Dead();
        
        if(enemy.GetAlive() == false)
        {
            enemy.Dead();
            return;
        }

    }


    void PlayerTurn()
    {
        
        player.playerTurn = true;
        while(player.playerTurn == true)
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

    //Prints the stats of all entitys
    void printAllStats(Player player, Enemy enemy)
    {
        Console.Clear();
        //Writes player stats
        Console.ForegroundColor = ConsoleColor.White;
        Console.Write($"[{player.name}] ");
        Console.ForegroundColor = ConsoleColor.Red;
        Console.Write($"{tH.DisplayHpOrMana(player.Hp, player.maxHealth)} ");
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine($"{tH.DisplayHpOrMana(player.Mana, player.maxMana)}");
        Console.ForegroundColor = ConsoleColor.White;
        
        Console.Write("Potions: ");
        Console.ForegroundColor = ConsoleColor.Red;
        Console.Write($"{player.healthPotions} ");
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine($"{player.manaPotions}");
        //Writes enemy stats
        Console.ForegroundColor = ConsoleColor.DarkRed;
        Console.Write($"\n[{enemy.name}] ");
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine($"[{enemy.printAffiliation}]");
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine(tH.DisplayHpOrMana(enemy.Hp, enemy.maxHealth));
    }
}