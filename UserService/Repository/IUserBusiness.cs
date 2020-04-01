using System.Collections.Generic;

using UserService.Models;

namespace UserService.Repository
{
    public interface IUserBusiness
    {
        User GetAll();
        User GetById(int id);
    }
    
}
