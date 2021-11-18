
namespace UISocialNetwork
{
    partial class GameScoreCreated
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
            this.NameGame = new System.Windows.Forms.Label();
            this.PlayerName = new System.Windows.Forms.Label();
            this.score = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // NameGame
            // 
            this.NameGame.AutoSize = true;
            this.NameGame.Location = new System.Drawing.Point(15, 11);
            this.NameGame.Name = "NameGame";
            this.NameGame.Size = new System.Drawing.Size(73, 13);
            this.NameGame.TabIndex = 0;
            this.NameGame.Text = "NombreJuego";
            // 
            // PlayerName
            // 
            this.PlayerName.AutoSize = true;
            this.PlayerName.Location = new System.Drawing.Point(15, 33);
            this.PlayerName.Name = "PlayerName";
            this.PlayerName.Size = new System.Drawing.Size(82, 13);
            this.PlayerName.TabIndex = 1;
            this.PlayerName.Text = "NombreJugador";
            // 
            // score
            // 
            this.score.AutoSize = true;
            this.score.Location = new System.Drawing.Point(132, 22);
            this.score.Name = "score";
            this.score.Size = new System.Drawing.Size(33, 13);
            this.score.TabIndex = 2;
            this.score.Text = "score";
            // 
            // GameScoreCreated
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.score);
            this.Controls.Add(this.PlayerName);
            this.Controls.Add(this.NameGame);
            this.Name = "GameScoreCreated";
            this.Size = new System.Drawing.Size(236, 72);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NameGame;
        private System.Windows.Forms.Label PlayerName;
        private System.Windows.Forms.Label score;
    }
}
