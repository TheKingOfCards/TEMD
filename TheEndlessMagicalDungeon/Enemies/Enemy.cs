using System.Diagnostics.Contracts;
using SpellsLogic;
using EntityLogic;

namespace EnemyLogic
{
    public class Enemy: Entity
    {
        public List<Spell> spells = new();
        public List<String> names = new();
        List<Char> affiliations = new();


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


        //Decides the attack of the enemy
        public void Attack()
        {

        }


        //Makes it so that the enemy can take damage
        public void TakeDamage(int damage, Spell usedSpell)
        {
            if(usedSpell.noSpellUsed == true) //If physical attack is used
            {
                health -= damage;
            }else //If spell is used
            {

            }
        }
    }

    

}
