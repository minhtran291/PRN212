using System;

namespace Ex1
{
    public class Program
    {
        static void Main(string[] args)
        {
            Controller controller = new Controller();

            // Menu
            while (true)
            {
                Console.WriteLine("1. Add Employee");
                Console.WriteLine("2. Display Employees");
                Console.WriteLine("3. Find Employee by name");
                Console.WriteLine("4. Find highest salary");
                Console.WriteLine("5. Exit");
                Console.Write("Choose an option: ");
                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        controller.AddEmployee();
                        break;
                    case 2:
                        controller.DisplayEmployees();
                        break;
                    case 3:
                        Console.WriteLine(controller.FindName());
                        break;
                    case 4:
                        controller.HighestSalary();
                        break;
                    case 5:
                        return;
                    default:
                        Console.WriteLine("Invalid option. Please try again.");
                        break;
                }
            }
        }
    }
}
