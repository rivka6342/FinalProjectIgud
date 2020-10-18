using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
  public class SchoolDTO
    {
        public int YeshivaId { get; set; }
        public string Name { get; set; }
        public bool IsBig { get; set; }
        public Nullable<bool> IsDelete { get; set; }
        public Nullable<System.DateTime> DeletionDate { get; set; }
    }
}
