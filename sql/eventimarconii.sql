-- phpMyAdmin SQL Dump
-- Versione corretta basata sullo Schema Logico (EsTh3.2.5 - Ghouzlani Amir)
-- Data: Apr 16, 2026

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `eventimarconi`
--

-- --------------------------------------------------------

--
-- Struttura della tabella `indirizzi`
-- CORRETTA: rimossa FK sigla_classe (relazione inversa gestita in classi)
--           dimensione nome corretta a VARCHAR(30)
--

CREATE TABLE `indirizzi` (
  `ID` int NOT NULL AUTO_INCREMENT,
  `nome` varchar(30) NOT NULL,
  PRIMARY KEY (`ID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Struttura della tabella `classi`
-- CORRETTA: PK è sigla CHAR(3) (non IDclasse INT)
--           aggiunta FK studenteID -> utenti
--           sezione ridotta a CHAR(2)
--           anno rimane TINYINT(1)
--           indirizzoID rimane FK verso indirizzi
--

CREATE TABLE `classi` (
  `sigla` char(3) NOT NULL,
  `aula` varchar(4) NOT NULL,
  `anno` tinyint(1) NOT NULL,
  `sezione` char(2) NOT NULL,
  `indirizzoID` int NOT NULL,
  PRIMARY KEY (`sigla`),
  KEY `indirizzoID` (`indirizzoID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Struttura della tabella `utenti`
-- CORRETTA: password VARCHAR(30) (non INT)
--           matricola CHAR(8) UNIQUE (non CHAR(7))
--           rimosso adminStudente, aggiunto ruolo CHAR(1)
--           classeID è FK verso classi.sigla (CHAR(3))
--           username VARCHAR(30)
--           nome e cognome VARCHAR(30)
--

CREATE TABLE `utenti` (
  `ID` int NOT NULL AUTO_INCREMENT,
  `nome` varchar(30) NOT NULL,
  `cognome` varchar(30) NOT NULL,
  `username` varchar(30) NOT NULL,
  `password` varchar(30) NOT NULL,
  `matricola` char(8) DEFAULT NULL,
  `rappresentanteClasse` tinyint(1) DEFAULT NULL,
  `rappresentanteIstituto` tinyint(1) DEFAULT NULL,
  `ruolo` char(1) NOT NULL,
  `classeID` char(3) NOT NULL,
  PRIMARY KEY (`ID`),
  UNIQUE KEY `username` (`username`),
  UNIQUE KEY `matricola` (`matricola`),
  KEY `classeID` (`classeID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Struttura della tabella `eventi`
-- CORRETTA: descrizione VARCHAR(250) (non 100)
--           aggiunto INDEX su nome
--

CREATE TABLE `eventi` (
  `ID` int NOT NULL AUTO_INCREMENT,
  `nome` varchar(50) NOT NULL,
  `descrizione` varchar(250) DEFAULT NULL,
  `dal` date NOT NULL,
  `al` date NOT NULL,
  `adminID` int NOT NULL,
  PRIMARY KEY (`ID`),
  KEY `nome` (`nome`),
  KEY `adminID` (`adminID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Struttura della tabella `attivita`
-- CORRETTA: titolo VARCHAR(50), testo VARCHAR(250)
--           ordine TINYINT (non INT UNSIGNED)
--

CREATE TABLE `attivita` (
  `ID` int NOT NULL AUTO_INCREMENT,
  `titolo` varchar(50) NOT NULL,
  `testo` varchar(250) NOT NULL,
  `ordine` tinyint NOT NULL,
  `dalle` time NOT NULL,
  `alle` time NOT NULL,
  `eventoID` int NOT NULL,
  PRIMARY KEY (`ID`),
  KEY `eventoID` (`eventoID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Struttura della tabella `aderire`
-- CORRETTA: PK surrogata IDaderire mantenuta (necessaria perché classeID e studenteID
--           sono nullable — l'iscrizione è individuale (studenteID) OPPURE collettiva
--           (classeID), mai entrambi obbligatori, quindi una PK composta NON NULL
--           non è applicabile).
--           Unicità logica garantita da UNIQUE KEY su (attivitaID, classeID, studenteID).
--           classeID FK verso classi.sigla (CHAR(3))
--           studenteID FK verso utenti.ID
--

CREATE TABLE `aderire` (
  `IDaderire` int NOT NULL AUTO_INCREMENT,
  `iscritto` tinyint(1) NOT NULL DEFAULT '0',
  `autorizzato` tinyint(1) NOT NULL DEFAULT '0',
  `pagato` tinyint(1) DEFAULT NULL,
  `partecipato` tinyint(1) NOT NULL DEFAULT '0',
  `attivitaID` int NOT NULL,
  `classeID` char(3) DEFAULT NULL,
  `studenteID` int DEFAULT NULL,
  PRIMARY KEY (`IDaderire`),
  UNIQUE KEY `unicita_adesione` (`attivitaID`, `classeID`, `studenteID`),
  KEY `classeID` (`classeID`),
  KEY `studenteID` (`studenteID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------
--
-- Vincoli (Foreign Keys)
--

-- classi -> indirizzi
ALTER TABLE `classi`
  ADD CONSTRAINT `classi_indirizzi` FOREIGN KEY (`indirizzoID`) REFERENCES `indirizzi` (`ID`) ON DELETE RESTRICT ON UPDATE CASCADE;

-- utenti -> classi
ALTER TABLE `utenti`
  ADD CONSTRAINT `utenti_classi` FOREIGN KEY (`classeID`) REFERENCES `classi` (`sigla`) ON DELETE RESTRICT ON UPDATE CASCADE;

-- eventi -> utenti (admin)
ALTER TABLE `eventi`
  ADD CONSTRAINT `eventi_admin` FOREIGN KEY (`adminID`) REFERENCES `utenti` (`ID`) ON DELETE RESTRICT ON UPDATE CASCADE;

-- attivita -> eventi
ALTER TABLE `attivita`
  ADD CONSTRAINT `attivita_eventi` FOREIGN KEY (`eventoID`) REFERENCES `eventi` (`ID`) ON DELETE RESTRICT ON UPDATE CASCADE;

-- aderire -> attivita
ALTER TABLE `aderire`
  ADD CONSTRAINT `aderire_attivita` FOREIGN KEY (`attivitaID`) REFERENCES `attivita` (`ID`) ON DELETE RESTRICT ON UPDATE CASCADE;

-- aderire -> classi
ALTER TABLE `aderire`
  ADD CONSTRAINT `aderire_classi` FOREIGN KEY (`classeID`) REFERENCES `classi` (`sigla`) ON DELETE RESTRICT ON UPDATE CASCADE;

-- aderire -> utenti (studente)
ALTER TABLE `aderire`
  ADD CONSTRAINT `aderire_studente` FOREIGN KEY (`studenteID`) REFERENCES `utenti` (`ID`) ON DELETE RESTRICT ON UPDATE CASCADE;

COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
