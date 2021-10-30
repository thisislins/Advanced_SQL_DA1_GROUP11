﻿-- bảng tầm ảnh hưởng
--             thêm    xóa    sửa
--ct_hoadon     +       -     +(Soluong, GiaBan, GiaGiam)

-- Xác nhập với việc update TONGTIEN ở bảng HOADON
use QuanLyHoaDon

GO
-- 2a. Thành tiền CTHD= (Số lượng * (Giá bán-Giá giảm))
CREATE TRIGGER tg_THANHTIEN_FOR_INSERT ON CT_HOADON
FOR UPDATE, INSERT
AS
BEGIN
	UPDATE CT_HOADON
	SET THANHTIEN = (SELECT SOLUONG FROM inserted WHERE MAHD = CT_HOADON.MAHD AND MASP = CT_HOADON.MASP) *
	                ((SELECT GIABAN FROM inserted WHERE MAHD = CT_HOADON.MAHD AND MASP = CT_HOADON.MASP) -
					 (SELECT GIAGIAM FROM inserted WHERE MAHD = CT_HOADON.MAHD AND MASP = CT_HOADON.MASP))
	FROM CT_HOADON
	JOIN inserted ON inserted.MAHD = CT_HOADON.MAHD AND inserted.MASP = CT_HOADON.MASP
END

--insert into CT_HOADON (MAHD, MASP, SOLUONG, GIABAN, GIAGIAM) values ('HD000001', 'SP000015', 7, 30750.0000, 500.0000)

--update CT_HOADON set GIAGIAM = 5750 where MAHD = 'HD000002' and MASP = 'SP000000'

--update CT_HOADON set THANHTIEN = 0