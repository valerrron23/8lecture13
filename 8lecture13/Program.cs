using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortLab
{
    class Program
    {

        static void Main()
        {
            Sort(); //сортировка
        }

        /*Основная программа*/
        static void Sort()
        {

            int[] myint = { //задание элементов массива
				99,
                88,
                77,
                66,
                55,
                44,
                33,
                22,
                11,
                8,
                5,
                3,
                1
            };

            WriteArray(myint);//вывод массива
            ShakerSort(myint);//сортировка
            WriteArray(myint);//вывод массива

            Console.ReadLine(); //ожидание нажатия клавиши

        }
        /* Шейкер-сортировка */
        static void ShakerSort(int[] myint)
        {
            int beg, //целочисленная переменная
            end; //целочисленная переменная
            int count = 0; //целочисленная переменная

            for (int i = 0; i < myint.Length / 2; i++) //можно переберать за кол-во итераций, в 2 раза меньше
            { //целочисленное деление округляет в меньшую сторону
                beg = 0; //задание переменной
                end = myint.Length - 1; //задание переменной

                do //цикл с постусловием
                {
                    count += 2;
                    /* идем спереди */
                    if (myint[beg] > myint[beg + 1]) Swap(myint, beg, beg + 1); //выполнять, если верно условие
                    end--; //сдвигаем позицию назад
                    beg++; //сдвигаем позицию вперед

                    /* идем сзади */
                    if (myint[end - 1] > myint[end]) Swap(myint, end - 1, end); //выполнять, если верно условие
                    end--; //сдвигаем позицию назад

                }
                while (beg <= end); // условия усреднения
            }
            Console.Write("\nКоличество сравнений = {0}\n", count);
        }

        /* Поменять элементы местами */
        static void Swap(int[] myint, int i, int j)
        {
            int glass; //задание переменной
            glass = myint[i]; //задание элемента массива
            myint[i] = myint[j]; //задание элемента массива
            myint[j] = glass; //задание элемента массива
        }

        /*Вывести массив*/
        static void WriteArray(int[] a)
        {
            foreach (int i in a) //выполнять для каждого указанного элемента
                Console.Write("{0}|", i); //вывод массива
            Console.WriteLine("\n\n\n"); //вывод массива
        }
    }
}