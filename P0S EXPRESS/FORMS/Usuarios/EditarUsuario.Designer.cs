namespace P0S_EXPRESS.FORMS.Usuarios
{
    partial class EditarUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditarUsuario));
            this.label4 = new System.Windows.Forms.Label();
            this.txtusuario = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtdireccion = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TXTCUI = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.Atras = new System.Windows.Forms.PictureBox();
            this.Agregar = new System.Windows.Forms.Button();
            this.Monedas = new System.Windows.Forms.Label();
            this.Direccion = new System.Windows.Forms.Label();
            this.Nombre = new System.Windows.Forms.Label();
            this.txtrol = new System.Windows.Forms.ComboBox();
            this.txtapellidos = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.Atras)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(57, 214);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 82;
            this.label4.Text = "Usuario";
            // 
            // txtusuario
            // 
            this.txtusuario.Location = new System.Drawing.Point(59, 230);
            this.txtusuario.Name = "txtusuario";
            this.txtusuario.Size = new System.Drawing.Size(250, 20);
            this.txtusuario.TabIndex = 81;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(56, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 80;
            this.label3.Text = "Direccion";
            // 
            // txtdireccion
            // 
            this.txtdireccion.Location = new System.Drawing.Point(59, 132);
            this.txtdireccion.Name = "txtdireccion";
            this.txtdireccion.Size = new System.Drawing.Size(250, 20);
            this.txtdireccion.TabIndex = 79;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(56, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 78;
            this.label2.Text = "CUI";
            // 
            // TXTCUI
            // 
            this.TXTCUI.Location = new System.Drawing.Point(59, 178);
            this.TXTCUI.Name = "TXTCUI";
            this.TXTCUI.Size = new System.Drawing.Size(250, 20);
            this.TXTCUI.TabIndex = 77;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.Location = new System.Drawing.Point(59, 326);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(62, 17);
            this.checkBox1.TabIndex = 76;
            this.checkBox1.Text = "Activo";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // Atras
            // 
            this.Atras.Image = global::P0S_EXPRESS.Properties.Resources.hacia_atras;
            this.Atras.Location = new System.Drawing.Point(310, 443);
            this.Atras.Name = "Atras";
            this.Atras.Size = new System.Drawing.Size(42, 28);
            this.Atras.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Atras.TabIndex = 75;
            this.Atras.TabStop = false;
            this.Atras.Click += new System.EventHandler(this.Atras_Click);
            // 
            // Agregar
            // 
            this.Agregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Agregar.Location = new System.Drawing.Point(79, 374);
            this.Agregar.Name = "Agregar";
            this.Agregar.Size = new System.Drawing.Size(200, 50);
            this.Agregar.TabIndex = 74;
            this.Agregar.Text = "Editar";
            this.Agregar.UseVisualStyleBackColor = true;
            this.Agregar.Click += new System.EventHandler(this.Agregar_Click);
            // 
            // Monedas
            // 
            this.Monedas.AutoSize = true;
            this.Monedas.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Monedas.Location = new System.Drawing.Point(57, 265);
            this.Monedas.Name = "Monedas";
            this.Monedas.Size = new System.Drawing.Size(26, 13);
            this.Monedas.TabIndex = 73;
            this.Monedas.Text = "Rol";
            // 
            // Direccion
            // 
            this.Direccion.AutoSize = true;
            this.Direccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Direccion.Location = new System.Drawing.Point(56, 70);
            this.Direccion.Name = "Direccion";
            this.Direccion.Size = new System.Drawing.Size(58, 13);
            this.Direccion.TabIndex = 70;
            this.Direccion.Text = "Apellidos";
            // 
            // Nombre
            // 
            this.Nombre.AutoSize = true;
            this.Nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nombre.Location = new System.Drawing.Point(56, 19);
            this.Nombre.Name = "Nombre";
            this.Nombre.Size = new System.Drawing.Size(50, 13);
            this.Nombre.TabIndex = 69;
            this.Nombre.Text = "Nombre";
            // 
            // txtrol
            // 
            this.txtrol.FormattingEnabled = true;
            this.txtrol.Location = new System.Drawing.Point(60, 283);
            this.txtrol.Name = "txtrol";
            this.txtrol.Size = new System.Drawing.Size(250, 21);
            this.txtrol.TabIndex = 68;
            // 
            // txtapellidos
            // 
            this.txtapellidos.Location = new System.Drawing.Point(59, 86);
            this.txtapellidos.Name = "txtapellidos";
            this.txtapellidos.Size = new System.Drawing.Size(250, 20);
            this.txtapellidos.TabIndex = 67;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(59, 35);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(250, 20);
            this.txtNombre.TabIndex = 66;
            // 
            // EditarUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(363, 480);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtusuario);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtdireccion);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TXTCUI);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.Atras);
            this.Controls.Add(this.Agregar);
            this.Controls.Add(this.Monedas);
            this.Controls.Add(this.Direccion);
            this.Controls.Add(this.Nombre);
            this.Controls.Add(this.txtrol);
            this.Controls.Add(this.txtapellidos);
            this.Controls.Add(this.txtNombre);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EditarUsuario";
            this.Text = "EditarUsuario";
            ((System.ComponentModel.ISupportInitialize)(this.Atras)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtusuario;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtdireccion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TXTCUI;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.PictureBox Atras;
        private System.Windows.Forms.Button Agregar;
        private System.Windows.Forms.Label Monedas;
        private System.Windows.Forms.Label Direccion;
        private System.Windows.Forms.Label Nombre;
        private System.Windows.Forms.ComboBox txtrol;
        private System.Windows.Forms.TextBox txtapellidos;
        private System.Windows.Forms.TextBox txtNombre;
    }
}