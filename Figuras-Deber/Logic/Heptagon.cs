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
        private float mSide;         // Longitud del lado
        private float mRadius;       // Radio (calculado)
        private float mPerimeter;
        private float mArea;
        private Graphics mGraph;
        private Pen mPen;
        private const float SF = 20;
        private const int NUM_SIDES = 7; // Número de lados del heptágono

        // Constructor
        public Heptagon()
        {
            mSide = 0.0f;
            mRadius = 0.0f;
            mPerimeter = 0.0f;
            mArea = 0.0f;
        }

        // Método para leer el lado
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

                // Calcular el radio a partir del lado
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
            // Área de un heptágono regular = (7/4) * lado^2 / tan(π/7)
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

            // Calcular el centro del PictureBox
            float centerX = picCanvas.Width / 2;
            float centerY = picCanvas.Height / 2;

            // Calcular el radio escalado para que se ajuste al PictureBox
            float scaledRadius = Math.Min(picCanvas.Width, picCanvas.Height) * 0.4f;
            if (mRadius > 0)
            {
                // Usar el radio calculado a partir del lado
                scaledRadius = Math.Min(scaledRadius, mRadius * SF);
            }

            // Crear un array para los puntos del heptágono
            PointF[] points = new PointF[NUM_SIDES];

            // Calcular los vértices del heptágono
            for (int i = 0; i < NUM_SIDES; i++)
            {
                // Ángulo para cada vértice (empezando desde arriba y yendo en sentido horario)
                float angle = ((float)Math.PI / 2) + (2 * (float)Math.PI * i / NUM_SIDES);

                // Calcular coordenadas de cada vértice
                float x = centerX + scaledRadius * (float)Math.Cos(angle);
                float y = centerY - scaledRadius * (float)Math.Sin(angle);

                points[i] = new PointF(x, y);
            }

            // Dibujar el heptágono
            mGraph.DrawPolygon(mPen, points);
        }

        public void CloseForm(Form ObjForm)
        {
            ObjForm.Close();
        }
    }
}