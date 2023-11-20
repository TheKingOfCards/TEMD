public class Spell
{
    public string name = "";
    public string description = "";
    public int damage;
    public int manaCost;

    public bool noSpellUsed = false;

    public bool canSetOnFire = false;
    public bool willSetOnFire = false;

    public bool hasDodgeChanceNegation = false;
    public int dodgeChanceNegation;

    public bool hasDamageNegation = false;
    public int damageNegation;
}