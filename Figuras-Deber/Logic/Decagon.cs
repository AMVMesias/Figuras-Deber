using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Figuras_Deber.Logic
{
    internal class Decagon
    {
        private float mSide;
        private float mPerimeter;
        private float mArea;
        private Graphics mgraphics;
        private Pen mpen;
        private const float SF = 10f;

        public Decagon()
        {
            mSide = 0.0f;
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
                    MessageBox.Show("Error: El lado debe ser un valor positivo.",
                        "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }

                return true;
            }
            catch
            {
                MessageBox.Show("Error: Datos no válidos...",
                    "Mensaje de error");
                return false;
            }
        }

        public void CalculatePerimeter()
        {
            mPerimeter = 10 * mSide;
        }

        public void CalculateArea()
        {
            // Área de un decágono regular: (5/2) * lado² * cot(π/10)
            double cotPI10 = 1.0 / Math.Tan(Math.PI / 10);
            mArea = (float)(5.0 / 2.0 * mSide * mSide * cotPI10);
        }

        public void PrintData(TextBox txtPerimeter, TextBox txtArea)
        {
            txtPerimeter.Text = mPerimeter.ToString();
            txtArea.Text = mArea.ToString();
        }

        public void InitializeData(TextBox txtSide, TextBox txtPerimeter, TextBox txtArea, PictureBox picCanvas)
        {
            txtSide.Text = "";
            txtPerimeter.Text = "";
            txtArea.Text = "";
            txtSide.Focus();
            picCanvas.Refresh();
        }

        public void PlotShape(PictureBox picCanvas)
        {
            mgraphics = picCanvas.CreateGraphics();
            mgraphics.Clear(picCanvas.BackColor);
            mpen = new Pen(Color.DeepPink, 2);

            float scaledSide = mSide * SF;

            float radius = scaledSide / (2 * (float)Math.Sin(Math.PI / 10));

            float centerX = picCanvas.Width / 2;
            float centerY = picCanvas.Height / 2;

            PointF[] points = new PointF[10];

            for (int i = 0; i < 10; i++)
            {
                double angle = i * 2 * Math.PI / 10;
                points[i] = new PointF(
                    centerX + radius * (float)Math.Cos(angle),
                    centerY + radius * (float)Math.Sin(angle)
                );
            }

            mgraphics.DrawPolygon(mpen, points);

            Pen dashPen = new Pen(Color.Gray, 1);
            dashPen.DashStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            mgraphics.DrawLine(dashPen, centerX, centerY, centerX + radius, centerY);
        }

        public void CloseForm(Form form)
        {
            form.Close();
        }
    }
}