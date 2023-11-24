using System.Security.Authentication;
using System;
using System.Diagnostics.Contracts;
using FightingLogic;
using System.Runtime.ExceptionServices;

public class Player : Entity
{
    public PlayerState currentState = PlayerState.isFighting;
    public PlayerClass currentClass;
    public PlayerElement currentElement;

    private int _mana;
    public int Mana
    {
        set
        {
            _mana = value;
            if (_mana < 0)
            {
                _mana = 0;
            }

            if(_mana > maxMana)
            {
                _mana = maxMana;
            }
        }

        get => Hp;
    }
    int maxMana = 80;

    public int dodgeChance;
    int setdodgeChance = 5;

    public int shieldBlockAmount;
    int setShieldBlockAmount = 10;

    private int xp = 0;
    int Xp{
        set
        {
            xp = value;

            if(xp >= levelUpPoint)
            {
                level++;
                perkPoints++;
                xp -= levelUpPoint;
            }
        }

        get => xp;
    }
    int levelUpPoint = 50;
    int coins = 0;
    int level = 0;
    int perkPoints = 0;

    public int healthPotions = 0;
    int maxHealthPotions = 5;
    int healthPotionHealAmount = 20;

    public int manaPotions = 0;
    int maxManaPotions = 3;
    int manaPotionRaiseAmount = 15;

    public bool playerTurn = false;

    public List<Spell> currentSpells = new();
    public List<Spell> inventorySpells = new();
    public List<Weapon> inventoryWeapons = new();
    Weapon currentWeapon;

    Enemy currentEnemy;
    TextHandler tH;


    public Player()
    {
        maxHealth = 100;
        Hp = maxHealth;
        _mana = maxMana;

        healthPotions = maxHealthPotions;
        manaPotions = maxManaPotions;

        tH = new TextHandler();

        inventoryWeapons.Add(new Zweihander());
        currentWeapon = inventoryWeapons[0];
        currentSpells.Add(new NoSpell());
        currentSpells.Add(new Pyroorb());
        currentSpells.Add(new Tsunami());
        currentSpells.Add(new Earthjavelin());
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
                Console.WriteLine("1. Attack \n2. Shield \n3. Dodge \n4. Go Back \n");
                UsePhysical(Console.ReadKey().KeyChar);
            }
            else if (playerInput == '2')
            {
                tH.SpellSelect(currentSpells[1], currentSpells[2], currentSpells[3]);
                SpellSelect(Console.ReadKey().KeyChar);
            }
            else if (playerInput == '3')
            {
                tH.PotionSelect();
                UsePotions(Console.ReadKey().KeyChar);
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
    void SpellSelect(char spellSelect)
    {
        Spell attackingSpell;
        if (spellSelect == '1')
        {
            attackingSpell = currentSpells[1];
            SpellAttacking(attackingSpell);
        }
        else if (spellSelect == '2')
        {
            attackingSpell = currentSpells[2];
            SpellAttacking(attackingSpell);
        }
        else if (spellSelect == '3')
        {
            attackingSpell = currentSpells[3];
            SpellAttacking(attackingSpell);
        }
        else
        {
            playerTurn = true;
            return;
        }
    }


    void SpellAttacking(Spell attackingSpell)
    {
        Console.ForegroundColor = ConsoleColor.White;
        Console.CursorLeft--;
        if (attackingSpell.damage > 0)
        {
            currentEnemy.Hp -= attackingSpell.damage;
            Mana -= attackingSpell.manaCost;
            Console.WriteLine($"You attacked the monster with {attackingSpell.name} dealing {attackingSpell.damage} damage and using {attackingSpell.manaCost} mana");
            Console.ReadKey();
        }
    }


    //Player can either attack, use spells or get a higher dodge chance
    void UsePhysical(char physicalSelect)
    {
        Console.CursorLeft--;
        if (physicalSelect == '1') //Attack
        {
            currentEnemy.Hp -= currentWeapon.baseDamage;
            Console.WriteLine($"You attacked {currentEnemy.name} with your {currentWeapon.name} dealing {currentWeapon.baseDamage}");
            Console.ReadKey();
        }
        else if (physicalSelect == '2') //Shield
        {
            shieldBlockAmount = setShieldBlockAmount;
        }
        else if (physicalSelect == '3') //Dodge
        {
            dodgeChance = setdodgeChance;
        }
        else //Go back to previous menu
        {
            playerTurn = true;
            return;
        }
    }


    //Uses healthpotions or manapotions
    void UsePotions(char potionSelect)
    {
        Console.CursorLeft--;
        if (potionSelect == '1') //Heals the player
        {
            if (healthPotions > 0)
            {
                healthPotions--;
                Hp += healthPotionHealAmount;
                if (Hp > maxHealth)
                {
                    Hp = maxHealth;
                }
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine($"You healed {healthPotionHealAmount} hp points");
                Console.ReadKey();
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
                _mana += manaPotionRaiseAmount;
                if (_mana > maxMana)
                {
                    _mana = maxMana;
                }
                Console.WriteLine($"You restored {manaPotionRaiseAmount} mana points");
            }
            else
            {
                Console.WriteLine("\nYou dont have any mana potions left");
                Console.ReadKey();
            }
        }
        else
        {
            playerTurn = true;
            return;
        }
    }


    //Shows the player perks and if they can get them
    public void Perks()
    {

    }



    //Takes in the base xp from enemies killed and adds it to player xp (multipliers)
    public int GetXp(int baseDropXp)
    {
        Xp += baseDropXp;

        return xp;
    }


    public static void Dead()
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

    public enum PlayerClass
    {
        barb,
        wizard,
        knight,
        assasin
    }

    public enum PlayerElement
    {
        fire,
        water,
        earth,
        air
    }
}
