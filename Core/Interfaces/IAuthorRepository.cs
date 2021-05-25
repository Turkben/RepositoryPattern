using RepositoryPattern.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RepositoryPattern.Core.Interfaces
{
    public interface IAuthorRepository : IGenericRepository<Author>
    {
        Author GetAuthorWithCourses(int id);
    }
}
