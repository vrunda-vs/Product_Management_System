USE [gateway]
GO
/****** Object:  Table [dbo].[product_details]    Script Date: 14-01-2021 21:22:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[product_details](
	[product_id] [int] IDENTITY(1,1) NOT NULL,
	[userid] [int] NOT NULL,
	[product_name] [nvarchar](50) NOT NULL,
	[category] [nvarchar](30) NOT NULL,
	[price] [bigint] NOT NULL,
	[quantity] [bigint] NOT NULL,
	[short_description] [nvarchar](50) NOT NULL,
	[long_description] [nvarchar](100) NOT NULL,
	[small_img] [text] NOT NULL,
	[large_img] [text] NOT NULL,
 CONSTRAINT [PK_product_details] PRIMARY KEY CLUSTERED 
(
	[product_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Registration]    Script Date: 14-01-2021 21:22:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Registration](
	[userid] [int] IDENTITY(1,1) NOT NULL,
	[firstname] [nvarchar](50) NOT NULL,
	[lastname] [nvarchar](50) NOT NULL,
	[city] [nvarchar](50) NOT NULL,
	[state] [nvarchar](50) NOT NULL,
	[country] [nvarchar](50) NOT NULL,
	[email] [nvarchar](50) NOT NULL,
	[password] [nvarchar](50) NOT NULL,
	[mono] [bigint] NULL,
 CONSTRAINT [PK_Registration] PRIMARY KEY CLUSTERED 
(
	[userid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[student]    Script Date: 14-01-2021 21:22:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[student](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [nvarchar](50) NOT NULL,
	[email] [nvarchar](50) NULL,
	[age] [int] NOT NULL,
	[dob] [nvarchar](50) NULL,
	[doj] [datetime] NULL,
 CONSTRAINT [PK_student] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET IDENTITY_INSERT [dbo].[product_details] ON 

INSERT [dbo].[product_details] ([product_id], [userid], [product_name], [category], [price], [quantity], [short_description], [long_description], [small_img], [large_img]) VALUES (3, 1, N'Apple', N'Fruits', 100, 1, N'healthy', N'it is good for increase immunity', N'apple.jpg', N'banana.jpg')
INSERT [dbo].[product_details] ([product_id], [userid], [product_name], [category], [price], [quantity], [short_description], [long_description], [small_img], [large_img]) VALUES (4, 1, N'almond', N'dryfruits', 250, 1, N'good for health', N'healthy', N'almondsmall.jpg', N'almondlarge.jpg')
INSERT [dbo].[product_details] ([product_id], [userid], [product_name], [category], [price], [quantity], [short_description], [long_description], [small_img], [large_img]) VALUES (10, 1, N'Sony TV', N'Tv Appliance', 100000, 1, N'HD TV', N'easy to watch precious movement with your family ', N'TVsmall.jpg', N'largetv.png')
INSERT [dbo].[product_details] ([product_id], [userid], [product_name], [category], [price], [quantity], [short_description], [long_description], [small_img], [large_img]) VALUES (13, 1, N'iphone', N'Mobile', 70000, 1, N'High Quality', N'easy to use', N'small1mobile.jpg', N'large1mm.png')
SET IDENTITY_INSERT [dbo].[product_details] OFF
SET IDENTITY_INSERT [dbo].[Registration] ON 

INSERT [dbo].[Registration] ([userid], [firstname], [lastname], [city], [state], [country], [email], [password], [mono]) VALUES (1, N'vrunda', N'savaliya', N'surat', N'gujarat', N'india', N'vrunda.2511.vs@gmail.com', N'123456', 8767584838)
INSERT [dbo].[Registration] ([userid], [firstname], [lastname], [city], [state], [country], [email], [password], [mono]) VALUES (2, N'komal', N'savaliya', N'surat', N'gujarat', N'india', N'k@gmail.com', N'123456', 9700448008)
INSERT [dbo].[Registration] ([userid], [firstname], [lastname], [city], [state], [country], [email], [password], [mono]) VALUES (3, N'khushali', N'savaliya', N'surat', N'gujarat', N'india', N'kha@gmail.com', N'123456', 9700448008)
INSERT [dbo].[Registration] ([userid], [firstname], [lastname], [city], [state], [country], [email], [password], [mono]) VALUES (4, N'khushali', N'desai', N'Adoni', N'Andhra Pradesh', N'India', N'vihani@gmail.com', N'12345', 23456789)
INSERT [dbo].[Registration] ([userid], [firstname], [lastname], [city], [state], [country], [email], [password], [mono]) VALUES (5, N'khushali', N'desai', N'Adoni', N'Andhra Pradesh', N'in', N'vihani@gmail.com', N'2345', 123456)
INSERT [dbo].[Registration] ([userid], [firstname], [lastname], [city], [state], [country], [email], [password], [mono]) VALUES (6, N'khushali', N'desai', N'Adoni', N'Andhra Pradesh', N'in', N'vihani@gmail.com', N'23456', 123456)
INSERT [dbo].[Registration] ([userid], [firstname], [lastname], [city], [state], [country], [email], [password], [mono]) VALUES (7, N'vihani', N'desai', N'toronto', N'ontario', N'canada', N'vihanidesai@gmail.com', N'123456', 7800996690)
INSERT [dbo].[Registration] ([userid], [firstname], [lastname], [city], [state], [country], [email], [password], [mono]) VALUES (8, N'vivaan', N'savaliya', N'Surat', N'Gujrat', N'India', N'vivaan@gmail.com', N'123456', 2345678)
INSERT [dbo].[Registration] ([userid], [firstname], [lastname], [city], [state], [country], [email], [password], [mono]) VALUES (9, N'kayara', N'patel', N'saxony', N'chemnitz', N'germany', N'kayara@gmail.com', N'1234567', 9988779909)
SET IDENTITY_INSERT [dbo].[Registration] OFF
SET IDENTITY_INSERT [dbo].[student] ON 

INSERT [dbo].[student] ([id], [name], [email], [age], [dob], [doj]) VALUES (1, N'vrunda', N'vrunda@gmail.com', 20, N'20/12/1998', CAST(N'2005-02-01 00:00:00.000' AS DateTime))
SET IDENTITY_INSERT [dbo].[student] OFF
/****** Object:  StoredProcedure [dbo].[customer_add]    Script Date: 14-01-2021 21:22:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[customer_add]
@firstname nvarchar(50),
@lastname nvarchar(50),
@city nvarchar(50),
@state nvarchar(50),
@country nvarchar(50),
@email nvarchar(50),
@password nvarchar(50),
@mono nvarchar(50)
as
begin
insert into Registration values(
@firstname,
@lastname,
@city,
@state,
@country,
@email,
@password,
@mono
)
end

GO
/****** Object:  StoredProcedure [dbo].[EditProduct]    Script Date: 14-01-2021 21:22:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[EditProduct]
@product_id int,
@product_name nvarchar(50),
@category nvarchar(50),
@price int,
@quantity int,
@short_des nvarchar(100),
@long_des nvarchar(100)

as
begin
update product_details set product_name=@product_name , category=@category, price=@price , quantity=@quantity , short_description=@short_des,long_description=@long_des where product_id=@product_id;
end
GO
/****** Object:  StoredProcedure [dbo].[Login_credancial]    Script Date: 14-01-2021 21:22:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[Login_credancial]
@email nvarchar(50),
@password nvarchar(50)
as
begin
select firstname,lastname,userid from Registration where email=@email and password=@password; 
end

GO
/****** Object:  StoredProcedure [dbo].[product_add]    Script Date: 14-01-2021 21:22:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[product_add]
@userid int,
@product_name nvarchar(50),
@category nvarchar(50),
@price int,
@quality int,
@short_description nvarchar(50),
@long_description nvarchar(50),
@small_img nvarchar(50),
@large_img nvarchar(50)
as
begin
insert into product_details(userid,product_name,category,price,quantity,short_description,long_description,small_img,large_img) values(@userid,@product_name,@category,@price,@quality,@short_description,@long_description,@small_img,@large_img);
end






GO
/****** Object:  StoredProcedure [dbo].[product_add_details]    Script Date: 14-01-2021 21:22:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[product_add_details]
@userid int,
@product_name nvarchar(50),
@category nvarchar(50),
@price int,
@quality int,
@short_description nvarchar(100),
@long_description nvarchar(200),
@small_img nvarchar(100),
@large_img nvarchar(100)
as
begin
insert into product_details(userid,product_name,category,price,quantity,short_description,long_description,small_img,large_img) values(@userid,@product_name,@category,@price,@quality,@short_description,@long_description,@small_img,@large_img);
end






GO
/****** Object:  StoredProcedure [dbo].[viewdata]    Script Date: 14-01-2021 21:22:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[viewdata]
as
begin
select product_id,product_name,category,price,quantity,short_description,long_description,small_img,large_img from product_details;
end
GO
/****** Object:  StoredProcedure [dbo].[viewdatasearch]    Script Date: 14-01-2021 21:22:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[viewdatasearch]
@search nvarchar(40)
as
begin
select * from product_details order by category ASC
end
GO
