using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Figuras_Deber.Logic; // Asumiendo que Square y Deltoid están en este namespace

namespace Figuras_Deber.Forms
{
    public partial class FrmSquare : Form
    {
        Square ObjSquare = new Square();

        public FrmSquare()
        {
            InitializeComponent();
        }

        private void FrmSquare_Load(object sender, EventArgs e)
        {
            // Si necesitas inicializar algo al cargar el formulario
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            if (ObjSquare.ReadData(txtSide))
            {
                ObjSquare.CalculatePerimeter();
                ObjSquare.CalculateArea();
                ObjSquare.PrintData(txtPerimeter, txtArea);
                ObjSquare.PlotShape(picCanvas);
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ObjSquare.InitializeData(txtSide, txtPerimeter, txtArea, picCanvas);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            ObjSquare.CloseForm(this);
        }
    }
}