using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nebuteater.Models.Entities
{
    public class Role : EntityBase
    {
        public int PlayId { get; set; }
        public string Name { get; set; }
        public string GroupAName { get; set; }
        public string GroupBName { get; set; }
    }
}
