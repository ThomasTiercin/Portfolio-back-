using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Models
{
    public class Education
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Date { get; set; }
        public string City { get; set; }
        public string School { get; set; }
    }
}
