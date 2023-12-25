USE FlightTicketManagement
GO

SET DATEFORMAT dmy
GO

--Tạo giá trị cho "Tham Số"
INSERT INTO Parameters (ParametersID, MinimumFlightTime, MaxPreventiveAirports, MinimumStopoverTime, MaximumStopoverTime, EarliestBookingTime, LatestBookingCancellationTime)
VALUES ('PA', 30, 2, 10, 20, 1, 1);
GO

--Tạo giá trị cho "Quyền"
INSERT INTO PERMISSION (RoleID, RoleName, PermissionCode)
VALUES
	('RL0001', N'Siêu quản trị', '111111'),
	('RL0002', N'Quản trị', '000010'),
	('RL0003', N'Ban giám đốc', '101001'),
	('RL0004', N'Nhân viên', '111100')
GO

--Tạo giá trị cho "Tài Khoản"
INSERT INTO ACCOUNT (AccountID, Name, Phone, Email, Password, Created, RoleID)
VALUES
  ('AC0001', N'Huỳnh Mai Cao Nhân', '123456789', 'tinhoctrevnnhan@gmail.com', '1', '1/1/2023', 'RL0001'),
  ('AC0002', N'Huỳnh Mai Cao Nhân', '987654321', 'test1@gmail.com', '1', '1/1/2023', 'RL0002'),
  ('AC0003', N'Huỳnh Mai Cao Nhân', '555555555', 'test2@gmail.com', '1', '1/1/2023', 'RL0003'),
  ('AC0004', N'Huỳnh Mai Cao Nhân', '999999999', 'test3@gmail.com', '1', '1/1/2023', 'RL0004');
GO

--Tạo giá trị cho "Hạng Vé"
INSERT INTO TICKET_CLASS (TicketClassID, TicketClassName, PricePercentage)
VALUES 
    ('TC0001', N'Phổ thông', 100),
    ('TC0002', N'Thương gia', 105)
GO

--Tạo giá trị cho "Sân Bay"
INSERT INTO AIRPORT (AirportID, AirportName, CityName, CountryName)
VALUES
	('AP0001', N'Sân bay Quốc tế Tân Sơn Nhất', N'Hồ Chí Minh', N'Việt Nam'),
	('AP0002', N'Sân bay Quốc tế Nội Bài', N'Hà Nội', N'Việt Nam'),
	('AP0003', N'Sân bay Quốc tế Đà Nẵng', N'Đà Nẵng', N'Việt Nam'),
	('AP0004', N'Sân bay Cam Ranh', N'Khánh Hòa', N'Việt Nam'),
	('AP0005', N'Sân bay Phú Quốc', N'Phú Quốc', N'Việt Nam'),
	('AP0006', N'Sân bay Điện Biên', N'Điện Biên Phủ', N'Việt Nam'),
	('AP0007', N'Sân bay Cần Thơ', N'Cần Thơ', N'Việt Nam'),
	('AP0008', N'Sân bay Cát Bi', N'Hải Phòng', N'Việt Nam')
GO

--Tạo giá trị cho "Máy Bay"
INSERT INTO PLANE (PlaneID, PlaneName, SeatCount)
VALUES 
	('PE0001', N'Phi cơ 1', 18),
	('PE0002', N'Phi cơ 2', 36),
	('PE0003', N'Phi cơ 3', 60)
GO

--Tạo giá trị cho "Ghế"
INSERT INTO SEAT (SeatID, PlaneID, TicketClassID) VALUES
	('A1', 'PE0001', 'TC0002'),
	('A2', 'PE0001', 'TC0002'),
	('A3', 'PE0001', 'TC0002'),
	('A4', 'PE0001', 'TC0002'),
	('A5', 'PE0001', 'TC0002'),
	('A6', 'PE0001', 'TC0002'),
	('B1', 'PE0001', 'TC0001'),
	('B2', 'PE0001', 'TC0001'),
	('B3', 'PE0001', 'TC0001'),
	('B4', 'PE0001', 'TC0001'),
	('B5', 'PE0001', 'TC0001'),
	('B6', 'PE0001', 'TC0001'),
	('C1', 'PE0001', 'TC0001'),
	('C2', 'PE0001', 'TC0001'),
	('C3', 'PE0001', 'TC0001'),
	('C4', 'PE0001', 'TC0001'),
	('C5', 'PE0001', 'TC0001'),
	('C6', 'PE0001', 'TC0001')
GO

INSERT INTO SEAT (SeatID, PlaneID, TicketClassID) VALUES
	('A1', 'PE0002', 'TC0002'),
	('A2', 'PE0002', 'TC0002'),
	('A3', 'PE0002', 'TC0002'),
	('A4', 'PE0002', 'TC0002'),
	('A5', 'PE0002', 'TC0002'),
	('A6', 'PE0002', 'TC0002'),
	('B1', 'PE0002', 'TC0002'),
	('B2', 'PE0002', 'TC0002'),
	('B3', 'PE0002', 'TC0001'),
	('B4', 'PE0002', 'TC0001'),
	('B5', 'PE0002', 'TC0001'),
	('B6', 'PE0002', 'TC0001'),
	('C1', 'PE0002', 'TC0001'),
	('C2', 'PE0002', 'TC0001'),
	('C3', 'PE0002', 'TC0001'),
	('C4', 'PE0002', 'TC0001'),
	('C5', 'PE0002', 'TC0001'),
	('C6', 'PE0002', 'TC0001'),
	('D1', 'PE0002', 'TC0001'),
	('D2', 'PE0002', 'TC0001'),
	('D3', 'PE0002', 'TC0001'),
	('D4', 'PE0002', 'TC0001'),
	('D5', 'PE0002', 'TC0001'),
	('D6', 'PE0002', 'TC0001'),
	('E1', 'PE0002', 'TC0001'),
	('E2', 'PE0002', 'TC0001'),
	('E3', 'PE0002', 'TC0001'),
	('E4', 'PE0002', 'TC0001'),
	('E5', 'PE0002', 'TC0001'),
	('E6', 'PE0002', 'TC0001'),
	('F1', 'PE0002', 'TC0001'),
	('F2', 'PE0002', 'TC0001'),
	('F3', 'PE0002', 'TC0001'),
	('F4', 'PE0002', 'TC0001'),
	('F5', 'PE0002', 'TC0001'),
	('F6', 'PE0002', 'TC0001');
GO

INSERT INTO SEAT (SeatID, PlaneID, TicketClassID) VALUES
	('A1', 'PE0003', 'TC0002'),
	('A2', 'PE0003', 'TC0002'),
	('A3', 'PE0003', 'TC0002'),
	('A4', 'PE0003', 'TC0002'),
	('A5', 'PE0003', 'TC0002'),
	('A6', 'PE0003', 'TC0002'),
	('B1', 'PE0003', 'TC0002'),
	('B2', 'PE0003', 'TC0002'),
	('B3', 'PE0003', 'TC0002'),
	('B4', 'PE0003', 'TC0002'),
	('B5', 'PE0003', 'TC0002'),
	('B6', 'PE0003', 'TC0002'),
	('C1', 'PE0003', 'TC0002'),
	('C2', 'PE0003', 'TC0002'),
	('C3', 'PE0003', 'TC0002'),
	('C4', 'PE0003', 'TC0002'),
	('C5', 'PE0003', 'TC0002'),
	('C6', 'PE0003', 'TC0002'),
	('D1', 'PE0003', 'TC0002'),
	('D2', 'PE0003', 'TC0002'),
	('D3', 'PE0003', 'TC0002'),
	('D4', 'PE0003', 'TC0002'),
	('D5', 'PE0003', 'TC0002'),
	('D6', 'PE0003', 'TC0002'),
	('E1', 'PE0003', 'TC0002'),
	('E2', 'PE0003', 'TC0002'),
	('E3', 'PE0003', 'TC0002'),
	('E4', 'PE0003', 'TC0002'),
	('E5', 'PE0003', 'TC0002'),
	('E6', 'PE0003', 'TC0002'),
	('F1', 'PE0003', 'TC0001'),
	('F2', 'PE0003', 'TC0001'),
	('F3', 'PE0003', 'TC0001'),
	('F4', 'PE0003', 'TC0001'),
	('F5', 'PE0003', 'TC0001'),
	('F6', 'PE0003', 'TC0001'),
	('G1', 'PE0003', 'TC0001'),
	('G2', 'PE0003', 'TC0001'),
	('G3', 'PE0003', 'TC0001'),
	('G4', 'PE0003', 'TC0001'),
	('G5', 'PE0003', 'TC0001'),
	('G6', 'PE0003', 'TC0001'),
	('H1', 'PE0003', 'TC0001'),
	('H2', 'PE0003', 'TC0001'),
	('H3', 'PE0003', 'TC0001'),
	('H4', 'PE0003', 'TC0001'),
	('H5', 'PE0003', 'TC0001'),
	('H6', 'PE0003', 'TC0001'),
	('I1', 'PE0003', 'TC0001'),
	('I2', 'PE0003', 'TC0001'),
	('I3', 'PE0003', 'TC0001'),
	('I4', 'PE0003', 'TC0001'),
	('I5', 'PE0003', 'TC0001'),
	('I6', 'PE0003', 'TC0001'),
	('J1', 'PE0003', 'TC0001'),
	('J2', 'PE0003', 'TC0001'),
	('J3', 'PE0003', 'TC0001'),
	('J4', 'PE0003', 'TC0001'),
	('J5', 'PE0003', 'TC0001'),
	('J6', 'PE0003', 'TC0001')
GO

--Tạo giá trị cho "Chuyến Bay"
INSERT INTO FLIGHT (FlightID, PlaneID, DepartureAirportCode, ArrivalAirportCode, TicketPrice, DepartureDateTime, FlightDuration) VALUES
	('FL0001', 'PE0001', 'AP0007', 'AP0008', 1977583, '01/01/2023 12:00:00', 39),
	('FL0002', 'PE0002', 'AP0005', 'AP0001', 1116973, '02/01/2023 12:00:00', 30),
	('FL0003', 'PE0003', 'AP0004', 'AP0002', 1418386, '03/01/2023 12:00:00', 60),
	('FL0004', 'PE0001', 'AP0002', 'AP0008', 534438, '04/01/2023 12:00:00', 52),
	('FL0005', 'PE0002', 'AP0004', 'AP0007', 1405647, '05/01/2023 12:00:00', 39),
	('FL0006', 'PE0003', 'AP0004', 'AP0006', 513244, '06/01/2023 12:00:00', 58),
	('FL0007', 'PE0001', 'AP0001', 'AP0004', 1485810, '01/02/2023 12:00:00', 41),
	('FL0008', 'PE0002', 'AP0005', 'AP0004', 895303, '02/02/2023 12:00:00', 60),
	('FL0009', 'PE0003', 'AP0002', 'AP0007', 657359, '03/02/2023 12:00:00', 44),
	('FL0010', 'PE0001', 'AP0007', 'AP0001', 548759, '04/02/2023 12:00:00', 45),
	('FL0011', 'PE0002', 'AP0001', 'AP0008', 654032, '05/02/2023 12:00:00', 37),
	('FL0012', 'PE0003', 'AP0008', 'AP0001', 1928611, '06/02/2023 12:00:00', 33),
	('FL0013', 'PE0001', 'AP0007', 'AP0006', 1278743, '04/03/2023 12:00:00', 50),
	('FL0014', 'PE0002', 'AP0005', 'AP0004', 1421362, '05/03/2023 12:00:00', 48),
	('FL0015', 'PE0003', 'AP0002', 'AP0007', 667920, '06/03/2023 12:00:00', 39),
	('FL0016', 'PE0001', 'AP0004', 'AP0003', 1279742, '07/03/2023 12:00:00', 42),
	('FL0017', 'PE0002', 'AP0004', 'AP0005', 1254944, '08/03/2023 12:00:00', 41),
	('FL0018', 'PE0003', 'AP0003', 'AP0007', 587623, '09/03/2023 12:00:00', 58),
	('FL0019', 'PE0001', 'AP0007', 'AP0008', 1726678, '04/04/2023 12:00:00', 33),
	('FL0020', 'PE0002', 'AP0008', 'AP0004', 1868255, '05/04/2023 12:00:00', 50),
	('FL0021', 'PE0003', 'AP0003', 'AP0004', 1872085, '06/04/2023 12:00:00', 52),
	('FL0022', 'PE0001', 'AP0008', 'AP0001', 1741934, '07/04/2023 12:00:00', 57),
	('FL0023', 'PE0002', 'AP0001', 'AP0004', 1724859, '08/04/2023 12:00:00', 30),
	('FL0024', 'PE0003', 'AP0004', 'AP0003', 1847546, '09/04/2023 12:00:00', 31),
	('FL0025', 'PE0001', 'AP0006', 'AP0007', 987748, '05/05/2023 12:00:00', 36),
	('FL0026', 'PE0002', 'AP0005', 'AP0002', 501962, '06/05/2023 12:00:00', 31),
	('FL0027', 'PE0003', 'AP0003', 'AP0001', 1532586, '07/05/2023 12:00:00', 46),
	('FL0028', 'PE0001', 'AP0007', 'AP0005', 995944, '08/05/2023 12:00:00', 47),
	('FL0029', 'PE0002', 'AP0007', 'AP0006', 1050540, '09/05/2023 12:00:00', 44),
	('FL0030', 'PE0003', 'AP0002', 'AP0004', 1332828, '10/05/2023 12:00:00', 47),
	('FL0031', 'PE0001', 'AP0007', 'AP0008', 1119432, '05/06/2023 12:00:00', 39),
	('FL0032', 'PE0002', 'AP0006', 'AP0001', 1604067, '06/06/2023 12:00:00', 59),
	('FL0033', 'PE0003', 'AP0004', 'AP0001', 985044, '07/06/2023 12:00:00', 45),
	('FL0034', 'PE0001', 'AP0002', 'AP0004', 915122, '08/06/2023 12:00:00', 36),
	('FL0035', 'PE0002', 'AP0006', 'AP0002', 1401089, '09/06/2023 12:00:00', 44),
	('FL0036', 'PE0003', 'AP0006', 'AP0005', 1742100, '10/06/2023 12:00:00', 56),
	('FL0037', 'PE0001', 'AP0003', 'AP0008', 1716368, '06/07/2023 12:00:00', 59),
	('FL0038', 'PE0002', 'AP0002', 'AP0001', 1840184, '07/07/2023 12:00:00', 51),
	('FL0039', 'PE0003', 'AP0007', 'AP0006', 1713533, '08/07/2023 12:00:00', 57),
	('FL0040', 'PE0001', 'AP0008', 'AP0005', 1314466, '09/07/2023 12:00:00', 40),
	('FL0041', 'PE0002', 'AP0005', 'AP0006', 1195338, '10/07/2023 12:00:00', 57),
	('FL0042', 'PE0003', 'AP0002', 'AP0003', 962978, '11/07/2023 12:00:00', 47),
	('FL0043', 'PE0001', 'AP0007', 'AP0001', 1994137, '06/08/2023 12:00:00', 59),
	('FL0044', 'PE0002', 'AP0001', 'AP0003', 1070946, '07/08/2023 12:00:00', 54),
	('FL0045', 'PE0003', 'AP0008', 'AP0004', 600201, '08/08/2023 12:00:00', 39),
	('FL0046', 'PE0001', 'AP0008', 'AP0005', 1147429, '09/08/2023 12:00:00', 30),
	('FL0047', 'PE0002', 'AP0004', 'AP0005', 1176938, '10/08/2023 12:00:00', 45),
	('FL0048', 'PE0003', 'AP0005', 'AP0006', 542479, '11/08/2023 12:00:00', 57),
	('FL0049', 'PE0001', 'AP0003', 'AP0005', 1258774, '06/09/2023 12:00:00', 31),
	('FL0050', 'PE0002', 'AP0007', 'AP0006', 1544377, '07/09/2023 12:00:00', 49),
	('FL0051', 'PE0003', 'AP0004', 'AP0003', 1300260, '08/09/2023 12:00:00', 35),
	('FL0052', 'PE0001', 'AP0007', 'AP0001', 1786125, '09/09/2023 12:00:00', 56),
	('FL0053', 'PE0002', 'AP0002', 'AP0003', 1033152, '10/09/2023 12:00:00', 48),
	('FL0054', 'PE0003', 'AP0008', 'AP0001', 656491, '11/09/2023 12:00:00', 53),
	('FL0055', 'PE0001', 'AP0001', 'AP0003', 1016989, '07/10/2023 12:00:00', 47),
	('FL0056', 'PE0002', 'AP0005', 'AP0006', 623610, '08/10/2023 12:00:00', 52),
	('FL0057', 'PE0003', 'AP0005', 'AP0003', 1649257, '09/10/2023 12:00:00', 49),
	('FL0058', 'PE0001', 'AP0007', 'AP0001', 1488913, '10/10/2023 12:00:00', 53),
	('FL0059', 'PE0002', 'AP0001', 'AP0004', 1382001, '11/10/2023 12:00:00', 54),
	('FL0060', 'PE0003', 'AP0003', 'AP0007', 1774399, '12/10/2023 12:00:00', 38),
	('FL0061', 'PE0001', 'AP0002', 'AP0006', 1335836, '07/11/2023 12:00:00', 49),
	('FL0062', 'PE0002', 'AP0008', 'AP0002', 1149533, '08/11/2023 12:00:00', 33),
	('FL0063', 'PE0003', 'AP0001', 'AP0003', 1802366, '09/11/2023 12:00:00', 49),
	('FL0064', 'PE0001', 'AP0005', 'AP0002', 657739, '10/11/2023 12:00:00', 38),
	('FL0065', 'PE0002', 'AP0006', 'AP0004', 1640275, '11/11/2023 12:00:00', 46),
	('FL0066', 'PE0003', 'AP0005', 'AP0004', 1789792, '12/11/2023 12:00:00', 45)
GO

--Tạo giá trị cho "Chi Tiết Hạng Vé Chuyến Bay"
DECLARE @i INT = 1;
WHILE @i <= 132
BEGIN
    DECLARE @flightID NVARCHAR(50) = 'FL' + RIGHT('0000' + CAST((@i + 1) / 2 AS NVARCHAR(50)), 4);
    DECLARE @ticketClassID NVARCHAR(50) = CASE WHEN @i % 2 = 0 THEN 'TC0002' ELSE 'TC0001' END;
    
	DECLARE @price DECIMAL(10, 2);
	SELECT @price = 
		CASE WHEN @i % 2 = 0 THEN 105 * TicketPrice / 100 
		ELSE TicketPrice
	END
	FROM FLIGHT
	WHERE FlightID = @flightID

	DECLARE @seatCapacity INT;
	SELECT @seatCapacity = SeatCount
	FROM PLANE p
	INNER JOIN FLIGHT f on p.PlaneID = f.PlaneID
	WHERE f.FlightID = @flightID

	DECLARE @ticketSold INT = CASE WHEN @i % 2 = 0 THEN 2 ELSE 0 END
	DECLARE @seatRemaining INT = @seatCapacity - @ticketSold

    INSERT INTO FLIGHT_TICKET_CLASS_DETAIL (FlightID, TicketClassID, Fare, SeatCapacity, TicketSold, SeatRemaining)
    VALUES (@flightID, @ticketClassID, @price, @seatCapacity, @ticketSold, @seatRemaining);

    SET @i = @i + 1;
END

-- Tạo giá trị cho "Vé chuyến bay"

-- Khởi tạo danh sách tên
DECLARE @names TABLE (ID INT IDENTITY(1,1), FullName NVARCHAR(50));
INSERT INTO @names (FullName) VALUES (N'Huỳnh Mai Cao Nhân'), (N'Đỗ Nguyễn Anh Khoa'), (N'Nguyễn Phúc Khang'), (N'Lý Nam Kháng'), (N'Trần Văn Toán');

-- Thêm dữ liệu vào bảng FLIGHT_TICKET
DECLARE @i INT = 1;
WHILE @i <= 132
BEGIN
    DECLARE @flightTicketID NVARCHAR(50) = 'TK' + RIGHT('0000' + CAST(@i AS NVARCHAR(50)), 4);
    DECLARE @flightID NVARCHAR(50) = 'FL' + RIGHT('0000' + CAST((@i + 1) / 2 AS NVARCHAR(50)), 4);
    DECLARE @ticketClassID NVARCHAR(50) = 'TC0002'
    DECLARE @price DECIMAL(10, 2);
	
	SELECT @price = 105 * TicketPrice / 100
	FROM FLIGHT
	WHERE FlightID = @flightID

    DECLARE @fullName NVARCHAR(255) = (SELECT FullName FROM @names WHERE ID = ((@i-1) % 5) + 1);
    DECLARE @idCard NVARCHAR(50) = CAST((ABS(CHECKSUM(NEWID())) % 900000000) + 100000000 AS NVARCHAR(9));
    DECLARE @phoneNumber NVARCHAR(50) = '0' + CAST((ABS(CHECKSUM(NEWID())) % 900000000) + 100000000 AS NVARCHAR(9));
    DECLARE @email NVARCHAR(255) = 'user' + CAST(@i AS NVARCHAR(255)) + '@example.com';
    DECLARE @seatID NVARCHAR(50) = CASE WHEN @i % 2 = 0 THEN 'A1' ELSE 'B1' END;
    DECLARE @flightStatus NVARCHAR(255) = N'Đã đặt chỗ';

    INSERT INTO FLIGHT_TICKET (FlightTicketID, FlightID, TicketClassID, Price, FullName, IDCard, PhoneNumber, Email, SeatID, FlightStatus)
    VALUES (@flightTicketID, @flightID, @ticketClassID, @price, @fullName, @idCard, @phoneNumber, @email, @seatID, @flightStatus);

    SET @i = @i + 1;
END