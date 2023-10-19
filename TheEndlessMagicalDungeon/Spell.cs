namespace SpellsLogic;

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


//Used if the player uses a physical attack
public class NoSpell: Spell
{
    public NoSpell()
    {
        noSpellUsed = true;
    }
}


//Fire spells begin
public class Pyroorb: Spell
{
    public Pyroorb()
    {
        name = "PyroOrb";
        description = $"Shoot out an orb of fire and deal {this.name} damage - has a chance to set enemies on fire";
        damage = 20;
        canSetOnFire = true;
        manaCost = 20;
    }
}

public class Pyroquake: Spell
{
    public Pyroquake()
    {
        willSetOnFire = true;
        name = "PyroQuake";
        description = "Light the floor under the enemy on fire - deals no damage when casting but will set the enemy on fire";
        damage = 0;
        manaCost = 30;
    }
}

public class Combustion: Spell
{
    public Combustion()
    {
        name = "Combustion";
        description = $"Condense a large amount of fire and shoot it at the enemy and deal {this.name} damage - has a chance to set enemies on fire";
        damage = 35;
        canSetOnFire = true;
        manaCost = 40;
    }
}
//Fire spells end



//Earth spells begin
public class Earthquake: Spell
{
    public Earthquake()
    {
        name = "EarthQuake";
        description = $"Create a earthquake beneath the enemy and deal {this.name} damage - makes it harder for the enemy to dodge2";
        damage = 15;
        hasDodgeChanceNegation = true;
        dodgeChanceNegation = 20;
    }
}

public class Terraspike: Spell
{
    public Terraspike()
    {
        name = "TerraSpike";
        damage = 35;
        description = $"Causes spikes to erupt from below the enemy peircing them and dealing {this.name} damage";
        manaCost = 40;
    }
}

public class Earthjavelin: Spell
{
    public Earthjavelin()
    {
        name = "EarthJavelin";
        damage = 25;
        description = $"Create a javelin of earth and throw it at the enemy and deal 25 damage";
        manaCost = 25;
    }
}
//Earth spells end


//Water spells begin
public class Tsunami: Spell
{
    public Tsunami()
    {
        name = "Tsunami";
        damage = 50;
        description = "";
        manaCost = 60;
    }
}

public class WaterOctopus: Spell
{
    public WaterOctopus()
    {
        name = "AquaPus";
        damage = 30;
        description = $"Create a octopus from water and hit the enemy with your 8 arms dealing {this.damage}";
        manaCost = 35;
    }
}

public class AquaBarrier: Spell
{
    public AquaBarrier()
    {
        name = "AquaBarrier";
        damage = 0;
        description = "Incase yourself in water and negate some of the damage";
        manaCost = 60;
    }
}
//Water spells end


//Air spells begin

//Air spells end