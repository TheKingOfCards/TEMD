public class Effects : Entity
{
    public int burningTime = 3;
    public bool isBurning = false;
    string effectTarget = "";

    public void Tick(string eT)
    {
        Burning(eT);
    }


    void Burning(string eT)
    {
        if (isBurning == true) // Checks if player is burning and lowers the time if they are
        {
            Hp--;
            burningTime--;
            Console.Clear();
            Console.WriteLine($"{eT} took damage from being on fire");
            Console.ReadKey();
        }
        else
        {
            burningTime = 3;
        }


        if (isBurning == true && burningTime <= 0) //Puts the player out if burning time == 0
        {
            isBurning = false;
        }
    }
}