using System;
using SpellsLogic;
using EntityLogic;
using System.Diagnostics.Contracts;
using EnemyLogic;
using EffectsLogic;
using WeaponsLogic;

namespace PlayerLogic
{
    public class Player : Entity
    {
        public PlayerState currentState = PlayerState.isFighting;
        public int mana = 0;
        int maxMana = 80;

        public int shieldBlockAmount;
        int setShieldBlockAmount = 10;

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
        public List<Spell> inventorySpells = new();
        public List<Weapon> inventoryWeapons = new(); 
        Weapon currentWeapon;

        Enemy currentEnemy;


        public Player()
        {
            maxHealth = 10;
            health = maxHealth;
            mana = maxMana;
            
            healthPotions = maxHealthPotions;
            manaPotions = maxManaPotions;

            inventoryWeapons.Add(new Zweihander());
            currentWeapon = inventoryWeapons[0];
            spells.Add(new NoSpell());
        }


        //Writes out the actions the player can do
        public void WriteActionChoices()
        {
            if (currentState == PlayerState.isFighting)
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("1. Physical Action \n2. Spells \n3. Potions");
            }
            else if (currentState == PlayerState.isLooting)
            {

            }
            else if (currentState == PlayerState.inBlacksmith)
            {

            }
            else if (currentState == PlayerState.inMagicShop)
            {

            }
        }


        //Takes the players action with a char
        public void Action(char playerInput)
        {
            Console.ForegroundColor = ConsoleColor.White;
            if (currentState == PlayerState.isFighting) //The actions the player can take while fighting
            {
                if (playerInput == '1')
                {
                    Console.WriteLine("1. Attack \n2. Shield \n3. Dodge");
                    UsePhysical(Console.ReadKey().KeyChar);
                }
                else if (playerInput == '2')
                {
                    UseSpells(Console.ReadKey().KeyChar);
                }
                else if (playerInput == '3')
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("1. Health Potion");
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("\n2. Mana Potion");
                    UsePotions(Console.ReadKey().KeyChar);
                }
                else if (playerInput == '4')
                {
                    Console.WriteLine("1. Perks");
                    Perks();
                }
                else
                {
                    return;
                }
            }
            else if (currentState == PlayerState.isLooting) //The actions the player can take while looting
            {

            }
        }


        public void setEnemy(Enemy e)
        {
            currentEnemy = e;
        }


        //Player decide which spell they would like to use
        void UseSpells(char spellSelect)
        {

        }


        //Player can either attack, use spells or get a higher dodge chance
        void UsePhysical(char physicalSelect)
        {
            if (physicalSelect == '1') //Attack
            {
                currentEnemy.health -= currentWeapon.baseDamage;
            }
            else if (physicalSelect == '2') //Shield
            {
                shieldBlockAmount = setShieldBlockAmount;
            }
            else if (physicalSelect == '3') //Dodge
            {
                dodgeChance += 10;
            }
        }


        //Uses healthpotions or manapotions
        void UsePotions(char potionSelect)
        {
            if (potionSelect == '1') //Heals the player
            {
                if (healthPotions > 0)
                {
                    healthPotions--;
                    health += healthPotionHealAmount;
                    if (health > maxHealth)
                    {
                        health = maxHealth;
                    }
                }
                else
                {
                    Console.WriteLine("\nYou dont have any health potions left");
                    Console.ReadKey();
                }
            }
            else if (potionSelect == '2') //Raises the players mana
            {
                if (manaPotions > 0)
                {
                    manaPotions--;
                    mana += manaPotionRaiseAmount;
                    if (mana > maxMana)
                    {
                        mana = maxMana;
                    }
                }
                else
                {
                    Console.WriteLine("\nYou dont have any mana potions left");
                    Console.ReadKey();
                }
            }
        }


        //Shows the player perks and if they can get them
        public void Perks()
        {

        }



        //Takes in the base xp from enemies killed and adds it to player xp (multipliers)
        public int GetXp(int baseDropXp)
        {
            if (xp >= levelUpPoint)
            {
                level++;
                perkPoints++;
                xp -= levelUpPoint;
            }

            return xp;
        }


        public void Dead()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.Write("You died");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(", press any button to exit the game");
            Console.ReadKey();
            Environment.Exit(1);
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