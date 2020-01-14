using System;

namespace wk1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            string myName;
            Console.Write("Enter your name: ");
            myName = Console.ReadLine();

            
            string loc;
            Console.Write("Enter your location: ");
            loc = Console.ReadLine();
            

            Console.WriteLine($"My name is: {myName}");
            //Console.WriteLine($"I am {0} at {1}", myName, loc);
            */

            var currDate = DateTime.Now;
            Console.WriteLine("The current date is: " + currDate.ToString("d"));

            var christmas = new DateTime(2020, 12, 25);
            var daysToXmas = christmas - currDate;
            Console.WriteLine("Days until Christmas: " + daysToXmas.ToString());


            Console.WriteLine("Press any key to cotinue");
            Console.ReadKey();

        }
    }
}
