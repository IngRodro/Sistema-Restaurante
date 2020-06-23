insert into Proveedores (nombre, ubicacion, telefono, email) values ('Vericel Corporation', 'Naga', '4125781177', 'vcurcher0@census.gov');
insert into Proveedores (nombre, ubicacion, telefono, email) values ('Live Nation Entertainment, Inc.', 'Fryčovice', '8163498768', 'sbresland1@cpanel.net');
insert into Proveedores (nombre, ubicacion, telefono, email) values ('Farmers Capital Bank Corporation', 'Nagiba', '2683019186', 'mbenian2@so-net.ne.jp');
insert into Proveedores (nombre, ubicacion, telefono, email) values ('Halyard Health, Inc.', 'Kauswagan', '1013828497', 'prosetti3@usnews.com');
insert into Proveedores (nombre, ubicacion, telefono, email) values ('Customers Bancorp, Inc', 'Jiangyou', '7788169807', 'vwhitcomb4@imgur.com');
insert into Proveedores (nombre, ubicacion, telefono, email) values ('Dover Motorsports, Inc.', 'Shimen', '9439275263', 'gjanicki5@mapy.cz');
insert into Proveedores (nombre, ubicacion, telefono, email) values ('Sibanye Gold Limited', 'Llipa', '6856741847', 'tgallyon6@homestead.com');
insert into Proveedores (nombre, ubicacion, telefono, email) values ('Silver Run Acquisition Corporation II', 'Armenta', '8554457985', 'askipp7@delicious.com');
insert into Proveedores (nombre, ubicacion, telefono, email) values ('Gladstone Capital Corporation', 'Xuancheng', '3637919605', 'regginton8@cbslocal.com');
insert into Proveedores (nombre, ubicacion, telefono, email) values ('Lexicon Pharmaceuticals, Inc.', 'Barrunchal', '8978636124', 'dchantillon9@comsenz.com');

insert into ProductosCompra (nombre, precio, idProveedor) values ('Beef Flat Iron Steak', '5.33', 5);
insert into ProductosCompra (nombre, precio, idProveedor) values ('Long Island Ice Tea', '5.73', 7);
insert into ProductosCompra (nombre, precio, idProveedor) values ('Waffle Stix', '9.33', 8);
insert into ProductosCompra (nombre, precio, idProveedor) values ('Creme De Menthe Green', '0.77', 1);
insert into ProductosCompra (nombre, precio, idProveedor) values ('Smirnoff Green Apple Twist', '4.27', 2);
insert into ProductosCompra (nombre, precio, idProveedor) values ('Puree - Pear', '3.44', 7);
insert into ProductosCompra (nombre, precio, idProveedor) values ('Seedlings - Clamshell', '1.95', 5);
insert into ProductosCompra (nombre, precio, idProveedor) values ('Pork - Ground', '8.03', 8);
insert into ProductosCompra (nombre, precio, idProveedor) values ('Beer - Blue', '7.41', 1);
insert into ProductosCompra (nombre, precio, idProveedor) values ('Bread - Roll, Calabrese', '8.55', 3);
insert into ProductosCompra (nombre, precio, idProveedor) values ('Wine - Two Oceans Sauvignon', '3.50', 8);
insert into ProductosCompra (nombre, precio, idProveedor) values ('Juice - Pineapple, 341 Ml', '4.13', 3);

insert into ProductosVenta (nombre, precio) values ('Turkey - Ground. Lean', '6.76');
insert into ProductosVenta (nombre, precio) values ('Marjoram - Fresh', '3.57');
insert into ProductosVenta (nombre, precio) values ('Wine - Saint - Bris 2002, Sauv', '9.02');
insert into ProductosVenta (nombre, precio) values ('Liners - Banana, Paper', '0.96');
insert into ProductosVenta (nombre, precio) values ('Vinegar - White', '0.15');
insert into ProductosVenta (nombre, precio) values ('Soup - Campbells, Spinach Crm', '9.94');
insert into ProductosVenta (nombre, precio) values ('Chocolate - Sugar Free Semi Choc', '7.91');
insert into ProductosVenta (nombre, precio) values ('Wine - Segura Viudas Aria Brut', '6.39');
insert into ProductosVenta (nombre, precio) values ('Beans - Black Bean, Dry', '0.38');
insert into ProductosVenta (nombre, precio) values ('Chinese Foods - Pepper Beef', '1.54');
insert into ProductosVenta (nombre, precio) values ('Cocoa Powder - Dutched', '7.03');
insert into ProductosVenta (nombre, precio) values ('Beans - Black Bean, Preserved', '2.09');

insert into Almacen (idProductoC, cantidadDisponible) values (1,100)
insert into Almacen (idProductoC, cantidadDisponible) values (2,100)
insert into Almacen (idProductoC, cantidadDisponible) values (3,100)
insert into Almacen (idProductoC, cantidadDisponible) values (4,100)
insert into Almacen (idProductoC, cantidadDisponible) values (5,100)
insert into Almacen (idProductoC, cantidadDisponible) values (6,100)
insert into Almacen (idProductoC, cantidadDisponible) values (7,100)
insert into Almacen (idProductoC, cantidadDisponible) values (8,100)
insert into Almacen (idProductoC, cantidadDisponible) values (9,100)

Update ProductosCompra set estado = 'Activo'
Update Proveedores set estado = 'Activo'
Update ProductosVenta set estado = 'Activo'