//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace GUI
{
    using System;
    using System.Collections.Generic;
    
    public partial class EMPLOYEE_TBL
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public EMPLOYEE_TBL()
        {
            this.CUSTOMERS_TBL = new HashSet<CUSTOMERS_TBL>();
            this.EMPLOYEE_PAY_TBL = new HashSet<EMPLOYEE_PAY_TBL>();
        }
    
        public string EMPID { get; set; }
        public string lastNAME { get; set; }
        public string firstname { get; set; }
        public string ADDRess { get; set; }
        public string CITY { get; set; }
        public string STate { get; set; }
        public string PHONE { get; set; }
        public Nullable<System.DateTime> datehire { get; set; }
        public string managerid { get; set; }
        public Nullable<int> position { get; set; }
        public Nullable<System.DateTime> birthdate { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CUSTOMERS_TBL> CUSTOMERS_TBL { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EMPLOYEE_PAY_TBL> EMPLOYEE_PAY_TBL { get; set; }
    }
}