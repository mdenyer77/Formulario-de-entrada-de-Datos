namespace Formulario_de_entrada_de_Datos
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtID = new TextBox();
            txtEmail = new TextBox();
            txtNombre = new TextBox();
            txtDireccion = new TextBox();
            txtApellido = new TextBox();
            txtTelefono = new TextBox();
            txtCargo = new TextBox();
            txtSalario = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            btnGuardar_Click = new Button();
            button2 = new Button();
            button3 = new Button();
            cmbGenero = new ComboBox();
            dtpFechaIngreso = new DateTimePicker();
            SuspendLayout();
            // 
            // txtID
            // 
            txtID.Location = new Point(158, 12);
            txtID.Name = "txtID";
            txtID.Size = new Size(150, 31);
            txtID.TabIndex = 0;
            txtID.TextChanged += textBox1_TextChanged;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(158, 292);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(150, 31);
            txtEmail.TabIndex = 1;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(158, 69);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(150, 31);
            txtNombre.TabIndex = 2;
            // 
            // txtDireccion
            // 
            txtDireccion.Location = new Point(158, 178);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(150, 31);
            txtDireccion.TabIndex = 3;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(158, 122);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(150, 31);
            txtApellido.TabIndex = 4;
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(158, 238);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(150, 31);
            txtTelefono.TabIndex = 6;
            // 
            // txtCargo
            // 
            txtCargo.Location = new Point(158, 348);
            txtCargo.Name = "txtCargo";
            txtCargo.Size = new Size(150, 31);
            txtCargo.TabIndex = 8;
            // 
            // txtSalario
            // 
            txtSalario.Location = new Point(158, 405);
            txtSalario.Name = "txtSalario";
            txtSalario.Size = new Size(150, 31);
            txtSalario.TabIndex = 9;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(77, 18);
            label1.Name = "label1";
            label1.Size = new Size(34, 25);
            label1.TabIndex = 10;
            label1.Text = "ID:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(52, 519);
            label2.Name = "label2";
            label2.Size = new Size(73, 25);
            label2.TabIndex = 11;
            label2.Text = "Genero:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(3, 468);
            label3.Name = "label3";
            label3.Size = new Size(150, 25);
            label3.TabIndex = 12;
            label3.Text = "Fecha de ingreso:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(60, 411);
            label4.Name = "label4";
            label4.Size = new Size(69, 25);
            label4.TabIndex = 13;
            label4.Text = "Salario:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(60, 354);
            label5.Name = "label5";
            label5.Size = new Size(64, 25);
            label5.TabIndex = 14;
            label5.Text = "Cargo:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(60, 299);
            label6.Name = "label6";
            label6.Size = new Size(58, 25);
            label6.TabIndex = 15;
            label6.Text = "Email:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(60, 238);
            label7.Name = "label7";
            label7.Size = new Size(83, 25);
            label7.TabIndex = 16;
            label7.Text = "Telefono:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(60, 181);
            label8.Name = "label8";
            label8.Size = new Size(89, 25);
            label8.TabIndex = 17;
            label8.Text = "Direccion:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(60, 122);
            label9.Name = "label9";
            label9.Size = new Size(82, 25);
            label9.TabIndex = 18;
            label9.Text = "Apellido:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(60, 69);
            label10.Name = "label10";
            label10.Size = new Size(82, 25);
            label10.TabIndex = 19;
            label10.Text = "Nombre:";
            // 
            // btnGuardar_Click
            // 
            btnGuardar_Click.Location = new Point(114, 568);
            btnGuardar_Click.Name = "btnGuardar_Click";
            btnGuardar_Click.Size = new Size(112, 34);
            btnGuardar_Click.TabIndex = 20;
            btnGuardar_Click.Text = "Guardar";
            btnGuardar_Click.UseVisualStyleBackColor = true;
            btnGuardar_Click.Click += btnGuardar_Click_Click;
            // 
            // button2
            // 
            button2.Location = new Point(281, 568);
            button2.Name = "button2";
            button2.Size = new Size(112, 34);
            button2.TabIndex = 21;
            button2.Text = "Abrir";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(445, 568);
            button3.Name = "button3";
            button3.Size = new Size(112, 34);
            button3.TabIndex = 22;
            button3.Text = "Salida";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // cmbGenero
            // 
            cmbGenero.FormattingEnabled = true;
            cmbGenero.Location = new Point(158, 519);
            cmbGenero.Name = "cmbGenero";
            cmbGenero.Size = new Size(182, 33);
            cmbGenero.TabIndex = 24;
            // 
            // dtpFechaIngreso
            // 
            dtpFechaIngreso.Location = new Point(159, 468);
            dtpFechaIngreso.Name = "dtpFechaIngreso";
            dtpFechaIngreso.Size = new Size(300, 31);
            dtpFechaIngreso.TabIndex = 25;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 604);
            Controls.Add(dtpFechaIngreso);
            Controls.Add(cmbGenero);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(btnGuardar_Click);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtSalario);
            Controls.Add(txtCargo);
            Controls.Add(txtTelefono);
            Controls.Add(txtApellido);
            Controls.Add(txtDireccion);
            Controls.Add(txtNombre);
            Controls.Add(txtEmail);
            Controls.Add(txtID);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtID;
        private TextBox txtEmail;
        private TextBox txtNombre;
        private TextBox txtDireccion;
        private TextBox txtApellido;
        private TextBox txtTelefono;
        private TextBox txtCargo;
        private TextBox txtSalario;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Button btnGuardar_Click;
        private Button button2;
        private Button button3;
        private ComboBox cmbGenero;
        private DateTimePicker dtpFechaIngreso;
    }
}
