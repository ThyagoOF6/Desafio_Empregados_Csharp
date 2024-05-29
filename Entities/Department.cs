using System;
using System.Collections.Generic;
using System.Text;
using Empregados.Entities;

namespace Empregados.Entities
{
    public class Department
    {
        private string name;
        private int payDay;
        private Address address;
        private List<Employee> employees = new List<Employee>();

        public Department()
        {
        }

        public Department(string name, int payDay, Address address)
        {
            this.name = name;
            this.payDay = payDay;
            this.address = address;
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int PayDay
        {
            get { return payDay; }
            set { payDay = value; }
        }

        public Address Address
        {
            get { return address; }
            set { address = value; }
        }

        public List<Employee> Employees
        {
            get { return employees; }
        }

        public void AddEmployee(Employee employee)
        {
            employees.Add(employee);
        }

        public void RemoveEmployee(Employee employee)
        {
            employees.Remove(employee);
        }

        public double Payroll()
        {
            double sum = 0.0;
            foreach (Employee employee in employees)
            {
                sum += employee.Salary;
            }
            return sum;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Departamento ");
            sb.Append(name);
            sb.Append(" = R$ ");
            sb.Append(string.Format("{0:F2}", Payroll()));
            sb.Append("\n Pagamento realizado no dia " + payDay + "\n");
            sb.Append("Funcionários: \n");
            foreach (Employee employee in employees)
            {
                sb.Append(employee.Name + "\n");
            }
            sb.Append("Para dúvidas favor entrar em contato: " + address.Email);
            return sb.ToString();
        }
    }
}