namespace AppRestaurante
{
    partial class newCamarero
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
            this.txbUsuario = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblMovil = new System.Windows.Forms.Label();
            this.txbNombre = new System.Windows.Forms.TextBox();
            this.txbMovil = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdTarde = new System.Windows.Forms.RadioButton();
            this.rdManana = new System.Windows.Forms.RadioButton();
            this.btnCancel = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txbUsuario
            // 
            this.txbUsuario.Location = new System.Drawing.Point(221, 55);
            this.txbUsuario.Name = "txbUsuario";
            this.txbUsuario.Size = new System.Drawing.Size(100, 20);
            this.txbUsuario.TabIndex = 0;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(100, 110);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(91, 13);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Nombre Completo";
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Location = new System.Drawing.Point(100, 58);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(83, 13);
            this.lblUsuario.TabIndex = 2;
            this.lblUsuario.Text = "Nombre Usuario";
            // 
            // lblMovil
            // 
            this.lblMovil.AutoSize = true;
            this.lblMovil.Location = new System.Drawing.Point(100, 147);
            this.lblMovil.Name = "lblMovil";
            this.lblMovil.Size = new System.Drawing.Size(87, 13);
            this.lblMovil.TabIndex = 3;
            this.lblMovil.Text = "Número de Móvil";
            // 
            // txbNombre
            // 
            this.txbNombre.Location = new System.Drawing.Point(221, 110);
            this.txbNombre.Name = "txbNombre";
            this.txbNombre.Size = new System.Drawing.Size(100, 20);
            this.txbNombre.TabIndex = 4;
            // 
            // txbMovil
            // 
            this.txbMovil.Location = new System.Drawing.Point(221, 147);
            this.txbMovil.Name = "txbMovil";
            this.txbMovil.Size = new System.Drawing.Size(100, 20);
            this.txbMovil.TabIndex = 5;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(203, 267);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "Ok";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdTarde);
            this.groupBox1.Controls.Add(this.rdManana);
            this.groupBox1.Location = new System.Drawing.Point(162, 173);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(159, 68);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Turno";
            // 
            // rdTarde
            // 
            this.rdTarde.AutoSize = true;
            this.rdTarde.Location = new System.Drawing.Point(97, 33);
            this.rdTarde.Name = "rdTarde";
            this.rdTarde.Size = new System.Drawing.Size(53, 17);
            this.rdTarde.TabIndex = 1;
            this.rdTarde.Text = "Tarde";
            this.rdTarde.UseVisualStyleBackColor = true;
            // 
            // rdManana
            // 
            this.rdManana.AutoSize = true;
            this.rdManana.Checked = true;
            this.rdManana.Location = new System.Drawing.Point(7, 33);
            this.rdManana.Name = "rdManana";
            this.rdManana.Size = new System.Drawing.Size(64, 17);
            this.rdManana.TabIndex = 0;
            this.rdManana.TabStop = true;
            this.rdManana.Text = "Mañana";
            this.rdManana.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(344, 267);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.button1_Click);
            // 
            // newCamarero
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txbMovil);
            this.Controls.Add(this.txbNombre);
            this.Controls.Add(this.lblMovil);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.txbUsuario);
            this.Name = "newCamarero";
            this.Text = "Jardi - Añadir Camarero";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txbUsuario;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblMovil;
        private System.Windows.Forms.TextBox txbNombre;
        private System.Windows.Forms.TextBox txbMovil;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdTarde;
        private System.Windows.Forms.RadioButton rdManana;
        private System.Windows.Forms.Button btnCancel;
    }
}