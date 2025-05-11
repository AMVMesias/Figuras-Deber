namespace Figuras_Deber
{
    partial class FrmHome
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuFigura = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCircle = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuEllipse = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuOval = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuRectangle = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTrapeze = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuIsoscelesTrapezoid = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSquare = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDeltoid = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuRhomboid = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mnuTrapezoid = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHeptagon = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuRhombus = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuOctagon = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuPentagon = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDecagon = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHexagon = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuEnneagon = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(311, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(285, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Figuras Geometricas";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFigura});
            this.menuStrip1.Location = new System.Drawing.Point(51, 82);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(183, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnuFigura
            // 
            this.mnuFigura.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuCircle,
            this.mnuEllipse,
            this.mnuOval,
            this.mnuRectangle,
            this.mnuTrapeze,
            this.mnuIsoscelesTrapezoid,
            this.mnuSquare,
            this.mnuDeltoid,
            this.mnuRhomboid,
            this.mnuTrapezoid,
            this.mnuHeptagon,
            this.mnuRhombus,
            this.mnuOctagon,
            this.mnuPentagon,
            this.mnuDecagon,
            this.mnuHexagon,
            this.mnuEnneagon});
            this.mnuFigura.Name = "mnuFigura";
            this.mnuFigura.Size = new System.Drawing.Size(55, 20);
            this.mnuFigura.Text = "Figura:";
            this.mnuFigura.Click += new System.EventHandler(this.mnuFigura_Click);
            // 
            // mnuCircle
            // 
            this.mnuCircle.Name = "mnuCircle";
            this.mnuCircle.Size = new System.Drawing.Size(180, 22);
            this.mnuCircle.Text = "Círculo";
            this.mnuCircle.Click += new System.EventHandler(this.mnuCircle_Click);
            // 
            // mnuEllipse
            // 
            this.mnuEllipse.Name = "mnuEllipse";
            this.mnuEllipse.Size = new System.Drawing.Size(180, 22);
            this.mnuEllipse.Text = "Elipse";
            this.mnuEllipse.Click += new System.EventHandler(this.mnuEllipse_Click);
            // 
            // mnuOval
            // 
            this.mnuOval.Name = "mnuOval";
            this.mnuOval.Size = new System.Drawing.Size(180, 22);
            this.mnuOval.Text = "Óvalo";
            this.mnuOval.Click += new System.EventHandler(this.mnuOval_Click);
            // 
            // mnuRectangle
            // 
            this.mnuRectangle.Name = "mnuRectangle";
            this.mnuRectangle.Size = new System.Drawing.Size(180, 22);
            this.mnuRectangle.Text = "Rectángulo";
            this.mnuRectangle.Click += new System.EventHandler(this.mnuRectangle_Click);
            // 
            // mnuTrapeze
            // 
            this.mnuTrapeze.Name = "mnuTrapeze";
            this.mnuTrapeze.Size = new System.Drawing.Size(180, 22);
            this.mnuTrapeze.Text = "Trapecio";
            this.mnuTrapeze.Click += new System.EventHandler(this.mnuTrapeze_Click);
            // 
            // mnuIsoscelesTrapezoid
            // 
            this.mnuIsoscelesTrapezoid.Name = "mnuIsoscelesTrapezoid";
            this.mnuIsoscelesTrapezoid.Size = new System.Drawing.Size(180, 22);
            this.mnuIsoscelesTrapezoid.Text = "Trapecio Isóceles";
            this.mnuIsoscelesTrapezoid.Click += new System.EventHandler(this.mnuIsoscelesTrapezoid_Click);
            // 
            // mnuSquare
            // 
            this.mnuSquare.Name = "mnuSquare";
            this.mnuSquare.Size = new System.Drawing.Size(180, 22);
            this.mnuSquare.Text = "Cuadrado";
            this.mnuSquare.Click += new System.EventHandler(this.mnuSquare_Click);
            // 
            // mnuDeltoid
            // 
            this.mnuDeltoid.Name = "mnuDeltoid";
            this.mnuDeltoid.Size = new System.Drawing.Size(180, 22);
            this.mnuDeltoid.Text = "Deltoide";
            this.mnuDeltoid.Click += new System.EventHandler(this.mnuDeltoid_Click);
            // 
            // mnuRhomboid
            // 
            this.mnuRhomboid.Name = "mnuRhomboid";
            this.mnuRhomboid.Size = new System.Drawing.Size(180, 22);
            this.mnuRhomboid.Text = "Romboide";
            this.mnuRhomboid.Click += new System.EventHandler(this.mnuRhomboid_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // mnuTrapezoid
            // 
            this.mnuTrapezoid.Name = "mnuTrapezoid";
            this.mnuTrapezoid.Size = new System.Drawing.Size(180, 22);
            this.mnuTrapezoid.Text = "Trapezoide";
            this.mnuTrapezoid.Click += new System.EventHandler(this.mnuTrapezoid_Click);
            // 
            // mnuHeptagon
            // 
            this.mnuHeptagon.Name = "mnuHeptagon";
            this.mnuHeptagon.Size = new System.Drawing.Size(180, 22);
            this.mnuHeptagon.Text = "Heptágono";
            this.mnuHeptagon.Click += new System.EventHandler(this.mnuHeptagon_Click);
            // 
            // mnuRhombus
            // 
            this.mnuRhombus.Name = "mnuRhombus";
            this.mnuRhombus.Size = new System.Drawing.Size(180, 22);
            this.mnuRhombus.Text = "Rombo";
            this.mnuRhombus.Click += new System.EventHandler(this.mnuRhombus_Click);
            // 
            // mnuOctagon
            // 
            this.mnuOctagon.Name = "mnuOctagon";
            this.mnuOctagon.Size = new System.Drawing.Size(180, 22);
            this.mnuOctagon.Text = "Octágono";
            this.mnuOctagon.Click += new System.EventHandler(this.mnuOctagon_Click);
            // 
            // mnuPentagon
            // 
            this.mnuPentagon.Name = "mnuPentagon";
            this.mnuPentagon.Size = new System.Drawing.Size(180, 22);
            this.mnuPentagon.Text = "Pentágono";
            this.mnuPentagon.Click += new System.EventHandler(this.mnuPentagon_Click);
            // 
            // mnuDecagon
            // 
            this.mnuDecagon.Name = "mnuDecagon";
            this.mnuDecagon.Size = new System.Drawing.Size(180, 22);
            this.mnuDecagon.Text = "Decágono";
            this.mnuDecagon.Click += new System.EventHandler(this.mnuDecagon_Click);
            // 
            // mnuHexagon
            // 
            this.mnuHexagon.Name = "mnuHexagon";
            this.mnuHexagon.Size = new System.Drawing.Size(180, 22);
            this.mnuHexagon.Text = "Hexágono";
            this.mnuHexagon.Click += new System.EventHandler(this.mnuHexagon_Click);
            // 
            // mnuEnneagon
            // 
            this.mnuEnneagon.Name = "mnuEnneagon";
            this.mnuEnneagon.Size = new System.Drawing.Size(180, 22);
            this.mnuEnneagon.Text = "Eneágono";
            this.mnuEnneagon.Click += new System.EventHandler(this.mnuEnneagon_Click);
            // 
            // FrmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(915, 647);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmHome";
            this.Text = "home";
            this.Load += new System.EventHandler(this.FrmHome_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuFigura;
        private System.Windows.Forms.ToolStripMenuItem mnuCircle;
        private System.Windows.Forms.ToolStripMenuItem mnuEllipse;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuOval;
        private System.Windows.Forms.ToolStripMenuItem mnuRectangle;
        private System.Windows.Forms.ToolStripMenuItem mnuTrapeze;
        private System.Windows.Forms.ToolStripMenuItem mnuIsoscelesTrapezoid;
        private System.Windows.Forms.ToolStripMenuItem mnuSquare;
        private System.Windows.Forms.ToolStripMenuItem mnuDeltoid;
        private System.Windows.Forms.ToolStripMenuItem mnuRhomboid;
        private System.Windows.Forms.ToolStripMenuItem mnuTrapezoid;
        private System.Windows.Forms.ToolStripMenuItem mnuHeptagon;
        private System.Windows.Forms.ToolStripMenuItem mnuRhombus;
        private System.Windows.Forms.ToolStripMenuItem mnuOctagon;
        private System.Windows.Forms.ToolStripMenuItem mnuPentagon;
        private System.Windows.Forms.ToolStripMenuItem mnuDecagon;
        private System.Windows.Forms.ToolStripMenuItem mnuHexagon;
        private System.Windows.Forms.ToolStripMenuItem mnuEnneagon;
    }
}