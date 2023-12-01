using FightingLogic;

public class LocaitonLogic
{
    Arena arena;
    Blacksmith blacksmith;
    WizardShop wizardShop;

    Random random = new();

    
    List<Enemy> allEnemies;

    public LocaitonLogic(Arena a)
    {
        arena = a;
    }


    public void GetNewLocation(Player player) //Sets the new location of the game 
    {
        if (player.currentState == Player.PlayerState.isFighting)
        {
            arena.Start(NewEnemy());
        }

        if (player.currentState == Player.PlayerState.inBlacksmith || player.currentState == Player.PlayerState.inMagicShop)
        {
            arena.Start(NewEnemy());
        }
    }


    Enemy NewEnemy() //Creates a new enemy
    {
        allEnemies = new()
        {
            new TankEnemy(),
            new NibmleEnemy(),
            new WizardEnemy(),
            new ElementalEnemy(),
            new FlyingEnemy()
        };

        Enemy newEnemy;
        int index;

        index = random.Next(allEnemies.Count);
        newEnemy = allEnemies[index];

        return newEnemy;
    }
}