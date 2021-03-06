USE [master]
GO
/****** Object:  Database [OnlineShopManagement]    Script Date: 7/19/2019 4:53:06 PM ******/
CREATE DATABASE [OnlineShopManagement]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'BusinessManagement', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.MSSQLSERVER\MSSQL\DATA\BusinessManagement.mdf' , SIZE = 3072KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'BusinessManagement_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.MSSQLSERVER\MSSQL\DATA\BusinessManagement_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [OnlineShopManagement] SET COMPATIBILITY_LEVEL = 110
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [OnlineShopManagement].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [OnlineShopManagement] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [OnlineShopManagement] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [OnlineShopManagement] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [OnlineShopManagement] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [OnlineShopManagement] SET ARITHABORT OFF 
GO
ALTER DATABASE [OnlineShopManagement] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [OnlineShopManagement] SET AUTO_CREATE_STATISTICS ON 
GO
ALTER DATABASE [OnlineShopManagement] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [OnlineShopManagement] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [OnlineShopManagement] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [OnlineShopManagement] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [OnlineShopManagement] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [OnlineShopManagement] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [OnlineShopManagement] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [OnlineShopManagement] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [OnlineShopManagement] SET  DISABLE_BROKER 
GO
ALTER DATABASE [OnlineShopManagement] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [OnlineShopManagement] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [OnlineShopManagement] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [OnlineShopManagement] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [OnlineShopManagement] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [OnlineShopManagement] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [OnlineShopManagement] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [OnlineShopManagement] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [OnlineShopManagement] SET  MULTI_USER 
GO
ALTER DATABASE [OnlineShopManagement] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [OnlineShopManagement] SET DB_CHAINING OFF 
GO
ALTER DATABASE [OnlineShopManagement] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [OnlineShopManagement] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
USE [OnlineShopManagement]
GO
/****** Object:  Table [dbo].[Categories]    Script Date: 7/19/2019 4:53:06 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Categories](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Code] [int] NOT NULL,
	[CategoryName] [nvarchar](255) NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Customers]    Script Date: 7/19/2019 4:53:06 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Customers](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Code] [int] NULL,
	[Name] [nvarchar](50) NULL,
	[Address] [nvarchar](50) NULL,
	[Email] [nvarchar](50) NULL,
	[Contact] [nvarchar](50) NULL,
	[Point] [int] NULL,
	[Image] [varbinary](max) NULL,
 CONSTRAINT [PK_Customer] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Products]    Script Date: 7/19/2019 4:53:06 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Products](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Code] [int] NOT NULL,
	[ProductName] [nvarchar](255) NULL,
	[ReOrderQuantity] [int] NULL,
	[Description] [nvarchar](255) NULL,
	[CategoryID] [int] NULL,
	[Image] [varbinary](max) NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Stocks]    Script Date: 7/19/2019 4:53:06 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Stocks](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[ProductID] [int] NULL,
	[OrderDate] [date] NULL,
	[InvoiceNo] [nvarchar](50) NULL,
	[SupplierID] [int] NULL,
	[ManufacturedDate] [date] NULL,
	[ExpireDate] [date] NULL,
	[Quantity] [int] NULL,
	[UnitPrice] [float] NULL,
	[Remark] [nvarchar](50) NULL,
	[MRP] [int] NULL,
	[CustomerID] [int] NULL,
	[Status] [nvarchar](50) NULL,
	[SalesDate] [date] NULL,
 CONSTRAINT [PK_Purchase] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Suppliers]    Script Date: 7/19/2019 4:53:06 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Suppliers](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Code] [int] NULL,
	[Name] [nvarchar](50) NULL,
	[Address] [nvarchar](50) NULL,
	[Email] [nvarchar](50) NULL,
	[Contact] [nvarchar](50) NULL,
	[ContactPerson] [nvarchar](50) NULL,
	[Logo] [varbinary](max) NULL,
 CONSTRAINT [PK_Supplier] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Users]    Script Date: 7/19/2019 4:53:06 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Users](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[UserName] [nvarchar](255) NULL,
	[Password] [nvarchar](255) NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET IDENTITY_INSERT [dbo].[Categories] ON 

INSERT [dbo].[Categories] ([Id], [Code], [CategoryName]) VALUES (1, 1, N'Electronics')
INSERT [dbo].[Categories] ([Id], [Code], [CategoryName]) VALUES (2, 2, N'Mobile')
SET IDENTITY_INSERT [dbo].[Categories] OFF
SET IDENTITY_INSERT [dbo].[Customers] ON 

INSERT [dbo].[Customers] ([ID], [Code], [Name], [Address], [Email], [Contact], [Point], [Image]) VALUES (1, 1, N'Ali', N'Mirpur,Dhaka', N'ali@gmail.com', N'0178633566', 0, NULL)
SET IDENTITY_INSERT [dbo].[Customers] OFF
SET IDENTITY_INSERT [dbo].[Products] ON 

INSERT [dbo].[Products] ([Id], [Code], [ProductName], [ReOrderQuantity], [Description], [CategoryID], [Image]) VALUES (1, 1, N'Nokia3002', 100, N'Button phone', 2, NULL)
INSERT [dbo].[Products] ([Id], [Code], [ProductName], [ReOrderQuantity], [Description], [CategoryID], [Image]) VALUES (2, 2, N'HP2450', 20, N'Laptop', 1, NULL)
SET IDENTITY_INSERT [dbo].[Products] OFF
SET IDENTITY_INSERT [dbo].[Stocks] ON 

INSERT [dbo].[Stocks] ([ID], [ProductID], [OrderDate], [InvoiceNo], [SupplierID], [ManufacturedDate], [ExpireDate], [Quantity], [UnitPrice], [Remark], [MRP], [CustomerID], [Status], [SalesDate]) VALUES (1, 1, CAST(0xEA3F0B00 AS Date), N'dsgd2333', 1, CAST(0x9E3D0B00 AS Date), CAST(0xC7420B00 AS Date), 200, 8000, NULL, 8700, NULL, N'StockIN', NULL)
INSERT [dbo].[Stocks] ([ID], [ProductID], [OrderDate], [InvoiceNo], [SupplierID], [ManufacturedDate], [ExpireDate], [Quantity], [UnitPrice], [Remark], [MRP], [CustomerID], [Status], [SalesDate]) VALUES (2, 1, NULL, N'trf3322', NULL, NULL, NULL, 2, 7500, NULL, 8000, 1, N'Sold', CAST(0xEA3F0B00 AS Date))
SET IDENTITY_INSERT [dbo].[Stocks] OFF
SET IDENTITY_INSERT [dbo].[Suppliers] ON 

INSERT [dbo].[Suppliers] ([ID], [Code], [Name], [Address], [Email], [Contact], [ContactPerson], [Logo]) VALUES (1, 1, N'NokiaStore', N'Dhaka', N'nokiastore@gmail.com', N'017896266', N'Lubna Hok', NULL)
SET IDENTITY_INSERT [dbo].[Suppliers] OFF
/****** Object:  Index [UQ__Category__A25C5AA7BFDC1E3B]    Script Date: 7/19/2019 4:53:06 PM ******/
ALTER TABLE [dbo].[Categories] ADD UNIQUE NONCLUSTERED 
(
	[Code] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [UQ__Product__A25C5AA711EC6ADB]    Script Date: 7/19/2019 4:53:06 PM ******/
ALTER TABLE [dbo].[Products] ADD UNIQUE NONCLUSTERED 
(
	[Code] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Products]  WITH CHECK ADD  CONSTRAINT [FK_Product_Category] FOREIGN KEY([CategoryID])
REFERENCES [dbo].[Categories] ([Id])
GO
ALTER TABLE [dbo].[Products] CHECK CONSTRAINT [FK_Product_Category]
GO
ALTER TABLE [dbo].[Stocks]  WITH CHECK ADD  CONSTRAINT [FK_Purchase_Customer] FOREIGN KEY([CustomerID])
REFERENCES [dbo].[Customers] ([ID])
GO
ALTER TABLE [dbo].[Stocks] CHECK CONSTRAINT [FK_Purchase_Customer]
GO
ALTER TABLE [dbo].[Stocks]  WITH CHECK ADD  CONSTRAINT [FK_Purchase_Product] FOREIGN KEY([ProductID])
REFERENCES [dbo].[Products] ([Id])
GO
ALTER TABLE [dbo].[Stocks] CHECK CONSTRAINT [FK_Purchase_Product]
GO
ALTER TABLE [dbo].[Stocks]  WITH CHECK ADD  CONSTRAINT [FK_Purchase_Supplier] FOREIGN KEY([SupplierID])
REFERENCES [dbo].[Suppliers] ([ID])
GO
ALTER TABLE [dbo].[Stocks] CHECK CONSTRAINT [FK_Purchase_Supplier]
GO
USE [master]
GO
ALTER DATABASE [OnlineShopManagement] SET  READ_WRITE 
GO
