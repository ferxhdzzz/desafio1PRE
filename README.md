                                 Calculadora de Descuentos en una Tienda con Ambiente Gráfico

Esta aplicación fue desarrollada en Windows Forms con C# y permite calcular el precio final de un producto después de aplicar un descuento,
dependiendo de la categoría seleccionada y el monto total de la compra.
El sistema valida los datos ingresados por el usuario antes de realizar cualquier cálculo, garantizando que solo se procesen valores correctos.

 **Objetivo**

Calcular el precio final de una compra aplicando descuentos según:

-Categoría del producto

-Monto total de la compra

**Cómo Ejecutar el Programa**

1. Abrir Visual Studio.

2. Seleccionar Abrir Proyecto.

3, Buscar la carpeta del proyecto.

4. Abrir el archivo .sln.

5. Presionar el botón Iniciar (▶) o la tecla F5.

El programa se ejecutará mostrando la interfaz gráfica del sistema.

***Características Implementadas***

- Interfaz gráfica en Windows Forms

- Uso de TextBox para ingreso de datos

- ComboBox para selección de categoría

- Botón para ejecutar el cálculo

- Labels para mostrar resultados

- Validaciones de datos

- Uso de estructuras if-else

- Uso de estructura switch-case

- Cálculo dinámico del descuento

- Formato de salida con dos decimales

**Descuentos por Categoría**

Electrónica → 10% si el monto es mayor a $500

Ropa → 15% si el monto es mayor a $300

Alimentos → 5% si el monto es mayor a $200

Hogar → 20% si el monto es mayor a $400

Si no se cumple la condición, no se aplica descuento.

***Validaciones Implementadas***

El programa valida que:

El precio del producto sea un número positivo.

El monto total sea un número positivo.

Se haya seleccionado una categoría.

Si algún dato es incorrecto, se muestra un mensaje de error.

**Lógica del Programa**

El programa recibe el precio, el monto total y la categoría seleccionada. Primero valida que los datos sean numéricos, positivos y que exista una categoría elegida.
Luego, mediante un switch, identifica la categoría y con un if verifica si el monto cumple la condición para aplicar descuento. Si aplica, calcula el descuento y obtiene el precio final; de lo contrario, mantiene el monto original. 
Finalmente, muestra el resultado en la interfaz junto con el mensaje correspondiente.

**Tecnologías Utilizadas**

Lenguaje: C#

Plataforma: .NET Framework

Entorno de desarrollo: Visual Studio

Interfaz gráfica: Windows Forms


