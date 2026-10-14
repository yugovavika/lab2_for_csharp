namespace Lab2
{
    internal class ProgramLab2
    {
        static void Main(string[] args)
        {
            Checked c = new Checked();

            //Задание 1.3: Имена
            Console.WriteLine("Задание 1.3: Имена");

            string firstName1 = c.ReadString("Введите личное " +
                "имя (только имя): ");
            Name name1 = new Name(firstName1);

            string firstName2 = c.ReadString("Введите личное " +
                "имя второго человека: ");
            string surname2 = c.ReadString("Введите фамилию" +
                " второго человека: ");
            string patronymic2 = c.ReadString("Введите " +
                "отчество второго человека: ");
            Name name2 = new Name(firstName2, surname2,
                patronymic2);

            string firstName3 = c.ReadString("Введите " +
                "личное имя третьего человека: ");
            string surname3 = c.ReadString("Введите " +
                "фамилию третьего человека: ");
            Name name3 = new Name(firstName3, surname3);

            Console.WriteLine("Имя 1: " + name1);
            Console.WriteLine("Имя 2: " + name2);
            Console.WriteLine("Имя 3: " + name3);
            Console.WriteLine();

            // Задание 1.2: Человек
            Console.WriteLine("Задание 1.2: Человек");

            string personName1 = c.ReadString("Введите имя " +
                "первого человека: ");
            int height1 = c.ReadPositiveInt("Введите рост " +
                "первого человека: ");
            Person person1 = new Person(personName1, height1);

            string personName2 = c.ReadString("Введите имя " +
                "второго человека: ");
            int height2 = c.ReadPositiveInt("Введите рост " +
                "второго человека: ");
            Person person2 = new Person(personName2, height2);

            string personName3 = c.ReadString("Введите имя " +
                "третьего человека: ");
            int height3 = c.ReadPositiveInt("Введите рост " +
                "третьего человека: ");
            Person person3 = new Person(personName3, height3);

            Console.WriteLine(person1);
            Console.WriteLine(person2);
            Console.WriteLine(person3);
            Console.WriteLine();

            // Задание 2.4: Сотрудники и отделы
            Console.WriteLine("Задание 2.4: Сотрудники " +
                "и отделы ");

            string deptTitle = c.ReadString("Введите " +
                "название отдела: ");
            Department dept = new Department(deptTitle);

            string empName1 = c.ReadString("Введите имя " +
                "первого сотрудника: ");
            Employee emp1 = new Employee(empName1, dept);

            string empName2 = c.ReadString("Введите имя " +
                "второго сотрудника: ");
            Employee emp2 = new Employee(empName2, dept);

            string empName3 = c.ReadString("Введите имя " +
                "третьего сотрудника: ");
            Employee emp3 = new Employee(empName3, dept);

            Console.WriteLine("Список сотрудников:");
            Console.WriteLine("1. " + emp1.Name);
            Console.WriteLine("2. " + emp2.Name);
            Console.WriteLine("3. " + emp3.Name);

            int nomer = c.ReadInt("Введите номер начальника: ");

            while (nomer < 1 || nomer > 3)
            {
                Console.WriteLine("Ошибка! Введите число " +
                    "от 1 до 3: ");
                nomer = c.ReadInt("Введите номер начальника: ");
            }

            if (nomer == 1)
            {
                dept.Boss = emp1;
            }
            if (nomer == 2)
            {
                dept.Boss = emp2;
            }
            if (nomer == 3)
            {
                dept.Boss = emp3;
            }

            Console.WriteLine("Начальник: " + dept.Boss.Name);
            Console.WriteLine();

            Console.WriteLine(emp1);
            Console.WriteLine(emp2);
            Console.WriteLine(emp3);
            Console.WriteLine();

            // Задание 3.4: Список сотрудников отдела
            Console.WriteLine("Задание 3.4: Список " +
                "сотрудников отдела ");

            Employee link = emp1;

            Console.WriteLine("Ссылка на сотрудника: "
                + link.Name);
            Console.WriteLine("Отдел: "
                + link.Department.Title);

            Employee[] colleagues = link.GetColleagues();

            Console.WriteLine("Список всех сотрудников " +
                "отдела (массив):");
            int i = 0;
            while (i < colleagues.Length)
            {
                Console.WriteLine("  " + (i + 1) + ". "
                    + colleagues[i].Name);
                i++;
            }

            Console.WriteLine("Количество сотрудников в " +
                "отделе: " + colleagues.Length);
            Console.WriteLine("Строкой: "
                + link.GetColleaguesAsString());
            Console.WriteLine();

            // Задание 4.5: Создаем Имена 
            Console.WriteLine("Задание 4.5: Создаем Имена ");

            string a1 = c.ReadString("Имя 1 (только " +
                "личное имя): ");
            Name nn1 = new Name(a1);

            string a2 = c.ReadString("Имя 2 (личное имя): ");
            string b2 = c.ReadString("Фамилия 2: ");
            string d2 = c.ReadString("Отчество 2: ");
            Name nn2 = new Name(a2, b2, d2);

            string a3 = c.ReadString("Имя 3 (личное имя): ");
            string b3 = c.ReadString("Фамилия 3: ");
            Name nn3 = new Name(a3, b3);

            string a4 = c.ReadString("Имя 4 (личное имя): ");
            string b4 = c.ReadString("Фамилия 4: ");
            Name nn4 = new Name(a4, b4);

            Console.WriteLine("Имя 1: " + nn1);
            Console.WriteLine("Имя 2: " + nn2);
            Console.WriteLine("Имя 3: " + nn3);
            Console.WriteLine("Имя 4: " + nn4);
            Console.WriteLine();

            // Задание 5.1: Пистолет
            Console.WriteLine("Задание 5.1: Пистолет ");

            int pat = c.ReadNonNegativeInt("Введите " +
                "начальное количество патронов: ");
            Pistol pistol = new Pistol(pat);

            Console.WriteLine("Создан: " + pistol);

            int shots = c.ReadPositiveInt("Сколько " +
                "раз выстрелить? ");

            int j = 0;
            while (j < shots)
            {
                Console.Write("Выстрел " + (j + 1) + ": ");
                pistol.Shoot();
                j++;
            }

            Console.WriteLine("После выстрелов: " + pistol);
            Console.WriteLine();

            // пистолет по умолчанию
            Console.WriteLine("Пистолет по умолчанию " +
                "(5 патронов) ");
            Pistol defPistol = new Pistol();
            Console.WriteLine("Создан: " + defPistol);
            defPistol.Shoot();
            Console.WriteLine("После выстрела: " + defPistol);
        }
    }
}