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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<string> items = new List<string>();
        public int n = 0;
        string writePath = @"Out1.txt";//Адрес куда записывать результат

        private void button1_Click(object sender, EventArgs e)
        {
            int q = 0;
            int[] Razm = new int[n];

            RichTextBox1.Text = "";
            RichTextBox1.Text += "{";
            foreach (string Item in items)
            {
                RichTextBox1.Text += Item;
                q++;
                if (q < (n))
                {
                    RichTextBox1.Text += ",";
                }
            }
            RichTextBox1.Text += "}";

            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();

            StreamWriter sw = new StreamWriter(writePath, false, System.Text.Encoding.Default);
            for (int t = n; t > 0; t--)
            recfan2(Razm, n, t, sw);
            sw.Write("{ }");//пустое множество
            sw.Close();

            stopWatch.Stop();
            TimeSpan ts = stopWatch.Elapsed;
            string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}", ts.Hours, ts.Minutes, ts.Seconds, ts.Milliseconds);
            RichTextBox.Text = elapsedTime;
        }


        void recfan2(int[] Razm, int n, int k, StreamWriter sw)
        {
            for (int i = 0; i < k; i++)
            {
                Razm[i] = i;
                sw.Write(items[i]);
            }
            sw.Write("\n");

            while (CombObject(Razm, k, n))//Пока есть сочетания, пишем их
            {
                for (int j = 0; j < k; j++)
                {
                    sw.Write(items[Razm[j]]);
                }
                sw.Write("\n");
            }
        }

        bool CombObject(int[] Razm, int k, int n)
        {
            for (int i = k - 1; i >= 0; i--)
            {
                if (Razm[i] < n - k + i)
                {
                    Razm[i]++;
                    for (int j = i + 1; j < k; j++)
                    {
                        Razm[j] = Razm[j - 1] + 1;
                    }
                    return true;
                }
            }
            return false;
        }

        private void buttonToWrite_Click(object sender, EventArgs e)
        {
            items.Add(TextBox1.Text);
            n++;
            TextBox1.Text = "";
        }
    }
}
