# Caso de Estudio: Árboles y Grafos en C#

## 1. Descripción del Proyecto

Este proyecto es una aplicación de escritorio desarrollada en **C# y Windows Forms** para la asignatura de Estructuras de Datos. La solución implementa las estructuras de datos de **Árbol General** y **Grafo Ponderado No Dirigido** para resolver los requerimientos de un caso de estudio propuesto por la Universidad Americana (UAM).

El software está diseñado para el parque tecnológico "Innovatec" y aborda dos funcionalidades principales:

*   **Administración de la Jerarquía Organizativa:** Utiliza un árbol para modelar y gestionar la estructura del personal.
*   **Modelado del Sistema de Rutas:** Utiliza un grafo para representar los edificios y las rutas internas del parque.

## 2. Características Implementadas

### Módulo de Jerarquía Organizativa (Árbol)

*   **Construcción del Árbol:** Permite la inserción y eliminación de nodos para representar la jerarquía.
*   **Funcionalidades de Análisis:**
    *   **Búsqueda de Nodos:** Localiza elementos específicos dentro de la estructura.
    *   **Conteo de Nodos:** Realiza un conteo total, diferenciando entre nodos padre y nodos hoja.
    *   **Recorridos de Árbol:** Implementa los algoritmos de recorrido **Pre-Orden, In-Orden y Post-Orden**, con una demostración visual que resalta cada nodo visitado.

### Módulo de Sistema de Rutas (Grafo)

*   **Representación del Grafo:** Se utiliza una **lista de adyacencia** para modelar un grafo no dirigido y ponderado, donde los vértices son edificios y las aristas son rutas con distancias asociadas.
*   **Funcionalidades de Grafo:**
    *   **Gestión de Vértices y Aristas:** Permite añadir edificios y crear conexiones entre ellos.
    *   **Cálculo de Ruta Más Corta:** Implementa el **Algoritmo de Dijkstra** para determinar el camino de menor coste entre dos edificios. El resultado se muestra tanto en texto como de forma visual en el grafo.
    *   **Análisis de Conexiones:**
        *   **Listado de Aristas:** Muestra un informe de todas las conexiones existentes.
        *   **Validación de Conexidad:** Verifica si todos los edificios del parque están interconectados.

## 3. Tecnologías

*   **Lenguaje:** C#
*   **Framework:** .NET Framework
*   **Plataforma:** Windows Forms
*   **IDE:** Microsoft Visual Studio

## 4. Estructura del Código

*   `Form1.cs`: Contiene la lógica de la interfaz de usuario y la gestión de eventos.
*   `Grafo.cs`: Clase dedicada que encapsula la implementación de la estructura de datos del grafo, incluyendo la lista de adyacencia y los algoritmos asociados.

## 5. Autor

*   **[Diego Marcello Chamendy Chow]**
*   **[dmchamendy@uamv.edu.ni]**
