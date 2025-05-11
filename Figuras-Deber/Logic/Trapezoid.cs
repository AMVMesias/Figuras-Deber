using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Figuras_Deber.Logic
{
    class Trapezoid
    {
        private float mSide1; 
        private float mSide2; 
        private float mSide3; 
        private float mSide4; 
        private float mPerimeter;
        private float mArea;
        private Graphics mGraph;
        private Pen mPen;
        private const float SF = 20;

        // Constructor
        public Trapezoid()
        {
            mSide1 = 0.0f; mSide2 = 0.0f;
            mSide3 = 0.0f; mSide4 = 0.0f;
            mPerimeter = 0.0f; mArea = 0.0f;
        }

        public bool ReadData(TextBox txtSide1, TextBox txtSide2, TextBox txtSide3, TextBox txtSide4)
        {
            try
            {
                mSide1 = float.Parse(txtSide1.Text);
                mSide2 = float.Parse(txtSide2.Text);
                mSide3 = float.Parse(txtSide3.Text);
                mSide4 = float.Parse(txtSide4.Text);

                if (mSide1 <= 0 || mSide2 <= 0 || mSide3 <= 0 || mSide4 <= 0)
                {
                    MessageBox.Show("Error: Todos los lados deben ser positivos.",
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

        public void PerimeterTrapezoid()
        {
            mPerimeter = mSide1 + mSide2 + mSide3 + mSide4;
        }

        public void AreaTrapezoid()
        {
            float x1 = 100, y1 = 100;
            float x2 = x1 + mSide1 * SF, y2 = y1;
            float x3 = x2 - mSide2 * 0.6f * SF, y3 = y2 + mSide2 * SF;
            float x4 = x1 - mSide4 * 0.4f * SF, y4 = y1 + mSide4 * SF;

            mArea = 0.5f * Math.Abs(
                x1 * y2 + x2 * y3 + x3 * y4 + x4 * y1 -
                (y1 * x2 + y2 * x3 + y3 * x4 + y4 * x1)
            );
        }

        public void PrintData(TextBox txtPerimeter, TextBox txtArea)
        {
            txtPerimeter.Text = mPerimeter.ToString("F2");
            txtArea.Text = mArea.ToString("F2");
        }

        public void InitializeData(TextBox txtSide1, TextBox txtSide2,
            TextBox txtSide3, TextBox txtSide4,
            TextBox txtPerimeter, TextBox txtArea,
            PictureBox picCanvas)
        {
            mSide1 = mSide2 = mSide3 = mSide4 = 0.0f;
            mPerimeter = mArea = 0.0f;

            txtSide1.Text = ""; txtSide2.Text = "";
            txtSide3.Text = ""; txtSide4.Text = "";
            txtPerimeter.Text = ""; txtArea.Text = "";
            txtSide1.Focus();
            picCanvas.Refresh();
        }

        public void PlotShape(PictureBox picCanvas)
        {
            mGraph = picCanvas.CreateGraphics();
            mGraph.Clear(Color.White);
            mPen = new Pen(Color.Blue, 2);

            // Calcular la posición centrada en el PictureBox
            float centerX = picCanvas.Width / 2;
            float centerY = (picCanvas.Height / 2)+10;

            float x1 = centerX - (mSide1 * SF) / 2, y1 = centerY - (mSide2 * SF) / 2;
            float x2 = x1 + mSide1 * SF, y2 = y1;
            float x3 = x2 - mSide2 * 0.6f * SF, y3 = y2 + mSide2 * SF;
            float x4 = x1 - mSide4 * 0.4f * SF, y4 = y1 + mSide4 * SF;

            PointF[] points = {
        new PointF(x1, y1),  
        new PointF(x2, y2),  
        new PointF(x3, y3),   
        new PointF(x4, y4)    
    };

            mGraph.DrawPolygon(mPen, points);

            Font labelFont = new Font("Arial", 10, FontStyle.Bold);
            Brush textBrush = new SolidBrush(Color.Red);


            float label1X = (points[0].X + points[1].X) / 2;
            float label1Y = (points[0].Y + points[1].Y) / 2 - 15;
            mGraph.DrawString("Lado (a)", labelFont, textBrush, label1X, label1Y);

            // Lado 2 (Derecho) - Entre puntos 1 y 2
            float label2X = (points[1].X + points[2].X) / 2 + 10;
            float label2Y = (points[1].Y + points[2].Y) / 2;
            mGraph.DrawString("Lado (b)", labelFont, textBrush, label2X, label2Y);

            // Lado 3 (Inferior) - Entre puntos 2 y 3
            float label3X = (points[2].X + points[3].X) / 2;
            float label3Y = (points[2].Y + points[3].Y) / 2 + 15;
            mGraph.DrawString("Lado (c)", labelFont, textBrush, label3X, label3Y);

            // Lado 4 (Izquierdo) - Entre puntos 3 y 0
            float label4X = (points[3].X + points[0].X) / 2 - 45;
            float label4Y = (points[3].Y + points[0].Y) / 2;
            mGraph.DrawString("Lado (d)", labelFont, textBrush, label4X, label4Y);

            mGraph.Dispose();

        }

        public void CloseForm(Form ObjForm)
        {
            ObjForm.Close();
        }
    }
}
