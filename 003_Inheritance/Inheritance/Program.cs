﻿using System;

// Наследование. 

// Наследование — механизм объектно-ориентированного программирования, позволяющий описать
// новый (производный) класс
// на основе уже существующего (базового),
// при этом свойства и функциональность базового класса заимствуются новым производным классом.

//        Базовый класс             -                Производный  класс
//        Супер класс               -                Подкласс или (сабкласс)
//        Родительский класс        -                Дочерний класс
//        Родитель                  -                Потомок

namespace Inheritance
{
    class Program
    {
        static void Main()
        {
            DerivedClass instance = new DerivedClass();

            Console.WriteLine(instance.publicField);
           // Console.WriteLine(instance.protectedField); НЕДОСТУПНО!!!!!

            // Delay.
            Console.ReadKey();
        }
    }
}