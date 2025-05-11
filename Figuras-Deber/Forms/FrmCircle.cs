using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Figuras_Deber
{
    public partial class FrmCircle : Form
    {
        Circle ObjCircle = new Circle();
        public FrmCircle()
        {
            InitializeComponent();
        }

        private void grbinputs_Enter(object sender, EventArgs e)
        {

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            if (ObjCircle.ReadData(txtRadius))
            {
                ObjCircle.PerimeterCircle();
                ObjCircle.AreaCircle();
                ObjCircle.PrintData(txtPerimeter, txtArea);
                ObjCircle.PlotShape(picCanvas);
            }
            else
            {
                picCanvas.Refresh();
            }

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ObjCircle.InizializeData(txtRadius, txtPerimeter, txtArea, picCanvas);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            ObjCircle.CloseForn(this);
        }

        private void FrmCircle_Load(object sender, EventArgs e)
        {

        }

        private void lblRadius_Click(object sender, EventArgs e)
        {

        }
    }
    }
