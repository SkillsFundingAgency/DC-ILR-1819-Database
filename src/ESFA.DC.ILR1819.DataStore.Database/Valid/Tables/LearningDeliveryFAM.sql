CREATE TABLE [Valid].[LearningDeliveryFAM] (
	[LearningDeliveryFAM_Id] INT       NOT NULL,
    [UKPRN]               INT          NOT NULL,
    [LearnRefNumber]      VARCHAR (12) NOT NULL,
    [AimSeqNumber]        INT          NOT NULL,
    [LearnDelFAMType]     VARCHAR (3)  NOT NULL,
    [LearnDelFAMCode]     VARCHAR (5)  NOT NULL,
    [LearnDelFAMDateFrom] DATE         NULL,
    [LearnDelFAMDateTo]   DATE         NULL, 
    CONSTRAINT [PK_LearningDeliveryFAM] PRIMARY KEY ([LearningDeliveryFAM_Id], [UKPRN])
);


GO
CREATE NONCLUSTERED INDEX [IX_Valid_LearningDeliveryFAM]
    ON [Valid].[LearningDeliveryFAM]([UKPRN] ASC, [LearnRefNumber] ASC, [AimSeqNumber] ASC, [LearnDelFAMType] ASC, [LearnDelFAMDateFrom] ASC);

