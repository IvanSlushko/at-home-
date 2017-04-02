using System;

namespace Classes
{
    class Program
    {
        static void Main()
        {
            PartialClass instance = new PartialClass();

            instance.MethodFromPart1(); //из 1 части
            instance.MethodFromPart2(); //из 2 части
        }
    }
}
