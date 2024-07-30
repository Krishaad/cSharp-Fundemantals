using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_Fundemantals
{
    class BethanyPieShop
    {

        static void Main(string[] args)
        {
            
            //UsingValueParameters();
            //UsingParams();
            UsingStruct();
            //UsingEnumerations();
            Console.ReadLine();
        }

        private static void UsingStruct()
        {
            Employee employee;
            employee.Name = "Bethany";
            employee.Wage = 1250;
            employee.Work();
        }

        private static void UsingEnumerations()
        {
            EmployeeType employeeType = EmployeeType.Manager;
            StoreType storeType = StoreType.Seating;
            int baseWage = 1000;

            CalculateWage(baseWage,employeeType,storeType);
        }

        public static void UsingValueParameters()
        {
            int monthlyWage = 1234;
            int months = 12;
            int bonus = 1000;
            int yearlyWage = CalculateYearlyWage(monthlyWage, months);
            int yearlyWageWithBonus = CalculateYearlyWage(monthlyWage, months, bonus);
           // Console.WriteLine($"Yearly wage is {yearlyWage}");
            //Console.WriteLine($"Yearly wage after bonus is {yearlyWageWithBonus}");

            //int a = 10;
            //modifyNum(ref a);
            //Console.WriteLine(a);
        }

        public static int CalculateYearlyWage(int monthlyWage, int numberOfMonthsWorked)
        {
            //Console.WriteLine($"Yearly wage: {monthlyWage*numberOfMonthsWorked}");
            return monthlyWage * numberOfMonthsWorked;
        }

        public static int CalculateYearlyWage(int monthlyWage, int numberOfMonthsWorked, int bonus)
        {
            return monthlyWage * numberOfMonthsWorked + bonus;
        }

        public static void modifyNum(ref int a)
        {
            a = 20;
        }

        private static void UsingParams()
        {
            int monthlyWage = 1234, monthlyWage2 = 2345, monthlyWage3 = 3456, monthlyWage4 = 4567;
            int average = CalculateAverageWage(monthlyWage, monthlyWage2,monthlyWage3,monthlyWage4);
            Console.WriteLine($"month 1 wage = {monthlyWage}, month2 = {monthlyWage2}, month3 = {monthlyWage3}, month4 = {monthlyWage4}");
            Console.WriteLine($"Average wage is {average}");

        }

        private static int CalculateAverageWage(params int[] wage)
        {
            int total = 0;
            int numberOfWages = wage.Length;

            for(int i = 0;i < numberOfWages; i++) 
            {
                total += wage[i];
            }

            return total / numberOfWages;

        }

        private static void CalculateWage(int baseWage, EmployeeType employeeType, StoreType storeType)
        {
            int calculateWage = 0;
            if (employeeType == EmployeeType.Manager)
            {
                calculateWage = baseWage * 3;
            }
            else
            {
                calculateWage = baseWage * 2;
            }

            if (storeType == StoreType.FullPieRestaraunt)
            {
                calculateWage += 500;
            }

            Console.WriteLine($"The calculated wage is {calculateWage}");
        }



    }

    enum EmployeeType
    {
        Sales,//0
        Manager,//1
        Research,//2
        StoreManager//3
    }

    enum StoreType
    {
        PieCorner = 10,
        Seating = 20,
        FullPieRestaraunt = 100,
        Undefined = 99
    }

    struct Employee
    {
        public string Name;
        public int Wage;

        public void Work()
        {
            Console.WriteLine($"{Name} is now doing work");
        }
    }


}
