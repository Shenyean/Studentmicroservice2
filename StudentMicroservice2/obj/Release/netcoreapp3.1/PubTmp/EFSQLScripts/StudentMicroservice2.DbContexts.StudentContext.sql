IF OBJECT_ID(N'[__EFMigrationsHistory]') IS NULL
BEGIN
    CREATE TABLE [__EFMigrationsHistory] (
        [MigrationId] nvarchar(150) NOT NULL,
        [ProductVersion] nvarchar(32) NOT NULL,
        CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY ([MigrationId])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200325044802_Initialcreate')
BEGIN
    CREATE TABLE [Ccas] (
        [Id] int NOT NULL IDENTITY,
        [Name] nvarchar(max) NULL,
        [Description] nvarchar(max) NULL,
        CONSTRAINT [PK_Ccas] PRIMARY KEY ([Id])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200325044802_Initialcreate')
BEGIN
    CREATE TABLE [Students] (
        [Id] int NOT NULL IDENTITY,
        [Name] nvarchar(max) NULL,
        [CcaId] int NOT NULL,
        CONSTRAINT [PK_Students] PRIMARY KEY ([Id])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200325044802_Initialcreate')
BEGIN
    IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'Description', N'Name') AND [object_id] = OBJECT_ID(N'[Ccas]'))
        SET IDENTITY_INSERT [Ccas] ON;
    INSERT INTO [Ccas] ([Id], [Description], [Name])
    VALUES (1, N'Div A and Div B Football team', N'Football');
    IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'Description', N'Name') AND [object_id] = OBJECT_ID(N'[Ccas]'))
        SET IDENTITY_INSERT [Ccas] OFF;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200325044802_Initialcreate')
BEGIN
    IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'Description', N'Name') AND [object_id] = OBJECT_ID(N'[Ccas]'))
        SET IDENTITY_INSERT [Ccas] ON;
    INSERT INTO [Ccas] ([Id], [Description], [Name])
    VALUES (2, N'Sing', N'Choir');
    IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'Description', N'Name') AND [object_id] = OBJECT_ID(N'[Ccas]'))
        SET IDENTITY_INSERT [Ccas] OFF;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200325044802_Initialcreate')
BEGIN
    IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'Description', N'Name') AND [object_id] = OBJECT_ID(N'[Ccas]'))
        SET IDENTITY_INSERT [Ccas] ON;
    INSERT INTO [Ccas] ([Id], [Description], [Name])
    VALUES (3, N'Draw', N'Art Class');
    IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'Description', N'Name') AND [object_id] = OBJECT_ID(N'[Ccas]'))
        SET IDENTITY_INSERT [Ccas] OFF;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200325044802_Initialcreate')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20200325044802_Initialcreate', N'3.1.3');
END;

GO

