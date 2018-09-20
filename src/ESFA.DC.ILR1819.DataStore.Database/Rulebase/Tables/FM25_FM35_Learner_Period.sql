CREATE TABLE [Rulebase].[FM25_FM35_Learner_Period] (
    [UKPRN]          INT             NOT NULL,
    [LearnRefNumber] VARCHAR (12)    NOT NULL,
    [Period]         INT             NOT NULL,
    [LnrOnProgPay]   DECIMAL (10, 5) NULL,
    PRIMARY KEY CLUSTERED ([UKPRN] ASC, [LearnRefNumber] ASC, [Period] ASC)
);

