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
    
    public partial class ESF_Learner
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ESF_Learner()
        {
            this.ESF_LearningDelivery = new HashSet<ESF_LearningDelivery>();
        }
    
        public int UKPRN { get; set; }
        public string LearnRefNumber { get; set; }
    
        public virtual ESF_global ESF_global { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ESF_LearningDelivery> ESF_LearningDelivery { get; set; }
    }
}
