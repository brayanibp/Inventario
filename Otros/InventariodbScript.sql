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
    tipo CHAR(1) NOT NULL,
    cedula INT UNIQUE NOT NULL,
    nombre VARCHAR(20) NOT NULL,
    apellido VARCHAR(20) NOT NULL,
    username VARCHAR(20) NOT NULL,
    direccion TEXT(100) NOT NULL,
    fecha_nacimiento DATE NOT NULL,
    accesos VARCHAR(45) NOT NULL DEFAULT 'Inv',
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
    estatus CHAR(1) NOT NULL,
    responsable_id INT NOT NULL,
    cliente_id INT NOT NULL,
    CONSTRAINT responsable_id FOREIGN KEY (responsable_id) 
    REFERENCES usuarios(id),
    CONSTRAINT cliente_id FOREIGN KEY (cliente_id) 
    REFERENCES clientes(id)
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
CREATE TRIGGER `_control_factura` AFTER INSERT ON `facturas` FOR EACH ROW UPDATE facturas SET facturas.nro_factura = facturas.id.OLD, facturas.nro_control = facturas.id.OLD WHERE facturas.id = facturas.id;

INSERT INTO usuarios (tipo,cedula,nombre,apellido,username,direccion,fecha_nacimiento,accesos,u_password) VALUES ('V',0,'ADMINISTRADOR','ADMINISTRADOR','ADMIN','EMPRESA',NOW(),'Inv.cUs.cAc.cCl.lCl.Fac.rFa.aFa.','admin')