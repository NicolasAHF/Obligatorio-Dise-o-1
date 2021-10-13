
namespace UISocialNetwork
{
    partial class CreateStatus
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
            this.saveStatusbtn = new System.Windows.Forms.Button();
            this.statusLbl = new System.Windows.Forms.Label();
            this.statusTxtBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // saveStatusbtn
            // 
            this.saveStatusbtn.BackColor = System.Drawing.Color.Maroon;
            this.saveStatusbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveStatusbtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.saveStatusbtn.Location = new System.Drawing.Point(268, 18);
            this.saveStatusbtn.Name = "saveStatusbtn";
            this.saveStatusbtn.Size = new System.Drawing.Size(87, 33);
            this.saveStatusbtn.TabIndex = 0;
            this.saveStatusbtn.Text = "Guardar";
            this.saveStatusbtn.UseVisualStyleBackColor = false;
            this.saveStatusbtn.Click += new System.EventHandler(this.saveStatusbtn_Click);
            // 
            // statusLbl
            // 
            this.statusLbl.AutoSize = true;
            this.statusLbl.Location = new System.Drawing.Point(21, 38);
            this.statusLbl.Name = "statusLbl";
            this.statusLbl.Size = new System.Drawing.Size(85, 13);
            this.statusLbl.TabIndex = 1;
            this.statusLbl.Text = "Frase de estatus";
            // 
            // statusTxtBox
            // 
            this.statusTxtBox.Location = new System.Drawing.Point(24, 69);
            this.statusTxtBox.Multiline = true;
            this.statusTxtBox.Name = "statusTxtBox";
            this.statusTxtBox.Size = new System.Drawing.Size(331, 165);
            this.statusTxtBox.TabIndex = 2;
            // 
            // CreateStatus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.statusTxtBox);
            this.Controls.Add(this.statusLbl);
            this.Controls.Add(this.saveStatusbtn);
            this.Name = "CreateStatus";
            this.Size = new System.Drawing.Size(390, 265);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button saveStatusbtn;
        private System.Windows.Forms.Label statusLbl;
        private System.Windows.Forms.TextBox statusTxtBox;
    }
}
