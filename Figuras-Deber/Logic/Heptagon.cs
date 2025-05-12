using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Figuras_Deber.Logic
{
    internal class Heptagon
    {
        private float mSide;       
        private float mRadius;       
        private float mPerimeter;
        private float mArea;
        private Graphics mGraph;
        private Pen mPen;
        private const float SF = 20;
        private const int NUM_SIDES = 7; 

        public Heptagon()
        {
            mSide = 0.0f;
            mRadius = 0.0f;
            mPerimeter = 0.0f;
            mArea = 0.0f;
        }

        public bool ReadData(TextBox txtSide)
        {
            try
            {
                mSide = float.Parse(txtSide.Text);

                if (mSide <= 0)
                {
                    MessageBox.Show("Error: El lado debe ser positivo.",
                        "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }

                mRadius = mSide / (2 * (float)Math.Sin(Math.PI / NUM_SIDES));
                return true;
            }
            catch
            {
                MessageBox.Show("Error: Datos no válidos...",
                    "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public void CalculatePerimeter()
        {
            mPerimeter = NUM_SIDES * mSide;
        }

        public void CalculateArea()
        {
            mArea = (7 * mSide * mSide) / (4 * (float)Math.Tan(Math.PI / NUM_SIDES));
        }

        public void PrintData(TextBox txtPerimeter, TextBox txtArea)
        {
            txtPerimeter.Text = mPerimeter.ToString("F2");
            txtArea.Text = mArea.ToString("F2");
        }

        public void InitializeData(TextBox txtSide, TextBox txtPerimeter, TextBox txtArea, PictureBox picCanvas)
        {
            mSide = 0.0f;
            mRadius = 0.0f;
            mPerimeter = 0.0f;
            mArea = 0.0f;

            txtSide.Text = "";
            txtPerimeter.Text = "";
            txtArea.Text = "";
            txtSide.Focus();
            picCanvas.Refresh();
        }

        public void PlotShape(PictureBox picCanvas)
        {
            mGraph = picCanvas.CreateGraphics();
            mGraph.Clear(Color.White);
            mPen = new Pen(Color.Purple, 2);

            float centerX = picCanvas.Width / 2;
            float centerY = picCanvas.Height / 2;

            float scaledRadius = Math.Min(picCanvas.Width, picCanvas.Height) * 0.4f;
            if (mRadius > 0)
            {
                scaledRadius = Math.Min(scaledRadius, mRadius * SF);
            }

            PointF[] points = new PointF[NUM_SIDES];

            for (int i = 0; i < NUM_SIDES; i++)
            {
                float angle = ((float)Math.PI / 2) + (2 * (float)Math.PI * i / NUM_SIDES);

                float x = centerX + scaledRadius * (float)Math.Cos(angle);
                float y = centerY - scaledRadius * (float)Math.Sin(angle);

                points[i] = new PointF(x, y);
            }

            mGraph.DrawPolygon(mPen, points);
        }

        public void CloseForm(Form ObjForm)
        {
            ObjForm.Close();
        }
    }
}