CREATE DATABASE FlightTicketManagement
GO

USE FlightTicketManagement
GO

CREATE TABLE AIRPORT (
  AirportCode VARCHAR(20) NOT NULL,
  AirportName NVARCHAR(255),
  CityName NVARCHAR(255),
  CountryName NVARCHAR(255),
  CONSTRAINT PK_AP PRIMARY KEY(AirportCode)
);
GO

CREATE TABLE PLANE
(
	PlaneCode VARCHAR(20) NOT NULL,
	PlaneName VARCHAR(255),
	SeatCount SMALLINT,
	CONSTRAINT PK_PE PRIMARY KEY(PlaneCode)
);
GO

CREATE TABLE TICKETCLASS
(
	TicketClassCode VARCHAR(20) NOT NULL,
	TicketClassName NVARCHAR(255),
	PricePercentage SMALLINT,
	CONSTRAINT PK_TC PRIMARY KEY(TicketClassCode)
);
GO

CREATE TABLE SEAT
(
	SeatCode VARCHAR(20) NOT NULL,
	PlaneCode VARCHAR(20) NOT NULL,
	TicketClassCode VARCHAR(20),
	CONSTRAINT PK_ST PRIMARY KEY(SeatCode, PlaneCode),
	CONSTRAINT FK_ST_TC FOREIGN KEY (TicketClassCode) REFERENCES TICKETCLASS(TicketClassCode),
	CONSTRAINT FK_ST_PE FOREIGN KEY (PlaneCode) REFERENCES PLANE(PlaneCode)
);
GO

CREATE TABLE FLIGHT
(
  FlightCode VARCHAR(20) NOT NULL,
  DepartureAirportCode VARCHAR(20),
  DestinationAirportCode VARCHAR(20),
  PlaneCode VARCHAR(20),
  TicketPrice DECIMAL(10, 2),
  DateTimeScheduled SMALLDATETIME,
  FlightDuration TIME,
  CONSTRAINT PK_FL PRIMARY KEY(FlightCode),
  CONSTRAINT FK_FL_AP1 FOREIGN KEY (DepartureAirportCode) REFERENCES AIRPORT(AirportCode),
  CONSTRAINT FK_FL_AP2 FOREIGN KEY (DestinationAirportCode) REFERENCES AIRPORT(AirportCode),
  CONSTRAINT FK_FL_PE FOREIGN KEY (PlaneCode) REFERENCES PLANE(PlaneCode),
);
GO

CREATE TABLE FLIGHTDETAIL
(
  AirportCode VARCHAR(20) not null,
  FlightCode VARCHAR(20) not null,
  DelayTime TIME,
  Notes NVARCHAR(255),
  CONSTRAINT PK_FLD PRIMARY KEY(AirportCode),
  CONSTRAINT FK_FLD_AP FOREIGN KEY (AirportCode) REFERENCES AIRPORT(AirportCode),
  CONSTRAINT FK_FLD_FL FOREIGN KEY (FlightCode) REFERENCES FLIGHT(FlightCode)
);
GO

CREATE TABLE REGULATIONS(
  MinimumFlightTime TIME,
  MaxDelayAirports TINYINT,
  MinimumDelayTime TIME,
  MaximumDelayTime TIME,
  LatestBookingTime TIME,
  LatestCancellationTime TIME
);
GO

--CREATE TABLE FlightTicket (
--  TicketID VARCHAR(255) PRIMARY KEY,
--  FlightCode VARCHAR(255),
--  CustomerID VARCHAR(255),
--  TicketCompany VARCHAR(255),
--  TicketPrice DECIMAL(10, 2),
--  FullName NVARCHAR(255),
--  IdentificationNumber VARCHAR(255),
--  PhoneNumber VARCHAR(255)
--);
--GO
