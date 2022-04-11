CREATE DATABASE BTL_QLBH;
GO
USE BTL_QLBH;
----------------------
create table TaiKhoan(
TenTaiKhoan char(30),
MatKhau char(30)
);
--------------------------------
create table NhaCC(
MaNCC char(5) not null,
TenNCC nvarchar(255),
constraint mancc_PK primary key (MaNCC),
);
insert into NhaCC values ('CC01',N'HC'),
						('CC02',N'FPT'),
						('CC03',N'Th? Gi?i Di ??ng'),
						('CC04',N'?i?n Máy Xanh'),
						('CC05',N'SamSung'),
						('CC06',N'Hà N?i Computer'),
						('CC07',N'Hu?n Nguyên'),
						('CC08',N'Siêu Th? ?i?n Máy PICO'),
						('CC09',N'Thành ph? ?i?n máy Digicity'),
						('CC10',N'?i?n máy Ch? L?n');
						select * from NhaCC;
---------------------------------------------------------------------------------
create table PhanLoai(
MaLoai char(5) not null,
TenLoai nvarchar(255),
constraint maloai_PK primary key (MaLoai),
);
insert into PhanLoai values('PL01',N'?i?n Tho?i Di ??ng'),
							('PL02',N'LapTop'),
							('PL03',N'Máy Tính Bàn'),
							('PL04',N'Gh? Gaming'),
							('PL05',N'Ph? Ki?n Máy Tính')
							select * from PhanLoai;
------------------------------------------------------------------------------------------
create table HangHoa(
MaHang char(10) not null,
MaLoai char(5) not null,
MaNCC char(5) not null,
TenHang nvarchar(255),
Gia int,
SoLuong int,
constraint mahang_PK primary key (MaHang),
constraint FK_mancc foreign key (MaNCC) references NhaCC(MaNCC),
constraint FK_maloai foreign key (MaLoai) references PhanLoai(MaLoai)
);
insert into HangHoa values('H01','PL01','CC05',N'Ði?n Tho?i SamSung S22 utra',220,5),
						('H02','PL02','CC06',N'Laptop Acer nitro 5',333,10),
						('H03','PL03','CC01',N'HP 205 Pro G4 AIO R5',1233,7),
						('H04','PL04','CC02',N'Gh? Gamer Warrior Raider Series Black',123,15),
						('H05','PL05','CC03',N'Chu?t Không Dây Fuhlen',111,100);
						select * from HangHoa;
--------------------------------------------------------------------------------------------------
create table NhanVien(
MaNV char(10) not null,
TenNV nvarchar(255),
SDT char(10),
DiaChi nvarchar(255),
DoanhSo int,
constraint manv_PK primary key (MaNV)
);
insert into NhanVien values ('NV01',N'Tr?n ??c Ti?n','0983000',N'Phú Th?',10),
							('NV02',N'?inh Kh?c Ho?t','098743',N'Qu?ng Ninh',16),
							('NV03',N'?ào Vi?t B?o','098337254',N'Hà N?i',11),
							('NV04',N'Nguy?n Ph??ng ?ông','0987436',N'Phú Th?',3),
							('NV05',N'Lê Duy ??ng','09834443',N'Ngh? An',4),
							('NV06',N'Tr?n ??c Anh','0984540',N'Phú Th?',8),
							('NV07',N'?inh Kh?c Ho?t Bá','098743353',N'Qu?ng Ninh',19),
							('NV08',N'?ào Vi?t B?o Ng?u','09822463',N'Hà N?i',13),
							('NV09',N'Nguy?n Ph??ng ?ông Anh','098732436',N'H?i Phòng',1),
							('NV10',N'Lê Duy Phát','0983666443',N'hà N?i',7)
							select * from NhanVien
----------------------------------------------------------------------------------------------
create table KhachHang(
MaKH char(10) not null,
TenKH nvarchar(255),
SDT char(10),
DiaChi nvarchar(255),
LuotMua int,
GhiChu char(5)
constraint makh_PK primary key (MaKH)
);
insert into KhachHang values('KH01',N'Phan Th? Ð?nh','093497683',N'Hà Giang',7,'BT'),
							('KH02',N'Tr?n Chung Kiên','093495763',N'Hà N?i',6,'BT'),
							('KH03',N'Tr?n Van Son','09349444',N'Hà N?i',6,'BT'),
							('KH04',N'Nguy?n Van Toàn','093666',N'Lào Cai',11,'VIP1'),
							('KH05',N'Bùi Hoàng Vi?t Anh','09342223',N'Hà N?i',16,'VIP2'),
							('KH06',N'Nguy?n Van Duong','09344553',N'Thanh Hóa',2,'BT');
							select * from KhachHang;
----------------------------------------
create table HoaDon(
MaHD char(10) not null,
MaHang char(10) not null,
MaNV char(10) not null,
MaKH char(10) not null,
NgayHD date,
ThanhTien float,
constraint mahd_PK primary key (MaHD),
constraint FK_MaHang foreign key (MaHang) references HangHoa(MaHang),
constraint FK_MaNV foreign key (MaNV) references NhanVien(MaNV),
constraint FK_MaKH foreign key (MaKH) references KhachHang(MaKH)
);
insert into HoaDon values ('HD01','H01','NV01','KH01','2022/01/06',1111),
							('HD02','H02','NV01','KH02','2022/02/07',1221),
							('HD03','H03','NV02','KH03','2022/01/04',1111),
					    	('HD04','H04','NV03','KH04','2022/02/12',1221),
							('HD05','H05','NV02','KH01','2022/04/06',1113);
							select * from HoaDon;
----------------------------------------------------------------------------
--Thủ Tục Thêm,Sửa,Xóa Bang NhaCC---
create procedure usp_insertNhaNCC
(	@MaNCC char(5),
	@TenNCC nvarchar(255)
)
as
	begin
		
				insert into dbo.NhaCC
				values (@MaNCC, @TenNCC)
				print N'Thêm mới thành công'
			end
--Sua
create procedure updateNhaCC
(	@MaNCC char(5),
	@TenNCC nvarchar(255)
)as
			begin
				update dbo.NhaCC set
				TenNCC = @TenNCC
				where MaNCC = @MaNCC
				print N'Cập nhật thành công'
			end

--xoa
create procedure usp_deleteNhaCC
(	@MaNCC char(5),
	@TenNCC nvarchar(255)
)as
begin
				delete from dbo.NhaCC
				where MaNCC = @MaNCC
				print N'Xóa thành công'
			end
--Thủ Tục truy vấn
create procedure sp_selectNhaCC (@MaNCC char(5)) as
begin
	if(exists(select * from dbo.NhaCC where MaNCC = @MaNCC))
		select * from dbo.NhaCC where MaNCC = @MaNCC
	else
		print 'Not found!'
end
exec sp_selectNhaCC 'FPT'
-----------------------------------------------------------------
-----------------------------------------------------------------
--Thủ Tục Bảng Phân Loại
create procedure usp_insertPhanLoai
(	@MaLoai char(5),
	@TenLoai nvarchar(255)
)
as
	begin
		
				insert into dbo.PhanLoai
				values (@MaLoai, @TenLoai)
				print N'Thêm mới thành công'
			end
--Sua
create procedure updatePhanLoai
(	@MaLoai char(5),
	@TenLoai nvarchar(255)
)as
			begin
				update dbo.PhanLoai set
				TenLoai = @TenLoai
				where MaLoai = @MaLoai
				print N'Cập nhật thành công'
			end

--xoa
create procedure usp_deletePhanLoai
(	@MaLoai char(5),
	@TenLoai nvarchar(255)
)as
begin
				delete from dbo.PhanLoai
				where MaLoai = @MaLoai
				print N'Xóa thành công'
			end
--Thủ Tục truy vấn
create procedure sp_selectPhanLoai (@MaLoai char(5)) as
begin
	if(exists(select * from dbo.PhanLoai where MaLoai = @MaLoai))
		select * from dbo.PhanLoai where MaLoai = @MaLoai
	else
		print 'Not found!'
end
-----------------------------------------------------------------
-----------------------------------------------------------------
--Thủ Tục Truy vấn bảng Hàng Hóa
create procedure usp_inserttHangHoa
(	@MaHang char(10),
	@MaLoai char(5),
	@MaNCC char(5),
	@TenHang nvarchar(255),
	@Gia int,
	@SoLuong int
)
as
	begin
		
				insert into dbo.HangHoa
				values (@MaHang,@MaLoai,@MaNCC,@TenHang,@Gia,@SoLuong)
				print N'Thêm mới thành công'
			end

--Sua
create procedure usp_updateHangHoa
(	@MaHang char(10),
	@MaLoai char(5),
	@MaNCC char(5),
	@TenHang nvarchar(255),
	@Gia int,
	@SoLuong int
)as
			begin
				update dbo.HangHoa set
				MaLoai = @MaLoai,
				MaNCC = @MaNCC,
				TenHang = @TenHang,
				Gia = @Gia,
				SoLuong = @SoLuong
				where MaHang = @MaHang
				print N'Cập nhật thành công'
			end
--xoa
create procedure usp_deleteHangHoa
(	@MaHang char(10),
	@MaLoai char(5),
	@MaNCC char(5),
	@TenHang nvarchar(255),
	@Gia int,
	@SoLuong int
)as
begin
				delete from dbo.HangHoa
				where MaHang = @MaHang
				print N'Xóa thành công'
			end
--tim kiem
create procedure sp_selectHangHoa (@MaHang char(10)) as
begin
	if(exists(select * from dbo.HangHoa where MaHang = @MaHang))
		select * from dbo.HangHoa where MaHang = @MaHang
	else
		print 'Not found!'
end
-----------------------------------------------------------------
-----------------------------------------------------------------
--Nhân Viên
create procedure usp_insertNhanVien
(	@MaNV char(10),
	@TenNV nvarchar(255),
	@SDT char(10),
	@DiaChi nvarchar(255),
	@DoanhSo int
)
as
	begin
		
				insert into dbo.NhanVien
				values (@MaNV,@TenNV,@SDT,@DiaChi,@DoanhSo)
				print N'Thêm mới thành công'
			end

--Sua
create procedure usp_updateNhanVien
(	@MaNV char(10),
	@TenNV nvarchar(255),
	@SDT char(10),
	@DiaChi nvarchar(255),
	@DoanhSo int
)as
			begin
				update dbo.NhanVien set
				TenNV = @TenNV,
				SDT = @SDT,
				DiaChi = @DiaChi,
				DoanhSo = @DoanhSo
				where MaNV = @MaNV
				print N'Cập nhật thành công'
			end
--xoa
create procedure usp_deleteNhanVien
(	@MaNV char(10),
	@TenNV nvarchar(255),
	@SDT char(10),
	@DiaChi nvarchar(255),
	@DoanhSo int
)as
begin
				delete from dbo.NhanVien
				where MaNV = @MaNV
				print N'Xóa thành công'
			end
--tim kiem
create procedure sp_selectNhanVien (@MaNV char(10)) as
begin
	if(exists(select * from dbo.NhanVien where MaNV = @MaNV))
		select * from dbo.NhanVien where MaNV = @MaNV
	else
		print 'Not found!'
end
-----------------------------------------------------------------
-----------------------------------------------------------------
--Khach Hang
create procedure usp_insertKhachHang
(	@MaKH char(10),
	@TenKH nvarchar(255),
	@SDT char(10),
	@DiaChi nvarchar(255),
	@LuotMua int,
	@GhiChu char(5)
)
as
	begin
		
				insert into dbo.KhachHang
				values (@MaKH,@TenKH,@SDT,@DiaChi,@LuotMua,@GhiChu)
				print N'Thêm mới thành công'
			end

--Sua
create procedure usp_updateKhachHang
(	@MaKH char(10),
	@TenKH nvarchar(255),
	@SDT char(10),
	@DiaChi nvarchar(255),
	@LuotMua int,
	@GhiChu char(5)
)as
			begin
				update dbo.KhachHang set
				TenKH = @TenKH,
				SDT = @SDT,
				DiaChi = @DiaChi,
				LuotMua = @LuotMua,
				GhiChu = @GhiChu
				where MaKH = @MaKH
				print N'Cập nhật thành công'
			end
--xoa
create procedure usp_deleteKhachHang
(	@MaKH char(10),
	@TenKH nvarchar(255),
	@SDT char(10),
	@DiaChi nvarchar(255),
	@LuotMua int,
	@GhiChu char(5)
)as
begin
				delete from dbo.KhachHang
				where MaKH = @MaKH
				print N'Xóa thành công'
			end
--tim kiem
create procedure sp_selectKhachHang (@MaKH char(10)) as
begin
	if(exists(select * from dbo.KhachHang where MaKH = @MaKH))
		select * from dbo.KhachHang where @MaKH = @MaKH
	else
		print 'Not found!'
end
-----------------------------------------------------------------
-----------------------------------------------------------------
--Hoa Don
create procedure usp_insertHoaDon
(	@MaHD char(10),
	@MaHang char(10),
	@MaNV char(10),
	@MaKH char(10),
	@NgayHD date,
	@ThanhTien float
)
as
	begin
		
				insert into dbo.HoaDon
				values (@MaHD,@MaHang,@MaNV,@MaKH,@NgayHD,@ThanhTien)
				print N'Thêm mới thành công'
			end

--Sua
create procedure usp_updateHoaDon
(	@MaHD char(10),
	@MaHang char(10),
	@MaNV char(10),
	@MaKH char(10),
	@NgayHD date,
	@ThanhTien float
)as
			begin
				update dbo.HoaDon set
				MaHang = @MaHang,
				MaNV = @MaNV,
				MaKH = @MaKH,
				NgayHD = @NgayHD,
				ThanhTien = @ThanhTien
				where MaHD = @MaHD
				print N'Cập nhật thành công'
			end
--xoa
create procedure usp_deleteHoaDon
(	@MaHD char(10),
	@MaHang char(10),
	@MaNV char(10),
	@MaKH char(10),
	@NgayHD date,
	@ThanhTien float
)as
begin
				delete from dbo.HoaDon
				where MaHD = @MaHD
				print N'Xóa thành công'
			end
--tim kiem
create procedure sp_selectHoaDon (@MaHD char(10)) as
begin
	if(exists(select * from dbo.HoaDon where MaHD = @MaHD))
		select * from dbo.HoaDon where @MaHD = @MaHD
	else
		print 'Not found!'
end