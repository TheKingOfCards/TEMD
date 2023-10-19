using EnemyLogic;

public class FlyingEnemy : Enemy
{

    public FlyingEnemy()
    {
        maxHealth = 75;
        health = maxHealth;

        names.Add("Skyborne Harrier");
        names.Add("Aerial Seraph");
        names.Add("Stormwing Drake");
        names.Add("Falconclaw Avian");
        names.Add("Wyvern");

        GetName();
        GetAffilitation();
    }
}