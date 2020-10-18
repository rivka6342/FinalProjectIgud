using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
   public class CommunityDTO
    {
        public int CommunityId { get; set; }
        public string CommunityName { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
        public int HouseNumber { get; set; }
        public string RavName { get; set; }
        public string CoordinatorId { get; set; }
        public Nullable<bool> IsDelete { get; set; }
        public Nullable<System.DateTime> delitiondate { get; set; }
    }
}
