USE QuanLyHoaDon;

--Các hóa đơn lập trong năm 2020
GO
SELECT * 
FROM HOADON
WHERE year(NGAYLAP) = 2020
