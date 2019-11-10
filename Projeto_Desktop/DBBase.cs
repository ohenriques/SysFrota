using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Desktop
{
    public class DBBase
    {
        public void ExecutaInstrucaoNaBase(string QuerySQL)
        {
            string strConxao = "Data Source=DESKTOP-P8BLD71\\SQLEXPRESS;Initial Catalog=SysCar;Integrated Security=True";
            string Query = QuerySQL;
            SqlConnection con = new SqlConnection(strConxao);
            SqlCommand sqlCommand = new SqlCommand(Query, con);

            try
            {
                con.Open();
                sqlCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                string erro = ex.Message;
                erro += "   !!!";
            }
            finally
            {
                con.Close();
            }

        }
    }


}
