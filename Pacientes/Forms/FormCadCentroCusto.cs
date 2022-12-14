using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pacientes
{
    public partial class FormCadCentroCusto : Form
    {
        private CentroCusto centroCusto = new CentroCusto();
        public FormCadCentroCusto()
        {
            InitializeComponent();
        }

        FormCadInternacao frmRI = new FormCadInternacao();
        FormMovimentacao frmRIC = new FormMovimentacao();

        public FormCadCentroCusto(FormCadInternacao RI)
        {
            InitializeComponent();
            frmRI = RI;
        }

        public FormCadCentroCusto(FormMovimentacao RIC)
        {
            InitializeComponent();
            frmRIC = RIC;
        }

        public static void LimpaCampos(Control.ControlCollection controles)
        {
            foreach (Control controle in controles)
            {
                if (controle is TextBox)
                {
                    ((TextBox)controle).Text = String.Empty;
                }
            }
        }

        private void ExibirDados()
        {
            try
            {
                using (SqlConnection cn = new SqlConnection(Conn.StrCon))
                {
                    cn.Open();
                    string sqlQuery = "SELECT codCentroCusto as 'Código do centro de custo', nomeCentroCusto as 'Nome do centro de custo' FROM MvtCentroCusto";
                    using (SqlDataAdapter da = new SqlDataAdapter(sqlQuery, cn))
                    {
                        using (DataTable dt = new DataTable())
                        {
                            da.Fill(dt);

                            dgvCentroCusto.DataSource = dt;
                        }
                    }
                    cn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Falha ao tentar conectar\n\n" + ex.Message);
            }
        }

        private void Salvar_Click(object sender, EventArgs e)
        {
            SalvarCentroCusto();
            LimpaCampos(this.Controls);
        }

        private void SalvarCentroCusto()
        {
            if (txtNome.Text != "" )
            {
                centroCusto.Nome = txtNome.Text;
                centroCusto.Codigo = string.IsNullOrEmpty(this.txtCod.Text)
               ? 0
               : int.Parse(this.txtCod.Text);

                centroCusto.SalvarCentroCusto(centroCusto);

                MessageBox.Show("Centro de custo salvo!");
                ExibirDados();
                LimpaCampos(this.Controls);
            }
            else
            {
                MessageBox.Show("Insira todos os dados");
            }
        }

        private void Excluir_Click_1(object sender, EventArgs e)
        {
            var id = Convert.ToInt32(dgvCentroCusto.Rows[dgvCentroCusto.CurrentCell.RowIndex].Cells[0].Value);
            try
            {
                using (SqlConnection cn = new SqlConnection(Conn.StrCon))
                {
                    cn.Open();

                    string sql = "DELETE FROM MvtCentroCusto where codCentroCusto=" + id;

                    using (SqlCommand cmd = new SqlCommand(sql, cn))
                    {
                        if (DialogResult.Yes == MessageBox.Show("Deseja excluir o centro de custo", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2))
                        {
                            cmd.ExecuteNonQuery();
                        }
                    }
                    cn.Close();

                    ExibirDados();
                    LimpaCampos(this.Controls);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Nenhum centro de custo selecionado\n\n" + ex.Message);
            }
        }

        private void dgvCentroCusto_SelectionChanged(object sender, EventArgs e)
        {
            DataGridView dgv = (DataGridView)sender;
            int contlinhas = dgv.SelectedRows.Count;
            if (contlinhas > 0)
            {
                DataTable dt = new DataTable();
                string vid = dgv.SelectedRows[0].Cells[0].Value.ToString();
                dt = Funcoes.ObterDadosCentroCustoForm(vid);
                txtCod.Text = dt.Rows[0].Field<int>("codCentroCusto").ToString();
                txtNome.Text = dt.Rows[0].Field<string>("nomeCentroCusto").ToString();
            }
        }

        private void Limpar_Click(object sender, EventArgs e)
        {
            txtCod.Text = "";
            txtNome.Text = "";
        }

        private void FormCadCentroCusto_Load(object sender, EventArgs e)
        {
            dgvCentroCusto.DataSource = Funcoes.ObterTodosCentroCusto();
            dgvCentroCusto.Columns[0].Width = 85;
            dgvCentroCusto.Columns[1].Width = 190;
            txtCod.Clear();
            txtNome.Clear();



            dgvCentroCusto.AutoResizeColumns();
            dgvCentroCusto.AutoResizeRows();
        }

        private void dgvCentroCusto_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewRow dgrv = dgvCentroCusto.Rows[e.RowIndex];
            frmRI.frmCadCentroCusto = dgrv.Cells[0].Value.ToString();

            Close();

            DataGridViewRow dgrvc = dgvCentroCusto.Rows[e.RowIndex];
            frmRIC.frmCadCentroCusto = dgrvc.Cells[0].Value.ToString();

            Close();
        }
    }
}
