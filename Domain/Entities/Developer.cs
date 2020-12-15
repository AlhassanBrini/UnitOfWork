using System.Collections.Generic;

namespace Domain.Entities
{
    public class Developer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Followers { get; set; }
        public ICollection<Project> Projects { get; set; }
    }
}
