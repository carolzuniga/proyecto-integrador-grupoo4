Sistema PHP - CRUD mínimo de clientes
====================================
Web (Apache + PHP) en XAMPP, BD remota en 10.50.30.200 (MariaDB/MySQL).

1) Subir al servidor web
   Copie la carpeta 'clientes' a /opt/lampp/htdocs/
      sudo cp -r clientes /opt/lampp/htdocs/
      sudo chown -R daemon:daemon /opt/lampp/htdocs/clientes
      sudo chmod -R 755 /opt/lampp/htdocs/clientes

2) Crear BD (en el servidor 10.50.30.200)
   CREATE DATABASE clientesdb;
   USE clientesdb;
   CREATE TABLE clientes (
       id INT AUTO_INCREMENT PRIMARY KEY,
       nombre VARCHAR(50),
       apellido VARCHAR(50)
   );

3) Ajustar credenciales si es necesario
   En db.php puedes cambiar usuario/clave/BD.

4) Probar
   http://<IP_DEL_SERVIDOR_WEB>/clientes/

Nota: asegúrate de que el MySQL en 10.50.30.200 acepte conexiones remotas
      (bind-address=0.0.0.0) y el puerto 3306 esté accesible.
