USE QuanLyHoaDon

GO
CREATE TRIGGER TG_TONGTIEN_FOR_INSERT_UPDATE 
ON HOADON FOR INSERT, UPDATE
AS
BEGIN
	UPDATE HOADON
	SET TONGTIEN = (SELECT SUM(CT_HOADON.THANHTIEN)
					FROM CT_HOADON JOIN inserted ON (CT_HOADON.MAHD=inserted.MAHD)
					WHERE inserted.MAHD = HOADON.MAHD)
END