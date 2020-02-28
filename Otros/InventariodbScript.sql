DROP DATABASE IF EXISTS inventariodb;
CREATE DATABASE IF NOT EXISTS inventariodb;
USE inventariodb;
CREATE TABLE IF NOT EXISTS clientes(
	id INT PRIMARY KEY AUTO_INCREMENT,
    tipo CHAR(1) NOT NULL,
    cedula INT UNIQUE NOT NULL,
    nombre VARCHAR(20) NOT NULL,
    apellido VARCHAR(20) NOT NULL,
    direccion TEXT(100) NOT NULL,
    fecha_nacimiento DATE NOT NULL
) ENGINE = InnoDB;

CREATE TABLE IF NOT EXISTS marcas(
	id INT PRIMARY KEY AUTO_INCREMENT,
    nombre VARCHAR(45) NOT NULL
) ENGINE = InnoDB;

CREATE TABLE IF NOT EXISTS usuarios(
	id INT PRIMARY KEY AUTO_INCREMENT,
    cedula INT UNIQUE NOT NULL,
    nombre VARCHAR(20) NOT NULL,
    apellido VARCHAR(20) NOT NULL,
    fecha_nacimiento DATE NOT NULL,
    direccion TEXT(100) NOT NULL,
    accesos VARCHAR(45) NOT NULL DEFAULT 'a1',
    u_password VARCHAR(45) NOT NULL
) ENGINE = InnoDB;

CREATE TABLE IF NOT EXISTS productos(
	id INT PRIMARY KEY AUTO_INCREMENT,
    nombre VARCHAR(45) NOT NULL,
    marca_id INT NOT NULL,
    precio DOUBLE NOT NULL,
    iva INT NOT NULL DEFAULT 16,
    unidades INT NOT NULL DEFAULT 0,
    CONSTRAINT marca_id FOREIGN KEY (marca_id)
    REFERENCES marcas (id)
) ENGINE = InnoDB;

CREATE TABLE facturas(
	id INT PRIMARY KEY AUTO_INCREMENT,
    nro_factura INT NOT NULL,
    nro_control INT NOT NULL,
    fecha DATE NOT NULL,
    monto_bruto DOUBLE NOT NULL,
    iva INT NOT NULL DEFAULT 16,
    estatus CHAR(1) NOT NULL
) ENGINE = InnoDB;

CREATE TABLE facturas_det(
	id INT PRIMARY KEY AUTO_INCREMENT,
    factura_id INT NOT NULL,
    producto_id INT NOT NULL,
    unidades INT NOT NULL,
    CONSTRAINT factura_id FOREIGN KEY (factura_id)
    REFERENCES facturas (id),
    CONSTRAINT producto_id FOREIGN KEY (producto_id)
    REFERENCES productos (id)
) ENGINE = InnoDB;