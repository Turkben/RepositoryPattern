using Microsoft.EntityFrameworkCore;
using RepositoryPattern.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RepositoryPattern.Data
{
    public class ApplicationContext : DbContext
    {

        public ApplicationContext()
            : base()
        {
            
        }

        public virtual DbSet<Author> Authors { get; set; }
        public virtual DbSet<Course> Courses { get; set; }


    }
}
