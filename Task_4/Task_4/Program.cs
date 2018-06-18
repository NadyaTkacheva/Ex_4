using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4
{
    class Program
    {       
       /// <summary>
       /// проверка на ввод точности
       /// </summary>
       /// <returns></returns>
        static double InputDouble()
        {
            double a = 0;
            bool ok;
            do
            {
                try
                {
                    a = Convert.ToDouble(Console.ReadLine());
                    ok = true;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Ошибка! Введите число типа double");
                    ok = false;
                }
            } while (!ok);
            return a;
        }
        /// <summary>
        /// метод для подсчета факториала числа
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        static int Fact(int n)
        {
            int fact = 1;
            for (int i = 1; i <= n; i++) 
             fact = fact * i; 
            return fact;
        }
    
        /// <summary>
        /// метод для подсчета суммы
        /// </summary>
        /// <param name="eps"></param>
        static void Sum(double eps)
        {
            int n = 0;
            double se = 0, se1 = 0;
            //цикл подсчета
            do
            {
                se = se1;
                se1 = se + Math.Pow((-2), n) / Fact(n);
                n++;
            } while ((Math.Abs(se1 - se) >= eps));

            Console.WriteLine("Сумма равна: "+se1);
        }
        static void Main(string[] args)
        {
            double eps = 0; //точность
            Console.Write("Eps= ");
            eps = InputDouble();
            Sum(eps);//метод для суммы
            Console.ReadKey();

            
        }
    }
}
