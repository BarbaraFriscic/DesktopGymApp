using GymApp.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymApp.Repository
{
    public class LoginRepository :BaseRepository, ILoginRepository
    {
        //Fields    

        public LoginRepository(string connectionString)
        {
            this.connectionString = connectionString;
        }

        //Properties

        //Methodes
        public void Login(Login login)
        {
            string loginUsername = login.Username;
            string loginPassword = login.Password;
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "select l.\"Id\", l.\"Username\", l.\"Password\", e.\"Position\" from LoginData l inner join Employee e on l.\"Id\"=e.\"Id\"; ";
                command.Parameters.Add("@username", SqlDbType.NVarChar).Value = loginUsername;
                command.Parameters.Add("@password", SqlDbType.NVarChar).Value = loginPassword;

                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        if (reader.HasRows)
                        {
                            login.IsSuccessful = true;
                            if (reader[2].ToString() == "admin")
                                login.IsAdmin = true;
                            else
                                login.IsAdmin = false;
                        }
                        else
                        {
                            login.IsSuccessful = false;
                            if (reader.GetString(1) == loginUsername && reader.GetString(2) != loginPassword)
                                login.Message = "Invalid password";
                            else if (reader.GetString(1) != loginUsername && reader.GetString(2) == loginPassword)
                                login.Message = "Invalid username";
                            else
                                login.Message = "Invalid username and password";
                        }
                    }
                }
            }
        }
    }
}
