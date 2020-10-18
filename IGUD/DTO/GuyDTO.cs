using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class GuyDTO:UserDTO
    {
        public int YeshivaId { get; set; }
        public string YeshivaName { get; set; }
        public bool IsBig { get; set; }
        public string Lesson { get; set; }
    }
}
