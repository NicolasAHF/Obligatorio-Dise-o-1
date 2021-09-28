
namespace UISocialNetwork
{
    partial class CreateUserControl
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
            this.lblPath = new System.Windows.Forms.Label();
            this.lblErrorMsg = new System.Windows.Forms.Label();
            this.saveUser = new System.Windows.Forms.Button();
            this.avatarBtn = new System.Windows.Forms.Button();
            this.avatarBox = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cityLbl = new System.Windows.Forms.Label();
            this.textBoxCountry = new System.Windows.Forms.TextBox();
            this.textBoxCity = new System.Windows.Forms.TextBox();
            this.textBoxStreet = new System.Windows.Forms.TextBox();
            this.streetlbl = new System.Windows.Forms.Label();
            this.titleCreateUser = new System.Windows.Forms.Label();
            this.doblbl = new System.Windows.Forms.Label();
            this.dateofbirth = new System.Windows.Forms.DateTimePicker();
            this.textBoxLastname = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.textBoxUsername = new System.Windows.Forms.TextBox();
            this.Lastnamelbl = new System.Windows.Forms.Label();
            this.nameLbl = new System.Windows.Forms.Label();
            this.PasswordlblCreate = new System.Windows.Forms.Label();
            this.UsernamelblCreate = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.avatarBox)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPath
            // 
            this.lblPath.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPath.AutoSize = true;
            this.lblPath.Location = new System.Drawing.Point(68, 329);
            this.lblPath.Name = "lblPath";
            this.lblPath.Size = new System.Drawing.Size(32, 13);
            this.lblPath.TabIndex = 65;
            this.lblPath.Text = "Path:";
            // 
            // lblErrorMsg
            // 
            this.lblErrorMsg.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblErrorMsg.AutoSize = true;
            this.lblErrorMsg.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblErrorMsg.Location = new System.Drawing.Point(201, 401);
            this.lblErrorMsg.Name = "lblErrorMsg";
            this.lblErrorMsg.Size = new System.Drawing.Size(40, 17);
            this.lblErrorMsg.TabIndex = 64;
            this.lblErrorMsg.Text = "Error";
            this.lblErrorMsg.Visible = false;
            // 
            // saveUser
            // 
            this.saveUser.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.saveUser.Location = new System.Drawing.Point(57, 392);
            this.saveUser.Name = "saveUser";
            this.saveUser.Size = new System.Drawing.Size(127, 23);
            this.saveUser.TabIndex = 63;
            this.saveUser.Text = "Guardar Usuario";
            this.saveUser.UseVisualStyleBackColor = true;
            // 
            // avatarBtn
            // 
            this.avatarBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.avatarBtn.Location = new System.Drawing.Point(204, 293);
            this.avatarBtn.Name = "avatarBtn";
            this.avatarBtn.Size = new System.Drawing.Size(75, 23);
            this.avatarBtn.TabIndex = 62;
            this.avatarBtn.Text = "Upload";
            this.avatarBtn.UseVisualStyleBackColor = true;
            // 
            // avatarBox
            // 
            this.avatarBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.avatarBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.avatarBox.Location = new System.Drawing.Point(285, 278);
            this.avatarBox.Name = "avatarBox";
            this.avatarBox.Size = new System.Drawing.Size(150, 111);
            this.avatarBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.avatarBox.TabIndex = 61;
            this.avatarBox.TabStop = false;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(74, 258);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 17);
            this.label1.TabIndex = 60;
            this.label1.Text = "Pais:";
            // 
            // cityLbl
            // 
            this.cityLbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cityLbl.AutoSize = true;
            this.cityLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cityLbl.Location = new System.Drawing.Point(71, 232);
            this.cityLbl.Name = "cityLbl";
            this.cityLbl.Size = new System.Drawing.Size(56, 17);
            this.cityLbl.TabIndex = 59;
            this.cityLbl.Text = "Ciudad:";
            // 
            // textBoxCountry
            // 
            this.textBoxCountry.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxCountry.Location = new System.Drawing.Point(210, 252);
            this.textBoxCountry.Name = "textBoxCountry";
            this.textBoxCountry.Size = new System.Drawing.Size(133, 20);
            this.textBoxCountry.TabIndex = 58;
            // 
            // textBoxCity
            // 
            this.textBoxCity.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxCity.Location = new System.Drawing.Point(210, 226);
            this.textBoxCity.Name = "textBoxCity";
            this.textBoxCity.Size = new System.Drawing.Size(133, 20);
            this.textBoxCity.TabIndex = 57;
            // 
            // textBoxStreet
            // 
            this.textBoxStreet.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxStreet.Location = new System.Drawing.Point(210, 200);
            this.textBoxStreet.Name = "textBoxStreet";
            this.textBoxStreet.Size = new System.Drawing.Size(133, 20);
            this.textBoxStreet.TabIndex = 56;
            // 
            // streetlbl
            // 
            this.streetlbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.streetlbl.AutoSize = true;
            this.streetlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.streetlbl.Location = new System.Drawing.Point(68, 203);
            this.streetlbl.Name = "streetlbl";
            this.streetlbl.Size = new System.Drawing.Size(43, 17);
            this.streetlbl.TabIndex = 55;
            this.streetlbl.Text = "Calle:";
            // 
            // titleCreateUser
            // 
            this.titleCreateUser.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.titleCreateUser.AutoSize = true;
            this.titleCreateUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.titleCreateUser.Location = new System.Drawing.Point(144, 13);
            this.titleCreateUser.Name = "titleCreateUser";
            this.titleCreateUser.Size = new System.Drawing.Size(183, 31);
            this.titleCreateUser.TabIndex = 54;
            this.titleCreateUser.Text = "Crear Usuario";
            // 
            // doblbl
            // 
            this.doblbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.doblbl.AutoSize = true;
            this.doblbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.doblbl.Location = new System.Drawing.Point(68, 170);
            this.doblbl.Name = "doblbl";
            this.doblbl.Size = new System.Drawing.Size(143, 17);
            this.doblbl.TabIndex = 53;
            this.doblbl.Text = "Fecha de nacimiento:";
            // 
            // dateofbirth
            // 
            this.dateofbirth.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dateofbirth.Location = new System.Drawing.Point(217, 167);
            this.dateofbirth.MinDate = new System.DateTime(1941, 1, 1, 0, 0, 0, 0);
            this.dateofbirth.Name = "dateofbirth";
            this.dateofbirth.Size = new System.Drawing.Size(200, 20);
            this.dateofbirth.TabIndex = 52;
            this.dateofbirth.Value = new System.DateTime(2021, 9, 23, 0, 0, 0, 0);
            // 
            // textBoxLastname
            // 
            this.textBoxLastname.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxLastname.Location = new System.Drawing.Point(210, 141);
            this.textBoxLastname.Name = "textBoxLastname";
            this.textBoxLastname.Size = new System.Drawing.Size(133, 20);
            this.textBoxLastname.TabIndex = 51;
            // 
            // textBoxName
            // 
            this.textBoxName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxName.Location = new System.Drawing.Point(210, 115);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(133, 20);
            this.textBoxName.TabIndex = 50;
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxPassword.Location = new System.Drawing.Point(210, 89);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(133, 20);
            this.textBoxPassword.TabIndex = 49;
            this.textBoxPassword.UseSystemPasswordChar = true;
            // 
            // textBoxUsername
            // 
            this.textBoxUsername.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxUsername.Location = new System.Drawing.Point(210, 62);
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.Size = new System.Drawing.Size(133, 20);
            this.textBoxUsername.TabIndex = 48;
            // 
            // Lastnamelbl
            // 
            this.Lastnamelbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Lastnamelbl.AutoSize = true;
            this.Lastnamelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Lastnamelbl.Location = new System.Drawing.Point(68, 144);
            this.Lastnamelbl.Name = "Lastnamelbl";
            this.Lastnamelbl.Size = new System.Drawing.Size(62, 17);
            this.Lastnamelbl.TabIndex = 47;
            this.Lastnamelbl.Text = "Apellido:";
            // 
            // nameLbl
            // 
            this.nameLbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.nameLbl.AutoSize = true;
            this.nameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.nameLbl.Location = new System.Drawing.Point(68, 118);
            this.nameLbl.Name = "nameLbl";
            this.nameLbl.Size = new System.Drawing.Size(62, 17);
            this.nameLbl.TabIndex = 46;
            this.nameLbl.Text = "Nombre:";
            // 
            // PasswordlblCreate
            // 
            this.PasswordlblCreate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PasswordlblCreate.AutoSize = true;
            this.PasswordlblCreate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.PasswordlblCreate.Location = new System.Drawing.Point(68, 92);
            this.PasswordlblCreate.Name = "PasswordlblCreate";
            this.PasswordlblCreate.Size = new System.Drawing.Size(85, 17);
            this.PasswordlblCreate.TabIndex = 45;
            this.PasswordlblCreate.Text = "Contraseña:";
            // 
            // UsernamelblCreate
            // 
            this.UsernamelblCreate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.UsernamelblCreate.AutoSize = true;
            this.UsernamelblCreate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.UsernamelblCreate.Location = new System.Drawing.Point(68, 65);
            this.UsernamelblCreate.Name = "UsernamelblCreate";
            this.UsernamelblCreate.Size = new System.Drawing.Size(133, 17);
            this.UsernamelblCreate.TabIndex = 44;
            this.UsernamelblCreate.Text = "Nombre de usuario:";
            // 
            // CreateUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblPath);
            this.Controls.Add(this.lblErrorMsg);
            this.Controls.Add(this.saveUser);
            this.Controls.Add(this.avatarBtn);
            this.Controls.Add(this.avatarBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cityLbl);
            this.Controls.Add(this.textBoxCountry);
            this.Controls.Add(this.textBoxCity);
            this.Controls.Add(this.textBoxStreet);
            this.Controls.Add(this.streetlbl);
            this.Controls.Add(this.titleCreateUser);
            this.Controls.Add(this.doblbl);
            this.Controls.Add(this.dateofbirth);
            this.Controls.Add(this.textBoxLastname);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.textBoxUsername);
            this.Controls.Add(this.Lastnamelbl);
            this.Controls.Add(this.nameLbl);
            this.Controls.Add(this.PasswordlblCreate);
            this.Controls.Add(this.UsernamelblCreate);
            this.Name = "CreateUserControl";
            this.Size = new System.Drawing.Size(499, 435);
            ((System.ComponentModel.ISupportInitialize)(this.avatarBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPath;
        private System.Windows.Forms.Label lblErrorMsg;
        private System.Windows.Forms.Button saveUser;
        private System.Windows.Forms.Button avatarBtn;
        private System.Windows.Forms.PictureBox avatarBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label cityLbl;
        private System.Windows.Forms.TextBox textBoxCountry;
        private System.Windows.Forms.TextBox textBoxCity;
        private System.Windows.Forms.TextBox textBoxStreet;
        private System.Windows.Forms.Label streetlbl;
        private System.Windows.Forms.Label titleCreateUser;
        private System.Windows.Forms.Label doblbl;
        private System.Windows.Forms.DateTimePicker dateofbirth;
        private System.Windows.Forms.TextBox textBoxLastname;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.TextBox textBoxUsername;
        private System.Windows.Forms.Label Lastnamelbl;
        private System.Windows.Forms.Label nameLbl;
        private System.Windows.Forms.Label PasswordlblCreate;
        private System.Windows.Forms.Label UsernamelblCreate;
    }
}
