USE QuanLyHoaDon
GO

--3a. Các hóa đơn lập trong năm 2020
SELECT * 
FROM HOADON
WHERE year(NGAYLAP) = 2020
GO

-- 3b. Danh sách các khách hàng ở TP.HCM
SELECT *
FROM KHACHHANG
WHERE TPHO LIKE N'TP. Hồ Chí Minh'
GO

--3c. Danh sách các sản phẩm có giá trong một khoảng từ 30000 đến 40000
select sp.MASP, sp.TENSP, sp.GIA
from SANPHAM sp
where sp.GIA >= 30000 AND sp.GIA =< 40000
GO

--3d. Danh sách các sản phẩm có số lượng tồn < 100
select sp.MASP, sp.TENSP, sp.SOLUONGTON
from SANPHAM sp
where sp.SOLUONGTON < 100
GO


-- 3e. Danh sách sản phẩm bán chạy nhất.
SELECT * 
FROM SANPHAM AS SP
WHERE SP.MASP IN (SELECT MASP
				FROM CT_HOADON
				GROUP BY MASP
				HAVING SUM(SOLUONG) >= ALL(
							SELECT SUM(CT.SOLUONG)
							FROM CT_HOADON AS CT
							GROUP BY MASP
							) 
				)


GO

-- 3f. Sản phẩm có doanh thu cao nhất.
SELECT * 
FROM SANPHAM AS SP
WHERE SP.MASP IN ( SELECT MASP
				FROM CT_HOADON
				GROUP BY MASP
				HAVING SUM(THANHTIEN) >= ALL(
							SELECT SUM(CT.THANHTIEN)
							FROM CT_HOADON AS CT
							GROUP BY MASP
							) 
				)

