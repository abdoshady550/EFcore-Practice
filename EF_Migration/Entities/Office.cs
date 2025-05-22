using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Migration.Entities
{
    public class Office
    {
        public int Id { get; set; }
        public string? officeName { get; set; }
        public string? officeLocation { get; set; }
        public Instractor? instractor { get; set; }

    }
}
