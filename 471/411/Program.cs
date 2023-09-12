using System;

namespace _411
{
    public class Employee
    {
        private string name;
        private decimal salary;
        private decimal bonus;

        public string Name
        {
            get { return name; }
        }

        public decimal Salary
        {
            get { return salary; }
            set { salary = value; }
        }
        public Employee(string name, decimal salary)
        {
            this.name = name;
            this.salary = salary;
        }
        public virtual void SetBonus(decimal bonus)
        {
            this.bonus = bonus;
        }
        public decimal ToPay()
        {
            return salary + bonus;
        }
    }
    class SalesPerson : Employee
    {
        private int percent;
        public SalesPerson(string name, decimal salary, int percent)
        : base(name, salary)
        {
            this.percent = percent;
        }
        public override void SetBonus(decimal bonus)
        {
            if (percent > 100)
                base.SetBonus(bonus * 2);
            else if (percent > 200)
                base.SetBonus(bonus * 3);
            else
                base.SetBonus(bonus);
        }
    }
    public class Manager : Employee
    {
        private int quantity;

        public Manager(string name, decimal salary, int clientAmount)
            : base(name, salary)
        {
            this.quantity = clientAmount;
        }
        public override void SetBonus(decimal bonus)
        {
            if (quantity > 100)
                bonus += 500;
            else if (quantity > 150)
                bonus += 1000;
            else
                base.SetBonus(bonus);
        }
    }
    public class Company
    {
        private Employee[] employees;

        public Company(Employee[] employees)
        {
            this.employees = employees;
        }
        public void GiveEverybodyBonus(decimal companyBonus)
        {
            foreach (Employee employee in employees)
            {
                employee.SetBonus(companyBonus);
            }
        }
        public decimal TotalToPay()
        {
            decimal totalCompensation = 0;
            foreach (Employee employee in employees)
            {
                totalCompensation += employee.ToPay();
            }
            return totalCompensation;
        }
        public string GetNameSalary(Employee employee)
        {
            return $"{employee.Name}: {employee.ToPay()}";
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Employee[] employees = new Employee[]
            {
            new SalesPerson("Amanda", 5000, 90),
            new Manager("Eva", 6000, 150),
            new Employee("Max", 4000)
            };

            Company company = new Company(employees);
            company.GiveEverybodyBonus(500);

            foreach (Employee employee in employees)
            {
                Console.WriteLine(company.GetNameSalary(employee));
            }

            decimal totalCompensation = company.TotalToPay();
            Console.WriteLine($"Total Compensation: {totalCompensation}");
        }
    }
}




