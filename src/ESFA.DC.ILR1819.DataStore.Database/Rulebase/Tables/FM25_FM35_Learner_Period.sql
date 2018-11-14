CREATE TABLE [Rulebase].[FM25_FM35_Learner_Period] (
    [UKPRN]          INT             NOT NULL,
    [LearnRefNumber] VARCHAR (12)    NOT NULL,
    [Period]         INT             NOT NULL,
    [LnrOnProgPay]   DECIMAL (10, 5) NULL,
    PRIMARY KEY CLUSTERED ([UKPRN] ASC, [LearnRefNumber] ASC, [Period] ASC)
);
GO

ALTER TABLE [Rulebase].[FM25_FM35_Learner_Period] ADD CONSTRAINT [FK_FM25FM35LearnerPeriod_FM25FM35global] FOREIGN KEY([UKPRN])
REFERENCES [Rulebase].[FM25_FM35_global] ([UKPRN]);
GO

ALTER TABLE [Rulebase].[FM25_FM35_Learner_Period] CHECK CONSTRAINT [FK_FM25FM35LearnerPeriod_FM25FM35global]
GO