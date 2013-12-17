-- phpMyAdmin SQL Dump
-- version 4.0.4.1
-- http://www.phpmyadmin.net
--
-- Host: 127.0.0.1
-- Generation Time: Dec 17, 2013 at 09:46 PM
-- Server version: 5.5.32
-- PHP Version: 5.4.16

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;

--
-- Database: `capisano`
--
CREATE DATABASE IF NOT EXISTS `capisano` DEFAULT CHARACTER SET latin1 COLLATE latin1_swedish_ci;
USE `capisano`;

-- --------------------------------------------------------

--
-- Table structure for table `daftarcustomer`
--

CREATE TABLE IF NOT EXISTS `daftarcustomer` (
  `phone` varchar(25) NOT NULL DEFAULT '',
  `email` varchar(50) NOT NULL DEFAULT 'blank',
  `password` varchar(50) NOT NULL DEFAULT 'blank',
  `name` varchar(50) NOT NULL DEFAULT 'blank',
  `address` varchar(200) NOT NULL DEFAULT 'blank',
  `city` varchar(25) NOT NULL DEFAULT 'blank',
  `state` varchar(25) NOT NULL DEFAULT 'blank',
  `country` varchar(25) NOT NULL DEFAULT 'blank',
  `postal` varchar(25) NOT NULL DEFAULT 'blank',
  `auto` int(11) NOT NULL AUTO_INCREMENT,
  `timestamp` timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
  `operator` varchar(50) NOT NULL DEFAULT 'blank',
  `modul` varchar(10) NOT NULL DEFAULT 'blank',
  `status` char(1) NOT NULL DEFAULT 'N',
  PRIMARY KEY (`phone`),
  UNIQUE KEY `code` (`phone`),
  KEY `auto` (`auto`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=2 ;

--
-- Dumping data for table `daftarcustomer`
--

INSERT INTO `daftarcustomer` (`phone`, `email`, `password`, `name`, `address`, `city`, `state`, `country`, `postal`, `auto`, `timestamp`, `operator`, `modul`, `status`) VALUES
('admin', 'admin', 'admin', 'admin', 'admin', 'admin', 'admin', 'admin', 'admin', 1, '2013-12-17 17:51:49', 'admin', 'DFTCUST', 'Y');

-- --------------------------------------------------------

--
-- Table structure for table `daftaritem`
--

CREATE TABLE IF NOT EXISTS `daftaritem` (
  `code` varchar(25) NOT NULL DEFAULT '',
  `name` varchar(50) DEFAULT 'blank',
  `kategori` varchar(25) NOT NULL DEFAULT 'blank',
  `price` double NOT NULL DEFAULT '0',
  `details` varchar(250) DEFAULT 'blank',
  `images` varchar(100) NOT NULL DEFAULT 'blank',
  `auto` int(11) NOT NULL AUTO_INCREMENT,
  `timestamp` timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
  `operator` varchar(50) NOT NULL DEFAULT 'blank',
  `modul` varchar(10) NOT NULL DEFAULT 'blank',
  `status` char(1) NOT NULL DEFAULT 'N',
  PRIMARY KEY (`code`),
  UNIQUE KEY `code` (`code`),
  KEY `auto` (`auto`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=11 ;

--
-- Dumping data for table `daftaritem`
--

INSERT INTO `daftaritem` (`code`, `name`, `kategori`, `price`, `details`, `images`, `auto`, `timestamp`, `operator`, `modul`, `status`) VALUES
('G001', 'Ayam Panggang', '00', 12000, 'Ayam panggang dengan rasa enak dan tingkat kematangan sempurna pas untuk selera nusantara.', '', 1, '2013-12-17 18:08:45', 'admin', 'DFTITEM', 'Y'),
('G002', 'Rujak Bali', '00', 8000, 'Rujak Bali dengan kualitas buah No.1 yang dipetik langsung dari kebun dan dengan saos yang lezat.', '', 2, '2013-12-17 18:21:45', 'admin', 'DFTITEM', 'Y'),
('G003', 'Ice Cream', '00', 28000, 'Aneka Ice Cream dengan susu asli menjaga kelembutan dan rasa yang enak. Paduan buah dan saos lezat.', '', 3, '2013-12-17 18:25:37', 'admin', 'DFTITEM', 'Y'),
('G004', 'Biscuit Berry', '00', 5000, 'Strawberry Biscuit dibuat dari tepung berkualitas dan Strawberry yang dipetik langsung dari kebunnya.', '', 4, '2013-12-17 18:30:16', 'admin', 'DFTITEM', 'Y'),
('G005', 'Kacang Fantasy', '00', 25000, 'Campuran Kacang, sayuran dan buah-buahan dengan bumbu yang menyatukan semua rasa menjadi fantastis.', '', 5, '2013-12-17 18:34:44', 'admin', 'DFTITEM', 'Y'),
('G006', 'Acar Spesial', '00', 12000, 'Campuran sayuran dan buah-buahan dengan bumbu yang menyatukan semua rasa menjadi fantastis.', '', 6, '2013-12-17 18:38:47', 'admin', 'DFTITEM', 'Y'),
('G007', 'Special Snack', '00', 15000, 'Teh Hangat, buah dan beberapa roti akan mengasikkan suasana istirahat anda.', '', 7, '2013-12-17 18:55:13', 'admin', 'DFTITEM', 'Y'),
('G008', 'X-Sea Food', '00', 23000, 'Udang, cumi dan beberapa sajian Seafood dengan bumbu yang pastinya lezat.', '', 8, '2013-12-17 18:57:42', 'admin', 'DFTITEM', 'Y'),
('G009', 'Crazy Potatoes', '00', 9000, 'Kentang goreng gurih dengan bumbu super pedas akan menggoyang lidah anda.', '', 9, '2013-12-17 19:01:46', 'admin', 'DFTITEM', 'Y'),
('G010', 'Heaven Soup', '00', 15000, 'Sup spesial dengan campuran berbagai rempah dengan bumbu kental nikmat.', '', 10, '2013-12-17 19:05:10', 'admin', 'DFTITEM', 'Y');

-- --------------------------------------------------------

--
-- Table structure for table `daftarkategoriitem`
--

CREATE TABLE IF NOT EXISTS `daftarkategoriitem` (
  `code` varchar(25) NOT NULL DEFAULT '',
  `name` varchar(50) DEFAULT 'blank',
  `details` varchar(100) DEFAULT 'blank',
  `auto` int(11) NOT NULL AUTO_INCREMENT,
  `timestamp` timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
  `operator` varchar(50) NOT NULL DEFAULT 'blank',
  `modul` varchar(10) NOT NULL DEFAULT 'blank',
  `status` char(1) NOT NULL DEFAULT 'N',
  PRIMARY KEY (`code`),
  UNIQUE KEY `code` (`code`),
  KEY `auto` (`auto`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=2 ;

--
-- Dumping data for table `daftarkategoriitem`
--

INSERT INTO `daftarkategoriitem` (`code`, `name`, `details`, `auto`, `timestamp`, `operator`, `modul`, `status`) VALUES
('00', 'General Category', 'General Category for all items.', 1, '2013-12-17 17:50:06', 'admin', 'DFTKITEM', 'Y');

-- --------------------------------------------------------

--
-- Table structure for table `daftarkategorimenu`
--

CREATE TABLE IF NOT EXISTS `daftarkategorimenu` (
  `code` varchar(25) NOT NULL DEFAULT '',
  `name` varchar(50) DEFAULT 'blank',
  `details` varchar(100) DEFAULT 'blank',
  `auto` int(11) NOT NULL AUTO_INCREMENT,
  `timestamp` timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
  `operator` varchar(50) NOT NULL DEFAULT 'blank',
  `modul` varchar(10) NOT NULL DEFAULT 'blank',
  `status` char(1) NOT NULL DEFAULT 'N',
  PRIMARY KEY (`code`),
  UNIQUE KEY `code` (`code`),
  KEY `auto` (`auto`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=2 ;

--
-- Dumping data for table `daftarkategorimenu`
--

INSERT INTO `daftarkategorimenu` (`code`, `name`, `details`, `auto`, `timestamp`, `operator`, `modul`, `status`) VALUES
('00', 'General Category', 'General Category for all menus.', 1, '2013-12-17 17:50:34', 'admin', 'DFTKMENU', 'N');

-- --------------------------------------------------------

--
-- Table structure for table `daftarmenu`
--

CREATE TABLE IF NOT EXISTS `daftarmenu` (
  `code` varchar(25) NOT NULL DEFAULT '',
  `name` varchar(50) DEFAULT 'blank',
  `kategori` varchar(25) NOT NULL DEFAULT 'blank',
  `price` double NOT NULL DEFAULT '0',
  `details` varchar(250) DEFAULT 'blank',
  `images` varchar(100) NOT NULL DEFAULT 'blank',
  `auto` int(11) NOT NULL AUTO_INCREMENT,
  `timestamp` timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
  `operator` varchar(50) NOT NULL DEFAULT 'blank',
  `modul` varchar(10) NOT NULL DEFAULT 'blank',
  `status` char(1) NOT NULL DEFAULT 'N',
  PRIMARY KEY (`code`),
  UNIQUE KEY `code` (`code`),
  KEY `auto` (`auto`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1 AUTO_INCREMENT=1 ;

-- --------------------------------------------------------

--
-- Table structure for table `daftarmenudetails`
--

CREATE TABLE IF NOT EXISTS `daftarmenudetails` (
  `menucode` varchar(25) NOT NULL DEFAULT 'blank',
  `itemcode` varchar(25) NOT NULL DEFAULT 'blank',
  `itemname` varchar(50) DEFAULT 'blank',
  `itemkategori` varchar(25) NOT NULL DEFAULT 'blank',
  `itemprice` double NOT NULL DEFAULT '0',
  `itemqty` int(11) NOT NULL DEFAULT '0',
  `auto` int(11) NOT NULL AUTO_INCREMENT,
  `timestamp` timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
  `operator` varchar(50) NOT NULL DEFAULT 'blank',
  `modul` varchar(10) NOT NULL DEFAULT 'blank',
  `status` char(1) NOT NULL DEFAULT 'N',
  PRIMARY KEY (`auto`),
  KEY `auto` (`auto`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1 AUTO_INCREMENT=1 ;

-- --------------------------------------------------------

--
-- Table structure for table `daftarorder`
--

CREATE TABLE IF NOT EXISTS `daftarorder` (
  `auto` int(11) NOT NULL AUTO_INCREMENT,
  `username` varchar(50) NOT NULL DEFAULT 'blank',
  `code` varchar(25) NOT NULL DEFAULT 'blank',
  `name` varchar(50) DEFAULT 'blank',
  `price` double NOT NULL DEFAULT '0',
  `qty` double DEFAULT '0',
  `total` double NOT NULL DEFAULT '0',
  `timestamp` timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
  `operator` varchar(50) NOT NULL DEFAULT 'blank',
  `modul` varchar(10) NOT NULL DEFAULT 'blank',
  `status` char(1) NOT NULL DEFAULT 'N',
  PRIMARY KEY (`auto`),
  UNIQUE KEY `auto_2` (`auto`),
  KEY `auto` (`auto`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1 AUTO_INCREMENT=1 ;

-- --------------------------------------------------------

--
-- Table structure for table `daftarpayment`
--

CREATE TABLE IF NOT EXISTS `daftarpayment` (
  `auto` int(11) NOT NULL AUTO_INCREMENT,
  `orderid` int(11) NOT NULL DEFAULT '0',
  `username` varchar(50) NOT NULL DEFAULT 'blank',
  `code` varchar(25) NOT NULL DEFAULT 'blank',
  `name` varchar(50) DEFAULT 'blank',
  `price` double NOT NULL DEFAULT '0',
  `qty` double DEFAULT '0',
  `total` double NOT NULL DEFAULT '0',
  `bankname` varchar(25) NOT NULL DEFAULT 'blank',
  `sender` varchar(50) NOT NULL DEFAULT 'blank',
  `comments` varchar(50) NOT NULL DEFAULT 'blank',
  `timestamp` timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
  `operator` varchar(50) NOT NULL DEFAULT 'blank',
  `modul` varchar(10) NOT NULL DEFAULT 'blank',
  `status` char(1) NOT NULL DEFAULT 'N',
  PRIMARY KEY (`auto`),
  UNIQUE KEY `auto_2` (`auto`),
  KEY `auto` (`auto`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1 AUTO_INCREMENT=1 ;

-- --------------------------------------------------------

--
-- Table structure for table `setup`
--

CREATE TABLE IF NOT EXISTS `setup` (
  `code` varchar(20) NOT NULL,
  `periode` date DEFAULT NULL,
  `status` char(1) NOT NULL DEFAULT 'N',
  PRIMARY KEY (`code`),
  UNIQUE KEY `code` (`code`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `setup`
--

INSERT INTO `setup` (`code`, `periode`, `status`) VALUES
('capisano', '2013-11-01', 'N');

-- --------------------------------------------------------

--
-- Table structure for table `smstemplate`
--

CREATE TABLE IF NOT EXISTS `smstemplate` (
  `code` varchar(25) NOT NULL DEFAULT '',
  `description` varchar(50) DEFAULT 'blank',
  `message` varchar(1000) DEFAULT 'blank',
  `auto` int(11) NOT NULL AUTO_INCREMENT,
  `timestamp` timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
  `operator` varchar(50) NOT NULL DEFAULT 'blank',
  `modul` varchar(10) NOT NULL DEFAULT 'blank',
  PRIMARY KEY (`code`),
  KEY `auto` (`auto`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1 AUTO_INCREMENT=1 ;

-- --------------------------------------------------------

--
-- Table structure for table `user`
--

CREATE TABLE IF NOT EXISTS `user` (
  `username` varchar(50) NOT NULL,
  `password` varchar(50) NOT NULL DEFAULT 'blank',
  `priv_a1` tinyint(1) NOT NULL DEFAULT '0',
  `priv_a2` tinyint(1) NOT NULL DEFAULT '0',
  `priv_a3` tinyint(1) NOT NULL DEFAULT '0',
  `priv_a4` tinyint(1) NOT NULL DEFAULT '0',
  `priv_b1` tinyint(1) NOT NULL DEFAULT '0',
  `priv_b2` tinyint(1) NOT NULL DEFAULT '0',
  `priv_b3` tinyint(1) NOT NULL DEFAULT '0',
  `priv_b4` tinyint(1) NOT NULL DEFAULT '0',
  `priv_b5` tinyint(1) NOT NULL DEFAULT '0',
  `priv_b6` tinyint(1) NOT NULL DEFAULT '0',
  `priv_c1` tinyint(1) NOT NULL DEFAULT '0',
  `priv_d1` tinyint(1) NOT NULL DEFAULT '0',
  `priv_d2` tinyint(1) NOT NULL DEFAULT '0',
  `priv_d3` tinyint(1) NOT NULL DEFAULT '0',
  `priv_e1` tinyint(1) NOT NULL DEFAULT '0',
  `auto` int(11) NOT NULL AUTO_INCREMENT,
  `timestamp` timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
  `operator` varchar(50) NOT NULL DEFAULT 'blank',
  `modul` varchar(10) NOT NULL DEFAULT 'blank',
  PRIMARY KEY (`username`),
  KEY `auto` (`auto`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=6 ;

--
-- Dumping data for table `user`
--

INSERT INTO `user` (`username`, `password`, `priv_a1`, `priv_a2`, `priv_a3`, `priv_a4`, `priv_b1`, `priv_b2`, `priv_b3`, `priv_b4`, `priv_b5`, `priv_b6`, `priv_c1`, `priv_d1`, `priv_d2`, `priv_d3`, `priv_e1`, `auto`, `timestamp`, `operator`, `modul`) VALUES
('adm2', 'admin', 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 3, '2013-11-26 16:01:32', 'admin', 'USERMNG'),
('admin', 'admin', 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, '2013-11-26 16:10:59', 'admin', 'USERMNG'),
('rwaeataw', 'admin', 0, 0, 1, 1, 1, 1, 1, 1, 0, 0, 1, 0, 1, 0, 1, 5, '2013-11-26 16:02:10', 'admin', 'USERMNG'),
('test', 'test', 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 2, '2013-11-25 17:00:00', 'blank', 'blank');

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
