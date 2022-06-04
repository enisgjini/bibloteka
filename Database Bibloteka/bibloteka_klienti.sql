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
-- Table structure for table `klienti`
--

DROP TABLE IF EXISTS `klienti`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `klienti` (
  `id_klienti` int NOT NULL AUTO_INCREMENT,
  `emri` varchar(25) NOT NULL,
  `emri_i_prindit` varchar(25) NOT NULL,
  `data_e_lindjes` varchar(25) NOT NULL,
  `gjinia` char(1) NOT NULL,
  `data_e_antarsimit` varchar(25) NOT NULL,
  `lexues_i_rregullt` char(3) NOT NULL,
  PRIMARY KEY (`id_klienti`)
) ENGINE=InnoDB AUTO_INCREMENT=11 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `klienti`
--

LOCK TABLES `klienti` WRITE;
/*!40000 ALTER TABLE `klienti` DISABLE KEYS */;
INSERT INTO `klienti` VALUES (1,'Enis','Agron','1/11/2003','M','4/23/2022','Jo'),(2,'Almir','Gazmend','3/25/2004','M','4/13/2022','Jo'),(3,'Agim','Hoxha','7/17/2003','M','6/2/2021','Jo'),(4,'Bekim','Lushi','6/29/1997','M','2/20/2022','Po'),(5,'Kela','Kujtimi','10/24/1992','M','10/29/2020','Po'),(6,'Ariana','Pollo','9/12/2000','F','4/3/2022','Po'),(7,'Marxhela','Arian','6/27/2004','F','9/19/2020','Po'),(8,'Filan','Fisteku','7/20/1999','F','4/6/2022','Po'),(9,'Gazmend','Januz','3/24/2002','M','4/4/2022','Po'),(10,'Ernest','Yzmer','6/25/2000','M','4/12/2022','Po');
/*!40000 ALTER TABLE `klienti` ENABLE KEYS */;
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
