namespace P0S_EXPRESS.FORMS
{
    partial class INICIO
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(INICIO));
            this.btnLogin = new System.Windows.Forms.Button();
            this.USER = new System.Windows.Forms.TextBox();
            this.PW = new System.Windows.Forms.TextBox();
            this.USUARIO = new System.Windows.Forms.Label();
            this.CONTRASEÑA = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(89, 335);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(133, 50);
            this.btnLogin.TabIndex = 0;
            this.btnLogin.Text = "INICIO";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // USER
            // 
            this.USER.Location = new System.Drawing.Point(55, 172);
            this.USER.Name = "USER";
            this.USER.Size = new System.Drawing.Size(203, 20);
            this.USER.TabIndex = 1;
            // 
            // PW
            // 
            this.PW.Location = new System.Drawing.Point(55, 252);
            this.PW.Name = "PW";
            this.PW.PasswordChar = '*';
            this.PW.Size = new System.Drawing.Size(203, 20);
            this.PW.TabIndex = 2;
            this.PW.TextChanged += new System.EventHandler(this.PW_TextChanged);
            // 
            // USUARIO
            // 
            this.USUARIO.AutoSize = true;
            this.USUARIO.Location = new System.Drawing.Point(124, 156);
            this.USUARIO.Name = "USUARIO";
            this.USUARIO.Size = new System.Drawing.Size(56, 13);
            this.USUARIO.TabIndex = 3;
            this.USUARIO.Text = "USUARIO";
            // 
            // CONTRASEÑA
            // 
            this.CONTRASEÑA.AutoSize = true;
            this.CONTRASEÑA.Location = new System.Drawing.Point(115, 236);
            this.CONTRASEÑA.Name = "CONTRASEÑA";
            this.CONTRASEÑA.Size = new System.Drawing.Size(81, 13);
            this.CONTRASEÑA.TabIndex = 4;
            this.CONTRASEÑA.Text = "CONTRASEÑA";
            this.CONTRASEÑA.Click += new System.EventHandler(this.CONTRASEÑA_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::P0S_EXPRESS.Properties.Resources.Logotipo_de_Empresa_Tecnológica_Moderno_Azul_y_Verde__315_x_315_px___2_1;
            this.pictureBox1.Location = new System.Drawing.Point(63, 51);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(186, 102);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // INICIO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(320, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.CONTRASEÑA);
            this.Controls.Add(this.USUARIO);
            this.Controls.Add(this.PW);
            this.Controls.Add(this.USER);
            this.Controls.Add(this.btnLogin);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(336, 489);
            this.MinimumSize = new System.Drawing.Size(336, 489);
            this.Name = "INICIO";
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.TextBox USER;
        private System.Windows.Forms.TextBox PW;
        private System.Windows.Forms.Label USUARIO;
        private System.Windows.Forms.Label CONTRASEÑA;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}