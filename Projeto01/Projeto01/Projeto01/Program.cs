﻿using System;
using System.Collections.Generic;
using System.Globalization;
using Projeto01.Entities;

namespace Projeto01
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> list = new List<Employee>();

            Console.Write("Enter the number for employees: ");

            int n = int.Parse(Console.ReadLine());

            for (int i= 1; i <= n; i++)
            {
                Console.WriteLine($"Employee # {i} data: ");
                Console.Write("Outsourced (y/n)?");
                char ch = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Hours: ");
                int hours = int.Parse(Console.ReadLine());
                Console.Write("Value per hour: ");
                double valuePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (ch == 'y')
                {
                    Console.Write("Additional charge: ");
                    double addditionalCharge = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new OutsourceEmployee(name, hours, valuePerHour, addditionalCharge));
                }

                else
                {
                    list.Add(new Employee(name, hours, valuePerHour));
                }

            }

            Console.WriteLine();
            Console.WriteLine("PAYMENTS: ");
            foreach(Employee emp in list)
            {
                Console.WriteLine(emp.Name + "- $ " + emp.Payment().ToString("f2", CultureInfo.InvariantCulture));
            }

        }
    }
}
