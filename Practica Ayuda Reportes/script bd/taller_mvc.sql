CREATE DATABASE IF NOT EXISTS taller_mvc;

USE taller_mvc;

CREATE TABLE bodega (
    id_bodega INT NOT NULL AUTO_INCREMENT,
    id_sucursal INT,
    nombre_bodega VARCHAR(100),
    id_direccion INT,
    capacidad_bodega INT,
    telefono_bodega VARCHAR(20),
    PRIMARY KEY (id_bodega)
);


INSERT INTO bodega
    (id_sucursal, nombre_bodega, id_direccion, capacidad_bodega, telefono_bodega)
VALUES
    (1, 'Bodega Central',   1, 500, '5555-1001'),
    (2, 'Bodega Norte',     2, 750, '5555-1002'),
    (3, 'Bodega Sur',       3, 600, '5555-1003'),
    (4, 'Bodega Oriente',   4, 900, '5555-1004'),
    (5, 'Bodega Occidente', 5, 450, '5555-1005');

