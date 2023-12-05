public class Tsunami: Spell
{
    public Tsunami()
    {
        name = "Tsunami";
        damage = 50;
        manaCost = 60;
        description = $"Causes a tsunami to hit the enemy and deal {damage} damage and costs {manaCost} mana";
        color = ConsoleColor.Blue;
    }
}