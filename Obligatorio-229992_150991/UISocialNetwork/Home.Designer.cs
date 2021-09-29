
namespace UISocialNetwork
{
    partial class Home
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
            this.searchBox = new System.Windows.Forms.TextBox();
            this.userList = new System.Windows.Forms.ListBox();
            this.searchBtn = new System.Windows.Forms.Button();
            this.lblErrorMsg = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // searchBox
            // 
            this.searchBox.Location = new System.Drawing.Point(18, 4);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(225, 20);
            this.searchBox.TabIndex = 0;
            this.searchBox.Text = "Buscar usuario";
            this.searchBox.Click += new System.EventHandler(this.searchBox_Click);
            // 
            // userList
            // 
            this.userList.FormattingEnabled = true;
            this.userList.Location = new System.Drawing.Point(18, 31);
            this.userList.Name = "userList";
            this.userList.Size = new System.Drawing.Size(225, 95);
            this.userList.TabIndex = 1;
            this.userList.Visible = false;
            this.userList.DoubleClick += new System.EventHandler(this.userList_DoubleClick);
            // 
            // searchBtn
            // 
            this.searchBtn.Location = new System.Drawing.Point(262, 4);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(124, 20);
            this.searchBtn.TabIndex = 2;
            this.searchBtn.Text = "Buscar";
            this.searchBtn.UseVisualStyleBackColor = true;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // lblErrorMsg
            // 
            this.lblErrorMsg.AutoSize = true;
            this.lblErrorMsg.Location = new System.Drawing.Point(262, 31);
            this.lblErrorMsg.Name = "lblErrorMsg";
            this.lblErrorMsg.Size = new System.Drawing.Size(29, 13);
            this.lblErrorMsg.TabIndex = 3;
            this.lblErrorMsg.Text = "Error";
            this.lblErrorMsg.Visible = false;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblErrorMsg);
            this.Controls.Add(this.searchBtn);
            this.Controls.Add(this.userList);
            this.Controls.Add(this.searchBox);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Home";
            this.Size = new System.Drawing.Size(634, 715);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox searchBox;
        private System.Windows.Forms.ListBox userList;
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.Label lblErrorMsg;
    }
}
