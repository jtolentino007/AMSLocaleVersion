USE [master]
GO
/****** Object:  Database [AMSDB]    Script Date: 5/10/2017 1:44:46 PM ******/
CREATE DATABASE [AMSDB]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'STACRUZDB', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\STACRUZDB.mdf' , SIZE = 3264KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'STACRUZDB_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\STACRUZDB_log.ldf' , SIZE = 832KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [AMSDB] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [AMSDB].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [AMSDB] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [AMSDB] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [AMSDB] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [AMSDB] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [AMSDB] SET ARITHABORT OFF 
GO
ALTER DATABASE [AMSDB] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [AMSDB] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [AMSDB] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [AMSDB] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [AMSDB] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [AMSDB] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [AMSDB] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [AMSDB] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [AMSDB] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [AMSDB] SET  ENABLE_BROKER 
GO
ALTER DATABASE [AMSDB] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [AMSDB] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [AMSDB] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [AMSDB] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [AMSDB] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [AMSDB] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [AMSDB] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [AMSDB] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [AMSDB] SET  MULTI_USER 
GO
ALTER DATABASE [AMSDB] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [AMSDB] SET DB_CHAINING OFF 
GO
ALTER DATABASE [AMSDB] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [AMSDB] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [AMSDB] SET DELAYED_DURABILITY = DISABLED 
GO
USE [AMSDB]
GO
/****** Object:  Table [dbo].[Attendance]    Script Date: 5/10/2017 1:44:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Attendance](
	[Attendance_Id] [int] IDENTITY(1,1) NOT NULL,
	[Gathering_ID] [varchar](50) NOT NULL,
	[brethren_id] [nvarchar](100) NULL,
	[Church_ID] [varchar](50) NOT NULL,
	[Attendance_Status] [int] NOT NULL,
	[Real_Time] [datetime] NOT NULL,
	[is_interlocale] [bit] NOT NULL,
	[remarks] [varchar](150) NULL,
 CONSTRAINT [PK_Attendance] PRIMARY KEY CLUSTERED 
(
	[Attendance_Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Batches]    Script Date: 5/10/2017 1:44:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Batches](
	[Batch_ID] [int] IDENTITY(1,1) NOT NULL,
	[Batch_Code] [varchar](50) NOT NULL,
	[gathering_id] [int] NOT NULL CONSTRAINT [DF_Batches_gathering_id]  DEFAULT ((0)),
	[Batch_Time] [datetime] NOT NULL,
 CONSTRAINT [PK_Batches] PRIMARY KEY CLUSTERED 
(
	[Batch_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Brethren]    Script Date: 5/10/2017 1:44:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Brethren](
	[brethren_id] [nvarchar](100) NOT NULL,
	[Church_Id] [varchar](100) NULL,
	[Firstname] [varchar](100) NULL,
	[Middlename] [varchar](100) NULL,
	[Lastname] [varchar](100) NULL,
	[Image_Path] [varchar](max) NULL,
	[Sketch_Path] [varchar](max) NULL,
	[Date_Baptism] [date] NULL,
	[Date_Birth] [date] NULL,
	[Gender] [varchar](100) NULL,
	[Civil_Status] [varchar](100) NULL,
	[Street] [varchar](100) NULL,
	[Brgy] [varchar](100) NULL,
	[City_Town] [varchar](100) NULL,
	[Province] [varchar](100) NULL,
	[Region] [varchar](100) NULL,
	[Employment] [varchar](100) NULL,
	[Phone_no] [varchar](50) NULL,
	[Contact_Person] [varchar](100) NULL,
	[Contact_Person_no] [varchar](100) NULL,
	[Status] [varchar](100) NULL,
	[Remarks] [varchar](140) NULL,
	[Group_ID] [int] NULL CONSTRAINT [DF_Brethren_Group_ID]  DEFAULT ((0)),
	[Committee_Names] [varchar](250) NULL,
	[locale_id] [int] NULL CONSTRAINT [DF_Brethren_locale_id]  DEFAULT ((0)),
	[Baptizer] [varchar](200) NULL,
	[is_contact_person_member] [tinyint] NOT NULL CONSTRAINT [DF_Brethren_is_contact_person_member]  DEFAULT ((0)),
	[is_deleted] [tinyint] NOT NULL CONSTRAINT [DF_Brethren_is_deleted]  DEFAULT ((0)),
 CONSTRAINT [PK_Brethren] PRIMARY KEY CLUSTERED 
(
	[brethren_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Committee]    Script Date: 5/10/2017 1:44:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Committee](
	[committee_id] [int] IDENTITY(1,1) NOT NULL,
	[committee_name] [varchar](50) NOT NULL,
	[committee_code] [varchar](50) NULL,
	[is_deleted] [bit] NULL,
 CONSTRAINT [PK_Committee] PRIMARY KEY CLUSTERED 
(
	[committee_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Gathering]    Script Date: 5/10/2017 1:44:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Gathering](
	[Gathering_Id] [varchar](100) NOT NULL,
	[Gathering_Type] [int] NOT NULL,
	[Gathering_Week] [nvarchar](50) NOT NULL,
	[Gathering_Month] [int] NOT NULL,
	[Gathering_Year] [int] NOT NULL,
	[Viewing_Type] [varchar](50) NOT NULL,
	[Gathering_Day] [varchar](50) NOT NULL,
	[Batch_ID] [int] NOT NULL,
	[Gathering_Date] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Gathering] PRIMARY KEY CLUSTERED 
(
	[Gathering_Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Gathering_types]    Script Date: 5/10/2017 1:44:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Gathering_types](
	[gathering_id] [int] IDENTITY(1,1) NOT NULL,
	[gathering_code] [varchar](50) NULL,
	[gathering] [varchar](150) NULL,
	[is_deleted] [tinyint] NOT NULL CONSTRAINT [DF_Gathering_types_is_deleted]  DEFAULT ((0)),
 CONSTRAINT [PK_Gathering_types] PRIMARY KEY CLUSTERED 
(
	[gathering_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Group_servants]    Script Date: 5/10/2017 1:44:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Group_servants](
	[group_servants_id] [int] IDENTITY(1,1) NOT NULL,
	[servant_id] [nvarchar](50) NULL,
	[asst_servant_id] [nvarchar](50) NULL,
	[group_id] [int] NULL,
 CONSTRAINT [PK_Group_servants] PRIMARY KEY CLUSTERED 
(
	[group_servants_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Groupings]    Script Date: 5/10/2017 1:44:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Groupings](
	[Group_Id] [int] IDENTITY(1,1) NOT NULL,
	[Group_name] [varchar](50) NOT NULL,
	[servant_id] [nvarchar](50) NULL CONSTRAINT [DF_Groupings_is_deleted]  DEFAULT ((0)),
	[asst_servant_id] [nvarchar](50) NULL,
	[is_deleted] [tinyint] NOT NULL CONSTRAINT [DF_Groupings_is_deleted_1]  DEFAULT ((0)),
 CONSTRAINT [PK_Group] PRIMARY KEY CLUSTERED 
(
	[Group_Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Interlocale]    Script Date: 5/10/2017 1:44:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Interlocale](
	[Interlocale_Id] [nvarchar](100) NOT NULL,
	[Church_Id] [varchar](50) NULL,
	[Firstname] [varchar](100) NOT NULL,
	[Lastname] [varchar](100) NOT NULL,
	[Locale] [varchar](50) NOT NULL,
	[DateOfBaptism] [date] NULL,
	[Middlename] [varchar](50) NULL,
 CONSTRAINT [PK_Interlocale] PRIMARY KEY CLUSTERED 
(
	[Interlocale_Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Interlocale_Attendance]    Script Date: 5/10/2017 1:44:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Interlocale_Attendance](
	[InterlocaleAttendance_Id] [int] IDENTITY(1,1) NOT NULL,
	[Interlocale_ID] [int] NOT NULL,
	[Gathering_Id] [varchar](50) NOT NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Locale]    Script Date: 5/10/2017 1:44:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Locale](
	[locale_id] [int] IDENTITY(1,1) NOT NULL,
	[dist] [varchar](50) NOT NULL,
	[div] [varchar](50) NOT NULL,
	[address] [varchar](200) NULL,
	[image] [varchar](50) NULL,
	[locale] [varchar](50) NOT NULL,
	[locale_code] [varchar](50) NULL,
	[is_deleted] [bit] NULL,
 CONSTRAINT [PK_Locale] PRIMARY KEY CLUSTERED 
(
	[locale_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[System_Logs]    Script Date: 5/10/2017 1:44:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[System_Logs](
	[Log_ID] [int] IDENTITY(1,1) NOT NULL,
	[user_id] [int] NULL,
	[Activity] [varchar](300) NULL,
	[Date] [date] NULL,
	[Time] [time](5) NULL,
	[Module] [varchar](150) NULL,
	[Activity_Status] [int] NULL,
 CONSTRAINT [PK_System_Logs] PRIMARY KEY CLUSTERED 
(
	[Log_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tempAttendance]    Script Date: 5/10/2017 1:44:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tempAttendance](
	[tempAttendance_Id] [int] IDENTITY(1,1) NOT NULL,
	[tempGathering_ID] [varchar](50) NOT NULL,
	[temp_brethren_id] [nvarchar](100) NULL,
	[tempChurch_ID] [varchar](50) NOT NULL,
	[tempAttendance_Status] [int] NOT NULL,
	[tempReal_Time] [datetime] NOT NULL,
	[is_interlocale] [bit] NOT NULL,
	[remarks] [varchar](150) NULL,
 CONSTRAINT [PK_tempAttendance] PRIMARY KEY CLUSTERED 
(
	[tempAttendance_Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Users]    Script Date: 5/10/2017 1:44:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Users](
	[user_id] [int] IDENTITY(1,1) NOT NULL,
	[church_id] [varchar](50) NOT NULL,
	[password] [varchar](50) NOT NULL,
	[fname] [varchar](50) NOT NULL,
	[mname] [varchar](50) NULL,
	[lname] [varchar](50) NOT NULL,
	[privilege] [int] NOT NULL,
	[locale_id] [int] NOT NULL,
	[is_deleted] [bit] NULL,
	[is_approve] [bit] NULL,
	[user_img_path] [varchar](max) NULL,
 CONSTRAINT [PK_Users] PRIMARY KEY CLUSTERED 
(
	[user_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[Attendance] ON 

INSERT [dbo].[Attendance] ([Attendance_Id], [Gathering_ID], [brethren_id], [Church_ID], [Attendance_Status], [Real_Time], [is_interlocale], [remarks]) VALUES (332, N'172WSW3SAT7:30 PM', N'B-0034', N'STP00084', 1, CAST(N'1900-01-01 19:15:00.000' AS DateTime), 0, N'')
INSERT [dbo].[Attendance] ([Attendance_Id], [Gathering_ID], [brethren_id], [Church_ID], [Attendance_Status], [Real_Time], [is_interlocale], [remarks]) VALUES (333, N'172WSW3SAT7:30 PM', N'B-0023', N'STP00048', 1, CAST(N'1900-01-01 19:16:00.000' AS DateTime), 0, N'')
INSERT [dbo].[Attendance] ([Attendance_Id], [Gathering_ID], [brethren_id], [Church_ID], [Attendance_Status], [Real_Time], [is_interlocale], [remarks]) VALUES (334, N'172WSW3SAT7:30 PM', N'B-0018', N'STP00029', 1, CAST(N'1900-01-01 19:16:00.000' AS DateTime), 0, N'')
INSERT [dbo].[Attendance] ([Attendance_Id], [Gathering_ID], [brethren_id], [Church_ID], [Attendance_Status], [Real_Time], [is_interlocale], [remarks]) VALUES (335, N'172WSW3SAT7:30 PM', N'B-0032', N'11307397', 1, CAST(N'1900-01-01 19:16:00.000' AS DateTime), 0, N'')
INSERT [dbo].[Attendance] ([Attendance_Id], [Gathering_ID], [brethren_id], [Church_ID], [Attendance_Status], [Real_Time], [is_interlocale], [remarks]) VALUES (336, N'172WSW3SAT7:30 PM', N'B-0027', N'11112036', 1, CAST(N'1900-01-01 19:16:00.000' AS DateTime), 0, N'')
INSERT [dbo].[Attendance] ([Attendance_Id], [Gathering_ID], [brethren_id], [Church_ID], [Attendance_Status], [Real_Time], [is_interlocale], [remarks]) VALUES (337, N'172WSW3SAT7:30 PM', N'B-0006', N'STP00061', 1, CAST(N'1900-01-01 19:16:00.000' AS DateTime), 0, N'')
INSERT [dbo].[Attendance] ([Attendance_Id], [Gathering_ID], [brethren_id], [Church_ID], [Attendance_Status], [Real_Time], [is_interlocale], [remarks]) VALUES (338, N'172WSW3SAT7:30 PM', N'B-0042', N'11478797', 1, CAST(N'1900-01-01 19:17:00.000' AS DateTime), 0, N'')
INSERT [dbo].[Attendance] ([Attendance_Id], [Gathering_ID], [brethren_id], [Church_ID], [Attendance_Status], [Real_Time], [is_interlocale], [remarks]) VALUES (339, N'172WSW3SAT7:30 PM', N'B-0001', N'MA600030', 1, CAST(N'1900-01-01 19:18:00.000' AS DateTime), 0, N'')
INSERT [dbo].[Attendance] ([Attendance_Id], [Gathering_ID], [brethren_id], [Church_ID], [Attendance_Status], [Real_Time], [is_interlocale], [remarks]) VALUES (340, N'172WSW3SAT7:30 PM', N'B-0012', N'STP00042', 1, CAST(N'1900-01-01 19:21:00.000' AS DateTime), 0, N'')
INSERT [dbo].[Attendance] ([Attendance_Id], [Gathering_ID], [brethren_id], [Church_ID], [Attendance_Status], [Real_Time], [is_interlocale], [remarks]) VALUES (341, N'172WSW3SAT7:30 PM', N'B-0008', N'701145', 1, CAST(N'1900-01-01 19:24:00.000' AS DateTime), 0, N'')
INSERT [dbo].[Attendance] ([Attendance_Id], [Gathering_ID], [brethren_id], [Church_ID], [Attendance_Status], [Real_Time], [is_interlocale], [remarks]) VALUES (342, N'172WSW3SAT7:30 PM', N'B-0007', N'701024', 1, CAST(N'1900-01-01 19:24:00.000' AS DateTime), 0, N'')
INSERT [dbo].[Attendance] ([Attendance_Id], [Gathering_ID], [brethren_id], [Church_ID], [Attendance_Status], [Real_Time], [is_interlocale], [remarks]) VALUES (343, N'172WSW3SAT7:30 PM', N'B-0038', N'11416006', 1, CAST(N'1900-01-01 19:26:00.000' AS DateTime), 0, N'')
INSERT [dbo].[Attendance] ([Attendance_Id], [Gathering_ID], [brethren_id], [Church_ID], [Attendance_Status], [Real_Time], [is_interlocale], [remarks]) VALUES (344, N'172WSW3SAT7:30 PM', N'B-0037', N'11416458', 1, CAST(N'1900-01-01 19:26:00.000' AS DateTime), 0, N'')
INSERT [dbo].[Attendance] ([Attendance_Id], [Gathering_ID], [brethren_id], [Church_ID], [Attendance_Status], [Real_Time], [is_interlocale], [remarks]) VALUES (345, N'172WSW3SAT7:30 PM', N'B-0036', N'11403632', 1, CAST(N'1900-01-01 19:28:00.000' AS DateTime), 0, N'')
INSERT [dbo].[Attendance] ([Attendance_Id], [Gathering_ID], [brethren_id], [Church_ID], [Attendance_Status], [Real_Time], [is_interlocale], [remarks]) VALUES (346, N'172WSW3SAT7:30 PM', N'IL-3', N'STP00009', 1, CAST(N'1900-01-01 19:30:00.000' AS DateTime), 1, N'ACC')
INSERT [dbo].[Attendance] ([Attendance_Id], [Gathering_ID], [brethren_id], [Church_ID], [Attendance_Status], [Real_Time], [is_interlocale], [remarks]) VALUES (347, N'172WSW3SAT7:30 PM', N'B-0028', N'808939', 1, CAST(N'1900-01-01 19:31:00.000' AS DateTime), 0, N'')
INSERT [dbo].[Attendance] ([Attendance_Id], [Gathering_ID], [brethren_id], [Church_ID], [Attendance_Status], [Real_Time], [is_interlocale], [remarks]) VALUES (348, N'172WSW3SAT7:30 PM', N'B-0016', N'STP00111', 1, CAST(N'1900-01-01 19:34:00.000' AS DateTime), 0, N'')
INSERT [dbo].[Attendance] ([Attendance_Id], [Gathering_ID], [brethren_id], [Church_ID], [Attendance_Status], [Real_Time], [is_interlocale], [remarks]) VALUES (349, N'172WSW3SAT7:30 PM', N'B-0019', N'STP00057', 1, CAST(N'1900-01-01 19:35:00.000' AS DateTime), 0, N'')
INSERT [dbo].[Attendance] ([Attendance_Id], [Gathering_ID], [brethren_id], [Church_ID], [Attendance_Status], [Real_Time], [is_interlocale], [remarks]) VALUES (350, N'172WSW3SAT7:30 PM', N'B-0052', N'11604440', 1, CAST(N'1900-01-01 19:36:00.000' AS DateTime), 0, N'')
INSERT [dbo].[Attendance] ([Attendance_Id], [Gathering_ID], [brethren_id], [Church_ID], [Attendance_Status], [Real_Time], [is_interlocale], [remarks]) VALUES (351, N'172WSW3SAT7:30 PM', N'B-0053', N'11604442', 1, CAST(N'1900-01-01 19:36:00.000' AS DateTime), 0, N'')
INSERT [dbo].[Attendance] ([Attendance_Id], [Gathering_ID], [brethren_id], [Church_ID], [Attendance_Status], [Real_Time], [is_interlocale], [remarks]) VALUES (352, N'172WSW3SAT7:30 PM', N'B-0021', N'STP00012', 1, CAST(N'1900-01-01 19:37:00.000' AS DateTime), 0, N'')
INSERT [dbo].[Attendance] ([Attendance_Id], [Gathering_ID], [brethren_id], [Church_ID], [Attendance_Status], [Real_Time], [is_interlocale], [remarks]) VALUES (353, N'172WSW3SAT7:30 PM', N'B-65', N'STP00002', 1, CAST(N'1900-01-01 19:39:00.000' AS DateTime), 0, N'')
INSERT [dbo].[Attendance] ([Attendance_Id], [Gathering_ID], [brethren_id], [Church_ID], [Attendance_Status], [Real_Time], [is_interlocale], [remarks]) VALUES (354, N'172WSW3SAT7:30 PM', N'IL-2', N'STP00017', 1, CAST(N'1900-01-01 19:41:00.000' AS DateTime), 1, N'FLORIDABLANCA')
INSERT [dbo].[Attendance] ([Attendance_Id], [Gathering_ID], [brethren_id], [Church_ID], [Attendance_Status], [Real_Time], [is_interlocale], [remarks]) VALUES (355, N'172WSW3SAT7:30 PM', N'IL-5', N'11700481', 1, CAST(N'1900-01-01 19:41:00.000' AS DateTime), 1, N'FLORIDABLANCA')
INSERT [dbo].[Attendance] ([Attendance_Id], [Gathering_ID], [brethren_id], [Church_ID], [Attendance_Status], [Real_Time], [is_interlocale], [remarks]) VALUES (356, N'172WSW3SAT7:30 PM', N'IL-6', N'STP00056', 1, CAST(N'1900-01-01 19:42:00.000' AS DateTime), 1, N'ACC')
INSERT [dbo].[Attendance] ([Attendance_Id], [Gathering_ID], [brethren_id], [Church_ID], [Attendance_Status], [Real_Time], [is_interlocale], [remarks]) VALUES (357, N'172WSW3SAT7:30 PM', N'IL-4', N'00703240', 1, CAST(N'1900-01-01 19:47:00.000' AS DateTime), 1, N'MARISOL')
INSERT [dbo].[Attendance] ([Attendance_Id], [Gathering_ID], [brethren_id], [Church_ID], [Attendance_Status], [Real_Time], [is_interlocale], [remarks]) VALUES (358, N'172WSW3SAT7:30 PM', N'B-0026', N'11112207', 1, CAST(N'1900-01-01 19:51:00.000' AS DateTime), 0, N'')
INSERT [dbo].[Attendance] ([Attendance_Id], [Gathering_ID], [brethren_id], [Church_ID], [Attendance_Status], [Real_Time], [is_interlocale], [remarks]) VALUES (359, N'172WSW3SAT7:30 PM', N'B-64', N'STP00106', 1, CAST(N'1900-01-01 21:09:00.000' AS DateTime), 0, N'')
INSERT [dbo].[Attendance] ([Attendance_Id], [Gathering_ID], [brethren_id], [Church_ID], [Attendance_Status], [Real_Time], [is_interlocale], [remarks]) VALUES (394, N'172SPMW2SUN5:30 PM', N'B-0018', N'STP00029', 1, CAST(N'1900-01-01 07:26:00.000' AS DateTime), 0, N'')
INSERT [dbo].[Attendance] ([Attendance_Id], [Gathering_ID], [brethren_id], [Church_ID], [Attendance_Status], [Real_Time], [is_interlocale], [remarks]) VALUES (395, N'172SPMW2SUN5:30 PM', N'B-0031', N'701653', 1, CAST(N'1900-01-01 07:26:00.000' AS DateTime), 0, N'')
INSERT [dbo].[Attendance] ([Attendance_Id], [Gathering_ID], [brethren_id], [Church_ID], [Attendance_Status], [Real_Time], [is_interlocale], [remarks]) VALUES (396, N'172SPMW2SUN5:30 PM', N'B-0006', N'STP00061', 1, CAST(N'1900-01-01 07:26:00.000' AS DateTime), 0, N'')
INSERT [dbo].[Attendance] ([Attendance_Id], [Gathering_ID], [brethren_id], [Church_ID], [Attendance_Status], [Real_Time], [is_interlocale], [remarks]) VALUES (397, N'172SPMW2SUN5:30 PM', N'B-0032', N'11307397', 1, CAST(N'1900-01-01 07:26:00.000' AS DateTime), 0, N'')
INSERT [dbo].[Attendance] ([Attendance_Id], [Gathering_ID], [brethren_id], [Church_ID], [Attendance_Status], [Real_Time], [is_interlocale], [remarks]) VALUES (398, N'172SPMW2SUN5:30 PM', N'B-0028', N'808939', 1, CAST(N'1900-01-01 07:26:00.000' AS DateTime), 0, N'')
INSERT [dbo].[Attendance] ([Attendance_Id], [Gathering_ID], [brethren_id], [Church_ID], [Attendance_Status], [Real_Time], [is_interlocale], [remarks]) VALUES (399, N'172SPMW2SUN5:30 PM', N'IL-3', N'STP00009', 1, CAST(N'1900-01-01 07:26:00.000' AS DateTime), 1, N'ACC')
INSERT [dbo].[Attendance] ([Attendance_Id], [Gathering_ID], [brethren_id], [Church_ID], [Attendance_Status], [Real_Time], [is_interlocale], [remarks]) VALUES (400, N'172SPMW2SUN5:30 PM', N'B-64', N'STP00106', 1, CAST(N'1900-01-01 07:26:00.000' AS DateTime), 0, N'')
INSERT [dbo].[Attendance] ([Attendance_Id], [Gathering_ID], [brethren_id], [Church_ID], [Attendance_Status], [Real_Time], [is_interlocale], [remarks]) VALUES (401, N'172SPMW2SUN5:30 PM', N'B-0052', N'11604440', 1, CAST(N'1900-01-01 07:27:00.000' AS DateTime), 0, N'')
INSERT [dbo].[Attendance] ([Attendance_Id], [Gathering_ID], [brethren_id], [Church_ID], [Attendance_Status], [Real_Time], [is_interlocale], [remarks]) VALUES (402, N'172SPMW2SUN5:30 PM', N'B-0053', N'11604442', 1, CAST(N'1900-01-01 07:27:00.000' AS DateTime), 0, N'')
INSERT [dbo].[Attendance] ([Attendance_Id], [Gathering_ID], [brethren_id], [Church_ID], [Attendance_Status], [Real_Time], [is_interlocale], [remarks]) VALUES (403, N'172SPMW2SUN5:30 PM', N'B-0042', N'11478797', 1, CAST(N'1900-01-01 07:27:00.000' AS DateTime), 0, N'')
INSERT [dbo].[Attendance] ([Attendance_Id], [Gathering_ID], [brethren_id], [Church_ID], [Attendance_Status], [Real_Time], [is_interlocale], [remarks]) VALUES (404, N'172SPMW2SUN5:30 PM', N'B-0001', N'MA600030', 1, CAST(N'1900-01-01 07:27:00.000' AS DateTime), 0, N'')
INSERT [dbo].[Attendance] ([Attendance_Id], [Gathering_ID], [brethren_id], [Church_ID], [Attendance_Status], [Real_Time], [is_interlocale], [remarks]) VALUES (405, N'172SPMW2SUN5:30 PM', N'B-0023', N'STP00048', 1, CAST(N'1900-01-01 07:27:00.000' AS DateTime), 0, N'')
INSERT [dbo].[Attendance] ([Attendance_Id], [Gathering_ID], [brethren_id], [Church_ID], [Attendance_Status], [Real_Time], [is_interlocale], [remarks]) VALUES (406, N'172SPMW2SUN5:30 PM', N'B-0034', N'STP00084', 1, CAST(N'1900-01-01 07:27:00.000' AS DateTime), 0, N'')
INSERT [dbo].[Attendance] ([Attendance_Id], [Gathering_ID], [brethren_id], [Church_ID], [Attendance_Status], [Real_Time], [is_interlocale], [remarks]) VALUES (407, N'172SPMW2SUN5:30 PM', N'B-0019', N'STP00057', 1, CAST(N'1900-01-01 07:27:00.000' AS DateTime), 0, N'')
INSERT [dbo].[Attendance] ([Attendance_Id], [Gathering_ID], [brethren_id], [Church_ID], [Attendance_Status], [Real_Time], [is_interlocale], [remarks]) VALUES (408, N'172SPMW2SUN5:30 PM', N'B-0021', N'STP00012', 1, CAST(N'1900-01-01 07:27:00.000' AS DateTime), 0, N'')
INSERT [dbo].[Attendance] ([Attendance_Id], [Gathering_ID], [brethren_id], [Church_ID], [Attendance_Status], [Real_Time], [is_interlocale], [remarks]) VALUES (409, N'172SPMW2SUN5:30 PM', N'B-0014', N'STP00096', 1, CAST(N'1900-01-01 07:28:00.000' AS DateTime), 0, N'')
INSERT [dbo].[Attendance] ([Attendance_Id], [Gathering_ID], [brethren_id], [Church_ID], [Attendance_Status], [Real_Time], [is_interlocale], [remarks]) VALUES (410, N'172SPMW2SUN5:30 PM', N'B-0015', N'STP00097', 1, CAST(N'1900-01-01 07:28:00.000' AS DateTime), 0, N'')
INSERT [dbo].[Attendance] ([Attendance_Id], [Gathering_ID], [brethren_id], [Church_ID], [Attendance_Status], [Real_Time], [is_interlocale], [remarks]) VALUES (411, N'172SPMW2SUN5:30 PM', N'B-0027', N'11112036', 1, CAST(N'1900-01-01 07:28:00.000' AS DateTime), 0, N'')
INSERT [dbo].[Attendance] ([Attendance_Id], [Gathering_ID], [brethren_id], [Church_ID], [Attendance_Status], [Real_Time], [is_interlocale], [remarks]) VALUES (412, N'172SPMW2SUN5:30 PM', N'B-0026', N'11112207', 1, CAST(N'1900-01-01 07:28:00.000' AS DateTime), 0, N'')
INSERT [dbo].[Attendance] ([Attendance_Id], [Gathering_ID], [brethren_id], [Church_ID], [Attendance_Status], [Real_Time], [is_interlocale], [remarks]) VALUES (526, N'172TGPW2SUN6:00 AM', N'B-0007', N'701024', 1, CAST(N'1900-01-01 06:49:00.000' AS DateTime), 0, N'')
INSERT [dbo].[Attendance] ([Attendance_Id], [Gathering_ID], [brethren_id], [Church_ID], [Attendance_Status], [Real_Time], [is_interlocale], [remarks]) VALUES (527, N'172TGPW2SUN6:00 AM', N'B-0008', N'701145', 1, CAST(N'1900-01-01 06:49:00.000' AS DateTime), 0, N'')
INSERT [dbo].[Attendance] ([Attendance_Id], [Gathering_ID], [brethren_id], [Church_ID], [Attendance_Status], [Real_Time], [is_interlocale], [remarks]) VALUES (528, N'172TGPW2SUN6:00 AM', N'B-0041', N'11422172', 1, CAST(N'1900-01-01 06:49:00.000' AS DateTime), 0, N'')
INSERT [dbo].[Attendance] ([Attendance_Id], [Gathering_ID], [brethren_id], [Church_ID], [Attendance_Status], [Real_Time], [is_interlocale], [remarks]) VALUES (529, N'172TGPW2SUN6:00 AM', N'B-0037', N'11416458', 1, CAST(N'1900-01-01 06:49:00.000' AS DateTime), 0, N'')
INSERT [dbo].[Attendance] ([Attendance_Id], [Gathering_ID], [brethren_id], [Church_ID], [Attendance_Status], [Real_Time], [is_interlocale], [remarks]) VALUES (530, N'172TGPW2SUN6:00 AM', N'B-0038', N'11416006', 1, CAST(N'1900-01-01 06:49:00.000' AS DateTime), 0, N'')
INSERT [dbo].[Attendance] ([Attendance_Id], [Gathering_ID], [brethren_id], [Church_ID], [Attendance_Status], [Real_Time], [is_interlocale], [remarks]) VALUES (531, N'172TGPW2SUN6:00 AM', N'B-0002', N'STP00125', 1, CAST(N'1900-01-01 06:49:00.000' AS DateTime), 0, N'')
INSERT [dbo].[Attendance] ([Attendance_Id], [Gathering_ID], [brethren_id], [Church_ID], [Attendance_Status], [Real_Time], [is_interlocale], [remarks]) VALUES (532, N'172TGPW2SUN6:00 AM', N'B-0055', N'STP00039', 1, CAST(N'1900-01-01 06:49:00.000' AS DateTime), 0, N'')
INSERT [dbo].[Attendance] ([Attendance_Id], [Gathering_ID], [brethren_id], [Church_ID], [Attendance_Status], [Real_Time], [is_interlocale], [remarks]) VALUES (533, N'172TGPW2SUN6:00 AM', N'B-0033', N'11308026', 1, CAST(N'1900-01-01 06:49:00.000' AS DateTime), 0, N'')
INSERT [dbo].[Attendance] ([Attendance_Id], [Gathering_ID], [brethren_id], [Church_ID], [Attendance_Status], [Real_Time], [is_interlocale], [remarks]) VALUES (534, N'172TGPW2SUN6:00 AM', N'B-0052', N'11604440', 1, CAST(N'1900-01-01 06:49:00.000' AS DateTime), 0, N'')
INSERT [dbo].[Attendance] ([Attendance_Id], [Gathering_ID], [brethren_id], [Church_ID], [Attendance_Status], [Real_Time], [is_interlocale], [remarks]) VALUES (535, N'172TGPW2SUN6:00 AM', N'B-0053', N'11604442', 1, CAST(N'1900-01-01 06:50:00.000' AS DateTime), 0, N'')
INSERT [dbo].[Attendance] ([Attendance_Id], [Gathering_ID], [brethren_id], [Church_ID], [Attendance_Status], [Real_Time], [is_interlocale], [remarks]) VALUES (536, N'172TGPW2SUN6:00 AM', N'B-0027', N'11112036', 1, CAST(N'1900-01-01 06:50:00.000' AS DateTime), 0, N'')
INSERT [dbo].[Attendance] ([Attendance_Id], [Gathering_ID], [brethren_id], [Church_ID], [Attendance_Status], [Real_Time], [is_interlocale], [remarks]) VALUES (537, N'172TGPW2SUN6:00 AM', N'B-0045', N'STP00008', 1, CAST(N'1900-01-01 06:50:00.000' AS DateTime), 0, N'')
INSERT [dbo].[Attendance] ([Attendance_Id], [Gathering_ID], [brethren_id], [Church_ID], [Attendance_Status], [Real_Time], [is_interlocale], [remarks]) VALUES (538, N'172TGPW2SUN6:00 AM', N'B-0018', N'STP00029', 1, CAST(N'1900-01-01 06:50:00.000' AS DateTime), 0, N'')
INSERT [dbo].[Attendance] ([Attendance_Id], [Gathering_ID], [brethren_id], [Church_ID], [Attendance_Status], [Real_Time], [is_interlocale], [remarks]) VALUES (539, N'172TGPW2SUN6:00 AM', N'B-0034', N'STP00084', 1, CAST(N'1900-01-01 06:50:00.000' AS DateTime), 0, N'')
INSERT [dbo].[Attendance] ([Attendance_Id], [Gathering_ID], [brethren_id], [Church_ID], [Attendance_Status], [Real_Time], [is_interlocale], [remarks]) VALUES (540, N'172TGPW2SUN6:00 AM', N'B-0023', N'STP00048', 1, CAST(N'1900-01-01 06:50:00.000' AS DateTime), 0, N'')
INSERT [dbo].[Attendance] ([Attendance_Id], [Gathering_ID], [brethren_id], [Church_ID], [Attendance_Status], [Real_Time], [is_interlocale], [remarks]) VALUES (541, N'172TGPW2SUN6:00 AM', N'B-0026', N'11112207', 2, CAST(N'1900-01-01 07:02:00.000' AS DateTime), 0, N'')
INSERT [dbo].[Attendance] ([Attendance_Id], [Gathering_ID], [brethren_id], [Church_ID], [Attendance_Status], [Real_Time], [is_interlocale], [remarks]) VALUES (542, N'172TGPW2SUN6:00 AM', N'B-0042', N'11478797', 2, CAST(N'1900-01-01 07:13:00.000' AS DateTime), 0, N'')
INSERT [dbo].[Attendance] ([Attendance_Id], [Gathering_ID], [brethren_id], [Church_ID], [Attendance_Status], [Real_Time], [is_interlocale], [remarks]) VALUES (690, N'172PMW3WED7:30 PM', N'B-0033', N'11308026', 1, CAST(N'1900-01-01 19:20:00.000' AS DateTime), 0, N'')
INSERT [dbo].[Attendance] ([Attendance_Id], [Gathering_ID], [brethren_id], [Church_ID], [Attendance_Status], [Real_Time], [is_interlocale], [remarks]) VALUES (691, N'172PMW3WED7:30 PM', N'B-0027', N'11112036', 1, CAST(N'1900-01-01 19:20:00.000' AS DateTime), 0, N'')
INSERT [dbo].[Attendance] ([Attendance_Id], [Gathering_ID], [brethren_id], [Church_ID], [Attendance_Status], [Real_Time], [is_interlocale], [remarks]) VALUES (692, N'172PMW3WED7:30 PM', N'B-0001', N'MA600030', 1, CAST(N'1900-01-01 19:20:00.000' AS DateTime), 0, N'')
INSERT [dbo].[Attendance] ([Attendance_Id], [Gathering_ID], [brethren_id], [Church_ID], [Attendance_Status], [Real_Time], [is_interlocale], [remarks]) VALUES (693, N'172PMW3WED7:30 PM', N'B-0012', N'STP00042', 1, CAST(N'1900-01-01 19:20:00.000' AS DateTime), 0, N'')
INSERT [dbo].[Attendance] ([Attendance_Id], [Gathering_ID], [brethren_id], [Church_ID], [Attendance_Status], [Real_Time], [is_interlocale], [remarks]) VALUES (694, N'172PMW3WED7:30 PM', N'B-0061', N'STP00079', 1, CAST(N'1900-01-01 19:20:00.000' AS DateTime), 0, N'')
INSERT [dbo].[Attendance] ([Attendance_Id], [Gathering_ID], [brethren_id], [Church_ID], [Attendance_Status], [Real_Time], [is_interlocale], [remarks]) VALUES (695, N'172PMW3WED7:30 PM', N'B-0032', N'11307397', 1, CAST(N'1900-01-01 19:20:00.000' AS DateTime), 0, N'')
INSERT [dbo].[Attendance] ([Attendance_Id], [Gathering_ID], [brethren_id], [Church_ID], [Attendance_Status], [Real_Time], [is_interlocale], [remarks]) VALUES (696, N'172PMW3WED7:30 PM', N'B-0023', N'STP00048', 1, CAST(N'1900-01-01 19:20:00.000' AS DateTime), 0, N'')
INSERT [dbo].[Attendance] ([Attendance_Id], [Gathering_ID], [brethren_id], [Church_ID], [Attendance_Status], [Real_Time], [is_interlocale], [remarks]) VALUES (697, N'172PMW3WED7:30 PM', N'B-0034', N'STP00084', 1, CAST(N'1900-01-01 19:21:00.000' AS DateTime), 0, N'')
INSERT [dbo].[Attendance] ([Attendance_Id], [Gathering_ID], [brethren_id], [Church_ID], [Attendance_Status], [Real_Time], [is_interlocale], [remarks]) VALUES (698, N'172PMW3WED7:30 PM', N'B-0036', N'11403632', 1, CAST(N'1900-01-01 19:29:00.000' AS DateTime), 0, N'')
INSERT [dbo].[Attendance] ([Attendance_Id], [Gathering_ID], [brethren_id], [Church_ID], [Attendance_Status], [Real_Time], [is_interlocale], [remarks]) VALUES (699, N'172PMW3WED7:30 PM', N'B-0028', N'808939', 1, CAST(N'1900-01-01 19:29:00.000' AS DateTime), 0, N'')
INSERT [dbo].[Attendance] ([Attendance_Id], [Gathering_ID], [brethren_id], [Church_ID], [Attendance_Status], [Real_Time], [is_interlocale], [remarks]) VALUES (700, N'172PMW3WED7:30 PM', N'IL-7', N'ANG00235', 1, CAST(N'1900-01-01 19:31:00.000' AS DateTime), 1, N'ACC')
INSERT [dbo].[Attendance] ([Attendance_Id], [Gathering_ID], [brethren_id], [Church_ID], [Attendance_Status], [Real_Time], [is_interlocale], [remarks]) VALUES (701, N'172PMW3WED7:30 PM', N'IL-8', N'ANG00067', 1, CAST(N'1900-01-01 19:31:00.000' AS DateTime), 1, N'ACC')
INSERT [dbo].[Attendance] ([Attendance_Id], [Gathering_ID], [brethren_id], [Church_ID], [Attendance_Status], [Real_Time], [is_interlocale], [remarks]) VALUES (702, N'172PMW3WED7:30 PM', N'IL-3', N'STP00009', 1, CAST(N'1900-01-01 19:32:00.000' AS DateTime), 1, N'ACC')
INSERT [dbo].[Attendance] ([Attendance_Id], [Gathering_ID], [brethren_id], [Church_ID], [Attendance_Status], [Real_Time], [is_interlocale], [remarks]) VALUES (703, N'172PMW3WED7:30 PM', N'B-64', N'STP00106', 1, CAST(N'1900-01-01 19:33:00.000' AS DateTime), 0, N'')
INSERT [dbo].[Attendance] ([Attendance_Id], [Gathering_ID], [brethren_id], [Church_ID], [Attendance_Status], [Real_Time], [is_interlocale], [remarks]) VALUES (704, N'172PMW3WED7:30 PM', N'B-0015', N'STP00097', 1, CAST(N'1900-01-01 19:36:00.000' AS DateTime), 0, N'')
INSERT [dbo].[Attendance] ([Attendance_Id], [Gathering_ID], [brethren_id], [Church_ID], [Attendance_Status], [Real_Time], [is_interlocale], [remarks]) VALUES (705, N'172PMW3WED7:30 PM', N'B-0014', N'STP00096', 1, CAST(N'1900-01-01 19:37:00.000' AS DateTime), 0, N'')
INSERT [dbo].[Attendance] ([Attendance_Id], [Gathering_ID], [brethren_id], [Church_ID], [Attendance_Status], [Real_Time], [is_interlocale], [remarks]) VALUES (706, N'172PMW3WED7:30 PM', N'B-0008', N'701145', 1, CAST(N'1900-01-01 19:40:00.000' AS DateTime), 0, N'')
INSERT [dbo].[Attendance] ([Attendance_Id], [Gathering_ID], [brethren_id], [Church_ID], [Attendance_Status], [Real_Time], [is_interlocale], [remarks]) VALUES (707, N'172PMW3WED7:30 PM', N'B-0019', N'STP00057', 1, CAST(N'1900-01-01 19:42:00.000' AS DateTime), 0, N'')
INSERT [dbo].[Attendance] ([Attendance_Id], [Gathering_ID], [brethren_id], [Church_ID], [Attendance_Status], [Real_Time], [is_interlocale], [remarks]) VALUES (708, N'172PMW3WED7:30 PM', N'B-0045', N'STP00008', 1, CAST(N'1900-01-01 19:46:00.000' AS DateTime), 0, N'')
INSERT [dbo].[Attendance] ([Attendance_Id], [Gathering_ID], [brethren_id], [Church_ID], [Attendance_Status], [Real_Time], [is_interlocale], [remarks]) VALUES (709, N'172PMW3WED7:30 PM', N'B-0052', N'11604440', 1, CAST(N'1900-01-01 19:47:00.000' AS DateTime), 0, N'')
INSERT [dbo].[Attendance] ([Attendance_Id], [Gathering_ID], [brethren_id], [Church_ID], [Attendance_Status], [Real_Time], [is_interlocale], [remarks]) VALUES (710, N'172PMW3WED7:30 PM', N'B-0002', N'STP00125', 1, CAST(N'1900-01-01 19:52:00.000' AS DateTime), 0, N'')
INSERT [dbo].[Attendance] ([Attendance_Id], [Gathering_ID], [brethren_id], [Church_ID], [Attendance_Status], [Real_Time], [is_interlocale], [remarks]) VALUES (711, N'172PMW3WED7:30 PM', N'B-0026', N'11112207', 1, CAST(N'1900-01-01 20:00:00.000' AS DateTime), 0, N'')
INSERT [dbo].[Attendance] ([Attendance_Id], [Gathering_ID], [brethren_id], [Church_ID], [Attendance_Status], [Real_Time], [is_interlocale], [remarks]) VALUES (712, N'172PMW3WED7:30 PM', N'B-0021', N'STP00012', 1, CAST(N'1900-01-01 20:01:00.000' AS DateTime), 0, N'')
INSERT [dbo].[Attendance] ([Attendance_Id], [Gathering_ID], [brethren_id], [Church_ID], [Attendance_Status], [Real_Time], [is_interlocale], [remarks]) VALUES (713, N'172PMW3WED7:30 PM', N'B-0037', N'11416458', 1, CAST(N'1900-01-01 20:01:00.000' AS DateTime), 0, N'')
INSERT [dbo].[Attendance] ([Attendance_Id], [Gathering_ID], [brethren_id], [Church_ID], [Attendance_Status], [Real_Time], [is_interlocale], [remarks]) VALUES (714, N'172PMW3WED7:30 PM', N'B-0038', N'11416006', 1, CAST(N'1900-01-01 20:01:00.000' AS DateTime), 0, N'')
INSERT [dbo].[Attendance] ([Attendance_Id], [Gathering_ID], [brethren_id], [Church_ID], [Attendance_Status], [Real_Time], [is_interlocale], [remarks]) VALUES (715, N'172PMW3WED7:30 PM', N'B-0060', N'STP00080', 2, CAST(N'1900-01-01 20:04:00.000' AS DateTime), 0, N'')
INSERT [dbo].[Attendance] ([Attendance_Id], [Gathering_ID], [brethren_id], [Church_ID], [Attendance_Status], [Real_Time], [is_interlocale], [remarks]) VALUES (716, N'172PMW3WED7:30 PM', N'B-0003', N'STP00122', 2, CAST(N'1900-01-01 20:04:00.000' AS DateTime), 0, N'')
INSERT [dbo].[Attendance] ([Attendance_Id], [Gathering_ID], [brethren_id], [Church_ID], [Attendance_Status], [Real_Time], [is_interlocale], [remarks]) VALUES (717, N'172PMW3WED7:30 PM', N'B-0058', N'11612756', 1, CAST(N'1900-01-01 20:25:00.000' AS DateTime), 0, N'')
INSERT [dbo].[Attendance] ([Attendance_Id], [Gathering_ID], [brethren_id], [Church_ID], [Attendance_Status], [Real_Time], [is_interlocale], [remarks]) VALUES (718, N'172WSW4SAT7:30 PM', N'B-0033', N'11308026', 1, CAST(N'1900-01-01 19:20:00.000' AS DateTime), 0, N'')
INSERT [dbo].[Attendance] ([Attendance_Id], [Gathering_ID], [brethren_id], [Church_ID], [Attendance_Status], [Real_Time], [is_interlocale], [remarks]) VALUES (719, N'172WSW4SAT7:30 PM', N'B-0023', N'STP00048', 1, CAST(N'1900-01-01 19:20:00.000' AS DateTime), 0, N'')
INSERT [dbo].[Attendance] ([Attendance_Id], [Gathering_ID], [brethren_id], [Church_ID], [Attendance_Status], [Real_Time], [is_interlocale], [remarks]) VALUES (720, N'172WSW4SAT7:30 PM', N'B-0034', N'STP00084', 1, CAST(N'1900-01-01 19:20:00.000' AS DateTime), 0, N'')
INSERT [dbo].[Attendance] ([Attendance_Id], [Gathering_ID], [brethren_id], [Church_ID], [Attendance_Status], [Real_Time], [is_interlocale], [remarks]) VALUES (721, N'172WSW4SAT7:30 PM', N'B-0061', N'STP00079', 1, CAST(N'1900-01-01 19:20:00.000' AS DateTime), 0, N'')
INSERT [dbo].[Attendance] ([Attendance_Id], [Gathering_ID], [brethren_id], [Church_ID], [Attendance_Status], [Real_Time], [is_interlocale], [remarks]) VALUES (722, N'172WSW4SAT7:30 PM', N'B-0001', N'MA600030', 1, CAST(N'1900-01-01 19:20:00.000' AS DateTime), 0, N'')
INSERT [dbo].[Attendance] ([Attendance_Id], [Gathering_ID], [brethren_id], [Church_ID], [Attendance_Status], [Real_Time], [is_interlocale], [remarks]) VALUES (723, N'172WSW4SAT7:30 PM', N'B-0027', N'11112036', 1, CAST(N'1900-01-01 19:20:00.000' AS DateTime), 0, N'')
INSERT [dbo].[Attendance] ([Attendance_Id], [Gathering_ID], [brethren_id], [Church_ID], [Attendance_Status], [Real_Time], [is_interlocale], [remarks]) VALUES (724, N'172WSW4SAT7:30 PM', N'B-0012', N'STP00042', 1, CAST(N'1900-01-01 19:20:00.000' AS DateTime), 0, N'')
GO
INSERT [dbo].[Attendance] ([Attendance_Id], [Gathering_ID], [brethren_id], [Church_ID], [Attendance_Status], [Real_Time], [is_interlocale], [remarks]) VALUES (725, N'172WSW4SAT7:30 PM', N'IL-9', N'00900914', 1, CAST(N'1900-01-01 19:22:00.000' AS DateTime), 1, N'MANIBAUG')
INSERT [dbo].[Attendance] ([Attendance_Id], [Gathering_ID], [brethren_id], [Church_ID], [Attendance_Status], [Real_Time], [is_interlocale], [remarks]) VALUES (726, N'172WSW4SAT7:30 PM', N'B-0053', N'11604442', 1, CAST(N'1900-01-01 19:23:00.000' AS DateTime), 0, N'')
INSERT [dbo].[Attendance] ([Attendance_Id], [Gathering_ID], [brethren_id], [Church_ID], [Attendance_Status], [Real_Time], [is_interlocale], [remarks]) VALUES (727, N'172WSW4SAT7:30 PM', N'B-66', N'STP00042', 1, CAST(N'1900-01-01 19:25:00.000' AS DateTime), 0, N'')
INSERT [dbo].[Attendance] ([Attendance_Id], [Gathering_ID], [brethren_id], [Church_ID], [Attendance_Status], [Real_Time], [is_interlocale], [remarks]) VALUES (728, N'172WSW4SAT7:30 PM', N'IL-7', N'ANG00235', 1, CAST(N'1900-01-01 19:26:00.000' AS DateTime), 1, N'ACC')
INSERT [dbo].[Attendance] ([Attendance_Id], [Gathering_ID], [brethren_id], [Church_ID], [Attendance_Status], [Real_Time], [is_interlocale], [remarks]) VALUES (729, N'172WSW4SAT7:30 PM', N'IL-8', N'ANG00067', 1, CAST(N'1900-01-01 19:26:00.000' AS DateTime), 1, N'ACC')
INSERT [dbo].[Attendance] ([Attendance_Id], [Gathering_ID], [brethren_id], [Church_ID], [Attendance_Status], [Real_Time], [is_interlocale], [remarks]) VALUES (730, N'172WSW4SAT7:30 PM', N'B-0038', N'11416006', 1, CAST(N'1900-01-01 19:26:00.000' AS DateTime), 0, N'')
INSERT [dbo].[Attendance] ([Attendance_Id], [Gathering_ID], [brethren_id], [Church_ID], [Attendance_Status], [Real_Time], [is_interlocale], [remarks]) VALUES (731, N'172WSW4SAT7:30 PM', N'B-0037', N'11416458', 1, CAST(N'1900-01-01 19:26:00.000' AS DateTime), 0, N'')
INSERT [dbo].[Attendance] ([Attendance_Id], [Gathering_ID], [brethren_id], [Church_ID], [Attendance_Status], [Real_Time], [is_interlocale], [remarks]) VALUES (732, N'172WSW4SAT7:30 PM', N'B-64', N'STP00106', 1, CAST(N'1900-01-01 19:27:00.000' AS DateTime), 0, N'')
INSERT [dbo].[Attendance] ([Attendance_Id], [Gathering_ID], [brethren_id], [Church_ID], [Attendance_Status], [Real_Time], [is_interlocale], [remarks]) VALUES (733, N'172WSW4SAT7:30 PM', N'IL-4', N'00703240', 1, CAST(N'1900-01-01 19:27:00.000' AS DateTime), 1, N'MARISOL')
INSERT [dbo].[Attendance] ([Attendance_Id], [Gathering_ID], [brethren_id], [Church_ID], [Attendance_Status], [Real_Time], [is_interlocale], [remarks]) VALUES (734, N'172WSW4SAT7:30 PM', N'B-0016', N'STP00111', 1, CAST(N'1900-01-01 19:27:00.000' AS DateTime), 0, N'')
INSERT [dbo].[Attendance] ([Attendance_Id], [Gathering_ID], [brethren_id], [Church_ID], [Attendance_Status], [Real_Time], [is_interlocale], [remarks]) VALUES (735, N'172WSW4SAT7:30 PM', N'IL-6', N'STP00056', 1, CAST(N'1900-01-01 19:30:00.000' AS DateTime), 1, N'ACC')
INSERT [dbo].[Attendance] ([Attendance_Id], [Gathering_ID], [brethren_id], [Church_ID], [Attendance_Status], [Real_Time], [is_interlocale], [remarks]) VALUES (736, N'172WSW4SAT7:30 PM', N'B-0008', N'701145', 1, CAST(N'1900-01-01 19:30:00.000' AS DateTime), 0, N'')
INSERT [dbo].[Attendance] ([Attendance_Id], [Gathering_ID], [brethren_id], [Church_ID], [Attendance_Status], [Real_Time], [is_interlocale], [remarks]) VALUES (737, N'172WSW4SAT7:30 PM', N'B-0028', N'808939', 1, CAST(N'1900-01-01 19:33:00.000' AS DateTime), 0, N'')
INSERT [dbo].[Attendance] ([Attendance_Id], [Gathering_ID], [brethren_id], [Church_ID], [Attendance_Status], [Real_Time], [is_interlocale], [remarks]) VALUES (738, N'172WSW4SAT7:30 PM', N'IL-3', N'STP00009', 1, CAST(N'1900-01-01 19:35:00.000' AS DateTime), 1, N'ACC')
INSERT [dbo].[Attendance] ([Attendance_Id], [Gathering_ID], [brethren_id], [Church_ID], [Attendance_Status], [Real_Time], [is_interlocale], [remarks]) VALUES (739, N'172WSW4SAT7:30 PM', N'B-0042', N'11478797', 1, CAST(N'1900-01-01 19:39:00.000' AS DateTime), 0, N'')
INSERT [dbo].[Attendance] ([Attendance_Id], [Gathering_ID], [brethren_id], [Church_ID], [Attendance_Status], [Real_Time], [is_interlocale], [remarks]) VALUES (740, N'172WSW4SAT7:30 PM', N'IL-10', N'00704070', 1, CAST(N'1900-01-01 19:42:00.000' AS DateTime), 1, N'ACC')
INSERT [dbo].[Attendance] ([Attendance_Id], [Gathering_ID], [brethren_id], [Church_ID], [Attendance_Status], [Real_Time], [is_interlocale], [remarks]) VALUES (741, N'172WSW4SAT7:30 PM', N'B-0060', N'STP00080', 1, CAST(N'1900-01-01 19:46:00.000' AS DateTime), 0, N'')
INSERT [dbo].[Attendance] ([Attendance_Id], [Gathering_ID], [brethren_id], [Church_ID], [Attendance_Status], [Real_Time], [is_interlocale], [remarks]) VALUES (742, N'172WSW4SAT7:30 PM', N'B-0002', N'STP00125', 1, CAST(N'1900-01-01 19:47:00.000' AS DateTime), 0, N'')
INSERT [dbo].[Attendance] ([Attendance_Id], [Gathering_ID], [brethren_id], [Church_ID], [Attendance_Status], [Real_Time], [is_interlocale], [remarks]) VALUES (743, N'172WSW4SAT7:30 PM', N'B-0056', N'11606363', 1, CAST(N'1900-01-01 19:52:00.000' AS DateTime), 0, N'')
INSERT [dbo].[Attendance] ([Attendance_Id], [Gathering_ID], [brethren_id], [Church_ID], [Attendance_Status], [Real_Time], [is_interlocale], [remarks]) VALUES (744, N'172WSW4SAT7:30 PM', N'B-0026', N'11112207', 1, CAST(N'1900-01-01 19:54:00.000' AS DateTime), 0, N'')
INSERT [dbo].[Attendance] ([Attendance_Id], [Gathering_ID], [brethren_id], [Church_ID], [Attendance_Status], [Real_Time], [is_interlocale], [remarks]) VALUES (745, N'172WSW4SAT7:30 PM', N'B-0003', N'STP00122', 1, CAST(N'1900-01-01 19:57:00.000' AS DateTime), 0, N'')
INSERT [dbo].[Attendance] ([Attendance_Id], [Gathering_ID], [brethren_id], [Church_ID], [Attendance_Status], [Real_Time], [is_interlocale], [remarks]) VALUES (746, N'172WSW4SAT7:30 PM', N'B-0019', N'STP00057', 1, CAST(N'1900-01-01 20:03:00.000' AS DateTime), 0, N'')
INSERT [dbo].[Attendance] ([Attendance_Id], [Gathering_ID], [brethren_id], [Church_ID], [Attendance_Status], [Real_Time], [is_interlocale], [remarks]) VALUES (747, N'172WSW4SAT7:30 PM', N'B-0021', N'STP00012', 1, CAST(N'1900-01-01 20:04:00.000' AS DateTime), 0, N'')
INSERT [dbo].[Attendance] ([Attendance_Id], [Gathering_ID], [brethren_id], [Church_ID], [Attendance_Status], [Real_Time], [is_interlocale], [remarks]) VALUES (748, N'172WSW4SAT7:30 PM', N'B-0042', N'11478797', 1, CAST(N'1900-01-01 20:27:00.000' AS DateTime), 0, N'')
INSERT [dbo].[Attendance] ([Attendance_Id], [Gathering_ID], [brethren_id], [Church_ID], [Attendance_Status], [Real_Time], [is_interlocale], [remarks]) VALUES (749, N'172WSW4SAT7:30 PM', N'B-0042', N'11478797', 1, CAST(N'1900-01-01 20:29:00.000' AS DateTime), 0, N'')
INSERT [dbo].[Attendance] ([Attendance_Id], [Gathering_ID], [brethren_id], [Church_ID], [Attendance_Status], [Real_Time], [is_interlocale], [remarks]) VALUES (750, N'172WSW4SAT7:30 PM', N'B-0004', N'903914', 1, CAST(N'1900-01-01 20:29:00.000' AS DateTime), 0, N'')
INSERT [dbo].[Attendance] ([Attendance_Id], [Gathering_ID], [brethren_id], [Church_ID], [Attendance_Status], [Real_Time], [is_interlocale], [remarks]) VALUES (867, N'172TGPW3SUN6:00 AM', N'B-0007', N'701024', 1, CAST(N'1900-01-01 08:08:00.000' AS DateTime), 0, N'')
INSERT [dbo].[Attendance] ([Attendance_Id], [Gathering_ID], [brethren_id], [Church_ID], [Attendance_Status], [Real_Time], [is_interlocale], [remarks]) VALUES (868, N'172TGPW3SUN6:00 AM', N'B-0008', N'701145', 1, CAST(N'1900-01-01 08:08:00.000' AS DateTime), 0, N'')
INSERT [dbo].[Attendance] ([Attendance_Id], [Gathering_ID], [brethren_id], [Church_ID], [Attendance_Status], [Real_Time], [is_interlocale], [remarks]) VALUES (869, N'172TGPW3SUN6:00 AM', N'B-0035', N'11316389', 1, CAST(N'1900-01-01 08:08:00.000' AS DateTime), 0, N'')
INSERT [dbo].[Attendance] ([Attendance_Id], [Gathering_ID], [brethren_id], [Church_ID], [Attendance_Status], [Real_Time], [is_interlocale], [remarks]) VALUES (870, N'172TGPW3SUN6:00 AM', N'B-0033', N'11308026', 1, CAST(N'1900-01-01 08:08:00.000' AS DateTime), 0, N'')
INSERT [dbo].[Attendance] ([Attendance_Id], [Gathering_ID], [brethren_id], [Church_ID], [Attendance_Status], [Real_Time], [is_interlocale], [remarks]) VALUES (871, N'172TGPW3SUN6:00 AM', N'B-0041', N'11422172', 1, CAST(N'1900-01-01 08:08:00.000' AS DateTime), 0, N'')
INSERT [dbo].[Attendance] ([Attendance_Id], [Gathering_ID], [brethren_id], [Church_ID], [Attendance_Status], [Real_Time], [is_interlocale], [remarks]) VALUES (872, N'172TGPW3SUN6:00 AM', N'B-0036', N'11403632', 1, CAST(N'1900-01-01 08:08:00.000' AS DateTime), 0, N'')
INSERT [dbo].[Attendance] ([Attendance_Id], [Gathering_ID], [brethren_id], [Church_ID], [Attendance_Status], [Real_Time], [is_interlocale], [remarks]) VALUES (873, N'172TGPW3SUN6:00 AM', N'B-0055', N'STP00039', 1, CAST(N'1900-01-01 08:09:00.000' AS DateTime), 0, N'')
INSERT [dbo].[Attendance] ([Attendance_Id], [Gathering_ID], [brethren_id], [Church_ID], [Attendance_Status], [Real_Time], [is_interlocale], [remarks]) VALUES (874, N'172TGPW3SUN6:00 AM', N'B-0037', N'11416458', 1, CAST(N'1900-01-01 08:09:00.000' AS DateTime), 0, N'')
INSERT [dbo].[Attendance] ([Attendance_Id], [Gathering_ID], [brethren_id], [Church_ID], [Attendance_Status], [Real_Time], [is_interlocale], [remarks]) VALUES (875, N'172TGPW3SUN6:00 AM', N'B-0038', N'11416006', 1, CAST(N'1900-01-01 08:09:00.000' AS DateTime), 0, N'')
INSERT [dbo].[Attendance] ([Attendance_Id], [Gathering_ID], [brethren_id], [Church_ID], [Attendance_Status], [Real_Time], [is_interlocale], [remarks]) VALUES (876, N'172TGPW3SUN6:00 AM', N'B-64', N'STP00106', 1, CAST(N'1900-01-01 08:09:00.000' AS DateTime), 0, N'')
INSERT [dbo].[Attendance] ([Attendance_Id], [Gathering_ID], [brethren_id], [Church_ID], [Attendance_Status], [Real_Time], [is_interlocale], [remarks]) VALUES (877, N'172TGPW3SUN6:00 AM', N'B-0003', N'STP00122', 1, CAST(N'1900-01-01 08:09:00.000' AS DateTime), 0, N'')
INSERT [dbo].[Attendance] ([Attendance_Id], [Gathering_ID], [brethren_id], [Church_ID], [Attendance_Status], [Real_Time], [is_interlocale], [remarks]) VALUES (878, N'172TGPW3SUN6:00 AM', N'B-0002', N'STP00125', 1, CAST(N'1900-01-01 08:10:00.000' AS DateTime), 0, N'')
INSERT [dbo].[Attendance] ([Attendance_Id], [Gathering_ID], [brethren_id], [Church_ID], [Attendance_Status], [Real_Time], [is_interlocale], [remarks]) VALUES (879, N'172TGPW3SUN6:00 AM', N'B-0053', N'11604442', 1, CAST(N'1900-01-01 08:10:00.000' AS DateTime), 0, N'')
INSERT [dbo].[Attendance] ([Attendance_Id], [Gathering_ID], [brethren_id], [Church_ID], [Attendance_Status], [Real_Time], [is_interlocale], [remarks]) VALUES (880, N'172TGPW3SUN6:00 AM', N'B-0052', N'11604440', 1, CAST(N'1900-01-01 08:10:00.000' AS DateTime), 0, N'')
INSERT [dbo].[Attendance] ([Attendance_Id], [Gathering_ID], [brethren_id], [Church_ID], [Attendance_Status], [Real_Time], [is_interlocale], [remarks]) VALUES (881, N'172TGPW3SUN6:00 AM', N'B-67', N'11105434', 1, CAST(N'1900-01-01 08:10:00.000' AS DateTime), 0, N'')
INSERT [dbo].[Attendance] ([Attendance_Id], [Gathering_ID], [brethren_id], [Church_ID], [Attendance_Status], [Real_Time], [is_interlocale], [remarks]) VALUES (882, N'172TGPW3SUN6:00 AM', N'B-0015', N'STP00097', 1, CAST(N'1900-01-01 08:10:00.000' AS DateTime), 0, N'')
INSERT [dbo].[Attendance] ([Attendance_Id], [Gathering_ID], [brethren_id], [Church_ID], [Attendance_Status], [Real_Time], [is_interlocale], [remarks]) VALUES (883, N'172TGPW3SUN6:00 AM', N'B-0058', N'11612756', 1, CAST(N'1900-01-01 08:10:00.000' AS DateTime), 0, N'')
INSERT [dbo].[Attendance] ([Attendance_Id], [Gathering_ID], [brethren_id], [Church_ID], [Attendance_Status], [Real_Time], [is_interlocale], [remarks]) VALUES (884, N'172TGPW3SUN6:00 AM', N'B-0014', N'STP00096', 1, CAST(N'1900-01-01 08:10:00.000' AS DateTime), 0, N'')
INSERT [dbo].[Attendance] ([Attendance_Id], [Gathering_ID], [brethren_id], [Church_ID], [Attendance_Status], [Real_Time], [is_interlocale], [remarks]) VALUES (885, N'172TGPW3SUN6:00 AM', N'IL-0001', N'DA100126', 1, CAST(N'1900-01-01 08:11:00.000' AS DateTime), 1, N'DAU')
INSERT [dbo].[Attendance] ([Attendance_Id], [Gathering_ID], [brethren_id], [Church_ID], [Attendance_Status], [Real_Time], [is_interlocale], [remarks]) VALUES (886, N'172TGPW3SUN6:00 AM', N'IL-10', N'00704070', 1, CAST(N'1900-01-01 08:12:00.000' AS DateTime), 1, N'ACC')
INSERT [dbo].[Attendance] ([Attendance_Id], [Gathering_ID], [brethren_id], [Church_ID], [Attendance_Status], [Real_Time], [is_interlocale], [remarks]) VALUES (887, N'172TGPW3SUN6:00 AM', N'IL-3', N'STP00009', 1, CAST(N'1900-01-01 08:12:00.000' AS DateTime), 1, N'ACC')
INSERT [dbo].[Attendance] ([Attendance_Id], [Gathering_ID], [brethren_id], [Church_ID], [Attendance_Status], [Real_Time], [is_interlocale], [remarks]) VALUES (888, N'172TGPW3SUN6:00 AM', N'IL-7', N'ANG00235', 1, CAST(N'1900-01-01 08:12:00.000' AS DateTime), 1, N'ACC')
INSERT [dbo].[Attendance] ([Attendance_Id], [Gathering_ID], [brethren_id], [Church_ID], [Attendance_Status], [Real_Time], [is_interlocale], [remarks]) VALUES (889, N'172TGPW3SUN6:00 AM', N'IL-8', N'ANG00067', 1, CAST(N'1900-01-01 08:12:00.000' AS DateTime), 1, N'ACC')
INSERT [dbo].[Attendance] ([Attendance_Id], [Gathering_ID], [brethren_id], [Church_ID], [Attendance_Status], [Real_Time], [is_interlocale], [remarks]) VALUES (890, N'172TGPW3SUN6:00 AM', N'B-0056', N'11606363', 1, CAST(N'1900-01-01 08:12:00.000' AS DateTime), 0, N'')
INSERT [dbo].[Attendance] ([Attendance_Id], [Gathering_ID], [brethren_id], [Church_ID], [Attendance_Status], [Real_Time], [is_interlocale], [remarks]) VALUES (891, N'172TGPW3SUN6:00 AM', N'B-0027', N'11112036', 1, CAST(N'1900-01-01 08:12:00.000' AS DateTime), 0, N'')
INSERT [dbo].[Attendance] ([Attendance_Id], [Gathering_ID], [brethren_id], [Church_ID], [Attendance_Status], [Real_Time], [is_interlocale], [remarks]) VALUES (892, N'172TGPW3SUN6:00 AM', N'B-0018', N'STP00029', 1, CAST(N'1900-01-01 08:13:00.000' AS DateTime), 0, N'')
INSERT [dbo].[Attendance] ([Attendance_Id], [Gathering_ID], [brethren_id], [Church_ID], [Attendance_Status], [Real_Time], [is_interlocale], [remarks]) VALUES (893, N'172TGPW3SUN6:00 AM', N'B-0060', N'STP00080', 1, CAST(N'1900-01-01 08:13:00.000' AS DateTime), 0, N'')
INSERT [dbo].[Attendance] ([Attendance_Id], [Gathering_ID], [brethren_id], [Church_ID], [Attendance_Status], [Real_Time], [is_interlocale], [remarks]) VALUES (894, N'172TGPW3SUN6:00 AM', N'B-0042', N'11478797', 1, CAST(N'1900-01-01 08:13:00.000' AS DateTime), 0, N'')
INSERT [dbo].[Attendance] ([Attendance_Id], [Gathering_ID], [brethren_id], [Church_ID], [Attendance_Status], [Real_Time], [is_interlocale], [remarks]) VALUES (895, N'172TGPW3SUN6:00 AM', N'B-0023', N'STP00048', 1, CAST(N'1900-01-01 08:13:00.000' AS DateTime), 0, N'')
INSERT [dbo].[Attendance] ([Attendance_Id], [Gathering_ID], [brethren_id], [Church_ID], [Attendance_Status], [Real_Time], [is_interlocale], [remarks]) VALUES (896, N'172TGPW3SUN6:00 AM', N'B-0045', N'STP00008', 1, CAST(N'1900-01-01 08:13:00.000' AS DateTime), 0, N'')
INSERT [dbo].[Attendance] ([Attendance_Id], [Gathering_ID], [brethren_id], [Church_ID], [Attendance_Status], [Real_Time], [is_interlocale], [remarks]) VALUES (897, N'172TGPW3SUN6:00 AM', N'B-0034', N'STP00084', 1, CAST(N'1900-01-01 08:13:00.000' AS DateTime), 0, N'')
INSERT [dbo].[Attendance] ([Attendance_Id], [Gathering_ID], [brethren_id], [Church_ID], [Attendance_Status], [Real_Time], [is_interlocale], [remarks]) VALUES (920, N'172PMW4WED7:30 PM', N'B-0027', N'11112036', 1, CAST(N'1900-01-01 19:22:00.000' AS DateTime), 0, N'')
INSERT [dbo].[Attendance] ([Attendance_Id], [Gathering_ID], [brethren_id], [Church_ID], [Attendance_Status], [Real_Time], [is_interlocale], [remarks]) VALUES (921, N'172PMW4WED7:30 PM', N'B-0001', N'MA600030', 1, CAST(N'1900-01-01 19:22:00.000' AS DateTime), 0, N'')
INSERT [dbo].[Attendance] ([Attendance_Id], [Gathering_ID], [brethren_id], [Church_ID], [Attendance_Status], [Real_Time], [is_interlocale], [remarks]) VALUES (922, N'172PMW4WED7:30 PM', N'B-0061', N'STP00079', 1, CAST(N'1900-01-01 19:22:00.000' AS DateTime), 0, N'')
INSERT [dbo].[Attendance] ([Attendance_Id], [Gathering_ID], [brethren_id], [Church_ID], [Attendance_Status], [Real_Time], [is_interlocale], [remarks]) VALUES (923, N'172PMW4WED7:30 PM', N'B-0023', N'STP00048', 1, CAST(N'1900-01-01 19:22:00.000' AS DateTime), 0, N'')
INSERT [dbo].[Attendance] ([Attendance_Id], [Gathering_ID], [brethren_id], [Church_ID], [Attendance_Status], [Real_Time], [is_interlocale], [remarks]) VALUES (924, N'172PMW4WED7:30 PM', N'B-0031', N'701653', 1, CAST(N'1900-01-01 19:22:00.000' AS DateTime), 0, N'')
INSERT [dbo].[Attendance] ([Attendance_Id], [Gathering_ID], [brethren_id], [Church_ID], [Attendance_Status], [Real_Time], [is_interlocale], [remarks]) VALUES (925, N'172PMW4WED7:30 PM', N'B-0034', N'STP00084', 1, CAST(N'1900-01-01 19:22:00.000' AS DateTime), 0, N'')
INSERT [dbo].[Attendance] ([Attendance_Id], [Gathering_ID], [brethren_id], [Church_ID], [Attendance_Status], [Real_Time], [is_interlocale], [remarks]) VALUES (926, N'172PMW4WED7:30 PM', N'B-0018', N'STP00029', 1, CAST(N'1900-01-01 19:23:00.000' AS DateTime), 0, N'')
INSERT [dbo].[Attendance] ([Attendance_Id], [Gathering_ID], [brethren_id], [Church_ID], [Attendance_Status], [Real_Time], [is_interlocale], [remarks]) VALUES (927, N'172PMW4WED7:30 PM', N'B-0033', N'11308026', 1, CAST(N'1900-01-01 19:23:00.000' AS DateTime), 0, N'')
INSERT [dbo].[Attendance] ([Attendance_Id], [Gathering_ID], [brethren_id], [Church_ID], [Attendance_Status], [Real_Time], [is_interlocale], [remarks]) VALUES (928, N'172PMW4WED7:30 PM', N'B-0032', N'11307397', 1, CAST(N'1900-01-01 19:23:00.000' AS DateTime), 0, N'')
INSERT [dbo].[Attendance] ([Attendance_Id], [Gathering_ID], [brethren_id], [Church_ID], [Attendance_Status], [Real_Time], [is_interlocale], [remarks]) VALUES (929, N'172PMW4WED7:30 PM', N'B-0006', N'STP00061', 1, CAST(N'1900-01-01 19:23:00.000' AS DateTime), 0, N'')
INSERT [dbo].[Attendance] ([Attendance_Id], [Gathering_ID], [brethren_id], [Church_ID], [Attendance_Status], [Real_Time], [is_interlocale], [remarks]) VALUES (930, N'172PMW4WED7:30 PM', N'B-64', N'STP00106', 1, CAST(N'1900-01-01 19:27:00.000' AS DateTime), 0, N'')
INSERT [dbo].[Attendance] ([Attendance_Id], [Gathering_ID], [brethren_id], [Church_ID], [Attendance_Status], [Real_Time], [is_interlocale], [remarks]) VALUES (931, N'172PMW4WED7:30 PM', N'B-0036', N'11403632', 1, CAST(N'1900-01-01 19:31:00.000' AS DateTime), 0, N'')
INSERT [dbo].[Attendance] ([Attendance_Id], [Gathering_ID], [brethren_id], [Church_ID], [Attendance_Status], [Real_Time], [is_interlocale], [remarks]) VALUES (932, N'172PMW4WED7:30 PM', N'B-0038', N'11416006', 1, CAST(N'1900-01-01 19:31:00.000' AS DateTime), 0, N'')
INSERT [dbo].[Attendance] ([Attendance_Id], [Gathering_ID], [brethren_id], [Church_ID], [Attendance_Status], [Real_Time], [is_interlocale], [remarks]) VALUES (933, N'172PMW4WED7:30 PM', N'B-0037', N'11416458', 1, CAST(N'1900-01-01 19:31:00.000' AS DateTime), 0, N'')
INSERT [dbo].[Attendance] ([Attendance_Id], [Gathering_ID], [brethren_id], [Church_ID], [Attendance_Status], [Real_Time], [is_interlocale], [remarks]) VALUES (934, N'172PMW4WED7:30 PM', N'B-66', N'STP00042', 1, CAST(N'1900-01-01 19:31:00.000' AS DateTime), 0, N'')
INSERT [dbo].[Attendance] ([Attendance_Id], [Gathering_ID], [brethren_id], [Church_ID], [Attendance_Status], [Real_Time], [is_interlocale], [remarks]) VALUES (935, N'172PMW4WED7:30 PM', N'B-0014', N'STP00096', 1, CAST(N'1900-01-01 19:32:00.000' AS DateTime), 0, N'')
INSERT [dbo].[Attendance] ([Attendance_Id], [Gathering_ID], [brethren_id], [Church_ID], [Attendance_Status], [Real_Time], [is_interlocale], [remarks]) VALUES (936, N'172PMW4WED7:30 PM', N'B-0021', N'STP00012', 1, CAST(N'1900-01-01 19:37:00.000' AS DateTime), 0, N'')
INSERT [dbo].[Attendance] ([Attendance_Id], [Gathering_ID], [brethren_id], [Church_ID], [Attendance_Status], [Real_Time], [is_interlocale], [remarks]) VALUES (937, N'172PMW4WED7:30 PM', N'B-0003', N'STP00122', 1, CAST(N'1900-01-01 19:37:00.000' AS DateTime), 0, N'')
INSERT [dbo].[Attendance] ([Attendance_Id], [Gathering_ID], [brethren_id], [Church_ID], [Attendance_Status], [Real_Time], [is_interlocale], [remarks]) VALUES (938, N'172PMW4WED7:30 PM', N'B-65', N'STP00002', 1, CAST(N'1900-01-01 19:37:00.000' AS DateTime), 0, N'')
INSERT [dbo].[Attendance] ([Attendance_Id], [Gathering_ID], [brethren_id], [Church_ID], [Attendance_Status], [Real_Time], [is_interlocale], [remarks]) VALUES (939, N'172PMW4WED7:30 PM', N'IL-2', N'STP00017', 1, CAST(N'1900-01-01 19:37:00.000' AS DateTime), 1, N'FLORIDABLANCA')
INSERT [dbo].[Attendance] ([Attendance_Id], [Gathering_ID], [brethren_id], [Church_ID], [Attendance_Status], [Real_Time], [is_interlocale], [remarks]) VALUES (940, N'172PMW4WED7:30 PM', N'B-0008', N'701145', 1, CAST(N'1900-01-01 19:38:00.000' AS DateTime), 0, N'')
INSERT [dbo].[Attendance] ([Attendance_Id], [Gathering_ID], [brethren_id], [Church_ID], [Attendance_Status], [Real_Time], [is_interlocale], [remarks]) VALUES (941, N'172PMW4WED7:30 PM', N'B-0062', N'11006953', 1, CAST(N'1900-01-01 19:44:00.000' AS DateTime), 0, N'')
INSERT [dbo].[Attendance] ([Attendance_Id], [Gathering_ID], [brethren_id], [Church_ID], [Attendance_Status], [Real_Time], [is_interlocale], [remarks]) VALUES (942, N'172PMW4WED7:30 PM', N'B-0060', N'STP00080', 1, CAST(N'1900-01-01 19:44:00.000' AS DateTime), 0, N'')
INSERT [dbo].[Attendance] ([Attendance_Id], [Gathering_ID], [brethren_id], [Church_ID], [Attendance_Status], [Real_Time], [is_interlocale], [remarks]) VALUES (943, N'172PMW4WED7:30 PM', N'B-0026', N'11112207', 1, CAST(N'1900-01-01 19:48:00.000' AS DateTime), 0, N'')
INSERT [dbo].[Attendance] ([Attendance_Id], [Gathering_ID], [brethren_id], [Church_ID], [Attendance_Status], [Real_Time], [is_interlocale], [remarks]) VALUES (944, N'172PMW4WED7:30 PM', N'B-0019', N'STP00057', 1, CAST(N'1900-01-01 19:48:00.000' AS DateTime), 0, N'')
INSERT [dbo].[Attendance] ([Attendance_Id], [Gathering_ID], [brethren_id], [Church_ID], [Attendance_Status], [Real_Time], [is_interlocale], [remarks]) VALUES (950, N'172WSW5SAT7:30 PM', N'B-0018', N'STP00029', 1, CAST(N'1900-01-01 19:18:00.000' AS DateTime), 0, N'')
INSERT [dbo].[Attendance] ([Attendance_Id], [Gathering_ID], [brethren_id], [Church_ID], [Attendance_Status], [Real_Time], [is_interlocale], [remarks]) VALUES (951, N'172WSW5SAT7:30 PM', N'B-0032', N'11307397', 1, CAST(N'1900-01-01 19:18:00.000' AS DateTime), 0, N'')
INSERT [dbo].[Attendance] ([Attendance_Id], [Gathering_ID], [brethren_id], [Church_ID], [Attendance_Status], [Real_Time], [is_interlocale], [remarks]) VALUES (952, N'172WSW5SAT7:30 PM', N'B-0033', N'11308026', 1, CAST(N'1900-01-01 19:18:00.000' AS DateTime), 0, N'')
INSERT [dbo].[Attendance] ([Attendance_Id], [Gathering_ID], [brethren_id], [Church_ID], [Attendance_Status], [Real_Time], [is_interlocale], [remarks]) VALUES (953, N'172WSW5SAT7:30 PM', N'B-0038', N'11416006', 1, CAST(N'1900-01-01 19:18:00.000' AS DateTime), 0, N'')
INSERT [dbo].[Attendance] ([Attendance_Id], [Gathering_ID], [brethren_id], [Church_ID], [Attendance_Status], [Real_Time], [is_interlocale], [remarks]) VALUES (954, N'172WSW5SAT7:30 PM', N'B-0027', N'11112036', 1, CAST(N'1900-01-01 19:18:00.000' AS DateTime), 0, N'')
INSERT [dbo].[Attendance] ([Attendance_Id], [Gathering_ID], [brethren_id], [Church_ID], [Attendance_Status], [Real_Time], [is_interlocale], [remarks]) VALUES (955, N'172WSW5SAT7:30 PM', N'IL-7', N'ANG00235', 1, CAST(N'1900-01-01 19:19:00.000' AS DateTime), 1, N'ACC')
INSERT [dbo].[Attendance] ([Attendance_Id], [Gathering_ID], [brethren_id], [Church_ID], [Attendance_Status], [Real_Time], [is_interlocale], [remarks]) VALUES (956, N'172WSW5SAT7:30 PM', N'IL-8', N'ANG00067', 1, CAST(N'1900-01-01 19:19:00.000' AS DateTime), 1, N'ACC')
INSERT [dbo].[Attendance] ([Attendance_Id], [Gathering_ID], [brethren_id], [Church_ID], [Attendance_Status], [Real_Time], [is_interlocale], [remarks]) VALUES (957, N'172WSW5SAT7:30 PM', N'B-0023', N'STP00048', 1, CAST(N'1900-01-01 19:19:00.000' AS DateTime), 0, N'')
INSERT [dbo].[Attendance] ([Attendance_Id], [Gathering_ID], [brethren_id], [Church_ID], [Attendance_Status], [Real_Time], [is_interlocale], [remarks]) VALUES (958, N'172WSW5SAT7:30 PM', N'B-0034', N'STP00084', 1, CAST(N'1900-01-01 19:19:00.000' AS DateTime), 0, N'')
INSERT [dbo].[Attendance] ([Attendance_Id], [Gathering_ID], [brethren_id], [Church_ID], [Attendance_Status], [Real_Time], [is_interlocale], [remarks]) VALUES (959, N'172WSW5SAT7:30 PM', N'B-0001', N'MA600030', 1, CAST(N'1900-01-01 19:19:00.000' AS DateTime), 0, N'')
INSERT [dbo].[Attendance] ([Attendance_Id], [Gathering_ID], [brethren_id], [Church_ID], [Attendance_Status], [Real_Time], [is_interlocale], [remarks]) VALUES (960, N'172WSW5SAT7:30 PM', N'B-0053', N'11604442', 1, CAST(N'1900-01-01 19:20:00.000' AS DateTime), 0, N'')
INSERT [dbo].[Attendance] ([Attendance_Id], [Gathering_ID], [brethren_id], [Church_ID], [Attendance_Status], [Real_Time], [is_interlocale], [remarks]) VALUES (961, N'172WSW5SAT7:30 PM', N'B-0043', N'11456021', 1, CAST(N'1900-01-01 19:20:00.000' AS DateTime), 0, N'')
INSERT [dbo].[Attendance] ([Attendance_Id], [Gathering_ID], [brethren_id], [Church_ID], [Attendance_Status], [Real_Time], [is_interlocale], [remarks]) VALUES (962, N'172WSW5SAT7:30 PM', N'B-0036', N'11403632', 1, CAST(N'1900-01-01 19:25:00.000' AS DateTime), 0, N'')
INSERT [dbo].[Attendance] ([Attendance_Id], [Gathering_ID], [brethren_id], [Church_ID], [Attendance_Status], [Real_Time], [is_interlocale], [remarks]) VALUES (963, N'172WSW5SAT7:30 PM', N'B-64', N'STP00106', 1, CAST(N'1900-01-01 19:31:00.000' AS DateTime), 0, N'')
INSERT [dbo].[Attendance] ([Attendance_Id], [Gathering_ID], [brethren_id], [Church_ID], [Attendance_Status], [Real_Time], [is_interlocale], [remarks]) VALUES (964, N'172WSW5SAT7:30 PM', N'B-0021', N'STP00012', 1, CAST(N'1900-01-01 19:31:00.000' AS DateTime), 0, N'')
INSERT [dbo].[Attendance] ([Attendance_Id], [Gathering_ID], [brethren_id], [Church_ID], [Attendance_Status], [Real_Time], [is_interlocale], [remarks]) VALUES (965, N'172WSW5SAT7:30 PM', N'B-0019', N'STP00057', 1, CAST(N'1900-01-01 19:32:00.000' AS DateTime), 0, N'')
INSERT [dbo].[Attendance] ([Attendance_Id], [Gathering_ID], [brethren_id], [Church_ID], [Attendance_Status], [Real_Time], [is_interlocale], [remarks]) VALUES (966, N'172WSW5SAT7:30 PM', N'IL-3', N'STP00009', 1, CAST(N'1900-01-01 19:32:00.000' AS DateTime), 1, N'ACC')
INSERT [dbo].[Attendance] ([Attendance_Id], [Gathering_ID], [brethren_id], [Church_ID], [Attendance_Status], [Real_Time], [is_interlocale], [remarks]) VALUES (967, N'172WSW5SAT7:30 PM', N'B-0008', N'701145', 1, CAST(N'1900-01-01 19:32:00.000' AS DateTime), 0, N'')
GO
INSERT [dbo].[Attendance] ([Attendance_Id], [Gathering_ID], [brethren_id], [Church_ID], [Attendance_Status], [Real_Time], [is_interlocale], [remarks]) VALUES (968, N'172WSW5SAT7:30 PM', N'B-0007', N'701024', 1, CAST(N'1900-01-01 19:32:00.000' AS DateTime), 0, N'')
INSERT [dbo].[Attendance] ([Attendance_Id], [Gathering_ID], [brethren_id], [Church_ID], [Attendance_Status], [Real_Time], [is_interlocale], [remarks]) VALUES (969, N'172WSW5SAT7:30 PM', N'B-0028', N'808939', 1, CAST(N'1900-01-01 19:35:00.000' AS DateTime), 0, N'')
INSERT [dbo].[Attendance] ([Attendance_Id], [Gathering_ID], [brethren_id], [Church_ID], [Attendance_Status], [Real_Time], [is_interlocale], [remarks]) VALUES (970, N'172WSW5SAT7:30 PM', N'B-0042', N'11478797', 1, CAST(N'1900-01-01 19:46:00.000' AS DateTime), 0, N'')
INSERT [dbo].[Attendance] ([Attendance_Id], [Gathering_ID], [brethren_id], [Church_ID], [Attendance_Status], [Real_Time], [is_interlocale], [remarks]) VALUES (971, N'172WSW5SAT7:30 PM', N'B-65', N'STP00002', 1, CAST(N'1900-01-01 19:47:00.000' AS DateTime), 0, N'')
INSERT [dbo].[Attendance] ([Attendance_Id], [Gathering_ID], [brethren_id], [Church_ID], [Attendance_Status], [Real_Time], [is_interlocale], [remarks]) VALUES (972, N'172WSW5SAT7:30 PM', N'IL-2', N'STP00017', 1, CAST(N'1900-01-01 19:48:00.000' AS DateTime), 1, N'FLORIDABLANCA')
INSERT [dbo].[Attendance] ([Attendance_Id], [Gathering_ID], [brethren_id], [Church_ID], [Attendance_Status], [Real_Time], [is_interlocale], [remarks]) VALUES (973, N'172WSW5SAT7:30 PM', N'IL-5', N'11700481', 1, CAST(N'1900-01-01 19:48:00.000' AS DateTime), 1, N'FLORIDABLANCA')
INSERT [dbo].[Attendance] ([Attendance_Id], [Gathering_ID], [brethren_id], [Church_ID], [Attendance_Status], [Real_Time], [is_interlocale], [remarks]) VALUES (974, N'172WSW5SAT7:30 PM', N'B-0026', N'11112207', 1, CAST(N'1900-01-01 19:51:00.000' AS DateTime), 0, N'')
INSERT [dbo].[Attendance] ([Attendance_Id], [Gathering_ID], [brethren_id], [Church_ID], [Attendance_Status], [Real_Time], [is_interlocale], [remarks]) VALUES (975, N'172WSW5SAT7:30 PM', N'B-0060', N'STP00080', 1, CAST(N'1900-01-01 19:55:00.000' AS DateTime), 0, N'')
INSERT [dbo].[Attendance] ([Attendance_Id], [Gathering_ID], [brethren_id], [Church_ID], [Attendance_Status], [Real_Time], [is_interlocale], [remarks]) VALUES (976, N'172WSW5SAT7:30 PM', N'B-0012', N'STP00042', 1, CAST(N'1900-01-01 20:02:00.000' AS DateTime), 0, N'')
INSERT [dbo].[Attendance] ([Attendance_Id], [Gathering_ID], [brethren_id], [Church_ID], [Attendance_Status], [Real_Time], [is_interlocale], [remarks]) VALUES (984, N'173PMW1WED7:30 PM', N'B-0018', N'STP00029', 1, CAST(N'1900-01-01 19:32:00.000' AS DateTime), 0, N'')
INSERT [dbo].[Attendance] ([Attendance_Id], [Gathering_ID], [brethren_id], [Church_ID], [Attendance_Status], [Real_Time], [is_interlocale], [remarks]) VALUES (985, N'173PMW1WED7:30 PM', N'B-0013', N'STP00094', 1, CAST(N'1900-01-01 19:32:00.000' AS DateTime), 0, N'')
INSERT [dbo].[Attendance] ([Attendance_Id], [Gathering_ID], [brethren_id], [Church_ID], [Attendance_Status], [Real_Time], [is_interlocale], [remarks]) VALUES (986, N'173PMW1WED7:30 PM', N'B-0061', N'STP00079', 1, CAST(N'1900-01-01 19:32:00.000' AS DateTime), 0, N'')
INSERT [dbo].[Attendance] ([Attendance_Id], [Gathering_ID], [brethren_id], [Church_ID], [Attendance_Status], [Real_Time], [is_interlocale], [remarks]) VALUES (987, N'173PMW1WED7:30 PM', N'B-0031', N'701653', 1, CAST(N'1900-01-01 19:32:00.000' AS DateTime), 0, N'')
INSERT [dbo].[Attendance] ([Attendance_Id], [Gathering_ID], [brethren_id], [Church_ID], [Attendance_Status], [Real_Time], [is_interlocale], [remarks]) VALUES (988, N'173PMW1WED7:30 PM', N'B-0032', N'11307397', 1, CAST(N'1900-01-01 19:32:00.000' AS DateTime), 0, N'')
INSERT [dbo].[Attendance] ([Attendance_Id], [Gathering_ID], [brethren_id], [Church_ID], [Attendance_Status], [Real_Time], [is_interlocale], [remarks]) VALUES (989, N'173PMW1WED7:30 PM', N'B-0037', N'11416458', 1, CAST(N'1900-01-01 19:32:00.000' AS DateTime), 0, N'')
INSERT [dbo].[Attendance] ([Attendance_Id], [Gathering_ID], [brethren_id], [Church_ID], [Attendance_Status], [Real_Time], [is_interlocale], [remarks]) VALUES (990, N'173PMW1WED7:30 PM', N'B-0038', N'11416006', 1, CAST(N'1900-01-01 19:32:00.000' AS DateTime), 0, N'')
INSERT [dbo].[Attendance] ([Attendance_Id], [Gathering_ID], [brethren_id], [Church_ID], [Attendance_Status], [Real_Time], [is_interlocale], [remarks]) VALUES (991, N'173PMW1WED7:30 PM', N'B-0033', N'11308026', 1, CAST(N'1900-01-01 19:32:00.000' AS DateTime), 0, N'')
INSERT [dbo].[Attendance] ([Attendance_Id], [Gathering_ID], [brethren_id], [Church_ID], [Attendance_Status], [Real_Time], [is_interlocale], [remarks]) VALUES (992, N'173PMW1WED7:30 PM', N'B-0027', N'11112036', 1, CAST(N'1900-01-01 19:32:00.000' AS DateTime), 0, N'')
INSERT [dbo].[Attendance] ([Attendance_Id], [Gathering_ID], [brethren_id], [Church_ID], [Attendance_Status], [Real_Time], [is_interlocale], [remarks]) VALUES (993, N'173PMW1WED7:30 PM', N'B-0014', N'STP00096', 1, CAST(N'1900-01-01 19:33:00.000' AS DateTime), 0, N'')
INSERT [dbo].[Attendance] ([Attendance_Id], [Gathering_ID], [brethren_id], [Church_ID], [Attendance_Status], [Real_Time], [is_interlocale], [remarks]) VALUES (994, N'173PMW1WED7:30 PM', N'IL-7', N'ANG00235', 1, CAST(N'1900-01-01 19:33:00.000' AS DateTime), 1, N'ACC')
INSERT [dbo].[Attendance] ([Attendance_Id], [Gathering_ID], [brethren_id], [Church_ID], [Attendance_Status], [Real_Time], [is_interlocale], [remarks]) VALUES (995, N'173PMW1WED7:30 PM', N'IL-8', N'ANG00067', 1, CAST(N'1900-01-01 19:33:00.000' AS DateTime), 1, N'ACC')
INSERT [dbo].[Attendance] ([Attendance_Id], [Gathering_ID], [brethren_id], [Church_ID], [Attendance_Status], [Real_Time], [is_interlocale], [remarks]) VALUES (996, N'173PMW1WED7:30 PM', N'B-0036', N'11403632', 1, CAST(N'1900-01-01 19:33:00.000' AS DateTime), 0, N'')
INSERT [dbo].[Attendance] ([Attendance_Id], [Gathering_ID], [brethren_id], [Church_ID], [Attendance_Status], [Real_Time], [is_interlocale], [remarks]) VALUES (997, N'173PMW1WED7:30 PM', N'B-0057', N'11507206', 1, CAST(N'1900-01-01 19:33:00.000' AS DateTime), 0, N'')
INSERT [dbo].[Attendance] ([Attendance_Id], [Gathering_ID], [brethren_id], [Church_ID], [Attendance_Status], [Real_Time], [is_interlocale], [remarks]) VALUES (998, N'173PMW1WED7:30 PM', N'B-0007', N'701024', 1, CAST(N'1900-01-01 19:33:00.000' AS DateTime), 0, N'')
INSERT [dbo].[Attendance] ([Attendance_Id], [Gathering_ID], [brethren_id], [Church_ID], [Attendance_Status], [Real_Time], [is_interlocale], [remarks]) VALUES (999, N'173PMW1WED7:30 PM', N'B-0008', N'701145', 1, CAST(N'1900-01-01 19:33:00.000' AS DateTime), 0, N'')
INSERT [dbo].[Attendance] ([Attendance_Id], [Gathering_ID], [brethren_id], [Church_ID], [Attendance_Status], [Real_Time], [is_interlocale], [remarks]) VALUES (1000, N'173PMW1WED7:30 PM', N'B-64', N'STP00106', 1, CAST(N'1900-01-01 19:34:00.000' AS DateTime), 0, N'')
INSERT [dbo].[Attendance] ([Attendance_Id], [Gathering_ID], [brethren_id], [Church_ID], [Attendance_Status], [Real_Time], [is_interlocale], [remarks]) VALUES (1001, N'173PMW1WED7:30 PM', N'B-0034', N'STP00084', 1, CAST(N'1900-01-01 19:34:00.000' AS DateTime), 0, N'')
INSERT [dbo].[Attendance] ([Attendance_Id], [Gathering_ID], [brethren_id], [Church_ID], [Attendance_Status], [Real_Time], [is_interlocale], [remarks]) VALUES (1002, N'173PMW1WED7:30 PM', N'B-0023', N'STP00048', 1, CAST(N'1900-01-01 19:34:00.000' AS DateTime), 0, N'')
INSERT [dbo].[Attendance] ([Attendance_Id], [Gathering_ID], [brethren_id], [Church_ID], [Attendance_Status], [Real_Time], [is_interlocale], [remarks]) VALUES (1003, N'173PMW1WED7:30 PM', N'B-0028', N'808939', 1, CAST(N'1900-01-01 19:35:00.000' AS DateTime), 0, N'')
INSERT [dbo].[Attendance] ([Attendance_Id], [Gathering_ID], [brethren_id], [Church_ID], [Attendance_Status], [Real_Time], [is_interlocale], [remarks]) VALUES (1004, N'173PMW1WED7:30 PM', N'B-0019', N'STP00057', 1, CAST(N'1900-01-01 19:35:00.000' AS DateTime), 0, N'')
INSERT [dbo].[Attendance] ([Attendance_Id], [Gathering_ID], [brethren_id], [Church_ID], [Attendance_Status], [Real_Time], [is_interlocale], [remarks]) VALUES (1005, N'173PMW1WED7:30 PM', N'B-0021', N'STP00012', 1, CAST(N'1900-01-01 19:36:00.000' AS DateTime), 0, N'')
INSERT [dbo].[Attendance] ([Attendance_Id], [Gathering_ID], [brethren_id], [Church_ID], [Attendance_Status], [Real_Time], [is_interlocale], [remarks]) VALUES (1006, N'173PMW1WED7:30 PM', N'B-65', N'STP00002', 1, CAST(N'1900-01-01 19:42:00.000' AS DateTime), 0, N'')
INSERT [dbo].[Attendance] ([Attendance_Id], [Gathering_ID], [brethren_id], [Church_ID], [Attendance_Status], [Real_Time], [is_interlocale], [remarks]) VALUES (1007, N'173PMW1WED7:30 PM', N'IL-2', N'STP00017', 1, CAST(N'1900-01-01 19:42:00.000' AS DateTime), 1, N'FLORIDABLANCA')
INSERT [dbo].[Attendance] ([Attendance_Id], [Gathering_ID], [brethren_id], [Church_ID], [Attendance_Status], [Real_Time], [is_interlocale], [remarks]) VALUES (1008, N'173PMW1WED7:30 PM', N'IL-5', N'11700481', 1, CAST(N'1900-01-01 19:42:00.000' AS DateTime), 1, N'FLORIDABLANCA')
INSERT [dbo].[Attendance] ([Attendance_Id], [Gathering_ID], [brethren_id], [Church_ID], [Attendance_Status], [Real_Time], [is_interlocale], [remarks]) VALUES (1009, N'173PMW1WED7:30 PM', N'B-0022', N'STP00043', 1, CAST(N'1900-01-01 19:49:00.000' AS DateTime), 0, N'')
INSERT [dbo].[Attendance] ([Attendance_Id], [Gathering_ID], [brethren_id], [Church_ID], [Attendance_Status], [Real_Time], [is_interlocale], [remarks]) VALUES (1010, N'173PMW1WED7:30 PM', N'B-0062', N'11006953', 1, CAST(N'1900-01-01 19:49:00.000' AS DateTime), 0, N'')
INSERT [dbo].[Attendance] ([Attendance_Id], [Gathering_ID], [brethren_id], [Church_ID], [Attendance_Status], [Real_Time], [is_interlocale], [remarks]) VALUES (1011, N'173PMW1WED7:30 PM', N'B-0002', N'STP00125', 1, CAST(N'1900-01-01 19:49:00.000' AS DateTime), 0, N'')
INSERT [dbo].[Attendance] ([Attendance_Id], [Gathering_ID], [brethren_id], [Church_ID], [Attendance_Status], [Real_Time], [is_interlocale], [remarks]) VALUES (1012, N'173PMW1WED7:30 PM', N'B-0060', N'STP00080', 1, CAST(N'1900-01-01 19:49:00.000' AS DateTime), 0, N'')
INSERT [dbo].[Attendance] ([Attendance_Id], [Gathering_ID], [brethren_id], [Church_ID], [Attendance_Status], [Real_Time], [is_interlocale], [remarks]) VALUES (1013, N'173PMW1WED7:30 PM', N'B-0052', N'11604440', 1, CAST(N'1900-01-01 19:49:00.000' AS DateTime), 0, N'')
INSERT [dbo].[Attendance] ([Attendance_Id], [Gathering_ID], [brethren_id], [Church_ID], [Attendance_Status], [Real_Time], [is_interlocale], [remarks]) VALUES (1014, N'173PMW1WED7:30 PM', N'B-0045', N'STP00008', 1, CAST(N'1900-01-01 19:50:00.000' AS DateTime), 0, N'')
INSERT [dbo].[Attendance] ([Attendance_Id], [Gathering_ID], [brethren_id], [Church_ID], [Attendance_Status], [Real_Time], [is_interlocale], [remarks]) VALUES (1015, N'173PMW1WED7:30 PM', N'B-0026', N'11112207', 1, CAST(N'1900-01-01 19:55:00.000' AS DateTime), 0, N'')
INSERT [dbo].[Attendance] ([Attendance_Id], [Gathering_ID], [brethren_id], [Church_ID], [Attendance_Status], [Real_Time], [is_interlocale], [remarks]) VALUES (1029, N'173WSW2SAT7:30 PM', N'B-0061', N'STP00079', 1, CAST(N'1900-01-01 19:12:00.000' AS DateTime), 0, N'')
INSERT [dbo].[Attendance] ([Attendance_Id], [Gathering_ID], [brethren_id], [Church_ID], [Attendance_Status], [Real_Time], [is_interlocale], [remarks]) VALUES (1030, N'173WSW2SAT7:30 PM', N'B-0013', N'STP00094', 1, CAST(N'1900-01-01 19:12:00.000' AS DateTime), 0, N'')
INSERT [dbo].[Attendance] ([Attendance_Id], [Gathering_ID], [brethren_id], [Church_ID], [Attendance_Status], [Real_Time], [is_interlocale], [remarks]) VALUES (1031, N'173WSW2SAT7:30 PM', N'B-0027', N'11112036', 1, CAST(N'1900-01-01 19:12:00.000' AS DateTime), 0, N'')
INSERT [dbo].[Attendance] ([Attendance_Id], [Gathering_ID], [brethren_id], [Church_ID], [Attendance_Status], [Real_Time], [is_interlocale], [remarks]) VALUES (1032, N'173WSW2SAT7:30 PM', N'B-0032', N'11307397', 1, CAST(N'1900-01-01 19:12:00.000' AS DateTime), 0, N'')
INSERT [dbo].[Attendance] ([Attendance_Id], [Gathering_ID], [brethren_id], [Church_ID], [Attendance_Status], [Real_Time], [is_interlocale], [remarks]) VALUES (1033, N'173WSW2SAT7:30 PM', N'B-0033', N'11308026', 1, CAST(N'1900-01-01 19:12:00.000' AS DateTime), 0, N'')
INSERT [dbo].[Attendance] ([Attendance_Id], [Gathering_ID], [brethren_id], [Church_ID], [Attendance_Status], [Real_Time], [is_interlocale], [remarks]) VALUES (1034, N'173WSW2SAT7:30 PM', N'B-0023', N'STP00048', 1, CAST(N'1900-01-01 19:14:00.000' AS DateTime), 0, N'')
INSERT [dbo].[Attendance] ([Attendance_Id], [Gathering_ID], [brethren_id], [Church_ID], [Attendance_Status], [Real_Time], [is_interlocale], [remarks]) VALUES (1035, N'173WSW2SAT7:30 PM', N'B-0038', N'11416006', 1, CAST(N'1900-01-01 19:14:00.000' AS DateTime), 0, N'')
INSERT [dbo].[Attendance] ([Attendance_Id], [Gathering_ID], [brethren_id], [Church_ID], [Attendance_Status], [Real_Time], [is_interlocale], [remarks]) VALUES (1036, N'173WSW2SAT7:30 PM', N'B-0037', N'11416458', 1, CAST(N'1900-01-01 19:15:00.000' AS DateTime), 0, N'')
INSERT [dbo].[Attendance] ([Attendance_Id], [Gathering_ID], [brethren_id], [Church_ID], [Attendance_Status], [Real_Time], [is_interlocale], [remarks]) VALUES (1037, N'173WSW2SAT7:30 PM', N'B-0034', N'STP00084', 1, CAST(N'1900-01-01 19:19:00.000' AS DateTime), 0, N'')
INSERT [dbo].[Attendance] ([Attendance_Id], [Gathering_ID], [brethren_id], [Church_ID], [Attendance_Status], [Real_Time], [is_interlocale], [remarks]) VALUES (1038, N'173WSW2SAT7:30 PM', N'B-64', N'STP00106', 1, CAST(N'1900-01-01 19:20:00.000' AS DateTime), 0, N'')
INSERT [dbo].[Attendance] ([Attendance_Id], [Gathering_ID], [brethren_id], [Church_ID], [Attendance_Status], [Real_Time], [is_interlocale], [remarks]) VALUES (1039, N'173WSW2SAT7:30 PM', N'B-0004', N'903914', 1, CAST(N'1900-01-01 19:26:00.000' AS DateTime), 0, N'')
INSERT [dbo].[Attendance] ([Attendance_Id], [Gathering_ID], [brethren_id], [Church_ID], [Attendance_Status], [Real_Time], [is_interlocale], [remarks]) VALUES (1040, N'173WSW2SAT7:30 PM', N'B-0036', N'11403632', 1, CAST(N'1900-01-01 19:27:00.000' AS DateTime), 0, N'')
INSERT [dbo].[Attendance] ([Attendance_Id], [Gathering_ID], [brethren_id], [Church_ID], [Attendance_Status], [Real_Time], [is_interlocale], [remarks]) VALUES (1041, N'173WSW2SAT7:30 PM', N'IL-3', N'STP00009', 1, CAST(N'1900-01-01 19:30:00.000' AS DateTime), 1, N'ACC')
INSERT [dbo].[Attendance] ([Attendance_Id], [Gathering_ID], [brethren_id], [Church_ID], [Attendance_Status], [Real_Time], [is_interlocale], [remarks]) VALUES (1042, N'173WSW2SAT7:30 PM', N'B-0053', N'11604442', 1, CAST(N'1900-01-01 19:31:00.000' AS DateTime), 0, N'')
INSERT [dbo].[Attendance] ([Attendance_Id], [Gathering_ID], [brethren_id], [Church_ID], [Attendance_Status], [Real_Time], [is_interlocale], [remarks]) VALUES (1043, N'173WSW2SAT7:30 PM', N'B-0052', N'11604440', 1, CAST(N'1900-01-01 19:31:00.000' AS DateTime), 0, N'')
INSERT [dbo].[Attendance] ([Attendance_Id], [Gathering_ID], [brethren_id], [Church_ID], [Attendance_Status], [Real_Time], [is_interlocale], [remarks]) VALUES (1044, N'173WSW2SAT7:30 PM', N'B-0015', N'STP00097', 1, CAST(N'1900-01-01 19:31:00.000' AS DateTime), 0, N'')
INSERT [dbo].[Attendance] ([Attendance_Id], [Gathering_ID], [brethren_id], [Church_ID], [Attendance_Status], [Real_Time], [is_interlocale], [remarks]) VALUES (1045, N'173WSW2SAT7:30 PM', N'B-0014', N'STP00096', 1, CAST(N'1900-01-01 19:32:00.000' AS DateTime), 0, N'')
INSERT [dbo].[Attendance] ([Attendance_Id], [Gathering_ID], [brethren_id], [Church_ID], [Attendance_Status], [Real_Time], [is_interlocale], [remarks]) VALUES (1046, N'173WSW2SAT7:30 PM', N'B-0028', N'808939', 1, CAST(N'1900-01-01 19:33:00.000' AS DateTime), 0, N'')
INSERT [dbo].[Attendance] ([Attendance_Id], [Gathering_ID], [brethren_id], [Church_ID], [Attendance_Status], [Real_Time], [is_interlocale], [remarks]) VALUES (1047, N'173WSW2SAT7:30 PM', N'B-0019', N'STP00057', 1, CAST(N'1900-01-01 19:34:00.000' AS DateTime), 0, N'')
INSERT [dbo].[Attendance] ([Attendance_Id], [Gathering_ID], [brethren_id], [Church_ID], [Attendance_Status], [Real_Time], [is_interlocale], [remarks]) VALUES (1048, N'173WSW2SAT7:30 PM', N'B-0021', N'STP00012', 1, CAST(N'1900-01-01 19:35:00.000' AS DateTime), 0, N'')
INSERT [dbo].[Attendance] ([Attendance_Id], [Gathering_ID], [brethren_id], [Church_ID], [Attendance_Status], [Real_Time], [is_interlocale], [remarks]) VALUES (1049, N'173WSW2SAT7:30 PM', N'IL-6', N'STP00056', 1, CAST(N'1900-01-01 19:40:00.000' AS DateTime), 1, N'ACC')
INSERT [dbo].[Attendance] ([Attendance_Id], [Gathering_ID], [brethren_id], [Church_ID], [Attendance_Status], [Real_Time], [is_interlocale], [remarks]) VALUES (1050, N'173WSW2SAT7:30 PM', N'B-67', N'11105434', 1, CAST(N'1900-01-01 19:42:00.000' AS DateTime), 0, N'')
INSERT [dbo].[Attendance] ([Attendance_Id], [Gathering_ID], [brethren_id], [Church_ID], [Attendance_Status], [Real_Time], [is_interlocale], [remarks]) VALUES (1051, N'173WSW2SAT7:30 PM', N'B-0062', N'11006953', 1, CAST(N'1900-01-01 19:43:00.000' AS DateTime), 0, N'')
INSERT [dbo].[Attendance] ([Attendance_Id], [Gathering_ID], [brethren_id], [Church_ID], [Attendance_Status], [Real_Time], [is_interlocale], [remarks]) VALUES (1052, N'173WSW2SAT7:30 PM', N'B-0060', N'STP00080', 1, CAST(N'1900-01-01 19:47:00.000' AS DateTime), 0, N'')
INSERT [dbo].[Attendance] ([Attendance_Id], [Gathering_ID], [brethren_id], [Church_ID], [Attendance_Status], [Real_Time], [is_interlocale], [remarks]) VALUES (1053, N'173WSW2SAT7:30 PM', N'B-0046', N'11435111', 1, CAST(N'1900-01-01 19:47:00.000' AS DateTime), 0, N'')
INSERT [dbo].[Attendance] ([Attendance_Id], [Gathering_ID], [brethren_id], [Church_ID], [Attendance_Status], [Real_Time], [is_interlocale], [remarks]) VALUES (1054, N'173WSW2SAT7:30 PM', N'B-0042', N'11478797', 1, CAST(N'1900-01-01 19:47:00.000' AS DateTime), 0, N'')
INSERT [dbo].[Attendance] ([Attendance_Id], [Gathering_ID], [brethren_id], [Church_ID], [Attendance_Status], [Real_Time], [is_interlocale], [remarks]) VALUES (1055, N'173WSW2SAT7:30 PM', N'B-0008', N'701145', 1, CAST(N'1900-01-01 19:48:00.000' AS DateTime), 0, N'')
INSERT [dbo].[Attendance] ([Attendance_Id], [Gathering_ID], [brethren_id], [Church_ID], [Attendance_Status], [Real_Time], [is_interlocale], [remarks]) VALUES (1056, N'173WSW2SAT7:30 PM', N'B-0044', N'00000000', 1, CAST(N'1900-01-01 19:51:00.000' AS DateTime), 0, N'')
INSERT [dbo].[Attendance] ([Attendance_Id], [Gathering_ID], [brethren_id], [Church_ID], [Attendance_Status], [Real_Time], [is_interlocale], [remarks]) VALUES (1057, N'173WSW2SAT7:30 PM', N'B-0026', N'11112207', 1, CAST(N'1900-01-01 19:58:00.000' AS DateTime), 0, N'')
INSERT [dbo].[Attendance] ([Attendance_Id], [Gathering_ID], [brethren_id], [Church_ID], [Attendance_Status], [Real_Time], [is_interlocale], [remarks]) VALUES (1065, N'173TGPW1SUN6:00 AM', N'B-0007', N'701024', 1, CAST(N'1900-01-01 06:22:00.000' AS DateTime), 0, N'')
INSERT [dbo].[Attendance] ([Attendance_Id], [Gathering_ID], [brethren_id], [Church_ID], [Attendance_Status], [Real_Time], [is_interlocale], [remarks]) VALUES (1066, N'173TGPW1SUN6:00 AM', N'B-0008', N'701145', 1, CAST(N'1900-01-01 06:22:00.000' AS DateTime), 0, N'')
INSERT [dbo].[Attendance] ([Attendance_Id], [Gathering_ID], [brethren_id], [Church_ID], [Attendance_Status], [Real_Time], [is_interlocale], [remarks]) VALUES (1067, N'173TGPW1SUN6:00 AM', N'B-0041', N'11422172', 1, CAST(N'1900-01-01 06:23:00.000' AS DateTime), 0, N'')
INSERT [dbo].[Attendance] ([Attendance_Id], [Gathering_ID], [brethren_id], [Church_ID], [Attendance_Status], [Real_Time], [is_interlocale], [remarks]) VALUES (1068, N'173TGPW1SUN6:00 AM', N'B-0055', N'STP00039', 1, CAST(N'1900-01-01 06:23:00.000' AS DateTime), 0, N'')
INSERT [dbo].[Attendance] ([Attendance_Id], [Gathering_ID], [brethren_id], [Church_ID], [Attendance_Status], [Real_Time], [is_interlocale], [remarks]) VALUES (1069, N'173TGPW1SUN6:00 AM', N'B-0037', N'11416458', 1, CAST(N'1900-01-01 06:23:00.000' AS DateTime), 0, N'')
INSERT [dbo].[Attendance] ([Attendance_Id], [Gathering_ID], [brethren_id], [Church_ID], [Attendance_Status], [Real_Time], [is_interlocale], [remarks]) VALUES (1070, N'173TGPW1SUN6:00 AM', N'B-0038', N'11416006', 1, CAST(N'1900-01-01 06:24:00.000' AS DateTime), 0, N'')
INSERT [dbo].[Attendance] ([Attendance_Id], [Gathering_ID], [brethren_id], [Church_ID], [Attendance_Status], [Real_Time], [is_interlocale], [remarks]) VALUES (1071, N'173TGPW1SUN6:00 AM', N'IL-3', N'STP00009', 1, CAST(N'1900-01-01 06:24:00.000' AS DateTime), 1, N'ACC')
INSERT [dbo].[Attendance] ([Attendance_Id], [Gathering_ID], [brethren_id], [Church_ID], [Attendance_Status], [Real_Time], [is_interlocale], [remarks]) VALUES (1072, N'173TGPW1SUN6:00 AM', N'B-0027', N'11112036', 1, CAST(N'1900-01-01 06:24:00.000' AS DateTime), 0, N'')
INSERT [dbo].[Attendance] ([Attendance_Id], [Gathering_ID], [brethren_id], [Church_ID], [Attendance_Status], [Real_Time], [is_interlocale], [remarks]) VALUES (1073, N'173TGPW1SUN6:00 AM', N'B-0052', N'11604440', 1, CAST(N'1900-01-01 06:24:00.000' AS DateTime), 0, N'')
INSERT [dbo].[Attendance] ([Attendance_Id], [Gathering_ID], [brethren_id], [Church_ID], [Attendance_Status], [Real_Time], [is_interlocale], [remarks]) VALUES (1074, N'173TGPW1SUN6:00 AM', N'B-0033', N'11308026', 1, CAST(N'1900-01-01 06:29:00.000' AS DateTime), 0, N'')
INSERT [dbo].[Attendance] ([Attendance_Id], [Gathering_ID], [brethren_id], [Church_ID], [Attendance_Status], [Real_Time], [is_interlocale], [remarks]) VALUES (1075, N'173TGPW1SUN6:00 AM', N'IL-7', N'ANG00235', 1, CAST(N'1900-01-01 06:30:00.000' AS DateTime), 1, N'ACC')
INSERT [dbo].[Attendance] ([Attendance_Id], [Gathering_ID], [brethren_id], [Church_ID], [Attendance_Status], [Real_Time], [is_interlocale], [remarks]) VALUES (1076, N'173TGPW1SUN6:00 AM', N'IL-8', N'ANG00067', 1, CAST(N'1900-01-01 06:31:00.000' AS DateTime), 1, N'ACC')
INSERT [dbo].[Attendance] ([Attendance_Id], [Gathering_ID], [brethren_id], [Church_ID], [Attendance_Status], [Real_Time], [is_interlocale], [remarks]) VALUES (1077, N'173TGPW1SUN6:00 AM', N'B-0034', N'STP00084', 1, CAST(N'1900-01-01 06:31:00.000' AS DateTime), 0, N'')
INSERT [dbo].[Attendance] ([Attendance_Id], [Gathering_ID], [brethren_id], [Church_ID], [Attendance_Status], [Real_Time], [is_interlocale], [remarks]) VALUES (1078, N'173TGPW1SUN6:00 AM', N'B-0023', N'STP00048', 1, CAST(N'1900-01-01 06:31:00.000' AS DateTime), 0, N'')
INSERT [dbo].[Attendance] ([Attendance_Id], [Gathering_ID], [brethren_id], [Church_ID], [Attendance_Status], [Real_Time], [is_interlocale], [remarks]) VALUES (1079, N'173TGPW1SUN6:00 AM', N'B-0002', N'STP00125', 1, CAST(N'1900-01-01 06:33:00.000' AS DateTime), 0, N'')
INSERT [dbo].[Attendance] ([Attendance_Id], [Gathering_ID], [brethren_id], [Church_ID], [Attendance_Status], [Real_Time], [is_interlocale], [remarks]) VALUES (1080, N'173TGPW1SUN6:00 AM', N'B-67', N'11105434', 1, CAST(N'1900-01-01 06:33:00.000' AS DateTime), 0, N'')
INSERT [dbo].[Attendance] ([Attendance_Id], [Gathering_ID], [brethren_id], [Church_ID], [Attendance_Status], [Real_Time], [is_interlocale], [remarks]) VALUES (1081, N'173TGPW1SUN6:00 AM', N'B-0003', N'STP00122', 1, CAST(N'1900-01-01 06:38:00.000' AS DateTime), 0, N'')
INSERT [dbo].[Attendance] ([Attendance_Id], [Gathering_ID], [brethren_id], [Church_ID], [Attendance_Status], [Real_Time], [is_interlocale], [remarks]) VALUES (1082, N'173TGPW1SUN6:00 AM', N'B-0058', N'11612756', 1, CAST(N'1900-01-01 06:38:00.000' AS DateTime), 0, N'')
INSERT [dbo].[Attendance] ([Attendance_Id], [Gathering_ID], [brethren_id], [Church_ID], [Attendance_Status], [Real_Time], [is_interlocale], [remarks]) VALUES (1083, N'173TGPW1SUN6:00 AM', N'B-0015', N'STP00097', 1, CAST(N'1900-01-01 06:39:00.000' AS DateTime), 0, N'')
INSERT [dbo].[Attendance] ([Attendance_Id], [Gathering_ID], [brethren_id], [Church_ID], [Attendance_Status], [Real_Time], [is_interlocale], [remarks]) VALUES (1084, N'173TGPW1SUN6:00 AM', N'B-0014', N'STP00096', 1, CAST(N'1900-01-01 06:39:00.000' AS DateTime), 0, N'')
INSERT [dbo].[Attendance] ([Attendance_Id], [Gathering_ID], [brethren_id], [Church_ID], [Attendance_Status], [Real_Time], [is_interlocale], [remarks]) VALUES (1085, N'173TGPW1SUN6:00 AM', N'B-0018', N'STP00029', 1, CAST(N'1900-01-01 06:41:00.000' AS DateTime), 0, N'')
INSERT [dbo].[Attendance] ([Attendance_Id], [Gathering_ID], [brethren_id], [Church_ID], [Attendance_Status], [Real_Time], [is_interlocale], [remarks]) VALUES (1086, N'173TGPW1SUN6:00 AM', N'B-0056', N'11606363', 1, CAST(N'1900-01-01 06:41:00.000' AS DateTime), 0, N'')
INSERT [dbo].[Attendance] ([Attendance_Id], [Gathering_ID], [brethren_id], [Church_ID], [Attendance_Status], [Real_Time], [is_interlocale], [remarks]) VALUES (1087, N'173TGPW1SUN6:00 AM', N'B-0013', N'STP00094', 1, CAST(N'1900-01-01 06:48:00.000' AS DateTime), 0, N'')
INSERT [dbo].[Attendance] ([Attendance_Id], [Gathering_ID], [brethren_id], [Church_ID], [Attendance_Status], [Real_Time], [is_interlocale], [remarks]) VALUES (1088, N'173TGPW1SUN6:00 AM', N'B-0026', N'11112207', 1, CAST(N'1900-01-01 06:50:00.000' AS DateTime), 0, N'')
INSERT [dbo].[Attendance] ([Attendance_Id], [Gathering_ID], [brethren_id], [Church_ID], [Attendance_Status], [Real_Time], [is_interlocale], [remarks]) VALUES (1089, N'173TGPW1SUN6:00 AM', N'B-0060', N'STP00080', 1, CAST(N'1900-01-01 07:03:00.000' AS DateTime), 0, N'')
INSERT [dbo].[Attendance] ([Attendance_Id], [Gathering_ID], [brethren_id], [Church_ID], [Attendance_Status], [Real_Time], [is_interlocale], [remarks]) VALUES (1090, N'173TGPW1SUN6:00 AM', N'B-0042', N'11478797', 1, CAST(N'1900-01-01 07:09:00.000' AS DateTime), 0, N'')
INSERT [dbo].[Attendance] ([Attendance_Id], [Gathering_ID], [brethren_id], [Church_ID], [Attendance_Status], [Real_Time], [is_interlocale], [remarks]) VALUES (2091, N'173SPMW2TUE5:30 PM', N'B-0018', N'STP00029', 1, CAST(N'1900-01-01 17:46:00.000' AS DateTime), 0, N'')
INSERT [dbo].[Attendance] ([Attendance_Id], [Gathering_ID], [brethren_id], [Church_ID], [Attendance_Status], [Real_Time], [is_interlocale], [remarks]) VALUES (2092, N'173SPMW2TUE5:30 PM', N'B-0032', N'11307397', 1, CAST(N'1900-01-01 17:46:00.000' AS DateTime), 0, N'')
INSERT [dbo].[Attendance] ([Attendance_Id], [Gathering_ID], [brethren_id], [Church_ID], [Attendance_Status], [Real_Time], [is_interlocale], [remarks]) VALUES (2093, N'173SPMW2TUE5:30 PM', N'B-0038', N'11416006', 1, CAST(N'1900-01-01 17:46:00.000' AS DateTime), 0, N'')
INSERT [dbo].[Attendance] ([Attendance_Id], [Gathering_ID], [brethren_id], [Church_ID], [Attendance_Status], [Real_Time], [is_interlocale], [remarks]) VALUES (2094, N'173SPMW2TUE5:30 PM', N'B-0023', N'STP00048', 1, CAST(N'1900-01-01 17:46:00.000' AS DateTime), 0, N'')
GO
INSERT [dbo].[Attendance] ([Attendance_Id], [Gathering_ID], [brethren_id], [Church_ID], [Attendance_Status], [Real_Time], [is_interlocale], [remarks]) VALUES (2095, N'173SPMW2TUE5:30 PM', N'B-0001', N'MA600030', 1, CAST(N'1900-01-01 17:46:00.000' AS DateTime), 0, N'')
INSERT [dbo].[Attendance] ([Attendance_Id], [Gathering_ID], [brethren_id], [Church_ID], [Attendance_Status], [Real_Time], [is_interlocale], [remarks]) VALUES (2096, N'173SPMW2TUE5:30 PM', N'B-0031', N'701653', 1, CAST(N'1900-01-01 17:46:00.000' AS DateTime), 0, N'')
INSERT [dbo].[Attendance] ([Attendance_Id], [Gathering_ID], [brethren_id], [Church_ID], [Attendance_Status], [Real_Time], [is_interlocale], [remarks]) VALUES (2097, N'173SPMW2TUE5:30 PM', N'B-64', N'STP00106', 1, CAST(N'1900-01-01 17:46:00.000' AS DateTime), 0, N'')
INSERT [dbo].[Attendance] ([Attendance_Id], [Gathering_ID], [brethren_id], [Church_ID], [Attendance_Status], [Real_Time], [is_interlocale], [remarks]) VALUES (2098, N'173SPMW2TUE5:30 PM', N'B-0014', N'STP00096', 1, CAST(N'1900-01-01 17:47:00.000' AS DateTime), 0, N'')
INSERT [dbo].[Attendance] ([Attendance_Id], [Gathering_ID], [brethren_id], [Church_ID], [Attendance_Status], [Real_Time], [is_interlocale], [remarks]) VALUES (2099, N'173SPMW2TUE5:30 PM', N'B-0036', N'11403632', 1, CAST(N'1900-01-01 17:47:00.000' AS DateTime), 0, N'')
INSERT [dbo].[Attendance] ([Attendance_Id], [Gathering_ID], [brethren_id], [Church_ID], [Attendance_Status], [Real_Time], [is_interlocale], [remarks]) VALUES (2100, N'173SPMW2TUE5:30 PM', N'B-0027', N'11112036', 1, CAST(N'1900-01-01 17:47:00.000' AS DateTime), 0, N'')
INSERT [dbo].[Attendance] ([Attendance_Id], [Gathering_ID], [brethren_id], [Church_ID], [Attendance_Status], [Real_Time], [is_interlocale], [remarks]) VALUES (2101, N'173SPMW2TUE5:30 PM', N'B-0019', N'STP00057', 1, CAST(N'1900-01-01 17:47:00.000' AS DateTime), 0, N'')
INSERT [dbo].[Attendance] ([Attendance_Id], [Gathering_ID], [brethren_id], [Church_ID], [Attendance_Status], [Real_Time], [is_interlocale], [remarks]) VALUES (2102, N'173SPMW2TUE5:30 PM', N'B-0021', N'STP00012', 1, CAST(N'1900-01-01 17:47:00.000' AS DateTime), 0, N'')
INSERT [dbo].[Attendance] ([Attendance_Id], [Gathering_ID], [brethren_id], [Church_ID], [Attendance_Status], [Real_Time], [is_interlocale], [remarks]) VALUES (2103, N'173SPMW2TUE5:30 PM', N'IL-7', N'ANG00235', 1, CAST(N'1900-01-01 17:47:00.000' AS DateTime), 1, N'ACC')
INSERT [dbo].[Attendance] ([Attendance_Id], [Gathering_ID], [brethren_id], [Church_ID], [Attendance_Status], [Real_Time], [is_interlocale], [remarks]) VALUES (2104, N'173SPMW2TUE5:30 PM', N'IL-8', N'ANG00067', 1, CAST(N'1900-01-01 17:47:00.000' AS DateTime), 1, N'ACC')
INSERT [dbo].[Attendance] ([Attendance_Id], [Gathering_ID], [brethren_id], [Church_ID], [Attendance_Status], [Real_Time], [is_interlocale], [remarks]) VALUES (2105, N'173SPMW2TUE5:30 PM', N'B-0034', N'STP00084', 1, CAST(N'1900-01-01 17:48:00.000' AS DateTime), 0, N'')
INSERT [dbo].[Attendance] ([Attendance_Id], [Gathering_ID], [brethren_id], [Church_ID], [Attendance_Status], [Real_Time], [is_interlocale], [remarks]) VALUES (2106, N'173SPMW2TUE5:30 PM', N'B-0028', N'808939', 1, CAST(N'1900-01-01 17:48:00.000' AS DateTime), 0, N'')
INSERT [dbo].[Attendance] ([Attendance_Id], [Gathering_ID], [brethren_id], [Church_ID], [Attendance_Status], [Real_Time], [is_interlocale], [remarks]) VALUES (2107, N'173SPMW2TUE5:30 PM', N'B-0013', N'STP00094', 1, CAST(N'1900-01-01 17:50:00.000' AS DateTime), 0, N'')
INSERT [dbo].[Attendance] ([Attendance_Id], [Gathering_ID], [brethren_id], [Church_ID], [Attendance_Status], [Real_Time], [is_interlocale], [remarks]) VALUES (2108, N'173SPMW2TUE5:30 PM', N'B-0061', N'STP00079', 1, CAST(N'1900-01-01 17:50:00.000' AS DateTime), 0, N'')
INSERT [dbo].[Attendance] ([Attendance_Id], [Gathering_ID], [brethren_id], [Church_ID], [Attendance_Status], [Real_Time], [is_interlocale], [remarks]) VALUES (2109, N'173SPMW2TUE5:30 PM', N'B-0051', N'11402791', 1, CAST(N'1900-01-01 17:50:00.000' AS DateTime), 0, N'')
INSERT [dbo].[Attendance] ([Attendance_Id], [Gathering_ID], [brethren_id], [Church_ID], [Attendance_Status], [Real_Time], [is_interlocale], [remarks]) VALUES (2110, N'173SPMW2TUE5:30 PM', N'B-0060', N'STP00080', 1, CAST(N'1900-01-01 17:57:00.000' AS DateTime), 0, N'')
INSERT [dbo].[Attendance] ([Attendance_Id], [Gathering_ID], [brethren_id], [Church_ID], [Attendance_Status], [Real_Time], [is_interlocale], [remarks]) VALUES (2111, N'173SPMW2TUE5:30 PM', N'B-0044', N'00000000', 1, CAST(N'1900-01-01 17:58:00.000' AS DateTime), 0, N'')
INSERT [dbo].[Attendance] ([Attendance_Id], [Gathering_ID], [brethren_id], [Church_ID], [Attendance_Status], [Real_Time], [is_interlocale], [remarks]) VALUES (2112, N'173SPMW2TUE5:30 PM', N'B-0042', N'11478797', 1, CAST(N'1900-01-01 17:58:00.000' AS DateTime), 0, N'')
INSERT [dbo].[Attendance] ([Attendance_Id], [Gathering_ID], [brethren_id], [Church_ID], [Attendance_Status], [Real_Time], [is_interlocale], [remarks]) VALUES (2113, N'173WSW3SAT7:30 PM', N'B-0037', N'11416458', 1, CAST(N'1900-01-01 19:32:00.000' AS DateTime), 0, N'')
INSERT [dbo].[Attendance] ([Attendance_Id], [Gathering_ID], [brethren_id], [Church_ID], [Attendance_Status], [Real_Time], [is_interlocale], [remarks]) VALUES (2114, N'173WSW3SAT7:30 PM', N'B-0038', N'11416006', 1, CAST(N'1900-01-01 19:32:00.000' AS DateTime), 0, N'')
INSERT [dbo].[Attendance] ([Attendance_Id], [Gathering_ID], [brethren_id], [Church_ID], [Attendance_Status], [Real_Time], [is_interlocale], [remarks]) VALUES (2115, N'173WSW3SAT7:30 PM', N'B-0018', N'STP00029', 1, CAST(N'1900-01-01 19:32:00.000' AS DateTime), 0, N'')
INSERT [dbo].[Attendance] ([Attendance_Id], [Gathering_ID], [brethren_id], [Church_ID], [Attendance_Status], [Real_Time], [is_interlocale], [remarks]) VALUES (2116, N'173WSW3SAT7:30 PM', N'B-0032', N'11307397', 1, CAST(N'1900-01-01 19:32:00.000' AS DateTime), 0, N'')
INSERT [dbo].[Attendance] ([Attendance_Id], [Gathering_ID], [brethren_id], [Church_ID], [Attendance_Status], [Real_Time], [is_interlocale], [remarks]) VALUES (2117, N'173WSW3SAT7:30 PM', N'B-0027', N'11112036', 1, CAST(N'1900-01-01 19:32:00.000' AS DateTime), 0, N'')
INSERT [dbo].[Attendance] ([Attendance_Id], [Gathering_ID], [brethren_id], [Church_ID], [Attendance_Status], [Real_Time], [is_interlocale], [remarks]) VALUES (2118, N'173WSW3SAT7:30 PM', N'B-0061', N'STP00079', 1, CAST(N'1900-01-01 19:32:00.000' AS DateTime), 0, N'')
INSERT [dbo].[Attendance] ([Attendance_Id], [Gathering_ID], [brethren_id], [Church_ID], [Attendance_Status], [Real_Time], [is_interlocale], [remarks]) VALUES (2119, N'173WSW3SAT7:30 PM', N'B-0042', N'11478797', 1, CAST(N'1900-01-01 19:33:00.000' AS DateTime), 0, N'')
INSERT [dbo].[Attendance] ([Attendance_Id], [Gathering_ID], [brethren_id], [Church_ID], [Attendance_Status], [Real_Time], [is_interlocale], [remarks]) VALUES (2120, N'173WSW3SAT7:30 PM', N'B-0053', N'11604442', 1, CAST(N'1900-01-01 19:33:00.000' AS DateTime), 0, N'')
INSERT [dbo].[Attendance] ([Attendance_Id], [Gathering_ID], [brethren_id], [Church_ID], [Attendance_Status], [Real_Time], [is_interlocale], [remarks]) VALUES (2121, N'173WSW3SAT7:30 PM', N'B-0015', N'STP00097', 1, CAST(N'1900-01-01 19:33:00.000' AS DateTime), 0, N'')
INSERT [dbo].[Attendance] ([Attendance_Id], [Gathering_ID], [brethren_id], [Church_ID], [Attendance_Status], [Real_Time], [is_interlocale], [remarks]) VALUES (2122, N'173WSW3SAT7:30 PM', N'B-0058', N'11612756', 1, CAST(N'1900-01-01 19:33:00.000' AS DateTime), 0, N'')
INSERT [dbo].[Attendance] ([Attendance_Id], [Gathering_ID], [brethren_id], [Church_ID], [Attendance_Status], [Real_Time], [is_interlocale], [remarks]) VALUES (2123, N'173WSW3SAT7:30 PM', N'B-0014', N'STP00096', 1, CAST(N'1900-01-01 19:33:00.000' AS DateTime), 0, N'')
INSERT [dbo].[Attendance] ([Attendance_Id], [Gathering_ID], [brethren_id], [Church_ID], [Attendance_Status], [Real_Time], [is_interlocale], [remarks]) VALUES (2124, N'173WSW3SAT7:30 PM', N'B-66', N'STP00042', 1, CAST(N'1900-01-01 19:33:00.000' AS DateTime), 0, N'')
INSERT [dbo].[Attendance] ([Attendance_Id], [Gathering_ID], [brethren_id], [Church_ID], [Attendance_Status], [Real_Time], [is_interlocale], [remarks]) VALUES (2125, N'173WSW3SAT7:30 PM', N'B-0023', N'STP00048', 1, CAST(N'1900-01-01 19:33:00.000' AS DateTime), 0, N'')
INSERT [dbo].[Attendance] ([Attendance_Id], [Gathering_ID], [brethren_id], [Church_ID], [Attendance_Status], [Real_Time], [is_interlocale], [remarks]) VALUES (2126, N'173WSW3SAT7:30 PM', N'B-0034', N'STP00084', 1, CAST(N'1900-01-01 19:33:00.000' AS DateTime), 0, N'')
INSERT [dbo].[Attendance] ([Attendance_Id], [Gathering_ID], [brethren_id], [Church_ID], [Attendance_Status], [Real_Time], [is_interlocale], [remarks]) VALUES (2127, N'173WSW3SAT7:30 PM', N'IL-3', N'STP00009', 1, CAST(N'1900-01-01 19:33:00.000' AS DateTime), 1, N'ACC')
INSERT [dbo].[Attendance] ([Attendance_Id], [Gathering_ID], [brethren_id], [Church_ID], [Attendance_Status], [Real_Time], [is_interlocale], [remarks]) VALUES (2128, N'173WSW3SAT7:30 PM', N'IL-6', N'STP00056', 1, CAST(N'1900-01-01 19:36:00.000' AS DateTime), 1, N'ACC')
INSERT [dbo].[Attendance] ([Attendance_Id], [Gathering_ID], [brethren_id], [Church_ID], [Attendance_Status], [Real_Time], [is_interlocale], [remarks]) VALUES (2129, N'173WSW3SAT7:30 PM', N'B-0062', N'11006953', 1, CAST(N'1900-01-01 19:37:00.000' AS DateTime), 0, N'')
INSERT [dbo].[Attendance] ([Attendance_Id], [Gathering_ID], [brethren_id], [Church_ID], [Attendance_Status], [Real_Time], [is_interlocale], [remarks]) VALUES (2130, N'173WSW3SAT7:30 PM', N'B-0044', N'00000000', 1, CAST(N'1900-01-01 19:52:00.000' AS DateTime), 0, N'')
INSERT [dbo].[Attendance] ([Attendance_Id], [Gathering_ID], [brethren_id], [Church_ID], [Attendance_Status], [Real_Time], [is_interlocale], [remarks]) VALUES (2131, N'173WSW3SAT7:30 PM', N'B-0012', N'STP00042', 1, CAST(N'1900-01-01 20:40:00.000' AS DateTime), 0, N'')
INSERT [dbo].[Attendance] ([Attendance_Id], [Gathering_ID], [brethren_id], [Church_ID], [Attendance_Status], [Real_Time], [is_interlocale], [remarks]) VALUES (2132, N'173WSW3SAT7:30 PM', N'B-0026', N'11112207', 1, CAST(N'1900-01-01 20:41:00.000' AS DateTime), 0, N'')
INSERT [dbo].[Attendance] ([Attendance_Id], [Gathering_ID], [brethren_id], [Church_ID], [Attendance_Status], [Real_Time], [is_interlocale], [remarks]) VALUES (2133, N'173WSW3SAT7:30 PM', N'B-0060', N'STP00080', 1, CAST(N'1900-01-01 20:41:00.000' AS DateTime), 0, N'')
INSERT [dbo].[Attendance] ([Attendance_Id], [Gathering_ID], [brethren_id], [Church_ID], [Attendance_Status], [Real_Time], [is_interlocale], [remarks]) VALUES (2134, N'173TGPW2SUN6:00 AM', N'B-0041', N'11422172', 1, CAST(N'1900-01-01 06:20:00.000' AS DateTime), 0, N'')
INSERT [dbo].[Attendance] ([Attendance_Id], [Gathering_ID], [brethren_id], [Church_ID], [Attendance_Status], [Real_Time], [is_interlocale], [remarks]) VALUES (2135, N'173TGPW2SUN6:00 AM', N'B-0013', N'STP00094', 1, CAST(N'1900-01-01 06:20:00.000' AS DateTime), 0, N'')
INSERT [dbo].[Attendance] ([Attendance_Id], [Gathering_ID], [brethren_id], [Church_ID], [Attendance_Status], [Real_Time], [is_interlocale], [remarks]) VALUES (2136, N'173TGPW2SUN6:00 AM', N'B-0037', N'11416458', 1, CAST(N'1900-01-01 06:20:00.000' AS DateTime), 0, N'')
INSERT [dbo].[Attendance] ([Attendance_Id], [Gathering_ID], [brethren_id], [Church_ID], [Attendance_Status], [Real_Time], [is_interlocale], [remarks]) VALUES (2137, N'173TGPW2SUN6:00 AM', N'B-0038', N'11416006', 1, CAST(N'1900-01-01 06:20:00.000' AS DateTime), 0, N'')
INSERT [dbo].[Attendance] ([Attendance_Id], [Gathering_ID], [brethren_id], [Church_ID], [Attendance_Status], [Real_Time], [is_interlocale], [remarks]) VALUES (2138, N'173TGPW2SUN6:00 AM', N'B-0002', N'STP00125', 1, CAST(N'1900-01-01 06:21:00.000' AS DateTime), 0, N'')
INSERT [dbo].[Attendance] ([Attendance_Id], [Gathering_ID], [brethren_id], [Church_ID], [Attendance_Status], [Real_Time], [is_interlocale], [remarks]) VALUES (2139, N'173TGPW2SUN6:00 AM', N'IL-7', N'ANG00235', 1, CAST(N'1900-01-01 06:21:00.000' AS DateTime), 1, N'ACC')
INSERT [dbo].[Attendance] ([Attendance_Id], [Gathering_ID], [brethren_id], [Church_ID], [Attendance_Status], [Real_Time], [is_interlocale], [remarks]) VALUES (2140, N'173TGPW2SUN6:00 AM', N'IL-8', N'ANG00067', 1, CAST(N'1900-01-01 06:21:00.000' AS DateTime), 1, N'ACC')
INSERT [dbo].[Attendance] ([Attendance_Id], [Gathering_ID], [brethren_id], [Church_ID], [Attendance_Status], [Real_Time], [is_interlocale], [remarks]) VALUES (2141, N'173TGPW2SUN6:00 AM', N'B-0027', N'11112036', 1, CAST(N'1900-01-01 06:21:00.000' AS DateTime), 0, N'')
INSERT [dbo].[Attendance] ([Attendance_Id], [Gathering_ID], [brethren_id], [Church_ID], [Attendance_Status], [Real_Time], [is_interlocale], [remarks]) VALUES (2142, N'173TGPW2SUN6:00 AM', N'B-66', N'STP00042', 1, CAST(N'1900-01-01 06:21:00.000' AS DateTime), 0, N'')
INSERT [dbo].[Attendance] ([Attendance_Id], [Gathering_ID], [brethren_id], [Church_ID], [Attendance_Status], [Real_Time], [is_interlocale], [remarks]) VALUES (2143, N'173TGPW2SUN6:00 AM', N'B-0023', N'STP00048', 1, CAST(N'1900-01-01 06:21:00.000' AS DateTime), 0, N'')
INSERT [dbo].[Attendance] ([Attendance_Id], [Gathering_ID], [brethren_id], [Church_ID], [Attendance_Status], [Real_Time], [is_interlocale], [remarks]) VALUES (2144, N'173TGPW2SUN6:00 AM', N'IL-3', N'STP00009', 1, CAST(N'1900-01-01 06:21:00.000' AS DateTime), 1, N'ACC')
INSERT [dbo].[Attendance] ([Attendance_Id], [Gathering_ID], [brethren_id], [Church_ID], [Attendance_Status], [Real_Time], [is_interlocale], [remarks]) VALUES (2145, N'173TGPW2SUN6:00 AM', N'B-0034', N'STP00084', 1, CAST(N'1900-01-01 06:25:00.000' AS DateTime), 0, N'')
INSERT [dbo].[Attendance] ([Attendance_Id], [Gathering_ID], [brethren_id], [Church_ID], [Attendance_Status], [Real_Time], [is_interlocale], [remarks]) VALUES (2146, N'173TGPW2SUN6:00 AM', N'B-0033', N'11308026', 1, CAST(N'1900-01-01 06:33:00.000' AS DateTime), 0, N'')
INSERT [dbo].[Attendance] ([Attendance_Id], [Gathering_ID], [brethren_id], [Church_ID], [Attendance_Status], [Real_Time], [is_interlocale], [remarks]) VALUES (2147, N'173TGPW2SUN6:00 AM', N'B-0018', N'STP00029', 1, CAST(N'1900-01-01 06:34:00.000' AS DateTime), 0, N'')
INSERT [dbo].[Attendance] ([Attendance_Id], [Gathering_ID], [brethren_id], [Church_ID], [Attendance_Status], [Real_Time], [is_interlocale], [remarks]) VALUES (2148, N'173TGPW2SUN6:00 AM', N'B-67', N'11105434', 1, CAST(N'1900-01-01 06:36:00.000' AS DateTime), 0, N'')
INSERT [dbo].[Attendance] ([Attendance_Id], [Gathering_ID], [brethren_id], [Church_ID], [Attendance_Status], [Real_Time], [is_interlocale], [remarks]) VALUES (2149, N'173TGPW2SUN6:00 AM', N'B-0003', N'STP00122', 1, CAST(N'1900-01-01 06:37:00.000' AS DateTime), 0, N'')
INSERT [dbo].[Attendance] ([Attendance_Id], [Gathering_ID], [brethren_id], [Church_ID], [Attendance_Status], [Real_Time], [is_interlocale], [remarks]) VALUES (2150, N'173TGPW2SUN6:00 AM', N'B-0015', N'STP00097', 1, CAST(N'1900-01-01 06:38:00.000' AS DateTime), 0, N'')
INSERT [dbo].[Attendance] ([Attendance_Id], [Gathering_ID], [brethren_id], [Church_ID], [Attendance_Status], [Real_Time], [is_interlocale], [remarks]) VALUES (2151, N'173TGPW2SUN6:00 AM', N'B-0014', N'STP00096', 1, CAST(N'1900-01-01 06:38:00.000' AS DateTime), 0, N'')
INSERT [dbo].[Attendance] ([Attendance_Id], [Gathering_ID], [brethren_id], [Church_ID], [Attendance_Status], [Real_Time], [is_interlocale], [remarks]) VALUES (2152, N'173TGPW2SUN6:00 AM', N'B-0056', N'11606363', 1, CAST(N'1900-01-01 06:41:00.000' AS DateTime), 0, N'')
INSERT [dbo].[Attendance] ([Attendance_Id], [Gathering_ID], [brethren_id], [Church_ID], [Attendance_Status], [Real_Time], [is_interlocale], [remarks]) VALUES (2153, N'173TGPW2SUN6:00 AM', N'B-0042', N'11478797', 1, CAST(N'1900-01-01 06:56:00.000' AS DateTime), 0, N'')
INSERT [dbo].[Attendance] ([Attendance_Id], [Gathering_ID], [brethren_id], [Church_ID], [Attendance_Status], [Real_Time], [is_interlocale], [remarks]) VALUES (2154, N'173TGPW2SUN6:00 AM', N'B-0060', N'STP00080', 1, CAST(N'1900-01-01 07:09:00.000' AS DateTime), 0, N'')
INSERT [dbo].[Attendance] ([Attendance_Id], [Gathering_ID], [brethren_id], [Church_ID], [Attendance_Status], [Real_Time], [is_interlocale], [remarks]) VALUES (2155, N'173TGPW2SUN6:00 AM', N'B-0062', N'11006953', 1, CAST(N'1900-01-01 07:09:00.000' AS DateTime), 0, N'')
INSERT [dbo].[Attendance] ([Attendance_Id], [Gathering_ID], [brethren_id], [Church_ID], [Attendance_Status], [Real_Time], [is_interlocale], [remarks]) VALUES (2156, N'173PMW3WED7:30 PM', N'B-0018', N'STP00029', 1, CAST(N'1900-01-01 19:25:00.000' AS DateTime), 0, N'')
INSERT [dbo].[Attendance] ([Attendance_Id], [Gathering_ID], [brethren_id], [Church_ID], [Attendance_Status], [Real_Time], [is_interlocale], [remarks]) VALUES (2157, N'173PMW3WED7:30 PM', N'B-0006', N'STP00061', 1, CAST(N'1900-01-01 19:25:00.000' AS DateTime), 0, N'')
INSERT [dbo].[Attendance] ([Attendance_Id], [Gathering_ID], [brethren_id], [Church_ID], [Attendance_Status], [Real_Time], [is_interlocale], [remarks]) VALUES (2158, N'173PMW3WED7:30 PM', N'B-0013', N'STP00094', 1, CAST(N'1900-01-01 19:25:00.000' AS DateTime), 0, N'')
INSERT [dbo].[Attendance] ([Attendance_Id], [Gathering_ID], [brethren_id], [Church_ID], [Attendance_Status], [Real_Time], [is_interlocale], [remarks]) VALUES (2159, N'173PMW3WED7:30 PM', N'B-0037', N'11416458', 1, CAST(N'1900-01-01 19:26:00.000' AS DateTime), 0, N'')
INSERT [dbo].[Attendance] ([Attendance_Id], [Gathering_ID], [brethren_id], [Church_ID], [Attendance_Status], [Real_Time], [is_interlocale], [remarks]) VALUES (2160, N'173PMW3WED7:30 PM', N'B-0038', N'11416006', 1, CAST(N'1900-01-01 19:26:00.000' AS DateTime), 0, N'')
INSERT [dbo].[Attendance] ([Attendance_Id], [Gathering_ID], [brethren_id], [Church_ID], [Attendance_Status], [Real_Time], [is_interlocale], [remarks]) VALUES (2161, N'173PMW3WED7:30 PM', N'B-0061', N'STP00079', 1, CAST(N'1900-01-01 19:26:00.000' AS DateTime), 0, N'')
INSERT [dbo].[Attendance] ([Attendance_Id], [Gathering_ID], [brethren_id], [Church_ID], [Attendance_Status], [Real_Time], [is_interlocale], [remarks]) VALUES (2162, N'173PMW3WED7:30 PM', N'B-0001', N'MA600030', 1, CAST(N'1900-01-01 19:26:00.000' AS DateTime), 0, N'')
INSERT [dbo].[Attendance] ([Attendance_Id], [Gathering_ID], [brethren_id], [Church_ID], [Attendance_Status], [Real_Time], [is_interlocale], [remarks]) VALUES (2163, N'173PMW3WED7:30 PM', N'B-0033', N'11308026', 1, CAST(N'1900-01-01 19:26:00.000' AS DateTime), 0, N'')
INSERT [dbo].[Attendance] ([Attendance_Id], [Gathering_ID], [brethren_id], [Church_ID], [Attendance_Status], [Real_Time], [is_interlocale], [remarks]) VALUES (2164, N'173PMW3WED7:30 PM', N'B-0027', N'11112036', 1, CAST(N'1900-01-01 19:26:00.000' AS DateTime), 0, N'')
INSERT [dbo].[Attendance] ([Attendance_Id], [Gathering_ID], [brethren_id], [Church_ID], [Attendance_Status], [Real_Time], [is_interlocale], [remarks]) VALUES (2165, N'173PMW3WED7:30 PM', N'IL-7', N'ANG00235', 1, CAST(N'1900-01-01 19:26:00.000' AS DateTime), 1, N'ACC')
INSERT [dbo].[Attendance] ([Attendance_Id], [Gathering_ID], [brethren_id], [Church_ID], [Attendance_Status], [Real_Time], [is_interlocale], [remarks]) VALUES (2166, N'173PMW3WED7:30 PM', N'IL-8', N'ANG00067', 1, CAST(N'1900-01-01 19:26:00.000' AS DateTime), 1, N'ACC')
INSERT [dbo].[Attendance] ([Attendance_Id], [Gathering_ID], [brethren_id], [Church_ID], [Attendance_Status], [Real_Time], [is_interlocale], [remarks]) VALUES (2167, N'173PMW3WED7:30 PM', N'B-0060', N'STP00080', 1, CAST(N'1900-01-01 19:26:00.000' AS DateTime), 0, N'')
INSERT [dbo].[Attendance] ([Attendance_Id], [Gathering_ID], [brethren_id], [Church_ID], [Attendance_Status], [Real_Time], [is_interlocale], [remarks]) VALUES (2168, N'173PMW3WED7:30 PM', N'B-0019', N'STP00057', 1, CAST(N'1900-01-01 19:27:00.000' AS DateTime), 0, N'')
INSERT [dbo].[Attendance] ([Attendance_Id], [Gathering_ID], [brethren_id], [Church_ID], [Attendance_Status], [Real_Time], [is_interlocale], [remarks]) VALUES (2169, N'173PMW3WED7:30 PM', N'B-64', N'STP00106', 1, CAST(N'1900-01-01 19:27:00.000' AS DateTime), 0, N'')
INSERT [dbo].[Attendance] ([Attendance_Id], [Gathering_ID], [brethren_id], [Church_ID], [Attendance_Status], [Real_Time], [is_interlocale], [remarks]) VALUES (2170, N'173PMW3WED7:30 PM', N'B-0023', N'STP00048', 1, CAST(N'1900-01-01 19:27:00.000' AS DateTime), 0, N'')
INSERT [dbo].[Attendance] ([Attendance_Id], [Gathering_ID], [brethren_id], [Church_ID], [Attendance_Status], [Real_Time], [is_interlocale], [remarks]) VALUES (2171, N'173PMW3WED7:30 PM', N'B-0034', N'STP00084', 1, CAST(N'1900-01-01 19:27:00.000' AS DateTime), 0, N'')
INSERT [dbo].[Attendance] ([Attendance_Id], [Gathering_ID], [brethren_id], [Church_ID], [Attendance_Status], [Real_Time], [is_interlocale], [remarks]) VALUES (2172, N'173PMW3WED7:30 PM', N'B-0036', N'11403632', 1, CAST(N'1900-01-01 19:32:00.000' AS DateTime), 0, N'')
INSERT [dbo].[Attendance] ([Attendance_Id], [Gathering_ID], [brethren_id], [Church_ID], [Attendance_Status], [Real_Time], [is_interlocale], [remarks]) VALUES (2173, N'173PMW3WED7:30 PM', N'B-0021', N'STP00012', 1, CAST(N'1900-01-01 19:32:00.000' AS DateTime), 0, N'')
INSERT [dbo].[Attendance] ([Attendance_Id], [Gathering_ID], [brethren_id], [Church_ID], [Attendance_Status], [Real_Time], [is_interlocale], [remarks]) VALUES (2174, N'173PMW3WED7:30 PM', N'B-0028', N'808939', 1, CAST(N'1900-01-01 19:32:00.000' AS DateTime), 0, N'')
INSERT [dbo].[Attendance] ([Attendance_Id], [Gathering_ID], [brethren_id], [Church_ID], [Attendance_Status], [Real_Time], [is_interlocale], [remarks]) VALUES (2175, N'173PMW3WED7:30 PM', N'B-0008', N'701145', 1, CAST(N'1900-01-01 19:37:00.000' AS DateTime), 0, N'')
INSERT [dbo].[Attendance] ([Attendance_Id], [Gathering_ID], [brethren_id], [Church_ID], [Attendance_Status], [Real_Time], [is_interlocale], [remarks]) VALUES (2176, N'173PMW3WED7:30 PM', N'B-0056', N'11606363', 1, CAST(N'1900-01-01 19:37:00.000' AS DateTime), 0, N'')
INSERT [dbo].[Attendance] ([Attendance_Id], [Gathering_ID], [brethren_id], [Church_ID], [Attendance_Status], [Real_Time], [is_interlocale], [remarks]) VALUES (2177, N'173PMW3WED7:30 PM', N'B-0026', N'11112207', 1, CAST(N'1900-01-01 19:50:00.000' AS DateTime), 0, N'')
INSERT [dbo].[Attendance] ([Attendance_Id], [Gathering_ID], [brethren_id], [Church_ID], [Attendance_Status], [Real_Time], [is_interlocale], [remarks]) VALUES (2178, N'173PMW3WED7:30 PM', N'B-0044', N'00000000', 1, CAST(N'1900-01-01 19:51:00.000' AS DateTime), 0, N'')
INSERT [dbo].[Attendance] ([Attendance_Id], [Gathering_ID], [brethren_id], [Church_ID], [Attendance_Status], [Real_Time], [is_interlocale], [remarks]) VALUES (2179, N'173PMW3WED7:30 PM', N'B-0042', N'11478797', 1, CAST(N'1900-01-01 19:53:00.000' AS DateTime), 0, N'')
SET IDENTITY_INSERT [dbo].[Attendance] OFF
SET IDENTITY_INSERT [dbo].[Batches] ON 

INSERT [dbo].[Batches] ([Batch_ID], [Batch_Code], [gathering_id], [Batch_Time]) VALUES (6, N'B1', 1, CAST(N'1900-01-01 17:30:00.000' AS DateTime))
INSERT [dbo].[Batches] ([Batch_ID], [Batch_Code], [gathering_id], [Batch_Time]) VALUES (10, N'B1', 2, CAST(N'1900-01-01 06:00:00.000' AS DateTime))
INSERT [dbo].[Batches] ([Batch_ID], [Batch_Code], [gathering_id], [Batch_Time]) VALUES (12, N'B1', 3, CAST(N'1900-01-01 19:30:00.000' AS DateTime))
INSERT [dbo].[Batches] ([Batch_ID], [Batch_Code], [gathering_id], [Batch_Time]) VALUES (13, N'B1', 5, CAST(N'1900-01-01 06:00:00.000' AS DateTime))
SET IDENTITY_INSERT [dbo].[Batches] OFF
INSERT [dbo].[Brethren] ([brethren_id], [Church_Id], [Firstname], [Middlename], [Lastname], [Image_Path], [Sketch_Path], [Date_Baptism], [Date_Birth], [Gender], [Civil_Status], [Street], [Brgy], [City_Town], [Province], [Region], [Employment], [Phone_no], [Contact_Person], [Contact_Person_no], [Status], [Remarks], [Group_ID], [Committee_Names], [locale_id], [Baptizer], [is_contact_person_member], [is_deleted]) VALUES (N'B-0001', N'MA600030', N'RUTH', N'ESTRABILLO', N'DUNGAO', NULL, NULL, CAST(N'2000-06-30' AS Date), CAST(N'1985-06-02' AS Date), N'FEMALE', N'Married', N'56 SAN ISIDRO', N'STA.CRUZ', N'PORAC', N'PAMPANGA', N'3', NULL, N'9.22919e+009', N'OMAR DUNGAO', NULL, N'Active', NULL, 1, NULL, 5, NULL, 1, 0)
INSERT [dbo].[Brethren] ([brethren_id], [Church_Id], [Firstname], [Middlename], [Lastname], [Image_Path], [Sketch_Path], [Date_Baptism], [Date_Birth], [Gender], [Civil_Status], [Street], [Brgy], [City_Town], [Province], [Region], [Employment], [Phone_no], [Contact_Person], [Contact_Person_no], [Status], [Remarks], [Group_ID], [Committee_Names], [locale_id], [Baptizer], [is_contact_person_member], [is_deleted]) VALUES (N'B-0002', N'STP00125', N'WESLEY', N'VILLANUEVA', N'DAYRIT', NULL, NULL, CAST(N'2005-10-07' AS Date), CAST(N'1970-01-14' AS Date), N'MALE', N'Married', N'SAN MARCELINO', N'STA.CRUZ', N'PORAC', N'PAMPANGA', N'3', NULL, NULL, N'DIODEMA DAYRIT', NULL, N'Active', NULL, 3, NULL, 5, NULL, 1, 0)
INSERT [dbo].[Brethren] ([brethren_id], [Church_Id], [Firstname], [Middlename], [Lastname], [Image_Path], [Sketch_Path], [Date_Baptism], [Date_Birth], [Gender], [Civil_Status], [Street], [Brgy], [City_Town], [Province], [Region], [Employment], [Phone_no], [Contact_Person], [Contact_Person_no], [Status], [Remarks], [Group_ID], [Committee_Names], [locale_id], [Baptizer], [is_contact_person_member], [is_deleted]) VALUES (N'B-0003', N'STP00122', N'DIODEMA', N'PATINING', N'DAYRIT', NULL, NULL, CAST(N'2005-09-02' AS Date), CAST(N'1964-06-05' AS Date), N'FEMALE', N'Married', N'SAN MARCELINO', N'STA.CRUZ', N'PORAC', N'PAMPANGA', N'3', NULL, NULL, N'WESLEY DAYRIT', NULL, N'Active', NULL, 3, NULL, 5, NULL, 1, 0)
INSERT [dbo].[Brethren] ([brethren_id], [Church_Id], [Firstname], [Middlename], [Lastname], [Image_Path], [Sketch_Path], [Date_Baptism], [Date_Birth], [Gender], [Civil_Status], [Street], [Brgy], [City_Town], [Province], [Region], [Employment], [Phone_no], [Contact_Person], [Contact_Person_no], [Status], [Remarks], [Group_ID], [Committee_Names], [locale_id], [Baptizer], [is_contact_person_member], [is_deleted]) VALUES (N'B-0004', N'903914', N'FRANCIS', N'MANUNTAG', N'ESGUERRA', NULL, NULL, CAST(N'2009-05-01' AS Date), CAST(N'1986-06-27' AS Date), N'MALE', N'Single', N'DONA ADELA PHASE II', N'STA.CRUZ', N'PORAC', N'PAMPANGA', N'3', NULL, NULL, N'RODOLFO DAVID', NULL, N'Active', NULL, 3, NULL, 5, NULL, 1, 0)
INSERT [dbo].[Brethren] ([brethren_id], [Church_Id], [Firstname], [Middlename], [Lastname], [Image_Path], [Sketch_Path], [Date_Baptism], [Date_Birth], [Gender], [Civil_Status], [Street], [Brgy], [City_Town], [Province], [Region], [Employment], [Phone_no], [Contact_Person], [Contact_Person_no], [Status], [Remarks], [Group_ID], [Committee_Names], [locale_id], [Baptizer], [is_contact_person_member], [is_deleted]) VALUES (N'B-0005', N'MAG00002', N'AILENE', N'SIMEON', N'EVARISTO', NULL, NULL, CAST(N'1998-08-14' AS Date), CAST(N'1978-10-17' AS Date), N'FEMALE', N'Married', N'697 RIZAL EXT.', N'CUT-CUT', N'ANGELES', N'PAMPANGA', N'3', NULL, NULL, N'CELIA DUNGAO', NULL, N'Active', NULL, 2, NULL, 5, NULL, 1, 0)
INSERT [dbo].[Brethren] ([brethren_id], [Church_Id], [Firstname], [Middlename], [Lastname], [Image_Path], [Sketch_Path], [Date_Baptism], [Date_Birth], [Gender], [Civil_Status], [Street], [Brgy], [City_Town], [Province], [Region], [Employment], [Phone_no], [Contact_Person], [Contact_Person_no], [Status], [Remarks], [Group_ID], [Committee_Names], [locale_id], [Baptizer], [is_contact_person_member], [is_deleted]) VALUES (N'B-0006', N'STP00061', N'MYRNA', N'SIMEON', N'EVARISTO', NULL, NULL, CAST(N'1999-07-30' AS Date), CAST(N'1952-11-11' AS Date), N'FEMALE', N'Married', N'697 RIZAL EXT.', N'CUT-CUT', N'ANGELES', N'PAMPANGA', N'3', NULL, NULL, N'AILENE EVARISTO', NULL, N'Active', NULL, 2, NULL, 5, NULL, 1, 0)
INSERT [dbo].[Brethren] ([brethren_id], [Church_Id], [Firstname], [Middlename], [Lastname], [Image_Path], [Sketch_Path], [Date_Baptism], [Date_Birth], [Gender], [Civil_Status], [Street], [Brgy], [City_Town], [Province], [Region], [Employment], [Phone_no], [Contact_Person], [Contact_Person_no], [Status], [Remarks], [Group_ID], [Committee_Names], [locale_id], [Baptizer], [is_contact_person_member], [is_deleted]) VALUES (N'B-0007', N'701024', N'MARLINA', N'INFANTE', N'GARCIA', NULL, NULL, CAST(N'2007-03-09' AS Date), CAST(N'1980-11-11' AS Date), N'MALE', N'Married', N'121 SAN FRANCISCO', N'STA.CRUZ', N'PORAC', N'PAMPANGA', N'3', NULL, NULL, N'ROMMEL GARCIA', NULL, N'Active', NULL, 1, NULL, 5, N'SIS. ODINAH DUNGAO', 1, 0)
INSERT [dbo].[Brethren] ([brethren_id], [Church_Id], [Firstname], [Middlename], [Lastname], [Image_Path], [Sketch_Path], [Date_Baptism], [Date_Birth], [Gender], [Civil_Status], [Street], [Brgy], [City_Town], [Province], [Region], [Employment], [Phone_no], [Contact_Person], [Contact_Person_no], [Status], [Remarks], [Group_ID], [Committee_Names], [locale_id], [Baptizer], [is_contact_person_member], [is_deleted]) VALUES (N'B-0008', N'701145', N'ROMMEL', N'ANGELES', N'GARCIA', NULL, NULL, CAST(N'2007-03-09' AS Date), CAST(N'1972-08-30' AS Date), N'MALE', N'Married', N'121 SAN FRANCISCO', N'STA.CRUZ', N'PORAC', N'PAMPANGA', N'3', NULL, NULL, N'MARLINA GARCIA', NULL, N'Active', NULL, 1, NULL, 5, NULL, 1, 0)
INSERT [dbo].[Brethren] ([brethren_id], [Church_Id], [Firstname], [Middlename], [Lastname], [Image_Path], [Sketch_Path], [Date_Baptism], [Date_Birth], [Gender], [Civil_Status], [Street], [Brgy], [City_Town], [Province], [Region], [Employment], [Phone_no], [Contact_Person], [Contact_Person_no], [Status], [Remarks], [Group_ID], [Committee_Names], [locale_id], [Baptizer], [is_contact_person_member], [is_deleted]) VALUES (N'B-0009', N'600836', N'ERNEST', N'ANAC-ANAC', N'JOHNSON', NULL, NULL, CAST(N'2006-02-10' AS Date), CAST(N'1971-06-28' AS Date), N'MALE', N'Single', N'133-B CLEMENT AVENUE', N'STA.CRUZ', N'PORAC', N'PAMPANGA', N'3', NULL, NULL, N'RODOLFO DAVID', NULL, N'Active', NULL, 0, NULL, 5, NULL, 1, 0)
INSERT [dbo].[Brethren] ([brethren_id], [Church_Id], [Firstname], [Middlename], [Lastname], [Image_Path], [Sketch_Path], [Date_Baptism], [Date_Birth], [Gender], [Civil_Status], [Street], [Brgy], [City_Town], [Province], [Region], [Employment], [Phone_no], [Contact_Person], [Contact_Person_no], [Status], [Remarks], [Group_ID], [Committee_Names], [locale_id], [Baptizer], [is_contact_person_member], [is_deleted]) VALUES (N'B-0010', N'STP00126', N'ARTEMIO', N'SAGUSAY', N'MACARAYAN', NULL, NULL, CAST(N'2005-10-11' AS Date), CAST(N'1962-10-30' AS Date), N'MALE', N'Married', N'4B ARAYAT BLVD.', N'PAMPANG', N'ANGELES', N'PAMPANGA', N'3', NULL, NULL, N'JUVY MACARAYAN', NULL, N'Active', NULL, 4, NULL, 5, NULL, 1, 0)
INSERT [dbo].[Brethren] ([brethren_id], [Church_Id], [Firstname], [Middlename], [Lastname], [Image_Path], [Sketch_Path], [Date_Baptism], [Date_Birth], [Gender], [Civil_Status], [Street], [Brgy], [City_Town], [Province], [Region], [Employment], [Phone_no], [Contact_Person], [Contact_Person_no], [Status], [Remarks], [Group_ID], [Committee_Names], [locale_id], [Baptizer], [is_contact_person_member], [is_deleted]) VALUES (N'B-0011', N'STP00124', N'JUVY', N'TAYAG', N'MACARAYAN', NULL, NULL, CAST(N'2005-10-11' AS Date), CAST(N'1965-05-12' AS Date), N'MALE', N'Married', N'4B ARAYAT BLVD.', N'PAMPANG', N'ANGELES', N'PAMPANGA', N'3', NULL, NULL, N'ARTEMIO MACARAYAN', NULL, N'Active', NULL, 4, NULL, 5, NULL, 1, 0)
INSERT [dbo].[Brethren] ([brethren_id], [Church_Id], [Firstname], [Middlename], [Lastname], [Image_Path], [Sketch_Path], [Date_Baptism], [Date_Birth], [Gender], [Civil_Status], [Street], [Brgy], [City_Town], [Province], [Region], [Employment], [Phone_no], [Contact_Person], [Contact_Person_no], [Status], [Remarks], [Group_ID], [Committee_Names], [locale_id], [Baptizer], [is_contact_person_member], [is_deleted]) VALUES (N'B-0012', N'STP00042', N'OMAR', N'TIPON', N'DUNGAO', NULL, NULL, CAST(N'2002-04-19' AS Date), CAST(N'1983-09-06' AS Date), N'MALE', N'Married', N'56 SAN ISIDRO', N'STA.CRUZ', N'PORAC', N'PAMPANGA', N'3', NULL, NULL, N'RUTH DUNGAO', NULL, N'Active', NULL, 1, NULL, 5, NULL, 1, 0)
INSERT [dbo].[Brethren] ([brethren_id], [Church_Id], [Firstname], [Middlename], [Lastname], [Image_Path], [Sketch_Path], [Date_Baptism], [Date_Birth], [Gender], [Civil_Status], [Street], [Brgy], [City_Town], [Province], [Region], [Employment], [Phone_no], [Contact_Person], [Contact_Person_no], [Status], [Remarks], [Group_ID], [Committee_Names], [locale_id], [Baptizer], [is_contact_person_member], [is_deleted]) VALUES (N'B-0013', N'STP00094', N'ROSALINDA', N'ARCEO', N'MAGTOTO', NULL, NULL, CAST(N'2000-10-22' AS Date), CAST(N'1950-01-25' AS Date), N'FEMALE', N'Married', N'29 SAN AGUSTIN', N'STA.CRUZ', N'PORAC', N'PAMPANGA', N'3', NULL, NULL, N'CECILLE MAMUCUD', NULL, N'Active', NULL, 2, NULL, 5, NULL, 1, 0)
INSERT [dbo].[Brethren] ([brethren_id], [Church_Id], [Firstname], [Middlename], [Lastname], [Image_Path], [Sketch_Path], [Date_Baptism], [Date_Birth], [Gender], [Civil_Status], [Street], [Brgy], [City_Town], [Province], [Region], [Employment], [Phone_no], [Contact_Person], [Contact_Person_no], [Status], [Remarks], [Group_ID], [Committee_Names], [locale_id], [Baptizer], [is_contact_person_member], [is_deleted]) VALUES (N'B-0014', N'STP00096', N'BALTAZAR', N'GUTIERREZ', N'MAMUCUD', NULL, NULL, CAST(N'2000-10-06' AS Date), CAST(N'1971-01-06' AS Date), N'MALE', N'Married', N'120 MALIGAYA', N'CUT-CUT', N'ANGELES', N'PAMPANGA', N'3', NULL, NULL, N'CECILLE MAMUCUD', NULL, N'Active', NULL, 2, NULL, 5, NULL, 1, 0)
INSERT [dbo].[Brethren] ([brethren_id], [Church_Id], [Firstname], [Middlename], [Lastname], [Image_Path], [Sketch_Path], [Date_Baptism], [Date_Birth], [Gender], [Civil_Status], [Street], [Brgy], [City_Town], [Province], [Region], [Employment], [Phone_no], [Contact_Person], [Contact_Person_no], [Status], [Remarks], [Group_ID], [Committee_Names], [locale_id], [Baptizer], [is_contact_person_member], [is_deleted]) VALUES (N'B-0015', N'STP00097', N'CECILE', N'MAGTOTO', N'MAMUCUD', NULL, NULL, CAST(N'2000-12-22' AS Date), CAST(N'1978-08-11' AS Date), N'FEMALE', N'Married', N'120 MALIGAYA', N'CUT-CUT', N'ANGELES', N'PAMPANGA', N'3', NULL, NULL, N'BALTAZAR MAMUCUD', NULL, N'Active', NULL, 2, NULL, 5, NULL, 1, 0)
INSERT [dbo].[Brethren] ([brethren_id], [Church_Id], [Firstname], [Middlename], [Lastname], [Image_Path], [Sketch_Path], [Date_Baptism], [Date_Birth], [Gender], [Civil_Status], [Street], [Brgy], [City_Town], [Province], [Region], [Employment], [Phone_no], [Contact_Person], [Contact_Person_no], [Status], [Remarks], [Group_ID], [Committee_Names], [locale_id], [Baptizer], [is_contact_person_member], [is_deleted]) VALUES (N'B-0016', N'STP00111', N'ROCKWELL', N'HERNANDEZ', N'PANTIG', NULL, NULL, CAST(N'2004-09-10' AS Date), CAST(N'1989-06-13' AS Date), N'MALE', N'Married', N'061 PADRE PIO', N'STA.CRUZ', N'PORAC', N'PAMPANGA', N'3', NULL, NULL, N'AMELIA PANTIG', NULL, N'Active', NULL, 3, N'KKTK, ADDPRO', 5, N'BRO. DINO HILARIO', 1, 0)
INSERT [dbo].[Brethren] ([brethren_id], [Church_Id], [Firstname], [Middlename], [Lastname], [Image_Path], [Sketch_Path], [Date_Baptism], [Date_Birth], [Gender], [Civil_Status], [Street], [Brgy], [City_Town], [Province], [Region], [Employment], [Phone_no], [Contact_Person], [Contact_Person_no], [Status], [Remarks], [Group_ID], [Committee_Names], [locale_id], [Baptizer], [is_contact_person_member], [is_deleted]) VALUES (N'B-0017', N'11006194', N'MANUEL', N'MENDOZA', N'MANALILI', NULL, NULL, CAST(N'2010-04-16' AS Date), CAST(N'1975-09-25' AS Date), N'MALE', N'MARRIED', N'178 PONCIANO AVENUE', NULL, N'STA.CRUZ', N'PAMPANGA', N'3', NULL, NULL, N'RODOLFO DAVID', NULL, N'Active', NULL, 0, NULL, 5, N'BRO.ANTONIO DE LEON', 1, 0)
INSERT [dbo].[Brethren] ([brethren_id], [Church_Id], [Firstname], [Middlename], [Lastname], [Image_Path], [Sketch_Path], [Date_Baptism], [Date_Birth], [Gender], [Civil_Status], [Street], [Brgy], [City_Town], [Province], [Region], [Employment], [Phone_no], [Contact_Person], [Contact_Person_no], [Status], [Remarks], [Group_ID], [Committee_Names], [locale_id], [Baptizer], [is_contact_person_member], [is_deleted]) VALUES (N'B-0018', N'STP00029', N'HONORATO', N'MUNGCAL', N'MERCADO', NULL, NULL, CAST(N'2000-05-26' AS Date), CAST(N'1942-07-03' AS Date), N'MALE', N'MARRIED', N'255 MA. AQUINO', N'STA.CRUZ', N'PORAC', N'PAMPANGA', N'3', NULL, NULL, N'RODOLFO DAVID', NULL, N'Active', NULL, 1, NULL, 5, NULL, 1, 0)
INSERT [dbo].[Brethren] ([brethren_id], [Church_Id], [Firstname], [Middlename], [Lastname], [Image_Path], [Sketch_Path], [Date_Baptism], [Date_Birth], [Gender], [Civil_Status], [Street], [Brgy], [City_Town], [Province], [Region], [Employment], [Phone_no], [Contact_Person], [Contact_Person_no], [Status], [Remarks], [Group_ID], [Committee_Names], [locale_id], [Baptizer], [is_contact_person_member], [is_deleted]) VALUES (N'B-0019', N'STP00057', N'AMELIA  ', N'HERNANDEZ', N'PANTIG', NULL, NULL, CAST(N'1999-09-10' AS Date), CAST(N'1964-07-31' AS Date), N'FEMALE', N'MARRIED', N'061 PADRE PIO', N'STA.CRUZ', N'PORAC', N'PAMPANGA', N'3', NULL, NULL, N'NOEL PANTIG', NULL, N'Active', NULL, 3, NULL, 5, NULL, 1, 0)
INSERT [dbo].[Brethren] ([brethren_id], [Church_Id], [Firstname], [Middlename], [Lastname], [Image_Path], [Sketch_Path], [Date_Baptism], [Date_Birth], [Gender], [Civil_Status], [Street], [Brgy], [City_Town], [Province], [Region], [Employment], [Phone_no], [Contact_Person], [Contact_Person_no], [Status], [Remarks], [Group_ID], [Committee_Names], [locale_id], [Baptizer], [is_contact_person_member], [is_deleted]) VALUES (N'B-0020', N'706578', N'FRANCES RAMONA ', N'HERNANDEZ', N'PANTIG', NULL, NULL, CAST(N'2007-10-19' AS Date), CAST(N'1990-01-01' AS Date), N'FEMALE', N'SINGLE', N'061 PADRE PIO', N'STA.CRUZ', N'PORAC', N'PAMPANGA', N'3', NULL, NULL, N'NOEL PANTIG', NULL, N'Active', NULL, 3, NULL, 5, NULL, 1, 0)
INSERT [dbo].[Brethren] ([brethren_id], [Church_Id], [Firstname], [Middlename], [Lastname], [Image_Path], [Sketch_Path], [Date_Baptism], [Date_Birth], [Gender], [Civil_Status], [Street], [Brgy], [City_Town], [Province], [Region], [Employment], [Phone_no], [Contact_Person], [Contact_Person_no], [Status], [Remarks], [Group_ID], [Committee_Names], [locale_id], [Baptizer], [is_contact_person_member], [is_deleted]) VALUES (N'B-0021', N'STP00012', N'NOEL', N'YALUNG', N'PANTIG', NULL, NULL, CAST(N'1999-09-10' AS Date), CAST(N'1990-01-01' AS Date), N'MALE', N'MARRIED', N'061 PADRE PIO', N'STA.CRUZ', N'PORAC', N'PAMPANGA', N'3', NULL, NULL, N'AMELIA PANTIG', NULL, N'Active', NULL, 3, NULL, 5, NULL, 1, 0)
INSERT [dbo].[Brethren] ([brethren_id], [Church_Id], [Firstname], [Middlename], [Lastname], [Image_Path], [Sketch_Path], [Date_Baptism], [Date_Birth], [Gender], [Civil_Status], [Street], [Brgy], [City_Town], [Province], [Region], [Employment], [Phone_no], [Contact_Person], [Contact_Person_no], [Status], [Remarks], [Group_ID], [Committee_Names], [locale_id], [Baptizer], [is_contact_person_member], [is_deleted]) VALUES (N'B-0022', N'STP00043', N'JODAN', N'DE GUZMAN', N'PORRAS', NULL, NULL, CAST(N'2000-02-11' AS Date), CAST(N'1973-01-02' AS Date), N'MALE', N'SINGLE', N'543 PETER VILLAGE', N'CUT-CUT', N'ANGELES', N'PAMPANGA', N'3', NULL, NULL, N'RODOLFO DAVID', NULL, N'Active', NULL, 4, NULL, 5, NULL, 1, 0)
INSERT [dbo].[Brethren] ([brethren_id], [Church_Id], [Firstname], [Middlename], [Lastname], [Image_Path], [Sketch_Path], [Date_Baptism], [Date_Birth], [Gender], [Civil_Status], [Street], [Brgy], [City_Town], [Province], [Region], [Employment], [Phone_no], [Contact_Person], [Contact_Person_no], [Status], [Remarks], [Group_ID], [Committee_Names], [locale_id], [Baptizer], [is_contact_person_member], [is_deleted]) VALUES (N'B-0023', N'STP00048', N'CELIA', N'TIPON', N'DUNGAO', NULL, NULL, CAST(N'1988-06-07' AS Date), CAST(N'1950-04-14' AS Date), N'FEMALE', N'Married', N'56 SAN ISIDRO', N'STA.CRUZ', N'PORAC', N'PAMPANGA', N'3', NULL, NULL, N'CECIL DUNGAO', NULL, N'Active', NULL, 1, NULL, 5, NULL, 1, 0)
INSERT [dbo].[Brethren] ([brethren_id], [Church_Id], [Firstname], [Middlename], [Lastname], [Image_Path], [Sketch_Path], [Date_Baptism], [Date_Birth], [Gender], [Civil_Status], [Street], [Brgy], [City_Town], [Province], [Region], [Employment], [Phone_no], [Contact_Person], [Contact_Person_no], [Status], [Remarks], [Group_ID], [Committee_Names], [locale_id], [Baptizer], [is_contact_person_member], [is_deleted]) VALUES (N'B-0024', N'803200', N'ELIBERTO', N'ESPINOSA', N'SANCHEZ', NULL, NULL, CAST(N'2008-05-09' AS Date), CAST(N'1971-04-09' AS Date), N'MALE', N'SINGLE', N'153 PONCIANO AVENUE', N'STA.CRUZ', N'PORAC', N'PAMPANGA', N'3', NULL, NULL, N'RODOLFO DAVID', NULL, N'Inactive', NULL, 0, NULL, 5, NULL, 1, 0)
INSERT [dbo].[Brethren] ([brethren_id], [Church_Id], [Firstname], [Middlename], [Lastname], [Image_Path], [Sketch_Path], [Date_Baptism], [Date_Birth], [Gender], [Civil_Status], [Street], [Brgy], [City_Town], [Province], [Region], [Employment], [Phone_no], [Contact_Person], [Contact_Person_no], [Status], [Remarks], [Group_ID], [Committee_Names], [locale_id], [Baptizer], [is_contact_person_member], [is_deleted]) VALUES (N'B-0025', N'STP00078', N'ROBERTO', N'MUSNI', N'SANCHEZ', NULL, NULL, CAST(N'1999-05-19' AS Date), CAST(N'1948-10-04' AS Date), N'MALE', N'WIDOW', N'153 PONCIANO AVENUE', N'STA.CRUZ', N'PORAC', N'PAMPANGA', N'3', NULL, NULL, N'RODOLFO DAVID', NULL, N'Inactive', NULL, 0, NULL, 5, NULL, 1, 0)
INSERT [dbo].[Brethren] ([brethren_id], [Church_Id], [Firstname], [Middlename], [Lastname], [Image_Path], [Sketch_Path], [Date_Baptism], [Date_Birth], [Gender], [Civil_Status], [Street], [Brgy], [City_Town], [Province], [Region], [Employment], [Phone_no], [Contact_Person], [Contact_Person_no], [Status], [Remarks], [Group_ID], [Committee_Names], [locale_id], [Baptizer], [is_contact_person_member], [is_deleted]) VALUES (N'B-0026', N'11112207', N'ARTURO', N'MASICLAT', N'TOLENTINO', NULL, NULL, CAST(N'2011-09-16' AS Date), CAST(N'1963-11-29' AS Date), N'MALE', N'MARRIED', N'169 STO.NINO', N'STA.CRUZ', N'PORAC', N'PAMPANGA', N'3', NULL, NULL, N'KENNETH TOLENTINO', NULL, N'Active', NULL, 2, NULL, 5, NULL, 1, 0)
INSERT [dbo].[Brethren] ([brethren_id], [Church_Id], [Firstname], [Middlename], [Lastname], [Image_Path], [Sketch_Path], [Date_Baptism], [Date_Birth], [Gender], [Civil_Status], [Street], [Brgy], [City_Town], [Province], [Region], [Employment], [Phone_no], [Contact_Person], [Contact_Person_no], [Status], [Remarks], [Group_ID], [Committee_Names], [locale_id], [Baptizer], [is_contact_person_member], [is_deleted]) VALUES (N'B-0027', N'11112036', N'JOHN KENNETH', N'DE ASIS', N'TOLENTINO', NULL, NULL, CAST(N'2011-09-16' AS Date), CAST(N'1995-09-07' AS Date), N'MALE', N'SINGLE', N'169 STO.NINO', N'STA.CRUZ', N'PORAC', N'PAMPANGA', N'3', NULL, NULL, N'ARTURO TOLENTINO', NULL, N'Active', NULL, 2, N'KKTK, ADDPRO', 5, NULL, 1, 0)
INSERT [dbo].[Brethren] ([brethren_id], [Church_Id], [Firstname], [Middlename], [Lastname], [Image_Path], [Sketch_Path], [Date_Baptism], [Date_Birth], [Gender], [Civil_Status], [Street], [Brgy], [City_Town], [Province], [Region], [Employment], [Phone_no], [Contact_Person], [Contact_Person_no], [Status], [Remarks], [Group_ID], [Committee_Names], [locale_id], [Baptizer], [is_contact_person_member], [is_deleted]) VALUES (N'B-0028', N'808939', N'FELIX', N'CRUZ', N'VALDEZ', NULL, NULL, CAST(N'2008-12-05' AS Date), CAST(N'1990-01-01' AS Date), N'MALE', N'MARRIED', N'ROSAL', N'STA.CRUZ', N'PORAC', N'PAMPANGA', N'3', NULL, NULL, N'RODOLFO DAVID', NULL, N'Active', NULL, 3, NULL, 5, NULL, 1, 0)
INSERT [dbo].[Brethren] ([brethren_id], [Church_Id], [Firstname], [Middlename], [Lastname], [Image_Path], [Sketch_Path], [Date_Baptism], [Date_Birth], [Gender], [Civil_Status], [Street], [Brgy], [City_Town], [Province], [Region], [Employment], [Phone_no], [Contact_Person], [Contact_Person_no], [Status], [Remarks], [Group_ID], [Committee_Names], [locale_id], [Baptizer], [is_contact_person_member], [is_deleted]) VALUES (N'B-0029', N'11210536', N'KENT', N'PATINING', N'DAYRIT', NULL, NULL, CAST(N'2012-07-27' AS Date), CAST(N'1945-05-19' AS Date), N'MALE', N'SINGLE', N'SAN MARCELINO', N'STA.CRUZ', N'PORAC', N'PAMPANGA', N'3', NULL, NULL, N'WESLEY DAYRIT', NULL, N'Active', NULL, 3, NULL, 5, NULL, 1, 0)
INSERT [dbo].[Brethren] ([brethren_id], [Church_Id], [Firstname], [Middlename], [Lastname], [Image_Path], [Sketch_Path], [Date_Baptism], [Date_Birth], [Gender], [Civil_Status], [Street], [Brgy], [City_Town], [Province], [Region], [Employment], [Phone_no], [Contact_Person], [Contact_Person_no], [Status], [Remarks], [Group_ID], [Committee_Names], [locale_id], [Baptizer], [is_contact_person_member], [is_deleted]) VALUES (N'B-0030', N'11210703', N'DEXTER', N'GERGON', N'SIODORA', NULL, NULL, CAST(N'2012-07-27' AS Date), CAST(N'1980-12-13' AS Date), N'MALE', N'SINGLE', NULL, N'STA.CRUZ', N'PORAC', N'PAMPANGA', N'3', NULL, NULL, N'RODOLFO DAVID', NULL, N'Inactive', NULL, 0, NULL, 5, NULL, 1, 0)
INSERT [dbo].[Brethren] ([brethren_id], [Church_Id], [Firstname], [Middlename], [Lastname], [Image_Path], [Sketch_Path], [Date_Baptism], [Date_Birth], [Gender], [Civil_Status], [Street], [Brgy], [City_Town], [Province], [Region], [Employment], [Phone_no], [Contact_Person], [Contact_Person_no], [Status], [Remarks], [Group_ID], [Committee_Names], [locale_id], [Baptizer], [is_contact_person_member], [is_deleted]) VALUES (N'B-0031', N'701653', N'NATIVIDAD', N'TIPON', N'TAYAG', NULL, NULL, CAST(N'2007-03-23' AS Date), CAST(N'1946-10-11' AS Date), N'FEMALE', N'MARRIED', N'MA. AQUINO', NULL, N'DAU', N'PAMPANGA', N'3', NULL, NULL, N'CELIA DUNGAO', NULL, N'Active', NULL, 2, NULL, 5, NULL, 1, 0)
INSERT [dbo].[Brethren] ([brethren_id], [Church_Id], [Firstname], [Middlename], [Lastname], [Image_Path], [Sketch_Path], [Date_Baptism], [Date_Birth], [Gender], [Civil_Status], [Street], [Brgy], [City_Town], [Province], [Region], [Employment], [Phone_no], [Contact_Person], [Contact_Person_no], [Status], [Remarks], [Group_ID], [Committee_Names], [locale_id], [Baptizer], [is_contact_person_member], [is_deleted]) VALUES (N'B-0032', N'11307397', N'BERNALIN', N'TANTHIATCO', N'UBANDO', NULL, NULL, CAST(N'2013-06-14' AS Date), CAST(N'1971-04-23' AS Date), N'FEMALE', N'MARRIED', N'SAN MIGUEL', N'STA.CRUZ', N'PORAC', N'PAMPANGA', N'3', NULL, NULL, N'CORNELIO UBANDO', NULL, N'Active', NULL, 1, NULL, 5, NULL, 1, 0)
INSERT [dbo].[Brethren] ([brethren_id], [Church_Id], [Firstname], [Middlename], [Lastname], [Image_Path], [Sketch_Path], [Date_Baptism], [Date_Birth], [Gender], [Civil_Status], [Street], [Brgy], [City_Town], [Province], [Region], [Employment], [Phone_no], [Contact_Person], [Contact_Person_no], [Status], [Remarks], [Group_ID], [Committee_Names], [locale_id], [Baptizer], [is_contact_person_member], [is_deleted]) VALUES (N'B-0033', N'11308026', N'CORNELIO', NULL, N'UBANDO', NULL, NULL, CAST(N'2013-06-21' AS Date), CAST(N'1958-05-15' AS Date), N'MALE', N'MARRIED', N'SAN MIGUEL', N'STA.CRUZ', N'PORAC', N'PAMPANGA', N'3', NULL, NULL, N'BERNALIN UBANDO', NULL, N'Active', NULL, 1, NULL, 5, NULL, 1, 0)
INSERT [dbo].[Brethren] ([brethren_id], [Church_Id], [Firstname], [Middlename], [Lastname], [Image_Path], [Sketch_Path], [Date_Baptism], [Date_Birth], [Gender], [Civil_Status], [Street], [Brgy], [City_Town], [Province], [Region], [Employment], [Phone_no], [Contact_Person], [Contact_Person_no], [Status], [Remarks], [Group_ID], [Committee_Names], [locale_id], [Baptizer], [is_contact_person_member], [is_deleted]) VALUES (N'B-0034', N'STP00084', N'LAMBERTO', N'DUE', N'DUNGAO', NULL, NULL, CAST(N'1988-06-07' AS Date), CAST(N'1940-04-16' AS Date), N'MALE', N'Married', N'56 SAN ISIDRO', N'STA.CRUZ', N'PORAC', N'PAMPANGA', N'3', NULL, NULL, N'CECIL DUNGAO', NULL, N'Active', NULL, 1, NULL, 5, NULL, 1, 0)
INSERT [dbo].[Brethren] ([brethren_id], [Church_Id], [Firstname], [Middlename], [Lastname], [Image_Path], [Sketch_Path], [Date_Baptism], [Date_Birth], [Gender], [Civil_Status], [Street], [Brgy], [City_Town], [Province], [Region], [Employment], [Phone_no], [Contact_Person], [Contact_Person_no], [Status], [Remarks], [Group_ID], [Committee_Names], [locale_id], [Baptizer], [is_contact_person_member], [is_deleted]) VALUES (N'B-0035', N'11316389', N'JHAYMIL', N'TANTHIATCO', N'UBANDO', NULL, NULL, CAST(N'2013-10-18' AS Date), CAST(N'1997-05-23' AS Date), N'MALE', N'SINGLE', N'SAN MIGUEL', N'STA.CRUZ', N'PORAC', N'PAMPANGA', N'3', NULL, NULL, N'CORNELIO UBANDO', NULL, N'Active', NULL, 1, NULL, 5, NULL, 1, 0)
INSERT [dbo].[Brethren] ([brethren_id], [Church_Id], [Firstname], [Middlename], [Lastname], [Image_Path], [Sketch_Path], [Date_Baptism], [Date_Birth], [Gender], [Civil_Status], [Street], [Brgy], [City_Town], [Province], [Region], [Employment], [Phone_no], [Contact_Person], [Contact_Person_no], [Status], [Remarks], [Group_ID], [Committee_Names], [locale_id], [Baptizer], [is_contact_person_member], [is_deleted]) VALUES (N'B-0036', N'11403632', N'ALBERTO', NULL, N'PINGOL', NULL, NULL, CAST(N'2014-03-21' AS Date), CAST(N'1990-01-01' AS Date), N'MALE', N'MARRIED', N'PISCES, DON ADELA', N'STA.CRUZ', N'PORAC', N'PAMPANGA', N'3', NULL, NULL, N'RODOLFO DAVID', NULL, N'Active', NULL, 2, NULL, 5, NULL, 1, 0)
INSERT [dbo].[Brethren] ([brethren_id], [Church_Id], [Firstname], [Middlename], [Lastname], [Image_Path], [Sketch_Path], [Date_Baptism], [Date_Birth], [Gender], [Civil_Status], [Street], [Brgy], [City_Town], [Province], [Region], [Employment], [Phone_no], [Contact_Person], [Contact_Person_no], [Status], [Remarks], [Group_ID], [Committee_Names], [locale_id], [Baptizer], [is_contact_person_member], [is_deleted]) VALUES (N'B-0037', N'11416458', N'GILBERT', NULL, N'YABUT', NULL, NULL, CAST(N'2014-08-22' AS Date), CAST(N'1980-09-19' AS Date), N'MALE', N'MARRIED', N'FIESTA COMMUNITY', N'MANIBAUG', N'PORAC', N'PAMPANGA', N'3', NULL, NULL, N'JINA YABUT', NULL, N'Active', NULL, 4, NULL, 5, NULL, 1, 0)
INSERT [dbo].[Brethren] ([brethren_id], [Church_Id], [Firstname], [Middlename], [Lastname], [Image_Path], [Sketch_Path], [Date_Baptism], [Date_Birth], [Gender], [Civil_Status], [Street], [Brgy], [City_Town], [Province], [Region], [Employment], [Phone_no], [Contact_Person], [Contact_Person_no], [Status], [Remarks], [Group_ID], [Committee_Names], [locale_id], [Baptizer], [is_contact_person_member], [is_deleted]) VALUES (N'B-0038', N'11416006', N'JINA', N'ALCAZAREN', N'YABUT', NULL, NULL, CAST(N'2014-08-22' AS Date), CAST(N'1979-06-10' AS Date), N'FEMALE', N'MARRIED', N'FIESTA COMMUNITY', N'MANIBAUG', N'PORAC', N'PAMPANGA', N'3', NULL, NULL, N'GILBERT YABUT', NULL, N'Inactive', NULL, 4, NULL, 5, NULL, 1, 0)
INSERT [dbo].[Brethren] ([brethren_id], [Church_Id], [Firstname], [Middlename], [Lastname], [Image_Path], [Sketch_Path], [Date_Baptism], [Date_Birth], [Gender], [Civil_Status], [Street], [Brgy], [City_Town], [Province], [Region], [Employment], [Phone_no], [Contact_Person], [Contact_Person_no], [Status], [Remarks], [Group_ID], [Committee_Names], [locale_id], [Baptizer], [is_contact_person_member], [is_deleted]) VALUES (N'B-0039', N'11495571', N'JENNIFER', NULL, N'GABRIEL', NULL, NULL, CAST(N'2014-12-19' AS Date), CAST(N'1990-01-01' AS Date), N'FEMALE', N'MARRIED', N'BLK1 LOT 3, VILLA JUANITA', N'STA.CRUZ', N'PORAC', N'PAMPANGA', N'3', NULL, NULL, N'BRYAN GABRIEL', NULL, N'Inactive', NULL, 0, NULL, 5, NULL, 1, 0)
INSERT [dbo].[Brethren] ([brethren_id], [Church_Id], [Firstname], [Middlename], [Lastname], [Image_Path], [Sketch_Path], [Date_Baptism], [Date_Birth], [Gender], [Civil_Status], [Street], [Brgy], [City_Town], [Province], [Region], [Employment], [Phone_no], [Contact_Person], [Contact_Person_no], [Status], [Remarks], [Group_ID], [Committee_Names], [locale_id], [Baptizer], [is_contact_person_member], [is_deleted]) VALUES (N'B-0040', N'11468596', N'JUNE', NULL, N'PALO', NULL, NULL, CAST(N'2014-12-19' AS Date), CAST(N'1990-01-01' AS Date), N'MALE', N'MARRIED', N'21 MALIGAYA', N'CUT-CUT', N'ANGELES', N'PAMPANGA', N'3', NULL, NULL, N'RODOLFO DAVID', NULL, N'Active', NULL, 0, NULL, 5, NULL, 1, 0)
INSERT [dbo].[Brethren] ([brethren_id], [Church_Id], [Firstname], [Middlename], [Lastname], [Image_Path], [Sketch_Path], [Date_Baptism], [Date_Birth], [Gender], [Civil_Status], [Street], [Brgy], [City_Town], [Province], [Region], [Employment], [Phone_no], [Contact_Person], [Contact_Person_no], [Status], [Remarks], [Group_ID], [Committee_Names], [locale_id], [Baptizer], [is_contact_person_member], [is_deleted]) VALUES (N'B-0041', N'11422172', N'SYLVIA', N'CALAGUAS', N'DE JESUS', NULL, NULL, CAST(N'1990-01-01' AS Date), CAST(N'1990-01-01' AS Date), N'FEMALE', N'WIDOW', NULL, NULL, N'ANGELES', N'PAMPANGA', N'3', NULL, NULL, N'CELIA DUNGAO', NULL, N'Active', NULL, 3, NULL, 5, NULL, 1, 0)
INSERT [dbo].[Brethren] ([brethren_id], [Church_Id], [Firstname], [Middlename], [Lastname], [Image_Path], [Sketch_Path], [Date_Baptism], [Date_Birth], [Gender], [Civil_Status], [Street], [Brgy], [City_Town], [Province], [Region], [Employment], [Phone_no], [Contact_Person], [Contact_Person_no], [Status], [Remarks], [Group_ID], [Committee_Names], [locale_id], [Baptizer], [is_contact_person_member], [is_deleted]) VALUES (N'B-0042', N'11478797', N'RODEL', NULL, N'ARCEO', NULL, NULL, CAST(N'2015-01-23' AS Date), CAST(N'1990-01-01' AS Date), N'MALE', N'SINGLE', N'36 MALIGAYA', NULL, N'ANGELES', N'PAMPANGA', N'3', NULL, NULL, N'RODOLFO DAVID', NULL, N'Active', NULL, 2, NULL, 5, NULL, 1, 0)
INSERT [dbo].[Brethren] ([brethren_id], [Church_Id], [Firstname], [Middlename], [Lastname], [Image_Path], [Sketch_Path], [Date_Baptism], [Date_Birth], [Gender], [Civil_Status], [Street], [Brgy], [City_Town], [Province], [Region], [Employment], [Phone_no], [Contact_Person], [Contact_Person_no], [Status], [Remarks], [Group_ID], [Committee_Names], [locale_id], [Baptizer], [is_contact_person_member], [is_deleted]) VALUES (N'B-0043', N'11456021', N'OSCAR', NULL, N'ONG SR.', NULL, NULL, CAST(N'2015-01-23' AS Date), CAST(N'1990-01-01' AS Date), N'MALE', N'MARRIED', N'MA. AQUINO', N'STA.CRUZ', N'PORAC', N'PAMPANGA', N'3', NULL, NULL, N'RODOLFO DAVID', NULL, N'Inactive', NULL, 3, NULL, 5, NULL, 1, 0)
INSERT [dbo].[Brethren] ([brethren_id], [Church_Id], [Firstname], [Middlename], [Lastname], [Image_Path], [Sketch_Path], [Date_Baptism], [Date_Birth], [Gender], [Civil_Status], [Street], [Brgy], [City_Town], [Province], [Region], [Employment], [Phone_no], [Contact_Person], [Contact_Person_no], [Status], [Remarks], [Group_ID], [Committee_Names], [locale_id], [Baptizer], [is_contact_person_member], [is_deleted]) VALUES (N'B-0044', N'00000000', N'MARLON', NULL, N'CALMA', NULL, NULL, CAST(N'2015-01-23' AS Date), CAST(N'1990-01-01' AS Date), N'MALE', N'MARRIED', N'143 MALIGAYA ', N'CUT-CUT', N'ANGELES', N'PAMPANGA', N'3', NULL, NULL, N'RODOLFO DAVID', NULL, N'Active', NULL, 0, NULL, 5, NULL, 1, 0)
INSERT [dbo].[Brethren] ([brethren_id], [Church_Id], [Firstname], [Middlename], [Lastname], [Image_Path], [Sketch_Path], [Date_Baptism], [Date_Birth], [Gender], [Civil_Status], [Street], [Brgy], [City_Town], [Province], [Region], [Employment], [Phone_no], [Contact_Person], [Contact_Person_no], [Status], [Remarks], [Group_ID], [Committee_Names], [locale_id], [Baptizer], [is_contact_person_member], [is_deleted]) VALUES (N'B-0045', N'STP00008', N'JOAN', N'MEMORACION', N'CAJANDING', NULL, NULL, CAST(N'1998-08-14' AS Date), CAST(N'1979-12-04' AS Date), N'FEMALE', N'Married', N'107 SAN MIGUEL', N'STA.CRUZ', N'PORAC', N'PAMPANGA', N'3', NULL, NULL, N'HILARIO CAJANDING', NULL, N'Active', NULL, 4, NULL, 5, NULL, 1, 0)
INSERT [dbo].[Brethren] ([brethren_id], [Church_Id], [Firstname], [Middlename], [Lastname], [Image_Path], [Sketch_Path], [Date_Baptism], [Date_Birth], [Gender], [Civil_Status], [Street], [Brgy], [City_Town], [Province], [Region], [Employment], [Phone_no], [Contact_Person], [Contact_Person_no], [Status], [Remarks], [Group_ID], [Committee_Names], [locale_id], [Baptizer], [is_contact_person_member], [is_deleted]) VALUES (N'B-0046', N'11435111', N'JEFFERSON', NULL, N'BUGUERO', NULL, NULL, CAST(N'2015-01-23' AS Date), CAST(N'1999-06-01' AS Date), N'MALE', N'SINGLE', N'138 STO. NINO', N'STA.CRUZ', N'PORAC', N'PAMPANGA', N'3', NULL, NULL, N'RODOLFO DAVID', NULL, N'Inactive', NULL, 1, NULL, 5, NULL, 1, 0)
INSERT [dbo].[Brethren] ([brethren_id], [Church_Id], [Firstname], [Middlename], [Lastname], [Image_Path], [Sketch_Path], [Date_Baptism], [Date_Birth], [Gender], [Civil_Status], [Street], [Brgy], [City_Town], [Province], [Region], [Employment], [Phone_no], [Contact_Person], [Contact_Person_no], [Status], [Remarks], [Group_ID], [Committee_Names], [locale_id], [Baptizer], [is_contact_person_member], [is_deleted]) VALUES (N'B-0047', N'11483078', N'ARJIM', N'TAYAG', N'MACARAYAN', NULL, NULL, CAST(N'2015-01-23' AS Date), CAST(N'1990-01-01' AS Date), N'MALE', N'SINGLE', N'4B ARAYAT BLVD.', N'PAMPANG', N'ANGELES', N'PAMPANGA', N'3', NULL, NULL, N'ARTEMIO MACARAYAN', NULL, N'Inactive', NULL, 4, NULL, 5, NULL, 1, 0)
INSERT [dbo].[Brethren] ([brethren_id], [Church_Id], [Firstname], [Middlename], [Lastname], [Image_Path], [Sketch_Path], [Date_Baptism], [Date_Birth], [Gender], [Civil_Status], [Street], [Brgy], [City_Town], [Province], [Region], [Employment], [Phone_no], [Contact_Person], [Contact_Person_no], [Status], [Remarks], [Group_ID], [Committee_Names], [locale_id], [Baptizer], [is_contact_person_member], [is_deleted]) VALUES (N'B-0048', N'11015455', N'LEO', NULL, N'DUQUE', NULL, NULL, CAST(N'1990-01-01' AS Date), CAST(N'1990-01-01' AS Date), N'MALE', N'MARRIED', NULL, N'STA.CRUZ', N'PORAC', N'PAMPANGA', N'3', NULL, NULL, N'RODOLFO DAVID', NULL, N'Active', NULL, 2, NULL, 5, NULL, 1, 0)
INSERT [dbo].[Brethren] ([brethren_id], [Church_Id], [Firstname], [Middlename], [Lastname], [Image_Path], [Sketch_Path], [Date_Baptism], [Date_Birth], [Gender], [Civil_Status], [Street], [Brgy], [City_Town], [Province], [Region], [Employment], [Phone_no], [Contact_Person], [Contact_Person_no], [Status], [Remarks], [Group_ID], [Committee_Names], [locale_id], [Baptizer], [is_contact_person_member], [is_deleted]) VALUES (N'B-0049', N'11502463', N'ANTONIO', N'LOPEZ', N'TOMOLAC', NULL, NULL, CAST(N'2015-04-23' AS Date), CAST(N'1935-04-30' AS Date), N'MALE', N'MARRIED', N'PONCIANO', N'STA.CRUZ', N'PORAC', N'PAMPANGA', N'3', NULL, NULL, N'RODOLFO DAVID', NULL, N'Active', NULL, 0, NULL, 5, NULL, 1, 0)
INSERT [dbo].[Brethren] ([brethren_id], [Church_Id], [Firstname], [Middlename], [Lastname], [Image_Path], [Sketch_Path], [Date_Baptism], [Date_Birth], [Gender], [Civil_Status], [Street], [Brgy], [City_Town], [Province], [Region], [Employment], [Phone_no], [Contact_Person], [Contact_Person_no], [Status], [Remarks], [Group_ID], [Committee_Names], [locale_id], [Baptizer], [is_contact_person_member], [is_deleted]) VALUES (N'B-0050', N'00000000', N'EFREN', NULL, N'SIBUG', NULL, NULL, CAST(N'2015-05-21' AS Date), CAST(N'1950-01-01' AS Date), N'MALE', N'MARRIED', NULL, N'CUT-CUT', N'ANGELES', N'PAMPANGA', N'3', NULL, NULL, N'RODOLFO DAVID', NULL, N'Active', NULL, 0, NULL, 5, NULL, 1, 0)
INSERT [dbo].[Brethren] ([brethren_id], [Church_Id], [Firstname], [Middlename], [Lastname], [Image_Path], [Sketch_Path], [Date_Baptism], [Date_Birth], [Gender], [Civil_Status], [Street], [Brgy], [City_Town], [Province], [Region], [Employment], [Phone_no], [Contact_Person], [Contact_Person_no], [Status], [Remarks], [Group_ID], [Committee_Names], [locale_id], [Baptizer], [is_contact_person_member], [is_deleted]) VALUES (N'B-0051', N'11402791', N'DONELLE', N'ARCEO', N'MAGTOTO', NULL, NULL, CAST(N'2014-02-21' AS Date), CAST(N'1990-01-01' AS Date), N'MALE', N'MARRIED', N'29 SAN AGUSTIN', N'STA.CRUZ', N'PORAC', N'PAMPANGA', N'3', NULL, NULL, N'CECILLE MAMUCUD', NULL, N'Active', NULL, 2, NULL, 5, NULL, 1, 0)
INSERT [dbo].[Brethren] ([brethren_id], [Church_Id], [Firstname], [Middlename], [Lastname], [Image_Path], [Sketch_Path], [Date_Baptism], [Date_Birth], [Gender], [Civil_Status], [Street], [Brgy], [City_Town], [Province], [Region], [Employment], [Phone_no], [Contact_Person], [Contact_Person_no], [Status], [Remarks], [Group_ID], [Committee_Names], [locale_id], [Baptizer], [is_contact_person_member], [is_deleted]) VALUES (N'B-0052', N'11604440', N'RYANEL', N'MEMORACION', N'CAJANDING', NULL, NULL, CAST(N'2016-04-29' AS Date), CAST(N'1999-09-01' AS Date), N'FEMALE', N'SINGLE', N'107 SAN MIGUEL', N'STA.CRUZ', N'PORAC', N'PAMPANGA', N'3', NULL, NULL, N'HILARIO CAJANDING', NULL, N'Active', NULL, 4, NULL, 5, NULL, 1, 0)
INSERT [dbo].[Brethren] ([brethren_id], [Church_Id], [Firstname], [Middlename], [Lastname], [Image_Path], [Sketch_Path], [Date_Baptism], [Date_Birth], [Gender], [Civil_Status], [Street], [Brgy], [City_Town], [Province], [Region], [Employment], [Phone_no], [Contact_Person], [Contact_Person_no], [Status], [Remarks], [Group_ID], [Committee_Names], [locale_id], [Baptizer], [is_contact_person_member], [is_deleted]) VALUES (N'B-0053', N'11604442', N'JOHN RALPH LESTER', NULL, N'CAJANDING', NULL, NULL, CAST(N'2016-04-29' AS Date), CAST(N'2000-08-06' AS Date), N'MALE', N'SINGLE', N'107 SAN MIGUEL', N'STA.CRUZ', N'PORAC', N'PAMPANGA', N'3', NULL, NULL, N'HILARIO CAJANDING', NULL, N'Active', NULL, 2, NULL, 5, NULL, 1, 0)
INSERT [dbo].[Brethren] ([brethren_id], [Church_Id], [Firstname], [Middlename], [Lastname], [Image_Path], [Sketch_Path], [Date_Baptism], [Date_Birth], [Gender], [Civil_Status], [Street], [Brgy], [City_Town], [Province], [Region], [Employment], [Phone_no], [Contact_Person], [Contact_Person_no], [Status], [Remarks], [Group_ID], [Committee_Names], [locale_id], [Baptizer], [is_contact_person_member], [is_deleted]) VALUES (N'B-0054', N'11605005', N'ALJON', NULL, N'ARCEO', NULL, NULL, CAST(N'2016-05-20' AS Date), CAST(N'1990-05-10' AS Date), N'MALE', N'SINGLE', N'26 SAN ISIDRO', N'STA.CRUZ', N'PORAC', N'PAMPANGA', N'3', NULL, NULL, N'HILARIO CAJANDING', NULL, N'Active', NULL, 1, NULL, 5, NULL, 1, 0)
INSERT [dbo].[Brethren] ([brethren_id], [Church_Id], [Firstname], [Middlename], [Lastname], [Image_Path], [Sketch_Path], [Date_Baptism], [Date_Birth], [Gender], [Civil_Status], [Street], [Brgy], [City_Town], [Province], [Region], [Employment], [Phone_no], [Contact_Person], [Contact_Person_no], [Status], [Remarks], [Group_ID], [Committee_Names], [locale_id], [Baptizer], [is_contact_person_member], [is_deleted]) VALUES (N'B-0055', N'STP00039', N'HILARIO', N'DE GUZMAN', N'CAJANDING', NULL, NULL, CAST(N'1998-08-14' AS Date), CAST(N'1972-05-31' AS Date), N'MALE', N'Married', N'107 SAN MIGUEL', N'STA.CRUZ', N'PORAC', N'PAMPANGA', N'3', NULL, NULL, N'JOAN CAJANDING', NULL, N'Active', NULL, 4, NULL, 5, NULL, 1, 0)
INSERT [dbo].[Brethren] ([brethren_id], [Church_Id], [Firstname], [Middlename], [Lastname], [Image_Path], [Sketch_Path], [Date_Baptism], [Date_Birth], [Gender], [Civil_Status], [Street], [Brgy], [City_Town], [Province], [Region], [Employment], [Phone_no], [Contact_Person], [Contact_Person_no], [Status], [Remarks], [Group_ID], [Committee_Names], [locale_id], [Baptizer], [is_contact_person_member], [is_deleted]) VALUES (N'B-0056', N'11606363', N'CARLOS ROBERTO', N'PATINING', N'DAYRIT', NULL, NULL, CAST(N'2016-06-24' AS Date), CAST(N'1990-01-01' AS Date), N'MALE', N'SINGLE', N'SAN MARCELINO', N'STA.CRUZ', N'PORAC', N'PAMPANGA', N'3', NULL, NULL, N'WESLEY DAYRIT', NULL, N'Active', NULL, 3, NULL, 5, NULL, 1, 0)
INSERT [dbo].[Brethren] ([brethren_id], [Church_Id], [Firstname], [Middlename], [Lastname], [Image_Path], [Sketch_Path], [Date_Baptism], [Date_Birth], [Gender], [Civil_Status], [Street], [Brgy], [City_Town], [Province], [Region], [Employment], [Phone_no], [Contact_Person], [Contact_Person_no], [Status], [Remarks], [Group_ID], [Committee_Names], [locale_id], [Baptizer], [is_contact_person_member], [is_deleted]) VALUES (N'B-0057', N'11507206', N'JOMARI', NULL, N'CORTEZ', NULL, NULL, CAST(N'1990-01-01' AS Date), CAST(N'1990-01-01' AS Date), N'MALE', N'SINGLE', N'SAN ISIDRO', N'STA.CRUZ', N'PORAC', N'PAMPANGA', N'3', NULL, NULL, N'RODOLFO DAVID', NULL, N'Active', NULL, 0, NULL, 5, NULL, 1, 0)
INSERT [dbo].[Brethren] ([brethren_id], [Church_Id], [Firstname], [Middlename], [Lastname], [Image_Path], [Sketch_Path], [Date_Baptism], [Date_Birth], [Gender], [Civil_Status], [Street], [Brgy], [City_Town], [Province], [Region], [Employment], [Phone_no], [Contact_Person], [Contact_Person_no], [Status], [Remarks], [Group_ID], [Committee_Names], [locale_id], [Baptizer], [is_contact_person_member], [is_deleted]) VALUES (N'B-0058', N'11612756', N'NICOLE', N'MAGTOTO', N'MAMUCUD', NULL, NULL, CAST(N'2016-12-22' AS Date), CAST(N'1990-01-01' AS Date), N'FEMALE', N'SINGLE', N'120 MALIGAYA', N'CUT-CUT', N'ANGELES', N'PAMPANGA', N'3', NULL, NULL, N'BALTAZAR MAMUCUD', NULL, N'Active', NULL, 2, NULL, 5, NULL, 1, 0)
INSERT [dbo].[Brethren] ([brethren_id], [Church_Id], [Firstname], [Middlename], [Lastname], [Image_Path], [Sketch_Path], [Date_Baptism], [Date_Birth], [Gender], [Civil_Status], [Street], [Brgy], [City_Town], [Province], [Region], [Employment], [Phone_no], [Contact_Person], [Contact_Person_no], [Status], [Remarks], [Group_ID], [Committee_Names], [locale_id], [Baptizer], [is_contact_person_member], [is_deleted]) VALUES (N'B-0060', N'STP00080', N'ANALIZA', N'BALUYUT', N'DAVID', NULL, NULL, CAST(N'2001-04-13' AS Date), CAST(N'1967-05-03' AS Date), N'FEMALE', N'Married', N'138 STO. NINO', N'STA.CRUZ', N'PORAC', N'PAMPANGA', N'3', NULL, NULL, N'RODOLFO DAVID', NULL, N'Active', NULL, 4, NULL, 5, NULL, 1, 0)
INSERT [dbo].[Brethren] ([brethren_id], [Church_Id], [Firstname], [Middlename], [Lastname], [Image_Path], [Sketch_Path], [Date_Baptism], [Date_Birth], [Gender], [Civil_Status], [Street], [Brgy], [City_Town], [Province], [Region], [Employment], [Phone_no], [Contact_Person], [Contact_Person_no], [Status], [Remarks], [Group_ID], [Committee_Names], [locale_id], [Baptizer], [is_contact_person_member], [is_deleted]) VALUES (N'B-0061', N'STP00079', N'RODOLFO', N'ALLANIGUE', N'DAVID', NULL, NULL, CAST(N'2000-02-11' AS Date), CAST(N'1965-09-22' AS Date), N'MALE', N'Married', N'138 STO. NINO', N'STA.CRUZ', N'PORAC', N'PAMPANGA', N'3', NULL, NULL, N'ANALIZA DAVID', NULL, N'Active', NULL, 4, NULL, 5, NULL, 1, 0)
INSERT [dbo].[Brethren] ([brethren_id], [Church_Id], [Firstname], [Middlename], [Lastname], [Image_Path], [Sketch_Path], [Date_Baptism], [Date_Birth], [Gender], [Civil_Status], [Street], [Brgy], [City_Town], [Province], [Region], [Employment], [Phone_no], [Contact_Person], [Contact_Person_no], [Status], [Remarks], [Group_ID], [Committee_Names], [locale_id], [Baptizer], [is_contact_person_member], [is_deleted]) VALUES (N'B-0062', N'11006953', N'ROSE ANN', N'BALUYUT', N'DAVID', NULL, NULL, CAST(N'2010-05-30' AS Date), CAST(N'1996-10-09' AS Date), N'FEMALE', N'Single', N'138 STO. NINO', N'STA.CRUZ', N'PORAC', N'PAMPANGA', N'3', NULL, NULL, N'RODOLFO DAVID', NULL, N'Active', NULL, 4, NULL, 5, N'                                                                                              ', 1, 0)
INSERT [dbo].[Brethren] ([brethren_id], [Church_Id], [Firstname], [Middlename], [Lastname], [Image_Path], [Sketch_Path], [Date_Baptism], [Date_Birth], [Gender], [Civil_Status], [Street], [Brgy], [City_Town], [Province], [Region], [Employment], [Phone_no], [Contact_Person], [Contact_Person_no], [Status], [Remarks], [Group_ID], [Committee_Names], [locale_id], [Baptizer], [is_contact_person_member], [is_deleted]) VALUES (N'B-64', N'STP00106', N'CARMINA', N'', N'JOSON', N'', N'', CAST(N'1900-01-01' AS Date), CAST(N'1900-01-01' AS Date), N'', N'', N'', N'', N'', N'', N'', N'', N'', N'', N'', N'Active', N'', 0, N'', 5, N'', 0, 0)
INSERT [dbo].[Brethren] ([brethren_id], [Church_Id], [Firstname], [Middlename], [Lastname], [Image_Path], [Sketch_Path], [Date_Baptism], [Date_Birth], [Gender], [Civil_Status], [Street], [Brgy], [City_Town], [Province], [Region], [Employment], [Phone_no], [Contact_Person], [Contact_Person_no], [Status], [Remarks], [Group_ID], [Committee_Names], [locale_id], [Baptizer], [is_contact_person_member], [is_deleted]) VALUES (N'B-65', N'STP00002', N'JERLIN', N'', N'LAYUG', N'', N'', CAST(N'1900-01-01' AS Date), CAST(N'1900-01-01' AS Date), N'', N'', N'', N'', N'', N'', N'', N'', N'', N'', N'', N'Active', N'', 0, N'', 5, N'', 0, 0)
INSERT [dbo].[Brethren] ([brethren_id], [Church_Id], [Firstname], [Middlename], [Lastname], [Image_Path], [Sketch_Path], [Date_Baptism], [Date_Birth], [Gender], [Civil_Status], [Street], [Brgy], [City_Town], [Province], [Region], [Employment], [Phone_no], [Contact_Person], [Contact_Person_no], [Status], [Remarks], [Group_ID], [Committee_Names], [locale_id], [Baptizer], [is_contact_person_member], [is_deleted]) VALUES (N'B-66', N'STP00042', N'CECIL', N'', N'DUNGAO', NULL, NULL, CAST(N'2017-02-18' AS Date), CAST(N'1900-01-01' AS Date), N'', N'', N'', N'', N'', N'', N'', N'', N'', N'', N'', N'Active', N'', 0, N'', 0, N'', 0, 0)
INSERT [dbo].[Brethren] ([brethren_id], [Church_Id], [Firstname], [Middlename], [Lastname], [Image_Path], [Sketch_Path], [Date_Baptism], [Date_Birth], [Gender], [Civil_Status], [Street], [Brgy], [City_Town], [Province], [Region], [Employment], [Phone_no], [Contact_Person], [Contact_Person_no], [Status], [Remarks], [Group_ID], [Committee_Names], [locale_id], [Baptizer], [is_contact_person_member], [is_deleted]) VALUES (N'B-67', N'11105434', N'SYRA', N'', N'DAYRIT', NULL, NULL, CAST(N'2017-02-19' AS Date), CAST(N'1900-01-01' AS Date), N'', N'', N'', N'', N'', N'', N'', N'', N'', N'', N'', N'Active', N'', 0, N'', 0, N'', 0, 0)
SET IDENTITY_INSERT [dbo].[Committee] ON 

INSERT [dbo].[Committee] ([committee_id], [committee_name], [committee_code], [is_deleted]) VALUES (1, N'KKTK', N'DEPT-1000', 0)
INSERT [dbo].[Committee] ([committee_id], [committee_name], [committee_code], [is_deleted]) VALUES (2, N'ADDPRO', N'DEPT-1001', 0)
INSERT [dbo].[Committee] ([committee_id], [committee_name], [committee_code], [is_deleted]) VALUES (3, N'ADDCIT', N'DEPT-1002', 0)
INSERT [dbo].[Committee] ([committee_id], [committee_name], [committee_code], [is_deleted]) VALUES (4, N'ADDSAT', N'DEPT-1003', 0)
INSERT [dbo].[Committee] ([committee_id], [committee_name], [committee_code], [is_deleted]) VALUES (5, N'ARTISTS'' GUILD', N'DEPT-1004', 0)
INSERT [dbo].[Committee] ([committee_id], [committee_name], [committee_code], [is_deleted]) VALUES (6, N'CHOIR', N'DEPT-1005', 0)
INSERT [dbo].[Committee] ([committee_id], [committee_name], [committee_code], [is_deleted]) VALUES (7, N'TEATRO KRISTIANO', N'DEPT-1006', 0)
INSERT [dbo].[Committee] ([committee_id], [committee_name], [committee_code], [is_deleted]) VALUES (8, N'MOTHERS'' CLUB', N'DEPT-1007', 0)
INSERT [dbo].[Committee] ([committee_id], [committee_name], [committee_code], [is_deleted]) VALUES (9, N'WORKERS', N'DEPT-1008', 0)
INSERT [dbo].[Committee] ([committee_id], [committee_name], [committee_code], [is_deleted]) VALUES (10, N'KNC', N'DEPT-1009', 0)
SET IDENTITY_INSERT [dbo].[Committee] OFF
INSERT [dbo].[Gathering] ([Gathering_Id], [Gathering_Type], [Gathering_Week], [Gathering_Month], [Gathering_Year], [Viewing_Type], [Gathering_Day], [Batch_ID], [Gathering_Date]) VALUES (N'172PMW3WED7:30 PM', 4, N'W3', 2, 2017, N'VIDEO TAPE', N'WED', 12, N'15')
INSERT [dbo].[Gathering] ([Gathering_Id], [Gathering_Type], [Gathering_Week], [Gathering_Month], [Gathering_Year], [Viewing_Type], [Gathering_Day], [Batch_ID], [Gathering_Date]) VALUES (N'172PMW4WED7:30 PM', 4, N'W4', 2, 2017, N'VIDEO TAPE', N'WED', 12, N'22')
INSERT [dbo].[Gathering] ([Gathering_Id], [Gathering_Type], [Gathering_Week], [Gathering_Month], [Gathering_Year], [Viewing_Type], [Gathering_Day], [Batch_ID], [Gathering_Date]) VALUES (N'172SPMW2SUN5:30 PM', 1, N'W2', 2, 2017, N'LIVE VIDEO', N'SUN', 6, N'12')
INSERT [dbo].[Gathering] ([Gathering_Id], [Gathering_Type], [Gathering_Week], [Gathering_Month], [Gathering_Year], [Viewing_Type], [Gathering_Day], [Batch_ID], [Gathering_Date]) VALUES (N'172TGPW2SUN6:00 AM', 5, N'W2', 2, 2017, N'LIVE VIDEO', N'SUN', 13, N'12')
INSERT [dbo].[Gathering] ([Gathering_Id], [Gathering_Type], [Gathering_Week], [Gathering_Month], [Gathering_Year], [Viewing_Type], [Gathering_Day], [Batch_ID], [Gathering_Date]) VALUES (N'172TGPW3SUN6:00 AM', 5, N'W3', 2, 2017, N'LIVE VIDEO', N'SUN', 13, N'19')
INSERT [dbo].[Gathering] ([Gathering_Id], [Gathering_Type], [Gathering_Week], [Gathering_Month], [Gathering_Year], [Viewing_Type], [Gathering_Day], [Batch_ID], [Gathering_Date]) VALUES (N'172TGPW4SUN6:00 AM', 5, N'W4', 2, 2017, N'LIVE VIDEO', N'SUN', 13, N'26')
INSERT [dbo].[Gathering] ([Gathering_Id], [Gathering_Type], [Gathering_Week], [Gathering_Month], [Gathering_Year], [Viewing_Type], [Gathering_Day], [Batch_ID], [Gathering_Date]) VALUES (N'172WSW3SAT7:30 PM', 3, N'W3', 2, 2017, N'VIDEO TAPE', N'SAT', 12, N'11')
INSERT [dbo].[Gathering] ([Gathering_Id], [Gathering_Type], [Gathering_Week], [Gathering_Month], [Gathering_Year], [Viewing_Type], [Gathering_Day], [Batch_ID], [Gathering_Date]) VALUES (N'172WSW4SAT7:30 PM', 3, N'W4', 2, 2017, N'VIDEO TAPE', N'SAT', 12, N'18')
INSERT [dbo].[Gathering] ([Gathering_Id], [Gathering_Type], [Gathering_Week], [Gathering_Month], [Gathering_Year], [Viewing_Type], [Gathering_Day], [Batch_ID], [Gathering_Date]) VALUES (N'172WSW5SAT7:30 PM', 3, N'W5', 2, 2017, N'VIDEO TAPE', N'SAT', 12, N'25')
INSERT [dbo].[Gathering] ([Gathering_Id], [Gathering_Type], [Gathering_Week], [Gathering_Month], [Gathering_Year], [Viewing_Type], [Gathering_Day], [Batch_ID], [Gathering_Date]) VALUES (N'173PMW1WED7:30 PM', 4, N'W1', 3, 2017, N'VIDEO TAPE', N'WED', 12, N'1')
INSERT [dbo].[Gathering] ([Gathering_Id], [Gathering_Type], [Gathering_Week], [Gathering_Month], [Gathering_Year], [Viewing_Type], [Gathering_Day], [Batch_ID], [Gathering_Date]) VALUES (N'173PMW3WED7:30 PM', 4, N'W3', 3, 2017, N'VIDEO TAPE', N'WED', 12, N'15')
INSERT [dbo].[Gathering] ([Gathering_Id], [Gathering_Type], [Gathering_Week], [Gathering_Month], [Gathering_Year], [Viewing_Type], [Gathering_Day], [Batch_ID], [Gathering_Date]) VALUES (N'173SPMW2TUE5:30 PM', 1, N'W2', 3, 2017, N'LIVE VIDEO', N'TUE', 6, N'7')
INSERT [dbo].[Gathering] ([Gathering_Id], [Gathering_Type], [Gathering_Week], [Gathering_Month], [Gathering_Year], [Viewing_Type], [Gathering_Day], [Batch_ID], [Gathering_Date]) VALUES (N'173TGPW1SUN6:00 AM', 5, N'W1', 3, 2017, N'LIVE VIDEO', N'SUN', 13, N'5')
INSERT [dbo].[Gathering] ([Gathering_Id], [Gathering_Type], [Gathering_Week], [Gathering_Month], [Gathering_Year], [Viewing_Type], [Gathering_Day], [Batch_ID], [Gathering_Date]) VALUES (N'173TGPW2SUN6:00 AM', 5, N'W2', 3, 2017, N'LIVE VIDEO', N'SUN', 13, N'12')
INSERT [dbo].[Gathering] ([Gathering_Id], [Gathering_Type], [Gathering_Week], [Gathering_Month], [Gathering_Year], [Viewing_Type], [Gathering_Day], [Batch_ID], [Gathering_Date]) VALUES (N'173WSW2SAT7:30 PM', 3, N'W2', 3, 2017, N'VIDEO TAPE', N'SAT', 12, N'4')
INSERT [dbo].[Gathering] ([Gathering_Id], [Gathering_Type], [Gathering_Week], [Gathering_Month], [Gathering_Year], [Viewing_Type], [Gathering_Day], [Batch_ID], [Gathering_Date]) VALUES (N'173WSW3SAT7:30 PM', 3, N'W3', 3, 2017, N'VIDEO TAPE', N'SAT', 12, N'11')
SET IDENTITY_INSERT [dbo].[Gathering_types] ON 

INSERT [dbo].[Gathering_types] ([gathering_id], [gathering_code], [gathering], [is_deleted]) VALUES (1, N'SPM', N'SPECIAL PRAYER MEETING', 0)
INSERT [dbo].[Gathering_types] ([gathering_id], [gathering_code], [gathering], [is_deleted]) VALUES (2, N'TG', N'THANKSGIVING TO GOD', 0)
INSERT [dbo].[Gathering_types] ([gathering_id], [gathering_code], [gathering], [is_deleted]) VALUES (3, N'WS', N'WORSHIP SERVICE', 0)
INSERT [dbo].[Gathering_types] ([gathering_id], [gathering_code], [gathering], [is_deleted]) VALUES (4, N'PM', N'PRAYER MEETING', 0)
INSERT [dbo].[Gathering_types] ([gathering_id], [gathering_code], [gathering], [is_deleted]) VALUES (5, N'ITG', N'THANKSGIVING OF GOD''S PEOPLE', 0)
INSERT [dbo].[Gathering_types] ([gathering_id], [gathering_code], [gathering], [is_deleted]) VALUES (6, N'CSWSPM', N'COMBINE WORSHIP SERVICE AND PRAYER MEETING', 0)
SET IDENTITY_INSERT [dbo].[Gathering_types] OFF
SET IDENTITY_INSERT [dbo].[Groupings] ON 

INSERT [dbo].[Groupings] ([Group_Id], [Group_name], [servant_id], [asst_servant_id], [is_deleted]) VALUES (0, N'No Group', NULL, NULL, 0)
INSERT [dbo].[Groupings] ([Group_Id], [Group_name], [servant_id], [asst_servant_id], [is_deleted]) VALUES (1, N'Group 1', NULL, NULL, 0)
INSERT [dbo].[Groupings] ([Group_Id], [Group_name], [servant_id], [asst_servant_id], [is_deleted]) VALUES (2, N'Group 2', NULL, NULL, 0)
INSERT [dbo].[Groupings] ([Group_Id], [Group_name], [servant_id], [asst_servant_id], [is_deleted]) VALUES (3, N'Group 3', NULL, NULL, 0)
INSERT [dbo].[Groupings] ([Group_Id], [Group_name], [servant_id], [asst_servant_id], [is_deleted]) VALUES (4, N'Group 4', NULL, NULL, 0)
SET IDENTITY_INSERT [dbo].[Groupings] OFF
INSERT [dbo].[Interlocale] ([Interlocale_Id], [Church_Id], [Firstname], [Lastname], [Locale], [DateOfBaptism], [Middlename]) VALUES (N'IL-0001', N'DA100126', N'MICHAEL', N'JOSON', N'DAU', CAST(N'2017-02-11' AS Date), N'')
INSERT [dbo].[Interlocale] ([Interlocale_Id], [Church_Id], [Firstname], [Lastname], [Locale], [DateOfBaptism], [Middlename]) VALUES (N'IL-10', N'00704070', N'MARICAR', N'VELASQUEZ', N'ACC', CAST(N'2017-02-18' AS Date), N'MANALO')
INSERT [dbo].[Interlocale] ([Interlocale_Id], [Church_Id], [Firstname], [Lastname], [Locale], [DateOfBaptism], [Middlename]) VALUES (N'IL-2', N'STP00017', N'ROMMEL', N'LAYUG', N'FLORIDABLANCA', CAST(N'2017-02-11' AS Date), N'')
INSERT [dbo].[Interlocale] ([Interlocale_Id], [Church_Id], [Firstname], [Lastname], [Locale], [DateOfBaptism], [Middlename]) VALUES (N'IL-3', N'STP00009', N'ERNESTO', N'TIPON', N'ACC', CAST(N'2017-02-11' AS Date), N'')
INSERT [dbo].[Interlocale] ([Interlocale_Id], [Church_Id], [Firstname], [Lastname], [Locale], [DateOfBaptism], [Middlename]) VALUES (N'IL-4', N'00703240', N'ANDREA', N'PANTIG', N'MARISOL', CAST(N'2017-02-11' AS Date), N'SANTIAGO')
INSERT [dbo].[Interlocale] ([Interlocale_Id], [Church_Id], [Firstname], [Lastname], [Locale], [DateOfBaptism], [Middlename]) VALUES (N'IL-5', N'11700481', N'KYLA', N'LAYUG', N'FLORIDABLANCA', CAST(N'2017-02-11' AS Date), N'')
INSERT [dbo].[Interlocale] ([Interlocale_Id], [Church_Id], [Firstname], [Lastname], [Locale], [DateOfBaptism], [Middlename]) VALUES (N'IL-6', N'STP00056', N'SALLY', N'TIPON', N'ACC', CAST(N'2017-02-11' AS Date), N'')
INSERT [dbo].[Interlocale] ([Interlocale_Id], [Church_Id], [Firstname], [Lastname], [Locale], [DateOfBaptism], [Middlename]) VALUES (N'IL-7', N'ANG00235', N'REGINA', N'JONES', N'ACC', CAST(N'2017-02-15' AS Date), N'')
INSERT [dbo].[Interlocale] ([Interlocale_Id], [Church_Id], [Firstname], [Lastname], [Locale], [DateOfBaptism], [Middlename]) VALUES (N'IL-8', N'ANG00067', N'WILLIAM', N'JONES', N'ACC', CAST(N'2017-02-15' AS Date), N'')
INSERT [dbo].[Interlocale] ([Interlocale_Id], [Church_Id], [Firstname], [Lastname], [Locale], [DateOfBaptism], [Middlename]) VALUES (N'IL-9', N'00900914', N'EDLYN', N'ANCHETA', N'MANIBAUG', CAST(N'2017-02-18' AS Date), N'')
SET IDENTITY_INSERT [dbo].[Locale] ON 

INSERT [dbo].[Locale] ([locale_id], [dist], [div], [address], [image], [locale], [locale_code], [is_deleted]) VALUES (5, N'1', N'Pampanga', N'San Isidro St., Sta. Cruz, Porac', NULL, N'Sta. Cruz, Porac', N'LOCALE-1000', 0)
SET IDENTITY_INSERT [dbo].[Locale] OFF
SET IDENTITY_INSERT [dbo].[System_Logs] ON 

INSERT [dbo].[System_Logs] ([Log_ID], [user_id], [Activity], [Date], [Time], [Module], [Activity_Status]) VALUES (1, 8, N'Logged in', CAST(N'2017-02-11' AS Date), CAST(N'10:40:00' AS Time), N'Login', 1)
INSERT [dbo].[System_Logs] ([Log_ID], [user_id], [Activity], [Date], [Time], [Module], [Activity_Status]) VALUES (2, 8, N'Created 172WSW3SAT7:30 PM', CAST(N'2017-02-11' AS Date), CAST(N'10:41:00' AS Time), N'Gathering Management', 1)
INSERT [dbo].[System_Logs] ([Log_ID], [user_id], [Activity], [Date], [Time], [Module], [Activity_Status]) VALUES (3, 8, N'Added Interlocale, MICHAEL JOSON', CAST(N'2017-02-11' AS Date), CAST(N'10:43:00' AS Time), N'Interlocale Module', 1)
INSERT [dbo].[System_Logs] ([Log_ID], [user_id], [Activity], [Date], [Time], [Module], [Activity_Status]) VALUES (4, 8, N'Added Interlocale, ROMMEL YALUNG', CAST(N'2017-02-11' AS Date), CAST(N'10:43:00' AS Time), N'Interlocale Module', 1)
INSERT [dbo].[System_Logs] ([Log_ID], [user_id], [Activity], [Date], [Time], [Module], [Activity_Status]) VALUES (5, 2, N'Logged in', CAST(N'2017-02-11' AS Date), CAST(N'10:45:00' AS Time), N'Login', 1)
INSERT [dbo].[System_Logs] ([Log_ID], [user_id], [Activity], [Date], [Time], [Module], [Activity_Status]) VALUES (6, 2, N'Quickly Added Brethren, test brethren', CAST(N'2017-02-11' AS Date), CAST(N'10:46:00' AS Time), N'Newly Baptized Module', 1)
INSERT [dbo].[System_Logs] ([Log_ID], [user_id], [Activity], [Date], [Time], [Module], [Activity_Status]) VALUES (7, 8, N'Logged in', CAST(N'2017-02-11' AS Date), CAST(N'19:12:00' AS Time), N'Login', 1)
INSERT [dbo].[System_Logs] ([Log_ID], [user_id], [Activity], [Date], [Time], [Module], [Activity_Status]) VALUES (8, 8, N'Created 172WSW3SAT7:30 PM', CAST(N'2017-02-11' AS Date), CAST(N'19:15:00' AS Time), N'Gathering Management', 1)
INSERT [dbo].[System_Logs] ([Log_ID], [user_id], [Activity], [Date], [Time], [Module], [Activity_Status]) VALUES (9, 8, N'Added Interlocale, ERNESTO TIPON', CAST(N'2017-02-11' AS Date), CAST(N'19:25:00' AS Time), N'Interlocale Module', 1)
INSERT [dbo].[System_Logs] ([Log_ID], [user_id], [Activity], [Date], [Time], [Module], [Activity_Status]) VALUES (10, 8, N'Quickly Added Brethren, CARMINA JOSON', CAST(N'2017-02-11' AS Date), CAST(N'19:34:00' AS Time), N'Newly Baptized Module', 1)
INSERT [dbo].[System_Logs] ([Log_ID], [user_id], [Activity], [Date], [Time], [Module], [Activity_Status]) VALUES (11, 8, N'Added Interlocale, ANDREA PANTIG', CAST(N'2017-02-11' AS Date), CAST(N'19:35:00' AS Time), N'Interlocale Module', 1)
INSERT [dbo].[System_Logs] ([Log_ID], [user_id], [Activity], [Date], [Time], [Module], [Activity_Status]) VALUES (12, 8, N'Quickly Added Brethren, JERLIN LAYUG', CAST(N'2017-02-11' AS Date), CAST(N'19:39:00' AS Time), N'Newly Baptized Module', 1)
INSERT [dbo].[System_Logs] ([Log_ID], [user_id], [Activity], [Date], [Time], [Module], [Activity_Status]) VALUES (13, 8, N'Added Interlocale, KYLA LAYUG', CAST(N'2017-02-11' AS Date), CAST(N'19:40:00' AS Time), N'Interlocale Module', 1)
INSERT [dbo].[System_Logs] ([Log_ID], [user_id], [Activity], [Date], [Time], [Module], [Activity_Status]) VALUES (14, 8, N'Edited Interlocale, ROMMEL LAYUG', CAST(N'2017-02-11' AS Date), CAST(N'19:41:00' AS Time), N'Interlocale Module', 1)
INSERT [dbo].[System_Logs] ([Log_ID], [user_id], [Activity], [Date], [Time], [Module], [Activity_Status]) VALUES (15, 8, N'Added Interlocale, SALLY TIPON', CAST(N'2017-02-11' AS Date), CAST(N'19:42:00' AS Time), N'Interlocale Module', 1)
INSERT [dbo].[System_Logs] ([Log_ID], [user_id], [Activity], [Date], [Time], [Module], [Activity_Status]) VALUES (16, 8, N'Edited Interlocale, SALLY TIPON', CAST(N'2017-02-11' AS Date), CAST(N'19:42:00' AS Time), N'Interlocale Module', 1)
INSERT [dbo].[System_Logs] ([Log_ID], [user_id], [Activity], [Date], [Time], [Module], [Activity_Status]) VALUES (17, 8, N'Edited Interlocale, ANDREA PANTIG', CAST(N'2017-02-11' AS Date), CAST(N'19:43:00' AS Time), N'Interlocale Module', 1)
INSERT [dbo].[System_Logs] ([Log_ID], [user_id], [Activity], [Date], [Time], [Module], [Activity_Status]) VALUES (18, 8, N'Edits CARMINA JOSON Information', CAST(N'2017-02-11' AS Date), CAST(N'20:19:00' AS Time), N'Brethren Management', 1)
INSERT [dbo].[System_Logs] ([Log_ID], [user_id], [Activity], [Date], [Time], [Module], [Activity_Status]) VALUES (19, 1, N'Logged in', CAST(N'2017-02-11' AS Date), CAST(N'20:28:00' AS Time), N'Login', 1)
INSERT [dbo].[System_Logs] ([Log_ID], [user_id], [Activity], [Date], [Time], [Module], [Activity_Status]) VALUES (20, 8, N'Logged in', CAST(N'2017-02-11' AS Date), CAST(N'20:40:00' AS Time), N'Login', 1)
INSERT [dbo].[System_Logs] ([Log_ID], [user_id], [Activity], [Date], [Time], [Module], [Activity_Status]) VALUES (21, 8, N'Edits JERLIN LAYUG Information', CAST(N'2017-02-11' AS Date), CAST(N'20:42:00' AS Time), N'Brethren Management', 1)
INSERT [dbo].[System_Logs] ([Log_ID], [user_id], [Activity], [Date], [Time], [Module], [Activity_Status]) VALUES (22, 1, N'Logged in', CAST(N'2017-02-11' AS Date), CAST(N'20:44:00' AS Time), N'Login', 1)
INSERT [dbo].[System_Logs] ([Log_ID], [user_id], [Activity], [Date], [Time], [Module], [Activity_Status]) VALUES (23, 8, N'Logged in', CAST(N'2017-02-11' AS Date), CAST(N'20:54:00' AS Time), N'Login', 1)
INSERT [dbo].[System_Logs] ([Log_ID], [user_id], [Activity], [Date], [Time], [Module], [Activity_Status]) VALUES (24, 8, N'Edits CARMINA JOSON Information', CAST(N'2017-02-11' AS Date), CAST(N'21:09:00' AS Time), N'Brethren Management', 1)
INSERT [dbo].[System_Logs] ([Log_ID], [user_id], [Activity], [Date], [Time], [Module], [Activity_Status]) VALUES (25, 8, N'Logged in', CAST(N'2017-02-12' AS Date), CAST(N'06:48:00' AS Time), N'Login', 1)
INSERT [dbo].[System_Logs] ([Log_ID], [user_id], [Activity], [Date], [Time], [Module], [Activity_Status]) VALUES (26, 8, N'Created 172TGPW2SUN6:00 AM', CAST(N'2017-02-12' AS Date), CAST(N'06:48:00' AS Time), N'Gathering Management', 1)
INSERT [dbo].[System_Logs] ([Log_ID], [user_id], [Activity], [Date], [Time], [Module], [Activity_Status]) VALUES (27, 8, N'Edited Interlocale, MICHAEL JOSON', CAST(N'2017-02-12' AS Date), CAST(N'06:53:00' AS Time), N'Interlocale Module', 1)
INSERT [dbo].[System_Logs] ([Log_ID], [user_id], [Activity], [Date], [Time], [Module], [Activity_Status]) VALUES (28, 8, N'Created 172SPMW2SUN5:30 PM', CAST(N'2017-02-12' AS Date), CAST(N'07:26:00' AS Time), N'Gathering Management', 1)
INSERT [dbo].[System_Logs] ([Log_ID], [user_id], [Activity], [Date], [Time], [Module], [Activity_Status]) VALUES (29, 8, N'Logged in', CAST(N'2017-02-12' AS Date), CAST(N'07:40:00' AS Time), N'Login', 1)
INSERT [dbo].[System_Logs] ([Log_ID], [user_id], [Activity], [Date], [Time], [Module], [Activity_Status]) VALUES (30, 8, N'Logged in', CAST(N'2017-02-15' AS Date), CAST(N'19:18:00' AS Time), N'Login', 1)
INSERT [dbo].[System_Logs] ([Log_ID], [user_id], [Activity], [Date], [Time], [Module], [Activity_Status]) VALUES (31, 8, N'Created 172PMW3WED7:30 PM', CAST(N'2017-02-15' AS Date), CAST(N'19:19:00' AS Time), N'Gathering Management', 1)
INSERT [dbo].[System_Logs] ([Log_ID], [user_id], [Activity], [Date], [Time], [Module], [Activity_Status]) VALUES (32, 8, N'Added Interlocale, regina jones', CAST(N'2017-02-15' AS Date), CAST(N'19:24:00' AS Time), N'Interlocale Module', 1)
INSERT [dbo].[System_Logs] ([Log_ID], [user_id], [Activity], [Date], [Time], [Module], [Activity_Status]) VALUES (33, 8, N'Added Interlocale, WILLIAM JONES', CAST(N'2017-02-15' AS Date), CAST(N'19:24:00' AS Time), N'Interlocale Module', 1)
INSERT [dbo].[System_Logs] ([Log_ID], [user_id], [Activity], [Date], [Time], [Module], [Activity_Status]) VALUES (34, 8, N'Edited Interlocale, ERNESTO TIPON', CAST(N'2017-02-15' AS Date), CAST(N'19:27:00' AS Time), N'Interlocale Module', 1)
INSERT [dbo].[System_Logs] ([Log_ID], [user_id], [Activity], [Date], [Time], [Module], [Activity_Status]) VALUES (35, 8, N'Edited Interlocale, ERNESTO TIPON', CAST(N'2017-02-15' AS Date), CAST(N'19:28:00' AS Time), N'Interlocale Module', 1)
INSERT [dbo].[System_Logs] ([Log_ID], [user_id], [Activity], [Date], [Time], [Module], [Activity_Status]) VALUES (36, 8, N'Edited Interlocale, REGINA JONES', CAST(N'2017-02-15' AS Date), CAST(N'19:30:00' AS Time), N'Interlocale Module', 1)
INSERT [dbo].[System_Logs] ([Log_ID], [user_id], [Activity], [Date], [Time], [Module], [Activity_Status]) VALUES (37, 8, N'Quickly Added Brethren, NICOLE MAMUCUD', CAST(N'2017-02-15' AS Date), CAST(N'19:37:00' AS Time), N'Newly Baptized Module', 1)
INSERT [dbo].[System_Logs] ([Log_ID], [user_id], [Activity], [Date], [Time], [Module], [Activity_Status]) VALUES (38, 8, N'Logged in', CAST(N'2017-02-15' AS Date), CAST(N'20:20:00' AS Time), N'Login', 1)
INSERT [dbo].[System_Logs] ([Log_ID], [user_id], [Activity], [Date], [Time], [Module], [Activity_Status]) VALUES (39, 8, N'Logged in', CAST(N'2017-02-15' AS Date), CAST(N'20:39:00' AS Time), N'Login', 1)
INSERT [dbo].[System_Logs] ([Log_ID], [user_id], [Activity], [Date], [Time], [Module], [Activity_Status]) VALUES (40, 8, N'Logged in', CAST(N'2017-02-18' AS Date), CAST(N'19:19:00' AS Time), N'Login', 1)
INSERT [dbo].[System_Logs] ([Log_ID], [user_id], [Activity], [Date], [Time], [Module], [Activity_Status]) VALUES (41, 8, N'Created 172WSW4SAT7:30 PM', CAST(N'2017-02-18' AS Date), CAST(N'19:20:00' AS Time), N'Gathering Management', 1)
INSERT [dbo].[System_Logs] ([Log_ID], [user_id], [Activity], [Date], [Time], [Module], [Activity_Status]) VALUES (42, 8, N'Added Interlocale, EDLYN ANCHETA', CAST(N'2017-02-18' AS Date), CAST(N'19:21:00' AS Time), N'Interlocale Module', 1)
INSERT [dbo].[System_Logs] ([Log_ID], [user_id], [Activity], [Date], [Time], [Module], [Activity_Status]) VALUES (43, 8, N'Quickly Added Brethren, CECIL DUNGAO', CAST(N'2017-02-18' AS Date), CAST(N'19:25:00' AS Time), N'Newly Baptized Module', 1)
INSERT [dbo].[System_Logs] ([Log_ID], [user_id], [Activity], [Date], [Time], [Module], [Activity_Status]) VALUES (44, 8, N'Added Interlocale, MARICAR VELASQUEZ', CAST(N'2017-02-18' AS Date), CAST(N'19:41:00' AS Time), N'Interlocale Module', 1)
INSERT [dbo].[System_Logs] ([Log_ID], [user_id], [Activity], [Date], [Time], [Module], [Activity_Status]) VALUES (45, 8, N'Logged in', CAST(N'2017-02-18' AS Date), CAST(N'21:02:00' AS Time), N'Login', 1)
INSERT [dbo].[System_Logs] ([Log_ID], [user_id], [Activity], [Date], [Time], [Module], [Activity_Status]) VALUES (46, 8, N'Logged in', CAST(N'2017-02-19' AS Date), CAST(N'07:15:00' AS Time), N'Login', 1)
INSERT [dbo].[System_Logs] ([Log_ID], [user_id], [Activity], [Date], [Time], [Module], [Activity_Status]) VALUES (47, 8, N'Created 172TGPW3SUN6:00 AM', CAST(N'2017-02-19' AS Date), CAST(N'07:16:00' AS Time), N'Gathering Management', 1)
INSERT [dbo].[System_Logs] ([Log_ID], [user_id], [Activity], [Date], [Time], [Module], [Activity_Status]) VALUES (48, 8, N'Quickly Added Brethren, SYRA DAYRIT', CAST(N'2017-02-19' AS Date), CAST(N'07:18:00' AS Time), N'Newly Baptized Module', 1)
INSERT [dbo].[System_Logs] ([Log_ID], [user_id], [Activity], [Date], [Time], [Module], [Activity_Status]) VALUES (49, 8, N'Logged in', CAST(N'2017-02-19' AS Date), CAST(N'08:01:00' AS Time), N'Login', 1)
INSERT [dbo].[System_Logs] ([Log_ID], [user_id], [Activity], [Date], [Time], [Module], [Activity_Status]) VALUES (50, 0, N'Church or Password is incorrect', CAST(N'2017-02-19' AS Date), CAST(N'08:05:00' AS Time), N'Login', 1)
INSERT [dbo].[System_Logs] ([Log_ID], [user_id], [Activity], [Date], [Time], [Module], [Activity_Status]) VALUES (51, 8, N'Logged in', CAST(N'2017-02-19' AS Date), CAST(N'08:06:00' AS Time), N'Login', 1)
INSERT [dbo].[System_Logs] ([Log_ID], [user_id], [Activity], [Date], [Time], [Module], [Activity_Status]) VALUES (52, 8, N'Logged in', CAST(N'2017-02-22' AS Date), CAST(N'19:20:00' AS Time), N'Login', 1)
INSERT [dbo].[System_Logs] ([Log_ID], [user_id], [Activity], [Date], [Time], [Module], [Activity_Status]) VALUES (53, 8, N'Created 172PMW4WED7:30 PM', CAST(N'2017-02-22' AS Date), CAST(N'19:22:00' AS Time), N'Gathering Management', 1)
INSERT [dbo].[System_Logs] ([Log_ID], [user_id], [Activity], [Date], [Time], [Module], [Activity_Status]) VALUES (54, 8, N'Logged in', CAST(N'2017-02-22' AS Date), CAST(N'19:31:00' AS Time), N'Login', 1)
INSERT [dbo].[System_Logs] ([Log_ID], [user_id], [Activity], [Date], [Time], [Module], [Activity_Status]) VALUES (55, 8, N'Logged in', CAST(N'2017-02-25' AS Date), CAST(N'19:17:00' AS Time), N'Login', 1)
INSERT [dbo].[System_Logs] ([Log_ID], [user_id], [Activity], [Date], [Time], [Module], [Activity_Status]) VALUES (56, 8, N'Created 172WSW5SAT7:30 PM', CAST(N'2017-02-25' AS Date), CAST(N'19:18:00' AS Time), N'Gathering Management', 1)
INSERT [dbo].[System_Logs] ([Log_ID], [user_id], [Activity], [Date], [Time], [Module], [Activity_Status]) VALUES (57, 0, N'Church or Password is incorrect', CAST(N'2017-02-26' AS Date), CAST(N'06:11:00' AS Time), N'Login', 1)
INSERT [dbo].[System_Logs] ([Log_ID], [user_id], [Activity], [Date], [Time], [Module], [Activity_Status]) VALUES (58, 0, N'Church or Password is incorrect', CAST(N'2017-02-26' AS Date), CAST(N'06:11:00' AS Time), N'Login', 1)
INSERT [dbo].[System_Logs] ([Log_ID], [user_id], [Activity], [Date], [Time], [Module], [Activity_Status]) VALUES (59, 8, N'Logged in', CAST(N'2017-02-26' AS Date), CAST(N'06:11:00' AS Time), N'Login', 1)
INSERT [dbo].[System_Logs] ([Log_ID], [user_id], [Activity], [Date], [Time], [Module], [Activity_Status]) VALUES (60, 8, N'Created 172TGPW4SUN6:00 AM', CAST(N'2017-02-26' AS Date), CAST(N'06:12:00' AS Time), N'Gathering Management', 1)
INSERT [dbo].[System_Logs] ([Log_ID], [user_id], [Activity], [Date], [Time], [Module], [Activity_Status]) VALUES (61, 8, N'Edited Interlocale, REGINA JONES', CAST(N'2017-02-26' AS Date), CAST(N'06:34:00' AS Time), N'Interlocale Module', 1)
INSERT [dbo].[System_Logs] ([Log_ID], [user_id], [Activity], [Date], [Time], [Module], [Activity_Status]) VALUES (62, 8, N'Edited Interlocale, WILLIAM JONES', CAST(N'2017-02-26' AS Date), CAST(N'06:35:00' AS Time), N'Interlocale Module', 1)
INSERT [dbo].[System_Logs] ([Log_ID], [user_id], [Activity], [Date], [Time], [Module], [Activity_Status]) VALUES (63, 8, N'Logged in', CAST(N'2017-03-01' AS Date), CAST(N'19:29:00' AS Time), N'Login', 1)
INSERT [dbo].[System_Logs] ([Log_ID], [user_id], [Activity], [Date], [Time], [Module], [Activity_Status]) VALUES (64, 8, N'Created 173PMW1WED7:30 PM', CAST(N'2017-03-01' AS Date), CAST(N'19:29:00' AS Time), N'Gathering Management', 1)
INSERT [dbo].[System_Logs] ([Log_ID], [user_id], [Activity], [Date], [Time], [Module], [Activity_Status]) VALUES (65, 8, N'Logged in', CAST(N'2017-03-01' AS Date), CAST(N'19:32:00' AS Time), N'Login', 1)
INSERT [dbo].[System_Logs] ([Log_ID], [user_id], [Activity], [Date], [Time], [Module], [Activity_Status]) VALUES (66, 8, N'Logged in', CAST(N'2017-03-04' AS Date), CAST(N'19:07:00' AS Time), N'Login', 1)
INSERT [dbo].[System_Logs] ([Log_ID], [user_id], [Activity], [Date], [Time], [Module], [Activity_Status]) VALUES (67, 8, N'Created 173WSW2SAT7:30 PM', CAST(N'2017-03-04' AS Date), CAST(N'19:11:00' AS Time), N'Gathering Management', 1)
INSERT [dbo].[System_Logs] ([Log_ID], [user_id], [Activity], [Date], [Time], [Module], [Activity_Status]) VALUES (68, 0, N'Church or Password is incorrect', CAST(N'2017-03-05' AS Date), CAST(N'06:22:00' AS Time), N'Login', 1)
INSERT [dbo].[System_Logs] ([Log_ID], [user_id], [Activity], [Date], [Time], [Module], [Activity_Status]) VALUES (69, 8, N'Logged in', CAST(N'2017-03-05' AS Date), CAST(N'06:22:00' AS Time), N'Login', 1)
INSERT [dbo].[System_Logs] ([Log_ID], [user_id], [Activity], [Date], [Time], [Module], [Activity_Status]) VALUES (70, 8, N'Created 173TGPW1SUN6:00 AM', CAST(N'2017-03-05' AS Date), CAST(N'06:22:00' AS Time), N'Gathering Management', 1)
INSERT [dbo].[System_Logs] ([Log_ID], [user_id], [Activity], [Date], [Time], [Module], [Activity_Status]) VALUES (71, 8, N'Logged in', CAST(N'2017-03-07' AS Date), CAST(N'17:44:00' AS Time), N'Login', 1)
INSERT [dbo].[System_Logs] ([Log_ID], [user_id], [Activity], [Date], [Time], [Module], [Activity_Status]) VALUES (72, 8, N'Created 173SPMW2TUE5:30 PM', CAST(N'2017-03-07' AS Date), CAST(N'17:46:00' AS Time), N'Gathering Management', 1)
INSERT [dbo].[System_Logs] ([Log_ID], [user_id], [Activity], [Date], [Time], [Module], [Activity_Status]) VALUES (73, 8, N'Logged in', CAST(N'2017-03-11' AS Date), CAST(N'19:30:00' AS Time), N'Login', 1)
INSERT [dbo].[System_Logs] ([Log_ID], [user_id], [Activity], [Date], [Time], [Module], [Activity_Status]) VALUES (74, 8, N'Created 173WSW3SAT7:30 PM', CAST(N'2017-03-11' AS Date), CAST(N'19:31:00' AS Time), N'Gathering Management', 1)
INSERT [dbo].[System_Logs] ([Log_ID], [user_id], [Activity], [Date], [Time], [Module], [Activity_Status]) VALUES (75, 8, N'Logged in', CAST(N'2017-03-12' AS Date), CAST(N'06:18:00' AS Time), N'Login', 1)
INSERT [dbo].[System_Logs] ([Log_ID], [user_id], [Activity], [Date], [Time], [Module], [Activity_Status]) VALUES (76, 8, N'Created 173TGPW2SUN6:00 AM', CAST(N'2017-03-12' AS Date), CAST(N'06:20:00' AS Time), N'Gathering Management', 1)
INSERT [dbo].[System_Logs] ([Log_ID], [user_id], [Activity], [Date], [Time], [Module], [Activity_Status]) VALUES (77, 8, N'Logged in', CAST(N'2017-03-15' AS Date), CAST(N'19:25:00' AS Time), N'Login', 1)
INSERT [dbo].[System_Logs] ([Log_ID], [user_id], [Activity], [Date], [Time], [Module], [Activity_Status]) VALUES (78, 8, N'Created 173PMW3WED7:30 PM', CAST(N'2017-03-15' AS Date), CAST(N'19:25:00' AS Time), N'Gathering Management', 1)
SET IDENTITY_INSERT [dbo].[System_Logs] OFF
SET IDENTITY_INSERT [dbo].[Users] ON 

INSERT [dbo].[Users] ([user_id], [church_id], [password], [fname], [mname], [lname], [privilege], [locale_id], [is_deleted], [is_approve], [user_img_path]) VALUES (1, N'Admin', N'a', N'John', N'', N'Doe', 1, 5, 0, 1, NULL)
INSERT [dbo].[Users] ([user_id], [church_id], [password], [fname], [mname], [lname], [privilege], [locale_id], [is_deleted], [is_approve], [user_img_path]) VALUES (2, N'11112036', N'master', N'John Kenneth', N'De Asis', N'Tolentino', 2, 5, 0, 1, N'C:\Users\jdevb\Source\Workspaces\Attendance Monitoring System (Locale Version)\AMS v1\Attendance Monitoring V1\bin\Debug\Users\john kenneth.jpg')
INSERT [dbo].[Users] ([user_id], [church_id], [password], [fname], [mname], [lname], [privilege], [locale_id], [is_deleted], [is_approve], [user_img_path]) VALUES (8, N'MA600030', N'amspilot', N'RUTH', N'ESTRABILLO', N'DUNGAO', 2, 5, 0, 1, NULL)
SET IDENTITY_INSERT [dbo].[Users] OFF
/****** Object:  StoredProcedure [dbo].[Attendance_Report]    Script Date: 5/10/2017 1:44:47 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[Attendance_Report]
	@Date date,
	@Gathering_Type varchar(100)
AS
BEGIN
	SELECT
		(CASE WHEN a.brethren_id LIKE '%B-%' THEN b.Firstname + ' ' + b.Lastname WHEN a.brethren_id LIKE '%IL-%' THEN i.Firstname + ' ' + i.Lastname END) AS BrethrenName,
		(CASE WHEN a.brethren_id LIKE '%B-%' THEN b.Church_Id WHEN a.brethren_id LIKE '%IL-%' THEN i.Church_Id END) AS Church_Id,
		a.*,
		(CASE WHEN a.Attendance_Status = 1 THEN 'Timed In' ELSE 'Late' END) AS AttendanceStatus,
		(CASE WHEN a.is_interlocale = 1 THEN 'Yes' ELSE 'No' END) AS Interlocale_Status,
		REPLACE(REPLACE(RIGHT('0'+LTRIM(RIGHT(CONVERT(varchar,Real_Time,100),7)),7),'AM',' AM'),'PM',' PM') AS Batch_Time,
		g.*,
		gt.*
	FROM
		dbo.Attendance AS a
	LEFT JOIN (SELECT
		Gathering.*,
		Cast(CONCAT(Gathering_Year,'-',Gathering_Month,'-',Gathering_Date) AS date) AS DateOfGathering
	FROM dbo.Gathering) AS g ON g.Gathering_Id=a.Gathering_ID
	LEFT JOIN Brethren as b ON b.brethren_id = a.brethren_id
	LEFT JOIN Interlocale as i ON i.Interlocale_Id = a.brethren_id
	LEFT JOIN Gathering_types AS gt ON gt.gathering_id=g.Gathering_Type
	WHERE gt.gathering_code=@Gathering_Type AND g.DateOfGathering = @Date AND a.is_interlocale=0
	ORDER BY a.is_interlocale
END




GO
/****** Object:  StoredProcedure [dbo].[ATTENDANCE_REPORT_NEW]    Script Date: 5/10/2017 1:44:47 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ATTENDANCE_REPORT_NEW]
	@Date date,
	@Gathering_Type varchar(100)
AS
BEGIN
	SELECT
		(CASE WHEN a.brethren_id LIKE '%B-%' THEN b.Firstname + ' ' + b.Lastname WHEN a.brethren_id LIKE '%IL-%' THEN i.Firstname + ' ' + i.Lastname END) AS BrethrenName,
		(CASE WHEN a.brethren_id LIKE '%B-%' THEN b.Church_Id WHEN a.brethren_id LIKE '%IL-%' THEN i.Church_Id END) AS Church_Id,
		a.*,
		(CASE WHEN a.Attendance_Status = 1 THEN 'Timed In' ELSE 'Late' END) AS AttendanceStatus,
		(CASE WHEN a.is_interlocale = 1 THEN 'Yes' ELSE 'No' END) AS Interlocale_Status,
		REPLACE(REPLACE(RIGHT('0'+LTRIM(RIGHT(CONVERT(varchar,Real_Time,100),7)),7),'AM',' AM'),'PM',' PM') AS time_in,
		g.*,
		bat.batch_time,
		CONCAT(bat.batch_time, ' BATCH') AS batch_time_lbl,
		gt.*
	FROM
		dbo.Attendance AS a
	LEFT JOIN (SELECT
		Gathering.*,
		Cast(CONCAT(Gathering_Year,'-',Gathering_Month,'-',Gathering_Date) AS date) AS DateOfGathering
	FROM dbo.Gathering) AS g ON g.Gathering_Id=a.Gathering_ID
	LEFT JOIN Brethren as b ON b.brethren_id = a.brethren_id
	LEFT JOIN Interlocale as i ON i.Interlocale_Id = a.brethren_id
	LEFT JOIN (SELECT Batches.Batch_ID, RIGHT(CONVERT(CHAR(20), Batch_Time, 22), 11) AS batch_time FROM Batches) AS bat ON bat.Batch_ID=g.Batch_ID
	LEFT JOIN Gathering_types AS gt ON gt.gathering_id=g.Gathering_Type
	WHERE 
	gt.gathering_code=@Gathering_Type AND 
	g.DateOfGathering = @Date AND 
	a.is_interlocale=0
	ORDER BY bat.batch_time
END


GO
/****** Object:  StoredProcedure [dbo].[AUTHENTICATE_USER]    Script Date: 5/10/2017 1:44:47 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		JK
-- Create date: 10/08/2016
-- Description:	LOGIN SP
-- =============================================
CREATE PROCEDURE [dbo].[AUTHENTICATE_USER]
	@ChurchID varchar(50),
	@Password varchar(50)
AS
BEGIN
	SELECT 
	COUNT(*)
	FROM Users 
	WHERE 
	church_id = @ChurchID 
	AND password = @Password
	AND is_deleted = 0
	AND is_approve = 1
END





GO
/****** Object:  StoredProcedure [dbo].[CHECK_BRETHREN_IF_ATTENDED]    Script Date: 5/10/2017 1:44:47 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[CHECK_BRETHREN_IF_ATTENDED]
	@GatheringID varchar(50),
	@temp_brethren_id nvarchar(100)
AS
BEGIN
		SELECT COUNT(*) 
		FROM tempAttendance
		WHERE tempGathering_ID = @GatheringID 
		AND temp_brethren_id = @temp_brethren_id
END




GO
/****** Object:  StoredProcedure [dbo].[CLEAR_ATTENDANCE]    Script Date: 5/10/2017 1:44:47 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[CLEAR_ATTENDANCE]
AS
BEGIN
	TRUNCATE TABLE dbo.Attendance;
	TRUNCATE TABLE dbo.Interlocale_Attendance;
	TRUNCATE TABLE dbo.tempAttendance;
	TRUNCATE TABLE dbo.Gathering;
END




GO
/****** Object:  StoredProcedure [dbo].[CLEAR_DATA]    Script Date: 5/10/2017 1:44:47 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[CLEAR_DATA]
AS
BEGIN
	TRUNCATE TABLE dbo.Attendance
	TRUNCATE TABLE dbo.Gathering
	TRUNCATE TABLE dbo.Interlocale_Attendance
	TRUNCATE TABLE dbo.tempAttendance
	TRUNCATE TABLE dbo.System_Logs
END




GO
/****** Object:  StoredProcedure [dbo].[CLEAR_DATABASE]    Script Date: 5/10/2017 1:44:47 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[CLEAR_DATABASE]
AS
BEGIN
	DELETE FROM [dbo].Attendance

	DELETE FROM [dbo].Batches

	DELETE FROM [dbo].Brethren

	DELETE FROM [dbo].Committee

	DELETE FROM [dbo].Gathering

	DELETE FROM [dbo].Groupings

	DELETE FROM [dbo].Interlocale

	DELETE FROM [dbo].Locale

	DELETE FROM [dbo].System_Logs

	DELETE FROM [dbo].tempAttendance

END


GO
/****** Object:  StoredProcedure [dbo].[DELETE_BATCH]    Script Date: 5/10/2017 1:44:47 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[DELETE_BATCH]
(
	@BatchID int
)
AS
BEGIN
	DELETE FROM Batches
	WHERE Batch_ID = @BatchID
END





GO
/****** Object:  StoredProcedure [dbo].[DELETE_BRETHREN]    Script Date: 5/10/2017 1:44:47 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[DELETE_BRETHREN]
	-- Add the parameters for the stored procedure here
	@BrethrenID nvarchar(100)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	UPDATE Brethren SET is_deleted=1 WHERE brethren_id=@BrethrenID
END





GO
/****** Object:  StoredProcedure [dbo].[DELETE_COMMITTEE]    Script Date: 5/10/2017 1:44:47 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[DELETE_COMMITTEE]
	@CommitteeID int
AS
	UPDATE Committee SET is_deleted = 1 WHERE committee_id = @CommitteeID;
RETURN 0




GO
/****** Object:  StoredProcedure [dbo].[DELETE_GATHERING_TYPE]    Script Date: 5/10/2017 1:44:47 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[DELETE_GATHERING_TYPE]
	@Gathering_ID int
AS
BEGIN
	UPDATE Gathering_types SET is_deleted=1 WHERE gathering_id=@Gathering_ID
END


GO
/****** Object:  StoredProcedure [dbo].[DELETE_GROUPINGS]    Script Date: 5/10/2017 1:44:47 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[DELETE_GROUPINGS]
	@GroupId int
AS
	UPDATE Groupings SET is_deleted = 1 WHERE Group_Id = @GroupId;
RETURN 0




GO
/****** Object:  StoredProcedure [dbo].[DELETE_LOCALE]    Script Date: 5/10/2017 1:44:47 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[DELETE_LOCALE]
	@LocaleID int
AS
	UPDATE Locale SET is_deleted = 1 WHERE locale_id = @LocaleID
RETURN 0




GO
/****** Object:  StoredProcedure [dbo].[FILTER_BATCHES]    Script Date: 5/10/2017 1:44:47 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[FILTER_BATCHES]
	@GatheringType varchar(50)
AS 
BEGIN
	SELECT * 
	FROM Batches
	LEFT JOIN Gathering_types ON Gathering_types.gathering_id=Batches.gathering_id
	WHERE Gathering_types.gathering_code = @GatheringType
END





GO
/****** Object:  StoredProcedure [dbo].[GET_ATTENDANCE]    Script Date: 5/10/2017 1:44:47 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[GET_ATTENDANCE]
	/**@Gathering_Id varchar(55)**/
AS
BEGIN
	SELECT
		*
	FROM
		Attendance
END




GO
/****** Object:  StoredProcedure [dbo].[GET_BATCHES]    Script Date: 5/10/2017 1:44:47 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[GET_BATCHES]
AS 
BEGIN
	SELECT * 
	FROM Batches
	LEFT JOIN Gathering_types ON Gathering_types.gathering_id=Batches.gathering_id
END





GO
/****** Object:  StoredProcedure [dbo].[GET_BRETHREN]    Script Date: 5/10/2017 1:44:47 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- Batch submitted through debugger: SQLQuery8.sql|7|0|C:\Users\John\AppData\Local\Temp\~vs3654.sql
CREATE PROCEDURE [dbo].[GET_BRETHREN]
AS
BEGIN
	
	SET NOCOUNT ON;

    SELECT
	brethren_id,
	Church_Id,
	CONCAT(Firstname,' ', Lastname) AS BrethrenName,
	Image_Path,
	Sketch_Path,
	Firstname,
	Middlename,
	Lastname,
	Date_Baptism,
	Date_Birth,
	Gender,
	Civil_Status,
	Street,
	Brgy,
	City_Town,
	Province,
	Region,
	Employment,
	Phone_no,
	Contact_Person,
	Contact_Person_no,
	Status,
	Remarks,
	b.Group_Id,
	Group_name,
	Committee_Names,
	l.locale_id,
	locale,
	Baptizer,
	(CASE WHEN is_contact_person_member = 1 THEN 'YES' ELSE 'NO' END) AS is_contact_person_member
	FROM 
	(Brethren as b
	LEFT JOIN Groupings as g ON b.Group_ID = g.Group_Id
	LEFT JOIN Locale as l ON b.locale_id = l.locale_id)
	WHERE b.is_deleted=0
END





GO
/****** Object:  StoredProcedure [dbo].[GET_BRETHREN_ADDRESS]    Script Date: 5/10/2017 1:44:47 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[GET_BRETHREN_ADDRESS]
AS
BEGIN
	SELECT
	* 
	FROM
	(SELECT
	distinct(Brgy + ' ' + City_Town + ' ' + Province) as address
	FROM Brethren) AS a
	WHERE a.address != ''
END


GO
/****** Object:  StoredProcedure [dbo].[GET_BRETHREN_BY_COMMITTEE]    Script Date: 5/10/2017 1:44:47 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[GET_BRETHREN_BY_COMMITTEE]
	@Committee_name varchar(50)
AS
BEGIN
	SELECT
	brethren_id,
	Church_Id,
	CONCAT(Firstname,' ', Lastname) AS BrethrenName,
	Image_Path,
	Sketch_Path,
	Firstname,
	Middlename,
	Lastname,
	Date_Baptism,
	Date_Birth,
	Gender,
	Civil_Status,
	Street,
	Brgy,
	City_Town,
	Province,
	Region,
	Employment,
	Phone_no,
	Contact_Person,
	Contact_Person_no,
	Status,
	Remarks,
	b.Group_Id,
	Group_name,
	Committee_Names,
	l.locale_id,
	locale,
	Baptizer,
	(CASE WHEN is_contact_person_member = 1 THEN 'YES' ELSE 'NO' END) AS is_contact_person_member
	FROM 
	(Brethren as b
	LEFT JOIN Groupings as g ON b.Group_ID = g.Group_Id
	LEFT JOIN Locale as l ON b.locale_id = l.locale_id)
	WHERE b.is_deleted=0
	AND b.Committee_Names LIKE '%'+@Committee_name+'%'
END


GO
/****** Object:  StoredProcedure [dbo].[GET_CELEBRANTS]    Script Date: 5/10/2017 1:44:47 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[GET_CELEBRANTS]
AS
BEGIN
	SELECT
	brethren_id,
	Church_Id,
	CONCAT(Firstname,' ', Lastname) AS BrethrenName,
	Image_Path,
	Sketch_Path,
	Firstname,
	Middlename,
	Lastname,
	CONVERT(varchar(12),Date_Baptism,106) AS Date_Baptism,
	CONVERT(varchar(12),Date_Birth,106) AS Date_Birth,
	CONCAT(DATEDIFF(YEAR, Date_Baptism, GETDATE()),' YEAR(S)') AS Age_Church,
	Gender,
	Civil_Status,
	Street,
	Brgy,
	City_Town,
	Province,
	Region,
	Employment,
	Phone_no,
	Contact_Person,
	Contact_Person_no,
	Status,
	Remarks,
	b.Group_Id,
	Group_name,
	Committee_Names,
	l.locale_id,
	locale,
	Baptizer,
	(CASE WHEN is_contact_person_member = 1 THEN 'YES' ELSE 'NO' END) AS is_contact_person_member
	FROM 
	(Brethren as b
	LEFT JOIN Groupings as g ON b.Group_ID = g.Group_Id
	LEFT JOIN Locale as l ON b.locale_id = l.locale_id)
	WHERE b.is_deleted=0
	AND MONTH(b.Date_Baptism) = MONTH(GETDATE())
END


GO
/****** Object:  StoredProcedure [dbo].[GET_COMMITTEE]    Script Date: 5/10/2017 1:44:47 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[GET_COMMITTEE]
AS
	SELECT * 
	FROM Committee 
	WHERE is_deleted = 0
RETURN




GO
/****** Object:  StoredProcedure [dbo].[GET_COMMITTEE_COUNT]    Script Date: 5/10/2017 1:44:47 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[GET_COMMITTEE_COUNT]
	
AS
BEGIN
	SELECT
	bc.Committee_Names AS Description,
	COUNT(Committee_Names) as Counter
	FROM
	(SELECT BrethrenName,
	LTRIM(RTRIM(m.n.value('.[1]','varchar(8000)'))) AS Committee_Names
	FROM
	(
	SELECT CONCAT(Firstname,' ',Lastname) AS BrethrenName,
	CAST('<XMLRoot><RowData>' + REPLACE(ISNULL(NULLIF(Committee_Names, ''),'NO COMMITTEE'),', ','</RowData><RowData>') + '</RowData></XMLRoot>' AS XML) AS x
	FROM Brethren
	) b
	CROSS APPLY x.nodes('/XMLRoot/RowData')m(n)) bc
	GROUP BY bc.Committee_Names
END


GO
/****** Object:  StoredProcedure [dbo].[GET_CURRENT_ATTENDANCE]    Script Date: 5/10/2017 1:44:47 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[GET_CURRENT_ATTENDANCE]
	@Filter varchar(55)
AS
BEGIN
	TRUNCATE TABLE dbo.tempAttendance;
	INSERT INTO dbo.tempAttendance
	(
		tempGathering_ID,
		temp_brethren_id,
		tempChurch_ID,
		tempAttendance_Status,
		tempReal_Time,
		is_interlocale,
		remarks
	)
	SELECT
		Gathering_ID,
		brethren_id,
		Church_ID,
		Attendance_Status,
		Real_Time,
		is_interlocale,
		remarks
	FROM Attendance
	WHERE Gathering_ID = @Filter;
	DELETE FROM dbo.Attendance WHERE Gathering_ID = @Filter;
END




GO
/****** Object:  StoredProcedure [dbo].[GET_GATHERING_TYPES]    Script Date: 5/10/2017 1:44:47 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[GET_GATHERING_TYPES]
AS
BEGIN
	SELECT * FROM Gathering_types
	WHERE is_deleted=0
END


GO
/****** Object:  StoredProcedure [dbo].[GET_GATHERINGS]    Script Date: 5/10/2017 1:44:47 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[GET_GATHERINGS]
AS
BEGIN
	
	SELECT 
	g.Gathering_Id,
	gt.gathering AS Gathering_Type,
	CONCAT(Gathering_Month, '/', Gathering_Date, '/', Gathering_Year) AS DateOfGathering,
	Gathering_Month,
	Gathering_Date,
	Gathering_Year,
	Gathering_Week,
	Gathering_Date,
	Batch_Time,
	Gathering_Day
	FROM
	Gathering AS g
	LEFT JOIN Batches AS b ON b.Batch_ID = g.Batch_ID
	LEFT JOIN Gathering_types AS gt ON gt.gathering_id=g.Gathering_Type
END





GO
/****** Object:  StoredProcedure [dbo].[GET_GROUP_LIST]    Script Date: 5/10/2017 1:44:47 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[GET_GROUP_LIST]
	@Group_name varchar(50)
AS
BEGIN
	SELECT
	x.*
	FROM
	(SELECT 
	b.Status,
	b.Church_Id,
	CONCAT(gs.Firstname,' ', gs.Lastname) AS Group_servant,
	CONCAT(ags.Firstname,' ', ags.Lastname) AS Asst_servant,
	gr.*,
	CONCAT(b.Firstname, ' ', b.Middlename, ' ', b.Lastname) AS BrethrenName
	FROM Brethren AS b
	LEFT JOIN Groupings AS gr ON gr.Group_Id=b.Group_ID
	INNER JOIN Brethren AS gs ON gs.brethren_id=gr.servant_id
	INNER JOIN Brethren AS ags ON ags.brethren_id=gr.asst_servant_id
	WHERE gr.Group_name=@Group_name AND b.brethren_id != gr.servant_id AND b.brethren_id != gr.asst_servant_id) AS x
	ORDER BY x.BrethrenName
END


GO
/****** Object:  StoredProcedure [dbo].[GET_GROUPINGS]    Script Date: 5/10/2017 1:44:47 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[GET_GROUPINGS]
AS
BEGIN
	SELECT
	Groupings.Group_Id,
	Group_name,
	servant_id,
	asst_servant_id,
	CONCAT(gs.Firstname,' ', gs.Lastname) AS Group_servant,
	CONCAT(ags.Firstname,' ', ags.Lastname) AS Asst_servant
	FROM
	Groupings
	INNER JOIN Brethren AS gs ON Groupings.servant_id=gs.brethren_id
	INNER JOIN Brethren AS ags ON Groupings.asst_servant_id=ags.brethren_id
	WHERE Groupings.is_deleted=0
END




GO
/****** Object:  StoredProcedure [dbo].[GET_INTERLOCALE]    Script Date: 5/10/2017 1:44:47 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[GET_INTERLOCALE]
AS
BEGIN
	SELECT 
	* 
	FROM 
	Interlocale
END





GO
/****** Object:  StoredProcedure [dbo].[GET_INTERLOCALE_ATTENDANCE]    Script Date: 5/10/2017 1:44:47 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[GET_INTERLOCALE_ATTENDANCE]
	@Gathering_Code varchar(50),
	@Date date,
	@Locale varchar(50)
AS
BEGIN
	SELECT
	i.Interlocale_Id AS temp_brethren_id,
	a.Attendance_Id,
	a.Gathering_ID,
	a.is_interlocale AS tempChurch_ID,
	a.Church_ID,
	(CASE 
	WHEN a.Attendance_Status = 1 
	THEN 'TIMED IN' 
	ELSE 'LATE' 
	END) AS tempAttendance_Status,
	CONCAT(i.Firstname,' ',i.Lastname) AS Interlocale_name,
	i.Locale,
	a.Real_Time,
	a.remarks,
	g.Gathering_Type,
	gt.*,
	REPLACE(REPLACE(RIGHT('0'+LTRIM(RIGHT(CONVERT(varchar,Real_Time,100),7)),7),'AM',' AM'),'PM',' PM') AS time_in,
	CONCAT(bat.batch_time, ' BATCH') AS batch_time_lbl,
	REPLACE(REPLACE(RIGHT('0'+LTRIM(RIGHT(CONVERT(varchar,bat.Batch_Time,100),7)),7),'AM',' AM'),'PM',' PM') AS Batch_Time
	FROM Attendance AS a
	LEFT JOIN Interlocale AS i ON i.Interlocale_Id = a.brethren_id
	LEFT JOIN Brethren AS b ON b.brethren_id= a.brethren_id
	LEFT JOIN (SELECT
		Gathering.*,
		Cast(CONCAT(Gathering_Year,'-',Gathering_Month,'-',Gathering_Date) AS date) AS DateOfGathering
	FROM dbo.Gathering) AS g ON g.Gathering_Id=a.Gathering_ID
	LEFT JOIN Gathering_types AS gt ON gt.gathering_id = g.Gathering_Type
	LEFT JOIN (SELECT Batches.Batch_ID, RIGHT(CONVERT(CHAR(20), Batch_Time, 22), 11) AS batch_time FROM Batches) AS bat ON bat.Batch_ID=g.Batch_ID
	WHERE 
	gt.gathering_code = @Gathering_Code
	AND i.Locale=@Locale
	AND g.DateOfGathering = @Date
	AND a.is_interlocale=1
END


GO
/****** Object:  StoredProcedure [dbo].[GET_INTERLOCALE_LOCALE]    Script Date: 5/10/2017 1:44:47 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[GET_INTERLOCALE_LOCALE]
AS
BEGIN
	SELECT DISTINCT(Locale) AS Locale FROM Interlocale
END


GO
/****** Object:  StoredProcedure [dbo].[GET_LOCALE]    Script Date: 5/10/2017 1:44:47 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[GET_LOCALE]
AS
BEGIN
		SELECT * 
		FROM Locale	 
		WHERE is_deleted = 0
END




GO
/****** Object:  StoredProcedure [dbo].[GET_NEWLY_BAPTIZED]    Script Date: 5/10/2017 1:44:47 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[GET_NEWLY_BAPTIZED]
	
AS
BEGIN
	SELECT
	brethren_id,
	Church_Id,
	CONCAT(Firstname,' ', Lastname) AS BrethrenName,
	Image_Path,
	Sketch_Path,
	Firstname,
	Middlename,
	Lastname,
	CONVERT(varchar(12),Date_Baptism,106) AS Date_Baptism,
	CONVERT(varchar(12),Date_Birth,106) AS Date_Birth,
	DATEDIFF(MONTH, Date_Baptism, GETDATE()) AS Age_Church,
	Gender,
	Civil_Status,
	Street,
	Brgy,
	City_Town,
	Province,
	Region,
	Employment,
	Phone_no,
	Contact_Person,
	Contact_Person_no,
	Status,
	Remarks,
	b.Group_Id,
	Group_name,
	Committee_Names,
	l.locale_id,
	locale,
	Baptizer,
	(CASE WHEN is_contact_person_member = 1 THEN 'YES' ELSE 'NO' END) AS is_contact_person_member
	FROM 
	(Brethren as b
	LEFT JOIN Groupings as g ON b.Group_ID = g.Group_Id
	LEFT JOIN Locale as l ON b.locale_id = l.locale_id)
	WHERE b.is_deleted=0
	AND DATEDIFF(MONTH, Date_Baptism, GETDATE()) <= 6
END


GO
/****** Object:  StoredProcedure [dbo].[GET_SENIOR_CITIZEN_COUNT]    Script Date: 5/10/2017 1:44:47 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[GET_SENIOR_CITIZEN_COUNT]
	
AS
BEGIN
	SELECT
	Description = 'SENIOR CITIZEN',
	COUNT(age) AS Counter
	FROM
	(SELECT 
	CONCAT(Firstname,' ',Lastname) as brethren_name, 
	DATEDIFF(YEAR, Date_Birth, GETDATE()) AS age 
	FROM Brethren) BrethrenAge
	WHERE age > 59
END


GO
/****** Object:  StoredProcedure [dbo].[GET_STATUS_COUNT]    Script Date: 5/10/2017 1:44:47 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[GET_STATUS_COUNT]
AS
BEGIN
	SELECT
	*
	FROM
	(SELECT
		UPPER(Status) as Description,
		COUNT(Status) AS Counter
	FROM Brethren
	GROUP BY Status) AS status_count
	UNION
	(SELECT
	Description = 'SENIOR CITIZEN',
	COUNT(age) AS Counter
	FROM
	(SELECT 
	CONCAT(Firstname,' ',Lastname) as brethren_name, 
	DATEDIFF(YEAR, Date_Birth, GETDATE()) AS age 
	FROM Brethren) BrethrenAge
	WHERE age > 59)
END




GO
/****** Object:  StoredProcedure [dbo].[GET_SYSTEM_LOGS]    Script Date: 5/10/2017 1:44:47 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[GET_SYSTEM_LOGS]
	@User_Priv int = null,
	@User_id int = null,
	@StartDate date,
	@EndDate date
AS
BEGIN
	IF (@User_Priv = 0) 
		SELECT
			CONCAT(u.fname, ' ', u.lname) AS Username,
			sl.Activity,
			sl.Date,
			REPLACE(REPLACE(RIGHT('0'+LTRIM(RIGHT(CONVERT(varchar,sl.Time,100),7)),7),'AM',' AM'),'PM',' PM') AS Time,
			sl.Module,
			(CASE 
			WHEN sl.Activity_Status = 1 THEN
			'Success Log'
			WHEN sl.Activity_Status = 2 THEN
			'Attempts Log'
			ELSE
			'Error Log' END) AS Activity_Status
		FROM
		System_Logs AS sl
		LEFT JOIN Users AS u ON u.user_id = sl.user_id
		WHERE sl.Date BETWEEN @StartDate AND @EndDate;
	ELSE
		SELECT
			CONCAT(u.fname, ' ', u.lname) AS Username,
			sl.Activity,
			sl.Date,
			sl.Time,
			sl.Module,
			(CASE 
			WHEN sl.Activity_Status = 1 THEN
			'Success Log'
			WHEN sl.Activity_Status = 2 THEN
			'Attempts Log'
			ELSE
			'Error Log' END) AS Activity_Status
		FROM
		System_Logs AS sl
		LEFT JOIN Users AS u ON u.user_id = sl.user_id
		WHERE u.user_id = @User_id AND sl.Date BETWEEN @StartDate AND @EndDate;
END



GO
/****** Object:  StoredProcedure [dbo].[GET_TEMP_ATTENDANCE]    Script Date: 5/10/2017 1:44:47 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[GET_TEMP_ATTENDANCE]
AS
BEGIN
	SELECT
		(CASE 
		WHEN ta.is_interlocale = 1 
		THEN i.Interlocale_Id
		WHEN ta.is_interlocale = 0 
		THEN b.brethren_id 
		END) AS temp_brethren_id,
		tempAttendance_Id,
		tempGathering_ID,
		IIF(ta.is_interlocale=1, i.Church_Id, b.Church_Id) AS tempChurch_ID,
		(CASE 
		WHEN tempAttendance_Status = 1 
		THEN 'TIMED IN' 
		ELSE 'LATE' 
		END) AS tempAttendance_Status,
		(CASE 
		WHEN ta.is_interlocale = 1 
		THEN CONCAT(i.Firstname,' ',i.Lastname) 
		WHEN ta.is_interlocale = 0 
		THEN CONCAT(b.Firstname,' ',b.Lastname) 
		END) AS Name,
		(CASE WHEN is_interlocale = 1
		THEN 'YES' WHEN is_interlocale = 0 THEN 'NO' END) AS is_interlocale,
		tempReal_Time,
		ta.remarks,
		gt.gathering
	FROM tempAttendance AS ta
	LEFT JOIN Interlocale AS i ON i.Interlocale_Id = ta.temp_brethren_id
	LEFT JOIN Brethren AS b ON b.brethren_id=ta.temp_brethren_id
	LEFT JOIN Gathering AS g ON g.Gathering_Id = ta.tempGathering_ID
	LEFT JOIN Gathering_types AS gt ON gt.gathering_id = g.Gathering_Type;
END




GO
/****** Object:  StoredProcedure [dbo].[GET_USER_INFO]    Script Date: 5/10/2017 1:44:47 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[GET_USER_INFO]
	-- Add the parameters for the stored procedure here
	@ChurchID VARCHAR(50),
	@Password VARCHAR(50)
AS
BEGIN
	SELECT
	user_id,
	church_id,
	fname,
	mname,
	lname,
	CONCAT(fname,' ',mname,' ',lname) AS fullname, 
	privilege,
	Users.locale_id,
	locale,
	user_img_path
	FROM
	Users
	INNER JOIN 
	Locale
	ON 
	Users.locale_id = Locale.locale_id
	WHERE 
	church_id = @ChurchID
	AND password = @Password
END





GO
/****** Object:  StoredProcedure [dbo].[GET_USERS]    Script Date: 5/10/2017 1:44:47 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[GET_USERS]
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

   SELECT
	user_id,
	church_id,
	fname,
	mname,
	lname,
	CONCAT(fname,' ',mname,' ',lname) AS fullname, 
	privilege,
	(CASE privilege 
	WHEN 1 THEN 'Admin' 
	WHEN 2 THEN 'Secretary' 
	WHEN 3 THEN 'Worker' 
	WHEN 4 THEN 'Officer' 
	END) AS privilege_desc,
	Users.locale_id,
	locale,
	(CASE is_approve WHEN 1 THEN 'YES' ELSE 'NO' END) AS status
	FROM
	Users
	INNER JOIN 
	Locale
	ON 
	Users.locale_id = Locale.locale_id
END





GO
/****** Object:  StoredProcedure [dbo].[INSERT_ATTENDANCE]    Script Date: 5/10/2017 1:44:47 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[INSERT_ATTENDANCE]
AS
BEGIN
	INSERT INTO dbo.Attendance
	(
		Gathering_ID,
		brethren_id,
		Church_ID,
		Attendance_Status,
		Real_Time,
		is_interlocale,
		remarks
	)
	SELECT
		tempGathering_ID,
		temp_brethren_id,
		tempChurch_ID,
		tempAttendance_Status,
		tempReal_Time,
		is_interlocale,
		remarks
	FROM tempAttendance;

	TRUNCATE TABLE tempAttendance;
END




GO
/****** Object:  StoredProcedure [dbo].[INSERT_BATCH]    Script Date: 5/10/2017 1:44:47 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[INSERT_BATCH]
(
	@Batch_Code varchar(50),
	@Gathering_ID int,
	@BatchTime time(7)
)
AS
BEGIN
	INSERT 
	INTO Batches
	(
		Batch_Code,
		gathering_id,
		Batch_Time
	) 
	VALUES
	(
		
		@Batch_Code,
		@Gathering_ID,
		@BatchTime
	)
END





GO
/****** Object:  StoredProcedure [dbo].[INSERT_BRETHREN]    Script Date: 5/10/2017 1:44:47 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[INSERT_BRETHREN]
	-- Add the parameters for the stored procedure here
	@BrethrenID nvarchar(100),
	@ChurchID varchar(50),
	@Firstname varchar(50),
	@Middlename varchar(50) = NULL,
	@Lastname varchar(50),
	@Sketch_Path varchar(MAX) = NULL,
	@Image_Path varchar(300) = NULL,
	@GroupID int = 0,
	@DateOfBaptism date = NULL,
	@DateOfBirth date = NULL,
	@Gender varchar(50),
	@CivilStatus varchar(50) = NULL,
	@Street varchar(50) = NULL,
	@Brgy varchar(50) = NULL,
	@CityTown varchar(50) = NULL,
	@Province varchar(50) = NULL,
	@Region varchar(50) = NULL,
	@Employment varchar(50) = NULL,
	@PhoneNo varchar(50) = NULL,
	@ContactPerson varchar(50) = NULL,
	@ContactPersonNo varchar(50) = NULL,
	@Status varchar(50) = NULL,
	@Remarks varchar(140) = NULL,
	@Committee_Names varchar(250) = NULL,
	@locale_id int = 0,
	@Baptizer varchar(50) = NULL,
	@is_contact_person_member tinyint
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

	INSERT INTO Brethren
	(
		brethren_id,
		Church_Id,
		Firstname,
		Middlename,
		Lastname,
		Image_Path,
		Sketch_Path,
		Group_ID,
		Date_Baptism,
		Date_Birth,
		Gender,
		Civil_Status,
		Street,
		Brgy,
		City_Town,
		Province,
		Region,
		Employment,
		Phone_no,
		Contact_Person,
		Contact_Person_no,
		Status,
		Remarks,
		Committee_Names,
		locale_id,
		Baptizer,
		is_contact_person_member
	) 
	VALUES
	(
		@BrethrenID,
		@ChurchID,
		@Firstname,
		@Middlename,
		@Lastname,
		@Image_Path,
		@Sketch_Path,
		@GroupID,
		@DateOfBaptism,
		@DateOfBirth,
		@Gender,
		@CivilStatus,
		@Street,
		@Brgy,
		@CityTown,
		@Province,
		@Region,
		@Employment,
		@PhoneNo,
		@ContactPerson,
		@ContactPersonNo,
		@Status,
		@Remarks,
		@Committee_Names,
		@locale_id,
		@Baptizer,
		@is_contact_person_member
	)
END





GO
/****** Object:  StoredProcedure [dbo].[INSERT_COMMITTEE]    Script Date: 5/10/2017 1:44:47 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[INSERT_COMMITTEE]
	@CommitteCode varchar(50),
	@Committee varchar(50)
AS
	INSERT INTO Committee(committee_code,committee_name, is_deleted) 
	VALUES(@CommitteCode, @Committee, 0)
RETURN 0




GO
/****** Object:  StoredProcedure [dbo].[INSERT_GATHERING]    Script Date: 5/10/2017 1:44:47 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[INSERT_GATHERING]
	@GatheringId VARCHAR(100),
	@GatheringType VARCHAR(50),
	@GatheringWeek VARCHAR(50),
	@GatheringMonth INT,
	@GatheringYear INT,
	@ViewingType VARCHAR(50),
	@GatheringDay VARCHAR(50),
	@Gathering_Date VARCHAR(50),
	@Batch_ID VARCHAR(50)
AS
BEGIN
	INSERT INTO Gathering
	(
		Gathering_Id,
		Gathering_Type,
		Gathering_Week,
		Gathering_Month,
		Gathering_Year,
		Viewing_Type,
		Gathering_Day,
		Gathering_Date,
		Batch_ID
	)
	VALUES
	(
		@GatheringId,
		@GatheringType,
		@GatheringWeek,
		@GatheringMonth,
		@GatheringYear,
		@ViewingType,
		@GatheringDay,
		@Gathering_Date,
		@Batch_ID
	)
END





GO
/****** Object:  StoredProcedure [dbo].[INSERT_GATHERING_TYPE]    Script Date: 5/10/2017 1:44:47 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[INSERT_GATHERING_TYPE]
	@GatheringCode varchar(50),
	@Gathering varchar(150)
AS
BEGIN
	INSERT INTO Gathering_types(gathering_code,gathering) VALUES(@GatheringCode,@Gathering)
END


GO
/****** Object:  StoredProcedure [dbo].[INSERT_GROUP]    Script Date: 5/10/2017 1:44:47 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[INSERT_GROUP]
	@Groupname varchar(50),
	@Servant_Id nvarchar(50),
	@Asst_servant_Id nvarchar(50)
AS
BEGIN
	INSERT 
	INTO Groupings(Group_name, servant_id, asst_servant_id, is_deleted) 
	VALUES(@Groupname, @Servant_Id, @Asst_servant_Id,0)
END




GO
/****** Object:  StoredProcedure [dbo].[INSERT_GROUP_SERVANTS]    Script Date: 5/10/2017 1:44:47 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[INSERT_GROUP_SERVANTS]
	@Group_Id int,
	@Group_servant_id int,
	@Asst_servant_id int
AS
BEGIN
	DELETE 
	FROM Group_servants 
	WHERE group_id = @Group_Id

	INSERT INTO 
	Group_servants
	(
		servant_id, 
		asst_servant_id, 
		group_id
	) VALUES
	(
		@Group_servant_id,
		@Asst_servant_id,
		@Group_Id
	)
END


GO
/****** Object:  StoredProcedure [dbo].[INSERT_INTERLOCALE]    Script Date: 5/10/2017 1:44:47 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[INSERT_INTERLOCALE]
	@Interlocale_ID nvarchar(100),
	@Church_Id varchar(50),
	@Firstname varchar(100),
	@Lastname varchar(100),
	@Locale varchar(50),
	@Middlename varchar(50),
	@DateOfBaptism date
AS
BEGIN
	INSERT INTO Interlocale
	(
		Interlocale_Id,
		Church_Id,
		Firstname,
		Middlename,
		Lastname,
		Locale,
		DateOfBaptism
	) VALUES 
	(
		@Interlocale_ID,
		@Church_Id,
		@Firstname,
		@Middlename,
		@Lastname,
		@Locale,
		@DateOfBaptism
	)
END





GO
/****** Object:  StoredProcedure [dbo].[INSERT_INTERLOCALE_ATTENDANCE]    Script Date: 5/10/2017 1:44:47 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[INSERT_INTERLOCALE_ATTENDANCE]
	@Interlocale_ID nvarchar(100),
	@Gathering_Id varchar(50)
AS
BEGIN
	INSERT INTO Interlocale_Attendance
	(
		Interlocale_ID,
		Gathering_Id
	) VALUES 
	(
		@Interlocale_ID,
		@Gathering_Id
	)
END





GO
/****** Object:  StoredProcedure [dbo].[INSERT_LOCALE]    Script Date: 5/10/2017 1:44:47 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[INSERT_LOCALE]
	@Locale varchar(50),
	@District varchar(50),
	@Division varchar(50),
	@Address varchar(200),
	@LocalCode varchar(50)
AS
	INSERT INTO Locale(locale,address,dist,div, locale_code,is_deleted) 
	VALUES(@Locale,@Address,@District,@Division,@LocalCode,0)
RETURN 0




GO
/****** Object:  StoredProcedure [dbo].[INSERT_LOG]    Script Date: 5/10/2017 1:44:47 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[INSERT_LOG]
	@user_id int,
	@activity varchar(300) = null,
	@date date = null,
	@time time(5) = null,
	@module varchar(150),
	@activity_status bit
AS
BEGIN
	INSERT INTO System_Logs
	(
		user_id,
		Activity,
		Date,
		Time,
		Module,
		Activity_Status
	) VALUES
	(
		@user_id,
		@activity,
		@date,
		@time,
		@module,
		@activity_status
	)
END




GO
/****** Object:  StoredProcedure [dbo].[INSERT_TEMP_ATTENDANCE]    Script Date: 5/10/2017 1:44:47 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[INSERT_TEMP_ATTENDANCE]
	@tempGathering_ID varchar(50),
	@tempChurch_ID varchar(50),
	@tempAttendance_Status int,
	@tempReal_Time time(7),
	@is_interlocale bit,
	@remarks varchar(150),
	@temp_brethren_id nvarchar(100)
AS
BEGIN
	INSERT INTO tempAttendance
	(
		tempGathering_ID,
		tempChurch_ID,
		temp_brethren_id,
		tempAttendance_Status,
		tempReal_Time,
		is_interlocale,
		remarks
	)
	VALUES 
	(
		@tempGathering_ID,
		@tempChurch_ID,
		@temp_brethren_id,
		@tempAttendance_Status,
		@tempReal_Time,
		@is_interlocale,
		@remarks
	)
END





GO
/****** Object:  StoredProcedure [dbo].[INSERT_USER]    Script Date: 5/10/2017 1:44:47 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[INSERT_USER]
(
	@churchid varchar(50),
	@password varchar(50),
	@fname varchar(50),
	@mname varchar(50) null,
	@lname varchar(50),
	@privilege varchar(50),
	@locale_id int,
	@user_img_path varchar(max)
)
AS
BEGIN
	INSERT 
	INTO Users
	(
		church_id,
		password,
		fname,
		mname,
		lname,
		privilege,
		locale_id,
		is_deleted,
		is_approve,
		user_img_path
	) VALUES
	(
		@churchid,
		@password,
		@fname,
		@mname,
		@lname,
		(CASE @privilege 
		WHEN 'Administrator' THEN 1
		WHEN 'Secretary' THEN 2
		WHEN 'Worker' THEN 3
		WHEN 'Officer' THEN 4 END),
		@locale_id,
		0,
		0,
		@user_img_path
	)
END




GO
/****** Object:  StoredProcedure [dbo].[UPDATE_BATCH]    Script Date: 5/10/2017 1:44:47 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[UPDATE_BATCH]
(
	@BatchID int,
	@Batch_Code varchar(50),
	@Gathering_ID int,
	@Batch_Time time(7)
)
AS
BEGIN
	UPDATE Batches
	SET Batch_Code = @Batch_Code,
		Batch_Time = @Batch_Time,
		gathering_id = @Gathering_ID
	WHERE Batch_ID = @BatchID
END





GO
/****** Object:  StoredProcedure [dbo].[UPDATE_BRETHREN]    Script Date: 5/10/2017 1:44:47 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[UPDATE_BRETHREN]
	@BrethrenID nvarchar(100),
	@ChurchID varchar(50),
	@Firstname varchar(50),
	@Middlename varchar(50) = NULL,
	@Lastname varchar(50),
	@Image_Path varchar(300) = NULL,
	@Sketch_Path varchar(max) = null,
	@GroupID int = 0,
	@DateOfBaptism date,
	@DateOfBirth date = NULL,
	@Gender varchar(50),
	@CivilStatus varchar(50) = NULL,
	@Street varchar(50) = NULL,
	@Brgy varchar(50) = NULL,
	@CityTown varchar(50) = NULL,
	@Province varchar(50) = NULL,
	@Region varchar(50) = NULL,
	@Employment varchar(50) = NULL,
	@PhoneNo varchar(50) = NULL,
	@ContactPerson varchar(50) = NULL,
	@ContactPersonNo varchar(50) = NULL,
	@Status varchar(50) = NULL,
	@Remarks varchar(140) = NULL,
	@Committee_Names varchar(250) = NULL,
	@locale_id int = 0,
	@Baptizer varchar(50) = NULL,
	@is_contact_person_member tinyint
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

	UPDATE Brethren
	SET
		Church_Id=@ChurchID,
		Firstname=@Firstname,
		Middlename=@Middlename,
		Lastname=@Lastname,
		Image_Path=@Image_Path,
		Sketch_Path=@Sketch_Path,
		Group_ID=@GroupID,
		Date_Baptism=@DateOfBaptism,
		Date_Birth=@DateOfBirth,
		Gender=@Gender,
		Civil_Status=@CivilStatus,
		Street=@Street,
		Brgy=@Brgy,
		City_Town=@CityTown,
		Province=@Province,
		Region=@Region,
		Employment=@Employment,
		Phone_no=@PhoneNo,
		Contact_Person=@ContactPerson,
		Contact_Person_no=@ContactPersonNo,
		Status=@Status,
		Remarks=@Remarks,
		Committee_Names=@Committee_Names,
		locale_id=@locale_id,
		Baptizer=@Baptizer,
		is_contact_person_member=@is_contact_person_member
	WHERE
		brethren_id = @BrethrenID
END





GO
/****** Object:  StoredProcedure [dbo].[UPDATE_COMMITTEE]    Script Date: 5/10/2017 1:44:47 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[UPDATE_COMMITTEE]
	@CommitteeCode varchar(50),
	@Committee varchar(50)
AS
	UPDATE Committee SET 
	committee_code=@CommitteeCode,committee_name=@Committee
	WHERE committee_code = @CommitteeCode
RETURN 0




GO
/****** Object:  StoredProcedure [dbo].[UPDATE_GATHERING_TYPE]    Script Date: 5/10/2017 1:44:47 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[UPDATE_GATHERING_TYPE]
	@Gathering_Type_ID int,
	@Gathering_Code varchar(55),
	@Gathering varchar(150)
AS
BEGIN
	UPDATE Gathering_types 
	SET 
	gathering_code=@Gathering_Code, 
	gathering=@Gathering
	WHERE gathering_id=@Gathering_Type_ID
END


GO
/****** Object:  StoredProcedure [dbo].[UPDATE_GROUP]    Script Date: 5/10/2017 1:44:47 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[UPDATE_GROUP]
	@GroupId int,
	@Groupname varchar(50),
	@Servant_Id varchar(50) = null,
	@Asst_servant_Id varchar(50) = null
AS
	UPDATE Groupings SET 
	Group_name=@Groupname, 
	servant_id=@Servant_Id,
	asst_servant_id=@Asst_servant_Id
	WHERE Group_Id = @GroupId
RETURN 0




GO
/****** Object:  StoredProcedure [dbo].[UPDATE_INTERLOCALE]    Script Date: 5/10/2017 1:44:47 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[UPDATE_INTERLOCALE]
	@Interlocale_Id nvarchar(100),
	@Church_Id varchar(50),
	@Firstname varchar(100),
	@Middlename varchar(100),
	@Lastname varchar(100),
	@Locale varchar(50),
	@DateOfBaptism date
AS
BEGIN
	UPDATE Interlocale
	SET	Church_Id = @Church_Id,
		Firstname = @Firstname,
		Middlename = @Middlename,
		Lastname = @Lastname,
		Locale = @Locale,
		DateOfBaptism = @DateOfBaptism
	WHERE Interlocale_Id = @Interlocale_Id
END





GO
/****** Object:  StoredProcedure [dbo].[UPDATE_LOCALE]    Script Date: 5/10/2017 1:44:47 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[UPDATE_LOCALE]
	@Locale varchar(50),
	@District varchar(50),
	@Division varchar(50),
	@Address varchar(200),
	@LocalCode varchar(50)
AS
	UPDATE Locale SET 
	locale=@Locale,address=@Address,dist=@District,div=@Division,locale_code=@LocalCode
	WHERE locale_code = @LocalCode
RETURN 0




GO
/****** Object:  StoredProcedure [dbo].[UPDATE_USER]    Script Date: 5/10/2017 1:44:47 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[UPDATE_USER]
(
	@user_id int,
	@churchid varchar(50),
	@password varchar(50),
	@fname varchar(50),
	@mname varchar(50) null,
	@lname varchar(50),
	@privilege varchar(50),
	@locale_id int,
	@user_img_path varchar(max)
)
AS
BEGIN
	UPDATE Users 
	SET
	church_id = @churchid,
	password = @password,
	fname = @fname,
	mname = @mname,
	lname = @lname,
	locale_id = @locale_id,
	user_img_path = @user_img_path
	WHERE
	user_id = @user_id
END





GO
/****** Object:  StoredProcedure [dbo].[USER_COUNT]    Script Date: 5/10/2017 1:44:47 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[USER_COUNT]
AS
BEGIN
	SELECT COUNT(*) FROM Users
END





GO
/****** Object:  StoredProcedure [dbo].[usp_SSRS_Attendance_Summary]    Script Date: 5/10/2017 1:44:47 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


--usp_SSRS_Attendance_Summary 2,2017,5
CREATE proc [dbo].[usp_SSRS_Attendance_Summary]
	@Gathering_Month int,
	@Gathering_Year int,
	@No_of_absence int
AS
BEGIN

----------------- populate temp table
IF OBJECT_ID('tempdb.dbo.#temp', 'U') IS NOT NULL 
  DROP TABLE #temp

CREATE table #temp
(
	[Gathering_Week] [nvarchar](50) NOT NULL,
	[Gathering_Month] [int] NOT NULL,
	[Gathering_Year] [int] NOT NULL,
	[no_gathering]  [int] NOT NULL,
	[brethren_id] [nvarchar] (100) NOT NULL
)

DECLARE --@Gathering_Year as INT, @Gathering_Month as INT, 
@Gathering_Week nvarchar(50),@no_gathering as INT

DECLARE @Gathering as CURSOR;

SET @Gathering = CURSOR FOR
select Gathering_Year,Gathering_Month,Gathering_Week,COUNT(*) as no_gathering 
from (
		select distinct Gathering_Type,Gathering_Year,Gathering_Month,Gathering_Week
		from Gathering
		where
			Gathering_Year = @Gathering_Year
			and Gathering_Month = @Gathering_Month
	 ) t1
group by Gathering_Year,Gathering_Month,Gathering_Week

OPEN @Gathering
FETCH NEXT FROM @Gathering INTO @Gathering_Year, @Gathering_Month, @Gathering_Week, @no_gathering

WHILE @@FETCH_STATUS = 0
BEGIN
	insert #temp(Gathering_Year,Gathering_Month,Gathering_Week,no_gathering,brethren_id)
	select @Gathering_Year as Gathering_Year , @Gathering_Month as Gathering_Month, @Gathering_Week as Gathering_Week, @no_gathering as no_gathering , brethren_id 
	from Brethren
 FETCH NEXT FROM @Gathering INTO @Gathering_Year, @Gathering_Month, @Gathering_Week, @no_gathering
END

CLOSE @Gathering
DEALLOCATE @Gathering

----------------


select * from (
	
	select t1.Gathering_Year,t1.Gathering_Month,t1.Gathering_Week,t1.brethren_id,
		t3.Firstname +' '+ t3.Lastname as BrethrenName,no_gathering,isnull(no_presents,0) as no_presents,
		no_gathering - isnull(no_presents,0) as no_absences,
		SUM(no_gathering - isnull(no_presents,0)) over(partition by t1.brethren_id) as total_absences
	from #temp t1
	left join (
				select t2.Gathering_Year,t2.Gathering_Month,t2.Gathering_Week,t1.brethren_id, 
					COUNT(*) no_presents 
				from attendance t1
				left join gathering t2 
					on t1.gathering_Id = t2.gathering_Id
				group by t2.Gathering_Year,t2.Gathering_Month,t2.Gathering_Week,t1.brethren_id
				) t2
	on t1.Gathering_Year = t2.Gathering_Year
		and t1.Gathering_Month = t2.Gathering_Month
		and t1.Gathering_Week = t2.Gathering_Week
		and t1.brethren_id = t2.brethren_id
	left join Brethren t3
		on t1.brethren_id = t3.brethren_id
	group by
		t1.Gathering_Year,t1.Gathering_Month,t1.Gathering_Week,t1.brethren_id,
		t3.Firstname +' '+ t3.Lastname,no_gathering,isnull(no_presents,0)
	) data
where
	Gathering_Year = @Gathering_Year
	and Gathering_Month = @Gathering_Month
	and total_absences = @No_of_absence
order by BrethrenName,Gathering_Week asc


END





GO
/****** Object:  StoredProcedure [dbo].[usp_SSRS_Attendance_Summary_ODT]    Script Date: 5/10/2017 1:44:47 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


--usp_SSRS_Attendance_Summary_ODT '01/31/2017','02/28/2017',5,'porac'
CREATE proc [dbo].[usp_SSRS_Attendance_Summary_ODT]
	@from date, @to date,
	@No_of_absence int,
	@Address varchar(25)
AS
BEGIN

----------------- populate temp table
IF OBJECT_ID('tempdb.dbo.#temp', 'U') IS NOT NULL 
  DROP TABLE #temp

CREATE table #temp
(
	[Gathering_Week] [nvarchar](50) NOT NULL,
	[Gathering_Month] [int] NOT NULL,
	[Gathering_Year] [int] NOT NULL,
	[no_gathering]  [int] NOT NULL,
	[brethren_id] [nvarchar] (100) NOT NULL
)

DECLARE @Gathering_Year as INT, @Gathering_Month as INT, 
		@Gathering_Week nvarchar(50),@no_gathering as INT
		
DECLARE @Gathering as CURSOR;

SET @Gathering = CURSOR FOR
select Gathering_Year,Gathering_Month,Gathering_Week,COUNT(*) as no_gathering 
from (
		select distinct Gathering_Type,Gathering_Year,Gathering_Month,Gathering_Week
		from Gathering
		where
			CONVERT(date,cast(Gathering_Month as varchar(2))+'/'+Gathering_Date+'/'+cast(Gathering_Year as varchar(4))) between  @from and @to
	 ) t1
group by Gathering_Year,Gathering_Month,Gathering_Week

OPEN @Gathering
FETCH NEXT FROM @Gathering INTO @Gathering_Year, @Gathering_Month, @Gathering_Week, @no_gathering

WHILE @@FETCH_STATUS = 0
BEGIN
	insert #temp(Gathering_Year,Gathering_Month,Gathering_Week,no_gathering,brethren_id)
	select @Gathering_Year as Gathering_Year , @Gathering_Month as Gathering_Month, @Gathering_Week as Gathering_Week, @no_gathering as no_gathering , brethren_id 
	from Brethren
 FETCH NEXT FROM @Gathering INTO @Gathering_Year, @Gathering_Month, @Gathering_Week, @no_gathering
END

CLOSE @Gathering
DEALLOCATE @Gathering

----------------

select t1.brethren_id
		,t2.Church_Id
		,t2.Firstname +' '+ t2.Lastname as BrethrenName
		,t1.no_gathering
		,t1.no_presents
		,t1.total_absences
		,t2.Phone_no
		,t2.Province
		,t2.City_Town
		,t2.Brgy,Street
		,t2.Street + ' ' + t2.Brgy + ' ' + t2.City_Town + ' ' + t2.Province as Address
from (
	select 
		t1.brethren_id,
		sum(no_gathering) no_gathering ,sum(isnull(no_presents,0)) as no_presents,
		sum(no_gathering) - sum(isnull(no_presents,0)) as total_absences
	from #temp t1
	left join (
				select t2.Gathering_Year,t2.Gathering_Month,t2.Gathering_Week,t1.brethren_id, 
					COUNT(*) no_presents 
				from attendance t1
				left join gathering t2 
					on t1.gathering_Id = t2.gathering_Id
				group by t2.Gathering_Year,t2.Gathering_Month,t2.Gathering_Week,t1.brethren_id
				) t2
	on t1.Gathering_Year = t2.Gathering_Year
		and t1.Gathering_Month = t2.Gathering_Month
		and t1.Gathering_Week = t2.Gathering_Week
		and t1.brethren_id = t2.brethren_id
	group by
		t1.brethren_id
	) t1
left join Brethren t2
		on t1.brethren_id = t2.brethren_id
where 
	total_absences >= @No_of_absence
	and t2.Brgy + ' ' + t2.City_Town + ' ' + t2.Province  like '%'+@Address+'%'
	
order by t2.Province,t2.City_Town,Brgy,BrethrenName asc

END




GO
USE [master]
GO
ALTER DATABASE [AMSDB] SET  READ_WRITE 
GO
