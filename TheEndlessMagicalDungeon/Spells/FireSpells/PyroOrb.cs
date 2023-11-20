public class Pyroorb: Spell
{
    public Pyroorb()
    {
        name = "PyroOrb";
        description = $"Shoot out an orb of fire and deal {this.name} damage - has a chance to set enemies on fire";
        damage = 20;
        canSetOnFire = true;
        manaCost = 20;
    }
}