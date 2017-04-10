DROP DATABASE IF EXISTS clubbing;
CREATE DATABASE clubbing;
USE clubbing;

/* Schema */
CREATE TABLE `Account` (
	`id` INT(11) PRIMARY KEY AUTO_INCREMENT,
    `userName` varchar(30) unique not null,
	`firstname` VARCHAR(50) NOT NULL,
	`middleInitial` char(1) default null,
    `lastName` varchar(50) not null,
    `email` varchar(35) not null,
    `phoneNum` varchar(12) default null,
    `address` varchar(40) default null,
    `ST` char(2) default null,
    `zipCode` varchar(10) default null
);

insert into Account(userName, firstName, lastName, middleInitial, email, phoneNum, address, ST, zipCode) value 
('bcm27', 'Bjorn', 'Mathisen', 'C', 'bcm27@live.com', '224-639-1122', '265 Melody Lane', 'IL', '62026'),
('tounrey', 'Jacob', 'Huss', 'N', 'bla@live.com', '123-123-1234', '265 Applce Drive', 'IL', '62026'),
('NicholasWolf', 'nicholas', 'stranger', 'W', 'watermelon@live.com', '123-123-1234', '265 Applce Drive', 'IL', '62026'),
('andrew', 'Andrew', 'Christenson', 'Z', 'andrew@live.com', '879-622-5843', '1 Maybeck Place', 'IL', '62026'),
('imhi', 'Bjorn', 'Mathisen', 'C', 'bcm27@live.com', '111-999-5478', '265 Melody Lane', 'IL', '60110'),
('xplosivex', 'John', 'Estry', 'N', 'highexpl@osive.com', '333-622-5746', 'buckets of blood ln', 'NM', '60110');

select * from Account;