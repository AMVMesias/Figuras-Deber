using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Figuras_Deber
{
    public partial class FrmTriangle : Form
    {
        Triangle ObjTriangle = new Triangle();
        public FrmTriangle()
        {
            InitializeComponent();
        }

        private void lblRadius_Click(object sender, EventArgs e)
        {

        }

        private void FrmTriangle_Load(object sender, EventArgs e)
        {

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            if (ObjTriangle.ReadData(txtWidth, txtHeight))
            {
                ObjTriangle.PerimeterTriangle();
                ObjTriangle.AreaTriangle();
                ObjTriangle.PrintData(txtPerimeter, txtArea);
                ObjTriangle.PlotShape(picCanvas);
            }
            else { picCanvas.Refresh(); }

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ObjTriangle.InizializeData(txtWidth, txtHeight, txtPerimeter, txtArea, picCanvas);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
        ObjTriangle.CloseForn(this);
        }
    }
}
