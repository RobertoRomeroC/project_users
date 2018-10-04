using System.Collections.Generic;
using UserAdmin.Data.Entities;

namespace UserAdmin.Data
{
    public interface IUserAdminRepository
    {
        IEnumerable<User> GetAllUsers();
        IEnumerable<User> GetUserByStatus(bool status);

        bool SaveAll();
    }
}