namespace Cadastro_Hospital_1.Forms_Medicos
{
    partial class InserirMedicos
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxNomeM = new System.Windows.Forms.TextBox();
            this.textBoxSexoM = new System.Windows.Forms.TextBox();
            this.textBoxCRM = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(93, 124);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Entrar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nome";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "CRM";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Sexo";
            // 
            // textBoxNomeM
            // 
            this.textBoxNomeM.Location = new System.Drawing.Point(79, 38);
            this.textBoxNomeM.Name = "textBoxNomeM";
            this.textBoxNomeM.Size = new System.Drawing.Size(100, 20);
            this.textBoxNomeM.TabIndex = 4;
            // 
            // textBoxSexoM
            // 
            this.textBoxSexoM.Location = new System.Drawing.Point(79, 98);
            this.textBoxSexoM.Name = "textBoxSexoM";
            this.textBoxSexoM.Size = new System.Drawing.Size(100, 20);
            this.textBoxSexoM.TabIndex = 5;
            // 
            // textBoxCRM
            // 
            this.textBoxCRM.Location = new System.Drawing.Point(79, 68);
            this.textBoxCRM.Name = "textBoxCRM";
            this.textBoxCRM.Size = new System.Drawing.Size(100, 20);
            this.textBoxCRM.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(90, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Login Médico";
            // 
            // Medicos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(481, 214);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxCRM);
            this.Controls.Add(this.textBoxSexoM);
            this.Controls.Add(this.textBoxNomeM);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "Medicos";
            this.Text = "Medicos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxNomeM;
        private System.Windows.Forms.TextBox textBoxSexoM;
        private System.Windows.Forms.TextBox textBoxCRM;
        private System.Windows.Forms.Label label4;
    }
}