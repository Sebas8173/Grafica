namespace Figuras
{
    partial class FrmTrapecio
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
            this.txtBase = new System.Windows.Forms.TextBox();
            this.lblBase = new System.Windows.Forms.Label();
            this.txtHeight = new System.Windows.Forms.TextBox();
            this.lblHeight = new System.Windows.Forms.Label();
            this.txtSideB = new System.Windows.Forms.TextBox();
            this.txtSideA = new System.Windows.Forms.TextBox();
            this.lblSideB = new System.Windows.Forms.Label();
            this.lblSideA = new System.Windows.Forms.Label();
            this.grbOutputs = new System.Windows.Forms.GroupBox();
            this.txtArea = new System.Windows.Forms.TextBox();
            this.txtPerimeter = new System.Windows.Forms.TextBox();
            this.lblArea = new System.Windows.Forms.Label();
            this.lblPerimeter = new System.Windows.Forms.Label();
            this.grbProcess = new System.Windows.Forms.GroupBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.grbInputs.SuspendLayout();
            this.grbOutputs.SuspendLayout();
            this.grbProcess.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbInputs
            // 
            this.grbInputs.Controls.Add(this.txtBase);
            this.grbInputs.Controls.Add(this.lblBase);
            this.grbInputs.Controls.Add(this.txtHeight);
            this.grbInputs.Controls.Add(this.lblHeight);
            this.grbInputs.Controls.Add(this.txtSideB);
            this.grbInputs.Controls.Add(this.txtSideA);
            this.grbInputs.Controls.Add(this.lblSideB);
            this.grbInputs.Controls.Add(this.lblSideA);
            this.grbInputs.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbInputs.Location = new System.Drawing.Point(36, 10);
            this.grbInputs.Name = "grbInputs";
            this.grbInputs.Size = new System.Drawing.Size(291, 176);
            this.grbInputs.TabIndex = 9;
            this.grbInputs.TabStop = false;
            this.grbInputs.Text = "Entradas";
            // 
            // txtBase
            // 
            this.txtBase.Location = new System.Drawing.Point(150, 138);
            this.txtBase.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBase.Name = "txtBase";
            this.txtBase.Size = new System.Drawing.Size(100, 23);
            this.txtBase.TabIndex = 1;
            // 
            // lblBase
            // 
            this.lblBase.AutoSize = true;
            this.lblBase.Location = new System.Drawing.Point(22, 138);
            this.lblBase.Name = "lblBase";
            this.lblBase.Size = new System.Drawing.Size(98, 17);
            this.lblBase.TabIndex = 1;
            this.lblBase.Text = "Base Mayor:";
            // 
            // txtHeight
            // 
            this.txtHeight.Location = new System.Drawing.Point(150, 103);
            this.txtHeight.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtHeight.Name = "txtHeight";
            this.txtHeight.Size = new System.Drawing.Size(100, 23);
            this.txtHeight.TabIndex = 1;
            // 
            // lblHeight
            // 
            this.lblHeight.AutoSize = true;
            this.lblHeight.Location = new System.Drawing.Point(22, 70);
            this.lblHeight.Name = "lblHeight";
            this.lblHeight.Size = new System.Drawing.Size(56, 17);
            this.lblHeight.TabIndex = 1;
            this.lblHeight.Text = "Altura:";
            this.lblHeight.Click += new System.EventHandler(this.lblDiagMn_Click);
            // 
            // txtSideB
            // 
            this.txtSideB.Location = new System.Drawing.Point(150, 67);
            this.txtSideB.Name = "txtSideB";
            this.txtSideB.Size = new System.Drawing.Size(100, 23);
            this.txtSideB.TabIndex = 3;
            // 
            // txtSideA
            // 
            this.txtSideA.Location = new System.Drawing.Point(150, 36);
            this.txtSideA.Name = "txtSideA";
            this.txtSideA.Size = new System.Drawing.Size(100, 23);
            this.txtSideA.TabIndex = 2;
            // 
            // lblSideB
            // 
            this.lblSideB.AutoSize = true;
            this.lblSideB.Location = new System.Drawing.Point(20, 108);
            this.lblSideB.Name = "lblSideB";
            this.lblSideB.Size = new System.Drawing.Size(99, 17);
            this.lblSideB.TabIndex = 1;
            this.lblSideB.Text = "Base Menor:";
            // 
            // lblSideA
            // 
            this.lblSideA.AutoSize = true;
            this.lblSideA.Location = new System.Drawing.Point(22, 36);
            this.lblSideA.Name = "lblSideA";
            this.lblSideA.Size = new System.Drawing.Size(49, 17);
            this.lblSideA.TabIndex = 0;
            this.lblSideA.Text = "Lado:";
            // 
            // grbOutputs
            // 
            this.grbOutputs.Controls.Add(this.txtArea);
            this.grbOutputs.Controls.Add(this.txtPerimeter);
            this.grbOutputs.Controls.Add(this.lblArea);
            this.grbOutputs.Controls.Add(this.lblPerimeter);
            this.grbOutputs.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbOutputs.Location = new System.Drawing.Point(371, 78);
            this.grbOutputs.Name = "grbOutputs";
            this.grbOutputs.Size = new System.Drawing.Size(291, 151);
            this.grbOutputs.TabIndex = 11;
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
            this.lblArea.Location = new System.Drawing.Point(22, 93);
            this.lblArea.Name = "lblArea";
            this.lblArea.Size = new System.Drawing.Size(42, 17);
            this.lblArea.TabIndex = 1;
            this.lblArea.Text = "Área";
            // 
            // lblPerimeter
            // 
            this.lblPerimeter.AutoSize = true;
            this.lblPerimeter.Location = new System.Drawing.Point(22, 45);
            this.lblPerimeter.Name = "lblPerimeter";
            this.lblPerimeter.Size = new System.Drawing.Size(78, 17);
            this.lblPerimeter.TabIndex = 0;
            this.lblPerimeter.Text = "Perímetro";
            // 
            // grbProcess
            // 
            this.grbProcess.Controls.Add(this.btnExit);
            this.grbProcess.Controls.Add(this.btnReset);
            this.grbProcess.Controls.Add(this.btnCalculate);
            this.grbProcess.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbProcess.Location = new System.Drawing.Point(36, 204);
            this.grbProcess.Name = "grbProcess";
            this.grbProcess.Size = new System.Drawing.Size(291, 96);
            this.grbProcess.TabIndex = 12;
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
            // FrmTrapecio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(695, 298);
            this.Controls.Add(this.grbProcess);
            this.Controls.Add(this.grbOutputs);
            this.Controls.Add(this.grbInputs);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximumSize = new System.Drawing.Size(713, 345);
            this.MinimumSize = new System.Drawing.Size(713, 345);
            this.Name = "FrmTrapecio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmTrapecio";
            this.grbInputs.ResumeLayout(false);
            this.grbInputs.PerformLayout();
            this.grbOutputs.ResumeLayout(false);
            this.grbOutputs.PerformLayout();
            this.grbProcess.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox grbInputs;
        private System.Windows.Forms.TextBox txtHeight;
        private System.Windows.Forms.Label lblHeight;
        private System.Windows.Forms.TextBox txtSideB;
        private System.Windows.Forms.TextBox txtSideA;
        private System.Windows.Forms.Label lblSideB;
        private System.Windows.Forms.Label lblSideA;
        private System.Windows.Forms.GroupBox grbOutputs;
        private System.Windows.Forms.TextBox txtArea;
        private System.Windows.Forms.TextBox txtPerimeter;
        private System.Windows.Forms.Label lblArea;
        private System.Windows.Forms.Label lblPerimeter;
        private System.Windows.Forms.GroupBox grbProcess;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.TextBox txtBase;
        private System.Windows.Forms.Label lblBase;
    }
}