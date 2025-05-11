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
    public partial class FrmOval : Form
    {
        Oval ObjOval = new Oval();
        public FrmOval()
        {
            InitializeComponent();
        }

        private void FrmOval_Load(object sender, EventArgs e)
        {

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            if (ObjOval.ReadData(txtWidth, txtHeight))
            {
                ObjOval.PerimeterOval();
                ObjOval.AreaOval();
                ObjOval.PrintData(txtPerimeter, txtArea);
                ObjOval.PlotShape(picCanvas);
            }
            else { picCanvas.Refresh(); }
           
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ObjOval.InizializeData(txtWidth, txtHeight, txtPerimeter, txtArea, picCanvas);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            ObjOval.CloseForn(this);
        }
    }
}
