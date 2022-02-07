namespace BilheteriaEletronica.Forms
{
    partial class AlterarDados
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
            this.botaoSalvar = new System.Windows.Forms.Button();
            this.textBoxRG_CPF = new System.Windows.Forms.TextBox();
            this.textBoxNome = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxBusca = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.richTextBoxListar = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBoxVagao = new System.Windows.Forms.ComboBox();
            this.comboBoxDestino = new System.Windows.Forms.ComboBox();
            this.comboBoxPassagens = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.btnNovoTotal = new System.Windows.Forms.Button();
            this.labelTotal = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // botaoSalvar
            // 
            this.botaoSalvar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.botaoSalvar.Location = new System.Drawing.Point(205, 353);
            this.botaoSalvar.Name = "botaoSalvar";
            this.botaoSalvar.Size = new System.Drawing.Size(70, 23);
            this.botaoSalvar.TabIndex = 26;
            this.botaoSalvar.Text = "Alterar";
            this.botaoSalvar.UseVisualStyleBackColor = false;
            this.botaoSalvar.Click += new System.EventHandler(this.botaoSalvar_Click);
            // 
            // textBoxRG_CPF
            // 
            this.textBoxRG_CPF.Location = new System.Drawing.Point(122, 86);
            this.textBoxRG_CPF.Name = "textBoxRG_CPF";
            this.textBoxRG_CPF.Size = new System.Drawing.Size(100, 20);
            this.textBoxRG_CPF.TabIndex = 24;
            // 
            // textBoxNome
            // 
            this.textBoxNome.Location = new System.Drawing.Point(122, 60);
            this.textBoxNome.Name = "textBoxNome";
            this.textBoxNome.Size = new System.Drawing.Size(100, 20);
            this.textBoxNome.TabIndex = 23;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(71, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "Destino";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "RG ou CPF";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(81, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "Nome";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(93, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "ID";
            // 
            // textBoxBusca
            // 
            this.textBoxBusca.Location = new System.Drawing.Point(122, 34);
            this.textBoxBusca.Name = "textBoxBusca";
            this.textBoxBusca.Size = new System.Drawing.Size(40, 20);
            this.textBoxBusca.TabIndex = 18;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(40, 353);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(70, 23);
            this.button1.TabIndex = 17;
            this.button1.Text = "Pesquisar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // richTextBoxListar
            // 
            this.richTextBoxListar.Location = new System.Drawing.Point(40, 235);
            this.richTextBoxListar.Name = "richTextBoxListar";
            this.richTextBoxListar.Size = new System.Drawing.Size(235, 112);
            this.richTextBoxListar.TabIndex = 16;
            this.richTextBoxListar.Text = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(119, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 13);
            this.label5.TabIndex = 27;
            this.label5.Text = "Alterar Dados";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(73, 169);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 29;
            this.label6.Text = "Vagão";
            // 
            // comboBoxVagao
            // 
            this.comboBoxVagao.FormattingEnabled = true;
            this.comboBoxVagao.Items.AddRange(new object[] {
            "Vagão A",
            "Vagão B",
            "Vagão C",
            "Vagão D",
            "Vagão E"});
            this.comboBoxVagao.Location = new System.Drawing.Point(122, 166);
            this.comboBoxVagao.Name = "comboBoxVagao";
            this.comboBoxVagao.Size = new System.Drawing.Size(100, 21);
            this.comboBoxVagao.TabIndex = 30;
            // 
            // comboBoxDestino
            // 
            this.comboBoxDestino.FormattingEnabled = true;
            this.comboBoxDestino.Items.AddRange(new object[] {
            "Antonina-PR",
            "Morretes-PR"});
            this.comboBoxDestino.Location = new System.Drawing.Point(122, 139);
            this.comboBoxDestino.Name = "comboBoxDestino";
            this.comboBoxDestino.Size = new System.Drawing.Size(100, 21);
            this.comboBoxDestino.TabIndex = 31;
            // 
            // comboBoxPassagens
            // 
            this.comboBoxPassagens.FormattingEnabled = true;
            this.comboBoxPassagens.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.comboBoxPassagens.Location = new System.Drawing.Point(122, 112);
            this.comboBoxPassagens.Name = "comboBoxPassagens";
            this.comboBoxPassagens.Size = new System.Drawing.Size(100, 21);
            this.comboBoxPassagens.TabIndex = 34;
            this.comboBoxPassagens.SelectedIndexChanged += new System.EventHandler(this.comboBoxPassagens_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(55, 115);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 13);
            this.label7.TabIndex = 33;
            this.label7.Text = "Passagens";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "dd/MM/yyyy/HH:mm:ss";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(122, 193);
            this.dateTimePicker1.MaxDate = new System.DateTime(2020, 10, 31, 0, 0, 0, 0);
            this.dateTimePicker1.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dateTimePicker1.Size = new System.Drawing.Size(130, 20);
            this.dateTimePicker1.TabIndex = 35;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(56, 199);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 13);
            this.label8.TabIndex = 36;
            this.label8.Text = "Embarque";
            // 
            // btnNovoTotal
            // 
            this.btnNovoTotal.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnNovoTotal.Location = new System.Drawing.Point(122, 353);
            this.btnNovoTotal.Name = "btnNovoTotal";
            this.btnNovoTotal.Size = new System.Drawing.Size(70, 23);
            this.btnNovoTotal.TabIndex = 37;
            this.btnNovoTotal.Text = "Novo Total";
            this.btnNovoTotal.UseVisualStyleBackColor = false;
            this.btnNovoTotal.Click += new System.EventHandler(this.btnNovoTotal_Click);
            // 
            // labelTotal
            // 
            this.labelTotal.AutoSize = true;
            this.labelTotal.Location = new System.Drawing.Point(56, 219);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(66, 13);
            this.labelTotal.TabIndex = 38;
            this.labelTotal.Text = "Novo Total :";
            // 
            // AlterarDados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AntiqueWhite;
            this.ClientSize = new System.Drawing.Size(315, 387);
            this.Controls.Add(this.labelTotal);
            this.Controls.Add(this.btnNovoTotal);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.comboBoxPassagens);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.comboBoxDestino);
            this.Controls.Add(this.comboBoxVagao);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.botaoSalvar);
            this.Controls.Add(this.textBoxRG_CPF);
            this.Controls.Add(this.textBoxNome);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxBusca);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.richTextBoxListar);
            this.Name = "AlterarDados";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AlterarDados";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button botaoSalvar;
        private System.Windows.Forms.TextBox textBoxRG_CPF;
        private System.Windows.Forms.TextBox textBoxNome;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxBusca;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RichTextBox richTextBoxListar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBoxVagao;
        private System.Windows.Forms.ComboBox comboBoxDestino;
        private System.Windows.Forms.ComboBox comboBoxPassagens;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnNovoTotal;
        private System.Windows.Forms.Label labelTotal;
    }
}