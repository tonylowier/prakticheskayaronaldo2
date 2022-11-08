namespace Практическая__2
{
    internal class Program
    {
        static void Main()
        {
            while (true)
            {
                int a;

                Console.WriteLine("Введите программу, которую хотите открыть: ");
                Console.WriteLine("1. Угадай число ");
                Console.WriteLine("2. Таблица умножения ");
                Console.WriteLine("3. Делители числа ");
                Console.WriteLine("4. Закрыть программу ");
                a = Convert.ToInt32(Console.ReadLine());





                if (a == 1)
                {
                    Ugaday_Chislo();
                }
                else if (a == 2)
                {
                    Umnozhenie();
                }
                else if (a == 3)
                {
                    delitel();

                }

                else if (a == 4)
                {

                    Console.WriteLine("Конец программы");
                    break;
                }

                else
                {
                    Console.WriteLine("Неверно введено! Повторите. ");

                }
            }





        }
        static void Ugaday_Chislo()


        {
            Random random = new Random();
            int a;
            int b;
            a = random.Next(100);
            while (true)
            {
                Console.WriteLine("Введите число: ");
                b = Convert.ToInt32(Console.ReadLine());
                if (b == a)
                {
                    Console.WriteLine("Вы угадали, это число: " + a);
                    break;
                }
                else if (b > a)
                {
                    Console.WriteLine("Много, вводите меньше");
                }
                else
                {
                    Console.WriteLine("Мало, вводите больше");
                }
            }


        }


        static void Umnozhenie()
        {
            int[,] table;

            table = new int[10, 10];

            for (int i = 1; i < table.GetLength(0); i++)
            {
                for (int j = 1; j < table.GetLength(1); j++)
                {
                    if (i == 0)
                    {
                        table[i, j] = j + 1;
                    }
                    if (j == 0)
                        table[i, j] = i + 1;
                    table[i, j] = i * j;



                }

            }
            for (int i = 1; i < table.GetLength(0); i++)
            {
                for (int j = 1; j < table.GetLength(1); j++)
                {


                    Console.Write("{0,3}", table[i, j]);
                }
                Console.WriteLine();
            }


        }
        static void delitel()
        {
            Console.Write("Введите число ");
            int n;
            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Все делители числа: ");
            for (int i = 1; i <= n; i++)
            {
                if (n % i == 0)
                    Console.WriteLine(i);
            }

        }
    }


}