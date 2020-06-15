namespace AppRestaurante
{
    partial class Form3
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
            this.tbComensales = new System.Windows.Forms.TextBox();
            this.tbMesas = new System.Windows.Forms.TextBox();
            this.lblComen = new System.Windows.Forms.Label();
            this.lblMesas = new System.Windows.Forms.Label();
            this.btnOk = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbComensales
            // 
            this.tbComensales.Location = new System.Drawing.Point(84, 12);
            this.tbComensales.Name = "tbComensales";
            this.tbComensales.Size = new System.Drawing.Size(100, 20);
            this.tbComensales.TabIndex = 0;
            // 
            // tbMesas
            // 
            this.tbMesas.Location = new System.Drawing.Point(84, 38);
            this.tbMesas.Name = "tbMesas";
            this.tbMesas.Size = new System.Drawing.Size(100, 20);
            this.tbMesas.TabIndex = 1;
            // 
            // lblComen
            // 
            this.lblComen.AutoSize = true;
            this.lblComen.Location = new System.Drawing.Point(2, 12);
            this.lblComen.Name = "lblComen";
            this.lblComen.Size = new System.Drawing.Size(64, 13);
            this.lblComen.TabIndex = 2;
            this.lblComen.Text = "Comensales";
            // 
            // lblMesas
            // 
            this.lblMesas.AutoSize = true;
            this.lblMesas.Location = new System.Drawing.Point(28, 38);
            this.lblMesas.Name = "lblMesas";
            this.lblMesas.Size = new System.Drawing.Size(38, 13);
            this.lblMesas.TabIndex = 3;
            this.lblMesas.Text = "Mesas";
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(84, 64);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 4;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(226, 122);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.lblMesas);
            this.Controls.Add(this.lblComen);
            this.Controls.Add(this.tbMesas);
            this.Controls.Add(this.tbComensales);
            this.Name = "Form3";
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbComensales;
        private System.Windows.Forms.TextBox tbMesas;
        private System.Windows.Forms.Label lblComen;
        private System.Windows.Forms.Label lblMesas;
        private System.Windows.Forms.Button btnOk;
    }
}