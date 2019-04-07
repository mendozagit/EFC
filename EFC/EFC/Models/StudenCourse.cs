using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFC.Models
{
    public class StudenCourse
    {
        public int CourseId { get; set; }
        public virtual Course Course { get; set; }


        public int StudentId { get; set; }
        public virtual Student Student { get; set; }

        public float Calif { get; set; }

    }
}
