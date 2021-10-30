USE QuanLyHoaDon;

--Các hóa đơn lập trong năm 2020
GO


SELECT * 
FROM HOADON
WHERE year(NGAYLAP) = 2020


-- 3b. Danh sách các khách hàng ở TP.HCM

SELECT *
FROM KHACHHANG
WHERE TPHO LIKE N'TP. Hồ Chí Minh'


