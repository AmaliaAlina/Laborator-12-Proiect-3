
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 03/13/2020 16:55:08
-- Generated from EDMX file: C:\Users\Amalia\source\repos\PictureManagerSolution\PictureManagerLibrary\ModelDBPicturesManager.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [DBPictures];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_MediaTableWays]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[TableWays] DROP CONSTRAINT [FK_MediaTableWays];
GO
IF OBJECT_ID(N'[dbo].[FK_TagsTableWays]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[TableWays] DROP CONSTRAINT [FK_TagsTableWays];
GO
IF OBJECT_ID(N'[dbo].[FK_TagTypeTableWays]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[TableWays] DROP CONSTRAINT [FK_TagTypeTableWays];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[Media]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Media];
GO
IF OBJECT_ID(N'[dbo].[Tags]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Tags];
GO
IF OBJECT_ID(N'[dbo].[TagTypes]', 'U') IS NOT NULL
    DROP TABLE [dbo].[TagTypes];
GO
IF OBJECT_ID(N'[dbo].[TableWays]', 'U') IS NOT NULL
    DROP TABLE [dbo].[TableWays];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Media'
CREATE TABLE [dbo].[Media] (
    [Id_Media] int IDENTITY(1,1) NOT NULL,
    [Media_name] nvarchar(max)  NOT NULL,
    [Media_path] nvarchar(max)  NOT NULL,
    [Is_Deleted] bit  NOT NULL
);
GO

-- Creating table 'Tags'
CREATE TABLE [dbo].[Tags] (
    [Id_Tags] int IDENTITY(1,1) NOT NULL,
    [Value_tag] nvarchar(max)  NULL,
    [Is_Deleted] bit  NOT NULL
);
GO

-- Creating table 'TagTypes'
CREATE TABLE [dbo].[TagTypes] (
    [Id_TagType] int IDENTITY(1,1) NOT NULL,
    [Value_tagType] nvarchar(max)  NULL,
    [Is_Deleted] bit  NOT NULL
);
GO

-- Creating table 'TableWays'
CREATE TABLE [dbo].[TableWays] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Is_Deleted] bit  NOT NULL,
    [Medium_Id_Media] int  NOT NULL,
    [Tag_Id_Tags] int  NOT NULL,
    [TagType_Id_TagType] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id_Media] in table 'Media'
ALTER TABLE [dbo].[Media]
ADD CONSTRAINT [PK_Media]
    PRIMARY KEY CLUSTERED ([Id_Media] ASC);
GO

-- Creating primary key on [Id_Tags] in table 'Tags'
ALTER TABLE [dbo].[Tags]
ADD CONSTRAINT [PK_Tags]
    PRIMARY KEY CLUSTERED ([Id_Tags] ASC);
GO

-- Creating primary key on [Id_TagType] in table 'TagTypes'
ALTER TABLE [dbo].[TagTypes]
ADD CONSTRAINT [PK_TagTypes]
    PRIMARY KEY CLUSTERED ([Id_TagType] ASC);
GO

-- Creating primary key on [Id] in table 'TableWays'
ALTER TABLE [dbo].[TableWays]
ADD CONSTRAINT [PK_TableWays]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [Medium_Id_Media] in table 'TableWays'
ALTER TABLE [dbo].[TableWays]
ADD CONSTRAINT [FK_MediaTableWays]
    FOREIGN KEY ([Medium_Id_Media])
    REFERENCES [dbo].[Media]
        ([Id_Media])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_MediaTableWays'
CREATE INDEX [IX_FK_MediaTableWays]
ON [dbo].[TableWays]
    ([Medium_Id_Media]);
GO

-- Creating foreign key on [Tag_Id_Tags] in table 'TableWays'
ALTER TABLE [dbo].[TableWays]
ADD CONSTRAINT [FK_TagsTableWays]
    FOREIGN KEY ([Tag_Id_Tags])
    REFERENCES [dbo].[Tags]
        ([Id_Tags])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_TagsTableWays'
CREATE INDEX [IX_FK_TagsTableWays]
ON [dbo].[TableWays]
    ([Tag_Id_Tags]);
GO

-- Creating foreign key on [TagType_Id_TagType] in table 'TableWays'
ALTER TABLE [dbo].[TableWays]
ADD CONSTRAINT [FK_TagTypeTableWays]
    FOREIGN KEY ([TagType_Id_TagType])
    REFERENCES [dbo].[TagTypes]
        ([Id_TagType])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_TagTypeTableWays'
CREATE INDEX [IX_FK_TagTypeTableWays]
ON [dbo].[TableWays]
    ([TagType_Id_TagType]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------