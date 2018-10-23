/*
 Pre-Deployment Script Template							
--------------------------------------------------------------------------------------
 This file contains SQL statements that will be executed before the build script.	
 Use SQLCMD syntax to include a file in the pre-deployment script.			
 Example:      :r .\myfile.sql								
 Use SQLCMD syntax to reference a variable in the pre-deployment script.		
 Example:      :setvar TableName MyTable							
               SELECT * FROM [$(TableName)]					
--------------------------------------------------------------------------------------
*/
SET NOCOUNT ON;
GO

RAISERROR('		   Update valid.LearningDeliveryFAM.LearningDeliveryFAM_Id',10,1) WITH NOWAIT;
GO
DROP SEQUENCE IF EXISTS  [Valid].[LearningDeliveryFAM_SEQUENCE]
GO
CREATE SEQUENCE [Valid].[LearningDeliveryFAM_SEQUENCE]
    START WITH 1  
    INCREMENT BY 1 ;  
GO
RAISERROR('		   CREATE SEQUENCE',10,1) WITH NOWAIT;
GO
IF EXISTS
(SELECT * FROM INFORMATION_SCHEMA.COLUMNS C
WHERE C.TABLE_SCHEMA = 'Valid' 
  AND C.TABLE_NAME = 'LearningDeliveryFAM'
  AND C.COLUMN_NAME = 'LearningDeliveryFAM_Id'
) 
BEGIN
	RAISERROR('		   Start Update.',10,1) WITH NOWAIT;
	EXEC ('UPDATE O SET [LearningDeliveryFAM_Id] = NEXT VALUE FOR [Valid].[LearningDeliveryFAM_SEQUENCE] FROM [Valid].[LearningDeliveryFAM] O')
	RAISERROR('		     End Update.',10,1) WITH NOWAIT;
	
END
GO
DROP SEQUENCE IF EXISTS  [Valid].[LearningDeliveryFAM_SEQUENCE]
GO
RAISERROR('		   Update valid.LearningDeliveryFAM.LearningDeliveryFAM_Id END',10,1) WITH NOWAIT;
GO