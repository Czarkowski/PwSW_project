CREATE TABLE [StockAvailabilities] (
  [Id] integer PRIMARY KEY,
  [Name] text,
  [Quantity] real,
  [Unit] text
)
GO

CREATE TABLE [ReviewTypes] (
  [Id] integer PRIMARY KEY,
  [Name] text,
  [IsVisible] boolean DEFAULT (false),
  [Description] text DEFAULT ''
)
GO

CREATE TABLE [Review] (
  [Id] integer PRIMARY KEY,
  [ReviewTypeId] integer,
  [Description] text,
  [PlannedDate] timestamp,
  [RealizedDate] timestamp
)
GO

CREATE TABLE [Races] (
  [Id] integer PRIMARY KEY,
  [Name] text,
  [Description] text,
  [IsVisible] boolean
)
GO

CREATE TABLE [ProductionTypes] (
  [Id] integer PRIMARY KEY,
  [Name] text,
  [Description] text,
  [IsVisible] boolean
)
GO

CREATE TABLE [Productions] (
  [Id] integer PRIMARY KEY,
  [ProductionTypeId] integer
)
GO

CREATE TABLE [Notifications] (
  [Id] integer PRIMARY KEY,
  [ReviewId] integer,
  [LocalNotificationId] integer,
  [IsActivated] boolean,
  [Title] text,
  [Description] text,
  [NotifyTime] timestamp
)
GO

CREATE TABLE [Descriptions] (
  [Id] integer PRIMARY KEY,
  [Text] text
)
GO

CREATE TABLE [Photos] (
  [Id] integer PRIMARY KEY,
  [ImageData] blob,
  [DateTaken] timestamp,
  [DescriptionId] integer
)
GO

CREATE TABLE [BeeQueen] (
  [Id] integer PRIMARY KEY,
  [BirthDate] timestamp,
  [DeathDate] timestamp,
  [Description] text,
  [RaceId] integer
)
GO

CREATE TABLE [Hive] (
  [Id] integer PRIMARY KEY,
  [AddBeeQueenDate] timestamp,
  [BeeQueenId] integer,
  [Description] text,
  [IsNucleus] boolean,
  [Number] integer
)
GO

CREATE TABLE [ProductionHives] (
  [Id] integer PRIMARY KEY,
  [ProductionId] integer,
  [HiveId] integer
)
GO

CREATE TABLE [DescriptionHiveReview] (
  [Id] integer PRIMARY KEY,
  [ReviewId] integer,
  [HiveId] integer,
  [DescriptionId] integer
)
GO

EXEC sp_addextendedproperty
@name = N'Column_Description',
@value = 'Nullable',
@level0type = N'Schema', @level0name = 'dbo',
@level1type = N'Table',  @level1name = 'Review',
@level2type = N'Column', @level2name = 'RealizedDate';
GO

EXEC sp_addextendedproperty
@name = N'Column_Description',
@value = 'Nullable',
@level0type = N'Schema', @level0name = 'dbo',
@level1type = N'Table',  @level1name = 'BeeQueen',
@level2type = N'Column', @level2name = 'DeathDate';
GO

EXEC sp_addextendedproperty
@name = N'Column_Description',
@value = 'Nullable',
@level0type = N'Schema', @level0name = 'dbo',
@level1type = N'Table',  @level1name = 'BeeQueen',
@level2type = N'Column', @level2name = 'Description';
GO

EXEC sp_addextendedproperty
@name = N'Column_Description',
@value = 'Nullable',
@level0type = N'Schema', @level0name = 'dbo',
@level1type = N'Table',  @level1name = 'Hive',
@level2type = N'Column', @level2name = 'AddBeeQueenDate';
GO

EXEC sp_addextendedproperty
@name = N'Column_Description',
@value = 'Nullable',
@level0type = N'Schema', @level0name = 'dbo',
@level1type = N'Table',  @level1name = 'Hive',
@level2type = N'Column', @level2name = 'BeeQueenId';
GO

EXEC sp_addextendedproperty
@name = N'Column_Description',
@value = 'Nullable',
@level0type = N'Schema', @level0name = 'dbo',
@level1type = N'Table',  @level1name = 'DescriptionHiveReview',
@level2type = N'Column', @level2name = 'DescriptionId';
GO

ALTER TABLE [Review] ADD FOREIGN KEY ([ReviewTypeId]) REFERENCES [ReviewTypes] ([Id])
GO

ALTER TABLE [Productions] ADD FOREIGN KEY ([ProductionTypeId]) REFERENCES [ProductionTypes] ([Id])
GO

ALTER TABLE [Notifications] ADD FOREIGN KEY ([ReviewId]) REFERENCES [Review] ([Id])
GO

ALTER TABLE [Photos] ADD FOREIGN KEY ([DescriptionId]) REFERENCES [Descriptions] ([Id])
GO

ALTER TABLE [BeeQueen] ADD FOREIGN KEY ([RaceId]) REFERENCES [Races] ([Id])
GO

ALTER TABLE [BeeQueen] ADD FOREIGN KEY ([Id]) REFERENCES [Hive] ([BeeQueenId])
GO

ALTER TABLE [ProductionHives] ADD FOREIGN KEY ([ProductionId]) REFERENCES [Productions] ([Id])
GO

ALTER TABLE [ProductionHives] ADD FOREIGN KEY ([HiveId]) REFERENCES [Hive] ([Id])
GO

ALTER TABLE [DescriptionHiveReview] ADD FOREIGN KEY ([ReviewId]) REFERENCES [Review] ([Id])
GO

ALTER TABLE [DescriptionHiveReview] ADD FOREIGN KEY ([HiveId]) REFERENCES [Hive] ([Id])
GO

ALTER TABLE [Descriptions] ADD FOREIGN KEY ([Id]) REFERENCES [DescriptionHiveReview] ([DescriptionId])
GO
