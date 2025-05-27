-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: May 26, 2025 at 10:51 PM
-- Server version: 10.4.32-MariaDB
-- PHP Version: 8.2.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `evidencia_zamestnancov`
--

-- --------------------------------------------------------

--
-- Table structure for table `istorija_rm_radnika`
--

CREATE TABLE `istorija_rm_radnika` (
  `RadnikID` int(11) NOT NULL,
  `RadnoMestoID` int(11) NOT NULL,
  `DatumPocetka` date NOT NULL,
  `DatumZavrsetka` date NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `istorija_rm_radnika`
--

INSERT INTO `istorija_rm_radnika` (`RadnikID`, `RadnoMestoID`, `DatumPocetka`, `DatumZavrsetka`) VALUES
(1, 1, '2025-05-08', '2025-10-09');

-- --------------------------------------------------------

--
-- Table structure for table `kvalifikacija`
--

CREATE TABLE `kvalifikacija` (
  `KvalifikacijaID` int(11) NOT NULL,
  `Naziv` varchar(244) NOT NULL,
  `Koeficijent` float NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `kvalifikacija`
--

INSERT INTO `kvalifikacija` (`KvalifikacijaID`, `Naziv`, `Koeficijent`) VALUES
(1, 'Osnovna škola', 1),
(2, 'Srednja stručna sprema (SSS)', 1.2),
(3, 'Viša stručna sprema (VŠS)', 1.4),
(4, 'Visoka stručna sprema (VSS)', 1.6),
(5, 'Master', 1.8),
(6, 'Doktor nauka (PhD)', 2),
(7, 'Specijalizacija', 1.9),
(8, 'Stručni kurs', 1.1),
(9, 'Zanat', 1.15),
(10, 'Viša tehnička škola', 1.35);

-- --------------------------------------------------------

--
-- Table structure for table `radnik`
--

CREATE TABLE `radnik` (
  `RadnikID` int(11) NOT NULL,
  `Ime` varchar(244) NOT NULL,
  `Prezime` varchar(244) NOT NULL,
  `DatumRodjenja` date NOT NULL,
  `DatumZaposlenja` date NOT NULL,
  `Telefon` int(11) NOT NULL,
  `KvalifikacijaID` int(11) NOT NULL,
  `SektorID` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `radnik`
--

INSERT INTO `radnik` (`RadnikID`, `Ime`, `Prezime`, `DatumRodjenja`, `DatumZaposlenja`, `Telefon`, `KvalifikacijaID`, `SektorID`) VALUES
(1, 'John', 'Doe', '2005-05-12', '2025-05-08', 26984625, 5, 2);

-- --------------------------------------------------------

--
-- Table structure for table `radno_mesto`
--

CREATE TABLE `radno_mesto` (
  `RadnoMestoID` int(11) NOT NULL,
  `Naziv` varchar(244) NOT NULL,
  `Opis` varchar(244) NOT NULL,
  `PocetnaPlata` int(11) NOT NULL,
  `NajvisaPlata` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `radno_mesto`
--

INSERT INTO `radno_mesto` (`RadnoMestoID`, `Naziv`, `Opis`, `PocetnaPlata`, `NajvisaPlata`) VALUES
(1, 'Programer', 'Razvija softver i održava aplikacije', 80000, 150000),
(2, 'Administrator sistema', 'Održava serversku infrastrukturu', 70000, 130000),
(3, 'Menadžer projekta', 'Koordinira timovima i upravlja projektima', 90000, 160000),
(4, 'HR specijalista', 'Zadužen za zapošljavanje i kadrovsku administraciju', 60000, 100000),
(5, 'Analitičar podataka', 'Analizira podatke radi donošenja poslovnih odluka', 85000, 140000),
(6, 'Grafički dizajner', 'Kreira vizuelni sadržaj za različite platforme', 55000, 95000),
(7, 'Računovođa', 'Vodi evidenciju finansija i priprema izveštaje', 65000, 110000),
(8, 'Marketing menadžer', 'Razvija marketinške strategije i kampanje', 75000, 135000),
(9, 'Tehnička podrška', 'Pomaže korisnicima u rešavanju tehničkih problema', 50000, 85000),
(10, 'DevOps inženjer', 'Automatizuje i poboljšava razvojne i operativne procese', 95000, 170000);

-- --------------------------------------------------------

--
-- Table structure for table `rukovodi_sektorom`
--

CREATE TABLE `rukovodi_sektorom` (
  `SektorID` int(11) NOT NULL,
  `RadnikID` int(11) NOT NULL,
  `DatumPostavljanja` date NOT NULL,
  `DatumRazresenja` date NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `rukovodi_sektorom`
--

INSERT INTO `rukovodi_sektorom` (`SektorID`, `RadnikID`, `DatumPostavljanja`, `DatumRazresenja`) VALUES
(2, 1, '2025-05-29', '2025-08-06');

-- --------------------------------------------------------

--
-- Table structure for table `sektor`
--

CREATE TABLE `sektor` (
  `SektorID` int(11) NOT NULL,
  `Naziv` varchar(244) NOT NULL,
  `Opis` varchar(244) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `sektor`
--

INSERT INTO `sektor` (`SektorID`, `Naziv`, `Opis`) VALUES
(1, 'Finansije', 'Odgovoran za budžetiranje, izvještavanje i upravljanje prihodima i rashodima.'),
(2, 'IT', 'Pruža tehničku podršku i razvija softverska rješenja.'),
(3, 'Ljudski resursi', 'Zadužen za zapošljavanje, obuku i upravljanje zaposlenima.'),
(4, 'Marketing', 'Radi na promociji proizvoda i usluga te upravlja brendom.'),
(5, 'Prodaja', 'Odgovorna za direktnu prodaju proizvoda i komunikaciju s klijentima.'),
(6, 'Logistika', 'Organizuje skladištenje i distribuciju robe.'),
(7, 'Pravna služba', 'Savjetuje o pravnim pitanjima i priprema dokumentaciju.'),
(8, 'Razvoj', 'Fokusiran na istraživanje i razvoj novih proizvoda i usluga.');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `istorija_rm_radnika`
--
ALTER TABLE `istorija_rm_radnika`
  ADD KEY `RadnikID` (`RadnikID`,`RadnoMestoID`),
  ADD KEY `RadnoMestoID` (`RadnoMestoID`);

--
-- Indexes for table `kvalifikacija`
--
ALTER TABLE `kvalifikacija`
  ADD PRIMARY KEY (`KvalifikacijaID`);

--
-- Indexes for table `radnik`
--
ALTER TABLE `radnik`
  ADD PRIMARY KEY (`RadnikID`),
  ADD KEY `KvalifikacijaID` (`KvalifikacijaID`,`SektorID`),
  ADD KEY `SektorID` (`SektorID`);

--
-- Indexes for table `radno_mesto`
--
ALTER TABLE `radno_mesto`
  ADD PRIMARY KEY (`RadnoMestoID`);

--
-- Indexes for table `rukovodi_sektorom`
--
ALTER TABLE `rukovodi_sektorom`
  ADD KEY `SektorID` (`SektorID`,`RadnikID`),
  ADD KEY `RadnikID` (`RadnikID`);

--
-- Indexes for table `sektor`
--
ALTER TABLE `sektor`
  ADD PRIMARY KEY (`SektorID`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `kvalifikacija`
--
ALTER TABLE `kvalifikacija`
  MODIFY `KvalifikacijaID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=11;

--
-- AUTO_INCREMENT for table `radnik`
--
ALTER TABLE `radnik`
  MODIFY `RadnikID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- AUTO_INCREMENT for table `radno_mesto`
--
ALTER TABLE `radno_mesto`
  MODIFY `RadnoMestoID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=11;

--
-- AUTO_INCREMENT for table `sektor`
--
ALTER TABLE `sektor`
  MODIFY `SektorID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=9;

--
-- Constraints for dumped tables
--

--
-- Constraints for table `istorija_rm_radnika`
--
ALTER TABLE `istorija_rm_radnika`
  ADD CONSTRAINT `istorija_rm_radnika_ibfk_1` FOREIGN KEY (`RadnikID`) REFERENCES `radnik` (`RadnikID`),
  ADD CONSTRAINT `istorija_rm_radnika_ibfk_2` FOREIGN KEY (`RadnoMestoID`) REFERENCES `radno_mesto` (`RadnoMestoID`);

--
-- Constraints for table `radnik`
--
ALTER TABLE `radnik`
  ADD CONSTRAINT `radnik_ibfk_1` FOREIGN KEY (`KvalifikacijaID`) REFERENCES `kvalifikacija` (`KvalifikacijaID`),
  ADD CONSTRAINT `radnik_ibfk_2` FOREIGN KEY (`SektorID`) REFERENCES `sektor` (`SektorID`);

--
-- Constraints for table `rukovodi_sektorom`
--
ALTER TABLE `rukovodi_sektorom`
  ADD CONSTRAINT `rukovodi_sektorom_ibfk_1` FOREIGN KEY (`RadnikID`) REFERENCES `radnik` (`RadnikID`),
  ADD CONSTRAINT `rukovodi_sektorom_ibfk_2` FOREIGN KEY (`SektorID`) REFERENCES `sektor` (`SektorID`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
