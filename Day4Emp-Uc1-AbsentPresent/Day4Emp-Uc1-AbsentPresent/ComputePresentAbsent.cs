using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4Emp_Uc1_AbsentPresent
{
    public class ComputePresentAbsent
    {
        //variable initialization
       public const int isPresent = 1;
       public static Random random = new Random();
       public static int check = random.Next(0, 2);

        ///create selection methode to find present or absent
       public void Compute()
        {
            if (check == isPresent)
            {
                Console.WriteLine("Employee is present");
            }
            else
            {
                Console.WriteLine("Employee is not present");
            }
        }
    }
}
