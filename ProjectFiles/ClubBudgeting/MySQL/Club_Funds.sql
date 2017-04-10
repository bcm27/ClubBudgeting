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
  lastName VARCHAR(40) NOT NULL
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

CREATE TABLE Purchase (
  id INT(11) AUTO_INCREMENT PRIMARY KEY,
  purchaseDate DATE DEFAULT NULL,
  cost DECIMAL(6,2) NOT NULL,
  description varchar(100) DEFAULT NULL,
  purchaseType INT(11),
  memberId INT(11) NOT NULL,
  clubId INT(11) NOT NULL,
  CONSTRAINT FKPurchase_memberId FOREIGN KEY (memberId) REFERENCES Member (id)
    ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT FKPurchase_purchaseType FOREIGN KEY (purchaseType) REFERENCES 
    PurchaseType (id) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT FKPurchase_clubId FOREIGN KEY (clubId) REFERENCES Club (id)
    ON DELETE CASCADE ON UPDATE CASCADE
);

CREATE TABLE Budget (
  id INT(11) AUTO_INCREMENT PRIMARY KEY,
  allocatedMoney DECIMAL(8,2) NOT NULL,
  spentMoney DECIMAL(6,2) NOT NULL,
  balance DECIMAL(6,2) NOT NULL,
  debt DECIMAL(6,2) DEFAULT NULL,
  CONSTRAINT FKBudget_id FOREIGN KEY (id) REFERENCES Club (id)
    ON DELETE CASCADE ON UPDATE CASCADE
);

CREATE TABLE BudgetXPurchase (
  budgetId INT(11),
  purchaseId INT(11),
  CONSTRAINT FKBudgetXPurchase_purchaseId FOREIGN KEY (purchaseId)
    REFERENCES Purchase (id) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT FKBudgetXPurchase_budgetId FOREIGN KEY (budgetId)
    REFERENCES Budget (id) ON DELETE CASCADE ON UPDATE CASCADE
);

CREATE TABLE History (
  clubId INT(11),
  previousInfo char(300,
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