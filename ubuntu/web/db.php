<?php
$host = "10.50.30.200";  // IP del servidor de base de datos
$user = "grupo4";       // Usuario creado
$pass = "12345";          // Contraseña
$db   = "clientesdb";     // Base de datos

$conn = new mysqli($host, $user, $pass, $db);
if ($conn->connect_error) {
    die("Error de conexión: " . $conn->connect_error);
}
$conn->set_charset("utf8mb4");
?>

