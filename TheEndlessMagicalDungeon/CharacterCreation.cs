using System.Diagnostics;
using System.Diagnostics.Contracts;


public class CharacterCreation
{
    Player player;


    public CharacterCreation(Player setPlayer)
    {
        player = setPlayer;
    }


    public void Creation()
    {
        Console.WriteLine("Welcome to The Endless Magical Dungeon");
        Console.WriteLine("You will be fighting monsters and other people for an eternety or until you die");

        Console.WriteLine("You will be using the numbers buttons to move around in the UI");
        Console.WriteLine("You will be fighting diffrent enemies with increasing stats");
        Console.WriteLine("Spells use mana and you will only be able to carry 3 spells at a time");
        Console.WriteLine("And I won't say much more because you will find out by trying/dying");
        Console.WriteLine("Now you will create your chracter");

        SetName();
        ChooseElement();
        ChooseClass();
    }


    public void SetName()
    {
        Console.WriteLine("Now fighter, what is your name?");
        player.name = Console.ReadLine();
        Console.WriteLine($"Okay {player.name}");
        Console.ReadKey();
        Console.Clear();
    }


    void ChooseElement()
    {
        Console.WriteLine("Choose the Element you want your character to be");
        Console.WriteLine("\nWater is strong against Fire but weak against Air");
        Console.WriteLine("Earth is strong against Air but weak against Fire");
        Console.WriteLine("Fire is strong against Earth but weak against Water");
        Console.WriteLine("Air is strong against Water but weak against Earth");

        Console.ForegroundColor = ConsoleColor.Blue;
        Console.Write("\n1. Water");
        Console.ForegroundColor = ConsoleColor.DarkYellow;
        Console.Write("\n2. Earth");
        Console.ForegroundColor = ConsoleColor.Red;
        Console.Write("\n3. Fire");
        Console.ForegroundColor = ConsoleColor.White;
        Console.Write("\n4. Air\n");

        bool choosing = true;

        while (choosing == true)
        {
            char input = Console.ReadKey().KeyChar;

            choosing = false;
            if (input == '1') //Water
            {
                player.currentElement = Player.PlayerElement.water;
            }
            else if (input == '2') //Earth
            {
                player.currentElement = Player.PlayerElement.earth;
            }
            else if (input == '3') //Fire
            {
                player.currentElement = Player.PlayerElement.fire;
            }
            else if (input == '4') //Air
            {
                player.currentElement = Player.PlayerElement.air;
            }
            else
            {
                Console.WriteLine("\nUse one of the options above idiota");
                choosing = true;
            }
        }
        Console.Clear();
    }


    void ChooseClass()
    {
        Console.WriteLine("Which class do you want to be?\n");
        Console.WriteLine("1. Barbarian \n2. Knight \n3. Wizard \n4. Assasin");
        bool choosing = true;

        while (choosing == true)
        {
            choosing = false;

            char input = Console.ReadKey().KeyChar;

            if (input == '1')
            {
                player.currentClass = Player.PlayerClass.barb;
            }
            else if (input == '2')
            {
                player.currentClass = Player.PlayerClass.knight;
            }
            else if (input == '3')
            {
                player.currentClass = Player.PlayerClass.wizard;
            }
            else if (input == '4')
            {
                player.currentClass = Player.PlayerClass.assasin;
            }
            else
            {
                Console.WriteLine("\nUse one of the options above");
                choosing = true;
            }
        }
    }
}