USE [master]
GO
/****** Object:  Database [usuarios_otello]    Script Date: 12/09/2020 21:05:36 ******/
CREATE DATABASE [usuarios_otello]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'usuarios_otello', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\usuarios_otello.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'usuarios_otello_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\usuarios_otello_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [usuarios_otello] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [usuarios_otello].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [usuarios_otello] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [usuarios_otello] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [usuarios_otello] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [usuarios_otello] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [usuarios_otello] SET ARITHABORT OFF 
GO
ALTER DATABASE [usuarios_otello] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [usuarios_otello] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [usuarios_otello] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [usuarios_otello] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [usuarios_otello] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [usuarios_otello] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [usuarios_otello] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [usuarios_otello] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [usuarios_otello] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [usuarios_otello] SET  DISABLE_BROKER 
GO
ALTER DATABASE [usuarios_otello] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [usuarios_otello] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [usuarios_otello] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [usuarios_otello] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [usuarios_otello] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [usuarios_otello] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [usuarios_otello] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [usuarios_otello] SET RECOVERY FULL 
GO
ALTER DATABASE [usuarios_otello] SET  MULTI_USER 
GO
ALTER DATABASE [usuarios_otello] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [usuarios_otello] SET DB_CHAINING OFF 
GO
ALTER DATABASE [usuarios_otello] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [usuarios_otello] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [usuarios_otello] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'usuarios_otello', N'ON'
GO
ALTER DATABASE [usuarios_otello] SET QUERY_STORE = OFF
GO
USE [usuarios_otello]
GO
/****** Object:  Table [dbo].[base_usuarios]    Script Date: 12/09/2020 21:05:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[base_usuarios](
	[id_usu] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [nchar](50) NULL,
	[apellido] [nchar](50) NULL,
	[usuario] [nchar](50) NULL,
	[contraseña] [nchar](50) NULL,
	[nacimiento] [nchar](50) NULL,
	[pais] [nchar](50) NULL,
	[correo] [nchar](50) NULL,
 CONSTRAINT [PK_base_usuarios] PRIMARY KEY CLUSTERED 
(
	[id_usu] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[base_usuarios] ON 

INSERT [dbo].[base_usuarios] ([id_usu], [nombre], [apellido], [usuario], [contraseña], [nacimiento], [pais], [correo]) VALUES (1, N'elyte                                             ', N'lopez                                             ', N'dc                                                ', N'12345                                             ', N'1/2/2000                                          ', N'guatemala                                         ', N'elytedc@gmail.com                                 ')
INSERT [dbo].[base_usuarios] ([id_usu], [nombre], [apellido], [usuario], [contraseña], [nacimiento], [pais], [correo]) VALUES (2, N'marvin                                            ', N'lopez                                             ', N'dc                                                ', N'12345                                             ', N'1/2/2000                                          ', N'guatemala                                         ', N'elytedc@gmail.com                                 ')
INSERT [dbo].[base_usuarios] ([id_usu], [nombre], [apellido], [usuario], [contraseña], [nacimiento], [pais], [correo]) VALUES (3, N'marvin                                            ', N'lopez                                             ', N'dc                                                ', N'12345                                             ', N'aa                                                ', N'ss                                                ', N'nssj                                              ')
INSERT [dbo].[base_usuarios] ([id_usu], [nombre], [apellido], [usuario], [contraseña], [nacimiento], [pais], [correo]) VALUES (4, N'marvin                                            ', N'lopez                                             ', N'q                                                 ', N'12345                                             ', N'aa                                                ', N'ss                                                ', N'nssj                                              ')
INSERT [dbo].[base_usuarios] ([id_usu], [nombre], [apellido], [usuario], [contraseña], [nacimiento], [pais], [correo]) VALUES (5, N'john henry                                        ', N'lopez mijangos                                    ', N'201710392                                         ', N'100cristo                                         ', N'2/3/2000                                          ', N'guatemala                                         ', N'elytedc@gmail.com                                 ')
INSERT [dbo].[base_usuarios] ([id_usu], [nombre], [apellido], [usuario], [contraseña], [nacimiento], [pais], [correo]) VALUES (6, N'emrson                                            ', N's                                                 ', N'emerson                                           ', N'12345                                             ', N'2/3/2000                                          ', N'guatemala                                         ', N'dgdgd                                             ')
INSERT [dbo].[base_usuarios] ([id_usu], [nombre], [apellido], [usuario], [contraseña], [nacimiento], [pais], [correo]) VALUES (7, N'nancy                                             ', N'na                                                ', N'nancy                                             ', N'12345                                             ', N'1/2/2000                                          ', N'guatemala                                         ', N'elytedc@gmail.com                                 ')
INSERT [dbo].[base_usuarios] ([id_usu], [nombre], [apellido], [usuario], [contraseña], [nacimiento], [pais], [correo]) VALUES (8, N'nena                                              ', N'sharon scarlet                                    ', N'nenadc                                            ', N'12345                                             ', N'2020-09-15                                        ', N'guatemala                                         ', N'elytedc@gmail.com                                 ')
SET IDENTITY_INSERT [dbo].[base_usuarios] OFF
USE [master]
GO
ALTER DATABASE [usuarios_otello] SET  READ_WRITE 
GO
