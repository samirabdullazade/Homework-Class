using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_Class
{
    internal class Employee
    {
        private int employeeID;
        private string name;
        private string position;
        private decimal salary;

        // Constructor
        public Employee(int employeeID, string name, string position, decimal salary)
        {
            EmployeeID = employeeID;
            Name = name;
            Position = position;
            Salary = salary;
        }

        // Employee ID property
        public int EmployeeID
        {
            get { return employeeID; }
            private set
            {
                if (value <= 0)
                {
                    Console.WriteLine("ID-nizi daxil edin.");
                }
                employeeID = value;
            }
        }

        // Name property
        public string Name
        {
            get { return name; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    Console.WriteLine("Adınızı daxil edin.");
                }
                name = value;
            }
        }

        // Position property
        public string Position
        {
            get { return position; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    Console.WriteLine("Vəzifənizi qeyd edin.");
                }
                position = value;
            }
        }

        // Salary property
        public decimal Salary
        {
            get { return salary; }
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("Maaşınızı qeyd edin.");
                }
                salary = value;
            }
        }

        // Method to update employee's salary
        public void UpdateSalary(decimal newSalary)
        {
            if (newSalary < 0)
            {
                Console.WriteLine("Maaşınızı düzgün qeyd edin.");
            }
            Salary = newSalary;
        }

        // Method to change employee's position
        public void ChangePosition(string newPosition)
        {
            if (string.IsNullOrEmpty(newPosition))
            {
                Console.WriteLine("Vəzifənizi qeyd edin.");
            }
            Position = newPosition;
        }
        public void DisplayEmployeeInfo()
        {
            Console.WriteLine($"ID: {EmployeeID}");
            Console.WriteLine($"Ad: {Name}");
            Console.WriteLine($"Vəzifə: {Position}");
            Console.WriteLine($"Maaş: {Salary}");
        }
    }
}
