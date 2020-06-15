namespace AppRestaurante
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.txbUsuario = new System.Windows.Forms.TextBox();
            this.txbMovil = new System.Windows.Forms.TextBox();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblMovil = new System.Windows.Forms.Label();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblNomUsuar = new System.Windows.Forms.Label();
            this.lblNumMov = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblUserAd = new System.Windows.Forms.Label();
            this.lblT = new System.Windows.Forms.Label();
            this.lblTurno = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.lblComensalesRe = new System.Windows.Forms.Label();
            this.btnBuscClient = new System.Windows.Forms.Button();
            this.buttonPDF = new System.Windows.Forms.Button();
            this.textBoxComen = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txbUsuario
            // 
            this.txbUsuario.Location = new System.Drawing.Point(113, 23);
            this.txbUsuario.Name = "txbUsuario";
            this.txbUsuario.Size = new System.Drawing.Size(100, 20);
            this.txbUsuario.TabIndex = 0;
            this.txbUsuario.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txbMovil
            // 
            this.txbMovil.Location = new System.Drawing.Point(113, 77);
            this.txbMovil.Name = "txbMovil";
            this.txbMovil.Size = new System.Drawing.Size(100, 20);
            this.txbMovil.TabIndex = 1;
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.Location = new System.Drawing.Point(24, 23);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(67, 18);
            this.lblUsuario.TabIndex = 2;
            this.lblUsuario.Text = "Usuario";
            // 
            // lblMovil
            // 
            this.lblMovil.AutoSize = true;
            this.lblMovil.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMovil.Location = new System.Drawing.Point(24, 80);
            this.lblMovil.Name = "lblMovil";
            this.lblMovil.Size = new System.Drawing.Size(48, 18);
            this.lblMovil.TabIndex = 3;
            this.lblMovil.Text = "Móvil";
            // 
            // btnEnviar
            // 
            this.btnEnviar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnviar.Location = new System.Drawing.Point(37, 116);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(176, 23);
            this.btnEnviar.TabIndex = 4;
            this.btnEnviar.Text = "Identificar Camarero";
            this.btnEnviar.UseVisualStyleBackColor = true;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(296, 72);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(59, 13);
            this.lblNombre.TabIndex = 5;
            this.lblNombre.Text = "NomResult";
            // 
            // lblNomUsuar
            // 
            this.lblNomUsuar.AutoSize = true;
            this.lblNomUsuar.Location = new System.Drawing.Point(296, 108);
            this.lblNomUsuar.Name = "lblNomUsuar";
            this.lblNomUsuar.Size = new System.Drawing.Size(81, 13);
            this.lblNomUsuar.TabIndex = 6;
            this.lblNomUsuar.Text = "NomUserResult";
            // 
            // lblNumMov
            // 
            this.lblNumMov.AutoSize = true;
            this.lblNumMov.Location = new System.Drawing.Point(296, 145);
            this.lblNumMov.Name = "lblNumMov";
            this.lblNumMov.Size = new System.Drawing.Size(62, 13);
            this.lblNumMov.TabIndex = 7;
            this.lblNumMov.Text = "MovilResult";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(231, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Nombre:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(231, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Usuario:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(201, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Teléfono Móvil:";
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(37, 145);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(158, 23);
            this.btnAdd.TabIndex = 11;
            this.btnAdd.Text = "Añadir Camarero";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblUserAd
            // 
            this.lblUserAd.AutoSize = true;
            this.lblUserAd.Location = new System.Drawing.Point(285, 23);
            this.lblUserAd.Name = "lblUserAd";
            this.lblUserAd.Size = new System.Drawing.Size(88, 13);
            this.lblUserAd.TabIndex = 12;
            this.lblUserAd.Text = "Usuario Añadido!";
            // 
            // lblT
            // 
            this.lblT.AutoSize = true;
            this.lblT.Location = new System.Drawing.Point(236, 177);
            this.lblT.Name = "lblT";
            this.lblT.Size = new System.Drawing.Size(38, 13);
            this.lblT.TabIndex = 13;
            this.lblT.Text = "Turno:";
            // 
            // lblTurno
            // 
            this.lblTurno.AutoSize = true;
            this.lblTurno.Location = new System.Drawing.Point(296, 177);
            this.lblTurno.Name = "lblTurno";
            this.lblTurno.Size = new System.Drawing.Size(62, 13);
            this.lblTurno.TabIndex = 14;
            this.lblTurno.Text = "MovilResult";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(430, 18);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(191, 23);
            this.button1.TabIndex = 15;
            this.button1.Text = "Generar comensales";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblComensalesRe
            // 
            this.lblComensalesRe.AutoSize = true;
            this.lblComensalesRe.Location = new System.Drawing.Point(450, 44);
            this.lblComensalesRe.Name = "lblComensalesRe";
            this.lblComensalesRe.Size = new System.Drawing.Size(114, 13);
            this.lblComensalesRe.TabIndex = 16;
            this.lblComensalesRe.Text = "Resultado comensales";
            // 
            // btnBuscClient
            // 
            this.btnBuscClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscClient.Location = new System.Drawing.Point(37, 189);
            this.btnBuscClient.Name = "btnBuscClient";
            this.btnBuscClient.Size = new System.Drawing.Size(158, 23);
            this.btnBuscClient.TabIndex = 18;
            this.btnBuscClient.Text = "Buscar Cliente";
            this.btnBuscClient.UseVisualStyleBackColor = true;
            this.btnBuscClient.Click += new System.EventHandler(this.btnBuscClient_Click);
            // 
            // buttonPDF
            // 
            this.buttonPDF.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPDF.Location = new System.Drawing.Point(37, 286);
            this.buttonPDF.Name = "buttonPDF";
            this.buttonPDF.Size = new System.Drawing.Size(158, 23);
            this.buttonPDF.TabIndex = 19;
            this.buttonPDF.Text = "Generar PDF";
            this.buttonPDF.UseVisualStyleBackColor = true;
            this.buttonPDF.Click += new System.EventHandler(this.buttonPDF_Click);
            // 
            // textBoxComen
            // 
            this.textBoxComen.Location = new System.Drawing.Point(430, 108);
            this.textBoxComen.Multiline = true;
            this.textBoxComen.Name = "textBoxComen";
            this.textBoxComen.ReadOnly = true;
            this.textBoxComen.Size = new System.Drawing.Size(191, 201);
            this.textBoxComen.TabIndex = 20;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBoxComen);
            this.Controls.Add(this.buttonPDF);
            this.Controls.Add(this.btnBuscClient);
            this.Controls.Add(this.lblComensalesRe);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblTurno);
            this.Controls.Add(this.lblT);
            this.Controls.Add(this.lblUserAd);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblNumMov);
            this.Controls.Add(this.lblNomUsuar);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.btnEnviar);
            this.Controls.Add(this.lblMovil);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.txbMovil);
            this.Controls.Add(this.txbUsuario);
            this.Name = "Form1";
            this.Text = "Restaurante Jardi";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txbUsuario;
        private System.Windows.Forms.TextBox txbMovil;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblMovil;
        private System.Windows.Forms.Button btnEnviar;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblNomUsuar;
        private System.Windows.Forms.Label lblNumMov;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblUserAd;
        private System.Windows.Forms.Label lblT;
        private System.Windows.Forms.Label lblTurno;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblComensalesRe;
        private System.Windows.Forms.Button btnBuscClient;
        private System.Windows.Forms.Button buttonPDF;
        private System.Windows.Forms.TextBox textBoxComen;
    }
}

