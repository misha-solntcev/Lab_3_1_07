using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*7.Дано целое число N (> 0). Найти наименьшее целое положительное 
    число K, квадрат которого превосходит N: K2 > N.Функцию 
    извлечения квадратного корня не использовать.*/

namespace Lab_3_1_07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Метод брут форс.
            int N = 314873527;
            int K = 0;
            do
            {                
                K += 1;
                Console.WriteLine(K);
            }
            while (K * K <= N);

            Console.WriteLine($"N = {N}");
            Console.WriteLine($"K-1 = {K-1}, (K-1)^2 = {(K-1) * (K-1)}");
            Console.WriteLine($"K = {K}, K^2 = {K * K}");
            Console.ReadKey();
        }
    }
}
