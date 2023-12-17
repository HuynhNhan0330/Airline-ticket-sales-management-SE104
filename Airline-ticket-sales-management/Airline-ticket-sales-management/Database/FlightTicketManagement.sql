CREATE DATABASE FlightTicketManagement

USE FlightTicketManagement

CREATE TABLE FLIGHT (
    FlightID VARCHAR(20) PRIMARY KEY NOT NULL,
    PlaneID VARCHAR(20) NOT NULL,
    DepartureAirportCode VARCHAR(20) NOT NULL,
    ArrivalAirportCode VARCHAR(20) NOT NULL,
    TicketPrice DECIMAL(10, 2) NOT NULL,
    DepartureDateTime SMALLDATETIME NOT NULL,
    FlightDuration INT NOT NULL
);

CREATE TABLE PLANE (
    PlaneID VARCHAR(20) primary KEY NOT NULL,
    PlaneName NVARCHAR(255) NOT NULL,
    SeatCount INT NOT NULL
);

CREATE TABLE AIRPORT (
    AirportID VARCHAR(20) PRIMARY KEY NOT NULL,
    AirportName NVARCHAR(255) NOT NULL,
    CityName NVARCHAR(255) NOT NULL,
    CountryName NVARCHAR(255) NOT NULL
);

CREATE TABLE FLIGHT_TICKET (
    FlightTicketID VARCHAR(20) PRIMARY KEY NOT NULL,
    FlightID VARCHAR(20) NOT NULL,
    TicketClassID VARCHAR(20) NOT NULL,
    Price DECIMAL(10, 2) NOT NULL,
    FullName NVARCHAR(255) NOT NULL,
    IDCard VARCHAR(20) NOT NULL,
    PhoneNumber VARCHAR(50) NOT NULL,
    Email NVARCHAR(255) NOT NULL,
    SeatID VARCHAR(20),
    FlightStatus NVARCHAR(255) NOT NULL
);


CREATE TABLE FLIGHT_DETAIL (
    PreventiveAirportID VARCHAR(20) NOT NULL,
    FlightID VARCHAR(20) NOT NULL,
    StopoverDuration INT NOT NULL,
    Note NVARCHAR(255) NOT NULL,
    PRIMARY KEY (PreventiveAirportID, FlightID)
);

CREATE TABLE SEAT (
    SeatID VARCHAR(20) NOT NULL,
    PlaneID VARCHAR(20) NOT NULL,
    TicketClassID VARCHAR(20) NOT NULL,
    PRIMARY KEY (SeatID, PlaneID)
);

CREATE TABLE TICKET_CLASS (
    TicketClassID VARCHAR(20) PRIMARY KEY NOT NULL,
    TicketClassName NVARCHAR(255) NOT NULL,
    PricePercentage INT NOT NULL
);

CREATE TABLE FLIGHT_TICKET_CLASS_DETAIL (
	FlightID VARCHAR(20) NOT NULL,
    TicketClassID VARCHAR(20) NOT NULL,
    Fare DECIMAL(10, 2) NOT NULL,
    SeatCapacity INT NOT NULL,
    TicketSold INT NOT NULL,
    SeatRemaining INT NOT NULL,
    PRIMARY KEY (FlightID, TicketClassID)
);

CREATE TABLE ANNUAL_REVENUE_REPORT (
	Years INT PRIMARY KEY NOT NULL,
    TotalRevenue DECIMAL(10, 2) NOT NULL
);

CREATE TABLE DETAILED_ANNUAL_REVENUE_REPORT (
	Years INT NOT NULL,
    Months INT NOT NULL,
    FlightCount INT NOT NULL,
    Revenue DECIMAL(10, 2) NOT NULL,
    Ratio DECIMAL(10, 2) NOT NULL,
    PRIMARY KEY(Years, Months) 
);

CREATE TABLE DETAILED_MONTHLY_REVENUE_REPORT (
	Years INT NOT NULL,
    Months INT NOT NULL, 
    FlightID VARCHAR(20) NOT NULL,
    TicketSold INT NOT NULL,
    Revenue DECIMAL(10, 2) NOT NULL,
    Ratio DECIMAL(10, 2) NOT NULL,
    PRIMARY KEY(Years, Months, FlightID)
);

CREATE TABLE Parameters (
  ParametersID VARCHAR(20) PRIMARY KEY NOT NULL,
  MinimumFlightTime INT NOT NULL,
  MaxPreventiveAirports INT NOT NULL,
  MinimumStopoverTime INT NOT NULL,
  MaximumStopoverTime INT NOT NULL,
  EarliestBookingTime INT NOT NULL,
  LatestBookingCancellationTime INT NOT NULL
);

CREATE TABLE ACCOUNT (
  AccountID VARCHAR(20) PRIMARY KEY NOT NULL,
  Name NVARCHAR(100),
  Phone VARCHAR(20),
  Email NVARCHAR(100),
  Password NVARCHAR(100),
  Created SMALLDATETIME,
  RoleID VARCHAR(20) NOT NULL
);

CREATE TABLE PERMISSION (
  RoleID VARCHAR(20) PRIMARY KEY NOT NULL,
  RoleName NVARCHAR(100),
  PermissionCode NVARCHAR(100)
);

alter table ACCOUNT add foreign key (RoleID) references PERMISSION(RoleID);

/*Khoa ngoại*/
--alter table FLIGHT_TICKET add foreign key (SeatID) references SEAT(SeatID); // Không thực hiện được
alter table FLIGHT_TICKET add foreign key (FlightID) references FLIGHT(FlightID);
alter table FLIGHT_TICKET add foreign key (TicketClassID) references TICKET_CLASS(TicketClassID);

alter table FLIGHT_DETAIL add foreign key (PreventiveAirportID) references AIRPORT(AirportID);
alter table FLIGHT_DETAIL add foreign key (FlightID) references FLIGHT(FlightID);

alter table FLIGHT add foreign key (DepartureAirportCode) references AIRPORT(AirportID);
alter table FLIGHT add foreign key (ArrivalAirportCode) references AIRPORT(AirportID);
alter table FLIGHT add foreign key (PlaneID) references Plane(PlaneID);

alter table Seat add foreign key (PlaneID) references Plane(PlaneID);
alter table Seat add foreign key (TicketClassID) references TICKET_CLASS(TicketClassID);

alter table FLIGHT_TICKET_CLASS_DETAIL add foreign key (TicketClassID) references TICKET_CLASS(TicketClassID);
alter table FLIGHT_TICKET_CLASS_DETAIL add foreign key (FlightID) references FLIGHT(FlightID);

alter table DETAILED_MONTHLY_REVENUE_REPORT add foreign key (FlightID) references FLIGHT(FlightID);

--ALTER TABLE DETAILED_MONTHLY_REVENUE_REPORT 
--ADD FOREIGN KEY (Years, Months) 
--REFERENCES DETAILED_ANNUAL_REVENUE_REPORT(Years, Months);

--alter table  DETAILED_ANNUAL_REVENUE_REPORT add foreign key (Years) references ANNUAL_REVENUE_REPORT(Years);

