CREATE DATABASE BMS
GO
USE BMS

CREATE TABLE [dbo].[userType]
(
	[tName] NVARCHAR(10) PRIMARY KEY,
	[tMaxDay] INT NOT NULL CHECK(tMaxDay > 0),
	[tMaxNum] INT NOT NULL CHECK(tMaxNum > 0)
);

CREATE TABLE [dbo].[theUser]
(
	[uHeadPic] NVARCHAR(1000) NOT NULL DEFAULT('..\\..\\图片\\默认用户头像\\moren.png'),
	[uID] NVARCHAR(10) PRIMARY KEY CHECK(LEN(uID) = 10),
	[uPW] NVARCHAR(20) NOT NULL,
	[uType] NVARCHAR(10) REFERENCES userType(tName),
	[uName] NVARCHAR(20) NOT NULL,
	[uSex] BIT NOT NULL DEFAULT(1),
	[uInstitute] NVARCHAR(2) NOT NULL CHECK(LEN(uInstitute) = 2),
	[uClassName] NVARCHAR(5) NOT NULL CHECK(LEN(uClassName) = 5),
	[uSFID] NVARCHAR(18) CHECK(LEN(uSFID) = 18 OR LEN(uSFID) = 0),
	[uTelephone] NVARCHAR(11) CHECK(LEN(uTelephone) = 11 OR LEN(uTelephone) = 0),
	[uEmail] NVARCHAR(50),
	[uErrorCnt] INT NOT NULL DEFAULT(0)
);

CREATE TABLE [dbo].[recent]
(
	[rID] NVARCHAR(10) NOT NULL REFERENCES theUser(uID),
	[rRememPW] BIT NOT NULL DEFAULT(0),
	[rAutoLogin] BIT NOT NULL DEFAULT(0),
	[rInsertTime] DATETIME NOT NULL DEFAULT(GETDATE())
);

CREATE TABLE [dbo].[activeUser]
(
	[auID] NVARCHAR(10) REFERENCES theUser(uID),
	[auTime] INT,
	[auCount] INT NOT NULL DEFAULT(0),
	PRIMARY KEY(auID, auTime)
);

--------------------------------------------------------------

create table [dbo].[booktype]
(
	[bCategory] NVARCHAR(20) NOT NULL ,
	[bNo] INT primary key
);

CREATE TABLE [dbo].[Book]
(
	[bISBN] NVARCHAR(17) PRIMARY KEY CHECK(LEN(bISBN) = 17),
	[bName] NVARCHAR(20) NOT NULL,
	[bAuthor] NVARCHAR(20),
	[bCategory] NVARCHAR(20) NOT NULL,
	[bTableNumber] NVARCHAR(20) NOT NULL UNIQUE,
	[bCollectBooks] INT NOT NULL CHECK(bCollectBooks >= 0),
	[bStandingCrop] INT NOT NULL CHECK(bStandingCrop >= 0 ),
	[bPubCompany] NVARCHAR(20),
	[bPubDate] DATE CHECK(bPubDate <= GETDATE()),
	[bPrice] DECIMAL CHECK(bPrice >= 0),
	[bIntroduction] NVARCHAR(200),
	[bType]  NVARCHAR(20) NOT NULL,
	CHECK(bCollectBooks >= bStandingCrop)
);

CREATE TABLE [dbo].[activeBook]
(
	[abISBN] NVARCHAR(17) REFERENCES Book(bISBN),
	[abTime] NVARCHAR(6) CHECK(LEN(abTime) = 6),
	[abCount] INT DEFAULT(0),
	[abName] NCHAR(10)
);

CREATE TABLE [dbo].[Loan]
(
	[uID] NVARCHAR(10) CHECK(LEN(uID) = 10),
	[bISBN] NVARCHAR(17)CHECK(LEN(bISBN) = 17),
	[loanDate] DATE NOT NULL CHECK(loanDate <= GETDATE()),
	[isReBorrow] BIT NOT NULL DEFAULT(0),
	[num] INT,
	PRIMARY KEY(uID, bISBN),
	FOREIGN KEY(uID) REFERENCES theUser(uID),
	FOREIGN KEY(bISBN) REFERENCES Book(bISBN)
);


CREATE VIEW libMana
AS SELECT uHeadPic, uID, uPW, uName, uSex, uClassName, uSFID, uTelephone, uEmail, uErrorCnt
FROM theUser
WHERE uType = '图管' AND  uInstitute = '图管'
WITH CHECK OPTION;

CREATE VIEW reader
AS SELECT uHeadPic, uID, uPW, uType, uName, uSex, uInstitute, uClassName, uSFID, uTelephone, uEmail, uErrorCnt
FROM theUser
WHERE uType != '图管' AND uType != '系管'
WITH CHECK OPTION;

CREATE VIEW UserToLoan
AS SELECT uID, uType, uName, uSex, uInstitute, uClassName, tMaxDay, tMaxNum
FROM theUser, userType
WHERE uType = tName
WITH CHECK OPTION;


--删除记录
DELETE FROM Loan;
DELETE FROM recent;
DELETE FROM activeUser;
DELETE FROM theUser;
DELETE FROM userType;
DELETE FROM activeBook;
DELETE FROM Book;
DELETE FROM booktype;

--用户类别表插入数据
INSERT INTO userType VALUES('系管', 100000000, 100000000);
INSERT INTO userType VALUES('图管', 100000000, 100000000);
INSERT INTO userType VALUES('学士', 30, 6);
INSERT INTO userType VALUES('硕士', 60, 9);
INSERT INTO userType VALUES('博士', 90, 12);

--用户表插入数据
INSERT INTO theUser VALUES('..\..\图片\默认用户头像\a.jpg', '1704040213', '213', '系管', '卢宪涛', 1, '信息', '计算172', '370123199808134512', '15005417245', '2394226065@qq.com', 0);
INSERT INTO theUser VALUES('..\..\图片\默认用户头像\b.jpg', '1709030227', '227', '系管', '杨希洪', 1, '信息', '计算172', '379963199808134513', '15053444545', '815764965@qq.com', 0);
INSERT INTO theUser VALUES('..\..\图片\默认用户头像\c.jpg', '1700000001', '001', '图管', '黄家月', 0, '信息', '计算171', '397554199808134514', '15546554655', '2385822505@qq.com', 0);
INSERT INTO theUser VALUES('..\..\图片\默认用户头像\d.jpg', '1700000002', '002', '学士', '李佳琪', 0, '信息', '计算171', '387566199808134515', '15054424545', '2395525205@qq.com', 0);
INSERT INTO theUser VALUES('..\..\图片\默认用户头像\e.jpg', '1700000003', '003', '学士', '黄浩  ', 1, '信息', '信息172', '370134199808134512', '15542555245', '2315525535@qq.com', 0);
INSERT INTO theUser VALUES('..\..\图片\默认用户头像\f.jpg', '1700000004', '004', '学士', '李月  ', 0, '材料', '金属172', '373523199808134512', '18525525245', '2378585885@qq.com', 0);
INSERT INTO theUser VALUES('..\..\图片\默认用户头像\g.jpg', '1700000005', '005', '学士', '范子瑞', 1, '材料', '金属172', '376753199808134512', '15855252555', '2338688505@qq.com', 0);
INSERT INTO theUser VALUES('..\..\图片\默认用户头像\h.jpg', '1700000006', '006', '学士', '韩广阳', 1, '材料', '金属171', '987723199808134512', '15255424245', '2395974595@qq.com', 0);
INSERT INTO theUser VALUES('..\..\图片\默认用户头像\i.jpg', '1700000007', '007', '学士', '李一楠', 1, '材料', '金属171', '786663199808134512', '15058682245', '2359747205@qq.com', 0);
INSERT INTO theUser VALUES('..\..\图片\默认用户头像\j.jpg', '1700000008', '008', '硕士', '吕正芃', 1, '材料', '材物171', '987978199408134512', '15858252525', '2467945765@qq.com', 0);
INSERT INTO theUser VALUES('..\..\图片\默认用户头像\k.jpg', '1700000009', '009', '博士', '宋玉  ', 0, '材料', '材物172', '344578199108134512', '15825253585', '2394548485@qq.com', 0);
INSERT INTO theUser VALUES('..\..\图片\默认用户头像\l.jpg', '1700000010', '010', '图管', '宋广泽', 1, '材料', '材物171', '987978199408134515', '15858252567', '2467945678@qq.com', 0);
INSERT INTO theUser VALUES('..\..\图片\默认用户头像\m.jpg', '1700000011', '011', '图管', '理查德', 1, '材料', '材物172', '344578199108134516', '15825253556', '2394548678@qq.com', 0);

--最近登录表数据
INSERT INTO recent(rID, rRememPW, rAutoLogin) VALUES('1704040213', 1, 1);
INSERT INTO recent(rID, rRememPW, rAutoLogin) VALUES('1709030227', 1, 1);
INSERT INTO recent(rID, rRememPW, rAutoLogin) VALUES('1700000001', 1, 0);
INSERT INTO recent(rID, rRememPW, rAutoLogin) VALUES('1700000010', 0, 0);
INSERT INTO recent(rID, rRememPW, rAutoLogin) VALUES('1700000011', 1, 0);

--活跃人员统计
INSERT INTO activeUser VALUES('1704040213', 201901, 43);
INSERT INTO activeUser VALUES('1709030227', 201901, 54);
INSERT INTO activeUser VALUES('1700000003', 201901, 32);
INSERT INTO activeUser VALUES('1700000001', 201901, 54);

INSERT INTO activeUser VALUES('1704040213', 201902, 35);
INSERT INTO activeUser VALUES('1700000004', 201902, 43);
INSERT INTO activeUser VALUES('1700000008', 201902, 24);
INSERT INTO activeUser VALUES('1700000002', 201902, 54);

INSERT INTO activeUser VALUES('1700000008', 201903, 64);
INSERT INTO activeUser VALUES('1700000001', 201903, 32);
INSERT INTO activeUser VALUES('1700000002', 201903, 32);
INSERT INTO activeUser VALUES('1704040213', 201903, 23);

INSERT INTO activeUser VALUES('1700000004', 201904, 13);
INSERT INTO activeUser VALUES('1709030227', 201904, 43);
INSERT INTO activeUser VALUES('1700000003', 201904, 42);
INSERT INTO activeUser VALUES('1700000008', 201904, 21);

INSERT INTO activeUser VALUES('1700000001', 201905, 43);
INSERT INTO activeUser VALUES('1700000003', 201905, 43);

INSERT INTO activeUser VALUES('1700000009', 201906, 32);
INSERT INTO activeUser VALUES('1709030227', 201906, 54);
INSERT INTO activeUser VALUES('1700000001', 201906, 64);
INSERT INTO activeUser VALUES('1700000004', 201906, 21);

INSERT INTO activeUser VALUES('1700000008', 201907, 23);
INSERT INTO activeUser VALUES('1704040213', 201907, 65);
INSERT INTO activeUser VALUES('1700000001', 201907, 23);
INSERT INTO activeUser VALUES('1700000003', 201907, 12);
INSERT INTO activeUser VALUES('1700000002', 201907, 63);

INSERT INTO activeUser VALUES('1709030227', 201908, 23);
INSERT INTO activeUser VALUES('1700000001', 201908, 42);
INSERT INTO activeUser VALUES('1704040213', 201908, 64);
INSERT INTO activeUser VALUES('1700000004', 201908, 54);
INSERT INTO activeUser VALUES('1700000009', 201908, 23);

--------------------------------------------------------------------------------

--图书类别表
insert into booktype values('计算机类',1)
insert into booktype values('电子类',2)
insert into booktype values('信息类',3)


--图书信息表
insert into Book values('978-7-302-36013-5','编译原理','王生原','材料类','TP-9',4332,2344,'清华大学出版社','2012-2-1',69.5,'这本书很厉害，需要好好学习','正常')
insert into Book values('978-7-302-36003-3','C语言程序设计','谭浩强','计算机类','TP-3',7000,1599,'清华大学出版社','2012-2-1',49.5,'这本书很厉害，需要好好学习','正常')
insert into Book values('978-7-302-36003-4','电路分析','焦超','电子类','TP-5',7000,1599,'清华大学出版社','2012-2-1',20,'这本书很厉害，需要好好学习','正常')
insert into Book values('978-7-302-36003-5','数字逻辑电路','解本巨','计算机类','TP-6',7000,1599,'清华大学出版社','2012-2-1',29.5,'这本书很厉害，需要好好学习','正常')
insert into Book values('978-7-302-36003-6','软件测试技术','杜军威','计算机类','TP-7',7000,1599,'清华大学出版社','2012-2-1',49.5,'这本书很厉害，需要好好学习','正常')
insert into Book values('978-7-302-36003-7','计算机网络','张俊虎','计算机类','TP-8',7000,1599,'清华大学出版社','2012-2-1',69.5,'这本书很厉害，需要好好学习','正常')

--受欢迎图书表
insert into activeBook values('978-7-302-36003-3','201909','14','C语言程序设计')
insert into activeBook values('978-7-302-36003-4','201909','56','电路分析')
insert into activeBook values('978-7-302-36003-5','201909','31','数字逻辑电路')
insert into activeBook values('978-7-302-36003-6','201909','21','软件测试技术')
insert into activeBook values('978-7-302-36003-7','201909','45','计算机网络')
insert into activeBook values('978-7-302-36013-5','201909','23','编译原理')
insert into activeBook values('978-7-302-36003-3','201908','14','C语言程序设计')
insert into activeBook values('978-7-302-36003-4','201908','34','电路分析')
insert into activeBook values('978-7-302-36003-5','201908','13','数字逻辑电路')
insert into activeBook values('978-7-302-36003-6','201908','57','软件测试技术')
insert into activeBook values('978-7-302-36003-7','201908','12','计算机网络')
insert into activeBook values('978-7-302-36013-5','201908','13','编译原理')
insert into activeBook values('978-7-302-36003-3','201907','13','C语言程序设计')
insert into activeBook values('978-7-302-36003-4','201907','32','电路分析')
insert into activeBook values('978-7-302-36003-5','201907','5','数字逻辑电路')
insert into activeBook values('978-7-302-36003-6','201907','7','软件测试技术')
insert into activeBook values('978-7-302-36003-7','201907','5','计算机网络')
insert into activeBook values('978-7-302-36013-5','201907','3','编译原理')
insert into activeBook values('978-7-302-36003-3','201906','12','C语言程序设计')
insert into activeBook values('978-7-302-36003-4','201906','30','电路分析')
insert into activeBook values('978-7-302-36003-5','201906','17','数字逻辑电路')
insert into activeBook values('978-7-302-36003-6','201906','15','软件测试技术')
insert into activeBook values('978-7-302-36003-7','201906','14','计算机网络')
insert into activeBook values('978-7-302-36013-5','201906','3','编译原理')
insert into activeBook values('978-7-302-36003-3','201905','12','C语言程序设计')
insert into activeBook values('978-7-302-36003-4','201905','8','电路分析')
insert into activeBook values('978-7-302-36003-5','201905','13','数字逻辑电路')
insert into activeBook values('978-7-302-36003-6','201905','12','软件测试技术')
insert into activeBook values('978-7-302-36003-7','201905','24','计算机网络')
insert into activeBook values('978-7-302-36013-5','201905','43','编译原理')
insert into activeBook values('978-7-302-36003-3','201904','21','C语言程序设计')
insert into activeBook values('978-7-302-36003-4','201904','34','电路分析')
insert into activeBook values('978-7-302-36003-5','201904','31','数字逻辑电路')
insert into activeBook values('978-7-302-36003-6','201904','35','软件测试技术')
insert into activeBook values('978-7-302-36003-7','201904','16','计算机网络')
insert into activeBook values('978-7-302-36013-5','201904','19','编译原理')
insert into activeBook values('978-7-302-36003-3','201903','31','C语言程序设计')
insert into activeBook values('978-7-302-36003-4','201903','27','电路分析')
insert into activeBook values('978-7-302-36003-5','201903','31','数字逻辑电路')
insert into activeBook values('978-7-302-36003-6','201903','28','软件测试技术')
insert into activeBook values('978-7-302-36003-7','201903','36','计算机网络')
insert into activeBook values('978-7-302-36013-5','201903','23','编译原理')
insert into activeBook values('978-7-302-36003-3','201902','42','C语言程序设计')
insert into activeBook values('978-7-302-36003-4','201902','23','电路分析')
insert into activeBook values('978-7-302-36003-5','201902','18','数字逻辑电路')
insert into activeBook values('978-7-302-36003-6','201902','13','软件测试技术')
insert into activeBook values('978-7-302-36003-7','201902','31','计算机网络')
insert into activeBook values('978-7-302-36013-5','201902','48','编译原理')
insert into activeBook values('978-7-302-36003-3','201901','26','C语言程序设计')
insert into activeBook values('978-7-302-36003-4','201901','31','电路分析')
insert into activeBook values('978-7-302-36003-5','201901','27','数字逻辑电路')
insert into activeBook values('978-7-302-36003-6','201901','52','软件测试技术')
insert into activeBook values('978-7-302-36003-7','201901','23','计算机网络')
insert into activeBook values('978-7-302-36013-5','201901','14','编译原理')

--借阅表
insert into Loan values('1709030227','978-7-302-36003-4','2019-5-1',0,01)
insert into Loan values('1700000001','978-7-302-36003-4','2019-3-1',0,01)
insert into Loan values('1700000002','978-7-302-36003-5','2019-4-23',0,01)
insert into Loan values('1700000003','978-7-302-36003-6','2019-5-12',0,01)
insert into Loan values('1700000004','978-7-302-36003-7','2019-5-15',0,01)