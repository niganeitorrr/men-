using System;  //importa herramientas basicas para usar consola

 class Program  //define el programa principal
{
    static void Main(string [] args)

    {
        int opcion = 0; //variable donde se guarda la opcion del usuario

        //este ciclo repite el menú hasta que el usuario elija 4 (salir)
        while (opcion != 4)
        {
            Console.Clear(); //limpia la pantalla

            //Muestra el menú
            Console.WriteLine("=== MENU PRINCIPAL ===");
            Console.WriteLine("=== 1. ingresa nombre y edad ===");
            Console.WriteLine("=== 2. tabla de multiplicar del 1 al 12 ===");
            Console.WriteLine("=== 3. hola mundo ===");
            Console.WriteLine("=== 4. salir ===");

            Console.WriteLine("seleccione una opción: "); //pide una opción

            //intenta escribir lo que el usuario escribe a numero
            //si no puede (porque escribió letras), entra al if

            if (!int.TryParse(Console.ReadLine(), out opcion))
            {
                Console.WriteLine("Error: debes ingresar un número.");//mensaje de error
                Console.WriteLine("presiona una tecla para continuar...");
                Console.ReadKey(); //pausa
                continue; //regresa al menú de incio
            }
            //decide que hacer dependiendo de la opción

            switch (opcion)
            {
                case 1:
                    opcionnombreyedad();//llama a la funcion de nombre y edad
                    break;

                case 2:
                    tablademultiplicar();//llama a la funcion de tabla
                    break;

                case 3:
                    holamundo();//llama a la funcion hola mundo
                    break;

                case 4:
                    Console.WriteLine("saliendo del programa...");//mesnaje de salida
                    break;

                default:
                    //si el usuario pone un numero que no esta en el menú
                    Console.WriteLine("opcion no válida");
                    Console.WriteLine("presiona una tecla para continuar...");
                    Console.ReadKey();//pausa
                    break;

            }
        }




        // ============= OPCION 1 =====================
        static void opcionnombreyedad()
        {
            Console.Clear(); // Limpia pantalla

            Console.Write("Ingresa tu nombre: ");
            string nombre = Console.ReadLine() ?? string.Empty; // Guarda el nombre (no nulo)

            int edad; // Variable para la edad

            Console.Write("Ingresa tu edad: ");

            // Valida que sea número y que no sea negativo
            while (!int.TryParse(Console.ReadLine(), out edad) || edad < 0)
            {
                Console.Write("Edad no válida. Ingresa un número positivo: ");
            }

            // Verifica si es mayor o menor de edad
            if (edad >= 18)
            {
                Console.WriteLine(nombre + ", eres mayor de edad.");
            }
            else
            {
                Console.WriteLine(nombre + ", eres menor de edad.");
            }

            RegresarMenu(); // Regresa al menú
        }



        // ======== opcion 2 =========================
        static void tablademultiplicar()
        {
            Console.Clear(); // Limpia pantalla

            int num; // Variable del número

            Console.Write("Ingresa un número para ver su tabla: ");

            // Valida que sea número
            while (!int.TryParse(Console.ReadLine(), out num))
            {
                Console.Write("Entrada no válida. Ingresa un número: ");
            }

            Console.WriteLine("\nTabla del " + num + ":");

            // Ciclo que va del 1 al 12
            for (int i = 1; i <= 12; i++)
            {
                // Muestra la multiplicación
                Console.WriteLine(num + " x " + i + " = " + (num * i));
            }

            RegresarMenu(); // Regresa al menú
        }




        // ======== opcion 3 =========================
        static void holamundo()
        {
            Console.Clear(); // Limpia pantalla
            Console.WriteLine("Hola Mundo"); // Mensaje simple

            RegresarMenu(); // Regresa al menú
        }
        // ===== FUNCIÓN PARA REGRESAR =====
        static void RegresarMenu()
        {
            Console.WriteLine("\nPresiona cualquier tecla para regresar al menú principal...");
            Console.ReadKey(); // Espera que el usuario presione algo
        }
    }
}


