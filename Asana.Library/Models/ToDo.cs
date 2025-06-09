using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asana.Library.Models
{
    public class ToDo
    {
        public int? Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public int? Priority { get; set; }
        public bool? IsCompleted { get; set; }

        public override string ToString()
        {
            return $"{Id} {Name} - {Description}";
        }
    }
    public class Project
    {
        public int? Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public int? CompletePercent { get; set; }
        public List<ToDo>? ProjectToDos { get; set; } = new List<ToDo>();

        public override string ToString()
        {
            return $"{Id} {Name} - {Description}";
        }

    }
    
}
