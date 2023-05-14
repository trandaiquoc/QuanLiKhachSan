﻿USE QLKS
GO
--FUNCTION
CREATE OR ALTER 
FUNCTION UF_TONGTIENPHONG (@MAPHIEU INT)
RETURNS FLOAT
AS
BEGIN
	RETURN (SELECT P.GIA * PDP.SODEMLUUTRU FROM PHONG P JOIN PHIEUDATPHONG PDP ON P.MAPHONG = PDP.PHONG WHERE PDP.MAPHIEU = @MAPHIEU)
END
GO
---------------------------------------
CREATE OR ALTER 
FUNCTION UF_TONGTIENDICHVU (@MAPHIEU INT)
RETURNS FLOAT
AS
BEGIN
	RETURN (SELECT SUM (DV.GIA) FROM CHITIETPHIEUDV DV JOIN PHIEUDICHVU PDV ON DV.MAPHIEU = PDV.MAPHIEU WHERE PDV.MAPHIEU = @MAPHIEU)
END
GO
-----------------------------------------
CREATE OR ALTER 
FUNCTION UDF_GETNUM (@IN VARCHAR(255))
RETURNS INT
AS
BEGIN
	DECLARE @ALPHABETINDEX INT = PATINDEX('%[^0-9]%', @IN)  
	BEGIN  
		WHILE @ALPHABETINDEX > 0  
		BEGIN  
			SET @IN = STUFF(@IN, @ALPHABETINDEX, 1, '' )  
			SET @ALPHABETINDEX = PATINDEX('%[^0-9]%', @IN)
		END  
	END
	RETURN CAST(@IN AS INT)
END
GO
--PROCEDURE-----------------------------------------------------------------------------
--DÙNG CHUNG----------------------------------------------------------------------------
--ĐĂNG KÝ TÀI KHOẢN---------------------------------------------------------------------
CREATE OR ALTER
PROC SP_DANGKYTAIKHOAN
	@USERNAME VARCHAR(100),
	@PASSWORD VARCHAR(100),
	@PASSWORDCHECK VARCHAR(100)
AS
BEGIN
	IF @USERNAME = '' OR @PASSWORD = '' OR @PASSWORDCHECK = ''
	BEGIN
		PRINT N'Không nhập đầy đủ thông tin để đăng ký'
		RETURN 1
	END
	IF EXISTS (SELECT 1 FROM TAIKHOAN WHERE USERNAME = @USERNAME)
	BEGIN
		PRINT N'Tên tài khoản đã tồn tại'
		RETURN 2
	END

	IF @PASSWORD <> @PASSWORDCHECK
	BEGIN
		PRINT N'Mật Khẩu và Nhập Lại Mật Khẩu không trùng khớp'
		RETURN 3
	END

	--TẠO MÃ TÀI KHOẢN
	DECLARE @USERID INT = 0
	WHILE @USERID = 0 OR @USERID IN ( SELECT USERID FROM TAIKHOAN)
	BEGIN
		 SET @USERID += (SELECT MAX(MAKH) + 1 FROM KHACHHANG)
	END
	--THÊM TÀI KHOẢN
	INSERT INTO TAIKHOAN VALUES(@USERNAME,@PASSWORD,@USERID)
	--THÊM KHÁCH HÀNG
	INSERT INTO KHACHHANG(MAKH) VALUES(@USERID)
		
	IF @@ERROR <> 0 
		PRINT N'Đăng ký không thành công'
	ELSE
		PRINT N'Đăng ký thành công'
		RETURN 0
END
GO

--ĐĂNG NHẬP-----------------------------------------------------------------------------
CREATE OR ALTER
PROC SP_DANGNHAP
	@USERID VARCHAR(100),
	@PASSWORD VARCHAR(100)
AS
BEGIN
	IF @USERID = ''OR @PASSWORD = ''
	BEGIN
		PRINT N'Không nhập đầy đủ thông tin để đăng nhập'
		RETURN 1
	END
	IF NOT EXISTS (SELECT 1 FROM TAIKHOAN WHERE USERNAME = @USERID)
	BEGIN
		PRINT N'Tài khoản không tồn tại'
		RETURN 2
	END

	IF @PASSWORD <> (SELECT PASSWORD FROM TAIKHOAN WHERE USERNAME = @USERID)
	BEGIN
		PRINT N'Mật Khẩu Sai'
		RETURN 3
	END
	IF @@ERROR <> 0 
	BEGIN
		PRINT N'Đăng nhập không thành công'
		RETURN 4
	END
	ELSE
		PRINT N'Đăng nhập thành công'
		RETURN 0
END
GO
--KIỂM TRA LOẠI TÀI KHOẢN---------------------------------------------------------------
CREATE OR ALTER
PROC SP_CHECKTYPEACC
	@USERID INT
AS
BEGIN
	IF EXISTS (SELECT 1 FROM KHACHHANG WHERE MAKH = @USERID)
	BEGIN
		PRINT N'Khách hàng'
		RETURN 1
	END
	ELSE IF EXISTS (SELECT 1 FROM DOITAC WHERE MADT = @USERID)
	BEGIN
		PRINT N'Đối tác'
		RETURN 2
	END
	ELSE IF EXISTS (SELECT 1 FROM NHANVIEN WHERE MANV = @USERID AND VAITRO = 'Letan')
	BEGIN
		PRINT N'Nhân Viên Lễ Tân'
		RETURN 3
	END
	ELSE IF EXISTS (SELECT 1 FROM NHANVIEN WHERE MANV = @USERID AND VAITRO = 'Bellman')
	BEGIN
		PRINT N'Nhân Viên Bellman'
		RETURN 4
	END
	ELSE IF EXISTS (SELECT 1 FROM NHANVIEN WHERE MANV = @USERID AND VAITRO = 'Vesinh')
	BEGIN
		PRINT N'Nhân Viên Dọn Vệ Sinh'
		RETURN 5
	END
	ELSE RETURN 0
END
GO
--KHÁCH HÀNG----------------------------------------------------------------------------
--KHÁCH HÀNG CẬP NHẬT THÔNG TIN---------------------------------------------------------
CREATE OR ALTER
PROC SP_KH_CAPNHATTHONGTIN
	@MAKH INT,
	@TEN NVARCHAR(100),
	@EMAIL NVARCHAR(100),
	@SDT NVARCHAR(20),
	@CMND NVARCHAR(20),
	@DIACHI NVARCHAR(100),
	@DK NVARCHAR(100)
AS 
	IF (SELECT ISNUMERIC(@SDT)) = 0
	BEGIN
		PRINT N'Số Điện Thoại chỉ có số'
		RETURN 1
	END
	IF (SELECT ISNUMERIC(@CMND)) = 0
	BEGIN
		PRINT N'CCCD chỉ có số'
		RETURN 2
	END
	IF EXISTS(SELECT CMND FROM KHACHHANG WHERE CMND = @CMND)
	BEGIN
		PRINT N'CMND/CCCD/HC ' + @CMND + N' đã tồn tại'
		RETURN 3
	END 
	UPDATE KHACHHANG
	SET TEN = @TEN,
	    EMAIL = @EMAIL,
	    SDT = @SDT,
	    CMND = @CMND,
		DIACHI = @DIACHI,
		DOANKHACH = @DK
	WHERE MAKH = @MAKH
	RETURN 0
GO
--ĐẶT PHÒNG-----------------------------------------------------------------------------
CREATE OR ALTER
PROC SP_KH_DATPHONG
	@MAKH INT,
	@NVLAPPHIEU INT,
	@PHONG VARCHAR(5),
	@NGAYDEN VARCHAR(10),
	@SODEMLUUTRU INT,
	@YEUCAUKHACHHANG NVARCHAR(100),
	@LOAIPHONG NVARCHAR(20)
AS 
	IF @NVLAPPHIEU = 0
	BEGIN
		SET @NVLAPPHIEU = NULL;
	END
	IF @NGAYDEN = '' OR @SODEMLUUTRU = ''
	BEGIN
		PRINT N'Phải nhập ngày đến và sô đêm lưu trú'
		RETURN 1
	END
	--TAO MAPHIEU
	DECLARE @PHIEU INT = 0
	WHILE @PHIEU = 0 OR @PHIEU IN ( SELECT MAPHIEU FROM PHIEU)
	BEGIN
		 SET @PHIEU += (SELECT MAX(MAPHIEU) + 1 FROM PHIEU)
	END
	--TẠO MAHD
	DECLARE @MAHD INT = 0
	WHILE @MAHD = 0 OR @MAHD IN ( SELECT MAHD FROM HOADON)
	BEGIN
		 SET @MAHD += (SELECT MAX(MAHD) + 1 FROM HOADON)
	END
	--THÊM PHIẾU
	INSERT INTO PHIEU VALUES (@PHIEU,@MAKH,@NVLAPPHIEU);
	--THÊM PHIẾU ĐẶT PHÒNG
	INSERT INTO PHIEUDATPHONG VALUES (@PHIEU, @PHONG, N'HOÀN THÀNH', convert(datetime, @NGAYDEN, 101), @SODEMLUUTRU, @YEUCAUKHACHHANG, @LOAIPHONG)
	--THÊM HÓA ĐƠN
	INSERT INTO HOADON VALUES (@MAHD,@MAKH, DBO.UF_TONGTIENPHONG(@PHIEU), DBO.UF_TONGTIENPHONG(@PHIEU) * 30/100, NULL, N'CTT', NULL, @PHIEU, NULL)
	--SỬA TÌNH TRẠNG PHÒNG
	UPDATE PHONG
	SET TINHTRANG = N'ĐẦY'
	WHERE MAPHONG = @PHONG
	IF @@ERROR <> 0 
	BEGIN
		PRINT N'Tạo không thành công'
		RETURN 2
	END
	ELSE
		PRINT N'Thành công'
		RETURN 0
GO
--ĐẶT DỊCH VỤ-----------------------------------------------------------------------------
CREATE OR ALTER
PROC SP_KH_TAOPHIEUDV
	@MAKH INT
AS 
	--TAO MAPHIEU
	DECLARE @PHIEU INT = 0
	WHILE @PHIEU = 0 OR @PHIEU IN ( SELECT MAPHIEU FROM PHIEUDICHVU)
	BEGIN
		 SET @PHIEU += (SELECT MAX(MAPHIEU) + 1 FROM PHIEUDICHVU)
	END
	--THÊM PHIẾU DỊCH VỤ
	INSERT INTO PHIEUDICHVU VALUES (@PHIEU,@MAKH,GETDATE(),NULL,NULL);
	IF @@ERROR <> 0 
	BEGIN
		PRINT N'Tạo không thành công'
	END
	ELSE
		PRINT N'Thành công'
		SELECT @PHIEU
GO
--CHỌN DVTT-------------------------------------------------------------------------------
CREATE OR ALTER
PROC SP_KH_CHONDVTT
	@MAPHIEU INT,
	@MADV VARCHAR(5),
	@LDK NVARCHAR(20)
AS 
	IF @LDK =''
	BEGIN
		RETURN 1
	END
	--THÊM CHI TIẾT PHIẾU DỊCH VỤ
	INSERT INTO CHITIETPHIEUDV VALUES (@MAPHIEU,@MADV,@LDK,(SELECT GIA FROM DICHVU WHERE MADV = @MADV),NULL, NULL, 'CXN');
	RETURN 0
GO
--CHỌN DVT-------------------------------------------------------------------------------
CREATE OR ALTER
PROC SP_KH_CHONDVT
	@MAPHIEU INT,
	@MADV VARCHAR(5),
	@LDK NVARCHAR(20),
	@SNTG INT,
	@VANCHUYEN NVARCHAR(5)
AS 
	IF @LDK =''
	BEGIN
		RETURN 1
	END
	IF @SNTG =''
	BEGIN
		RETURN 2
	END
	IF @VANCHUYEN =''
	BEGIN
		RETURN 3
	END
	IF @SNTG > (SELECT SOLUONGTOIDA FROM DICHVUTOUR WHERE MADV = @MADV)
	BEGIN
		RETURN 4
	END

	--THÊM CHI TIẾT PHIẾU DỊCH VỤ
	DECLARE @VC BIT
	IF @VANCHUYEN = 'CÓ'
		SET @VC = 1
	ELSE
		SET @VC = 0
	INSERT INTO CHITIETPHIEUDV VALUES (@MAPHIEU,@MADV,@LDK,(SELECT GIA FROM DICHVU WHERE MADV = @MADV),@SNTG, @VC, 'CXN');
	RETURN 0
GO
--HỦY ĐƠN DỊCH VỤ-------------------------------------------------------------------------
CREATE OR ALTER
PROC SP_KH_HUY
	@MAPHIEU INT
AS 
	
	DELETE FROM CHITIETPHIEUDV WHERE MAPHIEU = @MAPHIEU
	DELETE FROM PHIEUDICHVU WHERE MAPHIEU = @MAPHIEU
	IF @@ERROR <> 0 
	BEGIN
		PRINT N'Không thành công'
	END
	ELSE
		PRINT N'Thành công'
GO
--XÁC NHẬN ĐƠN DỊCH VỤ---------------------------------------------------------------------
CREATE OR ALTER
PROC SP_KH_XACNHAN
	@MAPHIEU INT,
	@MAKH INT

AS 
	
	UPDATE PHIEUDICHVU
	SET TONGTIEN = DBO.UF_TONGTIENDICHVU(@MAPHIEU),
		SLDV = (SELECT COUNT(*) FROM CHITIETPHIEUDV WHERE MAPHIEU = @MAPHIEU)
	WHERE MAPHIEU = @MAPHIEU
	--TẠO MAHD
	DECLARE @MAHD INT = 0
	WHILE @MAHD = 0 OR @MAHD IN ( SELECT MAHD FROM HOADON)
	BEGIN
		 SET @MAHD += (SELECT MAX(MAHD) + 1 FROM HOADON)
	END

	INSERT INTO HOADON VALUES ( @MAHD, @MAKH, (SELECT TONGTIEN FROM PHIEUDICHVU WHERE MAPHIEU = @MAPHIEU), 0, NULL, 'CTT', NULL, NULL, @MAPHIEU)

	IF @@ERROR <> 0 
	BEGIN
		PRINT N'Không thành công'
	END
	ELSE
		PRINT N'Thành công'
GO
--THANH TOÁN-------------------------------------------------------------------------------
CREATE OR ALTER
PROC SP_KH_THANHTOAN
	@HTTT NVARCHAR(50),
	@MAKH INT

AS 
	IF @HTTT = ''
		RETURN 1
	ELSE
	BEGIN
		UPDATE HOADON
		SET HTTT = @HTTT,
			TINHTRANG = 'DTT',
			THOIGIAN = GETDATE()
		WHERE MAKH = @MAKH AND TINHTRANG = 'CTT'
	END
	IF @@ERROR <> 0 
	BEGIN
		PRINT N'Không thành công'
	END
	ELSE
		PRINT N'Thành công'
		RETURN 0
GO
--HỦY PHÒNG--------------------------------------------------------------------------------
CREATE OR ALTER
PROC SP_KH_HUYPHONG
	@MAPHIEU INT
AS 
	
	UPDATE PHIEUDATPHONG
	SET TINHTRANG = N'Đã Hủy'
	WHERE MAPHIEU = @MAPHIEU

	UPDATE PHONG
	SET TINHTRANG = N'TRỐNG'
	WHERE MAPHONG = (SELECT PHONG FROM PHIEUDATPHONG WHERE MAPHIEU = @MAPHIEU)
	IF @@ERROR <> 0 
	BEGIN
		PRINT N'Không thành công'
	END
	ELSE
		PRINT N'Thành công'
GO

--ĐỐI TÁC----------------------------------------------------------------------------------
--ĐỐI TÁC CẬP NHẬT THÔNG TIN---------------------------------------------------------------
CREATE OR ALTER
PROC SP_DT_CAPNHATTHONGTIN
	@MADT INT,
	@TEN NVARCHAR(100),
	@EMAIL NVARCHAR(100),
	@SDT NVARCHAR(20),
	@DIACHI NVARCHAR(100)
AS 
	IF (SELECT ISNUMERIC(@SDT)) = 0
	BEGIN
		PRINT N'Số Điện Thoại chỉ có số'
		RETURN 1
	END
	UPDATE DOITAC
	SET TENDT = @TEN,
	    EMAIL = @EMAIL,
	    SDT = @SDT,
		DIACHITRUSOCHINH = @DIACHI,
		SLDV = (SELECT COUNT(*) FROM DICHVUTOUR WHERE MADT = @MADT)
	WHERE MADT = @MADT
	RETURN 0
GO
--ĐỐI TÁC THÊM DỊCH VỤ---------------------------------------------------------------------
CREATE OR ALTER
PROC SP_DT_THEM
	@MADT INT,
	@TEN NVARCHAR(100),
	@SLTD INT,
	@DIADIEM NVARCHAR(100),
	@GIA FLOAT,
	@LHD NVARCHAR(20)
AS 
	IF @TEN = '' OR @SLTD = '' OR @DIADIEM = '' OR @GIA = '' OR @LHD = ''
	BEGIN
		PRINT N'Thiếu thông tin để thêm'
		RETURN 1
	END
	--KHỞI TẠO MÃ DỊCH VỤ
	DECLARE @MADV VARCHAR(5) = 'DV'
	WHILE @MADV = 'DV' OR @MADV IN (SELECT MADV FROM DICHVU)
	BEGIN
		SET @MADV += CAST((SELECT MAX(DBO.UDF_GETNUM(MADV)) + 1 FROM DICHVU) AS VARCHAR)
	END
	--TẠO DV
	INSERT INTO DICHVU VALUES (@MADV, @TEN, @GIA, @LHD, 'TOUR')
	--TẠO DVT
	INSERT INTO DICHVUTOUR VALUES (@MADV, @MADT, @SLTD, @DIADIEM)
	RETURN 0
GO

--ĐỐI TÁC SỬA DỊCH VỤ----------------------------------------------------------------------
CREATE OR ALTER
PROC SP_DT_SUA
	@MADV VARCHAR(5),
	@TEN NVARCHAR(100),
	@SLTD INT,
	@DIADIEM NVARCHAR(100),
	@GIA FLOAT,
	@LHD NVARCHAR(20)
AS 
	UPDATE DICHVUTOUR 
	SET SOLUONGTOIDA = @SLTD,
		DIADIEM = @DIADIEM
	WHERE MADV = @MADV

	UPDATE DICHVU
	SET TENDV = @TEN,
		GIA = @GIA,
		LICHHOATDONG =  @LHD
	WHERE MADV = @MADV
GO
--ĐỐI TÁC XÓA DỊCH VỤ----------------------------------------------------------------------
CREATE OR ALTER
PROC SP_DT_XOA
	@MADV VARCHAR(5)
AS 
	DELETE FROM DICHVUTOUR
	WHERE MADV = @MADV
	DELETE FROM DICHVU
	WHERE MADV = @MADV
GO
--LỄ TÂN-----------------------------------------------------------------------------------
--LỄ TÂN THÊM KHÁCH HÀNG MỚI---------------------------------------------------------------
CREATE OR ALTER
PROC SP_LT_THEMKH
	@TEN NVARCHAR(100),
	@EMAIL NVARCHAR(100),
	@SDT NVARCHAR(20),
	@CMND NVARCHAR(20),
	@DIACHI NVARCHAR(100),
	@DK NVARCHAR(100)
AS 
	IF (SELECT ISNUMERIC(@SDT)) = 0
	BEGIN
		PRINT N'Số Điện Thoại chỉ có số'
		RETURN 1
	END
	IF (SELECT ISNUMERIC(@CMND)) = 0
	BEGIN
		PRINT N'CCCD chỉ có số'
		RETURN 2
	END
	IF EXISTS(SELECT CMND FROM KHACHHANG WHERE CMND = @CMND)
	BEGIN
		PRINT N'CMND/CCCD/HC ' + @CMND + N' đã tồn tại'
		RETURN 3
	END 
	--TẠO MÃ TÀI KHOẢN
	DECLARE @USERID INT = 0
	WHILE @USERID = 0 OR @USERID IN ( SELECT USERID FROM TAIKHOAN)
	BEGIN
		 SET @USERID += (SELECT MAX(MAKH) + 1 FROM KHACHHANG)
	END
	--THEM KH
	INSERT INTO KHACHHANG VALUES (@USERID, @TEN, @EMAIL, @SDT, @DIACHI, @CMND, @DK)
	RETURN 0
GO
--LỄ TÂN TẠO PHIẾU NHẬN PHÒNG--------------------------------------------------------------
CREATE OR ALTER
PROC SP_LT_PNP
	@MAPHIEU INT
AS 
	--THEM PHIEU
	INSERT INTO PHIEUNHANPHONG VALUES (@MAPHIEU, (SELECT PHONG FROM PHIEUDATPHONG WHERE MAPHIEU = @MAPHIEU), N'CHƯA NHẬN', NULL, NULL, NULL)
GO