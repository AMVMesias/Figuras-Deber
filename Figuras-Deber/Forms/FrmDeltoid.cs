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
    public partial class FrmDeltoid : Form
    {
        Deltoid ObjDeltoid = new Deltoid();

        public FrmDeltoid()
        {
            InitializeComponent();
        }

        private void FrmDeltoid_Load(object sender, EventArgs e)
        {
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            if (ObjDeltoid.ReadData(txtDiagonalMajor, txtDiagonalMinor))
            {
                ObjDeltoid.CalculatePerimeter();
                ObjDeltoid.CalculateArea();
                ObjDeltoid.PrintData(txtPerimeter, txtArea);
                ObjDeltoid.PlotShape(picCanvas);
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ObjDeltoid.InitializeData(txtDiagonalMajor, txtDiagonalMinor,
                                    txtPerimeter, txtArea, picCanvas);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            ObjDeltoid.CloseForm(this);
        }
    }
}