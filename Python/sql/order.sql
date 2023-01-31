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

 Date: 31/01/2023 16:51:11
*/

SET NAMES utf8mb4;
SET FOREIGN_KEY_CHECKS = 0;

-- ----------------------------
-- Table structure for order
-- ----------------------------
DROP TABLE IF EXISTS `order`;
CREATE TABLE `order`  (
  `id` int NOT NULL AUTO_INCREMENT,
  `user_id` int NULL DEFAULT NULL COMMENT 'user.id',
  `module_id` int NULL DEFAULT NULL,
  `payment` int NULL DEFAULT NULL COMMENT '支付金额',
  `effect_date` timestamp NULL DEFAULT NULL COMMENT '授权开始时间',
  `expire_date` timestamp NULL DEFAULT NULL COMMENT '授权结束时间',
  `create_date` timestamp NULL DEFAULT NULL ON UPDATE CURRENT_TIMESTAMP COMMENT '创建日期',
  PRIMARY KEY (`id`) USING BTREE
) ENGINE = InnoDB AUTO_INCREMENT = 5 CHARACTER SET = utf8mb4 COLLATE = utf8mb4_0900_ai_ci ROW_FORMAT = Dynamic;

SET FOREIGN_KEY_CHECKS = 1;
