
namespace UISocialNetwork
{
    partial class StatusCreated
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
            this.staticlabelStatusUpdate = new System.Windows.Forms.Label();
            this.statusUpdateLbl = new System.Windows.Forms.Label();
            this.commentBtn = new System.Windows.Forms.Button();
            this.commentPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.loveBtn = new System.Windows.Forms.Button();
            this.congratsBtn = new System.Windows.Forms.Button();
            this.likeBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // usernameLbl
            // 
            this.usernameLbl.AutoSize = true;
            this.usernameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.usernameLbl.Location = new System.Drawing.Point(2, 17);
            this.usernameLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.usernameLbl.Name = "usernameLbl";
            this.usernameLbl.Size = new System.Drawing.Size(102, 25);
            this.usernameLbl.TabIndex = 1;
            this.usernameLbl.Text = "Username";
            // 
            // staticlabelStatusUpdate
            // 
            this.staticlabelStatusUpdate.AutoSize = true;
            this.staticlabelStatusUpdate.Location = new System.Drawing.Point(4, 42);
            this.staticlabelStatusUpdate.Name = "staticlabelStatusUpdate";
            this.staticlabelStatusUpdate.Size = new System.Drawing.Size(140, 13);
            this.staticlabelStatusUpdate.TabIndex = 2;
            this.staticlabelStatusUpdate.Text = "Actualizo su frase de estado";
            // 
            // statusUpdateLbl
            // 
            this.statusUpdateLbl.Location = new System.Drawing.Point(4, 64);
            this.statusUpdateLbl.Name = "statusUpdateLbl";
            this.statusUpdateLbl.Size = new System.Drawing.Size(636, 36);
            this.statusUpdateLbl.TabIndex = 3;
            this.statusUpdateLbl.Text = "label1";
            // 
            // commentBtn
            // 
            this.commentBtn.BackColor = System.Drawing.Color.Maroon;
            this.commentBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.commentBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.commentBtn.Location = new System.Drawing.Point(793, 120);
            this.commentBtn.Name = "commentBtn";
            this.commentBtn.Size = new System.Drawing.Size(75, 23);
            this.commentBtn.TabIndex = 19;
            this.commentBtn.Text = "Comentar";
            this.commentBtn.UseVisualStyleBackColor = false;
            this.commentBtn.Click += new System.EventHandler(this.commentBtn_Click);
            // 
            // commentPanel
            // 
            this.commentPanel.AutoSize = true;
            this.commentPanel.FlowDirection = System.Windows.Forms.FlowDirection.BottomUp;
            this.commentPanel.Location = new System.Drawing.Point(29, 149);
            this.commentPanel.Name = "commentPanel";
            this.commentPanel.Size = new System.Drawing.Size(863, 22);
            this.commentPanel.TabIndex = 18;
            // 
            // loveBtn
            // 
            this.loveBtn.BackColor = System.Drawing.Color.Maroon;
            this.loveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loveBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.loveBtn.Location = new System.Drawing.Point(288, 119);
            this.loveBtn.Name = "loveBtn";
            this.loveBtn.Size = new System.Drawing.Size(75, 23);
            this.loveBtn.TabIndex = 17;
            this.loveBtn.Text = "Me Encanta";
            this.loveBtn.UseVisualStyleBackColor = false;
            // 
            // congratsBtn
            // 
            this.congratsBtn.BackColor = System.Drawing.Color.Maroon;
            this.congratsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.congratsBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.congratsBtn.Location = new System.Drawing.Point(148, 119);
            this.congratsBtn.Name = "congratsBtn";
            this.congratsBtn.Size = new System.Drawing.Size(88, 23);
            this.congratsBtn.TabIndex = 16;
            this.congratsBtn.Text = "Felicitaciones";
            this.congratsBtn.UseVisualStyleBackColor = false;
            // 
            // likeBtn
            // 
            this.likeBtn.BackColor = System.Drawing.Color.Maroon;
            this.likeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.likeBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.likeBtn.Location = new System.Drawing.Point(29, 119);
            this.likeBtn.Name = "likeBtn";
            this.likeBtn.Size = new System.Drawing.Size(75, 23);
            this.likeBtn.TabIndex = 15;
            this.likeBtn.Text = "Me Gusta";
            this.likeBtn.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Maroon;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(900, 14);
            this.panel1.TabIndex = 20;
            // 
            // StatusCreated
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.commentBtn);
            this.Controls.Add(this.commentPanel);
            this.Controls.Add(this.loveBtn);
            this.Controls.Add(this.congratsBtn);
            this.Controls.Add(this.likeBtn);
            this.Controls.Add(this.statusUpdateLbl);
            this.Controls.Add(this.staticlabelStatusUpdate);
            this.Controls.Add(this.usernameLbl);
            this.Name = "StatusCreated";
            this.Size = new System.Drawing.Size(900, 180);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label usernameLbl;
        private System.Windows.Forms.Label staticlabelStatusUpdate;
        private System.Windows.Forms.Label statusUpdateLbl;
        private System.Windows.Forms.Button commentBtn;
        private System.Windows.Forms.FlowLayoutPanel commentPanel;
        private System.Windows.Forms.Button loveBtn;
        private System.Windows.Forms.Button congratsBtn;
        private System.Windows.Forms.Button likeBtn;
        private System.Windows.Forms.Panel panel1;
    }
}
