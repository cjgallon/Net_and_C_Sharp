using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HolaMundo3_RetoTokyo_ClasesYObjetos
{
    internal class Program
    {

        static void POO()
        {
            /* POO Programación Orientada a Objetos
             * 
             * OBJETOS
             *  Son los elementos que componen a un sistema, y cada uno a su vez tiene sus propios elementos y acciones justificadas. 
             *  Los objetos se componen de dos partes principalmente:
             *  
             *  CAMPOS      y       MÉTODOS
             *  Tamaño              Encender
             *  Color               AumentarVolumen
             *  Material            CambiarCanal
             * 
             * CAMPOS 
             *  Son los datos o las características del objeto.
             *  Estos campos pueden ser una variable de cualquier tipo que se declara directamente en una clase. 
             * 
             * METODOS
             *  METODOS son las accionnes que el objeto puede realizar.
             * 
             * CLASES
             *  Estas pueden ser vistas como un molde o una plantilla.
             *  A partir de estas plantillas(CLASES) podemos crear OBJETOS.
             *  
             */
        }

        static void POOEjemploNoFuncional()
        {
            /*
             * BICICLETA
             * CLASE
             *  Todas las bicicletas tienen CAMPOS como el color, tamaño, rodada, asiento, velocidades, etc
             *  Ademas, entre sus METODOS se cuentan acelerar, frenar, cambiar la velocidad, etc
             *  
             * OBJETO
             *  La CLASE solo funciona como una plantilla, te dice que puede ser o hacer, pero no es capaz de contener nada.
             *  Por eso creamos OBJETOS a partir de la CLASE, para así empezar a asignar CAMPOS Y METODOS.
             *  
             *  Una vez creado el OBJETO BICICLETA, podemos asignar valores a los CAMPOS y crear sus propios METODOS.
             * 
             */
            
        }

        static void POOMiembrosDeLaClase()
        {
            /*
             * MIEMBROS DE LA CLASE
             * Estos son los componentes que conforman a una CLASE.
             * 
             * CAMPOS y CONSTANTES
             * PROPIEDADES, METODOS, CONSTRUCTORES, FINALIZADORES
             * Entre otros...
             * 
             * 
             */
        }

        static void POOModificadoresDeAcceso()
        {
            /* Modificadores de Acceso
             * Existen con el fin de especificar la accesibilidad que se le da a los tipos y miembros
             * 
             * PUBLIC
             *  Modificador sin restricciones
             *   
             * PRIVATE
             *  Modificador con mas restricciones 
             */
        }

        // Las clases se encuentran dentro del namespace, pero no pueden ir dentro de otras clases, por lo que no puede ir dentro de la clase Program.
        // Estructura de una clase
        // [Modificador de acceso] [class] [identificador]

        public class AutomovilPublico
        {
            //Campos
            public string color, modelo, combustible;
            public byte año, numPuertas;
            public int ccMotor;

            //Métodos

            public bool Acelerar()
            {
                bool acelerar = true;
                Console.WriteLine("Acelerar");
                return acelerar;

            }

            public bool Frenar()
            {
                bool frenar = true;
                Console.WriteLine("Frenar");
                return frenar;
            }

            public void Velocidades(ref byte velocidadPa)
            {
                velocidadPa++;
                Console.WriteLine("Se cambió la velocidad");

            }
        }

        public class AutomovilPrivado
        {
            //Campos
            private string color = "Rojo", modelo, combustible;
            private byte año, numPuertas;
            private int ccMotor;

            //Constructor
            //Campos para el ejemplo de constructor
            private string asientos, colorTablero;
            private bool camaraTrasera;

            public AutomovilPrivado()
            {
                asientos = "Piel";
                colorTablero = "Negro";
                camaraTrasera = false;
            }

            //Propiedades
            //[acceso][tipo][Nombre]
            //El TIPO de la propidad debe ser igual que el CAMPO PRIVADO al que se desee acceder.
            //De la misma forma, suele usarse el mismo nombre/identificador, iniciando en MAYÚSCULA
            
             public string Color
            {
                //Descriptor de acceso "get"
                //Devolver  el valor de uno de los campos
                //get { return color; } , otra forma de escribir el get es:
                get => color; 
            }
            
            public string Combustible
            {
                //Descriptor de acceso "set"
                get { return combustible; }

                //Descriptor de acceso "set"
                //Dar un valor a uno de los campos
                //set { combustible = value;} , otra forma de escribir el set es:
                set => combustible = value; 
                //value es una palabra clave la cual funciona como un parametro. 
            }

            //Métodos
            public bool Acelerar()
            {
                bool acelerar = true;
                Console.WriteLine("Acelerar");
                return acelerar;
            }

            public bool Frenar()
            {
                bool frenar = true;
                Console.WriteLine("Frenar");
                return frenar;
            }

            public void Velocidades(ref byte velocidadPa)
            {
                velocidadPa++;
                Console.WriteLine("Se cambió la velocidad");
            }

            public String Mensaje()
            {
                string mensaje;
                mensaje = "El auto cuenta con asientos de " + asientos + ", su tablero es de color "+ colorTablero +" y el estado su camara trasera es:" + camaraTrasera;
                return mensaje;
            }
        }

        static void POOCrearObjeto()
        {
            //Crear un OBJETO // Instanciar una CLASE
            
            //La forma en la que se instancia una clase/crea un objeto es la siguiente:
            //[Identificador de la Clase] [Identificador] = new [Constructor de la Clase] 
            
            AutomovilPublico automovil1 = new AutomovilPublico();
            
            //Y así se referencia a un objeto
            //[Identificador del objeto][.][Método]
            
            automovil1.Acelerar();
            
            //Acceso a campos de una Clase
            //Se hace por medio de la referencia del objeto, que es la que conoce todos los datos de la clase.
            
            automovil1.color = "Rojo";
            automovil1.combustible = "Diesel";
            Console.WriteLine("El tipo de combustible es: {0}", automovil1.combustible);
            
            //Acceso a metodos de una clase
            automovil1.Acelerar();
        }

        static void POOPropiedades()
        {
            //Propiedades
            //Miembro de la clase que proporciona un mecanismo flexible para leer, escribir o calcular el valor de un campo que fue calculado como privado
            //En otras palabras, nos permite el acceso a modificadores PRIVATE

            //Para estos ejemplos, se usarán los campos privados de la clase AutomovilPrivado

            AutomovilPrivado automovil1 = new AutomovilPrivado();

            //Propiedad "get", donde se ve que devuelve el valor del campo privado "color"
            Console.WriteLine("El color es: {0}", automovil1.Color);

            //Propiedad "set", dando un valor al campo privado "combustible"
            automovil1.Combustible = "Diesel";
            Console.WriteLine("El combustible es: {0}", automovil1.Combustible);

        }

        static void POOConstructor()
        {
            //Constructor
            //Es un método especializado de la clase
            //Este se ejecuta al crear un objeto, y tiene las siguientes características:
            /*
             * El constructor lleva el mismo nombre que la clase
             * Puede o no tener parámetros
             * No tiene un tipo
             * Si nosotros no creamos el constructor, C# creará uno de forma predeterminada
             * Se puede tener mas de un constructor
             * Puede ser público o privado
             */
            AutomovilPrivado automovil1 = new AutomovilPrivado();
            Console.WriteLine(automovil1.Mensaje());
        }

        class Nombres
        {
            //Metodo
            public string Concatenar(string nombrePa, string apellidoPa)
            {
                string nombreApellido;
                nombreApellido = nombrePa + " " + apellidoPa;
                return nombreApellido;
            }

            //Sobrecarga del método Concatenar
            public string Concatenar(string nombrePa, string apellidoPa, string apellido2Pa)
            {
                string nombreApellido;
                nombreApellido = nombrePa + " " + apellidoPa+ " " +apellido2Pa;
                return nombreApellido;
            }
        }

        static void POOSobrecargaMetodo()
        {
            //Sobrecarga de métodos
            //Es posible sobrecargar un método, con el fin de tener variantes del mismo, y que puedan usarse según la situación

            //Variable para recibir desde el método Concatenar
            string nombreYApellido;
            
            //Instancia
            Nombres nombres = new Nombres();

            nombreYApellido = nombres.Concatenar("Carlos", "Gallon", "Cortés");
            Console.WriteLine(nombreYApellido);
            //En este caso, el metodo sobrecargado es el método Concatenar
            //Este método puede:
            /*
             * Recibir dos parametros, nombre y apellido
             * Recibir tres parametros, nombre, primer apellido y segundo apellido
             */
        }

        static void ClaseRandom()
        {
            Random random = new Random();
            Console.WriteLine(random.Next(20, 35));
        }

        public class Empleado
        {
            //Instanciamos a Random
            Random random = new Random();

            //Campos
            private string nombre, apellido, id, locker, banco, nip;

            //Constructor
            public Empleado(String nombrePa, string apellidoPa)
            {
                nombre = nombrePa;
                apellido = apellidoPa;

                //Llamada de metodos de generacion aleatoria
                id = GenerarID();
                locker = GenerarLocker();
                banco = GenerarBanco();

            }
            
            //Propiedades
            public string Nip
            {
                set => nip = value;
            }

            public string GenerarID()
            {
                
                //Variables
                int i, numero;
                string id = "";

                for (i = 0; i < 10; i++)
                {
                    numero = random.Next(10);
                    id += numero.ToString();
                }
                 
                return id;
            }

            public string GenerarLocker()
            {
                
                //Variables
                int i, numero;
                string locker = "";

                for (i = 0; i < 2; i++)
                {
                    numero = random.Next(10);
                    locker += numero.ToString();
                }

                return locker;
            }

            public string GenerarBanco()
            {
                
                int asignarBanco;
                string banco = "";

                asignarBanco = random.Next(1,3);
                
                switch (asignarBanco)
                {
                    case 1: banco = "Santander";
                        break;
                    case 2: banco = "BBVA";
                        break;

                }

                return banco;
            }

            public override string ToString()
            {
                string mensaje = "";
                mensaje = "Empleado: " + nombre + " " + apellido + 
                    "\nNúmero de empleado: " + id + 
                    "\nLocker No. " + locker + 
                    "\nBanco Asignado: " + banco +
                    "\nNúmero de Identificación: " + nip;
                
                return mensaje;
            }

        }

        static void POOEjercicioConClases()
        {
            string nombreAr, apellidoAr, nip;
            Console.WriteLine("Ingrese los siguientes campos que se solicitan:");

            Console.Write("Nombre: ");
            nombreAr = Console.ReadLine();
            Console.Write("Apellido: ");
            apellidoAr = Console.ReadLine();
            Console.Write("Nip: ");
            nip = Console.ReadLine();

            Empleado empleado1 = new Empleado(nombreAr, apellidoAr);
            empleado1.Nip = nip;

            //Mostrar la información del objeto
            Console.WriteLine(empleado1.ToString());
        }

        public class CuentaBancaria
        {
            //Campos
            private string nombre, apellidos, direccion, rfc;
            private double saldo;

            //Constructor
            public CuentaBancaria (string nombrePa, string apellidosPa, string direccionPa, string rfcPa, double saldoPa)
            {
                nombre = nombrePa;
                apellidos = apellidosPa;
                saldo = saldoPa;
                direccion = direccionPa;
                rfc = rfcPa;
            }

            public double Deposito(double montoPa)
            {
                saldo += montoPa;
                Console.WriteLine("Deposito exitoso!");
                Console.WriteLine("Saldo actual: {0}", saldo);
                return saldo;
            }

            public double Retiro(double montoPa)
            {
                if (saldo-montoPa < 0)
                {
                    Console.WriteLine("El retiro excede al monto actual, intente un monto menor.");
                    return saldo;
                } else
                {
                    saldo -= montoPa;
                    Console.WriteLine("Retiro Exitoso!");
                    Console.WriteLine("Saldo actual: {0}", saldo);
                    return saldo;

                }

            }

            public void ConsultaSaldo() 
            {
                Console.WriteLine(saldo);
            }

            public override string ToString()
            {
                string mensaje;
                mensaje = "Nombre: " + nombre + " \nApellidos: " + apellidos + "\nDireccion: " + direccion + "\nrfc: " + rfc + "\n5saldo: " + saldo;
                return mensaje;
            }
        }

        static void POOEjercicioCompleto()
        {
            int controlador = 0;
            string nombreAr, apellidosAr, direccionAr, rfcAr;
            double saldoAr, monto;

            Console.WriteLine("Digite la siguiente información");
            Console.Write("Nombre: ");
            nombreAr = Console.ReadLine();
            Console.Write("Apellidos: ");
            apellidosAr = Console.ReadLine();
            Console.Write("Direccion: ");
            direccionAr = Console.ReadLine();
            Console.Write("Rfc: ");
            rfcAr = Console.ReadLine();
            Console.Write("Saldo: ");
            saldoAr = Convert.ToDouble(Console.ReadLine());

            CuentaBancaria cuenta = new CuentaBancaria(nombreAr, apellidosAr, direccionAr, rfcAr, saldoAr);

            do
            {
                Console.WriteLine("Elija una de las siguientes opciones:");
                Console.WriteLine("1. Deposito");
                Console.WriteLine("2. Retiro");
                Console.WriteLine("3. Consultar saldo");
                Console.WriteLine("4. Mostrar información de la cuenta");
                Console.WriteLine("5. Salir");
                Console.Write("Respuesta: ");
                controlador = Convert.ToInt32(Console.ReadLine());

                switch (controlador)
                {
                    case 1:
                        Console.WriteLine("Ingrese el monto que desee depositar");
                        monto = Convert.ToDouble(Console.ReadLine());
                        cuenta.Deposito(monto);
                        break;

                    case 2:
                        Console.WriteLine("Ingrese el monto que desee retirar");
                        monto = Convert.ToDouble(Console.ReadLine());
                        cuenta.Retiro(monto);
                        break;

                    case 3:
                        cuenta.ConsultaSaldo();
                        break;

                    case 4:
                        Console.WriteLine(cuenta.ToString());
                        break;
                }



            } while (controlador != 5);
        } 

        static void Main(string[] args)
        {

            //POO();
            //POOEjemploNoFuncional();
            //POOMiembrosDeLaClase();
            //POOModificadoresDeAcceso();
            //POOCrearObjeto();
            //POOPropiedades();
            //POOConstructor();
            //POOSobrecargaMetodo();
            //ClaseRandom();
            //POOEjercicioConClases();
            //POOEjercicioCompleto();



        }
    }
}
