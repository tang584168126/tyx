USE [House]
GO
/****** Object:  Table [dbo].[District]    Script Date: 09/06/2015 13:23:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[District](
	[Id] [int] NOT NULL,
	[Name] [nvarchar](50) NULL,
 CONSTRAINT [PK_District] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[District] ([Id], [Name]) VALUES (1000, N'丰台')
INSERT [dbo].[District] ([Id], [Name]) VALUES (1001, N'东城')
INSERT [dbo].[District] ([Id], [Name]) VALUES (1002, N'西城')
INSERT [dbo].[District] ([Id], [Name]) VALUES (1003, N'石景山')
INSERT [dbo].[District] ([Id], [Name]) VALUES (1004, N'海淀')
INSERT [dbo].[District] ([Id], [Name]) VALUES (1006, N'朝阳')
/****** Object:  Table [dbo].[HouseType]    Script Date: 09/06/2015 13:23:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HouseType](
	[Id] [int] NOT NULL,
	[Name] [nvarchar](10) NOT NULL,
 CONSTRAINT [PK_HouseType] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[HouseType] ([Id], [Name]) VALUES (1000, N'一室一厅')
INSERT [dbo].[HouseType] ([Id], [Name]) VALUES (1001, N'一室两厅')
INSERT [dbo].[HouseType] ([Id], [Name]) VALUES (1002, N'两室一厅')
INSERT [dbo].[HouseType] ([Id], [Name]) VALUES (1003, N'两室两厅')
INSERT [dbo].[HouseType] ([Id], [Name]) VALUES (1004, N'三室一厅')
INSERT [dbo].[HouseType] ([Id], [Name]) VALUES (1005, N'三室两厅')
INSERT [dbo].[HouseType] ([Id], [Name]) VALUES (1006, N'四室一厅')
INSERT [dbo].[HouseType] ([Id], [Name]) VALUES (1007, N'四室两厅')
INSERT [dbo].[HouseType] ([Id], [Name]) VALUES (1008, N'四室三厅')
/****** Object:  Table [dbo].[User]    Script Date: 09/06/2015 13:23:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[User](
	[LoginId] [int] IDENTITY(10000,1) NOT NULL,
	[LoginName] [nvarchar](20) NOT NULL,
	[UserName] [nvarchar](10) NOT NULL,
	[Password] [nvarchar](50) NOT NULL,
	[Telephone] [nvarchar](20) NULL,
 CONSTRAINT [PK_User] PRIMARY KEY CLUSTERED 
(
	[LoginId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[User] ON
INSERT [dbo].[User] ([LoginId], [LoginName], [UserName], [Password], [Telephone]) VALUES (10001, N'admin', N'admin', N'admin', NULL)
INSERT [dbo].[User] ([LoginId], [LoginName], [UserName], [Password], [Telephone]) VALUES (10002, N'hlg_owner', N'包建昌', N'123', N'18612346578')
INSERT [dbo].[User] ([LoginId], [LoginName], [UserName], [Password], [Telephone]) VALUES (10003, N'tty_owner', N'陈豪', N'123', N'56567878')
SET IDENTITY_INSERT [dbo].[User] OFF
/****** Object:  Table [dbo].[Street]    Script Date: 09/06/2015 13:23:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Street](
	[Id] [int] NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[DistrictId] [int] NOT NULL,
 CONSTRAINT [PK_Street] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[Street] ([Id], [Name], [DistrictId]) VALUES (1000, N'知春路', 1004)
INSERT [dbo].[Street] ([Id], [Name], [DistrictId]) VALUES (1001, N'中关村大街', 1004)
INSERT [dbo].[Street] ([Id], [Name], [DistrictId]) VALUES (1002, N'学院路', 1004)
INSERT [dbo].[Street] ([Id], [Name], [DistrictId]) VALUES (1003, N'朝阳路', 1006)
/****** Object:  Table [dbo].[House]    Script Date: 09/06/2015 13:23:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[House](
	[HouseId] [int] IDENTITY(1,1) NOT NULL,
	[Title] [nvarchar](50) NOT NULL,
	[TypeId] [int] NOT NULL,
	[Floorage] [decimal](18, 2) NOT NULL,
	[Price] [decimal](18, 2) NOT NULL,
	[StreetId] [int] NOT NULL,
	[Contract] [nvarchar](50) NOT NULL,
	[Description] [nvarchar](1000) NULL,
	[PublishUser] [int] NOT NULL,
	[PublishTime] [datetime] NOT NULL,
 CONSTRAINT [PK_House] PRIMARY KEY CLUSTERED 
(
	[HouseId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[House] ON
INSERT [dbo].[House] ([HouseId], [Title], [TypeId], [Floorage], [Price], [StreetId], [Contract], [Description], [PublishUser], [PublishTime]) VALUES (2, N'知春路56号院 紧邻13号线', 1002, CAST(61.60 AS Decimal(18, 2)), CAST(4500.00 AS Decimal(18, 2)), 1000, N'13522039951', N'南北通透，家电齐全，拎包入住。', 10002, CAST(0x0000A1F300C0618A AS DateTime))
INSERT [dbo].[House] ([HouseId], [Title], [TypeId], [Floorage], [Price], [StreetId], [Contract], [Description], [PublishUser], [PublishTime]) VALUES (3, N'知春路罗庄东里南北通透', 1002, CAST(58.00 AS Decimal(18, 2)), CAST(3800.00 AS Decimal(18, 2)), 1000, N'1352210787', N'正规两居室，南北通透，木地板，房子非常干净，保持得很好。家电齐全，拎包入住。', 10002, CAST(0x0000A1F300C15DEE AS DateTime))
INSERT [dbo].[House] ([HouseId], [Title], [TypeId], [Floorage], [Price], [StreetId], [Contract], [Description], [PublishUser], [PublishTime]) VALUES (4, N'中关村大主卧', 1004, CAST(18.00 AS Decimal(18, 2)), CAST(1500.00 AS Decimal(18, 2)), 1001, N'55457788', N'大主卧，北大旁边，干净。', 10002, CAST(0x0000A1F300F8B598 AS DateTime))
INSERT [dbo].[House] ([HouseId], [Title], [TypeId], [Floorage], [Price], [StreetId], [Contract], [Description], [PublishUser], [PublishTime]) VALUES (5, N'朝阳一居室临6号线', 1000, CAST(40.00 AS Decimal(18, 2)), CAST(2600.00 AS Decimal(18, 2)), 1003, N'55457788', N'新装修的一居，希望租给学生或夫妻。', 10002, CAST(0x0000A1F300F92E86 AS DateTime))
INSERT [dbo].[House] ([HouseId], [Title], [TypeId], [Floorage], [Price], [StreetId], [Contract], [Description], [PublishUser], [PublishTime]) VALUES (6, N'青云小区单间', 1002, CAST(10.00 AS Decimal(18, 2)), CAST(900.00 AS Decimal(18, 2)), 1000, N'13522039951', N'二局中的一个小单间，希望租给生活有规律的社会人士或学生。', 10002, CAST(0x0000A1F300F9A355 AS DateTime))
INSERT [dbo].[House] ([HouseId], [Title], [TypeId], [Floorage], [Price], [StreetId], [Contract], [Description], [PublishUser], [PublishTime]) VALUES (7, N'北邮学生宿舍1床位', 1000, CAST(6.00 AS Decimal(18, 2)), CAST(300.00 AS Decimal(18, 2)), 1002, N'18711234566', N'北邮研究生宿舍1床位出租', 10002, CAST(0x0000A1F300FA53F8 AS DateTime))
INSERT [dbo].[House] ([HouseId], [Title], [TypeId], [Floorage], [Price], [StreetId], [Contract], [Description], [PublishUser], [PublishTime]) VALUES (9, N'人大好单间出租', 1004, CAST(12.00 AS Decimal(18, 2)), CAST(1200.00 AS Decimal(18, 2)), 1001, N'18645456766', N'该房子已有两租户入住，求1人合租，男女不限，生活非常方便。', 10003, CAST(0x0000A25000B7964C AS DateTime))
SET IDENTITY_INSERT [dbo].[House] OFF
/****** Object:  Default [DF_House_PublishTime]    Script Date: 09/06/2015 13:23:17 ******/
ALTER TABLE [dbo].[House] ADD  CONSTRAINT [DF_House_PublishTime]  DEFAULT (getdate()) FOR [PublishTime]
GO
/****** Object:  ForeignKey [FK_House_House]    Script Date: 09/06/2015 13:23:17 ******/
ALTER TABLE [dbo].[House]  WITH CHECK ADD  CONSTRAINT [FK_House_House] FOREIGN KEY([PublishUser])
REFERENCES [dbo].[User] ([LoginId])
GO
ALTER TABLE [dbo].[House] CHECK CONSTRAINT [FK_House_House]
GO
/****** Object:  ForeignKey [FK_House_HouseType]    Script Date: 09/06/2015 13:23:17 ******/
ALTER TABLE [dbo].[House]  WITH CHECK ADD  CONSTRAINT [FK_House_HouseType] FOREIGN KEY([TypeId])
REFERENCES [dbo].[HouseType] ([Id])
GO
ALTER TABLE [dbo].[House] CHECK CONSTRAINT [FK_House_HouseType]
GO
/****** Object:  ForeignKey [FK_House_Street]    Script Date: 09/06/2015 13:23:17 ******/
ALTER TABLE [dbo].[House]  WITH CHECK ADD  CONSTRAINT [FK_House_Street] FOREIGN KEY([StreetId])
REFERENCES [dbo].[Street] ([Id])
GO
ALTER TABLE [dbo].[House] CHECK CONSTRAINT [FK_House_Street]
GO
/****** Object:  ForeignKey [FK_Street_District]    Script Date: 09/06/2015 13:23:17 ******/
ALTER TABLE [dbo].[Street]  WITH CHECK ADD  CONSTRAINT [FK_Street_District] FOREIGN KEY([DistrictId])
REFERENCES [dbo].[District] ([Id])
GO
ALTER TABLE [dbo].[Street] CHECK CONSTRAINT [FK_Street_District]
GO
