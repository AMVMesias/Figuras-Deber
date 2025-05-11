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
    public partial class FrmPentagon : Form
    {
        private Pentagon pentagon = new Pentagon();

        public FrmPentagon()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            if (pentagon.ReadData(txtSide))
            {
                pentagon.CalculatePerimeter();
                pentagon.CalculateArea();
                pentagon.PrintData(txtPerimeter, txtArea);
                pentagon.PlotShape(picCanvas);
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            pentagon.InitializeData(txtSide, txtPerimeter, txtArea, picCanvas);

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            pentagon.CloseForm(this);

        }

        private void FrmPentagon_Load(object sender, EventArgs e)
        {

        }
    }
}
