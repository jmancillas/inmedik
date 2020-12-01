/*
Deployment script for dbINMEDIK

This code was generated by a tool.
Changes to this file may cause incorrect behavior and will be lost if
the code is regenerated.
*/

GO
SET ANSI_NULLS, ANSI_PADDING, ANSI_WARNINGS, ARITHABORT, CONCAT_NULL_YIELDS_NULL, QUOTED_IDENTIFIER ON;

SET NUMERIC_ROUNDABORT OFF;


GO
:setvar DatabaseName "dbINMEDIK"
:setvar DefaultFilePrefix "dbINMEDIK"
:setvar DefaultDataPath "F:\Data\"
:setvar DefaultLogPath "F:\Log\"

GO
:on error exit
GO
/*
Detect SQLCMD mode and disable script execution if SQLCMD mode is not supported.
To re-enable the script after enabling SQLCMD mode, execute the following:
SET NOEXEC OFF; 
*/
:setvar __IsSqlCmdEnabled "True"
GO
IF N'$(__IsSqlCmdEnabled)' NOT LIKE N'True'
    BEGIN
        PRINT N'SQLCMD mode must be enabled to successfully execute this script.';
        SET NOEXEC ON;
    END


GO
USE [$(DatabaseName)];


GO
PRINT N'Dropping <unnamed>...';


GO
PRINT N'Altering [dbo].[AHFComments]...';


GO
ALTER TABLE [dbo].[AHFComments]
    ADD [Created]   DATETIME NULL,
        [CreatedBy] INT      NULL,
        [Updated]   DATETIME NULL,
        [UpdatedBy] INT      NULL;


GO
PRINT N'Altering [dbo].[APNP]...';


GO
ALTER TABLE [dbo].[APNP]
    ADD [Created]   DATETIME NULL,
        [CreatedBy] INT      NULL,
        [Updated]   DATETIME NULL,
        [UpdatedBy] INT      NULL;


GO
PRINT N'Altering [dbo].[APP]...';


GO
ALTER TABLE [dbo].[APP]
    ADD [Created]   DATETIME NULL,
        [CreatedBy] INT      NULL,
        [Updated]   DATETIME NULL,
        [UpdatedBy] INT      NULL;


GO
PRINT N'Altering [dbo].[EvolutionNote]...';


GO
ALTER TABLE [dbo].[EvolutionNote]
    ADD [IsCancelled] BIT NULL;


GO
PRINT N'Altering [dbo].[InterconsultNote]...';


GO
ALTER TABLE [dbo].[InterconsultNote]
    ADD [IsCancelled] BIT NULL;


GO
PRINT N'Altering [dbo].[ReferenceNote]...';


GO
ALTER TABLE [dbo].[ReferenceNote]
    ADD [IsCancelled] BIT NULL;


GO
PRINT N'Creating [dbo].[FK_AHFComments_User]...';


GO
ALTER TABLE [dbo].[AHFComments] WITH NOCHECK
    ADD CONSTRAINT [FK_AHFComments_User] FOREIGN KEY ([UpdatedBy]) REFERENCES [dbo].[User] ([id]);


GO
PRINT N'Creating [dbo].[FK_AHFComments_User1]...';


GO
ALTER TABLE [dbo].[AHFComments] WITH NOCHECK
    ADD CONSTRAINT [FK_AHFComments_User1] FOREIGN KEY ([CreatedBy]) REFERENCES [dbo].[User] ([id]);


GO
PRINT N'Creating [dbo].[FK_APNP_User]...';


GO
ALTER TABLE [dbo].[APNP] WITH NOCHECK
    ADD CONSTRAINT [FK_APNP_User] FOREIGN KEY ([UpdatedBy]) REFERENCES [dbo].[User] ([id]);


GO
PRINT N'Creating [dbo].[FK_APNP_User1]...';


GO
ALTER TABLE [dbo].[APNP] WITH NOCHECK
    ADD CONSTRAINT [FK_APNP_User1] FOREIGN KEY ([CreatedBy]) REFERENCES [dbo].[User] ([id]);


GO
PRINT N'Creating [dbo].[FK_APP_User]...';


GO
ALTER TABLE [dbo].[APP] WITH NOCHECK
    ADD CONSTRAINT [FK_APP_User] FOREIGN KEY ([UpdatedBy]) REFERENCES [dbo].[User] ([id]);


GO
PRINT N'Creating [dbo].[FK_APP_User1]...';


GO
ALTER TABLE [dbo].[APP] WITH NOCHECK
    ADD CONSTRAINT [FK_APP_User1] FOREIGN KEY ([CreatedBy]) REFERENCES [dbo].[User] ([id]);


GO
PRINT N'Creating [dbo].[vwElectronicFilesUpdates]...';


GO
CREATE VIEW dbo.vwElectronicFilesUpdates
AS
SELECT        dbo.AHFComments.UpdatedBy, dbo.AHFComments.Updated, dbo.AHFComments.Id AS TabId, 'AHF' as Source
FROM            dbo.AHFComments
UNION
SELECT        dbo.APNP.UpdatedBy, dbo.APNP.Updated, dbo.APNP.Id,'APNP' as Source
FROM            dbo.APNP
UNION
SELECT        dbo.APP.UpdatedBy, dbo.APP.Updated, dbo.APP.Id,'APP' as Source
FROM            dbo.APP
UNION
SELECT        dbo.EvolutionNote.UpdatedBy, dbo.EvolutionNote.Updated, dbo.EvolutionNote.Id,'EvolutionNote' as Source
FROM            dbo.EvolutionNote
UNION
SELECT        dbo.InterconsultNote.UpdatedBy, dbo.InterconsultNote.Updated, dbo.InterconsultNote.Id,'InterconsultNote' as Source
FROM            dbo.InterconsultNote
UNION
SELECT        dbo.ReferenceNote.UpdatedBy, dbo.ReferenceNote.Updated, dbo.ReferenceNote.Id,'Reference Note' as Source
FROM            dbo.ReferenceNote
GO
PRINT N'Creating [dbo].[vwElectronicFilesUpdates].[MS_DiagramPane1]...';


GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPane1', @value = N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = -288
         Left = 0
      End
      Begin Tables = 
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
      Begin ColumnWidths = 9
         Width = 284
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'vwElectronicFilesUpdates';


GO
PRINT N'Creating [dbo].[vwElectronicFilesUpdates].[MS_DiagramPaneCount]...';


GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPaneCount', @value = 1, @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'vwElectronicFilesUpdates';


GO
PRINT N'Checking existing data against newly created constraints';


GO
USE [$(DatabaseName)];


GO
ALTER TABLE [dbo].[AHFComments] WITH CHECK CHECK CONSTRAINT [FK_AHFComments_User];

ALTER TABLE [dbo].[AHFComments] WITH CHECK CHECK CONSTRAINT [FK_AHFComments_User1];

ALTER TABLE [dbo].[APNP] WITH CHECK CHECK CONSTRAINT [FK_APNP_User];

ALTER TABLE [dbo].[APNP] WITH CHECK CHECK CONSTRAINT [FK_APNP_User1];

ALTER TABLE [dbo].[APP] WITH CHECK CHECK CONSTRAINT [FK_APP_User];

ALTER TABLE [dbo].[APP] WITH CHECK CHECK CONSTRAINT [FK_APP_User1];


GO
PRINT N'Update complete.';


GO