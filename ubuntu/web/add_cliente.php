<?php
error_reporting(E_ALL);
ini_set('display_errors', 1);

include("db.php");

if ($_SERVER['REQUEST_METHOD'] == 'POST') {
    // Verificar si los campos están definidos antes de usarlos
    $nombre = isset($_POST['nombre']) ? trim($_POST['nombre']) : '';
    $apellido = isset($_POST['apellido']) ? trim($_POST['apellido']) : '';

    // Solo insertar si ambos campos tienen valor
    if ($nombre !== '' && $apellido !== '') {
        $stmt = $conn->prepare("INSERT INTO clientes (Nombre, Apellido) VALUES (?, ?)");
        $stmt->bind_param("ss", $nombre, $apellido);

        if ($stmt->execute()) {
            // Redirigir de nuevo a la página principal después de guardar
            header("Location: index.php");
            exit();
        } else {
            echo "Error al guardar: " . $stmt->error;
        }

        $stmt->close();
    } else {
        echo "Por favor, complete todos los campos.";
    }
}

$conn->close();
?>

