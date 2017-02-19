using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Nebuteater.Models.Enums;

namespace Nebuteater.Models.Entities
{
    public class Play : EntityBase
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Location { get; set; }
        public int Price { get; set; }
        public PaymentMethods PaymentMethod { get; set; }
        public ICollection<Performance> Performances { get; set; }
        public ICollection<Role> Roles { get; set; }
    }
}