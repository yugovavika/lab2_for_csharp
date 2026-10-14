using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    internal class Checked
    {
        public int ReadInt(string promt)
        {
            Console.WriteLine(promt);
            string? input = Console.ReadLine();
            int x = 0;
            bool ok = false;
            while (!ok)
            {
                if (int.TryParse(input, out x))
                {
                    ok = true;
                }
                else
                {
                    Console.WriteLine("Ошибка ввода! " +
                        "Повторите ввод: ");
                    input = Console.ReadLine();
                }
            }
            return x;
        }

        public int ReadPositiveInt(string promt)
        {
            int x = 0;
            bool ok = false;
            while (!ok)
            {
                x = ReadInt(promt);
                if (x > 0)
                {
                    ok = true;
                }
                else
                {
                    Console.WriteLine("Число должно быть " +
                        "больше нуля. Повторите ввод: ");
                }
            }
            return x;
        }

        public int ReadNonNegativeInt(string promt)
        {
            int x = 0;
            bool ok = false;
            while (!ok)
            {
                x = ReadInt(promt);
                if (x >= 0)
                {
                    ok = true;
                }
                else
                {
                    Console.WriteLine("Число не " +
                        "может быть отрицательным. " +
                        "Повторите ввод: ");
                }
            }
            return x;
        }

        public string ReadString(string promt)
        {
            Console.WriteLine(promt);
            string? input = Console.ReadLine();
            while (input == null || input == "" || 
                input.Trim() == "")
            {
                Console.WriteLine("Ошибка ввода! " +
                    "Строка не может быть пустой. " +
                    "Повторите ввод: ");
                input = Console.ReadLine();
            }
            return input;
        }

        public bool ReadBool(string promt)
        {
            Console.WriteLine(promt);
            string? input = Console.ReadLine();
            bool result = false;
            bool ok = false;
            while (!ok)
            {
                if (bool.TryParse(input, out result))
                {
                    ok = true;
                }
                else
                {
                    Console.WriteLine("Ошибка ввода! " +
                        "Введите True или False: ");
                    input = Console.ReadLine();
                }
            }
            return result;
        }
    }
}