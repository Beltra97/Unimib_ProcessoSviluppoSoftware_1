CREATE DATABASE  IF NOT EXISTS `azienda` /*!40100 DEFAULT CHARACTER SET latin1 */;
USE `azienda`;
-- MySQL dump 10.16  Distrib 10.1.38-MariaDB, for Win64 (AMD64)
--
-- Host: 127.0.0.1    Database: azienda
-- ------------------------------------------------------
-- Server version	10.1.38-MariaDB

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `convenzioni`
--

DROP TABLE IF EXISTS `convenzioni`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `convenzioni` (
  `ID` int(11) NOT NULL AUTO_INCREMENT,
  `Titolo` varchar(50) NOT NULL,
  `Descrizione` varchar(255) NOT NULL,
  PRIMARY KEY (`ID`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `convenzioni`
--

LOCK TABLES `convenzioni` WRITE;
/*!40000 ALTER TABLE `convenzioni` DISABLE KEYS */;
INSERT INTO `convenzioni` VALUES (1,'Sconto Auto','Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.'),(2,'Sconto Medico','Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris \nnisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in \nreprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur.'),(3,'Sconto Cibo','Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.');
/*!40000 ALTER TABLE `convenzioni` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `dipendente`
--

DROP TABLE IF EXISTS `dipendente`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `dipendente` (
  `ID` int(11) NOT NULL AUTO_INCREMENT,
  `Cognome` varchar(50) NOT NULL,
  `Nome` varchar(50) NOT NULL,
  `Username` varchar(50) NOT NULL,
  `Psw` varchar(50) NOT NULL,
  `IDRuolo` int(11) NOT NULL,
  PRIMARY KEY (`ID`),
  KEY `IDRuolo` (`IDRuolo`),
  CONSTRAINT `dipendente_ibfk_1` FOREIGN KEY (`IDRuolo`) REFERENCES `ruolo` (`ID`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `dipendente`
--

LOCK TABLES `dipendente` WRITE;
/*!40000 ALTER TABLE `dipendente` DISABLE KEYS */;
INSERT INTO `dipendente` VALUES (1,'Bianchi','Marco','marco.bianchi','1234',1),(2,'Gialli','Paolo','paolo.gialli','1234',2),(3,'Rossi','Piero','piero.rossi','1234',3);
/*!40000 ALTER TABLE `dipendente` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `ruolo`
--

DROP TABLE IF EXISTS `ruolo`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `ruolo` (
  `ID` int(11) NOT NULL AUTO_INCREMENT,
  `Nome` varchar(50) NOT NULL,
  PRIMARY KEY (`ID`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `ruolo`
--

LOCK TABLES `ruolo` WRITE;
/*!40000 ALTER TABLE `ruolo` DISABLE KEYS */;
INSERT INTO `ruolo` VALUES (1,'Project Manager'),(2,'Senior Developer'),(3,'Junior Developer');
/*!40000 ALTER TABLE `ruolo` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2019-10-26 17:32:02
