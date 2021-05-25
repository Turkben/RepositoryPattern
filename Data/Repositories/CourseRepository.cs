using Microsoft.EntityFrameworkCore;
using RepositoryPattern.Core.Interfaces;
using RepositoryPattern.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RepositoryPattern.Data.Repositories
{
    public class CourseRepository : GenericRepository<Course>, ICourseRepository
    {

        //ICourseRepository provides all methods for course
        //and GenericRepository satisfy implemantation of ICourseRepository

        public CourseRepository(ApplicationContext context)
    : base(context)
        {
        }

        public ApplicationContext AppContext
        {
            get { return _context as ApplicationContext; }
        }

        public IEnumerable<Course> GetTopSellingCourses(int count)
        {
            return AppContext.Courses.OrderByDescending(c => c.FullPrice).Take(count).ToList();
        }

        public IEnumerable<Course> GetCoursesWithAuthors(int pageIndex, int pageSize = 10)
        {
            return AppContext.Courses
                .Include(c => c.Author)
                .OrderBy(c => c.Name)
                .Skip((pageIndex - 1) * pageSize)
                .Take(pageSize)
                .ToList();
        }



    }
}
