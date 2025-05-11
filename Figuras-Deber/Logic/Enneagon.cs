using System;
using System.Drawing;
using System.Windows.Forms;

namespace Figuras_Deber.Logic
{
    internal class Enneagon
    {
        private float mSide;
        private float mPerimeter;
        private float mArea;
        private Graphics mgraphics;
        private Pen mpen;
        private const float SF = 10f;

        public Enneagon()
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
            mPerimeter = 9 * mSide;
        }

        public void CalculateArea()
        {
            // Área de un eneágono regular: (9/4) * lado² * cot(π/9)
            double cotPI9 = 1.0 / Math.Tan(Math.PI / 9);
            mArea = (float)(9.0 / 4.0 * mSide * mSide * cotPI9);
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
            mpen = new Pen(Color.Teal, 2);

            float scaledSide = mSide * SF;

            float radius = scaledSide / (2 * (float)Math.Sin(Math.PI / 9));
            float centerX = picCanvas.Width / 2;
            float centerY = picCanvas.Height / 2;

            PointF[] points = new PointF[9];

            for (int i = 0; i < 9; i++)
            {
                // Sin rotación adicional: vértice arriba
                double angle = i * 2 * Math.PI / 9;
                points[i] = new PointF(
                    centerX + radius * (float)Math.Cos(angle),
                    centerY + radius * (float)Math.Sin(angle)
                );
            }

            mgraphics.DrawPolygon(mpen, points);

            // Dibujar línea de apotema hacia arriba
            Pen dashPen = new Pen(Color.Gray, 1);
            dashPen.DashStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            float apothem = radius * (float)Math.Cos(Math.PI / 9);
            mgraphics.DrawLine(dashPen, centerX, centerY, centerX, centerY - apothem);
        }

        public void CloseForm(Form form)
        {
            form.Close();
        }
    }
}
