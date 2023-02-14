using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using static ClassLibrary1.Class1;

namespace OOP_Assignment
{
    public class Program
    {
        static int mainBalance = 1000;
        //mainBalance is a static integer value
        static void Main(string[] args)
        {
            Console.Write("Please enter your name: ");
            string name = Console.ReadLine();
       
            Console.Write("Enter deposit amount: ");
            int deposit = Convert.ToInt32(Console.ReadLine());

            //object of BankCal class which inherites BlncCal interface
            BlncCal bankObj = new BankCal();    

            int currentBal;
            currentBal = bankObj.CurrentBal(name, mainBalance, deposit);

            //creating instances of reference project classes
            interestAmount interest = new interestAmount();
            accLevel level = interest;

            //passing value of deposited amount to abstract class and child class
            level.level(deposit);
            level.interest(deposit);

            Console.Write("Enter your salary: ");
            int sal = Convert.ToInt32(Console.ReadLine());

            //passing the value of salary to reference project's class
            Salary salary = new Salary();
            salary.SalaryAcess(sal);

            //makes the program wait for a key press
            Console.ReadKey();

        }
    }

    public class BankDetails
    {
        protected void accName(string name)
        {
            Console.WriteLine($"Your account name is {name}");
        }

        protected void accDeposit(int deposit)
        {
            Console.WriteLine($"Your deposited amount is {deposit}");
        }
    }


    interface BlncCal
    {
        int CurrentBal(string accName, int depositAmount, int prevBalance);

    }

    public class BankCal : BlncCal      //interface implementation
    {
        int BlncCal.CurrentBal(string accName, int depositAmount, int prevBalance)
        { 
            Console.WriteLine($"After depositing, your current balance of {accName} is {depositAmount + prevBalance}");
            return depositAmount + prevBalance;
        }
    }
}
