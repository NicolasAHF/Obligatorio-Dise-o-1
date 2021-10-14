
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
            this.SuspendLayout();
            // 
            // usernameLbl
            // 
            this.usernameLbl.AutoSize = true;
            this.usernameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.usernameLbl.Location = new System.Drawing.Point(35, 10);
            this.usernameLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.usernameLbl.Name = "usernameLbl";
            this.usernameLbl.Size = new System.Drawing.Size(102, 25);
            this.usernameLbl.TabIndex = 1;
            this.usernameLbl.Text = "Username";
            // 
            // staticlabelStatusUpdate
            // 
            this.staticlabelStatusUpdate.AutoSize = true;
            this.staticlabelStatusUpdate.Location = new System.Drawing.Point(37, 35);
            this.staticlabelStatusUpdate.Name = "staticlabelStatusUpdate";
            this.staticlabelStatusUpdate.Size = new System.Drawing.Size(140, 13);
            this.staticlabelStatusUpdate.TabIndex = 2;
            this.staticlabelStatusUpdate.Text = "Actualizo su frase de estado";
            // 
            // statusUpdateLbl
            // 
            this.statusUpdateLbl.Location = new System.Drawing.Point(37, 58);
            this.statusUpdateLbl.Name = "statusUpdateLbl";
            this.statusUpdateLbl.Size = new System.Drawing.Size(636, 36);
            this.statusUpdateLbl.TabIndex = 3;
            this.statusUpdateLbl.Text = "label1";
            // 
            // StatusCreated
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.statusUpdateLbl);
            this.Controls.Add(this.staticlabelStatusUpdate);
            this.Controls.Add(this.usernameLbl);
            this.Name = "StatusCreated";
            this.Size = new System.Drawing.Size(712, 105);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label usernameLbl;
        private System.Windows.Forms.Label staticlabelStatusUpdate;
        private System.Windows.Forms.Label statusUpdateLbl;
    }
}
