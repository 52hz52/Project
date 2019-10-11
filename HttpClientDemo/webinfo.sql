/*   dad

 Navicat Premium Data Transfer

 Source Server         : 1212
 Source Server Type    : MySQL
 Source Server Version : 80017
 Source Host           : localhost:3306
 Source Schema         : webinfo

 Target Server Type    : MySQL
 Target Server Version : 80017
 File Encoding         : 65001

 Date: 11/10/2019 10:58:31
*/

SET NAMES utf8mb4;
SET FOREIGN_KEY_CHECKS = 0;

-- ----------------------------
-- Table structure for info
-- ----------------------------
DROP TABLE IF EXISTS `info`;
CREATE TABLE `info`  (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `title` varchar(255) CHARACTER SET utf8 COLLATE utf8_bin NULL DEFAULT NULL,
  `content` varchar(255) CHARACTER SET utf8 COLLATE utf8_bin NULL DEFAULT NULL,
  `url` varchar(255) CHARACTER SET utf8 COLLATE utf8_bin NULL DEFAULT NULL,
  PRIMARY KEY (`id`) USING BTREE
) ENGINE = InnoDB CHARACTER SET = utf8 COLLATE = utf8_bin ROW_FORMAT = Dynamic;

-- ----------------------------
-- Records of info
-- ----------------------------
INSERT INTO `info` VALUES (1, '测试tit', '测试content', NULL);
INSERT INTO `info` VALUES (2, '测试tit', '测试content', '测试url');
INSERT INTO `info` VALUES (3, '千山 - 简洁的网址导航', '退出', '#');
INSERT INTO `info` VALUES (4, '千山 - 简洁的网址导航', '添加千山为主页', '#');
INSERT INTO `info` VALUES (5, '千山 - 简洁的网址导航', '更多站点', '#');
INSERT INTO `info` VALUES (6, '千山 - 简洁的网址导航', '自定义模式', '#');
INSERT INTO `info` VALUES (7, '千山 - 简洁的网址导航', '快捷键', '#');
INSERT INTO `info` VALUES (8, '千山 - 简洁的网址导航', '关于', '#');
INSERT INTO `info` VALUES (9, '千山 - 简洁的网址导航', '常用·工作', '#');
INSERT INTO `info` VALUES (10, '千山 - 简洁的网址导航', '百度', 'http://www.baidu.com');
INSERT INTO `info` VALUES (11, '千山 - 简洁的网址导航', '谷歌', 'http://www.google.com');
INSERT INTO `info` VALUES (12, '千山 - 简洁的网址导航', '网页版微信', 'http://wx.qq.com');
INSERT INTO `info` VALUES (13, '千山 - 简洁的网址导航', '印象笔记', 'http://app.yinxiang.com/Home.action');
INSERT INTO `info` VALUES (14, '千山 - 简洁的网址导航', 'QQ邮箱', 'http://mail.qq.com');
INSERT INTO `info` VALUES (15, '千山 - 简洁的网址导航', 'Gmail', 'http://gmail.com');
INSERT INTO `info` VALUES (16, '千山 - 简洁的网址导航', '网易', 'http://www.163.com');
INSERT INTO `info` VALUES (17, '千山 - 简洁的网址导航', '豆瓣电台', 'http://douban.fm');
INSERT INTO `info` VALUES (18, '千山 - 简洁的网址导航', '有道词典', 'http://dict.youdao.com');
INSERT INTO `info` VALUES (19, '千山 - 简洁的网址导航', '常用·社交', '#');
INSERT INTO `info` VALUES (20, '千山 - 简洁的网址导航', '知乎', 'http://www.zhihu.com');
INSERT INTO `info` VALUES (21, '千山 - 简洁的网址导航', '微博', 'http://weibo.com');
INSERT INTO `info` VALUES (22, '千山 - 简洁的网址导航', '豆瓣', 'http://www.douban.com');
INSERT INTO `info` VALUES (23, '千山 - 简洁的网址导航', '雪球', 'http://www.xueqiu.com');
INSERT INTO `info` VALUES (24, '千山 - 简洁的网址导航', '水木社区', 'http://www.newsmth.net');
INSERT INTO `info` VALUES (25, '千山 - 简洁的网址导航', '简书', 'http://www.jianshu.com');
INSERT INTO `info` VALUES (26, '千山 - 简洁的网址导航', '虎扑', 'http://www.hupu.com');
INSERT INTO `info` VALUES (27, '千山 - 简洁的网址导航', 'Chiphell', 'http://www.chiphell.com');
INSERT INTO `info` VALUES (28, '千山 - 简洁的网址导航', 'V2EX', 'http://www.v2ex.com');
INSERT INTO `info` VALUES (29, '千山 - 简洁的网址导航', '常用·生活', '#');
INSERT INTO `info` VALUES (30, '千山 - 简洁的网址导航', '淘宝', 'http://www.taobao.com');
INSERT INTO `info` VALUES (31, '千山 - 简洁的网址导航', '什么值得买', 'http://www.smzdm.com');
INSERT INTO `info` VALUES (32, '千山 - 简洁的网址导航', '新浪', 'http://www.sina.com.cn');
INSERT INTO `info` VALUES (33, '千山 - 简洁的网址导航', '支付宝', 'http://www.alipay.com');
INSERT INTO `info` VALUES (34, '千山 - 简洁的网址导航', '美团', 'http://www.meituan.com');
INSERT INTO `info` VALUES (35, '千山 - 简洁的网址导航', '大众点评', 'http://www.dianping.com');
INSERT INTO `info` VALUES (36, '千山 - 简洁的网址导航', 'Bilibili', 'http://www.bilibili.com');
INSERT INTO `info` VALUES (37, '千山 - 简洁的网址导航', 'Acfun', 'http://www.acfun.tv');
INSERT INTO `info` VALUES (38, '千山 - 简洁的网址导航', '网易云音乐', 'http://music.163.com');
INSERT INTO `info` VALUES (39, '千山 - 简洁的网址导航', '新闻', '#');
INSERT INTO `info` VALUES (40, '千山 - 简洁的网址导航', '百度新闻', 'http://news.baidu.com');
INSERT INTO `info` VALUES (41, '千山 - 简洁的网址导航', 'FT中文网', 'http://www.ftchinese.com');
INSERT INTO `info` VALUES (42, '千山 - 简洁的网址导航', '东方财富网', 'http://www.eastmoney.com/');
INSERT INTO `info` VALUES (43, '千山 - 简洁的网址导航', '36氪', 'http://www.36kr.com');
INSERT INTO `info` VALUES (44, '千山 - 简洁的网址导航', '虎嗅', 'http://www.huxiu.com');
INSERT INTO `info` VALUES (45, '千山 - 简洁的网址导航', '澎湃新闻', 'http://www.thepaper.cn');
INSERT INTO `info` VALUES (46, '千山 - 简洁的网址导航', '华尔街见闻', 'http://wallstreetcn.com');
INSERT INTO `info` VALUES (47, '千山 - 简洁的网址导航', '新浪娱乐', 'http://ent.sina.com.cn');
INSERT INTO `info` VALUES (48, '千山 - 简洁的网址导航', '汽车之家', 'http://www.autohome.com.cn');
INSERT INTO `info` VALUES (49, '千山 - 简洁的网址导航', '视频', '#');
INSERT INTO `info` VALUES (50, '千山 - 简洁的网址导航', '优酷', 'http://www.youku.com');
INSERT INTO `info` VALUES (51, '千山 - 简洁的网址导航', '爱奇艺', 'http://www.iqiyi.com');
INSERT INTO `info` VALUES (52, '千山 - 简洁的网址导航', '搜狐视频', 'http://tv.sohu.com');
INSERT INTO `info` VALUES (53, '千山 - 简洁的网址导航', '腾讯视频', 'http://v.qq.com');
INSERT INTO `info` VALUES (54, '千山 - 简洁的网址导航', '乐视', 'http://www.letv.com');
INSERT INTO `info` VALUES (55, '千山 - 简洁的网址导航', 'PPTV', 'http://www.pptv.com');
INSERT INTO `info` VALUES (56, '千山 - 简洁的网址导航', '斗鱼TV', 'http://www.douyutv.com');
INSERT INTO `info` VALUES (57, '千山 - 简洁的网址导航', '战旗TV', 'http://www.zhanqi.tv');
INSERT INTO `info` VALUES (58, '千山 - 简洁的网址导航', '湖南卫视', 'http://www.hunantv.com');
INSERT INTO `info` VALUES (59, '千山 - 简洁的网址导航', '购物', '#');
INSERT INTO `info` VALUES (60, '千山 - 简洁的网址导航', '淘宝', 'http://www.taobao.com');
INSERT INTO `info` VALUES (61, '千山 - 简洁的网址导航', '天猫', 'http://www.tmall.com');
INSERT INTO `info` VALUES (62, '千山 - 简洁的网址导航', '京东', 'http://www.jd.com');
INSERT INTO `info` VALUES (63, '千山 - 简洁的网址导航', '亚马逊', 'http://z.cn');
INSERT INTO `info` VALUES (64, '千山 - 简洁的网址导航', '当当', 'http://www.dangdang.com');
INSERT INTO `info` VALUES (65, '千山 - 简洁的网址导航', '唯品会', 'http://www.vip.com');
INSERT INTO `info` VALUES (66, '千山 - 简洁的网址导航', '苏宁易购', 'http://www.suning.com');
INSERT INTO `info` VALUES (67, '千山 - 简洁的网址导航', '一号店', 'http://www.yhd.com');
INSERT INTO `info` VALUES (68, '千山 - 简洁的网址导航', '小米网', 'http://www.mi.com');
INSERT INTO `info` VALUES (69, '千山 - 简洁的网址导航', '发现', '#');
INSERT INTO `info` VALUES (70, '千山 - 简洁的网址导航', '网易公开课', 'http://open.163.com');
INSERT INTO `info` VALUES (71, '千山 - 简洁的网址导航', '果壳', 'http://www.guokr.com');
INSERT INTO `info` VALUES (72, '千山 - 简洁的网址导航', '暴走漫画', 'http://baozoumanhua.com');
INSERT INTO `info` VALUES (73, '千山 - 简洁的网址导航', 'Lofter', 'http://www.lofter.com');
INSERT INTO `info` VALUES (74, '千山 - 简洁的网址导航', 'NEXT', 'http://next.36kr.com');
INSERT INTO `info` VALUES (75, '千山 - 简洁的网址导航', 'Zealer', 'http://www.zealer.com');
INSERT INTO `info` VALUES (76, '千山 - 简洁的网址导航', 'IT桔子', 'http://itjuzi.com');
INSERT INTO `info` VALUES (77, '千山 - 简洁的网址导航', '格瓦拉', 'http://www.gewara.com');
INSERT INTO `info` VALUES (78, '千山 - 简洁的网址导航', '富途证券', 'http://www.futu5.com');
INSERT INTO `info` VALUES (79, '千山 - 简洁的网址导航', '商旅', '#');
INSERT INTO `info` VALUES (80, '千山 - 简洁的网址导航', '穷游', 'http://www.qyer.com');
INSERT INTO `info` VALUES (81, '千山 - 简洁的网址导航', '蚂蜂窝', 'http://www.mafengwo.cn');
INSERT INTO `info` VALUES (82, '千山 - 简洁的网址导航', '面包旅行', 'http://www.breadtrip.com');
INSERT INTO `info` VALUES (83, '千山 - 简洁的网址导航', '去哪', 'http://www.qunar.com');
INSERT INTO `info` VALUES (84, '千山 - 简洁的网址导航', '携程', 'http://www.ctrip.com');
INSERT INTO `info` VALUES (85, '千山 - 简洁的网址导航', '天巡', 'http://www.tianxun.com');
INSERT INTO `info` VALUES (86, '千山 - 简洁的网址导航', 'Booking', 'http://www.booking.com');
INSERT INTO `info` VALUES (87, '千山 - 简洁的网址导航', 'Airbnb', 'http://zh.airbnb.com');
INSERT INTO `info` VALUES (88, '千山 - 简洁的网址导航', '神州租车', 'http://www.zuche.com');
INSERT INTO `info` VALUES (89, '千山 - 简洁的网址导航', '银行', '#');
INSERT INTO `info` VALUES (90, '千山 - 简洁的网址导航', '招商银行', 'http://www.cmbchina.com');
INSERT INTO `info` VALUES (91, '千山 - 简洁的网址导航', '工商银行', 'http://www.icbc.com.cn');
INSERT INTO `info` VALUES (92, '千山 - 简洁的网址导航', '建设银行', 'http://www.ccb.com');
INSERT INTO `info` VALUES (93, '千山 - 简洁的网址导航', '农业银行', 'http://www.abchina.com');
INSERT INTO `info` VALUES (94, '千山 - 简洁的网址导航', '中国银行', 'http://www.boc.cn');
INSERT INTO `info` VALUES (95, '千山 - 简洁的网址导航', '交通银行', 'http://www.bankcomm.com');
INSERT INTO `info` VALUES (96, '千山 - 简洁的网址导航', '广发银行', 'http://www.cgbchina.com.cn');
INSERT INTO `info` VALUES (97, '千山 - 简洁的网址导航', '民生银行', 'http://www.cmbc.com.cn');
INSERT INTO `info` VALUES (98, '千山 - 简洁的网址导航', '平安银行', 'http://bank.pingan.com');
INSERT INTO `info` VALUES (99, '千山 - 简洁的网址导航', 'Chrome', 'http://www.google.cn/chrome/browser/');
INSERT INTO `info` VALUES (100, '千山 - 简洁的网址导航', '搜狗', 'http://ie.sogou.com/');
INSERT INTO `info` VALUES (101, '千山 - 简洁的网址导航', '猎豹浏览器', 'http://www.liebao.cn/download.html');
INSERT INTO `info` VALUES (102, '千山 - 简洁的网址导航', '安装千山Chrome插件', '#');
INSERT INTO `info` VALUES (103, '千山 - 简洁的网址导航', '在新标签页中自定义', '#');
INSERT INTO `info` VALUES (104, '千山 - 简洁的网址导航', '我使用的不是Chrome，在当前页面自定义', '#');
INSERT INTO `info` VALUES (105, '千山 - 简洁的网址导航', '安装千山Chrome插件', '#');

SET FOREIGN_KEY_CHECKS = 1;
