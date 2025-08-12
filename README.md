🖩<h1>🖩 TP Final – C# Nivel 2 (MaxiPrograma)</h1>
<p>
Aplicación de escritorio desarrollada en C# siguiendo el enfoque de arquitectura en capas, como trabajo práctico final del curso <strong>C# Nivel 2</strong> de MaxiPrograma.  
El proyecto implementa un sistema CRUD con conexión a base de datos SQL Server, manejo de excepciones y una interfaz gráfica intuitiva basada en Windows Forms.
</p>

<hr>

<h2>Características Principales</h2>
<ul>
  <li><strong>Gestión de registros:</strong> Altas, bajas, modificaciones y consultas de datos almacenados en base de datos.</li>
  <li><strong>Interfaz gráfica con Windows Forms:</strong> Formularios interactivos, validación de datos y eventos bien estructurados.</li>
  <li><strong>Arquitectura en capas:</strong> Separación clara entre presentación, lógica de negocio, acceso a datos y entidades de dominio.</li>
  <li><strong>Conexión a base de datos SQL Server:</strong> Ejecución de consultas y transacciones de forma segura.</li>
  <li><strong>Manejo de excepciones:</strong> Captura y control de errores para garantizar estabilidad.</li>
  <li><strong>Código mantenible y escalable:</strong> Uso de principios de programación limpia y separación de responsabilidades.</li>
</ul>

<hr>

<h2>Conceptos Técnicos y Tecnologías Aplicadas</h2>
<p>
Este proyecto funciona como portfolio de la correcta aplicación de conceptos intermedios y avanzados de desarrollo con C#:
</p>

<h3>Programación Orientada a Objetos (POO)</h3>
<ul>
  <li><strong>Abstracción y encapsulamiento:</strong> Las clases de dominio representan entidades reales y ocultan la implementación interna.</li>
  <li><strong>Composición:</strong> La lógica de negocio combina objetos de diferentes capas para cumplir los requerimientos funcionales.</li>
  <li><strong>Separación de responsabilidades:</strong> Cada clase cumple un único propósito, facilitando el mantenimiento y escalabilidad.</li>
</ul>

<h3>Arquitectura en Capas</h3>
<ul>
  <li><strong>Dominio:</strong> Entidades que representan el modelo de datos.</li>
  <li><strong>Acceso a Datos:</strong> Clases que gestionan la interacción con SQL Server usando consultas parametrizadas.</li>
  <li><strong>Negocio:</strong> Contiene las reglas y procesos de la aplicación.</li>
  <li><strong>Presentación:</strong> Interfaz gráfica para la interacción con el usuario.</li>
</ul>

<h3>Conexión y Gestión de Base de Datos</h3>
<ul>
  <li>Uso de SQL Server como motor de base de datos.</li>
  <li>Consultas SQL seguras y optimizadas.</li>
  <li>Soporte para operaciones CRUD completas.</li>
</ul>

<h3>Interfaz de Usuario (Windows Forms)</h3>
<ul>
  <li>Formularios con controles personalizados.</li>
  <li>Eventos para capturar acciones del usuario.</li>
  <li>Validaciones de entrada para evitar datos erróneos.</li>
</ul>

<h3>Diseño Modular</h3>
<pre>
TPFinalCsNivel2/
├── AccesoDatos/     # Conexión y consultas SQL
├── Negocio/         # Lógica de negocio
├── Presentacion/    # Formularios y manejo de eventos
├── Dominio/         # Clases de entidades
└── TPFinalNivel2_AngottiLopez.sln  # Solución principal
</pre>
