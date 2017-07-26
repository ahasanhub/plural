using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Globalmantics.DAL;
using Globalmantics.DAL.Entities;

namespace Globalmantics.Logic
{
    public class UserService
    {
        private GlobalmanticsContext _context;

        public UserService(GlobalmanticsContext context)
        {
            _context = context;
        }

        public User GetUserByEmail(string email)
        {
            var user=_context.Users.Add(new User {Email = email});
            return user;
        }
    }
}
