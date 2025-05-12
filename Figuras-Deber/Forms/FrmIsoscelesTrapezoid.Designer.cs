namespace Figuras_Deber.Forms
{
    partial class FrmIsoscelesTrapezoid
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
            this.grbOutputs = new System.Windows.Forms.GroupBox();
            this.lblPerimeter = new System.Windows.Forms.Label();
            this.txtArea = new System.Windows.Forms.TextBox();
            this.lblArea = new System.Windows.Forms.Label();
            this.txtPerimeter = new System.Windows.Forms.TextBox();
            this.grbProcess = new System.Windows.Forms.GroupBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.grbCanvas = new System.Windows.Forms.GroupBox();
            this.picCanvas = new System.Windows.Forms.PictureBox();
            this.grbinputs = new System.Windows.Forms.GroupBox();
            this.lblLowerBase = new System.Windows.Forms.Label();
            this.txtLowerBase = new System.Windows.Forms.TextBox();
            this.lblHeigth = new System.Windows.Forms.Label();
            this.txtHeight = new System.Windows.Forms.TextBox();
            this.lblUpperBase = new System.Windows.Forms.Label();
            this.txtUpperBase = new System.Windows.Forms.TextBox();
            this.grbOutputs.SuspendLayout();
            this.grbProcess.SuspendLayout();
            this.grbCanvas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCanvas)).BeginInit();
            this.grbinputs.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbOutputs
            // 
            this.grbOutputs.Controls.Add(this.lblPerimeter);
            this.grbOutputs.Controls.Add(this.txtArea);
            this.grbOutputs.Controls.Add(this.lblArea);
            this.grbOutputs.Controls.Add(this.txtPerimeter);
            this.grbOutputs.Font = new System.Drawing.Font("Sans Serif Collection", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbOutputs.Location = new System.Drawing.Point(30, 308);
            this.grbOutputs.Name = "grbOutputs";
            this.grbOutputs.Size = new System.Drawing.Size(249, 126);
            this.grbOutputs.TabIndex = 23;
            this.grbOutputs.TabStop = false;
            this.grbOutputs.Text = "Salidas";
            // 
            // lblPerimeter
            // 
            this.lblPerimeter.AutoSize = true;
            this.lblPerimeter.Location = new System.Drawing.Point(27, 26);
            this.lblPerimeter.Name = "lblPerimeter";
            this.lblPerimeter.Size = new System.Drawing.Size(79, 37);
            this.lblPerimeter.TabIndex = 1;
            this.lblPerimeter.Text = "Perímetro";
            // 
            // txtArea
            // 
            this.txtArea.Enabled = false;
            this.txtArea.Location = new System.Drawing.Point(102, 65);
            this.txtArea.Multiline = true;
            this.txtArea.Name = "txtArea";
            this.txtArea.Size = new System.Drawing.Size(100, 35);
            this.txtArea.TabIndex = 4;
            // 
            // lblArea
            // 
            this.lblArea.AutoSize = true;
            this.lblArea.Location = new System.Drawing.Point(47, 63);
            this.lblArea.Name = "lblArea";
            this.lblArea.Size = new System.Drawing.Size(45, 37);
            this.lblArea.TabIndex = 2;
            this.lblArea.Text = "Área";
            // 
            // txtPerimeter
            // 
            this.txtPerimeter.Enabled = false;
            this.txtPerimeter.Location = new System.Drawing.Point(102, 26);
            this.txtPerimeter.Multiline = true;
            this.txtPerimeter.Name = "txtPerimeter";
            this.txtPerimeter.Size = new System.Drawing.Size(100, 33);
            this.txtPerimeter.TabIndex = 3;
            // 
            // grbProcess
            // 
            this.grbProcess.Controls.Add(this.btnExit);
            this.grbProcess.Controls.Add(this.btnReset);
            this.grbProcess.Controls.Add(this.btnCalculate);
            this.grbProcess.Font = new System.Drawing.Font("Sans Serif Collection", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbProcess.Location = new System.Drawing.Point(24, 190);
            this.grbProcess.Name = "grbProcess";
            this.grbProcess.Size = new System.Drawing.Size(260, 100);
            this.grbProcess.TabIndex = 22;
            this.grbProcess.TabStop = false;
            this.grbProcess.Text = "Procesos";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(174, 46);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 32);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Salir";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(87, 46);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(81, 32);
            this.btnReset.TabIndex = 1;
            this.btnReset.Text = "Resetear";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnCalculate
            // 
            this.btnCalculate.BackColor = System.Drawing.SystemColors.Control;
            this.btnCalculate.Location = new System.Drawing.Point(6, 46);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(75, 32);
            this.btnCalculate.TabIndex = 0;
            this.btnCalculate.Text = "Calcular";
            this.btnCalculate.UseVisualStyleBackColor = false;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // grbCanvas
            // 
            this.grbCanvas.Controls.Add(this.picCanvas);
            this.grbCanvas.Font = new System.Drawing.Font("Sans Serif Collection", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbCanvas.Location = new System.Drawing.Point(290, 25);
            this.grbCanvas.Name = "grbCanvas";
            this.grbCanvas.Size = new System.Drawing.Size(487, 409);
            this.grbCanvas.TabIndex = 21;
            this.grbCanvas.TabStop = false;
            this.grbCanvas.Text = "Gráfico";
            // 
            // picCanvas
            // 
            this.picCanvas.Location = new System.Drawing.Point(0, 19);
            this.picCanvas.Name = "picCanvas";
            this.picCanvas.Size = new System.Drawing.Size(481, 384);
            this.picCanvas.TabIndex = 0;
            this.picCanvas.TabStop = false;
            // 
            // grbinputs
            // 
            this.grbinputs.Controls.Add(this.lblLowerBase);
            this.grbinputs.Controls.Add(this.txtLowerBase);
            this.grbinputs.Controls.Add(this.lblHeigth);
            this.grbinputs.Controls.Add(this.txtHeight);
            this.grbinputs.Controls.Add(this.lblUpperBase);
            this.grbinputs.Controls.Add(this.txtUpperBase);
            this.grbinputs.Font = new System.Drawing.Font("Sans Serif Collection", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbinputs.Location = new System.Drawing.Point(24, 16);
            this.grbinputs.Name = "grbinputs";
            this.grbinputs.Size = new System.Drawing.Size(249, 168);
            this.grbinputs.TabIndex = 20;
            this.grbinputs.TabStop = false;
            this.grbinputs.Text = "Entrada";
            // 
            // lblLowerBase
            // 
            this.lblLowerBase.AutoSize = true;
            this.lblLowerBase.Location = new System.Drawing.Point(-1, 85);
            this.lblLowerBase.Name = "lblLowerBase";
            this.lblLowerBase.Size = new System.Drawing.Size(91, 37);
            this.lblLowerBase.TabIndex = 6;
            this.lblLowerBase.Text = "Base Menor:";
            // 
            // txtLowerBase
            // 
            this.txtLowerBase.Location = new System.Drawing.Point(108, 82);
            this.txtLowerBase.Name = "txtLowerBase";
            this.txtLowerBase.Size = new System.Drawing.Size(100, 37);
            this.txtLowerBase.TabIndex = 7;
            // 
            // lblHeigth
            // 
            this.lblHeigth.AutoSize = true;
            this.lblHeigth.Location = new System.Drawing.Point(53, 128);
            this.lblHeigth.Name = "lblHeigth";
            this.lblHeigth.Size = new System.Drawing.Size(58, 37);
            this.lblHeigth.TabIndex = 4;
            this.lblHeigth.Text = "ALtura";
            // 
            // txtHeight
            // 
            this.txtHeight.Location = new System.Drawing.Point(108, 125);
            this.txtHeight.Name = "txtHeight";
            this.txtHeight.Size = new System.Drawing.Size(100, 37);
            this.txtHeight.TabIndex = 5;
            // 
            // lblUpperBase
            // 
            this.lblUpperBase.AutoSize = true;
            this.lblUpperBase.Location = new System.Drawing.Point(6, 42);
            this.lblUpperBase.Name = "lblUpperBase";
            this.lblUpperBase.Size = new System.Drawing.Size(90, 37);
            this.lblUpperBase.TabIndex = 1;
            this.lblUpperBase.Text = "Base Mayor:";
            // 
            // txtUpperBase
            // 
            this.txtUpperBase.Location = new System.Drawing.Point(108, 39);
            this.txtUpperBase.Name = "txtUpperBase";
            this.txtUpperBase.Size = new System.Drawing.Size(100, 37);
            this.txtUpperBase.TabIndex = 3;
            // 
            // FrmIsoscelesTrapezoid
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grbOutputs);
            this.Controls.Add(this.grbProcess);
            this.Controls.Add(this.grbCanvas);
            this.Controls.Add(this.grbinputs);
            this.Name = "FrmIsoscelesTrapezoid";
            this.Text = "Trapecio (Isósceles)";
            this.Load += new System.EventHandler(this.FrmIsoscelesTrapezoid_Load);
            this.grbOutputs.ResumeLayout(false);
            this.grbOutputs.PerformLayout();
            this.grbProcess.ResumeLayout(false);
            this.grbCanvas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picCanvas)).EndInit();
            this.grbinputs.ResumeLayout(false);
            this.grbinputs.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbOutputs;
        private System.Windows.Forms.Label lblPerimeter;
        private System.Windows.Forms.TextBox txtArea;
        private System.Windows.Forms.Label lblArea;
        private System.Windows.Forms.TextBox txtPerimeter;
        private System.Windows.Forms.GroupBox grbProcess;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.GroupBox grbCanvas;
        private System.Windows.Forms.PictureBox picCanvas;
        private System.Windows.Forms.GroupBox grbinputs;
        private System.Windows.Forms.Label lblLowerBase;
        private System.Windows.Forms.TextBox txtLowerBase;
        private System.Windows.Forms.Label lblHeigth;
        private System.Windows.Forms.TextBox txtHeight;
        private System.Windows.Forms.Label lblUpperBase;
        private System.Windows.Forms.TextBox txtUpperBase;
    }
}