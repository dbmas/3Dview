USE [3dview]
GO
/****** Object:  Table [dbo].[ktx]    Script Date: 2024/4/19 17:01:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ktx](
	[id] [bigint] IDENTITY(1,1) NOT NULL,
	[ktxNo] [nvarchar](50) NOT NULL,
	[zkNo] [nvarchar](50) NOT NULL,
	[zkKtxNo] [nvarchar](50) NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[zkBase]    Script Date: 2024/4/19 17:01:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[zkBase](
	[id] [bigint] IDENTITY(1,1) NOT NULL,
	[zkNo] [nvarchar](50) NOT NULL,
	[zkQj] [numeric](10, 2) NOT NULL,
	[xZb] [numeric](18, 3) NOT NULL,
	[yZb] [numeric](18, 3) NOT NULL,
	[zZb] [numeric](18, 3) NOT NULL,
	[zkSd] [numeric](18, 3) NOT NULL,
	[endSd] [numeric](18, 3) NOT NULL,
	[endCw] [nvarchar](50) NOT NULL,
	[endXd] [numeric](10, 3) NOT NULL,
	[startDate] [date] NOT NULL,
	[endQ] [numeric](18, 3) NOT NULL,
	[sgDw] [nvarchar](50) NOT NULL,
	[sgDd] [nvarchar](50) NOT NULL,
	[cgCw] [nvarchar](50) NOT NULL,
	[cgMc] [nvarchar](50) NOT NULL,
	[cjSd] [numeric](18, 3) NOT NULL,
	[cjQ] [numeric](18, 2) NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[zkYanXing]    Script Date: 2024/4/19 17:01:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[zkYanXing](
	[id] [bigint] IDENTITY(1,1) NOT NULL,
	[zkNo] [nvarchar](50) NOT NULL,
	[dcDmj] [nvarchar](50) NOT NULL,
	[dcDmt] [nvarchar](50) NOT NULL,
	[dcDmd] [nvarchar](50) NOT NULL,
	[ycCh] [nvarchar](50) NOT NULL,
	[dcDmx] [nvarchar](50) NOT NULL,
	[dcDmz] [nvarchar](50) NOT NULL,
	[ycLjJhd] [numeric](18, 3) NOT NULL,
	[ycJhd] [numeric](18, 3) NOT NULL,
	[ysMc] [nvarchar](50) NOT NULL,
	[ycZhd] [nvarchar](50) NOT NULL,
	[ycLjZhd] [nvarchar](50) NOT NULL,
	[yxMs] [nvarchar](300) NOT NULL,
	[ycQj] [numeric](10, 3) NOT NULL,
	[cql] [numeric](10, 3) NOT NULL,
	[cc] [numeric](10, 3) NOT NULL,
	[bzcMc] [nvarchar](50) NOT NULL
) ON [PRIMARY]
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'勘探线编号' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'ktx', @level2type=N'COLUMN',@level2name=N'ktxNo'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'钻孔编号' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'ktx', @level2type=N'COLUMN',@level2name=N'zkNo'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'钻孔在该勘探线中的编号' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'ktx', @level2type=N'COLUMN',@level2name=N'zkKtxNo'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'钻孔编号' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'zkBase', @level2type=N'COLUMN',@level2name=N'zkNo'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'钻孔倾角' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'zkBase', @level2type=N'COLUMN',@level2name=N'zkQj'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'孔口x坐标' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'zkBase', @level2type=N'COLUMN',@level2name=N'xZb'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'孔口y坐标' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'zkBase', @level2type=N'COLUMN',@level2name=N'yZb'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'孔口z坐标' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'zkBase', @level2type=N'COLUMN',@level2name=N'zZb'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'钻孔深度' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'zkBase', @level2type=N'COLUMN',@level2name=N'zkSd'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'终孔深度' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'zkBase', @level2type=N'COLUMN',@level2name=N'endSd'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'终孔层位' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'zkBase', @level2type=N'COLUMN',@level2name=N'endCw'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'最终斜度' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'zkBase', @level2type=N'COLUMN',@level2name=N'endXd'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'开工日期' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'zkBase', @level2type=N'COLUMN',@level2name=N'startDate'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'竣工日期' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'zkBase', @level2type=N'COLUMN',@level2name=N'endQ'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'施工单位' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'zkBase', @level2type=N'COLUMN',@level2name=N'sgDw'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'施工地点' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'zkBase', @level2type=N'COLUMN',@level2name=N'sgDd'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'穿过层位' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'zkBase', @level2type=N'COLUMN',@level2name=N'cgCw'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'穿过煤层' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'zkBase', @level2type=N'COLUMN',@level2name=N'cgMc'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'测井深度' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'zkBase', @level2type=N'COLUMN',@level2name=N'cjSd'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'测井期' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'zkBase', @level2type=N'COLUMN',@level2name=N'cjQ'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'钻孔编号' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'zkYanXing', @level2type=N'COLUMN',@level2name=N'zkNo'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'地层代码界' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'zkYanXing', @level2type=N'COLUMN',@level2name=N'dcDmj'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'地层代码统' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'zkYanXing', @level2type=N'COLUMN',@level2name=N'dcDmt'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'地层代码段' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'zkYanXing', @level2type=N'COLUMN',@level2name=N'dcDmd'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'岩层层号' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'zkYanXing', @level2type=N'COLUMN',@level2name=N'ycCh'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'地层代码系' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'zkYanXing', @level2type=N'COLUMN',@level2name=N'dcDmx'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'地层代码组' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'zkYanXing', @level2type=N'COLUMN',@level2name=N'dcDmz'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'岩层累计假厚度' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'zkYanXing', @level2type=N'COLUMN',@level2name=N'ycLjJhd'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'岩层假厚度' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'zkYanXing', @level2type=N'COLUMN',@level2name=N'ycJhd'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'岩石名称' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'zkYanXing', @level2type=N'COLUMN',@level2name=N'ysMc'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'岩层真厚度' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'zkYanXing', @level2type=N'COLUMN',@level2name=N'ycZhd'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'岩层累计真厚度' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'zkYanXing', @level2type=N'COLUMN',@level2name=N'ycLjZhd'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'岩性描述' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'zkYanXing', @level2type=N'COLUMN',@level2name=N'yxMs'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'岩层倾角' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'zkYanXing', @level2type=N'COLUMN',@level2name=N'ycQj'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'采取率' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'zkYanXing', @level2type=N'COLUMN',@level2name=N'cql'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'采长' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'zkYanXing', @level2type=N'COLUMN',@level2name=N'cc'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'标志层名称' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'zkYanXing', @level2type=N'COLUMN',@level2name=N'bzcMc'
GO
