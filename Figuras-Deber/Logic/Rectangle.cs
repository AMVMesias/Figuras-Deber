using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Figuras_Deber.Logic
{
    class Rectangle
    {
        private float mWidth;
        private float mHeight;
        private float mPerimeter;
        private float mArea;
        private Graphics mGraph;
        private const float SF = 20;
        private Pen mPen;

        
        public Rectangle()
        {
            mWidth = 0.0f; mHeight = 0.0f;
            mPerimeter = 0.0f; mArea = 0.0f;
        }
        public bool ReadData(TextBox txtWidt, TextBox txtHidt)
        {
            try
            {
                mWidth = float.Parse(txtWidt.Text);
                mHeight = float.Parse(txtHidt.Text);

                if (mWidth <= 0 || mHeight <= 0)
                {
                    MessageBox.Show("Error: Todos los valores deben ser positivos.",
                        "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }

                if (mWidth == mHeight)
                {
                    MessageBox.Show("Error: El ancho y el alto no pueden ser iguales.",
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
        public void PerimeterRectangle()
        {
            mPerimeter = 2 * (mWidth + mHeight);
        }
        public void AreaRectangle()
        {
            mArea = mWidth * mHeight;
        }

        public void PrintData(TextBox txtPerimeter, TextBox txtArea)
        {
            txtPerimeter.Text = mPerimeter.ToString();
            txtArea.Text = mArea.ToString();
        }

        public void InitializeData(TextBox txtWidt, TextBox txtHeight,
            TextBox txtPerimeter, TextBox txtArea,
            PictureBox picCanvas)

        {
            mWidth = 0.0f; mHeight = 0.0f;
            mPerimeter = 0.0f; mArea = 0.0f;

            txtWidt.Text = ""; txtHeight.Text = "";
            txtPerimeter.Text = ""; txtArea.Text = "";
            txtWidt.Focus();
            picCanvas.Refresh();

        }

        public void PlotShape(PictureBox picCanvas)
        {
            mGraph = picCanvas.CreateGraphics();
            mGraph.Clear(Color.White);
            mPen = new Pen(Color.Red, 2);
            //Centrar el rectangulo
            float rectWidth = mWidth * SF;
            float rectHeight = mHeight * SF;
            float x = (picCanvas.Width - rectWidth) / 2;
            float y = (picCanvas.Height - rectHeight) / 2;
            mGraph.DrawRectangle(mPen, x, y, rectWidth, rectHeight);
        }
        public void CloseForm(Form ObjForm)
        {
            ObjForm.Close();
        }
    }
}
