use QuanLyHoaDon
go

<<<<<<< HEAD
create proc sp_Month_Statistic
=======
create proc sp_Monthly_Statistic
>>>>>>> 7498efc377057f6939ef2b9aadd0f732d1f3f123
@date date
as
begin
	select @date 'Tính đến ngày',count(MAHD) 'Tong so hoa don', SUM(TONGTIEN) 'Doanh thu (VNĐ)'
	from HOADON
	where month(NGAYLAP) = month(@date) and year(NGAYLAP) = year(@date)
	and day(@date) >= day(NGAYLAP)
end
go

alter proc sp_Monthly_Statistic
@year int
as
begin
	if @year < 0  
		Begin
			RAISERROR('Year is negative',16,1)
		End
	else
		Begin
			select month(NGAYLAP) 'Thang', count(MAHD) 'Tong so hoa don', SUM(TONGTIEN) 'Doanh thu (VNĐ)'
			from HOADON
			where year(NGAYLAP) = @year
			group by month(NGAYLAP)
			order by month(NGAYLAP) ASC
		End
end
go

alter proc sp_Yearly_Statistic
@year int
as
begin
	if @year < 0  
		Begin
			RAISERROR('Year is negative',16,1)
		End
	else
		Begin
			select year(NGAYLAP) 'Nam', count(MAHD) 'Tong so hoa don', SUM(TONGTIEN) 'Doanh thu (VNĐ)'
			from HOADON
			where year(NGAYLAP) = @year
			group by year(NGAYLAP)
		End
end
go

exec sp_Month_Statistic '06/30/2021'
exec sp_Monthly_Statistic 2021
exec sp_Yearly_Statistic 2021