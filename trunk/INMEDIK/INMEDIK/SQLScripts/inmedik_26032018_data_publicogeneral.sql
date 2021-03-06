USE [dbINMEDIK]
GO
SET IDENTITY_INSERT [dbo].[Address] ON 
INSERT [dbo].[Address] ([id], [CountyId], [AddressLine], [PostalCode], [Created], [Updated]) VALUES (1, 17, N'Dir', N'0000', CAST(0x0000A86A013C3A3A AS DateTime), CAST(0x0000A86A013C3A3A AS DateTime))
SET IDENTITY_INSERT [dbo].[Address] OFF

SET IDENTITY_INSERT [dbo].[Person] ON 
INSERT [dbo].[Person] ([id], [AddressId], [Name], [LastName], [BirthDate], [Sex], [Email], [PhoneNumber], [Mobile], [Deleted], [Created], [Updated]) VALUES (1, 1, N'PÚBLICO', N'GENERAL', CAST(0x20F10A00 AS Date), N'M', NULL, NULL, NULL, 0, CAST(0x0000A86A013C3A3C AS DateTime), CAST(0x0000A86A013C3A3C AS DateTime))
SET IDENTITY_INSERT [dbo].[Person] OFF

SET IDENTITY_INSERT [dbo].[Patient] ON 
INSERT [dbo].[Patient] ([id], [PersonId], [Reference], [Deleted], [Created], [Updated]) VALUES (1, 1, NULL, 0, CAST(0x0000A86A013C3A3F AS DateTime), CAST(0x0000A86A013C3A40 AS DateTime))
SET IDENTITY_INSERT [dbo].[Patient] OFF
