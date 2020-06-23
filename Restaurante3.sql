create procedure sp_registrarUsuario
@nombreUsuario varchar(30), @nombre varchar(50), @edad int, @telefono varchar(15), @email varchar(50), @contraseña varchar(64), @rol varchar(20)
as
begin
	Insert into Usuarios(nombredeUsuario,nombre,edad,telefono,email,contraseña,rol) values (@nombreUsuario,@nombre,@edad,@telefono,@email,@contraseña,@rol)
end
Go
create procedure sp_nuevoProductoVenta
@nombre varchar(25), @precio money, @categoria varchar(20)
as
begin
	Insert into ProductosVenta(nombre,precio,categoria) values(@nombre,@precio,@categoria)
end
Go
create procedure sp_modificarProductoVenta
@idProductoV int, @nombre varchar(25), @precio money, @categoria varchar(20)
as
begin
	update ProductosVenta set nombre = @nombre, precio = @precio, categoria = @categoria 
	where idProductoV = @idProductoV
end
Go
create procedure sp_eliminarProductoVenta
@idProductoV int
as
begin
	delete ProductosVenta where idProductoV = @idProductoV
end
Go
create procedure sp_nuevoProductoCompra
@nombre varchar(25), @precio money, @categoria varchar(20), @idProveedor int
as
begin
	Insert into ProductosCompra(nombre,precio,categoria, idProveedor) values(@nombre,@precio,@categoria, @idProveedor)
end
Go
create procedure sp_modificarProductoCompra
@idProductoC int, @nombre varchar(25), @precio money, @categoria varchar(20), @idProveedor int
as
begin
	update ProductosCompra set nombre = @nombre, precio = @precio, categoria = @categoria , idProveedor = @idProveedor
	where idProductoC = @idProductoC
end
Go
create procedure sp_eliminarProductoCompra
@idProductoC int
as
begin
	delete ProductosCompra where idProductoC = @idProductoC
end
Go
create procedure sp_nuevoProveedor
@nombre varchar(25), @ubicacion varchar(60), @telefono varchar(15), @email varchar(30)
as
begin
	Insert into Proveedores(nombre,ubicacion,telefono,email) values(@nombre,@ubicacion,@telefono, @email)
end
Go
create procedure sp_modificarProveedor
@idProveedor int, @nombre varchar(25), @ubicacion varchar(60), @telefono varchar(15), @email varchar(30)
as
begin
	update Proveedores set nombre = @nombre, ubicacion = @ubicacion, telefono = @telefono , email = @email
	where idProveedor = @idProveedor
end
Go
create procedure sp_eliminarProveedor
@idProveedor int
as
begin
	delete Proveedores where idProveedor = @idProveedor
end
Go
create procedure sp_nuevaVenta
@totalaPagar money, @nombredeUsuario varchar(30)
as
begin
	Declare @fecha date 
	Set @fecha = GetDate()
	Insert into Ventas(fechadeVenta,totalPagar,estado,nombredeUsuario) values(@fecha,@totalaPagar,'Enviada',@nombredeUsuario)
end
Go
create procedure sp_nuevoDetalleV
@idProductoV int, @precioVenta money, @cantidad int, @idVenta int
as
begin
	Declare @totalProducto money
	Set @totalProducto = @precioVenta*@cantidad
	Insert into DetallesVenta(idProductoV, precioVenta, cantidad, totalProducto, idVenta) 
	values(@idProductoV,@precioVenta, @cantidad,@totalProducto,@idVenta)
end
Go
create procedure sp_eliminarVenta
@idVenta int
as
begin
	Delete DetallesVenta where idVenta = @idVenta
	Delete Ventas where idVenta = @idVenta
end
Go
create procedure sp_nuevaCompra
@totalaPagar money, @nombredeUsuario varchar(30), @idProveedor int
as
begin
	Declare @fecha date 
	Set @fecha = GetDate()
	Insert into Compras(fechadeCompra,totalaPagar,idProveedor,nombredeUsuario) values(@fecha,@totalaPagar,@idProveedor,@nombredeUsuario)
end
Go
create procedure sp_nuevoDetalleC
@idProductoC int, @precioCompra money, @cantidad int, @idCompra int
as
begin
	Declare @totalProducto money
	Set @totalProducto = @precioCompra*@cantidad
	Insert into DetallesCompra(idProductoC, precioCompra, cantidad, totalProducto, idCompra) 
	values(@idProductoC,@precioCompra, @cantidad,@totalProducto,@idCompra)
end
Go
create procedure sp_RecibirCompra
@idCompra int
as
begin

--validar si la  orden ya fue recibida


	--Crear la tabla temporal
		drop table if exists #procesarorden;

		create table #procesarorden(
			id int identity primary key,
			idProductoC int,
			cantidad int
		);
	--Insertando todos los detalles de la orden a procesar
	insert into #procesarorden (idProductoC,cantidad)
	select idProductoC,cantidad from DetallesCompra where idCompra=@idCompra


	--procesando todas filas de la tabla temporal
	
		WHILE ( SELECT count(*) FROM #procesarorden ) >0  
		BEGIN  
	 
			-- variables temporales a usar
			declare @id int, @idProductoC int, @idAlmacen int =0,
			@cantidad int;

			--estableciendo valores en la variables
			select top 1 @id=id,@idProductoC=idProductoC,
			@cantidad=cantidad from #procesarorden;
			--Comprobando si ya existe el producto en el inventario
			select @idAlmacen = idAlmacen from Almacen where idProductoC=@idProductoC
			if @idAlmacen>=1
			--incrementar existencias
				begin 
					update Almacen set cantidadDisponible=cantidadDisponible+@cantidad
					where idAlmacen=@idAlmacen;
				end
			else
			--insertar
				begin
					insert into Almacen values(@idProductoC,@cantidad);
				end
			delete from #procesarorden where id=@id;
	
   
		END 

		--actualizar la orden a recibida
end
Go
create procedure sp_idUltimaCompra
as
begin
	Select MAX(idCompra) from Compras
end
Go
create procedure sp_ListarProductosCporProveedor
@idProveedor int
as
begin
	Select * from ProductosCompra where idProveedor = @idProveedor
end
Go
create procedure sp_RecibirVenta
@idVenta int
as
begin

--validar si la  orden ya fue recibida


	--Crear la tabla temporal
		drop table if exists #procesarorden;

		create table #procesarorden(
			id int identity primary key,
			idProductoV int,
			cantidad int
		);
	--Insertando todos los detalles de la orden a procesar
	insert into #procesarorden (idProductoV,cantidad)
	select idProductoV,cantidad from DetallesVenta where idVenta=@idVenta

	
	
		WHILE ( SELECT count(*) FROM #procesarorden ) >0  
		BEGIN  
			drop table if exists #procesarReceta;

			-- variables temporales a usar
			declare @id int, @idProductoV int, @cantidadV int;
			--estableciendo valores en la variables
			select top 1 @id=id,@idProductoV=idProductoV, @cantidadV = cantidad from #procesarorden;
			--procesando todas filas de la tabla temporal

			create table #procesarReceta(
			id int identity primary key,
			idProductoV int,
			idProductoC int,
			cantidadEstimada int
			);
			insert into #procesarReceta (idProductoV,idProductoC,cantidadEstimada)
			select idProductoV,idProductoC,cantidadEstimada from Recetas where idProductoV=@idProductoV

			WHILE ( SELECT count(*) FROM #procesarReceta ) >0  
			BEGIN  

			-- variables temporales a usar
			declare @idR int, @idProductoC int, @idAlmacen int =0,
			@cantidadEstimada int;
			--estableciendo valores en la variables
			select top 1 @idR=id,@idProductoc=idProductoC,
			@cantidadEstimada=cantidadEstimada from #procesarReceta;
			--procesando todas filas de la tabla temporal

			--Comprobando si ya existe el producto en el inventario
			select @idAlmacen = idAlmacen from Almacen where idProductoC=@idProductoC
			if @idAlmacen>=1
			--incrementar existencias
				begin 
					update Almacen set cantidadDisponible=cantidadDisponible-(@cantidadV/@cantidadEstimada)
					where idAlmacen=@idAlmacen;
				end
			
			delete from #procesarReceta where id=@idR;
			END
		delete from #procesarorden where id=@id;
		END 

		--actualizar la orden a recibida
end
Go

create procedure sp_ultimaVenta
as
begin
	Select MAX(idVenta) from Ventas
end
Go
create

create procedure sp_ListaDetalles
@IdVenta int
as
begin
	Select * from DetallesVenta where idVenta = @IdVenta
end
Go
create procedure sp_ActualizarEstadoVenta
@IdVenta int, @estado varchar(15)
as
begin
	Update Ventas set estado = @estado where idVenta = @IdVenta
end
Go
create procedure sp_ListaReceta
@idProductoV int
as
begin
	Select * from Recetas where idProductoV = @idProductoV
end
Go
create procedure sp_nuevaReceta
@idProductoV int, @idProductoC int, @cantidad int
as
begin
	Insert into Recetas(idProductoV,idProductoC,cantidadEstimada) values(@idProductoV,@idProductoC,@cantidad)
end
Go
create procedure sp_modificarReceta
@idProductoC int, @cantidad int, @idProductoV int
as
begin
	update Recetas set cantidadEstimada = @cantidad
	where idProductoC = @idProductoC and idProductoV = @idProductoV
end
Go
create procedure sp_eliminarReceta
@idProductoC int, @idProductoV int
as
begin
	delete Recetas where idProductoC = @idProductoC and idProductoV = @idProductoV
end