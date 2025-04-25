namespace P0S_EXPRESS.FORMS
{
    partial class MENU2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MENU2));
            this.CLIENTE = new System.Windows.Forms.Label();
            this.BUSCAR = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtCantidad = new System.Windows.Forms.TextBox();
            this.txteliminar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.Atras = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.boxarticulo = new System.Windows.Forms.ComboBox();
            this.txtnombre = new System.Windows.Forms.Label();
            this.boxcliente = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.PrecioU = new System.Windows.Forms.Label();
            this.Total = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Atras)).BeginInit();
            this.SuspendLayout();
            // 
            // CLIENTE
            // 
            this.CLIENTE.AutoSize = true;
            this.CLIENTE.Location = new System.Drawing.Point(37, 24);
            this.CLIENTE.Name = "CLIENTE";
            this.CLIENTE.Size = new System.Drawing.Size(52, 13);
            this.CLIENTE.TabIndex = 1;
            this.CLIENTE.Text = "CLIENTE";
            // 
            // BUSCAR
            // 
            this.BUSCAR.AutoSize = true;
            this.BUSCAR.Location = new System.Drawing.Point(30, 81);
            this.BUSCAR.Name = "BUSCAR";
            this.BUSCAR.Size = new System.Drawing.Size(117, 13);
            this.BUSCAR.TabIndex = 4;
            this.BUSCAR.Text = "AGREGAR ARTICULO";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(28, 126);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(760, 255);
            this.dataGridView1.TabIndex = 5;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::P0S_EXPRESS.Properties.Resources.Logotipo_de_Empresa_Tecnológica_Moderno_Azul_y_Verde__315_x_315_px___2_;
            this.pictureBox1.Location = new System.Drawing.Point(623, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(165, 77);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(215, 82);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Cantidad";
            // 
            // TxtCantidad
            // 
            this.TxtCantidad.Location = new System.Drawing.Point(209, 99);
            this.TxtCantidad.Name = "TxtCantidad";
            this.TxtCantidad.Size = new System.Drawing.Size(80, 20);
            this.TxtCantidad.TabIndex = 9;
            // 
            // txteliminar
            // 
            this.txteliminar.Location = new System.Drawing.Point(376, 96);
            this.txteliminar.Name = "txteliminar";
            this.txteliminar.Size = new System.Drawing.Size(75, 23);
            this.txteliminar.TabIndex = 40;
            this.txteliminar.Text = "Eliminar";
            this.txteliminar.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(297, 96);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 39;
            this.button1.Text = "Agregar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Atras
            // 
            this.Atras.Image = global::P0S_EXPRESS.Properties.Resources.hacia_atras;
            this.Atras.Location = new System.Drawing.Point(746, 410);
            this.Atras.Name = "Atras";
            this.Atras.Size = new System.Drawing.Size(42, 28);
            this.Atras.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Atras.TabIndex = 42;
            this.Atras.TabStop = false;
            this.Atras.Click += new System.EventHandler(this.Atras_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(281, 387);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(211, 23);
            this.button2.TabIndex = 41;
            this.button2.Text = "APLICAR";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(214, 38);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 43;
            this.button3.Text = "Agregar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // boxarticulo
            // 
            this.boxarticulo.FormattingEnabled = true;
            this.boxarticulo.Location = new System.Drawing.Point(33, 99);
            this.boxarticulo.Name = "boxarticulo";
            this.boxarticulo.Size = new System.Drawing.Size(154, 21);
            this.boxarticulo.TabIndex = 44;
            // 
            // txtnombre
            // 
            this.txtnombre.AutoSize = true;
            this.txtnombre.Location = new System.Drawing.Point(316, 48);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(0, 13);
            this.txtnombre.TabIndex = 45;
            // 
            // boxcliente
            // 
            this.boxcliente.FormattingEnabled = true;
            this.boxcliente.Location = new System.Drawing.Point(33, 40);
            this.boxcliente.Name = "boxcliente";
            this.boxcliente.Size = new System.Drawing.Size(154, 21);
            this.boxcliente.TabIndex = 46;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(463, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 47;
            this.label1.Text = "Precio Unitario";
            // 
            // PrecioU
            // 
            this.PrecioU.AutoSize = true;
            this.PrecioU.Location = new System.Drawing.Point(463, 106);
            this.PrecioU.Name = "PrecioU";
            this.PrecioU.Size = new System.Drawing.Size(10, 13);
            this.PrecioU.TabIndex = 48;
            this.PrecioU.Text = " ";
            // 
            // Total
            // 
            this.Total.AutoSize = true;
            this.Total.Location = new System.Drawing.Point(563, 105);
            this.Total.Name = "Total";
            this.Total.Size = new System.Drawing.Size(10, 13);
            this.Total.TabIndex = 50;
            this.Total.Text = " ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(563, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 49;
            this.label3.Text = "Total";
            // 
            // MENU2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Total);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.PrecioU);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.boxcliente);
            this.Controls.Add(this.txtnombre);
            this.Controls.Add(this.boxarticulo);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.Atras);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.txteliminar);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TxtCantidad);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.BUSCAR);
            this.Controls.Add(this.CLIENTE);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MENU2";
            this.Text = "VENTA";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Atras)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label CLIENTE;
        private System.Windows.Forms.Label BUSCAR;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtCantidad;
        private System.Windows.Forms.Button txteliminar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox Atras;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ComboBox boxarticulo;
        private System.Windows.Forms.Label txtnombre;
        private System.Windows.Forms.ComboBox boxcliente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label PrecioU;
        private System.Windows.Forms.Label Total;
        private System.Windows.Forms.Label label3;
    }
}