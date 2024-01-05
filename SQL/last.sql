--------------------------------------///////////////////////////////////////////////////////////
CREATE PROCEDURE  InsertRoom3
	@RVID int,                      --1
    @TypeR varchar(50),                     --2
    @nDays int,                     --3
    @Avl1 int,                      --4
    @Avl2 int,                      --5
    @Avl3 int                      --6
   
AS
BEGIN
	
	SET NOCOUNT ON;
    INSERT INTO Reservation
	VALUES ( @RVID, @TypeR, @nDays, @Avl1, @Avl2, @Avl3)
	
END
GO



CREATE PROCEDURE  InsertGym
	@GID int,                      --1
    @nHours varchar(50),                       --
    @No# int                      
    
AS
BEGIN
	
	SET NOCOUNT ON;
    INSERT INTO Gym 
	VALUES ( @GID, @nHours, @No#)
	
END
GO




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
	VALUES ( @RSID, @TypeT, @No#, @Orders, @T_Price, @TypeF )
	
END
GO

---/////////////////////////////

CREATE PROCEDURE GetCustomerData
	-- Add the parameters for the stored procedure here
	
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT 
	TypeT, T_Price,TypeR
	
	
	FROM Restaurant,Requesting_meal,Reservation, Guests, Booking_Room
	WHERE (RSID=RID) AND (Guests.G_ID=Booking_Room.GID)
END
GO
------------------------------------------------------------

CREATE PROCEDURE GetSingleroomAvail
AS
BEGIN
	
	SET NOCOUNT ON;
	Select Avl1 FROM Reservation WHERE  RVID = (SELECT MAX(RVID) FROM Reservation);
END
GO

------------------------------------------------------------

CREATE PROCEDURE GetDoubleroomAvail
AS
BEGIN
	
	SET NOCOUNT ON;
	Select Avl2 FROM Reservation WHERE  RVID = (SELECT MAX(RVID) FROM Reservation);
END
GO
------------------------------------------------------------

CREATE PROCEDURE GetSuiteroomAvail
AS
BEGIN
	
	SET NOCOUNT ON;
	Select Avl2 FROM Reservation WHERE  RVID = (SELECT MAX(RVID) FROM Reservation);
END
GO


----------------------------------//////////////////////////////////////////

---------------------------Current Order----------------------------------


----------------------------
CREATE PROCEDURE  InsertCurrentOrder
	@servic varchar(50) ,
    @price int                     
    
AS
BEGIN
	
	SET NOCOUNT ON;
    INSERT INTO CurrentOrder 
	VALUES ( @servic, @price)
	
END
GO
-------------------------------

CREATE PROCEDURE GetCurrentOrder1
AS
BEGIN
	
	SET NOCOUNT ON;
	Select servic, price From CurrentOrder;
END
GO

---------------------------------
CREATE PROCEDURE DeleteCurrentOrder
AS
BEGIN
	
	SET NOCOUNT ON;
	DELETE  FROM CurrentOrder
END
GO

----------------------------Relations----------------------------------------


-------------------------------------///////////////////////////////////////////////////////////
Create PROCEDURE  InsertBooking_Room1
	@RRID int,                      
    @GID int,
   @FID int,
   @Fromdate date,
   @todate date
   
AS
BEGIN
	
	SET NOCOUNT ON;
    INSERT INTO Booking_Room 
	VALUES ( @RRID, @GID, @FID, @Fromdate, @todate)
	
END
GO


CREATE PROCEDURE  InsertTraining
	@GYID int,
    @GID int,
    @FID int,
    @Dat date
   
AS
BEGIN
	
	SET NOCOUNT ON;
    INSERT INTO Training
	VALUES ( @GYID, @GID, @FID, @Dat)
	
END
GO



CREATE PROCEDURE  InsertRequesting_meal
@RID int,
@GID int,
@FID int,
@Dat date
   
AS
BEGIN
	
	SET NOCOUNT ON;
    INSERT INTO Requesting_meal 
	VALUES ( @RID, @GID, @FID, @Dat)
	
END
GO


Create PROCEDURE  InsertFinance1
@FID int,
@Descriptions varchar(50),
@In_OR_Out char(1),
@Amount int
   
AS
BEGIN
	
	SET NOCOUNT ON;
    INSERT INTO Finance
	VALUES ( @FID, @Descriptions, @In_OR_Out, @Amount)
	
END
GO
