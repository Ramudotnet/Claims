//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ClaimSolution.DBContext
{
    using System;
    using System.Collections.Generic;
    
    public partial class LegacyActivity
    {
        public string ClaimReference { get; set; }
        public int Id { get; set; }
        public System.DateTime ActivityDate { get; set; }
        public string CategoryInd { get; set; }
        public int CompletedBy { get; set; }
        public string AdhocOrPartyInd { get; set; }
        public Nullable<int> PartyId { get; set; }
        public Nullable<int> AdhocPartyId { get; set; }
        public string TypeCode { get; set; }
        public string Detail { get; set; }
        public System.DateTime LastUpdatedDate { get; set; }
        public int LastUpdatedId { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public int CreatedId { get; set; }
        public Nullable<System.DateTime> DeletedDate { get; set; }
        public Nullable<int> DeletedId { get; set; }
    }
}
