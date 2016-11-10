namespace TestIO
{
    internal class Employee
    {
        private readonly string Name;
        private readonly float Salary;

        public Employee(string name, float salary)
        {
            Name = name;
            Salary = salary;
        }

        public string getName()
        {
            return Name;
        }

        public float getSalary()
        {
            return Salary;
        }
    }
}