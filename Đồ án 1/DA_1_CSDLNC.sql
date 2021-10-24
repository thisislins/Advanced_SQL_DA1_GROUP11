use QuanLyHoaDon
go

--Danh sách các sản phẩm có số lượng tồn < 100
select sp.MASP, sp.TENSP, sp.SOLUONGTON
from SANPHAM sp
where sp.SOLUONGTON < 100

--Danh sách các sản phẩm có giá trong một khoảng từ 30000 đến 40000
select sp.MASP, sp.TENSP, sp.GIA
from SANPHAM sp
where sp.GIA > 30000 AND sp.GIA < 40000