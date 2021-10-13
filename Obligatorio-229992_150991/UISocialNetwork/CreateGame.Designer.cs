
namespace UISocialNetwork
{
    partial class CreateGame
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
            this.uploadCover = new System.Windows.Forms.Button();
            this.nameLbl = new System.Windows.Forms.Label();
            this.categoryLbl = new System.Windows.Forms.Label();
            this.coverPBox = new System.Windows.Forms.PictureBox();
            this.saveGame = new System.Windows.Forms.Button();
            this.nameTxtBox = new System.Windows.Forms.TextBox();
            this.categoryTxrBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.coverPBox)).BeginInit();
            this.SuspendLayout();
            // 
            // uploadCover
            // 
            this.uploadCover.BackColor = System.Drawing.Color.Maroon;
            this.uploadCover.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.uploadCover.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.uploadCover.Location = new System.Drawing.Point(132, 52);
            this.uploadCover.Name = "uploadCover";
            this.uploadCover.Size = new System.Drawing.Size(75, 23);
            this.uploadCover.TabIndex = 1;
            this.uploadCover.Text = "Subir Foto";
            this.uploadCover.UseVisualStyleBackColor = false;
            this.uploadCover.Click += new System.EventHandler(this.uploadCover_Click);
            // 
            // nameLbl
            // 
            this.nameLbl.AutoSize = true;
            this.nameLbl.Location = new System.Drawing.Point(26, 151);
            this.nameLbl.Name = "nameLbl";
            this.nameLbl.Size = new System.Drawing.Size(47, 13);
            this.nameLbl.TabIndex = 2;
            this.nameLbl.Text = "Nombre:";
            // 
            // categoryLbl
            // 
            this.categoryLbl.AutoSize = true;
            this.categoryLbl.Location = new System.Drawing.Point(26, 192);
            this.categoryLbl.Name = "categoryLbl";
            this.categoryLbl.Size = new System.Drawing.Size(55, 13);
            this.categoryLbl.TabIndex = 3;
            this.categoryLbl.Text = "Categoria:";
            // 
            // coverPBox
            // 
            this.coverPBox.Location = new System.Drawing.Point(15, 22);
            this.coverPBox.Name = "coverPBox";
            this.coverPBox.Size = new System.Drawing.Size(96, 91);
            this.coverPBox.TabIndex = 4;
            this.coverPBox.TabStop = false;
            // 
            // saveGame
            // 
            this.saveGame.BackColor = System.Drawing.Color.Maroon;
            this.saveGame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveGame.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.saveGame.Location = new System.Drawing.Point(90, 242);
            this.saveGame.Name = "saveGame";
            this.saveGame.Size = new System.Drawing.Size(75, 23);
            this.saveGame.TabIndex = 5;
            this.saveGame.Text = "Guardar";
            this.saveGame.UseVisualStyleBackColor = false;
            this.saveGame.Click += new System.EventHandler(this.saveGame_Click);
            // 
            // nameTxtBox
            // 
            this.nameTxtBox.Location = new System.Drawing.Point(79, 148);
            this.nameTxtBox.Name = "nameTxtBox";
            this.nameTxtBox.Size = new System.Drawing.Size(100, 20);
            this.nameTxtBox.TabIndex = 6;
            // 
            // categoryTxrBox
            // 
            this.categoryTxrBox.Location = new System.Drawing.Point(87, 189);
            this.categoryTxrBox.Name = "categoryTxrBox";
            this.categoryTxrBox.Size = new System.Drawing.Size(100, 20);
            this.categoryTxrBox.TabIndex = 7;
            // 
            // CreateGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.categoryTxrBox);
            this.Controls.Add(this.nameTxtBox);
            this.Controls.Add(this.saveGame);
            this.Controls.Add(this.coverPBox);
            this.Controls.Add(this.categoryLbl);
            this.Controls.Add(this.nameLbl);
            this.Controls.Add(this.uploadCover);
            this.Name = "CreateGame";
            this.Size = new System.Drawing.Size(258, 298);
            ((System.ComponentModel.ISupportInitialize)(this.coverPBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button uploadCover;
        private System.Windows.Forms.Label nameLbl;
        private System.Windows.Forms.Label categoryLbl;
        private System.Windows.Forms.PictureBox coverPBox;
        private System.Windows.Forms.Button saveGame;
        private System.Windows.Forms.TextBox nameTxtBox;
        private System.Windows.Forms.TextBox categoryTxrBox;
    }
}
