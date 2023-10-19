using EnemyLogic;
public class TankEnemy : Enemy
{
    public TankEnemy()
    {
        maxHealth = 150;
        health = maxHealth;

        dodgeChance = 10;
        critChance = 5;

        names.Add("The Ugly Troll");
        names.Add("Giant");
        names.Add("Titan");
        names.Add("Beast");
        names.Add("The Hulking Goliath");

        GetName();
        GetAffilitation();
    }
}