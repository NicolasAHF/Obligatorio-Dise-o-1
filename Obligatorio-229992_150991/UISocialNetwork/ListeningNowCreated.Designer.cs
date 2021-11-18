
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.commentBtn = new System.Windows.Forms.Button();
            this.commentPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.loveBtn = new System.Windows.Forms.Button();
            this.congratsBtn = new System.Windows.Forms.Button();
            this.likeBtn = new System.Windows.Forms.Button();
            this.loveCount = new System.Windows.Forms.Label();
            this.congratsCount = new System.Windows.Forms.Label();
            this.likeCount = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // usernameLbl
            // 
            this.usernameLbl.AutoSize = true;
            this.usernameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.usernameLbl.Location = new System.Drawing.Point(30, 18);
            this.usernameLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.usernameLbl.Name = "usernameLbl";
            this.usernameLbl.Size = new System.Drawing.Size(102, 25);
            this.usernameLbl.TabIndex = 0;
            this.usernameLbl.Text = "Username";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 45);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(238, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Actualizo la cancion que esta escuchando ahora";
            // 
            // songLbl
            // 
            this.songLbl.AutoSize = true;
            this.songLbl.Location = new System.Drawing.Point(34, 75);
            this.songLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.songLbl.Name = "songLbl";
            this.songLbl.Size = new System.Drawing.Size(49, 13);
            this.songLbl.TabIndex = 2;
            this.songLbl.Text = "Cancion:";
            // 
            // albumLbl
            // 
            this.albumLbl.AutoSize = true;
            this.albumLbl.Location = new System.Drawing.Point(200, 75);
            this.albumLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.albumLbl.Name = "albumLbl";
            this.albumLbl.Size = new System.Drawing.Size(39, 13);
            this.albumLbl.TabIndex = 3;
            this.albumLbl.Text = "Album:";
            // 
            // artistLbl
            // 
            this.artistLbl.AutoSize = true;
            this.artistLbl.Location = new System.Drawing.Point(366, 75);
            this.artistLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.artistLbl.Name = "artistLbl";
            this.artistLbl.Size = new System.Drawing.Size(39, 13);
            this.artistLbl.TabIndex = 4;
            this.artistLbl.Text = "Artista:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Maroon;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(900, 14);
            this.panel1.TabIndex = 5;
            // 
            // commentBtn
            // 
            this.commentBtn.BackColor = System.Drawing.Color.Maroon;
            this.commentBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.commentBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.commentBtn.Location = new System.Drawing.Point(798, 102);
            this.commentBtn.Name = "commentBtn";
            this.commentBtn.Size = new System.Drawing.Size(75, 23);
            this.commentBtn.TabIndex = 14;
            this.commentBtn.Text = "Comentar";
            this.commentBtn.UseVisualStyleBackColor = false;
            this.commentBtn.Click += new System.EventHandler(this.commentBtn_Click);
            // 
            // commentPanel
            // 
            this.commentPanel.AutoSize = true;
            this.commentPanel.FlowDirection = System.Windows.Forms.FlowDirection.BottomUp;
            this.commentPanel.Location = new System.Drawing.Point(37, 131);
            this.commentPanel.Name = "commentPanel";
            this.commentPanel.Size = new System.Drawing.Size(860, 22);
            this.commentPanel.TabIndex = 13;
            // 
            // loveBtn
            // 
            this.loveBtn.BackColor = System.Drawing.Color.Maroon;
            this.loveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loveBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.loveBtn.Location = new System.Drawing.Point(287, 101);
            this.loveBtn.Name = "loveBtn";
            this.loveBtn.Size = new System.Drawing.Size(75, 23);
            this.loveBtn.TabIndex = 12;
            this.loveBtn.Text = "Me Encanta";
            this.loveBtn.UseVisualStyleBackColor = false;
            this.loveBtn.Click += new System.EventHandler(this.loveBtn_Click);
            // 
            // congratsBtn
            // 
            this.congratsBtn.BackColor = System.Drawing.Color.Maroon;
            this.congratsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.congratsBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.congratsBtn.Location = new System.Drawing.Point(151, 101);
            this.congratsBtn.Name = "congratsBtn";
            this.congratsBtn.Size = new System.Drawing.Size(88, 23);
            this.congratsBtn.TabIndex = 11;
            this.congratsBtn.Text = "Felicitaciones";
            this.congratsBtn.UseVisualStyleBackColor = false;
            this.congratsBtn.Click += new System.EventHandler(this.congratsBtn_Click);
            // 
            // likeBtn
            // 
            this.likeBtn.BackColor = System.Drawing.Color.Maroon;
            this.likeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.likeBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.likeBtn.Location = new System.Drawing.Point(35, 101);
            this.likeBtn.Name = "likeBtn";
            this.likeBtn.Size = new System.Drawing.Size(75, 23);
            this.likeBtn.TabIndex = 10;
            this.likeBtn.Text = "Me Gusta";
            this.likeBtn.UseVisualStyleBackColor = false;
            this.likeBtn.Click += new System.EventHandler(this.likeBtn_Click);
            // 
            // loveCount
            // 
            this.loveCount.AutoSize = true;
            this.loveCount.Location = new System.Drawing.Point(368, 107);
            this.loveCount.Name = "loveCount";
            this.loveCount.Size = new System.Drawing.Size(13, 13);
            this.loveCount.TabIndex = 17;
            this.loveCount.Text = "0";
            // 
            // congratsCount
            // 
            this.congratsCount.AutoSize = true;
            this.congratsCount.Location = new System.Drawing.Point(245, 107);
            this.congratsCount.Name = "congratsCount";
            this.congratsCount.Size = new System.Drawing.Size(13, 13);
            this.congratsCount.TabIndex = 16;
            this.congratsCount.Text = "0";
            // 
            // likeCount
            // 
            this.likeCount.AutoSize = true;
            this.likeCount.Location = new System.Drawing.Point(116, 107);
            this.likeCount.Name = "likeCount";
            this.likeCount.Size = new System.Drawing.Size(13, 13);
            this.likeCount.TabIndex = 15;
            this.likeCount.Text = "0";
            // 
            // ListeningNowCreated
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.loveCount);
            this.Controls.Add(this.congratsCount);
            this.Controls.Add(this.likeCount);
            this.Controls.Add(this.commentBtn);
            this.Controls.Add(this.commentPanel);
            this.Controls.Add(this.loveBtn);
            this.Controls.Add(this.congratsBtn);
            this.Controls.Add(this.likeBtn);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.artistLbl);
            this.Controls.Add(this.albumLbl);
            this.Controls.Add(this.songLbl);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.usernameLbl);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ListeningNowCreated";
            this.Size = new System.Drawing.Size(900, 157);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label usernameLbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label songLbl;
        private System.Windows.Forms.Label albumLbl;
        private System.Windows.Forms.Label artistLbl;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button commentBtn;
        private System.Windows.Forms.FlowLayoutPanel commentPanel;
        private System.Windows.Forms.Button loveBtn;
        private System.Windows.Forms.Button congratsBtn;
        private System.Windows.Forms.Button likeBtn;
        private System.Windows.Forms.Label loveCount;
        private System.Windows.Forms.Label congratsCount;
        private System.Windows.Forms.Label likeCount;
    }
}
