using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace GreetingApp
{
    public class GreetingProgram
    {
        public static void Main(string[] args)
        {
            //User name
            Console.Write("Enter your name: ");
            string Name = Console.ReadLine();
            //Total Number of courses
            Console.Write("Enter the total number of your enrolled courses: ");
            int EnrolledCourses = Convert.ToInt32(Console.ReadLine());
            //Price of Favorite book
            Console.Write("Enter the price of your favorite book: ");
            double PriceBook = Convert.ToDouble(Console.ReadLine());
            //printing the user input
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Total enrolled courses: " + EnrolledCourses);
            Console.WriteLine("Price of my favorite book: " + PriceBook);
            Console.Write("\nPress any key to exit...");
            Console.ReadKey();

        }
    }
}
