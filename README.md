# PyT - Liquidador deducciones especiales incrementadas.

Liquidador para las deducciones especiales incrementadas correspondiente al impuesto a las ganancias.

## Descripción general.

El programa permite realizar el proceso integro para el cálculo de las deducciones especiales incrementadas, para el impuesto a las ganancias.

Para esto, se deberá de realizar la importación de diferentes datos para poder realizar el proceso.

## Importación de empleados.
La primera importación a realizar es la información correspondiente a los empleados. Para esto, se deberá de utilizar un archivo Excel –formato xlsx- que contenga la siguiente información:

+ Legajo
+ Cuil
+ Nombre y apellido
+ Fecha ingreso

Una vez importados los empleados, los siguientes procesos pueden realizarse sin un orden específico. Pero, vale aclarar que, el programa realiza validaciones a partir del CUIL de los empleados y/o el número de legajo. Por tanto, todos los datos que sean cargados sin haber cargado los empleados primero, serán rechazados.

## Importación de sueldo bruto mensual.

En este proceso, se importara el total de los haberes percibidos por el empleado en el mes. Cabe destacar, que dicho proceso, se realizara mediante un archivo Excel en formato “.xlsx”.

Los datos a importar son:

+ Legajo
+ Nombre y apellido
+ Año
+ Mes
+ Importe

Se permite un único registro por mes/año por empleado.

## Importación de deducción mensual.

Al igual que en el proceso anterior, se importara la sumatoria de descuentos ley correspondientes al cálculo de la primer deducción especial incrementada. Para realizarlo, se deberá de utilizar un archivo Excel –formato xlsx- que contenga los siguientes datos:

+ Legajo
+ Nombre y apellido
+ Año
+ Mes
+ Importe

Se permite un único registro por mes/año por empleado.

## Importación de Cargas de familia.

Mediante este proceso, se podrán importar las cargas de familia que van a utilizarse en caso de tener que calcular la primer deduccion especial incrementada. 

La importación se podrá realizar mediante dos opciones: 

### Importación desde Excel.

Como en el resto de los procedimientos, podremos importar la información mediante un archivo Excel en formato xlsx que contenga la siguiente información:

+ Legajo
+ CUIL empleado
+ Año
+ Tipo de documento
+ Numero de documento
+ Apellido
+ Nombre
+ Fecha de nacimiento
+ Mes desde
+ Mes hasta
+ Parentesco
+ Porcentaje deducción

### Importación desde XML

La información podrá importarse, también, desde los formularios 572 presentados por los empleados. 

Los mismos, deben estar contenidos dentro de una carpeta, la cual será especificada por el usuario en el momento de ejecutar el proceso.

### Importación de otros empleadores.
Mediante este proceso, se podrá cargar la información correspondiente a otros empleadores. Estos datos, serán tenidos en cuenta dos procesos, el cálculo del promedio bruto mensual y para el cálculo de la primer deducción especial incrementada.

La importación se podrá realizar mediante dos procesos:

### Importación mediante archivo Excel.

La primer opción es importar la información mediante un archivo Excel en formato xlxs. El archivo deberá de tener la siguiente información:

+ Legajo
+ Año
+ CUIL
+ CUIT
+ Denominación
+ Mes
+ Obra social
+ Seguridad social
+ Sindicato
+ Ganancia bruta
+ Retribuciones no habituales
+ Ajuste
+ Remuneración exenta
+ SAC
+ Hs. extras gravadas
+ Hs. extras exentas
+ Material didáctico
+ Movilidad y viáticos

### Importación desde XML.
La información podrá importarse, también, desde los formularios 572 presentados por los empleados.

Los mismos, deben estar contenidos dentro de una carpeta, la cual será especificada por el usuario en el momento de ejecutar el proceso.

## Importación de divisores.

Para el cálculo del promedio bruto mensual, se utiliza la fecha de ingreso del empleado. Sin embargo, entendemos que hay situaciones donde puede querer llegar a utilizar un divisor distinto. 

Para eso, permitimos la importación de divisores que sobrescriben el calculado por sistema.

Los divisores deben de ser importados mediante un archivo Excel –formato xlsx- con la siguiente información:
+ Legajo
+ Año
+ Mes
+ Divisor

## Proceso de cálculo.

El proceso de cálculo de las deducciones especiales incrementadas se divide en tres fases. Primero, se calculan los promedios brutos mensuales. Y, en base a los mismos, se determina el cálculo de la primero o segunda deducción.

Se puede seleccionar el año a liquidar, junto con un grupo de meses y empleados.

Los resultados, además de visualizarse en la aplicación, pueden ser exportados.

## Demo

El proceso completo de liquidación se puede observar en la siguiente serie de videos:

https://www.youtube.com/watch?v=EcQyQb8X478&list=PLbSUhAT1xP78N0FxEnUQRcW4HA4ix81_d

## Detalle técnico.
El programa fue realizado en .net, utilizando el lenguaje C# y Windows Forms. 

Para el diseño, se utilizó el patrón MVC. Para esto, se generaron tres capas, en distintos proyectos. Para mantener un orden lógico y, a su vez, que el mantenimiento del programa sea más sencillo.

La base de datos fue generada en SQL Server. En el cual se crearon las tablas necesarias como el armado de distintos procedimientos almacenados.
