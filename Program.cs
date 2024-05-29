using System;
using System.Globalization;
using System.Linq;
using System.Collections.Generic;
using Empregados.Entities;

namespace Empregados
{

    class Program
    {
        static void Main(string[] args)
        {
            CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("en-US");

            Console.Write("Nome do departamento: ");
            string departmentName = Console.ReadLine();
            
            Console.Write("Dia do pagamento: ");
            int payDay = int.Parse(Console.ReadLine());
            
            Console.Write("Email: ");
            string email = Console.ReadLine();
            
            Console.Write("Telefone: ");
            string phone = Console.ReadLine();

            Address address = new Address(email, phone);
            Department department = new Department(departmentName, payDay, address);

            Console.Write("Quantos funcionários tem o departamento? ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.Write($"Dados do funcionário {i + 1}:\n");
                Console.Write("Nome: ");
                string employeeName = Console.ReadLine();
                
                Console.Write("Salário: ");
                double salary = double.Parse(Console.ReadLine());
                
                Employee employee = new Employee(employeeName, salary);
                department.AddEmployee(employee);
            }

            ShowReport(department);
        }

        private static void ShowReport(Department department)
        {
            Console.WriteLine();
            Console.WriteLine("FOLHA DE PAGAMENTO:");
            Console.WriteLine(department.ToString());
        }
    }
}
