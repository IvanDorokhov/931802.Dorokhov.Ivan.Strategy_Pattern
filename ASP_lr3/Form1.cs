using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ASP_lr3
{
    public partial class Form1 : Form
    {
        Context context;

        public Form1()
        {
            InitializeComponent();

            context = new Context(new ConcreteStrategy1());
        }

        private void check_Button_Click(object sender, EventArgs e)
        {
            if(number_radioButton.Checked)
                context.SetStrategy(new ConcreteStrategy1());
            else
                if (lower_radioButton.Checked)
                    context.SetStrategy(new ConcreteStrategy2());
                else
                    context.SetStrategy(new ConcreteStrategy3());

            context.ExecuteOperation(input_TextBox.Text);
        }
    }


    public interface IStrategy
    {
        void Algorithm(string s);
    }

    //Первая конкретная реализация-стратегия
    public class ConcreteStrategy1 : IStrategy
    {
        public void Algorithm(string s)
        {
            if (s.Length == 0)
                MessageBox.Show("Строка пуста");
            else
            {
                foreach(char c in s)
                {
                    if (!(c >= '0' && c <= '9'))
                    {
                        MessageBox.Show("Введенная строка - НЕ число!!!");
                        return;
                    }
                }

                MessageBox.Show("Верно");
            }
        }
    }

    //Вторая конкретная реализация-стратегия
    public class ConcreteStrategy2 : IStrategy
    {
        public void Algorithm(string s)
        {
            if (s.Length == 0)
                MessageBox.Show("Строка пуста");
            else
            {
                foreach (char c in s)
                {
                    if (!(c >= 'а' && c <= 'я' || c == 'ё' || c >= 'a' && c <= 'z'))
                    {
                        MessageBox.Show("Введенная строка НЕ в нижнем регистре!!!");
                        return;
                    }
                }

                MessageBox.Show("Верно");
            }
        }
    }

    //Третья конкретная реализация-стратегия
    public class ConcreteStrategy3 : IStrategy
    {
        public void Algorithm(string s)
        {
            if (s.Length == 0)
                MessageBox.Show("Строка пуста");
            else
            {
                foreach (char c in s)
                {
                    if (!(c >= 'А' && c <= 'Я' || c == 'Ё' || c >= 'A' && c <= 'Z'))
                    {
                        MessageBox.Show("Введенная строка НЕ в верхнем регистре!!!");
                        return;
                    }
                }

                MessageBox.Show("Верно");
            }
        }
    }

    public class Context
    {
        private IStrategy _strategy;

        public Context(IStrategy strategy)
        {
            _strategy = strategy;
        }

        public void SetStrategy(IStrategy strategy)
        {
            _strategy = strategy;
        }

        public void ExecuteOperation(string s)
        {
            _strategy.Algorithm(s);
        }
    }


}