CREATE TABLE `role` (
  `roleid` varchar(1) NOT NULL,
  `rolename` varchar(100) DEFAULT NULL,
  PRIMARY KEY (`roleid`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb3


insert into db_test.`role`(roleid,rolename) values 
    ('1','一般')
  , ('5','Admin');