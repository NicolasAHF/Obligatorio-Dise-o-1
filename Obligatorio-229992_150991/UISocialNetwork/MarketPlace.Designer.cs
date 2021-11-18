
namespace UISocialNetwork
{
    partial class MarketPlace
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
            this.gamesPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.gamesLbl = new System.Windows.Forms.Label();
            this.createGameBtn = new System.Windows.Forms.Button();
            this.crateGamePanel = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // gamesPanel
            // 
            this.gamesPanel.AutoScroll = true;
            this.gamesPanel.FlowDirection = System.Windows.Forms.FlowDirection.BottomUp;
            this.gamesPanel.Location = new System.Drawing.Point(0, 46);
            this.gamesPanel.Name = "gamesPanel";
            this.gamesPanel.Size = new System.Drawing.Size(715, 434);
            this.gamesPanel.TabIndex = 0;
            // 
            // gamesLbl
            // 
            this.gamesLbl.AutoSize = true;
            this.gamesLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.gamesLbl.Location = new System.Drawing.Point(3, 9);
            this.gamesLbl.Name = "gamesLbl";
            this.gamesLbl.Size = new System.Drawing.Size(77, 25);
            this.gamesLbl.TabIndex = 1;
            this.gamesLbl.Text = "Juegos";
            // 
            // createGameBtn
            // 
            this.createGameBtn.BackColor = System.Drawing.Color.Maroon;
            this.createGameBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createGameBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.createGameBtn.Location = new System.Drawing.Point(547, 9);
            this.createGameBtn.Name = "createGameBtn";
            this.createGameBtn.Size = new System.Drawing.Size(134, 31);
            this.createGameBtn.TabIndex = 2;
            this.createGameBtn.Text = "Crear Juego";
            this.createGameBtn.UseVisualStyleBackColor = false;
            this.createGameBtn.Visible = false;
            this.createGameBtn.Click += new System.EventHandler(this.createGameBtn_Click);
            // 
            // crateGamePanel
            // 
            this.crateGamePanel.Location = new System.Drawing.Point(283, 9);
            this.crateGamePanel.Name = "crateGamePanel";
            this.crateGamePanel.Size = new System.Drawing.Size(258, 298);
            this.crateGamePanel.TabIndex = 3;
            this.crateGamePanel.Visible = false;
            // 
            // MarketPlace
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.crateGamePanel);
            this.Controls.Add(this.createGameBtn);
            this.Controls.Add(this.gamesLbl);
            this.Controls.Add(this.gamesPanel);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MarketPlace";
            this.Size = new System.Drawing.Size(715, 480);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel gamesPanel;
        private System.Windows.Forms.Label gamesLbl;
        private System.Windows.Forms.Button createGameBtn;
        private System.Windows.Forms.Panel crateGamePanel;
    }
}
