namespace Empregados.Entities
{
    public class Employee
    {
        private string name;
        private double salary;

        // Parameterless constructor
        public Employee()
        {
        }

        // Parameterized constructor
        public Employee(string name, double salary)
        {
            this.name = name;
            this.salary = salary;
        }

        // Property for Name
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        // Property for Salary
        public double Salary
        {
            get { return salary; }
            set { salary = value; }
        }
    }
}