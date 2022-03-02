using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4Emp_Uc3_PartTimeFullTimeWage
{
    internal class ComputeDailyWage
    {
        //constant
        public const int SalaryPerHr = 20;
        public const int FullTime = 1;
        public const int PartTime = 2;

        //variable initialization
        public static int empHr = 0;
        public static int TotalWage = 0;
        public static Random random = new Random();
        public static int check = random.Next(0, 3);

        ///compute daily wage be selection method
        public void DailyWage()
        {
            //conditional statment
            if (check == FullTime)
            {
                empHr = 8;
            }
            else if(check == PartTime)
            {
                empHr = 4;
            }
            else
            {
                empHr = 0;

            }
            //wages of employee
            TotalWage = SalaryPerHr * empHr;
            Console.WriteLine("DailyEmpWages Wages of Employee: " + TotalWage);
        }
    }
}
