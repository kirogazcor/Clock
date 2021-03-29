using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Clock
{
    abstract class Clocks
    {
        public DateTime dt;     // Хранение текущего времени и даты
        public abstract void ShowTime(Graphics graphics);
        // Конструктор базового класса отображения времени
        public Clocks()
        {
            dt = DateTime.Now;  //Присваивание текущего времени и даты
        }
    }
    class AnalogClock:Clocks
    {
        public SecondArrow S;   // Секундная стрелка
        public MinuteArrow M;   // Минутная стрелка 
        public HourArrow H;     // Часовая стрелка
        bool ShowSecond;        // Признак отображения секундной стрелки
        // Конструктор для класса аналоговых часов
        public AnalogClock(bool SecondShow, Color Col):base()
        {
            ShowSecond = SecondShow;
            if (ShowSecond) S = new SecondArrow(Col, dt);
            M = new MinuteArrow(Col, dt);
            H = new HourArrow(Col, dt);            
        }
        // Метод отображения времени в аналоговом виде
        public override void ShowTime(Graphics graphics)
        {
            if (ShowSecond) S.Show(graphics);   // Рисование секундной стрелки
            M.Show(graphics);                   // Рисование минутной стрелки
            H.Show(graphics);                   // Рисование часовой стрелки
        }
    }
    class DigitClock:Clocks
    {
        bool ShowDate;                  // Признак отображения даты
        public string Time, Date;       // Время и дата в виде строк
        // Конструктор для класса цифровых часов
        public DigitClock(bool DateShow) : base()
        {
            ShowDate = DateShow;            
        }
        // Метод отображения времени в цифровом виде
        public override void ShowTime(Graphics graphics)
        {
            Time = dt.ToLongTimeString();
            if (ShowDate)Date = dt.ToShortDateString();            
        }
    }
}
