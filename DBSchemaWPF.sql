USE [Lawyer Database]
GO
/****** Object:  Table [dbo].[Case]    Script Date: 28-Dec-17 1:15:59 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Case](
	[CaseId] [varchar](10) NOT NULL,
	[CaseName] [nvarchar](100) NOT NULL,
	[Plaintiff] [nvarchar](50) NOT NULL,
	[Defender] [nvarchar](50) NOT NULL,
	[OpponentLawyer] [nvarchar](50) NULL,
	[CaseDiscription] [nvarchar](max) NOT NULL,
	[startDate] [date] NOT NULL,
	[CourtId] [uniqueidentifier] NOT NULL,
	[CaseType] [varchar](20) NOT NULL,
	[ClientId] [nvarchar](20) NOT NULL,
	[isComplete] [bit] NULL,
 CONSTRAINT [PK_Case] PRIMARY KEY CLUSTERED 
(
	[CaseId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[CaseHearingDate]    Script Date: 28-Dec-17 1:16:00 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[CaseHearingDate](
	[CaseHearingId] [int] IDENTITY(1,1) NOT NULL,
	[CaseId] [varchar](10) NOT NULL,
	[HearingDate] [date] NOT NULL,
	[HearingTime] [time](7) NULL,
 CONSTRAINT [PK_CaseHearingDate] PRIMARY KEY CLUSTERED 
(
	[CaseHearingId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Client]    Script Date: 28-Dec-17 1:16:00 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Client](
	[ClientId] [nvarchar](20) NOT NULL,
	[ClientName] [nvarchar](30) NOT NULL,
	[ClientFname] [nvarchar](30) NOT NULL,
	[ClientContact] [nvarchar](20) NOT NULL,
	[ClientAddress] [nvarchar](200) NOT NULL,
 CONSTRAINT [PK_Client] PRIMARY KEY CLUSTERED 
(
	[ClientId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Court]    Script Date: 28-Dec-17 1:16:00 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Court](
	[CourtId] [uniqueidentifier] NOT NULL CONSTRAINT [DF_Court_CourtId]  DEFAULT (newid()),
	[CourtType] [nvarchar](60) NOT NULL,
	[CourtCity] [nvarchar](30) NOT NULL,
 CONSTRAINT [PK_Court] PRIMARY KEY CLUSTERED 
(
	[CourtId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[UserAccount]    Script Date: 28-Dec-17 1:16:00 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[UserAccount](
	[userName] [varchar](50) NOT NULL,
	[password] [varchar](512) NOT NULL,
	[userId] [int] IDENTITY(1,1) NOT NULL,
	[name] [varchar](50) NOT NULL,
	[email] [nvarchar](50) NOT NULL,
	[Contact] [nvarchar](50) NOT NULL,
	[RoleID] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_UserAccount] PRIMARY KEY CLUSTERED 
(
	[userName] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[UserRoles]    Script Date: 28-Dec-17 1:16:00 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[UserRoles](
	[roleID] [nvarchar](50) NOT NULL,
	[roleName] [varchar](50) NOT NULL,
 CONSTRAINT [PK_UserRoles] PRIMARY KEY CLUSTERED 
(
	[roleID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[Case] ([CaseId], [CaseName], [Plaintiff], [Defender], [OpponentLawyer], [CaseDiscription], [startDate], [CourtId], [CaseType], [ClientId], [isComplete]) VALUES (N'ABC124', N'ABC124-Huzaifa', N'Huzaifa', N'Rabnawaz Nadeem', N'Hammad', N'This is sample Description for this case.. 
', CAST(N'2017-12-14' AS Date), N'435b78c1-09a3-4d85-bed9-c8b9018d7fff', N'RettPetition', N'88888-8888888-8', 1)
INSERT [dbo].[Case] ([CaseId], [CaseName], [Plaintiff], [Defender], [OpponentLawyer], [CaseDiscription], [startDate], [CourtId], [CaseType], [ClientId], [isComplete]) VALUES (N'ABC130', N'ABC130-Ikramulla', N'Ikram ullah', N'kareem', N'haneef', N'this is sample of  casethis is sample of  casethis is sample of  casethis is sample of  casethis is sample of  casethis is sample of  casethis is sample of  casethis is sample of  casethis is sample of  casethis is sample of  case this is sample of  case this is sample of  casethis is sample of  casethis is sample of  case this is sample of  casethis is sample of  casethis is sample of  casethis is sample of  casethis is sample of  casethis is sample of  casethis is sample of  casethis is sample of  casethis is sample of  casethis is sample of  casethis is sample of  casethis is sample of  casethis is sample of  casethis is sample of  casethis is sample of  casethis is sample of  casethis is sample of  casethis is sample of  casethis is sample of  casethis is sample of  casethis is sample of  casethis is sample of  casethis is sample of  casethis is sample of  casethis is sample of  casethis is sample of  casethis is sample of  casethis is sample of  casethis is sample of  casethis is sample of  casethis is sample of  casethis is sample of  casethis is sample of  casethis is sample of  casethis is sample of  casethis is sample of  casethis is sample of  casethis is sample of  casethis is sample of  casethis is sample of  case  this is sample of  casethis is sample of  casethis is sample of  casethis is sample of  casethis is sample of  casethis is sample of  casethis is sample of  casethis is sample of  case
', CAST(N'2017-12-24' AS Date), N'34ebd061-1004-42f4-b7f3-74b825ccc26e', N'Civilian', N'00000-0000000-0', 0)
INSERT [dbo].[Case] ([CaseId], [CaseName], [Plaintiff], [Defender], [OpponentLawyer], [CaseDiscription], [startDate], [CourtId], [CaseType], [ClientId], [isComplete]) VALUES (N'ABC132', N'ABC132-Matloob', N'Matloob', N'goverment', N'NLC', N'Matloob claims that this land is belong to him
', CAST(N'2017-12-26' AS Date), N'efcbb71d-b939-4553-ae93-2f5cc8ba421a', N'RettPetition', N'11111-1111111-1', 0)
INSERT [dbo].[Case] ([CaseId], [CaseName], [Plaintiff], [Defender], [OpponentLawyer], [CaseDiscription], [startDate], [CourtId], [CaseType], [ClientId], [isComplete]) VALUES (N'ABC133', N'ABC133-Murtaza', N'Naveed', N'Murtaza', N'Habib', N'this case is belongs to muratza khan
', CAST(N'2017-12-22' AS Date), N'435b78c1-09a3-4d85-bed9-c8b9018d7fff', N'Family', N'33333-3333333-3', 1)
SET IDENTITY_INSERT [dbo].[CaseHearingDate] ON 

INSERT [dbo].[CaseHearingDate] ([CaseHearingId], [CaseId], [HearingDate], [HearingTime]) VALUES (3, N'ABC124', CAST(N'2017-12-18' AS Date), NULL)
INSERT [dbo].[CaseHearingDate] ([CaseHearingId], [CaseId], [HearingDate], [HearingTime]) VALUES (2020, N'ABC130', CAST(N'2017-12-28' AS Date), CAST(N'09:00:00' AS Time))
INSERT [dbo].[CaseHearingDate] ([CaseHearingId], [CaseId], [HearingDate], [HearingTime]) VALUES (2021, N'ABC132', CAST(N'2017-12-28' AS Date), CAST(N'09:00:00' AS Time))
INSERT [dbo].[CaseHearingDate] ([CaseHearingId], [CaseId], [HearingDate], [HearingTime]) VALUES (2022, N'ABC132', CAST(N'2017-12-27' AS Date), CAST(N'10:00:00' AS Time))
SET IDENTITY_INSERT [dbo].[CaseHearingDate] OFF
INSERT [dbo].[Client] ([ClientId], [ClientName], [ClientFname], [ClientContact], [ClientAddress]) VALUES (N'00000-0000000-0', N'Ikram ullah', N'kareem Khan', N'4444-4444444', N'Islamabad sector E-7/2 ')
INSERT [dbo].[Client] ([ClientId], [ClientName], [ClientFname], [ClientContact], [ClientAddress]) VALUES (N'11111-1111111-1', N'Matloob', N'Rab nawaz Nadeem', N'2121-2121212', N'Multan Karachi
')
INSERT [dbo].[Client] ([ClientId], [ClientName], [ClientFname], [ClientContact], [ClientAddress]) VALUES (N'33333-3333333-3', N'Murtaza', N'Ahsan Khan', N'9800-0000000', N'Kharachi, Pakistan
')
INSERT [dbo].[Client] ([ClientId], [ClientName], [ClientFname], [ClientContact], [ClientAddress]) VALUES (N'44444-4444444-4', N'Umer Azam', N'Muhammad Azam', N'1213-1212312', N'Gujranwala, pakistan
')
INSERT [dbo].[Client] ([ClientId], [ClientName], [ClientFname], [ClientContact], [ClientAddress]) VALUES (N'66666-6666666-6', N'Aziz Ullah', N'Naeem Khan', N'1212-3131231', N'khanpur, rahimyar khan
')
INSERT [dbo].[Client] ([ClientId], [ClientName], [ClientFname], [ClientContact], [ClientAddress]) VALUES (N'88888-8888888-8', N'Huzaifa', N'Rab nawaz Nadeem', N'1234-5678901', N'room A-4, Kuwait Hostel, street#4 Sector E-7/2, Islamabad')
INSERT [dbo].[Client] ([ClientId], [ClientName], [ClientFname], [ClientContact], [ClientAddress]) VALUES (N'99999-9999999-9', N'Ahsan Khan', N'Kaleem Ahmad', N'5678-9009873', N'Khayaban e Sarwar, street#4, house#7 DG Khan
')
INSERT [dbo].[Court] ([CourtId], [CourtType], [CourtCity]) VALUES (N'efcbb71d-b939-4553-ae93-2f5cc8ba421a', N'High Court', N'Islamabad')
INSERT [dbo].[Court] ([CourtId], [CourtType], [CourtCity]) VALUES (N'34ebd061-1004-42f4-b7f3-74b825ccc26e', N'Supreme Court', N'Islamabad')
INSERT [dbo].[Court] ([CourtId], [CourtType], [CourtCity]) VALUES (N'435b78c1-09a3-4d85-bed9-c8b9018d7fff', N'High Court', N'Multan')
INSERT [dbo].[Court] ([CourtId], [CourtType], [CourtCity]) VALUES (N'4beec050-680d-4d4c-b41a-d03d99093aab', N'Supreme Court', N'Lahore Bench')
SET IDENTITY_INSERT [dbo].[UserAccount] ON 

INSERT [dbo].[UserAccount] ([userName], [password], [userId], [name], [email], [Contact], [RoleID]) VALUES (N'adeel', N'36-27-90-9A-29-C3-13-81-A0-71-EC-27-F7-C9-CA-97-72-61-82-AE-D2-9A-7D-DD-2E-54-35-33-22-CF-B3-0A-BB-9E-3A-6D-F2-AC-2C-20-FE-23-43-63-11-D6-78-56-4D-0C-8D-30-59-30-57-5F-60-E2-D3-D0-48-18-4D-79', 4, N'Muhammad Adeel', N'adeel786@gmail.com', N'0000-0000000', N'6F7415F0-61C1-4A83-8C2D-8499A1BF6B83')
INSERT [dbo].[UserAccount] ([userName], [password], [userId], [name], [email], [Contact], [RoleID]) VALUES (N'fahad', N'36-27-90-9A-29-C3-13-81-A0-71-EC-27-F7-C9-CA-97-72-61-82-AE-D2-9A-7D-DD-2E-54-35-33-22-CF-B3-0A-BB-9E-3A-6D-F2-AC-2C-20-FE-23-43-63-11-D6-78-56-4D-0C-8D-30-59-30-57-5F-60-E2-D3-D0-48-18-4D-79', 3, N'Muhammad Fahad', N'fahad786@gmail.com', N'0000-0000000', N'dd2ee25f-1fc4-44b1-920a-9c24a543c5fd')
INSERT [dbo].[UserAccount] ([userName], [password], [userId], [name], [email], [Contact], [RoleID]) VALUES (N'matloob', N'36-27-90-9A-29-C3-13-81-A0-71-EC-27-F7-C9-CA-97-72-61-82-AE-D2-9A-7D-DD-2E-54-35-33-22-CF-B3-0A-BB-9E-3A-6D-F2-AC-2C-20-FE-23-43-63-11-D6-78-56-4D-0C-8D-30-59-30-57-5F-60-E2-D3-D0-48-18-4D-79', 7, N'Matloob uz Zaman', N'matloob786@gmail.com', N'8888-8888888', N'6F7415F0-61C1-4A83-8C2D-8499A1BF6B83')
SET IDENTITY_INSERT [dbo].[UserAccount] OFF
INSERT [dbo].[UserRoles] ([roleID], [roleName]) VALUES (N'6F7415F0-61C1-4A83-8C2D-8499A1BF6B83', N'Employee')
INSERT [dbo].[UserRoles] ([roleID], [roleName]) VALUES (N'dd2ee25f-1fc4-44b1-920a-9c24a543c5fd', N'Admin')
ALTER TABLE [dbo].[Case]  WITH CHECK ADD  CONSTRAINT [FK_Case_Client] FOREIGN KEY([ClientId])
REFERENCES [dbo].[Client] ([ClientId])
GO
ALTER TABLE [dbo].[Case] CHECK CONSTRAINT [FK_Case_Client]
GO
ALTER TABLE [dbo].[Case]  WITH CHECK ADD  CONSTRAINT [FK_Case_Court] FOREIGN KEY([CourtId])
REFERENCES [dbo].[Court] ([CourtId])
GO
ALTER TABLE [dbo].[Case] CHECK CONSTRAINT [FK_Case_Court]
GO
ALTER TABLE [dbo].[UserAccount]  WITH CHECK ADD  CONSTRAINT [FK_UserAccount_UserRoles] FOREIGN KEY([RoleID])
REFERENCES [dbo].[UserRoles] ([roleID])
GO
ALTER TABLE [dbo].[UserAccount] CHECK CONSTRAINT [FK_UserAccount_UserRoles]
GO
