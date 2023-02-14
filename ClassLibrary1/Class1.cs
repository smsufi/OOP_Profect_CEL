using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using static ClassLibrary1.Class1;

namespace ClassLibrary1
{
    public class Class1
    {
        public class SalaryType
        {
            protected void Type(int sal)
            {
                if (sal > 10000)
                    Console.WriteLine("You have a good Salary Range");
                else
                    Console.WriteLine("You have a poor Salary Range");
            }
        }

        public class Salary : SalaryType
        {
                       
            public void SalaryAcess(int salary)
            {
                //passing the value of salary to the parent protected class
                Type(salary);

            }            
        }


        public abstract class accLevel
        {
            //private access modifier used
            private int limit = 5000;

            public void level(int deposit)
            {
                if (deposit >= limit)
                    Console.WriteLine("Account is premium");
                else
                    Console.WriteLine("Account is not premium");
            }            
            public abstract void interest(int deposit);

        }

        public class interestAmount : accLevel
        {
            public override void interest(int deposit)
            {
                //interestPercentage = deposit/10;
                Console.WriteLine($"10% interest of your deposited amount will be {deposit/10}");
            }
        }

        

    }
}
