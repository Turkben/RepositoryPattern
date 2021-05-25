using RepositoryPattern.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RepositoryPattern.Core.Interfaces
{
    public interface ICourseRepository : IGenericRepository<Course>
    {
        //addition methods for course repository
        IEnumerable<Course> GetTopSellingCourses(int count);
        IEnumerable<Course> GetCoursesWithAuthors(int pageIndex, int pageSize);
    }
}
