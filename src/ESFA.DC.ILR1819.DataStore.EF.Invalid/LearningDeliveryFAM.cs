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
    
    public partial class LearningDeliveryFAM
    {
        public int LearningDeliveryFAM_Id { get; set; }
        public Nullable<int> LearningDelivery_Id { get; set; }
        public int UKPRN { get; set; }
        public string LearnRefNumber { get; set; }
        public Nullable<long> AimSeqNumber { get; set; }
        public string LearnDelFAMType { get; set; }
        public string LearnDelFAMCode { get; set; }
        public Nullable<System.DateTime> LearnDelFAMDateFrom { get; set; }
        public Nullable<System.DateTime> LearnDelFAMDateTo { get; set; }
    }
}
