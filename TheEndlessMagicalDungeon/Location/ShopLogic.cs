public class ShopLogic
{
    public Weapon ChangeWeapon(List<Weapon> weapons, Weapon currentW)
    {
        bool choosing = true;
        int chooseWNum = 0;

        while (choosing)
        {
            Console.Clear();
            Console.WriteLine("Use A and D to choose what weapon you want and press E or if you would like to exit press Q");
            Console.WriteLine($"Current weapon: {currentW.name} | Damage: {currentW.baseDamage} | Upgraded time(s): {currentW.upgradeTimes}\n");

            if (chooseWNum < 0)
            {
                chooseWNum = weapons.Count - 1;
            }
            else if (chooseWNum > weapons.Count - 1)
            {
                chooseWNum = 0;
            }

            Console.WriteLine($"< {weapons[chooseWNum].name} >");

            char input = Console.ReadKey().KeyChar;
            string stringInput = input.ToString();

            if (stringInput.ToLower() == "a")
            {
                chooseWNum--;
            }
            else if (stringInput.ToLower() == "d")
            {
                chooseWNum++;
            }
            else if(stringInput == "e")
            {
                weapons.Add(currentW);
                currentW = weapons[chooseWNum];
                weapons.Remove(currentW);
                Console.WriteLine($"You switched your weapon to {weapons[chooseWNum].name}");
                choosing = false;
            }
            else if(stringInput.ToLower() == "q")
            {
                choosing = false;
            }
        }
        return currentW;
    }
}