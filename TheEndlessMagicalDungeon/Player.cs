using System;
using SpellsLogic;
using EntityLogic;
using System.Diagnostics.Contracts;
using EnemyLogic;

namespace PlayerLogic
{
    public class Player: Entity 
    {
        public PlayerState currentState;
        public int mana = 0;
        int maxMana = 80;

        public int xp = 0;
        public int levelUpPoint = 50;
        public int coins = 0;
        public int level = 0;
        public int perkPoints = 0;

        char characterType;

        public int healthPotions = 0;
        int maxHealthPotions = 5;
        int healthPotionHealAmount = 20;

        public int manaPotions = 0; 
        int maxManaPotions = 3; 
        int manaPotionRaiseAmount = 15;

        public bool attackedEnemy = false;

        public List<Spell> spells = new();


        public Player()
        {
            maxHealth = 100;
            health = maxHealth;
            mana = maxMana;
baseDamage = 30;
            healthPotions = maxHealthPotions;
            manaPotions = maxManaPotions;

            spells.Add(new NoSpell());
        }


        //Writes out the actions the player can do
        public void WriteActionChoices()
        {
            if(currentState == PlayerState.isFighting)
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("1. Physical Action \n2. Spells \n3. Potions");
            }else if(currentState == PlayerState.isLooting)
            {
                
            }else if(currentState == PlayerState.inBlacksmith)
            {

            }else if(currentState == PlayerState.inMagicShop)
            {

            }
        }


        //Takes the players action with a char
        public void Action(char playerInput)
        {
            Console.ForegroundColor = ConsoleColor.White;
            if(currentState == PlayerState.isFighting) //The actions the player can take while fighting
            {
                if(playerInput == '1')
                {
                    Console.WriteLine("1. Attack \n2. Shield \n3. Dodge");
                    UsePhysical(Console.ReadKey().KeyChar);
                }else if(playerInput == '2')
                {
                    UseSpells(Console.ReadKey().KeyChar);
                }else if(playerInput == '3')
                {
                    Console.WriteLine("1. Health Potion\n2. Mana Potion");
                    UsePotions(Console.ReadKey().KeyChar);
                }else if(playerInput == '4')
                {
                    Console.WriteLine("1. Perks"); 
                    Perks();
                }else
                {
                    return;
                }
            }else if(currentState == PlayerState.isLooting) //The actions the player can take while looting
            {

            }
        }


        //Player decide which spell they would like to use
        public void UseSpells(char spellSelect)
        {
            
        }


        //Player can either attack, use spells or get a higher dodge chance
        public void UsePhysical(char physicalSelect)
        {
            if(physicalSelect == '1')
            {
                attackedEnemy = true;
            }else if(physicalSelect == '2')
            {

            }else if(physicalSelect == '3')
            {
                
            }else
            {

            }
        }


        //Uses healthpotions or manapotions
        public void UsePotions(char potionSelect)
        {
            if(potionSelect == '1') //Heals the player
            {
                if(healthPotions > 0)
                {
                    healthPotions--;
                    health += healthPotionHealAmount;
                    if(health > maxHealth)
                    {
                        health = maxHealth;
                    }
                }else
                {
                    Console.WriteLine("\nYou dont have any health potions left");
                    Console.ReadKey();
                }
            }else if(potionSelect == '2') //Raises the players mana
            {
                if(manaPotions > 0)
                {
                    manaPotions--;
                    mana += manaPotionRaiseAmount;
                    if(mana > maxMana)
                    {
                        mana = maxMana;
                    }
                }else
                {
                    Console.WriteLine("\nYou dont have any mana potions left");
                    Console.ReadKey();
                }
            }
        }


        //Takes in a enemys pysical damage in a parameter and puts takes away from health
        public void Attack(Enemy enemy)
        {
            if(true) //Take physical damage
            {

            }else //Take spelldamage and passive effects
            {

            }
        }


        //Shows the player perks and if they can get them
        public void Perks()
        {

        }



        //Takes in the base xp from enemies killed and adds it to player xp (multipliers)
        public int GetXp(int baseDropXp)
        {
            if(xp  >= levelUpPoint)
            {
                level++;
                perkPoints++;
                xp -= levelUpPoint;
            }

            return xp;
        }


        public enum PlayerState
        {
            isFighting,
            isLooting,
            inBlacksmith,
            inMagicShop,
            dead
        }
    }
}