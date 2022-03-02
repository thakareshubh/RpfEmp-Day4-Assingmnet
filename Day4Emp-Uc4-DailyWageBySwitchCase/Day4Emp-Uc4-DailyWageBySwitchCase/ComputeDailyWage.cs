using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4Emp_Uc4_DailyWageBySwitchCase
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
        public static int check = random.Next(0, 2);

        //compute daily wage by switch case
        public void DailyWage()
        {
            switch(check)
            {
                case FullTime: empHr=8; break;

                case PartTime: empHr=4; break;

                default: empHr=0; break;
            }
            //wages of employee
            TotalWage = SalaryPerHr * empHr;
            Console.WriteLine("DailyEmpWages Wages of Employee: " + TotalWage);
        }


    }
}
