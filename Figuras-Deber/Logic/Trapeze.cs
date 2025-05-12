using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Figuras_Deber.Logic
{
    internal class Trapeze
    {
        private float mUpperBase;
        private float mLowerBase;
        private float mHeight;
        private float mPerimeter;
        private float mArea;
        private Graphics mgraphics;
        private Pen mpen;
        private const float SF = 20f;

        // Añadimos un offset para crear asimetría
        private float mLeftOffset;

        public Trapeze()
        {
            mUpperBase = 0.0f; mLowerBase = 0.0f; mHeight = 0.0f; mPerimeter = 0.0f; mArea = 0.0f;
            // Por defecto, el offset será 1/3 de la diferencia entre bases
            mLeftOffset = 0.33f;
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
                    MessageBox.Show("Todos los valores deben ser mayores que cero.",
                        "Error de validación");
                    return false; 
                }

                if (mUpperBase >= mLowerBase)
                {
                    MessageBox.Show("La base superior debe ser menor que la base inferior.",
                        "Error de validación");
                    return false; 
                }

                return true;
            }
            catch
            {
                MessageBox.Show("Error: Datos no válidos. Ingrese solo valores numéricos.",
                    "Mensaje de error");
                return false;
            }
        }

        public void PerimeterTrapeze()
        {
            float baseDifference = mLowerBase - mUpperBase;

            float leftSide = (float)Math.Sqrt(
                Math.Pow(mHeight, 2) +
                Math.Pow(baseDifference * mLeftOffset, 2)
            );

            float rightSide = (float)Math.Sqrt(
                Math.Pow(mHeight, 2) +
                Math.Pow(baseDifference * (1 - mLeftOffset), 2)
            );

            mPerimeter = mLowerBase + mUpperBase + leftSide + rightSide;
        }

        public void AreaTrapeze()
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
            mgraphics.Clear(picCanvas.BackColor);
            mpen = new Pen(Color.Black, 2);

            float scaledUpperBase = mUpperBase * SF;
            float scaledLowerBase = mLowerBase * SF;
            float scaledHeight = mHeight * SF;
            float baseDifference = scaledLowerBase - scaledUpperBase;

            float x3 = (picCanvas.Width - scaledLowerBase) / 2;
            float y3 = (picCanvas.Height + scaledHeight) / 2;

            float x4 = x3 + scaledLowerBase;
            float y4 = y3;

            float x1 = x3 + baseDifference * mLeftOffset; 
            float y1 = y3 - scaledHeight;

            float x2 = x1 + scaledUpperBase; 
            float y2 = y1;

            PointF[] points = {
        new PointF(x1, y1), 
        new PointF(x2, y2), 
        new PointF(x4, y4), 
        new PointF(x3, y3)  
    };

            mgraphics.DrawPolygon(mpen, points);
        }


        public void CloseForn(Form form)
        {
            form.Close();
        }
    }
}