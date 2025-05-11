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
        private Form currentFigureForm; // Para mantener una referencia al formulario de figura actualmente abierto

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

        // Método centralizado para mostrar formularios de figuras
        private void ShowFigureForm(Form newForm)
        {
            // Cerrar el formulario actual si existe
            if (currentFigureForm != null && !currentFigureForm.IsDisposed)
            {
                currentFigureForm.Close();
            }
            newForm.MinimizeBox = false;
            newForm.MaximizeBox = false;
            newForm.ControlBox = false;
            // Configurar y mostrar el nuevo formulario
            newForm.MdiParent = this;
            CenterWindows(newForm);
            newForm.Show();

            // Almacenar referencia al nuevo formulario
            currentFigureForm = newForm;
        }

        public void CloseForn(Form form)
        {
            form.Close();
        }
        public void CenterWindows(Form form)
        {
            form.StartPosition = FormStartPosition.Manual;

            // Calcular la posición para centrar el formulario dentro de FrmHome
            int x = (this.ClientSize.Width - form.Width) / 2;
            int y = (this.ClientSize.Height - form.Height) / 2;
            form.Location = new Point(x, y + 30);
        }

        private void mnuFigura_Click(object sender, EventArgs e)
        {

        }

        // Todos los handlers de menú ahora usan el método ShowFigureForm
        private void triánguloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowFigureForm(new FrmTriangle());
        }

        private void mnuCircle_Click(object sender, EventArgs e)
        {
            ShowFigureForm(new FrmCircle());
        }

        private void mnuEllipse_Click(object sender, EventArgs e)
        {
            ShowFigureForm(new FrmEllipse());
        }

        private void mnuOval_Click(object sender, EventArgs e)
        {
            ShowFigureForm(new FrmOval());
        }

        private void mnuRectangle_Click(object sender, EventArgs e)
        {
            ShowFigureForm(new FrmRectangle());
        }

        private void mnuTrapeze_Click(object sender, EventArgs e)
        {
            ShowFigureForm(new FrmTrapeze());
        }

        private void mnuIsoscelesTrapezoid_Click(object sender, EventArgs e)
        {
            ShowFigureForm(new FrmIsoscelesTrapezoid());
        }

        private void mnuSquare_Click(object sender, EventArgs e)
        {
            ShowFigureForm(new FrmSquare());
        }

        private void mnuDeltoid_Click(object sender, EventArgs e)
        {
            ShowFigureForm(new FrmDeltoid());
        }

        private void mnuRhomboid_Click(object sender, EventArgs e)
        {
            ShowFigureForm(new FrmRhomboid());
        }

        private void mnuTrapezoid_Click(object sender, EventArgs e)
        {
            ShowFigureForm(new FrmTrapezoid());
        }

        private void mnuHeptagon_Click(object sender, EventArgs e)
        {
            ShowFigureForm(new FrmHeptagon());
        }

        private void mnuRhombus_Click(object sender, EventArgs e)
        {
            ShowFigureForm(new FrmRhombus());
        }

        private void mnuOctagon_Click(object sender, EventArgs e)
        {
            ShowFigureForm(new FrmOctagon());
        }

        private void mnuPentagon_Click(object sender, EventArgs e)
        {
            ShowFigureForm(new FrmPentagon());
        }

        private void mnuDecagon_Click(object sender, EventArgs e)
        {
            ShowFigureForm(new FrmDecagon());
        }

        private void mnuHexagon_Click(object sender, EventArgs e)
        {
            ShowFigureForm(new FrmHexagon());
        }

        private void mnuEnneagon_Click(object sender, EventArgs e)
        {
            ShowFigureForm(new FrmEnneagon());
        }

        private void mnuTriangle_Click(object sender, EventArgs e)
        {
            ShowFigureForm(new FrmTriangle());
        }
    }
}