/*
   miércoles, 18 de septiembre de 201907:08:02 p. m.
   User: usrINMEDIK
   Server: 192.168.1.77
   Database: dbINMEDIK
   Application: 
*/

/* To prevent any potential data loss issues, you should review this script in detail before running it outside the context of the database designer.*/
BEGIN TRANSACTION
SET QUOTED_IDENTIFIER ON
SET ARITHABORT ON
SET NUMERIC_ROUNDABORT OFF
SET CONCAT_NULL_YIELDS_NULL ON
SET ANSI_NULLS ON
SET ANSI_PADDING ON
SET ANSI_WARNINGS ON
COMMIT
BEGIN TRANSACTION
GO
CREATE TABLE dbo.ElectronicFileUpdatesHistoric
	(
	id int NOT NULL,
	UpdatedBy int NULL,
	Updated datetime NULL,
	Source nvarchar(50) NULL
	)  ON [PRIMARY]
GO
ALTER TABLE dbo.ElectronicFileUpdatesHistoric ADD CONSTRAINT
	PK_ElectronicFileUpdatesHistoric PRIMARY KEY CLUSTERED 
	(
	id
	) WITH( STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]

GO
ALTER TABLE dbo.ElectronicFileUpdatesHistoric SET (LOCK_ESCALATION = TABLE)
GO
COMMIT
select Has_Perms_By_Name(N'dbo.ElectronicFileUpdatesHistoric', 'Object', 'ALTER') as ALT_Per, Has_Perms_By_Name(N'dbo.ElectronicFileUpdatesHistoric', 'Object', 'VIEW DEFINITION') as View_def_Per, Has_Perms_By_Name(N'dbo.ElectronicFileUpdatesHistoric', 'Object', 'CONTROL') as Contr_Per 