using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Figuras_Deber
{
    internal class Triangle
    {
        private float mWidth;
        private float mHeight;
        private float mPerimeter;
        private float mArea;
        private Graphics mgraphics;
        private Pen mpen;
        private const float SF = 10f;

        public Triangle()
        {
            mWidth = 0.0f; mHeight = 0.0f; mPerimeter = 0.0f; mArea = 0.0f;
        }
        public bool ReadData(TextBox txtWidth, TextBox txtHeight)
        {
            try
            {
                mWidth = float.Parse(txtWidth.Text);
                mHeight = float.Parse(txtHeight.Text);

                if (mWidth <= 0 || mHeight <= 0)
                {
                    MessageBox.Show("Error: Todos los valores deben ser positivos.",
                        "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }

                return true;
            }
            catch
            {
                MessageBox.Show("Error: Datos no validos.....",
                            "Mensaje de error");
                return false;
            }
        }
        public void PerimeterTriangle()
        {
            mPerimeter = (mWidth * 3);
        }
        public void AreaTriangle()
        {
            mArea = (mWidth * mHeight) / 2;
        }
        public void PrintData(TextBox txtPerimeter, TextBox txtArea)
        {
            txtPerimeter.Text = mPerimeter.ToString();
            txtArea.Text = mArea.ToString();
        }
        public void InizializeData(TextBox txtWidth, TextBox txtHeight, TextBox txtPerimeter, TextBox txtArea, PictureBox picCanvas)
        {
            txtWidth.Text = "";
            txtHeight.Text = "";
            txtPerimeter.Text = "";
            txtArea.Text = "";
            txtWidth.Focus();
            picCanvas.Refresh();
        }
        public void PlotShape(PictureBox picCanvas)
        {
            mgraphics = picCanvas.CreateGraphics();
            mgraphics.Clear(Color.White);

            mpen = new Pen(Color.Red, 2);
            float triangleWidth = mWidth * SF;
            float triangleHeight = mHeight * SF;

            // Calcular las coordenadas para centrar el triángulo
            float offsetX = (picCanvas.Width - triangleWidth) / 2;
            float offsetY = (picCanvas.Height - triangleHeight) / 2;

            PointF[] points = new PointF[3];
            points[0] = new PointF(offsetX, offsetY + triangleHeight); 
            points[1] = new PointF(offsetX + triangleWidth, offsetY + triangleHeight); 
            points[2] = new PointF(offsetX + (triangleWidth / 2), offsetY); 

            mgraphics.DrawPolygon(mpen, points);
        }
        public void CloseForn(Form form)
        {
            form.Close();
        }
    }
}