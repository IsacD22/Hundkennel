
class Program
{

    public static void Main(String[] args)
    {
        //deklariation av variabler och listor
        List<Hund> dogList = new List<Hund>();
        Console.WriteLine("Hello and Welcome, press any buttom to get a dog");
        Console.ReadLine();
        Console.WriteLine("*****************");

        string dogName;
        string dogName2;
        string dogName3;
        double dogSpeed;
        double dogSpeed2;
        double dogSpeed3;
        string winnerName;
        string text2;
        string Continue;
        string save;
        bool addDog = true;
        double stats0;
        double stats1;
        double stats2 = 0;
        
        

        while (true)
        {
            while(dogList.Count < 3 && addDog)
            {

                // skapar hund 1
                while (true)
                {
                    Console.WriteLine("What do you want to name your dog?");
                    dogName = Console.ReadLine();

                    if (dogName == "")
                    {
                        Console.WriteLine("You need to write the name of your dog");
                    }
                    else
                    {
                        break;
                    }
                }

                //frågar hur snabb första hunden är
                while (true)
                    {
                        try
                        {
                            Console.WriteLine("How fast is your dog? (1 - 10)");
                            dogSpeed = Convert.ToDouble(Console.ReadLine());
                            if (dogSpeed < 1 || dogSpeed > 10)
                            {
                                Console.WriteLine("The speed of your dog must be between 1 and 10");
                            }
                            else
                            {
                                Hund hund = new Hund(dogName, dogSpeed);
                                dogList.Add(hund);
                                Console.WriteLine("*****************");
                                break;
                            }

                        }
                        catch (Exception a)
                        {
                            Console.WriteLine(a.Message);
                        }
                    }
                


                //skapar hund 2
                while (true)
                {
                    Console.WriteLine("What do you want to name your second dog?");
                    dogName2 = Console.ReadLine();
                    if (dogName2 == "")
                    {
                        Console.WriteLine("You need to write the name of your dog");
                    }
                    else
                    {
                        break;
                    }
                }

                //kollar hur snabb andra hunden är
                while (true)
                {
                    try
                    {
                        Console.WriteLine("How fast is your second dog? (1 - 10)");
                        dogSpeed2 = Convert.ToDouble(Console.ReadLine());
                        if (dogSpeed2 < 1 || dogSpeed2 > 10)
                        {
                            Console.WriteLine("The speed of your dog must be between 1 and 10");
                        }
                        else
                        {
                            Hund hund2 = new Hund(dogName2, dogSpeed2);
                            dogList.Add(hund2);
                            Console.WriteLine("*****************");
                            break;
                        }
                        

                    }
                    catch (Exception a)
                    {
                        Console.WriteLine(a.Message);
                    }
                }
                
                //skapar eventuellt hund 3
                while (addDog)
                {
                    try
                    {
                        Console.WriteLine("Do you want to add another dog? [y/n]");
                        text2 = Console.ReadLine();
                        Console.WriteLine("*****************");

                        switch (text2)
                        {
                            case "y":
                                while (true)
                                {
                                    Console.WriteLine("What do you want to name your third dog?");
                                    dogName3 = Console.ReadLine();
                                    if(dogName3 == "")
                                    {
                                        Console.WriteLine("You need to write the name of your dog");
                                    }
                                    else
                                    {
                                        break;
                                    }
                                }
                                //kollar hu snabb tredje hunden är
                                while (true)
                                {
                                    try
                                    {
                                        Console.WriteLine("How fast is your dog? (1 - 10)");
                                        dogSpeed3 = Convert.ToDouble(Console.ReadLine());
                                        if (dogSpeed3 < 1 || dogSpeed3 > 10)
                                        {
                                            Console.WriteLine("The speed of your dog must be between 1 and 10");
                                        }
                                        else
                                        {
                                            Hund hund3 = new Hund(dogName3, dogSpeed3);
                                            dogList.Add(hund3);
                                            addDog = false;
                                            Console.WriteLine("*****************");
                                            break;
                                        }
                                        

                                    }
                                    catch (Exception a)
                                    {
                                        Console.WriteLine(a.Message);
                                    }
                                }
                                
                                
                                
                                break;
                            case "n":
                                addDog = false;
                                break;
                            default:
                                Console.WriteLine("Try to press y or n");
                                break;

                        }

                    }
                    catch (Exception a)
                    {
                        Console.WriteLine(a.Message);
                    }
                }
            }
                


            //skriver ut hundarnas stats
            Console.WriteLine("The competitors are:");
            for (int i = 0; i < dogList.Count; i++)
            {
                dogList[i].Stats();
            }
            Console.WriteLine("*****************");
            Console.WriteLine("Press a button to start the race");
            Console.ReadLine();

            //räknar ut hundarnas totala stats
            stats0 = dogList[0].calcStamina() + dogList[0].calcSpeed();
            stats1 = dogList[1].calcStamina() + dogList[1].calcSpeed();

            if(dogList.Count == 3)
            {
                stats2 = dogList[2].calcStamina() + dogList[2].calcSpeed();
            }

            //jämför hundarnas stats
            
            if (dogList.Count == 2)
            {
                if (stats0 > stats1)
                {
                    winnerName = dogList[0].GetName();
                    Console.WriteLine("The winner is: " + winnerName);

                }
                else if (stats0 < stats1)
                {
                    winnerName = dogList[1].GetName();
                    Console.WriteLine("The winner is: " + winnerName);
                }
                else
                {
                    Console.WriteLine("Draw!");
                }
            }
            else
            {
                //jämförelse delen där som sker om det är tre hundar som tävlar

                if (stats0 > stats1 && stats0 > stats2)
                {
                    winnerName = dogList[0].GetName();
                    Console.WriteLine("The winner is: " + winnerName);

                }
                else if (stats0 < stats1 && stats1 > stats2)
                {
                    winnerName = dogList[1].GetName();
                    Console.WriteLine("The winner is: " + winnerName);
                }
                else if (stats1 < stats2 && stats0 < stats2)
                {
                    winnerName = dogList[2].GetName();
                    Console.WriteLine("The winner is: " + winnerName);
                }
                else if (stats1 == stats2 && stats0 == stats2)
                {
                    Console.WriteLine("Draw!");
                }
                else if(stats1 == stats2 && stats1 >= stats0)
                {
                    Console.WriteLine("Draw between " + dogList[1].GetName() + " and " + dogList[2].GetName());
                }
                else if (stats1 == stats0 && stats0 >= stats2)
                {
                    Console.WriteLine("Draw between " + dogList[0].GetName() + " and " + dogList[1].GetName());
                }
                else if (stats0 == stats2 && stats2 >= stats1)
                {
                    Console.WriteLine("Draw between " + dogList[0].GetName() + " and " + dogList[2].GetName());
                }
                Console.WriteLine("*****************");
            
            }
            //kollar om användaren vill fortsätta
            try
            {
                Console.WriteLine("Do you want to continue? [y/n]");
                Continue = Console.ReadLine();
                if (Continue == "y")
                {
                    try
                    {
                        //kollar om användaren vill spara hundarna
                        Console.WriteLine("Do you want to save your dogs? [y/n]");
                        save = Console.ReadLine();
                        if (save == "n")
                        {
                            dogList.Clear();
                            addDog = true;
                        }else if(save == "y")
                        {
                            try
                            {
                                //kollar om användaren vill lägga till en hund om det bara finns två hundar
                                while (true)
                                {
                                    Console.WriteLine("Do you want to add another dog? [y/n]");
                                    text2 = Console.ReadLine();
                                    if (text2 != "n" && text2 != "y")
                                    {
                                        Console.WriteLine("Type y or n");
                                    }
                                    else
                                    {
                                        Console.WriteLine("*****************");
                                        break;
                                    }
                                    
                                }

                                switch (text2)
                                {
                                    case "y":
                                        if (dogList.Count == 3)
                                        {
                                            Console.WriteLine("You can´t add another dog");
                                            Console.WriteLine("*****************");
                                        }
                                        else
                                        {
                                            while (true)
                                            {
                                                //skapar hund tre om användaren vill det och om det bara finns två hundar
                                                Console.WriteLine("What do you want to name your third dog?");
                                                dogName3 = Console.ReadLine();
                                                if(dogName3 == "")
                                                {
                                                    Console.WriteLine("You need to write the name of your dog");
                                                }
                                                else
                                                {
                                                    break;
                                                }
                                            }
                                            
                                            while (true)
                                            {
                                                try
                                                {
                                                    //frågar hur snabb den tredjehunden är
                                                    Console.WriteLine("How fast is your dog? (1 - 10)");
                                                    dogSpeed3 = Convert.ToDouble(Console.ReadLine());
                                                    if (dogSpeed3 < 1 || dogSpeed3 > 10)
                                                    {
                                                        Console.WriteLine("The speed of your dog must be between 1 and 10");
                                                    }
                                                    else
                                                    {
                                                        Hund hund3 = new Hund(dogName3, dogSpeed3);
                                                        dogList.Add(hund3);
                                                        addDog = false;
                                                        Console.WriteLine("*****************");
                                                        break;
                                                    }

                                                }
                                                catch (Exception a)
                                                {
                                                    Console.WriteLine(a.Message);
                                                }
                                            }
                                            
                                        }

                                        break;
                                    case "n":
                                        addDog = false;
                                        break;
                                    default:
                                        Console.WriteLine("Try to press y or n");
                                        break;

                                }

                            }
                            catch (Exception a)
                            {
                                Console.WriteLine(a.Message);
                            }

                        }

                    }
                    catch (Exception a)
                    {
                        Console.WriteLine(a.Message);
                    }
                }
                else if (Continue == "n")
                {
                    break;
                }

            }
            catch (Exception a)
            {
                Console.WriteLine(a.Message);
            }

        }

    } 
}
