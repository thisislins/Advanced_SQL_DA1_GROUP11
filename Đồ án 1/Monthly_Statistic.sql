use QuanLyHoaDon
go

create proc sp_Monthly_Statistic
@date date
as
begin
	select count(MAHD) 'Tong so hoa don', SUM(TONGTIEN) 'Doanh thu (VNĐ)'
	from HOADON
	where month(NGAYLAP) = month(@date) and year(NGAYLAP) = year(@date)
end
go

exec sp_Monthly_Statistic '03/10/2021' 