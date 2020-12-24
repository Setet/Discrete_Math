using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace calculator
{
    public partial class FormTest : Form
    {
        public FormTest()
        {
            InitializeComponent();
            labelNumber.Text = "";
        }
        string writePath = @"Write To File.txt";//путь сохранения
        //
        //Всякое-всякое
        //
        private void buttonClear_Click(object sender, EventArgs e)
        {
            labelNumber.Text = "";
        }//кнопка очистки

        private void buttonClearOneCharacter_Click(object sender, EventArgs e)
        {
            int lenght = labelNumber.Text.Length - 1;
            string text = labelNumber.Text;
            labelNumber.Text = "";
            for (int i = 0; i < lenght; i++)
            {
                labelNumber.Text = labelNumber.Text + text[i];
            }
        }//кнопка очистки последней цифры числа

        private void buttonPoint_Click(object sender, EventArgs e)//кнопка запятой
        {
            if ((labelNumber.Text.IndexOf(",") == -1) && (labelNumber.Text.IndexOf("∞") == -1))
            {
                labelNumber.Text += ",";
            }
        }

        private void buttonClearingTheLog_Click(object sender, EventArgs e)
        {
            Answer.Text = "";
        }//очистка поля ответа

        private void buttonWriteToFile_Click(object sender, EventArgs e)
        {
            StreamWriter sw = new StreamWriter(writePath, false, System.Text.Encoding.Default);
            sw.Write(Answer.Text + "\n");
            sw.Close();
        }//запись в файл

        private void CorrectNumber()
        {
            //если есть знак "бесконечность" - не даёт писать цифры после него
            if (labelNumber.Text.IndexOf("∞") != -1)
            {
                labelNumber.Text = labelNumber.Text.Substring(0, labelNumber.Text.Length - 1);
            }

            //ситуация: слева ноль, а после него НЕ запятая, тогда ноль можно удалить
            if (labelNumber.Text[0] == '0' && (labelNumber.Text.IndexOf(",") != 1))
            {
                labelNumber.Text = labelNumber.Text.Remove(0, 1);
            }
        }//кнопка удаления лишнего ноля впереди числа, если таковой имеется
        //
        //цифорки от 0-9
        //
        private void button0_Click(object sender, EventArgs e)
        {
            labelNumber.Text += "0";

            CorrectNumber();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            labelNumber.Text += "1";

            CorrectNumber();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            labelNumber.Text += "2";

            CorrectNumber();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            labelNumber.Text += "3";

            CorrectNumber();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            labelNumber.Text += "4";

            CorrectNumber();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            labelNumber.Text += "5";

            CorrectNumber();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            labelNumber.Text += "6";

            CorrectNumber();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            labelNumber.Text += "7";

            CorrectNumber();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            labelNumber.Text += "8";

            CorrectNumber();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            labelNumber.Text += "9";

            CorrectNumber();
        }
         //
         //Операции
         //
        private void buttonCalc_Click(object sender, EventArgs e)
        {
            string input;
            string GetExpression()
            {
                Answer.Text += labelNumber.Text;
                input = Convert.ToString(labelNumber);
                string output1 = string.Empty; //Строка для хранения выражения
                Stack<char> operStack = new Stack<char>(); //Стек для хранения операторов

                for (int i = 0; i < input.Length; i++) //Для каждого символа в входной строке
                {
                    //Разделители пропускаем
                    if (IsDelimeter(input[i]))
                        continue; //Переходим к следующему символу

                    //Если символ - цифра, то считывем все число
                    if (Char.IsDigit(input[i])) //Если цифра
                    {
                        //Читаем до разделителя или оператора, что бы получить число
                        while (!IsDelimeter(input[i]) && !IsOperator(input[i]))
                        {
                            output1 += input[i]; //Добаляем каждую цифру числа к нашей строке
                            i++; //Переходим к следующему символу

                            if (i == input.Length) break; //Если символ - последний, то выходим из цикла
                        }

                        output1 += " "; //Дописываем после числа пробел в строку с выражением
                        i--; //Возвращаемся на один символ назад, к символу перед разделителем
                    }

                    //Если символ - оператор
                    if (IsOperator(input[i])) //Если оператор
                    {
                        if (input[i] == '(') //Если символ - открывающая скобка
                            operStack.Push(input[i]); //Записываем её в стек
                        else if (input[i] == ')') //Если символ - закрывающая скобка
                        {
                            //Выписываем все операторы до открывающей скобки в строку
                            char s = operStack.Pop();

                            while (s != '(')
                            {
                                output1 += s.ToString() + ' ';
                                s = operStack.Pop();
                            }
                        }
                        else //Если любой другой оператор
                        {
                            if (operStack.Count > 0) //Если в стеке есть элементы
                                if (GetPriority(input[i]) <= GetPriority(operStack.Peek())) //И если приоретет нашего оператора меньше или равен приоретету оператора на вершине стека
                                    output1 += operStack.Pop().ToString() + " "; //То добавляем последний оператор из стека в строку с выражением

                            operStack.Push(char.Parse(input[i].ToString())); //Если стек пуст, или же приоретет оператора выше - добавляем оператов на вершину стека

                        }
                    }
                }

                //Когда прошли по всем символам, выкидываем из стека все оставшиеся там операторы в строку
                while (operStack.Count > 0)
                    output1 += operStack.Pop() + " ";

                labelNumber.Text = output1;
                return output1; //Возвращаем выражение в постфиксной записи
            }//Преобразовываем выражение в постфиксную запись

            double Counting()
            {
                input = Convert.ToString(labelNumber);
                double result1 = 0; //Результат
                Stack<double> temp = new Stack<double>(); //Временный стек для решения


                for (int i = 0; i < input.Length; i++) //Для каждого символа в строке
                {
                    //Если символ - цифра, то читаем все число и записываем на вершину стека
                    if (Char.IsDigit(input[i]))
                    {
                        string a = string.Empty;

                        while (!IsDelimeter(input[i]) && !IsOperator(input[i])) //Пока не разделитель
                        {
                            a += input[i]; //Добаляем
                            i++;
                            if (i == input.Length) break;
                        }
                        temp.Push(double.Parse(a)); //Записываем в стек
                        i--;
                    }
                    else if (IsOperator(input[i])) //Если символ - оператор
                    {
                        double a = temp.Pop(); //Берем 2 последних значения из стека
                        double b = temp.Pop();
                        switch (input[i]) //И производим над ними действие, согласно оператору
                        {
                            case '+': result1 = b + a; break;
                            case '-': result1 = b - a; break;
                            case '*': result1 = b * a; break;
                            case '/': result1 = b / a; break;
                            case '^': result1 = double.Parse(Math.Pow(double.Parse(b.ToString()), double.Parse(a.ToString())).ToString()); break;
                        }
                        temp.Push(result1); //Результат вычисления записываем обратно в стек
                    }
                }
                Answer.Text += Convert.ToString("=" + result1 + "\n");
                return temp.Peek(); //Забираем результат всех вычислений из стека и возвращаем его
            }//Решаем полученное выражение

            int GetPriority(char s)
            {
                switch (s)
                {
                    case '(': return 0;
                    case ')': return 1;
                    case '+': return 2;
                    case '-': return 3;
                    case '*': return 4;
                    case '/': return 4;
                    case '^': return 5;
                    default: return 6;
                }
            }//Метод возвращает приоритет оператора

            bool IsOperator(char с)
            {
                if (("+-/*^()".IndexOf(с) != -1))
                {
                    return true;
                }
                return false;
            }//Метод возвращает true, если проверяемый символ - разделитель ("пробел" или "равно")

            bool IsDelimeter(char c)
            {
                if ((" =".IndexOf(c) != -1))
                {
                    return true;
                }
                return false;
            }//Метод возвращает true, если проверяемый символ - разделитель ("пробел" или "равно")

            GetExpression();
            Counting();
            labelNumber.Text = "";
        }//кнопка равно

        private void buttonBracketOpen_Click(object sender, EventArgs e)
        {
            labelNumber.Text += "(";
        }//кнопка открыть скобки

        private void buttonBracketClose_Click(object sender, EventArgs e)
        {
            labelNumber.Text += ")";
        }//кнопка закрыть скобки

        private void buttonMult_Click(object sender, EventArgs e)
        {
            labelNumber.Text += "*";
        }//кнопка умножение

        private void buttonDiv_Click(object sender, EventArgs e)
        {
            labelNumber.Text += "/";
        }//кнопка деление

        private void buttonPlus_Click(object sender, EventArgs e)
        {
            labelNumber.Text += "+";
        }//кнопка сложение

        private void buttonMinus_Click(object sender, EventArgs e)
        {
                labelNumber.Text += "-";
        }//кнопка вычитание

        private void buttonDegreeY_Click(object sender, EventArgs e)
        {
            labelNumber.Text += "^";
        }//кнопка возведение в произвольную степень
        //
        //Сочетание и т.д
        //
        private void buttonCombination_Click(object sender, EventArgs e)
        {
            С newForm = new С();
            newForm.Owner = this;
            newForm.Show();

        }//кнопка сочетания

        private void buttonPermutation_Click(object sender, EventArgs e)
        {
            P newForm = new P();
            newForm.Owner = this;
            newForm.Show();
        }//кнопка перестановки

        private void buttonAccommodation_Click(object sender, EventArgs e)
        {
            A newForm = new A();
            newForm.Owner = this;
            newForm.Show();
        }//кнопка размещения

        private void buttonCombinationWithRepetitions_Click(object sender, EventArgs e)
        {
            C_Reiteration newForm = new C_Reiteration();
            newForm.Owner = this;
            newForm.Show();
        }//кнопка сочетаний с повторениями

        private void buttonPermutationWithRepetitions_Click(object sender, EventArgs e)
        {
            P_Reiteration newForm = new P_Reiteration();
            newForm.Owner = this;
            newForm.Show();
        }//кнопка перестановок с повторениями

        private void buttonRepetitionPlacement_Click(object sender, EventArgs e)
        {
            A_Reiteration newForm = new A_Reiteration();
            newForm.Owner = this;
            newForm.Show();
        }//кнопка размещений с повторениями

        private void Answer_TextChanged(object sender, EventArgs e)
        {
            Answer.SelectionStart = Answer.Text.Length;
            Answer.ScrollToCaret();
        }//авто скролл
    }
}