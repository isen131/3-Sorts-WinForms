using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySortsLibrary;
using System.IO;
using System.Threading;

namespace WinForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public static void WritingUnsortedArrayToFile(int n, int min, int max)
        {
            int[] a = new int[n];
            Random r = new Random();
            File.Delete("UnsortedArray.txt");
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

        public static void WritingSortedArrayToFile(int[] array, StreamWriter sw)
        {
            for (int i = 0; i < array.Length; i++)
            {
                sw.WriteLine(array[i]);
            }
            sw.Close();
        }

        int[] a;

        private void GenerateArray_Click(object sender, EventArgs e)
        {
            Status.Text = "Массив создается";
            try
            {
                int n = int.Parse(ArrayLength.Text);
                WritingUnsortedArrayToFile(n, int.Parse(MinValue.Text), int.Parse(MaxValue.Text));
                a = new int[n];
            }
            catch (Exception E)
            {
                if ((ArrayLength.Text) == "" | (MinValue.Text == "") | (MaxValue.Text == ""))
                {
                    MessageBox.Show("Все поля должны быть заполнены", "Ошибка");
                }
                else
                    MessageBox.Show("Проверьте правильность введенных данных", "Ошибка");
                return;
            }
            StreamReader sr = new StreamReader("UnsortedArray.txt");
            ReadArrayFromFile(sr, a);
            sr.Close();
            Status.Text = "Новый массив создан";
        }

        private void SortIt_Click(object sender, EventArgs e)
        {
            Sorts b = new Sorts();
            if (a == null)
            {
                MessageBox.Show("Массив еще не создан", "Ошибка");
                return;
            }
            var before = DateTime.UtcNow;
            if (Bubble.Checked)
            {
                StreamWriter BubbleSort = new StreamWriter("Bubble.txt");
                b.bubbleSort(a);
                WritingSortedArrayToFile(a, BubbleSort);
                Status.Text = "Готово";
            }
            if (Insertions.Checked)
            {
                StreamWriter insSort = new StreamWriter("insSort.txt");
                b.insertionSort(a);
                WritingSortedArrayToFile(a, insSort);
                Status.Text = "Готово";
            }
            if (Selection.Checked)
            {
                StreamWriter selSort = new StreamWriter("selSort.txt");
                b.selectionSort(a);
                Status.Text = "Готово";
                WritingSortedArrayToFile(a, selSort);
            }
            if ((Bubble.Checked == false)&&(Insertions.Checked == false)&&(Selection.Checked == false))
            {
                Status.Text = "Ожидание действий пользователя";
                MessageBox.Show("Вы не выбрали сортировку", "Ошибка");
                return;
            }
            var potracheno = DateTime.UtcNow - before;
            string potracheno_string = potracheno.ToString();
            TimeSpend.Text = potracheno_string;
        }

        private void SortIt_MouseDown(object sender, MouseEventArgs e)
        {
            Status.Text = "Массив сортируется";
        }
    }
}
