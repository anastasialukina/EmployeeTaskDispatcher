using System;
using System.Collections.Generic;

namespace Company
{
    class Program
    {
        static void Main(string[] args)
        {
            var webDepartment = new WebDepartment(new List<Employee>
            {
                new WebDeveloper(new FullName("Orlov", "Vasiliy", "Timofeevich"),
                    TaskType.WebApp, 0, 90),
                new WebDeveloper(new FullName("Petrova", "Elizaveta", "Igorevna"),
                    TaskType.WebApp, 2, 98)
            });
            Console.WriteLine("WDevs:" + webDepartment.Employees[0].TimeToComplete + " " +
                              webDepartment.Employees[1].TimeToComplete);
            var desktopDepartment = new DesktopDepartment(new List<Employee>
            {
                new DesktopDeveloper(new FullName("Grigoriev", "Alexander", "Petrovich"),
                    TaskType.DesktopApp, 1, 78),
                new DesktopDeveloper(new FullName("Figova", "Olga", "Alexeevna"),
                    TaskType.DesktopApp, 0, 86)
            });
            Console.WriteLine("DDevs:" + desktopDepartment.Employees[0].TimeToComplete + " " +
                              desktopDepartment.Employees[1].TimeToComplete);
            var mobileDepartment = new MobileDepartment(new List<Employee>
            {
                new MobileDeveloper(new FullName("Alyoshina", "Oxana", "Victorovna"),
                    TaskType.MobileApp, 0, 85),
                new MobileDeveloper(new FullName("Vasilkova", "Anna", "Nikolaevna"),
                    TaskType.MobileApp, 3, 89)
            });
            Console.WriteLine("MDevs:" + mobileDepartment.Employees[0].TimeToComplete + " " +
                              mobileDepartment.Employees[1].TimeToComplete);
            var company = new Company("My company",
                new List<Department>()
                {
                    webDepartment,
                    desktopDepartment,
                    mobileDepartment
                });

            Console.WriteLine("Order number 1:");

            var order1 = new Order("Order1", new[]
            {
                TaskType.DesktopApp,
                TaskType.WebApp
            }, 60);
            Console.WriteLine(order1.TimeInHours);
            var productsForOrder1 = new Product[] { };
            var flagForOrder1 = company.CompleteTheOrder(order1, ref productsForOrder1);
            if (flagForOrder1)
            {
                Console.WriteLine("Can be done");

                foreach (var product in productsForOrder1)
                {
                    Console.WriteLine(product.GetTitle());
                }
            }
            else Console.WriteLine("Can not be done");

            Console.WriteLine("...");
            Console.WriteLine("Order number 2:");

            var order2 = new Order("Order2", new[]
            {
                TaskType.MobileApp,
                TaskType.DesktopApp
            }, 85);
            Console.WriteLine(order2.TimeInHours);
            var productsForOrder2 = new Product[] { };
            var flagForOrder2 = company.CompleteTheOrder(order2, ref productsForOrder2);
            if (flagForOrder2)
            {
                Console.WriteLine("Can be done");

                foreach (var product in productsForOrder2)
                {
                    Console.WriteLine(product.GetTitle());
                }
            }
            else Console.WriteLine("Can not be done");

            Order order3 = null;
            var productsForOrder3 = new Product[] { };
            var flagForOrder3 = company.CompleteTheOrder(order3, ref productsForOrder3);
            if (flagForOrder3)
            {
                Console.WriteLine("Can be done");

                foreach (var product in productsForOrder3)
                {
                    Console.WriteLine(product.GetTitle());
                }
            }
            else Console.WriteLine("Can not be done");
        }
    }
}