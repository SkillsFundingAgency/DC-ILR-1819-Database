﻿
CREATE ROLE [DataViewing] AUTHORIZATION [dbo]
GO

-- Grant access rights to a specific schema in the database
GRANT 
	REFERENCES, 
	SELECT, 
	VIEW DEFINITION 
ON SCHEMA::dbo
	TO DataProcessing
GO

-- Grant access rights to a specific schema in the database
GRANT 
REFERENCES, 
	SELECT, 
	VIEW DEFINITION 
ON SCHEMA::Invalid
	TO DataProcessing
GO

-- Grant access rights to a specific schema in the database
GRANT 
	REFERENCES, 
	SELECT, 
	VIEW DEFINITION 
ON SCHEMA::Valid
	TO DataProcessing
GO

-- Grant access rights to a specific schema in the database
GRANT 
	REFERENCES, 
	SELECT, 
	VIEW DEFINITION 
ON SCHEMA::Rulebase
	TO DataProcessing
GO

-- Grant access rights to a specific schema in the database
GRANT 
	REFERENCES, 
	SELECT, 
	VIEW DEFINITION 
ON SCHEMA::DataLock
	TO DataProcessing
GO
