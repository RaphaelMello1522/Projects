namespace Cadastro_Hospital_1.Forms_Pacientes
{
    partial class PesquisaPaciente
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
            this.textBoxPesquisa = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.richTextBoxPesquisa = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(123, 211);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Pesquisar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxPesquisa
            // 
            this.textBoxPesquisa.Location = new System.Drawing.Point(83, 49);
            this.textBoxPesquisa.Name = "textBoxPesquisa";
            this.textBoxPesquisa.Size = new System.Drawing.Size(175, 20);
            this.textBoxPesquisa.TabIndex = 1;
            this.textBoxPesquisa.TextChanged += new System.EventHandler(this.textBoxPesquisa_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(138, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nome/ID/RG";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // richTextBoxPesquisa
            // 
            this.richTextBoxPesquisa.Location = new System.Drawing.Point(12, 75);
            this.richTextBoxPesquisa.Name = "richTextBoxPesquisa";
            this.richTextBoxPesquisa.Size = new System.Drawing.Size(320, 128);
            this.richTextBoxPesquisa.TabIndex = 3;
            this.richTextBoxPesquisa.Text = "";
            this.richTextBoxPesquisa.TextChanged += new System.EventHandler(this.richTextBoxPesquisa_TextChanged);
            // 
            // PesquisaPaciente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(344, 246);
            this.Controls.Add(this.richTextBoxPesquisa);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxPesquisa);
            this.Controls.Add(this.button1);
            this.Name = "PesquisaPaciente";
            this.Text = "Pesquisar Paciente";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBoxPesquisa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox richTextBoxPesquisa;
    }
}