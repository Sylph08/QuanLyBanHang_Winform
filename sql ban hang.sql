USE [master]
GO
/****** Object:  Database [QuanLyBanHang_MK]    Script Date: 6/3/2020 9:26:47 PM ******/
CREATE DATABASE [QuanLyBanHang_MK]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'QuanLyBanHang_MK', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.SQLEXPRESS\MSSQL\DATA\QuanLyBanHang_MK.mdf' , SIZE = 3136KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'QuanLyBanHang_MK_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.SQLEXPRESS\MSSQL\DATA\QuanLyBanHang_MK_log.ldf' , SIZE = 784KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [QuanLyBanHang_MK] SET COMPATIBILITY_LEVEL = 110
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [QuanLyBanHang_MK].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [QuanLyBanHang_MK] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [QuanLyBanHang_MK] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [QuanLyBanHang_MK] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [QuanLyBanHang_MK] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [QuanLyBanHang_MK] SET ARITHABORT OFF 
GO
ALTER DATABASE [QuanLyBanHang_MK] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [QuanLyBanHang_MK] SET AUTO_CREATE_STATISTICS ON 
GO
ALTER DATABASE [QuanLyBanHang_MK] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [QuanLyBanHang_MK] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [QuanLyBanHang_MK] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [QuanLyBanHang_MK] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [QuanLyBanHang_MK] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [QuanLyBanHang_MK] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [QuanLyBanHang_MK] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [QuanLyBanHang_MK] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [QuanLyBanHang_MK] SET  ENABLE_BROKER 
GO
ALTER DATABASE [QuanLyBanHang_MK] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [QuanLyBanHang_MK] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [QuanLyBanHang_MK] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [QuanLyBanHang_MK] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [QuanLyBanHang_MK] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [QuanLyBanHang_MK] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [QuanLyBanHang_MK] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [QuanLyBanHang_MK] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [QuanLyBanHang_MK] SET  MULTI_USER 
GO
ALTER DATABASE [QuanLyBanHang_MK] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [QuanLyBanHang_MK] SET DB_CHAINING OFF 
GO
ALTER DATABASE [QuanLyBanHang_MK] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [QuanLyBanHang_MK] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
USE [QuanLyBanHang_MK]
GO
/****** Object:  StoredProcedure [dbo].[USP_InsertBillInfo]    Script Date: 6/3/2020 9:26:47 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[USP_InsertBillInfo]
@idBill int, @idPro int, @quan int
as
begin
	declare @isExitBillInfo int
	declare @ProQuan int =1
	select @isExitBillInfo= idBillInfo,@ProQuan=quantity from BillInfo where idBill=@idBill and idpro=@idPro
	if(@isExitBillInfo>0)
	begin
		declare @newcount int =@ProQuan+@quan
		if (@newcount>0)
		update BillInfo set quantity=@newcount where idpro=@idPro and idBill=@idBill
		else 
		delete BillInfo where idBill=@idBill and idpro=@idPro
	end
	else
		begin 
		insert BillInfo(idbill,idpro,quantity)
		values (@idBill,@idPro,@quan)
		end
	
end

GO
/****** Object:  Table [dbo].[Bill]    Script Date: 6/3/2020 9:26:47 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Bill](
	[idBill] [int] IDENTITY(1,1) NOT NULL,
	[DateCreate] [date] NULL,
	[status] [int] NOT NULL,
	[TongTien] [int] NOT NULL,
	[GhiChu] [nvarchar](300) NULL,
PRIMARY KEY CLUSTERED 
(
	[idBill] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[BillInfo]    Script Date: 6/3/2020 9:26:47 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BillInfo](
	[idBillInfo] [int] IDENTITY(1,1) NOT NULL,
	[idBill] [int] NOT NULL,
	[idPro] [int] NOT NULL,
	[Quantity] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[idBillInfo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[ChitietDepartment]    Script Date: 6/3/2020 9:26:47 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChitietDepartment](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[idDep] [int] NOT NULL,
	[Diachichitiet] [nvarchar](200) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Department]    Script Date: 6/3/2020 9:26:47 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Department](
	[idDep] [int] IDENTITY(1,1) NOT NULL,
	[Location] [nvarchar](100) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[idDep] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[NoTien]    Script Date: 6/3/2020 9:26:47 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NoTien](
	[idNoTien] [int] IDENTITY(1,1) NOT NULL,
	[Ten] [nvarchar](100) NOT NULL,
	[Diachi] [nvarchar](200) NULL,
	[SotienNo] [int] NOT NULL,
	[NgayNo] [date] NULL,
	[ghichu] [nvarchar](300) NULL,
PRIMARY KEY CLUSTERED 
(
	[idNoTien] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Product]    Script Date: 6/3/2020 9:26:47 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Product](
	[idPro] [int] IDENTITY(1,1) NOT NULL,
	[name] [nvarchar](200) NOT NULL,
	[price] [int] NOT NULL,
	[idVitri] [int] NOT NULL,
	[Outlook] [image] NULL,
PRIMARY KEY CLUSTERED 
(
	[idPro] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET IDENTITY_INSERT [dbo].[ChitietDepartment] ON 

INSERT [dbo].[ChitietDepartment] ([id], [idDep], [Diachichitiet]) VALUES (1, 1, N'Gian ngoài')
INSERT [dbo].[ChitietDepartment] ([id], [idDep], [Diachichitiet]) VALUES (2, 1, N'Gian cận ngoài')
INSERT [dbo].[ChitietDepartment] ([id], [idDep], [Diachichitiet]) VALUES (3, 1, N'Gian logo')
INSERT [dbo].[ChitietDepartment] ([id], [idDep], [Diachichitiet]) VALUES (4, 2, N'Nằm trên tường')
INSERT [dbo].[ChitietDepartment] ([id], [idDep], [Diachichitiet]) VALUES (5, 2, N'Nằm dưới đất')
INSERT [dbo].[ChitietDepartment] ([id], [idDep], [Diachichitiet]) VALUES (6, 3, N'Tấm chắn trái')
INSERT [dbo].[ChitietDepartment] ([id], [idDep], [Diachichitiet]) VALUES (7, 4, N'Tầng 1')
INSERT [dbo].[ChitietDepartment] ([id], [idDep], [Diachichitiet]) VALUES (8, 4, N'Tầng 2')
INSERT [dbo].[ChitietDepartment] ([id], [idDep], [Diachichitiet]) VALUES (9, 4, N'Tầng 3')
INSERT [dbo].[ChitietDepartment] ([id], [idDep], [Diachichitiet]) VALUES (10, 5, N'Tầng 1')
INSERT [dbo].[ChitietDepartment] ([id], [idDep], [Diachichitiet]) VALUES (11, 5, N'Tầng 2')
INSERT [dbo].[ChitietDepartment] ([id], [idDep], [Diachichitiet]) VALUES (12, 5, N'Tầng 3')
INSERT [dbo].[ChitietDepartment] ([id], [idDep], [Diachichitiet]) VALUES (13, 6, N'Tầng 1')
INSERT [dbo].[ChitietDepartment] ([id], [idDep], [Diachichitiet]) VALUES (14, 6, N'Tầng 2')
INSERT [dbo].[ChitietDepartment] ([id], [idDep], [Diachichitiet]) VALUES (15, 6, N'Tầng 3')
INSERT [dbo].[ChitietDepartment] ([id], [idDep], [Diachichitiet]) VALUES (16, 6, N'Tầng 4')
INSERT [dbo].[ChitietDepartment] ([id], [idDep], [Diachichitiet]) VALUES (17, 7, N'Tầng 1')
INSERT [dbo].[ChitietDepartment] ([id], [idDep], [Diachichitiet]) VALUES (18, 7, N'Tầng 2')
INSERT [dbo].[ChitietDepartment] ([id], [idDep], [Diachichitiet]) VALUES (19, 7, N'Tầng 3')
INSERT [dbo].[ChitietDepartment] ([id], [idDep], [Diachichitiet]) VALUES (20, 7, N'Tầng 4')
INSERT [dbo].[ChitietDepartment] ([id], [idDep], [Diachichitiet]) VALUES (21, 8, N'Tầng 1')
INSERT [dbo].[ChitietDepartment] ([id], [idDep], [Diachichitiet]) VALUES (22, 8, N'Tầng 2')
INSERT [dbo].[ChitietDepartment] ([id], [idDep], [Diachichitiet]) VALUES (23, 9, N'Tủ lạnh')
INSERT [dbo].[ChitietDepartment] ([id], [idDep], [Diachichitiet]) VALUES (24, 9, N'Cửa ra vào')
INSERT [dbo].[ChitietDepartment] ([id], [idDep], [Diachichitiet]) VALUES (25, 9, N'Trong nhà')
SET IDENTITY_INSERT [dbo].[ChitietDepartment] OFF
SET IDENTITY_INSERT [dbo].[Department] ON 

INSERT [dbo].[Department] ([idDep], [Location]) VALUES (1, N'Gian chính')
INSERT [dbo].[Department] ([idDep], [Location]) VALUES (2, N'Gian ngoài phải')
INSERT [dbo].[Department] ([idDep], [Location]) VALUES (3, N'Gian ngoài trái')
INSERT [dbo].[Department] ([idDep], [Location]) VALUES (4, N'Tủ hàng phải 1')
INSERT [dbo].[Department] ([idDep], [Location]) VALUES (5, N'Tủ hàng phải 2')
INSERT [dbo].[Department] ([idDep], [Location]) VALUES (6, N'Tủ hàng trái')
INSERT [dbo].[Department] ([idDep], [Location]) VALUES (7, N'Tủ hàng ngang')
INSERT [dbo].[Department] ([idDep], [Location]) VALUES (8, N'Tủ đồ câu')
INSERT [dbo].[Department] ([idDep], [Location]) VALUES (9, N'Trong nhà')
SET IDENTITY_INSERT [dbo].[Department] OFF
ALTER TABLE [dbo].[Bill] ADD  DEFAULT (getdate()) FOR [DateCreate]
GO
ALTER TABLE [dbo].[Bill] ADD  DEFAULT ((0)) FOR [status]
GO
ALTER TABLE [dbo].[Bill] ADD  DEFAULT ((0)) FOR [TongTien]
GO
ALTER TABLE [dbo].[NoTien] ADD  DEFAULT (getdate()) FOR [NgayNo]
GO
ALTER TABLE [dbo].[BillInfo]  WITH CHECK ADD  CONSTRAINT [fk_idBill] FOREIGN KEY([idBill])
REFERENCES [dbo].[Bill] ([idBill])
GO
ALTER TABLE [dbo].[BillInfo] CHECK CONSTRAINT [fk_idBill]
GO
ALTER TABLE [dbo].[ChitietDepartment]  WITH CHECK ADD  CONSTRAINT [fk_chitietDepartment] FOREIGN KEY([idDep])
REFERENCES [dbo].[Department] ([idDep])
GO
ALTER TABLE [dbo].[ChitietDepartment] CHECK CONSTRAINT [fk_chitietDepartment]
GO
ALTER TABLE [dbo].[Product]  WITH CHECK ADD  CONSTRAINT [fk_idVitri] FOREIGN KEY([idVitri])
REFERENCES [dbo].[ChitietDepartment] ([id])
GO
ALTER TABLE [dbo].[Product] CHECK CONSTRAINT [fk_idVitri]
GO
USE [master]
GO
ALTER DATABASE [QuanLyBanHang_MK] SET  READ_WRITE 
GO
