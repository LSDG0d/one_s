using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace one_s
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Задание 1.");
            //Вводим с консоли размеры масива
            Console.Write("Введите размер матрицы (N): ");
            int n = int.Parse(Console.ReadLine());

            // Создаем двумерный массив
            int[,] matrix = new int[n, n];

            //Заполняем его случайными значениями
            Random random = new Random();
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    matrix[i, j] = random.Next(1, 10);
                }
            }

            //Отрисовываем матрицу
            Console.WriteLine("Исходная матрица:");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(matrix[i, j] + "\t");
                }
                Console.WriteLine();
            }
            int sum = 0;
            for (int i = 0; i < n; i++)
            {
                sum += matrix[i, i] * matrix[i, n - i - 1];
            }

            Console.WriteLine($"Сумма произведений элементов на главной и побочной диагоналях: {sum}");
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("Задание 2.");

            Console.Write("Введите первое число: ");
            int a = int.Parse(Console.ReadLine());

            Console.Write("Введите второе число: ");
            int b = int.Parse(Console.ReadLine());

            bool isDivisible = IsDivisibleWithoutDivision(a, b);

            if (isDivisible)
            {
                Console.WriteLine($"{a} делится на {b} нацело.");
            }
            else
            {
                Console.WriteLine($"{a} не делится на {b} нацело.");
            }
            Console.ReadKey();

            Console.Clear();
            Console.WriteLine("Задание 3.");

            Console.Write("Введите переменную A: ");
            int A = int.Parse(Console.ReadLine());

            Console.Write("Введите переменную B: ");
            int B = int.Parse(Console.ReadLine());

            //Алгоритм меняющий их местами
            A = A - B;
            B = A + B;
            A = B - A;
            Console.WriteLine($"A={A}, B={B}");
            Console.ReadKey();
            Console.Clear();


            Console.WriteLine("Задание 4.");
            Console.Write("Введите число a: ");
            a = int.Parse(Console.ReadLine());

            Console.Write("Введите число b: ");
            b = int.Parse(Console.ReadLine());

            Console.Write("Введите длину массива: ");
            int length = int.Parse(Console.ReadLine());

            int[] array = new int[length];

            Console.WriteLine("Введите элементы массива:");
            for (int i = 0; i < length; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }

            int countA = CountOccurrences(array, a);
            int countB = CountOccurrences(array, b);

            if (countA > countB)
            {
                Console.WriteLine($"Модуль {Math.Abs(a)} встречается чаще в массиве.");
            }
            else if (countB > countA)
            {
                Console.WriteLine($"Модуль {Math.Abs(b)} встречается чаще в массиве.");
            }
            else
            {
                Console.WriteLine($"Модули {Math.Abs(a)} и {Math.Abs(b)} встречаются одинаково часто в массиве.");
            }
            Console.ReadKey();
        }
        static bool IsDivisibleWithoutDivision(int a, int b)
        {
            // Используем цикл и вычитание для проверки деления нацело
            while (a >= b)
            {
                a -= b;
            }

            // Если результат вычитания стал равен 0, значит a делится нацело на b
            return a == 0;
        }
        static int CountOccurrences(int[] array, int number)
        {
            // Подсчитываем количество вхождений числа (или его модуля) в массиве
            int count = 0;
            foreach (var element in array)
            {
                if (Math.Abs(element) == Math.Abs(number))
                {
                    count++;
                }
            }
            return count;
        }
    }

}
