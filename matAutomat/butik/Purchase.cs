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
        private static string[] args;

        public static void  Cost()
        {
            int cash;
            
            double totalFruit = Order.fruitlist.Sum(item => item.fruitTotalPrice);
            double totalGodis = Order.godislist.Sum(item => item.godisTotalPrice);
            double totalDrink = Order.drinklist.Sum(item => item.drinkTotalPrice);

            decimal totalProductPrice = (int)(totalFruit + totalGodis + totalDrink);

            Console.Clear();


            //Anroppa logo 
            Program.logo();

            //Kvitto

            
            
            if (totalProductPrice != 0)
            {

                while (true)
                {
                    Console.WriteLine("\nDu ska betala " + totalProductPrice  + " SEK");


                    Dictionary<int, int> wallet = new Dictionary<int, int>();
                    wallet.Add(500, 10);
                    wallet.Add(100, 10);
                    wallet.Add(50, 10);
                    wallet.Add(20, 10);
                    wallet.Add(10, 10);
                    wallet.Add( 5, 10);
                    wallet.Add( 2, 10);
                    wallet.Add( 1, 10);


                    Console.WriteLine("\n     PLÅNBOK \n" +
                                      "------------------\n");

                    foreach (var currency in wallet)
                    {
                        Console.WriteLine("{0} ----------> {1}", currency.Key, currency.Value);

                    }


                    Console.Write("\nMata in sedlar här: ");
                    int customerMoney = Convert.ToInt32(Console.ReadLine());

                    Console.Write("Antal sedlar: ");
                    int currentQuantity = Convert.ToInt32(Console.ReadLine());

                    cash = currentQuantity * customerMoney;
                    
                    if (wallet[1] < currentQuantity)
                    {
                        Console.Clear();
                        Console.WriteLine("Du har inte {0} sedlar som är {1}kr i plånboken.", currentQuantity, customerMoney);
                        
                        
                    }
                    else
                    {
                        wallet[customerMoney] -= currentQuantity;
                        double change = (int)(cash - totalProductPrice), rem = 0;


                        Console.Clear();


                        //Anroppa logo 
                        Program.logo();


                        if (totalProductPrice == cash)


                        {
                            Console.WriteLine("Tack för att du hadlat oss\n" +
                                "\nTryck på valfri tangent för att fortsätta... ");
                            Console.ReadKey();
                            Console.Clear();
                            break;
                        }
                        else if (totalProductPrice <= cash)
                        {
                            Console.WriteLine("Tack för att du hadlat oss\n" +
                                              "Här är dina växel: " + change + " SEK\n");

                            Console.WriteLine("\n----------------");
                            Console.WriteLine("500: " + (int)(change / 500));
                            rem = change % 500;
                            Console.WriteLine("100: " + (int)(rem / 100));
                            rem = change % 100;
                            Console.WriteLine("50: " + (int)(rem / 50));
                            rem = change % 50;
                            Console.WriteLine("20: " + (int)(rem / 20));
                            rem = change % 20;
                            Console.WriteLine("10: " + (int)(rem / 10));
                            rem = change % 10;
                            Console.WriteLine("5: " + (int)(rem / 5));
                            rem = change % 5;
                            Console.WriteLine("2: " + (int)(rem / 2));
                            rem = change % 2;
                            Console.WriteLine("1: " + (int)(rem / 1));
                            rem = change % 1;
                            Console.WriteLine("----------------");

                            Console.WriteLine("\nPress any key to continue to Receipt");
                            Console.ReadKey();

                            break;
                        }
                        else
                        {
                            Console.WriteLine("\nDet räcker inte " + cash + " SEK");
                        }
                        

                    }               
                                        
                }
                
                receipt();

            }

            Console.WriteLine("\n\n         Din kundvagn är tom");

            Console.WriteLine("\n\n1. Beställa mer.\n" +
                                  "2. Huvud meny\n" +
                                  "3. Avsluta programmet\n" +
                                  "\nVälj en alternativ mellam 1 till 3");
            int output = Convert.ToInt32(Console.ReadLine());

            if (output == 1)
            {
                Console.Clear();
                Program.productMenu(args);

            }
            else if (output == 2)
            {
                Program.productMenu(args);
            }
            else if (output == 3)
            {
                Console.WriteLine("\nTack för att du har besökt oss :)\n\n\n");
                Environment.Exit(0);

            }
            else
            {
                Console.Clear();
                //Anroppa logo 
                Program.logo();

                Console.WriteLine("                    OBS!!!\n" +
                                  "----------------------------------------------\n" +
                                  "Var snäll välja em alternativ mellan 1 till 5!");
            }         

        }
        
        public static void receipt()
        {


            double totalFruit = Order.fruitlist.Sum(item => item.fruitTotalPrice);
            double totalGodis = Order.godislist.Sum(item => item.godisTotalPrice);
            double totalDrink = Order.drinklist.Sum(item => item.drinkTotalPrice);

            decimal totalProductPrice = (int)(totalFruit + totalGodis + totalDrink);           

            decimal total = (int) totalProductPrice;


            Console.Clear();


            //Anroppa logo 
            Program.logo();

            //Kvitto

            Console.WriteLine("                    KVITTO\n" +
                "-----------------------------------------------------");
            Order.fruitList();
            Order.godisList();

            Console.WriteLine("-----------------------------------------------------\n" +
                              "\nTotalt SEK                                     " + 
                              totalProductPrice  + ";-");



            Console.WriteLine("Köp" +
                              "SEK                      " + totalProductPrice + "\n" +
                              "GODKÄNT");           
           
            Console.WriteLine("\nTack för att du har besökt oss :)\n\n\n");
            Environment.Exit(0);
        }


        
 

    }
}
