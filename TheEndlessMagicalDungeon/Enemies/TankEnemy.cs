public class TankEnemy : Enemy
{
    public TankEnemy()
    {
        maxHealth = 150;
        Hp = maxHealth;
        baseDamage = 30;

        
        critChance = 5;
        critAmount = 2;

        names.Add("The Ugly Troll");
        names.Add("Giant");
        names.Add("Titan");
        names.Add("Beast");
        names.Add("The Hulking Goliath");

        GetName();
        GetAffilitation();
    }
}