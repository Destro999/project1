using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace project1.Models
{
    public class EFSignUpRepository : ISignUpRepository
    {
        private SignUpDbContext _context;
        public EFSignUpRepository(SignUpDbContext context)
        {
            _context = context;
        }
        public IQueryable<Project> Projects => _context.Projects;
    }
}
