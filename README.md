# 🧾 CRUD de Clientes - ASP.NET MVC (.NET C#)

Este proyecto consiste en un sitio web CRUD desarrollado en **ASP.NET MVC con C#**. Permite gestionar clientes mediante operaciones de alta, visualización, edición y eliminación.

---

## 📌 Funcionalidades requeridas

La aplicación permite:

### ➕ Dar de alta clientes
- **CUIT**: campo obligatorio de 11 dígitos numéricos (sin guiones).
- **Razón Social**: se completa automáticamente y es de solo lectura.
- **Teléfono**: numérico.
- **Dirección**: máximo 200 caracteres.
- **Activo**: checkbox (Sí/No).

### 📋 Listar clientes
Visualización de todos los clientes registrados, con tabla y acciones disponibles.

### ✏️ Editar cliente
Modificación de los datos existentes con validaciones.

### ❌ Eliminar cliente
Confirmación previa con modal antes de borrar un registro.

---

## 📸 Capturas de pantalla

### Formulario de alta
![Formulario de alta](_screenshots/s1.PNG)

### Listado de clientes
![Listado de clientes](_screenshots/s2.PNG)

### Edición de cliente
![Edición de cliente](_screenshots/s3.PNG)

---

## ⚙️ Tecnologías utilizadas

- **.NET Framework / .NET Core** (según la versión usada)
- **ASP.NET MVC**
- **Entity Framework**
- **Razor Views**
- **Bootstrap 5**
- **SweetAlert2** para las confirmaciones

---

## 🚀 Instrucciones para correr el proyecto

1. Clonar el repositorio:
   ```bash
   git clone https://github.com/alexander5109/ProyectoIntegraComex.git
