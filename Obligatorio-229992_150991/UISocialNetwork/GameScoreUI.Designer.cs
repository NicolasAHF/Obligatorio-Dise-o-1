
namespace UISocialNetwork
{
    partial class GameScoreUI
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
            this.scoreLbl = new System.Windows.Forms.Label();
            this.scroreTxtBox = new System.Windows.Forms.TextBox();
            this.saveScore = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // scoreLbl
            // 
            this.scoreLbl.AutoSize = true;
            this.scoreLbl.Location = new System.Drawing.Point(20, 17);
            this.scoreLbl.Name = "scoreLbl";
            this.scoreLbl.Size = new System.Drawing.Size(38, 13);
            this.scoreLbl.TabIndex = 0;
            this.scoreLbl.Text = "Score:";
            // 
            // scroreTxtBox
            // 
            this.scroreTxtBox.Location = new System.Drawing.Point(65, 17);
            this.scroreTxtBox.Name = "scroreTxtBox";
            this.scroreTxtBox.Size = new System.Drawing.Size(100, 20);
            this.scroreTxtBox.TabIndex = 1;
            // 
            // saveScore
            // 
            this.saveScore.BackColor = System.Drawing.Color.Maroon;
            this.saveScore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveScore.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.saveScore.Location = new System.Drawing.Point(52, 61);
            this.saveScore.Name = "saveScore";
            this.saveScore.Size = new System.Drawing.Size(75, 23);
            this.saveScore.TabIndex = 2;
            this.saveScore.Text = "Guardar";
            this.saveScore.UseVisualStyleBackColor = false;
            this.saveScore.Click += new System.EventHandler(this.saveScore_Click);
            // 
            // GameScoreUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.saveScore);
            this.Controls.Add(this.scroreTxtBox);
            this.Controls.Add(this.scoreLbl);
            this.Name = "GameScoreUI";
            this.Size = new System.Drawing.Size(200, 100);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label scoreLbl;
        private System.Windows.Forms.TextBox scroreTxtBox;
        private System.Windows.Forms.Button saveScore;
    }
}
