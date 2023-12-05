public class Earthjavelin: Spell
{
    public Earthjavelin()
    {
        name = "EarthJavelin";
        damage = 25;
        manaCost = 25;
        description = $"Create a javelin of earth and throw it at the enemy and deal {damage} damage and costs {manaCost} mana";
        color = ConsoleColor.DarkYellow;
    }
}