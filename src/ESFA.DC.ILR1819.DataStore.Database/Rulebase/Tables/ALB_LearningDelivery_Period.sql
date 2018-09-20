CREATE TABLE [Rulebase].[ALB_LearningDelivery_Period] (
    [UKPRN]                              BIGINT          NOT NULL,
    [LearnRefNumber]                     VARCHAR (12)    NOT NULL,
    [AimSeqNumber]                       INT             NOT NULL,
    [Period]                             INT             NOT NULL,
    [AreaUpliftOnProgPayment]            DECIMAL (12, 5) NULL,
    [AreaUpliftBalPayment]               DECIMAL (12, 5) NULL,
    [ALBCode]                            INT             NULL,
    [ALBSupportPayment]                  DECIMAL (12, 5) NULL,
    [LearnDelCarLearnPilotOnProgPayment] DECIMAL (12, 5) NULL,
    [LearnDelCarLearnPilotBalPayment]    DECIMAL (12, 5) NULL,
    PRIMARY KEY CLUSTERED ([UKPRN] ASC, [LearnRefNumber] ASC, [AimSeqNumber] ASC, [Period] ASC)
);



