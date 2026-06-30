using _09Demo_Connected_EF_WebAPI.Models;
using Microsoft.Data.SqlClient;

namespace _09Demo_Connected_EF_WebAPI.DAL
{
    // Ado.Net - COnnected Architeture Syntax
    public class EmpDbContext
    {
        private string ? _connectionString = null;
        public List<Emp> Emps { get { return GetAllEmpRecords(); } }
        public EmpDbContext(IConfiguration config)
        {
            _connectionString = config.GetConnectionString("conStr");
        }

        public List<Emp> GetAllEmpRecords()
        {
            List<Emp> EmpRecords = new List<Emp>();
            using (SqlConnection con = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.CommandText = "SELECT * FROM Emp";
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.Connection = con;

                    con.Open();

                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        EmpRecords.Add(new Emp() {
                            Id = Convert.ToInt32(reader["Id"]),
                            Name = reader["Name"].ToString(),
                            Address = reader["Address"].ToString()
                            });
                    }
                }
            }
                return EmpRecords;
        }
    }
}
