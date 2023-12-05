public class Pyroorb: Spell
{
    public Pyroorb()
    {
        name = "PyroOrb";
        damage = 20;
        manaCost = 20;
        description = $"Shoot out an orb of fire and deal {damage} damage - has a chance to set enemies on fire";
        canSetOnFire = true;
        color = ConsoleColor.Red;
    }
}