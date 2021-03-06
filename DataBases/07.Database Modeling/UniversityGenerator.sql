USE [master]
GO
/****** Object:  Database [University]    Script Date: 4.10.2015 г. 21:23:53 ч. ******/
CREATE DATABASE [University]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'University', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\University.mdf' , SIZE = 5120KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'University_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\University_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [University] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [University].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [University] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [University] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [University] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [University] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [University] SET ARITHABORT OFF 
GO
ALTER DATABASE [University] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [University] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [University] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [University] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [University] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [University] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [University] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [University] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [University] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [University] SET  DISABLE_BROKER 
GO
ALTER DATABASE [University] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [University] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [University] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [University] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [University] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [University] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [University] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [University] SET RECOVERY FULL 
GO
ALTER DATABASE [University] SET  MULTI_USER 
GO
ALTER DATABASE [University] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [University] SET DB_CHAINING OFF 
GO
ALTER DATABASE [University] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [University] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [University] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'University', N'ON'
GO
USE [University]
GO
/****** Object:  Table [dbo].[Courses]    Script Date: 4.10.2015 г. 21:23:53 ч. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Courses](
	[course_id] [int] IDENTITY(1,1) NOT NULL,
	[professor] [int] NOT NULL,
	[department] [int] NOT NULL,
	[name] [nchar](10) NOT NULL,
 CONSTRAINT [PK_Courses] PRIMARY KEY CLUSTERED 
(
	[course_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Departments]    Script Date: 4.10.2015 г. 21:23:53 ч. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Departments](
	[department_id] [int] IDENTITY(1,1) NOT NULL,
	[name] [nchar](20) NOT NULL,
	[faculty] [int] NOT NULL,
 CONSTRAINT [PK_Departments] PRIMARY KEY CLUSTERED 
(
	[department_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Faculties]    Script Date: 4.10.2015 г. 21:23:53 ч. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Faculties](
	[faculty_id] [int] IDENTITY(1,1) NOT NULL,
	[name] [nchar](20) NOT NULL,
	[university] [int] NOT NULL,
 CONSTRAINT [PK_Faculties] PRIMARY KEY CLUSTERED 
(
	[faculty_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[ProfessorCourses]    Script Date: 4.10.2015 г. 21:23:53 ч. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ProfessorCourses](
	[professor] [int] NOT NULL,
	[course] [int] NOT NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Professors]    Script Date: 4.10.2015 г. 21:23:53 ч. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Professors](
	[professor_id] [int] IDENTITY(1,1) NOT NULL,
	[department] [int] NOT NULL,
	[name] [nchar](10) NOT NULL,
 CONSTRAINT [PK_Professors] PRIMARY KEY CLUSTERED 
(
	[professor_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[ProfessorTitles]    Script Date: 4.10.2015 г. 21:23:53 ч. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ProfessorTitles](
	[professor_id] [int] NOT NULL,
	[title] [int] NOT NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Students]    Script Date: 4.10.2015 г. 21:23:53 ч. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Students](
	[student_id] [int] IDENTITY(1,1) NOT NULL,
	[name] [nchar](10) NOT NULL,
	[faculty] [int] NOT NULL,
 CONSTRAINT [PK_Students] PRIMARY KEY CLUSTERED 
(
	[student_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[StudentsCourses]    Script Date: 4.10.2015 г. 21:23:53 ч. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[StudentsCourses](
	[student] [int] NOT NULL,
	[course] [int] NOT NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Titles]    Script Date: 4.10.2015 г. 21:23:53 ч. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Titles](
	[title_id] [int] IDENTITY(1,1) NOT NULL,
	[name] [nchar](10) NOT NULL,
 CONSTRAINT [PK_Titles] PRIMARY KEY CLUSTERED 
(
	[title_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Universities]    Script Date: 4.10.2015 г. 21:23:53 ч. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Universities](
	[university_id] [int] IDENTITY(1,1) NOT NULL,
	[name] [nchar](20) NOT NULL,
 CONSTRAINT [PK_Universities] PRIMARY KEY CLUSTERED 
(
	[university_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
ALTER TABLE [dbo].[Courses]  WITH CHECK ADD  CONSTRAINT [FK_Courses_Departments] FOREIGN KEY([department])
REFERENCES [dbo].[Departments] ([department_id])
GO
ALTER TABLE [dbo].[Courses] CHECK CONSTRAINT [FK_Courses_Departments]
GO
ALTER TABLE [dbo].[Departments]  WITH CHECK ADD  CONSTRAINT [FK_Departments_Faculties] FOREIGN KEY([faculty])
REFERENCES [dbo].[Faculties] ([faculty_id])
GO
ALTER TABLE [dbo].[Departments] CHECK CONSTRAINT [FK_Departments_Faculties]
GO
ALTER TABLE [dbo].[Faculties]  WITH CHECK ADD  CONSTRAINT [FK_Faculties_Universities] FOREIGN KEY([university])
REFERENCES [dbo].[Universities] ([university_id])
GO
ALTER TABLE [dbo].[Faculties] CHECK CONSTRAINT [FK_Faculties_Universities]
GO
ALTER TABLE [dbo].[ProfessorCourses]  WITH CHECK ADD  CONSTRAINT [FK_ProfessorCourses_Courses] FOREIGN KEY([course])
REFERENCES [dbo].[Courses] ([course_id])
GO
ALTER TABLE [dbo].[ProfessorCourses] CHECK CONSTRAINT [FK_ProfessorCourses_Courses]
GO
ALTER TABLE [dbo].[ProfessorCourses]  WITH CHECK ADD  CONSTRAINT [FK_ProfessorCourses_Professors] FOREIGN KEY([professor])
REFERENCES [dbo].[Professors] ([professor_id])
GO
ALTER TABLE [dbo].[ProfessorCourses] CHECK CONSTRAINT [FK_ProfessorCourses_Professors]
GO
ALTER TABLE [dbo].[Professors]  WITH CHECK ADD  CONSTRAINT [FK_Professors_Departments] FOREIGN KEY([department])
REFERENCES [dbo].[Departments] ([department_id])
GO
ALTER TABLE [dbo].[Professors] CHECK CONSTRAINT [FK_Professors_Departments]
GO
ALTER TABLE [dbo].[ProfessorTitles]  WITH CHECK ADD  CONSTRAINT [FK_ProfessorTitles_Professors] FOREIGN KEY([professor_id])
REFERENCES [dbo].[Professors] ([professor_id])
GO
ALTER TABLE [dbo].[ProfessorTitles] CHECK CONSTRAINT [FK_ProfessorTitles_Professors]
GO
ALTER TABLE [dbo].[ProfessorTitles]  WITH CHECK ADD  CONSTRAINT [FK_ProfessorTitles_Titles] FOREIGN KEY([title])
REFERENCES [dbo].[Titles] ([title_id])
GO
ALTER TABLE [dbo].[ProfessorTitles] CHECK CONSTRAINT [FK_ProfessorTitles_Titles]
GO
ALTER TABLE [dbo].[Students]  WITH CHECK ADD  CONSTRAINT [FK_Students_Faculties] FOREIGN KEY([faculty])
REFERENCES [dbo].[Faculties] ([faculty_id])
GO
ALTER TABLE [dbo].[Students] CHECK CONSTRAINT [FK_Students_Faculties]
GO
ALTER TABLE [dbo].[StudentsCourses]  WITH CHECK ADD  CONSTRAINT [FK_StudentsCourses_Courses] FOREIGN KEY([course])
REFERENCES [dbo].[Courses] ([course_id])
GO
ALTER TABLE [dbo].[StudentsCourses] CHECK CONSTRAINT [FK_StudentsCourses_Courses]
GO
ALTER TABLE [dbo].[StudentsCourses]  WITH CHECK ADD  CONSTRAINT [FK_StudentsCourses_Students] FOREIGN KEY([student])
REFERENCES [dbo].[Students] ([student_id])
GO
ALTER TABLE [dbo].[StudentsCourses] CHECK CONSTRAINT [FK_StudentsCourses_Students]
GO
USE [master]
GO
ALTER DATABASE [University] SET  READ_WRITE 
GO
