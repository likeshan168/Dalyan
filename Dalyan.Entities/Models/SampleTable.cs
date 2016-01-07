//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated from the Dalyan T4 template.
// Do not change
//
// </auto-generated>
//------------------------------------------------------------------------------

namespace Dalyan.Entities.Models
{
    
    using System;
    using System.Collections.Generic;
    
    public partial class SampleTable
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Nullable<int> CompanyId { get; set; }
        public Nullable<int> Gender { get; set; }
        public Nullable<bool> Active { get; set; }
        public string Movies { get; set; }
        public string Series { get; set; }
        public byte[] ProfilePicture { get; set; }
        public Nullable<System.DateTime> LoginDate { get; set; }
        public Nullable<System.DateTime> LongLoginDate { get; set; }
        public string LongText { get; set; }
        public double Price { get; set; }
        public Nullable<decimal> Price2 { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public string CreatedIpAddress { get; set; }
        public Nullable<int> CreatedUserId { get; set; }
        public Nullable<System.DateTime> UpdatedDate { get; set; }
        public string UpdatedIpAddress { get; set; }
        public Nullable<int> UpdatedUserId { get; set; }
        public Nullable<bool> IsDeleted { get; set; }
    
        public virtual Company Company { get; set; }
    }
}