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
    
    public partial class SignActivity
    {
        public string GuyId { get; set; }
        public int ActivyId { get; set; }
        public int SignActivityID { get; set; }
    
        public virtual Activity Activity { get; set; }
        public virtual Guy Guy { get; set; }
    }
}