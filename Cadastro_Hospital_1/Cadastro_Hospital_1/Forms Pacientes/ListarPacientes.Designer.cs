namespace Cadastro_Hospital_1.Forms_Pacientes
{
    partial class ListarPacientes
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
            this.richTextBoxPacientes = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(126, 116);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Fechar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // richTextBoxPacientes
            // 
            this.richTextBoxPacientes.Location = new System.Drawing.Point(12, 12);
            this.richTextBoxPacientes.Name = "richTextBoxPacientes";
            this.richTextBoxPacientes.Size = new System.Drawing.Size(305, 98);
            this.richTextBoxPacientes.TabIndex = 1;
            this.richTextBoxPacientes.Text = "";
            this.richTextBoxPacientes.TextChanged += new System.EventHandler(this.richTextBoxPacientes_TextChanged);
            // 
            // ListarPacientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(329, 149);
            this.Controls.Add(this.richTextBoxPacientes);
            this.Controls.Add(this.button1);
            this.MaximizeBox = false;
            this.Name = "ListarPacientes";
            this.ShowIcon = false;
            this.Text = "Lista de Pacientes";
            this.Load += new System.EventHandler(this.ListarPacientes_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RichTextBox richTextBoxPacientes;
    }
}