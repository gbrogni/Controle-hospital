using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pacientes
{
    class Funcoes
    {
        public static DataTable ObterTodosPaciente()
        {
            SqlDataAdapter da = null;
            DataTable dt = new DataTable();
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
                    da = new SqlDataAdapter(sqlQuery, cn);
                    da.Fill(dt);
                    cn.Close();
                    return dt;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static DataTable ObterDadosPacienteForm(string id)
        {
            SqlDataAdapter da = null;
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection cn = new SqlConnection(Conn.StrCon))
                {
                    cn.Open();
                    string sqlQuery = "SELECT codPaciente, nomePaciente, dataNascimento, nomeMae, sexo, cor, cpf, rg, nacionalidade, naturalidade, grauInstrucao," +
                        " profissao, responsavel, cep, enderecoRua, enderecoBairro, enderecoCidade, enderecoUf, telefone, celular, contatoNome, contatoTelefone, email, observacao," +
                        " cns FROM MvtPaciente WHERE codPaciente =" + id;
                    da = new SqlDataAdapter(sqlQuery, cn);
                    da.Fill(dt);
                    cn.Close();
                    return dt;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static DataTable ObterTodosCentroCusto()
        {
            SqlDataAdapter da = null;
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection cn = new SqlConnection(Conn.StrCon))
                {
                    cn.Open();
                    string sqlQuery = "SELECT codCentroCusto as 'Código do centro de custo', nomeCentroCusto as 'Nome do centro de custo' FROM MvtCentroCusto";
                    da = new SqlDataAdapter(sqlQuery, cn);
                    da.Fill(dt);
                    cn.Close();
                    return dt;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static DataTable ObterDadosCentroCustoForm(string id)
        {
            SqlDataAdapter da = null;
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection cn = new SqlConnection(Conn.StrCon))
                {
                    cn.Open();
                    string sqlQuery = "SELECT codCentroCusto, nomeCentroCusto FROM MvtCentroCusto WHERE codCentroCusto =" + id;
                    da = new SqlDataAdapter(sqlQuery, cn);
                    da.Fill(dt);
                    cn.Close();
                    return dt;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static DataTable ObterTodosInternacao()
        {
            SqlDataAdapter da = null;
            DataTable dt = new DataTable();
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
                    da = new SqlDataAdapter(sqlQuery, cn);
                    da.Fill(dt);
                    cn.Close();
                    return dt;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public static DataTable ObterDadosInternacaoForm(string id)
        {
            SqlDataAdapter da = null;
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection cn = new SqlConnection(Conn.StrCon))
                {
                    cn.Open();
                    string sqlQuery = "SELECT prontuario, dataEntrada, horaEntrada, clinicaMedica, localizacao, leito, hipoteseDiagnostica, diagnostico, situacao, medico, " +
                        "crm, codPaciente, dataNascimento, cns FROM MvtInternacao WHERE prontuario =" + id;
                    da = new SqlDataAdapter(sqlQuery, cn);
                    da.Fill(dt);
                    cn.Close();
                    return dt;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        //public static DataTable ObterTodosMovimentacao()
        //{
        //    SqlDataAdapter da = null;
        //    DataTable dt = new DataTable();
        //    try
        //    {
        //        using (SqlConnection cn = new SqlConnection(Conn.StrCon))
        //        {
        //            cn.Open();
        //            string sqlQuery = "select sequencia as 'Sequência', dataMovimentacao as 'Data da movimentação', horaMovimentacao as 'Hora da movimentação', " +
        //                "prontuario as 'Prontuário', nomePaciente as 'Nome do paciente', nomeMae as 'Nome da Mãe', medico as 'Médico', " +
        //                "codCentroCusto as 'Centro de custo', motivo as 'Motivo' from MvtMovimentacao left join MvtPaciente " +
        //                "on MvtMovimentacao.codPaciente = MvtPaciente.codPaciente  ";
        //            da = new SqlDataAdapter(sqlQuery, cn);
        //            da.Fill(dt);
        //            cn.Close();
        //            return dt;
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }
        //}
    }
}
