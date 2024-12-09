-- Script Date: 09.12.2024 19:13  - ErikEJ.SqlCeScripting version 3.5.2.95
-- Database information:
-- Database: E:\BeeApp\BeeApp.db
-- ServerVersion: 3.40.0
-- DatabaseSize: 128 KB
-- Created: 15.06.2024 20:51

-- User Table information:
-- Number of tables: 15
-- __EFMigrationsHistory: -1 row(s)
-- BeeQueen: -1 row(s)
-- DescriptionHiveReview: -1 row(s)
-- Descriptions: -1 row(s)
-- Hive: -1 row(s)
-- Notifications: -1 row(s)
-- Photos: -1 row(s)
-- ProductionHives: -1 row(s)
-- Productions: -1 row(s)
-- ProductionTypes: -1 row(s)
-- Races: -1 row(s)
-- Review: -1 row(s)
-- ReviewTypes: -1 row(s)
-- StockAvailabilities: -1 row(s)
-- Users: -1 row(s)

SELECT 1;
PRAGMA foreign_keys=OFF;
BEGIN TRANSACTION;
CREATE TABLE [Users] (
  [Id] INTEGER PRIMARY KEY AUTOINCREMENT NOT NULL
, [Name] text NOT NULL
, [Email] text NOT NULL
);
CREATE TABLE [StockAvailabilities] (
  [Id] INTEGER PRIMARY KEY AUTOINCREMENT NOT NULL
, [Name] text NOT NULL
, [Quantity] real NOT NULL
, [Unit] text NOT NULL
);
CREATE TABLE [ReviewTypes] (
  [Id] INTEGER PRIMARY KEY AUTOINCREMENT NOT NULL
, [Name] text NOT NULL
, [IsVisible] bigint DEFAULT (0) NOT NULL
, [Description] text DEFAULT ('') NOT NULL
);
CREATE TABLE [Review] (
  [Id] INTEGER PRIMARY KEY AUTOINCREMENT NOT NULL
, [Description] text NOT NULL
, [PlannedDate] text NOT NULL
, [RealizedDate] text NULL
, [ReviewTypeId] bigint NOT NULL
, CONSTRAINT [FK_Review_0_0] FOREIGN KEY ([ReviewTypeId]) REFERENCES [ReviewTypes] ([Id]) ON DELETE CASCADE ON UPDATE NO ACTION
);
CREATE TABLE [Races] (
  [Id] INTEGER PRIMARY KEY AUTOINCREMENT NOT NULL
, [Description] text NOT NULL
, [Higienicznosc] bigint NOT NULL
, [IsVisible] bigint NOT NULL
, [Lagodnosc] bigint NOT NULL
, [Licznosc] bigint NOT NULL
, [Name] text NOT NULL
, [Produktywnosc] bigint NOT NULL
, [Rojliwosc] bigint NOT NULL
);
CREATE TABLE [ProductionTypes] (
  [Id] INTEGER PRIMARY KEY AUTOINCREMENT NOT NULL
, [Description] text NOT NULL
, [IsVisible] bigint NOT NULL
, [Name] text NOT NULL
, [ProductionTypeId] bigint NULL
, CONSTRAINT [FK_ProductionTypes_0_0] FOREIGN KEY ([ProductionTypeId]) REFERENCES [ProductionTypes] ([Id]) ON DELETE NO ACTION ON UPDATE NO ACTION
);
CREATE TABLE [Productions] (
  [Id] INTEGER PRIMARY KEY AUTOINCREMENT NOT NULL
, [ProductionTypeId] bigint NOT NULL
, CONSTRAINT [FK_Productions_0_0] FOREIGN KEY ([ProductionTypeId]) REFERENCES [ProductionTypes] ([Id]) ON DELETE CASCADE ON UPDATE NO ACTION
);
CREATE TABLE [Notifications] (
  [Id] INTEGER PRIMARY KEY AUTOINCREMENT NOT NULL
, [ReviewId] bigint NOT NULL
, [LocalNotificationId] bigint NOT NULL
, [IsActivated] bigint NOT NULL
, [Title] text NOT NULL
, [Description] text NOT NULL
, [NotifyTime] text NOT NULL
, CONSTRAINT [FK_Notifications_0_0] FOREIGN KEY ([ReviewId]) REFERENCES [Review] ([Id]) ON DELETE CASCADE ON UPDATE NO ACTION
);
CREATE TABLE [Descriptions] (
  [Id] INTEGER PRIMARY KEY AUTOINCREMENT NOT NULL
, [Text] text NOT NULL
);
CREATE TABLE [Photos] (
  [Id] INTEGER PRIMARY KEY AUTOINCREMENT NOT NULL
, [ImageData] image NOT NULL
, [DateTaken] text NOT NULL
, [DescriptionId] bigint NOT NULL
, CONSTRAINT [FK_Photos_0_0] FOREIGN KEY ([DescriptionId]) REFERENCES [Descriptions] ([Id]) ON DELETE CASCADE ON UPDATE NO ACTION
);
CREATE TABLE [BeeQueen] (
  [Id] INTEGER PRIMARY KEY AUTOINCREMENT NOT NULL
, [BirthDate] text NOT NULL
, [DeathDate] text NULL
, [Description] text NULL
, [RaceId] bigint NOT NULL
, CONSTRAINT [FK_BeeQueen_0_0] FOREIGN KEY ([RaceId]) REFERENCES [Races] ([Id]) ON DELETE CASCADE ON UPDATE NO ACTION
);
CREATE TABLE [Hive] (
  [Id] INTEGER PRIMARY KEY AUTOINCREMENT NOT NULL
, [AddBeeQueenDate] text NULL
, [BeeQueenId] bigint NULL
, [Description] text NOT NULL
, [IsNucleus] bigint NOT NULL
, [Number] bigint NOT NULL
, CONSTRAINT [FK_Hive_0_0] FOREIGN KEY ([BeeQueenId]) REFERENCES [BeeQueen] ([Id]) ON DELETE SET NULL ON UPDATE NO ACTION
);
CREATE TABLE [ProductionHives] (
  [Id] INTEGER PRIMARY KEY AUTOINCREMENT NOT NULL
, [ProductionId] bigint NOT NULL
, [HiveId] bigint NOT NULL
, CONSTRAINT [FK_ProductionHives_0_0] FOREIGN KEY ([ProductionId]) REFERENCES [Productions] ([Id]) ON DELETE CASCADE ON UPDATE NO ACTION
, CONSTRAINT [FK_ProductionHives_1_0] FOREIGN KEY ([HiveId]) REFERENCES [Hive] ([Id]) ON DELETE CASCADE ON UPDATE NO ACTION
);
CREATE TABLE [DescriptionHiveReview] (
  [Id] INTEGER PRIMARY KEY AUTOINCREMENT NOT NULL
, [DescriptionId] bigint NULL
, [HiveId] bigint NOT NULL
, [ReviewId] bigint NOT NULL
, CONSTRAINT [FK_DescriptionHiveReview_0_0] FOREIGN KEY ([ReviewId]) REFERENCES [Review] ([Id]) ON DELETE CASCADE ON UPDATE NO ACTION
, CONSTRAINT [FK_DescriptionHiveReview_1_0] FOREIGN KEY ([HiveId]) REFERENCES [Hive] ([Id]) ON DELETE CASCADE ON UPDATE NO ACTION
, CONSTRAINT [FK_DescriptionHiveReview_2_0] FOREIGN KEY ([DescriptionId]) REFERENCES [Descriptions] ([Id]) ON DELETE NO ACTION ON UPDATE NO ACTION
);
CREATE TABLE [__EFMigrationsHistory] (
  [MigrationId] text NOT NULL
, [ProductVersion] text NOT NULL
, CONSTRAINT [sqlite_autoindex___EFMigrationsHistory_1] PRIMARY KEY ([MigrationId])
);
CREATE INDEX [Review_IX_Review_ReviewTypeId] ON [Review] ([ReviewTypeId] ASC);
CREATE INDEX [ProductionTypes_IX_ProductionTypes_ProductionTypeId] ON [ProductionTypes] ([ProductionTypeId] ASC);
CREATE INDEX [Productions_IX_Productions_ProductionTypeId] ON [Productions] ([ProductionTypeId] ASC);
CREATE INDEX [Notifications_IX_Notifications_ReviewId] ON [Notifications] ([ReviewId] ASC);
CREATE INDEX [Photos_IX_Photos_DescriptionId] ON [Photos] ([DescriptionId] ASC);
CREATE INDEX [BeeQueen_IX_BeeQueen_RaceId] ON [BeeQueen] ([RaceId] ASC);
CREATE UNIQUE INDEX [Hive_IX_Hive_BeeQueenId] ON [Hive] ([BeeQueenId] ASC);
CREATE INDEX [ProductionHives_IX_ProductionHives_ProductionId] ON [ProductionHives] ([ProductionId] ASC);
CREATE INDEX [ProductionHives_IX_ProductionHives_HiveId] ON [ProductionHives] ([HiveId] ASC);
CREATE INDEX [DescriptionHiveReview_IX_DescriptionHiveReview_ReviewId] ON [DescriptionHiveReview] ([ReviewId] ASC);
CREATE INDEX [DescriptionHiveReview_IX_DescriptionHiveReview_HiveId] ON [DescriptionHiveReview] ([HiveId] ASC);
CREATE UNIQUE INDEX [DescriptionHiveReview_IX_DescriptionHiveReview_DescriptionId] ON [DescriptionHiveReview] ([DescriptionId] ASC);
CREATE TRIGGER [fki_Review_ReviewTypeId_ReviewTypes_Id] BEFORE Insert ON [Review] FOR EACH ROW BEGIN SELECT RAISE(ROLLBACK, 'Insert on table Review violates foreign key constraint FK_Review_0_0') WHERE (SELECT Id FROM ReviewTypes WHERE  Id = NEW.ReviewTypeId) IS NULL; END;
CREATE TRIGGER [fku_Review_ReviewTypeId_ReviewTypes_Id] BEFORE Update ON [Review] FOR EACH ROW BEGIN SELECT RAISE(ROLLBACK, 'Update on table Review violates foreign key constraint FK_Review_0_0') WHERE (SELECT Id FROM ReviewTypes WHERE  Id = NEW.ReviewTypeId) IS NULL; END;
CREATE TRIGGER [fki_ProductionTypes_ProductionTypeId_ProductionTypes_Id] BEFORE Insert ON [ProductionTypes] FOR EACH ROW BEGIN SELECT RAISE(ROLLBACK, 'Insert on table ProductionTypes violates foreign key constraint FK_ProductionTypes_0_0') WHERE NEW.ProductionTypeId IS NOT NULL AND(SELECT Id FROM ProductionTypes WHERE  Id = NEW.ProductionTypeId) IS NULL; END;
CREATE TRIGGER [fku_ProductionTypes_ProductionTypeId_ProductionTypes_Id] BEFORE Update ON [ProductionTypes] FOR EACH ROW BEGIN SELECT RAISE(ROLLBACK, 'Update on table ProductionTypes violates foreign key constraint FK_ProductionTypes_0_0') WHERE NEW.ProductionTypeId IS NOT NULL AND(SELECT Id FROM ProductionTypes WHERE  Id = NEW.ProductionTypeId) IS NULL; END;
CREATE TRIGGER [fki_Productions_ProductionTypeId_ProductionTypes_Id] BEFORE Insert ON [Productions] FOR EACH ROW BEGIN SELECT RAISE(ROLLBACK, 'Insert on table Productions violates foreign key constraint FK_Productions_0_0') WHERE (SELECT Id FROM ProductionTypes WHERE  Id = NEW.ProductionTypeId) IS NULL; END;
CREATE TRIGGER [fku_Productions_ProductionTypeId_ProductionTypes_Id] BEFORE Update ON [Productions] FOR EACH ROW BEGIN SELECT RAISE(ROLLBACK, 'Update on table Productions violates foreign key constraint FK_Productions_0_0') WHERE (SELECT Id FROM ProductionTypes WHERE  Id = NEW.ProductionTypeId) IS NULL; END;
CREATE TRIGGER [fki_Notifications_ReviewId_Review_Id] BEFORE Insert ON [Notifications] FOR EACH ROW BEGIN SELECT RAISE(ROLLBACK, 'Insert on table Notifications violates foreign key constraint FK_Notifications_0_0') WHERE (SELECT Id FROM Review WHERE  Id = NEW.ReviewId) IS NULL; END;
CREATE TRIGGER [fku_Notifications_ReviewId_Review_Id] BEFORE Update ON [Notifications] FOR EACH ROW BEGIN SELECT RAISE(ROLLBACK, 'Update on table Notifications violates foreign key constraint FK_Notifications_0_0') WHERE (SELECT Id FROM Review WHERE  Id = NEW.ReviewId) IS NULL; END;
CREATE TRIGGER [fki_Photos_DescriptionId_Descriptions_Id] BEFORE Insert ON [Photos] FOR EACH ROW BEGIN SELECT RAISE(ROLLBACK, 'Insert on table Photos violates foreign key constraint FK_Photos_0_0') WHERE (SELECT Id FROM Descriptions WHERE  Id = NEW.DescriptionId) IS NULL; END;
CREATE TRIGGER [fku_Photos_DescriptionId_Descriptions_Id] BEFORE Update ON [Photos] FOR EACH ROW BEGIN SELECT RAISE(ROLLBACK, 'Update on table Photos violates foreign key constraint FK_Photos_0_0') WHERE (SELECT Id FROM Descriptions WHERE  Id = NEW.DescriptionId) IS NULL; END;
CREATE TRIGGER [fki_BeeQueen_RaceId_Races_Id] BEFORE Insert ON [BeeQueen] FOR EACH ROW BEGIN SELECT RAISE(ROLLBACK, 'Insert on table BeeQueen violates foreign key constraint FK_BeeQueen_0_0') WHERE (SELECT Id FROM Races WHERE  Id = NEW.RaceId) IS NULL; END;
CREATE TRIGGER [fku_BeeQueen_RaceId_Races_Id] BEFORE Update ON [BeeQueen] FOR EACH ROW BEGIN SELECT RAISE(ROLLBACK, 'Update on table BeeQueen violates foreign key constraint FK_BeeQueen_0_0') WHERE (SELECT Id FROM Races WHERE  Id = NEW.RaceId) IS NULL; END;
CREATE TRIGGER [fki_Hive_BeeQueenId_BeeQueen_Id] BEFORE Insert ON [Hive] FOR EACH ROW BEGIN SELECT RAISE(ROLLBACK, 'Insert on table Hive violates foreign key constraint FK_Hive_0_0') WHERE NEW.BeeQueenId IS NOT NULL AND(SELECT Id FROM BeeQueen WHERE  Id = NEW.BeeQueenId) IS NULL; END;
CREATE TRIGGER [fku_Hive_BeeQueenId_BeeQueen_Id] BEFORE Update ON [Hive] FOR EACH ROW BEGIN SELECT RAISE(ROLLBACK, 'Update on table Hive violates foreign key constraint FK_Hive_0_0') WHERE NEW.BeeQueenId IS NOT NULL AND(SELECT Id FROM BeeQueen WHERE  Id = NEW.BeeQueenId) IS NULL; END;
CREATE TRIGGER [fki_ProductionHives_ProductionId_Productions_Id] BEFORE Insert ON [ProductionHives] FOR EACH ROW BEGIN SELECT RAISE(ROLLBACK, 'Insert on table ProductionHives violates foreign key constraint FK_ProductionHives_0_0') WHERE (SELECT Id FROM Productions WHERE  Id = NEW.ProductionId) IS NULL; END;
CREATE TRIGGER [fku_ProductionHives_ProductionId_Productions_Id] BEFORE Update ON [ProductionHives] FOR EACH ROW BEGIN SELECT RAISE(ROLLBACK, 'Update on table ProductionHives violates foreign key constraint FK_ProductionHives_0_0') WHERE (SELECT Id FROM Productions WHERE  Id = NEW.ProductionId) IS NULL; END;
CREATE TRIGGER [fki_ProductionHives_HiveId_Hive_Id] BEFORE Insert ON [ProductionHives] FOR EACH ROW BEGIN SELECT RAISE(ROLLBACK, 'Insert on table ProductionHives violates foreign key constraint FK_ProductionHives_1_0') WHERE (SELECT Id FROM Hive WHERE  Id = NEW.HiveId) IS NULL; END;
CREATE TRIGGER [fku_ProductionHives_HiveId_Hive_Id] BEFORE Update ON [ProductionHives] FOR EACH ROW BEGIN SELECT RAISE(ROLLBACK, 'Update on table ProductionHives violates foreign key constraint FK_ProductionHives_1_0') WHERE (SELECT Id FROM Hive WHERE  Id = NEW.HiveId) IS NULL; END;
CREATE TRIGGER [fki_DescriptionHiveReview_ReviewId_Review_Id] BEFORE Insert ON [DescriptionHiveReview] FOR EACH ROW BEGIN SELECT RAISE(ROLLBACK, 'Insert on table DescriptionHiveReview violates foreign key constraint FK_DescriptionHiveReview_0_0') WHERE (SELECT Id FROM Review WHERE  Id = NEW.ReviewId) IS NULL; END;
CREATE TRIGGER [fku_DescriptionHiveReview_ReviewId_Review_Id] BEFORE Update ON [DescriptionHiveReview] FOR EACH ROW BEGIN SELECT RAISE(ROLLBACK, 'Update on table DescriptionHiveReview violates foreign key constraint FK_DescriptionHiveReview_0_0') WHERE (SELECT Id FROM Review WHERE  Id = NEW.ReviewId) IS NULL; END;
CREATE TRIGGER [fki_DescriptionHiveReview_HiveId_Hive_Id] BEFORE Insert ON [DescriptionHiveReview] FOR EACH ROW BEGIN SELECT RAISE(ROLLBACK, 'Insert on table DescriptionHiveReview violates foreign key constraint FK_DescriptionHiveReview_1_0') WHERE (SELECT Id FROM Hive WHERE  Id = NEW.HiveId) IS NULL; END;
CREATE TRIGGER [fku_DescriptionHiveReview_HiveId_Hive_Id] BEFORE Update ON [DescriptionHiveReview] FOR EACH ROW BEGIN SELECT RAISE(ROLLBACK, 'Update on table DescriptionHiveReview violates foreign key constraint FK_DescriptionHiveReview_1_0') WHERE (SELECT Id FROM Hive WHERE  Id = NEW.HiveId) IS NULL; END;
CREATE TRIGGER [fki_DescriptionHiveReview_DescriptionId_Descriptions_Id] BEFORE Insert ON [DescriptionHiveReview] FOR EACH ROW BEGIN SELECT RAISE(ROLLBACK, 'Insert on table DescriptionHiveReview violates foreign key constraint FK_DescriptionHiveReview_2_0') WHERE NEW.DescriptionId IS NOT NULL AND(SELECT Id FROM Descriptions WHERE  Id = NEW.DescriptionId) IS NULL; END;
CREATE TRIGGER [fku_DescriptionHiveReview_DescriptionId_Descriptions_Id] BEFORE Update ON [DescriptionHiveReview] FOR EACH ROW BEGIN SELECT RAISE(ROLLBACK, 'Update on table DescriptionHiveReview violates foreign key constraint FK_DescriptionHiveReview_2_0') WHERE NEW.DescriptionId IS NOT NULL AND(SELECT Id FROM Descriptions WHERE  Id = NEW.DescriptionId) IS NULL; END;
COMMIT;

