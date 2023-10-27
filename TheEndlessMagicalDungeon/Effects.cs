namespace EffectsLogic;

public class Effects
{
    public int burningTime = 3;
    public bool isBurning = false;


    public void Tick()
    {
        //Burning effect begin
        if (isBurning == true) // Checks if player is burning and lowers the time if they are
        {
            burningTime--;
        }
        else
        {
            burningTime = 3;
        }


        if (isBurning == true && burningTime <= 0) //Puts the player out if burning time == 0
        {
            isBurning = false;
        }
        //Burning effect end
    }
}