using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ThreadApp1
{ // Circle shape specifics
    public class Circle : Shapes
    {
        public Circle(int xVal, int yVal, int width, int height, Color color, Form1 frm1, int speed)
        { this.xVal = xVal; this.yVal = yVal; this.color = color; this.width = width; this.height = height; this.frm1 = frm1; this.speed = speed; }


        public override void paint(Graphics g)
        {
            try
            {
                Thread.Sleep(100 / speed); // speed of shape
                Thread t = Thread.CurrentThread;

                lock (typeof(Thread))
                {
                    g.DrawEllipse(new System.Drawing.Pen(frm1.BackColor), xVal, yVal, width, height);
                    xVal = xVal + base.directionX;
                    yVal = yVal + base.directionY;
                    base.CheckCoordinates();
                    // draw circle
                    g.DrawEllipse(new System.Drawing.Pen(color), xVal, yVal, width, height);
                }
                
            }
            catch (Exception e)
            {
                Trace.WriteLine(e.ToString());
            }
        }
    }
}
