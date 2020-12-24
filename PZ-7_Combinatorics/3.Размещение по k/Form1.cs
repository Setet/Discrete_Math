using System;
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
using System.Runtime.InteropServices;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        const int n = 10;
        string[] A = new string[n] { "a", "b", "c", "d", "e", "f", "g", "h", "i", "j" };
        int j;
        string writePath = @"C:\Проги\ln1.txt";

        private void buttonAnswer_Click(object sender, EventArgs e)
        {
            int k = (TextBox.Text != "") ? Convert.ToInt32(TextBox.Text) : 0; // Условный оператор, если текстбокс не пуст, то к = текстбокс, иначе к = 0
            int[] Razm = new int[k];

            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();

            StreamWriter sw = new StreamWriter(writePath, false, System.Text.Encoding.Default);
            recfan2(Razm, j, A, n, k, sw);
            sw.Close();

            stopWatch.Stop();
            TimeSpan ts = stopWatch.Elapsed;
            string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}", ts.Hours, ts.Minutes, ts.Seconds, ts.Milliseconds);
            RichTextBox.Text = elapsedTime;
        }

        void recfan2(int[] Razm, int j, string[] A, int n, int k, StreamWriter sw)
        {
            int q = 1;
            for (int i = 0; i < k; i++)
                Razm[i] = 0;

            while (nextCombObject(Razm, k, n))
            {
                sw.Write(q + ": ");
                foreach (int item in Razm)
                {
                    sw.Write(A[item]);
                }
                sw.Write("\n");
                q++;
            }

        }

        bool nextCombObject(int[] Razm, int k, int n)
        {
            int j = k - 1;
            while (j >= 0 && Razm[j] == n - 1) j--;
            if (j == -1) return false;
            Razm[j]++;
            for (int i = j + 1; i < k; i++)
                Razm[i] = 0;
            return true;
        }
    }
}
