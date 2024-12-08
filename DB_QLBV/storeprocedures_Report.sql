﻿CREATE PROC SP_TIMBENHNHAN_DANGDUOCDIEUTRI
AS 
SELECT * FROM BENHNHAN WHERE MAPHG IS NOT NULL ; 
GO 
--EXEC SP_TIMBENHNHAN_DANGDUOCDIEUTRI
GO 

CREATE PROC SP_TIMTHONGTINBENHNHAN (@MABN CHAR(20))
AS
 SELECT BENHNHAN.MABN, BENHNHAN.HOBN, BENHNHAN.TENBN , BENHNHAN.SODTH, BENHNHAN.DIACHI, BENHNHAN.PHAI, BENHNHAN.MAPHG AS N'PHÒNG ĐIỀU TRỊ' ,BENHAN.KETQUA AS N'KẾT QUẢ BỆNH ÁN' 
 FROM BENHNHAN , BENHAN
 WHERE BENHAN.MABN= BENHNHAN.MABN AND BENHNHAN.MABN = @MABN ; 
 GO 
-- EXEC SP_TIMTHONGTINBENHNHAN 'BN00010'
 GO 
 CREATE PROC SP_TIMTHONGTINBENHNHAN_DIKHAMBENH(@MAPK CHAR (20), @MAK CHAR(20))
 AS
 SELECT *
 FROM BENHNHAN BN , KHOA K , PHONGKHAM PHGK , PKHAM_BENHNHAN PK_BN
 WHERE  PHGK.MAPK = @MAPK AND K.MAK = @MAK AND PK_BN.MABN = BN.MABN AND PK_BN.MAPK = PHGK.MAPK  AND PHGK.MAK = K.MAK
 GO 
 EXEC SP_TIMTHONGTINBENHNHAN_DIKHAMBENH'PK01','KH0001'
 GO 