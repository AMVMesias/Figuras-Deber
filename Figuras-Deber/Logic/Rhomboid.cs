using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Figuras_Deber.Logic
{
    internal class Rhomboid
    {
        private float mBase;
        private float mHeight;
        private float mAngle;  // En grados (opcional)
        private float mPerimeter;
        private float mArea;
        private Graphics mgraphics;
        private Pen mpen;
        private const float SF = 10f;

        public Rhomboid()
        {
            mBase = 0.0f;
            mHeight = 0.0f;
            mAngle = 45.0f;  // Ángulo predeterminado si no se proporciona
            mPerimeter = 0.0f;
            mArea = 0.0f;
        }

        // Versión con base y altura
        public bool ReadData(TextBox txtBase, TextBox txtHeight)
        {
            try
            {
                mBase = float.Parse(txtBase.Text);
                mHeight = float.Parse(txtHeight.Text);

                if (mBase <= 0 || mHeight <= 0)
                {
                    MessageBox.Show("Error: Base y altura deben ser valores positivos.",
                        "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }

                // Por defecto, usamos un ángulo de 45 grados
                mAngle = 45.0f;
                return true;
            }
            catch
            {
                MessageBox.Show("Error: Datos no válidos...",
                    "Mensaje de error");
                return false;
            }
        }

        // Versión con base, altura y ángulo (opcional)
        public bool ReadData(TextBox txtBase, TextBox txtHeight, TextBox txtAngle)
        {
            try
            {
                if (!ReadData(txtBase, txtHeight))
                    return false;

                // Si se proporciona un ángulo, lo leemos
                if (!string.IsNullOrEmpty(txtAngle.Text))
                {
                    mAngle = float.Parse(txtAngle.Text);

                    if (mAngle <= 0 || mAngle >= 90)
                    {
                        MessageBox.Show("Error: El ángulo debe estar entre 0 y 90 grados.",
                            "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return false;
                    }
                }

                return true;
            }
            catch
            {
                MessageBox.Show("Error: Datos no válidos...",
                    "Mensaje de error");
                return false;
            }
        }

        public void CalculatePerimeter()
        {
            // Calcular el lado usando trigonometría
            float radians = mAngle * (float)Math.PI / 180.0f;
            float side = mHeight / (float)Math.Sin(radians);

            // Perímetro = 2 * (base + lado)
            mPerimeter = 2 * (mBase + side);
        }

        public void CalculateArea()
        {
            // Área = base * altura
            mArea = mBase * mHeight;
        }

        public void PrintData(TextBox txtPerimeter, TextBox txtArea)
        {
            txtPerimeter.Text = mPerimeter.ToString();
            txtArea.Text = mArea.ToString();
        }

        public void InitializeData(TextBox txtBase, TextBox txtHeight, TextBox txtPerimeter,
                                  TextBox txtArea, PictureBox picCanvas)
        {
            txtBase.Text = "";
            txtHeight.Text = "";
            txtPerimeter.Text = "";
            txtArea.Text = "";
            txtBase.Focus();
            picCanvas.Refresh();
        }

        public void InitializeData(TextBox txtBase, TextBox txtHeight, TextBox txtAngle,
                                  TextBox txtPerimeter, TextBox txtArea, PictureBox picCanvas)
        {
            txtBase.Text = "";
            txtHeight.Text = "";
            txtAngle.Text = "";
            txtPerimeter.Text = "";
            txtArea.Text = "";
            txtBase.Focus();
            picCanvas.Refresh();
        }

        public void PlotShape(PictureBox picCanvas)
        {
            mgraphics = picCanvas.CreateGraphics();
            mgraphics.Clear(picCanvas.BackColor);
            mpen = new Pen(Color.DarkGreen, 2);

            // Usar el mismo factor de escala que en Square
            float scaledBase = mBase * SF;
            float scaledHeight = mHeight * SF;

            // Convertir el ángulo a radianes
            float radians = mAngle * (float)Math.PI / 180.0f;
            float scaledProjection = scaledHeight / (float)Math.Tan(radians);

            // Calcular las dimensiones totales del romboide
            float totalWidth = scaledBase + Math.Abs(scaledProjection);

            // Centrar el romboide en el canvas
            float offsetX = (picCanvas.Width - totalWidth + Math.Abs(scaledProjection)) / 2;
            float offsetY = (picCanvas.Height - scaledHeight) / 2;

            // Definir los cuatro puntos del romboide
            PointF[] points = new PointF[4];
            points[0] = new PointF(offsetX, offsetY);                              // Superior izquierdo
            points[1] = new PointF(offsetX + scaledBase, offsetY);                 // Superior derecho
            points[2] = new PointF(offsetX + scaledBase - scaledProjection, offsetY + scaledHeight);  // Inferior derecho
            points[3] = new PointF(offsetX - scaledProjection, offsetY + scaledHeight);             // Inferior izquierdo

            mgraphics.DrawPolygon(mpen, points);

            // Dibujar la altura con línea punteada
            Pen dashPen = new Pen(Color.Gray, 1);
            dashPen.DashStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            mgraphics.DrawLine(dashPen,
                              points[0].X, points[0].Y,
                              points[0].X, points[0].Y + scaledHeight);
        }

        public void CloseForm(Form form)
        {
            form.Close();
        }
    }
}