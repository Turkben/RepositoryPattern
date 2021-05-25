using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RepositoryPattern.Core.Models
{
    public class Course
    {

        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public int Level { get; set; }

        public float FullPrice { get; set; }

        public virtual Author Author { get; set; }

        public int AuthorId { get; set; }

        public bool IsBeginnerCourse
        {
            get { return Level == 1; }
        }
    }
}
