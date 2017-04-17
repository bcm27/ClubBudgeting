USE Club_Funds;

/* Test Queries */

#List the allowed spending for all clubs who started with no debt
SELECT c.id, c.name, balance FROM Budget b
  NATURAL JOIN Club c WHERE b.debt = 0;

#See how much a certain club has spent from their allocated budget
SELECT c.name, b.allocatedMoney, b.spentMoney FROM Club c
  NATURAL JOIN Budget b ORDER BY c.name;

#List in order the clubs that have the most allocated money and the most debt
SELECT c.id, c.name, MAX(b.allocatedMoney) Allocations, MAX(b.debt) Debt FROM Club c
  NATURAL JOIN Budget b
  GROUP BY c.id HAVING MAX(b.allocatedMoney) AND MAX(debt)
  ORDER BY Allocations DESC;

#List the club id and number of members of the club
SELECT c.id, c.name, count(*) 'Number of Members' FROM Member m
  JOIN ClubXMember cm ON m.id = cm.memberId
  JOIN Club c ON cm.clubId = c.id
  GROUP BY c.id;

#List the price and description of the highest priced purchase from each club --?????
SELECT DISTINCT p.clubId, p.id, p.cost, p.description, MAX(p.cost) FROM Purchase p
  JOIN Budget b ON p.id = b.id
  GROUP BY b.id, p.id HAVING MAX(p.cost);

#List all clubs who have spent money on purchase type “Conferences” and how much they spent
SELECT c.id, c.name, SUM(Cost) 'Conference Costs' FROM PurchaseType pt
  JOIN Purchase p ON pt.id = p.purchaseTypeId
  JOIN Club c ON p.clubId = c.id
  JOIN Budget b ON c.id = b.id
  WHERE type = 'Conferences'
  GROUP BY clubId;

#List the total allocated money and the most expensive travel cost
SELECT c.id, c.name, b.allocatedMoney, MAX(Cost) 'Max Travel Cost' FROM PurchaseType pt
  JOIN Purchase p ON pt.id = p.purchaseTypeId
  JOIN Club c ON p.clubId = c.id
  JOIN Budget b ON c.id = b.id
  WHERE type = 'Travel'
  GROUP BY clubId;

#List all of the members in a particular club
SELECT c.name Club, m.id MemberId, m.firstName, m.lastName FROM Member m
  JOIN ClubXMember cm ON m.id = cm.memberId
  JOIN Club c ON cm.clubId = c.id
  WHERE c.name = 'Sustainability Club'
  GROUP BY cm.memberId;

#List a specific club, its id, and its most recent purchase
SELECT c.name Club, c.id, (select MAX(purchaseDate) FROM Purchase WHERE clubId = 1) Purchases
  FROM Club c WHERE c.name = 'Solar Car';


#Give the club name, balance, and the percentage of their balance that would cover all of their debt
SELECT c.id, c.name 'Club Name', balance,
  CONCAT(ROUND((debt/balance)*100, 2), '%') '% of Balance Needed to Pay Off Debt'
  FROM Budget b JOIN Club c ON b.id = c.id
  GROUP BY c.id;

#Find how much each club has spent in the last month
SELECT c.id ClubId, c.name Name, SUM(p.cost) Spent FROM Club c
  NATURAL JOIN Budget b
  JOIN Purchase p ON b.id = p.id
  WHERE purchaseDate BETWEEN DATE_SUB(NOW(), INTERVAL 1 MONTH) AND NOW()
  GROUP BY c.id;

#Find how much a President has spent in a particular club
SELECT c.id, c.name, CONCAT(firstName,' ',lastName) President, SUM(cost) 'Spent Money' FROM Club c
  JOIN ClubXMember cm ON c.id = cm.clubId
  JOIN Member m ON cm.memberId = m.id
  JOIN Purchase p ON p.memberId = m.id
  JOIN MemberTitle mt ON cm.titleId = mt.id
  WHERE mt.title = 'President'
  GROUP BY m.id, c.id ORDER BY c.id;