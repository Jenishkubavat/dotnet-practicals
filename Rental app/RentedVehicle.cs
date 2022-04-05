using System;
using Vehicle;
namespace RentingVehicleSystem
{
    public class CarType<T>
    {
        internal T carobj;
        internal DateOnly rentStartDate, rentEndDate;
        internal int Units;
        internal decimal advancePayment;

        internal CarType(T carobj, DateOnly rentStartDate, DateOnly rentEndDate, decimal advancePayment)
        {
            this.carobj = carobj;
            this.advancePayment = advancePayment;
            this.rentStartDate = rentStartDate;
            this.rentEndDate = rentEndDate;
        }

        internal CarType(T carobj)
        {
            this.carobj = carobj;
        }
        internal int CalculateDays()
        {
            int year = rentEndDate.Year - rentStartDate.Year;
            int month = rentEndDate.Month - rentStartDate.Month;
            int day = rentEndDate.Day - rentStartDate.Day;
            return year + month + day;
        }
    }
    internal class RentedVehicle<T>
    {
        List<CarType<T>> Vehiclelist;
        internal RentedVehicle()
        {
            Vehiclelist = new List<CarType<T>>();
        }
        internal void AddVehicle(T carobj)
        {
            CarType<T> c = new CarType<T>(carobj);
        }
        internal void GiveForRent(T carobj, DateOnly rentStartDate, DateOnly rentEndDate, decimal apay)
        {
            CarType<T> c = new CarType<T>(carobj, rentStartDate, rentEndDate, apay);
            Vehiclelist.Add(c);
        }
        internal decimal CalculateRent(T carobj, int Units)
        {
            foreach (CarType<T> c in Vehiclelist)
            {
                if (c.carobj!.Equals(carobj))
                {
                    c.Units = Units;
                    return ((IVehicle)carobj).CalculateRent(Units) - c.advancePayment;
                }
            }
            return 0;
        }
        internal decimal CalculateTotalRentToday(T carobj, int TrentedVehicleaelUnits)
        {
            foreach (CarType<T> c in Vehiclelist)
            {
                if (c.carobj!.Equals(carobj))
                {
                    return (((IVehicle)carobj).CalculateRent(TrentedVehicleaelUnits) - c.advancePayment) / c.CalculateDays();
                }
            }
            return 0;
        }
        internal void GetCheckListRentedVehicle()
        {
            foreach (CarType<T> c in Vehiclelist)
            {
                ((IVehicle)c.carobj!).getDetails();
                Console.Write($"Rented From {c.rentStartDate} to {c.rentEndDate}\n");
            }
        }
        internal bool CheckVehiclesInMaintenance(T carobj)
        {
            DateOnly today = DateOnly.FromDateTime(DateTime.Today);
            foreach (CarType<T> c in Vehiclelist)
            {
                IVehicle car = ((IVehicle)c.carobj!);
                if (c.carobj!.Equals(carobj) && car.getLastMaintenanceDate().CompareTo(today) > 0)
                    return true;
            }
            return false;
        }
        internal void ShowAvailableByDate(DateOnly date)
        {
            Console.Write($"\nAvailable Vehicles on {date} : \n");
            foreach (CarType<T> c in Vehiclelist)
            {
                if (c.rentStartDate.CompareTo(date) > 0)
                {
                    ((IVehicle)c.carobj!).getDetails();
                }
            }
        }
    }


}
