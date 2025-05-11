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
using Figuras_Deber.Forms;


namespace Figuras_Deber
{
    public partial class FrmHome : Form
    {
        public FrmHome()
        {
            InitializeComponent();
        }

        private void lblTitulo_Click(object sender, EventArgs e)
        {

        }

        private void figurasToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void FrmHome_Load(object sender, EventArgs e)
        {
            
        }

        private void triánguloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmTriangle frmTriangle = new FrmTriangle();
            frmTriangle.MdiParent = this;
            CenterWindows(frmTriangle);
            frmTriangle.Show();

        }
        public void CloseForn(Form form)
        {
            form.Close();
        }

        private void mnuCircle_Click(object sender, EventArgs e)
        {
            FrmCircle frmCircle = new FrmCircle();
            frmCircle.MdiParent = this;


            CenterWindows(frmCircle);


            frmCircle.Show();
        }
        public void CenterWindows(Form form)
        {
            form.StartPosition = FormStartPosition.Manual;

            // Calcular la posición para centrar el formulario dentro de FrmHome
            int x = (this.ClientSize.Width - form.Width) / 2;
            int y = (this.ClientSize.Height - form.Height) / 2;
            form.Location = new Point(x, y+30);
        }

        private void mnuFigura_Click(object sender, EventArgs e)
        {

        }

        private void mnuEllipse_Click(object sender, EventArgs e)
        {
            FrmEllipse frmEllipse = new FrmEllipse();
            frmEllipse.MdiParent = this;
            CenterWindows(frmEllipse);
            frmEllipse.Show();
        }

        private void mnuOval_Click(object sender, EventArgs e)
        {
            FrmOval frmOval = new FrmOval();
            frmOval.MdiParent = this;
            CenterWindows(frmOval);
            frmOval.Show();
        }

        private void mnuRectangle_Click(object sender, EventArgs e)
        {
            FrmRectangle frmRectangle = new FrmRectangle();
            frmRectangle.MdiParent = this;
            CenterWindows(frmRectangle);
            frmRectangle.Show();
        }

        private void mnuTrapeze_Click(object sender, EventArgs e)
        {
            FrmTrapeze frmTrapeze = new FrmTrapeze();
            frmTrapeze.MdiParent = this;
            CenterWindows(frmTrapeze);
            frmTrapeze.Show();
        }

        private void mnuIsoscelesTrapezoid_Click(object sender, EventArgs e)
        {
            FrmIsoscelesTrapezoid frmIsoscelesTrapezoid = new FrmIsoscelesTrapezoid();
            frmIsoscelesTrapezoid.MdiParent = this;
            CenterWindows(frmIsoscelesTrapezoid);
            frmIsoscelesTrapezoid.Show();
        }

        private void mnuSquare_Click(object sender, EventArgs e)
        {

            FrmSquare frmSquare = new FrmSquare();
            frmSquare.MdiParent = this;
            CenterWindows(frmSquare);
            frmSquare.Show();

        
    }

        private void mnuDeltoid_Click(object sender, EventArgs e)
        {
            FrmDeltoid frmDeltoid = new FrmDeltoid();
            frmDeltoid.MdiParent = this;
            CenterWindows(frmDeltoid);
            frmDeltoid.Show();
        }

        private void mnuRhomboid_Click(object sender, EventArgs e)
        {
            FrmRhomboid frmRhomboid = new FrmRhomboid();
            frmRhomboid.MdiParent = this;
            CenterWindows(frmRhomboid);
            frmRhomboid.Show();
        }

        private void mnuTrapezoid_Click(object sender, EventArgs e)
        {
            FrmTrapezoid frmTrapezoid = new FrmTrapezoid();
            frmTrapezoid.MdiParent = this;
            CenterWindows(frmTrapezoid);
            frmTrapezoid.Show();
        }

        private void mnuHeptagon_Click(object sender, EventArgs e)
        {
            FrmHeptagon frmHeptagon = new FrmHeptagon();
            frmHeptagon.MdiParent = this;
            CenterWindows(frmHeptagon);
            frmHeptagon.Show();
        }

        private void mnuRhombus_Click(object sender, EventArgs e)
        {
            FrmRhombus frmRhombus = new FrmRhombus();
            frmRhombus.MdiParent = this;
            CenterWindows(frmRhombus);
            frmRhombus.Show();
        }

        private void mnuOctagon_Click(object sender, EventArgs e)
        {
            FrmOctagon frmOctagon = new FrmOctagon();
            frmOctagon.MdiParent = this;
            CenterWindows(frmOctagon);
            frmOctagon.Show();


        }

        private void mnuPentagon_Click(object sender, EventArgs e)
        {
            FrmPentagon frmPentagon = new FrmPentagon();
            frmPentagon.MdiParent = this;
            CenterWindows(frmPentagon);
            frmPentagon.Show();

        }

        private void mnuDecagon_Click(object sender, EventArgs e)
        {
            FrmDecagon frmDecagon = new FrmDecagon();
            frmDecagon.MdiParent = this;
            CenterWindows(frmDecagon);
            frmDecagon.Show();
        }

        private void mnuHexagon_Click(object sender, EventArgs e)
        {
            FrmHexagon frmHexagon = new FrmHexagon();
            frmHexagon.MdiParent = this;
            CenterWindows(frmHexagon);
            frmHexagon.Show();

        }

        private void mnuEnneagon_Click(object sender, EventArgs e)
        {
            FrmEnneagon frmEnneagon = new FrmEnneagon();
            frmEnneagon.MdiParent = this;
            CenterWindows(frmEnneagon);
            frmEnneagon.Show();
        }
    }
    }
