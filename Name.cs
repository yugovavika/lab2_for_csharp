using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    internal class Name
    {
        private string _firstName;
        private string _surname;
        private string _patronymic;

        public Name(string firstName)
        {
            this.FirstName = firstName;
            this._surname = null;
            this._patronymic = null;
        }

        public Name(string firstName, string surname)
        {
            this.FirstName = firstName;
            this.Surname = surname;
            this._patronymic = null;
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
            get
            {
                return this._firstName;
            }
            set
            {
                string? v = value;
                while (v == null || v == "" || v.Trim() == "")
                {
                    Console.WriteLine("Ошибка имени. " +
                        "Повторите ввод: ");
                    v = Console.ReadLine();
                }
                this._firstName = v;
            }
        }

        public string Surname
        {
            get
            {
                return this._surname;
            }
            set
            {
                if (value == null || value == "" ||
                    value.Trim() == "")
                {
                    this._surname = null;
                }
                else
                {
                    this._surname = value;
                }
            }
        }

        public string Patronymic
        {
            get
            {
                return this._patronymic;
            }
            set
            {
                if (value == null || value == "" ||
                    value.Trim() == "")
                {
                    this._patronymic = null;
                }
                else
                {
                    this._patronymic = value;
                }
            }
        }

        public override string ToString()
        {
            string s = "";
            if (this._surname != null)
            {
                s += this._surname + " ";
            }
            if (this._firstName != null)
            {
                s += this._firstName + " ";
            }
            if (this._patronymic != null)
            {
                s += this._patronymic;
            }
            return s.Trim();
        }
    }
}
