using PlayerLogic;
using EnemyLogic;
using SpellsLogic;
using FightingLogic;

Console.Title = "The Endeless Magical Dungeon";

Player player = new();
Arena arena = new(player);
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
        arena.Start(enemy);
    }


    while (player.currentState == Player.PlayerState.dead)
    {

    }
}