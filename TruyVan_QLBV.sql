﻿-- Các câu truy vấn 


-- Các câu truy vấn đơn giản 

----1 Xuất danh sách mã các nhân viên làm việc trong khoa nội----------------------
SELECT MAK,MANV
FROM KHOA_NV
WHERE MAK=N'KH0001 '
GO
---2 Xuất  danh sách các bác sĩ đang làm việc ở khoa phụ sản----
SELECT MaK, MABS, HOBS,TENBS
FROM BACSI
WHERE MaK =N'KH0005' 
GO
--- 3 Cho biết danh sách bác sĩ không thuộc khoa ngoại----
SELECT K.MAK,  K.TENK, BS.MABS, BS.HOBS, BS.TENBS
FROM KHOA K, BACSI BS
WHERE K.MAK=BS.MaK AND  K.TENK NOT LIKE N'KHOA NGOẠI'
GO
-- 4 Xuất  danh sách các bệnh nhan khám hoặc điều trị ở mã khoa KH0001
SELECT * 
FROM BENHNHAN , DIEUTRI
WHERE DIEUTRI.MAK ='KH0001'  AND DIEUTRI.MABN=BENHNHAN.MABN
GO
-- 5 Xuất  danh sách các bệnh nhân là nữ
SELECT * 
FROM BENHNHAN 
WHERE BENHNHAN.PHAI=N'NỮ'
GO
-- 6 Xuất  danh sách các bệnh nhân nằm ở phòng 20 chỗ
SELECT * 
FROM BENHNHAN , PHONGDIEUTRI
WHERE PHONGDIEUTRI.MAPDT= BENHNHAN.MAPHG AND PHONGDIEUTRI.LOAIPHONG=N'20 CHỖ';
GO
-- GOM NHÓM 

-- 7 Cho biết số lượng bệnh an do bác sĩ có mã số ‘BS0001’ viết
SELECT BS.MABS,COUNT (BA.MABA) AS  'BENH AN DO BAC SI MA BS0001 VIET '
FROM BACSI BS, BENHAN BA ,LICHSU_BA LS
WHERE LS.MABA=BA.MABA AND LS.MABS=BS.MABS AND BS.MABS=N'BS0001'
GROUP BY BS.MABS
GO
--- 8 Cho biết số lượng nam trong phòng bệnh PHG005----
SELECT PDT.MAPDT,COUNT (BN.PHAI) AS  'SO BENH NHAN PHAI NAM '
FROM BENHNHAN BN, PHONGDIEUTRI PDT
WHERE BN.MAPHG=PDT.MAPDT AND PDT.MAPDT=N'PHG005 ' AND BN.PHAI=N'NAM'
GROUP BY PDT.MAPDT
GO

-- 9 Cho biết mã bệnh nhân cũng như họ và tên bệnh nhân có hồ sơ bệnh án bình thường
SELECT  BN.MABN , BN.HOBN , BN.TENBN
FROM BENHNHAN BN , BENHAN BA 
WHERE  BA.KETQUA= N'BÌNH THƯỜNG' AND BA.MABN=BN.MABN
GROUP BY BA.KETQUA , BN.MABN , BN.HOBN , BN.TENBN
GO
-- 10 Cho biết số lượng bệnh nhân mà bác sĩ có mã đang thăm khám BS0001
SELECT  COUNT(*) AS N'SỐ LƯỢNG BỆNH NHÂN MÀ BÁC SĨ CÓ MÃ BS001 ĐĂNG THĂM KHÁM'
FROM BENHNHAN BN , KHAM_BENH KB 
WHERE KB.MABS='BS0001' AND KB.MABN=BN.MABN 
GROUP BY KB.MABS 
GO
-- 11 Cho biết số lượng nhân viên đang làm việc tại khoa “KH0002”
SELECT  COUNT(*) AS N'SỐ LƯỢNG NHÂN VIÊN ĐANG LÀM VIỆC TẠI KHOA KH0002'
FROM NHANVIEN NV , KHOA K  , KHOA_NV KNV
WHERE K.MAK='KH0002' AND KNV.MAK=K.MAK AND KNV.MANV=NV.MANV
GROUP BY K.MAK
GO

-- LỒNG GOM NHÓM 

-- 12 Cho biết bệnh nhân già tuổi nhất
SELECT BN.MABN, BN.HOBN, BN.TENBN, YEAR(GETDATE()) - YEAR(BN.NGAYSINH) AS 'BENH NHAN LON TUOI NHAT'
FROM BENHNHAN BN
GROUP BY BN.MABN, BN.HOBN, BN.TENBN,YEAR(BN.NGAYSINH)
HAVING YEAR(GETDATE()) - YEAR(BN.NGAYSINH) = (
    SELECT MAX(YEAR(GETDATE()) - YEAR(BN1.NGAYSINH))
    FROM BENHNHAN BN1
)
-- 13 Cho biết loại thuốc nào có giá nhỏ hơn mức giá trung bình các loại thuốc--
SELECT TC.MATHUOC,TC.TENTHUOC,TC.GIA
FROM THUOC TC
GROUP BY TC.MATHUOC,TC.TENTHUOC,TC.GIA
HAVING  TC.GIA <(SELECT AVG( TC1.GIA)
FROM  THUOC TC1
)
GO
-- 14 Cho biết phòng nào hiện tại đang có nhiều bệnh nhân ở--
SELECT PG.MAPDT,PG.LOAIPHONG ,COUNT (*) AS'SO BENH NHAN'
FROM PHONGDIEUTRI PG, BENHNHAN BN 
WHERE BN.MAPHG = PG.MAPDT
GROUP BY PG.MAPDT,PG.LOAIPHONG
HAVING COUNT (*) >= ALL(SELECT  COUNT (*)
FROM PHONGDIEUTRI,BENHNHAN
WHERE BENHNHAN.MAPHG = PHONGDIEUTRI.MAPDT
GROUP BY PHONGDIEUTRI.MAPDT
)
GO
-- 15 Cho biết chức vụ nào mà các nhân viên đang làm việc nhiều nhất
SELECT NV.CHUCVU, COUNT(*) AS N'SỐ LƯỢNG NHÂN VIÊN '
FROM NHANVIEN NV 
GROUP BY NV.CHUCVU 
HAVING COUNT(*) >= ALL(SELECT COUNT(*)
FROM NHANVIEN
GROUP BY CHUCVU )
GO
-- 16 Cho biết bác sĩ nào không khám cho bệnh nhân nào
SELECT BS.MABS 
FROM BACSI BS , KHAM_BENH KB , BENHNHAN bn 
WHERE KB.MABS = BS.MABS AND KB.MABN=BN.MABN
GROUP BY BS.MABS
HAVING COUNT(*) < ALL(SELECT COUNT(*)
FROM BACSI  , KHAM_BENH  , BENHNHAN  
WHERE KHAM_BENH.MABS = BACSI.MABS AND KHAM_BENH.MABN=BENHNHAN.MABN
GROUP BY BACSI.MABS )
GO
--17 Cho biết nhân viên bắt đầu làm việc tại bệnh viện trễ hơn so với các nhân viên còn lại
SELECT NV.NGAYLV
FROM NHANVIEN NV 
GROUP BY NV.NGAYLV
HAVING NV.NGAYLV >=ALL(SELECT NGAYLV
FROM NHANVIEN
GROUP BY NHANVIEN.NGAYLV )
GO
--18  CHO BIẾT HỌ VÀ TÊN NHỮNG NGƯỜI CÓ BẢO HIỂM Y TẾ
SELECT  BN.HOBN , BN.TENBN AS' TEN BENH NHAN CO THE BHYT'
FROM BHYT YT, BENHNHAN BN
WHERE YT.MABN=BN.MABN
GROUP BY YT.MABHYT , BN.HOBN , BN.TENBN
GO

--Cho biết mã bảo hiểm y tế ,họ và tên bệnh nhân có BHYT--
SELECT YT.MABHYT,BN.HOBN,BN.TENBN 
FROM BHYT YT, BENHNHAN BN
WHERE YT.MABN=BN.MABN
GROUP BY YT.MABHYT ,BN.HOBN,BN.TENBN 
GO