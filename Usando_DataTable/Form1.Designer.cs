namespace Usando_DataTable
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvDados = new System.Windows.Forms.DataGridView();
            this.lbDados = new System.Windows.Forms.ListBox();
            this.btnConsultaLINQ = new System.Windows.Forms.Button();
            this.ConsultaLINQ_ExpressaoLambda = new System.Windows.Forms.Button();
            this.btnConsultaLINQ_2 = new System.Windows.Forms.Button();
            this.btnDataTable_XML = new System.Windows.Forms.Button();
            this.btnCriarDataTable = new System.Windows.Forms.Button();
            this.btnSelecionarDados = new System.Windows.Forms.Button();
            this.cboCampo = new System.Windows.Forms.ComboBox();
            this.txtCriterio = new System.Windows.Forms.TextBox();
            this.btnXML_DataTable = new System.Windows.Forms.Button();
            this.btnList_DataTable = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblSelecao = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDados)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDados
            // 
            this.dgvDados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDados.Location = new System.Drawing.Point(12, 12);
            this.dgvDados.Name = "dgvDados";
            this.dgvDados.Size = new System.Drawing.Size(489, 292);
            this.dgvDados.TabIndex = 0;
            // 
            // lbDados
            // 
            this.lbDados.FormattingEnabled = true;
            this.lbDados.Location = new System.Drawing.Point(519, 70);
            this.lbDados.Name = "lbDados";
            this.lbDados.Size = new System.Drawing.Size(269, 199);
            this.lbDados.TabIndex = 1;
            // 
            // btnConsultaLINQ
            // 
            this.btnConsultaLINQ.Location = new System.Drawing.Point(519, 12);
            this.btnConsultaLINQ.Name = "btnConsultaLINQ";
            this.btnConsultaLINQ.Size = new System.Drawing.Size(269, 49);
            this.btnConsultaLINQ.TabIndex = 2;
            this.btnConsultaLINQ.Text = "Consultar Usando LINQ";
            this.btnConsultaLINQ.UseVisualStyleBackColor = true;
            this.btnConsultaLINQ.Click += new System.EventHandler(this.btnConsultaLINQ_Click);
            // 
            // ConsultaLINQ_ExpressaoLambda
            // 
            this.ConsultaLINQ_ExpressaoLambda.Location = new System.Drawing.Point(519, 304);
            this.ConsultaLINQ_ExpressaoLambda.Name = "ConsultaLINQ_ExpressaoLambda";
            this.ConsultaLINQ_ExpressaoLambda.Size = new System.Drawing.Size(269, 23);
            this.ConsultaLINQ_ExpressaoLambda.TabIndex = 3;
            this.ConsultaLINQ_ExpressaoLambda.Text = "Expressão Lambda";
            this.ConsultaLINQ_ExpressaoLambda.UseVisualStyleBackColor = true;
            this.ConsultaLINQ_ExpressaoLambda.Click += new System.EventHandler(this.ConsultaLINQ_ExpressaoLambda_Click);
            // 
            // btnConsultaLINQ_2
            // 
            this.btnConsultaLINQ_2.Location = new System.Drawing.Point(519, 275);
            this.btnConsultaLINQ_2.Name = "btnConsultaLINQ_2";
            this.btnConsultaLINQ_2.Size = new System.Drawing.Size(269, 23);
            this.btnConsultaLINQ_2.TabIndex = 4;
            this.btnConsultaLINQ_2.Text = "Consulta LINQ";
            this.btnConsultaLINQ_2.UseVisualStyleBackColor = true;
            this.btnConsultaLINQ_2.Click += new System.EventHandler(this.btnConsultaLINQ_2_Click);
            // 
            // btnDataTable_XML
            // 
            this.btnDataTable_XML.Location = new System.Drawing.Point(519, 333);
            this.btnDataTable_XML.Name = "btnDataTable_XML";
            this.btnDataTable_XML.Size = new System.Drawing.Size(269, 23);
            this.btnDataTable_XML.TabIndex = 5;
            this.btnDataTable_XML.Text = "Data Table => XML";
            this.btnDataTable_XML.UseVisualStyleBackColor = true;
            this.btnDataTable_XML.Click += new System.EventHandler(this.btnDataTable_XML_Click);
            // 
            // btnCriarDataTable
            // 
            this.btnCriarDataTable.Location = new System.Drawing.Point(12, 310);
            this.btnCriarDataTable.Name = "btnCriarDataTable";
            this.btnCriarDataTable.Size = new System.Drawing.Size(159, 46);
            this.btnCriarDataTable.TabIndex = 7;
            this.btnCriarDataTable.Text = "Criar e Exibir Data Table";
            this.btnCriarDataTable.UseVisualStyleBackColor = true;
            this.btnCriarDataTable.Click += new System.EventHandler(this.btnCriarDataTable_Click);
            // 
            // btnSelecionarDados
            // 
            this.btnSelecionarDados.Location = new System.Drawing.Point(177, 310);
            this.btnSelecionarDados.Name = "btnSelecionarDados";
            this.btnSelecionarDados.Size = new System.Drawing.Size(151, 46);
            this.btnSelecionarDados.TabIndex = 8;
            this.btnSelecionarDados.Text = "Selecionar Dados";
            this.btnSelecionarDados.UseVisualStyleBackColor = true;
            this.btnSelecionarDados.Click += new System.EventHandler(this.btnSelecionarDados_Click);
            // 
            // cboCampo
            // 
            this.cboCampo.FormattingEnabled = true;
            this.cboCampo.Location = new System.Drawing.Point(334, 310);
            this.cboCampo.Name = "cboCampo";
            this.cboCampo.Size = new System.Drawing.Size(167, 21);
            this.cboCampo.TabIndex = 9;
            // 
            // txtCriterio
            // 
            this.txtCriterio.Location = new System.Drawing.Point(334, 337);
            this.txtCriterio.Name = "txtCriterio";
            this.txtCriterio.Size = new System.Drawing.Size(167, 20);
            this.txtCriterio.TabIndex = 10;
            this.txtCriterio.Text = "Jessica";
            // 
            // btnXML_DataTable
            // 
            this.btnXML_DataTable.Location = new System.Drawing.Point(519, 362);
            this.btnXML_DataTable.Name = "btnXML_DataTable";
            this.btnXML_DataTable.Size = new System.Drawing.Size(269, 23);
            this.btnXML_DataTable.TabIndex = 11;
            this.btnXML_DataTable.Text = "XML => Data Table";
            this.btnXML_DataTable.UseVisualStyleBackColor = true;
            this.btnXML_DataTable.Click += new System.EventHandler(this.btnXML_DataTable_Click);
            // 
            // btnList_DataTable
            // 
            this.btnList_DataTable.Location = new System.Drawing.Point(519, 391);
            this.btnList_DataTable.Name = "btnList_DataTable";
            this.btnList_DataTable.Size = new System.Drawing.Size(269, 23);
            this.btnList_DataTable.TabIndex = 12;
            this.btnList_DataTable.Text = "List => Data Table";
            this.btnList_DataTable.UseVisualStyleBackColor = true;
            this.btnList_DataTable.Click += new System.EventHandler(this.btnList_DataTable_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 396);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Resultado da Seleção:";
            // 
            // lblSelecao
            // 
            this.lblSelecao.AutoSize = true;
            this.lblSelecao.Location = new System.Drawing.Point(136, 396);
            this.lblSelecao.Name = "lblSelecao";
            this.lblSelecao.Size = new System.Drawing.Size(35, 13);
            this.lblSelecao.TabIndex = 14;
            this.lblSelecao.Text = "label2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 425);
            this.Controls.Add(this.lblSelecao);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnList_DataTable);
            this.Controls.Add(this.btnXML_DataTable);
            this.Controls.Add(this.txtCriterio);
            this.Controls.Add(this.cboCampo);
            this.Controls.Add(this.btnSelecionarDados);
            this.Controls.Add(this.btnCriarDataTable);
            this.Controls.Add(this.btnDataTable_XML);
            this.Controls.Add(this.btnConsultaLINQ_2);
            this.Controls.Add(this.ConsultaLINQ_ExpressaoLambda);
            this.Controls.Add(this.btnConsultaLINQ);
            this.Controls.Add(this.lbDados);
            this.Controls.Add(this.dgvDados);
            this.Name = "Form1";
            this.Text = "Usando Data Table";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDados;
        private System.Windows.Forms.ListBox lbDados;
        private System.Windows.Forms.Button btnConsultaLINQ;
        private System.Windows.Forms.Button ConsultaLINQ_ExpressaoLambda;
        private System.Windows.Forms.Button btnConsultaLINQ_2;
        private System.Windows.Forms.Button btnDataTable_XML;
        private System.Windows.Forms.Button btnCriarDataTable;
        private System.Windows.Forms.Button btnSelecionarDados;
        private System.Windows.Forms.ComboBox cboCampo;
        private System.Windows.Forms.TextBox txtCriterio;
        private System.Windows.Forms.Button btnXML_DataTable;
        private System.Windows.Forms.Button btnList_DataTable;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblSelecao;
    }
}

