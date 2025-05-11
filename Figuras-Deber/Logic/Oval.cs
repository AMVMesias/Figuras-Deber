using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Figuras_Deber.Logic
{
    internal class Oval
    {
        private float mWidth;
        private float mHeight;
        private float mSemiMajorAxis;
        private float mSemiMinorAxis;
        private float mPerimeter;
        private float mArea;
        //Sirve para escalar la figura
        private const float SF = 10f;
        private float pi = (float)Math.PI;
        public Oval()
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
                mWidth = float.Parse(txtWidth.Text);
                mHeight = float.Parse(txtHeight.Text);

                if (mWidth <= 0 || mHeight <= 0)
                {
                    MessageBox.Show("Error: Todos los valores deben ser positivos.",
                        "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }

                mSemiMajorAxis = Math.Max(mWidth, mHeight) / 2;
                mSemiMinorAxis = Math.Min(mWidth, mHeight) / 2;
                return true;
            }
            catch
            {
                MessageBox.Show("Error: Datos no validos.....",
                            "Mensaje de error");
                return false;
            }
        }
        public void PerimeterOval()
        {
            float a = mSemiMajorAxis;
            float b = mSemiMinorAxis;
            float h = (float)Math.Pow((a - b) / (a + b), 2);
            mPerimeter = pi * (a + b) * (1 + (3 * h) / (10 + (float)Math.Sqrt(4 - 3 * h)));
        }
        public void AreaOval()
        {
            mArea = pi * mSemiMajorAxis * mSemiMinorAxis;

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
            // Crear un bitmap para dibujar
            Bitmap bmp = new Bitmap(picCanvas.Width, picCanvas.Height);
            using (Graphics g = Graphics.FromImage(bmp))
            {
                g.Clear(picCanvas.BackColor); // Limpiar el fondo
                g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

                // Calcular dimensiones escaladas
                float ovalWidth = mWidth * SF;
                float ovalHeight = mHeight * SF;

                // Centrar el óvalo en el PictureBox
                float x = (picCanvas.Width - ovalWidth) / 2;
                float y = (picCanvas.Height - ovalHeight) / 2;

                // Dibujar un óvalo tipo huevo (asimetría en el eje X)
                if (mWidth > 0 && mHeight > 0)
                {
                    using (Pen pen = new Pen(Color.Black, 2))
                    {
                        // Opción 1: Usar GraphicsPath para forma personalizada
                        System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath();

                        // Crear puntos para un óvalo asimétrico (forma de huevo)
                        PointF[] points = new PointF[36]; // 36 puntos para suavidad
                        for (int i = 0; i < 36; i++)
                        {
                            float angle = (float)(2 * Math.PI * i / 36);
                            float radiusX = ovalWidth / 2 * (1 + 0.2f * (float)Math.Sin(angle)); // Asimetría
                            float radiusY = ovalHeight / 2;
                            points[i] = new PointF(
                                x + ovalWidth / 2 + radiusX * (float)Math.Cos(angle),
                                y + ovalHeight / 2 + radiusY * (float)Math.Sin(angle)
                            );
                        }

                        path.AddClosedCurve(points, 0.5f); // Suavizado de curva
                        g.DrawPath(pen, path);
                    }
                }
            }

            // Asignar el bitmap al PictureBox
            picCanvas.Image = bmp;
        }
        public void CloseForn(Form form)
        {
            form.Close();
        }
    }
}
