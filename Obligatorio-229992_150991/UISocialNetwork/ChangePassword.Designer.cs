
namespace UISocialNetwork
{
    partial class ChangePassword
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
            this.button1 = new System.Windows.Forms.Button();
            this.newPasswordTxtBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.currentPassword = new System.Windows.Forms.Label();
            this.currentPasswordTxtBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Maroon;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(33, 159);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(164, 42);
            this.button1.TabIndex = 0;
            this.button1.Text = "Guardar Nueva Contraseña";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.SavePassword_Click);
            // 
            // newPasswordTxtBox
            // 
            this.newPasswordTxtBox.Location = new System.Drawing.Point(132, 87);
            this.newPasswordTxtBox.Name = "newPasswordTxtBox";
            this.newPasswordTxtBox.Size = new System.Drawing.Size(100, 20);
            this.newPasswordTxtBox.TabIndex = 1;
            this.newPasswordTxtBox.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nueva Contraseña";
            // 
            // currentPassword
            // 
            this.currentPassword.AutoSize = true;
            this.currentPassword.Location = new System.Drawing.Point(38, 45);
            this.currentPassword.Name = "currentPassword";
            this.currentPassword.Size = new System.Drawing.Size(88, 13);
            this.currentPassword.TabIndex = 3;
            this.currentPassword.Text = "Contraeña actual";
            // 
            // currentPasswordTxtBox
            // 
            this.currentPasswordTxtBox.Location = new System.Drawing.Point(132, 45);
            this.currentPasswordTxtBox.Name = "currentPasswordTxtBox";
            this.currentPasswordTxtBox.Size = new System.Drawing.Size(100, 20);
            this.currentPasswordTxtBox.TabIndex = 4;
            this.currentPasswordTxtBox.UseSystemPasswordChar = true;
            // 
            // ChangePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.currentPasswordTxtBox);
            this.Controls.Add(this.currentPassword);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.newPasswordTxtBox);
            this.Controls.Add(this.button1);
            this.Name = "ChangePassword";
            this.Size = new System.Drawing.Size(520, 326);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox newPasswordTxtBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label currentPassword;
        private System.Windows.Forms.TextBox currentPasswordTxtBox;
    }
}
