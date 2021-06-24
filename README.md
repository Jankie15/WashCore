# WashCore

# Pasos para ejecutar el proyecto

# 1 PASO
Craear base de datos llamada WashCarDB.
CREATE DATABASE WashCarDB.

# 2 PASO 
Configurar la conexion a la base de datos en la capa AccesoDatos.
Cambiar el Server existente (MSI-GF63-THIN) por el Server del sql local. 

optionsBuilder.UseSqlServer("Server=(localdb)\\MSI-GF63-THIN; Database=WashCarDB; Trusted_Connection=True;");

# 3 PASO 
En la capa presentación en el archivo de appsettings.json
Cambiar el string de conexión por el local 

"ConnectionStrings": {
    "WashCarDBContext": "Server=MSI-GF63-THIN; Database=WashCarDB; Trusted_Connection=True;"
  }