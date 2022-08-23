IF OBJECT_ID(N'[__EFMigrationsHistory]') IS NULL
BEGIN
    CREATE TABLE [__EFMigrationsHistory] (
        [MigrationId] nvarchar(150) NOT NULL,
        [ProductVersion] nvarchar(32) NOT NULL,
        CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY ([MigrationId])
    );
END;
GO

BEGIN TRANSACTION;
GO

CREATE TABLE [Admin] (
    [Id] uniqueidentifier NOT NULL,
    [Name] NVARCHAR(80) NOT NULL,
    [Email] NVARCHAR(45) NOT NULL,
    [PasswordHash] NVARCHAR(80) NOT NULL,
    CONSTRAINT [PK_Admin] PRIMARY KEY ([Id])
);
GO

CREATE TABLE [Professor] (
    [Id] uniqueidentifier NOT NULL,
    [Name] NVARCHAR(80) NOT NULL,
    [Email] NVARCHAR(45) NOT NULL,
    [PasswordHash] NVARCHAR(80) NOT NULL,
    [Ocupation] NVARCHAR(80) NOT NULL,
    CONSTRAINT [PK_Professor] PRIMARY KEY ([Id])
);
GO

CREATE TABLE [Student] (
    [Id] uniqueidentifier NOT NULL,
    [Name] NVARCHAR(80) NOT NULL,
    [Email] NVARCHAR(45) NOT NULL,
    [PasswordHash] NVARCHAR(80) NOT NULL,
    [ClassNumber] INT NOT NULL,
    CONSTRAINT [PK_Student] PRIMARY KEY ([Id])
);
GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20220822165919_InitialCreation', N'6.0.7');
GO

COMMIT;
GO

