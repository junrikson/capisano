/*
SQLyog Enterprise - MySQL GUI v7.12 
MySQL - 5.0.67-community-nt : Database - smsgateway
*********************************************************************
*/

/*!40101 SET NAMES utf8 */;

/*!40101 SET SQL_MODE=''*/;

/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;

CREATE DATABASE /*!32312 IF NOT EXISTS*/`smsgateway` /*!40100 DEFAULT CHARACTER SET latin1 */;

USE `smsgateway`;

/*Table structure for table `sms_history` */

DROP TABLE IF EXISTS `sms_history`;

CREATE TABLE `sms_history` (
  `id` int(11) unsigned NOT NULL auto_increment,
  `no_hp` varchar(20) default NULL,
  `pesan` varchar(300) default NULL,
  `tipe` tinyint(1) unsigned default '0',
  `tgl_sms` datetime default NULL,
  `com` varchar(3) default NULL,
  PRIMARY KEY  (`id`),
  KEY `byPhone` (`no_hp`)
) ENGINE=MyISAM AUTO_INCREMENT=1183 DEFAULT CHARSET=latin1;

/*Data for the table `sms_history` */

insert  into `sms_history`(`id`,`no_hp`,`pesan`,`tipe`,`tgl_sms`,`com`) values (1149,'085641820270','tes',1,'2011-09-09 12:00:00','9');
insert  into `sms_history`(`id`,`no_hp`,`pesan`,`tipe`,`tgl_sms`,`com`) values (1150,'085641820270','testing',1,'2011-08-21 11:38:26','9');
insert  into `sms_history`(`id`,`no_hp`,`pesan`,`tipe`,`tgl_sms`,`com`) values (1151,'085641820270','testing',1,'2011-08-21 11:38:27','9');
insert  into `sms_history`(`id`,`no_hp`,`pesan`,`tipe`,`tgl_sms`,`com`) values (1152,'085641820270','testing',1,'2011-08-21 11:38:27','9');
insert  into `sms_history`(`id`,`no_hp`,`pesan`,`tipe`,`tgl_sms`,`com`) values (1153,'085641820270','testing',1,'2011-08-21 11:38:27','9');
insert  into `sms_history`(`id`,`no_hp`,`pesan`,`tipe`,`tgl_sms`,`com`) values (1154,'085641820270','testing',1,'2011-08-21 11:38:27','9');
insert  into `sms_history`(`id`,`no_hp`,`pesan`,`tipe`,`tgl_sms`,`com`) values (1155,'085641820270','testing',1,'2011-08-21 11:38:28','9');
insert  into `sms_history`(`id`,`no_hp`,`pesan`,`tipe`,`tgl_sms`,`com`) values (1156,'085641820270','testing',1,'2011-08-21 11:38:28','9');
insert  into `sms_history`(`id`,`no_hp`,`pesan`,`tipe`,`tgl_sms`,`com`) values (1157,'085641820270','testing',1,'2011-08-21 11:38:28','9');
insert  into `sms_history`(`id`,`no_hp`,`pesan`,`tipe`,`tgl_sms`,`com`) values (1158,'085641820270','testing',1,'2011-08-21 11:38:28','9');
insert  into `sms_history`(`id`,`no_hp`,`pesan`,`tipe`,`tgl_sms`,`com`) values (1159,'085641820270','testing',1,'2011-08-21 11:38:28','9');
insert  into `sms_history`(`id`,`no_hp`,`pesan`,`tipe`,`tgl_sms`,`com`) values (1160,'085641820270','testing',1,'2011-08-21 11:38:28','9');
insert  into `sms_history`(`id`,`no_hp`,`pesan`,`tipe`,`tgl_sms`,`com`) values (1161,'085641820270','testing',1,'2011-08-21 11:38:29','9');
insert  into `sms_history`(`id`,`no_hp`,`pesan`,`tipe`,`tgl_sms`,`com`) values (1162,'085641820270','testing',1,'2011-08-21 11:38:29','9');
insert  into `sms_history`(`id`,`no_hp`,`pesan`,`tipe`,`tgl_sms`,`com`) values (1163,'085641820270','testing',1,'2011-08-21 11:38:29','9');
insert  into `sms_history`(`id`,`no_hp`,`pesan`,`tipe`,`tgl_sms`,`com`) values (1164,'085641820270','testing',1,'2011-08-21 11:38:29','9');
insert  into `sms_history`(`id`,`no_hp`,`pesan`,`tipe`,`tgl_sms`,`com`) values (1165,'085641820270','testing',1,'2011-08-21 11:38:29','9');
insert  into `sms_history`(`id`,`no_hp`,`pesan`,`tipe`,`tgl_sms`,`com`) values (1166,'085641820270','testing',1,'2011-08-21 11:38:29','9');
insert  into `sms_history`(`id`,`no_hp`,`pesan`,`tipe`,`tgl_sms`,`com`) values (1167,'085641820270','testing',1,'2011-08-21 11:38:29','9');
insert  into `sms_history`(`id`,`no_hp`,`pesan`,`tipe`,`tgl_sms`,`com`) values (1168,'085641820270','testing',1,'2011-08-21 11:38:30','9');
insert  into `sms_history`(`id`,`no_hp`,`pesan`,`tipe`,`tgl_sms`,`com`) values (1169,'085641820270','testing',1,'2011-08-21 11:38:30','9');
insert  into `sms_history`(`id`,`no_hp`,`pesan`,`tipe`,`tgl_sms`,`com`) values (1170,'085641820270','testing',1,'2011-08-21 11:38:30','9');
insert  into `sms_history`(`id`,`no_hp`,`pesan`,`tipe`,`tgl_sms`,`com`) values (1171,'085641820270','testing',1,'2011-08-21 11:38:30','9');
insert  into `sms_history`(`id`,`no_hp`,`pesan`,`tipe`,`tgl_sms`,`com`) values (1172,'085641820270','testing',1,'2011-08-21 11:38:30','9');
insert  into `sms_history`(`id`,`no_hp`,`pesan`,`tipe`,`tgl_sms`,`com`) values (1173,'085641820270','testing',1,'2011-08-21 11:38:30','9');
insert  into `sms_history`(`id`,`no_hp`,`pesan`,`tipe`,`tgl_sms`,`com`) values (1174,'085641820270','testing',1,'2011-08-21 11:38:31','9');
insert  into `sms_history`(`id`,`no_hp`,`pesan`,`tipe`,`tgl_sms`,`com`) values (1175,'085641820270','testing',1,'2011-08-21 11:38:31','9');
insert  into `sms_history`(`id`,`no_hp`,`pesan`,`tipe`,`tgl_sms`,`com`) values (1176,'085641820270','testing',1,'2011-08-21 11:38:31','9');
insert  into `sms_history`(`id`,`no_hp`,`pesan`,`tipe`,`tgl_sms`,`com`) values (1177,'085641820270','testing',1,'2011-08-21 11:38:31','9');
insert  into `sms_history`(`id`,`no_hp`,`pesan`,`tipe`,`tgl_sms`,`com`) values (1178,'085641820270','testing',1,'2011-08-21 11:38:31','9');
insert  into `sms_history`(`id`,`no_hp`,`pesan`,`tipe`,`tgl_sms`,`com`) values (1179,'085641820270','testing',1,'2011-08-21 11:38:31','9');
insert  into `sms_history`(`id`,`no_hp`,`pesan`,`tipe`,`tgl_sms`,`com`) values (1180,'085641820270','testing',1,'2011-08-21 11:38:32','9');
insert  into `sms_history`(`id`,`no_hp`,`pesan`,`tipe`,`tgl_sms`,`com`) values (1181,'085641820270','xxxxxxxxxxxxxx',1,'2011-08-22 12:24:34','9');
insert  into `sms_history`(`id`,`no_hp`,`pesan`,`tipe`,`tgl_sms`,`com`) values (1182,'085641820270','test',1,'2011-08-22 12:25:31','9');

/*Table structure for table `sms_inbox` */

DROP TABLE IF EXISTS `sms_inbox`;

CREATE TABLE `sms_inbox` (
  `id` int(11) unsigned NOT NULL auto_increment,
  `sourceno` varchar(20) default '0',
  `tgl` datetime NOT NULL default '1980-07-15 00:00:00',
  `text` varchar(300) default NULL,
  `port` varchar(3) default '0',
  `ip` varchar(20) default '127.0.0.1',
  PRIMARY KEY  (`id`)
) ENGINE=MyISAM AUTO_INCREMENT=9 DEFAULT CHARSET=latin1;

/*Data for the table `sms_inbox` */

insert  into `sms_inbox`(`id`,`sourceno`,`tgl`,`text`,`port`,`ip`) values (1,'+6285641820270','2011-08-21 11:16:12','Tes','9','127.0.0.1');
insert  into `sms_inbox`(`id`,`sourceno`,`tgl`,`text`,`port`,`ip`) values (2,'+6285641820270','2011-08-21 11:30:24','Tes','9','127.0.0.1');
insert  into `sms_inbox`(`id`,`sourceno`,`tgl`,`text`,`port`,`ip`) values (3,'+6285641820270','2011-08-21 11:34:06','Tes','9','127.0.0.1');
insert  into `sms_inbox`(`id`,`sourceno`,`tgl`,`text`,`port`,`ip`) values (4,'+6285641820270','2011-08-21 11:35:16','Tes','9','127.0.0.1');
insert  into `sms_inbox`(`id`,`sourceno`,`tgl`,`text`,`port`,`ip`) values (5,'+6285641820270','2011-08-21 11:35:22','Tes','9','127.0.0.1');
insert  into `sms_inbox`(`id`,`sourceno`,`tgl`,`text`,`port`,`ip`) values (6,'+14C627A0','2011-08-21 11:38:55','Kamu dpt GRATIS 10.000 SMS ke semua operator s.d pk 12 malam.Nikmati juga GRATIS SMS SEPUASNYA ke semua operator pk 00-06 dgn kirim 3 SMS setiap hari. Info 838\0','9','127.0.0.1');
insert  into `sms_inbox`(`id`,`sourceno`,`tgl`,`text`,`port`,`ip`) values (7,'+6285641820270','2011-08-22 12:12:58','Tes','9','127.0.0.1');
insert  into `sms_inbox`(`id`,`sourceno`,`tgl`,`text`,`port`,`ip`) values (8,'+14C627A0','2011-08-22 12:26:01','Kamu dapat GRATIS SMS SEPUASNYA ke semua operator sampai dengan pukul 6 pagi. Nikmati juga GRATISAN di jam lainnya.Info 838','9','127.0.0.1');

/*Table structure for table `sms_outbox` */

DROP TABLE IF EXISTS `sms_outbox`;

CREATE TABLE `sms_outbox` (
  `id` int(11) unsigned NOT NULL auto_increment,
  `no_hp` varchar(100) default NULL,
  `pesan` varchar(300) default NULL,
  `tgl_sms` datetime default NULL,
  `com` varchar(3) default NULL,
  `ip` varchar(20) NOT NULL default '127.0.0.1',
  PRIMARY KEY  (`id`),
  KEY `byNophone` (`no_hp`),
  KEY `idx` (`com`,`ip`)
) ENGINE=MyISAM AUTO_INCREMENT=509 DEFAULT CHARSET=latin1;

/*Data for the table `sms_outbox` */

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
