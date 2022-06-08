namespace vista
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
            this.pnlLogin = new System.Windows.Forms.Panel();
            this.btnRegistrarLO = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtContraseña = new System.Windows.Forms.TextBox();
            this.btnLoginLO = new System.Windows.Forms.Button();
            this.pnlRegistro = new System.Windows.Forms.Panel();
            this.btnRegistrarRE = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtContraseñaRE = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtUsuarioRE = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNombreRE = new System.Windows.Forms.TextBox();
            this.txtApellidoRE = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pnlLogin.SuspendLayout();
            this.pnlRegistro.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlLogin
            // 
            this.pnlLogin.Controls.Add(this.btnRegistrarLO);
            this.pnlLogin.Controls.Add(this.label1);
            this.pnlLogin.Controls.Add(this.txtUsuario);
            this.pnlLogin.Controls.Add(this.txtContraseña);
            this.pnlLogin.Controls.Add(this.btnLoginLO);
            this.pnlLogin.Location = new System.Drawing.Point(12, 12);
            this.pnlLogin.Name = "pnlLogin";
            this.pnlLogin.Size = new System.Drawing.Size(264, 255);
            this.pnlLogin.TabIndex = 8;
            // 
            // btnRegistrarLO
            // 
            this.btnRegistrarLO.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrarLO.Location = new System.Drawing.Point(76, 203);
            this.btnRegistrarLO.Name = "btnRegistrarLO";
            this.btnRegistrarLO.Size = new System.Drawing.Size(113, 34);
            this.btnRegistrarLO.TabIndex = 12;
            this.btnRegistrarLO.Text = "Registrar";
            this.btnRegistrarLO.UseVisualStyleBackColor = true;
            this.btnRegistrarLO.Click += new System.EventHandler(this.btnRegistrarLO_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(226, 70);
            this.label1.TabIndex = 11;
            this.label1.Text = "Sánchez \r\nAutomotores";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtUsuario
            // 
            this.txtUsuario.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuario.ForeColor = System.Drawing.Color.Silver;
            this.txtUsuario.Location = new System.Drawing.Point(29, 84);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(206, 32);
            this.txtUsuario.TabIndex = 10;
            this.txtUsuario.Text = "Nombre de usuario";
            this.txtUsuario.Enter += new System.EventHandler(this.txtUsuario_Enter);
            this.txtUsuario.Leave += new System.EventHandler(this.txtUsuario_Leave);
            // 
            // txtContraseña
            // 
            this.txtContraseña.BackColor = System.Drawing.Color.White;
            this.txtContraseña.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContraseña.ForeColor = System.Drawing.Color.Silver;
            this.txtContraseña.Location = new System.Drawing.Point(29, 121);
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.Size = new System.Drawing.Size(206, 32);
            this.txtContraseña.TabIndex = 9;
            this.txtContraseña.Text = "Contraseña";
            this.txtContraseña.Enter += new System.EventHandler(this.txtContraseña_Enter);
            this.txtContraseña.Leave += new System.EventHandler(this.txtContraseña_Leave);
            // 
            // btnLoginLO
            // 
            this.btnLoginLO.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoginLO.Location = new System.Drawing.Point(29, 158);
            this.btnLoginLO.Name = "btnLoginLO";
            this.btnLoginLO.Size = new System.Drawing.Size(206, 39);
            this.btnLoginLO.TabIndex = 8;
            this.btnLoginLO.Text = "Ingresar";
            this.btnLoginLO.UseVisualStyleBackColor = true;
            // 
            // pnlRegistro
            // 
            this.pnlRegistro.Controls.Add(this.btnRegistrarRE);
            this.pnlRegistro.Controls.Add(this.label6);
            this.pnlRegistro.Controls.Add(this.txtContraseñaRE);
            this.pnlRegistro.Controls.Add(this.label5);
            this.pnlRegistro.Controls.Add(this.txtUsuarioRE);
            this.pnlRegistro.Controls.Add(this.label4);
            this.pnlRegistro.Controls.Add(this.label3);
            this.pnlRegistro.Controls.Add(this.txtNombreRE);
            this.pnlRegistro.Controls.Add(this.txtApellidoRE);
            this.pnlRegistro.Controls.Add(this.label2);
            this.pnlRegistro.Location = new System.Drawing.Point(282, 12);
            this.pnlRegistro.Name = "pnlRegistro";
            this.pnlRegistro.Size = new System.Drawing.Size(243, 335);
            this.pnlRegistro.TabIndex = 9;
            // 
            // btnRegistrarRE
            // 
            this.btnRegistrarRE.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrarRE.Location = new System.Drawing.Point(57, 266);
            this.btnRegistrarRE.Name = "btnRegistrarRE";
            this.btnRegistrarRE.Size = new System.Drawing.Size(126, 61);
            this.btnRegistrarRE.TabIndex = 23;
            this.btnRegistrarRE.Text = "Registrar";
            this.btnRegistrarRE.UseVisualStyleBackColor = true;
            this.btnRegistrarRE.Click += new System.EventHandler(this.btnRegistrarRE_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(9, 213);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 15);
            this.label6.TabIndex = 22;
            this.label6.Text = "Contraseña";
            // 
            // txtContraseñaRE
            // 
            this.txtContraseñaRE.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContraseñaRE.ForeColor = System.Drawing.Color.Silver;
            this.txtContraseñaRE.Location = new System.Drawing.Point(9, 229);
            this.txtContraseñaRE.Name = "txtContraseñaRE";
            this.txtContraseñaRE.Size = new System.Drawing.Size(227, 31);
            this.txtContraseñaRE.TabIndex = 21;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 162);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 15);
            this.label5.TabIndex = 20;
            this.label5.Text = "Nombre de usuario";
            // 
            // txtUsuarioRE
            // 
            this.txtUsuarioRE.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuarioRE.ForeColor = System.Drawing.Color.Silver;
            this.txtUsuarioRE.Location = new System.Drawing.Point(9, 178);
            this.txtUsuarioRE.Name = "txtUsuarioRE";
            this.txtUsuarioRE.Size = new System.Drawing.Size(227, 31);
            this.txtUsuarioRE.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(9, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 15);
            this.label4.TabIndex = 16;
            this.label4.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(9, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 15);
            this.label3.TabIndex = 15;
            this.label3.Text = "Apellido";
            // 
            // txtNombreRE
            // 
            this.txtNombreRE.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreRE.ForeColor = System.Drawing.Color.Silver;
            this.txtNombreRE.Location = new System.Drawing.Point(9, 75);
            this.txtNombreRE.Name = "txtNombreRE";
            this.txtNombreRE.Size = new System.Drawing.Size(227, 31);
            this.txtNombreRE.TabIndex = 14;
            // 
            // txtApellidoRE
            // 
            this.txtApellidoRE.BackColor = System.Drawing.Color.White;
            this.txtApellidoRE.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApellidoRE.ForeColor = System.Drawing.Color.Silver;
            this.txtApellidoRE.Location = new System.Drawing.Point(9, 128);
            this.txtApellidoRE.Name = "txtApellidoRE";
            this.txtApellidoRE.Size = new System.Drawing.Size(227, 31);
            this.txtApellidoRE.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 35);
            this.label2.TabIndex = 13;
            this.label2.Text = "Registro";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(530, 351);
            this.Controls.Add(this.pnlRegistro);
            this.Controls.Add(this.pnlLogin);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnlLogin.ResumeLayout(false);
            this.pnlLogin.PerformLayout();
            this.pnlRegistro.ResumeLayout(false);
            this.pnlRegistro.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlLogin;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.TextBox txtContraseña;
        private System.Windows.Forms.Button btnLoginLO;
        private System.Windows.Forms.Button btnRegistrarLO;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlRegistro;
        private System.Windows.Forms.TextBox txtNombreRE;
        private System.Windows.Forms.TextBox txtApellidoRE;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnRegistrarRE;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtContraseñaRE;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtUsuarioRE;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
    }
}

