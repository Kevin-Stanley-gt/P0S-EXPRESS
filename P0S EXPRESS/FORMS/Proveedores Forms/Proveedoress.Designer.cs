namespace P0S_EXPRESS.FORMS
{
    partial class Proveedoress
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Buscar = new System.Windows.Forms.Button();
            this.txtprov = new System.Windows.Forms.TextBox();
            this.Editar = new System.Windows.Forms.PictureBox();
            this.Agregar = new System.Windows.Forms.PictureBox();
            this.Atras = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Editar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Agregar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Atras)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(50, 99);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(701, 310);
            this.dataGridView1.TabIndex = 7;
            // 
            // Buscar
            // 
            this.Buscar.Location = new System.Drawing.Point(630, 64);
            this.Buscar.Name = "Buscar";
            this.Buscar.Size = new System.Drawing.Size(121, 29);
            this.Buscar.TabIndex = 6;
            this.Buscar.Text = "Buscar";
            this.Buscar.UseVisualStyleBackColor = true;
            this.Buscar.Click += new System.EventHandler(this.Buscar_Click);
            // 
            // txtprov
            // 
            this.txtprov.Location = new System.Drawing.Point(50, 69);
            this.txtprov.Name = "txtprov";
            this.txtprov.Size = new System.Drawing.Size(560, 20);
            this.txtprov.TabIndex = 5;
            // 
            // Editar
            // 
            this.Editar.AccessibleDescription = "Editar";
            this.Editar.AccessibleName = "Editar";
            this.Editar.Image = global::P0S_EXPRESS.Properties.Resources.boton_editar;
            this.Editar.Location = new System.Drawing.Point(92, 41);
            this.Editar.Name = "Editar";
            this.Editar.Size = new System.Drawing.Size(24, 22);
            this.Editar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Editar.TabIndex = 9;
            this.Editar.TabStop = false;
            this.Editar.Click += new System.EventHandler(this.Editar_Click);
            // 
            // Agregar
            // 
            this.Agregar.AccessibleDescription = "Agregar";
            this.Agregar.AccessibleName = "Agregar";
            this.Agregar.Image = global::P0S_EXPRESS.Properties.Resources.boton_mas;
            this.Agregar.Location = new System.Drawing.Point(50, 41);
            this.Agregar.Name = "Agregar";
            this.Agregar.Size = new System.Drawing.Size(24, 22);
            this.Agregar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Agregar.TabIndex = 8;
            this.Agregar.TabStop = false;
            this.Agregar.Click += new System.EventHandler(this.Agregar_Click);
            // 
            // Atras
            // 
            this.Atras.Image = global::P0S_EXPRESS.Properties.Resources.hacia_atras;
            this.Atras.Location = new System.Drawing.Point(749, 414);
            this.Atras.Name = "Atras";
            this.Atras.Size = new System.Drawing.Size(42, 28);
            this.Atras.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Atras.TabIndex = 26;
            this.Atras.TabStop = false;
            this.Atras.Click += new System.EventHandler(this.Atras_Click);
            // 
            // Proveedoress
            // 
            this.AccessibleName = "Agregar";
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.Cursor;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Atras);
            this.Controls.Add(this.Editar);
            this.Controls.Add(this.Agregar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Buscar);
            this.Controls.Add(this.txtprov);
            this.Name = "Proveedoress";
            this.Text = "Proveedores";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Editar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Agregar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Atras)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Editar;
        private System.Windows.Forms.PictureBox Agregar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button Buscar;
        private System.Windows.Forms.TextBox txtprov;
        private System.Windows.Forms.PictureBox Atras;
    }
}