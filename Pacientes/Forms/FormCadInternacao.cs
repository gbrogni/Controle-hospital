using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Pacientes
{
    public partial class FormCadInternacao : Form
    {
        private Internacao internacao = new Internacao();
        public string frmCadPaciente { get; set; }
        public string frmCadCentroCusto { get; set; }


        public FormCadInternacao(string codPaciente)
        {
            InitializeComponent();
            txtCod.Text = codPaciente;
        }
        public FormCadInternacao()
        {
            InitializeComponent();
        }

        FormMovimentacao frmRI = new FormMovimentacao();

        public FormCadInternacao(FormMovimentacao RI)
        {
            InitializeComponent();
            frmRI = RI;
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
                    string sqlQuery = "SELECT TOP (50) prontuario as 'Prontuário', nomePaciente as 'Nome', dataEntrada as 'Data de entrada', horaEntrada as 'Hora de entrada'," +
                        " dataSaida as 'Data saída', horaSaida as 'Hora saída', clinicaMedica as 'Clínica', localizacao as 'Sala', leito as 'Leito', " +
                        " hipoteseDiagnostica as 'Hipótese diagnóstica', medico as 'Médico', nomeCentroCusto as 'CentroCusto',  crm as 'CRM', diagnostico as 'Diagnóstico', " +
                        "situacao  as 'Situação' FROM MvtPaciente JOIN MvtInternacao ON MvtPaciente.codPaciente = MvtInternacao.codPaciente" +
                        " LEFT JOIN MvtCentroCusto ON MvtCentroCusto.codCentroCusto = MvtInternacao.codCentroCusto WHERE dataEntrada" +
                        " BETWEEN  CONVERT(date, GETDATE()) and dataEntrada";

                    using (SqlDataAdapter da = new SqlDataAdapter(sqlQuery, cn))
                    {
                        using (DataTable dt = new DataTable())
                        {
                            da.Fill(dt);

                            dgvInternacao.DataSource = dt;
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
            SalvarInternacao();
            LimpaCampos(this.Controls);
            comboSituacao.Text = " ";
        }

        private void SalvarInternacao()
        {
            if (Internacao.ExisteInternacao(internacao))
            {
                MessageBox.Show("Paciente já está internado");

                return;
            }
            else if (comboSituacao.Text != "" && dtpDataEntrada.Text != null && dtpHoraEntrada.Text != "" && txtClinica.Text != "" && txtLocal.Text != ""
                && txtLeito.Text != "" && txtHipotese.Text != "" && txtDiagnostico.Text != "" && txtMedico.Text != "" && txtCrm.Text != "" && txtCod.Text != "" && dtpNascimento.Text != null
                && txtCns.Text != "" && txtCodCentroCusto.Text != "")
            {
                internacao.DataEntrada = dtpDataEntrada.Value.Date;
                internacao.HoraEntrada = Convert.ToDateTime(dtpHoraEntrada.Text);
                internacao.DataSaida = dtpDataSaida.Value.Date;
                internacao.HoraSaida = Convert.ToDateTime(dtpHoraSaida.Text);
                internacao.ClinicaMedica = txtClinica.Text;
                internacao.Localizacao = txtLocal.Text;
                internacao.Leito = txtLeito.Text;
                internacao.HipoteseDiagnostico = txtHipotese.Text;
                internacao.Diagnostico = txtDiagnostico.Text;
                internacao.Situacao = comboSituacao.Text;
                internacao.Medico = txtMedico.Text;
                internacao.CRM = txtCrm.Text;
                internacao.CodPaciente = int.Parse(txtCod.Text);
                internacao.DataNascimento = dtpNascimento.Value.Date;
                internacao.CNS = txtCns.Text;
                internacao.CodCentroCusto = int.Parse(txtCodCentroCusto.Text);
                internacao.Prontuario = 0;
                if (!string.IsNullOrEmpty(this.txtProntuario.Text.Trim()))
                {
                    internacao.Prontuario = int.Parse(this.txtProntuario.Text.Trim());
                }

                internacao.SalvarInternacao(internacao);

                MessageBox.Show("Internação salva!");
                ExibirDados();
                LimpaCampos(this.Controls);
            }
            else
            {
                MessageBox.Show("Insira todos os dados");
            }
        }
        private void FormCadInternacao_Load(object sender, EventArgs e)
        {
            dgvInternacao.DataSource = Funcoes.ObterTodosInternacao();
            dgvInternacao.Columns[0].Width = 85;
            dgvInternacao.Columns[1].Width = 190;
            dtpNascimento.Value = DateTime.Today;
            dtpHoraEntrada.Value = DateTime.Now;
            dtpDataEntrada.Value = DateTime.Today;
            txtProntuario.Clear();
            txtCod.Clear();
            dtpDataSaida.Value = DateTime.Today;
            dtpHoraSaida.Value = DateTime.Now;
            txtClinica.Clear();
            txtLocal.Clear();
            txtLeito.Clear();
            txtHipotese.Clear();
            txtDiagnostico.Clear();
            txtMedico.Clear();
            txtCrm.Text = "  ";

            dgvInternacao.AutoResizeColumns();
            dgvInternacao.AutoResizeRows();
        }

        private void Excluir_Click(object sender, EventArgs e)
        {
            {
                var id = Convert.ToInt32(dgvInternacao.Rows[dgvInternacao.CurrentCell.RowIndex].Cells[0].Value);
                try
                {
                    using (SqlConnection cn = new SqlConnection(Conn.StrCon))
                    {
                        cn.Open();

                        string sql = "DELETE FROM MvtInternacao where prontuario=" + id;

                        using (SqlCommand cmd = new SqlCommand(sql, cn))
                        {
                            if (DialogResult.Yes == MessageBox.Show("Deseja excluir o registro de internação?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2))
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

        private void txtCns_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8) e.Handled = true;
            txtCns.MaxLength = 15;
        }

        private void Limpar_Click(object sender, EventArgs e)
        {
            txtProntuario.Text = " ";
            dtpDataEntrada.Value = DateTime.Today;
            dtpHoraEntrada.Value = DateTime.Now;
            dtpDataSaida.Value = DateTime.Today;
            dtpHoraSaida.Value = DateTime.Now;
            txtClinica.Text = " ";
            txtLocal.Text = " ";
            txtLeito.Text = " ";
            txtHipotese.Text = " ";
            txtDiagnostico.Text = " ";
            comboSituacao.Text = "  ";
            txtMedico.Text = " ";
            txtCrm.Text = " ";
            txtCod.Text = " ";
            dtpNascimento.Value = DateTime.Now;
            txtCns.Text = " ";
        }

        private void btnOpenPacientece_Click(object sender, EventArgs e)
        {
            FormCadPaciente fcp = new FormCadPaciente(this);
            fcp.ShowDialog();

            if (DialogResult == DialogResult.None)
            {
                txtCod.Text = frmCadPaciente;
            }
        }

        private void txtCod_TextChanged(object sender, EventArgs e)
        {
            using (SqlConnection cn = new SqlConnection(Conn.StrCon))
            {
                cn.Open();

                string sql = "SELECT nomePaciente, dataNascimento, nomeMae, cns FROM MvtPaciente WHERE codPaciente = @codPaciente";

                using (SqlCommand cmd = new SqlCommand(sql, cn))
                {
                    cmd.Parameters.AddWithValue("@codPaciente", txtCod.Text);

                    SqlDataReader da = cmd.ExecuteReader();

                    while (da.Read())
                    {
                        txtNomePaciente.Text = da["nomePaciente"].ToString();
                        dtpNascimento.Text = da["dataNascimento"].ToString();
                        txtNomeMae.Text = da["nomeMae"].ToString();
                        txtCns.Text = da["cns"].ToString();
                    }

                    if (txtCod.Text == "")
                    {
                        txtNomePaciente.Text = "";
                        txtNomeMae.Text = "";
                        dtpNascimento.Text = "";
                        txtCns.Text = "";
                    }
                }

                cn.Close();
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
        private void dgvInternacao_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewRow dgrv = dgvInternacao.Rows[e.RowIndex];
            frmRI.frmCadInternacao = dgrv.Cells[0].Value.ToString();

            Close();
        }

        private void dgvInternacao_SelectionChanged(object sender, EventArgs e)
        {
            DataGridView dgv = (DataGridView)sender;
            int contlinhas = dgv.SelectedRows.Count;
            if (contlinhas > 0)
            {
                DataTable dt = new DataTable();
                string vid = dgv.SelectedRows[0].Cells[0].Value.ToString();
                dt = Funcoes.ObterDadosInternacaoForm(vid);
                txtProntuario.Text = dt.Rows[0].Field<int>("prontuario").ToString();
                dtpDataEntrada.Text = dt.Rows[0].Field<DateTime>("dataEntrada").ToString();
                dtpHoraEntrada.Text = dt.Rows[0].Field<DateTime>("horaEntrada").ToString();
                txtClinica.Text = dt.Rows[0].Field<string>("clinicaMedica").ToString();
                txtLocal.Text = dt.Rows[0].Field<string>("localizacao").ToString();
                txtLeito.Text = dt.Rows[0].Field<string>("leito").ToString();
                txtHipotese.Text = dt.Rows[0].Field<string>("hipoteseDiagnostica").ToString();
                txtDiagnostico.Text = dt.Rows[0].Field<string>("diagnostico").ToString();
                comboSituacao.Text = dt.Rows[0].Field<string>("situacao").ToString();
                txtMedico.Text = dt.Rows[0].Field<string>("medico").ToString();
                txtCrm.Text = dt.Rows[0].Field<string>("crm").ToString();
                txtCod.Text = dt.Rows[0].Field<int>("codPaciente").ToString();
                dtpNascimento.Text = dt.Rows[0].Field<DateTime>("dataNascimento").ToString();
                txtCns.Text = dt.Rows[0].Field<string>("cns").ToString();
            }
        }

        private void txtProntuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8) e.Handled = true;
        }

    }
}
