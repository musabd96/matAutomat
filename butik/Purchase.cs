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
            int cash, output,  fiveHundred, oneHundred, fifty, twenty, ten, five, two, one;
            //List till alla produkter 
            double totalFruit = Order.fruitlist.Sum(item => item.TotalPrice);
            double totalGodis = Order.candylist.Sum(item => item.TotalPrice);
            double totalDrink = Order.drinklist.Sum(item => item.TotalPrice);
            

            //totala priser till alla produkter i kundvagn
            decimal totalProductPrice = (int)(totalFruit + totalGodis + totalDrink);

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

                    //Här använda jag Dictionary till Plånboken 
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

                    //Kunden ska mata in sina sedlar här 
                    Console.Write("\nAnge pengar i automaten här: ");

                    int customerMoney = Convert.ToInt32(Console.ReadLine());

                    Console.Write("Antal sedlar: ");
                    int currentQuantity = Convert.ToInt32(Console.ReadLine());

                    cash = currentQuantity * customerMoney;
                    
                    //Om kunden mata in till räklig pengar eller inte eller om han mata in mer sedlar som  skule finns i sin plånbok.
                    if (wallet[1] < currentQuantity)
                    {
                        Console.Clear();
                        Console.WriteLine("Du har inte {0} sedlar som är {1}kr i plånboken.", currentQuantity, customerMoney);
                        
                        
                    }
                    else
                    {
                        wallet[customerMoney] -= currentQuantity;
                        double change = (int)(cash - totalProductPrice), rem = 0;
                        int customerChange = (int) change;

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
                            Console.Clear();
                            Program.logo();
                            Console.WriteLine("Tack för att du hadlat oss\n" +
                                              "Här är dina växel: " + change + " SEK\n");
                            

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

                            Console.Clear();
                            Program.logo();

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
                                              "\n TOTALT:     {0}", customerChange);


                            Console.WriteLine("\nPress any key to continue...");
                            Console.ReadKey();

                            Console.Clear();
                            Program.logo();
                            receipt();

                            Console.WriteLine("\nMottaget kontant: " + cash +
                                              "\nÅter     kontant: " + customerChange);

                            Console.WriteLine("\nPress any key to continue...");
                            Console.ReadKey();

                            Console.Clear();
                            Program.logo();

                            Console.Write("\n\n1. Beställa mer.\n" +
                                              "2. Huvud meny\n" +
                                              "3. Avsluta programmet\n" +
                                          "\nVälj en alternativ mellam 1 till 3: ");
                            output = Convert.ToInt32(Console.ReadLine());

                            if (output == 1)
                            {
                                Console.Clear();
                                Program.productMenu(args);

                            }
                            else if (output == 2)
                            {
                                Console.Clear();
                                Program.productMenu(args);
                            }
                            else if (output == 3)
                            {
                                Console.Clear();
                                Program.logo();
                                
                                

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


                            break;
                        }
                        else
                        {
                            Console.WriteLine("\nDet räcker inte " + cash + " SEK");
                        }
                        

                    }               
                                        
                }

                Console.Clear();
                Program.logo();



                
                

            }

            Console.WriteLine("\n\n         Din kundvagn är tom");

            Console.Write("\n\n1. Beställa mer.\n" +
                                  "2. Huvud meny\n" +
                                  "3. Avsluta programmet\n" +
                                  "\nVälj en alternativ mellam 1 till 3: ");
            output = Convert.ToInt32(Console.ReadLine());

            if (output == 1)
            {
                Console.Clear();
                Program.productMenu(args);

            }
            else if (output == 2)
            {
                Console.Clear();
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
        
        //kvito 
        public static void receipt()
        {


            double totalFruit = Order.fruitlist.Sum(item => item.TotalPrice);
            double totalGodis = Order.candylist.Sum(item => item.TotalPrice);
            double totalDrink = Order.drinklist.Sum(item => item.TotalPrice);

            decimal totalProductPrice = (int)(totalFruit + totalGodis + totalDrink);           

            decimal total = (int) totalProductPrice;


            Console.Clear();


            //Anroppa logo 
            Program.logo();

            //Kvitto

            Console.WriteLine("                           KVITTO\n" +
                              "----------------------------------------------------");
            Order.fruitList();
            Order.godisList();
            Order.drinkList();

            Console.WriteLine("----------------------------------------------------\n" +
                              "\nTotalt SEK                                      " +
                              totalProductPrice + ";-");



            Console.WriteLine("\n\n\nKöp" +
                              "SEK                      " + totalProductPrice + "\n" +
                              "GODKÄNT");

            Cart.remove();

            
            

            

            
        }



        
 

    }
}
