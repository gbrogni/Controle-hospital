using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Pacientes
{
    class Internacao
    {
        public int Prontuario { get; set; }
        public DateTime DataEntrada { get; set; }
        public DateTime HoraEntrada { get; set; }
        public DateTime DataSaida { get; set; }
        public DateTime HoraSaida { get; set; }
        public string ClinicaMedica { get; set; }
        public string Localizacao { get; set; }
        public string Leito { get; set; }
        public string HipoteseDiagnostico { get; set; }
        public string Diagnostico { get; set; }
        public string Situacao { get; set; }
        public string Medico { get; set; }
        public string CRM { get; set; }
        public int CodPaciente { get; set; }
        public DateTime DataNascimento { get; set; }
        public string CNS { get; set; }
        public int CodCentroCusto { get; set; }

        public static bool ExisteInternacao(Internacao internacao)
        {
            bool res;
            SqlDataAdapter da = null;
            DataTable dt = new DataTable();

            using (SqlConnection cn = new SqlConnection(Conn.StrCon))
            {
                cn.Open();
                string sqlQuery = "Select prontuario FROM MvtInternacao WHERE prontuario='" + internacao.Prontuario + "'";
                da = new SqlDataAdapter(sqlQuery, cn);
                da.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    res = true;
                }
                else
                {
                    res = false;
                }
            }

            return res;
        }

        public void SalvarInternacao(Internacao internacao)
        {
            if (ExisteInternacao(internacao))
            {
                try
                {
                    var sql = "UPDATE MvtInternacao SET dataSaida=@dataSaida, horaSaida=@horaSaida, situacao=@situacao WHERE prontuario=" + internacao.Prontuario;
                    using (SqlConnection cn = new SqlConnection(Conn.StrCon))
                    {
                        cn.Open();
                        using (var cmd = new SqlCommand(sql, cn))
                        {
                            cmd.Parameters.AddWithValue("@dataSaida", internacao.DataSaida);
                            cmd.Parameters.AddWithValue("@horaSaida", internacao.HoraSaida);
                            cmd.Parameters.AddWithValue("@situacao", internacao.Situacao);

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
            else
            {
                var sql = "INSERT INTO MvtInternacao (dataEntrada, horaEntrada, clinicaMedica, localizacao, leito, hipoteseDiagnostica," +
                    " diagnostico, situacao, medico, crm, codPaciente, dataNascimento, cns, codCentroCusto) VALUES (@dataEntrada, @horaEntrada, @clinicaMedica, @localizacao, @leito," +
                    " @hipoteseDiagnostica, @diagnostico, @situacao, @medico, @crm, @codPaciente, @dataNascimento, @cns, @codCentroCusto)";
                using (SqlConnection cn = new SqlConnection(Conn.StrCon))
                {
                    cn.Open();
                    using (var cmd = new SqlCommand(sql, cn))
                    {
                        cmd.Parameters.AddWithValue("@prontuario", internacao.Prontuario);
                        cmd.Parameters.AddWithValue("@dataEntrada", internacao.DataEntrada);
                        cmd.Parameters.AddWithValue("@horaEntrada", internacao.HoraEntrada);
                        cmd.Parameters.AddWithValue("@clinicaMedica", internacao.ClinicaMedica);
                        cmd.Parameters.AddWithValue("@localizacao", internacao.Localizacao);
                        cmd.Parameters.AddWithValue("@leito", internacao.Leito);
                        cmd.Parameters.AddWithValue("@hipoteseDiagnostica", internacao.HipoteseDiagnostico);
                        cmd.Parameters.AddWithValue("@diagnostico", internacao.Diagnostico);
                        cmd.Parameters.AddWithValue("@situacao", internacao.Situacao);
                        cmd.Parameters.AddWithValue("@medico", internacao.Medico);
                        cmd.Parameters.AddWithValue("@crm", internacao.CRM);
                        cmd.Parameters.AddWithValue("@codPaciente", internacao.CodPaciente);
                        cmd.Parameters.AddWithValue("@dataNascimento", internacao.DataNascimento);
                        cmd.Parameters.AddWithValue("@cns", internacao.CNS);
                        cmd.Parameters.AddWithValue("@codCentroCusto", internacao.CodCentroCusto);

                        cmd.ExecuteNonQuery();
                    }
                    cn.Close();
                }
            }
        }
    }
}
