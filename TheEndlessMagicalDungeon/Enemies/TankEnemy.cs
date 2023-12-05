public class TankEnemy : Enemy
{
    public TankEnemy()
    {
        maxHealth = 15;
        Hp = maxHealth;
        baseDamage = 1;

        
        critChance = 5;
        critAmount = 2;

        names.Add("The Ugly Troll");
        names.Add("Giant");
        names.Add("The Attack Titan");
        names.Add("The Beast Titan");
        names.Add("The Hulking Goliath");

        GetName();
        GetAffilitation();
    }
}