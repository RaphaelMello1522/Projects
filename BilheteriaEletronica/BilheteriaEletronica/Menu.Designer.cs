namespace BilheteriaEletronica
{
    partial class Menu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnACADM = new System.Windows.Forms.Button();
            this.btnAP = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnACADM
            // 
            this.btnACADM.Location = new System.Drawing.Point(12, 12);
            this.btnACADM.Name = "btnACADM";
            this.btnACADM.Size = new System.Drawing.Size(249, 71);
            this.btnACADM.TabIndex = 0;
            this.btnACADM.Text = "Acesso Administrativo";
            this.btnACADM.UseVisualStyleBackColor = true;
            this.btnACADM.Click += new System.EventHandler(this.btnACADM_Click);
            // 
            // btnAP
            // 
            this.btnAP.Location = new System.Drawing.Point(12, 89);
            this.btnAP.Name = "btnAP";
            this.btnAP.Size = new System.Drawing.Size(249, 71);
            this.btnAP.TabIndex = 1;
            this.btnAP.Text = "Acesso Público";
            this.btnAP.UseVisualStyleBackColor = true;
            this.btnAP.Click += new System.EventHandler(this.btnAP_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(273, 166);
            this.Controls.Add(this.btnAP);
            this.Controls.Add(this.btnACADM);
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnACADM;
        private System.Windows.Forms.Button btnAP;
    }
}

