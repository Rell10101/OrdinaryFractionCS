/// разработчик: Самаев Антон ИВТ-21
/// класс обыкновенная дробь
/// можно производить сложение, вычитание, умножение и деление с двумя дробями
/// можно переводить обыкновенную дробь в десятичную

using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;

namespace OrdinaryFraction
{
    public class OrdinaryFractionCS
    {
        // a - числитель, b - знаменатель
        private int a, b;

        // конструктор по умолчанию
        public OrdinaryFractionCS()
        {
            a = 0;
            b = 1;
        }

        // конструктор с параметрами
        // a1 - числитель, b1 - знаменатель
        public OrdinaryFractionCS(int a1, int b1)
        {
            a = a1;
            set_b(b1);
        }

        // геттер для числителя
        public int get_a()
        {
            return a;
        }

        // геттер для знаменателя
        public int get_b()
        {
            return b;
        }

        // сеттер для числителя
        public void set_a(int a1)
        {
            a = a1;
        }

        // сеттер для знаменателя с проверкой входных данных
        public void set_b(int b1)
        {
            if (b1 <= 0) throw new ArgumentException("denominator <= 0");
            b = b1;
        }

        // приведение дробей к общему знаменателю

        // При передаче объекта в параметр по значению, внутри метода
        // создаётся копия ссылки на объект, а не новый объект
        public void common_denominator(OrdinaryFractionCS f2)
        {
            if ((this.b == 0) || (f2.b == 0)) throw new ArgumentException("denominator <= 0");

            int b1 = this.b;

            this.a *= f2.b;
            this.b *= f2.b;

            f2.a *= b1;
            f2.b *= b1;
        }

        // сумма двух дробей
        public OrdinaryFractionCS sum(OrdinaryFractionCS f2)
        {
            OrdinaryFractionCS f3 = new OrdinaryFractionCS();
            if (this.b != f2.b) this.common_denominator(f2);

            int aa = this.a;

            aa += f2.a;

            f3.a = aa;
            f3.b = this.b;

            return f3;
        }

        // разница двух дробей
        public OrdinaryFractionCS diff(OrdinaryFractionCS f2)
        {
            OrdinaryFractionCS f3 = new OrdinaryFractionCS();
            if (this.b != f2.b) this.common_denominator(f2);
            f3.a = this.a - f2.a;
            f3.b = this.b;

            return f3;
        }

        // перемножение двух дробей
        public OrdinaryFractionCS mult(OrdinaryFractionCS f2)
        {
            OrdinaryFractionCS f3 = new OrdinaryFractionCS();
            f3.a = this.a * f2.a;
            f3.b = this.b * f2.b;

            return f3;
        }

        // деление двух дробей
        public OrdinaryFractionCS division(OrdinaryFractionCS f2)
        {
            OrdinaryFractionCS f3 = new OrdinaryFractionCS();
            f3.a = this.a * f2.b;
            f3.b = this.b * f2.a;

            return f3;
        }

        // перевод обыкновенной дроби в десятичную
        public float decimal_fraction()
        {
            float af = this.a;
            float bf = this.b;

            return af / bf;
        }

        // перевод значений дроби в строку
        public string to_string()
        {
            return "Numerator: " + Convert.ToString(this.a) +
                "\ndenominator: " + Convert.ToString(this.b);
        }
    }
}
