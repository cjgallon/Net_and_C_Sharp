using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HolaMundo2_AhoraEsPersonal
{
    internal class Program
    {
        static void MatrizUni()
        {
            //MATRICES
            //Son variables capaces de almacenar, a su vez, mas variables

            //Matrices UNIDIMENSIONALES
            //Como dice su nombre, es de una unica dimensión.
            //La forma en la que se estructuran es la siguiente:
            //tipo[] nombre = new tipo[tamaño];
            //Declaracion = creación o instanciación

            double[] calificaciones = new double[4]; //Declaración de una matriz de tipo "Double" 
            //En otras palabras:
            //Se creará un objeto de la clase Array, de tipo double, llamada calificaciones, de tamaño 4.

            string[] nombres = new string[5];
            int[] numeros = new int[10];
            byte[] datos = new byte[7];

            //Así se crea una matriz con un tamaño especificado en consola
            byte tamaño;
            Console.WriteLine("Cual es el tamaño de la matriz?");
            Console.Write("Tamaño: ");
            tamaño = Convert.ToByte(Console.ReadLine());

            int[] estudiantes = new int[tamaño];

            //La forma en la que alteras el valor de un elemento de una matriz es la siguiente
            calificaciones[0] = 6.5; //El elemento alterado es el 1er elemento de la matriz.
            calificaciones[2] = 1.11; //El elemento alterado es el 3er elemento de la matriz.


        }

        static void MatrizUniAccederPorIteracion()
        {
            //Acceso a la matriz llena

            //tipo[] nombre = new tipo[Tamaño]
            string[] nombres = new string[3];

            //Se colocan los valores en los 3 elementos
            nombres[0] = "Alex";
            nombres[1] = "Carlos";
            nombres[2] = "Maria";

            byte i; //Variable de control del ciclo

            for (i = 0; i < 2; i++)
            {
                Console.WriteLine(nombres[i]);   
            }
            
        }

        static void MatrizUniAlterarPorIteracion()
        {
            byte i; //Variable de control del ciclo

            //tipo[] nombre = new tipo[Tamaño]
            string[] nombres = new string[3];
            
            //Agregar a cada elemento un nombre
            for (i = 0; i <= 2; i++)
            {
                Console.Write("Digite los nombres para el índice {0}: ", i);
                nombres[i] = Console.ReadLine();
            }

            //Imprimir cada elemento de la matriz
            for (i = 0; i <= 2; i++)
            {
                Console.WriteLine(nombres[i]);
            }
        }

        static void MatrizUni_EjercicioCalificaciones()
        {
            byte i, numEstudiantes;
            double mejorNota = 0, peorNota = 100, peorEstudiante = 0, mejorEstudiante = 0, promedio = 0;
            

            Console.WriteLine("Digite la cantidad de alumnos");
            Console.Write("Alumnos: ");
            numEstudiantes = Convert.ToByte(Console.ReadLine());
            double[] calificaciones = new double[numEstudiantes];

            Console.WriteLine("Digite la calificación de los estudiantes");

            for (i = 0; i < numEstudiantes; i++)
            {
                Console.Write("Calificación #{0}: ", i+1);
                calificaciones[i] = Convert.ToDouble(Console.ReadLine());
                promedio += calificaciones[i] / numEstudiantes; 
            }

            for (i = 0; i < numEstudiantes; i++)
            {
                if (peorNota >= calificaciones[i])
                {
                    peorNota = calificaciones[i];
                    peorEstudiante = i+1;
                }

                if (mejorNota <= calificaciones[i])
                {
                    mejorNota = calificaciones[i];
                    mejorEstudiante = i+1;
                }
            }
            Console.WriteLine("El promedio de notas es: {0}", promedio);
            Console.WriteLine("La peor nota es la del estudiante #{0} con: {1}", peorEstudiante, peorNota);
            Console.WriteLine("La mejor nota es la del estudiante #{0} con: {1}", mejorEstudiante, mejorNota);

        }

        static void MatricesMultidimensionales()
        {
            //Estas matrices poseen dos o mas dimensiones
            //tipo[,] nombre = new tipo [filas, columnas]
            double[,] ventas = new double[4, 3] { {1, 2, 3},
                                                  {4, 5, 6},
                                                  {7, 8, 9},
                                                  {10, 11, 12} };

            Console.WriteLine("El último elemento de la matriz ventas es: {0}", ventas[2,3]);

            //Declaración e instancia de matriz de 3 dimensiones
            int[,,] matriz3D = new int[2, 2, 3] { { {01, 02, 03},{04, 05, 06} },
                                                  { {07, 08, 09},{10, 11, 12} } };

            Console.WriteLine("El último elemento de la matriz3D es: {0}", matriz3D[1, 1, 2]);
        }

        static void MatrizMultiAccederPorIteracion()
        {
            //Variables de control de ciclos
            int i; //Ciclo Exterior
            int j; //Ciclo Interior

            double[,] ventas = new double[4, 3] { {1, 2, 3},
                                                  {4, 5, 6},
                                                  {7, 8, 9},
                                                  {10, 11, 12} };

            for (i = 0; i < 4; i++)
            {

                for (j = 0; j < 3; j++)
                {
                    Console.WriteLine(ventas[i, j]);    
                     
                }
            }
        }

        static void MatrizMulti_EjercicioCalificaciones()
        {
            byte i, j, estudiantes, cursos;
            double mejorNota = 0, peorNota = 100, peorEstudiante = 0, mejorEstudiante = 0, promedio = 0, peorCurso = 0, mejorCurso = 0;
            
             
            Console.WriteLine("Digite la cantidad de cursos");
            Console.Write("Cursos: ");
            cursos = Convert.ToByte(Console.ReadLine());

            Console.WriteLine("Digite la cantidad de alumnos");
            Console.Write("Alumnos: ");
            estudiantes = Convert.ToByte(Console.ReadLine());
            double[,] calificaciones = new double[cursos,estudiantes];

            Console.WriteLine("Digite la calificación de los estudiantes de cada curso");

            for (i = 0; i < cursos; i++)
            {
                
                for (j = 0; j < estudiantes; j++)
                {
                    Console.Write("Curso #{0}, Calificación #{1}: ", i+1, j+1);
                    calificaciones[i, j] = Convert.ToDouble(Console.ReadLine());
                    promedio += calificaciones[i,j] / cursos*estudiantes;
                }
            }

            for (i = 0; i < cursos; i++)
            {


                for (j = 0; j < estudiantes; j++)
                {
                    if (peorNota >= calificaciones[i, j])
                    {
                        peorNota = calificaciones[i, j];
                        peorCurso = i+1; 
                        peorEstudiante = j+1;
                    }

                    if (mejorNota <= calificaciones[i, j])
                    {
                        mejorNota = calificaciones[i, j];
                        mejorCurso = i+1;
                        mejorEstudiante = j+1;
                    }
                }
            }
            Console.WriteLine("El promedio de notas es: {0}", promedio);
            Console.WriteLine("La calificación mínima viene del salón #{0}, es del estudiante #{1} con: {2}", peorCurso, peorEstudiante, peorNota);
            Console.WriteLine("La calificación máxima viene del salón #{0}, es del del estudiante #{1} con: {2}", mejorCurso, mejorEstudiante, mejorNota);

        }

        static void MatrizEscalonada()
        {
            //Estas matrices no mantienen el mismo tamaño en cada uno de sus lados, como se ve en la siguiente declaración

            //tipo [][] nombre = new tipo [filas][]
            double[][] ventas = new double[4][];

            //declaración de las matrices internas e inicialización
            ventas[0] = new double[] { 1, 2, 3 };
            ventas[1] = new double[] { 4, 5 };
            ventas[2] = new double[] { 6, 7, 8, 9 };
            ventas[3] = new double[] { 10 };

            //O también, de esta forma mas compacta

            double[][] ventas2 =
            {
                new double [] { 1, 2, 3 },
                new double [] { 4, 5 },
                new double [] { 6, 7, 8, 9 },
                new double [] { 10 }

            };

            //Para acceder a UNO de sus elementos, se hace de la siguiente forma
            Console.WriteLine("En la fila 0, el elemento 1 es: {0}", ventas[0][0]);
            Console.WriteLine("En la fila 1, el elemento 1 es: {0}", ventas[1][1]);
            Console.WriteLine("En la fila 2, el elemento 2 es: {0}", ventas[2][2]);
            Console.WriteLine("En la fila 3, el elemento 0 es: {0}", ventas[3][0]);

            //Para recorrer la totalidad de la matriz escalonada, hacemos lo siguiente:

            for (int i = 0; i < ventas.Length; i++)
            {
                Console.WriteLine("índice: {0}, ",i);
                for (int j = 0; j < ventas[i].Length; j++)
                {
                    Console.WriteLine("Elemento {0}: {1}", j, ventas[i][j]);
                }
            }

        }

        static void MatrizPropiedadLength()
        {

            //Esta propiedad devuelve el tamaño de la matriz
            double[][] ventas2 =
{
                new double [] { 1, 2, 3 },
                new double [] { 4, 5 },
                new double [] { 6, 7, 8, 9 },
                new double [] { 10 }

            };

            Console.WriteLine("El tamaño de la matriz es: {0}, es decir, tiene {0} matrices unidimensionales dentro de si misma.", ventas2.Length);
            Console.WriteLine("El tamaño del índice 0 de la matriz es: {0}, es decir, contiene {0} elementos.", ventas2[0].Length);
            Console.WriteLine("El tamaño del índice 1 de la matriz es: {0}, es decir, contiene {0} elementos.", ventas2[1].Length);
            Console.WriteLine("El tamaño del índice 2 de la matriz es: {0}, es decir, contiene {0} elementos.", ventas2[2].Length);
            Console.WriteLine("El tamaño del índice 3 de la matriz es: {0}, es decir, contiene {0} elementos.", ventas2[3].Length);

        }

        static void MatrizMetodoGetLength()
        {
            //Cuando no se conoce el 
        }

        static void Main(string[] args)
        {
            //MatrizUnidimensional()
            //MatrizUniAccederPorIteracion()
            //MatrizUniAlterarPorIteracion();
            //MatrizUni_EjercicioCalificaciones();
            //MatrizMultidimensional();
            //MatrizMultiAccederPorIteracion();
            //MatrizMulti_EjercicioCalificaciones();
            //MatrizEscalonada();
            //MatrizPropiedadLength();
            //MatrizMetodoGetLength();

           
        }


    }
}
