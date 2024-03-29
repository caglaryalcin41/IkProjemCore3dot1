USE [IkProjeDbCore]
GO
/****** Object:  Table [dbo].[ct_RolePrivilege]    Script Date: 16.05.2023 22:08:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ct_RolePrivilege](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[ReservedName] [nvarchar](max) NULL,
	[AktifMi] [int] NOT NULL,
	[CreatedOn] [datetime2](7) NULL,
	[CreatedBy] [int] NULL,
	[EditedOn] [datetime2](7) NULL,
	[EditedBy] [int] NULL,
	[DeletedOn] [datetime2](7) NULL,
	[DeletedBy] [int] NULL,
	[ActiveOn] [datetime2](7) NULL,
	[ActivetedBy] [int] NULL,
	[Reserved1] [nvarchar](max) NULL,
	[Reserved2] [nvarchar](max) NULL,
	[RoleId] [int] NOT NULL,
	[WebItemId] [int] NOT NULL,
 CONSTRAINT [PK_ct_RolePrivilege] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ct_UserRole]    Script Date: 16.05.2023 22:08:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ct_UserRole](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[ReservedName] [nvarchar](max) NULL,
	[AktifMi] [int] NOT NULL,
	[CreatedOn] [datetime2](7) NULL,
	[CreatedBy] [int] NULL,
	[EditedOn] [datetime2](7) NULL,
	[EditedBy] [int] NULL,
	[DeletedOn] [datetime2](7) NULL,
	[DeletedBy] [int] NULL,
	[ActiveOn] [datetime2](7) NULL,
	[ActivetedBy] [int] NULL,
	[Reserved1] [nvarchar](max) NULL,
	[Reserved2] [nvarchar](max) NULL,
	[RoleId] [int] NOT NULL,
	[UserId] [int] NOT NULL,
 CONSTRAINT [PK_ct_UserRole] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Personel16]    Script Date: 16.05.2023 22:08:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Personel16](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[ReservedName] [nvarchar](max) NULL,
	[AktifMi] [int] NOT NULL,
	[CreatedOn] [datetime2](7) NULL,
	[CreatedBy] [int] NULL,
	[EditedOn] [datetime2](7) NULL,
	[EditedBy] [int] NULL,
	[DeletedOn] [datetime2](7) NULL,
	[DeletedBy] [int] NULL,
	[ActiveOn] [datetime2](7) NULL,
	[ActivetedBy] [int] NULL,
	[Reserved1] [nvarchar](max) NULL,
	[Reserved2] [nvarchar](max) NULL,
	[Ad] [nvarchar](30) NOT NULL,
	[Soyad] [nvarchar](max) NULL,
	[SirketNumarasi] [int] NULL,
	[UnvanId] [int] NULL,
	[IseGirisTarihi] [datetime2](7) NULL,
	[CikisTarihi] [datetime2](7) NULL,
 CONSTRAINT [PK_Personel16] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Roller]    Script Date: 16.05.2023 22:08:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Roller](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[ReservedName] [nvarchar](max) NULL,
	[AktifMi] [int] NOT NULL,
	[CreatedOn] [datetime2](7) NULL,
	[CreatedBy] [int] NULL,
	[EditedOn] [datetime2](7) NULL,
	[EditedBy] [int] NULL,
	[DeletedOn] [datetime2](7) NULL,
	[DeletedBy] [int] NULL,
	[ActiveOn] [datetime2](7) NULL,
	[ActivetedBy] [int] NULL,
	[Reserved1] [nvarchar](max) NULL,
	[Reserved2] [nvarchar](max) NULL,
 CONSTRAINT [PK_Roller] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Unvan]    Script Date: 16.05.2023 22:08:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Unvan](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[ReservedName] [nvarchar](max) NULL,
	[AktifMi] [int] NOT NULL,
	[CreatedOn] [datetime2](7) NULL,
	[CreatedBy] [int] NULL,
	[EditedOn] [datetime2](7) NULL,
	[EditedBy] [int] NULL,
	[DeletedOn] [datetime2](7) NULL,
	[DeletedBy] [int] NULL,
	[ActiveOn] [datetime2](7) NULL,
	[ActivetedBy] [int] NULL,
	[Reserved1] [nvarchar](max) NULL,
	[Reserved2] [nvarchar](max) NULL,
 CONSTRAINT [PK_Unvan] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[User]    Script Date: 16.05.2023 22:08:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[User](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[ReservedName] [nvarchar](max) NULL,
	[AktifMi] [int] NOT NULL,
	[CreatedOn] [datetime2](7) NULL,
	[CreatedBy] [int] NULL,
	[EditedOn] [datetime2](7) NULL,
	[EditedBy] [int] NULL,
	[DeletedOn] [datetime2](7) NULL,
	[DeletedBy] [int] NULL,
	[ActiveOn] [datetime2](7) NULL,
	[ActivetedBy] [int] NULL,
	[Reserved1] [nvarchar](max) NULL,
	[Reserved2] [nvarchar](max) NULL,
	[Adi] [nvarchar](max) NULL,
	[Soyadi] [nvarchar](max) NULL,
	[KullaniciAdi] [nvarchar](max) NULL,
	[Sifre] [nvarchar](max) NULL,
 CONSTRAINT [PK_User] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[WebItem]    Script Date: 16.05.2023 22:08:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[WebItem](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[ReservedName] [nvarchar](max) NULL,
	[AktifMi] [int] NOT NULL,
	[CreatedOn] [datetime2](7) NULL,
	[CreatedBy] [int] NULL,
	[EditedOn] [datetime2](7) NULL,
	[EditedBy] [int] NULL,
	[DeletedOn] [datetime2](7) NULL,
	[DeletedBy] [int] NULL,
	[ActiveOn] [datetime2](7) NULL,
	[ActivetedBy] [int] NULL,
	[Reserved1] [nvarchar](max) NULL,
	[Reserved2] [nvarchar](max) NULL,
	[AreaName] [nvarchar](max) NULL,
	[ControllerName] [nvarchar](max) NULL,
	[ActionName] [nvarchar](max) NULL,
	[UpperId] [int] NULL,
 CONSTRAINT [PK_WebItem] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[ct_RolePrivilege] ON 

INSERT [dbo].[ct_RolePrivilege] ([Id], [ReservedName], [AktifMi], [CreatedOn], [CreatedBy], [EditedOn], [EditedBy], [DeletedOn], [DeletedBy], [ActiveOn], [ActivetedBy], [Reserved1], [Reserved2], [RoleId], [WebItemId]) VALUES (1, NULL, 1, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 1, 1)
INSERT [dbo].[ct_RolePrivilege] ([Id], [ReservedName], [AktifMi], [CreatedOn], [CreatedBy], [EditedOn], [EditedBy], [DeletedOn], [DeletedBy], [ActiveOn], [ActivetedBy], [Reserved1], [Reserved2], [RoleId], [WebItemId]) VALUES (2, NULL, 1, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 1, 2)
INSERT [dbo].[ct_RolePrivilege] ([Id], [ReservedName], [AktifMi], [CreatedOn], [CreatedBy], [EditedOn], [EditedBy], [DeletedOn], [DeletedBy], [ActiveOn], [ActivetedBy], [Reserved1], [Reserved2], [RoleId], [WebItemId]) VALUES (3, NULL, 1, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 1, 3)
INSERT [dbo].[ct_RolePrivilege] ([Id], [ReservedName], [AktifMi], [CreatedOn], [CreatedBy], [EditedOn], [EditedBy], [DeletedOn], [DeletedBy], [ActiveOn], [ActivetedBy], [Reserved1], [Reserved2], [RoleId], [WebItemId]) VALUES (4, NULL, 1, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 1, 4)
INSERT [dbo].[ct_RolePrivilege] ([Id], [ReservedName], [AktifMi], [CreatedOn], [CreatedBy], [EditedOn], [EditedBy], [DeletedOn], [DeletedBy], [ActiveOn], [ActivetedBy], [Reserved1], [Reserved2], [RoleId], [WebItemId]) VALUES (5, NULL, 1, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 1, 5)
INSERT [dbo].[ct_RolePrivilege] ([Id], [ReservedName], [AktifMi], [CreatedOn], [CreatedBy], [EditedOn], [EditedBy], [DeletedOn], [DeletedBy], [ActiveOn], [ActivetedBy], [Reserved1], [Reserved2], [RoleId], [WebItemId]) VALUES (6, NULL, 1, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 1, 6)
INSERT [dbo].[ct_RolePrivilege] ([Id], [ReservedName], [AktifMi], [CreatedOn], [CreatedBy], [EditedOn], [EditedBy], [DeletedOn], [DeletedBy], [ActiveOn], [ActivetedBy], [Reserved1], [Reserved2], [RoleId], [WebItemId]) VALUES (7, NULL, 1, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 1, 7)
INSERT [dbo].[ct_RolePrivilege] ([Id], [ReservedName], [AktifMi], [CreatedOn], [CreatedBy], [EditedOn], [EditedBy], [DeletedOn], [DeletedBy], [ActiveOn], [ActivetedBy], [Reserved1], [Reserved2], [RoleId], [WebItemId]) VALUES (8, NULL, 1, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 1, 8)
INSERT [dbo].[ct_RolePrivilege] ([Id], [ReservedName], [AktifMi], [CreatedOn], [CreatedBy], [EditedOn], [EditedBy], [DeletedOn], [DeletedBy], [ActiveOn], [ActivetedBy], [Reserved1], [Reserved2], [RoleId], [WebItemId]) VALUES (9, NULL, 1, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 1, 9)
INSERT [dbo].[ct_RolePrivilege] ([Id], [ReservedName], [AktifMi], [CreatedOn], [CreatedBy], [EditedOn], [EditedBy], [DeletedOn], [DeletedBy], [ActiveOn], [ActivetedBy], [Reserved1], [Reserved2], [RoleId], [WebItemId]) VALUES (10, NULL, 1, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 2, 7)
INSERT [dbo].[ct_RolePrivilege] ([Id], [ReservedName], [AktifMi], [CreatedOn], [CreatedBy], [EditedOn], [EditedBy], [DeletedOn], [DeletedBy], [ActiveOn], [ActivetedBy], [Reserved1], [Reserved2], [RoleId], [WebItemId]) VALUES (11, NULL, 1, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 2, 8)
INSERT [dbo].[ct_RolePrivilege] ([Id], [ReservedName], [AktifMi], [CreatedOn], [CreatedBy], [EditedOn], [EditedBy], [DeletedOn], [DeletedBy], [ActiveOn], [ActivetedBy], [Reserved1], [Reserved2], [RoleId], [WebItemId]) VALUES (12, NULL, 1, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 2, 9)
SET IDENTITY_INSERT [dbo].[ct_RolePrivilege] OFF
GO
SET IDENTITY_INSERT [dbo].[ct_UserRole] ON 

INSERT [dbo].[ct_UserRole] ([Id], [ReservedName], [AktifMi], [CreatedOn], [CreatedBy], [EditedOn], [EditedBy], [DeletedOn], [DeletedBy], [ActiveOn], [ActivetedBy], [Reserved1], [Reserved2], [RoleId], [UserId]) VALUES (1, NULL, 1, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 1, 2)
INSERT [dbo].[ct_UserRole] ([Id], [ReservedName], [AktifMi], [CreatedOn], [CreatedBy], [EditedOn], [EditedBy], [DeletedOn], [DeletedBy], [ActiveOn], [ActivetedBy], [Reserved1], [Reserved2], [RoleId], [UserId]) VALUES (2, NULL, 1, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 2, 1)
SET IDENTITY_INSERT [dbo].[ct_UserRole] OFF
GO
SET IDENTITY_INSERT [dbo].[Personel16] ON 

INSERT [dbo].[Personel16] ([Id], [ReservedName], [AktifMi], [CreatedOn], [CreatedBy], [EditedOn], [EditedBy], [DeletedOn], [DeletedBy], [ActiveOn], [ActivetedBy], [Reserved1], [Reserved2], [Ad], [Soyad], [SirketNumarasi], [UnvanId], [IseGirisTarihi], [CikisTarihi]) VALUES (2, NULL, 1, CAST(N'2023-04-30T22:51:47.0000000' AS DateTime2), NULL, CAST(N'2023-04-30T22:51:47.0000000' AS DateTime2), NULL, CAST(N'2023-04-30T22:51:56.0366667' AS DateTime2), NULL, CAST(N'2023-05-08T21:29:03.8315701' AS DateTime2), 1, NULL, NULL, N'serdar', N'Toprak', 213131, NULL, NULL, NULL)
INSERT [dbo].[Personel16] ([Id], [ReservedName], [AktifMi], [CreatedOn], [CreatedBy], [EditedOn], [EditedBy], [DeletedOn], [DeletedBy], [ActiveOn], [ActivetedBy], [Reserved1], [Reserved2], [Ad], [Soyad], [SirketNumarasi], [UnvanId], [IseGirisTarihi], [CikisTarihi]) VALUES (9, NULL, 1, CAST(N'2023-05-06T22:03:21.9089533' AS DateTime2), NULL, CAST(N'2023-05-06T22:03:21.9272116' AS DateTime2), 1, NULL, NULL, NULL, NULL, NULL, NULL, N'Çağlar 41', N'Yalçın', 414141, 1, NULL, NULL)
INSERT [dbo].[Personel16] ([Id], [ReservedName], [AktifMi], [CreatedOn], [CreatedBy], [EditedOn], [EditedBy], [DeletedOn], [DeletedBy], [ActiveOn], [ActivetedBy], [Reserved1], [Reserved2], [Ad], [Soyad], [SirketNumarasi], [UnvanId], [IseGirisTarihi], [CikisTarihi]) VALUES (10, NULL, 1, CAST(N'2023-04-27T23:14:36.0000000' AS DateTime2), NULL, CAST(N'2023-04-27T23:14:36.0000000' AS DateTime2), NULL, CAST(N'2023-04-30T22:53:25.3733333' AS DateTime2), NULL, CAST(N'2023-04-30T22:55:50.0333333' AS DateTime2), 1, NULL, NULL, N'Taner 41', N'Güleri 41', 414142341, 2, NULL, NULL)
INSERT [dbo].[Personel16] ([Id], [ReservedName], [AktifMi], [CreatedOn], [CreatedBy], [EditedOn], [EditedBy], [DeletedOn], [DeletedBy], [ActiveOn], [ActivetedBy], [Reserved1], [Reserved2], [Ad], [Soyad], [SirketNumarasi], [UnvanId], [IseGirisTarihi], [CikisTarihi]) VALUES (11, NULL, 1, CAST(N'2023-04-28T23:28:02.5933333' AS DateTime2), 1, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, N'Muhammet', N'AdıGüzel', 4141422, 2, NULL, NULL)
INSERT [dbo].[Personel16] ([Id], [ReservedName], [AktifMi], [CreatedOn], [CreatedBy], [EditedOn], [EditedBy], [DeletedOn], [DeletedBy], [ActiveOn], [ActivetedBy], [Reserved1], [Reserved2], [Ad], [Soyad], [SirketNumarasi], [UnvanId], [IseGirisTarihi], [CikisTarihi]) VALUES (12, NULL, 1, CAST(N'2023-04-30T22:10:43.5266667' AS DateTime2), 1, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, N'Sibel', N'can', 1414, 1, NULL, NULL)
INSERT [dbo].[Personel16] ([Id], [ReservedName], [AktifMi], [CreatedOn], [CreatedBy], [EditedOn], [EditedBy], [DeletedOn], [DeletedBy], [ActiveOn], [ActivetedBy], [Reserved1], [Reserved2], [Ad], [Soyad], [SirketNumarasi], [UnvanId], [IseGirisTarihi], [CikisTarihi]) VALUES (13, NULL, 1, CAST(N'2023-05-02T23:14:53.6633333' AS DateTime2), 1, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, N'sadadad', N'csdfsdasd', 2131313, 1, NULL, NULL)
INSERT [dbo].[Personel16] ([Id], [ReservedName], [AktifMi], [CreatedOn], [CreatedBy], [EditedOn], [EditedBy], [DeletedOn], [DeletedBy], [ActiveOn], [ActivetedBy], [Reserved1], [Reserved2], [Ad], [Soyad], [SirketNumarasi], [UnvanId], [IseGirisTarihi], [CikisTarihi]) VALUES (14, NULL, 1, CAST(N'2023-05-02T23:15:46.7433333' AS DateTime2), 1, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, N'asadasdas', N'sadada', 3214321, 1, NULL, NULL)
SET IDENTITY_INSERT [dbo].[Personel16] OFF
GO
SET IDENTITY_INSERT [dbo].[Roller] ON 

INSERT [dbo].[Roller] ([Id], [ReservedName], [AktifMi], [CreatedOn], [CreatedBy], [EditedOn], [EditedBy], [DeletedOn], [DeletedBy], [ActiveOn], [ActivetedBy], [Reserved1], [Reserved2]) VALUES (1, N'Admin', 1, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[Roller] ([Id], [ReservedName], [AktifMi], [CreatedOn], [CreatedBy], [EditedOn], [EditedBy], [DeletedOn], [DeletedBy], [ActiveOn], [ActivetedBy], [Reserved1], [Reserved2]) VALUES (2, N'Mod-1', 1, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[Roller] ([Id], [ReservedName], [AktifMi], [CreatedOn], [CreatedBy], [EditedOn], [EditedBy], [DeletedOn], [DeletedBy], [ActiveOn], [ActivetedBy], [Reserved1], [Reserved2]) VALUES (3, N'Mod-2', 1, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL)
SET IDENTITY_INSERT [dbo].[Roller] OFF
GO
SET IDENTITY_INSERT [dbo].[Unvan] ON 

INSERT [dbo].[Unvan] ([Id], [ReservedName], [AktifMi], [CreatedOn], [CreatedBy], [EditedOn], [EditedBy], [DeletedOn], [DeletedBy], [ActiveOn], [ActivetedBy], [Reserved1], [Reserved2]) VALUES (1, N'Müdür 41', 1, CAST(N'2023-05-06T22:26:18.5706548' AS DateTime2), NULL, CAST(N'2023-05-06T22:26:18.5716660' AS DateTime2), 1, NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[Unvan] ([Id], [ReservedName], [AktifMi], [CreatedOn], [CreatedBy], [EditedOn], [EditedBy], [DeletedOn], [DeletedBy], [ActiveOn], [ActivetedBy], [Reserved1], [Reserved2]) VALUES (2, N'Müdür Yardımcısı', 0, CAST(N'2023-04-28T23:21:31.0000000' AS DateTime2), NULL, NULL, NULL, CAST(N'2023-05-08T21:28:41.4854205' AS DateTime2), NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[Unvan] ([Id], [ReservedName], [AktifMi], [CreatedOn], [CreatedBy], [EditedOn], [EditedBy], [DeletedOn], [DeletedBy], [ActiveOn], [ActivetedBy], [Reserved1], [Reserved2]) VALUES (3, N'Stajer 42', 0, CAST(N'2023-05-06T22:37:32.0000000' AS DateTime2), NULL, CAST(N'2023-05-06T22:37:32.0000000' AS DateTime2), NULL, CAST(N'2023-05-06T22:39:27.1840644' AS DateTime2), NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[Unvan] ([Id], [ReservedName], [AktifMi], [CreatedOn], [CreatedBy], [EditedOn], [EditedBy], [DeletedOn], [DeletedBy], [ActiveOn], [ActivetedBy], [Reserved1], [Reserved2]) VALUES (4, N'Teknik Müdür', 1, CAST(N'2023-05-12T23:01:01.0050964' AS DateTime2), 1, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL)
SET IDENTITY_INSERT [dbo].[Unvan] OFF
GO
SET IDENTITY_INSERT [dbo].[User] ON 

INSERT [dbo].[User] ([Id], [ReservedName], [AktifMi], [CreatedOn], [CreatedBy], [EditedOn], [EditedBy], [DeletedOn], [DeletedBy], [ActiveOn], [ActivetedBy], [Reserved1], [Reserved2], [Adi], [Soyadi], [KullaniciAdi], [Sifre]) VALUES (1, NULL, 1, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, N'Çağlar', NULL, N'caca', N'123')
INSERT [dbo].[User] ([Id], [ReservedName], [AktifMi], [CreatedOn], [CreatedBy], [EditedOn], [EditedBy], [DeletedOn], [DeletedBy], [ActiveOn], [ActivetedBy], [Reserved1], [Reserved2], [Adi], [Soyadi], [KullaniciAdi], [Sifre]) VALUES (2, NULL, 1, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, N'Batu', NULL, N'bat', N'1234')
SET IDENTITY_INSERT [dbo].[User] OFF
GO
SET IDENTITY_INSERT [dbo].[WebItem] ON 

INSERT [dbo].[WebItem] ([Id], [ReservedName], [AktifMi], [CreatedOn], [CreatedBy], [EditedOn], [EditedBy], [DeletedOn], [DeletedBy], [ActiveOn], [ActivetedBy], [Reserved1], [Reserved2], [AreaName], [ControllerName], [ActionName], [UpperId]) VALUES (1, NULL, 1, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, N'1', NULL, N'Admin', NULL, NULL, NULL)
INSERT [dbo].[WebItem] ([Id], [ReservedName], [AktifMi], [CreatedOn], [CreatedBy], [EditedOn], [EditedBy], [DeletedOn], [DeletedBy], [ActiveOn], [ActivetedBy], [Reserved1], [Reserved2], [AreaName], [ControllerName], [ActionName], [UpperId]) VALUES (2, NULL, 1, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, N'1', NULL, NULL, N'Personel', NULL, 1)
INSERT [dbo].[WebItem] ([Id], [ReservedName], [AktifMi], [CreatedOn], [CreatedBy], [EditedOn], [EditedBy], [DeletedOn], [DeletedBy], [ActiveOn], [ActivetedBy], [Reserved1], [Reserved2], [AreaName], [ControllerName], [ActionName], [UpperId]) VALUES (3, NULL, 1, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, N'1', NULL, NULL, N'Unvan', NULL, 1)
INSERT [dbo].[WebItem] ([Id], [ReservedName], [AktifMi], [CreatedOn], [CreatedBy], [EditedOn], [EditedBy], [DeletedOn], [DeletedBy], [ActiveOn], [ActivetedBy], [Reserved1], [Reserved2], [AreaName], [ControllerName], [ActionName], [UpperId]) VALUES (4, NULL, 1, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, N'KisiListesi', 2)
INSERT [dbo].[WebItem] ([Id], [ReservedName], [AktifMi], [CreatedOn], [CreatedBy], [EditedOn], [EditedBy], [DeletedOn], [DeletedBy], [ActiveOn], [ActivetedBy], [Reserved1], [Reserved2], [AreaName], [ControllerName], [ActionName], [UpperId]) VALUES (5, NULL, 1, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, N'KisiEkleme', 2)
INSERT [dbo].[WebItem] ([Id], [ReservedName], [AktifMi], [CreatedOn], [CreatedBy], [EditedOn], [EditedBy], [DeletedOn], [DeletedBy], [ActiveOn], [ActivetedBy], [Reserved1], [Reserved2], [AreaName], [ControllerName], [ActionName], [UpperId]) VALUES (6, NULL, 1, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, N'KisiDuzenle', 2)
INSERT [dbo].[WebItem] ([Id], [ReservedName], [AktifMi], [CreatedOn], [CreatedBy], [EditedOn], [EditedBy], [DeletedOn], [DeletedBy], [ActiveOn], [ActivetedBy], [Reserved1], [Reserved2], [AreaName], [ControllerName], [ActionName], [UpperId]) VALUES (7, NULL, 1, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, N'UnvanListesi', 3)
INSERT [dbo].[WebItem] ([Id], [ReservedName], [AktifMi], [CreatedOn], [CreatedBy], [EditedOn], [EditedBy], [DeletedOn], [DeletedBy], [ActiveOn], [ActivetedBy], [Reserved1], [Reserved2], [AreaName], [ControllerName], [ActionName], [UpperId]) VALUES (8, NULL, 1, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, N'UnvanEkleme', 3)
INSERT [dbo].[WebItem] ([Id], [ReservedName], [AktifMi], [CreatedOn], [CreatedBy], [EditedOn], [EditedBy], [DeletedOn], [DeletedBy], [ActiveOn], [ActivetedBy], [Reserved1], [Reserved2], [AreaName], [ControllerName], [ActionName], [UpperId]) VALUES (9, NULL, 1, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, N'UnvanDuzenle', 3)
SET IDENTITY_INSERT [dbo].[WebItem] OFF
GO
ALTER TABLE [dbo].[Personel16] ADD  DEFAULT ((0)) FOR [AktifMi]
GO
ALTER TABLE [dbo].[Unvan] ADD  DEFAULT ((0)) FOR [AktifMi]
GO
