namespace CupsToOuncesBrady
{
    partial class CupsToOuncesForm
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblOuncesStatic = new System.Windows.Forms.Label();
            this.lblCupsStatic = new System.Windows.Forms.Label();
            this.btnConvert = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblOuncesOutput = new System.Windows.Forms.Label();
            this.txtCupsInput = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(32, 25);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(239, 17);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Cups to Fluid Ounces Converter";
            // 
            // lblOuncesStatic
            // 
            this.lblOuncesStatic.AutoSize = true;
            this.lblOuncesStatic.Location = new System.Drawing.Point(19, 125);
            this.lblOuncesStatic.Name = "lblOuncesStatic";
            this.lblOuncesStatic.Size = new System.Drawing.Size(95, 17);
            this.lblOuncesStatic.TabIndex = 1;
            this.lblOuncesStatic.Text = "Fluid Ounces:";
            // 
            // lblCupsStatic
            // 
            this.lblCupsStatic.AutoSize = true;
            this.lblCupsStatic.Location = new System.Drawing.Point(70, 72);
            this.lblCupsStatic.Name = "lblCupsStatic";
            this.lblCupsStatic.Size = new System.Drawing.Size(44, 17);
            this.lblCupsStatic.TabIndex = 2;
            this.lblCupsStatic.Text = "Cups:";
            // 
            // btnConvert
            // 
            this.btnConvert.Location = new System.Drawing.Point(39, 175);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(75, 23);
            this.btnConvert.TabIndex = 3;
            this.btnConvert.Text = "&Convert";
            this.btnConvert.UseVisualStyleBackColor = true;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Location = new System.Drawing.Point(160, 175);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "&Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblOuncesOutput
            // 
            this.lblOuncesOutput.AutoSize = true;
            this.lblOuncesOutput.Location = new System.Drawing.Point(136, 125);
            this.lblOuncesOutput.Name = "lblOuncesOutput";
            this.lblOuncesOutput.Size = new System.Drawing.Size(0, 17);
            this.lblOuncesOutput.TabIndex = 5;
            // 
            // txtCupsInput
            // 
            this.txtCupsInput.Location = new System.Drawing.Point(135, 71);
            this.txtCupsInput.Name = "txtCupsInput";
            this.txtCupsInput.Size = new System.Drawing.Size(100, 22);
            this.txtCupsInput.TabIndex = 6;
            // 
            // CupsToOuncesForm
            // 
            this.AcceptButton = this.btnConvert;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(306, 227);
            this.Controls.Add(this.txtCupsInput);
            this.Controls.Add(this.lblOuncesOutput);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnConvert);
            this.Controls.Add(this.lblCupsStatic);
            this.Controls.Add(this.lblOuncesStatic);
            this.Controls.Add(this.lblTitle);
            this.Name = "CupsToOuncesForm";
            this.Text = "CupsToOunces";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblOuncesStatic;
        private System.Windows.Forms.Label lblCupsStatic;
        private System.Windows.Forms.Button btnConvert;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblOuncesOutput;
        private System.Windows.Forms.TextBox txtCupsInput;
    }
}

