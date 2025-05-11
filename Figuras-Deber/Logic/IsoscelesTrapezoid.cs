using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Figuras_Deber.Logic
{
    internal class IsoscelesTrapezoid
    {
        private float mUpperBase;
        private float mLowerBase;
        private float mHeight;
        private float mPerimeter;
        private float mArea;
        private Graphics mgraphics;
        private Pen mpen;
        private const float SF = 10f;

        public IsoscelesTrapezoid()
        {
            mUpperBase = 0.0f; mLowerBase = 0.0f; mHeight = 0.0f; mPerimeter = 0.0f; mArea = 0.0f;
        }
        public bool ReadData(TextBox txtUpperBase, TextBox txtLowerBase, TextBox txtHeight)
        {
            try
            {
                mUpperBase = float.Parse(txtUpperBase.Text);
                mLowerBase = float.Parse(txtLowerBase.Text);
                mHeight = float.Parse(txtHeight.Text);

                if (mUpperBase <= 0 || mLowerBase <= 0 || mHeight <= 0)
                {
                    MessageBox.Show("Error: Todos los valores deben ser positivos.",
                        "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }

                if (mUpperBase >= mLowerBase)
                {
                    MessageBox.Show("Error: La base superior debe ser menor que la base inferior.",
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
        public void PerimeterIsoscelesTrapezoid()
        {
            float lateralSide = (float)Math.Sqrt(
                Math.Pow(mHeight, 2) +
                Math.Pow((mLowerBase - mUpperBase) / 2, 2)
            );
            mPerimeter = mLowerBase + mUpperBase + (2 * lateralSide);
        }
        public void AreaIsoscelesTrapezoid()
        {
            mArea = ((mUpperBase + mLowerBase) * mHeight) / 2;
        }
        public void PrintData(TextBox txtPerimeter, TextBox txtArea)
        {
            txtPerimeter.Text = mPerimeter.ToString();
            txtArea.Text = mArea.ToString();
        }
        public void InizializeData(TextBox txtUpperBase, TextBox txtLowerBase, TextBox txtHeight, TextBox txtPerimeter, TextBox txtArea, PictureBox picCanvas)
        {
            txtUpperBase.Text = "";
            txtLowerBase.Text = "";
            txtHeight.Text = "";
            txtPerimeter.Text = "";
            txtArea.Text = "";
            txtUpperBase.Focus();
            picCanvas.Refresh();
        }
        public void PlotShape(PictureBox picCanvas)
        {
            mgraphics = picCanvas.CreateGraphics();
            mgraphics.Clear(Color.White);
            mpen = new Pen(Color.Black, 2);

            float x1 = (picCanvas.Width - (mLowerBase * SF)) / 2;
            float y1 = (picCanvas.Height - (mHeight * SF)) / 2;
            float x2 = x1 + (mLowerBase * SF);
            float y2 = y1 + (mHeight * SF);
            float x3 = x1 + ((mLowerBase - mUpperBase) * SF) / 2;
            float y3 = y1;
            float x4 = x3 + (mUpperBase * SF);
            float y4 = y3;
            PointF[] points = {
                new PointF(x1, y2),
                new PointF(x3, y3),
                new PointF(x4, y3),
                new PointF(x2, y2)
            };
            mgraphics.DrawPolygon(mpen, points);
            mgraphics.Dispose();

        }
        public void CloseForm(Form form)
        {
            form.Close();
        }
    }
}
