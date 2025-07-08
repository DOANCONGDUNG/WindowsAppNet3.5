CREATE TABLE `users` (
  `id` int NOT NULL AUTO_INCREMENT,
  `username` varchar(50) DEFAULT NULL,
  `password` varchar(100) DEFAULT NULL,
  `email` varchar(50) DEFAULT NULL,
  `roleid` varchar(1) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=14 DEFAULT CHARSET=utf8mb3


insert into db_test.users(username,password,email,roleid) values 
    ('admin','03ac674216f3e15c761ee1a5e255f067953623c8b388b4459e13f978d7c846f4','abc@gmail.com','5')
  , ('test1',null,null,'1')
  , ('test3',null,null,'5')
  , ('test4',null,null,'5')
  , ('test5',null,null,'1')
  , ('test6',null,null,'1')
  , ('test7',null,'7@gmail.com','1')
  , ('test8',null,'123@yahoo.com','5')
  , ('test9',null,'9@gmail.com','1')
  , ('test10',null,null,'1')
  , ('test11',null,'11@gmail.com','5')
  , ('admin1','a665a45920422f9d417e4867efdc4fb8a04a1f3fff1fa07e998e86f7f7a27ae3','admin1@gmail.com','1');