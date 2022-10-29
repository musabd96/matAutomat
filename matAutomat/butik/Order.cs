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
        public static List<Godis> godislist = new List<Godis>();
        public static List<Drink> drinklist = new List<Drink>();

        
        
        public static void fruitList()
        {


            foreach (Fruit fruit in fruitlist)
            {

                Console.WriteLine("{0}             {1}kr/kg * {2}st               {3};- ",
                    fruit.fruitName, fruit.fruitPrice,
                    fruit.fruitQuantity, fruit.fruitTotalPrice);

            }

        }
      
        public static void godisList()
        {
            foreach (Godis godis in Order.godislist)
            {

                Console.WriteLine("{0}             {1}kr/kg * {2}st               {3};- ",
                    godis.godisName, godis.godisPrice,
                    godis.godisQuantity, godis.godisTotalPrice);

            }
        }
        public static void drinkList()
        {
            foreach (Drink drink in Order.drinklist)
            {

                Console.WriteLine("{0}             {1}kr/kg * {2}st               {3};- ",
                    drink.drinkName, drink.drinkPrice,
                    drink.drinkQuantity, drink.drinkTotalPrice);

            }
        }

        

        public static void total()
        {
            double total = fruitlist.Sum(item => item.fruitTotalPrice);

            Console.WriteLine(total);
        }

        
    }
}
