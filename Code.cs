
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace _1laba
{
    struct student
    {
        public string firstName;
        public string lastName;
        public int age;
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            int[] mass = { 11, 44, 55, 22, 33, 66 };

            Random rand = new Random();

            int difference = 0;
            bool found = false;

            int min = mass[0];
            int max = mass[0];

            Console.WriteLine("Задание 1: \n");

            Console.Write("Массив: ");

            for (int i = 0; i < mass.Length; i++)
            {
                Console.Write($"{mass[i]} ");
            }

            for (int i = 0; i < mass.Length; i++)
            {
                if (mass[i] < min)
                {
                    min = mass[i];
                }
            }

            for (int i = 0; i < mass.Length; i++)
            {
               if (mass[i] > max)
                {
                    max = mass[i];
                }
            }

            difference = max - min;

            Console.WriteLine();

            Console.WriteLine($"Минимальный элемент массива: {min}");
            Console.WriteLine($"Максимальный элемент массива: {max}");
            Console.WriteLine($"Разница: {difference}");

            Console.WriteLine("------------------------------------------------");


            Console.WriteLine("Задание 2: \n");
            Console.Write("Массив со случайными значениями: ");

            for (int i = 0; i < mass.Length; i++)
            {
                mass[i] = rand.Next(1, 101);
                Console.Write($"{mass[i]} ");
            }

            Console.WriteLine("\n------------------------------------------------");
            Console.WriteLine("Задание 3: \n");
            Console.Write("Введите размер массива: ");

            int size = int.Parse(Console.ReadLine());
            int[] mass2 = new int[size];    

            
            Console.Write($"Массив: ");
            for (int i = 0; i < mass2.Length; i++)
            {
                mass[i] = rand.Next(1, 100);
                Console.Write($"{mass[i]} ");
            }
           
            Console.WriteLine("\n------------------------------------------------");
            Console.Write("Задание 4: \n");

            int[,] mass3 =
        {
            { 1, 2, 3 },
            { 4, 5, 6 },
            { 7, 8, 9 },

        };

            int rows = mass3.GetLength(0); // Количество строк
            int columns = mass3.GetLength(1); // Количество столбцов

            int[] columnSum = new int[columns]; // Массив для хранения сумм значений в каждом столбце

            //Вывод матрицы на экран
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(mass3[i, j] + " ");
                }

                Console.WriteLine();
            }
            
            // Вычисляем сумму значений в каждом столбце
            for (int j = 0; j < columns; j++)
            {        
                int sum = 0;
                for (int i = 0; i < rows; i++)
                {
                    sum += mass3[i, j];
                }
                columnSum[j] = sum;
            }

            // Выводим результаты
            for (int j = 0; j < columns; j++)
            {
                Console.WriteLine("Сумма значений по столбцам {0}: {1}",j, columnSum[j]);
            }
            Console.WriteLine("------------------------------------------------");
            Console.WriteLine("Задание 5: \n");

      

        //Создаем массив структур student
        student[] students = new student[4];

            students[0].firstName = "Ivan";
            students[0].lastName = "Ermalaev";
            students[0].age = 18;

            students[1].firstName = "Nikita";
            students[1].lastName = "Ezhov";
            students[1].age = 18;

            students[2].firstName = "Vlad";
            students[2].lastName = "Kulikov";
            students[2].age = 19;

            students[3].firstName = "Semen";
            students[3].lastName = "Volkov";
            students[3].age = 19;


            Console.Write($"Список студентов по фамилиям: ");
            foreach(student s in students)
            {
                Console.Write($"{s.lastName} ");
            }

            Console.Write($"\nВведите фамилию студента для доп информации: ");

            string searchLastname = Console.ReadLine();

            Console.WriteLine();
            
            

            for (int i = 0; i < students.Length; i++)
            {
                if (students[i].lastName == searchLastname)
                {
                    Console.WriteLine("Найден студент с фамилией {0}: ", searchLastname);
                    Console.WriteLine("Имя: " + students[i].firstName);
                    Console.WriteLine("Фамилия: " + students[i].lastName);
                    Console.WriteLine("Возраст: " + students[i].age);

                    found = true;
                    break; //
                }
            }
                if (!found)
                {
                    Console.WriteLine("Данного студента с фамилией {0} нет в списке", searchLastname);  
                }
            }
        }
    }


