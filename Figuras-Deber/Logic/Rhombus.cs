using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Figuras_Deber.Logic
{
    internal class Rhombus
    {
        private float mDiagonalMajor;
        private float mDiagonalMinor;
        private float mPerimeter;
        private float mArea;
        private Graphics mgraphics;
        private Pen mpen;
        private const float SF = 10f;

        public Rhombus()
        {
            mDiagonalMajor = 0.0f;
            mDiagonalMinor = 0.0f;
            mPerimeter = 0.0f;
            mArea = 0.0f;
        }

        public bool ReadData(TextBox txtDiagonalMajor, TextBox txtDiagonalMinor)
        {
            try
            {
                mDiagonalMajor = float.Parse(txtDiagonalMajor.Text);
                mDiagonalMinor = float.Parse(txtDiagonalMinor.Text);

                if (mDiagonalMajor <= 0 || mDiagonalMinor <= 0)
                {
                    MessageBox.Show("Error: Ambas diagonales deben ser valores positivos.",
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
            // El perímetro del rombo es 4 veces el lado
            // El lado se puede calcular usando el teorema de Pitágoras
            float lado = (float)Math.Sqrt(
                Math.Pow(mDiagonalMajor / 2, 2) + Math.Pow(mDiagonalMinor / 2, 2)
            );

            mPerimeter = 4 * lado;
        }

        public void CalculateArea()
        {
            // El área de un rombo es la mitad del producto de sus diagonales
            mArea = (mDiagonalMajor * mDiagonalMinor) / 2;
        }

        public void PrintData(TextBox txtPerimeter, TextBox txtArea)
        {
            txtPerimeter.Text = mPerimeter.ToString();
            txtArea.Text = mArea.ToString();
        }

        public void InitializeData(TextBox txtDiagonalMajor, TextBox txtDiagonalMinor,
                                  TextBox txtPerimeter, TextBox txtArea, PictureBox picCanvas)
        {
            txtDiagonalMajor.Text = "";
            txtDiagonalMinor.Text = "";
            txtPerimeter.Text = "";
            txtArea.Text = "";
            txtDiagonalMajor.Focus();
            picCanvas.Refresh();
        }

        public void PlotShape(PictureBox picCanvas)
        {
            mgraphics = picCanvas.CreateGraphics();
            mgraphics.Clear(picCanvas.BackColor);
            mpen = new Pen(Color.DarkBlue, 2);

            float scaledDiagonalMajor = mDiagonalMajor * SF;
            float scaledDiagonalMinor = mDiagonalMinor * SF;

            float centerX = picCanvas.Width / 2;
            float centerY = picCanvas.Height / 2;

            // Definir los cuatro puntos del rombo usando las diagonales
            PointF[] points = new PointF[4];
            points[0] = new PointF(centerX, centerY - scaledDiagonalMinor / 2);  // Punto superior
            points[1] = new PointF(centerX + scaledDiagonalMajor / 2, centerY);  // Punto derecho
            points[2] = new PointF(centerX, centerY + scaledDiagonalMinor / 2);  // Punto inferior
            points[3] = new PointF(centerX - scaledDiagonalMajor / 2, centerY);  // Punto izquierdo

            mgraphics.DrawPolygon(mpen, points);

            // Dibujar las diagonales para visualizarlas
            Pen dashPen = new Pen(Color.Gray, 1);
            dashPen.DashStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            mgraphics.DrawLine(dashPen, points[0], points[2]); // Diagonal vertical
            mgraphics.DrawLine(dashPen, points[1], points[3]); // Diagonal horizontal
        }

        public void CloseForm(Form form)
        {
            form.Close();
        }
    }
}