-- phpMyAdmin SQL Dump
-- version 4.0.4.1
-- http://www.phpmyadmin.net
--
-- Host: 127.0.0.1
-- Generation Time: Nov 24, 2013 at 05:15 AM
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
-- Table structure for table `daftarkategoriitem`
--

CREATE TABLE IF NOT EXISTS `daftarkategoriitem` (
  `code` varchar(25) NOT NULL DEFAULT '',
  `name` varchar(50) DEFAULT 'blank',
  `details` varchar(100) DEFAULT 'blank',
  `auto` int(11) NOT NULL AUTO_INCREMENT,
  `timestamp` timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
  PRIMARY KEY (`code`),
  KEY `auto` (`auto`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=20 ;

--
-- Dumping data for table `daftarkategoriitem`
--

INSERT INTO `daftarkategoriitem` (`code`, `name`, `details`, `auto`, `timestamp`) VALUES
('test2', 'test', 'test', 14, '2013-11-24 04:07:59'),
('test23', 'test', 'test', 15, '2013-11-24 04:08:01'),
('test233', 'test', 'test', 17, '2013-11-24 04:08:06'),
('test24', 'test', 'test', 12, '2013-11-24 04:07:38');

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
  PRIMARY KEY (`code`),
  KEY `auto` (`auto`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=2 ;

--
-- Dumping data for table `daftarkategorimenu`
--

INSERT INTO `daftarkategorimenu` (`code`, `name`, `details`, `auto`, `timestamp`) VALUES
('test', 'blank', 'blank', 1, '2013-11-24 03:31:56');

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
  PRIMARY KEY (`username`),
  KEY `username` (`username`),
  KEY `auto` (`auto`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=3 ;

--
-- Dumping data for table `user`
--

INSERT INTO `user` (`username`, `password`, `priv_a1`, `priv_a2`, `priv_a3`, `priv_a4`, `priv_b1`, `priv_b2`, `priv_b3`, `priv_b4`, `priv_b5`, `priv_b6`, `priv_c1`, `priv_d1`, `priv_d2`, `priv_d3`, `priv_e1`, `auto`, `timestamp`) VALUES
('admin', 'admin', 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, '0000-00-00 00:00:00'),
('test', 'test', 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 2, '0000-00-00 00:00:00');

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
