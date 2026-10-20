using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    internal class Pistol
    {
        private int _patrons;

        public Pistol()
        {
            this._patrons = 5;
        }

        public Pistol(int patrons)
        {
            this.Patrons = patrons;
        }

        public int Patrons
        {
            get 
            { 
                return this._patrons; 
            }
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
                this._patrons = v;
            }
        }

        public void Shoot()
        {
            if (this._patrons > 0)
            {
                Console.WriteLine("Бах!");
                this._patrons--;
            }
            else
            {
                Console.WriteLine("Клац!");
            }
        }

        public override string ToString()
        {
            return "Пистолет, патронов: " + this._patrons;
        }
    }
}