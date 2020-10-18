using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
   public class WinnerDTO
    {
        public int IdWin { get; set; }
        public string WinnerId { get; set; }
        public System.DateTime DateWin { get; set; }
        public int ActivityId { get; set; }
        public string describe { get; set; }

    }
}
