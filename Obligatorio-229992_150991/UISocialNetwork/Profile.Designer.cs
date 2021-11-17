
namespace UISocialNetwork
{
    partial class Profile
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
            this.avatar = new System.Windows.Forms.PictureBox();
            this.lblUsername = new System.Windows.Forms.Label();
            this.modifyUser = new System.Windows.Forms.Button();
            this.modifyPanel = new System.Windows.Forms.Panel();
            this.completeNameLbl = new System.Windows.Forms.Label();
            this.followBtn = new System.Windows.Forms.Button();
            this.passwordPanel = new System.Windows.Forms.Panel();
            this.changePasswordBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.avatar)).BeginInit();
            this.SuspendLayout();
            // 
            // avatar
            // 
            this.avatar.Location = new System.Drawing.Point(11, 15);
            this.avatar.Margin = new System.Windows.Forms.Padding(2);
            this.avatar.Name = "avatar";
            this.avatar.Size = new System.Drawing.Size(109, 112);
            this.avatar.TabIndex = 0;
            this.avatar.TabStop = false;
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblUsername.Location = new System.Drawing.Point(124, 15);
            this.lblUsername.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(83, 20);
            this.lblUsername.TabIndex = 2;
            this.lblUsername.Text = "Username";
            // 
            // modifyUser
            // 
            this.modifyUser.BackColor = System.Drawing.Color.Maroon;
            this.modifyUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.modifyUser.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.modifyUser.Location = new System.Drawing.Point(452, 15);
            this.modifyUser.Margin = new System.Windows.Forms.Padding(2);
            this.modifyUser.Name = "modifyUser";
            this.modifyUser.Size = new System.Drawing.Size(118, 37);
            this.modifyUser.TabIndex = 3;
            this.modifyUser.Text = "Modificar Usuario";
            this.modifyUser.UseVisualStyleBackColor = false;
            this.modifyUser.Click += new System.EventHandler(this.modifyUser_Click);
            // 
            // modifyPanel
            // 
            this.modifyPanel.Location = new System.Drawing.Point(383, 57);
            this.modifyPanel.Margin = new System.Windows.Forms.Padding(2);
            this.modifyPanel.Name = "modifyPanel";
            this.modifyPanel.Size = new System.Drawing.Size(208, 262);
            this.modifyPanel.TabIndex = 4;
            this.modifyPanel.Visible = false;
            // 
            // completeNameLbl
            // 
            this.completeNameLbl.AutoSize = true;
            this.completeNameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.completeNameLbl.Location = new System.Drawing.Point(128, 38);
            this.completeNameLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.completeNameLbl.Name = "completeNameLbl";
            this.completeNameLbl.Size = new System.Drawing.Size(122, 17);
            this.completeNameLbl.TabIndex = 5;
            this.completeNameLbl.Text = "Nombre y apellido";
            // 
            // followBtn
            // 
            this.followBtn.BackColor = System.Drawing.Color.Maroon;
            this.followBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.followBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.followBtn.Location = new System.Drawing.Point(304, 15);
            this.followBtn.Name = "followBtn";
            this.followBtn.Size = new System.Drawing.Size(106, 37);
            this.followBtn.TabIndex = 8;
            this.followBtn.Text = "Seguir";
            this.followBtn.UseVisualStyleBackColor = false;
            this.followBtn.Click += new System.EventHandler(this.followBtn_Click);
            this.followBtn.MouseLeave += new System.EventHandler(this.followBtn_MouseLeave);
            this.followBtn.MouseHover += new System.EventHandler(this.followBtn_MouseHover);
            // 
            // passwordPanel
            // 
            this.passwordPanel.Location = new System.Drawing.Point(11, 179);
            this.passwordPanel.Name = "passwordPanel";
            this.passwordPanel.Size = new System.Drawing.Size(356, 204);
            this.passwordPanel.TabIndex = 9;
            // 
            // changePasswordBtn
            // 
            this.changePasswordBtn.BackColor = System.Drawing.Color.Maroon;
            this.changePasswordBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.changePasswordBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.changePasswordBtn.Location = new System.Drawing.Point(14, 136);
            this.changePasswordBtn.Name = "changePasswordBtn";
            this.changePasswordBtn.Size = new System.Drawing.Size(106, 37);
            this.changePasswordBtn.TabIndex = 10;
            this.changePasswordBtn.Text = "Cambiar Contraseña";
            this.changePasswordBtn.UseVisualStyleBackColor = false;
            this.changePasswordBtn.Click += new System.EventHandler(this.changePasswordBtn_Click);
            // 
            // Profile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.changePasswordBtn);
            this.Controls.Add(this.passwordPanel);
            this.Controls.Add(this.followBtn);
            this.Controls.Add(this.completeNameLbl);
            this.Controls.Add(this.modifyPanel);
            this.Controls.Add(this.modifyUser);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.avatar);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Profile";
            this.Size = new System.Drawing.Size(619, 396);
            this.Load += new System.EventHandler(this.Profile_Load);
            ((System.ComponentModel.ISupportInitialize)(this.avatar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox avatar;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Button modifyUser;
        private System.Windows.Forms.Panel modifyPanel;
        private System.Windows.Forms.Label completeNameLbl;
        private System.Windows.Forms.Button followBtn;
        private System.Windows.Forms.Panel passwordPanel;
        private System.Windows.Forms.Button changePasswordBtn;
    }
}
