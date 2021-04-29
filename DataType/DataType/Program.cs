using System;

namespace DataType
{
    class Program
    {
        static void Main(string[] args)
        {
            // data types

            bool completo = false;
            char genero = 'F';
            char letra = '\u0041';
            byte n1 = 126;
            int n2 = 1000;
            int n3 = 2147483647;
            long n4 = 2147483648L;
            float n5 = 4.5f;
            double n6 = 4.5;

            // nullable - 2 types to declare. Example.
            Nullable<double> numNull1 = null;
            double? numNull2 = null;
            double? numNull3 = 10.0;

            String nome = "Maria Green";
            Object obj1 = "Alex Brown";
            Object obj2 = 4.5f;
            Console.WriteLine("completo= " + completo);
            Console.WriteLine("genero= " + genero);
            Console.WriteLine("letra= " + letra);
            Console.WriteLine("n1= " + n1);
            Console.WriteLine("n2= " + n2);
            Console.WriteLine("n3= " + n3);
            Console.WriteLine("n4= " + n4);
            Console.WriteLine("n5= " + n5);
            Console.WriteLine("n6= " + n6);
            Console.WriteLine("nome= " + nome);
            Console.WriteLine("obj1= " + obj1);
            Console.WriteLine("obj2= " + obj2);

            Console.WriteLine("numNull1= " + numNull1.GetValueOrDefault());
            Console.WriteLine("numNull2= " + numNull2.HasValue);
            Console.WriteLine("numNull3= " + numNull3.Value);
        }
    }
}
