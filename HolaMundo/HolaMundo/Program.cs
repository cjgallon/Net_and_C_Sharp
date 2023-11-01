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
            double promedioParciales= 8.5;

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

        }
    }
} 

/*  namespace 
 *      clases
 *          metodos
 *  
 *  Los namespaces contienen clases los cuales a su vez contienen métodos
 */

