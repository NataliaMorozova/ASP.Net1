IF OBJECT_ID(N'__EFMigrationsHistory') IS NULL
BEGIN
    CREATE TABLE [__EFMigrationsHistory] (
        [MigrationId] nvarchar(150) NOT NULL,
        [ProductVersion] nvarchar(32) NOT NULL,
        CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY ([MigrationId])
    );
END;

GO

CREATE TABLE [Brands] (
    [id] int NOT NULL IDENTITY,
    [Name] nvarchar(max) NULL,
    [Order] int NOT NULL,
    CONSTRAINT [PK_Brands] PRIMARY KEY ([id])
);

GO

CREATE TABLE [Sections] (
    [id] int NOT NULL IDENTITY,
    [Name] nvarchar(max) NULL,
    [Order] int NOT NULL,
    [ParentId] int NULL,
    CONSTRAINT [PK_Sections] PRIMARY KEY ([id]),
    CONSTRAINT [FK_Sections_Sections_ParentId] FOREIGN KEY ([ParentId]) REFERENCES [Sections] ([id]) ON DELETE NO ACTION
);

GO

CREATE TABLE [Products] (
    [id] int NOT NULL IDENTITY,
    [BrandId] int NULL,
    [ImageUrl] nvarchar(max) NULL,
    [Name] nvarchar(max) NULL,
    [Order] int NOT NULL,
    [Price] decimal(18, 2) NOT NULL,
    [SectionId] int NOT NULL,
    CONSTRAINT [PK_Products] PRIMARY KEY ([id]),
    CONSTRAINT [FK_Products_Brands_BrandId] FOREIGN KEY ([BrandId]) REFERENCES [Brands] ([id]) ON DELETE NO ACTION,
    CONSTRAINT [FK_Products_Sections_SectionId] FOREIGN KEY ([SectionId]) REFERENCES [Sections] ([id]) ON DELETE CASCADE
);

GO

CREATE INDEX [IX_Products_BrandId] ON [Products] ([BrandId]);

GO

CREATE INDEX [IX_Products_SectionId] ON [Products] ([SectionId]);

GO

CREATE INDEX [IX_Sections_ParentId] ON [Sections] ([ParentId]);

GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20181123143341_Initial', N'2.0.0-rtm-26452');

GO

