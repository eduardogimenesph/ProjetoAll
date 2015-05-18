using ProjectAll_Infrastructure_ADO.Contracts;
using System;
using System.Data.SqlClient;
using System.Web.Configuration;
using System.Collections.Generic;
namespace ProjectAll_Infrastructure_ADO
{
    public class ConnectionADO : IConnection,IDisposable
    {
        public void InsertUpdateDelete()
        {
            using (var sqlConnection = new SqlConnection("TapMenuContext"))
            {
                sqlConnection.Open();
                using (var teste = new SqlCommand("INSERT INTO TB_TESTE(teste) VALUES(@p0)",sqlConnection)) {
                    teste.Parameters.AddWithValue("@p0", 1);
                    teste.ExecuteNonQuery();
                }
               

                sqlConnection.Close();
            }
        }

        public void Select()
        {
            using (var sqlConnection = new SqlConnection("TapMenuContext")) {
                sqlConnection.Open();
                using (var teste = new SqlCommand("Select * from teste")) {
                    using (var teste2 = teste.ExecuteReader()) {
                        teste2.Read();

                        if (teste2.HasRows) {
                            string testeLocal = teste2["teste"].ToString();
                        }
                    }

                }
            }
        }
        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }


    }
}
