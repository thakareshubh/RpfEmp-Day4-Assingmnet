using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4Emp_Uc6_WorkingHrDayReached
{
    internal class ComputeWorkingHrAndDay
    {
        //constan
        public const int FullTime = 1;
        public const int PartTime = 2;
        public const int SalaryPerHr = 20;
        public const int MaxDayOfWorking = 20;
        public const int TotalWorkingHr = 100;

        //variables
        public int WorkingDay = 0;
        public int WorkingHour = 0;
        public int empHr =0;

        ///compute total salar in month
        
        public void WorkDayCompute()
        {
            while (WorkingDay <= MaxDayOfWorking || WorkingHour <= TotalWorkingHr)
            {

                WorkingDay++;

                Random random = new Random();
                int check = random.Next(0, 3);
                if (check == FullTime)
                {
                    empHr = 8;
                }
                else if (check == PartTime)
                {
                    empHr = 4;
                }
                else
                {
                    empHr = 0;
                }

                WorkingHour = WorkingHour + empHr;
            }

            int TotalSalary = WorkingHour * SalaryPerHr;
            Console.WriteLine("Total salary of Employee: " + TotalSalary);
        }
    }
    
}
