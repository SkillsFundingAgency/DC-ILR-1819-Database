//------------------------------------------------------------------------------
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
    using System.Collections.Generic;
    
    public partial class LearningDelivery
    {
        public int LearningDelivery_Id { get; set; }
        public Nullable<int> Learner_Id { get; set; }
        public int UKPRN { get; set; }
        public string LearnRefNumber { get; set; }
        public string LearnAimRef { get; set; }
        public Nullable<long> AimType { get; set; }
        public Nullable<long> AimSeqNumber { get; set; }
        public Nullable<System.DateTime> LearnStartDate { get; set; }
        public Nullable<System.DateTime> OrigLearnStartDate { get; set; }
        public Nullable<System.DateTime> LearnPlanEndDate { get; set; }
        public Nullable<long> FundModel { get; set; }
        public Nullable<long> ProgType { get; set; }
        public Nullable<long> FworkCode { get; set; }
        public Nullable<long> PwayCode { get; set; }
        public Nullable<long> StdCode { get; set; }
        public Nullable<long> PartnerUKPRN { get; set; }
        public string DelLocPostCode { get; set; }
        public Nullable<long> AddHours { get; set; }
        public Nullable<long> PriorLearnFundAdj { get; set; }
        public Nullable<long> OtherFundAdj { get; set; }
        public string ConRefNumber { get; set; }
        public string EPAOrgID { get; set; }
        public Nullable<long> EmpOutcome { get; set; }
        public Nullable<long> CompStatus { get; set; }
        public Nullable<System.DateTime> LearnActEndDate { get; set; }
        public Nullable<long> WithdrawReason { get; set; }
        public Nullable<long> Outcome { get; set; }
        public Nullable<System.DateTime> AchDate { get; set; }
        public string OutGrade { get; set; }
        public string SWSupAimId { get; set; }
    }
}
