using EnemyLogic;
using SpellsLogic;
public class NibmleEnemy : Enemy
{
    public NibmleEnemy()
    {
        spells = new List<Spell>
            {
                new Pyroorb(),
                new Pyroquake()
            };

        maxHealth = 50;
        health = maxHealth;

        names.Add("Assassin");
        names.Add("Thief");
        names.Add("ShadowStalker");
        names.Add("Specter");
        names.Add("Rogue");

        GetName();
        GetAffilitation();
    }
}