USE [master]
GO
/****** Object:  Database [Administrar]    Script Date: 13/10/2019 08:30:10 ******/
CREATE DATABASE [Administrar]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Administrar', FILENAME = N'C:\Users\Diego\AppData\Local\Microsoft\Microsoft SQL Server Local DB\Instances\MSSQLLocalDB\Administrar.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'Administrar_log', FILENAME = N'C:\Users\Diego\AppData\Local\Microsoft\Microsoft SQL Server Local DB\Instances\MSSQLLocalDB\Administrar_log.ldf' , SIZE = 2048KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [Administrar] SET COMPATIBILITY_LEVEL = 110
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Administrar].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Administrar] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Administrar] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Administrar] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Administrar] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Administrar] SET ARITHABORT OFF 
GO
ALTER DATABASE [Administrar] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Administrar] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Administrar] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Administrar] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Administrar] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Administrar] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Administrar] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Administrar] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Administrar] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Administrar] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Administrar] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Administrar] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Administrar] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Administrar] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Administrar] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Administrar] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Administrar] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Administrar] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [Administrar] SET  MULTI_USER 
GO
ALTER DATABASE [Administrar] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Administrar] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Administrar] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Administrar] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [Administrar] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [Administrar] SET QUERY_STORE = OFF
GO
USE [Administrar]
GO
ALTER DATABASE SCOPED CONFIGURATION SET LEGACY_CARDINALITY_ESTIMATION = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION SET MAXDOP = 0;
GO
ALTER DATABASE SCOPED CONFIGURATION SET PARAMETER_SNIFFING = ON;
GO
ALTER DATABASE SCOPED CONFIGURATION SET QUERY_OPTIMIZER_HOTFIXES = OFF;
GO
USE [Administrar]
GO
/****** Object:  Table [dbo].[Estados]    Script Date: 13/10/2019 08:30:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Estados](
	[idEstado] [int] IDENTITY(1,1) NOT NULL,
	[estado] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Estados] PRIMARY KEY CLUSTERED 
(
	[idEstado] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Estados] ON 
GO
INSERT [dbo].[Estados] ([idEstado], [estado]) VALUES (1, N'Estado 1')
GO
INSERT [dbo].[Estados] ([idEstado], [estado]) VALUES (2, N'Estado 2')
GO
INSERT [dbo].[Estados] ([idEstado], [estado]) VALUES (3, N'Estado 3')
GO
SET IDENTITY_INSERT [dbo].[Estados] OFF
GO
/****** Object:  StoredProcedure [dbo].[borrarEstados]    Script Date: 13/10/2019 08:30:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
create PROCEDURE [dbo].[borrarEstados] 
	-- Add the parameters for the stored procedure here
	@idEstado int = 0 
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
delete from Estados where idEstado=@idEstado 

END

GO
/****** Object:  StoredProcedure [dbo].[editarEstados]    Script Date: 13/10/2019 08:30:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[editarEstados] 
	-- Add the parameters for the stored procedure here
	@idEstado int = 0 ,
	@estado varchar(50) = "sin estado" 
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	UPDATE Estados SET estado = @estado where idEstado = @idEstado;

END

GO
/****** Object:  StoredProcedure [dbo].[insertarEstados]    Script Date: 13/10/2019 08:30:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[insertarEstados] 
	-- Add the parameters for the stored procedure here
	@estado varchar(50) = "sin estado" 
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
insert into Estados (estado) values (@estado)

END

GO
/****** Object:  StoredProcedure [dbo].[mostrarEstados]    Script Date: 13/10/2019 08:30:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[mostrarEstados] 
	-- Add the parameters for the stored procedure here
	
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
select estado from Estados

END

GO
USE [master]
GO
ALTER DATABASE [Administrar] SET  READ_WRITE 
GO
