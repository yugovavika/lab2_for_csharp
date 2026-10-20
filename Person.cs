using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    internal class Person
    {
        private string _name;
        private int _height;

        public Person(string name, int height)
        {
            this.Name = name;
            this.Height = height;
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
                    Console.WriteLine("Ошибка имени. " +
                        "Повторите ввод: ");
                    v = Console.ReadLine();
                }
                this._name = v;
            }
        }

        public int Height
        {
            get
            {
                return this._height;
            }
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
                this._height = v;
            }
        }

        public override string ToString()
        {
            return this._name + ", рост: " + this._height;
        }
    }
}
