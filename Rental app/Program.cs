using System;
using Vehicle;
using RentingVehicleSystem;
namespace MainProgram
{

    class Program
    {
        static void Main(string[] args)
        {

            const string name = "Jenish Kubavat";
            Console.WriteLine($"name: {name},Time: {DateTime.Now.ToString("HH:mm:ss tt")}\n\n\n");

            MercedesBenz MB1 = new MercedesBenz(5, "khklhkssdh", IVehicle.Erenttype.KM, 3, 100, new DateOnly(2022, 01, 12));
            Indica indica = new Indica("Petrol", 7, "123lkfd", IVehicle.Erenttype.Day, 5, 60, new DateOnly(2021, 9, 27));
            Qualis qaualis1 = new Qualis("Diesel", 7, "ZGA18y", IVehicle.Erenttype.KM, 5, 15, new DateOnly(2021, 07, 12));
            MercedesBenz MB2 = new MercedesBenz(5, "cZ375c", IVehicle.Erenttype.KM, 10, 10, new DateOnly(2012, 01, 21));
            Qualis qaualis2 = new Qualis("CNG", 9, "wWA76s", IVehicle.Erenttype.KM, 10, 16, new DateOnly(2022, 02, 25));
            HarleyDavid hd = new HarleyDavid("XbA27FAAA", IVehicle.Erenttype.KM, 01, 100, new DateOnly(2022, 01, 12));
            RentedVehicle<IVehicle> rentedVehicle = new RentedVehicle<IVehicle>();
            rentedVehicle.AddVehicle(indica);
            rentedVehicle.AddVehicle(MB2);
            rentedVehicle.AddVehicle(qaualis1);
            rentedVehicle.AddVehicle(qaualis2);
            rentedVehicle.AddVehicle(MB1);
            rentedVehicle.AddVehicle(hd);

            rentedVehicle.GiveForRent(MB1, new DateOnly(2022, 03, 05), new DateOnly(2022, 06, 20), 3500);
            rentedVehicle.GiveForRent(indica, new DateOnly(2021, 12, 25), new DateOnly(2022, 02, 25), 300);
            rentedVehicle.GiveForRent(MB2, new DateOnly(2022, 02, 10), new DateOnly(2022, 05, 30), 1500);
            rentedVehicle.GiveForRent(qaualis2, new DateOnly(2022, 03, 10), new DateOnly(2022, 09, 10), 500);
            rentedVehicle.GiveForRent(hd, new DateOnly(2022, 04, 07), new DateOnly(2022, 04, 17), 3000);
            Console.Write("Total rent per day for the Harley David : ");
            Console.Write("\n");
            hd.getDetails();
            Console.Write("\n");
            rentedVehicle.ShowAvailableByDate(new DateOnly(2022, 02, 25));
            Console.Write("\n");
            Console.Write("Currently Rented Vehicles :");
            Console.Write("\n");
            rentedVehicle.GetCheckListRentedVehicle();
            Console.Write("\n");
            Console.Write($"Total rent for today : {rentedVehicle.CalculateTotalRentToday(MB1, 5):C2}\n\n");

        }

    }

}