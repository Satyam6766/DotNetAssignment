USE [master]
GO
/****** Object:  Database [MvcDemo]    Script Date: 24-10-2021 14:39:44 ******/
CREATE DATABASE [MvcDemo]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'MvcDemo', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\MvcDemo.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'MvcDemo_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\MvcDemo_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [MvcDemo] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [MvcDemo].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [MvcDemo] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [MvcDemo] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [MvcDemo] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [MvcDemo] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [MvcDemo] SET ARITHABORT OFF 
GO
ALTER DATABASE [MvcDemo] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [MvcDemo] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [MvcDemo] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [MvcDemo] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [MvcDemo] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [MvcDemo] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [MvcDemo] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [MvcDemo] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [MvcDemo] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [MvcDemo] SET  ENABLE_BROKER 
GO
ALTER DATABASE [MvcDemo] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [MvcDemo] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [MvcDemo] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [MvcDemo] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [MvcDemo] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [MvcDemo] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [MvcDemo] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [MvcDemo] SET RECOVERY FULL 
GO
ALTER DATABASE [MvcDemo] SET  MULTI_USER 
GO
ALTER DATABASE [MvcDemo] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [MvcDemo] SET DB_CHAINING OFF 
GO
ALTER DATABASE [MvcDemo] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [MvcDemo] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [MvcDemo] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [MvcDemo] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'MvcDemo', N'ON'
GO
ALTER DATABASE [MvcDemo] SET QUERY_STORE = OFF
GO
USE [MvcDemo]
GO
/****** Object:  Table [dbo].[LoginTable]    Script Date: 24-10-2021 14:39:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LoginTable](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[email] [varchar](max) NOT NULL,
	[password] [varchar](50) NOT NULL,
	[firstName] [varchar](50) NOT NULL,
	[lastName] [varchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  StoredProcedure [dbo].[SP_GetUsernameFromEmail]    Script Date: 24-10-2021 14:39:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


--create procedure SP_InsertUserLoginTable
--(
--@firstname varchar(50),
--@lastname varchar(50),
--@email varchar(max),
--@password varchar(50)
--)
--as begin
--if not exists(select * from LoginTable where email=@email)
--begin
--Insert into LoginTable(firstName,lastName,email,password)VALUES(@firstname,@lastname,@email,@password)
--end
--else
--begin 
--return -1
--end
--end

--select * from LoginTable

CREATE procedure [dbo].[SP_GetUsernameFromEmail]
(
@email varchar(max)
)
as begin
select firstname as fname,lastname as lname from LoginTable where email=@email
end

--exec SP_GetUsernameFromEmail 'xyz234@gmail.com'
GO
/****** Object:  StoredProcedure [dbo].[SP_InsertUserLoginTable]    Script Date: 24-10-2021 14:39:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


create procedure [dbo].[SP_InsertUserLoginTable]
(
@firstname varchar(50),
@lastname varchar(50),
@email varchar(max),
@password varchar(50)
)
as begin
if not exists(select * from LoginTable where email=@email)
begin
Insert into LoginTable(firstName,lastName,email,password)VALUES(@firstname,@lastname,@email,@password)
end
else
begin 
return -1
end
end
GO
USE [master]
GO
ALTER DATABASE [MvcDemo] SET  READ_WRITE 
GO
