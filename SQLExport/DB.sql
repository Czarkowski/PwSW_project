CREATE DATABASE  IF NOT EXISTS `PasiekaSchema` /*!40100 DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci */ /*!80016 DEFAULT ENCRYPTION='N' */;
USE `PasiekaSchema`;
-- MySQL dump 10.13  Distrib 8.0.33, for Win64 (x86_64)
--
-- Host: 127.0.0.1    Database: PasiekaSchema
-- ------------------------------------------------------
-- Server version	8.0.33

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!50503 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `OpisUlPrzeglad`
--

DROP TABLE IF EXISTS `OpisUlPrzeglad`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `OpisUlPrzeglad` (
  `ID` int NOT NULL AUTO_INCREMENT,
  `DataPrzegladu` datetime DEFAULT NULL,
  `Opis` varchar(1024) DEFAULT NULL,
  `UlId` int NOT NULL,
  `PrzegladId` int NOT NULL,
  PRIMARY KEY (`ID`),
  KEY `UlId_idx` (`UlId`),
  KEY `PrzegladId_idx` (`PrzegladId`),
  CONSTRAINT `PrzegladId` FOREIGN KEY (`PrzegladId`) REFERENCES `Przeglad` (`Id`),
  CONSTRAINT `UlId` FOREIGN KEY (`UlId`) REFERENCES `Ul` (`Id`)
) ENGINE=InnoDB AUTO_INCREMENT=113 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `OpisUlPrzeglad`
--

LOCK TABLES `OpisUlPrzeglad` WRITE;
/*!40000 ALTER TABLE `OpisUlPrzeglad` DISABLE KEYS */;
INSERT INTO `OpisUlPrzeglad` VALUES (64,'2023-10-31 15:21:40','Wymuszono Zakonczenie',20,21),(111,'2023-11-01 17:16:47','Wymuszono Zakonczenie',20,22),(112,'2023-11-01 17:16:47','Wymuszono Zakonczenie',23,22);
/*!40000 ALTER TABLE `OpisUlPrzeglad` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `Pozycja`
--

DROP TABLE IF EXISTS `Pozycja`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `Pozycja` (
  `Id` int NOT NULL AUTO_INCREMENT,
  `x` int NOT NULL,
  `y` int NOT NULL,
  `ColorEnum` int NOT NULL,
  `UlId` int NOT NULL,
  PRIMARY KEY (`Id`),
  UNIQUE KEY `UlId_UNIQUE` (`UlId`),
  CONSTRAINT `UlIdForPozycja` FOREIGN KEY (`UlId`) REFERENCES `Ul` (`Id`) ON DELETE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=42 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `Pozycja`
--

LOCK TABLES `Pozycja` WRITE;
/*!40000 ALTER TABLE `Pozycja` DISABLE KEYS */;
INSERT INTO `Pozycja` VALUES (35,617,208,166,20);
/*!40000 ALTER TABLE `Pozycja` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `Przeglad`
--

DROP TABLE IF EXISTS `Przeglad`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `Przeglad` (
  `Id` int NOT NULL AUTO_INCREMENT,
  `DataUtworzenia` datetime NOT NULL DEFAULT CURRENT_TIMESTAMP,
  `DataZaPlanowana` datetime NOT NULL,
  `DataWykonania` datetime DEFAULT NULL,
  `Cel` varchar(1024) NOT NULL,
  `Opis` varchar(1024) NOT NULL,
  `CelEnum` int NOT NULL,
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB AUTO_INCREMENT=23 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `Przeglad`
--

LOCK TABLES `Przeglad` WRITE;
/*!40000 ALTER TABLE `Przeglad` DISABLE KEYS */;
INSERT INTO `Przeglad` VALUES (20,'2023-10-31 15:20:04','2023-10-31 15:19:59','2023-10-31 15:21:28','','',2),(21,'2023-10-31 15:21:37','2023-10-31 15:21:34','2023-10-31 15:21:40','','',0),(22,'2023-10-31 18:36:47','2023-10-31 22:02:40','2023-11-01 17:16:47','sdfgsdfg','dfsgsdf',0);
/*!40000 ALTER TABLE `Przeglad` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `Rasa`
--

DROP TABLE IF EXISTS `Rasa`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `Rasa` (
  `Id` int NOT NULL AUTO_INCREMENT,
  `Nazwa` varchar(45) NOT NULL,
  `Opis` varchar(1024) NOT NULL,
  `Licznosc` tinyint unsigned NOT NULL,
  `Produktywnosc` tinyint unsigned NOT NULL,
  `Rojliwosc` tinyint unsigned NOT NULL,
  `Higienicznosc` tinyint unsigned NOT NULL,
  `Lagodnosc` tinyint unsigned NOT NULL,
  PRIMARY KEY (`Id`),
  UNIQUE KEY `Nazwa_UNIQUE` (`Nazwa`)
) ENGINE=InnoDB AUTO_INCREMENT=10 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `Rasa`
--

LOCK TABLES `Rasa` WRITE;
/*!40000 ALTER TABLE `Rasa` DISABLE KEYS */;
INSERT INTO `Rasa` VALUES (1,'Test','Test',1,3,5,7,9),(2,'Kraińska','Apis mellifera carnica Pollm',7,8,7,8,7),(3,'Środkowoeuropejska','Apis mellifera mellifera',5,5,6,5,6),(4,'Buckfast','Apis mellifera  buckfast-hybrid',10,9,8,8,8),(5,'Włoskie','Apis mellifera ligustica',8,8,4,8,9),(6,'Kaukaskie','Apis mellifera caucasica',4,5,5,7,8),(7,'---','Brak Matki',0,0,0,0,0);
/*!40000 ALTER TABLE `Rasa` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `Ul`
--

DROP TABLE IF EXISTS `Ul`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `Ul` (
  `Id` int NOT NULL AUTO_INCREMENT,
  `Numer` int NOT NULL,
  `DataDodania` datetime DEFAULT '0001-01-01 00:00:00',
  `DataOstatniegoPrzegladu` datetime DEFAULT '0001-01-01 00:00:00',
  `WiekMatki` int DEFAULT '0',
  `WiekMatkiData` datetime DEFAULT '0001-01-01 00:00:00',
  `RasaNazwa` varchar(45) DEFAULT '',
  `OpisStanu` varchar(1024) DEFAULT '',
  `CzyOdklad` tinyint DEFAULT '0',
  `CzyNowaMatka` tinyint DEFAULT '0',
  `CzyWyrojone` tinyint DEFAULT '0',
  `RasaId` int DEFAULT '1',
  `RamkiGniazdo` tinyint DEFAULT '10',
  `RamkiNadStawka` tinyint DEFAULT '0',
  `OpisZaPlanowane` varchar(1024) DEFAULT '',
  `OpisRamki` varchar(1024) DEFAULT '',
  PRIMARY KEY (`Id`),
  UNIQUE KEY `Numer_UNIQUE` (`Numer`),
  KEY `RasaId_idx` (`RasaId`),
  CONSTRAINT `RasaId` FOREIGN KEY (`RasaId`) REFERENCES `Rasa` (`Id`) ON DELETE SET NULL ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=34 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `Ul`
--

LOCK TABLES `Ul` WRITE;
/*!40000 ALTER TABLE `Ul` DISABLE KEYS */;
INSERT INTO `Ul` VALUES (6,11,'0001-01-01 00:00:00','0001-01-01 00:00:00',1,'2023-11-04 12:21:48','','dfhgfdh',0,1,1,2,0,0,'',''),(20,8,'2023-10-26 11:01:19','0001-01-01 00:00:00',0,'2023-11-04 15:06:01','','',0,0,0,7,0,0,'',''),(23,9,'2023-10-26 11:18:25','0001-01-01 00:00:00',1,'2023-11-04 20:04:08','','',0,1,0,4,0,0,'','');
/*!40000 ALTER TABLE `Ul` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2023-11-10 19:48:21
