using System.Collections.Generic;

namespace School.DAL.Entities
{
    public class Teacher
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<SchoolClass> SchoolClasses { get; set; }
        public Teacher()
        {
            SchoolClasses = new List<SchoolClass>();
        }
    }
}
