using System;

namespace number3
{
    class TestOverride
    {
        public class Employee
        {
            public string name;

            // Basepay is defined as protected, so that it may be
            // accessed only by this class and derived classes.
            protected decimal basepay;

            // Constructor to set the name and basepay values.
            public Employee(string name, decimal basepay)
            {
                this.name = name;
                this.basepay = basepay;
            }

            // Declared virtual so it can be overridden.
            public virtual decimal CalculatePay()
            {
                return basepay;
            }
        }

        // Derive a new class from Employee.
        public class SalesEmployee : Employee
        {
            // New field that will affect the base pay.
            private decimal salesbonus;

            // The constructor calls the base-class version, and
            // initializes the salesbonus field.
            public SalesEmployee(string name, decimal basepay,
                decimal salesbonus) : base(name, basepay)
            {
                this.salesbonus = salesbonus;
            }

            // Override the CalculatePay method
            // to take bonus into account.
            public override decimal CalculatePay()
            {
                return basepay + salesbonus;
            }
            public void PrintInfos()
            {
                Console.WriteLine($"name:{name},basepay:{basepay}, salesbonus: {salesbonus}");
            }
        }

        class PartTimeEmployee : Employee
        {
            public int workingDays;
            public PartTimeEmployee(string name, decimal basepay, int workingDays) : base(name, basepay)
            {
                this.workingDays = workingDays;
            }
            public override decimal CalculatePay()
            {
                return (basepay * workingDays) / 25;
            }

            public string PrintInfop()
            {
                return $"name:{name},basepay:{basepay}, workingDays: {workingDays}";
            }
            
        }
        static void Main()
        {
            // Create some new employees.
            var employee1 = new SalesEmployee("Alice", 1000, 500);
            var employee2 = new Employee("Bob", 1200);

            Console.WriteLine($"1 {employee1.name} заработал: {employee1.CalculatePay()}");
            Console.WriteLine($"2 {employee2.name} заработал: {employee2.CalculatePay()}");

            Random rnd = new Random();
            Employee[] arr = new Employee[rnd.Next(0,16)];
            for (int i = 0; i < arr.Length; i++)
            {
                string name = "";
                int count = (char)rnd.Next(3,8);
                for (int j = 0; j < count; j++)
                {
                    name += (char)rnd.Next('a', 'z');
                }
                if (i % 2 == 0)
                {
                    arr[i] = new SalesEmployee(name, rnd.Next(1000,100000), rnd.Next(100,600));
                    
                }
                else
                {
                    arr[i] = new PartTimeEmployee(name, rnd.Next(1000, 100000), rnd.Next(1, 30));
                }
            }

            Array.Sort(arr,
                (x, y) =>
                {
                    if (x.CalculatePay() < y.CalculatePay())
                    {
                        return 1;
                    }
                    else
                    {
                        return -1;
                    }
                });
                
            foreach (var i in arr)
            {
                if (i is SalesEmployee)
                {
                    (i as SalesEmployee).PrintInfos();
                }
                else if (i is PartTimeEmployee)
                {
                    Console.WriteLine((i as PartTimeEmployee).PrintInfop());
                    
                }
            }
        }
    }
}
