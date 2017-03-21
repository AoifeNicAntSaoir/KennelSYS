--KennelSYS.SQL
--this oracle script holds the database for the kennel system
--Author: Aoife Sayers


--Drop Table Statements
DROP TABLE Bookings;
DROP TABLE Kennels;
DROP TABLE KennelTypes;


--KennelTypes Relation
CREATE TABLE KennelTypes(
KennelType char(2) NOT NULL,
Rate numeric(5,2) NOT NULL,
Description char(30) NOT NULL,
CONSTRAINT kennel_pk PRIMARY KEY (KennelType));

--Kennels Relation
CREATE TABLE Kennels (
KennelNo numeric(4) NOT NULL,
Types char(2),
KennelStatus char(2) NOT NULL,
CONSTRAINT pk_Kennels PRIMARY KEY (KennelNo),
CONSTRAINT fk_Kennels FOREIGN KEY(Types) REFERENCES KennelTypes);

--Bookings Relation
CREATE TABLE Bookings(
BookingNo numeric(4),
KennelNo numeric(4),
Surname char(20),
Forename char(20),
DateFrom date,
DateTo date,
Street varchar(20),
Town char(20),
County char(20),
MobileNo varchar(10),
cost numeric(5,2),
CheckedIn char(3),
CONSTRAINT pk_Bookings PRIMARY KEY(BookingNo),
CONSTRAINT fk_Bookings FOREIGN KEY(KennelNo) REFERENCES Kennels);



COMMIT;
