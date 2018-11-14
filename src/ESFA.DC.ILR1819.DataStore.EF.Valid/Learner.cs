//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ESFA.DC.ILR1819.DataStore.EF.Valid
{
    using System;
    using System.Collections.Generic;
    
    public partial class Learner
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Learner()
        {
            this.ContactPreferences = new HashSet<ContactPreference>();
            this.LearnerEmploymentStatus = new HashSet<LearnerEmploymentStatu>();
            this.LearnerFAMs = new HashSet<LearnerFAM>();
            this.LearningDeliveries = new HashSet<LearningDelivery>();
            this.LLDDandHealthProblems = new HashSet<LLDDandHealthProblem>();
            this.ProviderSpecLearnerMonitorings = new HashSet<ProviderSpecLearnerMonitoring>();
        }
    
        public int UKPRN { get; set; }
        public string LearnRefNumber { get; set; }
        public string PrevLearnRefNumber { get; set; }
        public Nullable<int> PrevUKPRN { get; set; }
        public Nullable<int> PMUKPRN { get; set; }
        public long ULN { get; set; }
        public string FamilyName { get; set; }
        public string GivenNames { get; set; }
        public Nullable<System.DateTime> DateOfBirth { get; set; }
        public int Ethnicity { get; set; }
        public string Sex { get; set; }
        public int LLDDHealthProb { get; set; }
        public string NINumber { get; set; }
        public Nullable<int> PriorAttain { get; set; }
        public Nullable<int> Accom { get; set; }
        public Nullable<int> ALSCost { get; set; }
        public Nullable<int> PlanLearnHours { get; set; }
        public Nullable<int> PlanEEPHours { get; set; }
        public string MathGrade { get; set; }
        public string EngGrade { get; set; }
        public string PostcodePrior { get; set; }
        public string Postcode { get; set; }
        public string AddLine1 { get; set; }
        public string AddLine2 { get; set; }
        public string AddLine3 { get; set; }
        public string AddLine4 { get; set; }
        public string TelNo { get; set; }
        public string Email { get; set; }
        public string CampId { get; set; }
        public Nullable<long> OTJHours { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ContactPreference> ContactPreferences { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LearnerEmploymentStatu> LearnerEmploymentStatus { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LearnerFAM> LearnerFAMs { get; set; }
        public virtual LearnerHE LearnerHE { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LearningDelivery> LearningDeliveries { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LLDDandHealthProblem> LLDDandHealthProblems { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ProviderSpecLearnerMonitoring> ProviderSpecLearnerMonitorings { get; set; }
    }
}
