public class WaterOctopus: Spell
{
    public WaterOctopus()
    {
        name = "AquaPus";
        damage = 30;
        manaCost = 35;
        description = $"Create a octopus from water and hit the enemy with your 8 arms dealing {this.damage}";
        color = ConsoleColor.Blue;
    }
}