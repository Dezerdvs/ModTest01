using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ModTest01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (double.TryParse(textBox1.Text, out double baseLength) && double.TryParse(textBox2.Text, out double height) && double.TryParse(textBox3.Text, out double side))
            {
                // Створюємо об'єкт класу Parallelogram з введеними параметрами
                Parallelogram parallelogram = new Parallelogram { Base = baseLength, Height = height };

                // Розраховуємо площу та периметр
                double area = parallelogram.CalculateArea();
                double perimeter = parallelogram.CalculatePerimeter();

                // Виводимо результати на форму
                label4.Text = "Площа: " + area.ToString();
                label8.Text = "Периметр: " + perimeter.ToString();
            }
            else
            {
                // Виводимо повідомлення про помилку, якщо введені значення некоректні
                MessageBox.Show("Будь ласка, введіть коректні числові значення для бази та висоти паралелограма.");
            }

        }
        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Отримуємо значення довжини однієї з діагоналей та кута ромба з текстових полів
            if (double.TryParse(textBox6.Text, out double diagonal1) && double.TryParse(textBox2.Text, out double diagonal2))
            {
           
                // Створюємо об'єкт класу Rhombus з введеними параметрами
                Rhombus rhombus = new Rhombus { Diagonal1 = diagonal1, Diagonal2 = diagonal2 };

                // Розраховуємо площу та периметр
                double area = rhombus.CalculateArea();
                double perimeter = rhombus.CalculatePerimeter();

                // Виводимо результати на форму
                label7.Text = "Площа: " + area.ToString();
                label6.Text = "Периметр: " + perimeter.ToString();
            }
            else
            {
                // Виводимо повідомлення про помилку, якщо введені значення некоректні
                MessageBox.Show("Будь ласка, введіть коректні числові значення для діагоналі та кута ромба.");
            }
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Отримуємо значення довжини сторони квадрата з текстового поля
            if (double.TryParse(textBox7.Text, out double sideLength))
            {
                // Створюємо об'єкт класу Square з введеною довжиною сторони
                Square square = new Square { Side = sideLength };

                // Розраховуємо площу та периметр
                double area = square.CalculateArea();
                double perimeter = square.CalculatePerimeter();

                // Виводимо результати на форму
                label13.Text = "Площа: " + area.ToString();
                label9.Text = "Периметр: " + perimeter.ToString();
            }
            else
            {
                // Виводимо повідомлення про помилку, якщо введене значення некоректне
                MessageBox.Show("Будь ласка, введіть коректне числове значення для довжини сторони квадрата.");
            }
        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            // Отримуємо значення довжини та ширини прямокутника з текстових полів
            if (double.TryParse(textBox4.Text, out double height) && double.TryParse(textBox8.Text, out double width))
            {
                // Створюємо об'єкт класу Rectangle з введеними параметрами
                Rectangle rectangle = new Rectangle { Height = height, Width = width };

                // Розраховуємо площу та периметр
                double area = rectangle.CalculateArea();
                double perimeter = rectangle.CalculatePerimeter();

                // Виводимо результати на форму
                label17.Text = "Площа: " + area.ToString();
                label14.Text = "Периметр: " + perimeter.ToString();
            }
            else
            {
                // Виводимо повідомлення про помилку, якщо введені значення некоректні
                MessageBox.Show("Будь ласка, введіть коректні числові значення для довжини та ширини прямокутника.");
            }
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged_2(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click_1(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            // Отримуємо значення довжини першої основи, другої основи та висоти трапеції з текстових полів
            if (double.TryParse(textBox11.Text, out double base1) &&
                double.TryParse(textBox10.Text, out double base2) &&
                double.TryParse(textBox9.Text, out double height))
            {
                // Створюємо об'єкт класу Trapezoid з введеними параметрами
                Trapezoid trapezoid = new Trapezoid { Base1 = base1, Base2 = base2, Height = height };

                // Розраховуємо площу та периметр
                double area = trapezoid.CalculateArea();
                double perimeter = trapezoid.CalculatePerimeter();

                // Виводимо результати на форму
                label24.Text = "Площа: " + area.ToString();
                label23.Text = "Периметр: " + perimeter.ToString();
            }
            else
            {
                // Виводимо повідомлення про помилку, якщо введені значення некоректні
                MessageBox.Show("Будь ласка, введіть коректні числові значення для довжини основ та висоти трапеції.");
            }

        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void label24_Click(object sender, EventArgs e)
        {

        }

        private void label23_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            // Отримуємо значення радіуса та висоти циліндра з текстових полів
            if (double.TryParse(textBox13.Text, out double radius) && double.TryParse(textBox12.Text, out double height))
            {
                // Створюємо об'єкт класу Cylinder з введеними параметрами
                Cylinder cylinder = new Cylinder { Radius = radius, Height = height };

                // Розраховуємо площу та об'єм циліндра
                double surfaceArea = cylinder.CalculateArea();
                double volume = cylinder.CalculateVolume();

                // Виводимо результати на форму
                label30.Text = "Площа: " + surfaceArea.ToString();
                label29.Text = "Об'єм: " + volume.ToString();
            }
            else
            {
                // Виводимо повідомлення про помилку, якщо введені значення некоректні
                MessageBox.Show("Будь ласка, введіть коректні числові значення для радіуса та висоти циліндра.");
            }
        }

        private void textBox13_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {

        }

        private void label30_Click(object sender, EventArgs e)
        {

        }

        private void label29_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            // Отримуємо значення радіусу та висоти конуса з текстових полів
            if (double.TryParse(textBox15.Text, out double radius) && double.TryParse(textBox14.Text, out double height))
            {
                // Створюємо об'єкт класу Cone з введеними параметрами
                Cone cone = new Cone { Radius = radius, Height = height };

                // Розраховуємо площу та об'єм конуса
                double surfaceArea = cone.CalculateArea();
                double volume = cone.CalculateVolume();

                // Виводимо результати на форму
                label35.Text = "Площа: " + surfaceArea.ToString();
                label34.Text = "Об'єм: " + volume.ToString();
            }
            else
            {
                // Виводимо повідомлення про помилку, якщо введені значення некоректні
                MessageBox.Show("Будь ласка, введіть коректні числові значення для радіусу та висоти конуса.");
            }
        }

        private void textBox15_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox14_TextChanged(object sender, EventArgs e)
        {

        }

        private void label35_Click(object sender, EventArgs e)
        {

        }

        private void label34_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            // Отримуємо значення великого і малого радіусів торуса з текстових полів
            if (double.TryParse(textBox17.Text, out double majorRadius) &&
                double.TryParse(textBox16.Text, out double minorRadius))
            {
                // Створюємо об'єкт класу Torus з введеними параметрами
                Torus torus = new Torus { MajorRadius = majorRadius, MinorRadius = minorRadius };

                // Розраховуємо площу та об'єм торуса
                double surfaceArea = torus.CalculateArea();
                double volume = torus.CalculateVolume();

                // Виводимо результати на форму
                label40.Text = "Площа: " + surfaceArea.ToString();
                label39.Text = "Об'єм: " + volume.ToString();
            }
            else
            {
                // Виводимо повідомлення про помилку, якщо введені значення некоректні
                MessageBox.Show("Будь ласка, введіть коректні числові значення для великого та малого радіусів торуса.");
            }
        }

        private void textBox17_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox16_TextChanged(object sender, EventArgs e)
        {

        }

        private void label40_Click(object sender, EventArgs e)
        {

        }

        private void label39_Click(object sender, EventArgs e)
        {

        }
    }
}
