
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================

CREATE PROCEDURE  InsertGuest
	@G_Name varchar(50),            --0
	@G_ID int,                      --1
    @NID int,                       --2
    @Sex char(1),                   --4
    @Birth date,                    --5
    @City varchar(50)               --6
AS
BEGIN
	
	SET NOCOUNT ON;
    INSERT INTO Guests 
	VALUES ( @G_Name, @G_ID, @NID, @Sex, @Birth, @City)
	
END
GO
-----------------------------------------------------
CREATE PROCEDURE  InsertUser
	@mail varchar(100),
	@username varchar(50),
	@PASS varchar(50),
	@ty varchar(50)
AS
BEGIN
	
	SET NOCOUNT ON;
    INSERT INTO users 
	VALUES (@mail, @username, @PASS, @ty)
	
END
GO
-----------------------------------------------------
CREATE PROCEDURE  InsertAllService
	@Kind int,
	@AID int
AS
BEGIN
	
	SET NOCOUNT ON;
    INSERT INTO AllServices 
	VALUES (@Kind, @AID)
	
END
GO
-----------------------------------------------------
CREATE PROCEDURE  InsertStaff
	@S_Name varchar(50),
	@S_ID int,
	@NID int,
	@Birth date,
	@Salary int,
	@Department varchar(50),
	@Sex char(1),
	@W_Shift char(1),
	@SWD date,
	@EWD date,
	@City varchar(50)
AS
BEGIN
	
	SET NOCOUNT ON;
    INSERT INTO Staff 
	VALUES (@S_Name, @S_ID, @NID, @Birth, @Salary, @Department, @Sex, @W_Shift, @SWD, @EWD, @City)
	
END
GO
--------------------------------------------------------
CREATE PROCEDURE  InsertReservation
	@RVID int,
	@TypeR int,
	@nDays int,
	@Avl1 int,
	@Avl2 int,
	@Avl3 int
AS
BEGIN
	
	SET NOCOUNT ON;
    INSERT INTO Reservation 
	VALUES (@RVID, @TypeR, @nDays, @Avl1, @Avl2, @Avl3)
	
END
GO
--------------------------------------------------------
CREATE PROCEDURE  InsertGym
	@GID int,
	@nHours int,
	@No# int
AS
BEGIN
	
	SET NOCOUNT ON;
    INSERT INTO Gym
	VALUES (@GID, @nHours, @No#)
	
END
GO
--------------------------------------------------------
CREATE PROCEDURE  InsertRestaurant
	@RSID int,
	@TypeT varchar(50),
	@No# int,
	@Orders varchar(200),
	@T_Price int,
	@TypeF varchar(50)
AS
BEGIN
	
	SET NOCOUNT ON;
    INSERT INTO Restaurant
	VALUES (@RSID, @TypeT, @No#, @Orders, @T_Price, @TypeF)
	
END
GO
--------------------------------------------------------
CREATE PROCEDURE  InsertMenu
	@Nam varchar(50),
	@Price int,
	@Typ varchar(50)
AS
BEGIN
	
	SET NOCOUNT ON;
    INSERT INTO Menu
	VALUES (@Nam, @Price, @Typ)
	
END
GO
--------------------------------------------------------
CREATE PROCEDURE  InsertFinance
	@FID int,
	@Descriptions varchar(50),
	@In_OR_Out char(1),
	@Amount int
AS
BEGIN
	
	SET NOCOUNT ON;
    INSERT INTO Finance
	VALUES (@FID, @Descriptions, @In_OR_Out, @Amount)
	
END
GO
--------------------------------------------------------
CREATE PROCEDURE  InsertDependant
	@S_ID int,
	@Nam varchar(50),
	@sex varchar(50),
	@Bth date,
	@Relation varchar(50)
AS
BEGIN
	
	SET NOCOUNT ON;
    INSERT INTO Dependant
	VALUES (@S_ID, @Nam, @sex, @Bth, @Relation)
	
END
GO
--------------------------------------------------------
CREATE PROCEDURE  InsertS_phones
	@S_ID1 int,
	@S_phone1 int
AS
BEGIN
	
	SET NOCOUNT ON;
    INSERT INTO S_phones
	VALUES (@S_ID1, @S_phone1)
	
END
GO
--------------------------------------------------------
CREATE PROCEDURE  InsertG_phones
	@G_ID1 int,
	@G_phone1 int
AS
BEGIN
	
	SET NOCOUNT ON;
    INSERT INTO G_phones
	VALUES (@G_ID1, @G_phone1)
	
END
GO
--------------------------------------------------------
CREATE PROCEDURE  InsertOffer
	@RID int,
	@MName varchar(50)
AS
BEGIN
	
	SET NOCOUNT ON;
    INSERT INTO Offer
	VALUES (@RID, @MName)
	
END
GO
--------------------------------------------------------
CREATE PROCEDURE  InsertOutcome
	@S_ID int,
	@FID int
AS
BEGIN
	
	SET NOCOUNT ON;
    INSERT INTO Outcome
	VALUES (@S_ID, @FID)
	
END
GO
--------------------------------------------------------
CREATE PROCEDURE  InsertBooking_Room
	@RRID int,
	@GID int,
	@FID int,
	@Fromdate date,
	@todate date
AS
BEGIN
	
	SET NOCOUNT ON;
    INSERT INTO Booking_Room
	VALUES (@RRID, @GID, @FID, @Fromdate, @todate)
	
END
GO
--------------------------------------------------------
CREATE PROCEDURE  InsertTraining
	@GYID int,
	@GID int,
	@FID int,
	@Dat date
AS
BEGIN
	
	SET NOCOUNT ON;
    INSERT INTO Training
	VALUES (@GYID, @GID, @FID, @Dat)
	
END
GO
--------------------------------------------------------
CREATE PROCEDURE  InsertRequesting_meal
	@RID int,
	@GID int,
	@FID int,
	@Dat date
AS
BEGIN
	
	SET NOCOUNT ON;
    INSERT INTO Requesting_meal
	VALUES (@RID, @GID, @FID, @Dat)
	
END
GO
--------------------------------------------------------
--------------------------------------------------------
--------------------------------------------------------
----------------------UPDATE----------------------------
--------------------------------------------------------
--------------------------------------------------------
--------------------------------------------------------
CREATE PROCEDURE  ModifyGuest
	@G_Name varchar(50),            --0
	@G_ID int,                      --1
    @NID int,                       --2
    @Sex char(1),                      --4
    @Birth date,                    --5
    @City varchar(50)               --6
AS
BEGIN
	
	SET NOCOUNT ON;
    UPDATE Guests 
	SET  G_Name = @G_Name, G_ID = @G_ID, NID = @NID, Sex = @Sex, Birth = @Birth, City = @City
	WHERE G_ID = @G_ID
END
GO
--------------------------------------------------------
CREATE PROCEDURE  ModifyStaff
	@S_Name varchar(50), 
	@S_ID int,
	@NID int,
	@Birth date,
	@Salary int,
	@Department varchar(50),
	@Sex char(1),
	@W_Shift char(1),
	@SWD date,
	@EWD date,
	@City varchar(50)
AS
BEGIN
	
	SET NOCOUNT ON;
    UPDATE Staff 
	SET S_Name = @S_Name, S_ID = @S_ID, NID = @NID, Birth = @Birth, Salary = @Salary, Department = @Department, Sex = @Sex, W_Shift = @W_Shift, SWD = @SWD, EWD = @EWD, City = @City
	WHERE S_ID = @S_ID
END
GO
--------------------------------------------------------
CREATE PROCEDURE  ModifyFinance
	@FID int,
	@Descriptions varchar(50),
	@In_OR_Out char(1),
	@Amount int
AS
BEGIN
	
	SET NOCOUNT ON;
    UPDATE Finance
	SET FID = @FID, Descriptions = @Descriptions, In_OR_Out = @In_OR_Out, Amount = @Amount
	WHERE FID = @FID
END
GO
--------------------------------------------------------
CREATE PROCEDURE  ModifyS_phones
	@S_ID1 int,
	@S_phone1 int
AS
BEGIN
	
	SET NOCOUNT ON;
    UPDATE S_phones
	SET S_phone = @S_phone1
	WHERE S_ID = @S_ID1
END
GO
--------------------------------------------------------
CREATE PROCEDURE  ModifyG_phones
	@G_ID1 int,
	@G_phone1 int
AS
BEGIN
	
	SET NOCOUNT ON;
    UPDATE G_phones
	SET G_phone = @G_phone1
	WHERE G_ID = @G_ID1
END
GO
--------------------------------------------------------
CREATE PROCEDURE  ModifyUser
	@mail varchar(100),
	@username varchar(50),
	@PASS varchar(50)
BEGIN
	
	SET NOCOUNT ON;
    UPDATE users 
	SET username = @username, PASS = @PASS
	WHERE mail = @mail
END
GO
-------------------------------------------------------
-------------------------------------------------------
-------------------------------------------------------
-------------------------------------------------------
-------------------------------------------------------
CREATE PROCEDURE getOneGuest
	@G_ID int
AS
BEGIN
	SET NOCOUNT ON;
	SELECT * FROM Guests
	WHERE G_ID = @G_ID
END
GO
-------------------------------------------------------
CREATE PROCEDURE getOneStaff
	@S_ID int
AS
BEGIN
	SET NOCOUNT ON;
	SELECT * FROM Staff
	WHERE S_ID = @S_ID
END
GO
--------------------------------------------------------
CREATE PROCEDURE getOneFinance
	@FID int
AS
BEGIN
	SET NOCOUNT ON;
	SELECT * FROM Finance
	WHERE FID = @FID
END
GO
--------------------------------------------------------