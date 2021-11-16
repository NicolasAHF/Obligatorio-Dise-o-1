
namespace UISocialNetwork
{
    partial class AlbumCreated
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
            this.usernameLblAlbum = new System.Windows.Forms.Label();
            this.albumNameLbl = new System.Windows.Forms.Label();
            this.editAlbumBtn = new System.Windows.Forms.Button();
            this.albumPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.commentPanel = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // usernameLblAlbum
            // 
            this.usernameLblAlbum.AutoSize = true;
            this.usernameLblAlbum.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.usernameLblAlbum.Location = new System.Drawing.Point(18, 10);
            this.usernameLblAlbum.Name = "usernameLblAlbum";
            this.usernameLblAlbum.Size = new System.Drawing.Size(102, 25);
            this.usernameLblAlbum.TabIndex = 0;
            this.usernameLblAlbum.Text = "Username";
            // 
            // albumNameLbl
            // 
            this.albumNameLbl.AutoSize = true;
            this.albumNameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.albumNameLbl.Location = new System.Drawing.Point(20, 32);
            this.albumNameLbl.Name = "albumNameLbl";
            this.albumNameLbl.Size = new System.Drawing.Size(84, 17);
            this.albumNameLbl.TabIndex = 1;
            this.albumNameLbl.Text = "AlbumName";
            // 
            // editAlbumBtn
            // 
            this.editAlbumBtn.BackColor = System.Drawing.Color.Maroon;
            this.editAlbumBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editAlbumBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.editAlbumBtn.Location = new System.Drawing.Point(390, 15);
            this.editAlbumBtn.Name = "editAlbumBtn";
            this.editAlbumBtn.Size = new System.Drawing.Size(86, 35);
            this.editAlbumBtn.TabIndex = 2;
            this.editAlbumBtn.Text = "Editar";
            this.editAlbumBtn.UseVisualStyleBackColor = false;
            this.editAlbumBtn.Click += new System.EventHandler(this.EditAlbumBtn_Click);
            // 
            // albumPanel
            // 
            this.albumPanel.Location = new System.Drawing.Point(0, 60);
            this.albumPanel.Name = "albumPanel";
            this.albumPanel.Size = new System.Drawing.Size(520, 224);
            this.albumPanel.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Maroon;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(518, 10);
            this.panel1.TabIndex = 4;
            // 
            // commentPanel
            // 
            this.commentPanel.AutoScroll = true;
            this.commentPanel.AutoSize = true;
            this.commentPanel.Location = new System.Drawing.Point(0, 307);
            this.commentPanel.Name = "commentPanel";
            this.commentPanel.Size = new System.Drawing.Size(515, 14);
            this.commentPanel.TabIndex = 5;
            // 
            // AlbumCreated
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.commentPanel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.albumPanel);
            this.Controls.Add(this.editAlbumBtn);
            this.Controls.Add(this.albumNameLbl);
            this.Controls.Add(this.usernameLblAlbum);
            this.Cursor = System.Windows.Forms.Cursors.No;
            this.Name = "AlbumCreated";
            this.Size = new System.Drawing.Size(518, 324);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label usernameLblAlbum;
        private System.Windows.Forms.Label albumNameLbl;
        private System.Windows.Forms.Button editAlbumBtn;
        private System.Windows.Forms.FlowLayoutPanel albumPanel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel commentPanel;
    }
}
