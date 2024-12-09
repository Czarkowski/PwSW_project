CREATE TABLE `StockAvailabilities` (
  `Id` integer PRIMARY KEY,
  `Name` text,
  `Quantity` real,
  `Unit` text
);

CREATE TABLE `ReviewTypes` (
  `Id` integer PRIMARY KEY,
  `Name` text,
  `IsVisible` boolean DEFAULT false,
  `Description` text DEFAULT ''
);

CREATE TABLE `Review` (
  `Id` integer PRIMARY KEY,
  `ReviewTypeId` integer,
  `Description` text,
  `PlannedDate` timestamp,
  `RealizedDate` timestamp COMMENT 'Nullable'
);

CREATE TABLE `Races` (
  `Id` integer PRIMARY KEY,
  `Name` text,
  `Description` text,
  `IsVisible` boolean
);

CREATE TABLE `ProductionTypes` (
  `Id` integer PRIMARY KEY,
  `Name` text,
  `Description` text,
  `IsVisible` boolean
);

CREATE TABLE `Productions` (
  `Id` integer PRIMARY KEY,
  `ProductionTypeId` integer
);

CREATE TABLE `Notifications` (
  `Id` integer PRIMARY KEY,
  `ReviewId` integer,
  `LocalNotificationId` integer,
  `IsActivated` boolean,
  `Title` text,
  `Description` text,
  `NotifyTime` timestamp
);

CREATE TABLE `Descriptions` (
  `Id` integer PRIMARY KEY,
  `Text` text
);

CREATE TABLE `Photos` (
  `Id` integer PRIMARY KEY,
  `ImageData` blob,
  `DateTaken` timestamp,
  `DescriptionId` integer
);

CREATE TABLE `BeeQueen` (
  `Id` integer PRIMARY KEY,
  `BirthDate` timestamp,
  `DeathDate` timestamp COMMENT 'Nullable',
  `Description` text COMMENT 'Nullable',
  `RaceId` integer
);

CREATE TABLE `Hive` (
  `Id` integer PRIMARY KEY,
  `AddBeeQueenDate` timestamp COMMENT 'Nullable',
  `BeeQueenId` integer COMMENT 'Nullable',
  `Description` text,
  `IsNucleus` boolean,
  `Number` integer
);

CREATE TABLE `ProductionHives` (
  `Id` integer PRIMARY KEY,
  `ProductionId` integer,
  `HiveId` integer
);

CREATE TABLE `DescriptionHiveReview` (
  `Id` integer PRIMARY KEY,
  `ReviewId` integer,
  `HiveId` integer,
  `DescriptionId` integer COMMENT 'Nullable'
);

ALTER TABLE `Review` ADD FOREIGN KEY (`ReviewTypeId`) REFERENCES `ReviewTypes` (`Id`);

ALTER TABLE `Productions` ADD FOREIGN KEY (`ProductionTypeId`) REFERENCES `ProductionTypes` (`Id`);

ALTER TABLE `Notifications` ADD FOREIGN KEY (`ReviewId`) REFERENCES `Review` (`Id`);

ALTER TABLE `Photos` ADD FOREIGN KEY (`DescriptionId`) REFERENCES `Descriptions` (`Id`);

ALTER TABLE `BeeQueen` ADD FOREIGN KEY (`RaceId`) REFERENCES `Races` (`Id`);

ALTER TABLE `BeeQueen` ADD FOREIGN KEY (`Id`) REFERENCES `Hive` (`BeeQueenId`);

ALTER TABLE `ProductionHives` ADD FOREIGN KEY (`ProductionId`) REFERENCES `Productions` (`Id`);

ALTER TABLE `ProductionHives` ADD FOREIGN KEY (`HiveId`) REFERENCES `Hive` (`Id`);

ALTER TABLE `DescriptionHiveReview` ADD FOREIGN KEY (`ReviewId`) REFERENCES `Review` (`Id`);

ALTER TABLE `DescriptionHiveReview` ADD FOREIGN KEY (`HiveId`) REFERENCES `Hive` (`Id`);

ALTER TABLE `Descriptions` ADD FOREIGN KEY (`Id`) REFERENCES `DescriptionHiveReview` (`DescriptionId`);
