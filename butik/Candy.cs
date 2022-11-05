using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace butik
{
    internal class Candy : IProduct
    {
        public string Name { get; set; }

        public int Price { get; set; }

        public int Quantity { get; set; }

        public int TotalPrice { get; set; }

        public Candy(string name, int price)
        {
            Name = name;
            Price = price;
            TotalPrice = price;


        }

        public Candy()
        {
        }

        public override string ToString()
        {
            return Name + " " + Price + " " + Quantity + " " + TotalPrice;
        }


        //Frukt menyn

        public void description()
        {
            Candy candy = new Candy();
            while (true)
            {

                int OrderCandy;
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

                    string[] candyName = { "Kex",
                                           "Snickers", 
                                           "Twix", 
                                           "Polly", 
                                           "Haribo Nappar", 
                                           "Marabou" };
                    int[] candyCost = { 9, 9, 10, 25, 15, 24 };

                    Console.WriteLine("\nProdukter              kostnad");
                    Console.WriteLine("--------------------------------\n");

                    for (int i = 0; i < candyName.Length; i++)
                    {
                        Console.WriteLine(
                            "{0}. {1,-20} {2}kr/st\n", 
                            i + 1, candyName[i], candyCost[i]);
                    }

                    Console.WriteLine("7. Tillbaka till menyn");

                    Console.WriteLine("--------------------------------\n");

                    //Produkter och kostnad

                    Candy candy1 = new Candy("Kex", 9);
                    Candy candy2 = new Candy("Snickers", 9);
                    Candy candy3 = new Candy("Twix", 10);
                    Candy candy4 = new Candy("Polly", 25);
                    Candy candy5 = new Candy("Haribo Nappar", 15);
                    Candy candy6 = new Candy("Marabou", 24);


                    try
                    {
                        Console.Write("\nVälj en produkt att lägga i varukorgen: ");

                        OrderCandy = Convert.ToInt32(Console.ReadLine());

                        if (OrderCandy == 1)
                        {

                            Console.Clear();
                            //Anroppa logo 
                            Program.logo();

                            Console.WriteLine("Du har valt " + "---------->" + candy1.Name +
                                " " + candy1.Price + "kr/st");

                            Console.Write("\nHur många ska du ha:");

                            OrderQuantity = Convert.ToInt32(Console.ReadLine());

                            candy1.TotalPrice = OrderQuantity * candy1.TotalPrice;
                            candy1.Quantity = OrderQuantity;


                            order1 = candy1.Name + "  " + candy1.Price + "kr/st * " +
                                candy1.Quantity + "st  " + candy1.TotalPrice + ";-";

                            //Lägg till orderlist i Order Klass

                            Order.candylist.Add(candy1);
                            candylist.Add(candy1);
                            

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
                        else if (OrderCandy == 2)
                        {
                            Console.Clear();

                            //Anroppa logo 
                            Program.logo();

                            Console.WriteLine("Du har valt " + "---------->" + candy2.Name +
                                " " + candy2.Price + "kr");

                            Console.WriteLine("Hur Många ska du ha:");

                            OrderQuantity = Convert.ToInt32(Console.ReadLine());

                            candy2.TotalPrice = OrderQuantity * candy2.TotalPrice;
                            candy2.Quantity = OrderQuantity;

                            order2 = candy2.Name + "  " + candy2.Price + "kr/st * " +
                                candy2.Quantity + "st  " + candy2.TotalPrice + ";-";

                            //Lägg till orderlist i Order Klass
                            Order.candylist.Add(candy2);
                            candylist.Add(candy2);

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

                        else if (OrderCandy == 3)
                        {
                            Console.Clear();
                            //Anroppa logo 
                            Program.logo();

                            Console.WriteLine("Du har valt " + "---------->" + candy3.Name +
                                " " + candy3.Price + "kr");

                            Console.WriteLine("Hur många ska du ha:");

                            OrderQuantity = Convert.ToInt32(Console.ReadLine());

                            candy3.TotalPrice = OrderQuantity * candy3.TotalPrice;
                            candy3.Quantity = OrderQuantity; ;

                            order3 = candy3.Name + "  " + candy3.Price + "kr/st * " +
                                candy3.Quantity + "st  " + candy3.TotalPrice + ";-";

                            //Lägg till orderlist i Order Klass
                            Order.candylist.Add(candy3);
                            candylist.Add(candy3);

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
                        else if (OrderCandy == 4)
                        {
                            Console.Clear();

                            //Anroppa logo 
                            Program.logo();

                            Console.WriteLine("Du har valt " + "---------->" + candy4.Name +
                                " " + candy4.Price + "kr/st");

                            Console.WriteLine("\nHur många ska du ha:");

                            OrderQuantity = Convert.ToInt32(Console.ReadLine());
                            candy4.TotalPrice = OrderQuantity * candy4.TotalPrice;
                            candy4.Quantity = OrderQuantity; ;

                            order4 = candy4.Name + "  " + candy4.Price + "kr/st * " +
                                candy4.Quantity + "st  " + candy4.TotalPrice + ";-";



                            //Lägg till orderlist i Order Klass
                            Order.candylist.Add(candy4);
                            candylist.Add(candy4);

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
                        else if (OrderCandy == 5)
                        {
                            Console.Clear();

                            //Anroppa logo 
                            Program.logo();

                            Console.WriteLine("Du har valt " + "---------->" + candy5.Name +
                                " " + candy5.Price + "kr");


                            Console.WriteLine("\nHur många ska du ha:");

                            OrderQuantity = Convert.ToInt32(Console.ReadLine());

                            candy5.TotalPrice = OrderQuantity * candy5.TotalPrice;
                            candy5.Quantity = OrderQuantity; ;

                            order5 = candy5.Name + "  " + candy1.Price + "kr/st * " +
                                candy5.Quantity + "st  " + candy5.TotalPrice + ";-";

                            //Lägg till orderlist i Order Klass
                            Order.candylist.Add(candy5);
                            candylist.Add(candy5);

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
                        else if (OrderCandy == 6)
                        {

                            
                            Console.Clear();

                            //Anroppa logo 
                            Program.logo();
                            Console.WriteLine("Du har valt " + "---------->" + candy6.Name +
                                " " + candy6.Price + "kr");

                            

                            Console.WriteLine("\nHur många ska du ha:");

                            OrderQuantity = Convert.ToInt32(Console.ReadLine());

                            candy6.TotalPrice = OrderQuantity * candy6.TotalPrice;
                            candy6.Quantity = OrderQuantity; ;

                            order6 = candy5.Name + "  " + candy6.Price + "kr/st * " +
                                candy6.Quantity + "st  " + candy6.TotalPrice + ";-";



                            //Lägg till orderlist i Order Klass
                            Order.candylist.Add(candy6); ;
                            candylist.Add(candy6);
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
                        else if (OrderCandy == 7)
                        {
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

        //Drink order list 
        public static List<Candy> candylist = new List<Candy>();

        public void use()
        {
            foreach (Candy candy in candylist)
            {

                Console.WriteLine("\n     Äter ---->{0} ", candy.Name);

            }

        }

        public void buy()
        {
            foreach (Candy candy in candylist)
            {

                Console.WriteLine("\n     {0}st {1} som koster: {2}", candy.Quantity, candy.Name, candy.TotalPrice);

            }

        }


    }
}
