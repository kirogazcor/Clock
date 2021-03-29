using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Clock
{
    abstract class Arrow
    {
        Point begin = new Point(141, 104);  //Координаты начала стрелки
        protected Point end;                //Координаты конца стрелки
        protected Pen p;                    // Стиль пера для рисования
        protected int w;                    // Толщина пера
        // Конструктор базового класса отображения стрелки
        public Arrow(Color col)
        {
            w = 1;
            p = new Pen(col, w);
       
        }
        // Метод рисования стрелки
        public void Show(Graphics graphics)
        {
             graphics.DrawLine(p, begin,end);
        }
        protected abstract Point SetEnd(DateTime Dt);
       
    }
    class SecondArrow:Arrow
    {
        // Конструктор для класса секундной стрелки
        public SecondArrow(Color col, DateTime dt): base(col)
        {
            this.end = SetEnd(dt);
        }
        // Метод определения координат конца секундной стрелки
        protected override Point SetEnd(DateTime Dt)
        {
            DateTime DT = Dt;
            Point End;
            End = new Point(141 + (int)(90 * Math.Sin(Math.PI / 30 * DT.Second)), 104 - (int)(90 * Math.Cos(Math.PI / 30 * DT.Second)));
            return End;
        }
       
    }
    class MinuteArrow : Arrow
    {
        // Конструктор для класса минутной стрелки
        public MinuteArrow(Color col, DateTime dt) : base(col)
        {
            w = 2;
            p = new Pen(col, w);
            this.end = SetEnd(dt);
        }
        // Метод определения координат конца минутной стрелки
        protected override Point SetEnd(DateTime Dt)
        {
            DateTime DT = Dt;
            Point End;
            End = new Point(141 + (int)(80 * Math.Sin(Math.PI / 30 * (DT.Minute+ (float)DT.Second/60))), 104 - (int)(80 * Math.Cos(Math.PI / 30 * (DT.Minute + (float)DT.Second / 60))));
            return End;
        }
       
    }
    class HourArrow : Arrow
    {
        // Конструктор для класса часовой стрелки
        public HourArrow(Color col, DateTime dt) : base(col)
        {
            w = 4;
            p = new Pen(col, w);
            this.end = SetEnd(dt);
        }
        // Метод определения координат конца часовой стрелки
        protected override Point SetEnd(DateTime Dt)
        {
            DateTime DT = Dt;
            Point End;
            int Hour;
            if (DT.Hour < 12) Hour = DT.Hour;
            else Hour = DT.Hour - 12;
            End = new Point(141 + (int)(60 * Math.Sin(Math.PI / 6 * (Hour + (float)DT.Minute / 60))), 104 - (int)(60 * Math.Cos(Math.PI / 6 * (Hour + (float)DT.Minute / 60))));
            return End;
        }

    }
}
