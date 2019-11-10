namespace Projeto_Desktop
{
    partial class Aluguel_De_Frota_Devolucao
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cboxClientes = new System.Windows.Forms.ComboBox();
            this.clienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sysCarDataSet = new Projeto_Desktop.SysCarDataSet();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.txtNullStatus = new System.Windows.Forms.TextBox();
            this.clienteTableAdapter = new Projeto_Desktop.SysCarDataSetTableAdapters.ClienteTableAdapter();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sysCarDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.maskedTextBox1);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.comboBox4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.comboBox2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.cboxClientes);
            this.panel1.Location = new System.Drawing.Point(13, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(491, 231);
            this.panel1.TabIndex = 5;
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(10, 185);
            this.maskedTextBox1.Mask = "00/00/0000";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(97, 20);
            this.maskedTextBox1.TabIndex = 13;
            this.maskedTextBox1.ValidatingType = typeof(System.DateTime);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(277, 106);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(208, 20);
            this.textBox1.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(274, 89);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(121, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Motorista com o veículo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Placa";
            // 
            // comboBox4
            // 
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Location = new System.Drawing.Point(7, 105);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(208, 21);
            this.comboBox4.TabIndex = 9;
            this.comboBox4.Text = "---Selecione---";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(274, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Carros Ativos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 169);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Data da Devolução";
            // 
            // comboBox2
            // 
            this.comboBox2.DataSource = this.clienteBindingSource;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(277, 36);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(208, 21);
            this.comboBox2.TabIndex = 2;
            this.comboBox2.Text = "---Selecione---";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Cliente";
            // 
            // cboxClientes
            // 
            this.cboxClientes.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.clienteBindingSource, "NomeFantasia", true));
            this.cboxClientes.DataSource = this.sysCarDataSet;
            this.cboxClientes.DisplayMember = "Cliente.NomeFantasia";
            this.cboxClientes.FormattingEnabled = true;
            this.cboxClientes.Location = new System.Drawing.Point(7, 36);
            this.cboxClientes.Name = "cboxClientes";
            this.cboxClientes.Size = new System.Drawing.Size(203, 21);
            this.cboxClientes.TabIndex = 0;
            this.cboxClientes.ValueMember = "NomeFantasia";
            // 
            // clienteBindingSource
            // 
            this.clienteBindingSource.DataMember = "Cliente";
            this.clienteBindingSource.DataSource = this.sysCarDataSet;
            // 
            // sysCarDataSet
            // 
            this.sysCarDataSet.DataSetName = "SysCarDataSet";
            this.sysCarDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(14, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(490, 231);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(398, 250);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(106, 23);
            this.button3.TabIndex = 7;
            this.button3.Text = "Devolver Veículo";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(14, 250);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Voltar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // txtNullStatus
            // 
            this.txtNullStatus.Location = new System.Drawing.Point(184, 252);
            this.txtNullStatus.Name = "txtNullStatus";
            this.txtNullStatus.ReadOnly = true;
            this.txtNullStatus.Size = new System.Drawing.Size(208, 20);
            this.txtNullStatus.TabIndex = 12;
            // 
            // clienteTableAdapter
            // 
            this.clienteTableAdapter.ClearBeforeFill = true;
            // 
            // Aluguel_De_Frota_Devolucao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(517, 286);
            this.Controls.Add(this.txtNullStatus);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Name = "Aluguel_De_Frota_Devolucao";
            this.Text = "Alugar Veículo Devolução";
            this.Load += new System.EventHandler(this.Aluguel_De_Frota_Devolucao_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sysCarDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboxClientes;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.TextBox txtNullStatus;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private SysCarDataSet sysCarDataSet;
        private System.Windows.Forms.BindingSource clienteBindingSource;
        private SysCarDataSetTableAdapters.ClienteTableAdapter clienteTableAdapter;
    }
}