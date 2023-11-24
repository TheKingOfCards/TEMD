using System.Net.Mime;
using FightingLogic;


Console.Title = "The Endeless Magical Dungeon";

TextHandler tH = new();
Player player = new();
Arena arena = new(player);
Enemy enemy = new TankEnemy();
CharacterCreation CC = new(player);


bool start = false;
bool playing = true;


//The start of the game, choose type, name, affiliation and information
while (start == true)
{
    CC.Creation();
    Console.ReadKey();
    start = false;
    playing = true;
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