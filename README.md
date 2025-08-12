🖩 TP Final – C# Nivel 2 (MaxiPrograma)
Aplicación de escritorio desarrollada en C# siguiendo el enfoque de arquitectura en capas, como trabajo práctico final del curso C# Nivel 2 de MaxiPrograma.
El proyecto implementa un sistema CRUD con conexión a base de datos SQL Server, manejo de excepciones y una interfaz gráfica intuitiva basada en Windows Forms.

<h2>Características Principales</h2>
  🖩Gestión de registros: Altas, bajas, modificaciones y consultas de datos almacenados en base de datos.

  🖩Interfaz gráfica con Windows Forms: Formularios interactivos, validación de datos y eventos bien estructurados.

  🖩Arquitectura en capas: Separación clara entre presentación, lógica de negocio, acceso a datos y entidades de dominio.

  🖩Conexión a base de datos SQL Server: Ejecución de consultas y transacciones de forma segura.

  🖩Manejo de excepciones: Captura y control de errores para garantizar estabilidad.

  🖩Código mantenible y escalable: Uso de principios de programación limpia y separación de responsabilidades.

Conceptos Técnicos y Tecnologías Aplicadas
Este proyecto funciona como portfolio de la correcta aplicación de conceptos intermedios y avanzados de desarrollo con C#:

Programación Orientada a Objetos (POO)
  🖩Abstracción y encapsulamiento: Las clases de dominio representan entidades reales y ocultan la implementación interna.

  🖩Composición: La lógica de negocio combina objetos de diferentes capas para cumplir los requerimientos funcionales.

  🖩Separación de responsabilidades: Cada clase cumple un único propósito, facilitando el mantenimiento y escalabilidad.

Arquitectura en Capas
  🖩Dominio: Entidades que representan el modelo de datos.

  🖩Acceso a Datos: Clases que gestionan la interacción con SQL Server usando consultas parametrizadas.

  🖩Negocio: Contiene las reglas y procesos de la aplicación.

  🖩Presentación: Interfaz gráfica para la interacción con el usuario.

Conexión y Gestión de Base de Datos
  🖩Uso de SQL Server como motor de base de datos.

  🖩Consultas SQL seguras y optimizadas.

  🖩Soporte para operaciones CRUD completas.

Interfaz de Usuario (Windows Forms)
  🖩Formularios con controles personalizados.

  🖩Eventos para capturar acciones del usuario.

  🖩Validaciones de entrada para evitar datos erróneos.

Diseño Modular
El proyecto está estructurado en directorios que separan las capas:

TPFinalCsNivel2/
├── AccesoDatos/     # Conexión y consultas SQL
├── Negocio/         # Lógica de negocio
├── Presentacion/    # Formularios y manejo de eventos
├── dominio/         # Clases de entidades
└── TPFinalNivel2_AngottiLopez.sln  # Solución principal
