
namespace UISocialNetwork
{
    partial class ListeningNowCreated
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
            this.usernameLbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.songLbl = new System.Windows.Forms.Label();
            this.albumLbl = new System.Windows.Forms.Label();
            this.artistLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // usernameLbl
            // 
            this.usernameLbl.AutoSize = true;
            this.usernameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.usernameLbl.Location = new System.Drawing.Point(30, 8);
            this.usernameLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.usernameLbl.Name = "usernameLbl";
            this.usernameLbl.Size = new System.Drawing.Size(102, 25);
            this.usernameLbl.TabIndex = 0;
            this.usernameLbl.Text = "Username";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 35);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(238, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Actualizo la cancion que esta escuchando ahora";
            // 
            // songLbl
            // 
            this.songLbl.AutoSize = true;
            this.songLbl.Location = new System.Drawing.Point(34, 65);
            this.songLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.songLbl.Name = "songLbl";
            this.songLbl.Size = new System.Drawing.Size(49, 13);
            this.songLbl.TabIndex = 2;
            this.songLbl.Text = "Cancion:";
            // 
            // albumLbl
            // 
            this.albumLbl.AutoSize = true;
            this.albumLbl.Location = new System.Drawing.Point(200, 65);
            this.albumLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.albumLbl.Name = "albumLbl";
            this.albumLbl.Size = new System.Drawing.Size(39, 13);
            this.albumLbl.TabIndex = 3;
            this.albumLbl.Text = "Album:";
            // 
            // artistLbl
            // 
            this.artistLbl.AutoSize = true;
            this.artistLbl.Location = new System.Drawing.Point(366, 65);
            this.artistLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.artistLbl.Name = "artistLbl";
            this.artistLbl.Size = new System.Drawing.Size(39, 13);
            this.artistLbl.TabIndex = 4;
            this.artistLbl.Text = "Artista:";
            // 
            // ListeningNowCreated
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.artistLbl);
            this.Controls.Add(this.albumLbl);
            this.Controls.Add(this.songLbl);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.usernameLbl);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ListeningNowCreated";
            this.Size = new System.Drawing.Size(712, 105);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label usernameLbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label songLbl;
        private System.Windows.Forms.Label albumLbl;
        private System.Windows.Forms.Label artistLbl;
    }
}
