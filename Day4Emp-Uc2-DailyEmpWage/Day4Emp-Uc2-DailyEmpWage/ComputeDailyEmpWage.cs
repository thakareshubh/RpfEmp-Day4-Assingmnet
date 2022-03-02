using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4Emp_Uc2_DailyEmpWage
{
    internal class ComputeDailyEmpWage
    {
        //constant
        public const int SalaryPerHr = 20;
        public const int FullTime = 1;

        //variable initialization
        public static int empHr = 0;
        public static int TotalWage = 0;
        public static Random random = new Random();
        public static int check = random.Next(0, 2);

        ///compute daily wage be selection method
        public void DailyWage()
        {
            //conditional statment
            if (check == FullTime)
            {
                empHr = 8;
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
