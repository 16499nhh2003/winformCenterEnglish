use master
go
drop database trungtamngoaingu
go
create database trungtamngoaingu
go
use trungtamngoaingu
go
----PHANQUYEN---
create table chucvu
(
	id int primary key,
	ten nvarchar(255)
)
go
insert into chucvu values (1,N'Quản trị viên')
insert into chucvu values (2,N'Nhân Viên')
go
--***************************************** PROCEDURE *********************************
-- Them du lieu anh (byte) vao database
create procedure dbo.ImportImage(
	@MaAnh nvarchar(255),
	@DuongDanThuMuc nvarchar(1000),
	@TenFile nvarchar(1000)
)
AS
BEGIN
	Declare @Path2OutFile nvarchar(2000);
	Declare @tsql nvarchar(2000);
	Set nocount On
	Set @Path2OutFile = Concat(@DuongDanThuMuc,'\',@TenFile);
	Set @tsql = 'insert into Anh (MaAnh,FileAnh,DuongDan,AnhData)'
				+ 'SELECT ' + '''' + @MaAnh + '''' + ',' + '''' + @TenFile + '''' +  ',' + '''' + @Path2OutFile + '''' +', * ' +
				'FROM Openrowset( Bulk ' + '''' + @Path2OutFile + '''' + ', Single_Blob) as img'
	exec(@tsql)
	Set nocount off
END	
go
create table Anh(
MaAnh nvarchar(255), 
FileAnh nvarchar(255),
AnhData varbinary(max),
DuongDan varchar(1000),
primary key(MaAnh),
)
go
----NHANVIEN---
create table nhanvien(
	id varchar(255) primary key,
	tennhanvien nvarchar(255),
	gioitinh bit default 1,			  
	sdt nvarchar(255),
	ngaysinh date,
	email  nvarchar(255),
	idChucVu nvarchar(255),
	MaAnh nvarchar(255),
	constraint fk_maAnh foreign key(MaAnh) references Anh(MaAnh),
)
go
---ACCOUNT
select * from account
create table account
(
	maTaiKhoan int identity ,
	ghiChu nvarchar(255),
	tenDangNhap varchar(255) primary key,
	matKhau varchar(255),
	phanQuyen int default 2,
	email varchar(255),
	foreign key (phanquyen)  references  chucvu(id)
)
go
insert into account values (null,'admin','admin',1,null)
insert into account values (null,'user001','123456',2,null)
insert into account values (null,'user002','abcdef',2,null)
go
create proc PS_CheckLogin @us varchar(255) , @pw varchar(255)
as
	begin
		select * from  account where account.tenDangNhap = @us and account.matKhau = @pw
	end	
go
create proc PS_Register
	@tenDangNhap varchar(255),
	@matKhau varchar(255),
	@email varchar(255)
as
	begin
		insert into account(tenDangNhap,matKhau,email) values (@tenDangNhap,@matKhau,@email)
	end
go
--- PS  Update Mat Khau
create proc PS_Update @username varchar(255), @old varchar(255), @new  varchar(255)
as
	begin
		update account 
		set matkhau =  @new
		where  tenDangNhap = @username and matKhau = @old
	end
----PHIEUCHI
create table phieuchi
(
	id varchar(255) primary key,
	idKeToanVien varchar(255),
	ngayChi date,
	noiDung varchar(255),
	soTien float,
	nguoiNhan nvarchar(255),
	foreign key (idKeToanVien)  references  NhanVien(id)
)
go
create proc PS_InsertPhieuCHi @a varchar(255), @b datetime ,  @c  float 
as 
	begin
		insert into  phieuchi values(@a,null,@b,null,@c,null)
	end
go
----PHIEUTHU
--select * from phieuthu
create table phieuthu
(
	id varchar(255) primary key,
	idKeToanVien varchar(255),
	ngayThu date,
	noiDung varchar(255),
	soTien float,
	nguoiNop nvarchar(255),
	foreign key (idKeToanVien)  references  NhanVien(id)
)
go
create proc PS_ShowDoanhThu @start date , @end date
as
	begin
		select phieuthu.ngayThu as [Ngày Thu] , phieuthu.id as [Mã Phiếu Thu] , phieuthu.soTien[Số Tiền] from phieuthu
		where ngayThu between @start and @end  
	end
go
create proc PS_InsertPhieuThu @a varchar(255), @b datetime ,  @c  float 
as 
	begin
		insert into  phieuthu values(@a,null,@b,null,@c,null)
	end
go
create proc PS_DOANHTHU @start date , @end date
as
	begin
		select sum(soTien) from phieuthu
		where ngayThu between @start and @end  
	end
go
----LoaiGiangVien
create table loaigiangvien(
	id varchar(255) primary key,
	ten nvarchar(255),
)
go
----GIANGVIEN
create table giangvien
(
	id varchar(255) primary key,
	tenGiangVien varchar(255),
	ngaySinh date,
	cccd varchar(255),
	sdt varchar(255),
	gioitinh bit default 0, --- 1 nam 0 nu
	diachi  varchar(255),
	loaiGiangVien varchar(255),
	giaTheoGio int,
	constraint fk_loaiGV foreign key (loaiGiangVien) references loaigiangvien(id),
)
go 
--insert into giangvien values('GV0001',N'A','2003-1-1','092022202','0830383930',0,'Bmt')
----HOCVIEN
create table hocvien
(
	id varchar(255) primary key,
	tenHocVien nvarchar(255),
	gioitinh int default 0, -- 0  nam 1 nữ
	sdt nvarchar(255),
	email nvarchar(255),
	ghichu nvarchar(255),
	cccd nvarchar(255),
	ngaySinh datetime,
	tinhTrangHocTap int default 0, -- 0 Đang theo học --- 1 Không còn học
	ngayCapNhatGanNhat datetime ,
)
go
create proc PS_InsertHocVien @id varchar(255),@tenHocVien nvarchar(255),@gioitinh int,@sdt nvarchar(255),@email nvarchar(255),@ghichu nvarchar(255),@cccd nvarchar(255),@ngaySinh datetime,@tinhTrangHocTap int,@ngayCapNhatGanNhat datetime
as 
	begin
		insert into  hocvien values(@id,@tenHocVien,@gioitinh,@sdt,@email,@ghichu,@cccd,@ngaySinh,@tinhTrangHocTap,@ngayCapNhatGanNhat)
	end
go
create proc PS_getStudent 
as
	begin
		select	id as[Mã Học Viên],
				tenHocVien as[Tên Học Viên],
				CAST( CASE
					  WHEN gioitinh = 0 THEN 'Nam' ELSE N'Nữ'
					END AS nvarchar(5)) as [giới Tính] 
				,sdt[Số Điện Thoại],email as[Email],cccd as[Căn cước công dân],ngaySinh as [Ngày Sinh],
				CAST( CASE
					  WHEN tinhTrangHocTap = 0 THEN N'Đang theo học' ELSE N'Không còn học'
					END AS nvarchar(255)) as [Tình trạng theo học],ngayCapNhatGanNhat as [Cập nhật gần nhất] 
				from hocvien
	end
go
create proc PS_UpdateHocVien @id varchar(255),@tenHocVien nvarchar(255),@gioitinh int,@sdt nvarchar(255),@email nvarchar(255),@ghichu nvarchar(255),@cccd nvarchar(255),@ngaySinh datetime,@ngayCapNhatGanNhat datetime
as 
	begin
		update hocvien
		set tenHocVien = @tenHocVien,gioitinh = @gioitinh, sdt = @sdt,email = @email, ghichu = @ghichu, cccd =@cccd, ngaySinh = @ngaySinh,ngayCapNhatGanNhat = @ngayCapNhatGanNhat
		where id =@id
	end
go
--drop table hocvien
--exec PS_getStudent
exec PS_InsertHocVien 'HV0001', N'Nguyễn Huy Hòa', 1, '0906919299','nguyenhuyhoa2003@gmail.com',null,'067203001527','3/4/2003',0,'2020-10-10'
exec PS_InsertHocVien 'HV0002', N'Nguyễn Ngọc Minh', 1, '0906919299','nguyenhuyhoa2003@gmail.com',null,'067203001527','3/4/2003',0,'2020-10-10'
exec PS_InsertHocVien 'HV0003', N'Nguyễn Ngọc Nam', 1, '0906919299','nguyenhuyhoa2003@gmail.com',null,'067203001527','3/4/2003',0,'2020-10-10'
exec PS_InsertHocVien 'HV0004', N'Nguyễn Hữu Tín', 1, '0906919299','nguyenhuyhoa2003@gmail.com',null,'067203001527','3/4/2003',0,'2020-10-10'
exec PS_InsertHocVien 'HV0005', N'Võ Minh Thuận', 1, '0906919299','nguyenhuyhoa2003@gmail.com',null,'067203001527','3/4/2003',0,'2020-10-10'
exec PS_InsertHocVien 'HV0006', N'Hoàng Đức Minh', 1, '0906919299','nguyenhuyhoa2003@gmail.com',null,'067203001527','3/4/2003',0,'2020-10-10'
exec PS_InsertHocVien 'HV0007', N'Phan Thị Xuân Trà', 1, '0906919299','nguyenhuyhoa2003@gmail.com',null,'067203001527','3/4/2003',0,'2020-10-10'
exec PS_InsertHocVien 'HV0008', N'Phan Nguyễn Hạnh Nhân', 1, '0906919299','nguyenhuyhoa2003@gmail.com',null,'067203001527','3/4/2003',0,'2020-10-10'
go
----PhongHoc
select * from phonghoc
create table phonghoc
(
	id varchar(255) primary key,
	tenPhongHoc nvarchar(255),
	ghiChu nvarchar(255),
	soChoNgoi int
)
go
--select * from phonghoc
insert into phonghoc values ('P0001',N'Phòng số 1',null,50)
insert into phonghoc values ('P0002',N'Phòng số 2',null,60)
insert into phonghoc values ('P0003',N'Phòng số 3',null,80)
insert into phonghoc values ('P0004',N'Phòng số 4',null,30)
go
---Ca Học
--go
--drop table cahoc
create table cahoc
(
	id varchar(255) primary key,
	batdau time,
	ketthuc time,
	ten nvarchar(255)
)
----select * from cahoc
go
insert into cahoc values('C01','6:50','9:25',N'6:50-9:25')
insert into cahoc values('C02','9:30','12:00',N'9:30-12:00')
insert into cahoc values('C03','12:45','15:20','12:45-15:20')
insert into cahoc values('C04','15:25','17:55','15:25-17:55')
go
---Ngay Hoc
--select * from ngayhoc
create table ngayhoc
(
	id varchar(255) primary key,
	ten nvarchar(255),
	buoi1 int,
	buoi2 int,
	buoi3 int,
)
go
insert into ngayhoc values('N01',N'Thứ 2-4-6',2,4,6)
insert into ngayhoc values('N02',N'Thứ 3-5-7',3,5,7)
insert into ngayhoc values('N03',N'Thứ 2-4-7',2,4,7)
insert into ngayhoc values('N04',N'Thứ 3-5-Chủ Nhật',3,5,8)
go
----KHOAHOC
go
drop table khoahoc
create table khoahoc
(
	id varchar(255) primary key,
	tenKhoaHoc nvarchar(255),
	idCaHoc varchar(255),
	idNgayHoc varchar(255),
	ngaybatdau date,
	ngayketthuc date,
	hocPhi float,
	solophoc int default 0, ---TRIGGER
	soBuoi int,
	foreign key (idNgayHoc) references ngayhoc(id),
	foreign key (idCaHoc) references cahoc(id)
)
--go
--select * from khoahoc
go
insert into khoahoc values('KH001',N'Luyện Thi Ielt','C02','N02','2023-1-1','2023-2-1',1450000,0,20)
insert into khoahoc values('KH002',N'Tiếng Anh THCS','C03','N03','2023-01-01','2023-02-01',7450000,0,20)
insert into khoahoc values('KH003',N'Ielt 4.0','C01','N01','2023-1-1','2023-2-1',7450000,0,20)
insert into khoahoc values('KH004',N'Ielt 5.0','C01','N02','2023-1-1','2023-2-1',7450000,0,20)
insert into khoahoc values('KH005',N'Ielt 6.0','C02','N03','2023-1-1','2023-2-1',7450000,0,20)
insert into khoahoc values('KH006',N'Ielt 7.0','C03','N01','2023-1-1','2023-2-1',7450000,0,20)
insert into khoahoc values('KH007',N'Toeic','C02','N03','2023-1-1','2023-2-1',7450000,0,20)
insert into khoahoc values('KH008',N'Tiếng Anh THCS','C01','N01','2023-1-1','2023-2-1',2650000,0,20)
insert into khoahoc values('KH009',N'Tiếng Anh THCS','C01','N01','2023-1-1','2023-2-1',2250000,0,20)
insert into khoahoc values('KH010',N'Tiếng Anh THCS','C01','N01','2023-1-1','2023-2-1',3450000,0,20)
insert into khoahoc values('KH011',N'Anh văn giao tiếp cơ bản','C02','N02','2023-1-1','2023-2-1',5450000,0,20)
go
create proc PS_allKhoaHoc 
as
	begin
		select	 
				khoahoc.id as[Mã Khóa Học],khoahoc.tenKhoaHoc as[Tên Khóa Học],
				khoahoc.ngaybatdau as [Ngày Bắt Đầu]  , khoahoc.ngayketthuc as [Ngày Kết Thúc],
				khoahoc.hocPhi as [HọcPhí]  , khoahoc.solophoc as[Số Lượng Lớp],
				cahoc.ten as[Ca Học], ngayhoc.ten as[Ngày Học]
		from khoahoc
		join cahoc on khoahoc.idCaHoc = cahoc.id
		join ngayhoc on khoahoc.idNgayHoc = ngayhoc.id
	end
-- exec  PS_allKhoaHoc
----LOPHOC
go
select * from lophoc
drop table lophoc
create table lophoc
(
	id varchar(255) primary key,
	idGiangVien varchar(255),
	idKhoaHoc varchar(255),
	idNhanVien varchar(255),
	idPhongHoc varchar(255),
	tenLopHoc nvarchar(255),
	tinhtrang varchar(255),
	foreign key (idGiangVien) references giangvien(id), 
	foreign key (idKhoaHoc) references khoahoc(id), 
	foreign key (idNhanVien) references nhanvien(id), 
	foreign key (idPhongHoc) references phonghoc(id) 
)
go
insert into lophoc values ('L001',null,'KH001',null,null,N'Luyện Thi Ielt số 1',null)
insert into lophoc values ('L002',null,'KH001',null,null,N'Luyện Thi Ielt số 2',null)
insert into lophoc values ('L003',null,'KH002',null,null,N'Tiếng Anh THCS số 1',null)
insert into lophoc values ('L004',null,'KH002',null,null,N'Tiếng Anh THCS sô 2',null)
insert into lophoc values ('L005',null,'KH002',null,null,N'Tiếng Anh THCS sô 3',null)
insert into lophoc values ('L006',null,'KH003',null,null,N'Ielt 4.0 số 1',null)
insert into lophoc values ('L007',null,'KH004',null,null,N'Ielt 5.0 số 1',null)
insert into lophoc values ('L008',null,'KH004',null,null,N'Ielt 5.0 số 2',null)
insert into lophoc values ('L009',null,'KH005',null,null,N'Ielt 6.0 số 1',null)
insert into lophoc values ('L010',null,'KH006',null,null,N'Ielt 7.0 số 1',null)
insert into lophoc values ('L011',null,'KH001',null,null,N'Luyện Thi Ielt số 3',null)
insert into lophoc values ('L012',null,'KH002',null,null,N'Tiếng Anh THCS số 4',null)
insert into lophoc values ('L013',null,'KH007',null,null,N'Toeic số 1',null)
insert into lophoc values ('L014',null,'KH008',null,null,N'tiếng Anh THCS',null)
insert into lophoc values ('L015',null,'KH009',null,null,N'tiếng Anh THCS',null)
insert into lophoc values ('L016',null,'KH0010',null,null,N'tiếng Anh THCS',null)
--select * from lophoc
go
create proc PS_SEARCHLopByKhoaHoc @khoahoc varchar(255)
as
	begin
		select lh.id as [Mã lớp Học] , lh.tenLopHoc, concat(cahoc.ten,' ',ngayhoc.ten)  from lophoc lh
		join  khoahoc kh on lh.idKhoaHoc = kh.id
		join cahoc on kh.idCaHoc = cahoc.id
		join ngayhoc on kh.idNgayHoc = ngayhoc.id
		where lophoc.idKhoaHoc = @khoahoc
	end
exec PS_SEARCHLopByKhoaHoc 'KH001'
go
create proc PS_SearchByKhoa @khoa varchar(255)
as 
	begin
		select lophoc.id,lophoc.tenLopHoc from lophoc
		where lophoc.idKhoaHoc = @khoa
	end
go
create proc PS_searchbykhoaandlop @makhoa varchar(255) , @malop varchar(255)  
as
	begin
		select id as[Mã Học Viên],
				tenHocVien as[Tên Học Viên],
				CAST( CASE
					  WHEN gioitinh = 0 THEN 'Nam' ELSE N'Nữ'
					END AS nvarchar(5)) as [giới Tính] 
				,sdt[Số Điện Thoại],email as[Email],cccd as[Căn cước công dân],ngaySinh as [Ngày Sinh],
				CAST( CASE
					  WHEN tinhTrangHocTap = 0 THEN N'Đang theo học' ELSE N'Không còn học'
					END AS nvarchar(255)) as [Tình trạng theo học],ngayCapNhatGanNhat as [Cập nhật gần nhất] 
				from hocvien
		where hocvien.id 
		in(	select chitietlophoc.idHocVien from chitietlophoc
			join lophoc on chitietlophoc.idLopHoc = lophoc.id
			join khoahoc on khoahoc.id = lophoc.idKhoahoc
			where khoahoc.id = @makhoa  and lophoc.id = @malop )
		order by id asc
	end
--exec PS_searchbykhoaandlop 'KH001' ,'L001'
----CHITIETLOPHOC
go
--drop table chitietlophoc
create table chitietlophoc
(
	id int identity,
	idLopHoc varchar(255),
	idHocVien varchar(255),
	ngaydangki datetime,
	diem float,
	foreign key (idHocVien) references hocvien(id), 
	foreign key (idLopHoc) references lophoc(id), 
)
go
insert into chitietlophoc values ('L001','HV0001',null,null)
insert into chitietlophoc values ('L001','HV0002',null, null)
insert into chitietlophoc values ('L001','HV0003',null,null)
insert into chitietlophoc values ('L001','HV0004',null,null)
insert into chitietlophoc values ('L001','HV0005',null,null)
insert into chitietlophoc values ('L002','HV0002',null, null)
insert into chitietlophoc values ('L002','HV0003',null,null)
insert into chitietlophoc values ('L002','HV0001',null,null)
insert into chitietlophoc values ('L002','HV0004',null,null)
insert into chitietlophoc values ('L003','HV0001',null, null)
insert into chitietlophoc values ('L003','HV0002',null,null)
insert into chitietlophoc values ('L003','HV0003',null,null)
insert into chitietlophoc values ('L004','HV0006',null,null)
insert into chitietlophoc values ('L005','HV0008',null, null)
insert into chitietlophoc values ('L006','HV0007',null,null)
insert into chitietlophoc values ('L007','HV0007',null,null)
go
---- Check khóa học trong khoảng thời gian
create proc PS_searchnbdbnkt @a date ,@b date
as
	begin
		select *,concat(khoahoc.tenKhoaHoc,'/',cahoc.ten,'/',ngayhoc.ten) as [ABC] from khoahoc
		join  cahoc on cahoc.id = khoahoc.idCaHoc
		join ngayhoc on ngayhoc.id = khoahoc.idNgayHoc
		where  ngaybatdau >=  @a
	end
--- Lấy lớp học bằng id khóa học
go
create proc PS_getKhoaHocbyidLopHoc @idLopHoc varchar(255)
as
	begin
		select lophoc.id as[Mã lớp] from lophoc
		join khoahoc on lophoc.idKhoaHoc = khoahoc.id
	end
---- Check  tìm kiếm học viên bằng khóa học
go
create proc PS_searchHvByKhoaHoc @idKhoaHoc varchar(255)
as
	begin
		select * from hocvien
		join chitietlophoc on hocvien.id = chitietlophoc.idHocVien
		join lophoc on lophoc.id = chitietlophoc.idLopHoc
		join khoahoc on lophoc.idKhoaHoc = khoahoc.id 
		where khoahoc.id = @idKhoaHoc
	end
go
create proc PS_searchLopHocbyKhoaHoc @idKhoaHoc varchar(255)
as
	begin
		select * ,lophoc.id as [mã lớp] from lophoc
		join khoahoc on lophoc.idKhoaHoc = khoahoc.id
		where khoahoc.id = @idKhoaHoc
	end
GO
--- Chức năng đăng kí khóa học
create proc PS_InsertDangKyKhoaHoc 
	@idLopHoc varchar(255),
	@ngaydangki datetime,
	@idHocVien varchar(255)
as
	begin
		insert into chitietlophoc(idLopHoc,idHocVien,ngaydangki) values (@idLopHoc,@idHocVien,@ngaydangki)
	end
go
-- khóa học học viên đăng kí
create proc PS_XemKhoaHocHocvienDangky @hocvien varchar(255)
as 
	begin
		select chitietlophoc.ngaydangki as [Ngày đăng kí], khoahoc.id as [Mã Khoá học] ,khoahoc.hocPhi as[Học Phí],khoahoc.tenKhoaHoc as[Tên Khóa Học],hocvien.id  ,lophoc.id  from chitietlophoc
		join lophoc on chitietlophoc.idLopHoc = lophoc.id
		join khoahoc on khoahoc.id = lophoc.idKhoaHoc
		join hocvien on hocvien.id = chitietlophoc.idHocVien
		where chitietlophoc.idHocVien = @hocvien
		order by  chitietlophoc.ngaydangki asc
	end
--- laays gia tien cua mot khoa hoc
go
create proc PS_GetPriceByKhoaHoc @khoahoc varchar(255)
as
	begin
		select khoahoc.hocPhi from khoahoc
		where khoahoc.id = @khoahoc
	end
--exec PS_GetPriceByKhoaHoc 'KH001'
--- Laays ten bang ma hoc vien
go
create proc PS_getNamebyIDHv @idHocvien varchar(255)
as 
	begin
		select hocvien.tenHocVien from hocvien
		where hocvien.id = @idHocvien
	end
---  Lấy tên của khóa học 
go
create proc PS_GetNameByIdMaKhoaHoc @idKhoahoc varchar(255)
as 
	begin
		select khoahoc.tenKhoaHoc from khoahoc
		where khoahoc.id = @idKhoahoc 
	end

select * from khoahoc