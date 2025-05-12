using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Figuras_Deber.Logic
{
    public class Enneagon
    {
        private float mSide;
        private float mPerimeter;
        private float mArea;
        private Graphics mGraph;
        private Pen mPen;
        private const float SF = 10; 
        private const int SIDES = 9; 

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
                    MessageBox.Show("Error: El lado debe ser positivo.",
                        "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }

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
            mPerimeter = SIDES * mSide; 
        }

        public void CalculateArea()
        {
            // Fórmula para el área de un polígono regular: A = (n × s² × cot(π/n)) / 4
            // Donde: n = número de lados, s = longitud del lado
            double cotangent = 1.0 / Math.Tan(Math.PI / SIDES);
            mArea = (float)((SIDES * mSide * mSide * cotangent) / 4.0);
        }

        public void PrintData(TextBox txtPerimeter, TextBox txtArea)
        {
            txtPerimeter.Text = mPerimeter.ToString("F2");
            txtArea.Text = mArea.ToString("F2");
        }

        public void InitializeData(TextBox txtSide, TextBox txtPerimeter, TextBox txtArea, PictureBox picCanvas)
        {
            mSide = 0.0f;
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
            mPen = new Pen(Color.Black, 2);

            float centerX = picCanvas.Width / 2;
            float centerY = picCanvas.Height / 2;


            float radius = (mSide * SF) / (2.0f * (float)Math.Sin(Math.PI / SIDES));

            PointF[] points = new PointF[SIDES];
            double angle = -Math.PI / 2; 

            for (int i = 0; i < SIDES; i++)
            {
                float x = centerX + radius * (float)Math.Cos(angle);
                float y = centerY + radius * (float)Math.Sin(angle);
                points[i] = new PointF(x, y);
                angle += 2 * Math.PI / SIDES; 
            }

            mGraph.DrawPolygon(mPen, points);

            // Liberar recursos
            mGraph.Dispose();
        }

        public void CloseForm(Form objForm)
        {
            objForm.Close();
        }
    }
}