public class Pyroquake: Spell
{
    public Pyroquake()
    {
        willSetOnFire = true;
        name = "PyroQuake";
        description = "Light the floor under the enemy on fire - deals no damage when casting but will set the enemy on fire";
        damage = 0;
        manaCost = 30;
    }
}