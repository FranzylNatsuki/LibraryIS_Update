-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Mar 06, 2026 at 04:07 AM
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
-- Database: `library_`
--

-- --------------------------------------------------------

--
-- Table structure for table `book`
--

CREATE TABLE `book` (
  `BookNo` int(11) NOT NULL,
  `BookTitle` varchar(50) NOT NULL,
  `Book Author` varchar(50) NOT NULL,
  `BookCopyRight` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `book`
--

INSERT INTO `book` (`BookNo`, `BookTitle`, `Book Author`, `BookCopyRight`) VALUES
(2000, 'Metamorphosis', 'Franz Kafka', 'Franz Kafka'),
(2001, 'Interaction Design', 'Don Normal', '2015');

-- --------------------------------------------------------

--
-- Table structure for table `borrower`
--

CREATE TABLE `borrower` (
  `BorrNo` int(11) NOT NULL,
  `BorrName` varchar(50) NOT NULL,
  `BorrGradelevel` varchar(5) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `borrower`
--

INSERT INTO `borrower` (`BorrNo`, `BorrName`, `BorrGradelevel`) VALUES
(32, 'Jp', '10'),
(100, 'Franz boi', 'Gr9'),
(101, 'Javin Bicolano', 'Gr12'),
(11231, 'Cool Sauce', '8');

-- --------------------------------------------------------

--
-- Table structure for table `borrowtrans`
--

CREATE TABLE `borrowtrans` (
  `TransNo` int(11) NOT NULL,
  `BookNo` int(11) NOT NULL,
  `BorrNo` int(11) NOT NULL,
  `BorrowDate` date NOT NULL,
  `ReturnDate` date NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `borrowtrans`
--

INSERT INTO `borrowtrans` (`TransNo`, `BookNo`, `BorrNo`, `BorrowDate`, `ReturnDate`) VALUES
(12312, 2001, 101, '2026-03-06', '2026-03-06'),
(12345, 2000, 32, '2026-03-06', '2026-03-06'),
(77655, 2001, 100, '2026-03-06', '2026-03-06'),
(696969, 2000, 32, '2026-03-06', '2026-03-06');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `book`
--
ALTER TABLE `book`
  ADD PRIMARY KEY (`BookNo`);

--
-- Indexes for table `borrower`
--
ALTER TABLE `borrower`
  ADD PRIMARY KEY (`BorrNo`);

--
-- Indexes for table `borrowtrans`
--
ALTER TABLE `borrowtrans`
  ADD PRIMARY KEY (`TransNo`),
  ADD KEY `fk_bookno` (`BookNo`),
  ADD KEY `fk_borrowerno` (`BorrNo`);

--
-- Constraints for dumped tables
--

--
-- Constraints for table `borrowtrans`
--
ALTER TABLE `borrowtrans`
  ADD CONSTRAINT `fk_bookno` FOREIGN KEY (`BookNo`) REFERENCES `book` (`BookNo`),
  ADD CONSTRAINT `fk_borrowerno` FOREIGN KEY (`BorrNo`) REFERENCES `borrower` (`BorrNo`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
