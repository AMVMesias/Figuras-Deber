using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Figuras_Deber
{
    internal class Circle
    {
        private float mPerimeter;
        private float mRadius;
        private float mArea;
        private Graphics mgraphics;
        private Pen mpen;
        private const float SF = 10f;

        public Circle()
        {
            mPerimeter = 0.0f; mRadius = 0.0f; mArea = 0.0f;
        }

        public bool ReadData(TextBox txtRadius)
        {
            try
            {
                if (!float.TryParse(txtRadius.Text, out float radius))
                {
                    MessageBox.Show("Error: Por favor ingrese un valor numérico válido.",
                        "Error de formato", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

                if (radius <= 0)
                {
                    MessageBox.Show("Error: El radio debe ser un valor positivo mayor que cero.",
                        "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }

                mRadius = radius;
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error inesperado: {ex.Message}",
                    "Error del sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        public void PerimeterCircle()
            {
                mPerimeter = 2 * (float)Math.PI * mRadius;
            }
        public void AreaCircle()
        {
            mArea = (float)Math.PI * (mRadius * mRadius);
        }
        public void PrintData(TextBox txtPerimeter, TextBox txtArea)
        {
            txtPerimeter.Text = mPerimeter.ToString();
            txtArea.Text = mArea.ToString();
        }
        public void InizializeData(TextBox txtRadius, TextBox txtPerimeter, TextBox txtArea, PictureBox picCanvas )
        {
            txtRadius.Text = "";
            txtPerimeter.Text = "";
            txtArea.Text = "";
            txtRadius.Focus();
            picCanvas.Refresh();
        }
        public void PlotShape(PictureBox picCanvas)
        {
            mgraphics = picCanvas.CreateGraphics();
            mgraphics.Clear(picCanvas.BackColor);
            mgraphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            mpen = new Pen(Color.Red, 2);

            // Calcular el tamaño de la elipse
            float ellipseWidth = mRadius * SF;
            float ellipseHeight = mRadius * SF;

            // Calcular las coordenadas para centrar la elipse
            float x = (picCanvas.Width - ellipseWidth) / 2;
            float y = (picCanvas.Height - ellipseHeight) / 2;

            // Dibujar la elipse centrada
            mgraphics.DrawEllipse(mpen, x, y, ellipseWidth, ellipseHeight);
            mgraphics.Dispose();
        }
        public void CloseForn(Form form)
        {
            form.Close();
        }
    }
}
