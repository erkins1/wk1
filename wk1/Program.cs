using System;

namespace wk1
{
    class Program
    {
        static void Main(string[] args)
        {
            string myName;
            Console.Write("Enter your name: ");
            myName = Console.ReadLine();
                        
            string loc;
            Console.Write("Enter your location: ");
            loc = Console.ReadLine();
            
            Console.WriteLine($"My name is: {myName}, I am from {loc}");
            
            var currDate = DateTime.Now;
            Console.WriteLine("The current date is: " + currDate.ToString("d"));

            var christmas = new DateTime(2020, 12, 25);
            var daysToXmas = christmas - currDate;
            Console.WriteLine("Days until Christmas: " + daysToXmas.Days);

            double width, height, length, area;
            Console.Write("What is the width? ");
            width = double.Parse(Console.ReadLine());
            Console.Write("What is the height? ");
            height = double.Parse(Console.ReadLine());

            length = 2 * (width + height) * 3.25;
            area = 2 * (width * height);

            Console.WriteLine($"The length of the wood is {length}");
            Console.WriteLine($"The area of the glass is {area}");

            Console.WriteLine("Press any key to cotinue");
            Console.ReadKey();

        }
    }
}
