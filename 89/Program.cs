/*
89. Contabilidad doméstica (examen del tema 4, grupo presencial, 2013-2014, versión simplificada)

Crea un programa en C# que pueda almacenar hasta 10000 gastos e ingresos, para crear un pequeño sistema de contabilidad doméstica. Para cada gasto (o ingreso), debe permitir guardar los siguientes datos:

    Fecha (8 caracteres: formato AAAAMMDD)
    Descripción del gasto o ingreso (por ejemplo, "Ampliación de RAM para el ordenador")
    Categoría (por ejemplo, "estudios")
    Importe (positivo si es un ingreso, negativo si es un gasto)

El programa debe permitir al usuario realizar las siguientes operaciones:

1- Añadir un nuevo gasto (o ingreso). La fecha y la descripción no deben estar vacías. No hace falta validar los demás datos.

2- Mostrar todos los gastos (o ingresos) de una cierta categoría (por ejemplo, "estudios"). Al final de todos los datos se mostrará el importe total de los datos mostrados. Se mostrarán en una misma línea todos los datos de cada gasto.

3- Buscar gastos (o ingresos) cuya descripción sea la que introduzca el usuario.

4- Modificar una ficha (pedirá el número de ficha al usuario; se mostrará el valor anterior de cada campo y se podrá pulsar Intro para no modificar alguno de los datos). Se debe avisar (pero no volver a pedir) si el usuario introduce un número de ficha incorrecto. No hace falta validar ningún dato.

5- Borrar un cierto dato, a partir del número de registro que indique el usuario. Se debe avisar (pero no volver a pedir) si introduce un número incorrecto. Se debe mostrar la ficha que se va a borrar y pedir confirmación antes de proceder al borrado.

S- Salir (como aún no sabemos almacenar la información, los datos se perderán)
*/ // Boris Garcés Vernier


