use QLNHADAT
go

--Xem thông tin Khách Hàng yêu cầu. -> một procedure select KHACH HANG.
alter procedure sp_TimNhaChoKhachHang
	@loaiNha varchar(50) = NULL,
	@gia money = NULL,
	@loaiGia int = NULL, --1 la nho hon hoac bang, 2 la lon hon hoac bang
	@soLuongPhong  int = NULL,
	@duongNha varchar(50) = NULL,
	@quanNha varchar(50) = NULL,
	@tpNha varchar(50) = NULL,
	@khuVucNha varchar(50) = NULL,
	@idChiNhanh varchar(10) = NULL
	
as
begin
	declare @strQuery nvarchar(3900)
	declare @paraList nvarchar(500)
	set @paraList = '
			@gia money,
			@loaiGia int,
			@soLuongPhong int,
			@duongNha varchar(50),
			@quanNha varchar(50),
			@tpNha varchar(50),
			@khuVucNha varchar(50),
			@idChiNhanh varchar(10)'
	--Ket cac bang lai truoc va loc sau
	if(@loaiNha = 'Nha Ban')
	begin
		set @strQuery = N'select n.*, nb.GIABAN, nb.DIEUKIENCNHA
		from NHA n join NHABAN nb on n.IDNHA = nb.IDNHA
		where n.TINHTRANG != 1 and n.NGAYDANG < getdate() and (n.NGAYHETHANG is NULL or n.NGAYHETHANG > getdate())'
		if(@gia != N'')
			if(@loaiGia = 1)
				set @strQuery = @strQuery + ' and nb.GIABAN <= @gia'
			else
				set @strQuery = @strQuery + ' and nb.GIABAN >= @gia'
		if(@soLuongPhong != N'')
			set @strQuery = @strQuery + ' and n.SOLUONGNHA = @soLuongPhong'
		if(@duongNha != N'')
			set @strQuery = @strQuery + ' and n.DUONGNHA = @duongNha'
		if(@quanNha != N'')
			set @strQuery = @strQuery + ' and n.QUANNHA = @quanNha'
		if(@tpNha != N'')
			set @strQuery = @strQuery + ' and n.TPNHA = @tpNha'
		if(@khuVucNha != N'')
			set @strQuery = @strQuery + ' and n.KHUVUCNHA = @khuVucNha'
		if(@idChiNhanh != N'')
			set @strQuery = @strQuery + ' and n.IDCNHANH = @idChinhNhanh'
	end
	else if(@loaiNha = 'Nha Thue')
	begin
		set @strQuery = N'select n.*, nt.TIENTHUE
						from NHA n join NHATHUE nt on n.IDNHA = nt.IDNHA
						where n.TINHTRANG != 1 and n.NGAYDANG < getdate() and (n.NGAYHETHANG is NULL or n.NGAYHETHANG > getdate())'
		if(@gia != N'')
			if(@loaiGia = 1)
				set @strQuery = @strQuery + ' and nb.TIENTHUE <= @gia'
			else
				set @strQuery = @strQuery + ' and nb.TIENTHUE >= @gia'
		if(@soLuongPhong != N'')
			set @strQuery = @strQuery + ' and n.SOLUONGNHA = @soLuongPhong'
		if(@duongNha != N'')
			set @strQuery = @strQuery + ' and n.DUONGNHA = @duongNha'
		if(@quanNha != N'')
			set @strQuery = @strQuery + ' and n.QUANNHA = @quanNha'
		if(@tpNha != N'')
			set @strQuery = @strQuery + ' and n.TPNHA = @tpNha'
		if(@khuVucNha != N'')
			set @strQuery = @strQuery + ' and n.KHUVUCNHA = @khuVucNha'
		if(@idChiNhanh != N'')
			set @strQuery = @strQuery + ' and n.IDCNHANH = @idChinhNhanh'
	end
	else
	begin
		select * from NHA n
		where n.TINHTRANG != 1 and n.NGAYDANG < getdate() 
		and (n.NGAYHETHANG is NULL or n.NGAYHETHANG > getdate())
	end

	exec sp_executesql @strQuery,
		@paraList,
		@gia, --Doi so dua vao phai tuong ung voi paraList
		@loaiGia,
		@soLuongPhong,
		@duongNha,
		@quanNha,
		@tpNha,
		@khuVucNha,
		@idChiNhanh
end
go

--select getdate()
--exec sp_TimNhaChoKhachHang 'Nha Ban', 100000, 2, 5, 2
--go

--procedure xem yeu cau cau khach hang
alter procedure [dbo].[sp_XemYeuCauKhachHang] 
	@idKhachHang varchar(10) = NULL,
	@tenKhachHang varchar(50) = NULL,
	@idChiNhanh varchar(10) = NULL	
as
begin
	declare @strQuery nvarchar(3000) --Đây là chuỗi chứa câu lệnh sql thực thi xem thông tin khách hàng, nó được gọi ở cuối exec sp_executesql
	declare @paraList nvarchar(500)  --Là các argument đưa vào trong cái chuỗi @strQuery để lọc record, nó được thể hiện ở if.

	--Các đối số này tương ứng với các đối số của procedure
	set @paraList = '
		@idKhachHang varchar(10),
		@tenKhachHang varchar(50),    
		@idChiNhanh varchar(10)'
	--Cau lệnh thực thi
	set @strQuery = N'select kh.*
					from KHACHHANG kh
					where (1=1)'
	--Thêm điều kiện nếu tham số đưa vào từ Winform thỏa điều kiện khac rỗng, nếu không nhập gì thì bỏ qua điều kiện
	if(@idKhachHang != N'')
		set @strQuery = @strQuery + ' and kh.IDKH = @idKhachHang'  --Được thêm vào strQuery để thực thi lọc record
	if(@tenKhachHang != N'')
		set @strQuery = @strQuery + ' and kh.TENKH = @tenKhachHang'
	if(@idChiNhanh != N'')
	set @strQuery = @strQuery + ' and kh.IDCNHANH = @idChiNhanh'
	--Thuc thi procedure
	waitfor delay '00:00:30'
	exec sp_executesql
		@strQuery,
		@paraList,
		@idKhachHang,
		@tenKhachHang,
		@idChiNhanh		
end
GO
--exec sp_XemYeuCauKhachHang NULL, NULL, N'1'

--## Nhân viên ghi nhận đánh giá của khách hàng ##--
create procedure sp_AddHouseReview @houseID varchar(10) = NULL, @review varchar(100)= NULL
as
begin
	insert TTDANHGIANHA
	values((select max(tt.STT) from TTDANHGIANHA tt), @houseID, getdate(), @review)
end
go
--## Nhân viên sửa lại đánh giá của khách hàng ##--
create procedure sp_ModifyHouseReview @houseID varchar(10) = NULL, @review varchar(100)= NULL
as
begin
	update TTDANHGIANHA
	set NHANXET = @review, NGAYNX = getdate()
	where IDNHANX = @houseID
end
go

--## Nhân viên xóa đánh giá của khách hàng ##--


--### Nhân viên cập nhật lượt view cho nhà