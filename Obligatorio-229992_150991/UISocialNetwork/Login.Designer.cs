
namespace UISocialNetwork
{
    partial class Login
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

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.LoginBtn = new System.Windows.Forms.Button();
<<<<<<< HEAD
            this.PasswordTextBox = new System.Windows.Forms.TextBox();
            this.UsernameTextBox = new System.Windows.Forms.TextBox();
            this.lblErrorMsg = new System.Windows.Forms.Label();
            this.underlineUsername = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
=======
            this.PasswordLbL = new System.Windows.Forms.Label();
            this.UsernameLbl = new System.Windows.Forms.Label();
            this.PasswordTextBox = new System.Windows.Forms.TextBox();
            this.UsernameTextBox = new System.Windows.Forms.TextBox();
>>>>>>> user
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
<<<<<<< HEAD
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.label1.Location = new System.Drawing.Point(230, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 46);
=======
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label1.Location = new System.Drawing.Point(223, 43);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 39);
>>>>>>> user
            this.label1.TabIndex = 7;
            this.label1.Text = "Login";
            // 
            // LoginBtn
            // 
            this.LoginBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
<<<<<<< HEAD
            this.LoginBtn.BackColor = System.Drawing.Color.Maroon;
            this.LoginBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LoginBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.LoginBtn.Location = new System.Drawing.Point(128, 235);
            this.LoginBtn.Name = "LoginBtn";
            this.LoginBtn.Size = new System.Drawing.Size(269, 32);
            this.LoginBtn.TabIndex = 12;
            this.LoginBtn.Text = "Login";
            this.LoginBtn.UseVisualStyleBackColor = false;
            this.LoginBtn.Click += new System.EventHandler(this.LoginBtn_Click);
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PasswordTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PasswordTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.PasswordTextBox.ForeColor = System.Drawing.Color.Maroon;
            this.PasswordTextBox.Location = new System.Drawing.Point(129, 159);
            this.PasswordTextBox.Multiline = true;
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.Size = new System.Drawing.Size(268, 22);
            this.PasswordTextBox.TabIndex = 9;
            this.PasswordTextBox.Text = "Contraseña";
            this.PasswordTextBox.UseSystemPasswordChar = true;
            this.PasswordTextBox.Enter += new System.EventHandler(this.PasswordTextBox_Enter);
            this.PasswordTextBox.Leave += new System.EventHandler(this.PasswordTextBox_Leave);
=======
            this.LoginBtn.Location = new System.Drawing.Point(231, 289);
            this.LoginBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.LoginBtn.Name = "LoginBtn";
            this.LoginBtn.Size = new System.Drawing.Size(176, 28);
            this.LoginBtn.TabIndex = 12;
            this.LoginBtn.Text = "Login";
            this.LoginBtn.UseVisualStyleBackColor = true;
            this.LoginBtn.Click += new System.EventHandler(this.LoginBtn_Click);
            // 
            // PasswordLbL
            // 
            this.PasswordLbL.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PasswordLbL.AutoSize = true;
            this.PasswordLbL.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.PasswordLbL.Location = new System.Drawing.Point(49, 224);
            this.PasswordLbL.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PasswordLbL.Name = "PasswordLbL";
            this.PasswordLbL.Size = new System.Drawing.Size(100, 20);
            this.PasswordLbL.TabIndex = 11;
            this.PasswordLbL.Text = "Contraseña:";
            // 
            // UsernameLbl
            // 
            this.UsernameLbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.UsernameLbl.AutoSize = true;
            this.UsernameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.UsernameLbl.Location = new System.Drawing.Point(45, 162);
            this.UsernameLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.UsernameLbl.Name = "UsernameLbl";
            this.UsernameLbl.Size = new System.Drawing.Size(156, 20);
            this.UsernameLbl.TabIndex = 10;
            this.UsernameLbl.Text = "Nombre de usuario:";
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PasswordTextBox.Location = new System.Drawing.Point(231, 217);
            this.PasswordTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.Size = new System.Drawing.Size(175, 22);
            this.PasswordTextBox.TabIndex = 9;
            this.PasswordTextBox.UseSystemPasswordChar = true;
>>>>>>> user
            // 
            // UsernameTextBox
            // 
            this.UsernameTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
<<<<<<< HEAD
            this.UsernameTextBox.BackColor = System.Drawing.Color.White;
            this.UsernameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.UsernameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.UsernameTextBox.ForeColor = System.Drawing.Color.Maroon;
            this.UsernameTextBox.Location = new System.Drawing.Point(129, 110);
            this.UsernameTextBox.Multiline = true;
            this.UsernameTextBox.Name = "UsernameTextBox";
            this.UsernameTextBox.Size = new System.Drawing.Size(268, 22);
            this.UsernameTextBox.TabIndex = 8;
            this.UsernameTextBox.Text = "Nombre de usuario";
            this.UsernameTextBox.Enter += new System.EventHandler(this.UsernameTextBox_Enter);
            this.UsernameTextBox.Leave += new System.EventHandler(this.UsernameTextBox_Leave);
            // 
            // lblErrorMsg
            // 
            this.lblErrorMsg.AutoSize = true;
            this.lblErrorMsg.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblErrorMsg.Location = new System.Drawing.Point(126, 291);
            this.lblErrorMsg.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblErrorMsg.Name = "lblErrorMsg";
            this.lblErrorMsg.Size = new System.Drawing.Size(44, 20);
            this.lblErrorMsg.TabIndex = 13;
            this.lblErrorMsg.Text = "Error";
            this.lblErrorMsg.Visible = false;
            // 
            // underlineUsername
            // 
            this.underlineUsername.BackColor = System.Drawing.Color.Maroon;
            this.underlineUsername.Location = new System.Drawing.Point(129, 134);
            this.underlineUsername.Name = "underlineUsername";
            this.underlineUsername.Size = new System.Drawing.Size(269, 1);
            this.underlineUsername.TabIndex = 14;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Maroon;
            this.panel1.Location = new System.Drawing.Point(129, 184);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(269, 1);
            this.panel1.TabIndex = 15;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Controls.Add(this.UsernameTextBox);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.underlineUsername);
            this.Controls.Add(this.lblErrorMsg);
            this.Controls.Add(this.LoginBtn);
            this.Controls.Add(this.PasswordTextBox);
            this.Controls.Add(this.label1);
            this.Name = "Login";
            this.Size = new System.Drawing.Size(634, 415);
=======
            this.UsernameTextBox.Location = new System.Drawing.Point(231, 159);
            this.UsernameTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.UsernameTextBox.Name = "UsernameTextBox";
            this.UsernameTextBox.Size = new System.Drawing.Size(175, 22);
            this.UsernameTextBox.TabIndex = 8;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.LoginBtn);
            this.Controls.Add(this.PasswordLbL);
            this.Controls.Add(this.UsernameLbl);
            this.Controls.Add(this.PasswordTextBox);
            this.Controls.Add(this.UsernameTextBox);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Login";
            this.Size = new System.Drawing.Size(600, 554);
>>>>>>> user
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button LoginBtn;
<<<<<<< HEAD
        private System.Windows.Forms.TextBox PasswordTextBox;
        private System.Windows.Forms.TextBox UsernameTextBox;
        private System.Windows.Forms.Label lblErrorMsg;
        private System.Windows.Forms.Panel underlineUsername;
        private System.Windows.Forms.Panel panel1;
=======
        private System.Windows.Forms.Label PasswordLbL;
        private System.Windows.Forms.Label UsernameLbl;
        private System.Windows.Forms.TextBox PasswordTextBox;
        private System.Windows.Forms.TextBox UsernameTextBox;
>>>>>>> user
    }
}
