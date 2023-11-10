using EnemyLogic;
public class ElementalEnemy : Enemy
{
    List<Char> elementalAffiliation = new();

    public ElementalEnemy()
    {
        maxHealth = 75;
        Hp = maxHealth;
        baseDamage = 20;

        elementalAffiliation.Add('F');
        elementalAffiliation.Add('E');
        elementalAffiliation.Add('W');
        elementalAffiliation.Add('A');

        ElementalGetAffiliation();
        ElementalGetName(elementAffiliation);
    }


    //Has seperate because it most have a affiliation
    public void ElementalGetAffiliation()
    {
        int index = random.Next(elementalAffiliation.Count);

        elementAffiliation = elementalAffiliation[index];


        if (elementAffiliation == 'F')
        {
            printAffiliation = "Fire";
        }
        else if (elementAffiliation == 'E')
        {
            printAffiliation = "Earth";
        }
        else if (elementAffiliation == 'W')
        {
            printAffiliation = "Water";
        }
        else if (elementAffiliation == 'A')
        {
            printAffiliation = "Air";
        }
    }


    //Has sperate because the name depends on its affiliation
    public void ElementalGetName(char affiliation)
    {
        if (affiliation == 'F')
        {
            name = "Fire Guardian";
        }
        else if (affiliation == 'E')
        {
            name = "Earth Guardian";
        }
        else if (affiliation == 'W')
        {
            name = "Water Guardian";
        }
        else
        {
            name = "Air Guardian";
        }
    }
}