//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Woooo.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class MasterWallet
    {
        public long Id { get; set; }
        public string Mnemonic { get; set; }
        public string PublicAddress { get; set; }
        public double Balance { get; set; }
        public Nullable<bool> Enable { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public Nullable<System.DateTime> UpdatedDate { get; set; }
        public string CreatedBy { get; set; }
        public string UpdatedBy { get; set; }
    }
}