USE [dbINMEDIK]
GO
SET IDENTITY_INSERT [dbo].[DiscountType] ON 

INSERT [dbo].[DiscountType] ([id], [Code], [Description]) VALUES (1, N'Percentage', N'Porcentaje')
INSERT [dbo].[DiscountType] ([id], [Code], [Description]) VALUES (2, N'Direct', N'Porcentaje sucursal')
SET IDENTITY_INSERT [dbo].[DiscountType] OFF
