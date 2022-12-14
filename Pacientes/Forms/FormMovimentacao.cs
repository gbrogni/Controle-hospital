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
    public partial class FormMovimentacao : Form
    {
        private Movimentacao movimentacao = new Movimentacao();

        public string frmCadInternacao { get; set; }
        public string frmCadCentroCusto { get; set; }
        public FormMovimentacao()
        {
            InitializeComponent();
        }

        public static void LimpaCampos(Control.ControlCollection controles)
        {
            foreach (Control controle in controles)
            {
                if (controle is TextBox)
                {
                    ((TextBox)controle).Text = String.Empty;
                }
                if (controle is ComboBox)
                {
                    ((ComboBox)controle).Text = String.Empty;
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
                    string sqlQuery = "select sequencia as 'Sequência', dataMovimentacao as 'Data da movimentação', horaMovimentacao as 'Hora da movimentação', " +
                        "prontuario as 'Prontuário', nomePaciente as 'Nome do paciente', " +
                        "nomeMae as 'Nome da Mãe', medico as 'Médico', codCentroCusto as 'Centro de custo', motivo as 'Motivo' from MvtMovimentacao left join MvtPaciente " +
                        "on MvtMovimentacao.codPaciente = MvtPaciente.codPaciente where prontuario=" + txtProntuario.Text;
                    using (SqlDataAdapter da = new SqlDataAdapter(sqlQuery, cn))
                    {
                        using (DataTable dt = new DataTable())
                        {
                            da.Fill(dt);

                            dgvMovimentacao.DataSource = dt;
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
            if (comboSituacao.Text == "Internado")
            {
                SalvarMovimentacao();
                LimpaCampos(this.Controls);
                comboMotivo.Text = " ";
            }
            if (comboSituacao.Text == "Alta" || comboSituacao.Text == "Óbito")
            {
                SalvarMovimentacaoAlta();
                LimpaCampos(this.Controls);
                comboMotivo.Text = " ";
            }
        }

        private void SalvarMovimentacao()
        {
            if (txtCod.Text != "" && dtpNascimento.Text != null && dtpEntrada.Text != null && txtProntuario.Text != "" && txtCns.Text != ""
                 && comboMotivo.Text != "" && dtpData.Text != null && txtClinica.Text != "" && txtLocal.Text != "" && txtLeito.Text != ""
                 && dtpHora.Text != null && txtCodCentroCusto.Text != "" && txtMedico.Text != "" && txtCrm.Text != "")
            {
                movimentacao.DataMovimentacao = dtpData.Value.Date;
                movimentacao.HoraMovimentacao = Convert.ToDateTime(dtpHora.Text);
                movimentacao.Motivo = comboMotivo.Text;
                movimentacao.Localizacao = txtLocal.Text;
                movimentacao.Leito = txtLeito.Text;
                movimentacao.ClinicaMedica = txtClinica.Text;
                movimentacao.Medico = txtMedico.Text;
                movimentacao.CRM = txtCrm.Text;
                movimentacao.CodPaciente = int.Parse(txtCod.Text);
                movimentacao.DataNascimento = dtpNascimento.Value.Date;
                movimentacao.CNS = txtCns.Text;
                movimentacao.Prontuario = int.Parse(txtProntuario.Text);
                movimentacao.DataEntrada = dtpEntrada.Value.Date;
                movimentacao.CodCentroCusto = int.Parse(txtCodCentroCusto.Text);
                movimentacao.Situacao = comboSituacao.Text;
                if (!string.IsNullOrEmpty(this.txtSequencia.Text.Trim()))
                {
                    movimentacao.Sequencia = int.Parse(this.txtSequencia.Text.Trim());
                }

                movimentacao.SalvarMovimentacao(movimentacao);
                movimentacao.AtualizarInternacao(movimentacao);

                MessageBox.Show("Movimentação salva!");
                ExibirDados();
                LimpaCampos(this.Controls);
            }
            else
            {
                MessageBox.Show("Insira todos os dados");
            }
        }

        private void SalvarMovimentacaoAlta()
        {
            if (txtProntuario.Text != "" && comboSituacao.Text != "" && dtpData.Text != null)
            {
                movimentacao.DataSaida = Convert.ToDateTime(dtpData.Text);
                movimentacao.HoraSaida = Convert.ToDateTime(dtpHora.Text);
                movimentacao.Situacao = comboSituacao.Text;
                movimentacao.Prontuario = int.Parse(txtProntuario.Text);

                movimentacao.AtualizarInternacaoAlta(movimentacao);

                MessageBox.Show("Paciente com alta/óbito salvo!");
                ExibirDados();
                LimpaCampos(this.Controls);
            }
            else
            {
                MessageBox.Show("Insira todos os dados");
            }
        }

        private void Excluir_Click(object sender, EventArgs e)
        {
            {
                var id = Convert.ToInt32(dgvMovimentacao.Rows[dgvMovimentacao.CurrentCell.RowIndex].Cells[0].Value);
                try
                {
                    using (SqlConnection cn = new SqlConnection(Conn.StrCon))
                    {
                        cn.Open();

                        string sql = "DELETE FROM MvtMovimentacao where sequencia=" + id;

                        using (SqlCommand cmd = new SqlCommand(sql, cn))
                        {
                            if (DialogResult.Yes == MessageBox.Show("Deseja cancelar a movimentação?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2))
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
                    MessageBox.Show("Nenhum paciente selecionado\n\n" + ex.Message);
                }
            }
        }
        private void txtProntuario_Leave(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection cn = new SqlConnection(Conn.StrCon))
                {
                    cn.Open();
                    SqlCommand cmd;
                    SqlDataReader dr;
                    cmd = new SqlCommand("SELECT  prontuario, dataEntrada FROM MvtInternacao WHERE prontuario='" + txtProntuario.Text + "'", cn);
                    dr = cmd.ExecuteReader();
                    if (dr.Read())
                    {
                        dtpEntrada.Text = dr[1].ToString();
                    }
                    cn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }



        private void FormMovimentacao_Load(object sender, EventArgs e)
        {
            //dgvMovimentacao.DataSource = Funcoes.ObterTodosMovimentacao();
            //dgvMovimentacao.Columns[0].Width = 85;
            //dgvMovimentacao.Columns[1].Width = 190;
            dtpNascimento.Value = DateTime.Today;
            txtProntuario.Text = "  ";
            dtpData.Value = DateTime.Today;
            dtpHora.Value = DateTime.Now;
            dtpEntrada.Value = DateTime.Today;
            txtClinica.Clear();
            txtLocal.Clear();
            txtLeito.Clear();
            txtMedico.Clear();
            txtCrm.Text = "  ";

            dgvMovimentacao.AutoResizeColumns();
            dgvMovimentacao.AutoResizeRows();
        }

        private void Limpar_Click(object sender, EventArgs e)
        {
            txtProntuario.Text = "";
            dtpData.Value = DateTime.Today;
            dtpHora.Value = DateTime.Now;
            txtClinica.Text = "";
            txtLocal.Text = "";
            txtLeito.Text = "";
            txtMedico.Text = "";
            txtCrm.Text = "";
            txtCod.Text = "";
            dtpNascimento.Value = DateTime.Today;
            txtCns.Text = "";
        }

        private void LupaPaciente_Click(object sender, EventArgs e)
        {
            FormCadInternacao fci = new FormCadInternacao(this);
            fci.ShowDialog();

            if (DialogResult == DialogResult.None)
            {
                txtProntuario.Text = frmCadInternacao;
            }
        }

        private void txtProntuario_TextChanged(object sender, EventArgs e)
        {
            using (SqlConnection cn = new SqlConnection(Conn.StrCon))
            {
                cn.Open();

                string sql = "SELECT MvtPaciente.codPaciente, MvtPaciente.dataNascimento, dataEntrada, MvtPaciente.cns, nomePaciente, prontuario " +
                    "FROM MvtInternacao LEFT JOIN MvtPaciente ON MvtPaciente.codPaciente = MvtInternacao.codPaciente WHERE prontuario = @prontuario";

                using (SqlCommand cmd = new SqlCommand(sql, cn))
                {
                    cmd.Parameters.AddWithValue("@prontuario", txtProntuario.Text);

                    SqlDataReader da = cmd.ExecuteReader();

                    while (da.Read())
                    {
                        txtCod.Text = da["codPaciente"].ToString();
                        dtpNascimento.Text = da["dataNascimento"].ToString();
                        dtpEntrada.Text = da["dataEntrada"].ToString();
                        txtCns.Text = da["cns"].ToString();
                        txtNomePaciente.Text = da["nomePaciente"].ToString();
                    }

                    if (txtProntuario.Text == "")
                    {
                        txtCod.Text = "";
                        dtpNascimento.Text = "";
                        dtpEntrada.Text = "";
                        txtCns.Text = "";
                        txtNomePaciente.Text = "";
                    }
                }
            }
        }
        private void LupaCentroCusto_Click(object sender, EventArgs e)
        {
            FormCadCentroCusto fcc = new FormCadCentroCusto(this);
            fcc.ShowDialog();

            if (DialogResult == DialogResult.None)
            {
                txtCodCentroCusto.Text = frmCadCentroCusto;
            }
        }

        private void txtCodCentroCusto_TextChanged(object sender, EventArgs e)
        {
            using (SqlConnection cn = new SqlConnection(Conn.StrCon))
            {
                cn.Open();

                string sql = "SELECT nomeCentroCusto FROM MvtCentroCusto WHERE codCentroCusto = @codCentroCusto";

                using (SqlCommand cmd = new SqlCommand(sql, cn))
                {
                    cmd.Parameters.AddWithValue("@codCentroCusto", txtCodCentroCusto.Text);

                    SqlDataReader da = cmd.ExecuteReader();

                    while (da.Read())
                    {
                        txtNomeCentroCusto.Text = da["nomeCentroCusto"].ToString();
                    }

                    if (txtCodCentroCusto.Text == "")
                    {
                        txtNomeCentroCusto.Text = "";
                    }
                }

                cn.Close();
            }
        }
    }
}
