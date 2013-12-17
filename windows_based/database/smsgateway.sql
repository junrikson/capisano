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
  PRIMARY KEY (`id`),
  KEY `byPhone` (`no_hp`)
) ENGINE=MyISAM  DEFAULT CHARSET=latin1 AUTO_INCREMENT=3 ;

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
  PRIMARY KEY (`id`)
) ENGINE=MyISAM  DEFAULT CHARSET=latin1 AUTO_INCREMENT=33 ;

--
-- Dumping data for table `sms_inbox`
--

INSERT INTO `sms_inbox` (`id`, `sourceno`, `tgl`, `text`, `port`, `ip`) VALUES
(29, '+6282363820339', '2013-12-17 12:34:09', 'a', '5', 'localhost'),
(28, '+6282363820339', '2013-12-17 12:32:44', 'j', '5', 'localhost'),
(27, '+4D22379FC6E4B8C', '2013-12-17 12:08:34', 'Anda baru saja mengirimkan 1 SMS, dapatkan gratis 1000 SMS (termasuk 20 SMS ke operator lain) setelah pengiriman beberapa SMS, berlaku hingga pukul 24.00', '5', 'localhost'),
(26, '+6282363820339', '2013-12-17 12:00:03', 'jamd', '5', 'localhost'),
(30, '+6282363820339', '2013-12-17 12:37:07', 'at', '5', 'localhost'),
(31, '+6282363820339', '2013-12-17 12:37:54', 'tu', '5', 'localhost'),
(32, '+6282363820339', '2013-12-17 12:38:06', 'gj', '5', 'localhost');

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
  PRIMARY KEY (`id`),
  KEY `byNophone` (`no_hp`),
  KEY `idx` (`com`,`ip`)
) ENGINE=MyISAM  DEFAULT CHARSET=latin1 AUTO_INCREMENT=12 ;

--
-- Dumping data for table `sms_outbox`
--

INSERT INTO `sms_outbox` (`id`, `no_hp`, `pesan`, `tgl_sms`, `com`, `ip`) VALUES
(11, '082363820339', 'guh', '2013-12-17 12:37:38', '5', 'localhost');

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
