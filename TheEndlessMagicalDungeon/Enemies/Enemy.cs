using System.Diagnostics.Contracts;
using SpellsLogic;
using EntityLogic;
using PlayerLogic;

namespace EnemyLogic
{
    public class Enemy : Entity
    {
        public List<Spell> spells = new();
        public List<String> names = new();
        List<Char> affiliations = new();
        Player player;


        public Random random = new();
        public Enemy()
        {
            affiliations.Add('F');
            affiliations.Add('E');
            affiliations.Add('W');
            affiliations.Add('A');
            affiliations.Add('N');

            spells.Add(new NoSpell());
        }

        public void setPlayer(Player p)
        {
            player = p;
        }


        //Decides the affilitation of the enemy and make it so that PrintStats can write it out
        public void GetAffilitation()
        {
            int index = random.Next(affiliations.Count);

            elementAffiliation = affiliations[index];

            //Makes it so that the whole name of the element can be printed in PrintStats
            if (elementAffiliation == 'F')
            {
                printAffiliation = "Fire";
            }
            else if (elementAffiliation == 'E')
            {
                printAffiliation = "Earth";
            }
            else if (elementAffiliation == 'W')
            {
                printAffiliation = "Water";
            }
            else if (elementAffiliation == 'A')
            {
                printAffiliation = "Air";
            }
            else
            {
                printAffiliation = "Normal";
            }
        }


        //Gives the enemy a name from the list in its class
        public void GetName()
        {
            int index = random.Next(names.Count);

            name = names[index];
        }

        
        //Attacks the player
        public void Attack()
        {
            Console.ForegroundColor = ConsoleColor.White;
            if(player.shieldBlockAmount == 0) //If player didn't use shield
            {
                player.health -= damage;
                Console.WriteLine($"The enemy attack you dealing {damage} damage");
                Console.ReadKey();
            }else if(damage - player.shieldBlockAmount > 0) //If player used shield but didn't block all damage
            {
                player.health -= damage - player.shieldBlockAmount;
                Console.WriteLine($"You blocked {player.shieldBlockAmount} damage from the attack but was still hit for {damage - player.shieldBlockAmount}");
                player.shieldBlockAmount = 0;
                Console.ReadKey();
            }else if(damage - player.shieldBlockAmount <= 0) //If player used shield to blcok all damage
            {
                Console.WriteLine("You used your shield to block all damage");
                player.shieldBlockAmount = 0;
                Console.ReadKey();
            }
        }
    }
}

