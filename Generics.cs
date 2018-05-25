using System;
using System.Collections.Generic;

namespace FirstConsoleProject
{
    class MainClass
    {
        public static void Main (string[] args)
        {
            Console.WriteLine(Utility.CompareValues(10,3));
            Console.WriteLine(Utility.CompareTypes("hello", 54));
            Console.WriteLine(Utility.CompareTypes("hi", "hello"));
        }
    }

    class Utility
    {
        public static bool CompareValues<T01, T02> (T01 value01, T02 value02)
        {
            return value01.Equals(value02);
        }
        public static bool CompareTypes<T01, T02>(T01 type01, T02 type02)
        {
            return typeof(T01).Equals(typeof(T02));
        }
    }

}