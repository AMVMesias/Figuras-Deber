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

namespace Figuras_Deber
{
    public partial class FrmRhomboid : Form
    {
        Rhomboid ObjRhomboid = new Rhomboid();

        public FrmRhomboid()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            if (ObjRhomboid.ReadData(txtBase, txtHeight, txtAngle))
            {
                ObjRhomboid.CalculatePerimeter();
                ObjRhomboid.CalculateArea();
                ObjRhomboid.PrintData(txtPerimeter, txtArea);
                ObjRhomboid.PlotShape(picCanvas);
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ObjRhomboid.InitializeData(txtBase, txtHeight, txtAngle,
                                     txtPerimeter, txtArea, picCanvas);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            ObjRhomboid.CloseForm(this);
        }
    }
}