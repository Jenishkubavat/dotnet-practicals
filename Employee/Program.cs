using System;
using Employee;
namespace MainProgram
{
    class Program
    {
        public static void Main(string[] args)
        {
            const string name = "Jenish Kubavat";
            Console.WriteLine($"name: {name},Time: {DateTime.Now.ToString("HH:mm:ss tt")}\n");

            PermanentEmployee employee1 = new PermanentEmployee("Eren", "Jaeger", 30000, 10000, 3000, 2000, "21 April 2021", "21 April 2045");
            PermanentEmployee employee2 = new PermanentEmployee("Levi", "Ackerman", 20000, 5000, 2500, 1000, "2 September 2019", "2 Septmber ,2024");
            Console.WriteLine($"Information about First Employee:\n{employee1}");

            employee1.giveRaise(10);
            Console.WriteLine($"Information about First Employee after 10% raise:\n{employee1}\n");
            Console.WriteLine($"Information about First Employee:\n{employee2}");
            employee2.giveRaise(10);
            Console.WriteLine($"Information about First Employee after 10% raise:\n{employee2}\n");

        }
    }
}