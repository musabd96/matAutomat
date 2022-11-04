using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace butik
{
    internal class Program
    {


        static void Main(string[] args)
        {
            int Choice;

            
            //Hälsing meddelande till kunden
            

            // Huvudmenyn
            while (true)
            {
                Console.Clear();
                Console.WriteLine("-------------------------------------------------" +
                    "\n|          Välkommen till MUAB Supermarket      |\n"+
                    "-------------------------------------------------");

                Console.WriteLine("\n               1. Sätt in automater pengar" +
                                  "\n               2. Produkter" +
                                  "\n               3. Varukorgen" +
                                  "\n               4. Avsluta programmet");

                Console.Write("\nVälj en alternativ mellam 1 till 4: ");





                try
                {
                    Choice = Convert.ToInt32(Console.ReadLine());

                    //Anropa Product Menu klass

                    if (Choice == 1)
                    {
                        Console.Clear ();
                        logo();
                        Wallet.wallet();
                    }
                    else if (Choice == 2)
                    {
                        Console.Clear();

                        productMenu(args);
                        Console.Clear();
                    }

                    //Anropa Kungvagn klass
                    else if (Choice == 3)
                    {
                        Console.Clear();
                        Cart.printCart(args);
                        Console.Clear();
                    }

                    //Avsluta programmet
                    else if (Choice == 4)
                    {
                        Console.Clear();
                        Console.WriteLine("\nTack för att du har besökt oss :)\n\n\n");
                        Environment.Exit(0);

                    }
                    else
                    {
                        Console.Clear();

                        logo();

                        Console.WriteLine("                    OBS!!!\n" +
                                          "----------------------------------------------\n" +
                                          "Var snäll välja em alternativ mellan 1 till 4!");

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

        public static void productMenu(string[] args)
        {
            // Huvud  Menyn

            int Choice;


            
            logo();
            
            while (true)
            {

                
                 

                Console.WriteLine(
                    "\n          1. Frukter \n" +
                    "          2. Godis \n" +
                    "          3. Dricker \n" +
                    "          4. varukorgen \n" +
                    "          5. Betaling \n" +
                    "          6. Tillbaka hemma\n ");
                Console.Write("\nVälj en alternativ mellam 1 till 6: ");

                

                try
                {

                    Choice = Convert.ToInt32(Console.ReadLine());

                    //Anropa Fruit klass
                    if (Choice == 1)
                    {
                        Console.Clear();

                        Fruit.Menu(args);
                         
                        

                    }

                   
                    else if (Choice == 2)
                    {
                        Console.Clear();
                        Candy.Menu(args);

                    }
                    else if (Choice == 3)
                    {
                        Drink.Menu(args);
                    }
                    else if (Choice == 4)
                    {
                        Cart.printCart(args);
                    }

                    else if (Choice == 5)
                    {
                        Purchase.Cost();

                    }
                    //Anropa Main progrom klass
                    else if (Choice == 6)
                    {
                        Console.Clear();
                        
                        Main(args);
                        
                        break;

                    }
                    else
                    {
                        Console.Clear();
                        Program.logo();

                        Console.WriteLine("                    OBS!!!\n" +
                                          "----------------------------------------------\n" +
                                          "Var snäll välja en alternativ mellan 1 till 6!");

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
                "------------------------------------------------");
            double balance = Wallet.automaticMachine.Sum();

            //visa saldo i automaten
            Console.WriteLine("                                 saldo är: " + balance + " SEK");


        }

        


    }
}