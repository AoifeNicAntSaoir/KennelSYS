--KennelSYSData.sql
--this oracle script holds sample loaded data for KennelSYS
--Author: Aoife Sayers


--KennelTypes Sample Data
INSERT INTO KennelTypes
(KennelType,Rate,Description)
VALUES ('S', 55.30, 'This is a small kennel');

INSERT INTO KennelTypes
(KennelType,Rate,Description)
VALUES ('M', 66.30, 'This is a medium kennel');

INSERT INTO KennelTypes
(KennelType,Rate,Description)
VALUES ('L', 70.30, 'This is a medium kennel');

--Kennels Sample Data
INSERT INTO Kennels(KennelNo, Types, KennelStatus)
VALUES(1,'S','O');

INSERT INTO Kennels(KennelNo, Types, KennelStatus)
VALUES(2,'S','O');

INSERT INTO Kennels(KennelNo, Types, KennelStatus)
VALUES(3,'M','O');

INSERT INTO Kennels(KennelNo, Types, KennelStatus)
VALUES(4,'L','O');

INSERT INTO Kennels(KennelNo, Types, KennelStatus)
VALUES(5,'S','O');

INSERT INTO Kennels(KennelNo, Types, KennelStatus)
VALUES(6,'M','A');


--Data for Bookings
INSERT INTO Bookings(KennelNo, BookingNo, Surname, Forename, DateFrom, DateTo, Street, Town, County, MobileNo, cost, checkedIn)
VALUES(1,1,'Sayers','Aoife','25-APR-16','01-MAY-16','Inch','Annascaul','Kerry','0861234567',20.50,'No');

INSERT INTO Bookings(KennelNo, BookingNo, Surname, Forename, DateFrom, DateTo, Street, Town, County, MobileNo, cost, checkedIn)
VALUES(2,2,'Horgan','Aoife','25-APR-16','05-MAY-16','Main Street','Castleisland','Kerry','0861234567', 30.50, 'No');

INSERT INTO Bookings(KennelNo, BookingNo, Surname, Forename, DateFrom, DateTo, Street, Town, County, MobileNo, cost, CheckedIn)
VALUES(3,3,'Chan','Suki','26-APR-16','29-APR-16','Strand Street','Ennis','Clare','0861234567', 70.90, 'No');

INSERT INTO Bookings(KennelNo, BookingNo, Surname, Forename, DateFrom, DateTo, Street, Town, County, MobileNo, cost, CheckedIn)
VALUES(4,4,'Woods','Catherine','26-APR-16','01-MAY-16','Strand Street','Tralee','Kerry','0861234567', 87, 'Yes');

INSERT INTO Bookings(KennelNo, BookingNo, Surname, Forename, DateFrom, DateTo, Street, Town, County, MobileNo, cost, CheckedIn)
VALUES(5,5,'Foley','Mary','26-APR-16','02-MAY-16','Oakpark','Tralee','Kerry','0861234567', 99, 'No');

               
COMMIT;
