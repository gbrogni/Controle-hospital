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
    public partial class FormConsulta : Form
    {
        public FormConsulta()
        {
            InitializeComponent();
        }

        private void FormConsulta_Load(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection cn = new SqlConnection(Conn.StrCon))
                {
                    cn.Open();
                    string sqlQuery = "SELECT MvtInternacao.codPaciente as 'Código do paciente', prontuario as 'Prontuário', nomePaciente as 'Nome do Paciente'," +
                        " MvtPaciente.dataNascimento as 'Data de nascimento', rg as 'RG', cpf as 'CPF', nomeMae as 'Nome da mãe',localizacao as 'Localização', " +
                        "leito as 'Leito', situacao as 'Situação'FROM MvtPaciente LEFT JOIN MvtInternacao  ON MvtPaciente.codPaciente = MvtInternacao.codPaciente";

                    using (SqlDataAdapter da = new SqlDataAdapter(sqlQuery, cn))
                    {
                        using (DataTable dt = new DataTable())
                        {
                            da.Fill(dt);

                            dgvConsulta.DataSource = dt;
                        }
                    }
                    cn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Falha ao tentar conectar\n\n" + ex.Message);
            }
            dgvConsulta.Columns[0].Width = 85;
            dgvConsulta.Columns[1].Width = 190;

            dgvConsulta.AutoResizeColumns();
            dgvConsulta.AutoResizeRows();
        }

        private void txtCod_Leave(object sender, EventArgs e)
        {

            try
            {
                using (SqlConnection cn = new SqlConnection(Conn.StrCon))
                {
                    cn.Open();
                    SqlCommand cmd;
                    SqlDataReader dr;
                    cmd = new SqlCommand("SELECT  MvtPaciente.codPaciente as 'Código do paciente', nomePaciente as 'Nome do paciente', cpf as 'CPF', rg as 'RG', prontuario as 'Prontuário', " +
                        "situacao as 'Situação' FROM MvtPaciente LEFT JOIN MvtInternacao ON MvtPaciente.codPaciente = MvtInternacao.codPaciente" +
                        " WHERE MvtPaciente.codPaciente='" + txtCod.Text + "'", cn);
                    dr = cmd.ExecuteReader();
                    if (dr.Read())
                    {
                        txtNomePaciente.Text = dr[1].ToString();
                        txtCpf.Text = dr[2].ToString();
                        txtRg.Text = dr[3].ToString();
                        txtProntuario.Text = dr[4].ToString();
                        txtSituacao.Text = dr[5].ToString();
                    }
                    cn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Consultar_Click(object sender, EventArgs e)
        {
            if (comboTop.Text == "TOP 50" && comboTipo.Text == "Óbito")
            {
                try
                {
                    using (SqlConnection cn = new SqlConnection(Conn.StrCon))
                    {
                        cn.Open();
                        string sqlQuery = "SELECT TOP (50) MvtInternacao.codPaciente as 'Código do paciente', prontuario as 'Prontuário', nomePaciente as 'Nome do Paciente'," +
                            " MvtPaciente.dataNascimento as 'Data de nascimento', rg as 'RG', cpf as 'CPF', nomeMae as 'Nome da mãe',localizacao as 'Localização', " +
                            "leito as 'Leito', situacao as 'Situação'FROM MvtPaciente LEFT JOIN MvtInternacao  ON MvtPaciente.codPaciente = MvtInternacao.codPaciente WHERE situacao = 'Óbito'";

                        using (SqlDataAdapter da = new SqlDataAdapter(sqlQuery, cn))
                        {
                            using (DataTable dt = new DataTable())
                            {
                                da.Fill(dt);

                                dgvConsulta.DataSource = dt;
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
            else if (comboTop.Text == "TOP 50" && comboTipo.Text == "Alta")
            {
                try
                {
                    using (SqlConnection cn = new SqlConnection(Conn.StrCon))
                    {
                        cn.Open();
                        string sqlQuery = "SELECT TOP (100) MvtInternacao.codPaciente as 'Código do paciente', prontuario as 'Prontuário', nomePaciente as 'Nome do Paciente'," +
                            " MvtPaciente.dataNascimento as 'Data de nascimento', rg as 'RG', cpf as 'CPF', nomeMae as 'Nome da mãe',localizacao as 'Localização', " +
                            "leito as 'Leito', situacao as 'Situação'FROM MvtPaciente LEFT JOIN MvtInternacao  ON MvtPaciente.codPaciente = MvtInternacao.codPaciente WHERE situacao = 'Alta'";

                        using (SqlDataAdapter da = new SqlDataAdapter(sqlQuery, cn))
                        {
                            using (DataTable dt = new DataTable())
                            {
                                da.Fill(dt);

                                dgvConsulta.DataSource = dt;
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
            else if (comboTop.Text == "TOP 50" && comboTipo.Text == "Internados")
            {
                try
                {
                    using (SqlConnection cn = new SqlConnection(Conn.StrCon))
                    {
                        cn.Open();
                        string sqlQuery = "SELECT TOP (100) MvtInternacao.codPaciente as 'Código do paciente', prontuario as 'Prontuário', nomePaciente as 'Nome do Paciente'," +
                            " MvtPaciente.dataNascimento as 'Data de nascimento', rg as 'RG', cpf as 'CPF', nomeMae as 'Nome da mãe',localizacao as 'Localização', " +
                            "leito as 'Leito', situacao as 'Situação'FROM MvtPaciente LEFT JOIN MvtInternacao  ON MvtPaciente.codPaciente = MvtInternacao.codPaciente WHERE situacao = 'Internado'";

                        using (SqlDataAdapter da = new SqlDataAdapter(sqlQuery, cn))
                        {
                            using (DataTable dt = new DataTable())
                            {
                                da.Fill(dt);

                                dgvConsulta.DataSource = dt;
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
            else if (comboTop.Text == "TOP 100" && comboTipo.Text == "Óbito")
            {
                try
                {
                    using (SqlConnection cn = new SqlConnection(Conn.StrCon))
                    {
                        cn.Open();
                        string sqlQuery = "SELECT TOP (50) MvtInternacao.codPaciente as 'Código do paciente', prontuario as 'Prontuário', nomePaciente as 'Nome do Paciente'," +
                            " MvtPaciente.dataNascimento as 'Data de nascimento', rg as 'RG', cpf as 'CPF', nomeMae as 'Nome da mãe',localizacao as 'Localização', " +
                            "leito as 'Leito', situacao as 'Situação'FROM MvtPaciente LEFT JOIN MvtInternacao  ON MvtPaciente.codPaciente = MvtInternacao.codPaciente WHERE situacao = 'Óbito'";

                        using (SqlDataAdapter da = new SqlDataAdapter(sqlQuery, cn))
                        {
                            using (DataTable dt = new DataTable())
                            {
                                da.Fill(dt);

                                dgvConsulta.DataSource = dt;
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
            else if (comboTop.Text == "TOP 100" && comboTipo.Text == "Alta")
            {
                try
                {
                    using (SqlConnection cn = new SqlConnection(Conn.StrCon))
                    {
                        cn.Open();
                        string sqlQuery = "SELECT TOP (100) MvtInternacao.codPaciente as 'Código do paciente', prontuario as 'Prontuário', nomePaciente as 'Nome do Paciente'," +
                            " MvtPaciente.dataNascimento as 'Data de nascimento', rg as 'RG', cpf as 'CPF', nomeMae as 'Nome da mãe',localizacao as 'Localização', " +
                            "leito as 'Leito', situacao as 'Situação'FROM MvtPaciente LEFT JOIN MvtInternacao  ON MvtPaciente.codPaciente = MvtInternacao.codPaciente WHERE situacao = 'Alta'";

                        using (SqlDataAdapter da = new SqlDataAdapter(sqlQuery, cn))
                        {
                            using (DataTable dt = new DataTable())
                            {
                                da.Fill(dt);

                                dgvConsulta.DataSource = dt;
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
            else if (comboTop.Text == "TOP 100" && comboTipo.Text == "Internados")
            {
                try
                {
                    using (SqlConnection cn = new SqlConnection(Conn.StrCon))
                    {
                        cn.Open();
                        string sqlQuery = "SELECT TOP (100) MvtInternacao.codPaciente as 'Código do paciente', prontuario as 'Prontuário', nomePaciente as 'Nome do Paciente'," +
                            " MvtPaciente.dataNascimento as 'Data de nascimento', rg as 'RG', cpf as 'CPF', nomeMae as 'Nome da mãe',localizacao as 'Localização', " +
                            "leito as 'Leito', situacao as 'Situação'FROM MvtPaciente LEFT JOIN MvtInternacao  ON MvtPaciente.codPaciente = MvtInternacao.codPaciente WHERE situacao = 'Internado'";

                        using (SqlDataAdapter da = new SqlDataAdapter(sqlQuery, cn))
                        {
                            using (DataTable dt = new DataTable())
                            {
                                da.Fill(dt);

                                dgvConsulta.DataSource = dt;
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
            else if (comboTop.Text == "TOP 200" && comboTipo.Text == "Óbito")
            {
                try
                {
                    using (SqlConnection cn = new SqlConnection(Conn.StrCon))
                    {
                        cn.Open();
                        string sqlQuery = "SELECT TOP (50) MvtInternacao.codPaciente as 'Código do paciente', prontuario as 'Prontuário', nomePaciente as 'Nome do Paciente'," +
                            " MvtPaciente.dataNascimento as 'Data de nascimento', rg as 'RG', cpf as 'CPF', nomeMae as 'Nome da mãe',localizacao as 'Localização', " +
                            "leito as 'Leito', situacao as 'Situação'FROM MvtPaciente LEFT JOIN MvtInternacao  ON MvtPaciente.codPaciente = MvtInternacao.codPaciente WHERE situacao = 'Óbito'";

                        using (SqlDataAdapter da = new SqlDataAdapter(sqlQuery, cn))
                        {
                            using (DataTable dt = new DataTable())
                            {
                                da.Fill(dt);

                                dgvConsulta.DataSource = dt;
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
            else if (comboTop.Text == "TOP 200" && comboTipo.Text == "Alta")
            {
                try
                {
                    using (SqlConnection cn = new SqlConnection(Conn.StrCon))
                    {
                        cn.Open();
                        string sqlQuery = "SELECT TOP (50) MvtInternacao.codPaciente as 'Código do paciente', prontuario as 'Prontuário', nomePaciente as 'Nome do Paciente'," +
                            " MvtPaciente.dataNascimento as 'Data de nascimento', rg as 'RG', cpf as 'CPF', nomeMae as 'Nome da mãe',localizacao as 'Localização', " +
                            "leito as 'Leito', situacao as 'Situação'FROM MvtPaciente LEFT JOIN MvtInternacao  ON MvtPaciente.codPaciente = MvtInternacao.codPaciente WHERE situacao = 'Alta'";

                        using (SqlDataAdapter da = new SqlDataAdapter(sqlQuery, cn))
                        {
                            using (DataTable dt = new DataTable())
                            {
                                da.Fill(dt);

                                dgvConsulta.DataSource = dt;
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
            else if (comboTop.Text == "TOP 200" && comboTipo.Text == "Internados")
            {
                try
                {
                    using (SqlConnection cn = new SqlConnection(Conn.StrCon))
                    {
                        cn.Open();
                        string sqlQuery = "SELECT TOP (100) MvtInternacao.codPaciente as 'Código do paciente', prontuario as 'Prontuário', nomePaciente as 'Nome do Paciente'," +
                            " MvtPaciente.dataNascimento as 'Data de nascimento', rg as 'RG', cpf as 'CPF', nomeMae as 'Nome da mãe',localizacao as 'Localização', " +
                            "leito as 'Leito', situacao as 'Situação'FROM MvtPaciente LEFT JOIN MvtInternacao  ON MvtPaciente.codPaciente = MvtInternacao.codPaciente WHERE situacao = 'Internado'";

                        using (SqlDataAdapter da = new SqlDataAdapter(sqlQuery, cn))
                        {
                            using (DataTable dt = new DataTable())
                            {
                                da.Fill(dt);

                                dgvConsulta.DataSource = dt;
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
            else if (comboTop.Text == "TOP 50")
            {
                try
                {
                    using (SqlConnection cn = new SqlConnection(Conn.StrCon))
                    {
                        cn.Open();
                        string sqlQuery = "SELECT TOP (100) MvtInternacao.codPaciente as 'Código do paciente', prontuario as 'Prontuário', nomePaciente as 'Nome do Paciente'," +
                            " MvtPaciente.dataNascimento as 'Data de nascimento', rg as 'RG', cpf as 'CPF', nomeMae as 'Nome da mãe',localizacao as 'Localização', " +
                            "leito as 'Leito', situacao as 'Situação'FROM MvtPaciente LEFT JOIN MvtInternacao  ON MvtPaciente.codPaciente = MvtInternacao.codPaciente";

                        using (SqlDataAdapter da = new SqlDataAdapter(sqlQuery, cn))
                        {
                            using (DataTable dt = new DataTable())
                            {
                                da.Fill(dt);

                                dgvConsulta.DataSource = dt;
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
            else if (comboTop.Text == "TOP 100")
            {
                try
                {
                    using (SqlConnection cn = new SqlConnection(Conn.StrCon))
                    {
                        cn.Open();
                        string sqlQuery = "SELECT TOP (100) MvtInternacao.codPaciente as 'Código do paciente', prontuario as 'Prontuário', nomePaciente as 'Nome do Paciente'," +
                            " MvtPaciente.dataNascimento as 'Data de nascimento', rg as 'RG', cpf as 'CPF', nomeMae as 'Nome da mãe',localizacao as 'Localização', " +
                            "leito as 'Leito', situacao as 'Situação'FROM MvtPaciente LEFT JOIN MvtInternacao  ON MvtPaciente.codPaciente = MvtInternacao.codPaciente";

                        using (SqlDataAdapter da = new SqlDataAdapter(sqlQuery, cn))
                        {
                            using (DataTable dt = new DataTable())
                            {
                                da.Fill(dt);

                                dgvConsulta.DataSource = dt;
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
            else if (comboTop.Text == "TOP 200")
            {
                try
                {
                    using (SqlConnection cn = new SqlConnection(Conn.StrCon))
                    {
                        cn.Open();
                        string sqlQuery = "SELECT TOP (100) MvtInternacao.codPaciente as 'Código do paciente', prontuario as 'Prontuário', nomePaciente as 'Nome do Paciente'," +
                            " MvtPaciente.dataNascimento as 'Data de nascimento', rg as 'RG', cpf as 'CPF', nomeMae as 'Nome da mãe',localizacao as 'Localização', " +
                            "leito as 'Leito', situacao as 'Situação'FROM MvtPaciente LEFT JOIN MvtInternacao  ON MvtPaciente.codPaciente = MvtInternacao.codPaciente";

                        using (SqlDataAdapter da = new SqlDataAdapter(sqlQuery, cn))
                        {
                            using (DataTable dt = new DataTable())
                            {
                                da.Fill(dt);

                                dgvConsulta.DataSource = dt;
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
            else
            {
                MessageBox.Show("Selecione uma opção de consulta\n\n");
                return;
            }
        }

        private void Limpar_Click(object sender, EventArgs e)
        {
            txtCpf.Text = "";
            txtRg.Text = "";
            txtCod.Text = "";
            txtProntuario.Text = "";
            txtNomePaciente.Text = "";
            txtSituacao.Text = "";
        }
    }
}

