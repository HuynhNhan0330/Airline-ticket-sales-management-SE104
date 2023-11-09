USE FlightTicketManagement
GO

SET DATEFORMAT dmy
GO

INSERT INTO REGULATIONS (RegulationsCode, MinimumFlightTime, MaxDelayAirports, MinimumDelayTime, MaximumDelayTime, LatestBookingTime, LatestCancellationTime)
VALUES ('R0001', 30, 2, 10, 20, 1, 1);
GO

INSERT INTO TICKETCLASS (TicketClassCode, TicketClassName, PricePercentage)
VALUES 
    ('TC0001', N'Phổ thông', 100),
    ('TC0002', N'Thương gia', 105)
GO

DELETE FROM TICKETCLASS
SELECT * FROM TICKETCLASS