using EmployeeDepartment.Entities;
using EmployeeDepartment.Entities.Enums;
using System.Globalization;
namespace EmployeeDepartment
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Here, we gonna get employee information as well as their department, level and salary
            Console.WriteLine("Enter department's name: ");
            string dptName = Console.ReadLine();
            Console.Write("Enter worker data: ");
            string name = Console.ReadLine();
            Console.WriteLine("Level: |0) Junior |1) MidLevel |2) Senior: ");
            WorkerLevel workerLevel = Enum.Parse<WorkerLevel>(Console.ReadLine());
            Console.WriteLine("Base Salary: ");
            double baseSalary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //instance to create department and employee
            Department dept = new Department(dptName);
            Worker worker = new Worker(name, workerLevel, baseSalary, dept);

            // the number of contracts will trigger for loop below
            Console.WriteLine("How many contracts data: ");
            int numberContracts = int.Parse(Console.ReadLine());


            //this for will go through the contracts that we took above. 
            for (int i = 1; i < numberContracts; i++)

            {
                Console.WriteLine($"Enter #{i} contract data");
                Console.Write("Date (DD/MM/YYYY): ");
                DateTime date = DateTime.Parse(Console.ReadLine());
                Console.WriteLine("Value Per Hour: ");
                double valueHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.WriteLine("Duration (Hours): ");
                int durationHours = int.Parse(Console.ReadLine());
                HourContract hourContract = new HourContract(date, valueHour, durationHours);
                worker.AddContract(hourContract);
            }

            //
            Console.WriteLine();
            Console.Write("Enter month and year to calculate income (MM/YYYY): ");
            string monthYear = Console.ReadLine();
            int month = int.Parse(monthYear.Substring(0, 2));
            int year = int.Parse(monthYear.Substring(3, 6));

            Console.WriteLine("Name: " + worker.Name);
            Console.WriteLine("Department: " + worker.Department.name);
            Console.WriteLine("Income for: " + monthYear + " : " + worker.Income(month, year));


        }
    }
}