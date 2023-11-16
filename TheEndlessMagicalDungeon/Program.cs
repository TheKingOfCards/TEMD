using PlayerLogic;
using EnemyLogic;
using SpellsLogic;
using FightingLogic;

Console.Title = "The Endeless Magical Dungeon";

Player player = new();
Arena arena = new(player);
Enemy enemy = new TankEnemy();
CharacterCreation CC = new(player);


bool start = true;
bool playing = false;


//The start of the game, choose type, name, affiliation and information
while (start == true)
{
    CC.Creation();
    Console.WriteLine("Welcome to The Endless Magical Dungeon");
    Console.WriteLine("You will be fighting monsters and other people for an eternety or until you die");

    //Info dump
    Console.WriteLine("You will be using the numbers buttons to move around in the UI");
    Console.WriteLine("You will be fighting diffrent enemies with increasing stats");
    Console.WriteLine("Spells use mana and you will only be able to carry 3 spells at a time");
    Console.WriteLine("And I won't say much more because you will find out by trying/dying");
    Console.WriteLine("Now you will create your chracter");
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