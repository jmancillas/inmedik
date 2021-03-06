USE [dbINMEDIK]
GO
SET IDENTITY_INSERT [dbo].[User] ON 

INSERT [dbo].[User] ([id], [UserAccount], [UserPassword], [UserActive], [Authenticator], [UpdatedBy], [CreatedBy], [UpdatedDate], [CreatedDate]) VALUES (1, N'admin@admin.com', N'brMB+NkOsHM81/JOE9nho7tOh8BnIbsg5O1l030BmLGhZmPCBZJWcsUCt5HAODmni1/ikCKBYncuz6gd5AFyIMLNYv8BGrJP3WvO0OecVVcAc4i1v/H+Kh17N87C2WDS', 1, 0, 1, 1, CAST(0x0000A88D00D30169 AS DateTime), CAST(0x0000A71900B53A26 AS DateTime))

SET IDENTITY_INSERT [dbo].[User] OFF
INSERT [dbo].[UserRole] ([UserId], [RoleId]) VALUES (1, 1)

SET IDENTITY_INSERT [dbo].[Address] ON 

INSERT [dbo].[Address] ([id], [CountyId], [AddressLine], [PostalCode], [Created], [Updated]) VALUES (1, 1, N'Vicente Ferrara 114', N'63978', NULL, NULL)

SET IDENTITY_INSERT [dbo].[Address] OFF

SET IDENTITY_INSERT [dbo].[Clinic] ON 
INSERT [dbo].[Clinic] ([id], [AddressId], [Name], [PhoneNumber], [Email], [Deleted], [Created], [Updated], [AllowDonations], [MinDonation], [RFC]) VALUES (1, 1, N'Matriz', N'89659865', N'ab@ab.com', 0, NULL, CAST(0x0000A84600D0EAD5 AS DateTime), 1, CAST(30.00 AS Numeric(15, 2)), N'2')
SET IDENTITY_INSERT [dbo].[Clinic] OFF
