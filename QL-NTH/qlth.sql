USE [QLNTH]
GO
/****** Object:  Table [dbo].[Account]    Script Date: 11/30/2024 9:41:45 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Account](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[tk] [varchar](50) NULL,
	[mk] [varchar](50) NULL,
	[mod] [int] NULL,
	[baomat] [nvarchar](50) NULL,
 CONSTRAINT [PK_Account] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Listchoduyet]    Script Date: 11/30/2024 9:41:45 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Listchoduyet](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[hoten] [nvarchar](50) NULL,
	[lop] [nvarchar](50) NULL,
	[msv] [bigint] NULL,
	[sdt] [int] NULL,
	[khoa] [nvarchar](50) NULL,
	[monhoc] [nvarchar](50) NULL,
	[ngay] [date] NULL,
 CONSTRAINT [PK_Listchoduyet] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Listdaduyet]    Script Date: 11/30/2024 9:41:45 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Listdaduyet](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[hoten] [nvarchar](50) NULL,
	[lop] [nvarchar](50) NULL,
	[msv] [bigint] NULL,
	[sdt] [int] NULL,
	[khoa] [nvarchar](50) NULL,
	[monhoc] [nvarchar](50) NULL,
	[ngay] [date] NULL,
 CONSTRAINT [PK_Listdaduyet] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbThongbao]    Script Date: 11/30/2024 9:41:45 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbThongbao](
	[sotb] [nvarchar](10) NOT NULL,
	[noidung] [nvarchar](300) NULL,
	[ngay] [date] NULL,
 CONSTRAINT [PK_tbThongbao] PRIMARY KEY CLUSTERED 
(
	[sotb] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Account] ON 

INSERT [dbo].[Account] ([id], [tk], [mk], [mod], [baomat]) VALUES (1, N'user', N'123', 0, N'gg')
INSERT [dbo].[Account] ([id], [tk], [mk], [mod], [baomat]) VALUES (2, N'admin', N'123', 1, N'gg')
INSERT [dbo].[Account] ([id], [tk], [mk], [mod], [baomat]) VALUES (1002, N'admin', N'12345', 0, N'gg')
SET IDENTITY_INSERT [dbo].[Account] OFF
GO
SET IDENTITY_INSERT [dbo].[Listchoduyet] ON 

INSERT [dbo].[Listchoduyet] ([id], [hoten], [lop], [msv], [sdt], [khoa], [monhoc], [ngay]) VALUES (2, N'Dương Hải Sơn', N'DHTI15A7HN', 219999999, 981288245, N'KINH TẾ', N'Kế toán', CAST(N'2024-11-29' AS Date))
INSERT [dbo].[Listchoduyet] ([id], [hoten], [lop], [msv], [sdt], [khoa], [monhoc], [ngay]) VALUES (3, N'Lê Thành Đạt', N'DHTI15A7HN', 322323232, 232323245, N'CNTT', N'Lập trình web', CAST(N'2024-11-30' AS Date))
INSERT [dbo].[Listchoduyet] ([id], [hoten], [lop], [msv], [sdt], [khoa], [monhoc], [ngay]) VALUES (5, N'Phan Văn Linh', N'DHTI15A7HN', 3422442344, 898787999, N'KINH TẾ', N'Quản trị', CAST(N'2024-11-30' AS Date))
SET IDENTITY_INSERT [dbo].[Listchoduyet] OFF
GO
SET IDENTITY_INSERT [dbo].[Listdaduyet] ON 

INSERT [dbo].[Listdaduyet] ([id], [hoten], [lop], [msv], [sdt], [khoa], [monhoc], [ngay]) VALUES (1, N'Nguyễn Ngọc Tuân', N'DHTI15A7HN', 21103100377, 917208821, N'CNTT', N'Lập trình web', CAST(N'2024-11-29' AS Date))
SET IDENTITY_INSERT [dbo].[Listdaduyet] OFF
GO
INSERT [dbo].[tbThongbao] ([sotb], [noidung], [ngay]) VALUES (N'1', N'tuan sdsdssad', CAST(N'2024-11-29' AS Date))
INSERT [dbo].[tbThongbao] ([sotb], [noidung], [ngay]) VALUES (N'2', N'anh', CAST(N'2024-11-30' AS Date))
INSERT [dbo].[tbThongbao] ([sotb], [noidung], [ngay]) VALUES (N'3', N'tất cả anh em nộp bài đúng hạn nhé !', CAST(N'2024-11-30' AS Date))
GO
