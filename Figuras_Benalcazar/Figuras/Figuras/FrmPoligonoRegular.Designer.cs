namespace Figuras
{
    partial class FrmPoligonoRegular
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
            this.lblApotema = new System.Windows.Forms.Label();
            this.txtApotema = new System.Windows.Forms.TextBox();
            this.txtNumber = new System.Windows.Forms.TextBox();
            this.txtSide = new System.Windows.Forms.TextBox();
            this.lblSide = new System.Windows.Forms.Label();
            this.lblNumer = new System.Windows.Forms.Label();
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
            this.grbInputs.Controls.Add(this.lblApotema);
            this.grbInputs.Controls.Add(this.txtApotema);
            this.grbInputs.Controls.Add(this.txtNumber);
            this.grbInputs.Controls.Add(this.txtSide);
            this.grbInputs.Controls.Add(this.lblSide);
            this.grbInputs.Controls.Add(this.lblNumer);
            this.grbInputs.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbInputs.Location = new System.Drawing.Point(11, 27);
            this.grbInputs.Name = "grbInputs";
            this.grbInputs.Size = new System.Drawing.Size(291, 151);
            this.grbInputs.TabIndex = 7;
            this.grbInputs.TabStop = false;
            this.grbInputs.Text = "Entradas";
            // 
            // lblApotema
            // 
            this.lblApotema.AutoSize = true;
            this.lblApotema.Location = new System.Drawing.Point(22, 113);
            this.lblApotema.Name = "lblApotema";
            this.lblApotema.Size = new System.Drawing.Size(76, 17);
            this.lblApotema.TabIndex = 1;
            this.lblApotema.Text = "Apotema:";
            // 
            // txtApotema
            // 
            this.txtApotema.Location = new System.Drawing.Point(161, 113);
            this.txtApotema.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtApotema.Name = "txtApotema";
            this.txtApotema.Size = new System.Drawing.Size(100, 23);
            this.txtApotema.TabIndex = 1;
            // 
            // txtNumber
            // 
            this.txtNumber.Location = new System.Drawing.Point(161, 72);
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Size = new System.Drawing.Size(100, 23);
            this.txtNumber.TabIndex = 3;
            // 
            // txtSide
            // 
            this.txtSide.Location = new System.Drawing.Point(161, 34);
            this.txtSide.Name = "txtSide";
            this.txtSide.Size = new System.Drawing.Size(100, 23);
            this.txtSide.TabIndex = 2;
            // 
            // lblSide
            // 
            this.lblSide.AutoSize = true;
            this.lblSide.Location = new System.Drawing.Point(25, 34);
            this.lblSide.Name = "lblSide";
            this.lblSide.Size = new System.Drawing.Size(107, 17);
            this.lblSide.TabIndex = 1;
            this.lblSide.Text = "Tamaño Lado";
            // 
            // lblNumer
            // 
            this.lblNumer.AutoSize = true;
            this.lblNumer.Location = new System.Drawing.Point(22, 72);
            this.lblNumer.Name = "lblNumer";
            this.lblNumer.Size = new System.Drawing.Size(136, 17);
            this.lblNumer.TabIndex = 0;
            this.lblNumer.Text = "Numero de Lados";
            // 
            // grbProcess
            // 
            this.grbProcess.Controls.Add(this.btnExit);
            this.grbProcess.Controls.Add(this.btnReset);
            this.grbProcess.Controls.Add(this.btnCalculate);
            this.grbProcess.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbProcess.Location = new System.Drawing.Point(11, 193);
            this.grbProcess.Name = "grbProcess";
            this.grbProcess.Size = new System.Drawing.Size(291, 96);
            this.grbProcess.TabIndex = 8;
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
            this.grbOutputs.Location = new System.Drawing.Point(350, 83);
            this.grbOutputs.Name = "grbOutputs";
            this.grbOutputs.Size = new System.Drawing.Size(291, 151);
            this.grbOutputs.TabIndex = 9;
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
            // FrmPoligonoRegular
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(695, 298);
            this.Controls.Add(this.grbOutputs);
            this.Controls.Add(this.grbProcess);
            this.Controls.Add(this.grbInputs);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximumSize = new System.Drawing.Size(713, 345);
            this.MinimumSize = new System.Drawing.Size(713, 345);
            this.Name = "FrmPoligonoRegular";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmPoligonoRegular";
            this.grbInputs.ResumeLayout(false);
            this.grbInputs.PerformLayout();
            this.grbProcess.ResumeLayout(false);
            this.grbOutputs.ResumeLayout(false);
            this.grbOutputs.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox grbInputs;
        private System.Windows.Forms.Label lblApotema;
        private System.Windows.Forms.TextBox txtApotema;
        private System.Windows.Forms.TextBox txtNumber;
        private System.Windows.Forms.TextBox txtSide;
        private System.Windows.Forms.Label lblSide;
        private System.Windows.Forms.Label lblNumer;
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