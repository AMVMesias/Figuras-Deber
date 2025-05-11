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
    public partial class FrmTrapezoid : Form
    {
        Trapezoid ObjTrapezoid = new Trapezoid();

        public FrmTrapezoid()
        {
            InitializeComponent();
        }

        private void FrmTrapezoid_Load(object sender, EventArgs e)
        {

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            if (ObjTrapezoid.ReadData(txtSide1, txtSide2, txtSide3, txtSide4))
            {
                ObjTrapezoid.PerimeterTrapezoid();
                ObjTrapezoid.AreaTrapezoid();
                ObjTrapezoid.PrintData(txtPerimeter, txtArea);
                ObjTrapezoid.PlotShape(picCanvas);
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ObjTrapezoid.InitializeData(txtSide1, txtSide2, txtSide3, txtSide4,
                                      txtPerimeter, txtArea, picCanvas);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            ObjTrapezoid.CloseForm(this);
        }
    }
}
