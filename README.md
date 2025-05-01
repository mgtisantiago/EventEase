# EventEase

✅ 1. Visualización de Eventos
- Creación de una página EventList.razor para listar eventos dinámicamente desde un archivo JSON (data/events.json).
- Uso del componente <EventCard /> para mostrar los detalles de cada evento como nombre, ubicación, descripción y fecha.

✅ 2. Componente Reutilizable: EventCard
- Estructura del componente EventCard.razor para representar visualmente cada evento con Bootstrap.
- Parametrización del componente con la clase Event (@parameter public required Event Event { get; set; }).

✅ 3. Modelo de Datos
- Definición de la clase Event en EventEase.Shared.Models con las propiedades: Id, Name, Date, Location, Description.

✅ 4. Filtros Dinámicos
Implementación de filtros en la lista de eventos:

a) Filtro por Nombre
Input text para buscar eventos por coincidencia de nombre.

b) Filtro por Ubicación
- Primero implementado como select múltiple con JSInterop para leer los valores seleccionados.
- Luego modificado a select único más simple y sin JavaScript adicional.

c) Filtro por Fecha
Uso de <InputDate /> para seleccionar una fecha exacta.

d) Botón de Búsqueda
Ejecuta la función ApplyFilters() para aplicar todos los criterios de filtrado juntos.

✅ 5. Mejora de Código
Limpieza de errores y warnings:
- Corrección de bindings incorrectos (List<string> → string para el select).
- Uso correcto de @using para evitar el warning "Found markup element with unexpected name 'EventCard'".
- Eliminación del uso innecesario de JSRuntime tras cambiar el select a simple.

🧩 En resumen:
- Carga eventos dinámicamente.
- Permite filtrarlos por nombre, ubicación y fecha.
- Usa componentes reutilizables.
- Presenta una interfaz amigable y clara.
