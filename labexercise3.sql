-- phpMyAdmin SQL Dump
-- version 5.2.0
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: May 16, 2023 at 10:36 PM
-- Server version: 10.4.27-MariaDB
-- PHP Version: 8.2.0

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `labexercise3`
--

-- --------------------------------------------------------

--
-- Table structure for table `staff`
--

CREATE TABLE `staff` (
  `idnumber` varchar(100) DEFAULT NULL,
  `name` varchar(225) DEFAULT NULL,
  `surname` varchar(225) DEFAULT NULL,
  `email` varchar(225) DEFAULT NULL,
  `age` varchar(225) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `staff`
--

INSERT INTO `staff` (`idnumber`, `name`, `surname`, `email`, `age`) VALUES
('99236514897', 'Fumane', 'Madaba', 'FumaneMadaba@gmail.com', '24'),
('020201', 'Fumane', 'Madaba', 'FumaneMadaba@gmail.com', '21'),
('99236514897', 'Fumane', 'Madaba', 'FumaneMadaba@gmail.com', '24'),
('99236514897', 'thembi', 'nkosi', 'thembinkosi@gmail.com', '24'),
('921552', 'house', 'give', 'housegive@gmail.com', '31'),
('99236514897', 'dfg', 'xcvgh', 'dfgxcvgh@gmail.com', '24'),
('0202020202', 'first', 'try', 'firsttry@gmail.com', '21'),
('020202020', 'katlehom', 'madaba', 'katlehommadaba@gmail.com', '21');
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
