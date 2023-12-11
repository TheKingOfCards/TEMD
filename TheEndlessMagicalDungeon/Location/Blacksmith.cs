public class Blacksmith : ShopLogic
{
    Player player;
    Random random = new();
    List<Weapon> allWeapons = new()
    {
        new Dagger(),
        new Halberd(),
        new Katana(),
        new VikingAxe(),
        new Zweihander()
    };


    public Blacksmith(Player p)
    {
        player = p;
    }


    public void ChooseAction() //Choose to buy a new weapon or upgrade one of your weapons
    {
        bool choosing = true;

        while (choosing)
        {
            choosing = false;
            Console.Clear();
            Console.WriteLine("Hello fighter, what would you like to do here in my blacksmith");
            Console.WriteLine($"Coins: {player.coins}");
            Console.WriteLine("\n1. Buy weapon \n2. Upgrade weapon \n3. Inventory \n4. Leave");
            char input = Console.ReadKey().KeyChar;

            if (input == '1')
            {
                Buying();
            }
            else if (input == '2')
            {
                Upgrade();
            }
            else if (input == '3')
            {
                Console.Clear();
                Console.WriteLine("1. Switch weapon \n2. Switch spells");
                char chooseChar = Console.ReadKey().KeyChar;
                if (chooseChar == '1')
                {
                    ChangeWeapon(player.inventoryWeapons, player.currentWeapon);
                }
                else if(chooseChar == '2')
                {

                }
            }
            else
            {
                choosing = true;
            }
        }
    }


    void Upgrade()
    {

    }

    void Buying()
    {
        Console.Clear();
        Console.WriteLine("Which weapon would you like to buy?\n");

        int index = 0;
        int weaponChoiseNumber = 1;

        for (int i = 0; i < 3; i++)
        {
            index = random.Next(allWeapons.Count);
            Console.WriteLine($"{weaponChoiseNumber}. {allWeapons[i].name}");
            weaponChoiseNumber++;
        }

        Console.ReadKey();
    }
}