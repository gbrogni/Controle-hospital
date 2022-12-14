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
    class Pacientes
    {
        public int CodPaciente { get; set; }
        public string NomePaciente { get; set; }
        public DateTime DataNascimento { get; set; }
        public string NomeMae { get; set; }
        public string Sexo { get; set; }
        public string Cor { get; set; }
        public string CPF { get; set; }
        public string RG { get; set; }
        public string Nacionalidade { get; set; }
        public string Naturalidade { get; set; }
        public string GrauInstrucao { get; set; }
        public string Profissao { get; set; }
        public string Responsavel { get; set; }
        public string CEP { get; set; }
        public string Rua { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string UF { get; set; }
        public string Telefone { get; set; }
        public string Celular { get; set; }
        public string ContatoNome { get; set; }
        public string ContatoTelefone { get; set; }
        public string Email { get; set; }
        public string Observacao { get; set; }
        public string CNS { get; set; }

        public static bool ExistePaciente(Pacientes pacientes)
        {
            bool res;
            SqlDataAdapter da = null;
            DataTable dt = new DataTable();

            using (SqlConnection cn = new SqlConnection(Conn.StrCon))
            {
                cn.Open();
                string sqlQuery = "Select codPaciente FROM MvtPaciente WHERE codPaciente='" + pacientes.CodPaciente + "'";
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

        public void SalvarPaciente(Pacientes pacientes)
        {

            if (ExistePaciente(pacientes))
            {
                try
                {
                    var sql = "UPDATE MvtPaciente SET nomePaciente=@nomePaciente, dataNascimento=@dataNascimento, nomeMae=@nomeMae, sexo=@sexo, cor=@cor, cpf=@cpf, " +
                        "rg=@rg, nacionalidade=@nacionalidade, naturalidade=@naturalidade, grauInstrucao=@grauInstrucao, profissao=@profissao, responsavel=@responsavel, " +
                        "cep=@cep, enderecoRua=@enderecoRua, enderecoBairro=@enderecoBairro, enderecoCidade=@enderecoCidade, enderecoUf=@enderecoUf, telefone=@telefone, celular=@celular," +
                        " contatoNome=@contatoNome, contatoTelefone=@contatoTelefone, email=@email, observacao=@observacao, " +
                        "cns=@cns WHERE codPaciente=" + pacientes.CodPaciente;
                    using (SqlConnection cn = new SqlConnection(Conn.StrCon))
                    {
                        cn.Open();
                        using (var cmd = new SqlCommand(sql, cn))
                        {
                            cmd.Parameters.AddWithValue("@codPaciente", pacientes.CodPaciente);
                            cmd.Parameters.AddWithValue("@nomePaciente", pacientes.NomePaciente);
                            cmd.Parameters.AddWithValue("@dataNascimento", pacientes.DataNascimento);
                            cmd.Parameters.AddWithValue("@nomeMae", pacientes.NomeMae);
                            cmd.Parameters.AddWithValue("@sexo", pacientes.Sexo);
                            cmd.Parameters.AddWithValue("@cor", pacientes.Cor);
                            cmd.Parameters.AddWithValue("@cpf", pacientes.CPF);
                            cmd.Parameters.AddWithValue("@rg", pacientes.RG);
                            cmd.Parameters.AddWithValue("@nacionalidade", pacientes.Nacionalidade);
                            cmd.Parameters.AddWithValue("@naturalidade", pacientes.Naturalidade);
                            cmd.Parameters.AddWithValue("@grauInstrucao", pacientes.GrauInstrucao);
                            cmd.Parameters.AddWithValue("@profissao", pacientes.Profissao);
                            cmd.Parameters.AddWithValue("@responsavel", pacientes.Responsavel);
                            cmd.Parameters.AddWithValue("@cep", pacientes.CEP);
                            cmd.Parameters.AddWithValue("@enderecoRua", pacientes.Rua);
                            cmd.Parameters.AddWithValue("@enderecoBairro", pacientes.Bairro);
                            cmd.Parameters.AddWithValue("@enderecoCidade", pacientes.Cidade);
                            cmd.Parameters.AddWithValue("@enderecoUf", pacientes.UF);
                            cmd.Parameters.AddWithValue("@telefone", pacientes.Telefone);
                            cmd.Parameters.AddWithValue("@celular", pacientes.Celular);
                            cmd.Parameters.AddWithValue("@contatoNome", pacientes.ContatoNome);
                            cmd.Parameters.AddWithValue("@contatoTelefone", pacientes.ContatoTelefone);
                            cmd.Parameters.AddWithValue("@email", pacientes.Email);
                            cmd.Parameters.AddWithValue("@observacao", pacientes.Observacao);
                            cmd.Parameters.AddWithValue("@cns", pacientes.CNS);


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
                var sql = "INSERT INTO MvtPaciente (nomePaciente, dataNascimento, nomeMae, sexo, cor, cpf, rg, nacionalidade, naturalidade, grauInstrucao, " +
                    "profissao, responsavel, cep, enderecoRua, enderecoBairro, enderecoCidade, enderecoUf, telefone, celular, contatoNome, contatoTelefone, email, observacao, cns) " +
                    "VALUES (@nomePaciente, @dataNascimento, @nomeMae, @sexo, @cor, @cpf, @rg, @nacionalidade, @naturalidade, @grauInstrucao,@profissao, " +
                    "@responsavel, @cep, @enderecoRua, @enderecoBairro, @enderecoCidade, @enderecoUf, @telefone, @celular, @contatoNome, @contatoTelefone, @email, @observacao, @cns)";
                using (SqlConnection cn = new SqlConnection(Conn.StrCon))
                {
                    cn.Open();
                    using (var cmd = new SqlCommand(sql, cn))
                    {
                        cmd.Parameters.AddWithValue("@codPaciente", pacientes.CodPaciente);
                        cmd.Parameters.AddWithValue("@nomePaciente", pacientes.NomePaciente);
                        cmd.Parameters.AddWithValue("@dataNascimento", pacientes.DataNascimento);
                        cmd.Parameters.AddWithValue("@nomeMae", pacientes.NomeMae);
                        cmd.Parameters.AddWithValue("@sexo", pacientes.Sexo);
                        cmd.Parameters.AddWithValue("@cor", pacientes.Cor);
                        cmd.Parameters.AddWithValue("@cpf", pacientes.CPF);
                        cmd.Parameters.AddWithValue("@rg", pacientes.RG);
                        cmd.Parameters.AddWithValue("@nacionalidade", pacientes.Nacionalidade);
                        cmd.Parameters.AddWithValue("@naturalidade", pacientes.Naturalidade);
                        cmd.Parameters.AddWithValue("@grauInstrucao", pacientes.GrauInstrucao);
                        cmd.Parameters.AddWithValue("@profissao", pacientes.Profissao);
                        cmd.Parameters.AddWithValue("@responsavel", pacientes.Responsavel);
                        cmd.Parameters.AddWithValue("@cep", pacientes.CEP);
                        cmd.Parameters.AddWithValue("@enderecoRua", pacientes.Rua);
                        cmd.Parameters.AddWithValue("@enderecoBairro", pacientes.Bairro);
                        cmd.Parameters.AddWithValue("@enderecoCidade", pacientes.Cidade);
                        cmd.Parameters.AddWithValue("@enderecoUf", pacientes.UF);
                        cmd.Parameters.AddWithValue("@telefone", pacientes.Telefone);
                        cmd.Parameters.AddWithValue("@celular", pacientes.Celular);
                        cmd.Parameters.AddWithValue("@contatoNome", pacientes.ContatoNome);
                        cmd.Parameters.AddWithValue("@contatoTelefone", pacientes.ContatoTelefone);
                        cmd.Parameters.AddWithValue("@email", pacientes.Email);
                        cmd.Parameters.AddWithValue("@observacao", pacientes.Observacao);
                        cmd.Parameters.AddWithValue("@cns", pacientes.CNS);

                        cmd.ExecuteNonQuery();
                    }
                    cn.Close();
                }
            }
        }
    }
}
