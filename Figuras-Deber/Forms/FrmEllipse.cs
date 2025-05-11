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
    public partial class FrmEllipse : Form
    {
        Ellipse ObjEllipse = new Ellipse();

        public FrmEllipse()
        {
            InitializeComponent();
        }

        private void FrmEllipse_Load(object sender, EventArgs e)
        {


        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            if (ObjEllipse.ReadData(txtWidth, txtHeight))
            {
                ObjEllipse.PerimeterEllipse();
                ObjEllipse.AreaEllipse();
                ObjEllipse.PrintData(txtPerimeter, txtArea);
                ObjEllipse.PlotShape(picCanvas);
            }
            else
            {
                picCanvas.Refresh();


            }
        }
        private void btnReset_Click(object sender, EventArgs e)
        {
            ObjEllipse.InizializeData(txtWidth, txtHeight, txtPerimeter, txtArea, picCanvas);

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            ObjEllipse.CloseForn(this);

        }
    }
}
