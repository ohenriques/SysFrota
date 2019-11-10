namespace Projeto_Desktop
{
    partial class Frota_Pesquisar
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgTabela = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.txtIDPesquisa = new System.Windows.Forms.TextBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgTabela)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 317);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Voltar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dgTabela);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.txtIDPesquisa);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(524, 299);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pesquisar de Veículo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(6, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Insira o Código do Veículo";
            // 
            // dgTabela
            // 
            this.dgTabela.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgTabela.Location = new System.Drawing.Point(6, 72);
            this.dgTabela.Name = "dgTabela";
            this.dgTabela.Size = new System.Drawing.Size(512, 221);
            this.dgTabela.TabIndex = 4;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(295, 43);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(223, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Pesquisar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtIDPesquisa
            // 
            this.txtIDPesquisa.Location = new System.Drawing.Point(6, 46);
            this.txtIDPesquisa.Name = "txtIDPesquisa";
            this.txtIDPesquisa.Size = new System.Drawing.Size(283, 20);
            this.txtIDPesquisa.TabIndex = 0;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(304, 322);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(0, 13);
            this.lblStatus.TabIndex = 6;
            this.lblStatus.Click += new System.EventHandler(this.label2_Click);
            // 
            // Frota_Pesquisar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(548, 352);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Name = "Frota_Pesquisar";
            this.Text = "Pesquisar Frota";
            this.Load += new System.EventHandler(this.Frota_Pesquisar_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgTabela)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtIDPesquisa;
        private System.Windows.Forms.DataGridView dgTabela;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblStatus;
    }
}