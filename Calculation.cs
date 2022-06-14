using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace pr16_3
{
    class Calculation
    {
        public static void Third(double[] mas)
        {
            Queue<myList> myQueue = new Queue<myList>();
            int[] mass2 = new int[mas.Length];
            for (int i = 0; i < mas.Length; i++)
            {
                int count = (from x in mas where x == mas[i] select x).Count();
                mass2[i] = count;

            }
            int j = 0;
            double[] masss3 = new double[mas.Length];
            while (j != mas.Length)
            {
                if (!masss3.Contains(mas[j]))
                {
                    myList num = new myList();
                    num.Number = mas[j];
                    num.Freq = mass2[j];
                    myQueue.Enqueue(num);
                    masss3[j] = mas[j];
                }
                j++;
            }
            Console.WriteLine();
            Console.WriteLine("Изначальный массив");
            Console.WriteLine();
            foreach (myList bam in myQueue)
            {
                Console.WriteLine($"{bam.Number} - {bam.Freq}");
            }
            Console.WriteLine();
            Console.WriteLine("Новый массив в котором a[i] = a[i] * частоту");
            Console.WriteLine();
            foreach (myList l in myQueue)
            {
                Console.WriteLine($"{l.Number * l.Freq} - {l.Freq}");
            }
        }
    }
}
