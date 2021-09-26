
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
            ((System.ComponentModel.ISupportInitialize)(this.avatar)).BeginInit();
            this.SuspendLayout();
            // 
            // avatar
            // 
            this.avatar.Location = new System.Drawing.Point(15, 18);
            this.avatar.Name = "avatar";
            this.avatar.Size = new System.Drawing.Size(145, 138);
            this.avatar.TabIndex = 0;
            this.avatar.TabStop = false;
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblUsername.Location = new System.Drawing.Point(166, 18);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(102, 25);
            this.lblUsername.TabIndex = 2;
            this.lblUsername.Text = "Username";
            // 
            // modifyUser
            // 
            this.modifyUser.Location = new System.Drawing.Point(605, 10);
            this.modifyUser.Name = "modifyUser";
            this.modifyUser.Size = new System.Drawing.Size(157, 46);
            this.modifyUser.TabIndex = 3;
            this.modifyUser.Text = "Modificar Usuario";
            this.modifyUser.UseVisualStyleBackColor = true;
            this.modifyUser.Click += new System.EventHandler(this.modifyUser_Click);
            // 
            // modifyPanel
            // 
            this.modifyPanel.Location = new System.Drawing.Point(511, 70);
            this.modifyPanel.Name = "modifyPanel";
            this.modifyPanel.Size = new System.Drawing.Size(278, 479);
            this.modifyPanel.TabIndex = 4;
            this.modifyPanel.Visible = false;
            // 
            // completeNameLbl
            // 
            this.completeNameLbl.AutoSize = true;
            this.completeNameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.completeNameLbl.Location = new System.Drawing.Point(171, 47);
            this.completeNameLbl.Name = "completeNameLbl";
            this.completeNameLbl.Size = new System.Drawing.Size(143, 20);
            this.completeNameLbl.TabIndex = 5;
            this.completeNameLbl.Text = "Nombre y apellido";
            // 
            // Profile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.completeNameLbl);
            this.Controls.Add(this.modifyPanel);
            this.Controls.Add(this.modifyUser);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.avatar);
            this.Name = "Profile";
            this.Size = new System.Drawing.Size(825, 488);
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
    }
}
