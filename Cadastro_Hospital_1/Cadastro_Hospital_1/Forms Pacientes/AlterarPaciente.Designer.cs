namespace Cadastro_Hospital_1.Forms_Pacientes
{
    partial class AlterarPaciente
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
            this.richTextBoxListar = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBoxBusca = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.botaoSalvar = new System.Windows.Forms.Button();
            this.textBoxSintoma = new System.Windows.Forms.TextBox();
            this.textBoxRG = new System.Windows.Forms.TextBox();
            this.textBoxNome = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // richTextBoxListar
            // 
            this.richTextBoxListar.Location = new System.Drawing.Point(12, 154);
            this.richTextBoxListar.Name = "richTextBoxListar";
            this.richTextBoxListar.Size = new System.Drawing.Size(235, 128);
            this.richTextBoxListar.TabIndex = 4;
            this.richTextBoxListar.Text = "";
            this.richTextBoxListar.TextChanged += new System.EventHandler(this.richTextBoxListar_TextChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(12, 288);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Pesquisar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxBusca
            // 
            this.textBoxBusca.Location = new System.Drawing.Point(54, 15);
            this.textBoxBusca.Name = "textBoxBusca";
            this.textBoxBusca.Size = new System.Drawing.Size(194, 20);
            this.textBoxBusca.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "ID";
            // 
            // botaoSalvar
            // 
            this.botaoSalvar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.botaoSalvar.Location = new System.Drawing.Point(148, 288);
            this.botaoSalvar.Name = "botaoSalvar";
            this.botaoSalvar.Size = new System.Drawing.Size(100, 23);
            this.botaoSalvar.TabIndex = 15;
            this.botaoSalvar.Text = "Alterar";
            this.botaoSalvar.UseVisualStyleBackColor = false;
            this.botaoSalvar.Click += new System.EventHandler(this.botaoSalvar_Click);
            // 
            // textBoxSintoma
            // 
            this.textBoxSintoma.Location = new System.Drawing.Point(54, 95);
            this.textBoxSintoma.Name = "textBoxSintoma";
            this.textBoxSintoma.Size = new System.Drawing.Size(194, 20);
            this.textBoxSintoma.TabIndex = 14;
            // 
            // textBoxRG
            // 
            this.textBoxRG.Location = new System.Drawing.Point(54, 67);
            this.textBoxRG.Name = "textBoxRG";
            this.textBoxRG.Size = new System.Drawing.Size(194, 20);
            this.textBoxRG.TabIndex = 13;
            // 
            // textBoxNome
            // 
            this.textBoxNome.Location = new System.Drawing.Point(54, 41);
            this.textBoxNome.Name = "textBoxNome";
            this.textBoxNome.Size = new System.Drawing.Size(193, 20);
            this.textBoxNome.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Sintoma";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "RG";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Nome";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 130);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Bairro";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Barigui",
            "Batel",
            "Cachoeira",
            "Caixa d\'água",
            "Cedro",
            "Centro",
            "Itapema",
            "Jardim Maria Luiza",
            "KM-4",
            "Limoeiro",
            "Penha",
            "Pinheirinho",
            "Ponta da Pita",
            "Portinho",
            "Praia dos Polacos",
            "Saivá",
            "Tucunduva"});
            this.comboBox1.Location = new System.Drawing.Point(54, 127);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(193, 21);
            this.comboBox1.TabIndex = 17;
            // 
            // AlterarPaciente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(260, 333);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.botaoSalvar);
            this.Controls.Add(this.textBoxSintoma);
            this.Controls.Add(this.textBoxRG);
            this.Controls.Add(this.textBoxNome);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxBusca);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.richTextBoxListar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "AlterarPaciente";
            this.ShowIcon = false;
            this.Text = "Alterar Dados ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBoxListar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBoxBusca;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button botaoSalvar;
        private System.Windows.Forms.TextBox textBoxSintoma;
        private System.Windows.Forms.TextBox textBoxRG;
        private System.Windows.Forms.TextBox textBoxNome;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}