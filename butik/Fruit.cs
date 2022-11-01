using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace butik
{
    internal class Fruit : IProduct
    {
        public string Name { get; set; }

        public int Price { get; set; }

        public int Quantity { get; set; }

        public int TotalPrice { get; set; }

        public Fruit(string name, int price)
        {
            Name = name;
            Price = price;
            TotalPrice = price;
            
            
        }

        public override string ToString()
        {
            return Name + " " + Price + " " + Quantity+ " " + TotalPrice;
        }


        //Frukt menyn

        public static void Menu(string[] args)
        {
           while (true)
            {

                int OrderFruit;
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

                    string[] fruitName = { "Äpple", "Päron", "Mango", "Citron", "Banan", "Sallad" };
                    int[] fruitCost = { 29, 19, 10, 5, 16, 14 };

                    Console.WriteLine("\nProdukter              kostnad");
                    Console.WriteLine("--------------------------------\n");

                    for (int i = 0; i < fruitName.Length; i++)
                    {
                        Console.WriteLine("{0}. {1,-20} {2}kr/kg\n", i + 1, fruitName[i], fruitCost[i]);
                    }



                    //Produkter och kostnad

                    Fruit fruit1 = new Fruit("Äpple", 29);
                    Fruit fruit2 = new Fruit("Päron", 19);
                    Fruit fruit3 = new Fruit("Mango", 10);
                    Fruit fruit4 = new Fruit("Citron", 5);
                    Fruit fruit5 = new Fruit("Banan", 16);
                    Fruit fruit6 = new Fruit("Sallad", 14);



                    

                    try
                    {
                        Console.WriteLine("Välj en produkt att lägga i varukorgen: ");

                        OrderFruit = Convert.ToInt32(Console.ReadLine());


                        if (OrderFruit == 1)
                        {

                            Console.Clear();
                            //Anroppa logo 
                            Program.logo();

                            Console.WriteLine("Du har valt " + "---------->" + fruit1.Name +
                                " " + fruit1.Price + "kr/kg");


                            Console.WriteLine("\nHur mycket KG ska du ha:");

                            OrderQuantity = Convert.ToInt32(Console.ReadLine());

                            fruit1.TotalPrice = OrderQuantity * fruit1.TotalPrice;
                            fruit1.Quantity = OrderQuantity;



                            //Lägg till orderlist i Order Klass
                            Order.fruitlist.Add(fruit1);



                            order1 = fruit1.Name + "  " + fruit1.Price + "kg/kr * " +
                                fruit1.Quantity + "kg  " + fruit1.TotalPrice + ";-";

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
                        else if (OrderFruit == 2)
                        {
                            Console.Clear();

                            //Anroppa logo 
                            Program.logo();

                            Console.WriteLine("Du har valt " + "---------->" + fruit2.Name +
                                " " + fruit2.Price + "kr/kg");

                            Console.WriteLine("\nHur mycket KG ska du ha:");

                            OrderQuantity = Convert.ToInt32(Console.ReadLine());

                            fruit2.TotalPrice = OrderQuantity * fruit2.TotalPrice;
                            fruit2.Quantity = OrderQuantity; ;

                            order2 = fruit2.Name + "  " + fruit2.Price + "kg/kr * " +
                                fruit2.Quantity + "kg  " + fruit2.TotalPrice + ";-";

                            //Lägg till orderlist i Order Klass
                            Order.fruitlist.Add(fruit2);

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

                        else if (OrderFruit == 3)
                        {
                            Console.Clear();

                            //Anroppa logo 
                            Program.logo();
                            Console.WriteLine("Du har valt " + "---------->" + fruit3.Name +
                                " " + fruit3.Price + "kr/kg");

                            Console.WriteLine("\nHur mycket KG ska du ha:");

                            OrderQuantity = Convert.ToInt32(Console.ReadLine());

                            fruit3.TotalPrice = OrderQuantity * fruit3.TotalPrice;
                            fruit3.Quantity = OrderQuantity; ;

                            order3 = fruit3.Name + "  " + fruit3.Price + "kg/kr * " +
                                fruit3.Quantity + "kg  " + fruit3.TotalPrice + ";-";

                            //Lägg till orderlist i Order Klass
                            Order.fruitlist.Add(fruit3);

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
                        else if (OrderFruit == 4)
                        {
                            Console.Clear();

                            //Anroppa logo 
                            Program.logo();
                            Console.WriteLine("Du har valt " + "---------->" + fruit4.Name +
                                " " + fruit4.Price + "kr/kg");

                            Console.WriteLine("\nHur mycket KG ska du ha:");

                            OrderQuantity = Convert.ToInt32(Console.ReadLine());
                            fruit4.TotalPrice = OrderQuantity * fruit4.TotalPrice;
                            fruit4.Quantity = OrderQuantity; ;

                            order4 = fruit4.Name + "  " + fruit4.Price + "kg/kr * " +
                                fruit4.Quantity + "kg  " + fruit4.TotalPrice + ";-";



                            //Lägg till orderlist i Order Klass
                            Order.fruitlist.Add(fruit4);

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
                        else if (OrderFruit == 5)
                        {
                            Console.Clear();

                            Console.WriteLine("Du har valt " + "---------->" + fruit5.Name +
                                " " + fruit5.Price + "kr/kg");


                            Console.WriteLine("\nHur mycket KG ska du ha:");

                            OrderQuantity = Convert.ToInt32(Console.ReadLine());

                            fruit5.TotalPrice = OrderQuantity * fruit5.TotalPrice;
                            fruit5.Quantity = OrderQuantity; ;

                            order5 = fruit5.Name + "  " + fruit5.Price + "kg/kr * " +
                                fruit5.Quantity + "kg  " + fruit5.TotalPrice + ";-";

                            //Lägg till orderlist i Order Klass
                            Order.fruitlist.Add(fruit5);

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
                        else if (OrderFruit == 6)
                        {
                            Console.Clear();

                            //Anroppa logo 
                            Program.logo();
                            Console.WriteLine("Du har valt " + "---------->" + fruit6.Name +
                                " " + fruit6.Price + "kr/kg");

                            Console.WriteLine("\nHur mycket KG ska du ha:");

                            OrderQuantity = Convert.ToInt32(Console.ReadLine());

                            fruit6.TotalPrice = OrderQuantity * fruit6.TotalPrice;
                            fruit6.Quantity = OrderQuantity; ;

                            order6 = fruit5.Name + "  " + fruit6.Price + "kg/kr * " +
                                fruit6.Quantity + "kg  " + fruit6.TotalPrice + ";-";



                            //Lägg till orderlist i Order Klass
                            Order.fruitlist.Add(fruit6); ;
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
