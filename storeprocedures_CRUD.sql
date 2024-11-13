﻿-- TẠO STORE PROCEDURES BÁC SĨ 
CREATE PROC SP_THEMBACSI (@MABS CHAR (20) ,@HOBS NVARCHAR(30), @TENBS NVARCHAR (30) ,  @CHUCVU NVARCHAR (20) , @MaK CHAR (20))
AS
INSERT INTO BACSI VALUES (@MABS  ,@HOBS , @TENBS  ,  @CHUCVU  , @MaK)
GO 

--EXEC SP_THEMBACSI ''
GO 

-- XOÁ 
CREATE PROC SP_XOABACSI (@MABS CHAR (20))
AS 
DELETE BACSI WHERE MABS = @MABS 
GO 

-- SỬA
CREATE PROC SP_SUABACSI(@MABS CHAR (20) ,@HOBS NVARCHAR(30), @TENBS NVARCHAR (30) ,  @CHUCVU NVARCHAR (20) , @MaK CHAR (20))
AS
 UPDATE BACSI 
 SET HOBS = @HOBS 
    ,TENBS = @TENBS 
	,CHUCVU = @CHUCVU 
	, MaK = @MaK
 WHERE MABS = @MABS
 GO 

 -- TẠO STORE PROCEDURES BỆNH ÁN 
 CREATE  PROC SP_THEMBENHAN (@MABA CHAR (20)  ,@MABN CHAR (20), @KETQUA NVARCHAR (50))
 AS 
 INSERT INTO BENHAN VALUES (@MABA   ,@MABN , @KETQUA )
 GO 

	-- XOÁ 
CREATE PROC SP_XOABENHAN (@MABA CHAR (20))
AS 
DELETE BENHAN WHERE MABA = @MABA
GO 

-- SỬA 
CREATE PROC SP_SUABENHAN (@MABA CHAR (20)  ,@MABN CHAR (20), @KETQUA NVARCHAR (50))
AS
UPDATE BENHAN 
SET MABN = @MABN 
   ,KETQUA = @KETQUA 
WHERE MABA = @MABA 
GO 

 -- TẠO STORE PROCEDURES BỆNH NHÂN  
 CREATE  PROC SP_THEMBENHNHAN (@MABN CHAR (20), @HOBN NVARCHAR(30), @TENBN NVARCHAR (30), @SODTH VARCHAR(11), 
                               @DIACHI NVARCHAR(50), @NGAYSINH DATETIME , @PHAI NVARCHAR(10), @MAPHG CHAR (20))
 AS 
 INSERT INTO BENHNHAN VALUES (@MABN, @HOBN, @TENBN, @SODTH, @DIACHI, @NGAYSINH, @PHAI, @MAPHG )
 GO 

	-- XOÁ 
CREATE PROC SP_XOABENHNHAN (@MABN CHAR (20))
AS 
DELETE BENHNHAN WHERE MABN = @MABN
GO 

-- SỬA 
CREATE PROC SP_SUABENHNHAN (@MABN CHAR (20), @HOBN NVARCHAR(30), @TENBN NVARCHAR (30), @SODTH VARCHAR(11), 
                            @DIACHI NVARCHAR(50), @NGAYSINH DATETIME , @PHAI NVARCHAR(10), @MAPHG CHAR (20))
AS
UPDATE BENHNHAN
SET HOBN = @HOBN , 
    TENBN = @TENBN , 
	SODTH = @SODTH , 
	DIACHI = @DIACHI , 
	NGAYSINH = @NGAYSINH , 
	PHAI = @PHAI , 
	MAPHG = @MAPHG
WHERE MABN = @MABN 
GO 

 -- TẠO STORE PROCEDURES BẢO HIỂM Y TẾ 
 CREATE  PROC SP_THEMBHYT (@MABHYT CHAR (15), @MABN CHAR (20), @NGAYCAP DATE, @NGAYHETHAN DATE)
 AS 
 INSERT INTO BHYT VALUES (@MABHYT, @MABN, @NGAYCAP, @NGAYHETHAN )
 GO 

	-- XOÁ 
CREATE PROC SP_XOABHYT (@MABHYT CHAR (15))
AS 
DELETE BHYT WHERE MABHYT = @MABHYT
GO 

-- SỬA 
CREATE PROC SP_SUABHYT (@MABHYT CHAR (15), @MABN CHAR (20), @NGAYCAP DATE, @NGAYHETHAN DATE)
AS
UPDATE BHYT 
SET MABN = @MABN 
   ,NGAYCAP = @NGAYCAP
   , NGAYHETHAN = @NGAYHETHAN
WHERE MABHYT = @MABHYT 
GO 

 -- TẠO STORE PROCEDURES DỊCH VỤ  
 CREATE  PROC SP_THEMDV (@MADV CHAR (20), @TENDV NVARCHAR (100), @GIA MONEY)
 AS 
 INSERT INTO DICHVU VALUES (@MADV   ,@TENDV , @GIA )
 GO 

	-- XOÁ 
CREATE PROC SP_XOADV (@MADV CHAR (20))
AS 
DELETE DICHVU WHERE MADV = @MADV
GO 

-- SỬA 
CREATE PROC SP_SUADV (@MADV CHAR (20), @TENDV NVARCHAR (100), @GIA MONEY)
AS
UPDATE DICHVU 
SET TENDV = @TENDV
   ,GIA = @GIA 
WHERE MADV = @MADV
GO 

 -- TẠO STORE PROCEDURES ĐIỀU TRỊ 
 CREATE  PROC SP_THEMDIEUTRI (@MAK CHAR(20) ,@MABN CHAR (20))
 AS 
 INSERT INTO DIEUTRI VALUES (@MAK ,@MABN )
 GO 

	-- XOÁ 
CREATE PROC SP_XOADIEUTRI (@MAK CHAR(20) ,@MABN CHAR (20))
AS 
DELETE DIEUTRI WHERE MAK = @MAK AND MABN = @MABN
GO 

-- SỬA 
--CREATE PROC SP_SUADIEUTRI (@MAK CHAR(20) ,@MABN CHAR (20))
--AS
--UPDATE DIEUTRI
--SET 
--WHERE  MAK = @MAK AND MABN = @MABN
--GO 