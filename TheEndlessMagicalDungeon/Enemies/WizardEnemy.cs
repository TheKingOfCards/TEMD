using EnemyLogic;
using SpellsLogic;

public class WizardEnemy : Enemy
{
    public WizardEnemy()
    {
        spells = new()
        {
            
        };
        maxHealth = 75;
        health = maxHealth;

        names.Add("Fladnag The Grey");
        names.Add("Hotter Parry The Boy Who Died");
        names.Add("The Strange Doctor");
        names.Add("Whisperer of Os");
        names.Add("Headmaster Smartledore");
    }
}