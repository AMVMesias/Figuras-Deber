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
    public partial class FrmHeptagon : Form
    {
        Heptagon ObjHeptagon = new Heptagon();

        public FrmHeptagon()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            if (ObjHeptagon.ReadData(txtSide))
            {
                ObjHeptagon.CalculatePerimeter();
                ObjHeptagon.CalculateArea();
                ObjHeptagon.PrintData(txtPerimeter, txtArea);
                ObjHeptagon.PlotShape(picCanvas);
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ObjHeptagon.InitializeData(txtSide, txtPerimeter, txtArea, picCanvas);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            ObjHeptagon.CloseForm(this);
        }
    }
}
