
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
            this.howEliminatePhotoLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // usernameLblAlbum
            // 
            this.usernameLblAlbum.AutoSize = true;
            this.usernameLblAlbum.Location = new System.Drawing.Point(20, 10);
            this.usernameLblAlbum.Name = "usernameLblAlbum";
            this.usernameLblAlbum.Size = new System.Drawing.Size(55, 13);
            this.usernameLblAlbum.TabIndex = 0;
            this.usernameLblAlbum.Text = "Username";
            // 
            // albumNameLbl
            // 
            this.albumNameLbl.AutoSize = true;
            this.albumNameLbl.Location = new System.Drawing.Point(20, 32);
            this.albumNameLbl.Name = "albumNameLbl";
            this.albumNameLbl.Size = new System.Drawing.Size(64, 13);
            this.albumNameLbl.TabIndex = 1;
            this.albumNameLbl.Text = "AlbumName";
            // 
            // editAlbumBtn
            // 
            this.editAlbumBtn.BackColor = System.Drawing.Color.Maroon;
            this.editAlbumBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editAlbumBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.editAlbumBtn.Location = new System.Drawing.Point(387, 10);
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
            this.albumPanel.Size = new System.Drawing.Size(520, 266);
            this.albumPanel.TabIndex = 3;
            // 
            // howEliminatePhotoLbl
            // 
            this.howEliminatePhotoLbl.AutoSize = true;
            this.howEliminatePhotoLbl.Location = new System.Drawing.Point(186, 10);
            this.howEliminatePhotoLbl.Name = "howEliminatePhotoLbl";
            this.howEliminatePhotoLbl.Size = new System.Drawing.Size(63, 13);
            this.howEliminatePhotoLbl.TabIndex = 4;
            this.howEliminatePhotoLbl.Text = "eliminar foto";
            this.howEliminatePhotoLbl.Visible = false;
            // 
            // AlbumCreated
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.howEliminatePhotoLbl);
            this.Controls.Add(this.albumPanel);
            this.Controls.Add(this.editAlbumBtn);
            this.Controls.Add(this.albumNameLbl);
            this.Controls.Add(this.usernameLblAlbum);
            this.Name = "AlbumCreated";
            this.Size = new System.Drawing.Size(520, 326);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label usernameLblAlbum;
        private System.Windows.Forms.Label albumNameLbl;
        private System.Windows.Forms.Button editAlbumBtn;
        private System.Windows.Forms.FlowLayoutPanel albumPanel;
        private System.Windows.Forms.Label howEliminatePhotoLbl;
    }
}
