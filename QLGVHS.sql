create proc ThongKeHocSinh
	@idlop int
as
	begin
		select IDHOCSINH,HOTEN,GIOITINH,NGAYSINH
		from HOCSINH
		where IDLOP = @idlop
	end