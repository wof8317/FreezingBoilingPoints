
namespace FreezingBoilingPoints
{
    partial class Form1
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
            this.btnShowEffect = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.txtBoxEthyl = new System.Windows.Forms.TextBox();
            this.txtBoxMercury = new System.Windows.Forms.TextBox();
            this.txtBoxOxygen = new System.Windows.Forms.TextBox();
            this.txtBoxWater = new System.Windows.Forms.TextBox();
            this.lblEthylAlcohol = new System.Windows.Forms.Label();
            this.lblMercury = new System.Windows.Forms.Label();
            this.lblOxygen = new System.Windows.Forms.Label();
            this.lblWater = new System.Windows.Forms.Label();
            this.txtBoxInput = new System.Windows.Forms.TextBox();
            this.lblTempCommand = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnShowEffect
            // 
            this.btnShowEffect.Location = new System.Drawing.Point(60, 191);
            this.btnShowEffect.Name = "btnShowEffect";
            this.btnShowEffect.Size = new System.Drawing.Size(75, 23);
            this.btnShowEffect.TabIndex = 0;
            this.btnShowEffect.Text = "Show Effect";
            this.btnShowEffect.UseVisualStyleBackColor = true;
            this.btnShowEffect.Click += new System.EventHandler(this.btnShowEffect_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(60, 220);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 1;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(60, 249);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // txtBoxEthyl
            // 
            this.txtBoxEthyl.Enabled = false;
            this.txtBoxEthyl.Location = new System.Drawing.Point(425, 154);
            this.txtBoxEthyl.Name = "txtBoxEthyl";
            this.txtBoxEthyl.Size = new System.Drawing.Size(100, 20);
            this.txtBoxEthyl.TabIndex = 3;
            // 
            // txtBoxMercury
            // 
            this.txtBoxMercury.Enabled = false;
            this.txtBoxMercury.Location = new System.Drawing.Point(425, 193);
            this.txtBoxMercury.Name = "txtBoxMercury";
            this.txtBoxMercury.Size = new System.Drawing.Size(100, 20);
            this.txtBoxMercury.TabIndex = 4;
            // 
            // txtBoxOxygen
            // 
            this.txtBoxOxygen.Enabled = false;
            this.txtBoxOxygen.Location = new System.Drawing.Point(425, 232);
            this.txtBoxOxygen.Name = "txtBoxOxygen";
            this.txtBoxOxygen.Size = new System.Drawing.Size(100, 20);
            this.txtBoxOxygen.TabIndex = 5;
            // 
            // txtBoxWater
            // 
            this.txtBoxWater.Enabled = false;
            this.txtBoxWater.Location = new System.Drawing.Point(425, 268);
            this.txtBoxWater.Name = "txtBoxWater";
            this.txtBoxWater.Size = new System.Drawing.Size(100, 20);
            this.txtBoxWater.TabIndex = 6;
            // 
            // lblEthylAlcohol
            // 
            this.lblEthylAlcohol.AutoSize = true;
            this.lblEthylAlcohol.Location = new System.Drawing.Point(346, 157);
            this.lblEthylAlcohol.Name = "lblEthylAlcohol";
            this.lblEthylAlcohol.Size = new System.Drawing.Size(68, 13);
            this.lblEthylAlcohol.TabIndex = 7;
            this.lblEthylAlcohol.Text = "Ethyl Alcohol";
            // 
            // lblMercury
            // 
            this.lblMercury.AutoSize = true;
            this.lblMercury.Location = new System.Drawing.Point(346, 196);
            this.lblMercury.Name = "lblMercury";
            this.lblMercury.Size = new System.Drawing.Size(45, 13);
            this.lblMercury.TabIndex = 8;
            this.lblMercury.Text = "Mercury";
            // 
            // lblOxygen
            // 
            this.lblOxygen.AutoSize = true;
            this.lblOxygen.Location = new System.Drawing.Point(346, 235);
            this.lblOxygen.Name = "lblOxygen";
            this.lblOxygen.Size = new System.Drawing.Size(43, 13);
            this.lblOxygen.TabIndex = 9;
            this.lblOxygen.Text = "Oxygen";
            // 
            // lblWater
            // 
            this.lblWater.AutoSize = true;
            this.lblWater.Location = new System.Drawing.Point(346, 271);
            this.lblWater.Name = "lblWater";
            this.lblWater.Size = new System.Drawing.Size(36, 13);
            this.lblWater.TabIndex = 10;
            this.lblWater.Text = "Water";
            // 
            // txtBoxInput
            // 
            this.txtBoxInput.Location = new System.Drawing.Point(425, 96);
            this.txtBoxInput.Name = "txtBoxInput";
            this.txtBoxInput.Size = new System.Drawing.Size(100, 20);
            this.txtBoxInput.TabIndex = 11;
            // 
            // lblTempCommand
            // 
            this.lblTempCommand.AutoSize = true;
            this.lblTempCommand.Location = new System.Drawing.Point(374, 59);
            this.lblTempCommand.Name = "lblTempCommand";
            this.lblTempCommand.Size = new System.Drawing.Size(151, 13);
            this.lblTempCommand.TabIndex = 12;
            this.lblTempCommand.Text = "Enter a Farenheit Temperature";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblTempCommand);
            this.Controls.Add(this.txtBoxInput);
            this.Controls.Add(this.lblWater);
            this.Controls.Add(this.lblOxygen);
            this.Controls.Add(this.lblMercury);
            this.Controls.Add(this.lblEthylAlcohol);
            this.Controls.Add(this.txtBoxWater);
            this.Controls.Add(this.txtBoxOxygen);
            this.Controls.Add(this.txtBoxMercury);
            this.Controls.Add(this.txtBoxEthyl);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnShowEffect);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FreezingBoilingPoints";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnShowEffect;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TextBox txtBoxEthyl;
        private System.Windows.Forms.TextBox txtBoxMercury;
        private System.Windows.Forms.TextBox txtBoxOxygen;
        private System.Windows.Forms.TextBox txtBoxWater;
        private System.Windows.Forms.Label lblEthylAlcohol;
        private System.Windows.Forms.Label lblMercury;
        private System.Windows.Forms.Label lblOxygen;
        private System.Windows.Forms.Label lblWater;
        private System.Windows.Forms.TextBox txtBoxInput;
        private System.Windows.Forms.Label lblTempCommand;
    }
}

