Create Database Computadora
CREATE TABLE Computadoras (
    ID INT PRIMARY KEY,
    Nombre VARCHAR(100),
    Descripcion TEXT,
    Precio DECIMAL(10, 2),
    FechaFabricacion DATE
);
INSERT INTO Computadoras (ID, Nombre, Descripcion, Precio, FechaFabricacion) VALUES
(1, 'Laptop HP Pavilion', 'Laptop de gama media con procesador Intel Core i5 y 8GB de RAM', 699.99, '2023-05-15'),
(2, 'PC de escritorio Dell Inspiron', 'Computadora de escritorio con monitor de 24 pulgadas y procesador AMD Ryzen 7', 899.99, '2023-04-20'),
(3, 'MacBook Air', 'Portátil ligero y potente con procesador M1 y 256GB de almacenamiento SSD', 1299.99, '2023-06-10'),
(4, 'Lenovo ThinkPad X1 Carbon', 'Ultrabook empresarial con pantalla táctil de 14 pulgadas y procesador Intel Core i7', 1499.99, '2023-07-25'),
(5, 'Asus ROG Strix G15', 'Laptop para juegos con pantalla de 15.6 pulgadas, GPU NVIDIA GeForce RTX 3060 y 16GB de RAM', 1799.99, '2023-08-05'),
(6, 'iMac 27 pulgadas', 'Ordenador todo en uno con pantalla Retina 5K, procesador Intel Core i9 y 512GB de almacenamiento SSD', 2199.99, '2023-09-12');


Select * from Computadoras