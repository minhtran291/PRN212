using System;
using System.Collections.Generic;

// Lớp trừu tượng Person
abstract class Person
{
    protected string name;
    protected string address;

    public Person(string name, string address)
    {
        this.name = name;
        this.address = address;
    }

    public abstract void SetName(string name);
    public abstract string GetName();
    public abstract void SetAddress(string address);
    public abstract string GetAddress();
    public abstract void Display();
}

// Lớp Employee kế thừa từ Person
class Employee : Person
{
    private int salary;

    public Employee(string name, string address, int salary) : base(name, address)
    {
        this.salary = salary;
    }

    public override void SetName(string name)
    {
        this.name = name;
    }

    public override string GetName()
    {
        return this.name;
    }

    public override void SetAddress(string address)
    {
        this.address = address;
    }

    public override string GetAddress()
    {
        return this.address;
    }

    public int GetSalary()
    {
        return this.salary;
    }

    public override void Display()
    {
        Console.WriteLine("**Thông tin nhân viên**");
        Console.WriteLine("Tên: {0}", this.name);
        Console.WriteLine("Địa chỉ: {0}", this.address);
        Console.WriteLine("Lương: {0}", this.salary);
    }
}

// Lớp Customer kế thừa từ Person
class Customer : Person
{
    private int balance;

    public Customer(string name, string address, int balance) : base(name, address)
    {
        this.balance = balance;
    }

    public override void SetName(string name)
    {
        this.name = name;
    }

    public override string GetName()
    {
        return this.name;
    }

    public override void SetAddress(string address)
    {
        this.address = address;
    }

    public override string GetAddress()
    {
        return this.address;
    }

    public int GetBalance()
    {
        return this.balance;
    }

    public override void Display()
    {
        Console.WriteLine("**Thông tin khách hàng**");
        Console.WriteLine("Tên: {0}", this.name);
        Console.WriteLine("Địa chỉ: {0}", this.address);
        Console.WriteLine("Số dư: {0}", this.balance);
    }
}

// Lớp Main thực hiện các chức năng chính
class Program
{
    static void Main(string[] args)
    {
        List<Employee> employees = new List<Employee>();
        List<Customer> customers = new List<Customer>();

        while (true)
        {
            Console.WriteLine("1. Thêm nhân viên");
            Console.WriteLine("2. Thêm khách hàng");
            Console.WriteLine("3. Hiển thị nhân viên");
            Console.WriteLine("4. Hiển thị khách hàng");
            Console.WriteLine("5. Tìm nhân viên có lương cao nhất");
            Console.WriteLine("6. Tìm khách hàng có số dư nhỏ nhất");
            Console.WriteLine("7. Tìm nhân viên theo tên");
            Console.WriteLine("8. Thoát");
            Console.Write("Chọn một tùy chọn: ");
            int choice;

            try
            {
                choice = int.Parse(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("Lỗi: Vui lòng nhập số hợp lệ.");
                continue;
            }

            switch (choice)
            {
                case 1:
                    AddEmployee(employees);
                    break;
                case 2:
                    AddCustomer(customers);
                    break;
                case 3:
                    DisplayEmployees(employees);
                    break;
                case 4:
                    DisplayCustomers(customers);
                    break;
                case 5:
                    FindHighestSalaryEmployee(employees);
                    break;
                case 6:
                    FindLowestBalanceCustomer(customers);
                    break;
                case 7:
                    FindEmployeeByName(employees);
                    break;
                case 8:
                    return;
                default:
                    Console.WriteLine("Tùy chọn không hợp lệ. Vui lòng thử lại.");
                    break;
            }
        }
    }

    static void AddEmployee(List<Employee> employees)
    {
        try
        {
            Console.Write("Nhập tên nhân viên: ");
            string name = Console.ReadLine();
            Console.Write("Nhập địa chỉ nhân viên: ");
            string address = Console.ReadLine();
            Console.Write("Nhập lương nhân viên: ");
            int salary = int.Parse(Console.ReadLine());

            Employee employee = new Employee(name, address, salary);
            employees.Add(employee);
            Console.WriteLine("Đã thêm nhân viên thành công.");
        }
        catch (Exception)
        {
            Console.WriteLine("Lỗi: Dữ liệu nhập vào không hợp lệ.");
        }
    }

    static void AddCustomer(List<Customer> customers)
    {
        try
        {
            Console.Write("Nhập tên khách hàng: ");
            string name = Console.ReadLine();
            Console.Write("Nhập địa chỉ khách hàng: ");
            string address = Console.ReadLine();
            Console.Write("Nhập số dư khách hàng: ");
            int balance = int.Parse(Console.ReadLine());

            Customer customer = new Customer(name, address, balance);
            customers.Add(customer);
            Console.WriteLine("Đã thêm khách hàng thành công.");
        }
        catch (Exception)
        {
            Console.WriteLine("Lỗi: Dữ liệu nhập vào không hợp lệ.");
        }
    }

    static void DisplayEmployees(List<Employee> employees)
    {
        if (employees.Count == 0)
        {
            Console.WriteLine("Không có nhân viên nào.");
            return;
        }

        foreach (Employee employee in employees)
        {
            employee.Display();
        }
    }

    static void DisplayCustomers(List<Customer> customers)
    {
        if (customers.Count == 0)
        {
            Console.WriteLine("Không có khách hàng nào.");
            return;
        }

        foreach (Customer customer in customers)
        {
            customer.Display();
        }
    }

    static void FindHighestSalaryEmployee(List<Employee> employees)
    {
        if (employees.Count == 0)
        {
            Console.WriteLine("Không có nhân viên nào.");
            return;
        }

        Employee highestSalaryEmployee = employees[0];

        foreach (Employee employee in employees)
        {
            if (employee.GetSalary() > highestSalaryEmployee.GetSalary())
            {
                highestSalaryEmployee = employee;
            }
        }

        Console.WriteLine("Nhân viên có lương cao nhất:");
        highestSalaryEmployee.Display();
    }

    static void FindLowestBalanceCustomer(List<Customer> customers)
    {
        if (customers.Count == 0)
        {
            Console.WriteLine("Không có khách hàng nào.");
            return;
        }

        Customer lowestBalanceCustomer = customers[0];

        foreach (Customer customer in customers)
        {
            if (customer.GetBalance() < lowestBalanceCustomer.GetBalance())
            {
                lowestBalanceCustomer = customer;
            }
        }

        Console.WriteLine("Khách hàng có số dư nhỏ nhất:");
        lowestBalanceCustomer.Display();
    }

    static void FindEmployeeByName(List<Employee> employees)
    {
        Console.Write("Nhập tên nhân viên cần tìm: ");
        string name = Console.ReadLine();

        foreach (Employee employee in employees)
        {
            if (employee.GetName().ToLower().Contains(name.ToLower()))
            {
                employee.Display();
                return;
            }
        }

        Console.WriteLine("Không tìm thấy nhân viên có tên: " + name);
    }
}
