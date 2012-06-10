using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.SqlClient;
using GestiuneBusiness.Poco.Kernel;

namespace GestiuneBusiness.DataHelper.Kernel
{
    internal abstract class GestiuneDataHelper
    {
        protected string readStoredProcedureName = "";

        protected string insertStoredProcedureName = "";

        protected string updateStoredProcedureName = "";

        private const string StringProcedureFail = "Stored procedure failed: ";

        private const string StringDatabaseFail = "Connection to database failed.";

        public List<GestiuneObject> GetAll()
        {
            List<GestiuneObject> result = new List<GestiuneObject>();
            try
            {
                using (SqlConnection con = ConnectionHelper.Connection)
                {
                    try
                    {
                        using (SqlCommand cmd = new SqlCommand(readStoredProcedureName, con))
                        {
                            con.Open();
                            cmd.CommandType = System.Data.CommandType.StoredProcedure;
                            SqlDataReader reader = cmd.ExecuteReader();
                            while (reader.Read())
                            {
                                result.Add(ToPocoObject(reader));
                            }
                            reader.Close();
                            con.Close();
                        }
                    }
                    catch (Exception ex)
                    {
                        throw new Exception(StringProcedureFail + readStoredProcedureName, ex);
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(StringDatabaseFail, ex);
            }
            return result;
        }

        public int Create(List<DbObject> dbObjects)
        {
            // saves a new GestiuneObject (actually it's properties == dbObjects)
            // returns the id
            try
            {
                using (SqlConnection con = ConnectionHelper.Connection)
                {
                    try
                    {
                        using (SqlCommand cmd = new SqlCommand(insertStoredProcedureName, con))
                        {
                            con.Open();
                            cmd.CommandType = System.Data.CommandType.StoredProcedure;

                            SqlParameter idSqlParameter = new SqlParameter("@Id", System.Data.SqlDbType.Int);
                            idSqlParameter.Direction = System.Data.ParameterDirection.Output;
                            cmd.Parameters.Add(idSqlParameter);

                            foreach (var dboObject in dbObjects)
                            {
                                cmd.Parameters.AddWithValue(dboObject.Name, dboObject.Value);
                            }

                            cmd.ExecuteNonQuery();
                            con.Close();
                            return (int)idSqlParameter.Value;
                        }
                    }
                    catch (Exception ex)
                    {
                        throw new Exception(StringProcedureFail + insertStoredProcedureName, ex);
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(StringDatabaseFail, ex);
            }
        }

        public void Update(List<DbObject> dbObjects, int id)
        {
            try
            {
                using (SqlConnection con = ConnectionHelper.Connection)
                {
                    try
                    {
                        using (SqlCommand cmd = new SqlCommand(updateStoredProcedureName, con))
                        {
                            con.Open();
                            cmd.CommandType = System.Data.CommandType.StoredProcedure;
                            cmd.Parameters.AddWithValue("@Id", id);
                            foreach (var dboObject in dbObjects)
                            {
                                cmd.Parameters.AddWithValue(dboObject.Name, dboObject.Value);
                            }
                            cmd.ExecuteNonQuery();
                            con.Close();
                        }
                    }
                    catch (Exception ex)
                    {
                        throw new Exception(StringProcedureFail + updateStoredProcedureName, ex);
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(StringDatabaseFail, ex);
            }
        }

        protected abstract GestiuneObject ToPocoObject(SqlDataReader reader);
    }
}
