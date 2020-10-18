using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
 public  class ActiveDTO
    {
        public int ActiveId { get; set; }
        public System.DateTime Date { get; set; }
        public string Describe { get; set; }
        public Nullable<int> NumSubscibers { get; set; }
        public Nullable<int> ArtistId { get; set; }
        public bool Prepay { get; set; }
        public string tittle { get; set; }
    }
}
