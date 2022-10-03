using System;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

namespace ClassLibraryHomework
{
    public class Class1
    {
        public static void Print(string task, string fio = "Пугачеча Александра")
        {
            Console.Write("\n=============================================================================================");
            Console.WriteLine($"\nЗадание: {task} \nФИО: {fio}");
            Console.WriteLine("=============================================================================================\n");
        }

        public static void Minimum(int x = 0, int y = 0, int z = 0)
        {
            ClassLibraryHomework.Class1.Print("Написать метод, возвращающий минимальное из трёх чисел.");

            Console.Write("Введите 1 число:");
            x = int.Parse(Console.ReadLine());
            Console.Write("Введите 2 число:");
            y = int.Parse(Console.ReadLine());
            Console.Write("Введите 3 число:");
            z = int.Parse(Console.ReadLine());

            int Min;
            if (x < y && x < z)
                Min = x;
            else if (y < z && y < x)
                Min = y;
            else
                Min = z;

            Console.WriteLine($"Минимальное число равно: {Min}");
        }





        public static void Plus(string num = " ")
        {
            ClassLibraryHomework.Class1.Print("Написать метод подсчета количества цифр числа.");

            Console.Write("Введите число:");
            num = Console.ReadLine();


            for (int i = 0; i < num.Length; i++)
            {
                if (i == num.Length - 1)
                {
                    Console.WriteLine($"В num {i + 1} цифр");
                }

            }

        }




        public static void SumOfOddNums(int num = 0)
        {
            ClassLibraryHomework.Class1.Print("С клавиатуры вводятся числа, пока не будет введен 0. Подсчитать сумму всех нечетных положительных чисел.");

            int result = 0;

            do
            {
                Console.Write("Введите число: ");
                num = int.Parse(Console.ReadLine());
                if (num % 2 != 0)
                {
                    result += num;
                }

            }

            while (num != 0);

            Console.WriteLine($"Сумма чисел = {result}");
        }


        public static void LoginPassword(string login = "root", string password = "GeekBrains", int i = 3)
        {
            ClassLibraryHomework.Class1.Print("Реализовать метод проверки логина и пароля. На вход метода подается логин и пароль. \nНа выходе истина, если прошел авторизацию, и ложь, если не прошел (Логин: root, Password: GeekBrains). " +
            "\nИспользуя метод проверки логина и пароля, написать программу: пользователь вводит логин и пароль, программа пропускает его дальше или не пропускает. " +
            "\nС помощью цикла do while ограничить ввод пароля тремя попытками.");

            do
            {
                Console.Write($"Введите логин: ");
                string userLogin = Console.ReadLine();
                Console.Write($"Введите пароль: ");
                string userPassword = Console.ReadLine();

                if (userLogin == login && userPassword == password)
                {
                    Console.WriteLine("\nЛогин и пароль верны");
                    break;
                }
                else
                {
                    i--;
                    Console.WriteLine($"Вы ввели неверный логин или пароль, попробуйте еще раз. \nУ вас {i} попытки");
                }

            }

            while (i > 0);
        }


        public static void Imt(int weight = 0, double height = 0)
        {
            ClassLibraryHomework.Class1.Print("а) Написать программу, которая запрашивает массу и рост человека, вычисляет его индекс массы и сообщает, нужно ли человеку похудеть, набрать вес или всё в норме." +
           "\nб) *Рассчитать, на сколько кг похудеть или сколько кг набрать для нормализации веса.");

            Console.Write("Введите свой вес: ");
            weight = int.Parse(Console.ReadLine());
            Console.Write("Введите свой рост в метрах: ");
            height = double.Parse(Console.ReadLine());


            var result = weight / (Math.Pow(height, 2));
            var goodWeight = (height * 100) - 110;
            var needToGain = goodWeight - weight;
            var needToSlim = weight - goodWeight;


            Console.WriteLine("Ваш IMT равен: {0:F2}", result);

            if (result < 19)
            {
                Console.WriteLine($"У Вас недостаток веса, Вам следует набрать еще {needToGain} кг");
            }

            else if (result > 25 && result < 30)
            {
                Console.WriteLine($"У Вас хорошее соотношение роста и веса");
            }
            else if (result > 30)
            {
                Console.WriteLine($"У Вас избыточный вес, Вам следует похудеть на {needToSlim} кг");
            }


        }


        public static void GoodNumbers()
        {
            ClassLibraryHomework.Class1.Print("Написать программу подсчета количества «хороших» чисел в диапазоне от 1 до 1 000 000 000. " +
            $"\n«Хорошим» называется число, которое делится на сумму своих цифр. Реализовать подсчёт времени выполнения программы, используя структуру DateTime.");

            int goodnum = 0;
            int min = 1;
            int max = 1000000;


            DateTime currentTime = DateTime.Now; // фиксируем время начала запуска программы

            for (int num = min; num <= max; num++)
            {

                string snum = num.ToString(); //конвертируем num в строку
                int result = 0; //обнуляем результат для записи новой суммы цифр

                for (int i = 0; i < snum.Length; i++)
                {
                    result += snum[i] - '0'; /* суммируем цифры числа num по индексам i. вычитаем 0, т.к. его табличное значение = 48. 0 находится в '', потому что нам нужно не сам 0 , а его табличное значение (48).
                                              все числа в char все числа имеют  значение 48 + число */
                }

                if (num % result == 0)
                {
                    goodnum++; //если остаток от деления 0, то число хорошее
                }

            }
            Console.WriteLine($"Количество <Хороших> числе составило: {goodnum} \nПрограмма выполнялась: {DateTime.Now - currentTime}");
        }

        
    }
}
    
