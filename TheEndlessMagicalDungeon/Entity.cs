namespace EntityLogic;
using EffectsLogic;

public class Entity : Effects
{
    public string name = "";
    public int health;
    public int maxHealth;

    public int dodgeChance;
    public int critChance;

    public int baseDamage;
    public int damage;

    public char elementAffiliation;
    public string printAffiliation = "";

    //Checks if the enemy is alive
    public bool GetAlive()
    {
        if (health <= 0)
        {
            return false;
        }
        else
        {
            return true;
        }
    }

    //Calculates if the entity dodges
    public bool CalcDodge()
    {
        return true;
        return false;
    }


    //Calculates if the entity gets a critical attack 
    public bool CalcCrit()
    {
        return true;
        return false;
    }

}