using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThreadApp1
{
    public partial class Form1 : Form
    {
        private const int shapeSize = 10;
        private volatile Graphics g;
        public static Color shapeColor = Color.Black; // default to black
        public ColorDialog c;
        public static int threadCount = 0; // default to 0
        CountdownEvent countDown = new CountdownEvent(1); // pause, resume event
        private bool started = false;
        private Hashtable threadHolder = new Hashtable(); // store active threads in hashtable

        public Form1()
        {
            InitializeComponent();
            g = panel1.CreateGraphics();
        }

        private void StartThread()
        {
            //create the shape
            Shapes shapes;
            if (shapeComboBox.Text.Equals("Rectangle"))
                shapes = new Rectangle(0, 0, shapeSize, shapeSize, shapeColor, this, Convert.ToInt32(speedUpDown.Text.Trim()));
            else if (shapeComboBox.Text.Equals("Circle"))
                shapes = new Circle(0, 0, shapeSize, shapeSize, shapeColor, this, Convert.ToInt32(speedUpDown.Text.Trim()));
            else
                shapes = new Rectangle(0, 0, shapeSize, shapeSize, shapeColor, this, Convert.ToInt32(speedUpDown.Text.Trim()));

            while (true)
            {
                try
                {
                    if (started)
                    {
                        shapes.paint(g); 
                    }
                    else
                    {
                        countDown.Wait();
                    }
                    
                }

                catch (Exception e1)
                {
                    Console.WriteLine("Exception Form1 loop >> " + e1);
                    break;
                }
                
            }
            started = true;
            
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // shut down all currently active threads and exit program
            foreach (Thread t in threadHolder.Values)
            {
                if (t != null && t.IsAlive)
                    t.Abort();
            }
            Form1.ActiveForm.Close();	
        }

        private void startButton_Click(object sender, EventArgs e) 
        {
            // start, pause, resume threads

            if (started)
            {
                started = false;
                countDown.Reset(1);
                startButton.Text = "Resume";
                return;
            }

            started = true;
            countDown.Signal();
            startButton.Text = "Pause";
            
        }

        private void colorButton_Click(object sender, EventArgs e) // color dialog for color selection
        {
            c = new ColorDialog();
            c.ShowDialog();
            shapeColor = c.Color;
        }

        private void addShapeButton_Click(object sender, EventArgs e)
        {
            //create shape
            Shapes shapes;
            if (shapeComboBox.Text.Equals("Rectangle"))
                shapes = new Rectangle(0, 0, shapeSize, shapeSize, shapeColor, this, Convert.ToInt32(speedUpDown.Text.Trim()));
            else if (shapeComboBox.Text.Equals("Circle"))
                shapes = new Circle(0, 0, shapeSize, shapeSize, shapeColor, this, Convert.ToInt32(speedUpDown.Text.Trim()));
            else
                shapes = new Rectangle(0, 0, shapeSize, shapeSize, shapeColor, this, Convert.ToInt32(speedUpDown.Text.Trim()));

            shapes.paint(g);
            Thread t = new Thread(new ThreadStart(StartThread));
            threadHolder.Add(threadCount++, t);
            t.Name = "Thread ID: " + threadCount;
            t.IsBackground = true;
            t.Start();
            threadCountLabel.Text = "Thread Count = " + threadHolder.Count; // change thread count to number in threadHolder
           }

        }

    }

