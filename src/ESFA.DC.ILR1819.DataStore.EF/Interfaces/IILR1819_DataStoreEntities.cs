using System.Data.Entity;

namespace ESFA.DC.ILR1819.DataStore.EF.Interfaces
{
    public interface IILR1819_DataStoreEntities
    {
        DbSet<FileDetail> FileDetails { get; set; }
        DbSet<ProcessingData> ProcessingDatas { get; set; }
        DbSet<ValidationError> ValidationErrors { get; set; }
        DbSet<VersionInfo> VersionInfoes { get; set; }
        DbSet<AEC_ApprenticeshipPriceEpisode> AEC_ApprenticeshipPriceEpisode { get; set; }
        DbSet<AEC_ApprenticeshipPriceEpisode_Period> AEC_ApprenticeshipPriceEpisode_Period { get; set; }
        DbSet<AEC_ApprenticeshipPriceEpisode_PeriodisedValues> AEC_ApprenticeshipPriceEpisode_PeriodisedValues { get; set; }
        DbSet<AEC_global> AEC_global { get; set; }
        DbSet<AEC_HistoricEarningOutput> AEC_HistoricEarningOutput { get; set; }
        DbSet<AEC_LearningDelivery> AEC_LearningDelivery { get; set; }
        DbSet<AEC_LearningDelivery_Period> AEC_LearningDelivery_Period { get; set; }
        DbSet<AEC_LearningDelivery_PeriodisedTextValues> AEC_LearningDelivery_PeriodisedTextValues { get; set; }
        DbSet<AEC_LearningDelivery_PeriodisedValues> AEC_LearningDelivery_PeriodisedValues { get; set; }
        DbSet<ALB_global> ALB_global { get; set; }
        DbSet<ALB_Learner_Period> ALB_Learner_Period { get; set; }
        DbSet<ALB_Learner_PeriodisedValues> ALB_Learner_PeriodisedValues { get; set; }
        DbSet<ALB_LearningDelivery> ALB_LearningDelivery { get; set; }
        DbSet<ALB_LearningDelivery_Period> ALB_LearningDelivery_Period { get; set; }
        DbSet<ALB_LearningDelivery_PeriodisedValues> ALB_LearningDelivery_PeriodisedValues { get; set; }
        DbSet<DV_Learner> DV_Learner { get; set; }
        DbSet<DV_LearningDelivery> DV_LearningDelivery { get; set; }
        DbSet<ESF_DPOutcome> ESF_DPOutcome { get; set; }
        DbSet<ESF_LearningDelivery> ESF_LearningDelivery { get; set; }
        DbSet<ESF_LearningDeliveryDeliverable> ESF_LearningDeliveryDeliverable { get; set; }
        DbSet<ESF_LearningDeliveryDeliverable_Period> ESF_LearningDeliveryDeliverable_Period { get; set; }
        DbSet<ESF_LearningDeliveryDeliverable_PeriodisedValues> ESF_LearningDeliveryDeliverable_PeriodisedValues { get; set; }
        DbSet<ESFVAL_global> ESFVAL_global { get; set; }
        DbSet<ESFVAL_ValidationError> ESFVAL_ValidationError { get; set; }
        DbSet<FM25_global> FM25_global { get; set; }
        DbSet<FM25_Learner> FM25_Learner { get; set; }
        DbSet<FM35_global> FM35_global { get; set; }
        DbSet<FM35_LearningDelivery> FM35_LearningDelivery { get; set; }
        DbSet<FM35_LearningDelivery_Period> FM35_LearningDelivery_Period { get; set; }
        DbSet<FM35_LearningDelivery_PeriodisedValues> FM35_LearningDelivery_PeriodisedValues { get; set; }
        DbSet<TBL_global> TBL_global { get; set; }
        DbSet<TBL_LearningDelivery> TBL_LearningDelivery { get; set; }
        DbSet<TBL_LearningDelivery_Period> TBL_LearningDelivery_Period { get; set; }
        DbSet<TBL_LearningDelivery_PeriodisedValues> TBL_LearningDelivery_PeriodisedValues { get; set; }
        DbSet<VAL_global> VAL_global { get; set; }
        DbSet<VAL_Learner> VAL_Learner { get; set; }
        DbSet<VAL_LearningDelivery> VAL_LearningDelivery { get; set; }
        DbSet<VAL_ValidationError> VAL_ValidationError { get; set; }
        DbSet<VALDP_global> VALDP_global { get; set; }
        DbSet<VALDP_ValidationError> VALDP_ValidationError { get; set; }
        DbSet<VALFD_ValidationError> VALFD_ValidationError { get; set; }
        DbSet<DasLearnerCommitment> DasLearnerCommitments { get; set; }
        DbSet<PriceEpisodeMatch> PriceEpisodeMatches { get; set; }
        DbSet<PriceEpisodePeriodMatch> PriceEpisodePeriodMatches { get; set; }
        DbSet<FM25_FM35_global> FM25_FM35_global { get; set; }
        DbSet<FM25_FM35_Learner_Period> FM25_FM35_Learner_Period { get; set; }
        DbSet<FM25_FM35_Learner_PeriodisedValues> FM25_FM35_Learner_PeriodisedValues { get; set; }
        DbSet<DV_global> DV_global { get; set; }
        DbSet<ESF_global> ESF_global { get; set; }
    }
}