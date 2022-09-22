using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace CW_0_WPF_begin
{
    public partial class Form1 : Form
    {
        private bool ifMdown = false;
        private Point curspos;
        public Form1()
        {
            InitializeComponent();
            GraphicsPath gp = new GraphicsPath();
            Point[] pts = new Point[]
            {
                new Point(200, 16),
                new Point(239, 139),
                new Point(366, 146),
                new Point(264, 216),
                new Point(301, 338),
                new Point(200, 271),
                new Point(100, 340),
                new Point(134, 217),
                new Point(34, 143),
                new Point(160, 137)
            };
            gp.AddLines(pts);
            this.Region = new Region(gp);
        }
        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            ifMdown = true;
            curspos = e.Location;
        }
        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            ifMdown = false;
        }
        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (ifMdown)
                this.Location = new Point(Cursor.Position.X - curspos.X, Cursor.Position.Y - curspos.Y);
        }
    }
}
