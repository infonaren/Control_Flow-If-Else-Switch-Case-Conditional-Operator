using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Control_Flow_If_Else_Switch_Case_Conditional_Operator
{
    class Program
    {
        static void Main(string[] args)
        {

            // If_Else
            
            int hour = 10;

            if (hour > 0 && hour < 12)
            {
                Console.WriteLine("It's morning.");
            }
            else if (hour >=12 && hour < 18)
            {
                Console.WriteLine("It's afternoon.");
            }
            else
            {
                Console.WriteLine("It's evening");
            }

            // Conditional_Operator

            bool isGoldCustomer = false;
            float price = (isGoldCustomer) ? 19.95f : 29.95f;
            Console.WriteLine(price);

            /*
            float price;
            if (isGoldCustomer)
             {
               price = 19.95f;
             }
            else
             {
               price = 29.95f;
             }              
            */

            var season = Season.Summer;

            switch (season)
            {
                case Season.Autumn:
                    Console.WriteLine("It's autumn and a beautiful season");
                    break;

                case Season.Summer:
                    Console.WriteLine("It's perfect to go to the beach");
                    break;

                case Season.Spring:
                    Console.WriteLine("It's all right to go the falls");
                    break;

                default:
                    Console.WriteLine("It's not cool to go the beach");
                    break;


            }


            switch (season)
            {
                case Season.Autumn:
                case Season.Summer:
                    Console.WriteLine("I will get a promotion.");
                    break;
                
                default:
                    Console.WriteLine("What the fish, man");
                    break;


            }





        }
    }
}
