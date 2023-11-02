using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HolaMundo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Carlos");
            Console.WriteLine("está practicando");
            Console.WriteLine("ahora mismo");
            Console.WriteLine("la escritura del");
            Console.WriteLine("método WriteLine.");
            Console.WriteLine("PostData: recuerda que debes iniciar sin depurar desde el menu de navegacion *depurar* o ejecutando Ctrl + F5");
            Console.WriteLine("**************************");
            /*  WriteLine es un método, el cual imprime texto en la consola
             *  Console es una clase
             *  WriteLine es un método que pertenece a la clase Console
             *  Console es una clase, la cual contiene un método llamado WriteLine
             */

            int numerolibros, numEstudiantes, numerosEnteros;
            // las variables de tipo int almacenan valores númericos enteros.

            double promedioFinal, pesoInicial, alturaPromedio;
            //las variables de tipo double almacenan valores numéricos que incluyan decimales.

            numerolibros = 500;

            char salon;
            salon = 'A';
            //las variables de tipo char almacenan un y solo un caracter a la vez. Además, usa comillas simples y no dobles.

            string saludo = "Hola, un gusto conocerte!.";
            //En cambio, un string puede almacenar cero o mas caracteres, y usa comillas dobles. 

            bool x = true;
            //Una variable booleana o bool acepta los valores true o false.

            //decimal promedioExamenes = 8.5;
            //la linea anterior causaria error por como se interpretan los decimales de la variable decimal
            decimal promedioExamenes = 8.5m;
            float promedioQuices = 8.5f;
            double promedioParciales = 8.5;

            double precioCamisa = 59.99;
            string colorCamisa = "Vino tinto";
            Console.WriteLine("El precio de la camisa es: {0}", precioCamisa);
            Console.WriteLine("El color de la camisa es: {0}", colorCamisa);
            Console.WriteLine("La camisa cuesta {0}$ y es de color {1}.", precioCamisa, colorCamisa);
            //Las llaves que se encuentran dentro del método sirven para invocar una variable.

            Console.WriteLine(20 + 1 - 6 * 10 / 2.0 % 1);
            //Estas son las operaciones básicas
            //unicamente numeros con decimales, es decir, variables tipo Float, Decimal, Double, entre otros, son utilizables como divisores.

            Console.WriteLine("Hola!, " + "es un placer conocerte");
            //Al sumar cadenas de caracteres (char, string, etc), se concatenarán.

            Console.Write("¿Como te llamas?:");
            String nombreUsuario = Console.ReadLine();
            Console.WriteLine("Hola {0}!", nombreUsuario);
            //De esta forma se pueden guardar valores ingresados en la consola.


            String numAsString;
            int multiplier = 5, convertedStringAsInt, resultado;
            Console.WriteLine("Dame un número para guardarlo:");
            numAsString = Console.ReadLine();
            convertedStringAsInt = Convert.ToInt32(numAsString);
            resultado = multiplier * convertedStringAsInt;
            Console.WriteLine("El resultado de la multiplicación entre {0} y {1} es {2}", multiplier, convertedStringAsInt, resultado);
            //Convert.ToInt32(variable) convierte una variable de tipo String en Int

            /*  Como escribir un Pseudocódigo
             *  Ejercicio --> Hallar el area y perimetro de un rectangulo a partir de un ancho y altura dados por el usuario.
             *  INICIO
             *  Variables:
             *      altura, ancho, area, perímetro: double
             *  Escribir ("Dame una altura: ")
             *  Leer(altura)
             *  Escribir ("Dame un ancho: ")
             *  Leer(ancho)
             *  area <- altura * ancho
             *  perimetro <- 2(altura + ancho)
             *  Escribir ("El area es: ", area )
             *  Escribir ("El perímetro es: ", perimetro )
             *  
             *  FIN
             */

            //Area y perimetro de un rectangulo
            double altura, ancho, area, perimetro;
            Console.WriteLine("Dame una altura: ");
            altura = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Dame un ancho: ");
            ancho = Convert.ToDouble(Console.ReadLine());
            area = altura * ancho;
            perimetro = 2 * (altura + ancho);

            Console.WriteLine("El area es: {0}", area);
            Console.WriteLine("El perímetro es: {0}", perimetro);

            //Perimetro de cualquier polígono regular
            double numLados, longitud;
            Console.WriteLine("Dame el número de lados de la figura");
            numLados = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Dame la longitud de uno de los lados.");
            longitud = Convert.ToDouble(Console.ReadLine());
            perimetro = numLados * longitud;
            Console.WriteLine("El perimetro es: {0}", perimetro);

            //Conversión de grados centígrados a Fahrenheit
            double centigrados, fahrenheit;
            Console.WriteLine("Digite los grados centígrados");
            centigrados = Convert.ToDouble(Console.ReadLine());
            fahrenheit = centigrados * 9 / 5.0 + 32;
            Console.WriteLine("{0} grados centígrados equivalen a {1} grados Farenheit", centigrados, fahrenheit);

            //Datos Booleanos, bool, los cuales solo aceptan valores true o false.
            int a = 20, b = 20, c=30;
            
            //Existen principalmente dos operadores de igualdad: == y !=
            //El operador == indica igualdad
            Console.WriteLine(a == b);
            //En caso de ser iguales, arrojará un dato booleano igual a True
            Console.WriteLine(a == c);
            //En caso de no ser iguales, arrojará un dato booleano igual a False

            //El operador != indica desigualdad
            Console.WriteLine(a != c);
            //En caso de ser diferentes, arrojará un dato booleano igual a True
            Console.WriteLine(a != b);
            //En caso de no ser diferentes, arrojará un dato booleano igual a False

            //Los operadores de comparación que también existen son: >(mayor que), <(menor que), >=(mayor o igual que), <=(menor o igual que
            Console.WriteLine(6 > 5);
            Console.WriteLine(5 < 6);
            Console.WriteLine(20 >= 1);
            Console.WriteLine(20 >= 20);
            Console.WriteLine(1 <= 15);
            Console.WriteLine(15 <= 15);

            //IF
            //Pedir al usuario su edad y responder si es mayor o menor de edad
            double numero;
            Console.WriteLine("Dime tu edad");
            numero = Convert.ToDouble(Console.ReadLine());
            if (numero >= 18)
            {
                Console.WriteLine("Eres mayor de edad.");
                if (numero == 18)
                {
                    Console.WriteLine("Justo cumples con la mayoría de edad.");
                }
            }
            else
            {
                Console.WriteLine("Eres menor de edad.");
            }

            //OPERADORES LÓGICOS BOOLEANOS
            //Operador de negación !, altera el valor booleando a su contrario
            bool operador = true;
            Console.WriteLine(operador); //Resultado = true
            Console.WriteLine(!operador); //Resultado = false

            // Operador lógico condicional &&, arroja valor de true si y solo si ambas condiciones son verdaderas (true)
            double edad;
            bool licencia;
            Console.WriteLine("Necesito comprobar si puedes conducir, cual es tu edad?");
            edad = Convert.ToByte(Console.ReadLine());
            Console.WriteLine("Ahora, tienes licensia de conducir? (true/false)");
            licencia = Convert.ToBoolean(Console.ReadLine());
            if ((edad >= 18) && (licencia == true))
            {
                Console.WriteLine("Bien, puedes conducir.");
            } 
            else if (edad <= 18 && licencia == false)
            {
                Console.WriteLine("Te hace falta la licencia");
            } else
            {
                Console.WriteLine("No tienes ni la edad ni deberías poder tener licencia");
            }

            // Operador lógico condicional &&(llamado AND o Y), arroja valor de true si una de las dos condiciones es verdadera (true)
            bool residente, invitado;
            Console.WriteLine("Necesito comprobar si puedes entrar.");
            Console.WriteLine("Fuiste invitado por alguien?: (true/false)");
            invitado = Convert.ToBoolean(Console.ReadLine());
            Console.WriteLine("y dime, vives aquí?: (true/false)");
            residente = Convert.ToBoolean(Console.ReadLine());
            if (invitado == true || residente == true)
            {
                Console.WriteLine("Perfecto, puedes entrar.");
            } else 
            {
                Console.WriteLine("No puedes entrar.");    
            }

            //Ejercicio para usar ambos operadores logicos booleanos
            //Tenemos un avion con dos propulsores y un tanque de gasolina
            //Si los dos propulsores funcionan y el tanque de gasolina tiene un porcentaje de 75%, puede despegar
            //Si uno de los propulsores funciona y el tanque está lleno (100%), puede despegar
            //En otros escenarios, se impide su despegue
            int tanque;
            bool propulsorDerecho, propulsorIzquierdo;
            Console.WriteLine("El propulsor derecho funciona?: (true/false)");
            propulsorDerecho = Convert.ToBoolean(Console.ReadLine());
            Console.WriteLine("El propulsor izquierdo funciona?: (true/false)");
            propulsorIzquierdo = Convert.ToBoolean(Console.ReadLine());
            Console.WriteLine("Cual es el porcentaje del tanque?");
            tanque = Convert.ToInt32(Console.ReadLine());

            if (((propulsorDerecho && propulsorIzquierdo == true) && (tanque >= 75)) || ((propulsorDerecho == true) && (tanque == 100)) || ((propulsorIzquierdo == true) && (tanque == 100)))
            {
                Console.WriteLine("Puede despegar");
            }
            else
            {
                Console.WriteLine("No puede despegar");
            }

            //INSTRUCCIONES DE SELECCION Switch
            //Realiza una comparación entre multiples casos y realiza una tarea a partir del resultado
            String color;
            Console.WriteLine("Cual de los siguientes colores escoges?");
            Console.WriteLine("Verde");
            Console.WriteLine("Azul");
            Console.WriteLine("Rojo");
            Console.Write("Respuesta: ");
            color = Console.ReadLine();
            switch (color)
            {
                case "Red":
                case "Rojo":
                    Console.WriteLine("el código RGB para el color {0} es: 255, 0, 0", color);
                    break;
                case "Green":
                case "Verde":
                    Console.WriteLine("el código RGB para el color {0} es: 0, 255, 0", color);
                    break;
                case "Blue":
                case "Azul":
                    Console.WriteLine("el código RGB para el color {0} es: 0, 0, 255", color);
                    break;
                default:
                    Console.WriteLine("La opcion seleccionada no existe.");
                    break;
            }

            // Constantes
            const int valor = 10;
            //este valor no puede ser modificado al tener la etiqueta const
            //valor = 20; --> Esta línea de código marcaría error al estar intentando cambiar el valor de una constante.

            //Ejercicio
            //Pedir un número y devolver su equivalente en mes.
            int mes;
            Console.Write("Digita un número para devolver un mes equivalente: ");
            mes = Convert.ToInt32(Console.ReadLine());
            Console.Write("El mes correspondiente al número {0} es: ", mes);
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
                    Console.WriteLine("El valor digitado no corresponde con ningun mes del años");
                    break;
            }

            //Ejercicio
            //Pedir un número y escribir si es par o impar
            double num;
            Console.Write("Digite un valor para comprobar si es par o impar: ");
            num = Convert.ToDouble(Console.ReadLine());
            if (num%2 == 0)
            {
                Console.WriteLine("El número es par");
            } else
            {
                Console.WriteLine("El número es impar");
            }

            //Ejercicio
            //Pedir al usuario el tiempo de permanencia y cobrar: 500 dentro de los primeros 60 minutos; 750 entre una y dos horas; 1000 por encima de dos horas.
            double tiempo;
            Console.Write("Cuanto tiempo permaneció dentro del CC?: ");
            tiempo = Convert.ToDouble(Console.ReadLine());
            if(tiempo < 60)
            {
                Console.WriteLine("El cobro será de 500$");
            } else if (tiempo >= 60 && tiempo < 120)
            {
                Console.WriteLine("El cobro será de 750$");
            } else 
            {
                Console.WriteLine("El cobro será de 1000$");
            }

            //Operadores de incremento y decremento
            //los operadores escritos en prefijo, es decir ++i y --i, primero harán la operación y luego es que se mostrará el resultado.
            int opIncrementoDecremento  = 10;
            Console.WriteLine(++opIncrementoDecremento);
            Console.WriteLine(--opIncrementoDecremento);
            //los operadores escritos en sufijo, es decir i++ y i--, mostrarán la variable y luego harán la operación.

            //Instruccion de iteración FOR
            //for (Inicialización, Condición, Iteración)
            //La inicialización de for puede tener multiples instrucciones (int i = 9, variableXY, intrucción 3 ... instrucción x; condicion; iteracion)
            //La condición debe ser una condición booleana (inicializacion; (i < 10 ó  i < variableXY ó condición x); iteracion)
            //La Iteración puede ser un operador de incremento/decremento, o también una asignación compuesta (inicialziacion, condicion, (i++ ó i-- ó i += 2 ))
            //las instrucciones anteriormente mencionadas solo existen durante la duración del for
            double calificacion, notaFinal = 0;
            for (int i = 1; i <= 7; i++)
                {
                Console.WriteLine("Digita la nota #{0}:", i++);
                calificacion = Convert.ToDouble(Console.ReadLine());
                notaFinal = notaFinal + calificacion / 7.0;
                }
            Console.WriteLine("La nota final es: {0}", notaFinal);
            a = 10;
            b = 2;
            //Asignación compuesta
            // +=, a lo izquierdo de la asignación se le suma lo derecho del mismo
            // -=, a lo izquierdo de la asignación se le resta lo derecho del mismo
            // *=, a lo izquierdo de la asignación se le multiplica lo derecho del mismo
            // /=, a lo izquierdo de la asignación se le divide lo derecho del mismo
            Console.WriteLine(a += b); // a = 10 + 2 = 12
            Console.WriteLine(a -= b); // a = 10 - 2 = 8 
            Console.WriteLine(a *= b); // a = 10 * 2 = 20
            Console.WriteLine(a /= b); // a = 10 / 2 = 5

            //promedio de calificaciones de cierta cantidad de estudiantes
            numEstudiantes = 0;
            double notas, notaPromedio = 0;
            Console.WriteLine("Ingrese el numero de estudiantes");
            numEstudiantes = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= numEstudiantes; i++)
            {
                Console.WriteLine("Digite la nota del estudiante#{0}: ", i);
                notas = Convert.ToDouble(Console.ReadLine());
                notaPromedio += notas / numEstudiantes;
            }
            Console.WriteLine("La nota promedio de los estudiantes es: {0}", notaPromedio);

            //Calcular el factorial de cualquier número
            int factorial, acumulador = 1;
            Console.Write("Digite el número al cual desea buscar su factorial: ");
            factorial = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= factorial; i++)
            {
                acumulador *= i;
            }

            Console.WriteLine("El valor factorial de {0} es: {1}", factorial, acumulador);

            //Instrucción de iteración WHILE
            String contraseña1 = "", contraseña2 = "";
            bool button = true; 
            Console.WriteLine("Escriba su contraseña dos veces para verificarla.");
            while (button)
            {
                Console.Write("Contraseña 1: ");
                contraseña1 = Console.ReadLine();
                Console.Write("Contraseña 2: ");
                contraseña2 = Console.ReadLine();
                if (contraseña1 == contraseña2)
                {
                    Console.WriteLine("Contraseña verificada.");
                    button = false;
                } else
                {
                    Console.WriteLine("Intente nuevamente.");
                }
            }

            //Instruccion de iteración Do-While
            byte opc;
            do
            {
                Console.WriteLine("Digite una de las siguientes opciones:");
                Console.WriteLine("1. Sumar");
                Console.WriteLine("2. Restar");
                Console.WriteLine("3. Multiplicar");
                Console.WriteLine("4. Dividir");
                Console.Write("Digite aquí: ");
                opc = Convert.ToByte(Console.ReadLine());
            }
            while (!(opc > 0 && opc < 5)); //Lo mismo que decir (opc < 1 || opc > 4)
            Console.WriteLine("La opción escogida fue: {0}", opc);

            //Iteraciones anidadas
            int indice;
            Console.WriteLine("Digite dos numeros para mostrar su tabla de multiplicacion");
            Console.Write("numero 1: ");
            indice = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= indice; i++)
            {
                Console.WriteLine("Tabla de multiplicar del {0}", i);
                for (int j = 1; j <= 10; j++)
                {
                    resultado = i * j;
                    Console.WriteLine("{0} * {1}: {2}", i, j, resultado);
                }
            }

        }
    }
} 

/*  namespace 
 *      clases
 *          metodos
 *  
 *  Los namespaces contienen clases los cuales a su vez contienen métodos
 */

