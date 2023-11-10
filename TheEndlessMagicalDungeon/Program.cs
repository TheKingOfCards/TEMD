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
    Console.WriteLine("Welcome to The Endless Magical Dungeon");
    Console.WriteLine("You will be fighting monsters and other people for an eternety or until you die");
    Console.WriteLine("Now fighter, what is your name?");
    player.name = Console.ReadLine();
    Console.WriteLine($"Okay.. {player.name}... Your mother wasn't very nice to you huh?");
    Console.WriteLine("Anyway, now for some information so pay attention, after you have read the text that will pop up press any button ONCE!!");
    Console.ReadKey();
    Console.Clear();
    //Info dump
    Console.WriteLine("You will be using the numbers buttons to move around in the UI");
    Console.WriteLine("You will be fighting diffrent enemies with increasing stats");
    Console.WriteLine("Spells use mana and you will only be able to carry 3 spells at a time");
    Console.WriteLine("And I won't say much more because you will find out by trying/dying");
    Console.WriteLine("Your first fight will begin now");
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