using System;

namespace Ex1
{
    public interface IEmployee
    {
        int CalculateSalary();

        string GetName();
    }

    public abstract class Employee : IEmployee
    {
        private string name;
        private int paymentPerHour;

        public Employee(string name, int paymentPerHour)
        {
            this.name = name;
            this.paymentPerHour = paymentPerHour;
        }

        public string GetName()
        {
            return name;
        }

        public void setName(string name)
        {
            this.name = name;
        }

        public int getPaymentPerHour()
        {
            return paymentPerHour;
        }

        public void setPaymentPerHour(int paymentPerHour)
        {
            this.paymentPerHour = paymentPerHour;
        }

        public abstract int CalculateSalary();
        public override string ToString()
        {
            return $"Name: {name}, Payment Per Hour: {paymentPerHour}";
        }
    }


    public class PartTimeEmployee : Employee
    {
        private int workingHours;

        public PartTimeEmployee(string name, int paymentPerHour, int workingHours): base(name, paymentPerHour)
        {
            this.workingHours = workingHours;   
        }

        public int getWorkingHours()
        {
            return workingHours;
        }

        public void setWorkingHours(int workingHours)
        {
            this.workingHours = workingHours;    
        }

        public override int CalculateSalary()
        {
            return workingHours * getPaymentPerHour();
        }

        public override string ToString()
        {
            return base.ToString() + $", Working Hours: {workingHours}, Salary: {CalculateSalary()}";
        }
    }

    public class FullTimeEmployee : Employee
    {
        public FullTimeEmployee(string name, int paymentPerHour) : base(name, paymentPerHour)
        {
        }

        public override int CalculateSalary()
        {
            return 8 * getPaymentPerHour();
        }

        public override string ToString()
        {
            return base.ToString() + $", Salary: {CalculateSalary()}";
        }
    }

    public class BOEmployee
    {
        private List<IEmployee> ListEmployees = new List<IEmployee>();

        public void AddEmployee(IEmployee employee)
        {
            ListEmployees.Add(employee); 
        }
        

        public bool CheckList()
        {
            return ListEmployees.Count == 0;
        }

        public List<IEmployee> GetList()
        {
            return CheckList() ? null : ListEmployees; 
        }

        public int FindMaxFullTimeSalary()
        {
            int maxSalary = 0;
            foreach(var employee in ListEmployees)
            {
                if(employee is FullTimeEmployee fullTimeEmployee)
                {
                    int salary = fullTimeEmployee.CalculateSalary();
                    if(salary > maxSalary)
                    {
                        maxSalary = salary;
                    }
                }
            }
            return maxSalary;
        }

        public int FindMaxPartTimeSalary()
        {
            int maxSalary = 0;
            foreach (var employee in ListEmployees)
            {
                if(employee is PartTimeEmployee partTimeEmployee)
                {
                    int salary = partTimeEmployee.CalculateSalary();    
                    if(salary > maxSalary)
                    {
                        maxSalary = salary;
                    }
                }
            }
            return maxSalary ;
        }

        public IEmployee FindByName(string name)
        {
            foreach(var employee in ListEmployees)
            {
                if(employee is PartTimeEmployee partTimeEmployee)
                {
                    if (partTimeEmployee.GetName().ToLowerInvariant().Contains(name.ToLowerInvariant()))
                    {
                        return partTimeEmployee;
                    }
                }else if(employee is FullTimeEmployee fullTimeEmployee)
                {
                    if (fullTimeEmployee.GetName().ToLowerInvariant().Contains(name.ToLowerInvariant()))
                    {
                        return fullTimeEmployee;
                    }
                }
                
            }
            return null;
        }
    }

    public class Controller{
       private BOEmployee boEmployee = new BOEmployee();

        public Controller()
        {
            boEmployee.AddEmployee(new FullTimeEmployee("John Doe", 50));
            boEmployee.AddEmployee(new FullTimeEmployee("Jane Smith", 45));
            boEmployee.AddEmployee(new PartTimeEmployee("Alice Johnson", 30, 20));
            boEmployee.AddEmployee(new PartTimeEmployee("Bob Brown", 25, 15));
        }

        public void AddEmployee()
        {
            try
            {
                Console.Write("Enter name: ");
                string name = Console.ReadLine();
                while (string.IsNullOrEmpty(name))
                {
                    throw new ArgumentException("Name can't be empty!");
                    Console.Write("Enter name: ");
                    name = Console.ReadLine();
                }

                int paymentPerHour;
                while (true)
                {
                    try
                    {
                        Console.Write("Enter payment per hour: ");
                        if (!int.TryParse(Console.ReadLine(), out paymentPerHour))
                        {
                            throw new ArgumentException("Payment per hour must be a valid integer.");
                        }
                        break;
                    }
                    catch (ArgumentException ex)
                    {
                        Console.WriteLine($"Error: {ex.Message}");
                    }
                }

                Console.Write("full-time or part-time employee? (f/p): ");
                string isFullTime = Console.ReadLine();
                if(isFullTime.ToLower().Equals("f")) {
                    boEmployee.AddEmployee(new FullTimeEmployee(name, paymentPerHour));
                }
                else
                {
                    int workingHours;
                    while (true)
                    {
                        try
                        {
                            Console.Write("Enter working hours: ");
                            if (!int.TryParse(Console.ReadLine(), out workingHours))
                            {
                                throw new ArgumentException("Working hours must be a valid integer.");
                            }
                            break;
                        }
                        catch (ArgumentException ex)
                        {
                            Console.WriteLine($"Error: {ex.Message}");
                        }
                    }
                    boEmployee.AddEmployee(new PartTimeEmployee(name, paymentPerHour, workingHours));
                }
                Console.WriteLine("Employee added successfully.");
            }
            catch(ArgumentException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }

        public void DisplayEmployees()
        {
            var employees = boEmployee.GetList();
            if (employees == null)
            {
                Console.WriteLine("No employees in the list.");
            }
            else
            {
                foreach (var employee in employees)
                {
                    Console.WriteLine(employee.ToString());
                }
            }
        }

        public string FindName()
        {
            Console.Write("Enter name: ");
            string name = Console.ReadLine();
            var employee = boEmployee.FindByName(name);
            if (employee is PartTimeEmployee partTimeEmployee)
            {
                return partTimeEmployee.ToString();
            } else if (employee is FullTimeEmployee fullTimeEmployee)
            {
                return fullTimeEmployee.ToString();
            }
            return "Not found! ";
        }

        public void HighestSalary()
        {
            Console.WriteLine($"Highest salary FullTime: {boEmployee.FindMaxFullTimeSalary()}");
            Console.WriteLine($"Highest salary PartTime: {boEmployee.FindMaxPartTimeSalary()}");
        }
    }
}
