USE [WebShop]
GO
/****** Object:  Table [dbo].[Kategorije]    Script Date: 4/16/2019 2:27:06 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Kategorije](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Naziv] [nvarchar](50) NOT NULL,
	[Opis] [nvarchar](500) NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[KategorijeProizvodi]    Script Date: 4/16/2019 2:27:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KategorijeProizvodi](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[ProizvodId] [int] NOT NULL,
	[KategorijaId] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Korisnici]    Script Date: 4/16/2019 2:27:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Korisnici](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Ime] [nvarchar](50) NOT NULL,
	[Prezime] [nvarchar](50) NOT NULL,
	[Email] [varchar](50) NOT NULL,
	[AdresaDostave] [nvarchar](250) NOT NULL,
	[Kontakt] [varchar](50) NOT NULL,
	[Napomena] [nvarchar](max) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MjereProizvoda]    Script Date: 4/16/2019 2:27:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MjereProizvoda](
	[Id] [smallint] IDENTITY(1,1) NOT NULL,
	[Naziv] [nvarchar](10) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Narudzbe]    Script Date: 4/16/2019 2:27:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Narudzbe](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[KorisnikId] [int] NOT NULL,
	[Prezime] [nvarchar](50) NOT NULL,
	[Email] [varchar](50) NOT NULL,
	[DatumKreiranja] [datetime] NOT NULL,
	[DatumVrijemeDostave] [datetime] NOT NULL,
	[JeDostavljeno] [bit] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NarudzbeDetalji]    Script Date: 4/16/2019 2:27:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NarudzbeDetalji](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[NarudzbaId] [int] NULL,
	[ProizvodId] [int] NULL,
	[Kolicina] [decimal](18, 2) NOT NULL,
	[JedCijena] [decimal](18, 2) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Proizvodi]    Script Date: 4/16/2019 2:27:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Proizvodi](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[MjeraProizvodaId] [smallint] NOT NULL,
	[VrijemeKreiranja] [datetime] NOT NULL,
	[Naziv] [varchar](50) NOT NULL,
	[Cijena] [decimal](18, 2) NOT NULL,
	[Dostupan] [bit] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[KategorijeProizvodi]  WITH CHECK ADD FOREIGN KEY([KategorijaId])
REFERENCES [dbo].[Kategorije] ([Id])
GO
ALTER TABLE [dbo].[KategorijeProizvodi]  WITH CHECK ADD FOREIGN KEY([ProizvodId])
REFERENCES [dbo].[Proizvodi] ([Id])
GO
ALTER TABLE [dbo].[Narudzbe]  WITH CHECK ADD FOREIGN KEY([KorisnikId])
REFERENCES [dbo].[Korisnici] ([Id])
GO
ALTER TABLE [dbo].[NarudzbeDetalji]  WITH CHECK ADD FOREIGN KEY([NarudzbaId])
REFERENCES [dbo].[Narudzbe] ([Id])
GO
ALTER TABLE [dbo].[NarudzbeDetalji]  WITH CHECK ADD FOREIGN KEY([ProizvodId])
REFERENCES [dbo].[Proizvodi] ([Id])
GO
ALTER TABLE [dbo].[Proizvodi]  WITH CHECK ADD FOREIGN KEY([MjeraProizvodaId])
REFERENCES [dbo].[MjereProizvoda] ([Id])
GO
