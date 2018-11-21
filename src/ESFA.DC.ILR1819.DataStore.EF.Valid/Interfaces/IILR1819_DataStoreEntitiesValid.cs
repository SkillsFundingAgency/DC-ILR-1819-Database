using System.Data.Entity;

namespace ESFA.DC.ILR1819.DataStore.EF.Valid.Interfaces
{
    public interface IILR1819_DataStoreEntitiesValid
    {
         DbSet<AppFinRecord> AppFinRecords { get; set; }
         DbSet<CollectionDetail> CollectionDetails { get; set; }
         DbSet<ContactPreference> ContactPreferences { get; set; }
         DbSet<DPOutcome> DPOutcomes { get; set; }
         DbSet<EmploymentStatusMonitoring> EmploymentStatusMonitorings { get; set; }
         DbSet<Learner> Learners { get; set; }
         DbSet<LearnerDestinationandProgression> LearnerDestinationandProgressions { get; set; }
         DbSet<LearnerEmploymentStatus> LearnerEmploymentStatuses { get; set; }
         DbSet<LearnerFAM> LearnerFAMs { get; set; }
         DbSet<LearnerHE> LearnerHEs { get; set; }
         DbSet<LearnerHEFinancialSupport> LearnerHEFinancialSupports { get; set; }
         DbSet<LearningDelivery> LearningDeliveries { get; set; }
         DbSet<LearningDeliveryFAM> LearningDeliveryFAMs { get; set; }
         DbSet<LearningDeliveryHE> LearningDeliveryHEs { get; set; }
         DbSet<LearningDeliveryWorkPlacement> LearningDeliveryWorkPlacements { get; set; }
         DbSet<LearningProvider> LearningProviders { get; set; }
         DbSet<ProviderSpecDeliveryMonitoring> ProviderSpecDeliveryMonitorings { get; set; }
         DbSet<ProviderSpecLearnerMonitoring> ProviderSpecLearnerMonitorings { get; set; }
         DbSet<Source> Sources { get; set; }
         DbSet<SourceFile> SourceFiles { get; set; }
         DbSet<LLDDandHealthProblem> LLDDandHealthProblems { get; set; }
    }
}