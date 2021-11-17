
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.likeBtn = new System.Windows.Forms.Button();
            this.congratsBtn = new System.Windows.Forms.Button();
            this.loveBtn = new System.Windows.Forms.Button();
            this.commentPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.commentBtn = new System.Windows.Forms.Button();
            this.likeCount = new System.Windows.Forms.Label();
            this.congratsCount = new System.Windows.Forms.Label();
            this.loveCount = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // usernameLblAlbum
            // 
            this.usernameLblAlbum.AutoSize = true;
            this.usernameLblAlbum.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.usernameLblAlbum.Location = new System.Drawing.Point(20, 17);
            this.usernameLblAlbum.Name = "usernameLblAlbum";
            this.usernameLblAlbum.Size = new System.Drawing.Size(102, 25);
            this.usernameLblAlbum.TabIndex = 0;
            this.usernameLblAlbum.Text = "Username";
            // 
            // albumNameLbl
            // 
            this.albumNameLbl.AutoSize = true;
            this.albumNameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.albumNameLbl.Location = new System.Drawing.Point(22, 42);
            this.albumNameLbl.Name = "albumNameLbl";
            this.albumNameLbl.Size = new System.Drawing.Size(84, 17);
            this.albumNameLbl.TabIndex = 1;
            this.albumNameLbl.Text = "AlbumName";
            // 
            // editAlbumBtn
            // 
            this.editAlbumBtn.BackColor = System.Drawing.Color.Maroon;
            this.editAlbumBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editAlbumBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.editAlbumBtn.Location = new System.Drawing.Point(782, 20);
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
            this.albumPanel.Size = new System.Drawing.Size(882, 202);
            this.albumPanel.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Maroon;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(897, 14);
            this.panel1.TabIndex = 4;
            // 
            // likeBtn
            // 
            this.likeBtn.BackColor = System.Drawing.Color.Maroon;
            this.likeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.likeBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.likeBtn.Location = new System.Drawing.Point(31, 270);
            this.likeBtn.Name = "likeBtn";
            this.likeBtn.Size = new System.Drawing.Size(75, 23);
            this.likeBtn.TabIndex = 5;
            this.likeBtn.Text = "Me Gusta";
            this.likeBtn.UseVisualStyleBackColor = false;
            this.likeBtn.Click += new System.EventHandler(this.likeBtn_Click);
            // 
            // congratsBtn
            // 
            this.congratsBtn.BackColor = System.Drawing.Color.Maroon;
            this.congratsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.congratsBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.congratsBtn.Location = new System.Drawing.Point(162, 269);
            this.congratsBtn.Name = "congratsBtn";
            this.congratsBtn.Size = new System.Drawing.Size(89, 23);
            this.congratsBtn.TabIndex = 6;
            this.congratsBtn.Text = "Felicitaciones";
            this.congratsBtn.UseVisualStyleBackColor = false;
            this.congratsBtn.Click += new System.EventHandler(this.congratsBtn_Click);
            // 
            // loveBtn
            // 
            this.loveBtn.BackColor = System.Drawing.Color.Maroon;
            this.loveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loveBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.loveBtn.Location = new System.Drawing.Point(308, 269);
            this.loveBtn.Name = "loveBtn";
            this.loveBtn.Size = new System.Drawing.Size(75, 23);
            this.loveBtn.TabIndex = 7;
            this.loveBtn.Text = "Me Encanta";
            this.loveBtn.UseVisualStyleBackColor = false;
            this.loveBtn.Click += new System.EventHandler(this.loveBtn_Click);
            // 
            // commentPanel
            // 
            this.commentPanel.AutoSize = true;
            this.commentPanel.FlowDirection = System.Windows.Forms.FlowDirection.BottomUp;
            this.commentPanel.Location = new System.Drawing.Point(31, 299);
            this.commentPanel.Name = "commentPanel";
            this.commentPanel.Size = new System.Drawing.Size(851, 22);
            this.commentPanel.TabIndex = 8;
            // 
            // commentBtn
            // 
            this.commentBtn.BackColor = System.Drawing.Color.Maroon;
            this.commentBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.commentBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.commentBtn.Location = new System.Drawing.Point(793, 270);
            this.commentBtn.Name = "commentBtn";
            this.commentBtn.Size = new System.Drawing.Size(75, 23);
            this.commentBtn.TabIndex = 9;
            this.commentBtn.Text = "Comentar";
            this.commentBtn.UseVisualStyleBackColor = false;
            this.commentBtn.Click += new System.EventHandler(this.commentBtn_Click);
            // 
            // likeCount
            // 
            this.likeCount.AutoSize = true;
            this.likeCount.Location = new System.Drawing.Point(112, 274);
            this.likeCount.Name = "likeCount";
            this.likeCount.Size = new System.Drawing.Size(13, 13);
            this.likeCount.TabIndex = 10;
            this.likeCount.Text = "0";
            // 
            // congratsCount
            // 
            this.congratsCount.AutoSize = true;
            this.congratsCount.Location = new System.Drawing.Point(257, 274);
            this.congratsCount.Name = "congratsCount";
            this.congratsCount.Size = new System.Drawing.Size(13, 13);
            this.congratsCount.TabIndex = 11;
            this.congratsCount.Text = "0";
            // 
            // loveCount
            // 
            this.loveCount.AutoSize = true;
            this.loveCount.Location = new System.Drawing.Point(389, 275);
            this.loveCount.Name = "loveCount";
            this.loveCount.Size = new System.Drawing.Size(13, 13);
            this.loveCount.TabIndex = 12;
            this.loveCount.Text = "0";
            // 
            // AlbumCreated
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
            this.Controls.Add(this.albumPanel);
            this.Controls.Add(this.editAlbumBtn);
            this.Controls.Add(this.albumNameLbl);
            this.Controls.Add(this.usernameLblAlbum);
            this.Name = "AlbumCreated";
            this.Size = new System.Drawing.Size(897, 326);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label usernameLblAlbum;
        private System.Windows.Forms.Label albumNameLbl;
        private System.Windows.Forms.Button editAlbumBtn;
        private System.Windows.Forms.FlowLayoutPanel albumPanel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button likeBtn;
        private System.Windows.Forms.Button congratsBtn;
        private System.Windows.Forms.Button loveBtn;
        private System.Windows.Forms.FlowLayoutPanel commentPanel;
        private System.Windows.Forms.Button commentBtn;
        private System.Windows.Forms.Label likeCount;
        private System.Windows.Forms.Label congratsCount;
        private System.Windows.Forms.Label loveCount;
    }
}
