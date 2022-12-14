using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Pacientes
{
    public partial class FormCadPaciente : Form
    {
        private Pacientes pacientes = new Pacientes();
        public string frmCadInternacaoo { get; set; }
        public FormCadPaciente()
        {
            InitializeComponent();
        }

        FormCadInternacao frmRI = new FormCadInternacao();

        public FormCadPaciente(FormCadInternacao RI)
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
                    string sqlQuery = "SELECT codPaciente as 'Código do paciente', nomePaciente as 'Nome do paciente', dataNascimento as 'Data de nascimento'," +
                        "nomeMae as 'Nome da mãe', sexo as 'Sexo', cor as 'Cor', cpf as 'CPF', rg as 'RG', nacionalidade as 'Nacionalidade', naturalidade as 'Naturalidade'," +
                        "grauInstrucao as 'Grau de instrução', profissao as 'Profissão', responsavel as 'Responsável', cep as 'CEP', enderecoRua as 'Rua', enderecoBairro as 'Bairro'," +
                        "enderecoCidade as 'Cidade', enderecoUf as 'UF', telefone as 'Telefone', celular as 'Celular', contatoNome as 'Nome do contato', contatoTelefone as 'Telefone do contato'," +
                        "email as 'E-mail', observacao as 'Observação', cns as 'CNS' FROM MvtPaciente";
                    using (SqlDataAdapter da = new SqlDataAdapter(sqlQuery, cn))
                    {
                        using (DataTable dt = new DataTable())
                        {
                            da.Fill(dt);

                            dgvPaciente.DataSource = dt;
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
            SalvarPaciente();
            LimpaCampos(this.Controls);
            comboSexo.Text = " ";
            comboCor.Text = " ";
            comboUf.Text = " ";
        }

        private void SalvarPaciente()
        {
            if (txtNomePaciente.Text != "" && dtpNascimento != null && txtNomeMae.Text != "" && comboSexo.Text != "" && txtCpf.Text != "" && txtRg.Text != ""
                && txtNacionalidade.Text != "" && txtNaturalidade.Text != "" && txtInstrucao.Text != "" && txtProfissao.Text != "" && txtCep.Text != "" && txtRua.Text != ""
                && txtBairro.Text != "" && txtCidade.Text != "" && comboUf.Text != "" && txtCns.Text != "")
            {
                pacientes.NomePaciente = txtNomePaciente.Text;
                pacientes.DataNascimento = dtpNascimento.Value.Date;
                pacientes.NomeMae = txtNomeMae.Text;
                pacientes.Sexo = comboSexo.Text;
                pacientes.Cor = comboCor.Text;
                pacientes.CPF = txtCpf.Text;
                pacientes.RG = txtRg.Text;
                pacientes.Nacionalidade = txtNacionalidade.Text;
                pacientes.Naturalidade = txtNaturalidade.Text;
                pacientes.GrauInstrucao = txtInstrucao.Text;
                pacientes.Profissao = txtProfissao.Text;
                pacientes.Responsavel = txtResponsavel.Text;
                pacientes.CEP = txtCep.Text;
                pacientes.Rua = txtRua.Text;
                pacientes.Bairro = txtBairro.Text;
                pacientes.Cidade = txtCidade.Text;
                pacientes.UF = comboUf.Text;
                pacientes.Telefone = txtTelefone.Text;
                pacientes.Celular = txtCelular.Text;
                pacientes.ContatoNome = txtContatoNome.Text;
                pacientes.ContatoTelefone = txtTelefoneContato.Text;
                pacientes.Email = txtEmail.Text;
                pacientes.Observacao = txtObservacao.Text;
                pacientes.CNS = txtCns.Text;
                pacientes.CodPaciente = string.IsNullOrEmpty(this.txtCod.Text)
               ? 0
               : int.Parse(this.txtCod.Text);

                pacientes.SalvarPaciente(pacientes);

                MessageBox.Show("Pacientes salvo!");
                ExibirDados();
                LimpaCampos(this.Controls);
            }
            else
            {
                MessageBox.Show("Insira todos os dados");
            }
        }

        private void FormCadPaciente_Load(object sender, EventArgs e)
        {
            dgvPaciente.DataSource = Funcoes.ObterTodosPaciente();
            dgvPaciente.Columns[0].Width = 85;
            dgvPaciente.Columns[1].Width = 190;
            dtpNascimento.Value = DateTime.Today;
            txtCod.Clear();
            txtNomePaciente.Clear();
            dtpNascimento.Value = DateTime.Now;
            txtNomeMae.Clear();
            comboSexo.Text = " ";
            comboCor.Text = " ";
            txtCpf.Clear();
            txtRg.Clear();
            txtNacionalidade.Clear();
            txtNaturalidade.Clear();
            txtInstrucao.Clear();
            txtProfissao.Clear();
            txtResponsavel.Clear();
            txtCep.Clear();
            txtRua.Clear();
            txtBairro.Clear();
            txtCidade.Clear();
            comboUf.Text = " ";
            txtTelefone.Clear();
            txtCelular.Clear();
            txtContatoNome.Clear();
            txtTelefoneContato.Clear();
            txtEmail.Clear();
            txtObservacao.Clear();
            txtCns.Clear();



            dgvPaciente.AutoResizeColumns();
            dgvPaciente.AutoResizeRows();
        }

        private void Excluir_Click(object sender, EventArgs e)
        {
            {
                var id = Convert.ToInt32(dgvPaciente.Rows[dgvPaciente.CurrentCell.RowIndex].Cells[0].Value);
                try
                {
                    using (SqlConnection cn = new SqlConnection(Conn.StrCon))
                    {
                        cn.Open();

                        string sql = "DELETE FROM MvtPaciente where codPaciente=" + id;

                        using (SqlCommand cmd = new SqlCommand(sql, cn))
                        {
                            if (DialogResult.Yes == MessageBox.Show("Deseja excluir o paciente", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2))
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

        private void dgvPaciente_SelectionChanged(object sender, EventArgs e)
        {
            DataGridView dgv = (DataGridView)sender;
            int contlinhas = dgv.SelectedRows.Count;
            if (contlinhas > 0)
            {
                DataTable dt = new DataTable();
                string vid = dgv.SelectedRows[0].Cells[0].Value.ToString();
                dt = Funcoes.ObterDadosPacienteForm(vid);
                txtCod.Text = dt.Rows[0].Field<int>("codPaciente").ToString();
                txtNomePaciente.Text = dt.Rows[0].Field<string>("nomePaciente").ToString();
                dtpNascimento.Text = dt.Rows[0].Field<DateTime>("dataNascimento").ToString();
                txtNomeMae.Text = dt.Rows[0].Field<string>("nomeMae").ToString();
                comboSexo.Text = dt.Rows[0].Field<string>("sexo").ToString();
                comboCor.Text = dt.Rows[0].Field<string>("cor").ToString();
                txtCpf.Text = dt.Rows[0].Field<string>("cpf").ToString();
                txtRg.Text = dt.Rows[0].Field<string>("rg").ToString();
                txtNacionalidade.Text = dt.Rows[0].Field<string>("nacionalidade").ToString();
                txtNaturalidade.Text = dt.Rows[0].Field<string>("naturalidade").ToString();
                txtInstrucao.Text = dt.Rows[0].Field<string>("grauInstrucao").ToString();
                txtProfissao.Text = dt.Rows[0].Field<string>("profissao").ToString();
                txtResponsavel.Text = dt.Rows[0].Field<string>("responsavel").ToString();
                txtCep.Text = dt.Rows[0].Field<string>("cep").ToString();
                txtRua.Text = dt.Rows[0].Field<string>("enderecoRua").ToString();
                txtBairro.Text = dt.Rows[0].Field<string>("enderecoBairro").ToString();
                txtCidade.Text = dt.Rows[0].Field<string>("enderecoCidade").ToString();
                comboUf.Text = dt.Rows[0].Field<string>("enderecoUf").ToString();
                txtTelefone.Text = dt.Rows[0].Field<string>("telefone").ToString();
                txtCelular.Text = dt.Rows[0].Field<string>("celular").ToString();
                txtContatoNome.Text = dt.Rows[0].Field<string>("contatoNome").ToString();
                txtTelefoneContato.Text = dt.Rows[0].Field<string>("contatoTelefone").ToString();
                txtEmail.Text = dt.Rows[0].Field<string>("email").ToString();
                txtObservacao.Text = dt.Rows[0].Field<string>("observacao").ToString();
                txtCns.Text = dt.Rows[0].Field<string>("cns").ToString();
            }
        }

        private void txtNomePaciente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != 8) ;
        }

        private void txtCpf_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8) e.Handled = true;
            txtCpf.MaxLength = 11;
        }

        private void txtRg_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8) e.Handled = true;
            txtRg.MaxLength = 7;
        }

        private void txtNacionalidade_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != 8) ;
        }

        private void txtNaturalidade_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != 8) ;
        }

        private void txtNomeMae_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != 8) ;
        }

        private void txtResponsavel_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != 8) ;
        }

        private void txtCns_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8) e.Handled = true;
            txtCns.MaxLength = 15;
        }

        private void txtTelefone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8) e.Handled = true;
            txtTelefone.MaxLength = 10;
        }

        private void txtCelular_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8) e.Handled = true;
            txtCelular.MaxLength = 11;
        }

        private void txtContatoNome_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != 8) ;
        }

        private void txtTelefoneContato_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8) e.Handled = true;
            txtTelefoneContato.MaxLength = 10;
        }

        private void txtCep_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8) e.Handled = true;
            txtCep.MaxLength = 8;
        }

        private void Limpar_Click(object sender, EventArgs e)
        {
            txtCod.Text = "";
            txtNomePaciente.Text = "";
            dtpNascimento.Value = DateTime.Now;
            txtNomeMae.Text = "";
            comboSexo.Text = " ";
            comboCor.Text = " ";
            txtCpf.Text = "";
            txtRg.Text = "";
            txtNacionalidade.Text = "";
            txtNaturalidade.Text = "";
            txtInstrucao.Text = "";
            txtProfissao.Text = "";
            txtResponsavel.Text = "";
            txtCep.Text = "";
            txtRua.Text = "";
            txtBairro.Text = "";
            txtCidade.Text = "";
            comboUf.Text = " ";
            txtTelefone.Text = "";
            txtCelular.Text = "";
            txtContatoNome.Text = "";
            txtTelefoneContato.Text = "";
            txtEmail.Text = "";
            txtObservacao.Text = "";
            txtCns.Text = "";
        }


        private void dgvPaciente_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewRow dgrv = dgvPaciente.Rows[e.RowIndex];
            frmRI.frmCadPaciente = dgrv.Cells[0].Value.ToString();

            Close();
        }

        private void Internar_Click(object sender, EventArgs e)
        {
            FormCadInternacao tela = new FormCadInternacao(txtCod.Text);
            tela.ShowDialog();
        }
    }
}
