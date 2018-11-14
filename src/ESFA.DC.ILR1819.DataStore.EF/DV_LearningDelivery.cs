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
    
    public partial class DV_LearningDelivery
    {
        public int UKPRN { get; set; }
        public string LearnRefNumber { get; set; }
        public int AimSeqNumber { get; set; }
        public Nullable<int> LearnDel_AccToApp { get; set; }
        public Nullable<System.DateTime> LearnDel_AccToAppEmpDate { get; set; }
        public Nullable<int> LearnDel_AccToAppEmpStat { get; set; }
        public Nullable<decimal> LearnDel_AchFullLevel2Pct { get; set; }
        public Nullable<decimal> LearnDel_AchFullLevel3Pct { get; set; }
        public Nullable<int> LearnDel_Achieved { get; set; }
        public Nullable<int> LearnDel_AchievedIY { get; set; }
        public string LearnDel_AcMonthYTD { get; set; }
        public Nullable<int> LearnDel_ActDaysILAfterCurrAcYr { get; set; }
        public Nullable<int> LearnDel_ActDaysILCurrAcYr { get; set; }
        public Nullable<int> LearnDel_ActEndDateOnAfterJan1 { get; set; }
        public Nullable<int> LearnDel_ActEndDateOnAfterNov1 { get; set; }
        public Nullable<int> LearnDel_ActEndDateOnAfterOct1 { get; set; }
        public Nullable<int> LearnDel_ActiveIY { get; set; }
        public Nullable<int> LearnDel_ActiveJan { get; set; }
        public Nullable<int> LearnDel_ActiveNov { get; set; }
        public Nullable<int> LearnDel_ActiveOct { get; set; }
        public Nullable<int> LearnDel_ActTotalDaysIL { get; set; }
        public Nullable<int> LearnDel_AdvLoan { get; set; }
        public Nullable<int> LearnDel_AgeAimOrigStart { get; set; }
        public Nullable<int> LearnDel_AgeAtStart { get; set; }
        public Nullable<int> LearnDel_App { get; set; }
        public Nullable<int> LearnDel_App1618Fund { get; set; }
        public Nullable<int> LearnDel_App1925Fund { get; set; }
        public Nullable<int> LearnDel_AppAimType { get; set; }
        public Nullable<int> LearnDel_AppKnowl { get; set; }
        public Nullable<int> LearnDel_AppMainAim { get; set; }
        public Nullable<int> LearnDel_AppNonFund { get; set; }
        public Nullable<int> LearnDel_BasicSkills { get; set; }
        public Nullable<int> LearnDel_BasicSkillsParticipation { get; set; }
        public Nullable<int> LearnDel_BasicSkillsType { get; set; }
        public Nullable<int> LearnDel_CarryIn { get; set; }
        public Nullable<int> LearnDel_ClassRm { get; set; }
        public Nullable<int> LearnDel_CompAimApp { get; set; }
        public Nullable<int> LearnDel_CompAimProg { get; set; }
        public Nullable<int> LearnDel_Completed { get; set; }
        public Nullable<int> LearnDel_CompletedIY { get; set; }
        public Nullable<decimal> LearnDel_CompleteFullLevel2Pct { get; set; }
        public Nullable<decimal> LearnDel_CompleteFullLevel3Pct { get; set; }
        public Nullable<int> LearnDel_EFACoreAim { get; set; }
        public Nullable<int> LearnDel_Emp6MonthAimStart { get; set; }
        public Nullable<int> LearnDel_Emp6MonthProgStart { get; set; }
        public Nullable<System.DateTime> LearnDel_EmpDateBeforeFDL { get; set; }
        public Nullable<System.DateTime> LearnDel_EmpDatePriorFDL { get; set; }
        public Nullable<int> LearnDel_EmpID { get; set; }
        public Nullable<int> LearnDel_Employed { get; set; }
        public Nullable<int> LearnDel_EmpStatFDL { get; set; }
        public Nullable<int> LearnDel_EmpStatPrior { get; set; }
        public Nullable<int> LearnDel_EmpStatPriorFDL { get; set; }
        public Nullable<int> LearnDel_EnhanAppFund { get; set; }
        public Nullable<decimal> LearnDel_FullLevel2AchPct { get; set; }
        public Nullable<decimal> LearnDel_FullLevel2ContPct { get; set; }
        public Nullable<decimal> LearnDel_FullLevel3AchPct { get; set; }
        public Nullable<decimal> LearnDel_FullLevel3ContPct { get; set; }
        public Nullable<int> LearnDel_FuncSkills { get; set; }
        public Nullable<int> LearnDel_FundAgency { get; set; }
        public string LearnDel_FundingLineType { get; set; }
        public Nullable<int> LearnDel_FundingSource { get; set; }
        public Nullable<int> LearnDel_FundPrvYr { get; set; }
        public Nullable<int> LearnDel_FundStart { get; set; }
        public Nullable<int> LearnDel_GCE { get; set; }
        public Nullable<int> LearnDel_GCSE { get; set; }
        public Nullable<int> LearnDel_ILAcMonth1 { get; set; }
        public Nullable<int> LearnDel_ILAcMonth10 { get; set; }
        public Nullable<int> LearnDel_ILAcMonth11 { get; set; }
        public Nullable<int> LearnDel_ILAcMonth12 { get; set; }
        public Nullable<int> LearnDel_ILAcMonth2 { get; set; }
        public Nullable<int> LearnDel_ILAcMonth3 { get; set; }
        public Nullable<int> LearnDel_ILAcMonth4 { get; set; }
        public Nullable<int> LearnDel_ILAcMonth5 { get; set; }
        public Nullable<int> LearnDel_ILAcMonth6 { get; set; }
        public Nullable<int> LearnDel_ILAcMonth7 { get; set; }
        public Nullable<int> LearnDel_ILAcMonth8 { get; set; }
        public Nullable<int> LearnDel_ILAcMonth9 { get; set; }
        public Nullable<int> LearnDel_ILCurrAcYr { get; set; }
        public Nullable<System.DateTime> LearnDel_IYActEndDate { get; set; }
        public Nullable<System.DateTime> LearnDel_IYPlanEndDate { get; set; }
        public Nullable<System.DateTime> LearnDel_IYStartDate { get; set; }
        public Nullable<int> LearnDel_KeySkills { get; set; }
        public Nullable<int> LearnDel_LargeEmpDiscountId { get; set; }
        public Nullable<int> LearnDel_LargeEmployer { get; set; }
        public Nullable<System.DateTime> LearnDel_LastEmpDate { get; set; }
        public Nullable<int> LearnDel_LeaveMonth { get; set; }
        public Nullable<int> LearnDel_LenEmp { get; set; }
        public Nullable<int> LearnDel_LenUnemp { get; set; }
        public Nullable<int> LearnDel_LoanBursFund { get; set; }
        public Nullable<int> LearnDel_NotionLevel { get; set; }
        public Nullable<int> LearnDel_NotionLevelV2 { get; set; }
        public Nullable<int> LearnDel_NumHEDatasets { get; set; }
        public Nullable<int> LearnDel_OccupAim { get; set; }
        public Nullable<int> LearnDel_OLASS { get; set; }
        public Nullable<int> LearnDel_OLASSCom { get; set; }
        public Nullable<int> LearnDel_OLASSCus { get; set; }
        public Nullable<System.DateTime> LearnDel_OrigStartDate { get; set; }
        public Nullable<int> LearnDel_PlanDaysILAfterCurrAcYr { get; set; }
        public Nullable<int> LearnDel_PlanDaysILCurrAcYr { get; set; }
        public Nullable<int> LearnDel_PlanEndBeforeAug1 { get; set; }
        public Nullable<int> LearnDel_PlanEndOnAfterJan1 { get; set; }
        public Nullable<int> LearnDel_PlanEndOnAfterNov1 { get; set; }
        public Nullable<int> LearnDel_PlanEndOnAfterOct1 { get; set; }
        public Nullable<int> LearnDel_PlanTotalDaysIL { get; set; }
        public Nullable<int> LearnDel_PriorEducationStatus { get; set; }
        public Nullable<int> LearnDel_Prog { get; set; }
        public Nullable<int> LearnDel_ProgAimAch { get; set; }
        public Nullable<int> LearnDel_ProgAimApp { get; set; }
        public Nullable<int> LearnDel_ProgCompleted { get; set; }
        public Nullable<int> LearnDel_ProgCompletedIY { get; set; }
        public Nullable<System.DateTime> LearnDel_ProgStartDate { get; set; }
        public Nullable<int> LearnDel_QCF { get; set; }
        public Nullable<int> LearnDel_QCFCert { get; set; }
        public Nullable<int> LearnDel_QCFDipl { get; set; }
        public Nullable<int> LearnDel_QCFType { get; set; }
        public Nullable<int> LearnDel_RegAim { get; set; }
        public string LearnDel_SecSubAreaTier1 { get; set; }
        public string LearnDel_SecSubAreaTier2 { get; set; }
        public Nullable<int> LearnDel_SFAApproved { get; set; }
        public Nullable<int> LearnDel_SourceFundEFA { get; set; }
        public Nullable<int> LearnDel_SourceFundSFA { get; set; }
        public Nullable<int> LearnDel_StartBeforeApr1 { get; set; }
        public Nullable<int> LearnDel_StartBeforeAug1 { get; set; }
        public Nullable<int> LearnDel_StartBeforeDec1 { get; set; }
        public Nullable<int> LearnDel_StartBeforeFeb1 { get; set; }
        public Nullable<int> LearnDel_StartBeforeJan1 { get; set; }
        public Nullable<int> LearnDel_StartBeforeJun1 { get; set; }
        public Nullable<int> LearnDel_StartBeforeMar1 { get; set; }
        public Nullable<int> LearnDel_StartBeforeMay1 { get; set; }
        public Nullable<int> LearnDel_StartBeforeNov1 { get; set; }
        public Nullable<int> LearnDel_StartBeforeOct1 { get; set; }
        public Nullable<int> LearnDel_StartBeforeSep1 { get; set; }
        public Nullable<int> LearnDel_StartIY { get; set; }
        public Nullable<int> LearnDel_StartJan1 { get; set; }
        public Nullable<int> LearnDel_StartMonth { get; set; }
        public Nullable<int> LearnDel_StartNov1 { get; set; }
        public Nullable<int> LearnDel_StartOct1 { get; set; }
        public Nullable<int> LearnDel_SuccRateStat { get; set; }
        public Nullable<int> LearnDel_TrainAimType { get; set; }
        public Nullable<int> LearnDel_TransferDiffProvider { get; set; }
        public Nullable<int> LearnDel_TransferDiffProviderGovStrat { get; set; }
        public Nullable<int> LearnDel_TransferProvider { get; set; }
        public Nullable<int> LearnDel_UfIProv { get; set; }
        public Nullable<int> LearnDel_UnempBenFDL { get; set; }
        public Nullable<int> LearnDel_UnempBenPrior { get; set; }
        public Nullable<int> LearnDel_Withdrawn { get; set; }
        public string LearnDel_WorkplaceLocPostcode { get; set; }
        public Nullable<int> Prog_AccToApp { get; set; }
        public Nullable<int> Prog_Achieved { get; set; }
        public Nullable<int> Prog_AchievedIY { get; set; }
        public Nullable<System.DateTime> Prog_ActEndDate { get; set; }
        public Nullable<int> Prog_ActiveIY { get; set; }
        public Nullable<int> Prog_AgeAtStart { get; set; }
        public Nullable<int> Prog_EarliestAim { get; set; }
        public Nullable<int> Prog_Employed { get; set; }
        public Nullable<int> Prog_FundPrvYr { get; set; }
        public Nullable<int> Prog_ILCurrAcYear { get; set; }
        public Nullable<int> Prog_LatestAim { get; set; }
        public Nullable<int> Prog_SourceFundEFA { get; set; }
        public Nullable<int> Prog_SourceFundSFA { get; set; }
    
        public virtual DV_Learner DV_Learner { get; set; }
    }
}
