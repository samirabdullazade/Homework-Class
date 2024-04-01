using System;

namespace Homework_Class
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            Book book = new Book("Yaradılışın Hədəfi", "Hacı Şahin", "Parlaq İmzalar", 1500);
            book.IncreaseCopies(200);
            book.DecreaseCopies(2000);
            book.DisplayBookInfo();





            Employee employee = new Employee(114, "Samir", "Menecer", 345);

            employee.UpdateSalary(600);

            Console.WriteLine("Employee 114:");
            employee.DisplayEmployeeInfo();
        }
    }
}
