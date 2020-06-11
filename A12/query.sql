CREATE TABLE Utisak
(
  ID int primary key,
  Ime varchar(50),
  Email varchar(50),
  Komentar varchar(200),
  Datum datetime
);

SELECT MAX(ID) FROM Utisak;