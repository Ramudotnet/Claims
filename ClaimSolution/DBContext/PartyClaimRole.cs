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
    
    public partial class PartyClaimRole
    {
        public int Id { get; set; }
        public string PartyTypeCode { get; set; }
        public string ClaimReference { get; set; }
        public string AdhocOrPartyInd { get; set; }
        public Nullable<int> PartyId { get; set; }
        public Nullable<int> AdhocPartyId { get; set; }
        public string PartyReference { get; set; }
        public string ContactName { get; set; }
        public string Telephone { get; set; }
        public string EmailAddress { get; set; }
        public System.DateTime LastUpdatedDate { get; set; }
        public int LastUpdatedId { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public int CreatedId { get; set; }
    }
}
