USE [zfk]
GO
/****** Object:  Table [dbo].[T_User]    Script Date: 06/17/2015 10:42:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[T_User](
	[userID] [varchar](20) NOT NULL,
	[userName] [varchar](50) NULL,
	[userPassword] [varchar](50) NULL,
	[userGroup] [varchar](50) NULL,
 CONSTRAINT [PK_T_user] PRIMARY KEY CLUSTERED 
(
	[userID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'gly管理员、yh用户' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'T_User', @level2type=N'COLUMN',@level2name=N'userGroup'
GO
/****** Object:  Table [dbo].[T_TempStore]    Script Date: 06/17/2015 10:42:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[T_TempStore](
	[leftInstituteCode] [varchar](50) NOT NULL,
	[leftInstituteName] [varchar](200) NULL,
	[leftDeadline] [datetime] NULL,
 CONSTRAINT [PK_T_TempStore_1] PRIMARY KEY CLUSTERED 
(
	[leftInstituteCode] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[T_RequireModify]    Script Date: 06/17/2015 10:42:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[T_RequireModify](
	[leftInstituteCode] [varchar](50) NOT NULL,
	[leftInstituteName] [varchar](200) NULL,
	[leftDeadline] [datetime] NULL,
	[modifyHandleContent] [varchar](500) NULL,
	[handleDate] [datetime] NULL,
 CONSTRAINT [PK_T_RequireModify] PRIMARY KEY CLUSTERED 
(
	[leftInstituteCode] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[T_RequireFine]    Script Date: 06/17/2015 10:42:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[T_RequireFine](
	[leftInstituteCode] [varchar](50) NOT NULL,
	[leftInstituteName] [varchar](200) NULL,
	[leftDeadline] [datetime] NULL,
	[fineHandleContent] [varchar](500) NULL,
	[fineMoney] [int] NULL,
	[handleDate] [datetime] NULL,
 CONSTRAINT [PK_T_RequireFine] PRIMARY KEY CLUSTERED 
(
	[leftInstituteCode] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[T_LeftInstitute]    Script Date: 06/17/2015 10:42:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[T_LeftInstitute](
	[leftInstituteCode] [varchar](50) NOT NULL,
	[leftInstituteName] [varchar](200) NULL,
	[leftDeadline] [datetime] NULL,
 CONSTRAINT [PK_T_LeftInstitute] PRIMARY KEY CLUSTERED 
(
	[leftInstituteCode] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[T_CompareHistory]    Script Date: 06/17/2015 10:42:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[T_CompareHistory](
	[leftInstituteCode] [varchar](50) NOT NULL,
	[leftInstituteName] [varchar](200) NULL,
	[leftDeadline] [datetime] NULL,
 CONSTRAINT [PK_T_CompareHistory] PRIMARY KEY CLUSTERED 
(
	[leftInstituteCode] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
