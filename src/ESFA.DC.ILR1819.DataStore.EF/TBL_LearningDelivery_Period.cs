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
    
    public partial class TBL_LearningDelivery_Period
    {
        public int UKPRN { get; set; }
        public string LearnRefNumber { get; set; }
        public int AimSeqNumber { get; set; }
        public int Period { get; set; }
        public Nullable<decimal> AchPayment { get; set; }
        public Nullable<decimal> CoreGovContPayment { get; set; }
        public Nullable<decimal> CoreGovContUncapped { get; set; }
        public Nullable<int> InstPerPeriod { get; set; }
        public Nullable<bool> LearnSuppFund { get; set; }
        public Nullable<decimal> LearnSuppFundCash { get; set; }
        public Nullable<decimal> MathEngBalPayment { get; set; }
        public Nullable<decimal> MathEngBalPct { get; set; }
        public Nullable<decimal> MathEngOnProgPayment { get; set; }
        public Nullable<decimal> MathEngOnProgPct { get; set; }
        public Nullable<decimal> SmallBusPayment { get; set; }
        public Nullable<decimal> YoungAppFirstPayment { get; set; }
        public Nullable<decimal> YoungAppPayment { get; set; }
        public Nullable<decimal> YoungAppSecondPayment { get; set; }
    
        public virtual TBL_LearningDelivery TBL_LearningDelivery { get; set; }
    }
}
