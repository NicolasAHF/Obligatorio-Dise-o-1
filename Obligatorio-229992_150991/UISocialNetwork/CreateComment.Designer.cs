
namespace UISocialNetwork
{
    partial class CreateComment
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
            this.commentString = new System.Windows.Forms.TextBox();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.saveCommenBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // commentString
            // 
            this.commentString.Location = new System.Drawing.Point(17, 15);
            this.commentString.Multiline = true;
            this.commentString.Name = "commentString";
            this.commentString.Size = new System.Drawing.Size(480, 55);
            this.commentString.TabIndex = 0;
            // 
            // cancelBtn
            // 
            this.cancelBtn.BackColor = System.Drawing.Color.Maroon;
            this.cancelBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cancelBtn.Location = new System.Drawing.Point(143, 94);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(75, 23);
            this.cancelBtn.TabIndex = 1;
            this.cancelBtn.Text = "Cancelar";
            this.cancelBtn.UseVisualStyleBackColor = false;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // saveCommenBtn
            // 
            this.saveCommenBtn.BackColor = System.Drawing.Color.Maroon;
            this.saveCommenBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveCommenBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.saveCommenBtn.Location = new System.Drawing.Point(285, 94);
            this.saveCommenBtn.Name = "saveCommenBtn";
            this.saveCommenBtn.Size = new System.Drawing.Size(75, 23);
            this.saveCommenBtn.TabIndex = 2;
            this.saveCommenBtn.Text = "Comentar";
            this.saveCommenBtn.UseVisualStyleBackColor = false;
            this.saveCommenBtn.Click += new System.EventHandler(this.saveCommenBtn_Click);
            // 
            // CreateComment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.saveCommenBtn);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.commentString);
            this.Name = "CreateComment";
            this.Size = new System.Drawing.Size(520, 130);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox commentString;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Button saveCommenBtn;
    }
}
