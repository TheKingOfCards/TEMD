public class NibmleEnemy : Enemy
{
    public NibmleEnemy()
    {
        spells = new List<Spell>
            {
            };

        maxHealth = 5;
        Hp = maxHealth;
        baseDamage = 2;

        names.Add("Assassin");
        names.Add("Thief");
        names.Add("ShadowStalker");
        names.Add("Specter");
        names.Add("Rogue");

        GetName();
        GetAffilitation();
    }
}