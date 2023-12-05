public class FlyingEnemy : Enemy
{

    public FlyingEnemy()
    {
        maxHealth = 7;
        Hp = maxHealth;
        baseDamage = 15;

        names.Add("Skyborne Harrier");
        names.Add("Aerial Seraph");
        names.Add("Stormwing Drake");
        names.Add("Falconclaw Avian");
        names.Add("Wyvern");

        GetName();
        GetAffilitation();
    }
}