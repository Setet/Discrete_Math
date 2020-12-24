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

namespace IND_4
{
    public partial class Part1 : Form
    {
        public Part1()
        {
            InitializeComponent();
        }
        public int q = 0;//переменная как счётчик разбиений
        string writePath = @"Answer1.txt";//Адрес куда записывать результат первой части

        private void buttonAnswer_Click(object sender, EventArgs e)
        {
            int n = (TextBox1.Text != "") ? Convert.ToInt32(TextBox1.Text) : 0;//считываем значение из textbox-а

            if (n > 0)//если есть число,переходим к телу проги
            {
                int z = n;//микро костыль для красивого вывода в файл(и не только)
                int[] sum = new int[n];//генерим массив равный значению n *из-за самого плохого случая*

                Stopwatch stopWatch = new Stopwatch();
                stopWatch.Start();

                StreamWriter sw = new StreamWriter(writePath, false, System.Text.Encoding.Default);
                RichTextBox1.Text = "";
                print_terms(sw, z, sum, n);//осн.функция
                sw.Write("Кол-во разбиений = " + q);//запись кол-ва разбиений в файл
                sw.Close();

                stopWatch.Stop();
                TimeSpan ts = stopWatch.Elapsed;
                string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}", ts.Hours, ts.Minutes, ts.Seconds, ts.Milliseconds);
                RichTextBox1.Text = elapsedTime;
            }
            else
            {
                MessageBox.Show("Введите значение n!!!");
            }
        }

        void print_terms(StreamWriter sw, int z, int[] sum, int left, int min = 0, int i = 0)
        {
            int k = z;//k-ограничение максимального значения одного слогаемого(о,и костыль пригодился)

            if (left < 0 || min == k)//если left<0 или min==k,то нечего не происходит
            {
                return;
            }

            sum[i] = min;//первый элемент массива равен значению min
            if (min != 0)//если min не равен 0,то вызываем функцию с измн параметрами
            {
                print_terms(sw, z, sum, left-min, min, i + 1);
            }

            print_terms(sw, z, sum, left - 1, min + 1, i);//меняем параметры
            if (left == 0)//если число "раздербанено" то значит разложение готово
            {
                q++;//+1 за каждое разбиение
                for (int j = 0; j <= i; ++j)//цикл для печати
                {
                    sw.Write(sum[j]);//печатаем слогаемое
                    if (j <= i - 1)//i-1 чтобы не печатался один лишний + после слагаемого
                    {
                        sw.Write("+");//запись знака + в файл между слагаемыми
                    }
                }
                sw.Write("=" + z);//запись красоты(с тем самым костылём выше)
                sw.Write("\n");//переход на след строчку в файле
            }
        }

        private void buttonPart2_Click(object sender, EventArgs e)
        {
            Part2 newForm = new Part2();
            newForm.Owner = this;
            newForm.Show();
        }
    }
}
