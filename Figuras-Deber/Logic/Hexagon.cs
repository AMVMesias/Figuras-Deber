using System;
using System.Drawing;
using System.Windows.Forms;

namespace Figuras_Deber.Logic
{
    internal class Hexagon
    {
        private float mSide;
        private float mPerimeter;
        private float mArea;
        private Graphics mgraphics;
        private Pen mpen;
        private const float SF = 10f;

        public Hexagon()
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
            mPerimeter = 6 * mSide;
        }

        public void CalculateArea()
        {
            mArea = (float)((3 * Math.Sqrt(3) / 2) * mSide * mSide);
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
            mpen = new Pen(Color.MediumPurple, 2);

            float scaledSide = mSide * SF;
            float radius = scaledSide;

            float centerX = picCanvas.Width / 2;
            float centerY = picCanvas.Height / 2;

            PointF[] points = new PointF[6];

            for (int i = 0; i < 6; i++)
            {
                // Eliminamos el desfase de Math.PI / 6 para tener un vértice arriba
                double angle = i * 2 * Math.PI / 6;
                points[i] = new PointF(
                    centerX + radius * (float)Math.Cos(angle),
                    centerY + radius * (float)Math.Sin(angle)
                );
            }

            mgraphics.DrawPolygon(mpen, points);

            // Dibujar línea de apotema hacia un vértice
            Pen dashPen = new Pen(Color.Gray, 1);
            dashPen.DashStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            float apothem = radius * (float)Math.Cos(Math.PI / 6);
            mgraphics.DrawLine(dashPen, centerX, centerY, centerX, centerY - apothem);
        }

        public void CloseForm(Form form)
        {
            form.Close();
        }
    }
}
