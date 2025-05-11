using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Figuras_Deber.Logic
{
    internal class Ellipse
    {
        private float mWidth;
        private float mHeight;
        private float mSemiMajorAxis ;
        private float mSemiMinorAxis ;
        private float mPerimeter;
        private float mArea;
        private Graphics mgraphics;
        private Pen mpen;

        //Sirve para escalar la figura
        private const float SF = 10f;
        private float pi = (float)Math.PI;
        public Ellipse()
        {
            mWidth = 0.0f;
            mHeight = 0.0f;
            mSemiMajorAxis = 0.0f;
            mSemiMinorAxis = 0.0f;
            mPerimeter = 0.0f;
            mArea = 0.0f;
        }
        public bool ReadData(TextBox txtWidth, TextBox txtHeight)
        {
            try
            {
                if (!float.TryParse(txtWidth.Text, out float width) || !float.TryParse(txtHeight.Text, out float height))
                {
                    MessageBox.Show("Error: Por favor ingrese valores numéricos válidos.",
                        "Error de formato", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

                if (width <= 0 || height <= 0)
                {
                    MessageBox.Show("Error: Los valores deben ser positivos mayores que cero.",
                        "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }

                mSemiMajorAxis = width / 2;
                mSemiMinorAxis = height / 2;
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error inesperado: {ex.Message}",
                    "Error del sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        public void PerimeterEllipse()
        {
            mPerimeter = (float)(pi * (3 * (mSemiMajorAxis + mSemiMinorAxis) - Math.Sqrt((3 * mSemiMajorAxis + mSemiMinorAxis) * (mSemiMajorAxis + 3 * mSemiMinorAxis))));
        }
        public void AreaEllipse()
        {
            mArea = pi * mSemiMajorAxis * mSemiMinorAxis;
        }
        public void PrintData(TextBox txtPerimeter, TextBox txtArea)
        {
            txtPerimeter.Text = mPerimeter.ToString();
            txtArea.Text = mArea.ToString();
        }
        public void InizializeData(TextBox txtSemiMajorAxis, TextBox txtSemiMinorAxis, TextBox txtPerimeter, TextBox txtArea, PictureBox picCanvas)
        {
            txtSemiMajorAxis.Text = "";
            txtSemiMinorAxis.Text = "";
            txtPerimeter.Text = "";
            txtArea.Text = "";
            txtSemiMajorAxis.Focus();
            picCanvas.Refresh();
        }
        public void PlotShape(PictureBox picCanvas)
        {
            mgraphics = picCanvas.CreateGraphics();
            mgraphics.Clear(picCanvas.BackColor);

            mpen = new Pen(Color.Red, 2);
            float ellipseWidth = mSemiMajorAxis * SF;
            float ellipseHeight = mSemiMinorAxis * SF;
            // Calcular las coordenadas para centrar la elipse
            float x = (picCanvas.Width - ellipseWidth) / 2;
            float y = (picCanvas.Height - ellipseHeight) / 2;
            // Dibujar la elipse
            mgraphics.DrawEllipse(mpen, x, y, ellipseWidth, ellipseHeight);
            mgraphics.Dispose();

        }
        public void CloseForn(Form form)
        {
            form.Close();
        }

    }

}
