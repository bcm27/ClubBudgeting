DROP DATABASE IF EXISTS ClubSchema2;
CREATE DATABASE ClubSchema2;
USE ClubSchema2;

CREATE TABLE Club (
	id INT AUTO_INCREMENT PRIMARY KEY,
	name VARCHAR(60) NOT NULL,
	description VARCHAR(255) DEFAULT NULL
);

CREATE TABLE Member (
	id INT AUTO_INCREMENT PRIMARY KEY,
	adminRight BOOL NOT NULL,
    userName VARCHAR(40) NOT NULL UNIQUE KEY,
	firstName VARCHAR(40) DEFAULT NULL,
	lastName VARCHAR(40) DEFAULT NULL,
	pass VARCHAR(100) NOT NULL
);

CREATE TABLE Transactions (
	id INT AUTO_INCREMENT PRIMARY KEY,
	purchaseDate DATE NOT NULL,
	invoice LONGBLOB DEFAULT NULL,
    fileExtention VARCHAR(4) DEFAULT NULL,
	cost DECIMAL(8,2) NOT NULL,
	description VARCHAR(100) DEFAULT NULL,
	clubId INT NOT NULL,
    approved BOOL DEFAULT FALSE,
	CONSTRAINT FKTransactions_clubId FOREIGN KEY (clubId) REFERENCES Club (id)
		ON DELETE CASCADE ON UPDATE CASCADE
);

CREATE TABLE term (
	id INT AUTO_INCREMENT PRIMARY KEY,
    semester VARCHAR(3) NOT NULL
);

CREATE TABLE Budget (
	id INT(11) AUTO_INCREMENT PRIMARY KEY,
	termId INT NOT NULL,
	allocatedMoney DECIMAL(8,2) NOT NULL,
	spentMoney DECIMAL(8,2) NOT NULL,
	balance DECIMAL(8,2) NOT NULL,
	debt DECIMAL(8,2) DEFAULT NULL,
	CONSTRAINT FKBudget_clubId FOREIGN KEY (id) REFERENCES Club (id)
		ON DELETE CASCADE ON UPDATE CASCADE,
	CONSTRAINT FKBudget_termId FOREIGN KEY (termId) REFERENCES Term (id)
		ON DELETE CASCADE ON UPDATE CASCADE
);

CREATE TABLE BudgetProposal (
	id INT AUTO_INCREMENT PRIMARY KEY,
    termId INT NOT NULL,
    proposal LONGBLOB NOT NULL,
	CONSTRAINT FKBudgetProposal_termId FOREIGN KEY (termId) REFERENCES Term (id)
		ON DELETE CASCADE ON UPDATE CASCADE    
);
insert into club Values (NULL, 'PC+', null);
    
    
    select * from Transactions;
    select * from club;
    SELECT * FROM Transactions WHERE purchaseDate = '2017-04-22';
    
    