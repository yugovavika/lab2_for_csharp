using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    internal class Department
    {
        private string _title;
        private Employee _boss;
        private Employee[] _employees;
        private int _count;

        public Department(string title)
        {
            this.Title = title;
            this._boss = null;
            this._employees = new Employee[10];
            this._count = 0;
        }

        public string Title
        {
            get { return this._title; }
            set
            {
                string? v = value;
                while (v == null || v == "" || v.Trim() == "")
                {
                    Console.WriteLine("Ошибка названия " +
                        "отдела. Повторите ввод: ");
                    v = Console.ReadLine();
                }
                this._title = v;
            }
        }

        public Employee Boss
        {
            get
            {
                return this._boss;
            }
            set
            {
                this._boss = value;
            }
        }

        public int Count
        {
            get
            {
                return this._count;
            }
        }

        public Employee GetEmployee(int index)
        {
            return this._employees[index];
        }

        public void AddEmployee(Employee e)
        {
            if (e == null)
            {
                return;
            }

            if (this._count == this._employees.Length)
            {
                Employee[] newArr =
                    new Employee[this._employees.Length * 2];
                int i = 0;
                while (i < this._count)
                {
                    newArr[i] = this._employees[i];
                    i++;
                }
                this._employees = newArr;
            }

            this._employees[this._count] = e;
            this._count++;
        }

        public override string ToString()
        {
            return this._title;
        }
    }
}
