CREATE TABLE [Rulebase].[ALB_LearningDelivery] (
    [UKPRN]                               BIGINT          NOT NULL,
    [LearnRefNumber]                      VARCHAR (12)    NOT NULL,
    [AimSeqNumber]                        INT             NOT NULL,
    [AreaCostFactAdj]                     DECIMAL (10, 5) NULL,
    [WeightedRate]                        DECIMAL (12, 5) NULL,
    [PlannedNumOnProgInstalm]             INT             NULL,
    [FundStart]                           BIT             NULL,
    [Achieved]                            BIT             NULL,
    [ActualNumInstalm]                    INT             NULL,
    [OutstndNumOnProgInstalm]             INT             NULL,
    [AreaCostInstalment]                  DECIMAL (12, 5) NULL,
    [AdvLoan]                             BIT             NULL,
    [LoanBursAreaUplift]                  BIT             NULL,
    [LoanBursSupp]                        BIT             NULL,
    [FundLine]                            VARCHAR (50)    NULL,
    [LiabilityDate]                       DATE            NULL,
    [ApplicProgWeightFact]                VARCHAR (1)     NULL,
    [ApplicFactDate]                      DATE            NULL,
    [LearnDelEligCareerLearnPilot]        BIT             NULL,
    [LearnDelApplicSubsidyPilotAreaCode]  VARCHAR (50)    NULL,
    [LearnDelApplicLARSCarPilFundSubRate] DECIMAL (12, 5) NULL,
    [LearnDelCarLearnPilotAimValue]       DECIMAL (12, 5) NULL,
    [LearnDelCarLearnPilotInstalAmount]   DECIMAL (12, 5) NULL,
    PRIMARY KEY CLUSTERED ([UKPRN] ASC, [LearnRefNumber] ASC, [AimSeqNumber] ASC)
);



