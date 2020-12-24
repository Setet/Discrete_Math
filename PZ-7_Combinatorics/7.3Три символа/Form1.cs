using System;
using System.Collections.Generic;
using System.Diagnostics; // для таймера
using System.IO;
using System.Windows.Forms;

namespace PZ_7_7_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string writePath = @"Out.txt";

        private void buttonAnswer_Click(object sender, EventArgs e)
        {
            int k = 6, c = 3, n = 8;// k - длина слова,c - количество повторов
            int[] A = new int[8] { 1, 2, 3, 4, 5, 6, 7, 8 }; // Алфавит

            if (k > 0 && k >= c && c > 0)
            {
                Stopwatch stopWatch = new Stopwatch();
                stopWatch.Start();

                StreamWriter sw = new StreamWriter(writePath, false, System.Text.Encoding.Default);
                recfan2(A, n, k, c, sw);//Основная функция
                sw.Close();

                stopWatch.Stop();
                TimeSpan ts = stopWatch.Elapsed;
                string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}", ts.Hours, ts.Minutes, ts.Seconds, ts.Milliseconds);
                RichTextBox.Text = elapsedTime;
            }
            else
            {
                RichTextBox.Text = "Ошибка";
            }
        }

        void recfan2(int[] A, int n, int k, int c, StreamWriter sw)
        {
            List<int> Word = new List<int>();//Список для конечного слова

            int[] Razm1 = new int[c];//Массив с индексами мест, где повторяется "2" 
            for (int i = 0; i < c; i++)
            {
                Razm1[i] = i;
            }

            int[] Razm2 = new int[k - c];//Массив для размещения с повторением всех слов, где не повторяется "2"
            for (int i = 0; i < k - c; i++)
            {
                Razm2[i] = 0;
            }

            Result(Word, Razm1, Razm2, A, sw);//Сборка и вывод в файл

            while (RepetitionPlacement(Razm2, k - c, n))// Т.к. функции начинают со второй последовательности,а не с первой, приходиться прописывать этот вариант отдельно
            {
                Result(Word, Razm1, Razm2, A, sw);
            }

            for (int i = 0; i < k - c; i++)//После каждого окончания вызова массив с размещениями приходиться обнулять,т.к. при повторном вызове функции он сразу упрется в ...888 и закончит свое выполнение
            {                            
                Razm2[i] = 0;
            }
            sw.WriteLine("\n");

            while (CombObject(Razm1, c, k))//Сначала при помощи сочетания определим, где будут стоять "2"
            {

                Result(Word, Razm1, Razm2, A, sw);

                while (RepetitionPlacement(Razm2, k - c, n))//Далее при помощи размещения с повторением определим,что будет стоять на остальных места
                {
                    Result(Word, Razm1, Razm2, A, sw);//Сборка и вывод
                }

                for (int i = 0; i < k - c; i++)//Обнуление
                {
                    Razm2[i] = 0;
                }
                sw.WriteLine("\n");
            }
        }

        bool CombObject(int[] Razm, int k, int n)//Сочетание из k по n
        {                                        //Изначально заполнили массив 123...
            for (int i = k - 1; i >= 0; i--)//i-ый элемент пробегает значения от k-1 до 0
                if (Razm[i] < n - k + i) //Если элемент можно увеличить
                {
                    Razm[i]++;//увеличиваем его
                    for (int j = i + 1; j < k; j++)//При изменении i элементы правее i тоже увеличиваем
                        Razm[j] = Razm[j - 1] + 1;
                    return true;
                }
            return false;
        }

        bool RepetitionPlacement(int[] Razm, int k, int n)
        {
            int j = k - 1;
            while (j >= 0 && Razm[j] == n - 1) j--;
            if (j == -1) return false;
            Razm[j]++;

            if (Razm[j] == 1) RepetitionPlacement(Razm, k, n);

            for (int i = j + 1; i < k; i++)
                Razm[i] = 0;
            return true;
        }

        void Result(List<int> Word, int[] Razm1, int[] Razm2, int[] A, StreamWriter sw)
        {
            foreach (int item in Razm2)//Сначала расставляем все размещения
                Word.Add(item);
            foreach (int item in Razm1)//Далее подставляем в нужные места повторы
                Word.Insert(item, 1);
            foreach (int item in Word)//Печатаем в файл
                sw.Write(A[item]);
            sw.Write("\n");
            Word.Clear();//Очистка, чтобы не было наложения
        }
    }
}
