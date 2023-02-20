/*
 Navicat Premium Data Transfer

 Source Server         : 192.168.31.133_3306
 Source Server Type    : MySQL
 Source Server Version : 80028
 Source Host           : xc213618.ddns.me:3306
 Source Schema         : grid

 Target Server Type    : MySQL
 Target Server Version : 80028
 File Encoding         : 65001

 Date: 01/02/2023 19:54:39
*/

SET NAMES utf8mb4;
SET FOREIGN_KEY_CHECKS = 0;

-- ----------------------------
-- Table structure for serial-number
-- ----------------------------
DROP TABLE IF EXISTS `serial-number`;
CREATE TABLE `serial-number`  (
  `id` int NOT NULL AUTO_INCREMENT,
  `sn` char(24) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NULL DEFAULT NULL,
  `vendor_id` int NULL DEFAULT NULL,
  `module_id` int NULL DEFAULT NULL,
  `effect_months` timestamp NULL DEFAULT NULL,
  `create_date` timestamp NULL DEFAULT NULL,
  PRIMARY KEY (`id`) USING BTREE
) ENGINE = InnoDB CHARACTER SET = utf8mb4 COLLATE = utf8mb4_0900_ai_ci ROW_FORMAT = Dynamic;

SET FOREIGN_KEY_CHECKS = 1;
