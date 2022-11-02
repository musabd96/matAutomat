using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace butik
{
    internal class Drink : IProduct
    {
        public string Name { get; set; }

        public int Price { get; set; }

        public int Quantity { get; set; }

        public int TotalPrice { get; set; }

        public Drink(string name, int price)
        {
            Name = name;
            Price = price;
            TotalPrice = price;


        }

        public override string ToString()
        {
            return Name + " " + Price + " " + Quantity + " " + TotalPrice;
        }


        //Frukt menyn

        public static void Menu(string[] args)
        {
            while (true)
            {

                int orderDrink;
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
                        Console.WriteLine("{0}. {1,-20} {2}kr/st\n", i + 1, drinkName[i], drinkCost[i]);
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

                        orderDrink = Convert.ToInt32(Console.ReadLine());


                        if (orderDrink == 1)
                        {

                            Console.Clear();
                            //Anroppa logo 
                            Program.logo();

                            Console.WriteLine("Du har valt " + "---------->" + drink1.Name +
                                " " + drink1.Price + "kr");


                            Console.Write("\nHur många ska du ha:");

                            OrderQuantity = Convert.ToInt32(Console.ReadLine());

                            drink1.TotalPrice = OrderQuantity * drink1.TotalPrice;
                            drink1.Quantity = OrderQuantity;



                            //Lägg till orderlist i Order Klass
                            Order.drinklist.Add(drink1);



                            order1 = drink1.Name + "  " + drink1.Price + "kr * " +
                                drink1.Quantity + "st  " + drink1.TotalPrice + ";-";

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
                        else if (orderDrink == 2)
                        {
                            Console.Clear();

                            //Anroppa logo 
                            Program.logo();

                            Console.WriteLine("Du har valt " + "---------->" + drink2.Name +
                                " " + drink2.Price + "kr");

                            Console.Write("\nHur många ska du ha:");

                            OrderQuantity = Convert.ToInt32(Console.ReadLine());

                            drink2.TotalPrice = OrderQuantity * drink2.TotalPrice;
                            drink2.Quantity = OrderQuantity; ;

                            order2 = drink2.Name + "  " + drink2.Price + "kr * " +
                                drink2.Quantity + "st  " + drink2.TotalPrice + ";-";

                            //Lägg till orderlist i Order Klass
                            Order.drinklist.Add(drink2);

                            Console.Clear();
                            //Anroppa logo 
                            Program.logo();


                            Console.WriteLine("Tack för att du handlat oss! " +
                                "\nProdukten har lagt till i kundvagnen\n" + "\n" + order2);

                            Console.Write("\nTryck på valfri tangent för att fortsätta...");

                            Console.ReadKey();
                            Console.Clear();
                            Program.logo();
                            break;

                        }

                        else if (orderDrink == 3)
                        {
                            Console.Clear();

                            //Anroppa logo 
                            Program.logo();
                            Console.WriteLine("Du har valt " + "---------->" + drink3.Name +
                                " " + drink3.Price + "kr");

                            Console.WriteLine("\nHur många ska du ha:");

                            OrderQuantity = Convert.ToInt32(Console.ReadLine());

                            drink3.TotalPrice = OrderQuantity * drink3.TotalPrice;
                            drink3.Quantity = OrderQuantity; ;

                            order3 = drink3.Name + "  " + drink3.Price + "kr * " +
                                drink3.Quantity + "st  " + drink3.TotalPrice + ";-";

                            //Lägg till orderlist i Order Klass
                            Order.drinklist.Add(drink3);

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
                        else if (orderDrink == 4)
                        {
                            Console.Clear();

                            //Anroppa logo 
                            Program.logo();
                            Console.WriteLine("Du har valt " + "---------->" + drink4.Name +
                                " " + drink4.Price + "kr");

                            Console.Write("\nHur många ska du ha:");

                            OrderQuantity = Convert.ToInt32(Console.ReadLine());
                            drink4.TotalPrice = OrderQuantity * drink4.TotalPrice;
                            drink4.Quantity = OrderQuantity; ;

                            order4 = drink4.Name + "  " + drink4.Price + "kr * " +
                                drink4.Quantity + "st  " + drink4.TotalPrice + ";-";



                            //Lägg till orderlist i Order Klass
                            Order.drinklist.Add(drink4);

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
                        else if (orderDrink == 5)
                        {
                            Console.Clear();

                            Console.WriteLine("Du har valt " + "---------->" + drink5.Name +
                                " " + drink5.Price + "kr");


                            Console.Write("\nHur många ska du ha:");

                            OrderQuantity = Convert.ToInt32(Console.ReadLine());

                            drink5.TotalPrice = OrderQuantity * drink5.TotalPrice;
                            drink5.Quantity = OrderQuantity; ;

                            order5 = drink5.Name + "  " + drink1.Price + "kr * " +
                                drink5.Quantity + "st  " + drink5.TotalPrice + ";-";

                            //Lägg till orderlist i Order Klass
                            Order.drinklist.Add(drink5);

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
                        else if (orderDrink == 6)
                        {
                            Console.Clear();

                            //Anroppa logo 
                            Program.logo();
                            Console.WriteLine("Du har valt " + "---------->" + drink6.Name +
                                " " + drink6.Price + "kr");

                            Console.Write("\nHur många ska du ha:");

                            OrderQuantity = Convert.ToInt32(Console.ReadLine());

                            drink6.TotalPrice = OrderQuantity * drink6.TotalPrice;
                            drink6.Quantity = OrderQuantity; ;

                            order6 = drink5.Name + "  " + drink6.Price + "kr * " +
                                drink6.Quantity + "st  " + drink6.TotalPrice + ";-";



                            //Lägg till orderlist i Order Klass
                            Order.drinklist.Add(drink6); ;
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
