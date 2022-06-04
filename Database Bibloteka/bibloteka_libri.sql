-- MySQL dump 10.13  Distrib 8.0.28, for Win64 (x86_64)
--
-- Host: 127.0.0.1    Database: bibloteka
-- ------------------------------------------------------
-- Server version	8.0.28

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
-- Table structure for table `libri`
--

DROP TABLE IF EXISTS `libri`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `libri` (
  `ID` int NOT NULL AUTO_INCREMENT,
  `Titulli` varchar(45) NOT NULL,
  `Autori` varchar(45) NOT NULL,
  `Zhanri` varchar(45) NOT NULL,
  `Shtepia_botuese` varchar(45) NOT NULL,
  `Viti_i_botimit` varchar(45) NOT NULL,
  `Vrejtje` varchar(250) NOT NULL,
  PRIMARY KEY (`ID`)
) ENGINE=InnoDB AUTO_INCREMENT=9 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci COMMENT='		';
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `libri`
--

LOCK TABLES `libri` WRITE;
/*!40000 ALTER TABLE `libri` DISABLE KEYS */;
INSERT INTO `libri` VALUES (2,'Sociologjia e televizionit','Brigitte Le Grignou, Erik Neveu','Gazetari, sociologji','Zenit Editions','2018',''),(3,'Lirikë me shi','Azem Shkreli','Poezi','Onufri ','2020',''),(4,'Troje','Linda Agolli','Poezi','Botime Dritëro','2019',''),(5,'Principata e Arbërisë','Ali Podrimja','','Buzuku','1989',''),(6,'Porosia e madhe','Rexhep Qosja','','Toena','1981',''),(7,'Poema e mjerimit','Migjeni','','Rilindja','1982','');
/*!40000 ALTER TABLE `libri` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2022-04-28 23:20:50
