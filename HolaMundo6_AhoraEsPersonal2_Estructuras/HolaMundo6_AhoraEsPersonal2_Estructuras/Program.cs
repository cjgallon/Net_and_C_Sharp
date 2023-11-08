using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HolaMundo6_AhoraEsPersonal2_Estructuras
{
    internal class Program
    {
        struct AlumnoEstructura
        {
            //Campos
            string nombre;
            string apellido;
            double calificacion;
            bool alergias;
            string numeroTelefono;

            //Creamos una propiedad para Nombre
            public string Nombre { get => nombre; set => nombre = value; }
        }

        class AlumnoObjeto
        {
            //Campos
            string nombre;
            string apellido;
            double calificacion;
            bool alergias;
            string numeroTelefono;

            //Creamos una propiedad para Nombre
            public string Nombre { get => nombre; set => nombre = value; }
        }

        struct Transferencia
        {
            public DateTime fecha;
            public double monto;
            public string destinatario;
            public string numeroCuenta;
            public string concepto;

            public override string ToString()
            {
                string mensaje;

                mensaje = $"Fecha: {fecha.ToString()}, Monto: {monto}, Destinatario: {destinatario}, Numero de Cuenta: {numeroCuenta}, Concepto: {concepto}";
                return mensaje;
            }

        }

        class Jugador
        {
            string nombre;
            int vida;
            int puntaje;
            List<Item> inventario;
        }

        struct Item
        {
            string nombre;
            int tipo;
            int daño;
            int vida;
        }

        static void EstructurasYClases()
        {
            //ESTRUCTURAS
            //Son un tipo de dato que sirve para agrupar información la cual está relacionada entre si.
            //SIMILITUDES entre ESTRUCTURAS y CLASES
            /*
             * Contenedores: almacenan otros tipos dentro de ellas
             * Campos, Constantes, Propiedades, Métodos, Constructores, Eventos, Finalizadores, Operadores e Indexadores
             * Niveles de accesibilidad: Public, Private, Protected, etc
             * Interfaces
             * Anidarse
             * Instanciarse
             */

            //ClaseDeEjemplo clase = new ClaseDeEjemplo();
            //Crea la referencia al objeto = Parte encargada de crear el objeto.
            //A la hora de crearse el objeto, este se almacena en la memoria heap.
            //Mientras que la referencia queda en al memoria stack.

            //Instanciando estructura y clase
            AlumnoEstructura alumnoE1 = new AlumnoEstructura();
        AlumnoObjeto alumnoO1 = new AlumnoObjeto();

        //Asignando un valor a un campo
        alumnoE1.Nombre = "Carlos";
            alumnoO1.Nombre = "Carlos";

            //Segundo instanciado a partir del primero
            AlumnoEstructura alumnoE2 = alumnoE1;
        AlumnoObjeto alumnoO2 = alumnoO1;

        //Cambiando los nombres de las primeras instancias
        alumnoE1.Nombre = "Eric";
            alumnoO1.Nombre = "Eric";

            //imprimiendo los nombres de las instancias
            Console.WriteLine($"Estructura -- Primera instancia: {alumnoE1.Nombre}, segunda Instancia: {alumnoE2.Nombre}");
            Console.WriteLine($"    Objeto -- Primera instancia: {alumnoO1.Nombre}, segunda Instancia: {alumnoO2.Nombre}");

            //Es mejor usar estructuras cuando...
            // + Si se tiene un conjunto de datos pequeños y específicos que
            // + + se usen de forma temporal ó
            // + + que el objeto al que pertenecen sea grande

            Transferencia transferencia = new Transferencia();
        transferencia.fecha = DateTime.Now;
            transferencia.monto = 1000;
            transferencia.destinatario = "Jose Enrique";
            transferencia.numeroCuenta = "123149793023";
            transferencia.concepto = "Pago del préstamo";
            
            Console.WriteLine(transferencia.ToString());   

            //Al ser un grupo de datos muy pequeños, además de ser usados de forma temporal.
            //La mejor opción son las ESTRUCTURAS
        }

    static void Main(string[] args)
        {

            //EstructurasYClases();





        }


    }
}
