// Woody_Cashflowmanager
// IT112 
// NOTES: Quite a lot of repetitive things to do, but greatly appreciate the increased points in the assignment.
// BEHAVIORS NOT IMPLEMENTED AND WHY: Randomized the invoice number in the main as I didn't consider it a calculation, but you might? I don't know why you would though..
// Also, thanks for being a really chill and cool teacher. I enjoyed this class and actually learned a lot from it so yeah. Have a good summer,
// I hope to have you for another fall class! 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Woody_Cashflowmanager;

namespace Woody_CashFlowManager
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IPayable[] ArrayOfPayable = new IPayable[10];
            ArrayOfPayable[0] = new HourlyEmployee("Karen", "Williams" , "4444-44-4444" , 16.75m , 40, 0);    //All 6 of these (0 - 5 technically) are for the info already being displayed. Everything else will be added to this list.
            ArrayOfPayable[1] = new SalariedEmployee("John", "Smith", "111-11-1111", 800.50m);
            ArrayOfPayable[2] = new Invoice("266351_2536", 2, "Flux Capacitor", 3655.66m);
            ArrayOfPayable[3] = new HourlyEmployee("Carol", "Walsh", "333-33-3333", 19.50m, 40, 2);
            ArrayOfPayable[4] = new SalariedEmployee("Susan", "Mathews", "222-22-222", 1110.00m);
            ArrayOfPayable[5] = new Invoice("676677_5467", 3, "Flux Capacitor", 14.50m);
            string salempinv;
            int counter = 6;
            string FirstNameEnter;
            string LastNameEnter;
            string SSNEnter;
            decimal SalaryEnterDec;
            string SalaryEnter;
            string yesno;
            string OTHours;
            int OTHoursDec;
            string Hours;
            int HoursDec;
            string PartNum;
            int qtty;
            string qttystr;
            string itemname;
            int priceint;
            string pricestr;

            Random randomnumber = new Random();
            PartNum = randomnumber.Next(100000, 999999).ToString();
            PartNum = PartNum + "_";
            PartNum = PartNum + randomnumber.Next(1000, 9999).ToString(); //This is an RNG randomizer. I don't believe this counts as a calculation because there is by definition
                                                                          //no mathematical calculations. If you feel differently I would love to know if I got marked down for this though lol

            Console.WriteLine("Would you like to add to the expenses?");
            yesno = Console.ReadLine();

            while (yesno == "yes")
            {

                Console.WriteLine("Would you like to add a salaried employee, hourly employee, or invoice?");
                salempinv = Console.ReadLine();

                if (salempinv == "salaried employee")
                {
                    Console.WriteLine("Enter your salaried employee's first name");
                    FirstNameEnter = Console.ReadLine();

                    Console.WriteLine("Enter your salaried employee's last name");
                    LastNameEnter = Console.ReadLine();

                    Console.WriteLine("Enter your salaried employee's SSN");
                    SSNEnter = Console.ReadLine();

                    Console.WriteLine("Enter your salaried employee's Weekly Salary");
                    SalaryEnter = Console.ReadLine();
                    decimal.TryParse(SalaryEnter, out SalaryEnterDec);

                    ArrayOfPayable[counter] = new SalariedEmployee(FirstNameEnter, LastNameEnter, SSNEnter, SalaryEnterDec);

                    Console.WriteLine("\n");
                    Console.WriteLine("\n");

                    Console.WriteLine("Would you like to add another?");
                    yesno = Console.ReadLine();
                    counter++;

                }
                else if (salempinv == "hourly employee")
                {
                    Console.WriteLine("Enter your hourly employee's first name");
                    FirstNameEnter = Console.ReadLine();

                    Console.WriteLine("Enter your hourly employee's last name");
                    LastNameEnter = Console.ReadLine();

                    Console.WriteLine("Enter your hourly employee's SSN");
                    SSNEnter = Console.ReadLine();

                    Console.WriteLine("Enter your hourly employee's hourly Salary");
                    SalaryEnter = Console.ReadLine();
                    decimal.TryParse(SalaryEnter, out SalaryEnterDec);

                    Console.WriteLine("Enter your hourly employee's non-OT hours");
                    Hours = Console.ReadLine();
                    int.TryParse(Hours, out HoursDec);

                    Console.WriteLine("Enter your hourly employee's OT hours");
                    OTHours = Console.ReadLine();
                    int.TryParse(Hours, out OTHoursDec);

                    ArrayOfPayable[counter] = new HourlyEmployee(FirstNameEnter, LastNameEnter, SSNEnter, SalaryEnterDec, HoursDec, OTHoursDec);

                    Console.WriteLine("\n");
                    Console.WriteLine("\n");

                    Console.WriteLine("Would you like to add another?");
                    yesno = Console.ReadLine();
                    counter++;
                }
                else if (salempinv == "invoice")
                {

                    Console.WriteLine("Enter the name of the item you are purchasing");
                    itemname = Console.ReadLine();

                    Console.WriteLine("Enter the number of items you are purchasing");
                    qttystr = Console.ReadLine();
                    int.TryParse(qttystr, out qtty);

                    Console.WriteLine("Enter the price of the item(s) you are purchasing");
                    pricestr = Console.ReadLine();
                    int.TryParse(pricestr, out priceint);

                    Console.WriteLine("Generating part ID number..");
                    Thread.Sleep(1000);
                    Console.WriteLine("Success!");
                    Console.WriteLine("Part number: " + PartNum);

                    ArrayOfPayable[counter] = new Invoice(PartNum, qtty, itemname, priceint);

                    Console.WriteLine("\n");
                    Console.WriteLine("\n");

                    Console.WriteLine(" Would you like to add another?");
                    yesno = Console.ReadLine();
                    counter++;
                }
                else if (counter > 9)
                {
                    Console.WriteLine("Max number of accounts reached");
                }
                else
                {

                };

                
            };
            Console.Clear();
            Console.WriteLine("Weekly Cash Flow Analysis is as follows: \n");
            Console.WriteLine(ArrayOfPayable[0]);
            Console.WriteLine("");
            Console.WriteLine(ArrayOfPayable[1]);
            Console.WriteLine("");
            Console.WriteLine(ArrayOfPayable[2]);
            Console.WriteLine("");
            Console.WriteLine(ArrayOfPayable[3]);
            Console.WriteLine("");
            Console.WriteLine(ArrayOfPayable[4]);
            Console.WriteLine("");
            Console.WriteLine(ArrayOfPayable[5]);
            Console.WriteLine("");
            Console.WriteLine(ArrayOfPayable[6]);
            Console.WriteLine("");
            Console.WriteLine(ArrayOfPayable[7]);
            Console.WriteLine("");
            Console.WriteLine(ArrayOfPayable[8]);
            Console.WriteLine("");
            Console.WriteLine(ArrayOfPayable[9]);
            Console.WriteLine("");

        }

        
    }
} //Console.WriteLine(ArrayOfPayable[x].ToString());
//At end of each if statement, counter++