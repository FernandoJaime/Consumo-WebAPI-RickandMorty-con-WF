<h1 align="center">🧪 Consumo WebAPI Rick and Morty con WinForms</h1>

Aplicacion de escritorio desarrollada en C# con Windows Forms que consume la API publica de Rick and Morty para explorar personajes, aplicar filtros, navegar por paginas y consultar detalles extendidos como episodios y localizacion.

## 📄 Caracteristicas principales

- Interfaz de escritorio con menu inicial y navegacion entre formularios.
- Consumo de la API REST oficial: `https://rickandmortyapi.com/api`.
- Listado visual de personajes con imagenes en grilla dinamica.
- Filtros combinables por nombre, estado y genero.
- Paginacion de resultados con botones `Back` y `Next`.
- Vista de detalle por personaje al hacer click sobre su imagen.
- Consulta de ubicacion del personaje (nombre, tipo, dimension).
- Consulta de episodios del personaje en una grilla (`DataGridView`).
- Manejo basico de errores de API mediante mensajes al usuario.

## 🛠️ Tecnologias

- .NET 8 
- C#
- Windows Forms
- HttpClient para consumo HTTP
- System.Text.Json para deserializacion JSON

## 🗃️ Estructura del proyecto

```text
Consumo-WebAPI-RickandMorty-con-WF/
├── Consumo WebAPI RickandMorty.sln
├── README.md
└── RickandMorty/
	├── Program.cs
	├── RickandMorty.csproj
	├── Controllers/
	│   ├── CharacterController.cs
	│   ├── EpisodeController.cs
	│   └── LocationController.cs
	├── Models/
	│   ├── Character.cs
	│   ├── Characters.cs
	│   ├── Episode.cs
	│   ├── Episodes.cs
	│   ├── Info.cs
	│   ├── Location.cs
	│   └── Origin.cs
	├── Properties/
	│   ├── Resources.Designer.cs
	│   └── Resources.resx
	├── Resources/
	│   ├── ImageBack.jpg
	│   ├── ImageMenu.png
	│   ├── Menuu.jpg
	│   ├── Rick icono.ico
	│   ├── Rick y morty Pages.png
	│   └── tittle.png
	└── Views/
		├── Menu.cs
		├── PagesCharacters.cs
		└── InfoCharacter.cs
```

## 🧠 Arquitectura y flujo

El proyecto sigue una separacion simple por capas:

- `Views/`: formularios WinForms y eventos de interfaz.
- `Controllers/`: llamadas HTTP a la API externa.
- `Models/`: clases de mapeo para deserializar respuestas JSON.

Flujo principal de uso:

1. `Program.cs` inicia la app y abre `Menu`.
2. `Menu` abre `PagesCharacters`.
3. `PagesCharacters` carga personajes, permite filtrar y paginar.
4. Al hacer click en una imagen se abre `InfoCharacter`.
5. `InfoCharacter` muestra datos base y permite consultar ubicacion y episodios.

## 🧮 Modulos funcionales

- **Menu principal:** ingreso al explorador y salida de la aplicacion.
- **Explorador de personajes:** listado visual, filtros y paginacion.
- **Detalle de personaje:** informacion general, ubicacion y episodios.

## 🪪 Requisitos

- Windows (WinForms)
- .NET SDK 8.0 o superior
- Visual Studio 2022 (recomendado) o CLI de .NET
- Conexion a internet (la API es externa)

## ⚙️ Configuracion

Este proyecto no requiere variables de entorno ni base de datos local.

La URL de la API esta definida en los controladores:

- `https://rickandmortyapi.com/api/character`
- `https://rickandmortyapi.com/api/episode`

## ⬇️ Instalacion y ejecucion

```bash
# 1. Clonar el repositorio
git clone https://github.com/TU_USUARIO/Consumo-WebAPI-RickandMorty-con-WF.git
cd Consumo-WebAPI-RickandMorty-con-WF

# 2. Restaurar dependencias
dotnet restore "Consumo WebAPI RickandMorty.sln"

# Opcion 1: ejecutar por solucion/proyecto
dotnet run --project RickandMorty/RickandMorty.csproj

# Opcion 2: compilar primero
dotnet build "Consumo WebAPI RickandMorty.sln
```

## 🌐 Endpoints consumidos

La aplicacion consume endpoints de la API oficial de Rick and Morty:

- `GET /api/character`
- `GET /api/character/?name={name}&status={status}&gender={gender}`
- `GET` por URL de paginacion (`info.next`, `info.prev`)
- `GET` por URL de episodio (desde `character.episode[]`)
- `GET` por URL de ubicacion (desde `character.location.url`)

---

<h3 align="center">Ultima actualizacion: Diciembre 2023</h3>
