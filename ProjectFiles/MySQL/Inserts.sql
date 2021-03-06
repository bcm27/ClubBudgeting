USE ClubSchema2;

INSERT INTO Club VALUES
  (NULL, 'Overall Club Funds Budget', 'Total budget for all the clubs'),
  (NULL, 'Solar Car', 'Club that builds and races a solar car'),
  (NULL, 'Plus One', 'A cappella group that performs on campus'),
  (NULL, 'Astronomy Club', 'Looks at the starts and runs the observatory'),
  (NULL, 'Beekeeping Club', 'Keeps bees'),
  (NULL, 'Sustainability Club', 'Helps the campus stay sustainable'),
  (NULL, 'Euphrates', 'Promotes peace and stuff'),
  (NULL, 'Friendship Around the World', 'Does anyone actually know what this club does'),
  (NULL, 'IPC', 'Runs the International Perspectives Conference'),
  (NULL, 'Mobile Apps', 'They make mobile apps'),
  (NULL, 'PC+', 'They do techy things'),
  (NULL, 'Film Club', 'Club that makes movies'),
  (NULL, 'Lazy Zipper', 'Club that practices improvisation');

INSERT INTO Transactions VALUES
  (NULL, '2016-09-18',  50, 'Travel costs', 2, false),
  (NULL, '2016-10-10', 150, 'Conference costs', 3, false),
  (NULL, '2016-09-11', 15, 'Food costs', 4, false),
  (NULL, '2016-10-13', 40, 'Travel costs', 5, false),
  (NULL, '2016-10-01', 300, 'Materials costs', 6, false),
  (NULL, '2016-10-21', 55, 'Materials costs', 7, false),
  (NULL, '2016-09-11', 20, 'Food costs', 8, false),
  (NULL, '2016-09-10', 30, 'Travel costs', 9, false),
  (NULL, '2016-09-12', 50, 'Food costs', 10, false),
  (NULL, '2016-10-15', 170, 'Events costs', 11, false),
  (NULL, '2016-10-20', 30, 'Event costs', 12, false),
  (NULL, '2016-09-01', 30, 'Food costs', 13, false);

INSERT INTO Term VALUES
 (NULL, 'F13'), (NULL, 'S14'), (NULL, 'F14'), (NULL, 'S15'),
 (NULL, 'F15'), (NULL, 'S16'), (NULL, 'F16'), (NULL, 'S17');

 INSERT INTO Budget VALUES
  (NULL, 1, 8, 25500, 0, 0),
  (NULL, 2, 8, 15000, 10000, 5000),
  (NULL, 3, 8, 400, 400, 0),
  (NULL, 4, 8, 600, 50, 525),
  (NULL, 5, 8, 200, 50, 150),
  (NULL, 6, 8, 900, 225, 675),
  (NULL, 7, 8, 200, 75, 125),
  (NULL, 8, 8, 500, 70, 430),
  (NULL, 9, 8, 200, 150, 50),
  (NULL, 10, 8, 400, 0, 400),
  (NULL, 11, 8, 100, 50, 50),
  (NULL, 12, 8, 50, 50, 0),
  (NULL, 13, 8, 100, 0, 0);