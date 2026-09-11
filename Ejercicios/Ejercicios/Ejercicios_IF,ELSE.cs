using System.Diagnostics.Tracing;
using System.Reflection;
using System.Timers;

/* 1.Escribe un programa en C# que acepte dos números enteros y compruebe si son iguales o no.
Datos de prueba:
Primer número: 5.
Segundo número: 5.
Salida esperada :
5 y 5 son iguales. */

/* int nu1 = 5, nu2 = 5;

if (nu1 == nu2)
{
    Console.WriteLine("5 y 5 son iguales.");
}
else
{
    Console.WriteLine("No son iguales");
} */

/*2. Escribe un programa en C# para comprobar si un número dado es par o impar.
Datos de prueba: 15.
Salida esperada :
15 es un número entero impar. */

/* int par = 15;

if ( par % 2 == 0 )
{
    Console.WriteLine("15 es un número entero par.");
}
else
{
    Console.WriteLine("15 es un número entero impar.");
} */

/*3. Escribe un programa en C# para comprobar si un número dado es positivo o negativo.
Datos de prueba: 14.
Salida esperada :
14 es un número positivo */

/*Console.WriteLine("Ingrese un numero entero: ");
int num1 = Convert.ToInt32(Console.ReadLine());

if (num1 >= 0)
{
    Console.WriteLine($"{num1} es positivo");
}
else if (num1 <= 0)
{
    Console.WriteLine($"{num1} es negativo");
}
else
{
    Console.WriteLine("Por favor ingresa algo valido");
} */


/*4. Escribe un programa en C# para determinar si un año dado es bisiesto o no.
Datos de prueba: 2016.
Salida esperada :
2016 es un año bisiesto. */

/*Console.WriteLine("Ingrese un año: ");
int year = Convert.ToInt32(Console.ReadLine());

if( year  % 400 == 0)
{
    Console.WriteLine($"{year} es un año bisiesto"); 
}
else if (year % 100 == 0)
{
    Console.WriteLine($"{year} no es un año bisiesto");
}
else if (year % 4 == 0)
{
    Console.WriteLine($"{year} es un año bisiesto"); 
}
else
{
    Console.WriteLine($"{year} no es año bisiesto");

} */

/*5. Escribe un programa en C# para leer la edad de un candidato y determinar si es elegible para votar.
Datos de prueba: 21.
Salida esperada :
¡Felicitaciones! Eres elegible para votar. */

/*Console.WriteLine("Por favor ingrese su edad: ");
int edad = Convert.ToInt32(Console.ReadLine());

if (edad >= 21)
{
    Console.WriteLine("¡Felicitaciones! Eres elegible para votar.");
}
else
{
    Console.WriteLine("Lo siento, no eres elegible para votar.");
} */

/* 6. Escribe un programa en C# para leer el valor de un entero m y mostrar que el valor de n es 1 
cuando m es mayor que 0,0 cuando m es 0 y -1 cuando m es menor que 0.
Datos de prueba: -5
Salida esperada :
El valor de n = -1 */

/*Console.WriteLine("Ingrese un numero entero: ");
double m = Convert.ToDouble(Console.ReadLine());

if (m > 0.0 && m > 0)
{
    Console.WriteLine("El valor de n = 1");
}
else if (m < 0)
{
    Console.WriteLine("El valor de n = -1");
} */

/* 7. Escribe un programa en C# que acepte la altura de una persona en centímetros y
la clasifique según su altura.
Datos de prueba: 135.
Salida esperada :
La persona es enana. */

/*Console.WriteLine("Ingrese su altura en centimetros: ");
int altura = Convert.ToInt32(Console.ReadLine());

if (altura < 150)
{
    Console.WriteLine($"La persona es enana.{altura}");
}
else if (altura >= 160 && altura <= 180)
{
    Console.WriteLine($"Eres una persona de estatura promedio.{altura}");   
}
else if (altura >= 200)
{
    Console.WriteLine($"Eres una persona alta.{altura}");

} */

/*8. Escribe un programa en C# para encontrar el mayor de tres números.
Datos de prueba:
Ingresa el primer número: 25
Ingresa el segundo número: 63
Ingresa el tercer número: 10
Salida esperada :
El segundo número es el mayor de los tres */

/*Console.WriteLine("Ingrese el primer numero");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Ingrese el segundo numero");
int num2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Ingrese el tercer numero");
int num3 = Convert.ToInt32(Console.ReadLine());

if (num1 > num2 && num1 > num3)
{
    Console.WriteLine($"El primer numero {num1} es mayor que los tres");
}
else if (num2 > num1 && num2 > num3)
{
    Console.WriteLine($"El segundo numero {num2} es mayor que los tres");
}
else if (num3 > num1 & num3 > num2)
{
    Console.WriteLine($"El tercer numero {num3} es mayor que los tres");
} */

/* 9.Escribe un programa en C# para aceptar un punto de coordenadas en un sistema de coordenadas 
XY y determinar en qué cuadrante se encuentra dicho punto.
Datos de prueba:
Introduce el valor de la coordenada X: 7.
Introduce el valor de la coordenada Y: 9.
Salida esperada :
El punto de coordenadas (7,9) se encuentra en el primer cuadrante.*/

/*
Console.WriteLine("Ingrese el valor de la coordenada X: ");
float x = Convert.ToSingle(Console.ReadLine());

Console.WriteLine("Ingrese el valor de la coordenada Y: ");
float y = Convert.ToSingle(Console.ReadLine());

// Primer cuadrante
if (x >= 0 && y >= 0)
{
    Console.WriteLine($"el punto de coordenadas ({x},{y}) se encuentra en el primer cuadrante.");
}
// Segundo cuadrante
else if (x < 0 && y >= 0)
{
    Console.WriteLine($"el punto de coordenadas ({x},{y}) se encuentra en el segundo cuadrante");
}
// Tercer cuadrante
else if (x < 0 && y < 0)
{
    Console.WriteLine($"el punto de coordenadas ({x},{y}) se encuentra en el tercer cuadrante");
}
// Cuarto cuadrante
else if (x > 0 && y < 0)
{
    Console.WriteLine($"el punto de coordenadas ({x},{y}) se encuentra en el cuarto cuadrante");
} */

/* 10. Escriba un programa en C# Sharp para determinar la elegibilidad para la admisión a un curso profesional
según los siguientes criterios:
Calificación en Matemáticas >= 65
Calificación en Física >= 55
Calificación en Química >= 50
Total en las tres materias >= 180
o
Total en Matemáticas y Materias >= 140

Datos de prueba:
Introduzca la calificación obtenida en Física: 65.
Introduzca la calificación obtenida en Química: 51.
Introduzca la calificación obtenida en Matemáticas: 72.
Resultado esperado :
El candidato es elegible para la admisión.*/
/*
Console.WriteLine("Ingrese la calificacion obtenida en matematicas:");
int m = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Ingrese la calificacion obtenida en fisica: ");
int f = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Ingrese la calificacion obtenida en quimica: ");
int q = Convert.ToInt32(Console.ReadLine());

int materias;
materias = f + q;

if  (m >= 65 && f >= 55 && q >= 50 && (m+ f+ q) >= 180 || (m + materias) >= 140)
{
    Console.WriteLine("El candidato es elegible para la admision");
}
else
{
    Console.WriteLine("El candidato no es elegible para la admision");
} */

/* 11. Escribe un programa en C# para calcular la raíz de una ecuación cuadrática.
Datos de prueba:
Ingresa el valor de a: 1
Ingresa el valor de b: 5
Ingresa el valor de c: 7
Salida esperada :
Las raíces son imaginarias;
No hay solución.*/
/*
Console.WriteLine("Por favor ingresa el valor de a: ");
int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Por favor ingresa el valor de b: ");
int b = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Por favor ingresa el valor de c: ");
int c = Convert.ToInt32(Console.ReadLine());

double d, x1,x2;

d = b * b - 4 * a * c;

if (d == 0)
{
    Console.WriteLine("Ambas raices son iguales");
    x1 = -b / (2 * a);
    x2 = x1;
    Console.WriteLine("Primer raiz:" + x1);
    Console.WriteLine("Segunda riaz" + x2);
}
else if (d > 0)
{
    Console.WriteLine("Ambas raices son reales y diferentes");

    x1 = (-b + Math.Sqrt(d)) / (2 * a);
    x2 = (-b - Math.Sqrt(d)) / (2 * a);

    Console.WriteLine("Primera riaz" + x1);
    Console.WriteLine("Segunda raiz" + x2);
}
else
{
    Console.WriteLine("La raiz es imaginaria y no tiene solucion");
} */

/*12. Escribe un programa en C# para leer el número de matrícula, el nombre y las calificaciones de tres asignaturas y 
calcular el total, el porcentaje y la división.
Datos de prueba:
Ingresa el número de matrícula del estudiante: 784
Ingresa el nombre del estudiante: James
Ingresa las calificaciones de Física, Química y Aplicaciones Informáticas: 70 80 90
Salida esperada :
Número de matrícula: 784
Nombre del estudiante: James
Calificación en Física: 70
Calificación en Química: 80
Calificación en Aplicaciones Informáticas: 90
Calificación total = 240
Porcentaje = 80.00
División = Primera */

/*Console.WriteLine("Ingrese el numero de matricula del estudiante: ");
string matricuala = Console.ReadLine();

Console.WriteLine("Ingrese el nombre del estudiante: ");
string nombre = Console.ReadLine();

Console.WriteLine("Ingrese las calificaciones de fisica, quimica y aplicaciones informaticas: ");

Console.WriteLine("Ingrese la calificacion de fisica: ");
int fisica = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Ingrese la calificacion de quimica: ");
int quimica = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Ingrese la calificacion de aplicaciones informaticas: ");
int aplicaciones = Convert.ToInt32(Console.ReadLine());

int total;
double porcentaje;
string div;
total = fisica + quimica + aplicaciones;
porcentaje = total / 3.0;

if (porcentaje >= 60)
{
    div = "primera";
}
else if (porcentaje < 60 && porcentaje >= 48)
{
        div = "segunda";
}
else if (porcentaje < 48 && porcentaje >= 36)
{
    div = "Pasa";
}
else
{
    div = "No pasa";
}

Console.WriteLine("Numero de matricula: " + matricuala);
Console.WriteLine("Nombre del estudiante: " + nombre);
Console.WriteLine("Calificacion en fisica: " + fisica);
Console.WriteLine("Calificacion en quimica: " + quimica);
Console.WriteLine("Calificacion en aplicaciones informaticas: " + aplicaciones);
Console.WriteLine("Calificacion total: " + total);
Console.WriteLine("Porcentaje: " + porcentaje);
Console.WriteLine("División: " + div);
*/


/* 13. Escribe un programa en C# Sharp para leer la temperatura en centígrados y mostrar un mensaje adecuado según el estado 
 de temperatura a continuación:
Temperatura < 0 luego Tiempo
helado 
Temperatura 0-10 luego Clima
muy frío 
Temperatura 10-20 luego Clima
frío 
Temperatura 20-30 luego Normal en
temperatura
Temperatura 30-40 luego Su temperatura caliente
>=40 y luego Sus datos de prueba de Muy Calor:42
Salida esperada:
Está muy caliente.*/

/*Console.WriteLine("Por favor ingrese la temperatura en centigrados: ");
int temp = Convert.ToInt32(Console.ReadLine());

if (temp < 0 )
{
    Console.WriteLine("Tiempo eleado ");
}
else if (temp >= 0 && temp < 10)
{
    Console.WriteLine("Clima muy frio");
}
else if (temp >= 10 && temp < 20)
{
    Console.WriteLine("Clima frio");
}
else if (temp >= 20 && temp < 30)
{
    Console.WriteLine("Normal en temperatura");
}
else if (temp >= 30 && temp < 40)
{
    Console.WriteLine("Caliente");
}
else
{
    Console.WriteLine("Muy Calor");
}
*/

/*14. Escribe un programa en C# para comprobar si un triángulo es equilátero, isósceles o escaleno.
Datos de prueba:
50 50 60
Salida esperada :
Este es un triángulo isósceles. */
/*
Console.WriteLine("Ingrese el primer lado del triangulo: ");
int lado1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Ingrese el segundo lado del triangulo");
int lado2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Ingrese el tercer lado del triangulo");
int lado3 = Convert.ToInt32(Console.ReadLine());

if  (lado1 == lado2 && lado2 == lado3 && lado3 == lado1)
{
    Console.WriteLine("Este es un triangulo equilatero");
}
else if (lado1 == lado2 && lado1 != lado3 && lado2 != lado3)
{
    Console.WriteLine("Este es un triangulo isosceles");
}
else
{
    Console.WriteLine("Este es un lago escaleno");
} */

/*15. Escribe un programa en C# para comprobar si se puede formar un triángulo con los ángulos dados.
Datos de prueba:
40 55 65
Salida esperada :
El triángulo no es válido. */
/*
Console.WriteLine("Ingrese el primer angulo del triangulo: ");
int a1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Ingrese el segundo angulo del triangulo: ");
int a2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Ingrese el tercer angulo del triangulo: ");
int a3 = Convert.ToInt32(Console.ReadLine());

int total = a1 + a2 + a3;

if (total == 180)
{
    Console.WriteLine("El triangulo es valido");
}
else
{
    Console.WriteLine("El triangulo no es valido");
} */

/* 16. Escribe un programa en C# para comprobar si una letra del alfabeto es una vocal o una consonante.
Datos de prueba:
k
Salida esperada :
La letra es una consonante.*/

/* Console.WriteLine("Por favor ingrese una letra del alfabeto: ");
string letra = Console.ReadLine();

if (letra == "a" || letra == "e" || letra == "i" || letra == "o" || letra == "u")
{
   Console.WriteLine("La letra es una vocal");
}
else
{
     Console.WriteLine("La letra es una consonante");
}
*/

/*17. Escribe un programa en C# para calcular las ganancias y pérdidas de una transacción.
Datos de prueba:
500 700
Salida esperada :
Puedes registrar tu ganancia: 200 */
/*
Console.WriteLine("Calcular las ganascias");

Console.WriteLine("Por fovor ingrese el precio de comprar de los insumos:");
int pre = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Por favor ingrese el precio de venta de los insumos  ");
int ven = Convert.ToInt32(Console.ReadLine());

if (pre < ven)
{
    int total = ven - pre;
    Console.WriteLine("tu ganancia es de: " + total);
}
else if (pre > ven)
{
    int total = pre - ven;
    Console.WriteLine("tu perdida es de: " + total);
}
else
{
    Console.WriteLine("No hay ganancia ni perdida");
}
*/

/*18. Escriba un programa en C# para calcular e imprimir la factura de electricidad de un cliente. Desde el teclado, 
se deben obtener el nombre del cliente, su ID y la unidad consumida, y mostrarlos junto con el monto total a pagar.
Los cargos son los siguientes:

Unidad	                          Cargo/unidad
hasta 199	                        @1.20
200 o más, pero menos de 400	    @1.50
400 o más, pero menos de 600	    @1.80
600 y más                           @2.00

Si la factura supera las 400 rupias, se aplicará un recargo del 15% y la factura mínima deberá ser de 100 rupias.
Datos de prueba:
1001
James
800
Salida esperada :
ID del cliente: 1001
Nombre del cliente: James
Unidades consumidas: 800
Importe cobrado a 2,00 rupias por unidad: 1600,00
Importe del recargo: 240,00
Importe neto pagado por el cliente: 1840,00
 */

/*Console.WriteLine("Ingrese el ID del cliente: ");
int id = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Nombre del cliente:");
string nom= Console.ReadLine();

Console.WriteLine("Ingrese las unidades consumidas: ");
double consu = Convert.ToDouble(Console.ReadLine());

double total, recargo,neto;

if ( consu <= 199)
{
    total = consu * 1.20;
    recargo = 0;
    neto = total + recargo;
    Console.WriteLine("ID del cliente: " + id);
    Console.WriteLine("Nombre del cliente: " + nom);
    Console.WriteLine("Unidades consumidas: " + consu);
    Console.WriteLine("Importe cobrado a 2,00 rupias por unidad: " + total);
    Console.WriteLine("Importe del recargo: " + recargo);
    Console.WriteLine("Importe neto pagado por el cliente: " + neto);
}
else if ( consu >= 200 && consu < 400)
{
    total = consu * 1.50;
    recargo = 0;
    neto = total + recargo;
    Console.WriteLine("ID del cliente: " + id);
    Console.WriteLine("Nombre del cliente: " + nom);
    Console.WriteLine("Unidades consumidas: " + consu);
    Console.WriteLine("Importe cobrado a 2,00 rupias por unidad: " + total);
    Console.WriteLine("Importe del recargo: " + recargo);
    Console.WriteLine("Importe neto pagado por el cliente: " + neto);
}
else if (consu >= 400 && consu < 600)
{
    total = consu * 1.80;
    recargo = total * 0.15;
    neto = total + recargo;
    Console.WriteLine("ID del cliente: " + id);
    Console.WriteLine("Nombre del cliente: " + nom);
    Console.WriteLine("Unidades consumidas: " + consu);
    Console.WriteLine("Importe cobrado a 2,00 rupias por unidad: " + total);
    Console.WriteLine("Importe del recargo: " + recargo);
    Console.WriteLine("Importe neto pagado por el cliente: " + neto);
}
else if (consu >= 600)
{
    total = consu * 2.00;
    recargo = total * 0.15;
    neto = total + recargo;
    Console.WriteLine("ID del cliente: " + id);
    Console.WriteLine("Nombre del cliente: " + nom);
    Console.WriteLine("Unidades consumidas: " + consu);
    Console.WriteLine("Importe cobrado a 2,00 rupias por unidad: " + total);
    Console.WriteLine("Importe del recargo: " + recargo);
    Console.WriteLine("Importe neto pagado por el cliente: " + neto);
}
*/


/*19. Escribe un programa en C# Sharp para aceptar una calificación y declarar la descripción equivalente:

Grado	Descripción
E	    Excelente
V	     Muy bien
G	      Bien
A	    Promedio
F	     Fallo
Datos de la prueba:
Introduce la nota :a
Salida esperada:
Has elegido: Promedio*/

/* Console.WriteLine("Por favor ingrese una calificacion: ");
string calif = Console.ReadLine();

if (calif == "E" || calif == "e")
{
    Console.WriteLine("Has elegido: Excelente");
}
else if (calif == "V" || calif == "v")
{
    Console.WriteLine("Has elegido: Muy bien");
}
else if (calif == "G" || calif == "g")
{
    Console.WriteLine("Has elegido: Bien");
}
else if (calif == "A" || calif == "a")
{
    Console.WriteLine("Has elegido: Promedio");
}
else if (calif == "F" || calif == "f")
{
    Console.WriteLine("Has elegido: Fallo");
}
else
{
    Console.WriteLine("Calificación no válida");
} */

/*20. Escribe un programa en C# sostenido para leer cualquier número de día como un entero y 
 mostrar el nombre del día como una palabra.
Datos de prueba:
4
Salida esperada:
jueves */

/* Console.WriteLine("Por favor ingrese un numero de dia: "); 
int dia = Convert.ToInt32(Console.ReadLine());

if (dia == 1)
{
    Console.WriteLine("Lunes ");
}
else if (dia == 2)
{
    Console.WriteLine("Martes");
}
else if (dia == 3)
{
    Console.WriteLine("Miercoles");
}
else if (dia == 4)
{
    Console.WriteLine("Jueves");
}
else if (dia == 5)
{
    Console.WriteLine("Viernes");
}
else if (dia == 6)
{
    Console.WriteLine("Sabado");
}
else if (dia == 7)
{
    Console.WriteLine("Domingo");
}
else
{
    Console.WriteLine("Por favor ingrese un numero valido del 1 al 7");
} */

/*21. Escribe un programa en C# Sharp para leer cualquier dígito, mostrar la palabra. Datos
de prueba :
4
Salida esperada :
Cuatro */
/*
Console.WriteLine("Por favor ingrese un numero del 0 al 9: ");
int num = Convert.ToInt32(Console.ReadLine());

switch (num)
{
    case 0:
        Console.WriteLine("Cero");
        break;
    case 1:
        Console.WriteLine("Uno");
        break;
    case 2:
        Console.WriteLine("Dos");
        break;
    case 3:
        Console.WriteLine("Tres");
        break;
    case 4:
        Console.WriteLine("Cuatro");
        break;
    case 5:
        Console.WriteLine("Cinco");
        break;
    case 6:
        Console.WriteLine("Seis");
        break;
    case 7:
        Console.WriteLine("Siete");
        break;
    case 8:
        Console.WriteLine("Ocho");
        break;
    case 9:
        Console.WriteLine("Nueve");
        break;
    default:
        Console.WriteLine("Por favor ingrese un numero valido del 0 al 9");
        break;
} */

/*22. Escribe el programa C# Sharp para leer cualquier número de mes en entero y mostrar el nombre del mes. Datos
de la prueba :
4
Resultado esperado:
abril */

/* Console.WriteLine("Por favor ingrese un numero del 1 al 12: ");
int mes = Convert.ToInt32(Console.ReadLine());

switch (mes)
{
    case 1:
        Console.WriteLine("Enero");
        break;
    case 2:
        Console.WriteLine("Febrero");
        break;
    case 3:
        Console.WriteLine("Marzo");
        break;
    case 4:
        Console.WriteLine("Abril");
        break;
    case 5:
        Console.WriteLine("Mayo");
        break;
    case 6:
        Console.WriteLine("Junio");
        break;
    case 7:
        Console.WriteLine("Julio");
        break;
    case 8:
        Console.WriteLine("Agosto");
        break;
    case 9:
        Console.WriteLine("Septiembre");
        break;
    case 10:
        Console.WriteLine("Octubre");
        break;
    case 11:
        Console.WriteLine("Noviembre");
        break;
    case 12:
        Console.WriteLine("Diciembre");
        break;
    default:
        Console.WriteLine("Por favor ingrese un numero valido del 1 al 12");
        break;
} */

/* 23. Escribe un programa en C# sharp para leer cualquier número de mes entero y mostrar el número de días de este mes. 
Datos de prueba:
7
Salida esperada:
Mes tienen 31 días */

/*Console.WriteLine("Por favor ingrese un numero del 1 al 12: ");
int mes = Convert.ToInt32(Console.ReadLine());

switch (mes)
{
    case 1:
        Console.WriteLine("Enero tiene 31 días");
        break;
    case 2:
        Console.WriteLine("Febrero tiene 28 días");
        break;
    case 3:
        Console.WriteLine("Marzo tiene 31 días");
        break;
    case 4:
        Console.WriteLine("Abril tiene 30 días");
        break;
    case 5:
        Console.WriteLine("Mayo tiene 31 días");
        break;
    case 6:
        Console.WriteLine("Junio tiene 30 días");
        break;
    case 7:
        Console.WriteLine("Julio tiene 31 días");
        break;
    case 8:
        Console.WriteLine("Agosto tiene 31 días");
        break;
    case 9:
        Console.WriteLine("Septiembre tiene 30 días");
        break;
    case 10:
        Console.WriteLine("Octubre tiene 31 días");
        break;
    case 11:
        Console.WriteLine("Noviembre tiene 30 días");
        break;
    case 12:
        Console.WriteLine("Diciembre tiene 31 días");
        break;
    default:
        Console.WriteLine("Por favor ingrese un numero valido del 1 al 12");
        break;
}*/

/*24. Escribe un programa en C# Sharp que calcule el área de figuras geométricas utilizando un enfoque basado en menús.

Datos de prueba:
Introduzca su opción: 1
Introduzca el radio del círculo: 5

Resultado esperado :
El área es: 78.500000 */
/*
Console.WriteLine("Seleccione una figura geométrica para calcular el área:");
Console.WriteLine("1. Circulo");
Console.WriteLine("2. Triangulo");
Console.WriteLine("3. Rectangulo");
int opciones = Convert.ToInt32(Console.ReadLine());

switch (opciones)
{
    case 1:
        double pi = Math.PI, a, r;

        Console.WriteLine("ingrese el radio del circulo: ");
        r = Convert.ToDouble(Console.ReadLine());

        a = pi * Math.Pow(r, 2);

        Console.WriteLine($"El are del circulo es {a} y se halla de esta forma A = π × r²");        
        break;
    case 2:
        double b, h;

        Console.WriteLine("Por favor ingresa la base del triangulo: ");
        b = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Por favor ingresa la altura del triangulo");
        h = Convert.ToDouble(Console.ReadLine());

        a = (b * h) / 2;

        Console.WriteLine($"El area del triangulo es {a} y se halla de esta forma A = (b × h) / 2");
        break;
    case 3:

        Console.WriteLine("Por favor ingresa la base");
        b = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Por favor ingresa la altura");
        h = Convert.ToDouble(Console.ReadLine());

        a = b * h;

        Console.WriteLine($"El area del rectangulo es {a} y se halla de esta forma A = b × h");
        break;
    default:
        Console.WriteLine("Por favor ingrese una opción válida");
        break;

} */

/*25. Escribe un programa en C# Sharp que sea un programa basado en menús para realizar cálculos sencillos.

Fecha de la prueba y resultado esperado
Ingrese el primer número entero: 10
Ingrese el segundo número entero: 2

Estas son las opciones:
1-Suma.
2-Resta.
3-Multiplicación.
4-División.
5-Salir.

Ingrese su elección: 3
El producto de 10 y 2 es: 20 */
/*
Console.WriteLine("Menu de calculadora");
Console.WriteLine("Ingrese el primer numero entero: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Ingrese el segundo numero entero: ");
int num2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Estas son las opciones:");
Console.WriteLine("1-Suma.\n2-Resta.\n3-Multiplicación.\n4-División.\n5-Salir.");
int opciones = Convert.ToInt32(Console.ReadLine());

int total;

if (opciones == 1)
{
    total = num1 + num2;
    Console.WriteLine($"El resultado de la suma {num1} + {num2} = {total}");
}
else if (opciones == 2)
{
    total = num1 - num2;
    Console.WriteLine($"El resultado de la resta {num1} - {num2} = {total}");
}
else if (opciones == 3)
{
    total = num1 * num2; 
    Console.WriteLine($"El resultado de la multiplicacion {num1} * {num2} = {total}");
}
else if (opciones == 4)
{
    double total2 = (double)num1 / num2;
    Console.WriteLine($"El resultado de la división {num1} / {num2} = {total2}");
}
else if (opciones == 5)
{
    Console.WriteLine("Saliendo del programa...");
}
else
{
    Console.WriteLine("Por favor ingrese una opción válida");
} */