USE FlightTicketManagement
GO

SET DATEFORMAT dmy
GO

INSERT INTO REGULATIONS (MinimumFlightTime, MaxDelayAirports, MinimumDelayTime, MaximumDelayTime, LatestBookingTime, LatestCancellationTime)
VALUES (30, 2, 10, 20, 1, 1);
GO

