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
    public partial class FrmOctagon : Form
    {
        private Octagon octagon = new Octagon();

        public FrmOctagon()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            if (octagon.ReadData(txtSide))
            {
                octagon.CalculatePerimeter();
                octagon.CalculateArea();
                octagon.PrintData(txtPerimeter, txtArea);
                octagon.PlotShape(picCanvas);
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            octagon.InitializeData(txtSide, txtPerimeter, txtArea, picCanvas);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            octagon.CloseForm(this);
        }
    }
}