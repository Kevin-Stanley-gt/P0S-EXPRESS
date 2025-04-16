namespace P0S_EXPRESS.FORMS
{
    partial class Nuevo_Proveedor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Nuevo_Proveedor));
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtdireccion = new System.Windows.Forms.TextBox();
            this.txtmoneda = new System.Windows.Forms.ComboBox();
            this.Nombre = new System.Windows.Forms.Label();
            this.Direccion = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txttel = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtRazon = new System.Windows.Forms.TextBox();
            this.Monedas = new System.Windows.Forms.Label();
            this.Agregar = new System.Windows.Forms.Button();
            this.Atras = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Atras)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(58, 64);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(250, 20);
            this.txtNombre.TabIndex = 0;
            // 
            // txtdireccion
            // 
            this.txtdireccion.Location = new System.Drawing.Point(58, 129);
            this.txtdireccion.Name = "txtdireccion";
            this.txtdireccion.Size = new System.Drawing.Size(250, 20);
            this.txtdireccion.TabIndex = 1;
            // 
            // txtmoneda
            // 
            this.txtmoneda.FormattingEnabled = true;
            this.txtmoneda.Location = new System.Drawing.Point(58, 314);
            this.txtmoneda.Name = "txtmoneda";
            this.txtmoneda.Size = new System.Drawing.Size(250, 21);
            this.txtmoneda.TabIndex = 4;
            this.txtmoneda.Text = "Seleccione Moneda";
            // 
            // Nombre
            // 
            this.Nombre.AutoSize = true;
            this.Nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nombre.Location = new System.Drawing.Point(55, 48);
            this.Nombre.Name = "Nombre";
            this.Nombre.Size = new System.Drawing.Size(50, 13);
            this.Nombre.TabIndex = 5;
            this.Nombre.Text = "Nombre";
            // 
            // Direccion
            // 
            this.Direccion.AutoSize = true;
            this.Direccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Direccion.Location = new System.Drawing.Point(55, 113);
            this.Direccion.Name = "Direccion";
            this.Direccion.Size = new System.Drawing.Size(61, 13);
            this.Direccion.TabIndex = 6;
            this.Direccion.Text = "Direccion";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(55, 174);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Telefono";
            // 
            // txttel
            // 
            this.txttel.Location = new System.Drawing.Point(58, 190);
            this.txttel.Name = "txttel";
            this.txttel.Size = new System.Drawing.Size(250, 20);
            this.txttel.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(55, 235);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Razon Social";
            // 
            // txtRazon
            // 
            this.txtRazon.Location = new System.Drawing.Point(58, 251);
            this.txtRazon.Name = "txtRazon";
            this.txtRazon.Size = new System.Drawing.Size(250, 20);
            this.txtRazon.TabIndex = 9;
            // 
            // Monedas
            // 
            this.Monedas.AutoSize = true;
            this.Monedas.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Monedas.Location = new System.Drawing.Point(55, 296);
            this.Monedas.Name = "Monedas";
            this.Monedas.Size = new System.Drawing.Size(52, 13);
            this.Monedas.TabIndex = 11;
            this.Monedas.Text = "Moneda";
            // 
            // Agregar
            // 
            this.Agregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Agregar.Location = new System.Drawing.Point(84, 378);
            this.Agregar.Name = "Agregar";
            this.Agregar.Size = new System.Drawing.Size(200, 50);
            this.Agregar.TabIndex = 12;
            this.Agregar.Text = "Agregar";
            this.Agregar.UseVisualStyleBackColor = true;
            this.Agregar.Click += new System.EventHandler(this.Agregar_Click);
            // 
            // Atras
            // 
            this.Atras.Image = global::P0S_EXPRESS.Properties.Resources.hacia_atras;
            this.Atras.Location = new System.Drawing.Point(309, 440);
            this.Atras.Name = "Atras";
            this.Atras.Size = new System.Drawing.Size(42, 28);
            this.Atras.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Atras.TabIndex = 13;
            this.Atras.TabStop = false;
            this.Atras.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Nuevo_Proveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(363, 480);
            this.Controls.Add(this.Atras);
            this.Controls.Add(this.Agregar);
            this.Controls.Add(this.Monedas);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtRazon);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txttel);
            this.Controls.Add(this.Direccion);
            this.Controls.Add(this.Nombre);
            this.Controls.Add(this.txtmoneda);
            this.Controls.Add(this.txtdireccion);
            this.Controls.Add(this.txtNombre);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(379, 519);
            this.MinimumSize = new System.Drawing.Size(379, 519);
            this.Name = "Nuevo_Proveedor";
            this.Text = "Nuevo_Proveedor";
            ((System.ComponentModel.ISupportInitialize)(this.Atras)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtdireccion;
        private System.Windows.Forms.ComboBox txtmoneda;
        private System.Windows.Forms.Label Nombre;
        private System.Windows.Forms.Label Direccion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txttel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtRazon;
        private System.Windows.Forms.Label Monedas;
        private System.Windows.Forms.Button Agregar;
        private System.Windows.Forms.PictureBox Atras;
    }
}