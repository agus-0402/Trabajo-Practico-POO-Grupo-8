
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 06/07/2022 20:47:46
-- Generated from EDMX file: C:\Users\agusp\OneDrive\Escritorio\trabajo practico\vista\Modelo\Model1.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [CONCESIONARIO];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------


-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------


-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'UsuarioSet'
CREATE TABLE [dbo].[UsuarioSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Nombre] nvarchar(max)  NOT NULL,
    [Email] nvarchar(max)  NOT NULL,
    [DNI] nvarchar(max)  NOT NULL,
    [Contraseña] nvarchar(max)  NOT NULL,
    [Perfil_Id] int  NOT NULL
);
GO

-- Creating table 'PerfilSet'
CREATE TABLE [dbo].[PerfilSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Nombre] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'FormularioSet'
CREATE TABLE [dbo].[FormularioSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Nombre] nvarchar(max)  NOT NULL,
    [NombreSistema] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'PermisoSet'
CREATE TABLE [dbo].[PermisoSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Nombre] nvarchar(max)  NOT NULL,
    [NombreSistema] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'PermisoFormulario'
CREATE TABLE [dbo].[PermisoFormulario] (
    [Permiso_Id] int  NOT NULL,
    [Formulario_Id] int  NOT NULL
);
GO

-- Creating table 'PerfilFormulario'
CREATE TABLE [dbo].[PerfilFormulario] (
    [Perfil_Id] int  NOT NULL,
    [Formulario_Id] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'UsuarioSet'
ALTER TABLE [dbo].[UsuarioSet]
ADD CONSTRAINT [PK_UsuarioSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'PerfilSet'
ALTER TABLE [dbo].[PerfilSet]
ADD CONSTRAINT [PK_PerfilSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'FormularioSet'
ALTER TABLE [dbo].[FormularioSet]
ADD CONSTRAINT [PK_FormularioSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'PermisoSet'
ALTER TABLE [dbo].[PermisoSet]
ADD CONSTRAINT [PK_PermisoSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Permiso_Id], [Formulario_Id] in table 'PermisoFormulario'
ALTER TABLE [dbo].[PermisoFormulario]
ADD CONSTRAINT [PK_PermisoFormulario]
    PRIMARY KEY CLUSTERED ([Permiso_Id], [Formulario_Id] ASC);
GO

-- Creating primary key on [Perfil_Id], [Formulario_Id] in table 'PerfilFormulario'
ALTER TABLE [dbo].[PerfilFormulario]
ADD CONSTRAINT [PK_PerfilFormulario]
    PRIMARY KEY CLUSTERED ([Perfil_Id], [Formulario_Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [Perfil_Id] in table 'UsuarioSet'
ALTER TABLE [dbo].[UsuarioSet]
ADD CONSTRAINT [FK_UsuarioPerfil]
    FOREIGN KEY ([Perfil_Id])
    REFERENCES [dbo].[PerfilSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_UsuarioPerfil'
CREATE INDEX [IX_FK_UsuarioPerfil]
ON [dbo].[UsuarioSet]
    ([Perfil_Id]);
GO

-- Creating foreign key on [Permiso_Id] in table 'PermisoFormulario'
ALTER TABLE [dbo].[PermisoFormulario]
ADD CONSTRAINT [FK_PermisoFormulario_Permiso]
    FOREIGN KEY ([Permiso_Id])
    REFERENCES [dbo].[PermisoSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [Formulario_Id] in table 'PermisoFormulario'
ALTER TABLE [dbo].[PermisoFormulario]
ADD CONSTRAINT [FK_PermisoFormulario_Formulario]
    FOREIGN KEY ([Formulario_Id])
    REFERENCES [dbo].[FormularioSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_PermisoFormulario_Formulario'
CREATE INDEX [IX_FK_PermisoFormulario_Formulario]
ON [dbo].[PermisoFormulario]
    ([Formulario_Id]);
GO

-- Creating foreign key on [Perfil_Id] in table 'PerfilFormulario'
ALTER TABLE [dbo].[PerfilFormulario]
ADD CONSTRAINT [FK_PerfilFormulario_Perfil]
    FOREIGN KEY ([Perfil_Id])
    REFERENCES [dbo].[PerfilSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [Formulario_Id] in table 'PerfilFormulario'
ALTER TABLE [dbo].[PerfilFormulario]
ADD CONSTRAINT [FK_PerfilFormulario_Formulario]
    FOREIGN KEY ([Formulario_Id])
    REFERENCES [dbo].[FormularioSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_PerfilFormulario_Formulario'
CREATE INDEX [IX_FK_PerfilFormulario_Formulario]
ON [dbo].[PerfilFormulario]
    ([Formulario_Id]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------