using System.Collections.Generic;
using System.Linq;
using UserService.Models;

namespace UserService.Repository
{
    public class UserBusinessLogic : IUserBusiness
    {
        private User _users = new User { FirstName = "Nishu", LastName = "Goel", Age = "25", EmailId = "nishu.goel@nagarro.com" };
            //new User {FirstName = "Ritu", LastName = "Goel", Username = "user", Password = "user", Role = Role.User }
        
    
        public User GetAll()
        {
            return _users;
        }

        public User GetById(int id)
        {
            return _users;
        }
    }
}
