--Tạo database
create database QLBH 
use QLBH

--Tạo bảng trong database
--Bảng Hang
create table Hang(
	MaH int not null,
	TenHang nvarchar(255),
	DonGia int,
	GhiChu nvarchar(255)
);
--Bảng KhachHang
create table KhachHang(
	MaKH int not null,
	TenKH nvarchar(255),
	SDT varchar(10),
	GhiChu nvarchar(255)
);

--Bảng HoaDon
create table HoaDon(
	MaHD int not null,
	MaKH int not null,
	NgayHD date,
	GhiChu nvarchar(255)
);
--Bản HDCT
create table HDCT(
	MaHD int not null,
	MaH int not null,
	SoLuong int
);
--Primary key and Foreign key
alter table Hang add constraint pk_MaHang primary key (MaH);
alter table KhachHang add constraint pk_KhachHang primary key (MaKH);
alter table HoaDon add constraint pk_HoaDon primary key (MaHD);
alter table HoaDon add constraint fk_MaKH foreign key (MaKH) references KhachHang(MaKH);
alter table HDCT add constraint fk_MaH foreign key (MaH) references Hang(MaH);
alter table HDCT add constraint fk_MaHD foreign key (MaHD) references HoaDon(MaHD);
--Insert data to table
insert into Hang(MaH, TenHang, DonGia, GhiChu)
values	(1, N'Iphone 13', 500, N'Hàng cũ'),
		(2, N'Iphone 11 Pro Max', 799, N'New'),
		(3, N'Iphone 13 Pro Max', 1099, N'New'),
		(4, N'MacBook M1', 2799, N'New'),
		(5, N'Iphone X', 599, N'New'),
		(6, N'Iphone X', 499, N'Hàng cũ')
select * from Hang

insert into KhachHang(MaKH, TenKH, SDT, GhiChu)
values	(1, N'Ngô Lan Hương', '0193081012', N'VIP-1'),
		(2, N'Trần Đức Tiến', '0923423412', N'VIP-2'),
		(3, N'Đào Việt Bảo', '0922112412', N'VIP-3'),
		(4, N'Nguyễn Như Anh', '0923433442', N'BT'),
		(5, N'Hoàng Quốc Việt', '0977431412', N'BT'),
		(6, N'Hà Anh Tuấn', '0925663412', N'VIP-2'),
		(7, N'Dương Thị Nga', '0956789412', N'BT'),
		(8, N'Phạm Thị Thùy Linh', '0920909812', N'BT')
select * from KhachHang

insert into HoaDon(MaHD, MaKH, NgayHD, GhiChu)
values	(1, 1, '2022-02-19', N''),
		(2, 2, '2022-02-19', N''),
		(3, 4, '2022-02-19', N''),
		(4, 5, '2022-02-19', N''),
		(5, 7, '2022-02-19', N''),
		(6, 8, '2022-02-19', N''),
		(7, 3, '2022-02-19', N''),
		(8, 6, '2022-02-19', N''),
		(9, 8, '2022-02-19', N'')
select * from HoaDon

insert into HDCT(MaHD, MaH, SoLuong)
values	(1, 3, 1),
		(2, 2, 2),
		(3, 4, 1),
		(4, 5, 2),
		(5, 1, 1),
		(6, 6, 1),
		(7, 2, 3),
		(8, 2, 2),
		(9, 4, 2)
select * from HDCT

--Tạo thủ tục thêm, sửa, xóa, tìm kiếm
--Table Hang
create view v_Product as
select * from dbo.Hang
select * from v_Product
--Add
alter procedure sp_insertProduct
(
	@MaH int,
	@TenHang nvarchar(255),
	@DonGia int,
	@GhiChu nvarchar(255)
)
as
	begin
		if(not exists(select MaH from dbo.Hang where MaH = @MaH))
		begin
		insert into dbo.Hang
		values(@MaH, @TenHang, @DonGia, @GhiChu)
		print N'Insert succeeded!';
		end;
		else
		print N'Insert failse!'
	end;
--Update
create procedure sp_updateProduct
(
	@MaH int,
	@TenHang nvarchar(255),
	@DonGia int,
	@GhiChu nvarchar(255)
)
as
	begin
		update dbo.Hang set
		TenHang = @TenHang,
		DonGia = @DonGia,
		GhiChu = @GhiChu
		where MaH = @MaH
		print N'Update succeeded!'
	end
--Delete
create procedure sp_deleteProduct (@MaH int)
as
	begin
		delete from dbo.Hang
		where MaH = @MaH
		print N'Delete succeeded!'	
	end
--Find by ID Product
create procedure sp_findByIDProduct (@MaH int) as
begin
	if(exists(select * from dbo.Hang where MaH = @MaH))
		select * from dbo.Hang where MaH = @MaH
	else
		print 'Not found!'
end
select * from Hang
exec sp_insertProduct 10, N'Iphone 11', 499, N'New'
exec sp_updateProduct 8, N'Iphone 11', 599, N'New'
exec sp_deleteProduct 10
exec sp_findByIDProduct 11

--Table HoaDon
--Add
create procedure sp_insertBill
(
	@MaHD int,
	@MaKH int,
	@NgayHD date,
	@GhiChu nvarchar(255)
)
as
	begin
		if(not exists(select MaHD from dbo.HoaDon where MaHD = @MaHD))
		begin
		insert into dbo.HoaDon
		values(@MaHD, @MaKH, @NgayHD, @GhiChu)
		print N'Insert succeeded!';
		end;
		else
		print N'Insert failse!'
	end;
--Update
create procedure sp_updateBill
(
	@MaHD int,
	@MaKH int,
	@NgayHD date,
	@GhiChu nvarchar(255)
)
as
	begin
		update dbo.HoaDon set
		MaKH = @MaKH,
		NgayHD = @NgayHD,
		GhiChu = @GhiChu
		where MaHD = @MaHD
		print N'Update succeeded!'
	end
--Delete
create procedure sp_deleteBill (@MaHD int)
as
	begin
		delete from dbo.HoaDon
		where MaHD = @MaHD
		print N'Delete succeeded!'	
	end
--Find by ID Bill
create procedure sp_findByIDBill (@MaHD int) as
begin
	if(exists(select * from dbo.HoaDon where MaHD = @MaHD))
		select * from dbo.HoaDon where MaHD = @MaHD
	else
		print 'Not found!'
end
select * from HoaDon
--Thêm
exec sp_insertBill 7, 3, '2022-03-19', N''
--Sửa
exec sp_updateBill 8, 6, '2022-03-14', N''
--Xóa
exec sp_deleteBill 10
--Tìm kiếm bằng ID
exec sp_findByIDBill 1
--Table KhachHang
create procedure sp_insertCustomer
(
	@MaKH int,
	@TenKH nvarchar(255),
	@SDT varchar(10),
	@GhiChu nvarchar(255)
)
as
	begin
		if(not exists(select MaKH from dbo.KhachHang where MaKH = @MaKH))
		begin
		insert into dbo.KhachHang
		values(@MaKH, @TenKH, @SDT, @GhiChu)
		print N'Insert succeeded!';
		end;
		else
		print N'Insert failse!'
	end;
--Update
create procedure sp_updateCustomer
(
	@MaKH int,
	@TenKH nvarchar(255),
	@SDT varchar(10),
	@GhiChu nvarchar(255)
)
as
	begin
		update dbo.KhachHang set
		MaKH = @MaKH,
		TenKH = @TenKH,
		GhiChu = @GhiChu
		where MaKH = @MaKH
		print N'Update succeeded!'
	end
--Delete
create procedure sp_deleteCustomer (@MaKH int)
as
	begin
		delete from dbo.KhachHang
		where MaKH = @MaKH
		print N'Delete succeeded!'	
	end
--Find by ID Product
create procedure sp_findByIDCustomer (@MaKH int) as
begin
	if(exists(select * from dbo.KhachHang where MaKH = @MaKH))
		select * from dbo.KhachHang where MaKH = @MaKH
	else
		print 'Not found!'
end
select * from KhachHang
--Thêm
exec sp_insertCustomer 9, N'Đào Thùy Chi', '0920999912', N'VIP-1'
--Sửa
exec sp_updateCustomer 9, N'Đào Thùy Chi', '0920999912', N'BT'
--Xóa
exec sp_deleteCustomer 9
--Tìm kiếm theo ID
exec sp_findByIDCustomer 8

--Table HDCT
create procedure usp_ManageHDCT
(
	@MaHD int,
	@MaH int,
	@SoLuong int,
	@Type nvarchar(20)
)
as 
	begin
		if @Type = 'insert'
		begin
			insert into dbo.HDCT
			values (@MaHD, @MaH, @SoLuong)
			print N'Thêm mới thành công'
		end
		if @Type = 'update'
		begin
			update dbo.HDCT set
			MaH = @MaH,
			SoLuong = @SoLuong
			where MaHD = @MaHD
			print N'Cập nhật thành công'
		end
		else if @Type = 'delete'
			begin
				delete from dbo.HDCT
				where MaHD = @MaHD
				print N'Xóa thành công'
			end
	end
--Thêm
exec usp_ManageHDCT 10, 3, 1 , 'insert'
--Sửa
exec usp_ManageHDCT 10, 5, 2, 'update'
--Xóa
exec usp_ManageHDCT 10, 3, 1, 'delete'

--Tạo thủ tục truy vấn
--Table Hang

exec sp_findByIDHang 1
exec sp_findByIDHang 10
select * from Hang
--Table KhachHang
select * from KhachHang
alter procedure sp_findByIDKH (@MaKH int) as
begin
	if(exists(select * from dbo.KhachHang where MaKH = @MaKH))
		select * from dbo.KhachHang where MaKH = @MaKH
	else
		print 'Not found ID '
end
exec sp_findByIDKH 1
exec sp_findByIDKH 10
--Table HonDon
select * from HoaDon
alter procedure sp_detailHD (@MaHD int) as
begin
	if(exists(select * from dbo.HoaDon where MaHD = @MaHD))
		select b.MaHD, a.MaKH, a.TenKH, a.SDT, b.NgayHD
		from KhachHang a join HoaDon b 
		on a.MaKH = b.MaKH where b.MaHD = @MaHD
	else
		print 'Not found ID'
end
exec sp_detailHD 1
exec sp_detailHD 12
--Table HDCT
select * from HDCT
create procedure sp_HDCT (@MaHD int) as
begin
	 if(exists(select * from dbo.HDCT where MaHD = @MaHD))
		select b.MaHD, a.MaH, a.TenHang, a.DonGia * b.SoLuong as 'Don Gia', b.SoLuong
		from Hang a join HDCT b
		on a.MaH = b.MaH where b.MaHD = @MaHD
	 else
		print 'Not found ID'
end
exec sp_HDCT 2
exec sp_HDCT 12

--Create view for CrystalReport
create view v_detailCustomer as
select a.MaKH, a.TenKH, a.SDT, d.TenHang as 'DaMua', d.DonGia from dbo.KhachHang a
join dbo.HoaDon b
on a.MaKH = b.MaKH
join dbo.HDCT c 
on b.MaHD = c.MaHD
join dbo.Hang d
on c.MaH = d.MaH
select * from v_detailCustomer
--View product sell in March
create view v_sellInMarch as
select c.MaH, c.TenHang, b.SoLuong, a.NgayHD 'Ngay ban', a.GhiChu from dbo.HoaDon a join dbo.HDCT b
on a.MaHD = b.MaHD
join dbo.Hang c
on c.MaH = b.MaH
where MONTH(a.NgayHD) = 3
select * from v_sellInMarch

--Test chart sales in january, february, march
select * from dbo.HoaDon
insert into dbo.HoaDon (MaHD, MaKH, NgayHD, GhiChu)
values	(10, 3, '2022-01-20',N''),
		(11, 6, '2022-01-03',N''),
		(12, 7, '2022-01-11',N''),
		(13, 1, '2022-03-11',N''),
		(14, 7, '2022-01-22',N'')
select * from dbo.HDCT
insert into dbo.HDCT (MaHD, MaH, SoLuong)
values	(10, 7, 2),
		(11, 9, 3),
		(12, 8, 1),
		(13, 6, 1),
		(14, 5, 4)

create view vw_Sales as
select MONTH(a.NgayHD) as Thang, SUM(b.SoLuong) as SoLuong from dbo.HoaDon a join dbo.HDCT b
on a.MaHD = b.MaHD
group by MONTH(a.NgayHD)

select * from vw_Sales