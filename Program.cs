using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace One_dimensional_arrays_Ex1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {

                //Задача 1.
                //Заполнить одномерный массив из 8 целых чисел с клавиатуры и вывести его на экран.

                /*int[] array = new int[8];  //конструктор new обязателен в этом случае
                for(int i = 0; i < array.Length; i++)
                {
                    Console.Write($"Array[{i+1}] = "); //i+1 для того, чтобы начинался не с 0
                    array[i] = Convert.ToInt32(Console.ReadLine());
                }
                for(int i = 0; i < array.Length; i++)
                {
                    Console.WriteLine($"Array[{i+1}] = {array[i]}");
                }*/

                //Задача 2.
                //Объявить одномерный массив из n вещественных чисел,
                //инициализировать его положительными и отрицательными значениями.
                //Вывести на экран только положительные элементы.

                /*double[] array = { -6.5, 4.5, 123, -5, 12, -18, -3.63, 76};
                for(int i=0;i<array.Length;i++)
                {
                    if (array[i] > 0)
                    {
                        Console.WriteLine($"Array[{i}] = {array[i]}");
                    }
                }*/

                //Задача 3.
                //Заполнить одномерный массив из шести элементов следующими значениями:
                //первый элемент массива равен - -7, второй — 10, третий — 5, четвертый — 16,
                //пятый — -4, шестой — 18, не используя клавиатуру.
                //Вывести одномерный массив в обратном порядке.

                /*int[] array = { -7, 10, 5, 16, -4, 18 }; //ввели сразу
                for(int i = 5; i < array.Length && i>=0; i--)
                {
                    Console.WriteLine($"Array[{i}] = {array[i]}");
                }*/

                //Задача 4.
                //Массив предназначен для хранения значений ростов двенадцати человек.
                //С помощью датчика случайных чисел заполнить массив целыми значениями,
                //лежащими в диапазоне от 163 до 190 включительно.

                /*int[] array = new int[12];

                Random random = new Random();
                for (int i = 0; i < array.Length; i++)
                {

                    array[i] = random.Next(163, 190);
                    Console.WriteLine($"Array[{i}] = {array[i]}");
                        
                }*/

            }
            catch (Exception ex)
            {
                Console.WriteLine($"Исключение: {ex.Message}");
                Console.WriteLine($"Метод: {ex.TargetSite}");
                Console.WriteLine($"Трассировка стека: {ex.StackTrace}");
            }
            Console.ReadKey();

        }
    }
}
