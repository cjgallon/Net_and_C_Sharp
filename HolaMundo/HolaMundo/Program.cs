using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HolaMundo
{
    internal class Program
    {
        /*  namespace 
        *      clases
        *          metodos
        *  
        *  Los namespaces contienen clases los cuales a su vez contienen métodos
        */
        static void MetodoWriteLine()
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

        }

        static void TiposVariables()
        {
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


            //Datos Booleanos, bool, los cuales solo aceptan valores true o false.

            //Variable implícita var
            //Este tipo de variable permite que el compilador sea quien deduzca el tipo de la variable

            var nombre = "Carlos";
            //Esta variable será considerada como de tipo String

            var num = 8;
            //Esta variable será considerada como de tipo int

            var decimas = 9.99;
            //Esta variable será considerada como de tipo double

            
        }

        static void OperacionesBasicas()
        {
            Console.WriteLine(20 + 1 - 6 * 10 / 2.0 % 1);
            //Estas son las operaciones básicas
            //unicamente numeros con decimales, es decir, variables tipo Float, Decimal, Double, entre otros, son utilizables como divisores.

            Console.WriteLine("Hola!, " + "es un placer conocerte");
            //Al sumar cadenas de caracteres (char, string, etc), se concatenarán.
        }

        static void MetodoReadLine()
        {
            Console.Write("¿Como te llamas?:");
            String nombreUsuario = Console.ReadLine();
            Console.WriteLine("Hola {0}!", nombreUsuario);
            //De esta forma se pueden guardar valores ingresados en la consola.
        }

        static void Metodo_Convert_To()
        {
            String numAsString;
            int multiplier = 5, convertedStringAsInt, resultado;
            Console.WriteLine("Dame un número para guardarlo:");
            numAsString = Console.ReadLine();
            convertedStringAsInt = Convert.ToInt32(numAsString);
            resultado = multiplier * convertedStringAsInt;
            Console.WriteLine("El resultado de la multiplicación entre {0} y {1} es {2}", multiplier, convertedStringAsInt, resultado);
            //Convert.ToInt32(variable) convierte una variable de tipo String en Int
        }

        static void PseudoCodigo()
        {

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

        }

        static void AreaPerimetroRectangulo()
        {

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

        }
        static void PerimetroPoligonoRegular()
        {
            //Perimetro de cualquier polígono regular
            double numLados, longitud, perimetro;
            Console.WriteLine("Dame el número de lados de la figura");
            numLados = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Dame la longitud de uno de los lados.");
            longitud = Convert.ToDouble(Console.ReadLine());
            perimetro = numLados * longitud;
            Console.WriteLine("El perimetro es: {0}", perimetro);
        }

        static void ConversionCelsiusFahrenheit()
        {
            //Conversión de grados centígrados a Fahrenheit
            double centigrados, fahrenheit;
            Console.WriteLine("Digite los grados centígrados");
            centigrados = Convert.ToDouble(Console.ReadLine());
            fahrenheit = centigrados * 9 / 5.0 + 32;
            Console.WriteLine("{0} grados centígrados equivalen a {1} grados Farenheit", centigrados, fahrenheit);

        }

        static void OperadoresIgualdad()
        {
            //OPERADORES IGUALDAD
            int a = 20, b = 20, c = 30;

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
        }

        static void OperadoresComparacion()
        {

            //Los operadores de comparación que también existen son: >(mayor que), <(menor que), >=(mayor o igual que), <=(menor o igual que
            Console.WriteLine(6 > 5);
            Console.WriteLine(5 < 6);
            Console.WriteLine(20 >= 1);
            Console.WriteLine(20 >= 20);
            Console.WriteLine(1 <= 15);
            Console.WriteLine(15 <= 15);

        }

        static void InstruccionIf()
        {
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
        }

        static void OperadoresLogicosBooleanos()
        {
            //OPERADORES LÓGICOS BOOLEANOS
            //Operador unario de negación !, altera el valor booleando a su contrario
            bool operador = true;
            Console.WriteLine(operador); //Resultado = true
            Console.WriteLine(!operador); //Resultado = false

            // Operador lógico condicional binario && (llamado también AND ó Y), arroja valor de true si y solo si ambas condiciones son verdaderas (true)
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
            }
            else
            {
                Console.WriteLine("No tienes ni la edad ni deberías poder tener licencia");
            }

            // Operador lógico condicional binario || (llamado OR ó O), arroja valor de true si una de las dos condiciones es verdadera (true)
            bool residente, invitado;
            Console.WriteLine("Necesito comprobar si puedes entrar.");
            Console.WriteLine("Fuiste invitado por alguien?: (true/false)");
            invitado = Convert.ToBoolean(Console.ReadLine());
            Console.WriteLine("y dime, vives aquí?: (true/false)");
            residente = Convert.ToBoolean(Console.ReadLine());
            if (invitado == true || residente == true)
            {
                Console.WriteLine("Perfecto, puedes entrar.");
            }
            else
            {
                Console.WriteLine("No puedes entrar.");
            }
        }

        static void OperadoresLogicosBooleanos_EjercicioPermisoDespegue()
        {
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
        }

        static void InstruccionSwitch()
        {
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
        }
        
        static void Constantes()
        {
            // Constantes
            const int valor = 10;
            //este valor no puede ser modificado al tener la etiqueta const
            //valor = 20; --> Esta línea de código marcaría error al estar intentando cambiar el valor de una constante.

        }

        static void InstruccionSwitch_EjercicioMes()
        {
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
        }

        static void InstruccionIf_EjercicioParImpar()
        {
            //Ejercicio
            //Pedir un número y escribir si es par o impar
            double num;
            Console.Write("Digite un valor para comprobar si es par o impar: ");
            num = Convert.ToDouble(Console.ReadLine());
            if (num % 2 == 0)
            {
                Console.WriteLine("El número es par");
            }
            else
            {
                Console.WriteLine("El número es impar");
            }
        }

        static void InstruccionIf_EjercicioEstacionamiento()
        {
            //Ejercicio
            //Pedir al usuario el tiempo de permanencia y cobrar: 500 dentro de los primeros 60 minutos; 750 entre una y dos horas; 1000 por encima de dos horas.
            double tiempo;
            Console.Write("Cuanto tiempo permaneció dentro del CC?: ");
            tiempo = Convert.ToDouble(Console.ReadLine());
            if (tiempo < 60)
            {
                Console.WriteLine("El cobro será de 500$");
            }
            else if (tiempo >= 60 && tiempo < 120)
            {
                Console.WriteLine("El cobro será de 750$");
            }
            else
            {
                Console.WriteLine("El cobro será de 1000$");
            }
        }

        static void OperadoresIncrementoDecremento()
        {
            //Operadores de incremento y decremento
            //los operadores escritos en prefijo, es decir ++i y --i, primero harán la operación y luego es que se mostrará el resultado.
            int opIncrementoDecremento = 10;
            Console.WriteLine(++opIncrementoDecremento);
            Console.WriteLine(--opIncrementoDecremento);
            //los operadores escritos en sufijo, es decir i++ y i--, mostrarán la variable y luego harán la operación.
        }

        static void InstruccionFor()
        {
            //Instruccion de iteración FOR
            //for (Inicialización, Condición, Iteración)
            //La inicialización de for puede tener multiples instrucciones (int i = 9, variableXY, intrucción 3 ... instrucción x; condicion; iteracion)
            //La condición debe ser una condición booleana (inicializacion; (i < 10 ó  i < variableXY ó condición x); iteracion)
            //La Iteración puede ser un operador de incremento/decremento, o también una asignación compuesta (inicialziacion, condicion, (i++ ó i-- ó i += 2 ))
            //las instrucciones anteriormente mencionadas solo existen durante la duración del for
            double calificacion, notaFinal = 0;
            for (int i = 1; i <= 7; i++)
            {
                Console.WriteLine("Digita la nota #{0}:", i);
                calificacion = Convert.ToDouble(Console.ReadLine());
                notaFinal = notaFinal + calificacion / 7.0;
            }
            Console.WriteLine("La nota final es: {0}", notaFinal);
            }

        static void AsignacionCompuesta()
        {
            int a = 10;
            int b = 2;

            //Asignación compuesta
            // +=, a lo izquierdo de la asignación se le suma lo derecho del mismo
            // -=, a lo izquierdo de la asignación se le resta lo derecho del mismo
            // *=, a lo izquierdo de la asignación se le multiplica lo derecho del mismo
            // /=, a lo izquierdo de la asignación se le divide lo derecho del mismo
            Console.WriteLine(a += b); // a = 10 + 2 = 12
            Console.WriteLine(a -= b); // a = 10 - 2 = 8 
            Console.WriteLine(a *= b); // a = 10 * 2 = 20
            Console.WriteLine(a /= b); // a = 10 / 2 = 5
        }

        static void InstruccionFor_EjercicioPromedioCalificaciones()
        {
            //promedio de calificaciones de cierta cantidad de estudiantes
            int numEstudiantes = 0;
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

        }

        static void InstruccionFor_EjercicioFactorial()
        {
            //Calcular el factorial de cualquier número
            int factorial, acumulador = 1;
            Console.Write("Digite el número al cual desea buscar su factorial: ");
            factorial = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= factorial; i++)
            {
                acumulador *= i;
            }

            Console.WriteLine("El valor factorial de {0} es: {1}", factorial, acumulador);
        }

        static void InstruccionWhile()
        {
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
                }
                else
                {
                    Console.WriteLine("Intente nuevamente.");
                }
            }
        }

        static void InstruccionDoWhile()
        {
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
        }

        static void InstruccionForAnidado()
        {
            //Iteraciones anidadas
            int indice, resultado;
            Console.WriteLine("Digite un numero para mostrar las tablas de multiplicacion hasta dicho numero");
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

        static void InstruccionFor_EjercicioPotencia()
        {
            //Ejercicio
            //Sacar la potencia de cualquier numero
            double potencia = 1, numero1;
            Console.WriteLine("Digite el numero al cual le busca la potencia");
            numero1 = Convert.ToDouble(Console.ReadLine());
            for (int i = 0; i < numero1; i++)
            {
                potencia *= numero1;
            }

            Console.WriteLine("La potencia del número {0} es {1}", numero1, potencia);
        }

        static void InstruccionForAnidado_EjercicioPrimos()
        {
            //Ejercicio 
            //Hallar los numeros primos entre el 1 y 100
            double contador = 0;
            for (int i = 2; i <= 100; i++)
            {
                contador = 0;
                for (global::System.Int32 j = 1; j <= i; j++)
                {
                    if (i % j == 0)
                    {
                        contador++;

                    }
                }
                if (contador == 2)
                {
                    Console.WriteLine("{0} es primo", i);
                }
            }
        }

        static void InstruccionForAnidado_EjercicioBasePotencia()
        {
            //Ejercicio
            //Pedir una base y una potencia. La potencia puede ser positiva o negativa
            double numeroBase, potencia2, potenciaPositiva, resultado2 = 1;
            Console.WriteLine("Digite la base");
            numeroBase = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite la potencia");
            potencia2 = Convert.ToDouble(Console.ReadLine());
            potenciaPositiva = potencia2;
            if (potencia2 < 0)
            {
                potenciaPositiva *= -1;
            }
            for (int i = 1; i < potenciaPositiva + 1; i++)
            {
                resultado2 *= numeroBase;
            }
            if (potencia2 < 0)
            {
                resultado2 = 1.0 / resultado2;
            }

            Console.WriteLine("Siendo la base {0} y la potencia {1}, el resultado es: {2}", numeroBase, potencia2, resultado2);
        }

        static void Metodos()
        {
            //MÉTODOS
            //Pueden ser considerados como bloques de códigos.
            //Los métodos poseen un grupo de instrucciones, y a su vez el método puede ser llamado para que haga su trabajo.

            //ALgunos ejemplos de métodos usados hasta ahora son:
            /*
             * WriteLine
             * ReadLine
             * Parse
             * ToInt32
             */

            //Los métodos deben ser creados por fuera de la clase main. Ya sea por encima de este o por debajo
            //A su vez, deben encontrarse dentro de la clase Program.

            //ESTRUCTURA DE UN MÉTODO - MODIFICADOR_TIPO_IDENTIFICADOR_PARÁMETRO(S)_INSTRUCCIONES
            //Modificador: De momento, todos los que se hagan llevan el modificador "static"
            //Tipo: Los métodos que no devuelven ningún tipo de información se les pone "void"
            //Identificador: Un nombre de define a la función. Preferiblemente, se le coloca un nombre que abarque la funcionalidad del método.
            //Parámetro(s):
            //
            
            //EJEMPLO
            //static void Identificador(parametro_s)
            //{
                //Instrucciones
            //}

            /*
             * Existen cuatro estilos de métodos:
             * 1. Métodos sin parámetros ni tipos.
             * 2. Métodos con parámetros.
             * 3. Métodos que devuelven un tipo.
             * 4. Métodos con parámetros y que devuelven un tipo.
             */
        }
        static void MetodoEstilos_SinTipoSinParametro_Sumar()
        {
            //Variables del método. Solo existen durante la ejecución del método, y se dice que solo existen *a nivel de método*.
            decimal num1, num2, resultado;
            Console.Write("Ingresa el primer número: ");
            num1 = Convert.ToDecimal(Console.ReadLine());

            Console.Write("Ingresa el segundo número: ");
            num2 = Convert.ToDecimal(Console.ReadLine());

            resultado = num1 + num2;

            Console.WriteLine("{0} + {1} = {2}", num1, num2, resultado);
        }

        static decimal MetodoTipos_ConTipo_Restar()
        {
            //TIPOS
            //El tipo que se devuelva debe concordar con el tipo de variable.
            //En este caso, se devolverá un decimal al ser de tipo decimal.
            decimal num1, num2, resultado;
            Console.Write("Ingresa el primer número: ");
            num1 = Convert.ToDecimal(Console.ReadLine());

            Console.Write("Ingresa el segundo número: ");
            num2 = Convert.ToDecimal(Console.ReadLine());

            resultado = num1 - num2;
            //Return
            //Es una instruccion que termina la ejecucion del método y devuelve el tipo escrito en el método.
            return resultado;
        }

        static decimal MetodoEstilos_ConTipoConParametro_Multiplicar(decimal num1Pa, decimal num2Pa) 
        {
            //Los metodos con parametros se ven de la siguiente forma:
            //static tipo NombreMetodo(tipo variable1, tipo variable 2, etc)
            
            //Variables
            decimal resultado;

            //Multiplicacion de parametros
            resultado = num1Pa * num2Pa;

            return resultado;
        }

        static decimal MetodoEstilos_DevuelveTipo_Dividir(decimal num1Pa, decimal num2Pa)
        {
            decimal resultado;
            if (num2Pa != 0)
            {
                resultado = num1Pa / num2Pa;
                
            } else
            {
                Console.WriteLine("No es posible dividir sobre 0");
                resultado = 0;
            }
            return resultado;

        }

        static decimal IngresarNumero(String peticion)
        {
            //Variables
            decimal numero;
            //Pedimos el valor 
            Console.Write(peticion);
            //Convertimos el valor a decimal
            numero = Convert.ToDecimal(Console.ReadLine());
            //Devolvemos el valor de tipo decimal
            return numero;
        }

        static void ModificarPorReferencia( ref byte numPa)
        {
            //REFERENCIA
            //Si pasamos como argumento una variable por referencia, podemos modificar su valor dentro de un método.
            //Modificamos el valor del parámetro
            numPa = 20;
        }

        static void ModificarPorOut(out byte numPa, out string saludoPa, out int numPrimoPa)
        {
            //REFERENCIA
            //Si pasamos como argumento una variable por referencia, podemos modificar su valor dentro de un método.
            //Modificamos el valor del parámetro
            numPa = 20;
            saludoPa = "hola";
            numPrimoPa = 7;

        }

        static void TiposVariable_Tupla()
        {
            //TIPO DE DATO TUPLA, se puede usar este tipo si se tienen varios valores (no variables) que se deseen relacionar con alguna variable en particular.
            //Por ejemplo, tenemos los siguientes datos:
            string nombre1 = "Luis";
            byte edad = 50;
            long numero = 55300556088;
            int dirPostal = 080001;

            //Y se quiere relacionar con la variable persona1, se puede hacer una tupla
            //(tipo) identificador = (valor);
            var persona1 = ("Luis", 50, 55300556088, 080001);

            //La forma en la que se invoca a la variable completa o sus items es la siguiente:
            Console.WriteLine(persona1); //Se imprimen todos los items de la variable
            Console.WriteLine(persona1.Item1); //Se imprime el primer item de la variable
            Console.WriteLine(persona1.Item2); //Se imprime el segundo item de la variable

            //Es posible asignar un nombre a cada item, de forma que sea mas sencilla su identificación
            var persona2 = (nombre: "Luis", edad: 50, numero: 55300556088, dirPostal: 080001);

            //y de la siguiente forma, los llamamos
            Console.WriteLine(persona2.edad);
            Console.WriteLine(persona2.numero);

            //Por último, también se podrían colocar los tipos explícitos de los items
            (string nombre, byte edad, long numero, int dirPostal) persona3 = ("Luis", 50, 55300556088, 080001);
        }

        static (decimal, decimal, decimal) DevolverMultiplesValoresConReturn()
        {
            decimal num1, num2, resultado;
            
            Console.Write("Ingresa el primer número: ");
            num1 = Convert.ToDecimal(Console.ReadLine());

            Console.Write("Ingresa el segundo número: ");
            num2 = Convert.ToDecimal(Console.ReadLine());

            resultado = num1 - num2;

            //Devolvemos multiples valores con return
            return (num1, num2, resultado);
        }

        static double ConvertirGradosRadianes(double grados)
        {
            double radianes;
            radianes = grados * Math.PI / 180;
            return radianes;
        }

        static double AreaCirculo()
        {
            double radio, area;
            Console.WriteLine("Digite el radio del círculo");
            Console.Write("Radio: ");
            radio = Convert.ToDouble(Console.ReadLine());
            if (radio <= 0)
            {
                return -1;
            }
            else
            {
                area = radio * radio * Math.PI;
                return area;
            }
        }

        static double AreaTriangulo()
        {
            double baseFigura, altura, area;
            Console.WriteLine("Digite la base del triangulo");
            Console.Write("Base: ");
            baseFigura = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite la altura del triangulo");
            Console.Write("Altura: ");
            altura = Convert.ToDouble(Console.ReadLine());
            if (baseFigura <= 0 || altura <= 0)
            {
                return -1;
            }
            else
            {
                area = baseFigura * altura / 2;
                return area;
            }
        }

        static double AreaCuadrado()
        {
            double lado, area;
            Console.WriteLine("Digite el largo del lado del cuadrado");
            Console.Write("lado: ");
            lado = Convert.ToDouble(Console.ReadLine());
            if (lado <= 0)
            {
                return -1;
            }
            else
            {
                area = lado * lado;
                return area;
            }
        }



        static void Main(string[] args)
        {
            //MetodoWriteLine();
            //TiposDeVariables();
            //OperacionesBasicas();
            //MetodoReadLine();
            //Metodo_Convert_To();
            //PseudoCodigo();
            //AreaPerimetroRectangulo();
            //PerimetroPoligonoRegular();
            //ConversionCelsiusFahrenheit();
            //OperadoresIgualdad();
            //OperadoresComparacion();
            //InstruccionIf();
            //OperadoresLogicosBooleanos();
            //OperadoresLogicosBooleanos_EjercicioPermisoDespegue();
            //InstruccionSwitch();
            //Constantes();
            //InstruccionSwitch_EjercicioMes();
            //InstruccionIf_EjercicioParImpar();
            //InstruccionIf_EjercicioEstacionamiento();
            //OperadoresIncrementoDecremento();
            //InstruccionFor();
            //AsignacionCompuesta();
            //InstruccionFor_EjercicioPromedioCalificaciones();
            //InstruccionFor_EjercicioFactorial();
            //InstruccionWhile();
            //InstruccionDoWhile();
            //InstruccionForAnidado();
            //InstruccionFor_EjercicioPotencia();
            //InstruccionForAnidado_EjercicioPrimos();
            //Metodos();
            //MetodoEstilos_SinTipoSinParametro_Sumar();

            /*
            decimal r;
            r = MetodoTipos_ConTipo_Restar();
            Console.WriteLine("El resultado de la resta es: {0}", r);
            */

            /*
            decimal r, num1Ar, num2Ar;
            Console.Write("Ingresa el primer número: ");
            num1Ar = Convert.ToDecimal(Console.ReadLine());
            Console.Write("Ingresa el segundo número: ");
            num2Ar = Convert.ToDecimal(Console.ReadLine());
            r = MetodoEstilos_ConTipoConParametro_Multiplicar(num1Ar, num2Ar);
            Console.WriteLine("El resultado de la multiplicación es: {0}", r);
            */

            /*
            decimal r, num1Ar, num2Ar;
            Console.Write("Ingresa el primer número: ");
            num1Ar = Convert.ToDecimal(Console.ReadLine());
            Console.Write("Ingresa el segundo número: ");
            num2Ar = Convert.ToDecimal(Console.ReadLine());
            r = MetodoEstilos_DevuelveTipo_Dividir(num1Ar, num2Ar);
            Console.WriteLine("El resultado de la división es: {0}", r);
            */

            /*
            decimal r, num1Ar, num2Ar;
            num1Ar = IngresarNumero("Ingresa el primer número: ");
            num2Ar = IngresarNumero("Ingresa el segundo número: ");
            r = MetodoEstilos_ConTipoConParametro_Multiplicar(num1Ar, num2Ar);
            Console.WriteLine("El resultado de la multiplicación es: {0}", r);
            */

            /*
            //REFERENCIA
            //Si pasamos como argumento una variable por referencia(ref), podemos modificar su valor dentro de un método.
            //Variable local a Main(argumento)
            byte numAr;
            //Asignamos un valor
            numAr = 10;
            //Mostramos su valor en la consola
            Console.WriteLine(numAr);
            //Invocamos al método y mandamos al argumento
            ModificarPorReferencia(numAr);
            //Después de que el método cambió el valor, volvemos a mostrar al argumento
            Console.WriteLine(numAr);
            */

            /*
            //OUT
            //Si pasamos como argumento una variable como out, podemos modificar su valor dentro de un método.
            //Variable local a Main(argumento)
            byte numAr;
            string saludoAr;
            int numPrimoAr;

            //Invocamos al método y mandamos al argumento
            ModificarPorOut(out numAr, out saludoAr, out numPrimoAr);

            //Después de que el método cambió el valor, volvemos a mostrar al argumento
            Console.WriteLine(numAr);
            Console.WriteLine(saludoAr);
            Console.WriteLine(numPrimoAr);
            */

            //TiposVariable_Tupla();

            /*
            //Devolver multiples datos con un solo return
            (decimal num1, decimal num2, decimal resultado) numeros;
            numeros = DevolverMultiplesValoresConReturn();
            Console.WriteLine("{0} - {1} = {2}", numeros.num1, numeros.num2, numeros.resultado);
            */

            /*
            //Ejercicio
            //Crear un método para transformar grados a radianes
            double grados, radianes;
            Console.Write("Digite los grados que desea transformar a raidanes: ");
            grados = Convert.ToDouble(Console.ReadLine());
            radianes = ConvertirGradosRadianes(grados);
            Console.WriteLine("{0} grados son equivalentes a {1} radiantes", grados, radianes);
            */

            /*
            //Ejercicio
            //Crear una aplicación que calcule el área de un círculo, cuadrado o triángulo.
            //Le preguntaremos al usuario a qué figura le quiere calcular el área y, según el caso, ejecutaremos alguno de los 3 métodos.
            int opc ;
            double respuesta = 0;
            string nombreFigura = "";
            do 
            {
                Console.WriteLine("Escoja alguna de las siguientes opciones para buscar su area.");
                Console.WriteLine("1. Círculo");
                Console.WriteLine("2. Triángulo");
                Console.WriteLine("3. Cuadrado");
                Console.WriteLine("Cualquier otro número: Salir");
                Console.Write("Respuesta: ");
                opc = Convert.ToInt32(Console.ReadLine());
                switch (opc)
                {
                    case 1:
                        nombreFigura = "Circulo";
                        respuesta = AreaCirculo();
                        break;

                    case 2:
                        nombreFigura = "Triangulo";
                        respuesta = AreaTriangulo();
                        break;

                    case 3:
                        nombreFigura = "Cuadrado";
                        respuesta = AreaCuadrado();
                        break;

                    default:
                        break;

                }
                if (opc > 0 && opc < 4)
                {
                    if (respuesta == -1)
                    {
                        Console.WriteLine("Digite un valor mayor a cero");

                    }
                    else
                    {
                        Console.WriteLine("El area del {0} es {1}", nombreFigura, respuesta);

                    }
                }
                
            }
            while (opc > 0 && opc < 4);
            */


            



        }
    }
} 



