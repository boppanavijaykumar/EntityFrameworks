using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EntityFrameworks.Model
{
    public class EmployeeEntities
    {
        [Key]
        public int EmployeeId { get; set; }
        public int Name { get; set; }
        public int City { get; set; }
        public int Department { get; set; }
        public int Gender { get; set; }
    }
}
