using System.Collections.Generic;
using System.Linq;
using UserAdmin.Data.Entities;

namespace UserAdmin.Data
{
    public class UserAdminRepository : IUserAdminRepository
    {
        private readonly UserAdminContext _ctx;

        public UserAdminRepository(UserAdminContext ctx)
        {
            _ctx = ctx;
        }

        public IEnumerable<User> GetAllUsers()
        {
            return _ctx.Users
                .OrderBy(u => u.Users)
                .ToList();
        }

        public IEnumerable<User> GetUserByStatus(bool status)
        {
            return _ctx.Users
                    .Where(u => u.Status == status)
                    .ToList();
        }

        public bool SaveAll()
        {
            return _ctx.SaveChanges() > 0;
        }

    }
}
