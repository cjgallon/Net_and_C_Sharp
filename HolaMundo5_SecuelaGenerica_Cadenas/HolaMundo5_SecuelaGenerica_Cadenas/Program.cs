using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HolaMundo5_SecuelaGenerica_Cadenas
{
    internal class Program
    {

        static void CambiosSobreCadenas()
        {
            //Join y Concat
            string[] palabrasJoin = { "Hola", "a", "todos." };
            string textoJoin = string.Join("_", palabrasJoin);
            Console.WriteLine(textoJoin);

            string palabrasConcat = "Hola ", palabra2 = "a ", palabra3 = "todos.";
            Console.WriteLine(string.Concat(palabrasConcat, palabra2, palabra3));

            //Split
            string parrafoSplit = "Hola a todos, mi nombre es Carlos. Es un placer conocerlos";

            string[] palabrasSplit = parrafoSplit.Split(',', '.');

            foreach (string elemento in palabrasSplit)
            {
                Console.WriteLine("Texto sustraido: _{0}_", elemento);
            }

            //Contains
            string parrafoContains = "Hola, mi nombre es Carlos.";
            Console.WriteLine("Buscar: ");
            string buscarTextoContains = Console.ReadLine();
            if (parrafoContains.Contains(buscarTextoContains))
            {
                Console.WriteLine("Texto encontrado");
            }
            else
            {
                Console.WriteLine("Texto no encontrado");
            }

            //StartsWith - EndsWith
            string parrafoWith = "Hola, mi nombre es Carlos.";
            Console.WriteLine("Buscar: ");
            string buscarTextoWith = Console.ReadLine();
            if (parrafoWith.StartsWith(buscarTextoWith) || parrafoWith.EndsWith(buscarTextoWith))
            {
                Console.WriteLine("Texto sí empieza o finaliza con lo ingresado");
            }
            else
            {
                Console.WriteLine("Texto no empieza o finaliza con lo ingresado");
            }

            //IndexOf - LastIndexOf
            string palabraIndex = "Pantalla.";

            char caracterIndex = 'a';

            int primerAparicionIndex = palabraIndex.IndexOf(caracterIndex);
            int ultimaAparicionIndex = palabraIndex.LastIndexOf(caracterIndex);

            Console.WriteLine("Primera aparicion de caracter {0} en cadena {1}: {2}", caracterIndex, palabraIndex, primerAparicionIndex);
            Console.WriteLine("Ultima aparicion de caracter {0} en cadena {1}: {2}", caracterIndex, palabraIndex, ultimaAparicionIndex);

            //Replace
            string parrafoReplace = "Hola, mi nombre es Carlos.";
            string textoReemplazoReplace = parrafoReplace.Replace("Carlos", "Dorian");
            Console.WriteLine(textoReemplazoReplace);

            //Trim
            string parrafoTrim = "-----------Hola, mi nombre es Carlos.--------------";
            Console.WriteLine(parrafoTrim);
            string textoReemplazoTrim = parrafoTrim.Trim('-');
            Console.WriteLine(textoReemplazoTrim);

            //Remove
            string parrafoRemove = "Hola, mi nombre es Carlos. asdasdasd";
            Console.WriteLine(parrafoRemove);
            string textoReemplazoRemove = parrafoRemove.Remove(27);
            Console.WriteLine(textoReemplazoRemove);

        }

        static void CadenasStringBuilder()
        {
            //StringBuilder
            //Se usa en vez de un string cuando:
            // - Se espera realizar un numero desconocido a una cambiosa cadena
            // - Se espera que el codigo realice un numero grande cambios a una cadena
            //
            //String se usaría mas en estos casos:
            // - El numero de cmabios es pequeño
            // - El numero de concatenaciones es fijo
            // - Se realizan operaciones de busquedas extensas

            StringBuilder numeros = new StringBuilder();
            for (int i = 1; i <= 100; i++)
            {
                numeros.Append(i);
                numeros.Append(", ");
            }
            string cadenaNumeros = numeros.ToString();
            Console.WriteLine(cadenaNumeros);

            //Realizar esta operación usando strings desde un principio consumiría demasiados recursos.
            //Cada ocasión en la que se agrega un número a la cadena, funciona como si se creara nuevamente esa cadena

            //Usando StringBuilder, estas acciones no implican que haya una nueva creacion, sino modificaciones de bajo consumo.

        }

        static void MasCosasDeCadenas()
        {
            //Equals 
            string palabra1 = "Hola";
            string palabra2 = "HOLA";
            string palabra3 = "Hola";
            Console.WriteLine(Equals(palabra1, palabra2));
            Console.WriteLine(Equals(palabra1, palabra3));
            Console.WriteLine(palabra1.Equals(palabra3));

            //StringComparison
            Console.WriteLine(palabra1.Equals(palabra2, StringComparison.OrdinalIgnoreCase));
            //Ignora en la comparasion si son mayusculas o minusculas

            //ToUpper, convierte el string en mayusculas
            Console.WriteLine(palabra1.ToUpper());

            //ToLower, convierte el string en minusculas
            Console.WriteLine(palabra1.ToLower());

            //PadLeft PadRight
            Console.WriteLine(palabra1.PadLeft(10, '-'));
            Console.WriteLine(palabra1.PadRight(10, '#'));

            //Secuencias de Escape
            //\n Similar a presionar Enter, pasa a la siguiente linea
            //\a Manda un sonido de alerta a la hora de ejecutarse la linea
            Console.WriteLine("Hola\nSoy\nCarlos\a");
            //\r Sobreescribe el inicio de la cadena con lo siguiente a la secuencia
            //\b Elimina el caracter inmediatamente anterior a esta secuencia 
            Console.WriteLine("123456789");
            Console.WriteLine("123456\r789");
            Console.WriteLine("1\b23\b45\b67\b89\b ");
            //\" Agrega una comilla doble
            Console.WriteLine("\"Erase una vez...\"");
            //\' Agrega una comilla simple
            Console.WriteLine("\'Erase una vez...\'");
            //\\ Agrega una barra diagonal inversa
            Console.WriteLine("C:\\Windows\\Fonts");

        }

        static void AunMasCosasSobreCadenas()
        {
            //Cadenas de formato

            //Format, formato compuesto 
            int numero1 = 5, numero2 = 20;
            string cadena1;
            cadena1 = string.Format("el valor es: {0}", numero1);
            Console.WriteLine(cadena1);

            //Interpolacion de cadenas
            //$
            Console.WriteLine($"El primer valor es: {numero1}, el segundo valor es: {numero2}.");
            Console.WriteLine("El primer valor es: {0}, el segundo valor es: {1}.", numero1, numero2);

            //Identificador Textual
            //@
            string directorio = @"C:\Windows\Fonts";
            Console.WriteLine("C:\\Windows\\Fonts");
            Console.WriteLine(@"El libro comienza con: ""Erase una vez..."". ");
            Console.WriteLine(@"1. A 
                                2. B
                                3. C");

            //DateTime
            DateTime fecha = new DateTime(2023, 11, 8, 23, 12, 5);
            Console.WriteLine(fecha);
            //Interaccion del objeto DateTime con el método ToString
            //Formatos de fechas estándares
            Console.WriteLine(fecha.ToString("d"));
            Console.WriteLine(fecha.ToString("D"));
            Console.WriteLine(fecha.ToString("f"));
            Console.WriteLine(fecha.ToString("F"));
            Console.WriteLine(fecha.ToString("d\n"));
            Console.WriteLine(fecha.ToString("d M y h m s"));
            Console.WriteLine(fecha.ToString("dd MM yy hh mm ss"));
            Console.WriteLine(fecha.ToString("ddd MMM yyy hhh mmm sss"));
            Console.WriteLine(fecha.ToString("dddd MMMM yyyy hhhh mmmm ssss"));
            Console.WriteLine(fecha.ToString("dddd dd \"de\" MMMM\",\" yyyy hh:mm:ss tt\n"));

            //Convertir cadena en fecha
            string cadenaFechaHora;
            DateTime dateTimeFechaHora;

            Console.WriteLine("Escriba una fecha");
            cadenaFechaHora = Console.ReadLine();

            dateTimeFechaHora = DateTime.Parse(cadenaFechaHora);

            Console.WriteLine(dateTimeFechaHora);
        }



        class contraseña
        {
            string numeros = "0123456789",
                letrasMin = "qwertyuiopasdfghjklñzxcvbnm",
                letrasMay = "QWERTYUIOPASDFGHJKLÑZXCVBNM",
                caracterEspecial = "$%#&!?";

            int numContiene = 0,
                minContiene = 0,
                mayContiene = 0,
                espContiene = 0;

            public string GenerarContraseña()
            {
                //Variable que almacenará la contraseña
                string contraseñaGenerada = "";

                //Instanciamos la clase Random
                Random random = new Random();

                //Declaramos una variable que almacenará el tamaño de la contraseña. Contendrá un valor entre 8 y 20.
                int longitudContraseña = random.Next(8, 21);

                //Variables que determinan el numero de caracteres que se usaran por cada grupo.
                double numTener = longitudContraseña * .15;
                double minTener = longitudContraseña * .35;
                double mayTener = longitudContraseña * .35;
                double espTener = longitudContraseña * .15;

                //Almacena cada uno de los caracteres que conformarán la contraseña
                char caracterEscogido;

                //Ciclo para ir colocando los caracteres de cada grupo hasta completar la longitud deseada

                while (contraseñaGenerada.Length < longitudContraseña)
                {

                    //Casos para cada grupo de caracteres. Se usa un número random para ir metiendo las contraseñas
                    switch (random.Next(0, 4))
                    {
                        //A "caracterEscogido" se le asignará un caracter aleatorio dentro de los 4 grupos.
                        //Si los caracteres de un grupo son menores al limite que puede albergar la contraseña, entonces se ingresa dentro del if

                        case 0:
                            if (numContiene < numTener)
                            {
                                //Se le asigna a "caracterEscogido" al azar un caracter del grupo
                                caracterEscogido = numeros[random.Next(numeros.Length)];
                                //Se acumula en "contraseñaGenerada" el caracter que contiene "caracterEscogido"
                                contraseñaGenerada += caracterEscogido;
                                //Al conteo de caracteres individual del grupo escogido se le suma 1
                                numContiene++;
                            
                            }
                            break;

                        case 1:
                            caracterEscogido = letrasMin[random.Next(letrasMin.Length)];
                            contraseñaGenerada += caracterEscogido;
                            minContiene++;
                            break;

                        case 2:
                            caracterEscogido = letrasMay[random.Next(letrasMay.Length)];
                            contraseñaGenerada += caracterEscogido;
                            mayContiene++;

                            break;

                        case 3:
                            caracterEscogido = caracterEspecial[random.Next(caracterEspecial.Length)];
                            contraseñaGenerada += caracterEscogido;
                            espContiene++;

                            break;
                    }
                }

                return contraseñaGenerada;

            }
        }

        static void Main(string[] args)
        {

            //CambiosSobreCadenas();
            //CadenasStringBuilder();
            //MasCosasDeCadenas();
            //AunMasCosasSobreCadenas();

            /*
             * GENERADOR DE CONTRASEÑAS
             * De entre 08-20 caracteres
             * Contiene al menos:
             * - Una letra minúscula
             * - Una letra mayúscula
             * - Un número
             * - Un caracter especial de entre seis posibles opciones
             */

            

            //GenerarContraseña();


        }
    }
}

