using System;
namespace Employee
{
     class Employee
    {
        internal string firstName;
        internal string lastName;
        internal double salary;

        internal Employee(string firstName ,string lastName ,double salary )
        {
            this.firstName =firstName;
            this.lastName =lastName;
            if (salary > 0)
            {
                this.salary = salary;
            }
            else
            {
                this.salary = 0.0;
            }
        }
        internal string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }
        internal string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }
        internal double Salary
        {
            get { return salary; }
            set { salary = value; }
        }
        internal virtual double giveRaise(double raise)
        {
            return salary += ((salary * raise) / 100);

        }
        public override string ToString()
        {
            return $"employee {firstName} {lastName} has salary of{salary}Rs";
        }
    }
    class PermanentEmployee : Employee
    {
        private double hoursingRentAllowance;
        private double dearnessAllowance;
        private double providentFund;
        private string joiningDate;
        private string retirementDate;
         internal PermanentEmployee( string firstName,string lastName,double salary, double hoursingRentAllowance, double dearnessAllowance, double providentFund, string joiningDate, string retirementDate) : base(firstName,lastName, salary)
        {
            this.hoursingRentAllowance = hoursingRentAllowance;
            this.joiningDate = joiningDate;
            this.retirementDate = retirementDate;
            this.dearnessAllowance = dearnessAllowance;
            this.providentFund = providentFund;
            this.salary = salary+ hoursingRentAllowance+ dearnessAllowance;
        }
        internal double HoursingRentAllowance
        {
            get => hoursingRentAllowance;
            set => hoursingRentAllowance = value;
        }
        internal double DearnessAllowance
        {
            get => dearnessAllowance;
            set => hoursingRentAllowance = value;
                                               
        }
        internal double ProvidentFund
        {
            get => providentFund;
            set =>  providentFund = value;
        }
        internal string JoiningDate
        {
            get => joiningDate;
            set => joiningDate = value;

        }internal string RetirementDate
        {
            get => retirementDate;
            set => retirementDate = value;
        }
        internal override double giveRaise(double raise)
        {
            return (base.giveRaise(raise)+ dearnessAllowance + hoursingRentAllowance);

        }
        public override string ToString()
        {
            return $"{base.ToString()}\nJoining date: {joiningDate}\nRetirement date:{retirementDate}";
        }

    }
}
