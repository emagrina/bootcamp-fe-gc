CREATE DATABASE IF NOT EXISTS ex02;
USE ex02;

CREATE TABLE temas (
    clave_tema INT AUTO_INCREMENT PRIMARY KEY,
    nombre NVARCHAR(100)
);

CREATE TABLE autores (
    clave_autor INT AUTO_INCREMENT PRIMARY KEY,
    nombre NVARCHAR(100)
);

CREATE TABLE editoriales (
    clave_editorial INT AUTO_INCREMENT PRIMARY KEY,
    nombre NVARCHAR(100),
    direccion NVARCHAR(200),
    telefono NVARCHAR(15)
);

CREATE TABLE libros (
    clave_libro INT AUTO_INCREMENT PRIMARY KEY,
    titulo NVARCHAR(255),
    idioma NVARCHAR(100),
    formato NVARCHAR(100),
    clave_editorial INT,
    FOREIGN KEY (clave_editorial) REFERENCES editoriales(clave_editorial) ON UPDATE CASCADE ON DELETE CASCADE
);

CREATE TABLE ejemplares (
    clave_ejemplar INT AUTO_INCREMENT PRIMARY KEY,
    clave_libro INT,
    numero_orden INT,
    edicion NVARCHAR(50),
    ubicacion NVARCHAR(100),
    categoria NVARCHAR(50),
    FOREIGN KEY (clave_libro) REFERENCES libros(clave_libro) ON UPDATE CASCADE ON DELETE CASCADE
);

CREATE TABLE socios (
    clave_socio INT AUTO_INCREMENT PRIMARY KEY,
    nombre NVARCHAR(100),
    direccion NVARCHAR(200),
    telefono NVARCHAR(15),
    categoria NVARCHAR(50)
);

CREATE TABLE prestamos (
    clave_socio INT,
    clave_ejemplar INT,
    numero_orden INT,
    fecha_prestamo DATE,
    fecha_devolucion DATE,
    notas NVARCHAR(500),
    PRIMARY KEY (clave_socio, clave_ejemplar, numero_orden),
    FOREIGN KEY (clave_socio) REFERENCES socios(clave_socio) ON UPDATE CASCADE ON DELETE CASCADE,
    FOREIGN KEY (clave_ejemplar) REFERENCES ejemplares(clave_ejemplar) ON UPDATE CASCADE ON DELETE CASCADE
);

CREATE TABLE tratas_sobre (
    clave_libro INT,
    clave_tema INT,
    PRIMARY KEY (clave_libro, clave_tema),
    FOREIGN KEY (clave_libro) REFERENCES libros(clave_libro) ON UPDATE CASCADE ON DELETE CASCADE,
    FOREIGN KEY (clave_tema) REFERENCES temas(clave_tema) ON UPDATE CASCADE ON DELETE CASCADE
);

CREATE TABLE escrito_por (
    clave_libro INT,
    clave_autor INT,
    PRIMARY KEY (clave_libro, clave_autor),
    FOREIGN KEY (clave_libro) REFERENCES libros(clave_libro) ON UPDATE CASCADE ON DELETE CASCADE,
    FOREIGN KEY (clave_autor) REFERENCES autores(clave_autor) ON UPDATE CASCADE ON DELETE CASCADE
);
