using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySortsLibrary;
using System.IO;

namespace ConsoleApplication1
{
    class Program
    {
        public static void WritingUnsortedArrayToFile(int n, int min, int max)
        {
            int[] a = new int[n];
            Random r = new Random();
            StreamWriter sw = new StreamWriter("UnsortedArray.txt");
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = r.Next(min, max);
                sw.Write(a[i] + " ");
            }
            sw.Close();
        }

        public static void ReadArrayFromFile(StreamReader sr, int[] a)
        {
            string[] b = sr.ReadLine().Split(' ');
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = int.Parse(b[i]);
            }
        }

        public static void WritingSortedArrayToFile(int[] array, StreamWriter sw, string time)
        {
            for (int i = 0; i < array.Length; i++)
            {
                sw.WriteLine(array[i]);
            }
            sw.WriteLine("Потрачено времени: {0}", time);
            sw.Close();
        }

        static void Main(string[] args)
        {
            int n = 50000;
            int[] a = new int[n];
            WritingUnsortedArrayToFile(n, -50000, 50000);
            Sorts b = new Sorts();
            StreamReader sr = new StreamReader("UnsortedArray.txt");
            ReadArrayFromFile(sr, a);
            StreamWriter Bubble = new StreamWriter("Bubble.txt");
            StreamWriter insSort = new StreamWriter("insSort.txt");
            StreamWriter selSort = new StreamWriter("selSort.txt");
            var before = DateTime.UtcNow;
            //b.bubbleSort(a);
            b.insertionSort(a);
            //b.selectionSort(a);
            //b.quickSort(a,0,a.Length-1);
            var potracheno = DateTime.UtcNow - before;
            string potracheno_string = potracheno.ToString();
            WritingSortedArrayToFile(a, insSort, potracheno_string);
        }
    }
}
