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
    
    public partial class LearnerFAM
    {
        public int UKPRN { get; set; }
        public string LearnRefNumber { get; set; }
        public string LearnFAMType { get; set; }
        public int LearnFAMCode { get; set; }
    
        public virtual Learner Learner { get; set; }
    }
}
