use QuanLyHoaDon
go

--Danh sách khách hàng ở HCM
SELECT* FROM KHACHHANG AS KH
WHERE KH.TPHO = N'TP. Hồ Chí Minh'
go

--Danh sách các sản phẩm có số lượng tồn < 100
select sp.MASP, sp.TENSP, sp.SOLUONGTON
from SANPHAM sp
where sp.SOLUONGTON < 100
go

select sp.MASP, sp.TENSP, sp.SOLUONGTON
from SANPHAM sp
where sp.SOLUONGTON not in (
	select sp.SOLUONGTON
	from SANPHAM sp
	where sp.SOLUONGTON >= 100)
go

select sp.MASP, sp.TENSP, sp.SOLUONGTON
from SANPHAM sp
where not exists (
	select *
	from SANPHAM sp2
	where sp.MASP = sp2.MASP and sp.SOLUONGTON >= 100)
go

--Danh sách các sản phẩm có giá trong một khoảng từ 30000 đến 40000
select sp.MASP, sp.TENSP, sp.GIA
from SANPHAM sp
where sp.GIA >= 30000 AND sp.GIA <= 40000
go

select sp.MASP, sp.TENSP, sp.GIA
from SANPHAM sp
where sp.GIA BETWEEN 30000 AND 40000
go

select sp.MASP, sp.TENSP, sp.GIA
from SANPHAM sp
where sp.GIA not in (
	select sp.GIA
	from SANPHAM sp
	where sp.GIA > 40000 OR sp.GIA < 30000)
go

select sp.MASP, sp.TENSP, sp.GIA
from SANPHAM sp
where not exists (
	select *
	from SANPHAM sp2
	where sp.MASP = sp2.MASP and (sp.GIA > 40000 OR sp.GIA < 30000))
go