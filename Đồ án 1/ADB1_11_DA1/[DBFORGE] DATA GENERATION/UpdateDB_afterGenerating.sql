USE QuanLyHoaDon
GO
-- Sau khi khởi tạo data, update địa chỉ của những khách hàng ở TP.HCM để thỏa chiếm 2/3 tổng khách hàng
-- Update --
UPDATE KHACHHANG SET TPHO = N'TP. Hồ Chí Minh' WHERE TPHO IS NULL

UPDATE SANPHAM SET MOTA = N'Mô tả ' + TENSP WHERE MOTA IS NOT NULL