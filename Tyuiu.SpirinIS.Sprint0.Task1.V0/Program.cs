﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Tyuiu.SpirinIS.Sprint0.Task1.V0
{
    class Program
    {
        static void Main(string[] args)
        {
            //Вывод на консоль строку Hello, World!
            Console.WriteLine("Hello, World!");

            //Объявляем переменные
            string name = "Игорь";
            int age = 45;

            //Вывод на консоль строку 
            Console.WriteLine("Здравствуйте меня зовут " + name + " мне " + age + " лет.");
             
            //Ожидание нажатия клавиши, нужно чтобы окно консоли не закрывалось
             Console.ReadKey();
        }
    }
}
