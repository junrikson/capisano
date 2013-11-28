-- phpMyAdmin SQL Dump
-- version 4.0.4.1
-- http://www.phpmyadmin.net
--
-- Host: 127.0.0.1
-- Generation Time: Nov 27, 2013 at 10:44 PM
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
  UNIQUE KEY `email` (`email`),
  KEY `auto` (`auto`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=9 ;

--
-- Dumping data for table `daftarcustomer`
--

INSERT INTO `daftarcustomer` (`phone`, `email`, `password`, `name`, `address`, `city`, `state`, `country`, `postal`, `auto`, `timestamp`, `operator`, `modul`, `status`) VALUES
('44454yr', 'email245', 'pass3', 'nama2', '', 'kota2', 'provinsi3', 'negara4', 'kode pos5', 8, '2013-11-26 23:42:14', 'admin', 'DFTCUST', 'N'),
('phone1', 'email2', 'pass3', 'nama2', 'alamat1', 'kota2', 'provinsi3', 'negara4', 'kode pos5', 3, '2013-11-26 21:07:37', 'admin', 'DFTCUST', 'N');

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
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=9 ;

--
-- Dumping data for table `daftaritem`
--

INSERT INTO `daftaritem` (`code`, `name`, `kategori`, `price`, `details`, `images`, `auto`, `timestamp`, `operator`, `modul`, `status`) VALUES
('Item 11', 'Item 11', 'Kategori Item 1', 12000, '\n	\n\nLorem ipsum dolor sit amet, consectetuer adipiscing elit, sed diam nonummy nibh euismod tincidunt ut laoreet dolore magna aliquam erat volutpat. Ut wisi enim ad minim veniam, quis nostrud exerci tation ullamcorper suscipit lobortis nisl ut aliqui', '', 4, '2013-11-25 22:58:17', 'admin', 'DFTITEM', 'N'),
('Item 12', 'Item 12', 'Kategori Item 1', 14000, '\n	\n\nLorem ipsum dolor sit amet, consectetuer adipiscing elit, sed diam nonummy nibh euismod tincidunt ut laoreet dolore magna aliquam erat volutpat. Ut wisi enim ad minim veniam, quis nostrud exerci tation ullamcorper suscipit lobortis nisl ut aliqui', '', 5, '2013-11-25 22:58:30', 'admin', 'DFTITEM', 'N'),
('Item 13', 'Item 13', 'Kategori Item 1', 15000, '\n	\n\nLorem ipsum dolor sit amet, consectetuer adipiscing elit, sed diam nonummy nibh euismod tincidunt ut laoreet dolore magna aliquam erat volutpat. Ut wisi enim ad minim veniam, quis nostrud exerci tation ullamcorper suscipit lobortis nisl ut aliqui', '', 6, '2013-11-25 22:58:43', 'admin', 'DFTITEM', 'N'),
('Item 21', 'Item 21', 'Kategori Item 2', 15000, '\n	\n\nLorem ipsum dolor sit amet, consectetuer adipiscing elit, sed diam nonummy nibh euismod tincidunt ut laoreet dolore magna aliquam erat volutpat. Ut wisi enim ad minim veniam, quis nostrud exerci tation ullamcorper suscipit lobortis nisl ut aliqui', '', 7, '2013-11-25 22:58:59', 'admin', 'DFTITEM', 'N'),
('Item 22', 'Item 22', 'Kategori Item 2', 12000, '\n	\n\nLorem ipsum dolor sit amet, consectetuer adipiscing elit, sed diam nonummy nibh euismod tincidunt ut laoreet dolore magna aliquam erat volutpat. Ut wisi enim ad minim veniam, quis nostrud exerci tation ullamcorper suscipit lobortis nisl ut aliqui', '', 8, '2013-11-25 22:59:16', 'admin', 'DFTITEM', 'N');

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
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=26 ;

--
-- Dumping data for table `daftarkategoriitem`
--

INSERT INTO `daftarkategoriitem` (`code`, `name`, `details`, `auto`, `timestamp`, `operator`, `modul`, `status`) VALUES
('Kategori Item 1', 'Kategori Item 1', 'Lorem ipsum dolor sit amet, consectetuer adipiscing elit, sed diam nonummy nibh euismod tincidunt ut', 18, '2013-11-25 09:51:11', 'admin', 'DFTKITEM', 'N'),
('Kategori Item 2', 'Kategori Item 2', 'Lorem ipsum dolor sit amet, consectetuer adipiscing elit, sed diam nonummy nibh euismod tincidunt ut', 19, '2013-11-25 09:51:31', 'admin', 'DFTKITEM', 'N'),
('Kategori Item 3', 'Kategori Item 3', 'Lorem ipsum dolor sit amet, consectetuer adipiscing elit, sed diam nonummy nibh euismod tincidunt ut', 20, '2013-11-25 09:51:35', 'admin', 'DFTKITEM', 'N'),
('Kategori Item 4', 'Kategori Item 4', 'Lorem ipsum dolor sit amet, consectetuer adipiscing elit, sed diam nonummy nibh euismod tincidunt ut', 21, '2013-11-25 09:52:15', 'admin', 'DFTKITEM', 'N'),
('Kategori Item 5', 'Kategori Item 5', 'Lorem ipsum dolor sit amet, consectetuer adipiscing elit, sed diam nonummy nibh euismod tincidunt ut', 22, '2013-11-25 09:52:10', 'admin', 'DFTKITEM', 'N'),
('Kategori Item 6', 'Kategori Item 6', 'Lorem ipsum dolor sit amet, consectetuer adipiscing elit, sed diam nonummy nibh euismod tincidunt ut', 23, '2013-11-25 09:52:07', 'admin', 'DFTKITEM', 'N'),
('Kategori Item 7', 'Kategori Item 7', 'Lorem ipsum dolor sit amet, consectetuer adipiscing elit, sed diam nonummy nibh euismod tincidunt ut', 25, '2013-11-25 09:52:32', 'admin', 'DFTKITEM', 'N');

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
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=11 ;

--
-- Dumping data for table `daftarkategorimenu`
--

INSERT INTO `daftarkategorimenu` (`code`, `name`, `details`, `auto`, `timestamp`, `operator`, `modul`, `status`) VALUES
('Kategori Menu 1', 'Kategori Menu 1', 'Lorem ipsum dolor sit amet, consectetuer adipiscing elit, sed diam nonummy nibh euismod tincidunt ut', 4, '2013-11-25 09:55:10', 'admin', 'DFTKMENU', 'N'),
('Kategori Menu 2', 'Kategori Menu 2', 'Lorem ipsum dolor sit amet, consectetuer adipiscing elit, sed diam nonummy nibh euismod tincidunt ut', 5, '2013-11-25 09:55:21', 'admin', 'DFTKMENU', 'N'),
('Kategori Menu 4', 'Kategori Menu 3', 'Lorem ipsum dolor sit amet, consectetuer adipiscing elit, sed diam nonummy nibh euismod tincidunt ut', 6, '2013-11-25 09:55:28', 'admin', 'DFTKMENU', 'N'),
('Kategori Menu 5', 'Kategori Menu 5', 'Lorem ipsum dolor sit amet, consectetuer adipiscing elit, sed diam nonummy nibh euismod tincidunt ut', 7, '2013-11-25 09:55:35', 'admin', 'DFTKMENU', 'N'),
('Kategori Menu 6', 'Kategori Menu 6', 'Lorem ipsum dolor sit amet, consectetuer adipiscing elit, sed diam nonummy nibh euismod tincidunt ut', 8, '2013-11-25 09:55:42', 'admin', 'DFTKMENU', 'N'),
('Kategori Menu 7', 'Kategori Menu 7', 'Lorem ipsum dolor sit amet, consectetuer adipiscing elit, sed diam nonummy nibh euismod tincidunt ut', 9, '2013-11-25 09:55:47', 'admin', 'DFTKMENU', 'N'),
('Kategori Menu 8', 'Kategori Menu 8', 'Lorem ipsum dolor sit amet, consectetuer adipiscing elit, sed diam nonummy nibh euismod tincidunt ut', 10, '2013-11-25 09:55:55', 'admin', 'DFTKMENU', 'N');

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
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=5 ;

--
-- Dumping data for table `daftarmenu`
--

INSERT INTO `daftarmenu` (`code`, `name`, `kategori`, `price`, `details`, `images`, `auto`, `timestamp`, `operator`, `modul`, `status`) VALUES
('Menu 12', 'Menu 12', 'Kategori Menu 1', 20000, 'Lorem ipsum dolor sit amet, consectetuer adipiscing elit, sed diam nonummy nibh euismod tincidunt ut laoreet dolore magna aliquam erat volutpat. Ut wisi enim ad minim veniam, quis nostrud exerci tation ullamcorper suscipit lobortis nisl ut aliqui', '', 4, '2013-11-26 01:12:41', 'admin', 'DFTMENU', 'N'),
('Menu 13', 'Menu 13', 'Kategori Menu 1', 28000.36443, 'Lorem ipsum dolor sit amet, consectetuer adipiscing elit, sed diam nonummy nibh euismod tincidunt ut laoreet dolore magna aliquam erat volutpat. Ut wisi enim ad minim veniam, quis nostrud exerci tation ullamcorper suscipit lobortis nisl ut aliqui', '', 3, '2013-11-26 03:23:27', 'test', 'DFTMENU', 'N');

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
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=28 ;

--
-- Dumping data for table `daftarmenudetails`
--

INSERT INTO `daftarmenudetails` (`menucode`, `itemcode`, `itemname`, `itemkategori`, `itemprice`, `itemqty`, `auto`, `timestamp`, `operator`, `modul`, `status`) VALUES
('Menu 13', 'Item 21', 'Item 21', 'Kategori Item 2', 15000, 1, 16, '2013-11-26 01:03:16', 'admin', 'DFTMENUDET', 'N'),
('Menu 13', 'Item 21', 'Item 21', 'Kategori Item 2', 15000, 1, 18, '2013-11-26 01:03:22', 'admin', 'DFTMENUDET', 'N'),
('Menu 13', 'Item 13', 'Item 13', 'Kategori Item 1', 15000, 1, 19, '2013-11-26 01:03:25', 'admin', 'DFTMENUDET', 'N'),
('Menu 12', 'Item 21', 'Item 21', 'Kategori Item 2', 15000, 1, 21, '2013-11-26 01:14:02', 'admin', 'DFTMENUDET', 'N'),
('Menu 12', 'Item 13', 'Item 13', 'Kategori Item 1', 20000, 1, 22, '2013-11-26 01:14:38', 'admin', 'DFTMENUDET', 'N'),
('Menu 12', 'Item 13', 'Item 13', 'Kategori Item 1', 15000, 1, 23, '2013-11-26 01:14:13', 'admin', 'DFTMENUDET', 'N'),
('Menu 13', 'Item 13', 'Item 13', 'Kategori Item 1', 15000.4765, 1, 24, '2013-11-26 03:23:18', 'test', 'DFTMENUDET', 'N'),
('Menu 13', 'Item 22', 'Item 22', 'Kategori Item 2', 12000, 1, 26, '2013-11-26 03:22:00', 'test', 'DFTMENUDET', 'N'),
('Menu 13', 'Item 21', 'Item 21', 'Kategori Item 2', 150004, 1, 27, '2013-11-26 03:23:11', 'test', 'DFTMENUDET', 'N');

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
