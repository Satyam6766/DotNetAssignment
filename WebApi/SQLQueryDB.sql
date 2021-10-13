USE [master]
GO
/****** Object:  Database [WebApi12Sep]    Script Date: 13-10-2021 12:39:23 ******/
CREATE DATABASE [WebApi12Sep]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'WebApi12Sep', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\WebApi12Sep.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'WebApi12Sep_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\WebApi12Sep_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [WebApi12Sep] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [WebApi12Sep].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [WebApi12Sep] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [WebApi12Sep] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [WebApi12Sep] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [WebApi12Sep] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [WebApi12Sep] SET ARITHABORT OFF 
GO
ALTER DATABASE [WebApi12Sep] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [WebApi12Sep] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [WebApi12Sep] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [WebApi12Sep] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [WebApi12Sep] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [WebApi12Sep] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [WebApi12Sep] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [WebApi12Sep] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [WebApi12Sep] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [WebApi12Sep] SET  ENABLE_BROKER 
GO
ALTER DATABASE [WebApi12Sep] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [WebApi12Sep] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [WebApi12Sep] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [WebApi12Sep] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [WebApi12Sep] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [WebApi12Sep] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [WebApi12Sep] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [WebApi12Sep] SET RECOVERY FULL 
GO
ALTER DATABASE [WebApi12Sep] SET  MULTI_USER 
GO
ALTER DATABASE [WebApi12Sep] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [WebApi12Sep] SET DB_CHAINING OFF 
GO
ALTER DATABASE [WebApi12Sep] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [WebApi12Sep] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [WebApi12Sep] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [WebApi12Sep] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'WebApi12Sep', N'ON'
GO
ALTER DATABASE [WebApi12Sep] SET QUERY_STORE = OFF
GO
USE [WebApi12Sep]
GO
/****** Object:  Table [dbo].[Course]    Script Date: 13-10-2021 12:39:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Course](
	[Id] [int] IDENTITY(100,1) NOT NULL,
	[Coursename] [varchar](20) NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Student]    Script Date: 13-10-2021 12:39:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Student](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[StuName] [varchar](50) NULL,
	[Gender] [char](1) NULL,
	[CourseId] [int] NULL,
	[dob] [datetime] NULL,
	[email] [varchar](100) NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Course] ON 
GO
INSERT [dbo].[Course] ([Id], [Coursename]) VALUES (100, N'BCA')
GO
INSERT [dbo].[Course] ([Id], [Coursename]) VALUES (101, N'Master of CA')
GO
INSERT [dbo].[Course] ([Id], [Coursename]) VALUES (102, N'BTECH')
GO
INSERT [dbo].[Course] ([Id], [Coursename]) VALUES (103, N'BBA')
GO
INSERT [dbo].[Course] ([Id], [Coursename]) VALUES (104, N'MTECH')
GO
INSERT [dbo].[Course] ([Id], [Coursename]) VALUES (105, N'BPharma')
GO
INSERT [dbo].[Course] ([Id], [Coursename]) VALUES (106, N'MPharma')
GO
SET IDENTITY_INSERT [dbo].[Course] OFF
GO
SET IDENTITY_INSERT [dbo].[Student] ON 
GO
INSERT [dbo].[Student] ([Id], [StuName], [Gender], [CourseId], [dob], [email]) VALUES (3, N'Aakash', N'M', 106, CAST(N'1998-12-20T00:00:00.000' AS DateTime), N'Aakash123@gmail.com')
GO
INSERT [dbo].[Student] ([Id], [StuName], [Gender], [CourseId], [dob], [email]) VALUES (4, N'Devender', N'M', 104, CAST(N'1998-12-20T00:00:00.000' AS DateTime), N'Devender123@gmail.com')
GO
INSERT [dbo].[Student] ([Id], [StuName], [Gender], [CourseId], [dob], [email]) VALUES (6, N'Neha', N'F', 101, CAST(N'1998-12-20T00:00:00.000' AS DateTime), N'Neha145@gmail.com')
GO
INSERT [dbo].[Student] ([Id], [StuName], [Gender], [CourseId], [dob], [email]) VALUES (7, N'Latika ', N'F', 102, CAST(N'1998-12-20T00:00:00.000' AS DateTime), N'Latika.M@tothenew.com')
GO
INSERT [dbo].[Student] ([Id], [StuName], [Gender], [CourseId], [dob], [email]) VALUES (8, N'Shanaya Singh Shanaya', N'F', 102, CAST(N'1998-12-20T00:00:00.000' AS DateTime), N'shanayasingh123@gmail.com')
GO
INSERT [dbo].[Student] ([Id], [StuName], [Gender], [CourseId], [dob], [email]) VALUES (9, N'Shivanshu', N'M', 102, CAST(N'1998-12-20T00:00:00.000' AS DateTime), N'Shanaya123@gmail.com')
GO
SET IDENTITY_INSERT [dbo].[Student] OFF
GO
ALTER TABLE [dbo].[Student]  WITH CHECK ADD FOREIGN KEY([CourseId])
REFERENCES [dbo].[Course] ([Id])
GO
USE [master]
GO
ALTER DATABASE [WebApi12Sep] SET  READ_WRITE 
GO
