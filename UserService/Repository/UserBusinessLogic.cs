using Microsoft.AspNetCore.Http;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System.Linq;
using UserService.Models;

namespace UserService.Repository
{
    public class UserBusinessLogic : IUserBusiness
    {
        public NagpContext DbContext { get; }
        public UserBusinessLogic(NagpContext nagpContext)
        {
            DbContext = nagpContext;
        }
       
        public User GetUser()
        {
            User user = new User();
            using (MySqlConnection conn = DbContext.Connection)
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("select * from user where id = 1", conn);

                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        user.FirstName = reader["firstname"].ToString();
                        user.LastName = reader["lastname"].ToString();
                        user.Age = reader["age"].ToString();
                        user.EmailId = reader["emailid"].ToString();
                    }
                }
            }
            return user;
        }
    }
}
