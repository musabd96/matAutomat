namespace matAutomat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int Choice;

            Console.Clear();
            //Hälsing meddelande till kunden
            Console.WriteLine("-------------------------------------------------" +
                "\n|          Välkommen till MUAB Supermarket      |\n" +
                "-------------------------------------------------\n");

            //Huvudmenyn

            while (true)
            {


                //Anroppa logo 

                Console.WriteLine(
                    "\n1. Frukter \n" +
                    "2. Godis \n" +
                    "3. Dricker \n" +
                    "4. varukorgen \n" +
                    "5. Betaling \n" +
                    "6. Avsluta programmet");
                Console.Write("\nVälj en alternativ mellam 1 till 4: ");

                //var cart = new Cart();

                try
                {

                    Choice = Convert.ToInt32(Console.ReadLine());

                    //Anropa Fruit klass
                    if (Choice == 1)
                    {
                        Console.Clear();

                        //Fruit.Menu(args);



                    }

                    //Anropa Drink klass
                    else if (Choice == 2)
                    {
                        Console.Clear();
                        //Godis.Menu(args);

                    }
                    else if (Choice == 3)
                    {
                        //Drink.Menu(args);
                    }
                    else if (Choice == 4)
                    {
                        //Cart.printCart(args);
                    }

                    else if (Choice == 5)
                    {
                        //Purchase.Cost();

                    }
                    //Avsluta programmet
                    else if (Choice == 6)
                    {
                        Console.Clear();
                        Console.WriteLine("\nTack för att du har besökt oss :)\n\n\n");
                        Environment.Exit(0);

                    }
                    else
                    {
                        Console.Clear();
                        Program.logo();

                        Console.WriteLine("                    OBS!!!\n" +
                                          "----------------------------------------------\n" +
                                          "Var snäll välja em alternativ mellan 1 till 5!");

                    }
                }
                catch
                {
                    Console.Clear();
                    //Anroppa logo 
                    Program.logo();

                    Console.WriteLine("                    OBS!!!\n" +
                                      "----------------------------------------------\n" +
                                      "Var snäll välja em alternativ mellan 1 till 3!");
                }
            }

        }

        //LOGO
        public static void logo()
        {
            //LOGO
            Console.WriteLine("------------------------------------------------" +
                "\n|              MUAB Supermarket                |\n" +
                "------------------------------------------------\n");
        }
    }
}