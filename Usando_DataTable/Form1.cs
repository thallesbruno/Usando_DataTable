using System;
using System.Windows.Forms;
using System.Collections;
using System.Data;
using System.Windows.Forms;
using System.Collections.Generic;

namespace Usando_DataTable
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        DataTable dtb_Alunos;
        string txtCaminhoArquivo = @"c:\temp\DataTable_XML.xml";

        private DataTable CriarDataTable()
        {
            dtb_Alunos = new DataTable();
            dtb_Alunos.Columns.Add("AlunoId", typeof(int));
            dtb_Alunos.Columns.Add("Nome", typeof(string));
            dtb_Alunos.Columns.Add("Email", typeof(string));
            dtb_Alunos.Columns.Add("Telefone", typeof(string));
            dtb_Alunos.Columns.Add("Idade", typeof(int));
            dtb_Alunos.Rows.Add(1, "Macoratti", "macoratti@yahoo.com", "44669922", 45);
            dtb_Alunos.Rows.Add(2, "Jefferson", "jeff@bol.com.br", "88669977", 23);
            dtb_Alunos.Rows.Add(3, "Janice", "janjan@uol.com.br", "96885522", 20);
            dtb_Alunos.Rows.Add(4, "Jessica", "jessicalang@uol.com.br", "96885522", 25);
            dtb_Alunos.Rows.Add(5, "Miriam", "mimi@uol.com.br", "96885522", 48);
            return dtb_Alunos;
        }

        private void btnCriarDataTable_Click(object sender, EventArgs e)
        {
            DataTable tabela = CriarDataTable();
            dgvDados.DataSource = tabela;
        }        

        private void btnSelecionarDados_Click(object sender, EventArgs e)
        {
            string AlunoId = "";
            string Nome = "";
            string Email = "";
            string Telefone = "";
            string Idade = "";
            string campo = cboCampo.Text;
            string criterio = txtCriterio.Text;
            string comando;
            if (campo == "AlunoId" || campo == "Idade")
            {
                comando = campo + "=" + criterio;
            }
            else
            {
                comando = campo + "=" + "'" + criterio + "'";
            }
            DataRow[] oDataRow = dtb_Alunos.Select(comando);
            foreach (DataRow dr in oDataRow)
            {
                //usei 3 sintaxes diferentes para obter os valores
                AlunoId = dr[0].ToString();
                Nome = dr["Nome"].ToString();
                Email = dr[2].ToString();
                Telefone = dr[3].ToString();
                Idade = dr.Field<int>(4).ToString();
            }
            lblSelecao.Text = AlunoId + "   " + Nome + "   " + Email + "   " + Telefone + "   " + Idade;
        }

        private void btnConsultaLINQ_Click(object sender, EventArgs e)
        {
            //consulta usando LINQ
            IEnumerable consulta = from aluno in dtb_Alunos.AsEnumerable()
                                   select aluno;
            foreach (DataRow dr in consulta)
            {
                lbDados.Items.Add(dr.Field<int>("AlunoId") + " - " + dr.Field<string>("Nome"));
            }
        }

        private void btnConsultaLINQ_2_Click(object sender, EventArgs e)
        {
            var consulta = from p in dtb_Alunos.AsEnumerable()
                           where p.Field<string>(cboCampo.Text) == txtCriterio.Text
                           select new
                           {
                               nome = p.Field<string>("Nome"),
                               idade = p.Field<int>("Idade"),
                               fone = p.Field<string>("Telefone")
                           };
            lbDados.Items.Clear();
            //exibe o tipo anônimo
            foreach (var aluno in consulta)
            {
                lbDados.Items.Add(aluno.nome + "   " + aluno.idade + "  " + aluno.fone);
            }
        }

        private void ConsultaLINQ_ExpressaoLambda_Click(object sender, EventArgs e)
        {
            var consulta = from aluno in dtb_Alunos.AsEnumerable()
                           select aluno;
            IEnumerable alunos = consulta.Where(c => c.Field<string>("Nome").Contains("J"));
            lbDados.Items.Clear();
            //Todos os nomes que contem "J"
            foreach (DataRow aluno in alunos)
            {
                lbDados.Items.Add(aluno.Field<string>("Nome"));
            }
        }

        private void btnDataTable_XML_Click(object sender, EventArgs e)
        {
            try
            {
                dtb_Alunos.TableName = "Alunos";
                dtb_Alunos.WriteXml(txtCaminhoArquivo);
                MessageBox.Show("Arquivo XML gerado com sucesso");
                System.Diagnostics.Process.Start(txtCaminhoArquivo);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro : " + ex.Message);
            }
        }

        private void btnXML_DataTable_Click(object sender, EventArgs e)
        {
            try
            {
                dtb_Alunos.ReadXml(txtCaminhoArquivo);
                dgvDados.DataSource = dtb_Alunos;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro : " + ex.Message);
            }
        }

        private void btnList_DataTable_Click(object sender, EventArgs e)
        {
            // Examplo de lista : seleções da copa américa
            List<string[]> oLista = new List<string[]>();
            oLista.Add(new string[] { "Brasil", "Peru", "Venezuela", "Colômbia" });
            oLista.Add(new string[] { "Argentina", "Paraguai", "Uruguai", "Jamaica" });
            oLista.Add(new string[] { "Chile", "Bolívia", "México", "Equador" });
            // Converte para DataTable
            DataTable oDataTable = ConverteLista_DataTable(oLista);
            dgvDados.DataSource = oDataTable;
        }

        private DataTable ConverteLista_DataTable(List<string[]> oLista)
        {
            // Nova tabela
            DataTable oDataTable = new DataTable();
            // no maximo colunas
            int colunas = 0;
            foreach (var array in oLista)
            {
                if (array.Length > colunas)
                {
                    colunas = array.Length;
                }
            }
            // Adiciona colunas
            for (int i = 0; i < colunas; i++)
            {
                oDataTable.Columns.Add();
            }
            // Adiciona linhas
            foreach (var array in oLista)
            {
                oDataTable.Rows.Add(array);
            }
            return oDataTable;
        }
    }
}
