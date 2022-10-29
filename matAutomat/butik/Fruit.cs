using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace butik
{
    internal class Fruit
    {
        public string fruitName { get; set; }

        public int fruitPrice { get; set; }

        public int fruitQuantity { get; set; }

        public int fruitTotalPrice { get; set; }

        public Fruit(string name, int price)
        {
            fruitName = name;
            fruitPrice = price;
            fruitTotalPrice = price;
            
            
        }

        public override string ToString()
        {
            return fruitName + " " + fruitPrice + " " + fruitQuantity+ " " + fruitTotalPrice;
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
                        Console.WriteLine("{0}. {1} -------------> {2}kr/kg\n", i + 1, fruitName[i], fruitCost[i]);
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

                            Console.WriteLine("Du har valt " + "---------->" + fruit1.fruitName +
                                " " + fruit1.fruitPrice + "kr/kg");


                            Console.WriteLine("\nHur mycket KG ska du ha:");

                            OrderQuantity = Convert.ToInt32(Console.ReadLine());

                            fruit1.fruitTotalPrice = OrderQuantity * fruit1.fruitTotalPrice;
                            fruit1.fruitQuantity = OrderQuantity;



                            //Lägg till orderlist i Order Klass
                            Order.fruitlist.Add(fruit1);



                            order1 = fruit1.fruitName + "  " + fruit1.fruitPrice + "kg/kr * " +
                                fruit1.fruitQuantity + "kg  " + fruit1.fruitTotalPrice + ";-";

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

                            Console.WriteLine("Du har valt " + "---------->" + fruit2.fruitName +
                                " " + fruit2.fruitPrice + "kr/kg");

                            Console.WriteLine("\nHur mycket KG ska du ha:");

                            OrderQuantity = Convert.ToInt32(Console.ReadLine());

                            fruit2.fruitTotalPrice = OrderQuantity * fruit2.fruitTotalPrice;
                            fruit2.fruitQuantity = OrderQuantity; ;

                            order2 = fruit2.fruitName + "  " + fruit2.fruitPrice + "kg/kr * " +
                                fruit2.fruitQuantity + "kg  " + fruit2.fruitTotalPrice + ";-";

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
                            Console.WriteLine("Du har valt " + "---------->" + fruit3.fruitName +
                                " " + fruit3.fruitPrice + "kr/kg");

                            Console.WriteLine("\nHur mycket KG ska du ha:");

                            OrderQuantity = Convert.ToInt32(Console.ReadLine());

                            fruit3.fruitTotalPrice = OrderQuantity * fruit3.fruitTotalPrice;
                            fruit3.fruitQuantity = OrderQuantity; ;

                            order3 = fruit3.fruitName + "  " + fruit3.fruitPrice + "kg/kr * " +
                                fruit3.fruitQuantity + "kg  " + fruit3.fruitTotalPrice + ";-";

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
                            Console.WriteLine("Du har valt " + "---------->" + fruit4.fruitName +
                                " " + fruit4.fruitPrice + "kr/kg");

                            Console.WriteLine("\nHur mycket KG ska du ha:");

                            OrderQuantity = Convert.ToInt32(Console.ReadLine());
                            fruit4.fruitTotalPrice = OrderQuantity * fruit4.fruitTotalPrice;
                            fruit4.fruitQuantity = OrderQuantity; ;

                            order4 = fruit4.fruitName + "  " + fruit4.fruitPrice + "kg/kr * " +
                                fruit4.fruitQuantity + "kg  " + fruit4.fruitTotalPrice + ";-";



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

                            Console.WriteLine("Du har valt " + "---------->" + fruit5.fruitName +
                                " " + fruit5.fruitPrice + "kr/kg");


                            Console.WriteLine("\nHur mycket KG ska du ha:");

                            OrderQuantity = Convert.ToInt32(Console.ReadLine());

                            fruit5.fruitTotalPrice = OrderQuantity * fruit5.fruitTotalPrice;
                            fruit5.fruitQuantity = OrderQuantity; ;

                            order5 = fruit5.fruitName + "  " + fruit5.fruitPrice + "kg/kr * " +
                                fruit5.fruitQuantity + "kg  " + fruit5.fruitTotalPrice + ";-";

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
                            Console.WriteLine("Du har valt " + "---------->" + fruit6.fruitName +
                                " " + fruit6.fruitPrice + "kr/kg");

                            Console.WriteLine("\nHur mycket KG ska du ha:");

                            OrderQuantity = Convert.ToInt32(Console.ReadLine());

                            fruit6.fruitTotalPrice = OrderQuantity * fruit6.fruitTotalPrice;
                            fruit6.fruitQuantity = OrderQuantity; ;

                            order6 = fruit5.fruitName + "  " + fruit6.fruitPrice + "kg/kr * " +
                                fruit6.fruitQuantity + "kg  " + fruit6.fruitTotalPrice + ";-";



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
