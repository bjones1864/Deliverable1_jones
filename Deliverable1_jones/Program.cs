using System;

namespace Deliverable1
{
    public class Restocker
    {
        public static void Main(string[] args)
        {
            int sodaStock = 100;
            int sodaRestock = 40;
            int chipsStock = 40;
            int chipsRestock = 20;
            int candyStock = 60;
            int candyRestock = 40;

            Console.Write("How many sodas have been sold today?: ");
            sodaStock = updateStock(sodaStock);
            Console.WriteLine("There are " + sodaStock + " sodas left.");

            Console.Write("How many chips have been sold today?: ");
            chipsStock = updateStock(chipsStock);
            Console.WriteLine("There are " + chipsStock + " chips left.");

            Console.Write("How many candy have been sold today?: ");
            candyStock = updateStock(candyStock);
            Console.WriteLine("There are " + candyStock + " candy left.");

            Console.WriteLine("Thank you for filling out the values. Here’s what needs to be restocked.");
            if(sodaStock <= sodaRestock)
            {
                Console.WriteLine("Soda needs to be restocked");
            }
            if (chipsStock <= chipsRestock)
            {
                Console.WriteLine("Chips need to be restocked");
            }
            if (candyStock <= candyRestock)
            {
                Console.WriteLine("Candy needs to be restocked");
            }
            if (sodaStock > sodaRestock && chipsStock > chipsRestock && candyStock > candyRestock) 
            {
                Console.WriteLine("Nothing!");
            }

        }

        public static int updateStock(int stock)
        {
            int soldToday = int.Parse(Console.ReadLine());
            if (soldToday > stock)
            {
                Console.WriteLine("That value is too high, stock not adjusted.");
                return stock;
            }
            return stock - soldToday;
        }
    }
}