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
    
    public partial class ORDERS_TBL
    {
        public int ORDNUM { get; set; }
        public string CUSTID { get; set; }
        public string prodid { get; set; }
        public Nullable<int> QTY { get; set; }
        public Nullable<System.DateTime> ORDDATE { get; set; }
    
        public virtual CUSTOMERS_TBL CUSTOMERS_TBL { get; set; }
        public virtual products_tbl products_tbl { get; set; }
    }
}