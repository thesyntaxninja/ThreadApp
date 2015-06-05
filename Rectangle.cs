using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ThreadApp1
{   // Rectangle or square shape specifics
    public class Rectangle : Shapes
    {
        public Rectangle(int xVal, int yVal, int width, int height, Color color, Form1 frm1, int speed)
        { this.xVal = xVal; this.yVal = yVal; this.color = color; this.width = width; this.height = height; this.frm1 = frm1; this.speed = speed; }

        public override void paint(Graphics g)
        {
            try
            {
                Thread.Sleep(100 / speed); // speed of shape movement
                Thread t = Thread.CurrentThread;

                lock (typeof(Thread))
                {
                    g.DrawRectangle(new System.Drawing.Pen(frm1.BackColor), xVal, yVal, width, height);
                    xVal = xVal + base.directionX;
                    yVal = yVal + base.directionY;
                    base.CheckCoordinates();

                    // draw and fill rectangle
                    SolidBrush b = new SolidBrush(color);
                    g.DrawRectangle(new System.Drawing.Pen(color), xVal, yVal, width, height);
                    g.FillRectangle(b, xVal, yVal, width, height);
                    b.Dispose();
                }
                
            }
            catch (Exception e)
            {
                Trace.WriteLine(e.ToString());
            }

        }
    }
}
