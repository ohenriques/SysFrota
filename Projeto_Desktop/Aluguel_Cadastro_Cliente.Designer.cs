namespace Projeto_Desktop
{
    partial class Aluguel_Cadastro_Cliente
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.tipoDeAtuacao = new System.Windows.Forms.ComboBox();
            this.txtCNPJ = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtRazaoSocial = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNomeFantasia = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCadastrarCliente = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.lblStatus = new System.Windows.Forms.Label();
            this.txtIdCliente = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtIdCliente);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.tipoDeAtuacao);
            this.panel1.Controls.Add(this.txtCNPJ);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtRazaoSocial);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtNomeFantasia);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(13, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(491, 166);
            this.panel1.TabIndex = 13;
            // 
            // tipoDeAtuacao
            // 
            this.tipoDeAtuacao.FormattingEnabled = true;
            this.tipoDeAtuacao.Items.AddRange(new object[] {
            "Alimentos",
            "Telecomunicao",
            "Outros"});
            this.tipoDeAtuacao.Location = new System.Drawing.Point(10, 128);
            this.tipoDeAtuacao.Name = "tipoDeAtuacao";
            this.tipoDeAtuacao.Size = new System.Drawing.Size(210, 21);
            this.tipoDeAtuacao.TabIndex = 9;
            // 
            // txtCNPJ
            // 
            this.txtCNPJ.Location = new System.Drawing.Point(226, 130);
            this.txtCNPJ.Name = "txtCNPJ";
            this.txtCNPJ.Size = new System.Drawing.Size(259, 20);
            this.txtCNPJ.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(226, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "CNPJ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Tipo de Atuação";
            // 
            // txtRazaoSocial
            // 
            this.txtRazaoSocial.Location = new System.Drawing.Point(7, 79);
            this.txtRazaoSocial.Name = "txtRazaoSocial";
            this.txtRazaoSocial.Size = new System.Drawing.Size(478, 20);
            this.txtRazaoSocial.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Razão Social";
            // 
            // txtNomeFantasia
            // 
            this.txtNomeFantasia.Location = new System.Drawing.Point(7, 36);
            this.txtNomeFantasia.Name = "txtNomeFantasia";
            this.txtNomeFantasia.Size = new System.Drawing.Size(213, 20);
            this.txtNomeFantasia.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nome Fantasia";
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(14, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(490, 166);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            // 
            // btnCadastrarCliente
            // 
            this.btnCadastrarCliente.Location = new System.Drawing.Point(398, 185);
            this.btnCadastrarCliente.Name = "btnCadastrarCliente";
            this.btnCadastrarCliente.Size = new System.Drawing.Size(106, 23);
            this.btnCadastrarCliente.TabIndex = 15;
            this.btnCadastrarCliente.Text = "Cadastrar Cliente";
            this.btnCadastrarCliente.UseVisualStyleBackColor = true;
            this.btnCadastrarCliente.Click += new System.EventHandler(this.button3_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(13, 185);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 14;
            this.button1.Text = "Voltar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblStatus.Location = new System.Drawing.Point(236, 190);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(0, 13);
            this.lblStatus.TabIndex = 17;
            // 
            // txtIdCliente
            // 
            this.txtIdCliente.Location = new System.Drawing.Point(226, 36);
            this.txtIdCliente.Name = "txtIdCliente";
            this.txtIdCliente.Size = new System.Drawing.Size(259, 20);
            this.txtIdCliente.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(226, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(18, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "ID";
            // 
            // Aluguel_Cadastro_Cliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(517, 216);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnCadastrarCliente);
            this.Controls.Add(this.button1);
            this.Name = "Aluguel_Cadastro_Cliente";
            this.Text = "Cadastrar Cliente";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnCadastrarCliente;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtRazaoSocial;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNomeFantasia;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.TextBox txtCNPJ;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox tipoDeAtuacao;
        private System.Windows.Forms.TextBox txtIdCliente;
        private System.Windows.Forms.Label label5;
    }
}