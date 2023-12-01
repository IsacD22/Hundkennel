class Hund
{
    //skapar hundarnas stats
    double speed;
    string name;
    double stamina;
    public Hund(string name, double speed)
    {
        Random rand = new Random();
        stamina = rand.Next(1, 11);
        Console.WriteLine("Name: " + name + " Speed: " + speed + " Stamina: " + stamina);
        this.name = name;
        this.speed = speed;
        this.stamina = stamina;
    }

    public string GetName()
    {
        return name; 
    }


    //skriver ut stats på hundarna
    public double Stats()
    {
       Console.WriteLine("Name: " + name + " Speed: " + speed + " Stamina: " + stamina);
       return speed;
    }

    public double calcSpeed()
    {
        return speed;
    }

    public double calcStamina()
    {
        return stamina;
    }

    
}