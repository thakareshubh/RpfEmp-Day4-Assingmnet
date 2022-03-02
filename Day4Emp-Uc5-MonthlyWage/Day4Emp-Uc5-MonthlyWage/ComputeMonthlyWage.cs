using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4Emp_Uc5_MonthlyWage
{
    internal class ComputeMonthlyWage
    {
        //constant
        public const int SalaryPerHr = 20;
        public const int  FullTime = 1;
        public const int  parttime = 2;

        //variable
        public int empHr = 0;
        public int TotalWage = 0;

        ///Compute monthly salary of employee
        
        public void MonthlyWage()
        {
            for (int i = 1; i <= 20; i++)
            {
                Random random = new Random();
                int check = random.Next(0, 3);

                if (check == FullTime)
                {
                    empHr = 8;
                }
                else if (check == parttime)
                {
                    empHr = 4;
                }
                else
                {
                    empHr = 0;
                }
                TotalWage = TotalWage + empHr * SalaryPerHr;
            }
            Console.WriteLine("Monthly Wage of Employee is: " + TotalWage);
        }
    }
}
