using matAutomat;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace butik
{
    internal class Drink
    {
        public string drinkName { get; set; }

        public int drinkPrice { get; set; }

        public int drinkQuantity { get; set; }

        public int drinkTotalPrice { get; set; }

        public Drink(string name, int price)
        {
            drinkName = name;
            drinkPrice = price;
            drinkTotalPrice = price;


        }

        public override string ToString()
        {
            return drinkName + " " + drinkPrice + " " + drinkQuantity + " " + drinkTotalPrice;
        }


        //Frukt menyn

        public static void Menu(string[] args)
        {
            while (true)
            {

                int DrinkFruit;
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

                    string[] drinkName = { "Coca Cola", "Fanta", "Nocco", "Sprite", "Red bull", "Pepsi" };
                    int[] drinkCost = { 12, 13, 25, 15, 23, 14 };

                    Console.WriteLine("\nProdukter              kostnad");
                    Console.WriteLine("--------------------------------\n");

                    for (int i = 0; i < drinkName.Length; i++)
                    {
                        Console.WriteLine("{0}. {1} -------------> {2}kr/kg\n", i + 1, drinkName[i], drinkCost[i]);
                    }



                    //Produkter och kostnad

                    Drink drink1 = new Drink("Coca Cola", 12);
                    Drink drink2 = new Drink("Fanta", 13);
                    Drink drink3 = new Drink("Nocco", 25);
                    Drink drink4 = new Drink("Sprite", 15);
                    Drink drink5 = new Drink("Red bull", 23);
                    Drink drink6 = new Drink("Pepsi", 14);





                    try
                    {
                        Console.WriteLine("Välj en produkt att lägga i varukorgen: ");

                        DrinkFruit = Convert.ToInt32(Console.ReadLine());


                        if (DrinkFruit == 1)
                        {

                            Console.Clear();
                            //Anroppa logo 
                            Program.logo();

                            Console.WriteLine("Du har valt " + "---------->" + drink1.drinkName +
                                " " + drink1.drinkPrice + "kr/kg");


                            Console.WriteLine("\nHur många ska du ha:");

                            OrderQuantity = Convert.ToInt32(Console.ReadLine());

                            drink1.drinkTotalPrice = OrderQuantity * drink1.drinkTotalPrice;
                            drink1.drinkQuantity = OrderQuantity;



                            //Lägg till orderlist i Order Klass
                            //Order.drinklist.Add(drink1);



                            order1 = drink1.drinkName + "  " + drink1.drinkPrice + "kg/kr * " +
                                drink1.drinkQuantity + "kg  " + drink1.drinkTotalPrice + ";-";

                            Console.Clear();

                            //Anroppa logo 
                            Program.logo();



                            Console.WriteLine("Tack för att du handlat oss! " +
                                "\nProdukten har lagt till i kundvagnen\n" + "\n" + order1);
                            Console.WriteLine("");

                            Console.WriteLine("\nTryck på valfri tangent för att fortsätta...");

                            Console.ReadKey();
                            Console.Clear();
                            Program.logo();

                            break;

                        }
                        else if (DrinkFruit == 2)
                        {
                            Console.Clear();

                            //Anroppa logo 
                            Program.logo();

                            Console.WriteLine("Du har valt " + "---------->" + drink2.drinkName +
                                " " + drink2.drinkPrice + "kr/kg");

                            Console.WriteLine("\nHur många ska du ha:");

                            OrderQuantity = Convert.ToInt32(Console.ReadLine());

                            drink2.drinkTotalPrice = OrderQuantity * drink2.drinkTotalPrice;
                            drink2.drinkQuantity = OrderQuantity; ;

                            order2 = drink2.drinkName + "  " + drink2.drinkPrice + "kg/kr * " +
                                drink2.drinkQuantity + "kg  " + drink2.drinkTotalPrice + ";-";

                            //Lägg till orderlist i Order Klass
                            //Order.drinklist.Add(drink2);

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

                        else if (DrinkFruit == 3)
                        {
                            Console.Clear();

                            //Anroppa logo 
                            Program.logo();
                            Console.WriteLine("Du har valt " + "---------->" + drink3.drinkName +
                                " " + drink3.drinkPrice + "kr/kg");

                            Console.WriteLine("\nHur många ska du ha:");

                            OrderQuantity = Convert.ToInt32(Console.ReadLine());

                            drink3.drinkTotalPrice = OrderQuantity * drink3.drinkTotalPrice;
                            drink3.drinkQuantity = OrderQuantity; ;

                            order3 = drink3.drinkName + "  " + drink3.drinkPrice + "kg/kr * " +
                                drink3.drinkQuantity + "kg  " + drink3.drinkTotalPrice + ";-";

                            //Lägg till orderlist i Order Klass
                            //Order.drinklist.Add(drink3);

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
                        else if (DrinkFruit == 4)
                        {
                            Console.Clear();

                            //Anroppa logo 
                            Program.logo();
                            Console.WriteLine("Du har valt " + "---------->" + drink4.drinkName +
                                " " + drink4.drinkPrice + "kr/kg");

                            Console.WriteLine("\nHur många ska du ha:");

                            OrderQuantity = Convert.ToInt32(Console.ReadLine());
                            drink4.drinkTotalPrice = OrderQuantity * drink4.drinkTotalPrice;
                            drink4.drinkQuantity = OrderQuantity; ;

                            order4 = drink4.drinkName + "  " + drink4.drinkPrice + "kg/kr * " +
                                drink4.drinkQuantity + "kg  " + drink4.drinkTotalPrice + ";-";



                            //Lägg till orderlist i Order Klass
                            //Order.drinklist.Add(drink4);

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
                        else if (DrinkFruit == 5)
                        {
                            Console.Clear();

                            Console.WriteLine("Du har valt " + "---------->" + drink5.drinkName +
                                " " + drink5.drinkPrice + "kr/kg");


                            Console.WriteLine("\nHur många ska du ha:");

                            OrderQuantity = Convert.ToInt32(Console.ReadLine());

                            drink5.drinkTotalPrice = OrderQuantity * drink5.drinkTotalPrice;
                            drink5.drinkQuantity = OrderQuantity; ;

                            order5 = drink5.drinkName + "  " + drink1.drinkPrice + "kg/kr * " +
                                drink5.drinkQuantity + "kg  " + drink5.drinkTotalPrice + ";-";

                            //Lägg till orderlist i Order Klass
                            //Order.drinklist.Add(drink5);

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
                        else if (DrinkFruit == 6)
                        {
                            Console.Clear();

                            //Anroppa logo 
                            Program.logo();
                            Console.WriteLine("Du har valt " + "---------->" + drink6.drinkName +
                                " " + drink6.drinkPrice + "kr/kg");

                            Console.WriteLine("\nHur många ska du ha:");

                            OrderQuantity = Convert.ToInt32(Console.ReadLine());

                            drink6.drinkTotalPrice = OrderQuantity * drink6.drinkTotalPrice;
                            drink6.drinkQuantity = OrderQuantity; ;

                            order6 = drink5.drinkName + "  " + drink6.drinkPrice + "kg/kr * " +
                                drink6.drinkQuantity + "kg  " + drink6.drinkTotalPrice + ";-";



                            //Lägg till orderlist i Order Klass
                            //Order.drinklist.Add(drink6); ;
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
