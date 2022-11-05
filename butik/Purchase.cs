using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace butik
{
    internal class Purchase
    {
        //private static string[] args;

        public static void  Cost()
        {
            Fruit fruit = new Fruit();
            Candy candy = new Candy();
            Drink drink = new Drink();

            int output,  fiveHundred, oneHundred, fifty, twenty, ten, five, two, one;
            
            

            //totala priser till alla produkter i kundvagn
            decimal totalProductPrice = (int)(Cart.totalFruit + Cart.totalCandy + Cart.totalDrink);

            Console.Clear();


            //Anroppa logo 
            Program.logo();

            //Kvitto

            
            //Om totala produkt priser är 0 eller if jag änvander här if sats att kolla om kundvagn är tömt eller inte
            
            if (totalProductPrice != 0)
            {

                while (true)
                {
                    Console.WriteLine("\nDu ska betala " + totalProductPrice  + " SEK");

                    

                    

                    double customerMoney = Wallet.automaticMachine.Sum();

                    decimal cash = (int)customerMoney;
                    int change = (int)(cash - totalProductPrice);
                    int ChangeCurrency = change;
                    
                    try
                    {
                            Wallet.remove();
                        if (totalProductPrice == cash)


                        {
                            

                            Console.Clear();
                            Program.logo();
                            Console.WriteLine("\n     Kunden har köpt");
                            Console.WriteLine("-------------------------------");
                            fruit.buy();
                            candy.buy();
                            drink.buy();
                            Console.WriteLine("-------------------------------");

                            Console.WriteLine("\n\nPress any key to continue...");
                            Console.ReadKey();

                            Console.Clear();
                            Program.logo();

                            receipt();

                            Console.WriteLine("\nMottaget kontant: " + cash +
                                                "\nÅter     kontant: " + ChangeCurrency);

                            Console.WriteLine("\n\nTack för att du hadlat oss\n" +
                                "\nPress any key to continue... ");
                            Console.ReadKey();
                            Console.Clear();
                            Program.logo();

                            Console.WriteLine("\n     Kunden äter/dricker");
                            Console.WriteLine("-------------------------------");

                            fruit.use();
                            candy.use();
                            drink.use();

                            Console.WriteLine("\nPress any key to continue...");
                            Console.ReadKey();

                            Environment.Exit(0);
                        }
                        else if (totalProductPrice <= cash)
                        {

                            Console.Clear();
                            Program.logo();
                            Console.WriteLine("Tack för att du hadlat oss\n" +
                                                "Här är dina växel: " + change + " SEK\n");
                            //Växel tillbakas till kunden avrundad upp 
                            //Betalas ut största valör som finns 
                            fiveHundred = (int)change / 500;
                            change = change - (fiveHundred * 500);
                            oneHundred = (int)change / 100;
                            change = change - (oneHundred * 100);
                            fifty = (int)change / 50;
                            change = change - (fifty * 50);
                            twenty = (int)change / 20;
                            change = change - (twenty * 20);
                            ten = (int)change / 10;
                            change = change - (ten * 10);
                            five = (int)change / 5;
                            change = change - (five * 5);
                            two = (int)change / 2;
                            change = change - (two * 2);
                            one = (int)change / 1;
                            change = change - (one * 1);

                            

                            Console.WriteLine("\n     Här är dina Växel. Varsågod! " +
                                                "\n----------------------------------" +
                                                "\n          500: " + fiveHundred +
                                                "\n          100: " + oneHundred +
                                                "\n           50: " + fifty +
                                                "\n           20: " + twenty +
                                                "\n           10: " + ten +
                                                "\n            5: " + five +
                                                "\n            2: " + two +
                                                "\n            1: " + one +
                                                "\n----------------------------------" +
                                                "\n TOTALT:     {0}", ChangeCurrency);


                            Console.WriteLine("\n\nPress any key to continue...");
                            Console.ReadKey();

                            Console.Clear();
                            Program.logo();
                            Console.WriteLine("\n     Kunden har köpt");
                            Console.WriteLine("-------------------------------");
                            fruit.buy();
                            candy.buy();
                            drink.buy();
                            Console.WriteLine("-------------------------------");

                            Console.WriteLine("\n\nPress any key to continue...");
                            Console.ReadKey();

                            Console.Clear();
                            Program.logo();
                            receipt();

                            Console.WriteLine("\nMottaget kontant: " + cash +
                                                "\nÅter     kontant: " + ChangeCurrency);

                            Console.WriteLine("\n\nTack för att du hadlat oss\n" +
                                "\nPress any key to continue... ");
                           
                            Console.ReadKey();


                            Console.Clear();
                            Program.logo();

                            Console.WriteLine("\n     Kunden äter/dricker");
                            Console.WriteLine("-------------------------------");

                            fruit.use();
                            candy.use();
                            drink.use();

                            Console.WriteLine("\nPress any key to continue...");
                            Console.ReadKey();



                            Environment.Exit(0);

                        }
                        else
                        {
                            Console.WriteLine("\nAutomaten finns inte tillräckligt med pengar." +
                                              "\nSaldo är: " + cash + " SEK");

                            Wallet.wallet();

                        }
                    }
                    catch
                    {
                        Console.Clear();
                        Program.logo();
                        Console.WriteLine("Felaktigt skrivet!!");
                    }

                                 
                                        
                }                                             
             
            }
            else
            {
                Console.Clear();
                Program.logo();
                Console.WriteLine("\n\n          Din kundvagn är tom");
                Console.Write("\n\n\nPress any key to continue...");
                Console.ReadKey();
                Console.Clear();

            }
            Console.Clear ();
            Program.logo();
            

            return;
        }
        
        //kvito 
        public static void receipt()
        {


            decimal totalProductPrice = (int)(Cart.totalFruit + Cart.totalCandy + Cart.totalDrink);           
            


            


            Console.Clear();


            //Anroppa logo 
            Program.logo();

            //Kvitto

            Console.WriteLine("\n\n                       KVITTO\n" +
                              "------------------------------------------------");
            Order.fruitList();
            Order.candyList();
            Order.drinkList();

            Console.WriteLine("------------------------------------------------\n" +
                              "\nTotalt SEK                                 " +
                              totalProductPrice + ";-");
            


            Console.WriteLine("\n\n\nKöp" +
                              "SEK                      " + totalProductPrice + "\n" +
                              "GODKÄNT");
           
        }

    }
}
