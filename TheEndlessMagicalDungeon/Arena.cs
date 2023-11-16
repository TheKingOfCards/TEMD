using EnemyLogic;
using PlayerLogic;

namespace FightingLogic;

public class Arena
{
    private Player player;
    private Enemy enemy;

    public Arena(Player p)
    {
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
        while (player.GetAlive() && enemy.GetAlive())
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
        if(player.GetAlive() == false)
        {
            Player.Dead();
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
    static void printAllStats(Player player, Enemy enemy)
    {
        Console.Clear();
        //Writes player stats
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine($"[{player.name}] [Hp: {player.Hp}] [Mana: {player.mana}] [{player.printAffiliation}]");
        Console.Write("Potions: ");
        Console.ForegroundColor = ConsoleColor.Red;
        Console.Write($"{player.healthPotions} ");
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine($"{player.manaPotions}");
        //Writes enemy stats
        Console.ForegroundColor = ConsoleColor.DarkRed;
        Console.WriteLine($"Enemy: [{enemy.name}] [Hp: {enemy.Hp}] [{enemy.printAffiliation}]\n ");
    }
}