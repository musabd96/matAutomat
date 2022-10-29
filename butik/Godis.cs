using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace butik
{
    internal class Godis
    {
        public string godisName { get; set; }

        public int godisPrice { get; set; }

        public int godisQuantity { get; set; }

        public int godisTotalPrice { get; set; }

        public Godis(string name, int price)
        {
            godisName = name;
            godisPrice = price;
            godisTotalPrice = price;


        }

        public override string ToString()
        {
            return godisName + " " + godisPrice + " " + godisQuantity + " " + godisTotalPrice;
        }


        //Frukt menyn

        public static void Menu(string[] args)
        {
            while (true)
            {

                int OrderGodis;
                int OrderQuantity;

                //beställningar 
                string order1;
                string order2;
                string order3;
                string order4;
                string order5;
                string order6;

                while (true)
                {
                    Console.Clear();

                    //Anroppa logo 
                    Program.logo();

                    //Produkt display

                    string[] godisName = { "Kex",
                                           "Snickers", 
                                           "Twix", 
                                           "Polly", 
                                           "Haribo Nappar", 
                                           "Marabou" };
                    int[] godisCost = { 9, 9, 10, 25, 15, 24 };

                    Console.WriteLine("\nProdukter              kostnad");
                    Console.WriteLine("--------------------------------\n");

                    for (int i = 0; i < godisName.Length; i++)
                    {
                        Console.WriteLine(
                            "{0}. {1,-20} {2}kr/st\n", 
                            i + 1, godisName[i], godisCost[i]);
                    }



                    //Produkter och kostnad

                    Godis godis1 = new Godis("Kex", 9);
                    Godis godis2 = new Godis("Snickers", 9);
                    Godis godis3 = new Godis("Twix", 10);
                    Godis godis4 = new Godis("Polly", 25);
                    Godis godis5 = new Godis("Haribo Nappar", 15);
                    Godis godis6 = new Godis("Marabou", 24);


                    try
                    {
                        Console.WriteLine("Välj en produkt att lägga i varukorgen: ");

                        OrderGodis = Convert.ToInt32(Console.ReadLine());

                        if (OrderGodis == 1)
                        {

                            Console.Clear();
                            //Anroppa logo 
                            Program.logo();

                            Console.WriteLine("Du har valt " + "---------->" + godis1.godisName +
                                " " + godis1.godisPrice + "kr/st");

                            Console.WriteLine("\nHur många ska du ha:");

                            OrderQuantity = Convert.ToInt32(Console.ReadLine());

                            godis1.godisTotalPrice = OrderQuantity * godis1.godisTotalPrice;
                            godis1.godisQuantity = OrderQuantity;


                            order1 = godis1.godisName + "  " + godis1.godisPrice + "kr * " +
                                godis1.godisQuantity + "st  " + godis1.godisTotalPrice + ";-";

                            //Lägg till orderlist i Order Klass

                            Order.godislist.Add(godis1);

                            Console.Clear();

                            //Anroppa logo 
                            Program.logo();

                            Console.WriteLine("Tack för att du handlat oss! " +
                                "\nProdukten har lagt till i kundvagnen\n" + "\n" + order1);

                            Console.WriteLine("\nTryck på valfri tangent för att fortsätta...");

                            Console.ReadKey();
                            
                            Console.Clear();
                            Program.logo();

                            break;

                        }
                        else if (OrderGodis == 2)
                        {
                            Console.Clear();

                            //Anroppa logo 
                            Program.logo();

                            Console.WriteLine("Du har valt " + "---------->" + godis2.godisName +
                                " " + godis2.godisPrice + "kr");

                            Console.WriteLine("Hur Många ska du ha:");

                            OrderQuantity = Convert.ToInt32(Console.ReadLine());

                            godis2.godisTotalPrice = OrderQuantity * godis2.godisTotalPrice;
                            godis2.godisQuantity = OrderQuantity;

                            order2 = godis2.godisName + "  " + godis2.godisPrice + "kr * " +
                                godis2.godisQuantity + "st  " + godis2.godisTotalPrice + ";-";

                            //Lägg till orderlist i Order Klass
                            Order.godislist.Add(godis2);

                            Console.Clear();

                            //Anroppa logo 
                            Program.logo();

                            Console.WriteLine("Tack för att du handlat oss! " +
                                "\nProdukten har lagt till i kundvagnen\n" + "\n" + order2);

                            Console.WriteLine("\nTryck på valfri tangent för att fortsätta...");

                            Console.ReadKey();
                            Console.Clear();
                            Program.logo();
                            break;

                        }

                        else if (OrderGodis == 3)
                        {
                            Console.Clear();
                            //Anroppa logo 
                            Program.logo();

                            Console.WriteLine("Du har valt " + "---------->" + godis3.godisName +
                                " " + godis3.godisPrice + "kr");

                            Console.WriteLine("Hur många ska du ha:");

                            OrderQuantity = Convert.ToInt32(Console.ReadLine());

                            godis3.godisTotalPrice = OrderQuantity * godis3.godisTotalPrice;
                            godis3.godisQuantity = OrderQuantity; ;

                            order3 = godis3.godisName + "  " + godis3.godisPrice + "kr * " +
                                godis3.godisQuantity + "st  " + godis3.godisTotalPrice + ";-";

                            //Lägg till orderlist i Order Klass
                            Order.godislist.Add(godis3);

                            Console.Clear();

                            //Anroppa logo 
                            Program.logo();

                            Console.WriteLine("Tack för att du handlat oss! " +
                                "\nProdukten har lagt till i kundvagnen\n" + "\n" + order3);

                            Console.WriteLine("\nTryck på valfri tangent för att fortsätta...");

                            Console.ReadKey();
                            Console.Clear();
                            Program.logo();

                            break;

                        }
                        else if (OrderGodis == 4)
                        {
                            Console.Clear();

                            //Anroppa logo 
                            Program.logo();

                            Console.WriteLine("Du har valt " + "---------->" + godis4.godisName +
                                " " + godis4.godisPrice + "kr/st");

                            Console.WriteLine("\nHur många ska du ha:");

                            OrderQuantity = Convert.ToInt32(Console.ReadLine());
                            godis4.godisTotalPrice = OrderQuantity * godis4.godisTotalPrice;
                            godis4.godisQuantity = OrderQuantity; ;

                            order4 = godis4.godisName + "  " + godis4.godisPrice + "kr * " +
                                godis4.godisQuantity + "st  " + godis4.godisTotalPrice + ";-";



                            //Lägg till orderlist i Order Klass
                            Order.godislist.Add(godis4);

                            Console.Clear();

                            //Anroppa logo 
                            Program.logo();

                            Console.WriteLine("Tack för att du handlat oss! " +
                                "\nProdukten har lagt till i kundvagnen\n" + "\n" + order4);

                            Console.WriteLine("\nTryck på valfri tangent för att fortsätta...");

                            Console.ReadKey();
                            Console.Clear();
                            Program.logo();

                            break;

                        }
                        else if (OrderGodis == 5)
                        {
                            Console.Clear();

                            //Anroppa logo 
                            Program.logo();

                            Console.WriteLine("Du har valt " + "---------->" + godis5.godisName +
                                " " + godis5.godisPrice + "kr");


                            Console.WriteLine("\nHur många ska du ha:");

                            OrderQuantity = Convert.ToInt32(Console.ReadLine());

                            godis5.godisTotalPrice = OrderQuantity * godis5.godisTotalPrice;
                            godis5.godisQuantity = OrderQuantity; ;

                            order5 = godis5.godisName + "  " + godis1.godisPrice + "kr * " +
                                godis5.godisQuantity + "st  " + godis5.godisTotalPrice + ";-";

                            //Lägg till orderlist i Order Klass
                            Order.godislist.Add(godis5);

                            Console.Clear();

                            //Anroppa logo 
                            Program.logo();

                            Console.WriteLine("Tack för att du handlat oss! " +
                                "\nProdukten har lagt till i kundvagnen\n" + "\n" + order5);

                            Console.WriteLine("\nTryck på valfri tangent för att fortsätta...");

                            Console.ReadKey();
                            Console.Clear();
                            Program.logo();

                            break;

                        }
                        else if (OrderGodis == 6)
                        {

                            
                            Console.Clear();

                            //Anroppa logo 
                            Program.logo();
                            Console.WriteLine("Du har valt " + "---------->" + godis6.godisName +
                                " " + godis6.godisPrice + "kr");

                            

                            Console.WriteLine("\nHur många ska du ha:");

                            OrderQuantity = Convert.ToInt32(Console.ReadLine());

                            godis6.godisTotalPrice = OrderQuantity * godis6.godisTotalPrice;
                            godis6.godisQuantity = OrderQuantity; ;

                            order6 = godis5.godisName + "  " + godis6.godisPrice + "kr * " +
                                godis6.godisQuantity + "st  " + godis6.godisTotalPrice + ";-";



                            //Lägg till orderlist i Order Klass
                            Order.godislist.Add(godis6); ;
                            Console.Clear();

                            //Anroppa logo 
                            Program.logo();

                            Console.WriteLine("Tack för att du handlat oss! " +
                                "\nProdukten har lagt till i kundvagnen\n" + "\n" + order6);

                            Console.WriteLine("\nTryck på valfri tangent för att fortsätta...");

                            Console.ReadKey();
                            Console.Clear();
                            Program.logo();

                            break;

                        }
                        else
                        {
                            Console.Clear();
                            //Anroppa logo 
                            Program.logo();

                            Console.WriteLine("                    OBS!!!\n" +
                                              "----------------------------------------------\n" +
                                              "Var snäll välja em alternativ mellan 1 till 6!");

                        }

                    }
                    catch
                    {
                        Console.Clear();
                        //Anroppa logo 
                        Program.logo();

                        Console.WriteLine("                    OBS!!!\n" +
                                          "----------------------------------------------\n" +
                                          "Var snäll välja em alternativ mellan 1 till 6!");
                    }




                }
                
                break;

            }
        }
    }
}
