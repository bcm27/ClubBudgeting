DROP DATABASE IF EXISTS Club_Funds;
CREATE DATABASE Club_Funds;
USE Club_Funds;

/* Schema */

CREATE TABLE Club (
  id INT(11) AUTO_INCREMENT PRIMARY KEY,
  name VARCHAR(60) NOT NULL,
  description VARCHAR(255) DEFAULT NULL
);

CREATE TABLE MemberTitle (
  id INT(11) AUTO_INCREMENT PRIMARY KEY,
  title VARCHAR(30) NOT NULL
);

CREATE TABLE Member (
  id INT(11) AUTO_INCREMENT PRIMARY KEY,
  firstName VARCHAR(40) NOT NULL,
  lastName VARCHAR(40) NOT NULL,
  password VARCHAR(100) NOT NULL
);

CREATE TABLE ClubXMember (
  clubId INT(11) NOT NULL,
  memberId INT(11) NOT NULL,
  title INT(11) DEFAULT 6,
  CONSTRAINT FKClubXMember_title FOREIGN KEY (title) REFERENCES 
    MemberTitle (id) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT FKClubXMember_clubId FOREIGN KEY (clubId) REFERENCES Club (id)
    ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT FKClubXMember_memberId FOREIGN KEY (memberId) REFERENCES 
    Member (id) ON DELETE CASCADE ON UPDATE CASCADE
);

CREATE TABLE PurchaseType (
  id INT(11) AUTO_INCREMENT PRIMARY KEY,
  type VARCHAR(30) NOT NULL
);

CREATE TABLE Transactions (
  id INT(11) AUTO_INCREMENT PRIMARY KEY,
  purchaseDate DATE NOT NULL,
  cost DECIMAL(6,2) NOT NULL,
  description varchar(100) DEFAULT NULL,
  transactionsType INT(11),
  memberId INT(11) NOT NULL,
  clubId INT(11) NOT NULL,
  CONSTRAINT FKTransactions_memberId FOREIGN KEY (memberId) REFERENCES Member (id)
    ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT FKTransactions_transactionsType FOREIGN KEY (transactionsType) REFERENCES 
    PurchaseType (id) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT FKTransactions_clubId FOREIGN KEY (clubId) REFERENCES Club (id)
    ON DELETE CASCADE ON UPDATE CASCADE
);

CREATE TABLE Budget (
  id INT(11) AUTO_INCREMENT PRIMARY KEY,
  allocatedMoney DECIMAL(8,2) NOT NULL,
  spentMoney DECIMAL(8,2) NOT NULL,
  balance DECIMAL(8,2) NOT NULL,
  debt DECIMAL(8,2) DEFAULT NULL,
  CONSTRAINT FKBudget_id FOREIGN KEY (id) REFERENCES Club (id)
    ON DELETE CASCADE ON UPDATE CASCADE
);

CREATE TABLE BudgetXPurchase (
  budgetId INT(11),
  transactionsId INT(11),
  CONSTRAINT FKBudgetXTransactions_purchaseId FOREIGN KEY (transactionsId)
    REFERENCES Transactions (id) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT FKBudgetXTransactions_budgetId FOREIGN KEY (budgetId)
    REFERENCES Budget (id) ON DELETE CASCADE ON UPDATE CASCADE);

CREATE TABLE History (
  clubId INT(11),
  previousInfo char(30),
  CONSTRAINT FKHistory_clubId FOREIGN KEY (clubId) REFERENCES Club (id)
    ON DELETE CASCADE ON UPDATE CASCADE
);

# Fill enum tables

INSERT INTO `MemberTitle` VALUES
  (NULL, 'President'),
  (NULL, 'Vice President'),
  (NULL, 'Treasurer'),
  (NULL, 'Secretary'),
  (NULL, 'Adviser'),
  (NULL, 'Individual');

INSERT INTO `PurchaseType` VALUES
  (NULL, 'Travel'),
  (NULL, 'Food'),
  (NULL, 'Events'),
  (NULL, 'Materials'),
  (NULL, 'Conferences');