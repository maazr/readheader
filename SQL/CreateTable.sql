USE [UTILS]
GO

/****** Object:  Table [dbo].[filecolumns]    Script Date: 3/8/2020 9:42:36 PM ******/
DROP TABLE [dbo].[filecolumns]
GO

/****** Object:  Table [dbo].[filecolumns]    Script Date: 3/8/2020 9:42:36 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[filecolumns](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[ColumnName] [varchar](100) NULL
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO


