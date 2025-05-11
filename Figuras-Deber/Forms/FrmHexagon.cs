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
    public partial class FrmHexagon : Form
    {
        private Hexagon hexagon = new Hexagon();

        public FrmHexagon()
        {
            InitializeComponent();
        }

        private void FrmHexagon_Load(object sender, EventArgs e)
        {

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            if (hexagon.ReadData(txtSide))
            {
                hexagon.CalculatePerimeter();
                hexagon.CalculateArea();
                hexagon.PrintData(txtPerimeter, txtArea);
                hexagon.PlotShape(picCanvas);
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            hexagon.InitializeData(txtSide, txtPerimeter, txtArea, picCanvas);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            hexagon.CloseForm(this);
        }
    }
}
