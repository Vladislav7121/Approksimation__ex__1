using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace WindowsFormsApp1222
{   
    public partial class Form1 : Form
    {
        List<Point> p;

        public Form1()
        {
            InitializeComponent();
            p = new List<Point>();
            //p.Add(new Point(0, 0));
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            chart1.Series[0].Points.Clear();
            chart1.Series[1].Points.Clear();
            listBox1.Items.Clear();
        }

        private void chart1_MouseClick(object sender, MouseEventArgs e)
        {
            //p.Add(new Point(e.X  , 398 - (e.Y - 23) ));
            listBox1.Items.Add(string.Format("x= {0} ; y= {1}", e.X, e.Y));
            p.Add(new Point((e.X - 70)*1000/355 , (350 - e.Y)*1000/280 ));
            p.Sort(delegate (Point a, Point b) {
                return a.X.CompareTo(b.X);});

            chart1.Series[0].Points.Clear();
            foreach (Point aPoint in p)
            {
                chart1.Series[0].Points.AddXY(aPoint.X, aPoint.Y);
            }


            chart1.Series[1].Points.Clear();
            foreach (Point aPoint in p)
            {
                chart1.Series[1].Points.AddXY(aPoint.X, aPoint.Y);
            }

            



            for (int i = 0; i < chart1.Series[1].Points.Count() - 1; i++ )
            {
                //e.Graphics.DrawLine(SystemPens.Highlight, chart1.Series[1].Points[i], chart1.Series[1].Points[i+1]);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            chart1.Series[2].Points.Clear();
            chart1.Series[3].Points.Clear();

            for (int i = 0; i < 1000; i++)
            {
                chart1.Series[2].Points.AddXY(i, 0);
                chart1.Series[3].Points.AddXY(0, i);

                //e.Graphics.DrawLine(SystemPens.Highlight, chart1.Series[1].Points[i], chart1.Series[1].Points[i+1]);
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
