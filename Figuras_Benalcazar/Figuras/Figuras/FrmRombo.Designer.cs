﻿namespace Figuras
{
    partial class FrmRombo
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
            this.grbInputs = new System.Windows.Forms.GroupBox();
            this.lblHeight = new System.Windows.Forms.Label();
            this.txtSide = new System.Windows.Forms.TextBox();
            this.txtDiagMn = new System.Windows.Forms.TextBox();
            this.txtDiagMy = new System.Windows.Forms.TextBox();
            this.lblDiagMn = new System.Windows.Forms.Label();
            this.lblDiagMy = new System.Windows.Forms.Label();
            this.grbProcess = new System.Windows.Forms.GroupBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.grbOutputs = new System.Windows.Forms.GroupBox();
            this.txtArea = new System.Windows.Forms.TextBox();
            this.txtPerimeter = new System.Windows.Forms.TextBox();
            this.lblArea = new System.Windows.Forms.Label();
            this.lblPerimeter = new System.Windows.Forms.Label();
            this.grbInputs.SuspendLayout();
            this.grbProcess.SuspendLayout();
            this.grbOutputs.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbInputs
            // 
            this.grbInputs.Controls.Add(this.lblHeight);
            this.grbInputs.Controls.Add(this.txtSide);
            this.grbInputs.Controls.Add(this.txtDiagMn);
            this.grbInputs.Controls.Add(this.txtDiagMy);
            this.grbInputs.Controls.Add(this.lblDiagMn);
            this.grbInputs.Controls.Add(this.lblDiagMy);
            this.grbInputs.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbInputs.Location = new System.Drawing.Point(17, 18);
            this.grbInputs.Name = "grbInputs";
            this.grbInputs.Size = new System.Drawing.Size(291, 151);
            this.grbInputs.TabIndex = 7;
            this.grbInputs.TabStop = false;
            this.grbInputs.Text = "Entradas";
            // 
            // lblHeight
            // 
            this.lblHeight.AutoSize = true;
            this.lblHeight.Location = new System.Drawing.Point(22, 113);
            this.lblHeight.Name = "lblHeight";
            this.lblHeight.Size = new System.Drawing.Size(49, 17);
            this.lblHeight.TabIndex = 1;
            this.lblHeight.Text = "Lado:";
            // 
            // txtSide
            // 
            this.txtSide.Location = new System.Drawing.Point(146, 113);
            this.txtSide.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSide.Name = "txtSide";
            this.txtSide.Size = new System.Drawing.Size(100, 23);
            this.txtSide.TabIndex = 1;
            // 
            // txtDiagMn
            // 
            this.txtDiagMn.Location = new System.Drawing.Point(146, 72);
            this.txtDiagMn.Name = "txtDiagMn";
            this.txtDiagMn.Size = new System.Drawing.Size(100, 23);
            this.txtDiagMn.TabIndex = 3;
            // 
            // txtDiagMy
            // 
            this.txtDiagMy.Location = new System.Drawing.Point(146, 31);
            this.txtDiagMy.Name = "txtDiagMy";
            this.txtDiagMy.Size = new System.Drawing.Size(100, 23);
            this.txtDiagMy.TabIndex = 2;
            // 
            // lblDiagMn
            // 
            this.lblDiagMn.AutoSize = true;
            this.lblDiagMn.Location = new System.Drawing.Point(22, 72);
            this.lblDiagMn.Name = "lblDiagMn";
            this.lblDiagMn.Size = new System.Drawing.Size(122, 17);
            this.lblDiagMn.TabIndex = 1;
            this.lblDiagMn.Text = "Diagonal Menor";
            // 
            // lblDiagMy
            // 
            this.lblDiagMy.AutoSize = true;
            this.lblDiagMy.Location = new System.Drawing.Point(22, 36);
            this.lblDiagMy.Name = "lblDiagMy";
            this.lblDiagMy.Size = new System.Drawing.Size(121, 17);
            this.lblDiagMy.TabIndex = 0;
            this.lblDiagMy.Text = "Diagonal Mayor";
            // 
            // grbProcess
            // 
            this.grbProcess.Controls.Add(this.btnExit);
            this.grbProcess.Controls.Add(this.btnReset);
            this.grbProcess.Controls.Add(this.btnCalculate);
            this.grbProcess.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbProcess.Location = new System.Drawing.Point(17, 186);
            this.grbProcess.Name = "grbProcess";
            this.grbProcess.Size = new System.Drawing.Size(291, 96);
            this.grbProcess.TabIndex = 9;
            this.grbProcess.TabStop = false;
            this.grbProcess.Text = "Proceso";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(201, 45);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Salir";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(99, 45);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(96, 23);
            this.btnReset.TabIndex = 1;
            this.btnReset.Text = "Resetear";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(6, 45);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(87, 23);
            this.btnCalculate.TabIndex = 0;
            this.btnCalculate.Text = "Calcular";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // grbOutputs
            // 
            this.grbOutputs.Controls.Add(this.txtArea);
            this.grbOutputs.Controls.Add(this.txtPerimeter);
            this.grbOutputs.Controls.Add(this.lblArea);
            this.grbOutputs.Controls.Add(this.lblPerimeter);
            this.grbOutputs.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbOutputs.Location = new System.Drawing.Point(364, 90);
            this.grbOutputs.Name = "grbOutputs";
            this.grbOutputs.Size = new System.Drawing.Size(291, 151);
            this.grbOutputs.TabIndex = 10;
            this.grbOutputs.TabStop = false;
            this.grbOutputs.Text = "Salidas";
            // 
            // txtArea
            // 
            this.txtArea.Enabled = false;
            this.txtArea.Location = new System.Drawing.Point(123, 93);
            this.txtArea.Name = "txtArea";
            this.txtArea.Size = new System.Drawing.Size(100, 23);
            this.txtArea.TabIndex = 3;
            // 
            // txtPerimeter
            // 
            this.txtPerimeter.Enabled = false;
            this.txtPerimeter.Location = new System.Drawing.Point(123, 45);
            this.txtPerimeter.Name = "txtPerimeter";
            this.txtPerimeter.Size = new System.Drawing.Size(100, 23);
            this.txtPerimeter.TabIndex = 2;
            // 
            // lblArea
            // 
            this.lblArea.AutoSize = true;
            this.lblArea.Location = new System.Drawing.Point(25, 99);
            this.lblArea.Name = "lblArea";
            this.lblArea.Size = new System.Drawing.Size(42, 17);
            this.lblArea.TabIndex = 1;
            this.lblArea.Text = "Área";
            // 
            // lblPerimeter
            // 
            this.lblPerimeter.AutoSize = true;
            this.lblPerimeter.Location = new System.Drawing.Point(25, 45);
            this.lblPerimeter.Name = "lblPerimeter";
            this.lblPerimeter.Size = new System.Drawing.Size(78, 17);
            this.lblPerimeter.TabIndex = 0;
            this.lblPerimeter.Text = "Perímetro";
            // 
            // FrmRombo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(695, 298);
            this.Controls.Add(this.grbOutputs);
            this.Controls.Add(this.grbProcess);
            this.Controls.Add(this.grbInputs);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximumSize = new System.Drawing.Size(713, 345);
            this.MinimumSize = new System.Drawing.Size(713, 345);
            this.Name = "FrmRombo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmRombo";
            this.grbInputs.ResumeLayout(false);
            this.grbInputs.PerformLayout();
            this.grbProcess.ResumeLayout(false);
            this.grbOutputs.ResumeLayout(false);
            this.grbOutputs.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbInputs;
        private System.Windows.Forms.Label lblHeight;
        private System.Windows.Forms.TextBox txtSide;
        private System.Windows.Forms.TextBox txtDiagMn;
        private System.Windows.Forms.TextBox txtDiagMy;
        private System.Windows.Forms.Label lblDiagMn;
        private System.Windows.Forms.Label lblDiagMy;
        private System.Windows.Forms.GroupBox grbProcess;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.GroupBox grbOutputs;
        private System.Windows.Forms.TextBox txtArea;
        private System.Windows.Forms.TextBox txtPerimeter;
        private System.Windows.Forms.Label lblArea;
        private System.Windows.Forms.Label lblPerimeter;
    }
}