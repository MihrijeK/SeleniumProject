using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

using MySql.Data.MySqlClient;
using System.Data.SqlClient;

namespace ProjektiIS
{
    class connection
    {
        public static MySqlDataReader databaza(string sql)
        {
            try
            {
                MySqlConnection conn = new MySqlConnection("server=localhost;database=bks;userid=root;password= Your password here ");
                conn.Open();

                MySqlCommand cmd = new MySqlCommand(sql, conn);
                MySqlDataReader reader;
                reader = cmd.ExecuteReader();
                return reader;

            }


            catch (Exception exeption)
            {
                throw new Exception(exeption.Message);
            }
        }
        public static DataSet DataSet(string sql)
        {
            MySqlConnection conn = new MySqlConnection("server=localhost;database=bks;userid=root;password = Your password here ");
            DataSet DS = new DataSet();
            var SqlCommnad = new MySqlCommand(sql, conn);
            var DA = new MySqlDataAdapter(SqlCommnad);
            try
            {
                DA.Fill(DS);
                return DS;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        
        }
    }
}


