public class Pyroorb: Spell
{
    public Pyroorb()
    {
        name = "PyroOrb";
        description = $"Shoot out an orb of fire and deal {damage} damage - has a chance to set enemies on fire";
        damage = 20;
        canSetOnFire = true;
        manaCost = 20;
        color = ConsoleColor.Red;
    }
}