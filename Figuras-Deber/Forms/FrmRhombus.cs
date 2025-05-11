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
    public partial class FrmRhombus : Form
    {
        Rhombus ObjRhombus = new Rhombus();

        public FrmRhombus()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            if (ObjRhombus.ReadData(txtDiagonalMajor, txtDiagonalMinor))
            {
                ObjRhombus.CalculatePerimeter();
                ObjRhombus.CalculateArea();
                ObjRhombus.PrintData(txtPerimeter, txtArea);
                ObjRhombus.PlotShape(picCanvas);
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ObjRhombus.InitializeData(txtDiagonalMajor, txtDiagonalMinor,
                                    txtPerimeter, txtArea, picCanvas);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            ObjRhombus.CloseForm(this);
        }
    }
}
