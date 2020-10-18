//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DAL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class User
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public User()
        {
            this.Winners = new HashSet<Winner>();
        }
    //[MaxLength]
        public string UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public int CommunityId { get; set; }
        public int UserType { get; set; }
        public bool IsDeleted { get; set; }
        public Nullable<System.DateTime> DeleletionDate { get; set; }
        public Nullable<System.DateTime> BirthDate { get; set; }
        public string Street { get; set; }
        public int HouseNumber { get; set; }
        public string Phone { get; set; }
        public string Sector { get; set; }
    
        public virtual Community Community { get; set; }
        public virtual Guy Guy { get; set; }
        public virtual sector sector1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Winner> Winners { get; set; }
    }
}
