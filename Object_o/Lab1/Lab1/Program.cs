// Lab1

using System;

namespace Lab1
{
    class MainClass
    {
        private static Array MyArray = new Array();

        public static void Main(string[] args)
        {
            MyArray.square();
            MyArray.logout();
        }
    }
    class Array {
        private double[] array;
        private double[] arrayNew;

        private int length;

        private Random rnd = new Random();

        // Criating arrais
        private void ArrayLength () {
            Console.WriteLine("\n Write leangth of array");
            length = Convert.ToInt32(Console.ReadLine());
            array = new double[length];
            arrayNew = new double[length];
        }

        // Fulling arrais with data
        private void init()
        {
            for (int i = 0; i < length; i++)
                array[i] = (double)rnd.Next(1, 100);
        }

        // Doing math =)
        public void square () {
            for (int i = 0; i < length; i++)
                arrayNew[i] = Math.Pow(array[i],2);
        }

        // Printing data out
        public void logout () {
            for (int i = 0; i < length; i++)
                Console.WriteLine("\n" + arrayNew[i]);
        }

        public Array () {
            ArrayLength();
            init();
        }
    }
}
