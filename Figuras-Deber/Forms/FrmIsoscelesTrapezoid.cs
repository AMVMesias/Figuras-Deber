using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Figuras_Deber.Logic;

namespace Figuras_Deber.Forms
{
    public partial class FrmIsoscelesTrapezoid : Form
    {
        IsoscelesTrapezoid ObjIsoscelesTrapezoid = new IsoscelesTrapezoid();
        public FrmIsoscelesTrapezoid()
        {
            InitializeComponent();
        }

        private void FrmIsoscelesTrapezoid_Load(object sender, EventArgs e)
        {

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            if (ObjIsoscelesTrapezoid.ReadData(txtUpperBase, txtLowerBase, txtHeight))
            {
                ObjIsoscelesTrapezoid.PerimeterIsoscelesTrapezoid();
                ObjIsoscelesTrapezoid.AreaIsoscelesTrapezoid();
                ObjIsoscelesTrapezoid.PrintData(txtPerimeter, txtArea);
                ObjIsoscelesTrapezoid.PlotShape(picCanvas);
            }
            else
            {
                picCanvas.Refresh();
            }
        }
        private void btnReset_Click(object sender, EventArgs e)
        {
            ObjIsoscelesTrapezoid.InizializeData(txtUpperBase, txtLowerBase, txtHeight, txtPerimeter, txtArea, picCanvas);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            ObjIsoscelesTrapezoid.CloseForm(this);
        }
    }
}
