using System;
using System;

namespace Vehicle
{

    internal interface IVehicle
    {
        internal enum Erenttype
        {
            KM, Day
        }
        internal decimal CalculateRent(int Units);
        internal void getDetails();
        internal DateOnly getLastMaintenanceDate();
    }

    internal class Indica : IVehicle
    {
        internal string? type, number;
        internal IVehicle.Erenttype renttype;
        internal int age, rentperunit, noOfseats;
        internal DateOnly lastMaintenanceDate;

        internal Indica(string type, int noOfseats, string number, IVehicle.Erenttype rentType, int age, int rentperunit, DateOnly lastMaintenanceDate)
        {
            this.type = type;
            this.noOfseats = noOfseats;
            this.number = number;
            renttype = rentType;
            this.age = age;
            this.rentperunit = rentperunit;
            this.lastMaintenanceDate = lastMaintenanceDate;
        }

        public decimal CalculateRent(int Units)
        {
            return (decimal)rentperunit * Units;
        }

        public void getDetails()
        {
            Console.Write("\nBrand         : Indica \n");
            Console.Write($"Vehicle Number    : {number}\n");
            Console.Write($"Total Seats   : {noOfseats}\n");
            Console.Write($"Type          : {type}\n");
            Console.Write($"Vehicle age       : {age}\n");
            Console.Write($"Rent per unit : {rentperunit}\n");
        }

        public DateOnly getLastMaintenanceDate()
        {
            return lastMaintenanceDate;
        }
    }

    internal class Qualis : IVehicle
    {
        internal string? type, number;
        internal IVehicle.Erenttype renttype;
        internal int age, rentperunit, noOfseats;
        internal DateOnly lastMaintenanceDate;

        internal Qualis(string type, int noOfseats, string number, IVehicle.Erenttype rentType, int age, int rentperunit, DateOnly lastMaintenanceDate)
        {
            this.type = type;
            this.noOfseats = noOfseats;
            this.number = number;
            renttype = rentType;
            this.age = age;
            this.rentperunit = rentperunit;
            this.lastMaintenanceDate = lastMaintenanceDate;
        }

        public decimal CalculateRent(int Units)
        {
            return (decimal)rentperunit * Units;
        }

        public void getDetails()
        {
            Console.Write("\nBrand         : Qualis \n");
            Console.Write($"Vehicle Number    : {number}\n");
            Console.Write($"Total Seats   : {noOfseats}\n");
            Console.Write($"Type          : {type}\n");
            Console.Write($"Vehicle age       : {age}\n");
            Console.Write($"Rent per unit : {rentperunit}\n");
        }

        public DateOnly getLastMaintenanceDate()
        {
            return lastMaintenanceDate;
        }
    }

    internal class HarleyDavid : IVehicle
    {
        internal string? number;
        internal IVehicle.Erenttype renttype;
        internal int age, rentperunit;
        internal DateOnly lastMaintenanceDate;

        internal HarleyDavid(string number, IVehicle.Erenttype rentType, int age, int rentperunit, DateOnly lastMaintenanceDate)
        {
            this.number = number;
            renttype = rentType;
            this.age = age;
            this.rentperunit = rentperunit;
            this.lastMaintenanceDate = lastMaintenanceDate;
        }

        public decimal CalculateRent(int Units)
        {
            return (decimal)rentperunit * Units;
        }

        public void getDetails()
        {
            Console.Write("\nBrand         : HarleyDavid \n");
            Console.Write($"Vehicle Number    : {number}\n");
            Console.Write($"Vehicle age       : {age}\n");
            Console.Write($"Rent per unit : {rentperunit}\n");
        }

        public DateOnly getLastMaintenanceDate()
        {
            return lastMaintenanceDate;
        }
    }

    internal class MercedesBenz : IVehicle
    {
        internal string? number;
        internal IVehicle.Erenttype renttype;
        internal int age, rentperunit, noOfseats;
        internal DateOnly lastMaintenanceDate;

        internal MercedesBenz(int noOfseats, string number, IVehicle.Erenttype rentType, int age, int rentperunit, DateOnly lastMaintenanceDate)
        {
            this.noOfseats = noOfseats;
            this.number = number;
            renttype = rentType;
            this.age = age;
            this.rentperunit = rentperunit;
            this.lastMaintenanceDate = lastMaintenanceDate;
        }

        public decimal CalculateRent(int Units)
        {
            return (decimal)rentperunit * Units;
        }

        public void getDetails()
        {
            Console.Write("\nBrand         : MercedesBenz \n");
            Console.Write($"Vehicle Number    : {number}\n");
            Console.Write($"Total Seats   : {noOfseats}\n");
            Console.Write($"Vehicle age       : {age}\n");
            Console.Write($"Rent per unit : {rentperunit}\n");
        }

        public DateOnly getLastMaintenanceDate()
        {
            return lastMaintenanceDate;
        }
    }
    
}
