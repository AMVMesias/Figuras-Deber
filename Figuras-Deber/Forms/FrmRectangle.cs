using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Figuras_Deber.Logic;


namespace Figuras_Deber.Forms
{
    public partial class FrmRectangle : Form
    {
        Rectangle ObjRectangle = new Rectangle();
        public FrmRectangle()
        {
            InitializeComponent();
        }

        private void txtWidth_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmRectangle_Load(object sender, EventArgs e)
        {
            ObjRectangle.InitializeData(txtWidth, txtHeight, txtPerimeter, txtArea, picCanvas);
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {


            if (ObjRectangle.ReadData(txtWidth, txtHeight))
            {
                ObjRectangle.PerimeterRectangle();
                ObjRectangle.AreaRectangle();
                ObjRectangle.PrintData(txtPerimeter, txtArea);
                ObjRectangle.PlotShape(picCanvas);
            }
            else { picCanvas.Refresh(); }

        }

        private void btnReset_Click(object sender, EventArgs e)
        {

            //Inicializa los datos de los datos y controles
            //Llamada a la funcion InitializeData 
            ObjRectangle.InitializeData(txtWidth, txtHeight, txtPerimeter, txtArea, picCanvas);

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            //Cierra del formulario
            //Llamada a la funcion closeForm
            ObjRectangle.CloseForm(this);
        }

    }
}
