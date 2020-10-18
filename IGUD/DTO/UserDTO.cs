using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public enum eUserType
    {
        Coordinator, Guy, Sector, Manager
    }
    public class UserDTO
    {
        public string UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public int CommunityId { get; set; }
        public string CommunityName { get; set; }

        public eUserType UserType { get; set; }
        public bool IsDeleted { get; set; }
        public Nullable<System.DateTime> DeleletionDate { get; set; }
        public Nullable<System.DateTime> BirthDate { get; set; }
        public string Street { get; set; }
        public int HouseNumber { get; set; }
        public string Phone { get; set; }
        public string Sector { get; set; }
    }
}
