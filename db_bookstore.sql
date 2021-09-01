-- phpMyAdmin SQL Dump
-- version 5.0.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Sep 01, 2021 at 02:59 AM
-- Server version: 10.4.11-MariaDB
-- PHP Version: 7.4.3

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `db_bookstore`
--

-- --------------------------------------------------------

--
-- Table structure for table `bs_books`
--

CREATE TABLE `bs_books` (
  `book_pid` int(20) NOT NULL,
  `title` varchar(40) NOT NULL,
  `author` varchar(40) NOT NULL,
  `isbn` varchar(20) NOT NULL,
  `price` varchar(12) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `bs_books`
--

INSERT INTO `bs_books` (`book_pid`, `title`, `author`, `isbn`, `price`) VALUES
(1, 'How To Swim', 'Shams AL Ajrawi', '12345999', '10.89'),
(2, 'World War Z', 'Max Brooks', '12344321', '12.98'),
(3, 'The Empire did nothing wrong', 'Brandon Shawl', '12346421', '21.99'),
(4, 'Buy This Book Please', 'Josh Obrient', '12332241', '18.99'),
(5, 'Great Book', 'Johnson Hern', '12342231', '9.99'),
(6, 'Professor Cline', 'Peter Gabriel', '42325432', '12.29'),
(7, 'Books on Sale', 'Lindberg Olivas', '42356534', '7.99'),
(8, 'Sherry Potter and the Shorcerer\'s Shtone', 'Shtephenson Shteve', '32141342', '19.99'),
(9, 'Java', 'Joseph ', '1234567899', '19.99'),
(10, '', '', '', ''),
(11, 'C#_LINQ_SQL', 'Shams', '12345', '25'),
(12, 'A Clash of Kings', 'G.R.R.M', '14823457', '19.99'),
(13, 'A Game of Thrones', 'G.R.R.M', '284637', '23.99'),
(14, 'A Storm of Swords', 'GRRM', '3837472', '34.34'),
(15, 'A Feast of Crows', 'G.R.R.M', '12345322', '45.99'),
(16, 'A Dance of Dragons', 'GRRM', '123456', '20.59');

-- --------------------------------------------------------

--
-- Table structure for table `bs_customer`
--

CREATE TABLE `bs_customer` (
  `cust_pid` int(20) NOT NULL,
  `first_name` varchar(40) NOT NULL,
  `last_name` varchar(40) NOT NULL,
  `address` varchar(80) NOT NULL,
  `city` varchar(40) NOT NULL,
  `state` varchar(10) NOT NULL,
  `zip` varchar(10) NOT NULL,
  `phone` varchar(20) NOT NULL,
  `email` varchar(40) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `bs_customer`
--

INSERT INTO `bs_customer` (`cust_pid`, `first_name`, `last_name`, `address`, `city`, `state`, `zip`, `phone`, `email`) VALUES
(1, 'Kevin', 'Alex', '1234 Candy Cane Road', 'Carlsbad', 'CA', '92008', '7605556393', 'kevin@gmail.com'),
(2, 'Shams', 'Willis', '1234 Candy Cane Rd.', 'Carlsbad', 'CA', '92008', '7605556393', 'kevin@gmail.com'),
(3, 'Keanu', 'Reeves', '3453 Hollywood Blvd.', 'Hollywood', 'CA', '90210', '7605554123', 'TheOne@gmail.com'),
(4, 'John', 'Harrison', '1234 Candy Cane Rd.', 'Carlsbad', 'CA', '92008', '7605556393', 'kevin@gmail.com'),
(5, 'George', 'Lennon', '1234 Candy Cane Rd.', 'Carlsbad', 'CA', '92008', '7605556393', 'kevin@gmail.com'),
(6, 'Ringo', 'Townsend', '1234 Candy Cane Rd.', 'Carlsbad', 'CA', '92008', '7605556393', 'kevin@gmail.com'),
(7, 'Sarah', 'Customer', '1234 Address Here', 'Oceanside', 'CA', '92054', '1234567899', 'email@gmail.com'),
(8, 'Abe', 'Lincoln', '123 Street Name', 'City Name', 'DC', '12345', '1234567890', 'abe@usa.com'),
(9, 'First', 'Last', 'Address', 'City', 'ST', '12345', '1234567890', 'email@email.com'),
(10, 'Hello', 'Hello', '123 Hello St', 'San Diego', 'CA', '12345', '1234567890', 'a@b.com'),
(11, 'Example', 'Customer', '123 Street', 'San Diego', 'CA', '12345', '0987654321', 'b@a.com');

-- --------------------------------------------------------

--
-- Table structure for table `bs_orderdetails`
--

CREATE TABLE `bs_orderdetails` (
  `orderdetails_pid` int(20) NOT NULL,
  `order_fid` int(20) NOT NULL,
  `book_fid` int(20) NOT NULL,
  `quantity` int(10) NOT NULL,
  `lines_total` int(10) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `bs_orderdetails`
--

INSERT INTO `bs_orderdetails` (`orderdetails_pid`, `order_fid`, `book_fid`, `quantity`, `lines_total`) VALUES
(1, 3, 0, 0, 12345),
(2, 4, 0, 0, 12345),
(3, 5, 0, 0, 12345),
(4, 6, 12, 0, 12345),
(5, 7, 6, 2, 12345),
(6, 8, 6, 0, 12345),
(7, 9, 1, 1, 12345),
(8, 10, 10, 3, 12345),
(9, 11, 0, 2, 12345);

-- --------------------------------------------------------

--
-- Table structure for table `bs_orders`
--

CREATE TABLE `bs_orders` (
  `order_pid` int(20) NOT NULL,
  `cust_fid` int(20) NOT NULL,
  `sub_total` decimal(20,2) NOT NULL,
  `tax` decimal(20,2) NOT NULL,
  `total` decimal(20,2) NOT NULL,
  `order_date` date NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `bs_orders`
--

INSERT INTO `bs_orders` (`order_pid`, `cust_fid`, `sub_total`, `tax`, `total`, `order_date`) VALUES
(1, 0, '19.98', '1.00', '20.98', '0000-00-00'),
(2, 0, '37.98', '1.90', '39.88', '0000-00-00'),
(4, 0, '0.00', '0.00', '0.00', '2020-04-26'),
(5, 3, '25.96', '2.60', '28.56', '2020-04-26'),
(6, 2, '68.68', '6.87', '75.55', '2020-04-26'),
(7, 2, '39.98', '4.00', '43.98', '2020-04-26'),
(8, 2, '39.98', '4.00', '43.98', '2020-04-26'),
(9, 2, '21.99', '2.20', '24.19', '2020-04-26'),
(10, 4, '59.97', '6.00', '65.97', '2020-04-26'),
(11, 2, '25.96', '2.60', '28.56', '2020-04-26');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `bs_books`
--
ALTER TABLE `bs_books`
  ADD PRIMARY KEY (`book_pid`);

--
-- Indexes for table `bs_customer`
--
ALTER TABLE `bs_customer`
  ADD PRIMARY KEY (`cust_pid`);

--
-- Indexes for table `bs_orderdetails`
--
ALTER TABLE `bs_orderdetails`
  ADD PRIMARY KEY (`orderdetails_pid`);

--
-- Indexes for table `bs_orders`
--
ALTER TABLE `bs_orders`
  ADD PRIMARY KEY (`order_pid`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `bs_books`
--
ALTER TABLE `bs_books`
  MODIFY `book_pid` int(20) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=17;

--
-- AUTO_INCREMENT for table `bs_customer`
--
ALTER TABLE `bs_customer`
  MODIFY `cust_pid` int(20) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=14;

--
-- AUTO_INCREMENT for table `bs_orderdetails`
--
ALTER TABLE `bs_orderdetails`
  MODIFY `orderdetails_pid` int(20) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=10;

--
-- AUTO_INCREMENT for table `bs_orders`
--
ALTER TABLE `bs_orders`
  MODIFY `order_pid` int(20) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=12;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
