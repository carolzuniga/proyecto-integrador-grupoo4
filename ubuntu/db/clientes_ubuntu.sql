-- Creación de la base de datos para el sistema de clientes (Ubuntu)

CREATE DATABASE IF NOT EXISTS clientesdb
  CHARACTER SET utf8mb4
  COLLATE utf8mb4_unicode_ci;

USE clientesdb;

-- Tabla de clientes
CREATE TABLE IF NOT EXISTS clientes (
  IDclientes INT AUTO_INCREMENT PRIMARY KEY,
  Nombre VARCHAR(50) NOT NULL,
  Apellido VARCHAR(50) NOT NULL
);
