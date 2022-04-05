using System;
using Properties;
using Indexers;
namespace MainProgram
{
   /* class Program
     {
        public static void Main()
         {
             const string name = "Jenish Kubavat";
             Console.WriteLine($"name: {name},Time: {DateTime.Now.ToString("HH:mm:ss tt")}");
             TimePeriod t = new TimePeriod();
             t.Hours = 24;
             Console.WriteLine($"Time in hours: {t.Hours}");
             var person = new Person("Jack", "sparrow");
             Console.WriteLine(person.Name);
             var item = new SaleItem("hat", 19.95m);
             Console.WriteLine($"{item.Name}: sells for {item.Price:C2}");
         }


     }*/


   /* class Program
    {
        static void Main()
        {
            var tempRecord = new TempRecord();

            // Use the indexer's set accessor
            tempRecord[3] = 58.3F;
            tempRecord[5] = 60.1F;
            const string name = "Jenish Kubavat";
            Console.WriteLine($"name: {name},Time: {DateTime.Now.ToString("HH:mm:ss tt")}");
            // Use the indexer's get accessor
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"Element #{i} = {tempRecord[i]}");
            }

            // Keep the console window open in debug mode.
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }*/
    
    /*class Program
    {
        static void Main()
        {
            const string name = "Jenish Kubavat";
            Console.WriteLine($"name: {name},Time: {DateTime.Now.ToString("HH:mm:ss tt")}");
            var week = new DayCollection();
            Console.WriteLine(week["Fri"]);

            try
            {
                Console.WriteLine(week["Made-up day"]);
            }
            catch (ArgumentOutOfRangeException e)
            {
                Console.WriteLine($"Not supported input: {e.Message}");
            }
        }
       
    }
    */
}
    