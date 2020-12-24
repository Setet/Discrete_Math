﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Diagnostics; // для таймера
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        List<string> items = new List<string>();//список элем
        HashSet<string> Gachi = new HashSet<string>();//список слов 1
        public int n = 0, y = 0, c = 0;
        int j;
        string writePath = @"Answer.txt";//место записи в файл

        private void buttonAnswer_Click(object sender, EventArgs e)
        {
            int[] Razm = new int[n];

            RichTextBox1.Text = "";
            foreach (string Item in items)//красота для вывода в RichTextBox1
            {
                RichTextBox1.Text += Item;
            }
            
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();

            StreamWriter sw = new StreamWriter(writePath, false, System.Text.Encoding.Default);
            recfan2(Razm, j, items, n, sw);//осн функция
            sw.Close();

            stopWatch.Stop();
            TimeSpan ts = stopWatch.Elapsed;
            string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}", ts.Hours, ts.Minutes, ts.Seconds, ts.Milliseconds);
            RichTextBox.Text = elapsedTime;//запись времени работы программы
        }//запись в файл

        void swap(int[] Razm, int i, int j)
        {
            int s = Razm[i];
            Razm[i] = Razm[j];
            Razm[j] = s;
        }

        void recfan2(int[] Razm, int j, List<string> items, int n, StreamWriter sw)
        {
            int w = 0;//для цифорок в файле
            string Van="";//список в которые записываются по 1 элементы слова

            for (int i = 0; i < n; i++)
            {
                Razm[i] = i;
            }
            sw.Write("Начальное слово - "+RichTextBox1.Text+"\n");//запись слова "предка"
            while (nextCombObject(Razm, n))
            {
                foreach (int item in Razm)
                {
                    Van+=items[item];//запись букв в список
                }
                Gachi.Add(Van);//запись слов в Гачи
                Van = "";//опустошение списка 
            }

            foreach (string value in Gachi)
            {
                w++;
                sw.Write(w+":"+value+"\n");
            }
        }

        bool nextCombObject(int[] Razm, int n)
        {
            int j = n - 2;
            while (j != -1 && Razm[j] >= Razm[j + 1]) j--;
            if (j == -1)
                return false; // больше перестановок нет
            int k = n - 1;
            while (Razm[j] >= Razm[k]) k--;
            swap(Razm, j, k);
            int l = j + 1, r = n - 1; // сортируем оставшуюся часть последовательности
            while (l < r)
                swap(Razm, l++, r--);
            return true;
        }

        private void buttonToWrite_Click(object sender, EventArgs e)
        {
            items.Add(TextBox1.Text);
            n++;
            TextBox1.Text = "";
        }//кнопка записи элемент в алфавит
    }
}