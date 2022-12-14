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
    class CentroCusto
    {
        public int Codigo { get; set; }
        public string Nome { get; set; }

        public static bool ExisteCentroCusto(CentroCusto centroCusto)
        {
            bool res;
            SqlDataAdapter da = null;
            DataTable dt = new DataTable();

            using (SqlConnection cn = new SqlConnection(Conn.StrCon))
            {
                cn.Open();
                string sqlQuery = "Select codCentroCusto FROM MvtCentroCusto WHERE codCentroCusto='" + centroCusto.Codigo + "'";
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

        public void SalvarCentroCusto(CentroCusto centroCusto)
        {

            if (ExisteCentroCusto(centroCusto))
            {
                try
                {
                    var sql = "UPDATE MvtCentroCusto SET nomeCentroCusto=@nomeCentroCusto WHERE codCentroCusto=" + centroCusto.Codigo;
                    using (SqlConnection cn = new SqlConnection(Conn.StrCon))
                    {
                        cn.Open();
                        using (var cmd = new SqlCommand(sql, cn))
                        {
                            cmd.Parameters.AddWithValue("@codCentroCusto", centroCusto.Codigo);
                            cmd.Parameters.AddWithValue("@nomeCentroCusto", centroCusto.Nome);


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
                var sql = "INSERT INTO MvtCentroCusto (nomeCentroCusto) VALUES (@nomeCentroCusto)";
                using (SqlConnection cn = new SqlConnection(Conn.StrCon))
                {
                    cn.Open();
                    using (var cmd = new SqlCommand(sql, cn))
                    {
                        cmd.Parameters.AddWithValue("@codCentroCusto", centroCusto.Codigo);
                        cmd.Parameters.AddWithValue("@nomeCentroCusto", centroCusto.Nome);

                        cmd.ExecuteNonQuery();
                    }
                    cn.Close();
                }
            }
        }
    }
}
