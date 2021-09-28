
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
            this.modifyUserBtn = new System.Windows.Forms.Button();
            this.lblUsernameProfile = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.namelblModify = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // modifyUserBtn
            // 
            this.modifyUserBtn.Location = new System.Drawing.Point(345, 6);
            this.modifyUserBtn.Name = "modifyUserBtn";
            this.modifyUserBtn.Size = new System.Drawing.Size(208, 41);
            this.modifyUserBtn.TabIndex = 0;
            this.modifyUserBtn.Text = "Modificar Usuario";
            this.modifyUserBtn.UseVisualStyleBackColor = true;
            this.modifyUserBtn.Click += new System.EventHandler(this.modifyUserBtn_Click);
            // 
            // lblUsernameProfile
            // 
            this.lblUsernameProfile.AutoSize = true;
            this.lblUsernameProfile.Location = new System.Drawing.Point(102, 17);
            this.lblUsernameProfile.Name = "lblUsernameProfile";
            this.lblUsernameProfile.Size = new System.Drawing.Size(55, 13);
            this.lblUsernameProfile.TabIndex = 1;
            this.lblUsernameProfile.Text = "Username";
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(345, 53);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(208, 353);
            this.panel1.TabIndex = 2;
            this.panel1.Visible = false;
            // 
            // namelblModify
            // 
            this.namelblModify.AutoSize = true;
            this.namelblModify.Location = new System.Drawing.Point(105, 34);
            this.namelblModify.Name = "namelblModify";
            this.namelblModify.Size = new System.Drawing.Size(35, 13);
            this.namelblModify.TabIndex = 3;
            this.namelblModify.Text = "Name";
            // 
            // Profile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.namelblModify);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblUsernameProfile);
            this.Controls.Add(this.modifyUserBtn);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Profile";
            this.Size = new System.Drawing.Size(637, 409);
            this.Load += new System.EventHandler(this.Profile_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button modifyUserBtn;
        private System.Windows.Forms.Label lblUsernameProfile;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label namelblModify;
    }
}
