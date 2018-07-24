using System.Collections.Generic;

namespace School.DAL.Entities
{
    public class SchoolClass
    {
        public int Id { get; set; }
        public string Name { get; set; }
        
        public ICollection<Pupil> Pupils { get; set; }

        public ICollection<Teacher> Teachers { get; set; }

        public SchoolClass()
        {
            Teachers = new List<Teacher>();
        }
    } 
}
