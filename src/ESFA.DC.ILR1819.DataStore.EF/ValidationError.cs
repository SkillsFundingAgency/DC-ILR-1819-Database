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
    
    public partial class ValidationError
    {
        public long Id { get; set; }
        public Nullable<int> UKPRN { get; set; }
        public string Source { get; set; }
        public string LearnAimRef { get; set; }
        public Nullable<long> AimSeqNum { get; set; }
        public string SWSupAimID { get; set; }
        public string ErrorMessage { get; set; }
        public string FieldValues { get; set; }
        public string LearnRefNumber { get; set; }
        public string RuleName { get; set; }
        public string Severity { get; set; }
        public Nullable<int> FileLevelError { get; set; }
    }
}
