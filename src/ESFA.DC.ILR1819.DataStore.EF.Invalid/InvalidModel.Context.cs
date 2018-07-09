﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ESFA.DC.ILR1819.DataStore.EF.Invalid
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class ILR1819_DataStoreEntitiesInvalid : DbContext
    {
        public ILR1819_DataStoreEntitiesInvalid()
            : base("name=ILR1819_DataStoreEntitiesInvalid")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<AppFinRecord> AppFinRecords { get; set; }
        public virtual DbSet<CollectionDetail> CollectionDetails { get; set; }
        public virtual DbSet<ContactPreference> ContactPreferences { get; set; }
        public virtual DbSet<DPOutcome> DPOutcomes { get; set; }
        public virtual DbSet<EmploymentStatusMonitoring> EmploymentStatusMonitorings { get; set; }
        public virtual DbSet<Learner> Learners { get; set; }
        public virtual DbSet<LearnerDestinationandProgression> LearnerDestinationandProgressions { get; set; }
        public virtual DbSet<LearnerEmploymentStatu> LearnerEmploymentStatus { get; set; }
        public virtual DbSet<LearnerFAM> LearnerFAMs { get; set; }
        public virtual DbSet<LearnerHE> LearnerHEs { get; set; }
        public virtual DbSet<LearnerHEFinancialSupport> LearnerHEFinancialSupports { get; set; }
        public virtual DbSet<LearningDelivery> LearningDeliveries { get; set; }
        public virtual DbSet<LearningDeliveryFAM> LearningDeliveryFAMs { get; set; }
        public virtual DbSet<LearningDeliveryHE> LearningDeliveryHEs { get; set; }
        public virtual DbSet<LearningDeliveryWorkPlacement> LearningDeliveryWorkPlacements { get; set; }
        public virtual DbSet<LearningProvider> LearningProviders { get; set; }
        public virtual DbSet<LLDDandHealthProblem> LLDDandHealthProblems { get; set; }
        public virtual DbSet<ProviderSpecDeliveryMonitoring> ProviderSpecDeliveryMonitorings { get; set; }
        public virtual DbSet<ProviderSpecLearnerMonitoring> ProviderSpecLearnerMonitorings { get; set; }
        public virtual DbSet<Source> Sources { get; set; }
        public virtual DbSet<SourceFile> SourceFiles { get; set; }
    }
}
