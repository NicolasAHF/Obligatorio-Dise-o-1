
namespace UISocialNetwork
{
    partial class CreateListeningNow
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
            this.songLbl = new System.Windows.Forms.Label();
            this.songTxtBox = new System.Windows.Forms.TextBox();
            this.artistTxtBox = new System.Windows.Forms.TextBox();
            this.artistaLbl = new System.Windows.Forms.Label();
            this.albumTxtBox = new System.Windows.Forms.TextBox();
            this.albumLbl = new System.Windows.Forms.Label();
            this.saveListeningNowBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // songLbl
            // 
            this.songLbl.AutoSize = true;
            this.songLbl.Location = new System.Drawing.Point(38, 88);
            this.songLbl.Name = "songLbl";
            this.songLbl.Size = new System.Drawing.Size(59, 17);
            this.songLbl.TabIndex = 0;
            this.songLbl.Text = "Cancion";
            // 
            // songTxtBox
            // 
            this.songTxtBox.Location = new System.Drawing.Point(115, 88);
            this.songTxtBox.Name = "songTxtBox";
            this.songTxtBox.Size = new System.Drawing.Size(100, 22);
            this.songTxtBox.TabIndex = 1;
            // 
            // artistTxtBox
            // 
            this.artistTxtBox.Location = new System.Drawing.Point(115, 163);
            this.artistTxtBox.Name = "artistTxtBox";
            this.artistTxtBox.Size = new System.Drawing.Size(100, 22);
            this.artistTxtBox.TabIndex = 3;
            // 
            // artistaLbl
            // 
            this.artistaLbl.AutoSize = true;
            this.artistaLbl.Location = new System.Drawing.Point(38, 163);
            this.artistaLbl.Name = "artistaLbl";
            this.artistaLbl.Size = new System.Drawing.Size(48, 17);
            this.artistaLbl.TabIndex = 2;
            this.artistaLbl.Text = "Artista";
            // 
            // albumTxtBox
            // 
            this.albumTxtBox.Location = new System.Drawing.Point(115, 126);
            this.albumTxtBox.Name = "albumTxtBox";
            this.albumTxtBox.Size = new System.Drawing.Size(100, 22);
            this.albumTxtBox.TabIndex = 5;
            // 
            // albumLbl
            // 
            this.albumLbl.AutoSize = true;
            this.albumLbl.Location = new System.Drawing.Point(38, 126);
            this.albumLbl.Name = "albumLbl";
            this.albumLbl.Size = new System.Drawing.Size(47, 17);
            this.albumLbl.TabIndex = 4;
            this.albumLbl.Text = "Album";
            // 
            // saveListeningNowBtn
            // 
            this.saveListeningNowBtn.Location = new System.Drawing.Point(342, 126);
            this.saveListeningNowBtn.Name = "saveListeningNowBtn";
            this.saveListeningNowBtn.Size = new System.Drawing.Size(75, 23);
            this.saveListeningNowBtn.TabIndex = 6;
            this.saveListeningNowBtn.Text = "Guardar";
            this.saveListeningNowBtn.UseVisualStyleBackColor = true;
            this.saveListeningNowBtn.Click += new System.EventHandler(this.saveListeningNowBtn_Click);
            // 
            // ListeningNowCreate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.saveListeningNowBtn);
            this.Controls.Add(this.albumTxtBox);
            this.Controls.Add(this.albumLbl);
            this.Controls.Add(this.artistTxtBox);
            this.Controls.Add(this.artistaLbl);
            this.Controls.Add(this.songTxtBox);
            this.Controls.Add(this.songLbl);
            this.Name = "ListeningNowCreate";
            this.Size = new System.Drawing.Size(520, 326);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label songLbl;
        private System.Windows.Forms.TextBox songTxtBox;
        private System.Windows.Forms.TextBox artistTxtBox;
        private System.Windows.Forms.Label artistaLbl;
        private System.Windows.Forms.TextBox albumTxtBox;
        private System.Windows.Forms.Label albumLbl;
        private System.Windows.Forms.Button saveListeningNowBtn;
    }
}
