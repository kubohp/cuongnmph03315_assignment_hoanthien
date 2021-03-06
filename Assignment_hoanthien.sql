USE [Assignment]
GO
/****** Object:  Table [dbo].[customers]    Script Date: 10/18/2015 15:35:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[customers](
	[customer_id] [char](10) NOT NULL,
	[customer_name] [nvarchar](max) NOT NULL,
	[address] [nvarchar](max) NOT NULL,
	[phone] [char](10) NULL,
 CONSTRAINT [PK_customers] PRIMARY KEY CLUSTERED 
(
	[customer_id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[customers] ([customer_id], [customer_name], [address], [phone]) VALUES (N'KH001     ', N'Nguyen Manh Cuong', N'Hai Phong', N'01213037988')
INSERT [dbo].[customers] ([customer_id], [customer_name], [address], [phone]) VALUES (N'KH002     ', N'Trieu Van Viet', N'Hai Duong', N'01213037989')
INSERT [dbo].[customers] ([customer_id], [customer_name], [address], [phone]) VALUES (N'KH003     ', N'Nguyen Thanh Cong', N'Son La', N'01213037986')
INSERT [dbo].[customers] ([customer_id], [customer_name], [address], [phone]) VALUES (N'KH004     ', N'Nguyen Manh Tao', N'Bac Ninh', N'01213037987')
INSERT [dbo].[customers] ([customer_id], [customer_name], [address], [phone]) VALUES (N'KH05      ', N'Nong Van Than', N'Yen Bai', N'01213037985')
/****** Object:  Table [dbo].[types_product]    Script Date: 10/18/2015 15:35:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[types_product](
	[type_id] [char](10) NOT NULL,
	[type_name] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_types_product] PRIMARY KEY CLUSTERED 
(
	[type_id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[types_product] ([type_id], [type_name]) VALUES (N'1         ', N'Smart Phone')
INSERT [dbo].[types_product] ([type_id], [type_name]) VALUES (N'2         ', N'PC')
INSERT [dbo].[types_product] ([type_id], [type_name]) VALUES (N'3         ', N'Laptop')
INSERT [dbo].[types_product] ([type_id], [type_name]) VALUES (N'4         ', N'Desk Phone')
INSERT [dbo].[types_product] ([type_id], [type_name]) VALUES (N'5         ', N'SmartWatch')
/****** Object:  Table [dbo].[products]    Script Date: 10/18/2015 15:35:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[products](
	[product_id] [char](10) NOT NULL,
	[product_name] [nvarchar](max) NOT NULL,
	[amount] [char](10) NOT NULL,
	[description] [nvarchar](max) NOT NULL,
	[price] [char](10) NOT NULL,
	[type_id] [char](10) NOT NULL,
 CONSTRAINT [PK_products] PRIMARY KEY CLUSTERED 
(
	[product_id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[products] ([product_id], [product_name], [amount], [description], [price], [type_id]) VALUES (N'Dp001     ', N'Panasonic KXTS580', N'10        ', N'New', N'400.000   ', N'4         ')
INSERT [dbo].[products] ([product_id], [product_name], [amount], [description], [price], [type_id]) VALUES (N'Dp002     ', N'Panasonic KXTS520', N'5         ', N'New', N'550.000   ', N'4         ')
INSERT [dbo].[products] ([product_id], [product_name], [amount], [description], [price], [type_id]) VALUES (N'Dp003     ', N'Viettel KX-T2373', N'5         ', N'New', N'800.000   ', N'4         ')
INSERT [dbo].[products] ([product_id], [product_name], [amount], [description], [price], [type_id]) VALUES (N'Dp004     ', N'GAO126', N'10        ', N'New', N'350.000   ', N'4         ')
INSERT [dbo].[products] ([product_id], [product_name], [amount], [description], [price], [type_id]) VALUES (N'Lap001    ', N'Dell Inprison 4450', N'10        ', N'New', N'21.000.000', N'3         ')
INSERT [dbo].[products] ([product_id], [product_name], [amount], [description], [price], [type_id]) VALUES (N'Mob001    ', N'Iphone 4', N'23        ', N'LikeNew', N'2.500.000 ', N'1         ')
INSERT [dbo].[products] ([product_id], [product_name], [amount], [description], [price], [type_id]) VALUES (N'Mob002    ', N'Iphone 4s', N'24        ', N'New', N'4.100.000 ', N'1         ')
INSERT [dbo].[products] ([product_id], [product_name], [amount], [description], [price], [type_id]) VALUES (N'Mob003    ', N'Iphone 5', N'100       ', N'FullBox', N'5.400.000 ', N'1         ')
INSERT [dbo].[products] ([product_id], [product_name], [amount], [description], [price], [type_id]) VALUES (N'Mob004    ', N'Iphone 5s', N'12        ', N'LikeNew', N'9.800.000 ', N'1         ')
INSERT [dbo].[products] ([product_id], [product_name], [amount], [description], [price], [type_id]) VALUES (N'Mob005    ', N'Bphone', N'21        ', N'Made In VietNam', N'11.000.000', N'1         ')
INSERT [dbo].[products] ([product_id], [product_name], [amount], [description], [price], [type_id]) VALUES (N'Mob006    ', N'Samsung s6', N'11        ', N'New', N'10.000.000', N'1         ')
INSERT [dbo].[products] ([product_id], [product_name], [amount], [description], [price], [type_id]) VALUES (N'Pc001     ', N'Dell N4050', N'50        ', N'USA', N'5.999.000 ', N'2         ')
INSERT [dbo].[products] ([product_id], [product_name], [amount], [description], [price], [type_id]) VALUES (N'Pc002     ', N'AMD Ct92', N'21        ', N'New', N'9.900.000 ', N'2         ')
INSERT [dbo].[products] ([product_id], [product_name], [amount], [description], [price], [type_id]) VALUES (N'Pc003     ', N'Asus VT', N'10        ', N'New', N'5.700.000 ', N'2         ')
/****** Object:  Table [dbo].[invoices]    Script Date: 10/18/2015 15:35:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[invoices](
	[invoice_id] [char](10) NOT NULL,
	[initial_date] [date] NOT NULL,
	[customer_id] [char](10) NOT NULL,
	[total] [char](10) NOT NULL,
 CONSTRAINT [PK_invoices] PRIMARY KEY CLUSTERED 
(
	[invoice_id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[invoices] ([invoice_id], [initial_date], [customer_id], [total]) VALUES (N'HD001     ', CAST(0x923A0B00 AS Date), N'KH002     ', N'22        ')
INSERT [dbo].[invoices] ([invoice_id], [initial_date], [customer_id], [total]) VALUES (N'HD002     ', CAST(0x8A3A0B00 AS Date), N'KH001     ', N'12        ')
INSERT [dbo].[invoices] ([invoice_id], [initial_date], [customer_id], [total]) VALUES (N'HD003     ', CAST(0x843A0B00 AS Date), N'KH001     ', N'23        ')
INSERT [dbo].[invoices] ([invoice_id], [initial_date], [customer_id], [total]) VALUES (N'HD004     ', CAST(0x8A3A0B00 AS Date), N'KH003     ', N'11        ')
INSERT [dbo].[invoices] ([invoice_id], [initial_date], [customer_id], [total]) VALUES (N'HD005     ', CAST(0x843A0B00 AS Date), N'KH002     ', N'69        ')
INSERT [dbo].[invoices] ([invoice_id], [initial_date], [customer_id], [total]) VALUES (N'HD006     ', CAST(0x8A3A0B00 AS Date), N'KH001     ', N'1         ')
/****** Object:  Table [dbo].[details_invoice]    Script Date: 10/18/2015 15:35:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[details_invoice](
	[invoice_id] [char](10) NOT NULL,
	[product_id] [char](10) NOT NULL,
	[unit_price] [char](15) NOT NULL,
	[amount_purchase] [char](10) NOT NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[details_invoice] ([invoice_id], [product_id], [unit_price], [amount_purchase]) VALUES (N'HD001     ', N'Mob001    ', N'2.500.000      ', N'2.500.000 ')
/****** Object:  ForeignKey [FK_details_invoice_invoices]    Script Date: 10/18/2015 15:35:39 ******/
ALTER TABLE [dbo].[details_invoice]  WITH CHECK ADD  CONSTRAINT [FK_details_invoice_invoices] FOREIGN KEY([invoice_id])
REFERENCES [dbo].[invoices] ([invoice_id])
GO
ALTER TABLE [dbo].[details_invoice] CHECK CONSTRAINT [FK_details_invoice_invoices]
GO
/****** Object:  ForeignKey [FK_details_invoice_products]    Script Date: 10/18/2015 15:35:39 ******/
ALTER TABLE [dbo].[details_invoice]  WITH CHECK ADD  CONSTRAINT [FK_details_invoice_products] FOREIGN KEY([product_id])
REFERENCES [dbo].[products] ([product_id])
GO
ALTER TABLE [dbo].[details_invoice] CHECK CONSTRAINT [FK_details_invoice_products]
GO
/****** Object:  ForeignKey [FK_invoices_customers]    Script Date: 10/18/2015 15:35:39 ******/
ALTER TABLE [dbo].[invoices]  WITH CHECK ADD  CONSTRAINT [FK_invoices_customers] FOREIGN KEY([customer_id])
REFERENCES [dbo].[customers] ([customer_id])
GO
ALTER TABLE [dbo].[invoices] CHECK CONSTRAINT [FK_invoices_customers]
GO
/****** Object:  ForeignKey [FK_products_types_product]    Script Date: 10/18/2015 15:35:39 ******/
ALTER TABLE [dbo].[products]  WITH CHECK ADD  CONSTRAINT [FK_products_types_product] FOREIGN KEY([type_id])
REFERENCES [dbo].[types_product] ([type_id])
GO
ALTER TABLE [dbo].[products] CHECK CONSTRAINT [FK_products_types_product]
GO
