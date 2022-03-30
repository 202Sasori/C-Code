using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Lab_10.Ultil
{
    public  class ultil
    {
        public static int ExcuteProcedure(string[] paras, object[] values, string strConnection, string sp_name)
        {
            int kt = -1;
            SqlConnection connection = new SqlConnection(strConnection);
            if (connection.State == ConnectionState.Closed) connection.Open();
            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandText = sp_name;
            command.CommandType = CommandType.StoredProcedure;
            for (int i = 0; i < paras.Length; i++)
            {
                command.Parameters.AddWithValue(paras[i], values[i]);
            }
            try
            {
                command.ExecuteNonQuery();
                kt = 0;
            }
            catch (Exception)
            {
            }
            command.Dispose();
            connection.Dispose();
            return kt;
        }
    }
}
