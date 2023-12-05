public class ElementalEnemy : Enemy
{
    List<Char> elementalAffiliation = new();

    public ElementalEnemy()
    {
        maxHealth = 7;
        Hp = maxHealth;
        baseDamage = 3;

        elementalAffiliation.Add('F');
        elementalAffiliation.Add('E');
        elementalAffiliation.Add('W');
        elementalAffiliation.Add('A');

        ElementalGetAffiliation();
        ElementalGetName(elementAffiliation);
    }


    //Has seperate because it must have a affiliation
    void ElementalGetAffiliation()
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
    void ElementalGetName(char affiliation)
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