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
    public partial class FrmEnneagon : Form
    {
        private Enneagon enneagon = new Enneagon();

        public FrmEnneagon()
        {
            InitializeComponent();
        }

        private void FrmEnneagon_Load(object sender, EventArgs e)
        {

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            if (enneagon.ReadData(txtSide))
            {
                enneagon.CalculatePerimeter();
                enneagon.CalculateArea();
                enneagon.PrintData(txtPerimeter, txtArea);
                enneagon.PlotShape(picCanvas);
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            enneagon.InitializeData(txtSide, txtPerimeter, txtArea, picCanvas);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            enneagon.CloseForm(this);
        }
    }
}