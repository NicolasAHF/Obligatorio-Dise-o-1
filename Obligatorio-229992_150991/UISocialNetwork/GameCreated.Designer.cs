
namespace UISocialNetwork
{
    partial class GameCreated
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
            this.coverPBox = new System.Windows.Forms.PictureBox();
            this.categoryLbl = new System.Windows.Forms.Label();
            this.nameLbl = new System.Windows.Forms.Label();
            this.playGameBtn = new System.Windows.Forms.Button();
            this.gamePanel = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.coverPBox)).BeginInit();
            this.SuspendLayout();
            // 
            // coverPBox
            // 
            this.coverPBox.Location = new System.Drawing.Point(20, 27);
            this.coverPBox.Name = "coverPBox";
            this.coverPBox.Size = new System.Drawing.Size(96, 91);
            this.coverPBox.TabIndex = 5;
            this.coverPBox.TabStop = false;
            // 
            // categoryLbl
            // 
            this.categoryLbl.AutoSize = true;
            this.categoryLbl.Location = new System.Drawing.Point(152, 77);
            this.categoryLbl.Name = "categoryLbl";
            this.categoryLbl.Size = new System.Drawing.Size(52, 13);
            this.categoryLbl.TabIndex = 7;
            this.categoryLbl.Text = "Categoria";
            // 
            // nameLbl
            // 
            this.nameLbl.AutoSize = true;
            this.nameLbl.Location = new System.Drawing.Point(160, 43);
            this.nameLbl.Name = "nameLbl";
            this.nameLbl.Size = new System.Drawing.Size(44, 13);
            this.nameLbl.TabIndex = 6;
            this.nameLbl.Text = "Nombre";
            // 
            // playGameBtn
            // 
            this.playGameBtn.BackColor = System.Drawing.Color.Maroon;
            this.playGameBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.playGameBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.playGameBtn.Location = new System.Drawing.Point(32, 139);
            this.playGameBtn.Name = "playGameBtn";
            this.playGameBtn.Size = new System.Drawing.Size(75, 23);
            this.playGameBtn.TabIndex = 8;
            this.playGameBtn.Text = "Jugar";
            this.playGameBtn.UseVisualStyleBackColor = false;
            this.playGameBtn.Click += new System.EventHandler(this.playGameBtn_Click);
            // 
            // gamePanel
            // 
            this.gamePanel.Location = new System.Drawing.Point(20, 177);
            this.gamePanel.Name = "gamePanel";
            this.gamePanel.Size = new System.Drawing.Size(200, 100);
            this.gamePanel.TabIndex = 9;
            // 
            // GameCreated
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gamePanel);
            this.Controls.Add(this.playGameBtn);
            this.Controls.Add(this.categoryLbl);
            this.Controls.Add(this.nameLbl);
            this.Controls.Add(this.coverPBox);
            this.Name = "GameCreated";
            this.Size = new System.Drawing.Size(258, 298);
            ((System.ComponentModel.ISupportInitialize)(this.coverPBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox coverPBox;
        private System.Windows.Forms.Label categoryLbl;
        private System.Windows.Forms.Label nameLbl;
        private System.Windows.Forms.Button playGameBtn;
        private System.Windows.Forms.Panel gamePanel;
    }
}
