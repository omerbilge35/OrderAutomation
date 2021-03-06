USE [siparisotomasyonu]
GO
/****** Object:  Table [dbo].[musteri]    Script Date: 29.12.2019 23:23:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[musteri](
	[musteriID] [int] IDENTITY(1,1) NOT NULL,
	[ad] [nvarchar](50) NULL,
	[soyad] [nvarchar](50) NULL,
	[adres] [nvarchar](max) NULL,
	[tcno] [nvarchar](50) NULL,
	[sifre] [nvarchar](50) NULL,
 CONSTRAINT [PK_musteri] PRIMARY KEY CLUSTERED 
(
	[musteriID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[satisveri]    Script Date: 29.12.2019 23:23:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[satisveri](
	[satisveriID] [int] IDENTITY(1,1) NOT NULL,
	[musteriID] [int] NULL,
	[urunAd] [nvarchar](50) NULL,
	[urunADET] [int] NULL,
	[urunFIYAT] [float] NULL,
	[urunTFIYAT] [float] NULL,
	[urunTARIH] [smalldatetime] NULL,
	[urunODEME] [nvarchar](50) NULL,
	[urunADRES] [nvarchar](max) NULL,
 CONSTRAINT [PK_satisveri] PRIMARY KEY CLUSTERED 
(
	[satisveriID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[sepet]    Script Date: 29.12.2019 23:23:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[sepet](
	[sepetID] [int] IDENTITY(1,1) NOT NULL,
	[musteriID] [int] NULL,
	[Ad] [nvarchar](50) NULL,
	[Fiyat] [float] NULL,
	[Adet] [int] NULL,
	[ID] [int] NULL,
	[ToplamFiyat] [float] NULL,
 CONSTRAINT [PK_sepet] PRIMARY KEY CLUSTERED 
(
	[sepetID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[urun]    Script Date: 29.12.2019 23:23:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[urun](
	[urunID] [int] IDENTITY(1,1) NOT NULL,
	[urun_ad] [nvarchar](50) NULL,
	[urun_fiyat] [float] NULL,
	[urun_aciklama] [nvarchar](max) NULL,
 CONSTRAINT [PK_urun] PRIMARY KEY CLUSTERED 
(
	[urunID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[yonetici]    Script Date: 29.12.2019 23:23:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[yonetici](
	[yoneticiID] [int] IDENTITY(1,1) NOT NULL,
	[yon_sifre] [nvarchar](50) NULL,
 CONSTRAINT [PK_yonetici] PRIMARY KEY CLUSTERED 
(
	[yoneticiID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[musteri] ON 

INSERT [dbo].[musteri] ([musteriID], [ad], [soyad], [adres], [tcno], [sifre]) VALUES (2, N'Ömer Furkan', N'BİLGE', N'Atatürk Mahallesi 8809/17 Sokak No:7 Daire:5 ÇİĞLİ/İZMİR', N'23405149402', N'123omer123')
INSERT [dbo].[musteri] ([musteriID], [ad], [soyad], [adres], [tcno], [sifre]) VALUES (4, N'deneme', N'deneme', N'deneme adres', N'123', N'123')
INSERT [dbo].[musteri] ([musteriID], [ad], [soyad], [adres], [tcno], [sifre]) VALUES (5, N'', N'', N'', N'', N'')
SET IDENTITY_INSERT [dbo].[musteri] OFF
SET IDENTITY_INSERT [dbo].[satisveri] ON 

INSERT [dbo].[satisveri] ([satisveriID], [musteriID], [urunAd], [urunADET], [urunFIYAT], [urunTFIYAT], [urunTARIH], [urunODEME], [urunADRES]) VALUES (18, 4, N'Ekmek', 2, 1.25, 2.5, CAST(N'2019-12-28T17:47:00' AS SmallDateTime), N'Kapıda Ödeme', N'deneme adres')
INSERT [dbo].[satisveri] ([satisveriID], [musteriID], [urunAd], [urunADET], [urunFIYAT], [urunTFIYAT], [urunTARIH], [urunODEME], [urunADRES]) VALUES (19, 4, N'Çikolata', 3, 3, 9, CAST(N'2019-12-29T20:12:00' AS SmallDateTime), N'Kredi/Banka Kartı', N'deneme adres')
INSERT [dbo].[satisveri] ([satisveriID], [musteriID], [urunAd], [urunADET], [urunFIYAT], [urunTFIYAT], [urunTARIH], [urunODEME], [urunADRES]) VALUES (20, 4, N'Cips', 5, 4, 20, CAST(N'2019-12-29T20:12:00' AS SmallDateTime), N'Kredi/Banka Kartı', N'deneme adres')
INSERT [dbo].[satisveri] ([satisveriID], [musteriID], [urunAd], [urunADET], [urunFIYAT], [urunTFIYAT], [urunTARIH], [urunODEME], [urunADRES]) VALUES (21, 4, N'Süt (1 lt.)', 2, 6, 12, CAST(N'2019-12-29T23:00:00' AS SmallDateTime), N'Kapıda Ödeme', N'deneme adres')
INSERT [dbo].[satisveri] ([satisveriID], [musteriID], [urunAd], [urunADET], [urunFIYAT], [urunTFIYAT], [urunTARIH], [urunODEME], [urunADRES]) VALUES (22, 4, N'Ekmek', 3, 1.25, 3.75, CAST(N'2019-12-29T23:00:00' AS SmallDateTime), N'Kapıda Ödeme', N'deneme adres')
INSERT [dbo].[satisveri] ([satisveriID], [musteriID], [urunAd], [urunADET], [urunFIYAT], [urunTFIYAT], [urunTARIH], [urunODEME], [urunADRES]) VALUES (23, 4, N'Süt (1 lt.)', 2, 6, 12, CAST(N'2019-12-29T23:01:00' AS SmallDateTime), N'Kapıda Ödeme', N'deneme adres')
INSERT [dbo].[satisveri] ([satisveriID], [musteriID], [urunAd], [urunADET], [urunFIYAT], [urunTFIYAT], [urunTARIH], [urunODEME], [urunADRES]) VALUES (24, 4, N'Ekmek', 3, 1.25, 3.75, CAST(N'2019-12-29T23:01:00' AS SmallDateTime), N'Kapıda Ödeme', N'deneme adres')
SET IDENTITY_INSERT [dbo].[satisveri] OFF
SET IDENTITY_INSERT [dbo].[urun] ON 

INSERT [dbo].[urun] ([urunID], [urun_ad], [urun_fiyat], [urun_aciklama]) VALUES (4, N'Süt (1 lt.)', 6, N'Paket taze süt.')
INSERT [dbo].[urun] ([urunID], [urun_ad], [urun_fiyat], [urun_aciklama]) VALUES (5, N'Çikolata', 3, N'Sütlü çikolata.')
INSERT [dbo].[urun] ([urunID], [urun_ad], [urun_fiyat], [urun_aciklama]) VALUES (6, N'Ekmek', 1.25, N'Taze ekmek.')
INSERT [dbo].[urun] ([urunID], [urun_ad], [urun_fiyat], [urun_aciklama]) VALUES (7, N'Cips', 4, N'Doritos Peynirli Patates Cİpsi')
SET IDENTITY_INSERT [dbo].[urun] OFF
SET IDENTITY_INSERT [dbo].[yonetici] ON 

INSERT [dbo].[yonetici] ([yoneticiID], [yon_sifre]) VALUES (1, N'1234')
SET IDENTITY_INSERT [dbo].[yonetici] OFF
ALTER TABLE [dbo].[satisveri]  WITH CHECK ADD  CONSTRAINT [FK_satisveri_musteri] FOREIGN KEY([musteriID])
REFERENCES [dbo].[musteri] ([musteriID])
GO
ALTER TABLE [dbo].[satisveri] CHECK CONSTRAINT [FK_satisveri_musteri]
GO
ALTER TABLE [dbo].[sepet]  WITH CHECK ADD  CONSTRAINT [FK_sepet_musteri] FOREIGN KEY([musteriID])
REFERENCES [dbo].[musteri] ([musteriID])
GO
ALTER TABLE [dbo].[sepet] CHECK CONSTRAINT [FK_sepet_musteri]
GO
ALTER TABLE [dbo].[sepet]  WITH CHECK ADD  CONSTRAINT [FK_sepet_urun] FOREIGN KEY([ID])
REFERENCES [dbo].[urun] ([urunID])
GO
ALTER TABLE [dbo].[sepet] CHECK CONSTRAINT [FK_sepet_urun]
GO
