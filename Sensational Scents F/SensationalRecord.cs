//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sensational_Scents_F
{
    using System;
    using System.Collections.Generic;
    
    public partial class SensationalRecord
    {
        public int id { get; set; }
        public string CustomerName { get; set; }
        public string DateOrdered { get; set; }
        public Nullable<decimal> Cost { get; set; }
        public string CustomerAddress { get; set; }
        public Nullable<decimal> CustomerNumner { get; set; }
        public int TypeofProductID { get; set; }
    
        public virtual TypesofProductsUpdated TypesofProductsUpdated { get; set; }
    }
}