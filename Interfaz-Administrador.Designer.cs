namespace vista
{
    partial class Interfaz_Administrador
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Purchase_Button = new System.Windows.Forms.Button();
            this.Add_Employee = new System.Windows.Forms.Button();
            this.Kick_Employee = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Add_Vehicle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(128, 42);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Vehiculos Disponibles:";
            // 
            // Purchase_Button
            // 
            this.Purchase_Button.Location = new System.Drawing.Point(50, 84);
            this.Purchase_Button.Name = "Purchase_Button";
            this.Purchase_Button.Size = new System.Drawing.Size(75, 51);
            this.Purchase_Button.TabIndex = 2;
            this.Purchase_Button.Text = "Comprar Vehículo";
            this.Purchase_Button.UseVisualStyleBackColor = true;
            this.Purchase_Button.Click += new System.EventHandler(this.Purchase_Button_Click);
            // 
            // Add_Employee
            // 
            this.Add_Employee.Location = new System.Drawing.Point(212, 84);
            this.Add_Employee.Name = "Add_Employee";
            this.Add_Employee.Size = new System.Drawing.Size(75, 51);
            this.Add_Employee.TabIndex = 3;
            this.Add_Employee.Text = "Contratar empleado";
            this.Add_Employee.UseVisualStyleBackColor = true;
            this.Add_Employee.Click += new System.EventHandler(this.Add_Employee_Click);
            // 
            // Kick_Employee
            // 
            this.Kick_Employee.Location = new System.Drawing.Point(293, 84);
            this.Kick_Employee.Name = "Kick_Employee";
            this.Kick_Employee.Size = new System.Drawing.Size(75, 51);
            this.Kick_Employee.TabIndex = 4;
            this.Kick_Employee.Text = "Despedir empleado";
            this.Kick_Employee.UseVisualStyleBackColor = true;
            this.Kick_Employee.Click += new System.EventHandler(this.Kick_Employee_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(357, 45);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(255, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Nombre empleado:";
            // 
            // Add_Vehicle
            // 
            this.Add_Vehicle.Location = new System.Drawing.Point(131, 84);
            this.Add_Vehicle.Name = "Add_Vehicle";
            this.Add_Vehicle.Size = new System.Drawing.Size(75, 51);
            this.Add_Vehicle.TabIndex = 8;
            this.Add_Vehicle.Text = "Agregar Vehículo";
            this.Add_Vehicle.UseVisualStyleBackColor = true;
            this.Add_Vehicle.Click += new System.EventHandler(this.Add_Vehicle_Click);
            // 
            // Interfaz_Administrador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(498, 315);
            this.Controls.Add(this.Add_Vehicle);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Kick_Employee);
            this.Controls.Add(this.Add_Employee);
            this.Controls.Add(this.Purchase_Button);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Name = "Interfaz_Administrador";
            this.Text = "Interfaz_Administrador";
            this.Load += new System.EventHandler(this.Interfaz_Administrador_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Purchase_Button;
        private System.Windows.Forms.Button Add_Employee;
        private System.Windows.Forms.Button Kick_Employee;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Add_Vehicle;
    }
}