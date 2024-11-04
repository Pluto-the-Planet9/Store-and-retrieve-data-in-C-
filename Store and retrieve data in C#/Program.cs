using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store_and_retrieve_data_in_C_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine('b');
            Console.WriteLine(123);
            Console.WriteLine(0.25F);
            Console.WriteLine(2.625);
            Console.WriteLine(12.39816m);
            Console.WriteLine(true);
            Console.WriteLine(false);

            string firstName;
            firstName = "Bob";
            Console.WriteLine(firstName);
            firstName = "Liem";
            Console.WriteLine(firstName);
            firstName = "Isabella";
            Console.WriteLine(firstName);
            firstName = "Yasmin";
            Console.WriteLine(firstName);

            char userOption;
            int gameScore;
            decimal particlesPerMillion;
            bool processedCustomer;

            var message = "Hello world!";

            string name = "Bob";
            int num = 3;
            decimal cel = 34.4m;

            Console.WriteLine("Hello, " + name + "! You have " + num + " messages in your inbox. The temperature is " + cel + " celsius.");

            Console.ReadLine();
        }
    }
}
