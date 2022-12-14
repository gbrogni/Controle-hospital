using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pacientes
{
    class Movimentacao
    {
        public int Sequencia { get; set; }
        public DateTime DataMovimentacao { get; set; }
        public DateTime HoraMovimentacao { get; set; }
        public string Motivo { get; set; }
        public string Localizacao { get; set; }
        public string Leito { get; set; }
        public string ClinicaMedica { get; set; }
        public string Medico { get; set; }
        public string CRM { get; set; }
        public int CodPaciente { get; set; }
        public DateTime DataNascimento { get; set; }
        public string CNS { get; set; }
        public int Prontuario { get; set; }
        public DateTime DataEntrada { get; set; }
        public DateTime DataSaida { get; set; }
        public DateTime HoraSaida { get; set; }
        public int CodCentroCusto { get; set; }
        public string Situacao { get; set; }
        public string HipoteseDiagnostica { get; set; }
        public string Diagnostico { get; set; }


        public static bool ExisteInternacao(Movimentacao movimentacao)
        {
            bool res;
            SqlDataAdapter da = null;
            DataTable dt = new DataTable();

            using (SqlConnection cn = new SqlConnection(Conn.StrCon))
            {
                cn.Open();
                SqlCommand command = new SqlCommand("Select prontuario from MvtInternacao where prontuario=@prontuario", cn);

                command.Parameters.AddWithValue("@prontuario", movimentacao.Prontuario);
                var result = command.ExecuteScalar();

                return !result.Equals(null);
            }

            return false;
        }


        public void SalvarMovimentacao(Movimentacao movimentacao)
        {
            if (ExisteInternacao(movimentacao))
                try
                {
                    var sql = "INSERT INTO MvtMovimentacao (dataMovimentacao, horaMovimentacao, motivo, localizacao, leito, clinicaMedica, medico, crm, codPaciente," +
                        "dataNascimento, cns, prontuario, dataEntrada, codCentroCusto) VALUES (@dataMovimentacao, @horaMovimentacao, @motivo, @localizacao," +
                        " @leito, @clinicaMedica, @medico, @crm, @codPaciente, @dataNascimento, @cns, @prontuario, @dataEntrada, @codCentroCusto)";
                    using (SqlConnection cn = new SqlConnection(Conn.StrCon))
                    {
                        cn.Open();
                        using (var cmd = new SqlCommand(sql, cn))
                        {
                            cmd.Parameters.AddWithValue("@sequencia", movimentacao.Sequencia);
                            cmd.Parameters.AddWithValue("@dataMovimentacao", movimentacao.DataMovimentacao);
                            cmd.Parameters.AddWithValue("@horaMovimentacao", movimentacao.HoraMovimentacao);
                            cmd.Parameters.AddWithValue("@motivo", movimentacao.Motivo);
                            cmd.Parameters.AddWithValue("@localizacao", movimentacao.Localizacao);
                            cmd.Parameters.AddWithValue("@leito", movimentacao.Leito);
                            cmd.Parameters.AddWithValue("@clinicaMedica", movimentacao.ClinicaMedica);
                            cmd.Parameters.AddWithValue("@medico", movimentacao.Medico);
                            cmd.Parameters.AddWithValue("@crm", movimentacao.CRM);
                            cmd.Parameters.AddWithValue("@codPaciente", movimentacao.CodPaciente);
                            cmd.Parameters.AddWithValue("@dataNascimento", movimentacao.DataNascimento);
                            cmd.Parameters.AddWithValue("@cns", movimentacao.CNS);
                            cmd.Parameters.AddWithValue("@prontuario", movimentacao.Prontuario);
                            cmd.Parameters.AddWithValue("@dataEntrada", movimentacao.DataEntrada);
                            cmd.Parameters.AddWithValue("@codCentroCusto", movimentacao.CodCentroCusto);

                            cmd.ExecuteNonQuery();
                        }
                        cn.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro : " + ex.Message);
                }
        }
        public void AtualizarInternacao(Movimentacao movimentacao)
        {
            if (ExisteInternacao(movimentacao))
                try
                {
                    var sql = "UPDATE MvtInternacao SET clinicaMedica=@clinicaMedica, localizacao=@localizacao, leito=@leito, codCentroCusto=@codCentroCusto," +
                        "medico=@medico, crm=@crm, situacao=@situacao WHERE prontuario=" + movimentacao.Prontuario;
                    using (SqlConnection cn = new SqlConnection(Conn.StrCon))
                    {
                        cn.Open();
                        using (var cmd = new SqlCommand(sql, cn))
                        {
                            cmd.Parameters.AddWithValue("@clinicaMedica", movimentacao.ClinicaMedica);
                            cmd.Parameters.AddWithValue("@localizacao", movimentacao.Localizacao);
                            cmd.Parameters.AddWithValue("@leito", movimentacao.Leito);
                            cmd.Parameters.AddWithValue("@codCentroCusto", movimentacao.CodCentroCusto);
                            cmd.Parameters.AddWithValue("@medico", movimentacao.Medico);
                            cmd.Parameters.AddWithValue("@crm", movimentacao.CRM);
                            cmd.Parameters.AddWithValue("@situacao", movimentacao.Situacao);

                            cmd.ExecuteNonQuery();
                        }
                        cn.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro : " + ex.Message);
                }
        }
        public void AtualizarInternacaoAlta(Movimentacao movimentacao)
        {
            if (ExisteInternacao(movimentacao))
                try
                {
                    var sql = "UPDATE MvtInternacao SET dataSaida=@dataSaida, horaSaida=@horaSaida, situacao=@situacao WHERE prontuario=@prontuario";
                    using (SqlConnection cn = new SqlConnection(Conn.StrCon))
                    {
                        cn.Open();
                        using (var cmd = new SqlCommand(sql, cn))
                        {
                            cmd.Parameters.AddWithValue("@dataSaida", movimentacao.DataSaida);
                            cmd.Parameters.AddWithValue("@horaSaida", movimentacao.HoraSaida);
                            cmd.Parameters.AddWithValue("@situacao", movimentacao.Situacao);
                            cmd.Parameters.AddWithValue("@prontuario", movimentacao.Prontuario);

                            cmd.ExecuteNonQuery();
                        }
                        cn.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro : " + ex.Message);
                }
        }
    }
}
