using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clock
{
    public partial class Form1 : Form
    {
        AnalogClock A;  //Аналоговые часы
        DigitClock D;   //цифровые часы
        Color Col, Col1;    //Цвет стрелок и цифр
        public Form1()
        {
            InitializeComponent();
            pictureBox1.BackColor = Color.Transparent;  // Прозрачный фон области для рисования
            Col = Col1 = Color.Black;
        }

        // Обработка щелчка мыши по пункту меню Тип часов->Аналоговые
        private void аналоговыеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            аналоговыеToolStripMenuItem.Checked = true;      // Исменение отметок
            цифровыеToolStripMenuItem.Checked = false;       // и активности
            стрелкиToolStripMenuItem.Enabled = true;         // соответствующих
            циферблатToolStripMenuItem.Enabled = true;       // пунктов меню
            toolStripMenuItem1.Enabled = false;
            шрифтToolStripMenuItem.Enabled = false;
            датаToolStripMenuItem.Enabled = false;
            label1.Visible = false;     // Задание невидимости полям отображения времени и даты
            label2.Visible = false;
            pictureBox1.Visible = true; // Задание видимости области для рисования
            Height =Width= 300;
            // Вывод выбранного фонового рисунка формы
            if (всеЦифрыToolStripMenuItem.Checked) BackgroundImage = Clock.Properties.Resources.clock_A1;
            if (всеЦифрыToolStripMenuItem1.Checked) BackgroundImage = Clock.Properties.Resources.clock_R1;
            if (toolStripMenuItem3.Checked) BackgroundImage = Clock.Properties.Resources.clock_A3;
            if (iIIVIIXXIIToolStripMenuItem.Checked) BackgroundImage = Clock.Properties.Resources.clock_R3;
            if (безЦифрToolStripMenuItem.Checked) BackgroundImage = Clock.Properties.Resources.clock_N;
        }
        // Обработка щелчка мыши по пункту меню Тип часов->Цифровые
        private void цифровыеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            аналоговыеToolStripMenuItem.Checked = false;    // Исменение отметок
            цифровыеToolStripMenuItem.Checked = true;       // и активности
            стрелкиToolStripMenuItem.Enabled = false;       // соответствующих
            циферблатToolStripMenuItem.Enabled = false;     // пунктов меню
            toolStripMenuItem1.Enabled = true;
            шрифтToolStripMenuItem.Enabled = true;
            датаToolStripMenuItem.Enabled = true;
            pictureBox1.Visible = false;    // Задание невидимости области для рисования
            label1.Visible = true;          // Задание видимости полю отображения времени
            BackgroundImage = null; // Стирание фонового рисунка (циферблата)
        }
        // Обработка такта таймера
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (аналоговыеToolStripMenuItem.Checked)
            {
                A = new AnalogClock(секундыToolStripMenuItem.Checked, Col); //Инициализация аналоговых часов
                pictureBox1.Refresh();                                      //Очистка поля для рисования
                A.ShowTime(pictureBox1.CreateGraphics());                   //Отрисовка стрелок на поле для рисования
            }
            else
            {
                D = new DigitClock(датаToolStripMenuItem.Checked);          // Инициализация цифровых часов
                D.ShowTime(pictureBox1.CreateGraphics());
                label1.ForeColor = label2.ForeColor = Col1;
                label1.Text = D.Time;   // Вывод времени
                if (датаToolStripMenuItem.Checked)                
                {
                    int width = label2.Width;
                    label2.Visible = true;
                    label2.Text = D.Date;   // Вывод даты
                    // Настройка размеров формы и положение надписей
                    Height = 110 + 2 * label1.Height;
                    if (width <= 200)
                    {
                        Width = 250;
                        label2.Location = new Point((int)((Width - width) / 2) - 5, 60 + label1.Height);
                        width = label1.Width;
                        label1.Location = new Point((int)((Width - width) / 2) - 5, 40);
                    }
                    else
                    {
                        Width = width + 50;
                        label2.Location = new Point((int)((Width - width) / 2) - 5, 60 + label1.Height);
                        width = label1.Width;
                        label1.Location = new Point((int)((Width - width) / 2) - 5, 40);
                    }
                }
                else
                {
                    // Настройка размеров формы и положение надписей
                    int width = label1.Width;
                    if (width <= 200)
                    {
                        Width = 250;
                        label1.Location = new Point((int)((Width - width) / 2) - 5, 40);
                    }
                    else
                    {
                        Width = width + 50;
                        label1.Location = new Point((int)((Width - width) / 2) - 5, 40);
                    }
                    Height = 90 + label1.Height;
                }
            }
        }
        // Обработка щелчка мыши по пункту меню Изображение->Циферблат->Арабские->Все цифры
        private void всеЦифрыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            всеЦифрыToolStripMenuItem.Checked = true;       // Исменение отметок
            всеЦифрыToolStripMenuItem1.Checked = false;     // соответствующих
            toolStripMenuItem3.Checked = false;             // пунктов меню
            iIIVIIXXIIToolStripMenuItem.Checked = false;
            безЦифрToolStripMenuItem.Checked = false;
            // Вывод выбранного фонового рисунка формы
            BackgroundImage = Clock.Properties.Resources.clock_A1;
        }
        // Обработка щелчка мыши по пункту меню Изображение->Циферблат->Римские->Все цифры
        private void всеЦифрыToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            всеЦифрыToolStripMenuItem.Checked = false;       // Исменение отметок
            всеЦифрыToolStripMenuItem1.Checked = true;       // соответствующих
            toolStripMenuItem3.Checked = false;              // пунктов меню
            iIIVIIXXIIToolStripMenuItem.Checked = false;
            безЦифрToolStripMenuItem.Checked = false;
            // Вывод выбранного фонового рисунка формы
            BackgroundImage = Clock.Properties.Resources.clock_R1;
        }
        // Обработка щелчка мыши по пункту меню Изображение->Циферблат->Римские->III, VI, IX, XII
        private void iIIVIIXXIIToolStripMenuItem_Click(object sender, EventArgs e)
        {
            всеЦифрыToolStripMenuItem.Checked = false;       // Исменение отметок
            всеЦифрыToolStripMenuItem1.Checked = false;      // соответствующих
            toolStripMenuItem3.Checked = false;              // пунктов меню
            iIIVIIXXIIToolStripMenuItem.Checked = true;
            безЦифрToolStripMenuItem.Checked = false;
            // Вывод выбранного фонового рисунка формы
            BackgroundImage = Clock.Properties.Resources.clock_R3;
        }
        // Обработка щелчка мыши по пункту меню Изображение->Циферблат->Арабские->3, 6, 9, 12
        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            всеЦифрыToolStripMenuItem.Checked = false;       // Исменение отметок
            всеЦифрыToolStripMenuItem1.Checked = false;      // соответствующих
            toolStripMenuItem3.Checked = true;               // пунктов меню
            iIIVIIXXIIToolStripMenuItem.Checked = false;
            безЦифрToolStripMenuItem.Checked = false;
            // Вывод выбранного фонового рисунка формы
            BackgroundImage = Clock.Properties.Resources.clock_A3;
        }
        // Обработка щелчка мыши по пункту меню Изображение->Циферблат->Без цифр
        private void безЦифрToolStripMenuItem_Click(object sender, EventArgs e)
        {
            всеЦифрыToolStripMenuItem.Checked = false;      // Исменение отметок
            всеЦифрыToolStripMenuItem1.Checked = false;     // соответствующих
            toolStripMenuItem3.Checked = false;             // пунктов меню
            iIIVIIXXIIToolStripMenuItem.Checked = false;
            безЦифрToolStripMenuItem.Checked = true;
            // Вывод выбранного фонового рисунка формы
            BackgroundImage = Clock.Properties.Resources.clock_N;
        }
        // Выбор цвета фона
        private void цветФонаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() != DialogResult.Cancel)
            {
                BackColor = colorDialog1.Color;
            }
        }
        // Выбор цвета стрелок
        private void цветToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() != DialogResult.Cancel)
            {
                Col = colorDialog1.Color;
            }
        }
        // Выбор цвета цифр
        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() != DialogResult.Cancel)
            {
                Col1 = colorDialog1.Color;
            }
        }
        // Выбор шрифта цифр
        private void шрифтToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (fontDialog1.ShowDialog() != DialogResult.Cancel)
            {
                label1.Font=label2.Font = fontDialog1.Font;
            }
        }
        // Выход из приложения
        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }                
    }
}
