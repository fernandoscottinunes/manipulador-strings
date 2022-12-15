using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StringHandler.Entity;

namespace StringHandler.DAO
{
    public class StringHandlerDAO
    {
        public int insertHistory(EntityStringHandler objStringHandler)
        {
            using (SqlConnection con = new SqlConnection())
            {
                con.ConnectionString = StringHandler.DAO.Properties.Settings.Default.dbConnectionString;
                con.Open();

                SqlCommand cn = new SqlCommand();
                cn.CommandType = CommandType.Text;
                cn.CommandText = "INSERT INTO dbo.history ([inputText], [functionUsed], [outputText], [dateAndTime]) " +
                    "VALUES (@inputText, @functionUsed, @outputText, @dateAndTime)";
                cn.Parameters.Add("inputText", SqlDbType.VarChar).Value = objStringHandler.InputText;
                cn.Parameters.Add("functionUsed", SqlDbType.VarChar).Value = objStringHandler.FunctionUsed;
                cn.Parameters.Add("outputText", SqlDbType.VarChar).Value = objStringHandler.OutputText;
                cn.Parameters.Add("dateAndTime", SqlDbType.VarChar).Value = objStringHandler.DateAndTime;

                cn.Connection = con;

                int queryResult = cn.ExecuteNonQuery();

                con.Close();

                return queryResult;
            }

        }

        public List<EntityStringHandler> listHistory()
        {
            using (SqlConnection con = new SqlConnection())
            {
                con.ConnectionString = StringHandler.DAO.Properties.Settings.Default.dbConnectionString;
                con.Open();

                SqlCommand cn = new SqlCommand();
                cn.CommandType = CommandType.Text;
                cn.CommandText = "SELECT id, inputText, functionUsed, outputText, dateAndTime FROM dbo.history ORDER BY id DESC";

                cn.Connection = con;

                SqlDataReader dr;
                List<EntityStringHandler> history = new List<EntityStringHandler>();

                dr = cn.ExecuteReader();

                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        EntityStringHandler historyData = new EntityStringHandler();
                        historyData.Id = Convert.ToInt32(dr["id"]);
                        historyData.InputText = Convert.ToString(dr["inputText"]);
                        historyData.FunctionUsed = Convert.ToString(dr["functionUsed"]);
                        historyData.OutputText = Convert.ToString(dr["outputText"]);
                        historyData.DateAndTime = Convert.ToString(dr["dateAndTime"]);

                        history.Add(historyData);
                    }
                }

                return history;

            }
        }
    }
}
