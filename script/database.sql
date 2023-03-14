USE [master]
GO
/****** Object:  Database [SchoolDb]    Script Date: 14.03.2023 13:44:33 ******/
CREATE DATABASE [SchoolDb]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'SchoolDb', FILENAME = N'C:\UCC08\Database\SchoolDb.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'SchoolDb_log', FILENAME = N'C:\UCC08\Database\SchoolDb_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [SchoolDb] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [SchoolDb].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [SchoolDb] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [SchoolDb] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [SchoolDb] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [SchoolDb] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [SchoolDb] SET ARITHABORT OFF 
GO
ALTER DATABASE [SchoolDb] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [SchoolDb] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [SchoolDb] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [SchoolDb] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [SchoolDb] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [SchoolDb] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [SchoolDb] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [SchoolDb] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [SchoolDb] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [SchoolDb] SET  DISABLE_BROKER 
GO
ALTER DATABASE [SchoolDb] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [SchoolDb] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [SchoolDb] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [SchoolDb] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [SchoolDb] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [SchoolDb] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [SchoolDb] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [SchoolDb] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [SchoolDb] SET  MULTI_USER 
GO
ALTER DATABASE [SchoolDb] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [SchoolDb] SET DB_CHAINING OFF 
GO
ALTER DATABASE [SchoolDb] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [SchoolDb] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [SchoolDb] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [SchoolDb] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [SchoolDb] SET QUERY_STORE = OFF
GO
USE [SchoolDb]
GO
/****** Object:  Table [dbo].[datGrade]    Script Date: 14.03.2023 13:44:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[datGrade](
	[GradeID] [int] IDENTITY(1,1) NOT NULL,
	[Student] [int] NULL,
	[Lesson] [tinyint] NULL,
	[LessonGrade] [tinyint] NULL,
 CONSTRAINT [PK_datGrade] PRIMARY KEY CLUSTERED 
(
	[GradeID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[datLesson]    Script Date: 14.03.2023 13:44:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[datLesson](
	[LessonID] [tinyint] IDENTITY(1,1) NOT NULL,
	[LessonName] [nvarchar](50) NULL,
 CONSTRAINT [PK_datLesson] PRIMARY KEY CLUSTERED 
(
	[LessonID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[datStudent]    Script Date: 14.03.2023 13:44:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[datStudent](
	[StudentID] [int] IDENTITY(1,1) NOT NULL,
	[FirstName] [nvarchar](50) NULL,
	[LastName] [nvarchar](50) NULL,
	[StudentNumber] [char](5) NULL,
	[Department] [nvarchar](50) NULL,
 CONSTRAINT [PK_datStudent] PRIMARY KEY CLUSTERED 
(
	[StudentID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[datLesson] ON 

INSERT [dbo].[datLesson] ([LessonID], [LessonName]) VALUES (1, N'Algorithm and Programming
')
INSERT [dbo].[datLesson] ([LessonID], [LessonName]) VALUES (2, N'Physical')
INSERT [dbo].[datLesson] ([LessonID], [LessonName]) VALUES (3, N'Engineering Mathematics
')
INSERT [dbo].[datLesson] ([LessonID], [LessonName]) VALUES (4, N'Object Oriented Programming')
INSERT [dbo].[datLesson] ([LessonID], [LessonName]) VALUES (5, N'Artificial Intelligence
')
INSERT [dbo].[datLesson] ([LessonID], [LessonName]) VALUES (6, N'Biology')
INSERT [dbo].[datLesson] ([LessonID], [LessonName]) VALUES (7, N'Ar ge Engineering')
SET IDENTITY_INSERT [dbo].[datLesson] OFF
GO
SET IDENTITY_INSERT [dbo].[datStudent] ON 

INSERT [dbo].[datStudent] ([StudentID], [FirstName], [LastName], [StudentNumber], [Department]) VALUES (1, N'Muhammed Ferit', N'Simsek', N'13340', N'Maritime T.M Engineering
')
INSERT [dbo].[datStudent] ([StudentID], [FirstName], [LastName], [StudentNumber], [Department]) VALUES (2, N'Ali', N'Simsek', N'43371', N'Industrial Engineering
')
INSERT [dbo].[datStudent] ([StudentID], [FirstName], [LastName], [StudentNumber], [Department]) VALUES (3, N'Tahir', N'Ucar', N'84416', N'Mechanical Engineering
')
INSERT [dbo].[datStudent] ([StudentID], [FirstName], [LastName], [StudentNumber], [Department]) VALUES (4, N'Baris', N'Aktas', N'78813', N'Ship Engineering')
INSERT [dbo].[datStudent] ([StudentID], [FirstName], [LastName], [StudentNumber], [Department]) VALUES (5, N'Mehmet Nuri', N'Sariel', N'46417', N'Chemical Engineering
')
INSERT [dbo].[datStudent] ([StudentID], [FirstName], [LastName], [StudentNumber], [Department]) VALUES (6, N'Resul', N'Altintas', N'51468', N'Accounting')
INSERT [dbo].[datStudent] ([StudentID], [FirstName], [LastName], [StudentNumber], [Department]) VALUES (8, N'Resul', N'Altintas', N'51568', N'Accounting')
SET IDENTITY_INSERT [dbo].[datStudent] OFF
GO
ALTER TABLE [dbo].[datGrade]  WITH CHECK ADD  CONSTRAINT [FK_datGrade_datLesson] FOREIGN KEY([Lesson])
REFERENCES [dbo].[datLesson] ([LessonID])
GO
ALTER TABLE [dbo].[datGrade] CHECK CONSTRAINT [FK_datGrade_datLesson]
GO
ALTER TABLE [dbo].[datGrade]  WITH CHECK ADD  CONSTRAINT [FK_datGrade_datStudent] FOREIGN KEY([Student])
REFERENCES [dbo].[datStudent] ([StudentID])
GO
ALTER TABLE [dbo].[datGrade] CHECK CONSTRAINT [FK_datGrade_datStudent]
GO
USE [master]
GO
ALTER DATABASE [SchoolDb] SET  READ_WRITE 
GO
