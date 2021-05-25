using Microsoft.EntityFrameworkCore;
using RepositoryPattern.Core.Interfaces;
using RepositoryPattern.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RepositoryPattern.Data.Repositories
{
    public class AuthorRepository : GenericRepository<Author>, IAuthorRepository
    {

        public AuthorRepository(ApplicationContext context) : base(context)
        {
        }

        public ApplicationContext AppContext
        {
            get { return _context as ApplicationContext; }
        }

        public Author GetAuthorWithCourses(int id)
        {
            return AppContext.Authors.Include(a => a.Courses).SingleOrDefault(a => a.Id == id);
        }
    }
}
