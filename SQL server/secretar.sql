/*
Navicat MySQL Data Transfer

Source Server         : localhost_3306
Source Server Version : 50525
Source Host           : localhost:3306
Source Database       : secretar

Target Server Type    : MYSQL
Target Server Version : 50525
File Encoding         : 65001

Date: 2024-04-12 03:41:44
*/

SET FOREIGN_KEY_CHECKS=0;

-- ----------------------------
-- Table structure for authorization
-- ----------------------------
DROP TABLE IF EXISTS `authorization`;
CREATE TABLE `authorization` (
  `ID_teacher` int(255) NOT NULL AUTO_INCREMENT,
  `Login` varchar(255) DEFAULT NULL,
  `Password` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`ID_teacher`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of authorization
-- ----------------------------
INSERT INTO `authorization` VALUES ('1', 'zhukdv', '1810');
INSERT INTO `authorization` VALUES ('2', 'lisad', '2304');
INSERT INTO `authorization` VALUES ('3', 'gerasimovev', '2311');

-- ----------------------------
-- Table structure for evaluation
-- ----------------------------
DROP TABLE IF EXISTS `evaluation`;
CREATE TABLE `evaluation` (
  `ID` int(11) NOT NULL AUTO_INCREMENT,
  `ID_theme` int(255) DEFAULT NULL,
  `ID_student` int(255) DEFAULT NULL,
  `Grade` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`ID`),
  KEY `FK_ID_student` (`ID_student`),
  KEY `ID_theme` (`ID_theme`) USING BTREE,
  CONSTRAINT `FK_ID_student` FOREIGN KEY (`ID_student`) REFERENCES `student` (`ID_student`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=25 DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of evaluation
-- ----------------------------
INSERT INTO `evaluation` VALUES ('1', '1', '1', '5');
INSERT INTO `evaluation` VALUES ('2', '1', '2', '3');
INSERT INTO `evaluation` VALUES ('3', '1', '3', '3');
INSERT INTO `evaluation` VALUES ('4', '1', '4', '3');
INSERT INTO `evaluation` VALUES ('5', '1', '5', '5');
INSERT INTO `evaluation` VALUES ('6', '1', '6', '3');
INSERT INTO `evaluation` VALUES ('7', '1', '7', '5');
INSERT INTO `evaluation` VALUES ('8', '1', '8', '3');
INSERT INTO `evaluation` VALUES ('9', '1', '9', '3');
INSERT INTO `evaluation` VALUES ('10', '1', '10', '3');
INSERT INTO `evaluation` VALUES ('11', '1', '11', '3');
INSERT INTO `evaluation` VALUES ('12', '1', '12', '4');
INSERT INTO `evaluation` VALUES ('13', '2', '1', '5');
INSERT INTO `evaluation` VALUES ('14', '2', '2', '5');
INSERT INTO `evaluation` VALUES ('15', '2', '3', '3');
INSERT INTO `evaluation` VALUES ('16', '2', '4', '5');
INSERT INTO `evaluation` VALUES ('17', '2', '5', '4');
INSERT INTO `evaluation` VALUES ('18', '2', '6', '3');
INSERT INTO `evaluation` VALUES ('19', '2', '7', '4');
INSERT INTO `evaluation` VALUES ('20', '2', '8', '4');
INSERT INTO `evaluation` VALUES ('21', '2', '9', '3');
INSERT INTO `evaluation` VALUES ('22', '2', '10', '3');
INSERT INTO `evaluation` VALUES ('23', '2', '11', '5');
INSERT INTO `evaluation` VALUES ('24', '2', '12', '5');

-- ----------------------------
-- Table structure for group
-- ----------------------------
DROP TABLE IF EXISTS `group`;
CREATE TABLE `group` (
  `ID_group` int(255) NOT NULL AUTO_INCREMENT,
  `Group` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`ID_group`),
  CONSTRAINT `FK_ID_group` FOREIGN KEY (`ID_group`) REFERENCES `group teacher` (`ID_group`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of group
-- ----------------------------
INSERT INTO `group` VALUES ('1', 'ВК');
INSERT INTO `group` VALUES ('2', 'ИНС');
INSERT INTO `group` VALUES ('3', 'МБИТ');

-- ----------------------------
-- Table structure for group teacher
-- ----------------------------
DROP TABLE IF EXISTS `group teacher`;
CREATE TABLE `group teacher` (
  `ID` int(11) NOT NULL AUTO_INCREMENT,
  `ID_teacher` int(255) DEFAULT NULL,
  `ID_group` int(255) DEFAULT NULL,
  PRIMARY KEY (`ID`),
  KEY `FK2_ID_teacher` (`ID_teacher`),
  KEY `ID_group` (`ID_group`),
  CONSTRAINT `FK2_ID_teacher` FOREIGN KEY (`ID_teacher`) REFERENCES `teacher` (`ID_teacher`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of group teacher
-- ----------------------------
INSERT INTO `group teacher` VALUES ('1', '1', '1');
INSERT INTO `group teacher` VALUES ('2', '2', '2');
INSERT INTO `group teacher` VALUES ('3', '3', '3');

-- ----------------------------
-- Table structure for student
-- ----------------------------
DROP TABLE IF EXISTS `student`;
CREATE TABLE `student` (
  `ID_student` int(255) NOT NULL AUTO_INCREMENT,
  `Surname` varchar(255) DEFAULT NULL,
  `Name` varchar(255) DEFAULT NULL,
  `Fathername` varchar(255) DEFAULT NULL,
  `ID_group` int(255) DEFAULT NULL,
  `Gender` varchar(255) DEFAULT NULL,
  `Birth_year` date DEFAULT NULL,
  `City` varchar(255) DEFAULT NULL,
  `Telephone` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`ID_student`),
  KEY `FK2_ID_group` (`ID_group`),
  CONSTRAINT `FK2_ID_group` FOREIGN KEY (`ID_group`) REFERENCES `group` (`ID_group`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=13 DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of student
-- ----------------------------
INSERT INTO `student` VALUES ('1', 'Калашников', 'Михаил', 'Витальевич', '1', 'Мужчина', '2000-07-12', 'Пермь', '88826262512');
INSERT INTO `student` VALUES ('2', 'Мишустин', 'Георгий', 'Александрович', '2', 'Мужчина', '2000-06-26', 'Краснодара', '88826268213');
INSERT INTO `student` VALUES ('3', 'Чернышев', 'Кирилл', 'Георгиевич', '3', 'Мужчина', '2000-10-09', 'Калиниграда', '88826268214');
INSERT INTO `student` VALUES ('4', 'Зайцев', 'Филипп', 'Владиславович', '1', 'Мужчина', '2000-11-24', 'Екатеринбург', '88826262315');
INSERT INTO `student` VALUES ('5', 'Жданов', 'Лев', 'Захарович', '2', 'Мужчина', '2000-05-20', 'Самара', '82226329411');
INSERT INTO `student` VALUES ('6', 'Васильев', 'Леонид', 'Ярославович', '3', 'Мужчина', '2000-01-01', 'Псков', '82200004522');
INSERT INTO `student` VALUES ('7', 'Леонов', 'Сергей', 'Артёмович', '1', 'Мужчина', '2000-07-13', 'Тобольск', '82249165033');
INSERT INTO `student` VALUES ('8', 'Панов', 'Андрей', 'Артёмович', '2', 'Мужчина', '2000-02-20', 'Мурманск', '82853354532');
INSERT INTO `student` VALUES ('9', 'Алексеев', 'Константин', 'Максимович', '3', 'Мужчина', '2000-11-15', 'Владивосток', '84563354542');
INSERT INTO `student` VALUES ('10', 'Воробьева', 'Дарья', 'Максимовна', '1', 'Женщина', '2000-03-06', 'Воронеж', '82224952543');
INSERT INTO `student` VALUES ('11', 'Смирнова', 'Милана', 'Матвеевна', '2', 'Женщина', '2000-04-11', 'Казань', '82262454544');
INSERT INTO `student` VALUES ('12', 'Демина', 'Ксения', 'Романовна', '3', 'Женщина', '2000-08-22', 'Тюмень', '82452854511');

-- ----------------------------
-- Table structure for teacher
-- ----------------------------
DROP TABLE IF EXISTS `teacher`;
CREATE TABLE `teacher` (
  `ID_teacher` int(255) NOT NULL AUTO_INCREMENT,
  `Surname` varchar(255) DEFAULT NULL,
  `Name` varchar(255) DEFAULT NULL,
  `Fathername` varchar(255) DEFAULT NULL,
  `Gender` varchar(255) DEFAULT NULL,
  `Birth year` date DEFAULT NULL,
  `City` varchar(255) DEFAULT NULL,
  `Post` varchar(255) DEFAULT NULL,
  `Telephone` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`ID_teacher`),
  CONSTRAINT `FK_ID_teacher` FOREIGN KEY (`ID_teacher`) REFERENCES `authorization` (`ID_teacher`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of teacher
-- ----------------------------
INSERT INTO `teacher` VALUES ('1', 'Жук', 'Денис', 'Васильевич', 'Мужчина', '1991-10-18', 'Пыть-Ях', 'Старший преподаватель', '88005553552');
INSERT INTO `teacher` VALUES ('2', 'Лисейцев', 'Александр', 'Дмитриевич', 'Мужчина', '1992-04-23', 'Ноябрьск', 'Доцент', '88002223648');
INSERT INTO `teacher` VALUES ('3', 'Герасимов', 'Евгений', 'Витальевич', 'Мужчина', '1989-11-23', 'Заводоуковск', 'Профессор', '89345621786');

-- ----------------------------
-- Table structure for theme
-- ----------------------------
DROP TABLE IF EXISTS `theme`;
CREATE TABLE `theme` (
  `ID_theme` int(255) NOT NULL AUTO_INCREMENT,
  `Theme` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`ID_theme`),
  KEY `ID_theme` (`ID_theme`) USING BTREE,
  CONSTRAINT `FK_ID_theme` FOREIGN KEY (`ID_theme`) REFERENCES `evaluation` (`ID_theme`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of theme
-- ----------------------------
INSERT INTO `theme` VALUES ('1', 'Иностранный язык');
INSERT INTO `theme` VALUES ('2', 'Высшая математика');
SET FOREIGN_KEY_CHECKS=1;
