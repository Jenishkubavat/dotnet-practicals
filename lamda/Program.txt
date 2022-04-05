using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp18jan2022
{
    class BubbleSorter 
    {
        static public void Sort<T>(IList<T> sortArray, Func<T, T, bool> comparision)
        {
            /*
            bool swapped = true;
            do
            {
                swapped = false;
                for (int i = 0; i < sortArray.Count - 1; i++)
                {
                    if (comparision(sortArray[i], sortArray[i + 1]))   //element comparision true or false  1 or 0 -1
                    {
                        T temp = sortArray[i];

                        sortArray[i] = sortArray[i + 1];
                        sortArray[i + 1] = temp;
                        
                        swapped = true;
                    }

                }
            } while (swapped);

        }*/

            for (int i = 1; i < sortArray.Count - 1; i++)
            {
                for (int j = i + 1; j > 0; j--)
                {
                    IComparable currentitem = (IComparable)sortArray[i];
                    IComparable nextitem = (IComparable) sortArray[j];
                     int isgreater= nextitem.CompareTo(currentitem);
                    if (isgreater == 1)
                    {
                        T temp = sortArray[i];
                        sortArray[i]=sortArray[j];
                        sortArray[j]=temp;
                    }
                    {

                    }
                }

            }
        }
        public enum Designations
        {
            CEO = 5,
            CFO = 4,
            sde = 2,
            ba = 1,
            pm = 3
        }

        class Employee
        {
            int empid;
            float salary;
            public string name;
            Designations designation;

            public Employee(int EmpId, float Salary, string NAme, Designations design)
            {
                this.empid = EmpId;
                this.salary = Salary;
                this.name = NAme;
                this.designation = design;

            }

            internal static bool CompareSalary(Employee e1, Employee e2)
            {
                return e1.salary < e2.salary;
            }

            internal static bool CompareNames(Employee e1, Employee e2)
            {
                if (e1.name.CompareTo(e2.name) == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }

            }

            internal static bool CompareDesignations(Employee e1, Employee e2)
            {
                return e1.designation < e2.designation;
            }
        }


        public class TestGenericMethods
        {
            public static void Main(string[] args)
            {
                List<Employee> emplist = new List<Employee>(30);
                emplist.Add(new Employee(5, 500000, "ABCD", Designations.CFO));

                emplist.Add(new Employee(8, 12000000, "EFGH", Designations.CEO));

                emplist.Add(new Employee(1, 25000, "JKLM", Designations.sde));


                BubbleSorter.Sort<Employee>(emplist, Employee.CompareDesignations);

                foreach (Employee e1 in emplist)
                {
                    Console.WriteLine(e1.name);
                }
            }
        }
    }
}
