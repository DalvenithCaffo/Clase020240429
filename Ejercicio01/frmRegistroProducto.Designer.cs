namespace Ejercicio01
{
    partial class frmRegistroProducto
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
            label1 = new Label();
            label2 = new Label();
            cbCategoria = new ComboBox();
            label3 = new Label();
            txtProducto = new TextBox();
            txtPrecio = new TextBox();
            btnGrabar = new Button();
            dgwProductos = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgwProductos).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 25);
            label1.Name = "label1";
            label1.Size = new Size(72, 20);
            label1.TabIndex = 0;
            label1.Text = "Producto:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(24, 55);
            label2.Name = "label2";
            label2.Size = new Size(53, 20);
            label2.TabIndex = 1;
            label2.Text = "Precio:";
            // 
            // cbCategoria
            // 
            cbCategoria.FormattingEnabled = true;
            cbCategoria.Items.AddRange(new object[] { "Frutas", "Verduras", "Carnes" });
            cbCategoria.Location = new Point(102, 88);
            cbCategoria.Name = "cbCategoria";
            cbCategoria.Size = new Size(309, 28);
            cbCategoria.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(19, 88);
            label3.Name = "label3";
            label3.Size = new Size(77, 20);
            label3.TabIndex = 3;
            label3.Text = "Categoria:";
            // 
            // txtProducto
            // 
            txtProducto.Location = new Point(102, 22);
            txtProducto.Name = "txtProducto";
            txtProducto.Size = new Size(309, 27);
            txtProducto.TabIndex = 4;
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(102, 55);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(309, 27);
            txtPrecio.TabIndex = 5;
            // 
            // btnGrabar
            // 
            btnGrabar.Location = new Point(451, 84);
            btnGrabar.Name = "btnGrabar";
            btnGrabar.Size = new Size(156, 34);
            btnGrabar.TabIndex = 6;
            btnGrabar.Text = "Grabar";
            btnGrabar.UseVisualStyleBackColor = true;
            btnGrabar.Click += btnGrabar_Click;
            // 
            // dgwProductos
            // 
            dgwProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgwProductos.Location = new Point(24, 147);
            dgwProductos.Name = "dgwProductos";
            dgwProductos.RowHeadersWidth = 51;
            dgwProductos.Size = new Size(583, 150);
            dgwProductos.TabIndex = 7;
            // 
            // frmRegistroProducto
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(659, 344);
            Controls.Add(dgwProductos);
            Controls.Add(btnGrabar);
            Controls.Add(txtPrecio);
            Controls.Add(txtProducto);
            Controls.Add(label3);
            Controls.Add(cbCategoria);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmRegistroProducto";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Registro Productos";
            ((System.ComponentModel.ISupportInitialize)dgwProductos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private ComboBox cbCategoria;
        private Label label3;
        private TextBox txtProducto;
        private TextBox txtPrecio;
        private Button btnGrabar;
        private DataGridView dgwProductos;
    }
}