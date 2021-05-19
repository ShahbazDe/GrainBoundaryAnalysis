USE [GBAnalysisDB]
GO

/****** Object:  Table [dbo].[Specimens]    Script Date: 19-May-21 9:38:12 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Specimens](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[UserID] [int] NOT NULL,
	[UserName] [nvarchar](200) NOT NULL,
	[GBLabel] [nvarchar](50) NOT NULL,
	[GBEnergy] [float] NOT NULL,
	[SolidificationFactor] [float] NOT NULL,
	[ThermalFactor] [float] NOT NULL,
 CONSTRAINT [PK_Specimens] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[Specimens] ADD  CONSTRAINT [DF_Specimens_ThermalFactor]  DEFAULT ((1)) FOR [ThermalFactor]
GO


