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
    public partial class FrmDecagon : Form
    {
        private Decagon decagon = new Decagon();

        public FrmDecagon()
        {
            InitializeComponent();
        }

        private void FrmDecagon_Load(object sender, EventArgs e)
        {

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            if (decagon.ReadData(txtSide))
            {
                decagon.CalculatePerimeter();
                decagon.CalculateArea();
                decagon.PrintData(txtPerimeter, txtArea);
                decagon.PlotShape(picCanvas);
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            decagon.InitializeData(txtSide, txtPerimeter, txtArea, picCanvas);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            decagon.CloseForm(this);
        }
    }
}
