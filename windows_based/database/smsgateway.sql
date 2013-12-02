-- phpMyAdmin SQL Dump
-- version 4.0.4.1
-- http://www.phpmyadmin.net
--
-- Host: 127.0.0.1
-- Generation Time: Dec 02, 2013 at 09:35 PM
-- Server version: 5.5.32
-- PHP Version: 5.4.16

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;

--
-- Database: `smsgateway`
--
CREATE DATABASE IF NOT EXISTS `smsgateway` DEFAULT CHARACTER SET latin1 COLLATE latin1_swedish_ci;
USE `smsgateway`;

-- --------------------------------------------------------

--
-- Table structure for table `sms_history`
--

CREATE TABLE IF NOT EXISTS `sms_history` (
  `id` int(11) unsigned NOT NULL AUTO_INCREMENT,
  `no_hp` varchar(20) DEFAULT NULL,
  `pesan` varchar(300) DEFAULT NULL,
  `tipe` tinyint(1) unsigned DEFAULT '0',
  `tgl_sms` datetime DEFAULT NULL,
  `com` varchar(3) DEFAULT NULL,
  `status` char(1) NOT NULL DEFAULT 'N',
  PRIMARY KEY (`id`),
  KEY `byPhone` (`no_hp`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1 AUTO_INCREMENT=1 ;

-- --------------------------------------------------------

--
-- Table structure for table `sms_inbox`
--

CREATE TABLE IF NOT EXISTS `sms_inbox` (
  `id` int(11) unsigned NOT NULL AUTO_INCREMENT,
  `sourceno` varchar(20) DEFAULT '0',
  `tgl` datetime NOT NULL DEFAULT '1980-07-15 00:00:00',
  `text` varchar(300) DEFAULT NULL,
  `port` varchar(3) DEFAULT '0',
  `ip` varchar(20) DEFAULT '127.0.0.1',
  `status` char(1) NOT NULL DEFAULT 'N',
  PRIMARY KEY (`id`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1 AUTO_INCREMENT=1 ;

-- --------------------------------------------------------

--
-- Table structure for table `sms_outbox`
--

CREATE TABLE IF NOT EXISTS `sms_outbox` (
  `id` int(11) unsigned NOT NULL AUTO_INCREMENT,
  `no_hp` varchar(100) DEFAULT NULL,
  `pesan` varchar(300) DEFAULT NULL,
  `tgl_sms` datetime DEFAULT NULL,
  `com` varchar(3) DEFAULT NULL,
  `ip` varchar(20) NOT NULL DEFAULT '127.0.0.1',
  `status` char(1) NOT NULL DEFAULT 'N',
  PRIMARY KEY (`id`),
  KEY `byNophone` (`no_hp`),
  KEY `idx` (`com`,`ip`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1 AUTO_INCREMENT=1 ;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
