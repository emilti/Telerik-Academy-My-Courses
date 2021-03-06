USE [master]
GO
/****** Object:  Database [WorldData]    Script Date: 4.10.2015 г. 21:35:50 ч. ******/
CREATE DATABASE [WorldData]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'WorldData', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\WorldData.mdf' , SIZE = 5120KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'WorldData_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\WorldData_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [WorldData] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [WorldData].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [WorldData] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [WorldData] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [WorldData] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [WorldData] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [WorldData] SET ARITHABORT OFF 
GO
ALTER DATABASE [WorldData] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [WorldData] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [WorldData] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [WorldData] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [WorldData] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [WorldData] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [WorldData] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [WorldData] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [WorldData] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [WorldData] SET  DISABLE_BROKER 
GO
ALTER DATABASE [WorldData] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [WorldData] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [WorldData] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [WorldData] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [WorldData] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [WorldData] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [WorldData] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [WorldData] SET RECOVERY FULL 
GO
ALTER DATABASE [WorldData] SET  MULTI_USER 
GO
ALTER DATABASE [WorldData] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [WorldData] SET DB_CHAINING OFF 
GO
ALTER DATABASE [WorldData] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [WorldData] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [WorldData] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'WorldData', N'ON'
GO
USE [WorldData]
GO
/****** Object:  Table [dbo].[Address]    Script Date: 4.10.2015 г. 21:35:50 ч. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Address](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[address_text] [nchar](50) NOT NULL,
	[town_id] [int] NOT NULL,
 CONSTRAINT [PK_Address] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Contninent]    Script Date: 4.10.2015 г. 21:35:50 ч. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Contninent](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [nchar](20) NOT NULL CONSTRAINT [DF_Contninent_name]  DEFAULT (N'Unknown'),
 CONSTRAINT [PK_Contninent] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Country]    Script Date: 4.10.2015 г. 21:35:50 ч. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Country](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [nchar](20) NOT NULL,
	[continent_id] [int] NOT NULL,
 CONSTRAINT [PK_Country] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Person]    Script Date: 4.10.2015 г. 21:35:50 ч. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Person](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[first_name] [nchar](20) NOT NULL,
	[last_name] [nchar](20) NOT NULL,
	[address_id] [int] NOT NULL,
 CONSTRAINT [PK_Person] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Town]    Script Date: 4.10.2015 г. 21:35:50 ч. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Town](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [nchar](50) NOT NULL,
	[country_id] [int] NOT NULL,
 CONSTRAINT [PK_Town] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET IDENTITY_INSERT [dbo].[Address] ON 

INSERT [dbo].[Address] ([id], [address_text], [town_id]) VALUES (1, N'aaaaa                                             ', 1)
INSERT [dbo].[Address] ([id], [address_text], [town_id]) VALUES (2, N'bbbbb                                             ', 2)
INSERT [dbo].[Address] ([id], [address_text], [town_id]) VALUES (3, N'ccccc                                             ', 3)
SET IDENTITY_INSERT [dbo].[Address] OFF
SET IDENTITY_INSERT [dbo].[Contninent] ON 

INSERT [dbo].[Contninent] ([id], [name]) VALUES (1, N'Europe              ')
INSERT [dbo].[Contninent] ([id], [name]) VALUES (2, N'Asia                ')
INSERT [dbo].[Contninent] ([id], [name]) VALUES (3, N'North America       ')
SET IDENTITY_INSERT [dbo].[Contninent] OFF
SET IDENTITY_INSERT [dbo].[Country] ON 

INSERT [dbo].[Country] ([id], [name], [continent_id]) VALUES (1, N'Bulgaria            ', 1)
INSERT [dbo].[Country] ([id], [name], [continent_id]) VALUES (2, N'USA                 ', 3)
INSERT [dbo].[Country] ([id], [name], [continent_id]) VALUES (3, N'Russia              ', 2)
SET IDENTITY_INSERT [dbo].[Country] OFF
SET IDENTITY_INSERT [dbo].[Person] ON 

INSERT [dbo].[Person] ([id], [first_name], [last_name], [address_id]) VALUES (1, N'Pesho               ', N'Peshev              ', 1)
INSERT [dbo].[Person] ([id], [first_name], [last_name], [address_id]) VALUES (2, N'John                ', N'Johnev              ', 2)
INSERT [dbo].[Person] ([id], [first_name], [last_name], [address_id]) VALUES (3, N'Pyotr               ', N'Pytrev              ', 3)
SET IDENTITY_INSERT [dbo].[Person] OFF
SET IDENTITY_INSERT [dbo].[Town] ON 

INSERT [dbo].[Town] ([id], [name], [country_id]) VALUES (1, N'Sofia                                             ', 1)
INSERT [dbo].[Town] ([id], [name], [country_id]) VALUES (2, N'New York                                          ', 2)
INSERT [dbo].[Town] ([id], [name], [country_id]) VALUES (3, N'Moscow                                            ', 3)
SET IDENTITY_INSERT [dbo].[Town] OFF
ALTER TABLE [dbo].[Address]  WITH CHECK ADD  CONSTRAINT [FK_Address_Town] FOREIGN KEY([town_id])
REFERENCES [dbo].[Town] ([id])
GO
ALTER TABLE [dbo].[Address] CHECK CONSTRAINT [FK_Address_Town]
GO
ALTER TABLE [dbo].[Country]  WITH CHECK ADD  CONSTRAINT [FK_Country_Contninent] FOREIGN KEY([continent_id])
REFERENCES [dbo].[Contninent] ([id])
GO
ALTER TABLE [dbo].[Country] CHECK CONSTRAINT [FK_Country_Contninent]
GO
ALTER TABLE [dbo].[Person]  WITH CHECK ADD  CONSTRAINT [FK_Person_Address] FOREIGN KEY([address_id])
REFERENCES [dbo].[Address] ([id])
GO
ALTER TABLE [dbo].[Person] CHECK CONSTRAINT [FK_Person_Address]
GO
ALTER TABLE [dbo].[Town]  WITH CHECK ADD  CONSTRAINT [FK_Town_Country] FOREIGN KEY([country_id])
REFERENCES [dbo].[Country] ([id])
GO
ALTER TABLE [dbo].[Town] CHECK CONSTRAINT [FK_Town_Country]
GO
USE [master]
GO
ALTER DATABASE [WorldData] SET  READ_WRITE 
GO
