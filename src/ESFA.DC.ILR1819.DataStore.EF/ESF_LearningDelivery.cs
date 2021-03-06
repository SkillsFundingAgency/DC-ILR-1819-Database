//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ESFA.DC.ILR1819.DataStore.EF
{
    using System;
    using System.Collections.Generic;
    
    public partial class ESF_LearningDelivery
    {
        public int UKPRN { get; set; }
        public string LearnRefNumber { get; set; }
        public int AimSeqNumber { get; set; }
        public Nullable<bool> Achieved { get; set; }
        public Nullable<bool> AddProgCostElig { get; set; }
        public Nullable<decimal> AdjustedAreaCostFactor { get; set; }
        public Nullable<decimal> AdjustedPremiumFactor { get; set; }
        public Nullable<System.DateTime> AdjustedStartDate { get; set; }
        public string AimClassification { get; set; }
        public Nullable<decimal> AimValue { get; set; }
        public Nullable<decimal> ApplicWeightFundRate { get; set; }
        public Nullable<long> EligibleProgressionOutcomeCode { get; set; }
        public string EligibleProgressionOutcomeType { get; set; }
        public Nullable<System.DateTime> EligibleProgressionOutomeStartDate { get; set; }
        public Nullable<bool> FundStart { get; set; }
        public Nullable<decimal> LARSWeightedRate { get; set; }
        public Nullable<System.DateTime> LatestPossibleStartDate { get; set; }
        public Nullable<System.DateTime> LDESFEngagementStartDate { get; set; }
        public Nullable<bool> PotentiallyEligibleForProgression { get; set; }
        public Nullable<System.DateTime> ProgressionEndDate { get; set; }
        public Nullable<bool> Restart { get; set; }
        public Nullable<decimal> WeightedRateFromESOL { get; set; }
    }
}
