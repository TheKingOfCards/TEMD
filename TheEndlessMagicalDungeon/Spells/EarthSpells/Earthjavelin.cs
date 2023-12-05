public class Earthjavelin: Spell
{
    public Earthjavelin()
    {
        name = "EarthJavelin";
        damage = 5;
        manaCost = 5;
        description = $"Create a javelin of earth and throw it at the enemy and deal {damage} damage and costs {manaCost} mana";
        color = ConsoleColor.DarkYellow;
    }
}