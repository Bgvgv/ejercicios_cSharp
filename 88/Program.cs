/*
88. Gestor de colección de juegos, versión 4.

Crea un array que permita almacenar hasta 1000 juegos de ordenador o consola.

De cada juego se guardará: título (cadena de texto), plataforma (cadena de texto), espacio ocupado (en MB, número entero) y fecha de lanzamiento (mes y año, en forma de struct anidado).

El programa debe permitir al usuario realizar las siguientes operaciones:

1- Añadir datos de un nuevo juego (Se debe comprobar si cabe, y avisar en caso contrario).

2- Mostrar los nombres y plataformas de todos los juegos almacenados (ambos datos en una misma línea, con el formato "The last of us (PS3)". Cada juego debe aparecer en una línea distinta, precedido por el número de registro (empezando a contar desde 1). Si hay más de 20 juegos, se deberá hacer una pausa tras mostrar cada bloque de 20 juegos, y esperar a que el usuario pulse Intro antes de seguir. Se deberá avisar si no hay datos.

3- Ver todos los datos de un cierto programa (a partir de su número de registro, contando desde 1). Se deberá avisar (pero no volver a pedir) si el número no es válido.

4- Modificar una ficha (se pedirá el número y se volverá a introducir el valor de todos los campos. Se debe avisar (pero no volver a pedir) si introduce un número de ficha incorrecto. No hará falta volver a teclear todos los datos, sino que se debe permitir que el usuario pulse Intro sin introducir nada cuando desee conservar el valor previo de un campo, y sólo sea necesario que vuelva a teclear los campos que desee modificar.

5- Borrar un cierto dato, a partir del número de registro que indique el usuario. Se debe avisar (pero no volver a pedir) si introduce un número incorrecto.

T- Terminar (como no sabemos almacenar la información, los datos se perderán).
*/ //Boris Garcés Vernier
