public class Earthquake: Spell
{
    public Earthquake()
    {
        name = "EarthQuake";
        description = $"Create a earthquake beneath the enemy and deal {this.damage} damage - makes it harder for the enemy to dodge2";
        damage = 15;
        hasDodgeChanceNegation = true;
        dodgeChanceNegation = 20;
        color = ConsoleColor.DarkYellow;
    }
}