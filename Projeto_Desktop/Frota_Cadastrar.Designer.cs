namespace Projeto_Desktop
{
    partial class Frota_Cadastrar
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
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtAno = new System.Windows.Forms.ComboBox();
            this.txtPlaca = new System.Windows.Forms.MaskedTextBox();
            this.txtChassi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtIDVeiculo = new System.Windows.Forms.TextBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 152);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Voltar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(500, 152);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(112, 23);
            this.button2.TabIndex = 8;
            this.button2.Text = "Cadastrar Veículo";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tableLayoutPanel2);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(612, 134);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dados Principais";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.Controls.Add(this.textBox2, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.label6, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.txtMarca, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.label4, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.label5, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.txtAno, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.txtPlaca, 3, 1);
            this.tableLayoutPanel2.Controls.Add(this.txtChassi, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.label2, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.label7, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.txtIDVeiculo, 1, 1);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(12, 19);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 4;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(594, 95);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(3, 63);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(139, 20);
            this.textBox2.TabIndex = 36;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 40);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 33;
            this.label6.Text = "Chassi";
            // 
            // txtMarca
            // 
            this.txtMarca.Location = new System.Drawing.Point(3, 16);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(139, 20);
            this.txtMarca.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 24;
            this.label1.Text = "Marca";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(299, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 13);
            this.label4.TabIndex = 26;
            this.label4.Text = "Ano";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(447, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 27;
            this.label5.Text = "Placa";
            // 
            // txtAno
            // 
            this.txtAno.FormattingEnabled = true;
            this.txtAno.Items.AddRange(new object[] {
            "2009",
            "2010",
            "2011",
            "2012",
            "2013",
            "2014",
            "2015",
            "2016",
            "2017",
            "2018",
            "2019",
            "2020"});
            this.txtAno.Location = new System.Drawing.Point(299, 16);
            this.txtAno.Name = "txtAno";
            this.txtAno.Size = new System.Drawing.Size(139, 21);
            this.txtAno.TabIndex = 31;
            // 
            // txtPlaca
            // 
            this.txtPlaca.Location = new System.Drawing.Point(447, 16);
            this.txtPlaca.Mask = "000-0000";
            this.txtPlaca.Name = "txtPlaca";
            this.txtPlaca.Size = new System.Drawing.Size(141, 20);
            this.txtPlaca.TabIndex = 32;
            // 
            // txtChassi
            // 
            this.txtChassi.Location = new System.Drawing.Point(151, 63);
            this.txtChassi.Name = "txtChassi";
            this.txtChassi.Size = new System.Drawing.Size(139, 20);
            this.txtChassi.TabIndex = 34;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(151, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 25;
            this.label2.Text = "Modelo";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(151, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(16, 13);
            this.label7.TabIndex = 35;
            this.label7.Text = "Id";
            // 
            // txtIDVeiculo
            // 
            this.txtIDVeiculo.Location = new System.Drawing.Point(151, 16);
            this.txtIDVeiculo.Name = "txtIDVeiculo";
            this.txtIDVeiculo.Size = new System.Drawing.Size(139, 20);
            this.txtIDVeiculo.TabIndex = 28;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblStatus.Location = new System.Drawing.Point(343, 162);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(0, 13);
            this.lblStatus.TabIndex = 12;
            // 
            // Frota_Cadastrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(636, 187);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Frota_Cadastrar";
            this.Text = "Cadastrar Veículo";
            this.groupBox1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TextBox txtIDVeiculo;
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.ComboBox txtAno;
        private System.Windows.Forms.MaskedTextBox txtPlaca;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtChassi;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label7;
    }
}