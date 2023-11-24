public class Combustion: Spell
{
    public Combustion()
    {
        name = "Combustion";
        description = $"Condense a large amount of fire and shoot it at the enemy and deal {this.name} damage - has a chance to set enemies on fire";
        damage = 35;
        canSetOnFire = true;
        manaCost = 40;
        color = ConsoleColor.Red;
    }
}