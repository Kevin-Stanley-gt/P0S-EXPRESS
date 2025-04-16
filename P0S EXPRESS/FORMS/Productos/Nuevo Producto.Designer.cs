namespace P0S_EXPRESS.FORMS.Productos
{
    partial class NuevoProducto
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
            this.Atras = new System.Windows.Forms.PictureBox();
            this.Agregar = new System.Windows.Forms.Button();
            this.Monedas = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCosto = new System.Windows.Forms.TextBox();
            this.Direccion = new System.Windows.Forms.Label();
            this.Nombre = new System.Windows.Forms.Label();
            this.TxtProvee = new System.Windows.Forms.ComboBox();
            this.txtdescripcion = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.Atras)).BeginInit();
            this.SuspendLayout();
            // 
            // Atras
            // 
            this.Atras.Image = global::P0S_EXPRESS.Properties.Resources.hacia_atras;
            this.Atras.Location = new System.Drawing.Point(309, 440);
            this.Atras.Name = "Atras";
            this.Atras.Size = new System.Drawing.Size(42, 28);
            this.Atras.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Atras.TabIndex = 25;
            this.Atras.TabStop = false;
            this.Atras.Click += new System.EventHandler(this.Atras_Click);
            // 
            // Agregar
            // 
            this.Agregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Agregar.Location = new System.Drawing.Point(84, 378);
            this.Agregar.Name = "Agregar";
            this.Agregar.Size = new System.Drawing.Size(200, 50);
            this.Agregar.TabIndex = 24;
            this.Agregar.Text = "Agregar";
            this.Agregar.UseVisualStyleBackColor = true;
            this.Agregar.Click += new System.EventHandler(this.Agregar_Click);
            // 
            // Monedas
            // 
            this.Monedas.AutoSize = true;
            this.Monedas.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Monedas.Location = new System.Drawing.Point(55, 228);
            this.Monedas.Name = "Monedas";
            this.Monedas.Size = new System.Drawing.Size(65, 13);
            this.Monedas.TabIndex = 23;
            this.Monedas.Text = "Proveedor";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(55, 174);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "Costo";
            // 
            // txtCosto
            // 
            this.txtCosto.Location = new System.Drawing.Point(58, 190);
            this.txtCosto.Name = "txtCosto";
            this.txtCosto.Size = new System.Drawing.Size(250, 20);
            this.txtCosto.TabIndex = 19;
            // 
            // Direccion
            // 
            this.Direccion.AutoSize = true;
            this.Direccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Direccion.Location = new System.Drawing.Point(55, 113);
            this.Direccion.Name = "Direccion";
            this.Direccion.Size = new System.Drawing.Size(74, 13);
            this.Direccion.TabIndex = 18;
            this.Direccion.Text = "Descripcion";
            // 
            // Nombre
            // 
            this.Nombre.AutoSize = true;
            this.Nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nombre.Location = new System.Drawing.Point(55, 48);
            this.Nombre.Name = "Nombre";
            this.Nombre.Size = new System.Drawing.Size(50, 13);
            this.Nombre.TabIndex = 17;
            this.Nombre.Text = "Nombre";
            // 
            // TxtProvee
            // 
            this.TxtProvee.FormattingEnabled = true;
            this.TxtProvee.Location = new System.Drawing.Point(58, 246);
            this.TxtProvee.Name = "TxtProvee";
            this.TxtProvee.Size = new System.Drawing.Size(250, 21);
            this.TxtProvee.TabIndex = 16;
            // 
            // txtdescripcion
            // 
            this.txtdescripcion.Location = new System.Drawing.Point(58, 129);
            this.txtdescripcion.Name = "txtdescripcion";
            this.txtdescripcion.Size = new System.Drawing.Size(250, 20);
            this.txtdescripcion.TabIndex = 15;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(58, 64);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(250, 20);
            this.txtNombre.TabIndex = 14;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.Location = new System.Drawing.Point(58, 291);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(62, 17);
            this.checkBox1.TabIndex = 26;
            this.checkBox1.Text = "Activo";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // NuevoProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(363, 480);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.Atras);
            this.Controls.Add(this.Agregar);
            this.Controls.Add(this.Monedas);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCosto);
            this.Controls.Add(this.Direccion);
            this.Controls.Add(this.Nombre);
            this.Controls.Add(this.TxtProvee);
            this.Controls.Add(this.txtdescripcion);
            this.Controls.Add(this.txtNombre);
            this.MaximumSize = new System.Drawing.Size(379, 519);
            this.MinimumSize = new System.Drawing.Size(379, 519);
            this.Name = "NuevoProducto";
            this.Text = "Nuevo Producto";
            ((System.ComponentModel.ISupportInitialize)(this.Atras)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Atras;
        private System.Windows.Forms.Button Agregar;
        private System.Windows.Forms.Label Monedas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCosto;
        private System.Windows.Forms.Label Direccion;
        private System.Windows.Forms.Label Nombre;
        private System.Windows.Forms.ComboBox TxtProvee;
        private System.Windows.Forms.TextBox txtdescripcion;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}