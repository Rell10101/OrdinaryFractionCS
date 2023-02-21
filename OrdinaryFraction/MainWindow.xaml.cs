/// разработчик: Самаев Антон ИВТ-21
/// класс обыкновенная дробь
/// можно производить сложение, вычитание, умножение и деление с двумя дробями
/// можно переводить обыкновенную дробь в десятичную

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace OrdinaryFraction
{
    public partial class MainWindow : Window
    {
        // объекты для работы с дробями
        // с f1 и f2 производятся вычисления
        // f3 - ответ
        // это поля класса MainWindow
        // любой объект в C# это ссылка
        OrdinaryFractionCS f1, f2, f3;

        public MainWindow()
        {
            InitializeComponent();
            f1 = new OrdinaryFractionCS();
            f2 = new OrdinaryFractionCS();
            f3 = new OrdinaryFractionCS();
        }

        // ввод значения textbox-ов в начальные 2 дроби
        public void set_argumentsf1_f2()
        {
            // проверка на исключительные ситуации
            try
            {  
            f1.set_a(Convert.ToInt32(TextBox_a1.Text));
            f1.set_b(Convert.ToInt32(TextBox_b1.Text));
            f2.set_a(Convert.ToInt32(TextBox_a2.Text));
            f2.set_b(Convert.ToInt32(TextBox_b2.Text));
            }
            catch(ArgumentException er)
            {
                Label_error.Content = er.Message;
            }
        }

        // ввод значения textbox-ов в третью дробь(используется для перевода в десятичную дробь)
        public void set_argumentsf3()
        {
            // проверка на исключительные ситуации
            try
            {
                f3.set_a(Convert.ToInt32(TextBox_answer1.Text));
                f3.set_b(Convert.ToInt32(TextBox_answer2.Text));
            }
            catch(ArgumentException er)
            {
                Label_error.Content = er.Message;
            }
        }

        // вывод ответа из третьей дроби в специальные textbox-ы
        public void set_answer()
        {
            TextBox_answer1.Text = Convert.ToString(f3.get_a());
            TextBox_answer2.Text = Convert.ToString(f3.get_b());
        }

        // обработчик события суммы двух начальных дробей
        private void Button_sum_Click(object sender, RoutedEventArgs e)
        {
            set_argumentsf1_f2();
            f3 = f1.sum(f2);
            set_answer();
        }

        // обработчик события перевода в десятичную дробь
        private void Button_decimal_fraction_Click(object sender, RoutedEventArgs e)
        {
            set_argumentsf3();
            Label_decimal_fraction.Content = f3.decimal_fraction();
        }

        // обработчик события разницы двух начальных дробей
        private void Button_diff_Click(object sender, RoutedEventArgs e)
        {
            set_argumentsf1_f2();
            f3 = f1.diff(f2);
            set_answer();
        }

        // обработчик события умножения двух начальных дробей
        private void Button_mult_Click(object sender, RoutedEventArgs e)
        {
            set_argumentsf1_f2();
            f3 = f1.mult(f2);
            set_answer();
        }

        // обработчик события деления двух начальных дробей
        private void Button_division_Click(object sender, RoutedEventArgs e)
        {
            set_argumentsf1_f2();
            f3 = f1.division(f2);
            set_answer();
        }

        // обработчик события перевода в строку
        private void Button_to_string_Click(object sender, RoutedEventArgs e)
        {
            Label_to_string.Content = f3.to_string();
        }
    }
}
