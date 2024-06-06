INSERT INTO clientes (dni, nombre, apellidos, direccion, telefono, numero_tarjeta)
VALUES
('123456789', 'Juan', 'Pérez', 'Calle Mayor 123', '555-1234', '1234-5678-9012'),
('987654321', 'María', 'López', 'Avenida Principal 456', '555-5678', '5678-9012-3456'),
('456789123', 'Carlos', 'Gómez', 'Plaza Central 789', '555-9012', '9012-3456-7890'),
('321654987', 'Ana', 'Martínez', 'Calle Secundaria 456', '555-7890', '3456-7890-1234'),
('654321987', 'Pedro', 'Ramírez', 'Avenida Secundaria 789', '555-2345', '6789-0123-4567'),
('789456321', 'Laura', 'Sánchez', 'Calle Principal 321', '555-6789', '2345-6789-0123'),
('159753852', 'Sergio', 'Torres', 'Plaza Mayor 654', '555-3456', '5678-9012-3456'),
('753951852', 'Elena', 'García', 'Avenida Central 852', '555-4567', '9012-3456-7890'),
('258369147', 'Manuel', 'Hernández', 'Calle Central 741', '555-5678', '0123-4567-8901'),
('951753456', 'Isabel', 'Díaz', 'Avenida Principal 369', '555-6789', '4567-8901-2345');

INSERT INTO reservas (id, dni_cliente, numero_plazas, fecha_reserva)
VALUES
(1, '123456789', 2, '2023-08-01'),
(2, '987654321', 3, '2023-08-02'),
(3, '456789123', 1, '2023-08-03'),
(4, '321654987', 4, '2023-08-04'),
(5, '654321987', 2, '2023-08-05'),
(6, '789456321', 3, '2023-08-06'),
(7, '159753852', 1, '2023-08-07'),
(8, '753951852', 2, '2023-08-08'),
(9, '258369147', 3, '2023-08-09'),
(10, '951753456', 1, '2023-08-10');

INSERT INTO tarjetas_embarques (id_tarjeta, dni_cliente, id_reserva, fila, columna, planta)
VALUES
(1, '123456789', 1, 5, 8, 1),
(2, '987654321', 2, 2, 3, 2),
(3, '456789123', 3, 3, 2, 1),
(4, '321654987', 4, 6, 4, 1),
(5, '654321987', 5, 4, 5, 2),
(6, '789456321', 6, 1, 1, 1),
(7, '159753852', 7, 3, 6, 2),
(8, '753951852', 8, 2, 7, 1),
(9, '258369147', 9, 5, 2, 2),
(10, '951753456', 10, 4, 9, 1);

INSERT INTO aeropuertos (codigo, nombre, localidad, pais)
VALUES
('MAD', 'Aeropuerto Adolfo Suárez Madrid-Barajas', 'Madrid', 'España'),
('BCN', 'Aeropuerto Josep Tarradellas Barcelona-El Prat', 'Barcelona', 'España'),
('LHR', 'Heathrow Airport', 'London', 'United Kingdom'),
('CDG', 'Charles de Gaulle Airport', 'Paris', 'France'),
('JFK', 'John F. Kennedy International Airport', 'New York', 'United States'),
('HND', 'Haneda Airport', 'Tokyo', 'Japan'),
('PEK', 'Beijing Capital International Airport', 'Beijing', 'China'),
('SYD', 'Sydney Airport', 'Sydney', 'Australia'),
('DXB', 'Dubai International Airport', 'Dubai', 'United Arab Emirates'),
('SIN', 'Changi Airport Singapore', 'Singapore', 'Singapore');

INSERT INTO aviones (codigo, numero_plazas)
VALUES
('A320', 150),
('B737', 180),
('A380', 555),
('B777', 400),
('A330', 300),
('B747', 416),
('B787', 242),
('E190', 114),
('A340', 380),
('A350', 366);

INSERT INTO vuelos (codigo, fecha_salida, hora_salida, fecha_llegada, hora_llegada, codigo_aeropuerto_salida, codigo_aeropuerto_llegada, codigo_avion)
VALUES
('IB123', '2023-08-01', '08:00:00', '2023-08-01', '10:30:00', 'MAD', 'BCN', 'A320'),
('BA456', '2023-08-02', '14:30:00', '2023-08-02', '17:00:00', 'LHR', 'CDG', 'B737'),
('JFK789', '2023-08-03', '20:45:00', '2023-08-04', '08:15:00', 'JFK', 'MAD', 'A380'),
('PEK987', '2023-08-04', '10:00:00', '2023-08-05', '03:45:00', 'PEK', 'SYD', 'B777'),
('HND654', '2023-08-05', '13:15:00', '2023-08-06', '05:30:00', 'HND', 'DXB', 'A330'),
('SIN321', '2023-08-06', '23:30:00', '2023-08-07', '14:45:00', 'SIN', 'MAD', 'B747'),
('LHR789', '2023-08-07', '06:30:00', '2023-08-08', '09:45:00', 'LHR', 'BCN', 'A320'),
('DXB456', '2023-08-08', '17:45:00', '2023-08-09', '08:00:00', 'DXB', 'JFK', 'B787'),
('CDG654', '2023-08-09', '12:00:00', '2023-08-10', '17:30:00', 'CDG', 'PEK', 'E190'),
('SYD321', '2023-08-10', '09:15:00', '2023-08-11', '02:30:00', 'SYD', 'SIN', 'A340');

INSERT INTO reservas_vuelos (id_reserva, codigo_vuelo)
VALUES
(1, 'IB123'),
(2, 'BA456'),
(3, 'JFK789'),
(4, 'PEK987'),
(5, 'HND654'),
(6, 'SIN321'),
(7, 'LHR789'),
(8, 'DXB456'),
(9, 'CDG654'),
(10, 'SYD321');
