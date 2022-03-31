using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Lab_11.Ultil
{
    internal class ultil
    {
        public static int ExcuteProcedure(string[] paras, object[] values, string strConnection, string sp_name)
        {
            int kt = -1;
            SqlConnection connection = new SqlConnection(strConnection);
            if (connection.State == ConnectionState.Closed) connection.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = connection;
            cmd.CommandText = sp_name;
            cmd.CommandType = CommandType.StoredProcedure;
            for(int i = 0; i < paras.Length; i++)
            {
                cmd.Parameters.AddWithValue(paras[i], values[i]);
            }
            try
            {
                cmd.ExecuteNonQuery();
                kt = 0;
            }catch(Exception ex)
            {
            }
            cmd.Dispose();
            connection.Dispose();
            return kt;
        }
    }
}
