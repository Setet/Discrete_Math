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

namespace _3
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        List<string> items = new List<string>() {"a","b","c","d","e","f","g","h","j","k"};//нач алфавит
        List<string> A = new List<string>();//список промежуточной 3 букв(по сути микро алфавит размером 3)
        HashSet<string> B = new HashSet<string>();//список промежуточной 3 букв(по сути микро алфавит размером 3)(почему именно хэшсет-117 строка)

        public const int n = 9;//размер слов
        public const int k = 3;//кол-во нужных нам букв(из базового алфавита)
        public int w = 0;//переменная для счётчика кол-ва слов

        string writePath = @"Answer.txt";//Адрес куда записывать результат

        private void button1_Click(object sender, EventArgs e)
        {
            int[] Razm = new int[k];//массив для нужных нам букв(для микро алфавита)

            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();

            StreamWriter sw = new StreamWriter(writePath, false, System.Text.Encoding.Default);
            sw.Write(RichTextBox1.Text);
            RichTextBox.Text = "";
            recfan1(Razm, k, sw);//основная 2-х составная функция
            sw.Close();

            stopWatch.Stop();
            TimeSpan ts = stopWatch.Elapsed;
            string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}", ts.Hours, ts.Minutes, ts.Seconds, ts.Milliseconds);
            RichTextBox.Text = elapsedTime;
        }

        void recfan1(int[] Razm, int k, StreamWriter sw)//функция нахождения сочетания из алфавида по 3 буквы
        {
            int pi = 10;//кол-во элементов нач.алфавита
            string Da = "";//промежуточный список

            for (int i = 0; i < k; i++)
            {
                Razm[i] = i;
                A.Add(items[i]);//запись первой 3 букв как алвафит(a,b,c)
            }
            recfan2(sw);

            while (CombObject(Razm, k, pi))//Пока есть сочетания, пишем их
            {
                foreach (int item in Razm)
                {
                    Da = items[item];//список букв побуквенно(знаю звучит стрёмно)
                    A.Add(Da);//поэлементная запись в промежуточный список
                }
                recfan2(sw);//функция печати слов размером 9 из 3 букв найденых recfan1 ранее
                Da = "";//очищение списка
            }
            sw.Write("Кол-во слов = " + w);//вывод кол-ва слов
        }

        bool CombObject(int[] Razm, int k,int pi)
        {
            for (int i = k - 1; i >= 0; i--)
            {
                if (Razm[i] < pi - k + i)
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

        void recfan2(StreamWriter sw)
        {
            List<string> Gachi = new List<string>();//список слов для вывода

            int[] Razm1 = new int[n];//массива нужного нам размера для слов

            string Van = "";//промежуточный список слов
            string Bille = "";//промежуточный список слов

            for (int i = 0; i < n; i++)
            {
                Razm1[i] = 0;//заполняем массив нолями
            }

            while (nextCombObject1(Razm1, n, k))
            {
                foreach (int item in Razm1)
                {
                    Van = A[item];//записываем слово в помежуточный список
                    B.Add(Van);//посимвольно добавляем в хешсет
                }
                Van = "";//очистка промежуточного списка хранения слова

                if (B.Count == 3)//если в слове есть 3 буквы из нашего 2-ого алфавита,
                {

                    foreach (int item in Razm1)
                    {
                        Bille += A[item];//записываем слово в помежуточный список
                    }

                    Gachi.Add(Bille);//добавляем в список слов
                    Bille = "";//очещаем промежуточный список слов
                }
                B.Clear();//очещаем промежуточный список
            }

            foreach (string value in Gachi)
            {
                w++;//счётчик порядка слова
                sw.Write(w+": "+value + "\n");//печатаем слово и его номер
            }

            A.Clear();//очистка второго алфавита
        }

        bool nextCombObject1(int[] Razm1, int k, int n)
        {
            int j = k-1;
            while (j >= 0 && Razm1[j] == n - 1) j--;
            if (j == -1) return false;
            Razm1[j]++;
            for (int i = j + 1; i < k; i++)
                Razm1[i] = 0;
            return true;
        }
    }
}
