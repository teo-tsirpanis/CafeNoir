namespace CafeNoir.Core
{
    public class Employee
    {
        public Guid ID { get; } = Guid.NewGuid();

        public string Name { get; set; }

        public string Surname { get; set; }

        public EmployeeType EmployeeType { get; set; }

        public decimal SalaryPerMonth { get; set; }

        public Employee(EmployeeType type)
        {
            EmployeeType = type;
        }

        public Employee ShallowCopy() => (Employee)MemberwiseClone();
    }
}
