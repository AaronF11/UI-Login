namespace UI_Login
{
    partial class DlgLogin
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DlgLogin));
            this.BtnCerrar = new System.Windows.Forms.Button();
            this.TxtProfile = new System.Windows.Forms.TextBox();
            this.PnlControles = new System.Windows.Forms.Panel();
            this.PtbPassWord = new System.Windows.Forms.PictureBox();
            this.PtbProfile = new System.Windows.Forms.PictureBox();
            this.BtnVisibleInvisible = new System.Windows.Forms.Button();
            this.BtnLogIn = new System.Windows.Forms.Button();
            this.LblTitulo = new System.Windows.Forms.Label();
            this.TxtPassWord = new System.Windows.Forms.TextBox();
            this.LblPassWord = new System.Windows.Forms.Label();
            this.LblProfile = new System.Windows.Forms.Label();
            this.BtnFaceBook = new System.Windows.Forms.Button();
            this.BtnGoogle = new System.Windows.Forms.Button();
            this.BtnMail = new System.Windows.Forms.Button();
            this.PnlControles.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PtbPassWord)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PtbProfile)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnCerrar
            // 
            this.BtnCerrar.BackColor = System.Drawing.Color.Transparent;
            this.BtnCerrar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnCerrar.BackgroundImage")));
            this.BtnCerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnCerrar.FlatAppearance.BorderSize = 0;
            this.BtnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCerrar.Location = new System.Drawing.Point(365, 3);
            this.BtnCerrar.Name = "BtnCerrar";
            this.BtnCerrar.Size = new System.Drawing.Size(32, 32);
            this.BtnCerrar.TabIndex = 0;
            this.BtnCerrar.UseVisualStyleBackColor = false;
            this.BtnCerrar.Click += new System.EventHandler(this.BtnCerrar_Click);
            // 
            // TxtProfile
            // 
            this.TxtProfile.BackColor = System.Drawing.Color.White;
            this.TxtProfile.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtProfile.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtProfile.Location = new System.Drawing.Point(40, 137);
            this.TxtProfile.Multiline = true;
            this.TxtProfile.Name = "TxtProfile";
            this.TxtProfile.Size = new System.Drawing.Size(300, 40);
            this.TxtProfile.TabIndex = 0;
            // 
            // PnlControles
            // 
            this.PnlControles.BackColor = System.Drawing.Color.Transparent;
            this.PnlControles.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PnlControles.Controls.Add(this.PtbPassWord);
            this.PnlControles.Controls.Add(this.PtbProfile);
            this.PnlControles.Controls.Add(this.BtnVisibleInvisible);
            this.PnlControles.Controls.Add(this.BtnLogIn);
            this.PnlControles.Controls.Add(this.LblTitulo);
            this.PnlControles.Controls.Add(this.TxtPassWord);
            this.PnlControles.Controls.Add(this.LblPassWord);
            this.PnlControles.Controls.Add(this.TxtProfile);
            this.PnlControles.Controls.Add(this.LblProfile);
            this.PnlControles.Location = new System.Drawing.Point(12, 47);
            this.PnlControles.Name = "PnlControles";
            this.PnlControles.Size = new System.Drawing.Size(376, 441);
            this.PnlControles.TabIndex = 1;
            // 
            // PtbPassWord
            // 
            this.PtbPassWord.Image = global::UI_Login.Properties.Resources.Password;
            this.PtbPassWord.Location = new System.Drawing.Point(40, 195);
            this.PtbPassWord.Name = "PtbPassWord";
            this.PtbPassWord.Size = new System.Drawing.Size(32, 32);
            this.PtbPassWord.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PtbPassWord.TabIndex = 7;
            this.PtbPassWord.TabStop = false;
            // 
            // PtbProfile
            // 
            this.PtbProfile.Image = global::UI_Login.Properties.Resources.Profile;
            this.PtbProfile.Location = new System.Drawing.Point(40, 99);
            this.PtbProfile.Name = "PtbProfile";
            this.PtbProfile.Size = new System.Drawing.Size(32, 32);
            this.PtbProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PtbProfile.TabIndex = 6;
            this.PtbProfile.TabStop = false;
            // 
            // BtnVisibleInvisible
            // 
            this.BtnVisibleInvisible.BackColor = System.Drawing.Color.White;
            this.BtnVisibleInvisible.BackgroundImage = global::UI_Login.Properties.Resources.Visible;
            this.BtnVisibleInvisible.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnVisibleInvisible.FlatAppearance.BorderSize = 0;
            this.BtnVisibleInvisible.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnVisibleInvisible.Location = new System.Drawing.Point(306, 237);
            this.BtnVisibleInvisible.Name = "BtnVisibleInvisible";
            this.BtnVisibleInvisible.Size = new System.Drawing.Size(32, 32);
            this.BtnVisibleInvisible.TabIndex = 2;
            this.BtnVisibleInvisible.UseVisualStyleBackColor = false;
            // 
            // BtnLogIn
            // 
            this.BtnLogIn.BackColor = System.Drawing.Color.Transparent;
            this.BtnLogIn.BackgroundImage = global::UI_Login.Properties.Resources.Enter;
            this.BtnLogIn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BtnLogIn.FlatAppearance.BorderSize = 0;
            this.BtnLogIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnLogIn.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLogIn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnLogIn.Location = new System.Drawing.Point(40, 317);
            this.BtnLogIn.Name = "BtnLogIn";
            this.BtnLogIn.Size = new System.Drawing.Size(300, 65);
            this.BtnLogIn.TabIndex = 5;
            this.BtnLogIn.UseVisualStyleBackColor = false;
            // 
            // LblTitulo
            // 
            this.LblTitulo.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTitulo.ForeColor = System.Drawing.Color.White;
            this.LblTitulo.Location = new System.Drawing.Point(39, 28);
            this.LblTitulo.Name = "LblTitulo";
            this.LblTitulo.Size = new System.Drawing.Size(304, 51);
            this.LblTitulo.TabIndex = 4;
            this.LblTitulo.Text = "LOGIN";
            this.LblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TxtPassWord
            // 
            this.TxtPassWord.BackColor = System.Drawing.Color.White;
            this.TxtPassWord.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtPassWord.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPassWord.Location = new System.Drawing.Point(40, 233);
            this.TxtPassWord.Multiline = true;
            this.TxtPassWord.Name = "TxtPassWord";
            this.TxtPassWord.Size = new System.Drawing.Size(300, 40);
            this.TxtPassWord.TabIndex = 2;
            // 
            // LblPassWord
            // 
            this.LblPassWord.AutoSize = true;
            this.LblPassWord.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPassWord.ForeColor = System.Drawing.Color.White;
            this.LblPassWord.Location = new System.Drawing.Point(37, 262);
            this.LblPassWord.Name = "LblPassWord";
            this.LblPassWord.Size = new System.Drawing.Size(306, 21);
            this.LblPassWord.TabIndex = 3;
            this.LblPassWord.Text = "_____________________________________";
            // 
            // LblProfile
            // 
            this.LblProfile.AutoSize = true;
            this.LblProfile.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblProfile.ForeColor = System.Drawing.Color.White;
            this.LblProfile.Location = new System.Drawing.Point(37, 168);
            this.LblProfile.Name = "LblProfile";
            this.LblProfile.Size = new System.Drawing.Size(306, 21);
            this.LblProfile.TabIndex = 1;
            this.LblProfile.Text = "_____________________________________";
            // 
            // BtnFaceBook
            // 
            this.BtnFaceBook.BackColor = System.Drawing.Color.Transparent;
            this.BtnFaceBook.BackgroundImage = global::UI_Login.Properties.Resources.Facebook;
            this.BtnFaceBook.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnFaceBook.FlatAppearance.BorderSize = 0;
            this.BtnFaceBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnFaceBook.Location = new System.Drawing.Point(141, 494);
            this.BtnFaceBook.Name = "BtnFaceBook";
            this.BtnFaceBook.Size = new System.Drawing.Size(32, 32);
            this.BtnFaceBook.TabIndex = 2;
            this.BtnFaceBook.UseVisualStyleBackColor = false;
            // 
            // BtnGoogle
            // 
            this.BtnGoogle.BackColor = System.Drawing.Color.Transparent;
            this.BtnGoogle.BackgroundImage = global::UI_Login.Properties.Resources.Google;
            this.BtnGoogle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnGoogle.FlatAppearance.BorderSize = 0;
            this.BtnGoogle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnGoogle.Location = new System.Drawing.Point(192, 494);
            this.BtnGoogle.Name = "BtnGoogle";
            this.BtnGoogle.Size = new System.Drawing.Size(32, 32);
            this.BtnGoogle.TabIndex = 3;
            this.BtnGoogle.UseVisualStyleBackColor = false;
            // 
            // BtnMail
            // 
            this.BtnMail.BackColor = System.Drawing.Color.Transparent;
            this.BtnMail.BackgroundImage = global::UI_Login.Properties.Resources.Email;
            this.BtnMail.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnMail.FlatAppearance.BorderSize = 0;
            this.BtnMail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMail.Location = new System.Drawing.Point(244, 494);
            this.BtnMail.Name = "BtnMail";
            this.BtnMail.Size = new System.Drawing.Size(32, 32);
            this.BtnMail.TabIndex = 4;
            this.BtnMail.UseVisualStyleBackColor = false;
            // 
            // DlgLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::UI_Login.Properties.Resources.Background2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(400, 550);
            this.Controls.Add(this.BtnMail);
            this.Controls.Add(this.BtnGoogle);
            this.Controls.Add(this.BtnFaceBook);
            this.Controls.Add(this.PnlControles);
            this.Controls.Add(this.BtnCerrar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DlgLogin";
            this.Opacity = 0.8D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.PnlControles.ResumeLayout(false);
            this.PnlControles.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PtbPassWord)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PtbProfile)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnCerrar;
        private System.Windows.Forms.TextBox TxtProfile;
        private System.Windows.Forms.Panel PnlControles;
        private System.Windows.Forms.TextBox TxtPassWord;
        private System.Windows.Forms.Label LblPassWord;
        private System.Windows.Forms.Label LblProfile;
        private System.Windows.Forms.Button BtnLogIn;
        private System.Windows.Forms.Label LblTitulo;
        private System.Windows.Forms.Button BtnVisibleInvisible;
        private System.Windows.Forms.PictureBox PtbPassWord;
        private System.Windows.Forms.PictureBox PtbProfile;
        private System.Windows.Forms.Button BtnFaceBook;
        private System.Windows.Forms.Button BtnGoogle;
        private System.Windows.Forms.Button BtnMail;
    }
}

