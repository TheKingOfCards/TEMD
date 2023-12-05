using System.Net.Mime;
using FightingLogic;


Console.Title = "The Endeless Magical Dungeon";

Player player = new();
player.currentState = Player.PlayerState.inBlacksmith;
CharacterCreation CC = new(player);
Arena arena = new(player);
Blacksmith blacksmith = new(player);
LocaitonLogic lL = new(arena, blacksmith);

bool start = false;
bool playing = true;


//The start of the game, choose type, name, affiliation and information
while (start == true)
{
    CC.Creation();
    player.currentState = Player.PlayerState.inBlacksmith;
    Console.ReadKey();
    start = false;
    playing = true;
}


//The gameplay
while (playing == true)
{    
    lL.GetNewLocation(player);
}