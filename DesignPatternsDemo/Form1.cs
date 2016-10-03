using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace CoolTekenDing
{
    public partial class Form1 : Form
    {
        List<object> shapes = new List<object>();
        LegacyRectangle legacyMethod;
        Shape DrawingMethod;

        public Form1()
        {
            InitializeComponent();
        }

        private void OldCubeRbutton_CheckedChanged(object sender, EventArgs e)
        {
            if (OldCubeRbutton.Checked == true)
            {
                if (adapterTrackBar.Value == 0)
                {
                    DrawingMethod = new LegacyRectangleAdapter();
                }
                else
                {
                    legacyMethod = new LegacyRectangle();
                }
            }
        }

        private void CubeRbutton_CheckedChanged(object sender, EventArgs e)
        {
            if (CubeRbutton.Checked == true)
            {
                DrawingMethod = new drawRectangle();
            }
        }

        private void panel1_MouseClick(object sender, MouseEventArgs e)
        {
            object shape;
            if (adapterTrackBar.Value == 1 && OldCubeRbutton.Checked)
            {
                shape = legacyMethod.drawRectangle(e.X, e.Y, Convert.ToInt32(widthSelector.Value), Convert.ToInt32(heightSelector.Value));
            }
            else
            {
                shape = DrawingMethod.draw(e.X, e.Y, Convert.ToInt32(widthSelector.Value), Convert.ToInt32(heightSelector.Value));
            }
            shapes.Add(shape);

            panel1.Refresh();
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            SolidBrush brush = new SolidBrush(Color.Black);

            foreach (Rectangle shape in shapes)
            {
                e.Graphics.FillRectangle(brush, shape);
            }
        }

        private void adapterTrackBar_ValueChanged(object sender, EventArgs e)
        {
            OldCubeRbutton_CheckedChanged(sender, e);
        }
    }
}
