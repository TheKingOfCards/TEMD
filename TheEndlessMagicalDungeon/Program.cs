using PlayerLogic;
using EnemyLogic;
using SpellsLogic;

Console.Title = "The Endeless Magical Dungeon";

Player player = new();
Enemy enemy = new TankEnemy();


bool start = false;
bool playing = true;


//The start of the game, choose type, name, affiliation and information
while (start == true)
{

}


//The gameplay
while (playing == true)
{
    while (player.currentState == Player.PlayerState.isFighting)
    {
        
    }


    while (player.currentState == Player.PlayerState.dead)
    {

    }
}


void PlayerTurn()
{
    printAllStats(player, enemy);
    player.WriteActionChoices();
    char input = Console.ReadKey().KeyChar;
    printAllStats(player, enemy);
    player.Action(input);

    if (player.attackedEnemy == true)
    {
        enemy.TakeDamage(player.baseDamage, player.spells[0]);
        player.attackedEnemy = false;

    }
}


void EnemyTurn()
{

}


static void printAllStats(Player player, Enemy enemy)
{
    Console.Clear();
    //Writes player stats
    Console.ForegroundColor = ConsoleColor.White;
    Console.WriteLine($"[{player.name}] [Hp: {player.health}] [Mana: {player.mana}] [{player.printAffiliation}]");
    Console.Write("Potions: ");
    Console.ForegroundColor = ConsoleColor.Red;
    Console.Write($"{player.healthPotions} ");
    Console.ForegroundColor = ConsoleColor.Blue;
    Console.WriteLine($"{player.manaPotions}");
    //Writes enemy stats
    Console.ForegroundColor = ConsoleColor.DarkRed;
    Console.WriteLine($"Enemy: [{enemy.name}] [Hp: {enemy.health}] [{enemy.printAffiliation}]\n ");
}