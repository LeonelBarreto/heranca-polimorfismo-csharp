using System;
using System.Collections.Generic;
using Exercicio02.Entities;
using System.Globalization;

namespace Exercicio02;

class Program
{
    static void Main(string[] args)
    {
        List<Employee> employees = new List<Employee>();

        Console.Write("Informe a quantidade de funcionários: ");
        int n = int.Parse(Console.ReadLine());

        for (int i = 1; i <= n; i++)
        {
            Console.WriteLine($"Dados do Funcionário #{i}:");
            Console.Write("Outsourced? (s/n): ");
            char response = char.Parse(Console.ReadLine());

            Console.Write("Nome: ");
            string name = Console.ReadLine();

            Console.Write("Horas: ");
            int hours = int.Parse(Console.ReadLine());

            Console.Write("Valor da hora: ");
            double valuePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            if (response == 's')
            {
                Console.Write("Despesa adicional: R$");
                double additionalCharge = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                employees.Add(new OutsourcedEmployee(name, hours, valuePerHour, additionalCharge));
            }
            else
            {
                employees.Add(new Employee(name, hours, valuePerHour));
            }        
        }

        Console.WriteLine();
        Console.WriteLine("Pagamentos:");

        foreach (Employee emp in employees)
        {
            Console.WriteLine($"{emp.Name} - R${emp.Payment().ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}