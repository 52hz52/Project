/*
 Navicat Premium Data Transfer

 Source Server         : 1212
 Source Server Type    : MySQL
 Source Server Version : 80017
 Source Host           : localhost:3306
 Source Schema         : bookdb

 Target Server Type    : MySQL
 Target Server Version : 80017
 File Encoding         : 65001

 Date: 19/09/2019 16:59:15
*/

SET NAMES utf8mb4;
SET FOREIGN_KEY_CHECKS = 0;

-- ----------------------------
-- Table structure for book_info
-- ----------------------------
DROP TABLE IF EXISTS `book_info`;
CREATE TABLE `book_info`  (
  `no` int(11) NOT NULL AUTO_INCREMENT COMMENT '编号',
  `name` varchar(255) CHARACTER SET utf8 COLLATE utf8_bin NULL DEFAULT NULL COMMENT '书名',
  `photo` varchar(255) CHARACTER SET utf8 COLLATE utf8_bin NULL DEFAULT NULL COMMENT '图片',
  `author` varchar(255) CHARACTER SET utf8 COLLATE utf8_bin NULL DEFAULT NULL COMMENT '作者',
  `house` varchar(255) CHARACTER SET utf8 COLLATE utf8_bin NULL DEFAULT NULL COMMENT '出版社',
  `time` varchar(255) CHARACTER SET utf8 COLLATE utf8_bin NULL DEFAULT NULL COMMENT '出版时间',
  `bookinfo` varchar(255) CHARACTER SET utf8 COLLATE utf8_bin NULL DEFAULT NULL COMMENT '书籍详情',
  `price` double(10, 2) NULL DEFAULT NULL COMMENT '价格',
  `disprice` double(10, 2) NULL DEFAULT NULL COMMENT '折扣价',
  `booktype` int(255) NULL DEFAULT NULL COMMENT '书的类型',
  `attribute` int(255) NULL DEFAULT NULL COMMENT '属性',
  PRIMARY KEY (`no`) USING BTREE
) ENGINE = InnoDB AUTO_INCREMENT = 21 CHARACTER SET = utf8 COLLATE = utf8_bin ROW_FORMAT = Dynamic;

-- ----------------------------
-- Records of book_info
-- ----------------------------
INSERT INTO `book_info` VALUES (1, '私募（首部披露资本博弈秘密的金融小说）', 'img/book_love/8.jpg', '郭现杰', '花山文艺出版社', '2009-08', '数年前，在一次股市的多、空之战中，以赵云狄、林康为首的私募基金—金鼎投资，和以王雨龙为首的私募基金，达成锁仓协议分食利益。殊料，以王雨龙为首的私募基金—鑫利投资背信弃义，导致金鼎投资惨败。以至...', 32.00, 18.90, 4, 9);
INSERT INTO `book_info` VALUES (2, '圈子圈套.1.战局篇', 'img/book_love/9.jpg', '王强', '清华大学出版社', '2006-01', '虽然没有硝烟，却比战场更血腥；虽然并未战死，却比死亡更痛苦。 洪钧从一个底层的销售人员，成为一家著名的跨国公司的中国区代理首席代表，在即将被扶正，事业情感都志得意满的时候，掉入俞威设计的圈套，...', 28.00, 19.10, 6, NULL);
INSERT INTO `book_info` VALUES (3, '\r\n饕餮（最真实的商场高端博弈小说）', 'img/book_love/10.jpg', '韦帕', '国际文化出版公司', '2009-07', '北京，六百公里处，有宝地，233亩，土地价值2.5亿，总投资额近八亿，利润近三亿。　　项目吸引了众多北京房地产商目光，其中最贪婪的一道目光，来自顾忱。但顾忱，总资产不过千万！想拿项目，无异于“空手套...', 32.00, 23.60, 2, 9);
INSERT INTO `book_info` VALUES (4, '圈子圈套 迷局篇2：职场商战三部曲', 'img/book_love/11.jpg', '王强', '清华大学出版社', '2006-08', '《圈子圈套2・迷局篇》是“圈子圈套三部曲”的第二部。 职场风云再起。洪钧出任维西尔中国区总经理，他和俞威之间的较量又或明或暗地展开来，面对内部的纷争和商场上的尔虞我诈，他该如何出招……俞威依...', 28.00, 16.00, 6, NULL);
INSERT INTO `book_info` VALUES (5, '圈子圈套3.终局篇（附赠王强演讲光盘）', 'img/book_love/12.jpg', '王强', '清华大学出版社', '2007-10', '本书全景展示了商场和职场的生死厮杀、巅峰对决。主人公的命运、项目结局、所有的爱恨情仇都在本书中揭开谜底。 再次陷入低谷的洪钧在内忧外患中不甘消沉，在职场上和自己的上司明争暗斗，在商场上则和夙...', 32.00, 18.90, 6, NULL);
INSERT INTO `book_info` VALUES (6, '倾城之恋', 'img/book_love/1.jpg', '张爱玲', '北京十月文艺出版社', '2006-12', '白流苏和范柳原这一对现实庸俗的男女，在战争的兵荒马乱之中被命运掷骰子般地掷到了一起，于“一刹那”体会到了“一对平凡的夫妻”之间的“一点真心”。', 29.80, 25.00, 1, 9);
INSERT INTO `book_info` VALUES (7, '情人', 'img/book_love/2.jpg', '马格利特杜拉斯', '花山文艺出版社', '1984', '小说从不同的视角揭示了现代法国社会中男女对性爱的感悟和反思，折射出西方世界感情生活的不同侧面。是一部带有自传色彩的作品，以法国殖民者在越南的生活为背景，描写了一名贫穷的法国少女与富有的华裔少爷之间深沉而无望的爱情，笔触深达人性中某些最根本、最隐秘的特质，催人深思', 39.90, 30.00, 1, 9);
INSERT INTO `book_info` VALUES (8, '荆棘鸟', 'img/book_love/3.jpg', '考林麦卡洛', ' 译林出版社', '1977', '荆棘鸟》是澳大利亚当代作家考琳·麦卡洛创作的一部长篇小说。该作以女主人公梅吉和神父拉尔夫的爱情纠葛为主线，描写了克利里一家三代人的故事，时间跨度长达半个多世纪。', 25.00, 20.00, 1, 9);
INSERT INTO `book_info` VALUES (9, '挪威的森林', 'img/book_love/4.jpg', '村上春树', '宁夏人民出版社', '1987', '故事讲述主角纠缠在情绪不稳定且患有精神疾病的直子和开朗活泼的小林绿子之间，展开了自我成长的旅程。\r\n自该书在日本问世，截止2012年在日本共销出1500余万册', 40.50, 40.00, 1, 9);
INSERT INTO `book_info` VALUES (10, '失乐园', 'img/book_love/5.jpg', '渡边淳一', '现代出版社', '1667', '失乐园》是英国政治家、学者约翰·弥尔顿创作的史诗。《失乐园》讲述诗中叛逆之神撒旦，因为反抗上帝的权威被打入地狱，却毫不屈服，为复仇寻至伊甸园。亚当与夏娃受被撒旦附身的蛇的引诱，偷吃了上帝明令禁吃的知识树上的果子。最终，撒旦及其同伙遭谴全变成了蛇，亚当与夏娃被逐出了伊甸园。', 22.00, 18.90, 1, 9);
INSERT INTO `book_info` VALUES (11, '男人这东西', 'img/book_love/6.jpg', '渡边淳一', '文化艺术出版社', '2004-02', '作者从自身的感性经验出发，以医学和心理学作为理论基础，详尽剖析了男性从少年期到壮年期的生理与心理发展历程，他们在社会角色与情感生活中所呈现的与生俱来的优势与弱点，以及因此而导致的两性在价值观、情爱观上的歧异和冲突，旨在帮助男性更正确地认识自己、女性更深入地了解男人。', 35.00, 30.00, 1, 9);
INSERT INTO `book_info` VALUES (12, '第二性', 'img/book_love/7.jpg', '西蒙波德伏娃', '现代出版社', '2014-11', '《第二性》是台湾女歌手蔡依林演唱的一首歌曲，由陈绮贞填词、陈绮贞作曲。收录在蔡依林2014年11月15日发行专辑《呸》中。创意源自1949年西蒙波娃创作的一部存在主义和女性主义的散文名著，传达“新女性力量”。', 30.00, 20.00, 1, 9);
INSERT INTO `book_info` VALUES (13, '博士的爱情算式', 'img/book_love/13.jpg', '小川洋子 ', '人民文学出版社', '2005-7', '他的记忆只能维持80分钟，一旦超过这个时间，他的记忆就自动归零，重新开始，所以即便再快乐的时光，他也不会记得。他永远不记得我是他的保姆，不会记得他为我的儿子取名为“平方根”。然而博士却用一个简单的数学公式，验证了爱的永恒。', 17.00, 17.00, 1, 9);
INSERT INTO `book_info` VALUES (14, '我在三十岁的第一年', 'img/book_love/14.jpg', '毛利', '四川文艺出版社', '2018-01', '都市白领陈苏，努力奋斗到三十岁，唯一拥有的技能是用“海明威”撩汉子。她渴望真爱，却经历无数“狗血”：一身少爷病的前男友，不缺钱还很努力的90后“高富帅”，与现代文明格格不入的相亲对象……难道女人上了年纪，连爱的资格都要随时间流逝？', 39.00, 35.00, 1, 9);
INSERT INTO `book_info` VALUES (15, '爱情的边疆', 'img/book_love/15.jpg', '毛卫宁', '花山文艺出版社', '2018-03', '20世纪50年代末，北京广播学院女大学生文艺秋爱上苏联功勋播音员维卡，并与之在北京结婚。苏联撤走专家后，维卡被迫离开中国。而文艺秋自愿来到边境城市黑河工作，担任电台播音员，就是为了离维卡近一些。后来，维卡也来到黑河对岸的布拉戈维申斯克担任播音员，他俩竟然通过倾听对方广播的声音抚慰痛楚，倾诉思念。', 35.00, 28.00, 1, 9);
INSERT INTO `book_info` VALUES (16, '我们连孤独都不曾拥有', 'img/book_love/16.jpg', '七毛', '九州出版社', '2017-10', '本书是作者七毛首部短篇小说集，里面收录了25个小人物的故事。在七毛笔下，好像用力过哪种人生，都是无力的。众生各怀心事，各生喜悲，直到走向自己安排好的终点。', 20.00, 18.00, 1, 9);
INSERT INTO `book_info` VALUES (17, '愿你迷路到我身旁', 'img/book_love/17.jpg', '蕊希', '百花洲文艺出版社 ', '2017-05', '愿你相信，就算路遥车远，也总有人陪你一起。', 45.00, 40.00, 1, 9);
INSERT INTO `book_info` VALUES (18, '尼罗河上的惨案', 'img/book_love/18.jpg', '阿加莎·克里斯蒂 ', '新星出版社', '2013-09', '拥有巨大财富的林内特小姐（洛伊丝·奇利斯饰）同新婚丈夫西蒙（西蒙·麦克金代尔饰）一起登上了“卡纳克号”游艇，继续她的蜜月旅行。但是当游船在迷人的尼罗河溯江而上的时候，在一个不平静的夜晚，年轻、美丽又有钱的林内特在睡梦中遭到枪杀，她的头部中了一枪，而且是致命的一枪，桌上那条价值五万英镑的项链同时也不翼而飞了。', 38.00, 35.00, 1, 9);
INSERT INTO `book_info` VALUES (19, '好久不见，秦先生', 'img/book_love/19.jpg', '蕊希', '江苏凤凰文艺出版社', '2015-01', '苏念锦在遇见秦子阳前，从未想过，有一天，她会与传说中的男神有任何交集', 48.00, 40.00, 1, 9);
INSERT INTO `book_info` VALUES (20, '微微一笑很倾城', 'img/book_love/20.jpg', '顾漫', '花山文艺出版社', '2014-08', '庆大计算机系系花学霸贝微微与校草级大神师哥肖奈偶然间在网络游戏中相识，并在现实中见面，因而相知相恋最后走到一起的故事。', 40.00, 40.00, 1, 9);

-- ----------------------------
-- Table structure for book_order
-- ----------------------------
DROP TABLE IF EXISTS `book_order`;
CREATE TABLE `book_order`  (
  `orderNo` int(11) NOT NULL COMMENT '订单编号',
  `uid` int(255) NULL DEFAULT NULL COMMENT '购买用户编号',
  `buyGoods` varchar(255) CHARACTER SET utf8 COLLATE utf8_bin NULL DEFAULT NULL COMMENT '购买商品 存储商品id集合',
  `orderTime` datetime(0) NULL DEFAULT NULL COMMENT '订单时间',
  `payTime` datetime(0) NULL DEFAULT NULL COMMENT '支付时间',
  `sumMoney` varchar(255) CHARACTER SET utf8 COLLATE utf8_bin NULL DEFAULT NULL COMMENT '支付金额',
  `orderState` int(255) NULL DEFAULT NULL COMMENT '订单状态 ---订单状态表',
  `orderNotes` varchar(255) CHARACTER SET utf8 COLLATE utf8_bin NULL DEFAULT NULL COMMENT '订单注释',
  PRIMARY KEY (`orderNo`) USING BTREE
) ENGINE = InnoDB CHARACTER SET = utf8 COLLATE = utf8_bin ROW_FORMAT = Dynamic;

-- ----------------------------
-- Table structure for book_order_state
-- ----------------------------
DROP TABLE IF EXISTS `book_order_state`;
CREATE TABLE `book_order_state`  (
  `id` int(11) NULL DEFAULT NULL,
  `state` varchar(255) CHARACTER SET utf8 COLLATE utf8_bin NULL DEFAULT NULL
) ENGINE = InnoDB CHARACTER SET = utf8 COLLATE = utf8_bin ROW_FORMAT = Dynamic;

-- ----------------------------
-- Records of book_order_state
-- ----------------------------
INSERT INTO `book_order_state` VALUES (0, '已收货');
INSERT INTO `book_order_state` VALUES (1, '待发货');
INSERT INTO `book_order_state` VALUES (2, '邮递中');
INSERT INTO `book_order_state` VALUES (3, '待收货');

-- ----------------------------
-- Table structure for book_type
-- ----------------------------
DROP TABLE IF EXISTS `book_type`;
CREATE TABLE `book_type`  (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `type` varchar(255) CHARACTER SET utf8 COLLATE utf8_bin NULL DEFAULT NULL,
  PRIMARY KEY (`id`) USING BTREE
) ENGINE = InnoDB CHARACTER SET = utf8 COLLATE = utf8_bin ROW_FORMAT = Dynamic;

-- ----------------------------
-- Records of book_type
-- ----------------------------
INSERT INTO `book_type` VALUES (1, '爱情');
INSERT INTO `book_type` VALUES (2, '悬疑');
INSERT INTO `book_type` VALUES (3, '科幻');
INSERT INTO `book_type` VALUES (4, '金融');
INSERT INTO `book_type` VALUES (5, '都市生活');
INSERT INTO `book_type` VALUES (6, '历史');
INSERT INTO `book_type` VALUES (7, '经典');
INSERT INTO `book_type` VALUES (8, '二次元');
INSERT INTO `book_type` VALUES (9, '上升榜');
INSERT INTO `book_type` VALUES (10, '收藏榜');

-- ----------------------------
-- Table structure for book_user
-- ----------------------------
DROP TABLE IF EXISTS `book_user`;
CREATE TABLE `book_user`  (
  `id` int(11) UNSIGNED NOT NULL AUTO_INCREMENT,
  `name` varchar(255) CHARACTER SET utf8 COLLATE utf8_bin NULL DEFAULT NULL,
  `email` varchar(255) CHARACTER SET utf8 COLLATE utf8_bin NULL DEFAULT NULL,
  `phone` varchar(255) CHARACTER SET utf8 COLLATE utf8_bin NULL DEFAULT NULL,
  `password` varchar(255) CHARACTER SET utf8 COLLATE utf8_bin NULL DEFAULT NULL,
  `photo` varchar(255) CHARACTER SET utf8 COLLATE utf8_bin NULL DEFAULT NULL,
  `address` varchar(255) CHARACTER SET utf8 COLLATE utf8_bin NULL DEFAULT NULL,
  PRIMARY KEY (`id`) USING BTREE
) ENGINE = InnoDB AUTO_INCREMENT = 5 CHARACTER SET = utf8 COLLATE = utf8_bin ROW_FORMAT = Dynamic;

-- ----------------------------
-- Records of book_user
-- ----------------------------
INSERT INTO `book_user` VALUES (1, 'tom', 'tom@163.com', '13444444444', 'tom', 'img/user.png', '武汉江夏大道xx号');
INSERT INTO `book_user` VALUES (2, '123', '123@163.com', '17683916147', '123', 'img/user1.png', '湖北襄阳襄城区欧庙x');
INSERT INTO `book_user` VALUES (3, 'jack', NULL, NULL, '123', NULL, NULL);
INSERT INTO `book_user` VALUES (4, '52hz', '52hz@163.com', '12312312312', '123', NULL, NULL);

SET FOREIGN_KEY_CHECKS = 1;
