using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.SqlClient;
using GestiuneBusiness.Poco.Kernel;

namespace GestiuneBusiness.DataHelper.Kernel
{
    internal abstract class GestiuneDataHelper
    {
        protected string selectAllStoredProcedureName = "";

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
                        using (SqlCommand cmd = new SqlCommand(selectAllStoredProcedureName, con))
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
                        throw new Exception(StringProcedureFail + selectAllStoredProcedureName, ex);
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
            try
            {
                using (SqlConnection con = ConnectionHelper.Connection)
                {
                    try
                    {
                        using (SqlCommand cmd = new SqlCommand(insertStoredProcedureName, con))
                        {
                            const string ReferenceId = "@ReferenceID";
                            con.Open();
                            cmd.CommandType = System.Data.CommandType.StoredProcedure;
                            cmd.Parameters.Add(ReferenceId, System.Data.SqlDbType.Int).Direction = System.Data.ParameterDirection.ReturnValue;

                            foreach (var dboObject in dbObjects)
                            {
                                cmd.Parameters.AddWithValue(dboObject.Name, dboObject.Value);
                            }

                            cmd.ExecuteReader();

                            var id = cmd.Parameters["@ReferenceID"].Value;
                            return (int)id;
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
                            if (id != 0) cmd.Parameters.AddWithValue("@Id", id);
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

        public static bool TestConnection()
        {
            try
            {
                using (SqlConnection con = ConnectionHelper.Connection)
                {
                    con.Open();
                }
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        protected abstract GestiuneObject ToPocoObject(SqlDataReader reader);
    }
}
