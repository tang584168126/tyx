USE [master]
GO
/****** Object:  Database [FocusBook]    Script Date: 10/09/2015 14:39:32 ******/
CREATE DATABASE [FocusBook] ON  PRIMARY 
( NAME = N'FocusBook', FILENAME = N'E:\代码\第三期\毕业项目\FocusBook.mdf' , SIZE = 5120KB , MAXSIZE = 102400KB , FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'FocusBook_log', FILENAME = N'E:\代码\第三期\毕业项目\FocusBook_log.ldf' , SIZE = 1024KB , MAXSIZE = 102400KB , FILEGROWTH = 1024KB )
GO
ALTER DATABASE [FocusBook] SET COMPATIBILITY_LEVEL = 100
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [FocusBook].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [FocusBook] SET ANSI_NULL_DEFAULT OFF
GO
ALTER DATABASE [FocusBook] SET ANSI_NULLS OFF
GO
ALTER DATABASE [FocusBook] SET ANSI_PADDING OFF
GO
ALTER DATABASE [FocusBook] SET ANSI_WARNINGS OFF
GO
ALTER DATABASE [FocusBook] SET ARITHABORT OFF
GO
ALTER DATABASE [FocusBook] SET AUTO_CLOSE OFF
GO
ALTER DATABASE [FocusBook] SET AUTO_CREATE_STATISTICS ON
GO
ALTER DATABASE [FocusBook] SET AUTO_SHRINK OFF
GO
ALTER DATABASE [FocusBook] SET AUTO_UPDATE_STATISTICS ON
GO
ALTER DATABASE [FocusBook] SET CURSOR_CLOSE_ON_COMMIT OFF
GO
ALTER DATABASE [FocusBook] SET CURSOR_DEFAULT  GLOBAL
GO
ALTER DATABASE [FocusBook] SET CONCAT_NULL_YIELDS_NULL OFF
GO
ALTER DATABASE [FocusBook] SET NUMERIC_ROUNDABORT OFF
GO
ALTER DATABASE [FocusBook] SET QUOTED_IDENTIFIER OFF
GO
ALTER DATABASE [FocusBook] SET RECURSIVE_TRIGGERS OFF
GO
ALTER DATABASE [FocusBook] SET  DISABLE_BROKER
GO
ALTER DATABASE [FocusBook] SET AUTO_UPDATE_STATISTICS_ASYNC OFF
GO
ALTER DATABASE [FocusBook] SET DATE_CORRELATION_OPTIMIZATION OFF
GO
ALTER DATABASE [FocusBook] SET TRUSTWORTHY OFF
GO
ALTER DATABASE [FocusBook] SET ALLOW_SNAPSHOT_ISOLATION OFF
GO
ALTER DATABASE [FocusBook] SET PARAMETERIZATION SIMPLE
GO
ALTER DATABASE [FocusBook] SET READ_COMMITTED_SNAPSHOT OFF
GO
ALTER DATABASE [FocusBook] SET HONOR_BROKER_PRIORITY OFF
GO
ALTER DATABASE [FocusBook] SET  READ_WRITE
GO
ALTER DATABASE [FocusBook] SET RECOVERY FULL
GO
ALTER DATABASE [FocusBook] SET  MULTI_USER
GO
ALTER DATABASE [FocusBook] SET PAGE_VERIFY CHECKSUM
GO
ALTER DATABASE [FocusBook] SET DB_CHAINING OFF
GO
EXEC sys.sp_db_vardecimal_storage_format N'FocusBook', N'ON'
GO
USE [FocusBook]
GO
/****** Object:  ForeignKey [FK_UsersInfo_UsersRole_Id]    Script Date: 10/09/2015 14:39:35 ******/
ALTER TABLE [dbo].[UsersInfo] DROP CONSTRAINT [FK_UsersInfo_UsersRole_Id]
GO
/****** Object:  ForeignKey [FK_TotalBookTypes_BookTypes_TypeId]    Script Date: 10/09/2015 14:39:35 ******/
ALTER TABLE [dbo].[TotalBookTypes] DROP CONSTRAINT [FK_TotalBookTypes_BookTypes_TypeId]
GO
/****** Object:  ForeignKey [FK_BookBasicInfo_BookTypes_TypeId]    Script Date: 10/09/2015 14:39:35 ******/
ALTER TABLE [dbo].[BookBasicInfo] DROP CONSTRAINT [FK_BookBasicInfo_BookTypes_TypeId]
GO
/****** Object:  ForeignKey [FK_EntityBookInfo_BookBasicInfo_BasicId]    Script Date: 10/09/2015 14:39:35 ******/
ALTER TABLE [dbo].[EntityBookInfo] DROP CONSTRAINT [FK_EntityBookInfo_BookBasicInfo_BasicId]
GO
/****** Object:  ForeignKey [FK_EntityBookInfo_Publishers_Id]    Script Date: 10/09/2015 14:39:35 ******/
ALTER TABLE [dbo].[EntityBookInfo] DROP CONSTRAINT [FK_EntityBookInfo_Publishers_Id]
GO
/****** Object:  ForeignKey [FK_BookInfo_UsersInfo_UserId]    Script Date: 10/09/2015 14:39:35 ******/
ALTER TABLE [dbo].[EBookInfo] DROP CONSTRAINT [FK_BookInfo_UsersInfo_UserId]
GO
/****** Object:  ForeignKey [FK_EBookInfo_BookBasicInfo_BasicId]    Script Date: 10/09/2015 14:39:35 ******/
ALTER TABLE [dbo].[EBookInfo] DROP CONSTRAINT [FK_EBookInfo_BookBasicInfo_BasicId]
GO
/****** Object:  ForeignKey [FK_UserBuyer_UsersInfo_UserId]    Script Date: 10/09/2015 14:39:35 ******/
ALTER TABLE [dbo].[UserBuyer] DROP CONSTRAINT [FK_UserBuyer_UsersInfo_UserId]
GO
/****** Object:  ForeignKey [FK_UserProfit_UsersInfo_UserId]    Script Date: 10/09/2015 14:39:35 ******/
ALTER TABLE [dbo].[UserProfit] DROP CONSTRAINT [FK_UserProfit_UsersInfo_UserId]
GO
/****** Object:  ForeignKey [FK_UserHouse_EBookInfo_BookId]    Script Date: 10/09/2015 14:39:35 ******/
ALTER TABLE [dbo].[UserHouse] DROP CONSTRAINT [FK_UserHouse_EBookInfo_BookId]
GO
/****** Object:  ForeignKey [FK_UserHouse_UsersInfo_UserId]    Script Date: 10/09/2015 14:39:35 ******/
ALTER TABLE [dbo].[UserHouse] DROP CONSTRAINT [FK_UserHouse_UsersInfo_UserId]
GO
/****** Object:  ForeignKey [FK_UserComments_EBookInfo_EBookId]    Script Date: 10/09/2015 14:39:35 ******/
ALTER TABLE [dbo].[UserComments] DROP CONSTRAINT [FK_UserComments_EBookInfo_EBookId]
GO
/****** Object:  ForeignKey [FK_UserComments_EntityBookInfo_BookId]    Script Date: 10/09/2015 14:39:35 ******/
ALTER TABLE [dbo].[UserComments] DROP CONSTRAINT [FK_UserComments_EntityBookInfo_BookId]
GO
/****** Object:  ForeignKey [FK_UserComments_UsersInfo_UserId]    Script Date: 10/09/2015 14:39:35 ******/
ALTER TABLE [dbo].[UserComments] DROP CONSTRAINT [FK_UserComments_UsersInfo_UserId]
GO
/****** Object:  ForeignKey [FK_EProfit_EBookInfo_EBookId]    Script Date: 10/09/2015 14:39:35 ******/
ALTER TABLE [dbo].[EProfit] DROP CONSTRAINT [FK_EProfit_EBookInfo_EBookId]
GO
/****** Object:  ForeignKey [FK_EProfit_UsersInfo_UserId]    Script Date: 10/09/2015 14:39:35 ******/
ALTER TABLE [dbo].[EProfit] DROP CONSTRAINT [FK_EProfit_UsersInfo_UserId]
GO
/****** Object:  ForeignKey [FK_EntityProfit_EntityBookInfo_BookId]    Script Date: 10/09/2015 14:39:35 ******/
ALTER TABLE [dbo].[EntityProfit] DROP CONSTRAINT [FK_EntityProfit_EntityBookInfo_BookId]
GO
/****** Object:  ForeignKey [FK_EntityProfit_UsersInfo_UserId]    Script Date: 10/09/2015 14:39:35 ******/
ALTER TABLE [dbo].[EntityProfit] DROP CONSTRAINT [FK_EntityProfit_UsersInfo_UserId]
GO
/****** Object:  ForeignKey [FK_UserScores_EBookInfo_EBookId]    Script Date: 10/09/2015 14:39:35 ******/
ALTER TABLE [dbo].[UserScores] DROP CONSTRAINT [FK_UserScores_EBookInfo_EBookId]
GO
/****** Object:  ForeignKey [FK_UserScores_EntityBookInfo_BookId]    Script Date: 10/09/2015 14:39:35 ******/
ALTER TABLE [dbo].[UserScores] DROP CONSTRAINT [FK_UserScores_EntityBookInfo_BookId]
GO
/****** Object:  ForeignKey [FK_PlayManages_EBookInfo_EBookId]    Script Date: 10/09/2015 14:39:35 ******/
ALTER TABLE [dbo].[PlayManages] DROP CONSTRAINT [FK_PlayManages_EBookInfo_EBookId]
GO
/****** Object:  ForeignKey [FK_PlayManages_UsersInfo_UserId]    Script Date: 10/09/2015 14:39:35 ******/
ALTER TABLE [dbo].[PlayManages] DROP CONSTRAINT [FK_PlayManages_UsersInfo_UserId]
GO
/****** Object:  ForeignKey [FK_Orders_EntityBookInfo_BookId]    Script Date: 10/09/2015 14:39:35 ******/
ALTER TABLE [dbo].[Orders] DROP CONSTRAINT [FK_Orders_EntityBookInfo_BookId]
GO
/****** Object:  ForeignKey [FK_Orders_UsersInfo_UserId]    Script Date: 10/09/2015 14:39:35 ******/
ALTER TABLE [dbo].[Orders] DROP CONSTRAINT [FK_Orders_UsersInfo_UserId]
GO
/****** Object:  ForeignKey [FK_EAuthor_EBookInfo_EBookId]    Script Date: 10/09/2015 14:39:35 ******/
ALTER TABLE [dbo].[EAuthor] DROP CONSTRAINT [FK_EAuthor_EBookInfo_EBookId]
GO
/****** Object:  ForeignKey [FK_EAuthor_UsersInfo_UserId]    Script Date: 10/09/2015 14:39:35 ******/
ALTER TABLE [dbo].[EAuthor] DROP CONSTRAINT [FK_EAuthor_UsersInfo_UserId]
GO
/****** Object:  ForeignKey [FK_ChapterUrl_EBookInfo_EBookId]    Script Date: 10/09/2015 14:39:35 ******/
ALTER TABLE [dbo].[ChapterUrl] DROP CONSTRAINT [FK_ChapterUrl_EBookInfo_EBookId]
GO
/****** Object:  Table [dbo].[ChapterUrl]    Script Date: 10/09/2015 14:39:35 ******/
ALTER TABLE [dbo].[ChapterUrl] DROP CONSTRAINT [FK_ChapterUrl_EBookInfo_EBookId]
GO
DROP TABLE [dbo].[ChapterUrl]
GO
/****** Object:  Table [dbo].[EAuthor]    Script Date: 10/09/2015 14:39:35 ******/
ALTER TABLE [dbo].[EAuthor] DROP CONSTRAINT [FK_EAuthor_EBookInfo_EBookId]
GO
ALTER TABLE [dbo].[EAuthor] DROP CONSTRAINT [FK_EAuthor_UsersInfo_UserId]
GO
ALTER TABLE [dbo].[EAuthor] DROP CONSTRAINT [DF_EAuthor_Popularity]
GO
DROP TABLE [dbo].[EAuthor]
GO
/****** Object:  Table [dbo].[Orders]    Script Date: 10/09/2015 14:39:35 ******/
ALTER TABLE [dbo].[Orders] DROP CONSTRAINT [FK_Orders_EntityBookInfo_BookId]
GO
ALTER TABLE [dbo].[Orders] DROP CONSTRAINT [FK_Orders_UsersInfo_UserId]
GO
DROP TABLE [dbo].[Orders]
GO
/****** Object:  Table [dbo].[PlayManages]    Script Date: 10/09/2015 14:39:35 ******/
ALTER TABLE [dbo].[PlayManages] DROP CONSTRAINT [FK_PlayManages_EBookInfo_EBookId]
GO
ALTER TABLE [dbo].[PlayManages] DROP CONSTRAINT [FK_PlayManages_UsersInfo_UserId]
GO
DROP TABLE [dbo].[PlayManages]
GO
/****** Object:  Table [dbo].[UserScores]    Script Date: 10/09/2015 14:39:35 ******/
ALTER TABLE [dbo].[UserScores] DROP CONSTRAINT [FK_UserScores_EBookInfo_EBookId]
GO
ALTER TABLE [dbo].[UserScores] DROP CONSTRAINT [FK_UserScores_EntityBookInfo_BookId]
GO
DROP TABLE [dbo].[UserScores]
GO
/****** Object:  Table [dbo].[EntityProfit]    Script Date: 10/09/2015 14:39:35 ******/
ALTER TABLE [dbo].[EntityProfit] DROP CONSTRAINT [FK_EntityProfit_EntityBookInfo_BookId]
GO
ALTER TABLE [dbo].[EntityProfit] DROP CONSTRAINT [FK_EntityProfit_UsersInfo_UserId]
GO
DROP TABLE [dbo].[EntityProfit]
GO
/****** Object:  Table [dbo].[EProfit]    Script Date: 10/09/2015 14:39:35 ******/
ALTER TABLE [dbo].[EProfit] DROP CONSTRAINT [FK_EProfit_EBookInfo_EBookId]
GO
ALTER TABLE [dbo].[EProfit] DROP CONSTRAINT [FK_EProfit_UsersInfo_UserId]
GO
DROP TABLE [dbo].[EProfit]
GO
/****** Object:  Table [dbo].[UserComments]    Script Date: 10/09/2015 14:39:35 ******/
ALTER TABLE [dbo].[UserComments] DROP CONSTRAINT [FK_UserComments_EBookInfo_EBookId]
GO
ALTER TABLE [dbo].[UserComments] DROP CONSTRAINT [FK_UserComments_EntityBookInfo_BookId]
GO
ALTER TABLE [dbo].[UserComments] DROP CONSTRAINT [FK_UserComments_UsersInfo_UserId]
GO
DROP TABLE [dbo].[UserComments]
GO
/****** Object:  Table [dbo].[UserHouse]    Script Date: 10/09/2015 14:39:35 ******/
ALTER TABLE [dbo].[UserHouse] DROP CONSTRAINT [FK_UserHouse_EBookInfo_BookId]
GO
ALTER TABLE [dbo].[UserHouse] DROP CONSTRAINT [FK_UserHouse_UsersInfo_UserId]
GO
DROP TABLE [dbo].[UserHouse]
GO
/****** Object:  Table [dbo].[UserProfit]    Script Date: 10/09/2015 14:39:35 ******/
ALTER TABLE [dbo].[UserProfit] DROP CONSTRAINT [FK_UserProfit_UsersInfo_UserId]
GO
ALTER TABLE [dbo].[UserProfit] DROP CONSTRAINT [DF_UserProfit_AddMoney]
GO
DROP TABLE [dbo].[UserProfit]
GO
/****** Object:  Table [dbo].[UserBuyer]    Script Date: 10/09/2015 14:39:35 ******/
ALTER TABLE [dbo].[UserBuyer] DROP CONSTRAINT [FK_UserBuyer_UsersInfo_UserId]
GO
DROP TABLE [dbo].[UserBuyer]
GO
/****** Object:  Table [dbo].[EBookInfo]    Script Date: 10/09/2015 14:39:35 ******/
ALTER TABLE [dbo].[EBookInfo] DROP CONSTRAINT [FK_BookInfo_UsersInfo_UserId]
GO
ALTER TABLE [dbo].[EBookInfo] DROP CONSTRAINT [FK_EBookInfo_BookBasicInfo_BasicId]
GO
ALTER TABLE [dbo].[EBookInfo] DROP CONSTRAINT [DF_EBookInfo_UpDateTime]
GO
ALTER TABLE [dbo].[EBookInfo] DROP CONSTRAINT [DF_BookInfo_Ticket]
GO
DROP TABLE [dbo].[EBookInfo]
GO
/****** Object:  Table [dbo].[EntityBookInfo]    Script Date: 10/09/2015 14:39:35 ******/
ALTER TABLE [dbo].[EntityBookInfo] DROP CONSTRAINT [FK_EntityBookInfo_BookBasicInfo_BasicId]
GO
ALTER TABLE [dbo].[EntityBookInfo] DROP CONSTRAINT [FK_EntityBookInfo_Publishers_Id]
GO
DROP TABLE [dbo].[EntityBookInfo]
GO
/****** Object:  Table [dbo].[BookBasicInfo]    Script Date: 10/09/2015 14:39:35 ******/
ALTER TABLE [dbo].[BookBasicInfo] DROP CONSTRAINT [FK_BookBasicInfo_BookTypes_TypeId]
GO
ALTER TABLE [dbo].[BookBasicInfo] DROP CONSTRAINT [DF_BookBasicInfo_CoverImage]
GO
DROP TABLE [dbo].[BookBasicInfo]
GO
/****** Object:  Table [dbo].[TotalBookTypes]    Script Date: 10/09/2015 14:39:35 ******/
ALTER TABLE [dbo].[TotalBookTypes] DROP CONSTRAINT [FK_TotalBookTypes_BookTypes_TypeId]
GO
DROP TABLE [dbo].[TotalBookTypes]
GO
/****** Object:  Table [dbo].[UsersInfo]    Script Date: 10/09/2015 14:39:35 ******/
ALTER TABLE [dbo].[UsersInfo] DROP CONSTRAINT [FK_UsersInfo_UsersRole_Id]
GO
ALTER TABLE [dbo].[UsersInfo] DROP CONSTRAINT [DF_UsersInfo_Integral]
GO
ALTER TABLE [dbo].[UsersInfo] DROP CONSTRAINT [DF_UsersInfo_RegisterTime]
GO
DROP TABLE [dbo].[UsersInfo]
GO
/****** Object:  Table [dbo].[UsersRole]    Script Date: 10/09/2015 14:39:34 ******/
DROP TABLE [dbo].[UsersRole]
GO
/****** Object:  Table [dbo].[FocusAdmin]    Script Date: 10/09/2015 14:39:34 ******/
DROP TABLE [dbo].[FocusAdmin]
GO
/****** Object:  Table [dbo].[BookTypes]    Script Date: 10/09/2015 14:39:34 ******/
DROP TABLE [dbo].[BookTypes]
GO
/****** Object:  Table [dbo].[Publishers]    Script Date: 10/09/2015 14:39:34 ******/
DROP TABLE [dbo].[Publishers]
GO
/****** Object:  Table [dbo].[Publishers]    Script Date: 10/09/2015 14:39:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Publishers](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Publishers] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Publishers] ON
INSERT [dbo].[Publishers] ([Id], [Name]) VALUES (1, N'２１世纪出版社')
INSERT [dbo].[Publishers] ([Id], [Name]) VALUES (2, N'安徽文艺出版社')
INSERT [dbo].[Publishers] ([Id], [Name]) VALUES (3, N'北方交通大学出版社')
INSERT [dbo].[Publishers] ([Id], [Name]) VALUES (4, N'北京大学出版社')
INSERT [dbo].[Publishers] ([Id], [Name]) VALUES (5, N'北京航空航天大学出版社')
INSERT [dbo].[Publishers] ([Id], [Name]) VALUES (6, N'北京航天航空大学出版社')
INSERT [dbo].[Publishers] ([Id], [Name]) VALUES (7, N'北京科海出版社')
INSERT [dbo].[Publishers] ([Id], [Name]) VALUES (8, N'北京科海电子出版社')
INSERT [dbo].[Publishers] ([Id], [Name]) VALUES (9, N'北京科海集团公司')
INSERT [dbo].[Publishers] ([Id], [Name]) VALUES (10, N'北京理工大学出版社')
INSERT [dbo].[Publishers] ([Id], [Name]) VALUES (11, N'北京师范大学出版社')
INSERT [dbo].[Publishers] ([Id], [Name]) VALUES (12, N'北京伟地电子出版社')
INSERT [dbo].[Publishers] ([Id], [Name]) VALUES (13, N'北京希望电子出版社')
INSERT [dbo].[Publishers] ([Id], [Name]) VALUES (14, N'北京邮电学院出版社')
INSERT [dbo].[Publishers] ([Id], [Name]) VALUES (15, N'兵器工业出版社')
INSERT [dbo].[Publishers] ([Id], [Name]) VALUES (16, N'大连理工大学出版社')
INSERT [dbo].[Publishers] ([Id], [Name]) VALUES (17, N'电子工业出版社')
INSERT [dbo].[Publishers] ([Id], [Name]) VALUES (18, N'东北财经大学出版社')
INSERT [dbo].[Publishers] ([Id], [Name]) VALUES (19, N'东方出版社')
INSERT [dbo].[Publishers] ([Id], [Name]) VALUES (20, N'东南大学出版社')
INSERT [dbo].[Publishers] ([Id], [Name]) VALUES (21, N'复旦大学出版社')
INSERT [dbo].[Publishers] ([Id], [Name]) VALUES (22, N'高等教育出版社')
INSERT [dbo].[Publishers] ([Id], [Name]) VALUES (23, N'贵州民族出版社')
INSERT [dbo].[Publishers] ([Id], [Name]) VALUES (24, N'国防工业出版社')
INSERT [dbo].[Publishers] ([Id], [Name]) VALUES (25, N'海洋出版社')
INSERT [dbo].[Publishers] ([Id], [Name]) VALUES (26, N'航空工业出版社')
INSERT [dbo].[Publishers] ([Id], [Name]) VALUES (27, N'华东理工大学出版社')
INSERT [dbo].[Publishers] ([Id], [Name]) VALUES (28, N'华东师范大学出版社')
INSERT [dbo].[Publishers] ([Id], [Name]) VALUES (29, N'华南理工大学出版社')
INSERT [dbo].[Publishers] ([Id], [Name]) VALUES (30, N'华夏出版社')
INSERT [dbo].[Publishers] ([Id], [Name]) VALUES (31, N'华中科技大学出版社')
INSERT [dbo].[Publishers] ([Id], [Name]) VALUES (32, N'化学工业出版社')
INSERT [dbo].[Publishers] ([Id], [Name]) VALUES (33, N'黄河水利出版社')
INSERT [dbo].[Publishers] ([Id], [Name]) VALUES (34, N'机械工业出版社')
INSERT [dbo].[Publishers] ([Id], [Name]) VALUES (35, N'九州出版社')
INSERT [dbo].[Publishers] ([Id], [Name]) VALUES (36, N'科学出版社')
INSERT [dbo].[Publishers] ([Id], [Name]) VALUES (37, N'科学普及出版社')
INSERT [dbo].[Publishers] ([Id], [Name]) VALUES (38, N'辽宁科学技术出版社')
INSERT [dbo].[Publishers] ([Id], [Name]) VALUES (39, N'内蒙古大学出版社')
INSERT [dbo].[Publishers] ([Id], [Name]) VALUES (40, N'南开大学出版社')
INSERT [dbo].[Publishers] ([Id], [Name]) VALUES (41, N'农村读物出版社')
INSERT [dbo].[Publishers] ([Id], [Name]) VALUES (42, N'浦东电子')
INSERT [dbo].[Publishers] ([Id], [Name]) VALUES (43, N'清华大学')
INSERT [dbo].[Publishers] ([Id], [Name]) VALUES (44, N'清华大学出版社')
INSERT [dbo].[Publishers] ([Id], [Name]) VALUES (45, N'清华大学出版社；北京交通大学出版社')
INSERT [dbo].[Publishers] ([Id], [Name]) VALUES (46, N'人民大学出版社')
INSERT [dbo].[Publishers] ([Id], [Name]) VALUES (47, N'人民交通出版社')
INSERT [dbo].[Publishers] ([Id], [Name]) VALUES (48, N'人民文学出版社')
INSERT [dbo].[Publishers] ([Id], [Name]) VALUES (49, N'人民邮电出版社')
INSERT [dbo].[Publishers] ([Id], [Name]) VALUES (50, N'三秦出版社')
INSERT [dbo].[Publishers] ([Id], [Name]) VALUES (51, N'陕西科学技术出版社')
INSERT [dbo].[Publishers] ([Id], [Name]) VALUES (52, N'上海交通大学出版社')
INSERT [dbo].[Publishers] ([Id], [Name]) VALUES (53, N'上海科学普及出版社')
INSERT [dbo].[Publishers] ([Id], [Name]) VALUES (54, N'世界图书出版公司')
INSERT [dbo].[Publishers] ([Id], [Name]) VALUES (55, N'水利电力出版社')
INSERT [dbo].[Publishers] ([Id], [Name]) VALUES (56, N'水利水电出版社')
INSERT [dbo].[Publishers] ([Id], [Name]) VALUES (57, N'天津人民出版社')
INSERT [dbo].[Publishers] ([Id], [Name]) VALUES (58, N'未来出版社')
INSERT [dbo].[Publishers] ([Id], [Name]) VALUES (59, N'未知')
INSERT [dbo].[Publishers] ([Id], [Name]) VALUES (60, N'武汉理工大学出版社')
INSERT [dbo].[Publishers] ([Id], [Name]) VALUES (61, N'西安电子科技大学出版社')
INSERT [dbo].[Publishers] ([Id], [Name]) VALUES (62, N'西安交通大学出版社')
INSERT [dbo].[Publishers] ([Id], [Name]) VALUES (63, N'西北工业大学出版社')
INSERT [dbo].[Publishers] ([Id], [Name]) VALUES (64, N'西南师范大学出版社')
INSERT [dbo].[Publishers] ([Id], [Name]) VALUES (65, N'希望电脑')
INSERT [dbo].[Publishers] ([Id], [Name]) VALUES (66, N'新时代出版社')
INSERT [dbo].[Publishers] ([Id], [Name]) VALUES (67, N'冶金工业出版社')
INSERT [dbo].[Publishers] ([Id], [Name]) VALUES (68, N'浙江大学出版社')
INSERT [dbo].[Publishers] ([Id], [Name]) VALUES (69, N'中国电力出版社')
INSERT [dbo].[Publishers] ([Id], [Name]) VALUES (70, N'中国建筑工业出版社')
INSERT [dbo].[Publishers] ([Id], [Name]) VALUES (71, N'中国劳动出版社')
INSERT [dbo].[Publishers] ([Id], [Name]) VALUES (72, N'中国青年出版社')
INSERT [dbo].[Publishers] ([Id], [Name]) VALUES (73, N'中国时代经济出版社')
INSERT [dbo].[Publishers] ([Id], [Name]) VALUES (74, N'中国水利水电出版社')
INSERT [dbo].[Publishers] ([Id], [Name]) VALUES (75, N'中国铁道出版社')
INSERT [dbo].[Publishers] ([Id], [Name]) VALUES (76, N'中国宇航出版社')
INSERT [dbo].[Publishers] ([Id], [Name]) VALUES (77, N'中华工商联合出版社')
INSERT [dbo].[Publishers] ([Id], [Name]) VALUES (78, N'中山大学出版社')
INSERT [dbo].[Publishers] ([Id], [Name]) VALUES (79, N'中央广播电视大学出版社')
INSERT [dbo].[Publishers] ([Id], [Name]) VALUES (80, N'重庆大学出版社')
SET IDENTITY_INSERT [dbo].[Publishers] OFF
/****** Object:  Table [dbo].[BookTypes]    Script Date: 10/09/2015 14:39:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BookTypes](
	[TypeId] [int] IDENTITY(1,1) NOT NULL,
	[TypeName] [nvarchar](30) NOT NULL,
 CONSTRAINT [PK_BookTypes] PRIMARY KEY CLUSTERED 
(
	[TypeId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[BookTypes] ON
INSERT [dbo].[BookTypes] ([TypeId], [TypeName]) VALUES (1, N'文艺')
INSERT [dbo].[BookTypes] ([TypeId], [TypeName]) VALUES (2, N'青春')
INSERT [dbo].[BookTypes] ([TypeId], [TypeName]) VALUES (3, N'童书')
INSERT [dbo].[BookTypes] ([TypeId], [TypeName]) VALUES (4, N'教育')
INSERT [dbo].[BookTypes] ([TypeId], [TypeName]) VALUES (5, N'生活')
INSERT [dbo].[BookTypes] ([TypeId], [TypeName]) VALUES (6, N'人文社会')
INSERT [dbo].[BookTypes] ([TypeId], [TypeName]) VALUES (7, N'经营')
INSERT [dbo].[BookTypes] ([TypeId], [TypeName]) VALUES (8, N'科技')
INSERT [dbo].[BookTypes] ([TypeId], [TypeName]) VALUES (9, N'励志/成功')
INSERT [dbo].[BookTypes] ([TypeId], [TypeName]) VALUES (10, N'工具书')
INSERT [dbo].[BookTypes] ([TypeId], [TypeName]) VALUES (11, N'小说')
INSERT [dbo].[BookTypes] ([TypeId], [TypeName]) VALUES (12, N'玄幻')
INSERT [dbo].[BookTypes] ([TypeId], [TypeName]) VALUES (13, N'都市')
INSERT [dbo].[BookTypes] ([TypeId], [TypeName]) VALUES (14, N'游戏')
INSERT [dbo].[BookTypes] ([TypeId], [TypeName]) VALUES (15, N'科幻')
INSERT [dbo].[BookTypes] ([TypeId], [TypeName]) VALUES (16, N'仙侠')
INSERT [dbo].[BookTypes] ([TypeId], [TypeName]) VALUES (17, N'奇幻')
INSERT [dbo].[BookTypes] ([TypeId], [TypeName]) VALUES (18, N'武侠')
INSERT [dbo].[BookTypes] ([TypeId], [TypeName]) VALUES (19, N'惊悚')
SET IDENTITY_INSERT [dbo].[BookTypes] OFF
/****** Object:  Table [dbo].[FocusAdmin]    Script Date: 10/09/2015 14:39:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[FocusAdmin](
	[AdminId] [int] IDENTITY(10000,1) NOT NULL,
	[AdminPassword] [nvarchar](20) NOT NULL,
	[AdminName] [nvarchar](20) NOT NULL,
 CONSTRAINT [PK_FocusAdmin] PRIMARY KEY CLUSTERED 
(
	[AdminId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[FocusAdmin] ON
INSERT [dbo].[FocusAdmin] ([AdminId], [AdminPassword], [AdminName]) VALUES (10000, N'123456', N'Admin')
SET IDENTITY_INSERT [dbo].[FocusAdmin] OFF
/****** Object:  Table [dbo].[UsersRole]    Script Date: 10/09/2015 14:39:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UsersRole](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](20) NOT NULL,
 CONSTRAINT [PK_UsersRole] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[UsersRole] ON
INSERT [dbo].[UsersRole] ([Id], [Name]) VALUES (1, N'VIP0')
INSERT [dbo].[UsersRole] ([Id], [Name]) VALUES (2, N'VIP1')
INSERT [dbo].[UsersRole] ([Id], [Name]) VALUES (3, N'VIP2')
INSERT [dbo].[UsersRole] ([Id], [Name]) VALUES (4, N'VIP3')
INSERT [dbo].[UsersRole] ([Id], [Name]) VALUES (5, N'VIP4')
INSERT [dbo].[UsersRole] ([Id], [Name]) VALUES (6, N'VIP5')
INSERT [dbo].[UsersRole] ([Id], [Name]) VALUES (7, N'管理员')
SET IDENTITY_INSERT [dbo].[UsersRole] OFF
/****** Object:  Table [dbo].[UsersInfo]    Script Date: 10/09/2015 14:39:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UsersInfo](
	[UserId] [int] IDENTITY(1,1) NOT NULL,
	[LoginId] [nvarchar](20) NOT NULL,
	[Password] [nvarchar](20) NOT NULL,
	[Integral] [int] NOT NULL CONSTRAINT [DF_UsersInfo_Integral]  DEFAULT ((100)),
	[Email] [nvarchar](24) NOT NULL,
	[RegisterTime] [datetime] NOT NULL CONSTRAINT [DF_UsersInfo_RegisterTime]  DEFAULT (getdate()),
	[NickName] [nvarchar](20) NOT NULL,
	[RealName] [nvarchar](20) NULL,
	[UserRoleId] [int] NOT NULL,
	[TicketCount] [int] NULL,
 CONSTRAINT [PK_UsersInfo] PRIMARY KEY CLUSTERED 
(
	[UserId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[UsersInfo] ON
INSERT [dbo].[UsersInfo] ([UserId], [LoginId], [Password], [Integral], [Email], [RegisterTime], [NickName], [RealName], [UserRoleId], [TicketCount]) VALUES (3, N'bobo', N'123456', 0, N'123456@163.com', CAST(0x0000A35F00F099C0 AS DateTime), N'酱油君', N'刘波', 2, 5)
INSERT [dbo].[UsersInfo] ([UserId], [LoginId], [Password], [Integral], [Email], [RegisterTime], [NickName], [RealName], [UserRoleId], [TicketCount]) VALUES (4, N'xihongshi', N'123456', 1243, N'12345678@qq.com', CAST(0x00009EDB00000000 AS DateTime), N'我吃西红柿', N'朱洪志', 6, 30)
INSERT [dbo].[UsersInfo] ([UserId], [LoginId], [Password], [Integral], [Email], [RegisterTime], [NickName], [RealName], [UserRoleId], [TicketCount]) VALUES (5, N'chendong', N'123456', 0, N'chendong@163.com', CAST(0x0000A52A0115302A AS DateTime), N'辰东', NULL, 1, NULL)
SET IDENTITY_INSERT [dbo].[UsersInfo] OFF
/****** Object:  Table [dbo].[TotalBookTypes]    Script Date: 10/09/2015 14:39:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TotalBookTypes](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[TypeId] [int] NOT NULL,
	[Name] [nvarchar](20) NOT NULL,
 CONSTRAINT [PK_TotalBookTypes] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[TotalBookTypes] ON
INSERT [dbo].[TotalBookTypes] ([Id], [TypeId], [Name]) VALUES (1, 12, N'异界大陆')
INSERT [dbo].[TotalBookTypes] ([Id], [TypeId], [Name]) VALUES (2, 12, N'东方玄幻')
INSERT [dbo].[TotalBookTypes] ([Id], [TypeId], [Name]) VALUES (3, 12, N'异界争霸')
INSERT [dbo].[TotalBookTypes] ([Id], [TypeId], [Name]) VALUES (4, 12, N'远古神话')
SET IDENTITY_INSERT [dbo].[TotalBookTypes] OFF
/****** Object:  Table [dbo].[BookBasicInfo]    Script Date: 10/09/2015 14:39:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BookBasicInfo](
	[BasicId] [int] IDENTITY(1,1) NOT NULL,
	[Title] [nvarchar](20) NOT NULL,
	[Content] [nvarchar](200) NOT NULL,
	[TypeId] [int] NOT NULL,
	[CoverImage] [nvarchar](20) NOT NULL CONSTRAINT [DF_BookBasicInfo_CoverImage]  DEFAULT (N'1.jpg'),
	[Score] [decimal](18, 1) NULL,
	[ScoreCount] [int] NULL,
 CONSTRAINT [PK_BookBasicInfo] PRIMARY KEY CLUSTERED 
(
	[BasicId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[BookBasicInfo] ON
INSERT [dbo].[BookBasicInfo] ([BasicId], [Title], [Content], [TypeId], [CoverImage], [Score], [ScoreCount]) VALUES (3, N'雪鹰领主', N'深渊恶魔降临,异世界来客潜伏人间,神灵们在窥伺这座世界,然而，这是夏族统治的世界！夏族的强者们征战四方，巡守天地海洋，灭杀一切威胁！这群强者有一个共同的名字——超凡生命……在夏族的安阳行省，有一个很小很不起眼的领地，叫——雪鹰领！故事，就从这里开始！', 12, N'~/Images/1.jpg', CAST(4.9 AS Decimal(18, 1)), 2342)
SET IDENTITY_INSERT [dbo].[BookBasicInfo] OFF
/****** Object:  Table [dbo].[EntityBookInfo]    Script Date: 10/09/2015 14:39:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[EntityBookInfo](
	[BookId] [int] IDENTITY(1000,1) NOT NULL,
	[Author] [nvarchar](50) NOT NULL,
	[PublisherId] [int] NOT NULL,
	[PublishDate] [datetime] NOT NULL,
	[Price] [money] NOT NULL,
	[Count] [int] NOT NULL,
	[ISBN] [nvarchar](50) NOT NULL,
	[BuyPrice] [money] NOT NULL,
	[BasicId] [int] NOT NULL,
 CONSTRAINT [PK_EntityBookInfo] PRIMARY KEY CLUSTERED 
(
	[BookId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[EBookInfo]    Script Date: 10/09/2015 14:39:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[EBookInfo](
	[EBookId] [int] IDENTITY(1,1) NOT NULL,
	[AuthorId] [int] NOT NULL,
	[Price] [int] NOT NULL,
	[Count] [decimal](16, 4) NOT NULL,
	[UpDateTime] [datetime] NOT NULL CONSTRAINT [DF_EBookInfo_UpDateTime]  DEFAULT (getdate()),
	[State] [nvarchar](10) NOT NULL,
	[IsFree] [bit] NOT NULL,
	[CollectionCount] [int] NOT NULL,
	[Ticket] [int] NULL CONSTRAINT [DF_BookInfo_Ticket]  DEFAULT ((0)),
	[BasicId] [int] NOT NULL,
 CONSTRAINT [PK_BookInfo] PRIMARY KEY CLUSTERED 
(
	[EBookId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[EBookInfo] ON
INSERT [dbo].[EBookInfo] ([EBookId], [AuthorId], [Price], [Count], [UpDateTime], [State], [IsFree], [CollectionCount], [Ticket], [BasicId]) VALUES (4, 4, 50, CAST(1234567.0000 AS Decimal(16, 4)), CAST(0x0000A52700000000 AS DateTime), N'连载', 0, 12345, 12343, 3)
SET IDENTITY_INSERT [dbo].[EBookInfo] OFF
/****** Object:  Table [dbo].[UserBuyer]    Script Date: 10/09/2015 14:39:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UserBuyer](
	[Id] [int] NOT NULL,
	[UserId] [int] NOT NULL,
	[Address] [nvarchar](100) NULL,
	[Phone] [nvarchar](20) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[UserProfit]    Script Date: 10/09/2015 14:39:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UserProfit](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[UserId] [int] NOT NULL,
	[AddMoney] [money] NOT NULL CONSTRAINT [DF_UserProfit_AddMoney]  DEFAULT ((0)),
	[DateTime] [datetime] NULL,
 CONSTRAINT [PK_UserProfit] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[UserHouse]    Script Date: 10/09/2015 14:39:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UserHouse](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[UserId] [int] NOT NULL,
	[EBookId] [int] NOT NULL,
 CONSTRAINT [PK_UserHouse] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[UserComments]    Script Date: 10/09/2015 14:39:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UserComments](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[UserId] [int] NOT NULL,
	[EBookId] [int] NULL,
	[BookId] [int] NULL,
	[Content] [nvarchar](500) NOT NULL,
	[DateTime] [datetime] NOT NULL,
 CONSTRAINT [PK_UserComments] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[EProfit]    Script Date: 10/09/2015 14:39:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[EProfit](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[EBookId] [int] NOT NULL,
	[UserId] [int] NOT NULL,
	[Money] [money] NOT NULL,
	[DateTime] [datetime] NOT NULL,
 CONSTRAINT [PK_EProfit] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[EntityProfit]    Script Date: 10/09/2015 14:39:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[EntityProfit](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[BookId] [int] NOT NULL,
	[UserId] [int] NOT NULL,
	[DateTime] [datetime] NOT NULL,
	[Count] [int] NOT NULL,
	[SellPrice] [money] NOT NULL,
	[Profit] [money] NOT NULL,
 CONSTRAINT [PK_EntityProfit] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[UserScores]    Script Date: 10/09/2015 14:39:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UserScores](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[UserId] [int] NOT NULL,
	[EBookId] [int] NULL,
	[BookId] [int] NULL,
	[Score] [decimal](18, 1) NULL,
 CONSTRAINT [PK_UserScores] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PlayManages]    Script Date: 10/09/2015 14:39:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PlayManages](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[UserId] [int] NOT NULL,
	[EBookId] [int] NOT NULL,
	[Count] [int] NOT NULL,
 CONSTRAINT [PK_PlayManages] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Orders]    Script Date: 10/09/2015 14:39:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Orders](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[UserId] [int] NOT NULL,
	[BookId] [int] NOT NULL,
	[Count] [int] NOT NULL,
	[OrderTime] [datetime] NOT NULL,
	[Money] [money] NOT NULL,
 CONSTRAINT [PK_Orders] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[EAuthor]    Script Date: 10/09/2015 14:39:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[EAuthor](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[UserId] [int] NOT NULL,
	[EBookId] [int] NOT NULL,
	[Popularity] [int] NOT NULL CONSTRAINT [DF_EAuthor_Popularity]  DEFAULT ((0)),
 CONSTRAINT [PK_EAuthor] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ChapterUrl]    Script Date: 10/09/2015 14:39:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChapterUrl](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[EBookId] [int] NOT NULL,
	[Url] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_ChapterUrl] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  ForeignKey [FK_UsersInfo_UsersRole_Id]    Script Date: 10/09/2015 14:39:35 ******/
ALTER TABLE [dbo].[UsersInfo]  WITH CHECK ADD  CONSTRAINT [FK_UsersInfo_UsersRole_Id] FOREIGN KEY([UserRoleId])
REFERENCES [dbo].[UsersRole] ([Id])
GO
ALTER TABLE [dbo].[UsersInfo] CHECK CONSTRAINT [FK_UsersInfo_UsersRole_Id]
GO
/****** Object:  ForeignKey [FK_TotalBookTypes_BookTypes_TypeId]    Script Date: 10/09/2015 14:39:35 ******/
ALTER TABLE [dbo].[TotalBookTypes]  WITH CHECK ADD  CONSTRAINT [FK_TotalBookTypes_BookTypes_TypeId] FOREIGN KEY([TypeId])
REFERENCES [dbo].[BookTypes] ([TypeId])
GO
ALTER TABLE [dbo].[TotalBookTypes] CHECK CONSTRAINT [FK_TotalBookTypes_BookTypes_TypeId]
GO
/****** Object:  ForeignKey [FK_BookBasicInfo_BookTypes_TypeId]    Script Date: 10/09/2015 14:39:35 ******/
ALTER TABLE [dbo].[BookBasicInfo]  WITH CHECK ADD  CONSTRAINT [FK_BookBasicInfo_BookTypes_TypeId] FOREIGN KEY([TypeId])
REFERENCES [dbo].[BookTypes] ([TypeId])
GO
ALTER TABLE [dbo].[BookBasicInfo] CHECK CONSTRAINT [FK_BookBasicInfo_BookTypes_TypeId]
GO
/****** Object:  ForeignKey [FK_EntityBookInfo_BookBasicInfo_BasicId]    Script Date: 10/09/2015 14:39:35 ******/
ALTER TABLE [dbo].[EntityBookInfo]  WITH CHECK ADD  CONSTRAINT [FK_EntityBookInfo_BookBasicInfo_BasicId] FOREIGN KEY([BasicId])
REFERENCES [dbo].[BookBasicInfo] ([BasicId])
GO
ALTER TABLE [dbo].[EntityBookInfo] CHECK CONSTRAINT [FK_EntityBookInfo_BookBasicInfo_BasicId]
GO
/****** Object:  ForeignKey [FK_EntityBookInfo_Publishers_Id]    Script Date: 10/09/2015 14:39:35 ******/
ALTER TABLE [dbo].[EntityBookInfo]  WITH CHECK ADD  CONSTRAINT [FK_EntityBookInfo_Publishers_Id] FOREIGN KEY([PublisherId])
REFERENCES [dbo].[Publishers] ([Id])
GO
ALTER TABLE [dbo].[EntityBookInfo] CHECK CONSTRAINT [FK_EntityBookInfo_Publishers_Id]
GO
/****** Object:  ForeignKey [FK_BookInfo_UsersInfo_UserId]    Script Date: 10/09/2015 14:39:35 ******/
ALTER TABLE [dbo].[EBookInfo]  WITH CHECK ADD  CONSTRAINT [FK_BookInfo_UsersInfo_UserId] FOREIGN KEY([AuthorId])
REFERENCES [dbo].[UsersInfo] ([UserId])
GO
ALTER TABLE [dbo].[EBookInfo] CHECK CONSTRAINT [FK_BookInfo_UsersInfo_UserId]
GO
/****** Object:  ForeignKey [FK_EBookInfo_BookBasicInfo_BasicId]    Script Date: 10/09/2015 14:39:35 ******/
ALTER TABLE [dbo].[EBookInfo]  WITH CHECK ADD  CONSTRAINT [FK_EBookInfo_BookBasicInfo_BasicId] FOREIGN KEY([BasicId])
REFERENCES [dbo].[BookBasicInfo] ([BasicId])
GO
ALTER TABLE [dbo].[EBookInfo] CHECK CONSTRAINT [FK_EBookInfo_BookBasicInfo_BasicId]
GO
/****** Object:  ForeignKey [FK_UserBuyer_UsersInfo_UserId]    Script Date: 10/09/2015 14:39:35 ******/
ALTER TABLE [dbo].[UserBuyer]  WITH CHECK ADD  CONSTRAINT [FK_UserBuyer_UsersInfo_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[UsersInfo] ([UserId])
GO
ALTER TABLE [dbo].[UserBuyer] CHECK CONSTRAINT [FK_UserBuyer_UsersInfo_UserId]
GO
/****** Object:  ForeignKey [FK_UserProfit_UsersInfo_UserId]    Script Date: 10/09/2015 14:39:35 ******/
ALTER TABLE [dbo].[UserProfit]  WITH CHECK ADD  CONSTRAINT [FK_UserProfit_UsersInfo_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[UsersInfo] ([UserId])
GO
ALTER TABLE [dbo].[UserProfit] CHECK CONSTRAINT [FK_UserProfit_UsersInfo_UserId]
GO
/****** Object:  ForeignKey [FK_UserHouse_EBookInfo_BookId]    Script Date: 10/09/2015 14:39:35 ******/
ALTER TABLE [dbo].[UserHouse]  WITH CHECK ADD  CONSTRAINT [FK_UserHouse_EBookInfo_BookId] FOREIGN KEY([EBookId])
REFERENCES [dbo].[EBookInfo] ([EBookId])
GO
ALTER TABLE [dbo].[UserHouse] CHECK CONSTRAINT [FK_UserHouse_EBookInfo_BookId]
GO
/****** Object:  ForeignKey [FK_UserHouse_UsersInfo_UserId]    Script Date: 10/09/2015 14:39:35 ******/
ALTER TABLE [dbo].[UserHouse]  WITH CHECK ADD  CONSTRAINT [FK_UserHouse_UsersInfo_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[UsersInfo] ([UserId])
GO
ALTER TABLE [dbo].[UserHouse] CHECK CONSTRAINT [FK_UserHouse_UsersInfo_UserId]
GO
/****** Object:  ForeignKey [FK_UserComments_EBookInfo_EBookId]    Script Date: 10/09/2015 14:39:35 ******/
ALTER TABLE [dbo].[UserComments]  WITH CHECK ADD  CONSTRAINT [FK_UserComments_EBookInfo_EBookId] FOREIGN KEY([EBookId])
REFERENCES [dbo].[EBookInfo] ([EBookId])
GO
ALTER TABLE [dbo].[UserComments] CHECK CONSTRAINT [FK_UserComments_EBookInfo_EBookId]
GO
/****** Object:  ForeignKey [FK_UserComments_EntityBookInfo_BookId]    Script Date: 10/09/2015 14:39:35 ******/
ALTER TABLE [dbo].[UserComments]  WITH CHECK ADD  CONSTRAINT [FK_UserComments_EntityBookInfo_BookId] FOREIGN KEY([BookId])
REFERENCES [dbo].[EntityBookInfo] ([BookId])
GO
ALTER TABLE [dbo].[UserComments] CHECK CONSTRAINT [FK_UserComments_EntityBookInfo_BookId]
GO
/****** Object:  ForeignKey [FK_UserComments_UsersInfo_UserId]    Script Date: 10/09/2015 14:39:35 ******/
ALTER TABLE [dbo].[UserComments]  WITH CHECK ADD  CONSTRAINT [FK_UserComments_UsersInfo_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[UsersInfo] ([UserId])
GO
ALTER TABLE [dbo].[UserComments] CHECK CONSTRAINT [FK_UserComments_UsersInfo_UserId]
GO
/****** Object:  ForeignKey [FK_EProfit_EBookInfo_EBookId]    Script Date: 10/09/2015 14:39:35 ******/
ALTER TABLE [dbo].[EProfit]  WITH CHECK ADD  CONSTRAINT [FK_EProfit_EBookInfo_EBookId] FOREIGN KEY([EBookId])
REFERENCES [dbo].[EBookInfo] ([EBookId])
GO
ALTER TABLE [dbo].[EProfit] CHECK CONSTRAINT [FK_EProfit_EBookInfo_EBookId]
GO
/****** Object:  ForeignKey [FK_EProfit_UsersInfo_UserId]    Script Date: 10/09/2015 14:39:35 ******/
ALTER TABLE [dbo].[EProfit]  WITH CHECK ADD  CONSTRAINT [FK_EProfit_UsersInfo_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[UsersInfo] ([UserId])
GO
ALTER TABLE [dbo].[EProfit] CHECK CONSTRAINT [FK_EProfit_UsersInfo_UserId]
GO
/****** Object:  ForeignKey [FK_EntityProfit_EntityBookInfo_BookId]    Script Date: 10/09/2015 14:39:35 ******/
ALTER TABLE [dbo].[EntityProfit]  WITH CHECK ADD  CONSTRAINT [FK_EntityProfit_EntityBookInfo_BookId] FOREIGN KEY([BookId])
REFERENCES [dbo].[EntityBookInfo] ([BookId])
GO
ALTER TABLE [dbo].[EntityProfit] CHECK CONSTRAINT [FK_EntityProfit_EntityBookInfo_BookId]
GO
/****** Object:  ForeignKey [FK_EntityProfit_UsersInfo_UserId]    Script Date: 10/09/2015 14:39:35 ******/
ALTER TABLE [dbo].[EntityProfit]  WITH CHECK ADD  CONSTRAINT [FK_EntityProfit_UsersInfo_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[UsersInfo] ([UserId])
GO
ALTER TABLE [dbo].[EntityProfit] CHECK CONSTRAINT [FK_EntityProfit_UsersInfo_UserId]
GO
/****** Object:  ForeignKey [FK_UserScores_EBookInfo_EBookId]    Script Date: 10/09/2015 14:39:35 ******/
ALTER TABLE [dbo].[UserScores]  WITH CHECK ADD  CONSTRAINT [FK_UserScores_EBookInfo_EBookId] FOREIGN KEY([EBookId])
REFERENCES [dbo].[EBookInfo] ([EBookId])
GO
ALTER TABLE [dbo].[UserScores] CHECK CONSTRAINT [FK_UserScores_EBookInfo_EBookId]
GO
/****** Object:  ForeignKey [FK_UserScores_EntityBookInfo_BookId]    Script Date: 10/09/2015 14:39:35 ******/
ALTER TABLE [dbo].[UserScores]  WITH CHECK ADD  CONSTRAINT [FK_UserScores_EntityBookInfo_BookId] FOREIGN KEY([BookId])
REFERENCES [dbo].[EntityBookInfo] ([BookId])
GO
ALTER TABLE [dbo].[UserScores] CHECK CONSTRAINT [FK_UserScores_EntityBookInfo_BookId]
GO
/****** Object:  ForeignKey [FK_PlayManages_EBookInfo_EBookId]    Script Date: 10/09/2015 14:39:35 ******/
ALTER TABLE [dbo].[PlayManages]  WITH CHECK ADD  CONSTRAINT [FK_PlayManages_EBookInfo_EBookId] FOREIGN KEY([EBookId])
REFERENCES [dbo].[EBookInfo] ([EBookId])
GO
ALTER TABLE [dbo].[PlayManages] CHECK CONSTRAINT [FK_PlayManages_EBookInfo_EBookId]
GO
/****** Object:  ForeignKey [FK_PlayManages_UsersInfo_UserId]    Script Date: 10/09/2015 14:39:35 ******/
ALTER TABLE [dbo].[PlayManages]  WITH CHECK ADD  CONSTRAINT [FK_PlayManages_UsersInfo_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[UsersInfo] ([UserId])
GO
ALTER TABLE [dbo].[PlayManages] CHECK CONSTRAINT [FK_PlayManages_UsersInfo_UserId]
GO
/****** Object:  ForeignKey [FK_Orders_EntityBookInfo_BookId]    Script Date: 10/09/2015 14:39:35 ******/
ALTER TABLE [dbo].[Orders]  WITH CHECK ADD  CONSTRAINT [FK_Orders_EntityBookInfo_BookId] FOREIGN KEY([BookId])
REFERENCES [dbo].[EntityBookInfo] ([BookId])
GO
ALTER TABLE [dbo].[Orders] CHECK CONSTRAINT [FK_Orders_EntityBookInfo_BookId]
GO
/****** Object:  ForeignKey [FK_Orders_UsersInfo_UserId]    Script Date: 10/09/2015 14:39:35 ******/
ALTER TABLE [dbo].[Orders]  WITH CHECK ADD  CONSTRAINT [FK_Orders_UsersInfo_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[UsersInfo] ([UserId])
GO
ALTER TABLE [dbo].[Orders] CHECK CONSTRAINT [FK_Orders_UsersInfo_UserId]
GO
/****** Object:  ForeignKey [FK_EAuthor_EBookInfo_EBookId]    Script Date: 10/09/2015 14:39:35 ******/
ALTER TABLE [dbo].[EAuthor]  WITH CHECK ADD  CONSTRAINT [FK_EAuthor_EBookInfo_EBookId] FOREIGN KEY([EBookId])
REFERENCES [dbo].[EBookInfo] ([EBookId])
GO
ALTER TABLE [dbo].[EAuthor] CHECK CONSTRAINT [FK_EAuthor_EBookInfo_EBookId]
GO
/****** Object:  ForeignKey [FK_EAuthor_UsersInfo_UserId]    Script Date: 10/09/2015 14:39:35 ******/
ALTER TABLE [dbo].[EAuthor]  WITH CHECK ADD  CONSTRAINT [FK_EAuthor_UsersInfo_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[UsersInfo] ([UserId])
GO
ALTER TABLE [dbo].[EAuthor] CHECK CONSTRAINT [FK_EAuthor_UsersInfo_UserId]
GO
/****** Object:  ForeignKey [FK_ChapterUrl_EBookInfo_EBookId]    Script Date: 10/09/2015 14:39:35 ******/
ALTER TABLE [dbo].[ChapterUrl]  WITH CHECK ADD  CONSTRAINT [FK_ChapterUrl_EBookInfo_EBookId] FOREIGN KEY([EBookId])
REFERENCES [dbo].[EBookInfo] ([EBookId])
GO
ALTER TABLE [dbo].[ChapterUrl] CHECK CONSTRAINT [FK_ChapterUrl_EBookInfo_EBookId]
GO
