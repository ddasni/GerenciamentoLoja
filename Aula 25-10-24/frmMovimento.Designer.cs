namespace Aula_25_10_24
{
    partial class frmMovimento
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblDesc = new System.Windows.Forms.Label();
            this.txtCodMovto = new System.Windows.Forms.TextBox();
            this.txtCodProd = new System.Windows.Forms.TextBox();
            this.txtQuant = new System.Windows.Forms.TextBox();
            this.dateMovto = new System.Windows.Forms.DateTimePicker();
            this.grpbTipo = new System.Windows.Forms.GroupBox();
            this.rdbSaida = new System.Windows.Forms.RadioButton();
            this.rdbEntrada = new System.Windows.Forms.RadioButton();
            this.lblObs = new System.Windows.Forms.Label();
            this.btnIncluir = new System.Windows.Forms.Button();
            this.txtObservacoes = new System.Windows.Forms.TextBox();
            this.gridMovimento = new System.Windows.Forms.DataGridView();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.grpbTipo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridMovimento)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AllowDrop = true;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(128, 33);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Movimento";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(44, 126);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(235, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Código do Movimento :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(44, 177);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(205, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Código do Produto :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(44, 251);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(211, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Data do Movimento :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(49, 497);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(137, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "Quantidade :";
            // 
            // lblDesc
            // 
            this.lblDesc.AutoSize = true;
            this.lblDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDesc.Location = new System.Drawing.Point(335, 208);
            this.lblDesc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(30, 25);
            this.lblDesc.TabIndex = 5;
            this.lblDesc.Text = "...";
            // 
            // txtCodMovto
            // 
            this.txtCodMovto.Location = new System.Drawing.Point(340, 124);
            this.txtCodMovto.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCodMovto.Name = "txtCodMovto";
            this.txtCodMovto.Size = new System.Drawing.Size(132, 22);
            this.txtCodMovto.TabIndex = 6;
            // 
            // txtCodProd
            // 
            this.txtCodProd.Location = new System.Drawing.Point(340, 180);
            this.txtCodProd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCodProd.Name = "txtCodProd";
            this.txtCodProd.Size = new System.Drawing.Size(132, 22);
            this.txtCodProd.TabIndex = 7;
            // 
            // txtQuant
            // 
            this.txtQuant.Location = new System.Drawing.Point(255, 497);
            this.txtQuant.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtQuant.Name = "txtQuant";
            this.txtQuant.Size = new System.Drawing.Size(132, 22);
            this.txtQuant.TabIndex = 9;
            // 
            // dateMovto
            // 
            this.dateMovto.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateMovto.Location = new System.Drawing.Point(340, 250);
            this.dateMovto.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dateMovto.Name = "dateMovto";
            this.dateMovto.Size = new System.Drawing.Size(132, 22);
            this.dateMovto.TabIndex = 10;
            // 
            // grpbTipo
            // 
            this.grpbTipo.Controls.Add(this.rdbSaida);
            this.grpbTipo.Controls.Add(this.rdbEntrada);
            this.grpbTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpbTipo.Location = new System.Drawing.Point(52, 300);
            this.grpbTipo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpbTipo.Name = "grpbTipo";
            this.grpbTipo.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpbTipo.Size = new System.Drawing.Size(421, 159);
            this.grpbTipo.TabIndex = 11;
            this.grpbTipo.TabStop = false;
            this.grpbTipo.Text = "Tipo";
            // 
            // rdbSaida
            // 
            this.rdbSaida.AutoSize = true;
            this.rdbSaida.Location = new System.Drawing.Point(23, 98);
            this.rdbSaida.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rdbSaida.Name = "rdbSaida";
            this.rdbSaida.Size = new System.Drawing.Size(89, 29);
            this.rdbSaida.TabIndex = 1;
            this.rdbSaida.TabStop = true;
            this.rdbSaida.Text = "Saída";
            this.rdbSaida.UseVisualStyleBackColor = true;
            // 
            // rdbEntrada
            // 
            this.rdbEntrada.AutoSize = true;
            this.rdbEntrada.Location = new System.Drawing.Point(23, 44);
            this.rdbEntrada.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rdbEntrada.Name = "rdbEntrada";
            this.rdbEntrada.Size = new System.Drawing.Size(108, 29);
            this.rdbEntrada.TabIndex = 0;
            this.rdbEntrada.TabStop = true;
            this.rdbEntrada.Text = "Entrada";
            this.rdbEntrada.UseVisualStyleBackColor = true;
            // 
            // lblObs
            // 
            this.lblObs.AutoSize = true;
            this.lblObs.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblObs.Location = new System.Drawing.Point(49, 558);
            this.lblObs.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblObs.Name = "lblObs";
            this.lblObs.Size = new System.Drawing.Size(153, 25);
            this.lblObs.TabIndex = 12;
            this.lblObs.Text = "Observações :";
            // 
            // btnIncluir
            // 
            this.btnIncluir.Location = new System.Drawing.Point(561, 650);
            this.btnIncluir.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnIncluir.Name = "btnIncluir";
            this.btnIncluir.Size = new System.Drawing.Size(177, 58);
            this.btnIncluir.TabIndex = 14;
            this.btnIncluir.Text = "Incluir";
            this.btnIncluir.UseVisualStyleBackColor = true;
            this.btnIncluir.Click += new System.EventHandler(this.btnIncluir_Click);
            // 
            // txtObservacoes
            // 
            this.txtObservacoes.Location = new System.Drawing.Point(55, 599);
            this.txtObservacoes.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtObservacoes.Multiline = true;
            this.txtObservacoes.Name = "txtObservacoes";
            this.txtObservacoes.Size = new System.Drawing.Size(457, 185);
            this.txtObservacoes.TabIndex = 15;
            // 
            // gridMovimento
            // 
            this.gridMovimento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridMovimento.Location = new System.Drawing.Point(561, 87);
            this.gridMovimento.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gridMovimento.Name = "gridMovimento";
            this.gridMovimento.RowHeadersWidth = 51;
            this.gridMovimento.Size = new System.Drawing.Size(865, 516);
            this.gridMovimento.TabIndex = 16;
            this.gridMovimento.Visible = false;
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(791, 650);
            this.btnExcluir.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(177, 58);
            this.btnExcluir.TabIndex = 17;
            this.btnExcluir.Text = "Exlcuir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(1020, 650);
            this.btnPesquisar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(177, 58);
            this.btnPesquisar.TabIndex = 18;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.Location = new System.Drawing.Point(1249, 650);
            this.btnAlterar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(177, 58);
            this.btnAlterar.TabIndex = 19;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // frmMovimento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1473, 838);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.gridMovimento);
            this.Controls.Add(this.txtObservacoes);
            this.Controls.Add(this.btnIncluir);
            this.Controls.Add(this.lblObs);
            this.Controls.Add(this.grpbTipo);
            this.Controls.Add(this.dateMovto);
            this.Controls.Add(this.txtQuant);
            this.Controls.Add(this.txtCodProd);
            this.Controls.Add(this.txtCodMovto);
            this.Controls.Add(this.lblDesc);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmMovimento";
            this.Text = "Movimento";
            this.Load += new System.EventHandler(this.frmMovimento_Load);
            this.grpbTipo.ResumeLayout(false);
            this.grpbTipo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridMovimento)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblDesc;
        private System.Windows.Forms.TextBox txtCodMovto;
        private System.Windows.Forms.TextBox txtCodProd;
        private System.Windows.Forms.TextBox txtQuant;
        private System.Windows.Forms.DateTimePicker dateMovto;
        private System.Windows.Forms.GroupBox grpbTipo;
        private System.Windows.Forms.RadioButton rdbEntrada;
        private System.Windows.Forms.RadioButton rdbSaida;
        private System.Windows.Forms.Label lblObs;
        private System.Windows.Forms.Button btnIncluir;
        private System.Windows.Forms.TextBox txtObservacoes;
        private System.Windows.Forms.DataGridView gridMovimento;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.Button btnAlterar;
    }
}