USE MASTER
GO
/*--创建数据库MySchool具有一个数据文件和一个日志文件*/
IF  EXISTS(SELECT * FROM  sysdatabases  WHERE  name ='MySchool')
	DROP DATABASE MySchool
CREATE DATABASE MySchool
ON  PRIMARY 
(
 NAME='MySchool_data',  --主数据文件的逻辑名称
 FILENAME='D:\project\MySchool_data.mdf',  --主数据文件的物理名称
 SIZE=3mb,  --主数据文件的初始大小
 MAXSIZE=100mb,  --主数据文件增长的最大值
 FILEGROWTH=15%   --主数据文件的增长率
)
LOG ON
(
  NAME='MySchool_log',
  FILENAME='D:\project\MySchool_log.ldf',
  SIZE=3mb,
  MAXSIZE=20mb,  --日志文件增长的最大值
  FILEGROWTH=1mb
)

GO
USE [MySchool]
GO
/****** Object:  Table [dbo].[Admin]    Script Date: 09/07/2015 14:44:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Admin](
	[LoginId] [nvarchar](50) NOT NULL,
	[LoginPwd] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Admin_1] PRIMARY KEY CLUSTERED 
(
	[LoginId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[Admin] ([LoginId], [LoginPwd]) VALUES (N'jbit', N'bdqn')
/****** Object:  Table [dbo].[Grade]    Script Date: 09/07/2015 14:44:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Grade](
	[GradeId] [int] IDENTITY(1,1) NOT NULL,
	[GradeName] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Grade] PRIMARY KEY CLUSTERED 
(
	[GradeId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Grade] ON
INSERT [dbo].[Grade] ([GradeId], [GradeName]) VALUES (1, N'S1')
INSERT [dbo].[Grade] ([GradeId], [GradeName]) VALUES (2, N'S2')
INSERT [dbo].[Grade] ([GradeId], [GradeName]) VALUES (4, N'Y2')
SET IDENTITY_INSERT [dbo].[Grade] OFF
/****** Object:  Table [dbo].[Teacher]    Script Date: 09/07/2015 14:44:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Teacher](
	[TeacherID] [int] IDENTITY(1,1) NOT NULL,
	[TeacherName] [nvarchar](30) NOT NULL,
	[Gender] [nchar](1) NOT NULL,
	[BirthDay] [char](10) NOT NULL,
 CONSTRAINT [PK__teacher__EDF259444D94879B] PRIMARY KEY CLUSTERED 
(
	[TeacherID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[Teacher] ON
INSERT [dbo].[Teacher] ([TeacherID], [TeacherName], [Gender], [BirthDay]) VALUES (1, N'李楠', N'女', N'1984-09-09')
INSERT [dbo].[Teacher] ([TeacherID], [TeacherName], [Gender], [BirthDay]) VALUES (2, N'李至', N'女', N'1984-09-09')
INSERT [dbo].[Teacher] ([TeacherID], [TeacherName], [Gender], [BirthDay]) VALUES (3, N'王楠', N'女', N'1984-09-09')
INSERT [dbo].[Teacher] ([TeacherID], [TeacherName], [Gender], [BirthDay]) VALUES (4, N'王强', N'男', N'1984-09-09')
INSERT [dbo].[Teacher] ([TeacherID], [TeacherName], [Gender], [BirthDay]) VALUES (5, N'张楠', N'女', N'1984-09-09')
INSERT [dbo].[Teacher] ([TeacherID], [TeacherName], [Gender], [BirthDay]) VALUES (6, N'章波', N'男', N'1984-09-09')
SET IDENTITY_INSERT [dbo].[Teacher] OFF
/****** Object:  Table [dbo].[Subject]    Script Date: 09/07/2015 14:44:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Subject](
	[SubjectId] [int] IDENTITY(1,1) NOT NULL,
	[SubjectName] [nchar](10) NOT NULL,
	[ClassHour] [int] NULL,
	[GradeId] [int] NOT NULL,
 CONSTRAINT [PK_Subject] PRIMARY KEY CLUSTERED 
(
	[SubjectId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Subject] ON
INSERT [dbo].[Subject] ([SubjectId], [SubjectName], [ClassHour], [GradeId]) VALUES (1, N'C# OOP    ', 78, 2)
INSERT [dbo].[Subject] ([SubjectId], [SubjectName], [ClassHour], [GradeId]) VALUES (2, N'Java OOP  ', 67, 2)
INSERT [dbo].[Subject] ([SubjectId], [SubjectName], [ClassHour], [GradeId]) VALUES (3, N'C# 基础     ', 78, 1)
SET IDENTITY_INSERT [dbo].[Subject] OFF
/****** Object:  Table [dbo].[Student]    Script Date: 09/07/2015 14:44:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Student](
	[StudentNo] [int] IDENTITY(1000,1) NOT NULL,
	[LoginPwd] [nvarchar](50) NOT NULL,
	[StudentName] [nvarchar](50) NOT NULL,
	[Gender] [nchar](1) NOT NULL,
	[GradeId] [int] NOT NULL,
	[Phone] [nvarchar](255) NULL,
	[Address] [nvarchar](255) NULL,
	[Birthday] [datetime] NOT NULL,
	[Email] [nvarchar](50) NULL,
 CONSTRAINT [PK_Student] PRIMARY KEY CLUSTERED 
(
	[StudentNo] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Student] ON
INSERT [dbo].[Student] ([StudentNo], [LoginPwd], [StudentName], [Gender], [GradeId], [Phone], [Address], [Birthday], [Email]) VALUES (23214, N'0000', N'张无忌', N'男', 2, N'62345645', N'上海浦东大道', CAST(0x000089AD00000000 AS DateTime), N'')
INSERT [dbo].[Student] ([StudentNo], [LoginPwd], [StudentName], [Gender], [GradeId], [Phone], [Address], [Birthday], [Email]) VALUES (23221, N'0000', N'刘玲', N'女', 1, NULL, N'北京海淀区成府路', CAST(0x0000834200000000 AS DateTime), NULL)
INSERT [dbo].[Student] ([StudentNo], [LoginPwd], [StudentName], [Gender], [GradeId], [Phone], [Address], [Birthday], [Email]) VALUES (23225, N'123', N'百福美', N'女', 2, NULL, N'北京朝阳区', CAST(0x000087E500000000 AS DateTime), NULL)
INSERT [dbo].[Student] ([StudentNo], [LoginPwd], [StudentName], [Gender], [GradeId], [Phone], [Address], [Birthday], [Email]) VALUES (23229, N'123456', N'张立', N'男', 1, N'13634567688', N'北京丰台区', CAST(0x00008A1400000000 AS DateTime), N'zhuli@hotmail.com')
INSERT [dbo].[Student] ([StudentNo], [LoginPwd], [StudentName], [Gender], [GradeId], [Phone], [Address], [Birthday], [Email]) VALUES (23230, N'123', N'姚云', N'男', 1, NULL, NULL, CAST(0x0000839E00000000 AS DateTime), NULL)
INSERT [dbo].[Student] ([StudentNo], [LoginPwd], [StudentName], [Gender], [GradeId], [Phone], [Address], [Birthday], [Email]) VALUES (23231, N'123', N'姚远', N'男', 1, NULL, NULL, CAST(0x0000839E00000000 AS DateTime), NULL)
INSERT [dbo].[Student] ([StudentNo], [LoginPwd], [StudentName], [Gender], [GradeId], [Phone], [Address], [Birthday], [Email]) VALUES (23236, N'123', N'姚远', N'男', 4, NULL, NULL, CAST(0x0000839E00000000 AS DateTime), NULL)
SET IDENTITY_INSERT [dbo].[Student] OFF
/****** Object:  Table [dbo].[Result]    Script Date: 09/07/2015 14:44:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Result](
	[StudentNo] [int] NOT NULL,
	[SubjectId] [int] NOT NULL,
	[StudentResult] [int] NOT NULL,
	[ExamDate] [datetime] NOT NULL,
 CONSTRAINT [PK_Result] PRIMARY KEY CLUSTERED 
(
	[StudentNo] ASC,
	[SubjectId] ASC,
	[ExamDate] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[Result] ([StudentNo], [SubjectId], [StudentResult], [ExamDate]) VALUES (23214, 1, 80, CAST(0x00009C7F00000000 AS DateTime))
INSERT [dbo].[Result] ([StudentNo], [SubjectId], [StudentResult], [ExamDate]) VALUES (23214, 2, 50, CAST(0x00009C7F00000000 AS DateTime))
INSERT [dbo].[Result] ([StudentNo], [SubjectId], [StudentResult], [ExamDate]) VALUES (23214, 2, 70, CAST(0x00009C8200000000 AS DateTime))
INSERT [dbo].[Result] ([StudentNo], [SubjectId], [StudentResult], [ExamDate]) VALUES (23221, 1, 68, CAST(0x00009C7F00000000 AS DateTime))
INSERT [dbo].[Result] ([StudentNo], [SubjectId], [StudentResult], [ExamDate]) VALUES (23221, 2, 85, CAST(0x00009C8200000000 AS DateTime))
/****** Object:  StoredProcedure [dbo].[GetStudents]    Script Date: 09/07/2015 14:44:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create proc [dbo].[GetStudents]
@gender nvarchar(1)
as
select * from Student where Gender=@gender
GO
/****** Object:  Default [DF_Student_Gender]    Script Date: 09/07/2015 14:44:24 ******/
ALTER TABLE [dbo].[Student] ADD  CONSTRAINT [DF_Student_Gender]  DEFAULT ((1)) FOR [Gender]
GO
/****** Object:  Default [DF_Student_GradeId]    Script Date: 09/07/2015 14:44:24 ******/
ALTER TABLE [dbo].[Student] ADD  CONSTRAINT [DF_Student_GradeId]  DEFAULT ((1)) FOR [GradeId]
GO
/****** Object:  ForeignKey [FK_Result_Student]    Script Date: 09/07/2015 14:44:24 ******/
ALTER TABLE [dbo].[Result]  WITH CHECK ADD  CONSTRAINT [FK_Result_Student] FOREIGN KEY([StudentNo])
REFERENCES [dbo].[Student] ([StudentNo])
GO
ALTER TABLE [dbo].[Result] CHECK CONSTRAINT [FK_Result_Student]
GO
/****** Object:  ForeignKey [FK_Result_Subject]    Script Date: 09/07/2015 14:44:24 ******/
ALTER TABLE [dbo].[Result]  WITH CHECK ADD  CONSTRAINT [FK_Result_Subject] FOREIGN KEY([SubjectId])
REFERENCES [dbo].[Subject] ([SubjectId])
GO
ALTER TABLE [dbo].[Result] CHECK CONSTRAINT [FK_Result_Subject]
GO
/****** Object:  ForeignKey [FK_Student_Grade]    Script Date: 09/07/2015 14:44:24 ******/
ALTER TABLE [dbo].[Student]  WITH CHECK ADD  CONSTRAINT [FK_Student_Grade] FOREIGN KEY([GradeId])
REFERENCES [dbo].[Grade] ([GradeId])
GO
ALTER TABLE [dbo].[Student] CHECK CONSTRAINT [FK_Student_Grade]
GO
/****** Object:  ForeignKey [FK_Subject_Grade]    Script Date: 09/07/2015 14:44:24 ******/
ALTER TABLE [dbo].[Subject]  WITH CHECK ADD  CONSTRAINT [FK_Subject_Grade] FOREIGN KEY([GradeId])
REFERENCES [dbo].[Grade] ([GradeId])
GO
ALTER TABLE [dbo].[Subject] CHECK CONSTRAINT [FK_Subject_Grade]
GO
