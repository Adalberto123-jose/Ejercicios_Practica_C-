using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicios
{
    internal class Ejercicios_WHILE
    {
        public static void Main(string[] args)
        {
            /*1.- Realiza un programa en C#, que muestre los primeros 100 números enteros iniciando desde el 1. */
            /*int i = 1;

            while (i < 100)
            {
                Console.WriteLine(i);
                i++;
            }*/

            /*2.- Realiza un programa en C#, que muestre los primeros 100 números de forma inversa, es decir, del 100 al 1 */
            /* int i = 100;

            while (i >= 1)
            {
                Console.WriteLine(i);
                i--;
            }*/

            /*3.- Realiza un programa en C#, que muestre únicamente, los números pares en el rango del 1 al 100 */
            /* int i = 1;

             while (i <= 100)
             {
                 if (i% 2 == 0)
                 {
                     Console.WriteLine(i);
                 }
                 i++;
             } */

            /*4.- Realiza un programa en C#, que muestre la suma de los números del 1 al 100 */
            /*int i = 1;
            int suma = 0;

            while (i <= 100)
            {
                suma += i;
                i++;
            }
            Console.WriteLine(suma); */

            /*5.- Realiza un programa en C#, que muestre la suma de los números impares del 1 al 100 */
           /* int i = 1, suma = 0;

            while(i <= 100)
            {
                if (i % 2 != 0)
                {
                    suma += i;
                
                }
                i++;
            }
            Console.WriteLine(suma);*/

            /*6.- Realiza un programa en C#, que pida números mientras no se ingrese uno negativo. 
             Al final, se debe mostrar la suma de los números ingresados */
            /*int numero = 0, suma = 0;

            while (numero >= 0)
            {

                suma += numero;
                Console.WriteLine("Ingrese un número ");
                numero = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("La suma de los números ingresados es: " + suma); */

            /*7.- Realiza un programa en C#, que muestre un menú en pantalla con las opciones:

                1) Sumar
                2) Restar
                3) Multiplicar
                4) Dividir
                5) Salir

            El usuario debe seleccionar una opción. y a continuación, el programa deber solicitar el ingreso de 2 números enteros. 
            Una vez ingresados los números, se deberá evaluar con un switch, realizando la operación correspondiente a la opción seleccionada.
            La ejecución debe realizarse una y otra vez, hasta que el usuario seleccione la opción # 5. */

            /* int numero1 = 0, numero2 = 0, opcion = 0, suma = 0;
            bool correr = true;

            while(correr)
            {
               Console.WriteLine("Seleccione una opción: ");
               Console.WriteLine("1) Sumar");
                Console.WriteLine("2) Restar");
                Console.WriteLine("3) Multiplicar");
                Console.WriteLine("4) Dividir");
                Console.WriteLine("5) Salir");
                opcion = Convert.ToInt32(Console.ReadLine());

                if (opcion == 1)
                {
                   
                    Console.WriteLine("ingrese el primer número: ");
                    numero1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("ingrese el segundo número: ");
                    numero2 = Convert.ToInt32(Console.ReadLine());
                    suma = numero1 + numero2;

                    Console.WriteLine($"La suma de {numero1} y {numero2} es: {suma}");

                }
                else if (opcion == 2)
                {
                    
                    Console.WriteLine("ingrese el primer número: ");
                    numero1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("ingrese el segundo número: ");
                    numero2 = Convert.ToInt32(Console.ReadLine());
                    suma = numero1 - numero2;
                    Console.WriteLine($"La resta de {numero1} y {numero2} es: {suma}");

                }
                else if (opcion == 3)
                {
                    
                    Console.WriteLine("ingrese el primer número: ");
                    numero1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("ingrese el segundo número: ");
                    numero2 = Convert.ToInt32(Console.ReadLine());
                    suma = numero1 * numero2;
                    Console.WriteLine($"La multiplicación de {numero1} y {numero2} es: {suma}");
                }
                else if (opcion == 4)
                {
                    
                    Console.WriteLine("ingrese el primer número: ");
                    numero1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("ingrese el segundo número: ");
                    numero2 = Convert.ToInt32(Console.ReadLine());
                    suma = numero1 / numero2;
                    Console.WriteLine($"La división de {numero1} y {numero2} es: {suma}");
                }
                else if (opcion == 5)
                {
                    correr = false;
                    Console.WriteLine("Saliendo del programa...");

                }

            }*/

            /*8.- Realiza un programa en C#, que pida 2 números enteros, e imprima los números pares que existen entre los 2.
             Nota: Se debe validar que el segundo número sea mayor que el primero.  */

            /*int numero1 = 0, numero2 = 0;

            Console.WriteLine("Ingrese el primer número: ");
            numero1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo número: ");
            numero2 = Convert.ToInt32(Console.ReadLine());

            if (numero1 > numero2)
            {
              Console.WriteLine("El segundo número debe ser mayor que el primero.");
                return;
            }

            int contador = numero1;
            while(contador <= numero2)
            {
                if(contador %2 == 0)
                {
                    Console.WriteLine(contador);
                }
                contador++;
            }*/


        }
    }
}
