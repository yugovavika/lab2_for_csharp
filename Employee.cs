using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    internal class Employee
    {
        private string _name;
        private Department _department;

        public Employee(string name, Department department)
        {
            this.Name = name;
            this._department = department;
            this._department.AddEmployee(this);
        }

        public string Name
        {
            get
            {
                return this._name;
            }
            set
            {
                string? v = value;
                while (v == null || v == "" || v.Trim() == "")
                {
                    Console.WriteLine("Ошибка имени " +
                        "сотрудника. Повторите ввод: ");
                    v = Console.ReadLine();
                }
                this._name = v;
            }
        }

        public Department Department
        {
            get
            {
                return this._department;
            }
            set
            {
                this._department = value;
            }
        }

        public Employee[] GetColleagues()
        {
            Employee[] result = new Employee
                [this._department.Count];
            int i = 0;
            while (i < this._department.Count)
            {
                result[i] = this._department.GetEmployee(i);
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
            if (this._department.Boss == this)
            {
                return this._name + " начальник отдела "
                    + this._department.Title;
            }

            string bossName = "не назначен";
            if (this._department.Boss != null)
            {
                bossName = this._department.Boss.Name;
            }

            return this._name + " работает в отделе "
                + this._department.Title
                + ", начальник которого " + bossName;
        }
    }
}
