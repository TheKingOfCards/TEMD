namespace EntityLogic;
using EffectsLogic;

public class Entity : Effects
{
    public string name = "";
    private int _hp = 0;
    public int maxHealth;
    public int Hp
    {
        set
        {
            _hp = value;
            if (_hp < 0)
            {
                _hp = 0;
            }
            if (_hp > maxHealth)
            {
                _hp = maxHealth;
            }
        }
        get => _hp;
    }

    public int critChance;
    public int critAmount;

    public int baseDamage;
    public int damage;

    public char elementAffiliation;
    public string printAffiliation = "";
    Random random = new();

    //Checks if the enemy is alive
    public bool GetAlive()
    {
        if (Hp <= 0)
        {
            return false;
        }
        else
        {
            return true;
        }
    }

    //Calculates if the entity dodges
    public bool CalcDodge(int baseDodge)
    {
        int index = random.Next(1, 11);

        if (index <= baseDodge)
        {
            return true;
        }
        else
        {
            return false;
        }
    }


    //Calculates if the entity gets a critical attack 
    public bool CalcCrit()
    {
        int index = random.Next(0, 10);

        if (index <= critChance)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

}