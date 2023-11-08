﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Prueba
{
    class Program
    {
        static void Main()
        {
            // Variables
            string nombreJugador1, nombreJugador2;
            int primerTurno;

            //Pedimos el nombre del jugador 1
            Console.Write("Jugador 1, escoge tu nombre: ");
            nombreJugador1 = Console.ReadLine();

            // Creamos al primer jugador y enviamos su nombre y salud inicial
            Jugador jugador1 = new Jugador(nombreJugador1, 1000);

            //Le preguntamos al primer jugador el personaje y arma que va a usar
            jugador1.EscogerPersonaje();
            jugador1.EscogerArma();

            //Pedimos el nombre del jugador 2
            Console.Write("Jugador 2, escoge tu nombre: ");
            nombreJugador2 = Console.ReadLine();

            // Creamos al segundo jugador y enviamos su nombre y salud inicial
            Jugador jugador2 = new Jugador(nombreJugador2, 1000);

            // Le preguntamos al segundo jugador el personaje y arma que va a usar
            jugador2.EscogerPersonaje();
            jugador2.EscogerArma();

            // Invocamos a "TirarDados" y guardamos el valor random devuelto en la variable "primerTurno"
            primerTurno = Batalla.TirarDados();

            // Determinamos cuál jugador empezará primero
            if (primerTurno == 1)
            {
                // El jugador 1 empieza primero
                Console.WriteLine($"{jugador1.Nombre} empieza primero!\n");

                // Enviamos primero al jugador1 para que él realice el primer ataque
                Batalla.SimularBatalla(jugador1, jugador2);
            }
            else
            {
                // El jugador 2 empieza primero
                Console.WriteLine($"{jugador2.Nombre} empieza primero!\n");

                // Enviamos primero al jugador2 para que él realice el primer ataque
                Batalla.SimularBatalla(jugador2, jugador1);
            }

        } //Fin Main

    } //Fin class program

    enum TipoPersonaje
    {
        Escudero,
        Arquero,
        Caballero
    }

    enum TipoArma
    {
        Espada,
        Arco,
        Martillo
    }

    class Jugador
    {
        // Campos
        string nombre;
        int salud;
        int ataque;
        int defensa;
        TipoPersonaje personajeEscogido;
        TipoArma armaEquipada;

        //Instanciamos a "Random" para poder hacer uso de ella
        Random random = new Random();

        //Propiedades
        public string Nombre { get => nombre; set => nombre = value; }
        public int Salud { get => salud; set => salud = value; }
        public int Ataque { get => ataque; set => ataque = value; }
        public int Defensa { get => defensa; set => defensa = value; }
        internal TipoPersonaje PersonajeEscogido { get => personajeEscogido; set => personajeEscogido = value; }
        internal TipoArma ArmaEquipada { get => armaEquipada; set => armaEquipada = value; }

        // Constructor
        public Jugador(string nombrePa, int saludPa)
        {
            nombre = nombrePa;
            salud = saludPa;
        }

        // Método que permite al usuario escoger uno de los 3 personajes del enum "TipoPersonaje"
        public void EscogerPersonaje()
        {
            //Guarda el valor de la opción escogida
            int opcion;

            Console.Clear();

            // Mientras "opcion" no sea 1,2 o 3, se le seguirá pidiendo al usuario que ingrese una opción
            do
            {
                Console.WriteLine("1. Escudero");
                Console.WriteLine("2. Arquero");
                Console.WriteLine("3. Caballero");

                Console.Write($"\n{Nombre}, escoge un personaje: ");
                opcion = Convert.ToInt32(Console.ReadLine());

                Console.Clear();

                switch (opcion)
                {
                    //Le asignamos al campo "PersonajeEscogido"
                    case 1:
                        PersonajeEscogido = TipoPersonaje.Escudero;
                        ResumenPersonajeEscogido();
                        break;
                    case 2:
                        PersonajeEscogido = TipoPersonaje.Arquero;
                        ResumenPersonajeEscogido();
                        break;
                    case 3:
                        PersonajeEscogido = TipoPersonaje.Caballero;
                        ResumenPersonajeEscogido();
                        break;
                    default:
                        Console.WriteLine("Opción inválida. Intenta de nuevo");
                        break;
                }

            } while (opcion < 1 || opcion > 3);
        }

        public void ResumenPersonajeEscogido()
        {
            // Mostramos un resumen del personaje que escogió el jugador
            Console.WriteLine($"{Nombre}, ahora eres \"{PersonajeEscogido}\"");

            Console.Write("\nPresiona cualquier tecla para continuar...");
            Console.ReadKey();

            Console.Clear();
        }

        // Método para que el usuario escoja el arma que usará
        public void EscogerArma()
        {
            //Guarda el valor de la opción escogida
            int opcion;

            Console.Clear();

            // Mientras "opcion" no sea 1,2 o 3, se le seguirá pidiendo al usuario que ingrese una opción
            do
            {
                Console.WriteLine("1. Espada (Ataque: 130, Defensa: 40)");
                Console.WriteLine("2. Arco (Ataque: 140, Defensa: 30)");
                Console.WriteLine("3. Martillo (Ataque: 150, Defensa: 20)");

                Console.Write($"\n{Nombre}, elige un arma: ");
                opcion = Convert.ToInt32(Console.ReadLine());

                Console.Clear();

                switch (opcion)
                {
                    case 1:
                        ArmaEquipada = TipoArma.Espada;
                        ValoresAtaqueDefensaArma();
                        ResumenArmaEscogida();
                        break;
                    case 2:
                        ArmaEquipada = TipoArma.Arco;
                        ValoresAtaqueDefensaArma();
                        ResumenArmaEscogida();
                        break;
                    case 3:
                        ArmaEquipada = TipoArma.Martillo;
                        ValoresAtaqueDefensaArma();
                        ResumenArmaEscogida();
                        break;
                    default:
                        Console.WriteLine("Opción inválida. Intenta de nuevo");
                        break;
                }
            } while (opcion < 1 || opcion > 3);
        }

        // Método para asignar valores de ataque y defensa al jugador dependiendo del arma que equipen
        public void ValoresAtaqueDefensaArma()
        {
            switch (ArmaEquipada)
            {
                case TipoArma.Espada:
                    Ataque = 130;
                    Defensa = 40;
                    break;
                case TipoArma.Arco:
                    Ataque = 140;
                    Defensa = 30;
                    break;
                case TipoArma.Martillo:
                    Ataque = 150;
                    Defensa = 20;
                    break;
            }
        }

        public void ResumenArmaEscogida()
        {
            Console.WriteLine($"{Nombre}, escogiste \"{ArmaEquipada}\"\nCon un nivel de ataque de [{Ataque}] y una defensa de [{Defensa}]");

            Console.Write("\nPresiona cualquier tecla para continuar...");
            Console.ReadKey();
            Console.Clear();
        }

        // Método para mostrar un mensaje cuando el jugador decida atacar
        public void Atacar()
        {
            Console.WriteLine($"\n¡{PersonajeEscogido} {Nombre} ataca con su {ArmaEquipada}!\n");
        }

        // Método para mostrar un mensaje cuando el jugador decida defender
        public void Defender()
        {
            Console.WriteLine($"\n¡{PersonajeEscogido} {Nombre} se defiende con su {ArmaEquipada}!\n");
        }

        // Método para preguntarle al usuario si desea atacar o defender
        public void EscogerAtacarDefender()
        {
            //Guarda el valor de la opción escogida
            int opcion;

            // Mientras "opcion" no sea 1 o 2, se le seguirá pidiendo al usuario que ingrese una opción
            do
            {
                Console.WriteLine("1. Atacar");
                Console.WriteLine("2. Defender");

                Console.Write($"\n[{PersonajeEscogido} {Nombre}], elige una acción: ");
                opcion = Convert.ToInt32(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        Atacar();
                        break;
                    case 2:
                        Defender();
                        break;
                    default:
                        Console.WriteLine("Opción inválida. Intenta de nuevo");
                        break;
                }

            } while (opcion < 1 || opcion > 2);
        }

        // Método que nos muestra un resumen de los jugadores
        public void ResumenJugador()
        {
            Console.WriteLine($"[{PersonajeEscogido} {Nombre}] Salud: {Salud} / [{ArmaEquipada}] Ataque: {Ataque}, Defensa: {Defensa}");
        }


        // Método encargado de calcular el daño que un personaje inflinge sobre otro en función de los valores de ataque y defensa de su arma
        public void CalcularDaño(int ataqueOtroJugadorPa)
        {
            //Variable para recibir el valor aleatorio de ataque sorpresa
            int ataqueSorpresa;

            // Le asignamos un valor de ataque aleatorio usando Next
            ataqueSorpresa = random.Next(-15, 16);

            int dañoRecibido;
            dañoRecibido = ataqueOtroJugadorPa - Defensa + ataqueSorpresa;

            //Reducimos la vida del jugador
            Salud -= dañoRecibido;
        }

    } //Fin class Jugador

    class Batalla
    {
        // Campos
        static Random random = new Random();

        // Método que determina cuál jugador empezará primero
        public static int TirarDados()
        {
            Console.Write("Presiona cualquier tecla para tirar los dados y determinar quién comienza...");
            Console.ReadKey();
            Console.Clear();

            //Variable que guarda el valor de los dados
            int primerTurno;

            //Le asignamos a "primerTurno" uno de dos posibles valores (1 o 2) así sabremos qué jugador empezará primero
            primerTurno = random.Next(1, 3);
            return primerTurno;
        }

        public static void SimularBatalla(Jugador jugador1Pa, Jugador jugador2Pa)
        {
            // Variable encargada de controlar las rondas de los jugadores
            int ronda = 1;

            // Mensaje inicial
            Console.WriteLine("¡La batalla ha comenzado!\n");
            Console.WriteLine($"RONDA {ronda}\n");

            // Mostramos un resumen de cada jugador
            jugador1Pa.ResumenJugador();
            jugador2Pa.ResumenJugador();

            // Primera ronda del jugador 1
            Console.WriteLine($"\n{jugador1Pa.PersonajeEscogido} {jugador1Pa.Nombre}, empieza a atacar!");
            Console.Write($"Presiona Enter para usar tu {jugador1Pa.ArmaEquipada}...");
            Console.ReadKey();
            jugador1Pa.Atacar();

            //Calculamos el daño que el jugador 1 acaba de hacerle al jugador 2
            jugador2Pa.CalcularDaño(jugador1Pa.Ataque);

            // Primera ronda del jugador 2
            // Le preguntamos qué desea hacer
            jugador2Pa.EscogerAtacarDefender();

            // Calculamos el daño que el jugador 2 acaba de hacerle al jugador 1
            jugador1Pa.CalcularDaño(jugador2Pa.Ataque);

            // Seguimos haciendo lo mismo por otras 4 rondas más
            for (ronda = 2; ronda <= 5; ronda++)
            {
                // Mostramos la ronda que se está jugando
                Console.WriteLine($"RONDA {ronda}\n");

                // Mostramos un resumen de cada jugador
                jugador1Pa.ResumenJugador();
                jugador2Pa.ResumenJugador();

                // Le preguntamos al jugador 1 qué desea hacer
                jugador1Pa.EscogerAtacarDefender();
                //Calculamos el daño que el jugador 1 acaba de hacerle al jugador 2
                jugador2Pa.CalcularDaño(jugador1Pa.Ataque);

                // Le preguntamos al jugador 2 qué desea hacer
                jugador2Pa.EscogerAtacarDefender();
                //Calculamos el daño que el jugador 2 acaba de hacerle al jugador 1
                jugador1Pa.CalcularDaño(jugador2Pa.Ataque);

                // Espacio en blanco para después de cada ronda
                Console.WriteLine();
            }

            // Mensaje dando por terminada la batalla
            Console.WriteLine("\n¡La batalla ha terminado!\n");

            // Mostramos por última vez las estadísticas de cada jugador
            jugador1Pa.ResumenJugador();
            jugador2Pa.ResumenJugador();

            // Determinamos quién ganó la batalla basándonos en su nivel de salud final
            if (jugador1Pa.Salud > jugador2Pa.Salud)
            {
                // Si el jugador 1 terminó con más vida que el jugador 2
                Console.WriteLine($"\n¡{jugador1Pa.Nombre} ha ganado la batalla!");
            }
            else
            {
                // Si el jugador 2 terminó con más vida que el jugador 1
                Console.WriteLine($"\n¡{jugador2Pa.Nombre} ha ganado la batalla!");
            }
        }

    }//Fin class Batalla

} //Fin Namespace