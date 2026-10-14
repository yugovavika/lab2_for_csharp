using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    internal class Name
    {
        private string firstName;
        private string surname;
        private string patronymic;

        public Name(string firstName)
        {
            this.FirstName = firstName;
            this.surname = null;
            this.patronymic = null;
        }

        public Name(string firstName, string surname)
        {
            this.FirstName = firstName;
            this.Surname = surname;
            this.patronymic = null;
        }

        public Name(string firstName, string surname, 
            string patronymic)
        {
            this.FirstName = firstName;
            this.Surname = surname;
            this.Patronymic = patronymic;
        }

        public string FirstName
        {
            get { return this.firstName; }
            set
            {
                string? v = value;
                while (v == null || v == "" || v.Trim() == "")
                {
                    Console.WriteLine("Ошибка имени. " +
                        "Повторите ввод: ");
                    v = Console.ReadLine();
                }
                this.firstName = v;
            }
        }

        public string Surname
        {
            get { return this.surname; }
            set
            {
                if (value == null || value == "" || 
                    value.Trim() == "")
                {
                    this.surname = null;
                }
                else
                {
                    this.surname = value;
                }
            }
        }

        public string Patronymic
        {
            get { return this.patronymic; }
            set
            {
                if (value == null || value == "" ||
                    value.Trim() == "")
                {
                    this.patronymic = null;
                }
                else
                {
                    this.patronymic = value;
                }
            }
        }

        public override string ToString()
        {
            string s = "";
            if (this.surname != null)
            {
                s += this.surname + " ";
            }
            if (this.firstName != null)
            {
                s += this.firstName + " ";
            }
            if (this.patronymic != null)
            {
                s += this.patronymic;
            }
            return s.Trim();
        }
    }

    internal class Person
    {
        private string name;
        private int height;

        public Person(string name, int height)
        {
            this.Name = name;
            this.Height = height;
        }

        public string Name
        {
            get { return this.name; }
            set
            {
                string? v = value;
                while (v == null || v == "" || v.Trim() == "")
                {
                    Console.WriteLine("Ошибка имени. " +
                        "Повторите ввод: ");
                    v = Console.ReadLine();
                }
                this.name = v;
            }
        }

        public int Height
        {
            get { return this.height; }
            set
            {
                int v = value;
                while (v <= 0 || v >= 300)
                {
                    Console.WriteLine("Ошибка роста. " +
                        "Повторите ввод: ");
                    string? input = Console.ReadLine();
                    int.TryParse(input, out v);
                }
                this.height = v;
            }
        }

        public override string ToString()
        {
            return this.name + ", рост: " + this.height;
        }
    }

    internal class Department
    {
        private string title;
        private Employee boss;
        private Employee[] employees;
        private int count;

        public Department(string title)
        {
            this.Title = title;
            this.boss = null;
            this.employees = new Employee[10];
            this.count = 0;
        }

        public string Title
        {
            get { return this.title; }
            set
            {
                string? v = value;
                while (v == null || v == "" || v.Trim() == "")
                {
                    Console.WriteLine("Ошибка названия " +
                        "отдела. Повторите ввод: ");
                    v = Console.ReadLine();
                }
                this.title = v;
            }
        }

        public Employee Boss
        {
            get { return this.boss; }
            set { this.boss = value; }
        }

        public int Count
        {
            get { return this.count; }
        }

        public Employee GetEmployee(int index)
        {
            return this.employees[index];
        }

        public void AddEmployee(Employee e)
        {
            if (e == null)
            {
                return;
            }

            if (this.count == this.employees.Length)
            {
                Employee[] newArr =
                    new Employee[this.employees.Length * 2];
                int i = 0;
                while (i < this.count)
                {
                    newArr[i] = this.employees[i];
                    i++;
                }
                this.employees = newArr;
            }

            this.employees[this.count] = e;
            this.count++;
        }

        public override string ToString()
        {
            return this.title;
        }
    }


    internal class Employee
    {
        private string name;
        private Department department;

        public Employee(string name, Department department)
        {
            this.Name = name;
            this.department = department;
            this.department.AddEmployee(this);
        }

        public string Name
        {
            get { return this.name; }
            set
            {
                string? v = value;
                while (v == null || v == "" || v.Trim() == "")
                {
                    Console.WriteLine("Ошибка имени " +
                        "сотрудника. Повторите ввод: ");
                    v = Console.ReadLine();
                }
                this.name = v;
            }
        }

        public Department Department
        {
            get { return this.department; }
            set { this.department = value; }
        }

        public Employee[] GetColleagues()
        {
            Employee[] result = new Employee
                [this.department.Count];
            int i = 0;
            while (i < this.department.Count)
            {
                result[i] = this.department.GetEmployee(i);
                i++;
            }
            return result;
        }

        public string GetColleaguesAsString()
        {
            string s = "";
            Employee[] colleagues = this.GetColleagues();
            int i = 0;
            while (i < colleagues.Length)
            {
                if (i > 0)
                {
                    s += ", ";
                }
                s += colleagues[i].Name;
                i++;
            }
            return s;
        }

        public override string ToString()
        {
            if (this.department.Boss == this)
            {
                return this.name + " начальник отдела "
                    + this.department.Title;
            }

            string bossName = "не назначен";
            if (this.department.Boss != null)
            {
                bossName = this.department.Boss.Name;
            }

            return this.name + " работает в отделе "
                + this.department.Title
                + ", начальник которого " + bossName;
        }
    }

    internal class Pistol
    {
        private int patrons;

        public Pistol()
        {
            this.patrons = 5;
        }

        public Pistol(int patrons)
        {
            this.Patrons = patrons;
        }

        public int Patrons
        {
            get { return this.patrons; }
            set
            {
                int v = value;
                while (v < 0)
                {
                    Console.WriteLine("Ошибка количества " +
                        "патронов. Повторите ввод: ");
                    string? input = Console.ReadLine();
                    int.TryParse(input, out v);
                }
                this.patrons = v;
            }
        }

        public void Shoot()
        {
            if (this.patrons > 0)
            {
                Console.WriteLine("Бах!");
                this.patrons--;
            }
            else
            {
                Console.WriteLine("Клац!");
            }
        }

        public override string ToString()
        {
            return "Пистолет, патронов: " + this.patrons;
        }
    }
}