using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq;


namespace butik
{
    internal class Order
    {
        public static List<Fruit> fruitlist = new List<Fruit>();
        public static List<Candy> candylist = new List<Candy>();
        public static List<Drink> drinklist = new List<Drink>();
        
        

        
        
        public static void fruitList()
        {


            foreach (Fruit fruit in fruitlist)
            {

                Console.WriteLine("{0,-15} {1,5}kr/kg * {2}kg {3,10};- ",
                    fruit.Name, fruit.Price,
                    fruit.Quantity, fruit.TotalPrice);

            }

        }
      
        public static void candyList()
        {
            foreach (Candy godis in Order.candylist)
            {

                Console.WriteLine("{0,-15} {1,5}kr/st * {2}st {3,10};- ",
                    godis.Name, godis.Price,
                    godis.Quantity, godis.TotalPrice);

            }
        }
        public static void drinkList()
        {
            foreach (Drink drink in Order.drinklist)
            {

                Console.WriteLine("{0,-15} {1,5}kr/st * {2}st {3,10};- ",
                    drink.Name, drink.Price,
                    drink.Quantity, drink.TotalPrice);

            }
        }

        

        



        //efter användare betalat alla produckter i kundvagn ska ta bort
        public static void remove()
        {

            fruitlist.RemoveAll(fruitlist.Remove);
            
            
            
            
            

        }

    }
}
