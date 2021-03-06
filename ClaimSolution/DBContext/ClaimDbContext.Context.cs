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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class InterviewEntities : DbContext
    {
        public InterviewEntities()
            : base("name=InterviewEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<LossType> LossTypes { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Activity> Activities { get; set; }
        public virtual DbSet<Claim> Claims { get; set; }
        public virtual DbSet<Email> Emails { get; set; }
        public virtual DbSet<FileActivityLink> FileActivityLinks { get; set; }
        public virtual DbSet<File> Files { get; set; }
        public virtual DbSet<LegacyActivity> LegacyActivities { get; set; }
        public virtual DbSet<LegacyActivityCategory> LegacyActivityCategories { get; set; }
        public virtual DbSet<LegacyActivityType> LegacyActivityTypes { get; set; }
        public virtual DbSet<PartyClaimRole> PartyClaimRoles { get; set; }
        public virtual DbSet<PartyType> PartyTypes { get; set; }
        public virtual DbSet<database_firewall_rules> database_firewall_rules { get; set; }
    
        public virtual int sp_alterdiagram(string diagramname, Nullable<int> owner_id, Nullable<int> version, byte[] definition)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            var versionParameter = version.HasValue ?
                new ObjectParameter("version", version) :
                new ObjectParameter("version", typeof(int));
    
            var definitionParameter = definition != null ?
                new ObjectParameter("definition", definition) :
                new ObjectParameter("definition", typeof(byte[]));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_alterdiagram", diagramnameParameter, owner_idParameter, versionParameter, definitionParameter);
        }
    
        public virtual int sp_creatediagram(string diagramname, Nullable<int> owner_id, Nullable<int> version, byte[] definition)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            var versionParameter = version.HasValue ?
                new ObjectParameter("version", version) :
                new ObjectParameter("version", typeof(int));
    
            var definitionParameter = definition != null ?
                new ObjectParameter("definition", definition) :
                new ObjectParameter("definition", typeof(byte[]));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_creatediagram", diagramnameParameter, owner_idParameter, versionParameter, definitionParameter);
        }
    
        public virtual int sp_dropdiagram(string diagramname, Nullable<int> owner_id)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_dropdiagram", diagramnameParameter, owner_idParameter);
        }
    
        public virtual ObjectResult<sp_helpdiagramdefinition_Result> sp_helpdiagramdefinition(string diagramname, Nullable<int> owner_id)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_helpdiagramdefinition_Result>("sp_helpdiagramdefinition", diagramnameParameter, owner_idParameter);
        }
    
        public virtual ObjectResult<sp_helpdiagrams_Result> sp_helpdiagrams(string diagramname, Nullable<int> owner_id)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_helpdiagrams_Result>("sp_helpdiagrams", diagramnameParameter, owner_idParameter);
        }
    
        public virtual int sp_renamediagram(string diagramname, Nullable<int> owner_id, string new_diagramname)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            var new_diagramnameParameter = new_diagramname != null ?
                new ObjectParameter("new_diagramname", new_diagramname) :
                new ObjectParameter("new_diagramname", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_renamediagram", diagramnameParameter, owner_idParameter, new_diagramnameParameter);
        }
    
        public virtual int sp_upgraddiagrams()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_upgraddiagrams");
        }
    
        public virtual int usp_GetActivityEnrichments()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("usp_GetActivityEnrichments");
        }
    
        public virtual int usp_GetClaim(string claimReference)
        {
            var claimReferenceParameter = claimReference != null ?
                new ObjectParameter("ClaimReference", claimReference) :
                new ObjectParameter("ClaimReference", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("usp_GetClaim", claimReferenceParameter);
        }
    
        public virtual int usp_GetLegacyActivityTimeline(string claimReference, string filter, string category, Nullable<System.DateTime> start, Nullable<System.DateTime> end, Nullable<int> skip, Nullable<int> take, Nullable<bool> sortDescending)
        {
            var claimReferenceParameter = claimReference != null ?
                new ObjectParameter("ClaimReference", claimReference) :
                new ObjectParameter("ClaimReference", typeof(string));
    
            var filterParameter = filter != null ?
                new ObjectParameter("Filter", filter) :
                new ObjectParameter("Filter", typeof(string));
    
            var categoryParameter = category != null ?
                new ObjectParameter("Category", category) :
                new ObjectParameter("Category", typeof(string));
    
            var startParameter = start.HasValue ?
                new ObjectParameter("Start", start) :
                new ObjectParameter("Start", typeof(System.DateTime));
    
            var endParameter = end.HasValue ?
                new ObjectParameter("End", end) :
                new ObjectParameter("End", typeof(System.DateTime));
    
            var skipParameter = skip.HasValue ?
                new ObjectParameter("Skip", skip) :
                new ObjectParameter("Skip", typeof(int));
    
            var takeParameter = take.HasValue ?
                new ObjectParameter("Take", take) :
                new ObjectParameter("Take", typeof(int));
    
            var sortDescendingParameter = sortDescending.HasValue ?
                new ObjectParameter("SortDescending", sortDescending) :
                new ObjectParameter("SortDescending", typeof(bool));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("usp_GetLegacyActivityTimeline", claimReferenceParameter, filterParameter, categoryParameter, startParameter, endParameter, skipParameter, takeParameter, sortDescendingParameter);
        }
    
        public virtual int usp_GetLossTypes()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("usp_GetLossTypes");
        }
    
        public virtual int usp_InsertClaim(string claimReference, Nullable<int> lossAdjusterId, Nullable<System.DateTime> lossDate, Nullable<int> userId, Nullable<int> lossTypeId, string lossLocation, string policyNo)
        {
            var claimReferenceParameter = claimReference != null ?
                new ObjectParameter("ClaimReference", claimReference) :
                new ObjectParameter("ClaimReference", typeof(string));
    
            var lossAdjusterIdParameter = lossAdjusterId.HasValue ?
                new ObjectParameter("LossAdjusterId", lossAdjusterId) :
                new ObjectParameter("LossAdjusterId", typeof(int));
    
            var lossDateParameter = lossDate.HasValue ?
                new ObjectParameter("LossDate", lossDate) :
                new ObjectParameter("LossDate", typeof(System.DateTime));
    
            var userIdParameter = userId.HasValue ?
                new ObjectParameter("UserId", userId) :
                new ObjectParameter("UserId", typeof(int));
    
            var lossTypeIdParameter = lossTypeId.HasValue ?
                new ObjectParameter("LossTypeId", lossTypeId) :
                new ObjectParameter("LossTypeId", typeof(int));
    
            var lossLocationParameter = lossLocation != null ?
                new ObjectParameter("LossLocation", lossLocation) :
                new ObjectParameter("LossLocation", typeof(string));
    
            var policyNoParameter = policyNo != null ?
                new ObjectParameter("PolicyNo", policyNo) :
                new ObjectParameter("PolicyNo", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("usp_InsertClaim", claimReferenceParameter, lossAdjusterIdParameter, lossDateParameter, userIdParameter, lossTypeIdParameter, lossLocationParameter, policyNoParameter);
        }
    
        public virtual int usp_InsertLossType(Nullable<int> lossTypeCode, string lossTypeDescription, Nullable<int> userId)
        {
            var lossTypeCodeParameter = lossTypeCode.HasValue ?
                new ObjectParameter("LossTypeCode", lossTypeCode) :
                new ObjectParameter("LossTypeCode", typeof(int));
    
            var lossTypeDescriptionParameter = lossTypeDescription != null ?
                new ObjectParameter("LossTypeDescription", lossTypeDescription) :
                new ObjectParameter("LossTypeDescription", typeof(string));
    
            var userIdParameter = userId.HasValue ?
                new ObjectParameter("UserId", userId) :
                new ObjectParameter("UserId", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("usp_InsertLossType", lossTypeCodeParameter, lossTypeDescriptionParameter, userIdParameter);
        }
    }
}
