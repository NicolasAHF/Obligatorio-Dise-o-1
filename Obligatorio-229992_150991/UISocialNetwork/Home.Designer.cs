
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
            this.listeningBtn = new System.Windows.Forms.Button();
            this.panelContent = new System.Windows.Forms.Panel();
            this.panelButtons = new System.Windows.Forms.Panel();
            this.showContentPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.createAlbumBtn = new System.Windows.Forms.Button();
            this.panelButtons.SuspendLayout();
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
            // listeningBtn
            // 
            this.listeningBtn.Location = new System.Drawing.Point(429, 4);
            this.listeningBtn.Name = "listeningBtn";
            this.listeningBtn.Size = new System.Drawing.Size(132, 20);
            this.listeningBtn.TabIndex = 4;
            this.listeningBtn.Text = "Que estas escuchando";
            this.listeningBtn.UseVisualStyleBackColor = true;
            this.listeningBtn.Click += new System.EventHandler(this.listeningBtn_Click);
            // 
            // panelContent
            // 
            this.panelContent.AutoScroll = true;
            this.panelContent.AutoSize = true;
            this.panelContent.Location = new System.Drawing.Point(0, 92);
            this.panelContent.Name = "panelContent";
            this.panelContent.Size = new System.Drawing.Size(712, 105);
            this.panelContent.TabIndex = 5;
            // 
            // panelButtons
            // 
            this.panelButtons.Controls.Add(this.createAlbumBtn);
            this.panelButtons.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelButtons.Location = new System.Drawing.Point(0, 0);
            this.panelButtons.Name = "panelButtons";
            this.panelButtons.Size = new System.Drawing.Size(716, 86);
            this.panelButtons.TabIndex = 6;
            // 
            // showContentPanel
            // 
            this.showContentPanel.AutoSize = true;
            this.showContentPanel.FlowDirection = System.Windows.Forms.FlowDirection.BottomUp;
            this.showContentPanel.Location = new System.Drawing.Point(3, 203);
            this.showContentPanel.Name = "showContentPanel";
            this.showContentPanel.Size = new System.Drawing.Size(709, 131);
            this.showContentPanel.TabIndex = 7;
            // 
            // createAlbumBtn
            // 
            this.createAlbumBtn.Location = new System.Drawing.Point(567, 4);
            this.createAlbumBtn.Name = "createAlbumBtn";
            this.createAlbumBtn.Size = new System.Drawing.Size(132, 20);
            this.createAlbumBtn.TabIndex = 8;
            this.createAlbumBtn.Text = "Crear Album";
            this.createAlbumBtn.UseVisualStyleBackColor = true;
            this.createAlbumBtn.Click += new System.EventHandler(this.createAlbumBtn_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.Controls.Add(this.listeningBtn);
            this.Controls.Add(this.lblErrorMsg);
            this.Controls.Add(this.searchBtn);
            this.Controls.Add(this.userList);
            this.Controls.Add(this.searchBox);
            this.Controls.Add(this.panelButtons);
            this.Controls.Add(this.panelContent);
            this.Controls.Add(this.showContentPanel);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Home";
            this.Size = new System.Drawing.Size(716, 480);
            this.panelButtons.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox searchBox;
        private System.Windows.Forms.ListBox userList;
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.Label lblErrorMsg;
        private System.Windows.Forms.Button listeningBtn;
        private System.Windows.Forms.Panel panelContent;
        private System.Windows.Forms.Panel panelButtons;
        private System.Windows.Forms.FlowLayoutPanel showContentPanel;
        private System.Windows.Forms.Button createAlbumBtn;
    }
}
