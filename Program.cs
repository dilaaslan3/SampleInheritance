using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee("John",5000,"HR");
            employee.showInfo();
            employee.changeDepartment("Software");
            Manager manager = new Manager("Jack",6000,"IT",10);
            manager.showInfo();
            manager.Raise(300);
        }
    }

    class Employee //base class
    {
        string name;
        int salary;
        string department;

        public string Name
        {
            get { return name;  }
            set { name = value; }
        }
        public int Salary
        {
            get { return salary; }
            set { salary = value; }
        }
        public string Department
        {
            get { return department; }
            set { department = value; }
        }

        public Employee(string name, int salary, string department) //constructor
        {
            this.name = name;
            this.salary = salary;
            this.department = department;
        }

        public void work()
        {
            Console.WriteLine("Employee is working..");
        }
        public void showInfo()
        {
            Console.WriteLine("Name: " + name + " Salary: " + salary + " Department: " + department);
            
        }
        public void changeDepartment(string newDepartment)
        {
            Console.WriteLine("Old department is: " + department);
            this.department = newDepartment;
            Console.WriteLine("Updated department is: " + department);
        }
    }


    class Manager : Employee

    {
        int peopleInTeam;
        public Manager(string name, int salary, string department, int peopleInTeam) : base(name, salary,department)
        {
            //base, miras alınan classın constructorını almak için kullanılır

            this.peopleInTeam = peopleInTeam;

        }

        public void Raise(int raise_amount)
        {
            Console.WriteLine("Raised amount to employee's salary");
            Console.WriteLine("Old salary is: " + Salary);
            Console.WriteLine("Raise amount is: {0}", raise_amount);
            Salary += raise_amount;
            Console.WriteLine("New salary is: " + Salary);

        }

        public void showInfo()
        {
           // Console.WriteLine("Name: " + Name + " Salary: "+ Salary + " Department: "  + Department + " People: " + peopleInTeam);
            base.showInfo();
            Console.WriteLine("People: {0}", peopleInTeam);
        }
    }
}
