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
    
    public partial class FrmTrapeze : Form
    {
        Trapeze ObjTrapeze = new Trapeze();
        public FrmTrapeze()
        {
            InitializeComponent();
        }

        private void FrmTrapeze_Load(object sender, EventArgs e)
        {

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            if (ObjTrapeze.ReadData(txtUpperBase, txtLowerBase, txtHeight))
            {
                ObjTrapeze.PerimeterTrapeze();
                ObjTrapeze.AreaTrapeze();
                ObjTrapeze.PrintData(txtPerimeter, txtArea);
                ObjTrapeze.PlotShape(picCanvas);
            }
            else
            {
                // Opcionalmente, limpiamos el canvas si hay un error
                picCanvas.Refresh();
            }


        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ObjTrapeze.InizializeData(txtUpperBase, txtLowerBase, txtHeight, txtPerimeter, txtArea, picCanvas);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            ObjTrapeze.CloseForn(this);
        }
    }
}
