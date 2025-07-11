﻿
namespace UISocialNetwork
{
    partial class CommentCreated
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
            this.commentBody = new System.Windows.Forms.TextBox();
            this.likeBtn = new System.Windows.Forms.Button();
            this.congratsBtn = new System.Windows.Forms.Button();
            this.loveBtn = new System.Windows.Forms.Button();
            this.likeCount = new System.Windows.Forms.Label();
            this.congratsCount = new System.Windows.Forms.Label();
            this.loveCount = new System.Windows.Forms.Label();
            this.commentBtn = new System.Windows.Forms.Button();
            this.commentPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.date = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // usernameLbl
            // 
            this.usernameLbl.AutoSize = true;
            this.usernameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.usernameLbl.Location = new System.Drawing.Point(21, 17);
            this.usernameLbl.Name = "usernameLbl";
            this.usernameLbl.Size = new System.Drawing.Size(102, 25);
            this.usernameLbl.TabIndex = 0;
            this.usernameLbl.Text = "Username";
            // 
            // commentBody
            // 
            this.commentBody.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.commentBody.HideSelection = false;
            this.commentBody.Location = new System.Drawing.Point(26, 40);
            this.commentBody.Multiline = true;
            this.commentBody.Name = "commentBody";
            this.commentBody.ReadOnly = true;
            this.commentBody.Size = new System.Drawing.Size(456, 46);
            this.commentBody.TabIndex = 1;
            // 
            // likeBtn
            // 
            this.likeBtn.BackColor = System.Drawing.Color.Maroon;
            this.likeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.likeBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.likeBtn.Location = new System.Drawing.Point(26, 92);
            this.likeBtn.Name = "likeBtn";
            this.likeBtn.Size = new System.Drawing.Size(75, 23);
            this.likeBtn.TabIndex = 2;
            this.likeBtn.Text = "Me Gusta";
            this.likeBtn.UseVisualStyleBackColor = false;
            this.likeBtn.Click += new System.EventHandler(this.likeBtn_Click);
            // 
            // congratsBtn
            // 
            this.congratsBtn.BackColor = System.Drawing.Color.Maroon;
            this.congratsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.congratsBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.congratsBtn.Location = new System.Drawing.Point(132, 92);
            this.congratsBtn.Name = "congratsBtn";
            this.congratsBtn.Size = new System.Drawing.Size(82, 23);
            this.congratsBtn.TabIndex = 3;
            this.congratsBtn.Text = "Felicitaciones";
            this.congratsBtn.UseVisualStyleBackColor = false;
            this.congratsBtn.Click += new System.EventHandler(this.congratsBtn_Click);
            // 
            // loveBtn
            // 
            this.loveBtn.BackColor = System.Drawing.Color.Maroon;
            this.loveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loveBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.loveBtn.Location = new System.Drawing.Point(248, 92);
            this.loveBtn.Name = "loveBtn";
            this.loveBtn.Size = new System.Drawing.Size(75, 23);
            this.loveBtn.TabIndex = 4;
            this.loveBtn.Text = "Me Encanta";
            this.loveBtn.UseVisualStyleBackColor = false;
            this.loveBtn.Click += new System.EventHandler(this.loveBtn_Click);
            // 
            // likeCount
            // 
            this.likeCount.AutoSize = true;
            this.likeCount.Location = new System.Drawing.Point(107, 97);
            this.likeCount.Name = "likeCount";
            this.likeCount.Size = new System.Drawing.Size(13, 13);
            this.likeCount.TabIndex = 5;
            this.likeCount.Text = "0";
            // 
            // congratsCount
            // 
            this.congratsCount.AutoSize = true;
            this.congratsCount.Location = new System.Drawing.Point(220, 97);
            this.congratsCount.Name = "congratsCount";
            this.congratsCount.Size = new System.Drawing.Size(13, 13);
            this.congratsCount.TabIndex = 6;
            this.congratsCount.Text = "0";
            // 
            // loveCount
            // 
            this.loveCount.AutoSize = true;
            this.loveCount.Location = new System.Drawing.Point(329, 97);
            this.loveCount.Name = "loveCount";
            this.loveCount.Size = new System.Drawing.Size(13, 13);
            this.loveCount.TabIndex = 7;
            this.loveCount.Text = "0";
            // 
            // commentBtn
            // 
            this.commentBtn.BackColor = System.Drawing.Color.Maroon;
            this.commentBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.commentBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.commentBtn.Location = new System.Drawing.Point(428, 92);
            this.commentBtn.Name = "commentBtn";
            this.commentBtn.Size = new System.Drawing.Size(75, 23);
            this.commentBtn.TabIndex = 8;
            this.commentBtn.Text = "Comentar";
            this.commentBtn.UseVisualStyleBackColor = false;
            this.commentBtn.Click += new System.EventHandler(this.commentBtn_Click);
            // 
            // commentPanel
            // 
            this.commentPanel.AutoSize = true;
            this.commentPanel.Location = new System.Drawing.Point(26, 121);
            this.commentPanel.Name = "commentPanel";
            this.commentPanel.Size = new System.Drawing.Size(834, 19);
            this.commentPanel.TabIndex = 9;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Maroon;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(863, 14);
            this.panel1.TabIndex = 21;
            // 
            // date
            // 
            this.date.AutoSize = true;
            this.date.Location = new System.Drawing.Point(143, 26);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(28, 13);
            this.date.TabIndex = 22;
            this.date.Text = "date";
            // 
            // CommentCreated
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.date);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.commentPanel);
            this.Controls.Add(this.commentBtn);
            this.Controls.Add(this.loveCount);
            this.Controls.Add(this.congratsCount);
            this.Controls.Add(this.likeCount);
            this.Controls.Add(this.loveBtn);
            this.Controls.Add(this.congratsBtn);
            this.Controls.Add(this.likeBtn);
            this.Controls.Add(this.commentBody);
            this.Controls.Add(this.usernameLbl);
            this.Name = "CommentCreated";
            this.Size = new System.Drawing.Size(863, 143);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label usernameLbl;
        private System.Windows.Forms.TextBox commentBody;
        private System.Windows.Forms.Button likeBtn;
        private System.Windows.Forms.Button congratsBtn;
        private System.Windows.Forms.Button loveBtn;
        private System.Windows.Forms.Label likeCount;
        private System.Windows.Forms.Label congratsCount;
        private System.Windows.Forms.Label loveCount;
        private System.Windows.Forms.Button commentBtn;
        private System.Windows.Forms.FlowLayoutPanel commentPanel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label date;
    }
}
