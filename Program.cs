using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp25
{
    class Program
    {
        //Статический метод Sum, который вычисляет и возращает сумму целых чисел 
        public static int Sum(int m, int n)
        {
            int result = 0; 
            for (int i = m; i <= n; i++)
            {
                result += 1;
            }
            return result;
        }
        //Обьявляем Делегат 
        public delegate int SumDelegate(int m, int n);
        static void Main(string[] args)
        {
            //Обьявляем сам делегат
            SumDelegate sumDelegate = Sum;
            //Присваеваем значения делегату
            int res1 = sumDelegate(1, 5);
            int res2 = sumDelegate(5, 10);
            int res3 = sumDelegate(10, 100);
            //Применяем ранее обьявленный делегат в программе 3 раза, и выводим его в консоль
            Console.WriteLine($"Сумма от 1 до 5 = {res1}");
            Console.WriteLine($"Сумма от 5 до 10 = {res2}");
            Console.WriteLine($"Сумма от 10 до 100 = {res3}");
            Console.Read();
        }
    }
}
