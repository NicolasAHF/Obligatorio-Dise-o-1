
namespace UISocialNetwork
{
    partial class CreateAlbum
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
            this.addPhotoBtn = new System.Windows.Forms.Button();
            this.albumNameTxtBox = new System.Windows.Forms.TextBox();
            this.saveAlbumBtn = new System.Windows.Forms.Button();
            this.AlbumPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // addPhotoBtn
            // 
            this.addPhotoBtn.BackColor = System.Drawing.Color.Maroon;
            this.addPhotoBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addPhotoBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.addPhotoBtn.Location = new System.Drawing.Point(28, 14);
            this.addPhotoBtn.Name = "addPhotoBtn";
            this.addPhotoBtn.Size = new System.Drawing.Size(81, 29);
            this.addPhotoBtn.TabIndex = 0;
            this.addPhotoBtn.Text = "Agragar Foto";
            this.addPhotoBtn.UseVisualStyleBackColor = false;
            this.addPhotoBtn.Click += new System.EventHandler(this.AddPhotoBtn_Click);
            // 
            // albumNameTxtBox
            // 
            this.albumNameTxtBox.Location = new System.Drawing.Point(190, 14);
            this.albumNameTxtBox.Name = "albumNameTxtBox";
            this.albumNameTxtBox.Size = new System.Drawing.Size(100, 20);
            this.albumNameTxtBox.TabIndex = 1;
            // 
            // saveAlbumBtn
            // 
            this.saveAlbumBtn.BackColor = System.Drawing.Color.Maroon;
            this.saveAlbumBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveAlbumBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.saveAlbumBtn.Location = new System.Drawing.Point(385, 14);
            this.saveAlbumBtn.Name = "saveAlbumBtn";
            this.saveAlbumBtn.Size = new System.Drawing.Size(81, 29);
            this.saveAlbumBtn.TabIndex = 2;
            this.saveAlbumBtn.Text = "Guardar Album";
            this.saveAlbumBtn.UseVisualStyleBackColor = false;
            this.saveAlbumBtn.Click += new System.EventHandler(this.SaveAlbumBtn_Click);
            // 
            // AlbumPanel
            // 
            this.AlbumPanel.Location = new System.Drawing.Point(0, 62);
            this.AlbumPanel.Name = "AlbumPanel";
            this.AlbumPanel.Size = new System.Drawing.Size(521, 261);
            this.AlbumPanel.TabIndex = 3;
            // 
            // CreateAlbum
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.AlbumPanel);
            this.Controls.Add(this.saveAlbumBtn);
            this.Controls.Add(this.albumNameTxtBox);
            this.Controls.Add(this.addPhotoBtn);
            this.Name = "CreateAlbum";
            this.Size = new System.Drawing.Size(524, 326);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addPhotoBtn;
        private System.Windows.Forms.TextBox albumNameTxtBox;
        private System.Windows.Forms.Button saveAlbumBtn;
        private System.Windows.Forms.FlowLayoutPanel AlbumPanel;
    }
}
