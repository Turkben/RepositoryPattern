using RepositoryPattern.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RepositoryPattern.Core
{
    public interface IUnitOfWork : IDisposable
    {
        ICourseRepository Courses { get; }
        IAuthorRepository Authors { get; }
        int Complete();
    }
}
