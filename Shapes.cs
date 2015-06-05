using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThreadApp1
{   //abstract class for shapes
    public abstract class Shapes
    {
        protected int xVal;
        protected int yVal;
        protected Color color;
        protected int width;
        protected int height;
        protected int directionY = 1;
        protected int directionX = 1;
        protected Form1 frm1;
        protected int speed;

        public Shapes()
        { }

        public abstract void paint(Graphics g);

        public void CheckCoordinates() // change direction of shape when hits edge of panel
        {
            if ((frm1.panel1.Size.Height - 20 < yVal) || (yVal <= 0))
                directionY = directionY * (-1);

            if ((frm1.panel1.Size.Width - 20 < xVal) || (xVal <= 0))
                directionX = directionX * (-1);
        }
    }
}
