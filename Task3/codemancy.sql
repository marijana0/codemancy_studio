-- phpMyAdmin SQL Dump
-- version 5.0.2
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1:3306
-- Generation Time: May 07, 2021 at 06:51 PM
-- Server version: 8.0.21
-- PHP Version: 7.4.9

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `codemancy`
--

-- --------------------------------------------------------

--
-- Table structure for table `exam`
--

DROP TABLE IF EXISTS `exam`;
CREATE TABLE IF NOT EXISTS `exam` (
  `Id` int NOT NULL AUTO_INCREMENT,
  `Name` varchar(20) NOT NULL,
  `Points` int NOT NULL,
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf16;

--
-- Dumping data for table `exam`
--

INSERT INTO `exam` (`Id`, `Name`, `Points`) VALUES
(1, 'Math', 10),
(2, 'Alghorithms', 7),
(3, 'OOP', 6);

-- --------------------------------------------------------

--
-- Table structure for table `relationshiptable`
--

DROP TABLE IF EXISTS `relationshiptable`;
CREATE TABLE IF NOT EXISTS `relationshiptable` (
  `Id` int NOT NULL AUTO_INCREMENT,
  `Student` int NOT NULL,
  `Exam` int NOT NULL,
  PRIMARY KEY (`Id`),
  UNIQUE KEY `Student` (`Student`,`Exam`) USING BTREE,
  KEY `StudentId` (`Student`),
  KEY `StudentId_2` (`Student`),
  KEY `ExamId` (`Exam`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf16;

--
-- Dumping data for table `relationshiptable`
--

INSERT INTO `relationshiptable` (`Id`, `Student`, `Exam`) VALUES
(2, 1, 3),
(1, 2, 2),
(4, 2, 3),
(3, 3, 1);

-- --------------------------------------------------------

--
-- Table structure for table `student`
--

DROP TABLE IF EXISTS `student`;
CREATE TABLE IF NOT EXISTS `student` (
  `StudentId` int NOT NULL AUTO_INCREMENT,
  `FirstName` varchar(20) CHARACTER SET utf16 COLLATE utf16_general_ci NOT NULL,
  `LastName` varchar(20) CHARACTER SET utf16 COLLATE utf16_general_ci NOT NULL,
  PRIMARY KEY (`StudentId`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf16;

--
-- Dumping data for table `student`
--

INSERT INTO `student` (`StudentId`, `FirstName`, `LastName`) VALUES
(1, 'Marijana', 'S'),
(2, 'Student', 'Two'),
(3, 'Student', 'Three');

--
-- Constraints for dumped tables
--

--
-- Constraints for table `relationshiptable`
--
ALTER TABLE `relationshiptable`
  ADD CONSTRAINT `relationshiptable_ibfk_1` FOREIGN KEY (`Student`) REFERENCES `student` (`StudentId`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `relationshiptable_ibfk_2` FOREIGN KEY (`Exam`) REFERENCES `exam` (`Id`) ON DELETE CASCADE ON UPDATE CASCADE;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
