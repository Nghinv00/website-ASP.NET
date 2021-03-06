USE [master]
GO
/****** Object:  Database [WebsiteFilm]    Script Date: 15/03/2017 9:41:01 SA ******/
CREATE DATABASE [WebsiteFilm]
 CONTAINMENT = NONE
GO
ALTER DATABASE [WebsiteFilm] SET COMPATIBILITY_LEVEL = 110
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [WebsiteFilm].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [WebsiteFilm] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [WebsiteFilm] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [WebsiteFilm] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [WebsiteFilm] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [WebsiteFilm] SET ARITHABORT OFF 
GO
ALTER DATABASE [WebsiteFilm] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [WebsiteFilm] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [WebsiteFilm] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [WebsiteFilm] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [WebsiteFilm] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [WebsiteFilm] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [WebsiteFilm] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [WebsiteFilm] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [WebsiteFilm] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [WebsiteFilm] SET  DISABLE_BROKER 
GO
ALTER DATABASE [WebsiteFilm] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [WebsiteFilm] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [WebsiteFilm] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [WebsiteFilm] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [WebsiteFilm] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [WebsiteFilm] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [WebsiteFilm] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [WebsiteFilm] SET RECOVERY FULL 
GO
ALTER DATABASE [WebsiteFilm] SET  MULTI_USER 
GO
ALTER DATABASE [WebsiteFilm] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [WebsiteFilm] SET DB_CHAINING OFF 
GO
ALTER DATABASE [WebsiteFilm] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [WebsiteFilm] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
EXEC sys.sp_db_vardecimal_storage_format N'WebsiteFilm', N'ON'
GO
USE [WebsiteFilm]
GO
/****** Object:  Table [dbo].[Account]    Script Date: 15/03/2017 9:41:01 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Account](
	[idAcc] [int] IDENTITY(1,1) NOT NULL,
	[idEmp] [int] NOT NULL,
	[Username] [nvarchar](2000) NOT NULL,
	[Password] [nvarchar](2000) NOT NULL,
	[Permission] [int] NOT NULL,
	[State] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[idAcc] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Category]    Script Date: 15/03/2017 9:41:01 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Category](
	[CategoryID] [int] NOT NULL,
	[CategoryName] [nvarchar](2000) NULL,
PRIMARY KEY CLUSTERED 
(
	[CategoryID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[DetailMovie]    Script Date: 15/03/2017 9:41:01 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DetailMovie](
	[IdDetail] [int] IDENTITY(1,1) NOT NULL,
	[MovieID] [int] NULL,
	[MoviePart] [nvarchar](2000) NOT NULL,
	[ImagePicture] [nvarchar](2000) NULL,
	[Note] [nvarchar](2000) NULL,
PRIMARY KEY CLUSTERED 
(
	[IdDetail] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[DoanhThu]    Script Date: 15/03/2017 9:41:01 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DoanhThu](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Domain] [money] NULL,
	[Hosting] [money] NULL,
	[MuaPhim] [money] NULL,
	[BanPhim] [money] NULL,
	[BaoTri] [money] NULL,
	[TongSoDu] [money] NULL,
	[IdEmployee] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Employee]    Script Date: 15/03/2017 9:41:01 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Employee](
	[idEmp] [int] IDENTITY(1,1) NOT NULL,
	[NameEmp] [nvarchar](2000) NOT NULL,
	[Phone] [nvarchar](2000) NOT NULL,
	[Address] [nvarchar](2000) NOT NULL,
	[Birthday] [datetime] NULL,
	[Sex] [bit] NULL,
	[Note] [nvarchar](2000) NULL,
PRIMARY KEY CLUSTERED 
(
	[idEmp] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Movie]    Script Date: 15/03/2017 9:41:01 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Movie](
	[MovieID] [int] NOT NULL,
	[MovieName] [nvarchar](2000) NULL,
	[URLDetail] [nvarchar](2000) NULL,
	[LinkImage] [nvarchar](2000) NULL,
	[Descriptions] [nvarchar](2000) NULL,
	[Director] [nvarchar](2000) NULL,
	[Writer] [nvarchar](2000) NULL,
	[Stars] [nvarchar](2000) NULL,
	[YearProduce] [int] NULL,
	[AddressProduce] [nvarchar](2000) NULL,
	[RunningTime] [nvarchar](2000) NULL,
	[ReleaseDate] [date] NULL,
	[ReleaseAddress] [nvarchar](2000) NULL,
	[Img] [image] NULL,
	[idEmp] [int] NULL,
	[New] [nvarchar](2000) NULL,
	[CategoryID] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[MovieID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[MovieSuggest]    Script Date: 15/03/2017 9:41:01 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MovieSuggest](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Session] [nvarchar](50) NULL,
	[List] [nvarchar](50) NULL,
 CONSTRAINT [PK_MovieSuggest] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[MovieUser]    Script Date: 15/03/2017 9:41:01 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MovieUser](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[IdUser] [int] NOT NULL,
	[IdMovie] [int] NOT NULL,
	[ThoiGianXem] [nvarchar](2000) NOT NULL,
	[Secsion] [nvarchar](2000) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Occupation]    Script Date: 15/03/2017 9:41:01 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Occupation](
	[OccupationID] [int] NOT NULL,
	[OccupationName] [nvarchar](2000) NULL,
PRIMARY KEY CLUSTERED 
(
	[OccupationID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[PhimChuaKiemDuyet]    Script Date: 15/03/2017 9:41:01 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PhimChuaKiemDuyet](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[MovieID] [int] NULL,
	[MovieName] [nvarchar](2000) NULL,
	[URLDetail] [nvarchar](2000) NULL,
	[LinkImage] [nvarchar](2000) NULL,
	[Descriptions] [nvarchar](2000) NULL,
	[Director] [nvarchar](2000) NULL,
	[Writer] [nvarchar](2000) NULL,
	[Stars] [nvarchar](2000) NULL,
	[YearProduce] [int] NULL,
	[AddressProduce] [nvarchar](2000) NULL,
	[RunningTime] [nvarchar](2000) NULL,
	[ReleaseDate] [date] NULL,
	[ReleaseAddress] [nvarchar](2000) NULL,
	[Img] [image] NULL,
	[idEmp] [int] NULL,
	[new] [nvarchar](2000) NULL,
	[CategoryID] [int] NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[RatingOfMovie]    Script Date: 15/03/2017 9:41:01 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[RatingOfMovie](
	[MaThanhVien] [int] NOT NULL,
	[MovieID] [int] NOT NULL,
	[Rating] [int] NULL,
	[Data] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[MaThanhVien] ASC,
	[MovieID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Table1]    Script Date: 15/03/2017 9:41:01 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Table1](
	[A] [int] NULL,
	[B] [int] NULL,
	[C] [int] NULL,
	[D] [int] NULL,
	[E] [int] NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Table2]    Script Date: 15/03/2017 9:41:01 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Table2](
	[AB] [int] NULL,
	[AC] [int] NULL,
	[AD] [int] NULL,
	[AE] [int] NULL,
	[BC] [int] NULL,
	[BD] [int] NULL,
	[BE] [int] NULL,
	[CD] [int] NULL,
	[CE] [int] NULL,
	[DE] [int] NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[ThanhVien]    Script Date: 15/03/2017 9:41:01 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ThanhVien](
	[MaThanhVien] [int] IDENTITY(1,1) NOT NULL,
	[HoTen] [nvarchar](2000) NULL,
	[GioiTinh] [bit] NULL,
	[Passwords] [nvarchar](2000) NULL,
	[NgaySinh] [date] NULL,
	[Gmail] [nvarchar](200) NULL,
	[SoDienThoai] [int] NULL,
	[SoDuTaiKhoan] [float] NULL,
	[OccupationID] [int] NULL,
 CONSTRAINT [PK__ThanhVie__2BE0A0F01B13B044] PRIMARY KEY CLUSTERED 
(
	[MaThanhVien] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET IDENTITY_INSERT [dbo].[Account] ON 

INSERT [dbo].[Account] ([idAcc], [idEmp], [Username], [Password], [Permission], [State]) VALUES (13, 1, N'manager', N'123456', 1, 1)
INSERT [dbo].[Account] ([idAcc], [idEmp], [Username], [Password], [Permission], [State]) VALUES (14, 2, N'admin', N'123456', 2, 0)
INSERT [dbo].[Account] ([idAcc], [idEmp], [Username], [Password], [Permission], [State]) VALUES (15, 3, N'admin2', N'123456', 2, 1)
SET IDENTITY_INSERT [dbo].[Account] OFF
INSERT [dbo].[Category] ([CategoryID], [CategoryName]) VALUES (0, N'unknown')
INSERT [dbo].[Category] ([CategoryID], [CategoryName]) VALUES (1, N'Action')
INSERT [dbo].[Category] ([CategoryID], [CategoryName]) VALUES (2, N'Adventure')
INSERT [dbo].[Category] ([CategoryID], [CategoryName]) VALUES (3, N'Animation')
INSERT [dbo].[Category] ([CategoryID], [CategoryName]) VALUES (4, N'Children''s')
INSERT [dbo].[Category] ([CategoryID], [CategoryName]) VALUES (5, N'Comedy')
INSERT [dbo].[Category] ([CategoryID], [CategoryName]) VALUES (6, N'Crime')
INSERT [dbo].[Category] ([CategoryID], [CategoryName]) VALUES (7, N'Documen')
INSERT [dbo].[Category] ([CategoryID], [CategoryName]) VALUES (8, N'Drama')
INSERT [dbo].[Category] ([CategoryID], [CategoryName]) VALUES (9, N'Fantasy')
INSERT [dbo].[Category] ([CategoryID], [CategoryName]) VALUES (10, N'Film-Noir')
INSERT [dbo].[Category] ([CategoryID], [CategoryName]) VALUES (11, N'Horror')
INSERT [dbo].[Category] ([CategoryID], [CategoryName]) VALUES (12, N'Musical')
INSERT [dbo].[Category] ([CategoryID], [CategoryName]) VALUES (13, N'Mystery')
INSERT [dbo].[Category] ([CategoryID], [CategoryName]) VALUES (14, N'Romance')
INSERT [dbo].[Category] ([CategoryID], [CategoryName]) VALUES (15, N'Sci-Fi')
INSERT [dbo].[Category] ([CategoryID], [CategoryName]) VALUES (16, N'Thriller')
INSERT [dbo].[Category] ([CategoryID], [CategoryName]) VALUES (17, N'War')
INSERT [dbo].[Category] ([CategoryID], [CategoryName]) VALUES (18, N'Western')
SET IDENTITY_INSERT [dbo].[DetailMovie] ON 

INSERT [dbo].[DetailMovie] ([IdDetail], [MovieID], [MoviePart], [ImagePicture], [Note]) VALUES (5, 4, N'7 Anh Em Hồ Lô Phần 1', N'7AEHoLo1.jpg', N'https://www.youtube.com/embed/FERai-9bJlw')
INSERT [dbo].[DetailMovie] ([IdDetail], [MovieID], [MoviePart], [ImagePicture], [Note]) VALUES (6, 4, N'7 Anh Em Hồ Lô Phần 2', N'7AEHoLo2.jpg', N'https://www.youtube.com/embed/c00KJQ1RmFs')
INSERT [dbo].[DetailMovie] ([IdDetail], [MovieID], [MoviePart], [ImagePicture], [Note]) VALUES (7, 1, N'Tom And Jerry  tập 1 ', N'TomJerry1.jpg', N'link 1')
INSERT [dbo].[DetailMovie] ([IdDetail], [MovieID], [MoviePart], [ImagePicture], [Note]) VALUES (8, 1, N'Tom And jerry Tập 2', N'Tomjerry2.jpg', N'link 2')
SET IDENTITY_INSERT [dbo].[DetailMovie] OFF
SET IDENTITY_INSERT [dbo].[Employee] ON 

INSERT [dbo].[Employee] ([idEmp], [NameEmp], [Phone], [Address], [Birthday], [Sex], [Note]) VALUES (1, N'Nguyễn Văn An', N'123', N'Hà Nội', NULL, NULL, N'Quản Trị Hệ Thống')
INSERT [dbo].[Employee] ([idEmp], [NameEmp], [Phone], [Address], [Birthday], [Sex], [Note]) VALUES (2, N'Nguyễn Thị Hoa', N'456', N'Hải Phòng', NULL, NULL, N'Admin')
INSERT [dbo].[Employee] ([idEmp], [NameEmp], [Phone], [Address], [Birthday], [Sex], [Note]) VALUES (3, N'Nguyễn Văn Công', N'789', N'Hà Nội', NULL, NULL, N'Admin  2')
SET IDENTITY_INSERT [dbo].[Employee] OFF
INSERT [dbo].[Movie] ([MovieID], [MovieName], [URLDetail], [LinkImage], [Descriptions], [Director], [Writer], [Stars], [YearProduce], [AddressProduce], [RunningTime], [ReleaseDate], [ReleaseAddress], [Img], [idEmp], [New], [CategoryID]) VALUES (1, N'Toy Story (1995)
', N'https://www.youtube.com/embed/g4lOFeicCW0', N'1.jpg', N'abc', N'abc', N'acc', N'bca', 2000, NULL, N'10:20', CAST(N'2010-01-01' AS Date), NULL, NULL, NULL, N'1', 1)
INSERT [dbo].[Movie] ([MovieID], [MovieName], [URLDetail], [LinkImage], [Descriptions], [Director], [Writer], [Stars], [YearProduce], [AddressProduce], [RunningTime], [ReleaseDate], [ReleaseAddress], [Img], [idEmp], [New], [CategoryID]) VALUES (2, N'GoldenEye (1995)
', N'https://www.youtube.com/embed/h1ud3ngzt4A', N'2.jpg', N'd', N'ab', N'cie', N'ab', 1995, NULL, N'01:06:23', CAST(N'1995-11-13' AS Date), NULL, NULL, NULL, N'1', 1)
INSERT [dbo].[Movie] ([MovieID], [MovieName], [URLDetail], [LinkImage], [Descriptions], [Director], [Writer], [Stars], [YearProduce], [AddressProduce], [RunningTime], [ReleaseDate], [ReleaseAddress], [Img], [idEmp], [New], [CategoryID]) VALUES (3, N'Four Rooms (1995)
', N'https://www.youtube.com/embed/S_Pd2pGkq54', N'3.jpg', N'abc', N'acc', N'add', N'abc', 2016, NULL, N'24:25', CAST(N'2017-10-01' AS Date), NULL, NULL, NULL, N'1', 3)
INSERT [dbo].[Movie] ([MovieID], [MovieName], [URLDetail], [LinkImage], [Descriptions], [Director], [Writer], [Stars], [YearProduce], [AddressProduce], [RunningTime], [ReleaseDate], [ReleaseAddress], [Img], [idEmp], [New], [CategoryID]) VALUES (4, N'Get Shorty (1995)
', N'https://www.youtube.com/embed/yNLaTtpovys', N'4.jpg', N'agc', N'acc', N'ass', N'abc', 2015, NULL, N'01:02:10', CAST(N'2015-01-02' AS Date), NULL, NULL, NULL, N'1', 4)
INSERT [dbo].[Movie] ([MovieID], [MovieName], [URLDetail], [LinkImage], [Descriptions], [Director], [Writer], [Stars], [YearProduce], [AddressProduce], [RunningTime], [ReleaseDate], [ReleaseAddress], [Img], [idEmp], [New], [CategoryID]) VALUES (5, N'Copycat (1995)
', N'https://www.youtube.com/embed/7DYWx_SwZDU', N'5.jpg', N'a', N'k', N'h', N'n', 2010, NULL, N'02:02', CAST(N'2010-02-02' AS Date), NULL, NULL, NULL, N'1', 5)
INSERT [dbo].[Movie] ([MovieID], [MovieName], [URLDetail], [LinkImage], [Descriptions], [Director], [Writer], [Stars], [YearProduce], [AddressProduce], [RunningTime], [ReleaseDate], [ReleaseAddress], [Img], [idEmp], [New], [CategoryID]) VALUES (6, N'Shanghai Triad (Yao a yao yao dao waipo qiao) (1995)
', N'https://www.youtube.com/embed/mQf3Ngg2cks', N'6.jpg', N'abc', N'abc', N'add', N'baa', 2010, NULL, N'12:12', CAST(N'2010-01-01' AS Date), NULL, NULL, NULL, N'1', 1)
INSERT [dbo].[Movie] ([MovieID], [MovieName], [URLDetail], [LinkImage], [Descriptions], [Director], [Writer], [Stars], [YearProduce], [AddressProduce], [RunningTime], [ReleaseDate], [ReleaseAddress], [Img], [idEmp], [New], [CategoryID]) VALUES (7, N'Twelve Monkeys (1995)
', N'https://www.youtube.com/embed/9gwHN87EoNE', N'7.jpg', N'are', N'aci', N'gjk', N'k', 2007, NULL, N'02:15:16', CAST(N'2007-02-08' AS Date), NULL, NULL, NULL, N'1', 2)
INSERT [dbo].[Movie] ([MovieID], [MovieName], [URLDetail], [LinkImage], [Descriptions], [Director], [Writer], [Stars], [YearProduce], [AddressProduce], [RunningTime], [ReleaseDate], [ReleaseAddress], [Img], [idEmp], [New], [CategoryID]) VALUES (8, N'Babe (1995)
', N'https://www.youtube.com/embed/Cg_UjjTex-U', N'8.jpg', N'JPG', N'jei', N'jngi', N'kdj', 2000, NULL, N'01:15:01', CAST(N'2000-02-15' AS Date), NULL, NULL, NULL, N'1', 3)
INSERT [dbo].[Movie] ([MovieID], [MovieName], [URLDetail], [LinkImage], [Descriptions], [Director], [Writer], [Stars], [YearProduce], [AddressProduce], [RunningTime], [ReleaseDate], [ReleaseAddress], [Img], [idEmp], [New], [CategoryID]) VALUES (9, N'Dead Man Walking (1995)
', N'https://www.youtube.com/embed/RPtbSQpjUSM', N'9.jpg', N'kj;l ', N'j j', N' v', N'jkll;ka', 2008, NULL, N'03:22', CAST(N'2008-08-15' AS Date), NULL, NULL, NULL, N'1', 4)
INSERT [dbo].[Movie] ([MovieID], [MovieName], [URLDetail], [LinkImage], [Descriptions], [Director], [Writer], [Stars], [YearProduce], [AddressProduce], [RunningTime], [ReleaseDate], [ReleaseAddress], [Img], [idEmp], [New], [CategoryID]) VALUES (10, N'Richard III (1995)
', N'https://www.youtube.com/embed/OXc0-EME0C8', N'10.jpg', N'a', N't', N't', N'g', 2010, NULL, N'02:02', CAST(N'1995-02-02' AS Date), NULL, NULL, NULL, N'1', 5)
INSERT [dbo].[Movie] ([MovieID], [MovieName], [URLDetail], [LinkImage], [Descriptions], [Director], [Writer], [Stars], [YearProduce], [AddressProduce], [RunningTime], [ReleaseDate], [ReleaseAddress], [Img], [idEmp], [New], [CategoryID]) VALUES (11, N'Seven (Se7en) (1995)
', N'https://www.youtube.com/embed/znmZoVkCjpI', N'11.jpg', N'klj ', N'  ị', N'q', N'q', 2002, NULL, N'01:15:00', CAST(N'2002-12-12' AS Date), NULL, NULL, NULL, N'1', 1)
INSERT [dbo].[Movie] ([MovieID], [MovieName], [URLDetail], [LinkImage], [Descriptions], [Director], [Writer], [Stars], [YearProduce], [AddressProduce], [RunningTime], [ReleaseDate], [ReleaseAddress], [Img], [idEmp], [New], [CategoryID]) VALUES (12, N'Usual Suspects, The (1995)
', N'https://www.youtube.com/embed/oiXdPolca5w', N'12.jpg', N'b', N't', N'd', N't', 1995, NULL, N'01:01:01', CAST(N'1994-12-06' AS Date), NULL, NULL, NULL, N'1', 2)
INSERT [dbo].[Movie] ([MovieID], [MovieName], [URLDetail], [LinkImage], [Descriptions], [Director], [Writer], [Stars], [YearProduce], [AddressProduce], [RunningTime], [ReleaseDate], [ReleaseAddress], [Img], [idEmp], [New], [CategoryID]) VALUES (13, N'Mighty Aphrodite (1995)
', N'https://www.youtube.com/embed/zLkA6SvZmZ4', N'13.jpg', N'c', N'r', N'v', N't', 1997, NULL, N'12:12', CAST(N'1994-03-12' AS Date), NULL, NULL, NULL, N'1', 3)
INSERT [dbo].[Movie] ([MovieID], [MovieName], [URLDetail], [LinkImage], [Descriptions], [Director], [Writer], [Stars], [YearProduce], [AddressProduce], [RunningTime], [ReleaseDate], [ReleaseAddress], [Img], [idEmp], [New], [CategoryID]) VALUES (14, N'Postino, Il (1994)
', N'https://www.youtube.com/embed/XXCC7SdJW1o', N'14.jpg', N'e', N'3', N'd', N'b', 1994, NULL, N'12:56', CAST(N'1995-03-03' AS Date), NULL, NULL, NULL, N'1', 4)
INSERT [dbo].[Movie] ([MovieID], [MovieName], [URLDetail], [LinkImage], [Descriptions], [Director], [Writer], [Stars], [YearProduce], [AddressProduce], [RunningTime], [ReleaseDate], [ReleaseAddress], [Img], [idEmp], [New], [CategoryID]) VALUES (15, N'Mr. Holland''s Opus (1995)
', N'https://www.youtube.com/embed/DazBAe9ncfw', N'15.jpg', N'd', N'a', N'q', N'2e', 1995, NULL, N'01:23:34', CAST(N'1996-12-01' AS Date), NULL, NULL, NULL, N'1', 5)
INSERT [dbo].[Movie] ([MovieID], [MovieName], [URLDetail], [LinkImage], [Descriptions], [Director], [Writer], [Stars], [YearProduce], [AddressProduce], [RunningTime], [ReleaseDate], [ReleaseAddress], [Img], [idEmp], [New], [CategoryID]) VALUES (16, N'French Twist (Gazon maudit) (1995)
', N'https://www.youtube.com/embed/Qd_88LUuHGU', N'16.jpg', N'g', N't', N't', N'q', 1995, NULL, N'02:12', CAST(N'1994-04-02' AS Date), NULL, NULL, NULL, N'1', 1)
INSERT [dbo].[Movie] ([MovieID], [MovieName], [URLDetail], [LinkImage], [Descriptions], [Director], [Writer], [Stars], [YearProduce], [AddressProduce], [RunningTime], [ReleaseDate], [ReleaseAddress], [Img], [idEmp], [New], [CategoryID]) VALUES (17, N'From Dusk Till Dawn (1996)
', N'https://www.youtube.com/embed/i1erT5ZuDHE', N'17.jpg', N'a', N'3', N'c', N'u', 1994, NULL, N'03:13', CAST(N'1995-08-08' AS Date), NULL, NULL, NULL, N'1', 2)
INSERT [dbo].[Movie] ([MovieID], [MovieName], [URLDetail], [LinkImage], [Descriptions], [Director], [Writer], [Stars], [YearProduce], [AddressProduce], [RunningTime], [ReleaseDate], [ReleaseAddress], [Img], [idEmp], [New], [CategoryID]) VALUES (18, N'White Balloon, The (1995)
', N'https://www.youtube.com/embed/jL4l_tyPC0Y', N'18.jpg', N'e', N'a', N't', N'g', 199, NULL, N'02:25', CAST(N'1994-07-12' AS Date), NULL, NULL, NULL, N'1', 3)
INSERT [dbo].[Movie] ([MovieID], [MovieName], [URLDetail], [LinkImage], [Descriptions], [Director], [Writer], [Stars], [YearProduce], [AddressProduce], [RunningTime], [ReleaseDate], [ReleaseAddress], [Img], [idEmp], [New], [CategoryID]) VALUES (19, N'Antonia''s Line (1995)
', N'https://www.youtube.com/embed/qiAyu1qKkfE', N'19.jpg', N'g', N'h', N'q', N'y', 1995, NULL, N'01:01:00', CAST(N'1996-05-12' AS Date), NULL, NULL, NULL, N'1', 4)
INSERT [dbo].[Movie] ([MovieID], [MovieName], [URLDetail], [LinkImage], [Descriptions], [Director], [Writer], [Stars], [YearProduce], [AddressProduce], [RunningTime], [ReleaseDate], [ReleaseAddress], [Img], [idEmp], [New], [CategoryID]) VALUES (20, N'Angels and Insects (1995)
', N'https://www.youtube.com/embed/LK07QAoU8sQ', N'20.jpg', N'c', N'c', N'c', N'r', 1996, NULL, N'02:02:02', CAST(N'1995-12-12' AS Date), NULL, NULL, NULL, N'1', 5)
SET IDENTITY_INSERT [dbo].[MovieSuggest] ON 

INSERT [dbo].[MovieSuggest] ([Id], [Session], [List]) VALUES (14, N'LISTFILM', N'1;21;3')
INSERT [dbo].[MovieSuggest] ([Id], [Session], [List]) VALUES (15, N'LISTFILM', N'2;3;4;5')
INSERT [dbo].[MovieSuggest] ([Id], [Session], [List]) VALUES (16, N'LISTFILM', N'4;51;3')
INSERT [dbo].[MovieSuggest] ([Id], [Session], [List]) VALUES (17, N'LISTFILM', N'1;2;5;3')
INSERT [dbo].[MovieSuggest] ([Id], [Session], [List]) VALUES (18, N'LISTFILM	', N'1;2;3;4')
INSERT [dbo].[MovieSuggest] ([Id], [Session], [List]) VALUES (19, N'LISTFILM	', N'4;510;12')
INSERT [dbo].[MovieSuggest] ([Id], [Session], [List]) VALUES (20, N'LISTFILM	', N'1;4;6;7')
INSERT [dbo].[MovieSuggest] ([Id], [Session], [List]) VALUES (21, N'LISTFILM	', N'2;10;13;20')
INSERT [dbo].[MovieSuggest] ([Id], [Session], [List]) VALUES (22, N'LISTFILM	', N'5;10;15;20')
INSERT [dbo].[MovieSuggest] ([Id], [Session], [List]) VALUES (23, N'LISTFILM	', N'4;5;6;7')
INSERT [dbo].[MovieSuggest] ([Id], [Session], [List]) VALUES (24, N'LISTFILM	', N'2;11;16;18')
INSERT [dbo].[MovieSuggest] ([Id], [Session], [List]) VALUES (25, N'LISTFILM	', N'3;5;7;9')
INSERT [dbo].[MovieSuggest] ([Id], [Session], [List]) VALUES (26, N'LISTFILM', N'4;5')
INSERT [dbo].[MovieSuggest] ([Id], [Session], [List]) VALUES (27, N'LISTFILM', N'2')
INSERT [dbo].[MovieSuggest] ([Id], [Session], [List]) VALUES (28, N'LISTFILM', N'2;5')
INSERT [dbo].[MovieSuggest] ([Id], [Session], [List]) VALUES (29, N'LISTFILM', N'10;11;20;15')
INSERT [dbo].[MovieSuggest] ([Id], [Session], [List]) VALUES (30, N'LISTFILM', N'14;15;16;17')
INSERT [dbo].[MovieSuggest] ([Id], [Session], [List]) VALUES (31, N'LISTFILM', N'15;16;17;18')
INSERT [dbo].[MovieSuggest] ([Id], [Session], [List]) VALUES (32, N'LISTFILM', N'18;19;20')
INSERT [dbo].[MovieSuggest] ([Id], [Session], [List]) VALUES (33, N'LISTFILM', N'7;8;9;10')
INSERT [dbo].[MovieSuggest] ([Id], [Session], [List]) VALUES (34, N'LISTFILM', N'2;5;9;1')
INSERT [dbo].[MovieSuggest] ([Id], [Session], [List]) VALUES (35, N'LISTFILM', N'1;3;5;2')
INSERT [dbo].[MovieSuggest] ([Id], [Session], [List]) VALUES (36, N'LISTFILM', N'3;7;5;4')
INSERT [dbo].[MovieSuggest] ([Id], [Session], [List]) VALUES (37, N'LISTFILM', N'8;10;4')
INSERT [dbo].[MovieSuggest] ([Id], [Session], [List]) VALUES (38, N'LISTFILM', N'9;3;2')
INSERT [dbo].[MovieSuggest] ([Id], [Session], [List]) VALUES (39, N'LISTFILM', N'7;10;6')
INSERT [dbo].[MovieSuggest] ([Id], [Session], [List]) VALUES (40, N'LISTFILM', N'6;7;9;8')
INSERT [dbo].[MovieSuggest] ([Id], [Session], [List]) VALUES (52, NULL, N'6;11')
INSERT [dbo].[MovieSuggest] ([Id], [Session], [List]) VALUES (53, NULL, N'2;10;15')
SET IDENTITY_INSERT [dbo].[MovieSuggest] OFF
INSERT [dbo].[Occupation] ([OccupationID], [OccupationName]) VALUES (1, N'administrator')
INSERT [dbo].[Occupation] ([OccupationID], [OccupationName]) VALUES (2, N'artist')
INSERT [dbo].[Occupation] ([OccupationID], [OccupationName]) VALUES (3, N'doctor')
INSERT [dbo].[Occupation] ([OccupationID], [OccupationName]) VALUES (4, N'educator')
INSERT [dbo].[Occupation] ([OccupationID], [OccupationName]) VALUES (5, N'engineer')
INSERT [dbo].[Occupation] ([OccupationID], [OccupationName]) VALUES (6, N'entertainment')
INSERT [dbo].[Occupation] ([OccupationID], [OccupationName]) VALUES (7, N'executive')
INSERT [dbo].[Occupation] ([OccupationID], [OccupationName]) VALUES (8, N'healthcare')
INSERT [dbo].[Occupation] ([OccupationID], [OccupationName]) VALUES (9, N'homemaker')
INSERT [dbo].[Occupation] ([OccupationID], [OccupationName]) VALUES (10, N'lawyer')
INSERT [dbo].[Occupation] ([OccupationID], [OccupationName]) VALUES (11, N'librarian')
INSERT [dbo].[Occupation] ([OccupationID], [OccupationName]) VALUES (12, N'marketing')
INSERT [dbo].[Occupation] ([OccupationID], [OccupationName]) VALUES (13, N'none')
INSERT [dbo].[Occupation] ([OccupationID], [OccupationName]) VALUES (14, N'other')
INSERT [dbo].[Occupation] ([OccupationID], [OccupationName]) VALUES (15, N'programmer')
INSERT [dbo].[Occupation] ([OccupationID], [OccupationName]) VALUES (16, N'retired')
INSERT [dbo].[Occupation] ([OccupationID], [OccupationName]) VALUES (17, N'salesman')
INSERT [dbo].[Occupation] ([OccupationID], [OccupationName]) VALUES (18, N'scientist')
INSERT [dbo].[Occupation] ([OccupationID], [OccupationName]) VALUES (19, N'student')
INSERT [dbo].[Occupation] ([OccupationID], [OccupationName]) VALUES (20, N'technician')
INSERT [dbo].[Occupation] ([OccupationID], [OccupationName]) VALUES (21, N'writer')
INSERT [dbo].[Table1] ([A], [B], [C], [D], [E]) VALUES (2, 3, 2, 2, 3)
SET IDENTITY_INSERT [dbo].[ThanhVien] ON 

INSERT [dbo].[ThanhVien] ([MaThanhVien], [HoTen], [GioiTinh], [Passwords], [NgaySinh], [Gmail], [SoDienThoai], [SoDuTaiKhoan], [OccupationID]) VALUES (2, N'nv01', 1, N'123456', CAST(N'1995-10-10' AS Date), N'Nghinv42@wru.vn', 123, 0, 1)
INSERT [dbo].[ThanhVien] ([MaThanhVien], [HoTen], [GioiTinh], [Passwords], [NgaySinh], [Gmail], [SoDienThoai], [SoDuTaiKhoan], [OccupationID]) VALUES (4, N'nv02', 0, N'123456', CAST(N'1996-02-02' AS Date), N'Tientq@wru.vn', 123, 0, 2)
SET IDENTITY_INSERT [dbo].[ThanhVien] OFF
ALTER TABLE [dbo].[Account]  WITH CHECK ADD  CONSTRAINT [FK_Account_Employee] FOREIGN KEY([idEmp])
REFERENCES [dbo].[Employee] ([idEmp])
GO
ALTER TABLE [dbo].[Account] CHECK CONSTRAINT [FK_Account_Employee]
GO
ALTER TABLE [dbo].[DetailMovie]  WITH CHECK ADD  CONSTRAINT [_DetailMovie] FOREIGN KEY([MovieID])
REFERENCES [dbo].[Movie] ([MovieID])
GO
ALTER TABLE [dbo].[DetailMovie] CHECK CONSTRAINT [_DetailMovie]
GO
ALTER TABLE [dbo].[DoanhThu]  WITH CHECK ADD  CONSTRAINT [_Employee] FOREIGN KEY([IdEmployee])
REFERENCES [dbo].[Employee] ([idEmp])
GO
ALTER TABLE [dbo].[DoanhThu] CHECK CONSTRAINT [_Employee]
GO
ALTER TABLE [dbo].[Movie]  WITH CHECK ADD  CONSTRAINT [_idEmp] FOREIGN KEY([idEmp])
REFERENCES [dbo].[Employee] ([idEmp])
GO
ALTER TABLE [dbo].[Movie] CHECK CONSTRAINT [_idEmp]
GO
ALTER TABLE [dbo].[Movie]  WITH CHECK ADD  CONSTRAINT [_TheLoaiPhim] FOREIGN KEY([CategoryID])
REFERENCES [dbo].[Category] ([CategoryID])
GO
ALTER TABLE [dbo].[Movie] CHECK CONSTRAINT [_TheLoaiPhim]
GO
ALTER TABLE [dbo].[MovieUser]  WITH CHECK ADD  CONSTRAINT [_Movie] FOREIGN KEY([IdMovie])
REFERENCES [dbo].[Movie] ([MovieID])
GO
ALTER TABLE [dbo].[MovieUser] CHECK CONSTRAINT [_Movie]
GO
ALTER TABLE [dbo].[MovieUser]  WITH CHECK ADD  CONSTRAINT [_User] FOREIGN KEY([IdUser])
REFERENCES [dbo].[ThanhVien] ([MaThanhVien])
GO
ALTER TABLE [dbo].[MovieUser] CHECK CONSTRAINT [_User]
GO
ALTER TABLE [dbo].[RatingOfMovie]  WITH CHECK ADD  CONSTRAINT [_MaCV] FOREIGN KEY([MovieID])
REFERENCES [dbo].[Movie] ([MovieID])
GO
ALTER TABLE [dbo].[RatingOfMovie] CHECK CONSTRAINT [_MaCV]
GO
ALTER TABLE [dbo].[RatingOfMovie]  WITH CHECK ADD  CONSTRAINT [_UserUD] FOREIGN KEY([MaThanhVien])
REFERENCES [dbo].[ThanhVien] ([MaThanhVien])
GO
ALTER TABLE [dbo].[RatingOfMovie] CHECK CONSTRAINT [_UserUD]
GO
ALTER TABLE [dbo].[ThanhVien]  WITH CHECK ADD  CONSTRAINT [FK_ThanhVien_Occupation] FOREIGN KEY([OccupationID])
REFERENCES [dbo].[Occupation] ([OccupationID])
GO
ALTER TABLE [dbo].[ThanhVien] CHECK CONSTRAINT [FK_ThanhVien_Occupation]
GO
/****** Object:  StoredProcedure [dbo].[prd_AccountLogin]    Script Date: 15/03/2017 9:41:01 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[prd_AccountLogin]
@Username NVARCHAR(2000) ,
@Password NVARCHAR(2000)
AS
BEGIN 
	DECLARE @count INT 
	DECLARE @res BIT 
		SELECT @count = count(*) 
		FROM Account 
		WHERE Username = @Username AND Password = @Password 

		IF @count > 0
			SET @res = 1
		ELSE 
			SET @res = 0
	SELECT @res
END 



GO
/****** Object:  StoredProcedure [dbo].[prd_Bang1_Update]    Script Date: 15/03/2017 9:41:01 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[prd_Bang1_Update]
@A int,
@B int ,
@C int,
@D int,
@E int
as
begin
    update Table1
     SET        
		A = @A,
		B = @B,
		C = @C,
		D = @D,
		E = @E
end


GO
/****** Object:  StoredProcedure [dbo].[prd_Movie_Insert]    Script Date: 15/03/2017 9:41:01 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[prd_Movie_Insert]
@MovieID INT ,
@MovieName NVARCHAR(2000),
@URLDetail NVARCHAR(2000),
@LinkImage NVARCHAR(2000),
@Director NVARCHAR(2000),
@Writer NVARCHAR(2000),
@Stars NVARCHAR(2000),
@Descriptions NVARCHAR(2000),
@ReleaseDate NVARCHAR(2000) ,
@RunningTime NVARCHAR(2000),
@CategoryID INT,
@New NVARCHAR(2000)
AS 
BEGIN 
	INSERT INTO dbo.Movie
	        ( 
			  MovieID ,
	          MovieName ,
	          URLDetail ,
			  LinkImage,
			  Director,
			  Writer,
			  Stars,
			  Descriptions,
			  ReleaseDate ,
	          RunningTime,
			  CategoryID,
			  New       
	        )
	VALUES  ( 
	          @MovieID ,
	          @MovieName ,
	          @URLDetail ,
			  @LinkImage,
			  @Director,
			  @Writer,
			  @Stars,
			  @Descriptions,
			  @ReleaseDate ,
	          @RunningTime,
			  @CategoryID,
			  @New      
	        )
End




GO
/****** Object:  StoredProcedure [dbo].[prd_Movie_SelectAll]    Script Date: 15/03/2017 9:41:01 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE procedure [dbo].[prd_Movie_SelectAll]
as
begin
    Select mv.MovieID From Movie mv
end 



GO
/****** Object:  StoredProcedure [dbo].[prd_MovieList_All]    Script Date: 15/03/2017 9:41:01 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[prd_MovieList_All]
AS
SELECT * FROM dbo.Movie 
ORDER BY [MovieID] ASC 




GO
/****** Object:  StoredProcedure [dbo].[prd_MovieSuggest_Insert]    Script Date: 15/03/2017 9:41:01 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[prd_MovieSuggest_Insert]
@S nvarchar(50) 
as
begin 
	Insert into MovieSuggest ( List) Values (@s)	
end



GO
/****** Object:  StoredProcedure [dbo].[prd_Table1_Select]    Script Date: 15/03/2017 9:41:01 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[prd_Table1_Select]
as
begin
    Select mvS.List From MovieSuggest mvS
end




GO
/****** Object:  StoredProcedure [dbo].[prd_ThanhVienLogin]    Script Date: 15/03/2017 9:41:01 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[prd_ThanhVienLogin]
@HoTen NVARCHAR(2000) ,
@PassWords NVARCHAR(2000)
AS
BEGIN 
	DECLARE @count INT 
	DECLARE @res BIT 
		SELECT @count = count(*) 
		FROM Account 
		WHERE Username = @HoTen AND Password = @PassWords

		IF @count > 0
			SET @res = 1
		ELSE 
			SET @res = 0
	SELECT @res
END 



GO
USE [master]
GO
ALTER DATABASE [WebsiteFilm] SET  READ_WRITE 
GO
