USE FlightTicketManagement
GO

SET DATEFORMAT dmy
GO

INSERT INTO Parameters (ParametersID, MinimumFlightTime, MaxPreventiveAirports, MinimumStopoverTime, MaximumStopoverTime, EarliestBookingTime, LatestBookingCancellationTime)
VALUES ('PA', 30, 2, 10, 20, 1, 1);
GO

INSERT INTO TICKET_CLASS (TicketClassID, TicketClassName, PricePercentage)
VALUES 
    ('TC0001', N'Phổ thông', 100),
    ('TC0002', N'Thương gia', 105)
GO

INSERT INTO AIRPORT (AirportID, AirportName, CityName, CountryName)
VALUES
	('AP0001', N'Sân bay Quốc tế Tân Sơn Nhất', N'Thành phố Hồ Chí Minh', N'Việt Nam'),
	('AP0002', N'Sân bay Quốc tế Nội Bài', N'Hà Nội', N'Việt Nam'),
	('AP0003', N'Sân bay Quốc tế Đà Nẵng', N'Đà Nẵng', N'Việt Nam'),
	('AP0004', N'Sân bay Cam Ranh', N'Khánh Hòa', N'Việt Nam'),
	('AP0005', N'Sân bay Phú Quốc', N'Phú Quốc', N'Việt Nam'),
	('AP0006', N'Sân bay Điện Biên', N'Điện Biên Phủ', N'Việt Nam'),
	('AP0007', N'Sân bay Cần Thơ', N'Cần Thơ', N'Việt Nam'),
	('AP0008', N'Sân bay Cát Bi', N'Hải Phòng', N'Việt Nam'),
	('AP0009', N'Sân bay Suvarnabhumi', N'Bangkok', N'Thái Lan'),
	('AP0010', N'Sân bay Changi', N'Singapore', N'Singapore')
GO
