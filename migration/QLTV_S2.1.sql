USE [master]
GO
/****** Object:  Database [QLTV]    Script Date: 6/14/2022 2:09:56 AM ******/
CREATE DATABASE [QLTV]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'QLTV', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\QLTV.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'QLTV_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\QLTV_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [QLTV] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [QLTV].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [QLTV] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [QLTV] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [QLTV] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [QLTV] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [QLTV] SET ARITHABORT OFF 
GO
ALTER DATABASE [QLTV] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [QLTV] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [QLTV] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [QLTV] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [QLTV] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [QLTV] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [QLTV] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [QLTV] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [QLTV] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [QLTV] SET  DISABLE_BROKER 
GO
ALTER DATABASE [QLTV] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [QLTV] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [QLTV] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [QLTV] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [QLTV] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [QLTV] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [QLTV] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [QLTV] SET RECOVERY FULL 
GO
ALTER DATABASE [QLTV] SET  MULTI_USER 
GO
ALTER DATABASE [QLTV] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [QLTV] SET DB_CHAINING OFF 
GO
ALTER DATABASE [QLTV] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [QLTV] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [QLTV] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [QLTV] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'QLTV', N'ON'
GO
ALTER DATABASE [QLTV] SET QUERY_STORE = OFF
GO
USE [QLTV]
GO
/****** Object:  User [u_librarian]    Script Date: 6/14/2022 2:09:56 AM ******/
CREATE USER [u_librarian] FOR LOGIN [u_librarian] WITH DEFAULT_SCHEMA=[dbo]
GO
/****** Object:  User [test_1]    Script Date: 6/14/2022 2:09:56 AM ******/
CREATE USER [test_1] FOR LOGIN [test_1] WITH DEFAULT_SCHEMA=[dbo]
GO
/****** Object:  User [sa_qltv]    Script Date: 6/14/2022 2:09:56 AM ******/
CREATE USER [sa_qltv] FOR LOGIN [sa_qltv] WITH DEFAULT_SCHEMA=[dbo]
GO
/****** Object:  User [login_1]    Script Date: 6/14/2022 2:09:56 AM ******/
CREATE USER [login_1] FOR LOGIN [login_1] WITH DEFAULT_SCHEMA=[dbo]
GO
/****** Object:  User [hello]    Script Date: 6/14/2022 2:09:56 AM ******/
CREATE USER [hello] FOR LOGIN [hello] WITH DEFAULT_SCHEMA=[dbo]
GO
/****** Object:  DatabaseRole [test_role_2]    Script Date: 6/14/2022 2:09:56 AM ******/
CREATE ROLE [test_role_2]
GO
/****** Object:  DatabaseRole [test_role_1]    Script Date: 6/14/2022 2:09:56 AM ******/
CREATE ROLE [test_role_1]
GO
/****** Object:  DatabaseRole [test_role]    Script Date: 6/14/2022 2:09:56 AM ******/
CREATE ROLE [test_role]
GO
/****** Object:  DatabaseRole [role_1]    Script Date: 6/14/2022 2:09:56 AM ******/
CREATE ROLE [role_1]
GO
/****** Object:  DatabaseRole [reader_manager]    Script Date: 6/14/2022 2:09:56 AM ******/
CREATE ROLE [reader_manager]
GO
/****** Object:  DatabaseRole [librarian_manager]    Script Date: 6/14/2022 2:09:56 AM ******/
CREATE ROLE [librarian_manager]
GO
/****** Object:  DatabaseRole [librarian]    Script Date: 6/14/2022 2:09:56 AM ******/
CREATE ROLE [librarian]
GO
/****** Object:  DatabaseRole [book_manager]    Script Date: 6/14/2022 2:09:56 AM ******/
CREATE ROLE [book_manager]
GO
ALTER ROLE [db_owner] ADD MEMBER [u_librarian]
GO
ALTER ROLE [test_role] ADD MEMBER [test_1]
GO
ALTER ROLE [db_owner] ADD MEMBER [sa_qltv]
GO
ALTER ROLE [test_role] ADD MEMBER [hello]
GO
ALTER ROLE [db_accessadmin] ADD MEMBER [librarian_manager]
GO
/****** Object:  Table [dbo].[Account]    Script Date: 6/14/2022 2:09:56 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Account](
	[Username] [nvarchar](50) NOT NULL,
	[PasswordDigest] [nvarchar](100) NOT NULL,
	[Enable] [bit] NOT NULL,
	[UserableId] [nchar](10) NOT NULL,
	[UserableType] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Account] PRIMARY KEY CLUSTERED 
(
	[Username] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Author]    Script Date: 6/14/2022 2:09:56 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Author](
	[Id] [nchar](10) NOT NULL,
	[FirstName] [nvarchar](30) NOT NULL,
	[LastName] [nvarchar](50) NOT NULL,
	[Address] [nvarchar](150) NOT NULL,
	[Sex] [bit] NOT NULL,
	[Email] [nvarchar](100) NOT NULL,
	[Birthday] [date] NOT NULL,
 CONSTRAINT [PK_Author] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Book]    Script Date: 6/14/2022 2:09:56 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Book](
	[Id] [nchar](10) NOT NULL,
	[Size] [smallint] NOT NULL,
	[Lending] [bit] NOT NULL,
	[Notes] [varchar](max) NOT NULL,
	[Status] [smallint] NOT NULL,
	[BookTitleISBN] [nchar](13) NOT NULL,
	[CaseId] [bigint] NOT NULL,
	[LibrarianId] [nchar](10) NOT NULL,
	[CreatedAt] [datetime] NOT NULL,
 CONSTRAINT [PK_Book] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[BookCase]    Script Date: 6/14/2022 2:09:56 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BookCase](
	[Id] [nchar](10) NOT NULL,
	[Description] [nvarchar](max) NOT NULL,
	[Size] [smallint] NOT NULL,
 CONSTRAINT [PK_BookCase] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[BookCategory]    Script Date: 6/14/2022 2:09:56 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BookCategory](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](100) NOT NULL,
 CONSTRAINT [PK_BookCategory] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[BookTitle]    Script Date: 6/14/2022 2:09:56 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BookTitle](
	[ISBN] [nchar](13) NOT NULL,
	[Name] [nvarchar](max) NOT NULL,
	[Pages] [int] NOT NULL,
	[Price] [money] NOT NULL,
	[ReleaseDate] [date] NOT NULL,
	[PublisherId] [nchar](10) NOT NULL,
 CONSTRAINT [PK_BookTitle] PRIMARY KEY CLUSTERED 
(
	[ISBN] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[BookTitle_Author]    Script Date: 6/14/2022 2:09:56 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BookTitle_Author](
	[BookTitleISBN] [nchar](13) NOT NULL,
	[AuthorId] [nchar](10) NOT NULL,
 CONSTRAINT [PK_BookTitle_Author] PRIMARY KEY CLUSTERED 
(
	[BookTitleISBN] ASC,
	[AuthorId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[BookTitle_BookCategory]    Script Date: 6/14/2022 2:09:56 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BookTitle_BookCategory](
	[BookTitleISBN] [nchar](13) NOT NULL,
	[BookCategoryId] [bigint] NOT NULL,
 CONSTRAINT [PK_BookTitle_BookCategory] PRIMARY KEY CLUSTERED 
(
	[BookTitleISBN] ASC,
	[BookCategoryId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Caze]    Script Date: 6/14/2022 2:09:56 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Caze](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[Number] [bigint] NOT NULL,
	[BookCaseId] [nchar](10) NOT NULL,
 CONSTRAINT [PK_Case_1] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LendingSlip]    Script Date: 6/14/2022 2:09:56 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LendingSlip](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[ReaderId] [nchar](10) NOT NULL,
	[CreatedByLibrarianId] [nchar](10) NOT NULL,
	[CreatedAt] [date] NOT NULL,
 CONSTRAINT [PK_LendingSlip] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LendingSlipDetail]    Script Date: 6/14/2022 2:09:56 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LendingSlipDetail](
	[BookId] [nchar](10) NOT NULL,
	[LendingSlipId] [bigint] NOT NULL,
	[DueBackDate] [datetime] NOT NULL,
	[BookStatus] [smallint] NULL,
	[Notes] [nvarchar](max) NULL,
	[TookBack] [bit] NULL,
	[TookBackAt] [datetime] NULL,
	[TookBackBy] [nchar](10) NULL,
	[Extended] [bit] NULL,
	[ExtendedBy] [nchar](10) NULL,
	[ExtendedAt] [nchar](10) NULL,
 CONSTRAINT [PK_LendingSlipDetail] PRIMARY KEY CLUSTERED 
(
	[BookId] ASC,
	[LendingSlipId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Librarian]    Script Date: 6/14/2022 2:09:56 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Librarian](
	[Id] [nchar](10) NOT NULL,
	[FirstName] [nvarchar](30) NOT NULL,
	[LastName] [nvarchar](50) NOT NULL,
	[Sex] [bit] NOT NULL,
	[Address] [nvarchar](150) NOT NULL,
	[Birthday] [date] NOT NULL,
	[Email] [nvarchar](100) NOT NULL,
 CONSTRAINT [PK_Librarian] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LibraryCard]    Script Date: 6/14/2022 2:09:56 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LibraryCard](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[EffectiveDate] [datetime] NOT NULL,
	[EffectiveEndDate] [datetime] NOT NULL,
	[Fee] [money] NOT NULL,
	[ReaderId] [nchar](10) NOT NULL,
	[CreatedBy] [nchar](10) NOT NULL,
	[CreatedAt] [datetime] NOT NULL,
 CONSTRAINT [PK_LibraryCard] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LiquidatingSlip]    Script Date: 6/14/2022 2:09:56 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LiquidatingSlip](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[CreatedAt] [datetime] NOT NULL,
	[CreatedBy] [nchar](10) NOT NULL,
 CONSTRAINT [PK_LiquidatingSlip] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LiquidatingSlipDetail]    Script Date: 6/14/2022 2:09:56 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LiquidatingSlipDetail](
	[BookId] [nchar](10) NOT NULL,
	[LiquidatingSlipId] [bigint] NOT NULL,
	[Price] [money] NOT NULL,
	[Notes] [nvarchar](max) NULL,
 CONSTRAINT [PK_LiquidatingSlipDetail_1] PRIMARY KEY CLUSTERED 
(
	[BookId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Publisher]    Script Date: 6/14/2022 2:09:56 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Publisher](
	[Id] [nchar](10) NOT NULL,
	[Name] [nvarchar](255) NOT NULL,
	[Address] [nvarchar](255) NOT NULL,
	[PhoneNumber] [nvarchar](20) NOT NULL,
	[Email] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Publisher] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Reader]    Script Date: 6/14/2022 2:09:56 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Reader](
	[Id] [nchar](10) NOT NULL,
	[FirstName] [nvarchar](30) NOT NULL,
	[LastName] [nvarchar](50) NOT NULL,
	[Sex] [bit] NOT NULL,
	[Address] [nvarchar](150) NOT NULL,
	[Birthday] [date] NOT NULL,
	[Email] [nvarchar](50) NOT NULL,
	[PhoneNumber] [nvarchar](20) NOT NULL,
	[LibrarianId] [nchar](10) NOT NULL,
 CONSTRAINT [PK_Reader] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[Account] ([Username], [PasswordDigest], [Enable], [UserableId], [UserableType]) VALUES (N'LB00000011', N'4XGEd+XH4D7roncNefbB72fCrA/Om91Zie9YYfMPmNI=', 1, N'LB00000011', N'Librarian')
INSERT [dbo].[Account] ([Username], [PasswordDigest], [Enable], [UserableId], [UserableType]) VALUES (N'LB00000014', N'4XGEd+XH4D7roncNefbB72fCrA/Om91Zie9YYfMPmNI=', 1, N'LB00000014', N'Librarian')
INSERT [dbo].[Account] ([Username], [PasswordDigest], [Enable], [UserableId], [UserableType]) VALUES (N'LB00000015', N'4XGEd+XH4D7roncNefbB72fCrA/Om91Zie9YYfMPmNI=', 1, N'LB00000015', N'Librarian')
INSERT [dbo].[Account] ([Username], [PasswordDigest], [Enable], [UserableId], [UserableType]) VALUES (N'LB00000016', N'4XGEd+XH4D7roncNefbB72fCrA/Om91Zie9YYfMPmNI=', 1, N'LB00000016', N'Librarian')
GO
INSERT [dbo].[Author] ([Id], [FirstName], [LastName], [Address], [Sex], [Email], [Birthday]) VALUES (N'AT00000002', N'Anh', N'Nguyễn Minh', N'TP Hồ Chí Minh', 1, N'minhanh@gmail.com', CAST(N'2001-01-01' AS Date))
INSERT [dbo].[Author] ([Id], [FirstName], [LastName], [Address], [Sex], [Email], [Birthday]) VALUES (N'AT00000003', N'Anh', N'Trần Minh', N'TP Hồ Chí Minh', 0, N'minhanh@gmail.com', CAST(N'2000-06-14' AS Date))
INSERT [dbo].[Author] ([Id], [FirstName], [LastName], [Address], [Sex], [Email], [Birthday]) VALUES (N'AT00000004', N'Thư', N'Lê Anh', N'TP Hà Nội', 0, N'anhthu@outlook.com', CAST(N'1999-02-01' AS Date))
INSERT [dbo].[Author] ([Id], [FirstName], [LastName], [Address], [Sex], [Email], [Birthday]) VALUES (N'AT00000005', N'Sơn', N'Lê Thanh', N'TP Hải Phòng', 1, N'thanhson@gmail.com', CAST(N'1998-05-17' AS Date))
INSERT [dbo].[Author] ([Id], [FirstName], [LastName], [Address], [Sex], [Email], [Birthday]) VALUES (N'AT00000006', N'Minh', N'Lý Nguyệt', N'Hồ Chí Minh', 1, N'nguyetminh@gmail.com', CAST(N'1999-08-05' AS Date))
GO
INSERT [dbo].[Book] ([Id], [Size], [Lending], [Notes], [Status], [BookTitleISBN], [CaseId], [LibrarianId], [CreatedAt]) VALUES (N'BK00000001', 1, 0, N'Ghi chú', 4, N'24254-34-34-2', 2, N'LB00000011', CAST(N'2022-05-17T21:28:59.433' AS DateTime))
INSERT [dbo].[Book] ([Id], [Size], [Lending], [Notes], [Status], [BookTitleISBN], [CaseId], [LibrarianId], [CreatedAt]) VALUES (N'BK00000002', 2, 0, N'Ghi chú', 4, N'99921-57-10-6', 7, N'LB00000011', CAST(N'2022-05-18T14:53:12.027' AS DateTime))
INSERT [dbo].[Book] ([Id], [Size], [Lending], [Notes], [Status], [BookTitleISBN], [CaseId], [LibrarianId], [CreatedAt]) VALUES (N'BK00000003', 2, 0, N'Ghi chu', 4, N'99921-58-10-7', 4, N'LB00000011', CAST(N'2022-05-18T14:53:42.360' AS DateTime))
INSERT [dbo].[Book] ([Id], [Size], [Lending], [Notes], [Status], [BookTitleISBN], [CaseId], [LibrarianId], [CreatedAt]) VALUES (N'BK00000004', 1, 0, N'Note', 4, N'99923-56-10-1', 2, N'LB00000011', CAST(N'2022-05-18T14:54:17.900' AS DateTime))
INSERT [dbo].[Book] ([Id], [Size], [Lending], [Notes], [Status], [BookTitleISBN], [CaseId], [LibrarianId], [CreatedAt]) VALUES (N'BK00000005', 1, 0, N'Notes', 4, N'99923-56-10-1', 2, N'LB00000011', CAST(N'2022-05-18T00:00:00.000' AS DateTime))
INSERT [dbo].[Book] ([Id], [Size], [Lending], [Notes], [Status], [BookTitleISBN], [CaseId], [LibrarianId], [CreatedAt]) VALUES (N'BK00000006', 1, 0, N'Notes', 1, N'99923-56-10-1', 2, N'LB00000011', CAST(N'2022-01-01T00:00:00.000' AS DateTime))
INSERT [dbo].[Book] ([Id], [Size], [Lending], [Notes], [Status], [BookTitleISBN], [CaseId], [LibrarianId], [CreatedAt]) VALUES (N'BK00000007', 1, 0, N'NOte', 1, N'24254-34-34-2', 2, N'LB00000011', CAST(N'2022-06-04T01:40:23.637' AS DateTime))
INSERT [dbo].[Book] ([Id], [Size], [Lending], [Notes], [Status], [BookTitleISBN], [CaseId], [LibrarianId], [CreatedAt]) VALUES (N'BK00000008', 1, 0, N'Note', 1, N'24254-34-34-2', 2, N'LB00000011', CAST(N'2022-06-04T01:48:10.433' AS DateTime))
INSERT [dbo].[Book] ([Id], [Size], [Lending], [Notes], [Status], [BookTitleISBN], [CaseId], [LibrarianId], [CreatedAt]) VALUES (N'BK00000009', 1, 0, N'không có ghi chú', 1, N'24254-34-34-2', 2, N'LB00000011', CAST(N'2022-06-06T01:53:16.417' AS DateTime))
INSERT [dbo].[Book] ([Id], [Size], [Lending], [Notes], [Status], [BookTitleISBN], [CaseId], [LibrarianId], [CreatedAt]) VALUES (N'BK00000011', 1, 0, N'Note', 1, N'24254-34-34-2', 2, N'LB00000011', CAST(N'2022-06-09T01:15:45.523' AS DateTime))
INSERT [dbo].[Book] ([Id], [Size], [Lending], [Notes], [Status], [BookTitleISBN], [CaseId], [LibrarianId], [CreatedAt]) VALUES (N'BK00000013', 1, 0, N'', 1, N'24254-34-34-2', 2, N'LB00000011', CAST(N'2022-06-11T18:34:25.133' AS DateTime))
INSERT [dbo].[Book] ([Id], [Size], [Lending], [Notes], [Status], [BookTitleISBN], [CaseId], [LibrarianId], [CreatedAt]) VALUES (N'BK00000014', 1, 0, N'', 1, N'24254-34-34-2', 2, N'LB00000011', CAST(N'2022-06-12T22:59:58.830' AS DateTime))
INSERT [dbo].[Book] ([Id], [Size], [Lending], [Notes], [Status], [BookTitleISBN], [CaseId], [LibrarianId], [CreatedAt]) VALUES (N'BK00000015', 1, 0, N'', 1, N'24254-34-34-2', 2, N'LB00000011', CAST(N'2022-06-12T23:24:20.250' AS DateTime))
INSERT [dbo].[Book] ([Id], [Size], [Lending], [Notes], [Status], [BookTitleISBN], [CaseId], [LibrarianId], [CreatedAt]) VALUES (N'BK00000016', 1, 0, N'', 1, N'24254-34-34-2', 2, N'LB00000011', CAST(N'2022-06-14T01:58:54.593' AS DateTime))
GO
INSERT [dbo].[BookCase] ([Id], [Description], [Size]) VALUES (N'BC00000001', N'Kệ tạp chí', 1)
INSERT [dbo].[BookCase] ([Id], [Description], [Size]) VALUES (N'BC00000002', N'Kệ sách khoa học', 1)
INSERT [dbo].[BookCase] ([Id], [Description], [Size]) VALUES (N'BC00000003', N'Kệ sách truyện tranh', 1)
INSERT [dbo].[BookCase] ([Id], [Description], [Size]) VALUES (N'BC00000004', N'Kệ sách truyện chữ', 1)
GO
SET IDENTITY_INSERT [dbo].[BookCategory] ON 

INSERT [dbo].[BookCategory] ([Id], [Name]) VALUES (6, N'Hài hước')
INSERT [dbo].[BookCategory] ([Id], [Name]) VALUES (1, N'Hành động')
INSERT [dbo].[BookCategory] ([Id], [Name]) VALUES (4, N'Khoa học')
INSERT [dbo].[BookCategory] ([Id], [Name]) VALUES (5, N'Lãng mạn')
INSERT [dbo].[BookCategory] ([Id], [Name]) VALUES (7, N'Nhân văn')
INSERT [dbo].[BookCategory] ([Id], [Name]) VALUES (8, N'Thiếu nhi')
INSERT [dbo].[BookCategory] ([Id], [Name]) VALUES (3, N'Tiểu Thuyết')
INSERT [dbo].[BookCategory] ([Id], [Name]) VALUES (2, N'Trinh Thám')
INSERT [dbo].[BookCategory] ([Id], [Name]) VALUES (9, N'Vật lý')
SET IDENTITY_INSERT [dbo].[BookCategory] OFF
GO
INSERT [dbo].[BookTitle] ([ISBN], [Name], [Pages], [Price], [ReleaseDate], [PublisherId]) VALUES (N'24254-34-34-2', N'Truyền thuyết Sili', 1000, 10000000.0000, CAST(N'2022-05-17' AS Date), N'PB00000002')
INSERT [dbo].[BookTitle] ([ISBN], [Name], [Pages], [Price], [ReleaseDate], [PublisherId]) VALUES (N'99921-57-10-6', N'Tháp Sili', 900, 900000.0000, CAST(N'2022-05-17' AS Date), N'PB00000003')
INSERT [dbo].[BookTitle] ([ISBN], [Name], [Pages], [Price], [ReleaseDate], [PublisherId]) VALUES (N'99921-58-10-7', N'Lịch sử Sili', 1000, 1000000.0000, CAST(N'2022-05-06' AS Date), N'PB00000002')
INSERT [dbo].[BookTitle] ([ISBN], [Name], [Pages], [Price], [ReleaseDate], [PublisherId]) VALUES (N'99923-56-10-1', N'Vịnh Sili', 650, 650000.0000, CAST(N'2022-05-17' AS Date), N'PB00000003')
INSERT [dbo].[BookTitle] ([ISBN], [Name], [Pages], [Price], [ReleaseDate], [PublisherId]) VALUES (N'99924-21-13-8', N'Văn hóa Sili', 789, 789000.0000, CAST(N'2022-05-17' AS Date), N'PB00000004')
INSERT [dbo].[BookTitle] ([ISBN], [Name], [Pages], [Price], [ReleaseDate], [PublisherId]) VALUES (N'99999-45-45-1', N'Truyền thuyết vị vua vĩ đại', 2000, 2000000.0000, CAST(N'2022-06-08' AS Date), N'PB00000001')
INSERT [dbo].[BookTitle] ([ISBN], [Name], [Pages], [Price], [ReleaseDate], [PublisherId]) VALUES (N'9999-99-99-9 ', N'Ume', 200, 500000.0000, CAST(N'2022-06-09' AS Date), N'PB00000001')
GO
INSERT [dbo].[BookTitle_Author] ([BookTitleISBN], [AuthorId]) VALUES (N'24254-34-34-2', N'AT00000002')
INSERT [dbo].[BookTitle_Author] ([BookTitleISBN], [AuthorId]) VALUES (N'99921-57-10-6', N'AT00000002')
INSERT [dbo].[BookTitle_Author] ([BookTitleISBN], [AuthorId]) VALUES (N'99921-58-10-7', N'AT00000002')
INSERT [dbo].[BookTitle_Author] ([BookTitleISBN], [AuthorId]) VALUES (N'99921-58-10-7', N'AT00000003')
INSERT [dbo].[BookTitle_Author] ([BookTitleISBN], [AuthorId]) VALUES (N'99921-58-10-7', N'AT00000004')
INSERT [dbo].[BookTitle_Author] ([BookTitleISBN], [AuthorId]) VALUES (N'99923-56-10-1', N'AT00000004')
INSERT [dbo].[BookTitle_Author] ([BookTitleISBN], [AuthorId]) VALUES (N'99924-21-13-8', N'AT00000004')
INSERT [dbo].[BookTitle_Author] ([BookTitleISBN], [AuthorId]) VALUES (N'99924-21-13-8', N'AT00000005')
INSERT [dbo].[BookTitle_Author] ([BookTitleISBN], [AuthorId]) VALUES (N'99999-45-45-1', N'AT00000002')
INSERT [dbo].[BookTitle_Author] ([BookTitleISBN], [AuthorId]) VALUES (N'99999-45-45-1', N'AT00000003')
INSERT [dbo].[BookTitle_Author] ([BookTitleISBN], [AuthorId]) VALUES (N'9999-99-99-9 ', N'AT00000002')
INSERT [dbo].[BookTitle_Author] ([BookTitleISBN], [AuthorId]) VALUES (N'9999-99-99-9 ', N'AT00000004')
INSERT [dbo].[BookTitle_Author] ([BookTitleISBN], [AuthorId]) VALUES (N'9999-99-99-9 ', N'AT00000006')
GO
INSERT [dbo].[BookTitle_BookCategory] ([BookTitleISBN], [BookCategoryId]) VALUES (N'24254-34-34-2', 4)
INSERT [dbo].[BookTitle_BookCategory] ([BookTitleISBN], [BookCategoryId]) VALUES (N'99921-57-10-6', 4)
INSERT [dbo].[BookTitle_BookCategory] ([BookTitleISBN], [BookCategoryId]) VALUES (N'99921-58-10-7', 1)
INSERT [dbo].[BookTitle_BookCategory] ([BookTitleISBN], [BookCategoryId]) VALUES (N'99921-58-10-7', 4)
INSERT [dbo].[BookTitle_BookCategory] ([BookTitleISBN], [BookCategoryId]) VALUES (N'99923-56-10-1', 4)
INSERT [dbo].[BookTitle_BookCategory] ([BookTitleISBN], [BookCategoryId]) VALUES (N'99924-21-13-8', 4)
INSERT [dbo].[BookTitle_BookCategory] ([BookTitleISBN], [BookCategoryId]) VALUES (N'99924-21-13-8', 7)
INSERT [dbo].[BookTitle_BookCategory] ([BookTitleISBN], [BookCategoryId]) VALUES (N'99999-45-45-1', 1)
INSERT [dbo].[BookTitle_BookCategory] ([BookTitleISBN], [BookCategoryId]) VALUES (N'99999-45-45-1', 6)
INSERT [dbo].[BookTitle_BookCategory] ([BookTitleISBN], [BookCategoryId]) VALUES (N'9999-99-99-9 ', 1)
INSERT [dbo].[BookTitle_BookCategory] ([BookTitleISBN], [BookCategoryId]) VALUES (N'9999-99-99-9 ', 4)
INSERT [dbo].[BookTitle_BookCategory] ([BookTitleISBN], [BookCategoryId]) VALUES (N'9999-99-99-9 ', 7)
GO
SET IDENTITY_INSERT [dbo].[Caze] ON 

INSERT [dbo].[Caze] ([Id], [Number], [BookCaseId]) VALUES (2, 1, N'BC00000001')
INSERT [dbo].[Caze] ([Id], [Number], [BookCaseId]) VALUES (4, 2, N'BC00000001')
INSERT [dbo].[Caze] ([Id], [Number], [BookCaseId]) VALUES (5, 3, N'BC00000001')
INSERT [dbo].[Caze] ([Id], [Number], [BookCaseId]) VALUES (6, 1, N'BC00000002')
INSERT [dbo].[Caze] ([Id], [Number], [BookCaseId]) VALUES (7, 2, N'BC00000002')
INSERT [dbo].[Caze] ([Id], [Number], [BookCaseId]) VALUES (8, 3, N'BC00000002')
INSERT [dbo].[Caze] ([Id], [Number], [BookCaseId]) VALUES (9, 4, N'BC00000002')
SET IDENTITY_INSERT [dbo].[Caze] OFF
GO
SET IDENTITY_INSERT [dbo].[LendingSlip] ON 

INSERT [dbo].[LendingSlip] ([Id], [ReaderId], [CreatedByLibrarianId], [CreatedAt]) VALUES (45, N'RD00000001', N'LB00000011', CAST(N'2022-06-07' AS Date))
INSERT [dbo].[LendingSlip] ([Id], [ReaderId], [CreatedByLibrarianId], [CreatedAt]) VALUES (46, N'RD00000001', N'LB00000011', CAST(N'2022-06-07' AS Date))
INSERT [dbo].[LendingSlip] ([Id], [ReaderId], [CreatedByLibrarianId], [CreatedAt]) VALUES (47, N'RD00000001', N'LB00000011', CAST(N'2022-06-07' AS Date))
INSERT [dbo].[LendingSlip] ([Id], [ReaderId], [CreatedByLibrarianId], [CreatedAt]) VALUES (48, N'RD00000001', N'LB00000011', CAST(N'2022-06-07' AS Date))
INSERT [dbo].[LendingSlip] ([Id], [ReaderId], [CreatedByLibrarianId], [CreatedAt]) VALUES (49, N'RD00000001', N'LB00000011', CAST(N'2022-06-07' AS Date))
INSERT [dbo].[LendingSlip] ([Id], [ReaderId], [CreatedByLibrarianId], [CreatedAt]) VALUES (50, N'RD00000001', N'LB00000011', CAST(N'2022-06-08' AS Date))
INSERT [dbo].[LendingSlip] ([Id], [ReaderId], [CreatedByLibrarianId], [CreatedAt]) VALUES (51, N'RD00000001', N'LB00000011', CAST(N'2022-06-12' AS Date))
SET IDENTITY_INSERT [dbo].[LendingSlip] OFF
GO
INSERT [dbo].[LendingSlipDetail] ([BookId], [LendingSlipId], [DueBackDate], [BookStatus], [Notes], [TookBack], [TookBackAt], [TookBackBy], [Extended], [ExtendedBy], [ExtendedAt]) VALUES (N'BK00000001', 45, CAST(N'2022-06-07T03:39:06.000' AS DateTime), NULL, N'', 1, CAST(N'2022-06-07T21:37:00.777' AS DateTime), N'LB00000011', 0, NULL, NULL)
INSERT [dbo].[LendingSlipDetail] ([BookId], [LendingSlipId], [DueBackDate], [BookStatus], [Notes], [TookBack], [TookBackAt], [TookBackBy], [Extended], [ExtendedBy], [ExtendedAt]) VALUES (N'BK00000001', 46, CAST(N'2022-06-07T22:05:46.000' AS DateTime), NULL, N'', 1, CAST(N'2022-06-07T22:09:32.173' AS DateTime), N'LB00000011', 0, NULL, NULL)
INSERT [dbo].[LendingSlipDetail] ([BookId], [LendingSlipId], [DueBackDate], [BookStatus], [Notes], [TookBack], [TookBackAt], [TookBackBy], [Extended], [ExtendedBy], [ExtendedAt]) VALUES (N'BK00000001', 48, CAST(N'2022-06-07T22:55:43.643' AS DateTime), NULL, NULL, 1, CAST(N'2022-06-07T22:57:33.353' AS DateTime), N'LB00000011', 0, NULL, NULL)
INSERT [dbo].[LendingSlipDetail] ([BookId], [LendingSlipId], [DueBackDate], [BookStatus], [Notes], [TookBack], [TookBackAt], [TookBackBy], [Extended], [ExtendedBy], [ExtendedAt]) VALUES (N'BK00000002', 45, CAST(N'2022-06-07T03:39:09.000' AS DateTime), NULL, N'', 1, CAST(N'2022-06-07T22:01:07.720' AS DateTime), N'LB00000011', 0, NULL, NULL)
INSERT [dbo].[LendingSlipDetail] ([BookId], [LendingSlipId], [DueBackDate], [BookStatus], [Notes], [TookBack], [TookBackAt], [TookBackBy], [Extended], [ExtendedBy], [ExtendedAt]) VALUES (N'BK00000002', 46, CAST(N'2022-06-07T22:05:53.000' AS DateTime), NULL, N'', 1, CAST(N'2022-06-07T22:09:35.573' AS DateTime), N'LB00000011', 0, NULL, NULL)
INSERT [dbo].[LendingSlipDetail] ([BookId], [LendingSlipId], [DueBackDate], [BookStatus], [Notes], [TookBack], [TookBackAt], [TookBackBy], [Extended], [ExtendedBy], [ExtendedAt]) VALUES (N'BK00000002', 47, CAST(N'2022-06-07T22:07:14.000' AS DateTime), NULL, N'', 1, CAST(N'2022-06-07T22:16:13.483' AS DateTime), N'LB00000011', 0, NULL, NULL)
INSERT [dbo].[LendingSlipDetail] ([BookId], [LendingSlipId], [DueBackDate], [BookStatus], [Notes], [TookBack], [TookBackAt], [TookBackBy], [Extended], [ExtendedBy], [ExtendedAt]) VALUES (N'BK00000002', 48, CAST(N'2022-06-14T22:55:43.643' AS DateTime), NULL, NULL, 1, CAST(N'2022-06-08T00:34:53.357' AS DateTime), N'LB00000011', 1, N'LB00000011', N'Jun  8 202')
INSERT [dbo].[LendingSlipDetail] ([BookId], [LendingSlipId], [DueBackDate], [BookStatus], [Notes], [TookBack], [TookBackAt], [TookBackBy], [Extended], [ExtendedBy], [ExtendedAt]) VALUES (N'BK00000003', 45, CAST(N'2022-06-07T03:39:21.000' AS DateTime), NULL, N'', 1, CAST(N'2022-06-07T22:02:26.600' AS DateTime), N'LB00000011', 0, NULL, NULL)
INSERT [dbo].[LendingSlipDetail] ([BookId], [LendingSlipId], [DueBackDate], [BookStatus], [Notes], [TookBack], [TookBackAt], [TookBackBy], [Extended], [ExtendedBy], [ExtendedAt]) VALUES (N'BK00000003', 46, CAST(N'2022-06-07T22:05:57.000' AS DateTime), NULL, N'', 1, CAST(N'2022-06-07T22:09:40.337' AS DateTime), N'LB00000011', 0, NULL, NULL)
INSERT [dbo].[LendingSlipDetail] ([BookId], [LendingSlipId], [DueBackDate], [BookStatus], [Notes], [TookBack], [TookBackAt], [TookBackBy], [Extended], [ExtendedBy], [ExtendedAt]) VALUES (N'BK00000003', 48, CAST(N'2022-06-14T22:55:43.643' AS DateTime), NULL, NULL, 1, CAST(N'2022-06-08T00:35:00.643' AS DateTime), N'LB00000011', 1, N'LB00000011', N'Jun  8 202')
INSERT [dbo].[LendingSlipDetail] ([BookId], [LendingSlipId], [DueBackDate], [BookStatus], [Notes], [TookBack], [TookBackAt], [TookBackBy], [Extended], [ExtendedBy], [ExtendedAt]) VALUES (N'BK00000005', 47, CAST(N'2022-06-07T22:07:49.000' AS DateTime), NULL, N'', 1, CAST(N'2022-06-07T22:16:31.823' AS DateTime), N'LB00000011', 0, NULL, NULL)
INSERT [dbo].[LendingSlipDetail] ([BookId], [LendingSlipId], [DueBackDate], [BookStatus], [Notes], [TookBack], [TookBackAt], [TookBackBy], [Extended], [ExtendedBy], [ExtendedAt]) VALUES (N'BK00000005', 50, CAST(N'2022-06-08T17:28:22.153' AS DateTime), NULL, NULL, 1, CAST(N'2022-06-12T23:17:39.610' AS DateTime), N'LB00000011', 0, NULL, NULL)
INSERT [dbo].[LendingSlipDetail] ([BookId], [LendingSlipId], [DueBackDate], [BookStatus], [Notes], [TookBack], [TookBackAt], [TookBackBy], [Extended], [ExtendedBy], [ExtendedAt]) VALUES (N'BK00000006', 50, CAST(N'2022-06-08T17:28:22.153' AS DateTime), NULL, NULL, 1, CAST(N'2022-06-12T23:17:43.840' AS DateTime), N'LB00000011', 0, NULL, NULL)
INSERT [dbo].[LendingSlipDetail] ([BookId], [LendingSlipId], [DueBackDate], [BookStatus], [Notes], [TookBack], [TookBackAt], [TookBackBy], [Extended], [ExtendedBy], [ExtendedAt]) VALUES (N'BK00000007', 51, CAST(N'2022-06-12T23:15:02.173' AS DateTime), NULL, NULL, 1, CAST(N'2022-06-12T23:15:37.250' AS DateTime), N'LB00000011', 0, NULL, NULL)
INSERT [dbo].[LendingSlipDetail] ([BookId], [LendingSlipId], [DueBackDate], [BookStatus], [Notes], [TookBack], [TookBackAt], [TookBackBy], [Extended], [ExtendedBy], [ExtendedAt]) VALUES (N'BK00000009', 49, CAST(N'2022-06-14T22:58:26.170' AS DateTime), NULL, NULL, 1, CAST(N'2022-06-08T00:27:38.713' AS DateTime), N'LB00000011', 1, NULL, NULL)
GO
INSERT [dbo].[Librarian] ([Id], [FirstName], [LastName], [Sex], [Address], [Birthday], [Email]) VALUES (N'LB00000003', N'Anh', N'Trần Minh', 0, N'Hà Nội', CAST(N'2001-04-01' AS Date), N'minhanh@gmail.com')
INSERT [dbo].[Librarian] ([Id], [FirstName], [LastName], [Sex], [Address], [Birthday], [Email]) VALUES (N'LB00000004', N'Nhật Quỳnh', N'Nguyễn Minh', 0, N'Huế', CAST(N'2001-04-01' AS Date), N'minhnhat@gmail.com')
INSERT [dbo].[Librarian] ([Id], [FirstName], [LastName], [Sex], [Address], [Birthday], [Email]) VALUES (N'LB00000005', N'Tuyết Huỳnh', N'Điệp Lam', 0, N'Hải Phòng', CAST(N'2001-04-01' AS Date), N'lamtuyet@outlook.com')
INSERT [dbo].[Librarian] ([Id], [FirstName], [LastName], [Sex], [Address], [Birthday], [Email]) VALUES (N'LB00000006', N'Sơn', N'Diệp Thanh', 1, N'Cần Thơ', CAST(N'2001-04-11' AS Date), N'thanhson@outlook.com')
INSERT [dbo].[Librarian] ([Id], [FirstName], [LastName], [Sex], [Address], [Birthday], [Email]) VALUES (N'LB00000009', N'Anh', N'Trần Minh', 0, N'Đà Nẵng', CAST(N'2001-11-01' AS Date), N'tranminhanh@outlook.com')
INSERT [dbo].[Librarian] ([Id], [FirstName], [LastName], [Sex], [Address], [Birthday], [Email]) VALUES (N'LB00000011', N'Bạch Hoa', N'Lý Lộ', 1, N'Hồ Chí Minh', CAST(N'2001-07-01' AS Date), N'bachhoa@outlook.com')
INSERT [dbo].[Librarian] ([Id], [FirstName], [LastName], [Sex], [Address], [Birthday], [Email]) VALUES (N'LB00000014', N'Minh', N'Trần Nguyệt', 1, N'Hồ Chí Minh', CAST(N'2022-05-01' AS Date), N'nguyetminh@gmail.com')
INSERT [dbo].[Librarian] ([Id], [FirstName], [LastName], [Sex], [Address], [Birthday], [Email]) VALUES (N'LB00000015', N'Thường', N'Lý Tố', 0, N'Hải Phòng', CAST(N'2000-06-14' AS Date), N'tothuong@outlook.com')
INSERT [dbo].[Librarian] ([Id], [FirstName], [LastName], [Sex], [Address], [Birthday], [Email]) VALUES (N'LB00000016', N'Hoa Lam', N'Thanh Mộc', 1, N'Hà Nội', CAST(N'2022-06-08' AS Date), N'hoalam@gmail.com')
GO
SET IDENTITY_INSERT [dbo].[LibraryCard] ON 

INSERT [dbo].[LibraryCard] ([Id], [EffectiveDate], [EffectiveEndDate], [Fee], [ReaderId], [CreatedBy], [CreatedAt]) VALUES (1, CAST(N'2022-05-01T23:17:56.000' AS DateTime), CAST(N'2022-05-26T23:17:56.000' AS DateTime), 500000.0000, N'RD00000001', N'LB00000011', CAST(N'2022-05-19T23:18:01.747' AS DateTime))
INSERT [dbo].[LibraryCard] ([Id], [EffectiveDate], [EffectiveEndDate], [Fee], [ReaderId], [CreatedBy], [CreatedAt]) VALUES (4, CAST(N'2022-06-04T21:16:01.150' AS DateTime), CAST(N'2022-07-04T21:16:01.000' AS DateTime), 5000.0000, N'RD00000001', N'LB00000011', CAST(N'2022-06-04T21:18:46.920' AS DateTime))
INSERT [dbo].[LibraryCard] ([Id], [EffectiveDate], [EffectiveEndDate], [Fee], [ReaderId], [CreatedBy], [CreatedAt]) VALUES (6, CAST(N'2022-06-09T23:59:45.000' AS DateTime), CAST(N'2022-06-23T23:59:45.000' AS DateTime), 50000.0000, N'RD00000002', N'LB00000011', CAST(N'2022-06-09T00:00:51.917' AS DateTime))
INSERT [dbo].[LibraryCard] ([Id], [EffectiveDate], [EffectiveEndDate], [Fee], [ReaderId], [CreatedBy], [CreatedAt]) VALUES (7, CAST(N'2022-06-09T22:16:37.287' AS DateTime), CAST(N'2022-06-16T22:16:37.000' AS DateTime), 50000.0000, N'RD00000003', N'LB00000011', CAST(N'2022-06-09T22:16:48.503' AS DateTime))
SET IDENTITY_INSERT [dbo].[LibraryCard] OFF
GO
SET IDENTITY_INSERT [dbo].[LiquidatingSlip] ON 

INSERT [dbo].[LiquidatingSlip] ([Id], [CreatedAt], [CreatedBy]) VALUES (22, CAST(N'2022-06-08T17:26:26.540' AS DateTime), N'LB00000011')
INSERT [dbo].[LiquidatingSlip] ([Id], [CreatedAt], [CreatedBy]) VALUES (23, CAST(N'2022-06-08T17:27:46.267' AS DateTime), N'LB00000011')
INSERT [dbo].[LiquidatingSlip] ([Id], [CreatedAt], [CreatedBy]) VALUES (24, CAST(N'2022-06-12T23:18:43.290' AS DateTime), N'LB00000011')
SET IDENTITY_INSERT [dbo].[LiquidatingSlip] OFF
GO
INSERT [dbo].[LiquidatingSlipDetail] ([BookId], [LiquidatingSlipId], [Price], [Notes]) VALUES (N'BK00000001', 22, 50000.0000, NULL)
INSERT [dbo].[LiquidatingSlipDetail] ([BookId], [LiquidatingSlipId], [Price], [Notes]) VALUES (N'BK00000002', 22, 50000.0000, NULL)
INSERT [dbo].[LiquidatingSlipDetail] ([BookId], [LiquidatingSlipId], [Price], [Notes]) VALUES (N'BK00000003', 23, 50000.0000, NULL)
INSERT [dbo].[LiquidatingSlipDetail] ([BookId], [LiquidatingSlipId], [Price], [Notes]) VALUES (N'BK00000004', 23, 500000.0000, NULL)
INSERT [dbo].[LiquidatingSlipDetail] ([BookId], [LiquidatingSlipId], [Price], [Notes]) VALUES (N'BK00000005', 24, 5000000.0000, NULL)
GO
INSERT [dbo].[Publisher] ([Id], [Name], [Address], [PhoneNumber], [Email]) VALUES (N'PB00000001', N'Công ty TNHH Sili', N'Sili City', N'345-123-123', N'contact@sili.com')
INSERT [dbo].[Publisher] ([Id], [Name], [Address], [PhoneNumber], [Email]) VALUES (N'PB00000002', N'Nhà xuất bản Loulai', N'Sili City', N'123-123-123', N'contact@loulai.com')
INSERT [dbo].[Publisher] ([Id], [Name], [Address], [PhoneNumber], [Email]) VALUES (N'PB00000003', N'Công ty xuất bản sách Sera', N'Sili Bay', N'435-456-243', N'contact@sera.com')
INSERT [dbo].[Publisher] ([Id], [Name], [Address], [PhoneNumber], [Email]) VALUES (N'PB00000004', N'Nhà xuất bản Igura', N'Sili Tower', N'456-432-234', N'contract@igura.com')
GO
INSERT [dbo].[Reader] ([Id], [FirstName], [LastName], [Sex], [Address], [Birthday], [Email], [PhoneNumber], [LibrarianId]) VALUES (N'RD00000001', N'Anh', N'Vương Ngọc', 1, N'Hồ Chí Minh', CAST(N'2002-01-01' AS Date), N'ngocanh@gmail.com', N'0341234567', N'LB00000011')
INSERT [dbo].[Reader] ([Id], [FirstName], [LastName], [Sex], [Address], [Birthday], [Email], [PhoneNumber], [LibrarianId]) VALUES (N'RD00000002', N'Phi', N'Triệu Yến', 0, N'Hà Nội', CAST(N'2022-05-02' AS Date), N'yenphi@gmail.com', N'0341234567', N'LB00000011')
INSERT [dbo].[Reader] ([Id], [FirstName], [LastName], [Sex], [Address], [Birthday], [Email], [PhoneNumber], [LibrarianId]) VALUES (N'RD00000003', N'Thường', N'Lý Tố', 0, N'Hải Phòng', CAST(N'2000-06-14' AS Date), N'tothuong@outloook.com', N'0341234567', N'LB00000011')
INSERT [dbo].[Reader] ([Id], [FirstName], [LastName], [Sex], [Address], [Birthday], [Email], [PhoneNumber], [LibrarianId]) VALUES (N'RD00000004', N'Nhân', N'Nguyễn Thanh', 1, N'Hà Nội', CAST(N'2022-06-08' AS Date), N'thanhnhan@gmail.com', N'0341234567', N'LB00000011')
INSERT [dbo].[Reader] ([Id], [FirstName], [LastName], [Sex], [Address], [Birthday], [Email], [PhoneNumber], [LibrarianId]) VALUES (N'RD00000005', N'Nam', N'Nguyễn Thành', 1, N'Hồ Chí Minh', CAST(N'2022-06-09' AS Date), N'thanhnam@gmail.com', N'0341234567', N'LB00000011')
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_Account]    Script Date: 6/14/2022 2:09:57 AM ******/
CREATE UNIQUE NONCLUSTERED INDEX [IX_Account] ON [dbo].[Account]
(
	[UserableId] ASC,
	[UserableType] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_BookCategory]    Script Date: 6/14/2022 2:09:57 AM ******/
ALTER TABLE [dbo].[BookCategory] ADD  CONSTRAINT [IX_BookCategory] UNIQUE NONCLUSTERED 
(
	[Name] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Account] ADD  CONSTRAINT [DF_Account_Enable]  DEFAULT ((1)) FOR [Enable]
GO
ALTER TABLE [dbo].[LendingSlipDetail] ADD  CONSTRAINT [DF_LendingSlipDetail_ON_TookBack]  DEFAULT ('false') FOR [TookBack]
GO
ALTER TABLE [dbo].[LendingSlipDetail] ADD  CONSTRAINT [DF_LendingSlipDetail_ON_Extended]  DEFAULT ('false') FOR [Extended]
GO
ALTER TABLE [dbo].[Book]  WITH CHECK ADD  CONSTRAINT [FK_Book_BookTitle] FOREIGN KEY([BookTitleISBN])
REFERENCES [dbo].[BookTitle] ([ISBN])
GO
ALTER TABLE [dbo].[Book] CHECK CONSTRAINT [FK_Book_BookTitle]
GO
ALTER TABLE [dbo].[Book]  WITH CHECK ADD  CONSTRAINT [FK_Book_Case] FOREIGN KEY([CaseId])
REFERENCES [dbo].[Caze] ([Id])
GO
ALTER TABLE [dbo].[Book] CHECK CONSTRAINT [FK_Book_Case]
GO
ALTER TABLE [dbo].[Book]  WITH CHECK ADD  CONSTRAINT [FK_Book_Librarian] FOREIGN KEY([LibrarianId])
REFERENCES [dbo].[Librarian] ([Id])
GO
ALTER TABLE [dbo].[Book] CHECK CONSTRAINT [FK_Book_Librarian]
GO
ALTER TABLE [dbo].[BookTitle]  WITH CHECK ADD  CONSTRAINT [FK_BookTitle_Publisher] FOREIGN KEY([PublisherId])
REFERENCES [dbo].[Publisher] ([Id])
GO
ALTER TABLE [dbo].[BookTitle] CHECK CONSTRAINT [FK_BookTitle_Publisher]
GO
ALTER TABLE [dbo].[BookTitle_Author]  WITH CHECK ADD  CONSTRAINT [FK_BookTitle_Author_Author] FOREIGN KEY([AuthorId])
REFERENCES [dbo].[Author] ([Id])
GO
ALTER TABLE [dbo].[BookTitle_Author] CHECK CONSTRAINT [FK_BookTitle_Author_Author]
GO
ALTER TABLE [dbo].[BookTitle_Author]  WITH CHECK ADD  CONSTRAINT [FK_BookTitle_Author_BookTitle] FOREIGN KEY([BookTitleISBN])
REFERENCES [dbo].[BookTitle] ([ISBN])
GO
ALTER TABLE [dbo].[BookTitle_Author] CHECK CONSTRAINT [FK_BookTitle_Author_BookTitle]
GO
ALTER TABLE [dbo].[BookTitle_BookCategory]  WITH CHECK ADD  CONSTRAINT [FK_BookTitle_BookCategory_BookCategory] FOREIGN KEY([BookCategoryId])
REFERENCES [dbo].[BookCategory] ([Id])
GO
ALTER TABLE [dbo].[BookTitle_BookCategory] CHECK CONSTRAINT [FK_BookTitle_BookCategory_BookCategory]
GO
ALTER TABLE [dbo].[BookTitle_BookCategory]  WITH CHECK ADD  CONSTRAINT [FK_BookTitle_BookCategory_BookTitle] FOREIGN KEY([BookTitleISBN])
REFERENCES [dbo].[BookTitle] ([ISBN])
GO
ALTER TABLE [dbo].[BookTitle_BookCategory] CHECK CONSTRAINT [FK_BookTitle_BookCategory_BookTitle]
GO
ALTER TABLE [dbo].[Caze]  WITH CHECK ADD  CONSTRAINT [FK_Case_BookCase] FOREIGN KEY([BookCaseId])
REFERENCES [dbo].[BookCase] ([Id])
GO
ALTER TABLE [dbo].[Caze] CHECK CONSTRAINT [FK_Case_BookCase]
GO
ALTER TABLE [dbo].[LendingSlip]  WITH CHECK ADD  CONSTRAINT [FK_LendingSlip_Reader] FOREIGN KEY([ReaderId])
REFERENCES [dbo].[Reader] ([Id])
GO
ALTER TABLE [dbo].[LendingSlip] CHECK CONSTRAINT [FK_LendingSlip_Reader]
GO
ALTER TABLE [dbo].[LendingSlipDetail]  WITH CHECK ADD  CONSTRAINT [FK_LendingSlipDetail_Book] FOREIGN KEY([BookId])
REFERENCES [dbo].[Book] ([Id])
GO
ALTER TABLE [dbo].[LendingSlipDetail] CHECK CONSTRAINT [FK_LendingSlipDetail_Book]
GO
ALTER TABLE [dbo].[LendingSlipDetail]  WITH CHECK ADD  CONSTRAINT [FK_LendingSlipDetail_LendingSlip] FOREIGN KEY([LendingSlipId])
REFERENCES [dbo].[LendingSlip] ([Id])
GO
ALTER TABLE [dbo].[LendingSlipDetail] CHECK CONSTRAINT [FK_LendingSlipDetail_LendingSlip]
GO
ALTER TABLE [dbo].[LendingSlipDetail]  WITH CHECK ADD  CONSTRAINT [FK_LendingSlipDetail_Librarian] FOREIGN KEY([TookBackBy])
REFERENCES [dbo].[Librarian] ([Id])
GO
ALTER TABLE [dbo].[LendingSlipDetail] CHECK CONSTRAINT [FK_LendingSlipDetail_Librarian]
GO
ALTER TABLE [dbo].[LendingSlipDetail]  WITH CHECK ADD  CONSTRAINT [FK_LendingSlipDetail_Librarian1] FOREIGN KEY([ExtendedBy])
REFERENCES [dbo].[Librarian] ([Id])
GO
ALTER TABLE [dbo].[LendingSlipDetail] CHECK CONSTRAINT [FK_LendingSlipDetail_Librarian1]
GO
ALTER TABLE [dbo].[LibraryCard]  WITH CHECK ADD  CONSTRAINT [FK_LibraryCard_Librarian] FOREIGN KEY([CreatedBy])
REFERENCES [dbo].[Librarian] ([Id])
GO
ALTER TABLE [dbo].[LibraryCard] CHECK CONSTRAINT [FK_LibraryCard_Librarian]
GO
ALTER TABLE [dbo].[LibraryCard]  WITH CHECK ADD  CONSTRAINT [FK_LibraryCard_Reader] FOREIGN KEY([ReaderId])
REFERENCES [dbo].[Reader] ([Id])
GO
ALTER TABLE [dbo].[LibraryCard] CHECK CONSTRAINT [FK_LibraryCard_Reader]
GO
ALTER TABLE [dbo].[LiquidatingSlip]  WITH CHECK ADD  CONSTRAINT [FK_LiquidatingSlip_Librarian] FOREIGN KEY([CreatedBy])
REFERENCES [dbo].[Librarian] ([Id])
GO
ALTER TABLE [dbo].[LiquidatingSlip] CHECK CONSTRAINT [FK_LiquidatingSlip_Librarian]
GO
ALTER TABLE [dbo].[LiquidatingSlipDetail]  WITH CHECK ADD  CONSTRAINT [FK_LiquidatingSlipDetail_Book1] FOREIGN KEY([BookId])
REFERENCES [dbo].[Book] ([Id])
GO
ALTER TABLE [dbo].[LiquidatingSlipDetail] CHECK CONSTRAINT [FK_LiquidatingSlipDetail_Book1]
GO
ALTER TABLE [dbo].[LiquidatingSlipDetail]  WITH CHECK ADD  CONSTRAINT [FK_LiquidatingSlipDetail_LiquidatingSlip] FOREIGN KEY([LiquidatingSlipId])
REFERENCES [dbo].[LiquidatingSlip] ([Id])
GO
ALTER TABLE [dbo].[LiquidatingSlipDetail] CHECK CONSTRAINT [FK_LiquidatingSlipDetail_LiquidatingSlip]
GO
ALTER TABLE [dbo].[Reader]  WITH CHECK ADD  CONSTRAINT [FK_Reader_Librarian] FOREIGN KEY([LibrarianId])
REFERENCES [dbo].[Librarian] ([Id])
GO
ALTER TABLE [dbo].[Reader] CHECK CONSTRAINT [FK_Reader_Librarian]
GO
ALTER TABLE [dbo].[LibraryCard]  WITH CHECK ADD  CONSTRAINT [CK_LibraryCard_Fee] CHECK  (([Fee]>=(1000) AND [Fee]<=(1000000000)))
GO
ALTER TABLE [dbo].[LibraryCard] CHECK CONSTRAINT [CK_LibraryCard_Fee]
GO
/****** Object:  StoredProcedure [dbo].[sp_can_reader_lending]    Script Date: 6/14/2022 2:09:57 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[sp_can_reader_lending]
	@reader_id NCHAR(10)
AS
BEGIN
	DECLARE @count INT

	-- LibraryCard
	SELECT @count = COUNT(*) FROM LibraryCard WHERE ReaderId = @reader_id AND (CURRENT_TIMESTAMP BETWEEN EffectiveDate AND EffectiveEndDate)
	IF @count = 0
		RAISERROR(N'Bạn cần có thẻ thư viện có hiệu lực để mượn sách', 16 , 1) WITH NOWAIT

	-- LendingSlip
	SELECT @count = COUNT(*) FROM LendingSlip
	LEFT JOIN LendingSlipDetail ON LendingSlipDetail.LendingSlipId = LendingSlip.Id
	WHERE LendingSlip.ReaderId = @reader_id AND LendingSlipDetail.TookBack = 0 AND LendingSlipDetail.DueBackDate > CURRENT_TIMESTAMP

	IF @count != 0
		RAISERROR(N'Tồn tại sách chưa trả đúng hạn', 16 , 1) WITH NOWAIT

	-- LendingSlip
	SELECT @count = COUNT(*) FROM LendingSlip
	LEFT JOIN LendingSlipDetail ON LendingSlipDetail.LendingSlipId = LendingSlip.Id
	WHERE LendingSlip.ReaderId = @reader_id AND LendingSlipDetail.TookBack = 0

	IF @count > 2
		RAISERROR(N'Chỉ được phép mượn tối đa 3 quyển', 16 , 1) WITH NOWAIT
END
GO
/****** Object:  StoredProcedure [dbo].[sp_create_author]    Script Date: 6/14/2022 2:09:57 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create PROCEDURE [dbo].[sp_create_author]
	@id NCHAR(10),
	@first_name NVARCHAR(30),
	@last_name NVARCHAR(50),
	@birthday DATE,
	@sex BIT,
	@address NVARCHAR(150),
	@email NVARCHAR(150)
AS
BEGIN
	INSERT INTO Author (Id, FirstName, LastName, Birthday, Sex, Address, Email)
	VAlUES (@id, @first_name, @last_name, @birthday, @sex, @address, @email)
END
GO
/****** Object:  StoredProcedure [dbo].[sp_create_book]    Script Date: 6/14/2022 2:09:57 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[sp_create_book]
	@id NCHAR(10),
	@size SMALLINT,
	@notes NVARCHAR(MAX),
	@case_id INT,
	@book_title_isbn NCHAR(13),
	@librarian_id NCHAR(10),
	@status SMALLINT
AS
BEGIN
	INSERT INTO Book (Id, Size, Notes, CaseId, BookTitleISBN, LibrarianId, CreatedAt, Status, Lending)
	VALUES (@id, @size, @notes, @case_id, @book_title_isbn, @librarian_id, CURRENT_TIMESTAMP, 1, 0)
END
GO
/****** Object:  StoredProcedure [dbo].[sp_create_book_title]    Script Date: 6/14/2022 2:09:57 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_create_book_title]
	@ISBN NCHAR(13),
	@name NVARCHAR(MAX),
	@pages INT,
	@price MONEY,
	@release_date DATE,
	@publisher_id NCHAR(10),
	@categories NVARCHAR(MAX),
	@authors NVARCHAR(MAX)
AS
BEGIN
	BEGIN TRY
		BEGIN TRANSACTION

		INSERT INTO BookTitle (ISBN, Name, Pages, Price, ReleaseDate, PublisherId)
		VAlUES (@ISBN, @name, @pages, @price, @release_date, @publisher_id)

		INSERT INTO BookTitle_BookCategory
		SELECT @ISBN as BookTitleISBN, value as BookCategoryId FROM STRING_SPLIT(@categories, ',')

		INSERT INTO BookTitle_Author
		SELECT @ISBN as BookTitleISBN, value as AuthorId FROM STRING_SPLIT(@authors, ',');

		COMMIT TRANSACTION
	END TRY
	BEGIN CATCH
        ROLLBACK TRANSACTION
		
		DECLARE @ErrorMessage VARCHAR(MAX), @ErrorSeverity INT, @ErrorState INT
		SET @ErrorMessage  = ERROR_MESSAGE()
		SET @ErrorSeverity = ERROR_SEVERITY()
		SET @ErrorState    = ERROR_STATE()

		RAISERROR(@ErrorMessage, @ErrorSeverity, @ErrorState)
    END CATCH
END
GO
/****** Object:  StoredProcedure [dbo].[sp_create_lending_slip]    Script Date: 6/14/2022 2:09:57 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_create_lending_slip]
	@id INT,
	@reader_id NCHAR(10),
	@created_by_librarian_id NCHAR(10),
	@book_ids NVARCHAR(MAX)
AS
BEGIN
	BEGIN TRY
		BEGIN TRANSACTION

		-- Validate
		DECLARE @count INT

		-- LibraryCard
		SELECT @count = COUNT(*) FROM LibraryCard WHERE ReaderId = @reader_id AND (CURRENT_TIMESTAMP BETWEEN EffectiveDate AND EffectiveEndDate)
		IF @count = 0
			RAISERROR(N'Bạn cần có thẻ thư viện có hiệu lực để mượn sách', 16 , 1) WITH NOWAIT

		-- LendingSlip
		SELECT @count = COUNT(*) FROM LendingSlip
		LEFT JOIN LendingSlipDetail ON LendingSlipDetail.LendingSlipId = LendingSlip.Id
		WHERE LendingSlip.ReaderId = @reader_id AND LendingSlipDetail.TookBack = 'false' AND LendingSlipDetail.DueBackDate > CURRENT_TIMESTAMP

		IF @count != 0
			RAISERROR(N'Tồn tại sách chưa trả đúng hạn', 16 , 1) WITH NOWAIT

		IF (@book_ids = '')
			RAISERROR('Phải có ít nhất một quyển sách trong danh sách', 16, 1) WITH NOWAIT

		-- LendingSlip
		SELECT @count = COUNT(*) FROM LendingSlip
		LEFT JOIN LendingSlipDetail ON LendingSlipDetail.LendingSlipId = LendingSlip.Id
		WHERE LendingSlip.ReaderId = @reader_id AND LendingSlipDetail.TookBack = 'false'

		DECLARE @count_book_ids INT
		SELECT @count_book_ids = COUNT(value) FROM STRING_SPLIT(@book_ids, ',')

		IF @count_book_ids > 3 - @count
			RAISERROR(N'Chỉ được phép mượn tối đa 3 quyển', 16 , 1) WITH NOWAIT

		-- Insert

		DECLARE @OutputTbl TABLE (Id BIGINT)

		INSERT INTO LendingSlip (ReaderId, CreatedByLibrarianId, CreatedAt)
		OUTPUT Inserted.Id INTO @OutputTbl(Id)
		VALUES (@reader_id, @created_by_librarian_id, CURRENT_TIMESTAMP)

		DECLARE @lending_slip_id BIGINT
		DECLARE @sql NVARCHAR(MAX)
		SET @lending_slip_id = (SELECT Id FROM @OutputTbl)
		
		DECLARE @details NVARCHAR(MAX)
		SELECT @details = COALESCE(@details + ', ', '') + '(''' + value + ''', ' + CAST(@lending_slip_id AS NVARCHAR(MAX)) + ', CURRENT_TIMESTAMP)' FROM STRING_SPLIT(@book_ids, ',')

		SET @sql = 'DECLARE @lending_slip_id BIGINT ' +
				   'SET @lending_slip_id = ' + CAST((SELECT Id FROM @OutputTbl) AS NVARCHAR(MAX)) + ' ' +
				   'INSERT INTO LendingSlipDetail (BookId, LendingSlipId, DueBackDate) VALUES ' + @details
		EXECUTE (@sql)

		COMMIT TRANSACTION
	END TRY
	BEGIN CATCH
        ROLLBACK TRANSACTION
		
		DECLARE @ErrorMessage VARCHAR(MAX), @ErrorSeverity INT, @ErrorState INT
		SET @ErrorMessage  = ERROR_MESSAGE()
		SET @ErrorSeverity = ERROR_SEVERITY()
		SET @ErrorState    = ERROR_STATE()

		RAISERROR(@ErrorMessage, @ErrorSeverity, @ErrorState)
    END CATCH
END
GO
/****** Object:  StoredProcedure [dbo].[sp_create_lending_slip_detail]    Script Date: 6/14/2022 2:09:57 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[sp_create_lending_slip_detail]
	@book_id NCHAR(10),
	@lending_slip_id INT,
	@due_back_date DATETIME,
	@notes NVARCHAR(MAX)
as
begin
	INSERT INTO LendingSlipDetail (BookId, LendingSlipId, DueBackDate, Notes, BookStatus)
	VALUES (@book_id, @lending_slip_id, @due_back_date, @notes, 1)
end
GO
/****** Object:  StoredProcedure [dbo].[sp_create_librarian]    Script Date: 6/14/2022 2:09:57 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_create_librarian]
	@id NCHAR(10),
	@first_name NVARCHAR(30),
	@last_name NVARCHAR(50),
	@birthday DATE,
	@sex BIT,
	@address NVARCHAR(150),
	@email NVARCHAR(150),
	@username NVARCHAR(50),
	@password_digest NVARCHAR(100),
	@enable BIT
AS
BEGIN
	BEGIN TRY
		BEGIN TRANSACTION

		INSERT INTO Librarian (Id, FirstName, LastName, Birthday, Sex, Address, Email)
		VAlUES (@id, @first_name, @last_name, @birthday, @sex, @address, @email)

		INSERT INTO Account(Username, PasswordDigest, Enable, UserableId, UserableType)
		VAlUES (@username, @password_digest, @enable, @id, N'Librarian')

		COMMIT TRANSACTION
	END TRY
	BEGIN CATCH
        ROLLBACK TRANSACTION
		
		DECLARE @ErrorMessage VARCHAR(MAX), @ErrorSeverity INT, @ErrorState INT
		SET @ErrorMessage  = ERROR_MESSAGE()
		SET @ErrorSeverity = ERROR_SEVERITY()
		SET @ErrorState    = ERROR_STATE()

		RAISERROR(@ErrorMessage, @ErrorSeverity, @ErrorState)
    END CATCH
END
GO
/****** Object:  StoredProcedure [dbo].[sp_create_librarian_include_account]    Script Date: 6/14/2022 2:09:57 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_create_librarian_include_account]
	@id NCHAR(10),
	@first_name NVARCHAR(30),
	@last_name NVARCHAR(50),
	@birthday DATE,
	@sex BIT,
	@address NVARCHAR(150),
	@email NVARCHAR(150),
	@username NVARCHAR(50),
	@password NVARCHAR(MAX),
	@enable bit
AS
BEGIN
	BEGIN TRY
		BEGIN TRANSACTION

		INSERT INTO Librarian (Id, FirstName, LastName, Birthday, Sex, Address, Email)
		VAlUES (@id, @first_name, @last_name, @birthday, @sex, @address, @email)

		INSERT INTO Account(Username, PasswordDigest, Enable, UserableId, UserableType)
		VAlUES (@username, @password, @enable, @id, N'Librarian')

		COMMIT TRANSACTION
	END TRY
	BEGIN CATCH
        ROLLBACK TRANSACTION
		
		DECLARE @ErrorMessage VARCHAR(MAX), @ErrorSeverity INT, @ErrorState INT
		SET @ErrorMessage  = ERROR_MESSAGE()
		SET @ErrorSeverity = ERROR_SEVERITY()
		SET @ErrorState    = ERROR_STATE()

		RAISERROR(@ErrorMessage, @ErrorSeverity, @ErrorState)
    END CATCH
END
GO
/****** Object:  StoredProcedure [dbo].[sp_create_library_card]    Script Date: 6/14/2022 2:09:57 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_create_library_card]
	@id BIGINT,
	@effective_date DATETIME,
	@effective_end_date DATETIME,
	@fee MONEY,
	@reader_id NCHAR(10),
	@created_by NCHAR(10)
AS
BEGIN
	BEGIN TRY
		BEGIN TRANSACTION

		IF DATEDIFF(day, CURRENT_TIMESTAMP, @effective_date) < 0
			RAISERROR(N'Thời gian bắt đầu có hiệu của thẻ không được trước ngày hiện tại', 16 , 1) WITH NOWAIT

		IF DATEDIFF(day, @effective_date, @effective_end_date) < 7
			RAISERROR(N'Thẻ phải có thời gian hiệu lực từ 7 ngày trở lên', 16 , 1) WITH NOWAIT

		DECLARE @latest DATETIME
		SELECT TOP (1) @latest = MAX(EffectiveEndDate) FROM LibraryCard
		WHERE ReaderId = @reader_id

		IF DATEDIFF(day, CURRENT_TIMESTAMP, @latest) > 7
			RAISERROR(N'Tồn tại thẻ có hiệu lực hơn 7 ngày', 16 , 1) WITH NOWAIT

		IF DATEDIFF(day, @effective_date, @latest) > 0
			RAISERROR(N'Thời gian bắt đầu có hiệu lực phải sau thời gian kết thúc hiệu lực của thẻ đang có hiệu lực', 16 , 1) WITH NOWAIT

		INSERT INTO LibraryCard (EffectiveDate, EffectiveEndDate, Fee, ReaderId, CreatedBy, CreatedAt)
		VALUES (@effective_date, @effective_end_date, @fee, @reader_id, @created_by, CURRENT_TIMESTAMP)

		COMMIT TRANSACTION
	END TRY
	BEGIN CATCH
        ROLLBACK TRANSACTION
		
		DECLARE @ErrorMessage VARCHAR(MAX), @ErrorSeverity INT, @ErrorState INT
		SET @ErrorMessage  = ERROR_MESSAGE()
		SET @ErrorSeverity = ERROR_SEVERITY()
		SET @ErrorState    = ERROR_STATE()

		RAISERROR(@ErrorMessage, @ErrorSeverity, @ErrorState)
    END CATCH
END
GO
/****** Object:  StoredProcedure [dbo].[sp_create_liquidating_slip]    Script Date: 6/14/2022 2:09:57 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_create_liquidating_slip]
	@created_by NCHAR(10),
	@book_ids NVARCHAR(MAX),
	@prices NVARCHAR(MAX)
AS
BEGIN
	BEGIN TRY
		BEGIN TRANSACTION

		DECLARE @OutputTbl TABLE (Id BIGINT)

		INSERT INTO LiquidatingSlip(CreatedBy, CreatedAt)
		OUTPUT Inserted.Id INTO @OutputTbl(Id)
		VALUES (@created_by, CURRENT_TIMESTAMP)

		DECLARE @liquidating_slip_id BIGINT
		SET @liquidating_slip_id = (SELECT Id FROM @OutputTbl)

		SELECT CAST(A.value AS NCHAR(10)) AS BookId, CAST(B.value AS MONEY) AS Price, @liquidating_slip_id AS LiquidatingSlipId INTO #Details FROM
		(SELECT value, ROW_NUMBER() OVER(ORDER BY (SELECT 1)) AS [ordinal] FROM STRING_SPLIT(@book_ids, ',')) AS A
		INNER JOIN (SELECT value , ROW_NUMBER() OVER(ORDER BY (SELECT 1)) AS [ordinal] FROM STRING_SPLIT(@prices, ',')) AS B ON A.ordinal = B.ordinal

		INSERT INTO LiquidatingSlipDetail (BookId, LiquidatingSlipId, Price)
		SELECT BookId, LiquidatingSlipId, Price FROM #Details

		COMMIT TRANSACTION
	END TRY
	BEGIN CATCH
        ROLLBACK TRANSACTION
		
		DECLARE @ErrorMessage NVARCHAR(MAX), @ErrorSeverity INT, @ErrorState INT
		SET @ErrorMessage  = ERROR_MESSAGE()
		SET @ErrorSeverity = ERROR_SEVERITY()
		SET @ErrorState    = ERROR_STATE()

		RAISERROR(@ErrorMessage, @ErrorSeverity, @ErrorState)
    END CATCH
END
GO
/****** Object:  StoredProcedure [dbo].[sp_create_login]    Script Date: 6/14/2022 2:09:57 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_create_login]
	@loginname NVARCHAR(50),
	@password NVARCHAR(50),
	@username NVARCHAR(50),
	@roles NVARCHAR(MAX)
AS
BEGIN
	BEGIN TRY
		BEGIN TRANSACTION
		DECLARE @sql NVARCHAR(MAX)

		SET @sql = 'CREATE LOGIN [' + @loginname + '] WITH PASSWORD = ''' + @password + ''''
		EXECUTE (@sql)

		SET @sql = 'CREATE USER [' + @username + '] FOR LOGIN [' + @loginname + ']'
		EXECUTE (@sql)

		-- add roles
		IF (@roles != '')
		BEGIN
			SET @sql = NULL
			SELECT @sql = COALESCE(@sql + ' ', '') + 'ALTER ROLE ' + value + ' ADD MEMBER ' + @username FROM STRING_SPLIT(@roles, ',')
			EXECUTE (@sql)
		END

		COMMIT TRANSACTION
	END TRY
	BEGIN CATCH
        ROLLBACK TRANSACTION
		
		DECLARE @ErrorMessage VARCHAR(MAX), @ErrorSeverity INT, @ErrorState INT
		SET @ErrorMessage  = ERROR_MESSAGE()
		SET @ErrorSeverity = ERROR_SEVERITY()
		SET @ErrorState    = ERROR_STATE()

		RAISERROR(@ErrorMessage, @ErrorSeverity, @ErrorState)
    END CATCH
END
GO
/****** Object:  StoredProcedure [dbo].[sp_create_reader]    Script Date: 6/14/2022 2:09:57 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create PROCEDURE [dbo].[sp_create_reader]
	@id NCHAR(10),
	@first_name NVARCHAR(30),
	@last_name NVARCHAR(50),
	@birthday DATE,
	@sex BIT,
	@address NVARCHAR(150),
	@email NVARCHAR(150),
	@phone_number NVARCHAR(20),
	@librarian_id NCHAR(10)
AS
BEGIN
	INSERT INTO Reader (Id, FirstName, LastName, Birthday, Sex, Address, Email, PhoneNumber, LibrarianId)
	VAlUES (@id, @first_name, @last_name, @birthday, @sex, @address, @email, @phone_number, @librarian_id)
END
GO
/****** Object:  StoredProcedure [dbo].[sp_delete_book_title]    Script Date: 6/14/2022 2:09:57 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_delete_book_title]
	@isbn NCHAR(13)
AS
BEGIN
	BEGIN TRY
		BEGIN TRANSACTION

		DELETE FROM BookTitle_Author WHERE BookTitleISBN = @isbn
		DELETE FROM BookTitle_BookCategory WHERE BookTitleISBN = @isbn
		DELETE FROM BookTitle WHERE ISBN = @isbn

		COMMIT TRANSACTION
	END TRY
	BEGIN CATCH
        ROLLBACK TRANSACTION
		
		DECLARE @ErrorMessage VARCHAR(MAX), @ErrorSeverity INT, @ErrorState INT
		SET @ErrorMessage  = ERROR_MESSAGE()
		SET @ErrorSeverity = ERROR_SEVERITY()
		SET @ErrorState    = ERROR_STATE()

		RAISERROR(@ErrorMessage, @ErrorSeverity, @ErrorState)
    END CATCH
END
GO
/****** Object:  StoredProcedure [dbo].[sp_delete_librarian]    Script Date: 6/14/2022 2:09:57 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_delete_librarian]
	@id NCHAR(10)
AS
BEGIN
	BEGIN TRY
		BEGIN TRANSACTION
		DECLARE @username NVARCHAR(50)
		DELETE FROM Librarian WHERE Id = @id
		DELETE FROM Account WHERE UserableId = @id AND UserableType = N'Librarian'
	COMMIT TRANSACTION
	END TRY
	BEGIN CATCH
        ROLLBACK TRANSACTION
		
		DECLARE @ErrorMessage VARCHAR(MAX), @ErrorSeverity INT, @ErrorState INT
		SET @ErrorMessage  = ERROR_MESSAGE()
		SET @ErrorSeverity = ERROR_SEVERITY()
		SET @ErrorState    = ERROR_STATE()

		RAISERROR(@ErrorMessage, @ErrorSeverity, @ErrorState)
    END CATCH
END
GO
/****** Object:  StoredProcedure [dbo].[sp_delete_login]    Script Date: 6/14/2022 2:09:57 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_delete_login]
	@loginname NVARCHAR(50)
AS
BEGIN
	BEGIN TRY
		BEGIN TRANSACTION
		DECLARE @sql NVARCHAR(MAX),
				@username NVARCHAR(50)

		-- username
		SELECT @username = name FROM sys.sysusers WHERE sid = SUSER_SID(@loginname)

		-- drop login
		SET @sql = 'DROP LOGIN [' + @loginname + ']'
		EXECUTE(@sql)

		-- drop usre
		SET @sql = 'DROP USER [' + @username + ']'
		EXECUTE(@sql)

		COMMIT TRANSACTION
	END TRY
	BEGIN CATCH
        ROLLBACK TRANSACTION
		
		DECLARE @ErrorMessage VARCHAR(MAX), @ErrorSeverity INT, @ErrorState INT
		SET @ErrorMessage  = ERROR_MESSAGE()
		SET @ErrorSeverity = ERROR_SEVERITY()
		SET @ErrorState    = ERROR_STATE()

		RAISERROR(@ErrorMessage, @ErrorSeverity, @ErrorState)
    END CATCH
END
GO
/****** Object:  StoredProcedure [dbo].[sp_drop_login]    Script Date: 6/14/2022 2:09:57 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_drop_login]
	@loginname NVARCHAR(50)
AS
BEGIN
	BEGIN TRY
		BEGIN TRANSACTION
		DECLARE @sql NVARCHAR(MAX)

		SET @sql = 'DROP LOGIN ' + @loginname
		EXECUTE (@sql)

		DECLARE @username NVARCHAR(50)
		SELECT @username = name FROM sys.sysusers WHERE sid = SUSER_ID(@loginname)

		SET @sql = 'DROP USER ' + @username
		EXECUTE (@sql)

		COMMIT TRANSACTION
	END TRY
	BEGIN CATCH
        ROLLBACK TRANSACTION
		
		DECLARE @ErrorMessage VARCHAR(MAX), @ErrorSeverity INT, @ErrorState INT
		SET @ErrorMessage  = ERROR_MESSAGE()
		SET @ErrorSeverity = ERROR_SEVERITY()
		SET @ErrorState    = ERROR_STATE()

		RAISERROR(@ErrorMessage, @ErrorSeverity, @ErrorState)
    END CATCH
END
GO
/****** Object:  StoredProcedure [dbo].[sp_get_all_roles_of_user]    Script Date: 6/14/2022 2:09:57 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_get_all_roles_of_user]
	@loginname NVARCHAR(50)
AS
BEGIN
	DECLARE @username NVARCHAR(50)
	SELECT @username = name FROM sys.sysusers WHERE sid = SUSER_SID(@loginname)

	SELECT R.name FROM (SELECT * FROM sysusers WHERE issqlrole = 1) AS R
	INNER JOIN sysmembers M ON R.uid = M.groupuid AND M.memberuid = USER_ID(@username)
END
GO
/****** Object:  StoredProcedure [dbo].[sp_get_sgrants_of_role]    Script Date: 6/14/2022 2:09:57 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_get_sgrants_of_role]
	@role_name NVARCHAR(255)
AS
BEGIN
	SELECT TABLE_NAME,
		(CASE WHEN [SELECT] IS NOT NULL THEN CAST(1 AS BIT) ELSE CAST(0 AS BIT) END) AS [SELECT],
		(CASE WHEN [INSERT] IS NOT NULL THEN CAST(1 AS BIT) ELSE CAST(0 AS BIT) END) AS [INSERT],
		(CASE WHEN [UPDATE] IS NOT NULL THEN CAST(1 AS BIT) ELSE CAST(0 AS BIT) END) AS [UPDATE],
		(CASE WHEN [DELETE] IS NOT NULL THEN CAST(1 AS BIT) ELSE CAST(0 AS BIT) END) AS [DELETE]
	FROM
	(
		SELECT B.permission_name, T.TABLE_NAME FROM INFORMATION_SCHEMA.TABLES T
		LEFT JOIN (
			SELECT major_id, permission_name FROM sys.database_permissions P 
			INNER JOIN sysusers U ON U.uid = P.grantee_principal_id and U.name = @role_name
		) AS B ON B.major_id = OBJECT_ID(T.TABLE_NAME)
		WHERE TABLE_NAME != 'sysdiagrams'
	) AS A
	PIVOT  
	(  
	  MAX(permission_name)  
	  FOR permission_name  IN ([SELECT], [INSERT], [UPDATE], [DELETE])
	) AS PivotTable;
END
GO
/****** Object:  StoredProcedure [dbo].[sp_librarian_login]    Script Date: 6/14/2022 2:09:57 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_librarian_login]
	@username NVARCHAR(50),
	@password_digest NVARCHAR(MAX)
AS
BEGIN
	DECLARE @librarian_id NCHAR(10), @enable BIT
	SELECT @librarian_id = UserableId, @enable = Enable FROM Account WHERE Username = @username AND PasswordDigest = @password_digest AND UserableType = N'Librarian'

	IF @librarian_id IS NULL
		RAISERROR('Thông tin đăng nhập không chính xác!', 16 , 1) WITH NOWAIT
	
	IF @enable = 'False'
		RAISERROR('Tài khoản đang bị khóa hoặc chưa được kích hoạt!', 16 , 1) WITH NOWAIT

	SELECT * FROM Librarian WHERE Librarian.Id = @librarian_id
END
GO
/****** Object:  StoredProcedure [dbo].[sp_update_author]    Script Date: 6/14/2022 2:09:57 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_update_author]
	@id NCHAR(10),
	@first_name NVARCHAR(30),
	@last_name NVARCHAR(50),
	@birthday DATE,
	@sex BIT,
	@address NVARCHAR(150),
	@email NVARCHAR(150)
AS
BEGIN
	UPDATE Author
		SET FirstName = @first_name,
			LastName = @last_name,
			Birthday = @birthday,
			Sex = @sex,
			Address = @address,
			Email = @email
	WHERE Id = @id
END
GO
/****** Object:  StoredProcedure [dbo].[sp_update_book]    Script Date: 6/14/2022 2:09:57 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_update_book]
	@id NCHAR(10),
	@size SMALLINT,
	@notes NVARCHAR(MAX),
	@case_id INT,
	@book_title_isbn NCHAR(13),
	@librarian_id NCHAR(10),
	@status SMALLINT
AS
BEGIN
	UPDATE Book
		SET Size = @size,
			Notes = @notes,
			CaseId = @case_id,
			BookTitleISBN = @book_title_isbn,
			LibrarianId = @librarian_id,
			Status = @status
	WHERE Id = @id
END
GO
/****** Object:  StoredProcedure [dbo].[sp_update_book_title]    Script Date: 6/14/2022 2:09:57 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_update_book_title]
	@ISBN NCHAR(13),
	@name NVARCHAR(MAX),
	@pages INT,
	@price MONEY,
	@release_date DATE,
	@publisher_id NCHAR(10),
	@categories NVARCHAR(MAX),
	@authors NVARCHAR(MAX)
AS
BEGIN
	BEGIN TRY
		BEGIN TRANSACTION

		UPDATE BookTitle
			SET Name = @name,
				Pages = @pages,
				Price = @price,
				ReleaseDate = @release_date,
				PublisherId = @publisher_id
		WHERE ISBN = @ISBN

		DELETE FROM BookTitle_BookCategory WHERE BookTitleISBN = @isbn

		INSERT INTO BookTitle_BookCategory
		SELECT @ISBN as BookTitleISBN, value as BookCategoryId FROM STRING_SPLIT(@categories, ',');

		DELETE FROM BookTitle_Author WHERE BookTitleISBN = @isbn

		INSERT INTO BookTitle_Author
		SELECT @ISBN as BookTitleISBN, value as AuthorId FROM STRING_SPLIT(@authors, ',');

	COMMIT TRANSACTION
	END TRY
	BEGIN CATCH
        ROLLBACK TRANSACTION
		
		DECLARE @ErrorMessage VARCHAR(MAX), @ErrorSeverity INT, @ErrorState INT
		SET @ErrorMessage  = ERROR_MESSAGE()
		SET @ErrorSeverity = ERROR_SEVERITY()
		SET @ErrorState    = ERROR_STATE()

		RAISERROR(@ErrorMessage, @ErrorSeverity, @ErrorState)
    END CATCH
END
GO
/****** Object:  StoredProcedure [dbo].[sp_update_lending_slip]    Script Date: 6/14/2022 2:09:57 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_update_lending_slip]
	@id INT,
	@reader_id NCHAR(10),
	@created_by_librarian_id NCHAR(10)
AS
BEGIN
	UPDATE LendingSlip
		SET ReaderId = @reader_id,
			CreatedByLibrarianId = @created_by_librarian_id
	WHERE Id = @id
END
GO
/****** Object:  StoredProcedure [dbo].[sp_update_lending_slip_detail]    Script Date: 6/14/2022 2:09:57 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_update_lending_slip_detail]
	@book_id NCHAR(10),
	@lending_slip_id INT,
	@due_back_date DATETIME,
	@notes NVARCHAR(MAX)
AS
BEGIN
	UPDATE LendingSlipDetail
		SET DueBackDate = @due_back_date,
			Notes = @notes
	WHERE BookId = @book_id AND LendingSlipId = @lending_slip_id
END
GO
/****** Object:  StoredProcedure [dbo].[sp_update_lending_slip_detail_extended]    Script Date: 6/14/2022 2:09:57 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[sp_update_lending_slip_detail_extended]
	@book_id NVARCHAR(10),
	@lending_slip_id BIGINT,
	@librarian_id NVARCHAR(10)
AS
BEGIN
	BEGIN TRY
		BEGIN TRANSACTION

		DECLARE @due_back_date DATETIME, @extended BIT
		SELECT @due_back_date = DueBackDate, @extended = Extended FROM LendingSlipDetail WHERE BookId = @book_id AND LendingSlipId = @lending_slip_id
		IF @extended = 'true'
			RAISERROR('Đã từng gia hạn, không thể gia hạn thêm được nữa', 16, 1) WITH NOWAIT

		UPDATE LendingSlipDetail
			SET Extended = 'true',
				DueBackDate = DATEADD(day, 7, @due_back_date),
				ExtendedBy = @librarian_id,
				ExtendedAt = CURRENT_TIMESTAMP
		WHERE BookId = @book_id AND LendingSlipId = @lending_slip_id 

		COMMIT TRANSACTION
	END TRY
	BEGIN CATCH
        ROLLBACK TRANSACTION
		
		DECLARE @ErrorMessage VARCHAR(MAX), @ErrorSeverity INT, @ErrorState INT
		SET @ErrorMessage  = ERROR_MESSAGE()
		SET @ErrorSeverity = ERROR_SEVERITY()
		SET @ErrorState    = ERROR_STATE()

		RAISERROR(@ErrorMessage, @ErrorSeverity, @ErrorState)
    END CATCH
END
GO
/****** Object:  StoredProcedure [dbo].[sp_update_lending_slip_detail_took_back]    Script Date: 6/14/2022 2:09:57 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[sp_update_lending_slip_detail_took_back]
	@book_id NVARCHAR(10),
	@lending_slip_id BIGINT,
	@librarian_id NVARCHAR(10)
AS
BEGIN
	BEGIN TRY
		BEGIN TRANSACTION

		UPDATE LendingSlipDetail
			SET TookBack = 'true',
				TookBackAt = CURRENT_TIMESTAMP,
				TookBackBy = @librarian_id
		WHERE BookId = @book_id AND LendingSlipId = @lending_slip_id

		UPDATE Book
		SET Lending = 'false'
		WHERE Id = @book_id

		COMMIT TRANSACTION
	END TRY
	BEGIN CATCH
        ROLLBACK TRANSACTION
		
		DECLARE @ErrorMessage NVARCHAR(MAX), @ErrorSeverity INT, @ErrorState INT
		SET @ErrorMessage  = ERROR_MESSAGE()
		SET @ErrorSeverity = ERROR_SEVERITY()
		SET @ErrorState    = ERROR_STATE()

		RAISERROR(@ErrorMessage, @ErrorSeverity, @ErrorState)
    END CATCH
END
GO
/****** Object:  StoredProcedure [dbo].[sp_update_librarian]    Script Date: 6/14/2022 2:09:57 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_update_librarian]
	@id NCHAR(10),
	@first_name NVARCHAR(30),
	@last_name NVARCHAR(50),
	@birthday DATE,
	@sex BIT,
	@address NVARCHAR(150),
	@email NVARCHAR(150),
	@username NVARCHAR(50),
	@password_digest NVARCHAR(100),
	@enable BIT
AS
BEGIN
	BEGIN TRY
		BEGIN TRANSACTION

		UPDATE Librarian
		SET FirstName = @first_name,
			LastName = @last_name,
			Birthday = @birthday,
			Sex = @sex,
			Address = @address,
			Email = @email
		WHERE Id = @id

		IF @username != ''
		BEGIN
			IF @password_digest != ''
			BEGIN
				UPDATE Account
				SET Username = @username,
					PasswordDigest = @password_digest,
					Enable = @enable
				WHERE UserableId = @id AND UserableType = N'Librarian'
			END
			ELSE
			BEGIN
				UPDATE Account
				SET Username = @username,
					Enable = @enable
				WHERE UserableId = @id AND UserableType = N'Librarian'
			END
		END

		COMMIT TRANSACTION
	END TRY
	BEGIN CATCH
        ROLLBACK TRANSACTION
		
		DECLARE @ErrorMessage VARCHAR(MAX), @ErrorSeverity INT, @ErrorState INT
		SET @ErrorMessage  = ERROR_MESSAGE()
		SET @ErrorSeverity = ERROR_SEVERITY()
		SET @ErrorState    = ERROR_STATE()

		RAISERROR(@ErrorMessage, @ErrorSeverity, @ErrorState)
    END CATCH
END
GO
/****** Object:  StoredProcedure [dbo].[sp_update_librarian_account]    Script Date: 6/14/2022 2:09:57 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_update_librarian_account]
	@librarian_id NCHAR(10),
	@username NVARCHAR(50),
	@password_digest NVARCHAR(MAX)
AS
BEGIN
	UPDATE Account
		SET Username = @username,
			PasswordDigest = @password_digest
	WHERE UserableId = @librarian_id AND UserableType = N'Librarian'
END
GO
/****** Object:  StoredProcedure [dbo].[sp_update_librarian_include_account]    Script Date: 6/14/2022 2:09:57 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_update_librarian_include_account]
	@id NCHAR(10),
	@first_name NVARCHAR(30),
	@last_name NVARCHAR(50),
	@birthday DATE,
	@sex BIT,
	@address NVARCHAR(150),
	@email NVARCHAR(150),
	@username NVARCHAR(50),
	@password NVARCHAR(MAX),
	@enable bit
AS
BEGIN
	BEGIN TRY
		BEGIN TRANSACTION

		UPDATE Librarian
		SET FirstName = @first_name,
			LastName = @last_name,
			Birthday = @birthday,
			Sex = @sex,
			Address = @address,
			Email = @email
		WHERE Id = @id

		UPDATE Account
		SET Username = @username,
			PasswordDigest = @password,
			Enable = @enable
		WHERE UserableId = @id AND UserableType = N'Librarian'

		COMMIT TRANSACTION
	END TRY
	BEGIN CATCH
        ROLLBACK TRANSACTION
		
		DECLARE @ErrorMessage VARCHAR(MAX), @ErrorSeverity INT, @ErrorState INT
		SET @ErrorMessage  = ERROR_MESSAGE()
		SET @ErrorSeverity = ERROR_SEVERITY()
		SET @ErrorState    = ERROR_STATE()

		RAISERROR(@ErrorMessage, @ErrorSeverity, @ErrorState)
    END CATCH
END
GO
/****** Object:  StoredProcedure [dbo].[sp_update_library_card]    Script Date: 6/14/2022 2:09:57 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[sp_update_library_card]
	@id BIGINT,
	@effective_date DATETIME,
	@effective_end_date DATETIME,
	@fee MONEY,
	@reader_id NCHAR(10),
	@created_by NCHAR(10)
as
begin
	UPDATE LibraryCard
		SET EffectiveDate = @effective_date,
			EffectiveEndDate = @effective_end_date
	WHERE Id = @id
end
GO
/****** Object:  StoredProcedure [dbo].[sp_update_login]    Script Date: 6/14/2022 2:09:57 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[sp_update_login]
	@loginname NVARCHAR(50),
	@password NVARCHAR(50),
	@roles NVARCHAR(MAX)
AS
BEGIN
	BEGIN TRY
		BEGIN TRANSACTION
		DECLARE @sql NVARCHAR(MAX),
				@username NVARCHAR(50)

		-- username
		SELECT @username = name FROM sys.sysusers WHERE sid = SUSER_SID(@loginname)

		-- Change password
		IF @password IS NOT NULL AND TRIM(@password) != ''
		BEGIN
			SET @sql = 'ALTER LOGIN [' + @loginname + '] WITH PASSWORD=N''' + @password + ''''
			EXECUTE (@sql)
		END

		-- remove roles
		SET @sql = (
			SELECT STRING_AGG(CAST(N'ALTER ROLE ' + QUOTENAME(R.name) + N' DROP MEMBER ' + QUOTENAME(@username) + N';' AS NVARCHAR(MAX)), NCHAR(10))
			FROM (SELECT * FROM sysusers WHERE issqlrole = 1) AS R
			INNER JOIN sysmembers M ON R.uid = M.groupuid AND M.memberuid = USER_ID(@username)
		)
		EXECUTE(@sql)

		-- add roles
		IF (@roles != '')
		BEGIN
			SET @sql = NULL
			SELECT @sql = COALESCE(@sql + ' ', '') + 'ALTER ROLE ' + value + ' ADD MEMBER ' + @username FROM STRING_SPLIT(@roles, ',')
			EXECUTE (@sql)
		END

		COMMIT TRANSACTION
	END TRY
	BEGIN CATCH
        ROLLBACK TRANSACTION
		
		DECLARE @ErrorMessage VARCHAR(MAX), @ErrorSeverity INT, @ErrorState INT
		SET @ErrorMessage  = ERROR_MESSAGE()
		SET @ErrorSeverity = ERROR_SEVERITY()
		SET @ErrorState    = ERROR_STATE()

		RAISERROR(@ErrorMessage, @ErrorSeverity, @ErrorState)
    END CATCH
END
GO
/****** Object:  StoredProcedure [dbo].[sp_update_reader]    Script Date: 6/14/2022 2:09:57 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROCEDURE [dbo].[sp_update_reader]
	@id NCHAR(10),
	@first_name NVARCHAR(30),
	@last_name NVARCHAR(50),
	@birthday DATE,
	@sex BIT,
	@address NVARCHAR(150),
	@email NVARCHAR(150),
	@phone_number NVARCHAR(20),
	@librarian_id NCHAR(10)
AS
BEGIN
	UPDATE Reader
		SET FirstName = @first_name,
			LastName = @last_name,
			Birthday = @birthday,
			Sex = @sex,
			Address = @address,
			Email = @email,
			PhoneNumber = @phone_number,
			LibrarianId = @librarian_id
	WHERE Id = @id
END
GO
/****** Object:  Trigger [dbo].[tr_after_insert_lending_slip_detail]    Script Date: 6/14/2022 2:09:57 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TRIGGER [dbo].[tr_after_insert_lending_slip_detail] ON [dbo].[LendingSlipDetail]
AFTER INSERT
AS
BEGIN
	UPDATE Book
		SET Lending = 'true'
	WHERE Id IN (SELECT BookId FROM inserted)
END
GO
ALTER TABLE [dbo].[LendingSlipDetail] ENABLE TRIGGER [tr_after_insert_lending_slip_detail]
GO
/****** Object:  Trigger [dbo].[tr_after_insert_liquidating_slip_detail]    Script Date: 6/14/2022 2:09:57 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TRIGGER  [dbo].[tr_after_insert_liquidating_slip_detail]
   ON  [dbo].[LiquidatingSlipDetail]
   AFTER INSERT 
AS 
BEGIN
    UPDATE Book SET status = 4 
    WHERE Id IN (SELECT BookId FROM inserted)
END
GO
ALTER TABLE [dbo].[LiquidatingSlipDetail] ENABLE TRIGGER [tr_after_insert_liquidating_slip_detail]
GO
USE [master]
GO
ALTER DATABASE [QLTV] SET  READ_WRITE 
GO
