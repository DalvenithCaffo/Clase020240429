namespace Ejercicio01
{
    partial class frmRegistroUsuario
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
            lblUsuario = new Label();
            label1 = new Label();
            label2 = new Label();
            txtNombres = new TextBox();
            txtApellidos = new TextBox();
            dtpFechaNacimiento = new DateTimePicker();
            chkCasado = new CheckBox();
            btnAnalizar = new Button();
            lblMayorEdad = new Label();
            lblCasado = new Label();
            groupBox1 = new GroupBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblUsuario.ForeColor = SystemColors.ControlText;
            lblUsuario.Location = new Point(39, 39);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(78, 20);
            lblUsuario.TabIndex = 1;
            lblUsuario.Text = "Nombres:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label1.ForeColor = SystemColors.ControlText;
            label1.Location = new Point(39, 72);
            label1.Name = "label1";
            label1.Size = new Size(78, 20);
            label1.TabIndex = 2;
            label1.Text = "Apellidos:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label2.ForeColor = SystemColors.ControlText;
            label2.Location = new Point(39, 107);
            label2.Name = "label2";
            label2.Size = new Size(138, 20);
            label2.TabIndex = 3;
            label2.Text = "Fecha Nacimiento:";
            // 
            // txtNombres
            // 
            txtNombres.Location = new Point(183, 32);
            txtNombres.Name = "txtNombres";
            txtNombres.Size = new Size(413, 27);
            txtNombres.TabIndex = 5;
            // 
            // txtApellidos
            // 
            txtApellidos.Location = new Point(183, 65);
            txtApellidos.Name = "txtApellidos";
            txtApellidos.Size = new Size(413, 27);
            txtApellidos.TabIndex = 6;
            // 
            // dtpFechaNacimiento
            // 
            dtpFechaNacimiento.Location = new Point(183, 100);
            dtpFechaNacimiento.Name = "dtpFechaNacimiento";
            dtpFechaNacimiento.Size = new Size(250, 27);
            dtpFechaNacimiento.TabIndex = 7;
            // 
            // chkCasado
            // 
            chkCasado.AutoSize = true;
            chkCasado.Location = new Point(182, 138);
            chkCasado.Name = "chkCasado";
            chkCasado.Size = new Size(105, 24);
            chkCasado.TabIndex = 8;
            chkCasado.Text = "Es Casado?";
            chkCasado.UseVisualStyleBackColor = true;
            // 
            // btnAnalizar
            // 
            btnAnalizar.Location = new Point(183, 189);
            btnAnalizar.Name = "btnAnalizar";
            btnAnalizar.Size = new Size(413, 29);
            btnAnalizar.TabIndex = 9;
            btnAnalizar.Text = "Analizar";
            btnAnalizar.UseVisualStyleBackColor = true;
            btnAnalizar.Click += btnAnalizar_Click;
            // 
            // lblMayorEdad
            // 
            lblMayorEdad.AutoSize = true;
            lblMayorEdad.Location = new Point(33, 45);
            lblMayorEdad.Name = "lblMayorEdad";
            lblMayorEdad.Size = new Size(102, 20);
            lblMayorEdad.TabIndex = 10;
            lblMayorEdad.Text = "MAYOR EDAD";
            // 
            // lblCasado
            // 
            lblCasado.AutoSize = true;
            lblCasado.Location = new Point(347, 45);
            lblCasado.Name = "lblCasado";
            lblCasado.Size = new Size(99, 20);
            lblCasado.TabIndex = 11;
            lblCasado.Text = "SOY CASADO";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.GradientActiveCaption;
            groupBox1.Controls.Add(lblCasado);
            groupBox1.Controls.Add(lblMayorEdad);
            groupBox1.Location = new Point(150, 254);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(478, 85);
            groupBox1.TabIndex = 12;
            groupBox1.TabStop = false;
            groupBox1.Text = "Resultado";
            // 
            // frmRegistroUsuario
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(649, 420);
            Controls.Add(groupBox1);
            Controls.Add(btnAnalizar);
            Controls.Add(chkCasado);
            Controls.Add(dtpFechaNacimiento);
            Controls.Add(txtApellidos);
            Controls.Add(txtNombres);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lblUsuario);
            Name = "frmRegistroUsuario";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Registro Usuarios";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblUsuario;
        private Label label1;
        private Label label2;
        private TextBox txtNombres;
        private TextBox txtApellidos;
        private DateTimePicker dtpFechaNacimiento;
        private CheckBox chkCasado;
        private Button btnAnalizar;
        private Label lblMayorEdad;
        private Label lblCasado;
        private GroupBox groupBox1;
    }
}