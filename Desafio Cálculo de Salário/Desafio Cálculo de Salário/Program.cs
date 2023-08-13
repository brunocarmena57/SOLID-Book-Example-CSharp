using System;

namespace SalaryCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Salary Calculator");

            Console.Write("Enter employee name: ");
            string name = Console.ReadLine();

            Console.Write("Enter employee role (DEV, DBA, TESTER): ");
            string role = Console.ReadLine();

            Console.Write("Enter employee salary: ");
            double salary = Convert.ToDouble(Console.ReadLine());

            Employee employee;

            if (role == "DEV")
            {
                employee = new Developer(name, salary);
            }
            else if (role == "DBA")
            {
                employee = new DBA(name, salary);
            }
            else if (role == "TESTER")
            {
                employee = new Tester(name, salary);
            }
            else
            {
                Console.WriteLine("Invalid role");
                return;
            }

            double calculatedSalary = employee.CalculateSalary();

            Console.WriteLine($"Employee: {name}");
            Console.WriteLine($"Role: {role}");
            Console.WriteLine($"Calculated Salary: R${calculatedSalary:N2}");
        }
    }

    abstract class Employee
    {
        public string Name { get; }
        public double BaseSalary { get; }

        public Employee(string name, double baseSalary)
        {
            Name = name;
            BaseSalary = baseSalary;
        }

        public abstract double CalculateSalary();
    }

    class Developer : Employee
    {
        public Developer(string name, double baseSalary) : base(name, baseSalary)
        {
        }

        public override double CalculateSalary()
        {
            if (BaseSalary > 3000)
            {
                return BaseSalary * 1.10;
            }
            else
            {
                return BaseSalary * 1.20;
            }
        }
    }

    class DBA : Employee
    {
        public DBA(string name, double baseSalary) : base(name, baseSalary)
        {
        }

        public override double CalculateSalary()
        {
            if (BaseSalary > 3000)
            {
                return BaseSalary * 1.15;
            }
            else
            {
                return BaseSalary * 1.20;
            }
        }
    }

    class Tester : Employee
    {
        public Tester(string name, double baseSalary) : base(name, baseSalary)
        {
        }

        public override double CalculateSalary()
        {
            if (BaseSalary > 3000)
            {
                return BaseSalary * 1.15;
            }
            else
            {
                return BaseSalary * 1.20;
            }
        }
    }
}
