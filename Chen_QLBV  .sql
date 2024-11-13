SET DATEFORMAT DMY 

-- CHÈN DỮ LIỆU CHO KHOA 
INSERT INTO KHOA (MAK , TENK)
VALUES ('KH0001',N'KHOA NỘI'),
('KH0002',N'KHOA NGOẠI'),
('KH0003',N'KHOA NỘI TIM MẠCH'),
('KH0004',N'KHOA NỘI TIÊU HÓA'),
('KH0005',N'KHOA PHỤ SẢN')
SELECT*FROM KHOA
GO 
 -- CHÈN DỮ LIỆU CHO PHÒNG 
 INSERT INTO PHONGDIEUTRI(MAPDT,LOAIPHONG)
 VALUES ('PDT001',N'1 CHỖ'), 
 ('PDT002',N'ĐÔI'),
 ('PDT003',N'5 CHỖ'),
 ('PDT004',N'20 CHỖ'),
 ('PDT005',N'30 CHỖ') 
 SELECT *FROM PHONGDIEUTRI 
 GO
 INSERT INTO PHONGKHAM (MAPK,MAK)
 VALUES ('PK01','KH0001'),
 ('PK02','KH0001'),
 ('PK03','KH0001'),
 ('PK04','KH0002'),
 ('PK05','KH0002'),
 ('PK06','KH0003'),
 ('PK07', 'KH0003'),
 ('PK08','KH0004'),
 ('PK09','KH0004'),
 ('PK010','KH0005')
 GO 
-- CHÈN DỮ LIỆU CHO BÁC SĨ 
INSERT INTO BACSI (MABS ,HOBS,TENBS,CHUCVU,MaK )
VALUES ('BS0001',N'NUYỄN CÔNG ',N'TOÀN',N'BÁC SĨ HẠNG 1' ,'KH0001'),
('BS0002',N'TRẦN ĐÌNH ',N'THÀNH ',N'THỰC TẬP ' ,'KH0001'),
('BS0003',N'LÊ THI KIM  ',N'NGÂN',N'BÁC SĨ HẠNG 2 ' ,'KH0002'),
('BS0004',N'NGUYỄN ĐỨC ',N'HẠNH',N'BÁC SĨ HẠNG 1 ' ,'KH0002'),
('BS0005',N'NGUYỄN VIẾT ',N'MINH',N'BÁC SĨ HẠNG 3' ,'KH0001'),
('BS0006',N'NUYỄN CÔNG ',N'MINH',N'BÁC SĨ HẠNG 3 ' ,'KH0004'),
('BS0007',N'LÊ MINH ',N'TRIẾT',N'THỰC TẬP ','KH0003'),
('BS0008',N'PHẠM VĂN ',N'KHƯƠNG',N'BÁC SĨ HẠNG 2 ' ,'KH0004'),
('BS0009',N'NUYỄN CÔNG ',N'TOÀN',N'BÁC SĨ HẠNG 2','KH0005'),
('BS00010',N'ĐINH CÔNG ',N'THÀNH',N'BÁC SĨ HẠNG 2 ' ,'KH0003')
 SELECT*FROM BACSI 
 GO
 -- CHÈN DỮ LIỆU CHO BỆNH NHÂN 
 INSERT INTO BENHNHAN(MABN ,HOBN,TENBN,SODTH,DIACHI,NGAYSINH,PHAI,MAPHG)
VALUES('BN0001',N'NGUYỄN THỊ KIỀU ',N'TRANG','09876543212',N'47 NGUYỄN HUỆ,Q1,TP.HCM','21/06/1980',N'NỮ','PDT001'),
('BN0002',N'LÊ BÁ ',N'TRÍ','02334567891',N'145 ĐỒNG KHỞI ,Q1,TP.HCM','26/04/1985',N'NAM','PDT005'),
('BN0003',N'TRẦN THỊ',N'MƯỜI','09877513212',N'45 HAI BÀ TRƯNG,Q3,TP.HCM','5/12/1988',N'NỮ','PDT005'),
('BN0004',N'TRẦN THANH',N'TÙNG','04512947382',N'36 NGUYỄN THỊ MINH KHAI,Q BÌNH HẠNH,TP.HCM','15/06/1990',N'NAM','PDT004'),
('BN0005',N'NGUYỄN NGỌC ',N'THỦY','09813487624',N'HAI BÀ TRƯNG,Q4,TP.HCM','3/12/1988',N'NỮ','PDT002'),
('BN0006',N'TRÂN THANH',N'TOÀN','01873513212',N'24 ĐỒNG KHỞI ,Q1,TP.HCM','12/1/1986',N'NAM','PDT002'),
('BN0007',N'TÔ NHẬT',N'QUANG','01512942389',N'67 TRẦN HƯNG ĐẠO,Q5,TP.HCM','21/4/1999',N'NAM','PDT003'),
('BN0008',N'NGUYỄN ÁNH',N'NGUYỆT','09334867899',N'125 TRẦN HƯNG ĐẠO ,Q1,TP.HCM','1/1/1980',N'NỮ','PDT004'),
('BN0009',N' NGUYỄN THANH ',N'THỦY','09776543211',N'324 NGUYỄN THỊ MINH KHAI ,Q BÌNH HẠNH ,TP.HCM','2/10/2000',N'NỮ','PDT001'),
('BN00010',N'LÊ NGỌC MINH',N'ĐẮC','0813994098',N'24 KỲ ĐÔNG ,Q3,TP.HCM','21/06/2005',N'NAM','PDT005')
 SELECT*FROM BENHNHAN
GO

 ---CHÈN DỮ LIỆU CHO NHÂN VIÊN
 INSERT INTO NHANVIEN(MANV,HONV , TENNV  , SODTH , DIACHI , NGAYSINH , PHAI , CHUCVU  , NGAYLV )
 VALUES ('NV0001',N'Phạm Đình ',N'Trung','0954372916',N'48 Bùi Viện ,Q1 ,TP.HCM','8/9/1990',N'NAM',N'Bảo Vệ','22/4/2014'),
('NV0002',N'Phan Mai',N'Phương','0945015836',N'54 Bạch Đằng ,Phú Nhuận ,TP.HCM','29/6/1990',N'NỮ',N'Tạp Vụ','30/5/2016'),
('NV0003',N'Lê Anh ',N'Dũng','0943850137',N'54 Bạch Đằng ,Phú Nhuận ,TP.HCM','19/12/1990',N'NAM',N'Bảo Vệ','22/4/2017'),
('NV0004',N'Nguyễn Hữu ',N'Đạt','0946104724',N'48 Bùi Viện ,Q1 ,TP.HCM','28/4/1990',N'NAM',N'Điều Dưỡng','22/4/2017'),
('NV0005',N'Trương Đặng Ngọc',N'Cầm','0995432802',N'468 Mã Lò ,Bình Tân ,TP.HCM','25/6/1991',N'NỮ',N'Điều Dưỡng','22/4/2018'),
('NV0006',N'Phạmh Minh ',N'Anh','0908136275',N'49 Trần Quang Khải ,Q1 ,TP.HCM','10/4/1993',N'NAM',N'Điều Dưỡng','2/7/2019'),
('NV0007',N'Nguyễn Tiến ',N'Đạt','0970841257',N'46 ,Bình Tân ,TP.HCM','22/2/1994',N'NAM',N'Điều Dưỡng','22/4/2019'),
('NV0008',N'Hoàng Minh ',N'Anh','0906185902',N'468 Mã Lò ,Bình Tân ,TP.HCM','29/11/1998',N'NAM',N'Bảo Vệ','22/4/2020'),
('NV0009',N'Phạm Ngọc',N'Nhi','0903182642',N'46 ,Bình Tân ,TP.HCM','15/5/1996',N'NỮ',N'Điều Dưỡng','8/1/2021'),
('NV00010',N'Phạm Thị Minh',N'Anh','0922418859',N'486 Phan Xích Long,Phú Nhuận,TP.HCM','1/5/1998',N'NỮ',N'Thu Ngân','25/1/2021')
  SELECT*FROM NHANVIEN
 GO

 -- CHÈN DỮ LIỆU CHO BHYT 
 INSERT INTO BHYT (MABHYT,MABN,NGAYCAP,NGAYHETHAN)
 VALUES ('HS4010120878817','BN00010','24/01/2019','24/01/2024'),
 ('HS5012330879870','BN0007','24/04/2020','24/04/2025'),
 ('HS6013920878818','BN0005','12/01/2024','12/01/2029'),
 ('HS7030120228897','BN0003','2/04/2015','2/04/2020')
 SELECT*FROM BHYT 
 GO 

 -----------------------------------------------------------------------------------------------------------------------------
 -- CHÈN DỮ LIỆU CHO KHOA_NV
 INSERT INTO KHOA_NV(MAK,MANV)
 VALUES ('KH0001','NV0001'),
 ('KH0001','NV0002'),
 ('KH0002','NV0003'),
 ('KH0002','NV0004'),
 ('KH0003','NV0005'),
 ('KH0004','NV0006'),
 ('KH0001','NV0007'),
 ('KH0002','NV0008'),
 ('KH0005','NV0009'),
 ('KH0001','NV00010')
 SELECT * FROM KHOA_NV
 GO
 -- CHÈN DỮ LIỆU CHO ĐIỀU TRỊ 
 INSERT INTO DIEUTRI (MAK,MABN)
 VALUES ('KH0003','BN0001'),
 ('KH0001','BN0002'),
 ('KH0001','BN0003'),
 ('KH0002','BN0004'),
 ('KH0003','BN0005'),
 ('KH0004','BN0006'),
 ('KH0004','BN0007'),
 ('KH0001','BN0008'),
 ('KH0004','BN00010'),
 ('KH0005','BN0009')
  SELECT*FROM DIEUTRI 
  GO 

  -- CHÈN DỮ LIỆU CHO BỆNH ÁN 
  INSERT INTO BENHAN (MABA , MABN , KETQUA)
  VALUES ('BA101','BN0001',N'BỊ BỆNH VAN TIM'),
  ('BA102','BN0002',N'BÌNH THƯỜNG '),
  ('BA103','BN0003',N'ĐÁI THÁO ĐƯỜNG '),
  ('BA104','BN0004',N'UNG THƯ'),
  ('BA105','BN0005',N'BỆNH CƠ TIM BỊ GIÃN NỠ'),
  ('BA106','BN0006',N'BỆNH ĐƯỜNG RUỘT '),
  ('BA107','BN0007',N'VIÊM LOÉT DẠ DÀY '),
  ('BA108','BN0008',N'VIÊM KHỚP '),
  ('BA109','BN0009',N'BÌNH THƯỜNG'),
  ('BA1010','BN00010',N'VIÊM THỰC QUẢN')
  SELECT*FROM BENHAN
  GO 

  -- CHÈN DỮ LIỆU CHO KHÁM BỆNH 
  INSERT INTO KHAM_BENH(MABS,MABN,NGAYKHAM)
  VALUES 
  -- KHOA 01
  ('BS0001','BN0002','2/4/2023'),
  ('BS0001','BN0003','12/6/2023'),
  ('BS0001','BN0008','8/4/2023'),
  ('BS0005','BN0008','1/6/2023'),
  ('BS0005','BN0003','2/8/2023'),
  ('BS0002','BN0003','3/9/2023'),
  --KHOA 02 
  ('BS0003','BN0004','4/9/2023'),
  ('BS0004','BN0004','5/10/2023'),
  -- KHOA 03 
  ('BS0007','BN0001','3/9/2023'),
  ('BS00010','BN0001','12/9/2023'),
  ('BS00010','BN0005','3/9/2023'),
  -- KHOA 04 
  ('BS0006','BN0006','3/1/2023'),
  ('BS0008','BN0007','21/12/2023'),
  ('BS0008','BN00010','3/1/2024'),
  -- KHOA 05 
  ('BS0009','BN0009','21/6/2023')
  SELECT*FROM KHAM_BENH
  GO
  ----------------------------------------------------------------------------------------------------------------
  -- CHÈN DỮ LIỆU CHO LỊCH SỬ BỆNH ÁN 
  INSERT INTO LICHSU_BA(MABS,MABA,NGAYVIET)
  VALUES 
  -- KHOA 01
  ('BS0001','BA102','2/4/2023'),
  ('BS0001','BA103','12/6/2023'),
  ('BS0001','BA108','1/6/2023'),
  --KHOA02
  ('BS0003','BA104','4/9/2023'),
  --KHOA03
  ('BS0007','BA101','3/9/2023'),
  ('BS00010','BA105','3/9/2023'),
  --KHOA 04 
  ('BS0006','BA106','3/1/2023'),
  ('BS0008','BA107','21/12/2023'),
  ('BS0008','BA1010','3/1/2023'),
  --KHOA 05
  ('BS0009','BA109','21/6/2023')
  SELECT *FROM LICHSU_BA
  GO
  ---CHÈN DỮ LIỆU CHO DICHVU
 INSERT INTO DICHVU (MADV, TENDV ,GIA )
 VALUES ('DV001',N'Khám Ngoại','200,000'),
('DV002',N'Khám Nội','200,000'),
('DV003',N'Khám Mắt','200,000'),
('DV004',N'Khám Phụ sản','300,000'),
('DV005',N'Khám Nhi','500,000'),
('DV006',N'Khám Phụ sản','300,000'),
('DV007',N'Khám Răng hàm mặt','200,000'),
('DV008',N'Khám Tai mũi họng','200,000'),
('DV009',N'Chụp cộng hưởng từ động mạch chi trên (1.5T)','2,400,000'),
('DV0010',N'Chụp cộng hưởng từ động mạch chi trên có tiêm tương phản (1.5T)','3,600,000'),
('DV0011',N'Định nhóm máu ABO, Rh','173,000'),
('DV0012',N'Siêu âm bụng tổng quát - siêu âm 2D','240,000'),
('DV0013',N'Siêu âm bụng tổng quát - siêu âm 4D','420,000'),
('DV0014',N'Nội soi thực quản - dạ dày - tá tràng có sinh thiết','2,100,000'),
('DV0015',N'Nội soi thực quản - dạ dày - tá tràng không sinh thiết','1,250,000'),
('DV0016',N'Nội soi thực quản - dạ dày - tá tràng qua đường mũi','1,500,000'),
('DV0017',N'Nội soi trực tràng ống mềm có sinh thiết','1,390,000'),
('DV0018',N'Nội soi trực tràng ống mềm không sinh thiết','895,000')
 SELECT*FROM DICHVU
 GO
 ----------------------------------------------------------------------------------------------------------------------------
  ---CHÈN DỮ LIỆU CHO THUỐC
 INSERT INTO THUOC (MATHUOC, TENTHUOC, SL, GIA)
 VALUES ('TH001',N'Viên ngậm Cufo vị mật ong chanh hỗ trợ điều trị triệu chứng trong nhiễm khuẩn miệng và họng','1','1.600'),
('TH002',N'Thuốc Tocemux điều trị tiêu chất nhầy, bệnh lý hô hấp có đờm ','1','700'),
('TH003',N'Siro HoAstex OPC điều trị ho, giảm ho trong viêm họng, viêm phế quản (90ml)','1 ','38.000'),
('TH004',N'Thuốc Euxamus 200mg Euvipharm tiêu chất nhầy trong bệnh nhầy nhớt ','1 ','800'),
('TH005',N'Thuốc Medi-Ambroxol Medisun tiêu chất nhầy đường hô hấp ','1 ','6.000'),
('TH006',N'Tinh dầu trẻ em Nasomom-4 Reliv giảm triệu chứng nghẹt mũi, sổ mũi, khò khè, cảm cúm (70ml) ','1 ','39.000'),
('TH007',N'Thuốc Dacolfort Danapha điều trị triệu chứng liên quan đến suy tĩnh mạch, mạch bạch huyết ','1','2.600'),
('TH008',N'Siro Deslotid OPV trị viêm mũi dị ứng, phản ứng dị ứng da (60ml) ','1 ','65.000'),
('TH009',N'Thuốc Exopadin 60mg Trường Thọ điều trị viêm mũi dị ứng, mày đay ','1 ','2.000'),
('TH0010',N'Thuốc nhỏ mắt V.Rohto Vitamin hỗ trợ cải thiện tình trạng giảm thị lực, mắt mờ (13ml) ','1 ','51.990'),
('TH0011',N'Thuốc nhỏ mắt Eyemiru 40 EX điều trị căng mắt, xung huyết kết mạc (15ml) ','1 ','73.800'),
('TH0012',N'Thuốc nhỏ mắt, nhỏ mũi Natri Clorid 0,9% Pharmedic (10ml) ','1 ','3.000'),
('TH0013',N'Thuốc nhỏ mắt Rohto Antibacterial điều trị lẹo mắt, viêm kết mạc, viêm mi mắt (13ml) ','1 ','53.000'),
('TH0014',N'Thuốc Myhemo BRV điều trị dự phòng thiếu sắt và folic acid trong khi mang thai','1 ','5.500'),
('TH0015',N'Dung dịch uống CalciMAX OPV giúp ngon miệng, chắc khỏe xương ','1 ','7.500'),
('TH0016',N'Thuốc Magnesium - B6 TV.Pharm giảm các triệu chứng thiếu hụt magnesi, nôn mửa, khó chịu ','1 ','500'),
('TH0017',N'Viên ngậm sát trùng Tyrotab Pharmedic điều trị viêm họng, viêm amidan ','1 ','500'),
('TH0018',N'Kem bôi da Ketoconazol 2% Medipharco điều trị các bệnh nấm da và niêm mạc (10g) ','1 ','11.000'),
('TH0019',N'Kem bôi da Lifedovate Cream 0,05% Hadiphar điều trị các vết long eczema, viêm da (10g) ','1 ','35.000'),
('TH0020',N'Thuốc Warfarin 5 S.P.M điều trị ngắn hạn huyết khối tĩnh mạch và nghẽn mạch phổi cấp tính ','1 ','7.334'),
('TH0021',N'Viên nén Metformin 850mg Tipharco điều trị đái tháo đường  ','1 ','300'),
('TH0022',N'Thuốc Stadovas 5 CAP Stella điều trị tăng huyết áp, đau thắt ngực mạn tính ổn định ','1 ','200'),
('TH0023',N'Thuốc Berberin 100mg Domesco điều trị nhiễm khuẩn đường ruột, tiêu chảy, kiết lỵ  ','1 ','650'),
('TH0024',N'Dung dịch Suncurmin Sao Thái Dương điều trị viêm loét dạ dày, hành tá tràng (100ml)  ','1 ','50.000'),
('TH0025',N'Viên uống Jex Natural Ecogreen hỗ trợ giảm đau trong thoái hoá khớp, viêm khớp   ','1 ','11.000'),
('TH0026',N'Hỗn dịch uống Phosphalugel Sanofi giảm độ axit của dạ dày ','1 ','4.200')
  SELECT*FROM THUOC 
 GO
   -- CHÈN DỮ LIỆU CHO Mua Thuoc
 INSERT INTO MUA_THUOC (MATHUOC,MABN, SL)
 VALUES ('TH0020','BN0001','14'),
 ('TH0021','BN0003','14'),
 ('TH0017','BN0004','14'),
 ('TH0022','BN0005','14'),
 ('TH0023','BN0006','14'),
 ('TH0022','BN0007','1'),
 ('TH0025','BN0008','14'),
 ('TH0026','BN00010','14')
  SELECT*FROM MUA_THUOC
  GO 
  -- CHÈN DỮ LIỆU CHO SỬ DỤNG DỊCH VỤ 
  INSERT INTO SUDUNG_DICHVU(MADV,MABN,TGIAN,SL)
  VALUES ('DV0010','BN0001', '3/9/2023','1'),
  ('DV009','BN0001', '3/9/2023', '1'),
  ('DV0011','BN0001', '3/9/2023', '1'),
  ('DV001','BN0002', '2/4/2023', '1'),
  ('DV002','BN0002', '2/4/2023', '1'),
  ('DV003','BN0002', '2/4/2023', '1'),
  ('DV007','BN0002', '2/4/2023', '1'),
  ('DV008','BN0002', '2/4/2023', '1'),
  ('DV0011','BN0002', '2/4/2023', '1'),
  ('DV001','BN0003', '12/6/2023', '1'),
  ('DV0011','BN0003', '12/6/2023', '1'),
  ('DV001','BN0004', '4/9/2023', '1'),
  ('DV001','BN0005', '3/9/2023', '1'),
  ('DV0011','BN0005', '3/9/2023', '1'),
  ('DV009','BN0005', '3/9/2023', '1'),
  ('DV0017','BN0006', '3/1/2023', '1'),
  ('DV0018','BN0007', '21/12/2023', '1'),
  ('DV001','BN0008', '8/4/2023', '1'),
  ('DV004','BN0009', '21/6/2023', '1'),
  ('DV005','BN0009', '21/6/2023', '1'),
  ('DV006','BN0009', '21/6/2023', '1'),
  ('DV0014','BN00010', '3/1/2023', '1')
  SELECT * FROM SUDUNG_DICHVU
  GO
   -- CHÈN DỮ LIỆU CHO HÓA ĐƠN 
 INSERT INTO HOADON(MAHD, MADV, MABN, THUOC, SL, THANHTIEN)
VALUES
('HD0001', 'DV0010', 'BN0001', NULL, NULL, '3,600,000'),
('HD0002', 'DV009', 'BN0001', 'TH0020','14', '2.498,000'),
('HD0003', 'DV0011', 'BN0001', NULL, NULL, '173,000'),
('HD0004', 'DV001', 'BN0002', NULL, NULL, '200,000'),
('HD0005', 'DV002', 'BN0002', NULL, NULL, '200,000'),
('HD0006', 'DV003', 'BN0002', NULL, NULL, '200,000'),
('HD0007', 'DV007', 'BN0002', NULL, NULL, '200,000'),
('HD0008', 'DV008', 'BN0002', NULL, NULL, '200,000'),
('HD0009', 'DV0011', 'BN0002', NULL, NULL, '173,000'),
('HD00010', 'DV001', 'BN0003','TH0021','14', '204,200'),
('HD00011', 'DV0011', 'BN0003', NULL, NULL, '173,000'),
('HD00012', 'DV001', 'BN0004', 'TH0017','14', '207,000'),
('HD00013', 'DV001', 'BN0005','TH0022','14', '202,800'),
('HD00014', 'DV0011', 'BN0005', NULL, NULL, '173,000'),
('HD00015', 'DV009', 'BN0005', NULL, NULL, '2,400,000'),
('HD00016', 'DV0017', 'BN0006','TH0023','14', '1,399,100'),
('HD00017', 'DV0018', 'BN0007','TH0022','14', '987.800'),
('HD00018', 'DV001', 'BN0008','TH0025','14', '354,000'),
('HD00019', 'DV004', 'BN0009', NULL, NULL, '300,000'),
('HD00020', 'DV005', 'BN0009', NULL, NULL, '500,000'),
('HD00021', 'DV006', 'BN0009', NULL, NULL, '300,000'),
('HD00022', 'DV0014', 'BN00010','TH0026','14', '2,158,800')
SELECT * FROM HOADON 
GO 
-- CHÈN DỮ LIỆU PKHAM_BENHNHAN

--  INSERT INTO PHONGKHAM (MAPK,MAK)
 --VALUES ('PK01','KH0001'),
-- ('PK02','KH0001'),
 --('PK03','KH0001'),
-- ('PK04','KH0002'),
-- ('PK05','KH0002'),
-- ('PK06','KH0003'),
 --('PK07', 'KH0003'),
 --('PK08','KH0004'),
 --('PK09','KH0004'),
-- ('PK10','KH0005')
 GO 
INSERT	INTO PKHAM_BENHNHAN (MAPK, MABN,TGIAN)
VALUES ('PK06','BN0001','3/9/2023'),
('PK01','BN0002','2/4/2023'),
('PK01','BN0003','12/6/2023'),
('PK05','BN0004','4/9/2023'),
('PK04','BN0004','5/10/2023'),
('PK06','BN0005','3/9/2023'),
('PK09','BN0006','3/1/2023'),
('PK08','BN0007','21/12/2023'),
('PK02','BN0008','8/4/2023'),
('PK03','BN0008','1/6/2023'),
('PK010','BN0009','21/6/2023'),
('PK08','BN00010','3/1/2023')
GO