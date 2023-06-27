using System;

namespace JuegoAhorcadito
{
    class Program
    {
        public static void Main(string[] args)
        {
            string[] palabrasParaAdivinar = {"titanic","napoleon", "perro", "leopardo", "manzana", "dos", "scary movie", "popeye"};

            Random generadorDeNumeroAleatorio = new Random();
            int numeroAleatorio = generadorDeNumeroAleatorio.Next(0,palabrasParaAdivinar.Length);

            string palabraOculta = palabrasParaAdivinar[numeroAleatorio];

            int intentosRestantes = 8;
            char letraIngresadaPorElUsuario;
            bool termino = false;
            string cadenaEnPantalla = "";

            MostrarGuionesConLaPalabraOculta();
            
            do
            {
                PedirUnaLetraAlUsuarioPorConsola();
                VerificarSiLaLetraIngresadaApareceEnLaPalabraOculta();

                if(!cadenaEnPantalla.Contains('-'))
                {
                    Console.WriteLine("Felicidades acertaste la palabra, " + palabraOculta);
                    termino = true;
                }
                else if(intentosRestantes <= 0)
                {
                    Console.WriteLine("Estuviste cerca la palabra era: " + palabraOculta);
                    termino = true;
                }

                Console.WriteLine("");
            }while(!termino);

            void VerificarSiLaLetraIngresadaApareceEnLaPalabraOculta()
            {
                if(!palabraOculta.Contains(letraIngresadaPorElUsuario))
                {
                    intentosRestantes --;
                    Console.WriteLine("Intentos restantes: " + intentosRestantes);
                    MostrarAhorcadito();
                }
                
                MostrarLetrasDescubiertas();
            }

            void MostrarAhorcadito()
            {
                switch(intentosRestantes)
                {
                    case 7:
                        Console.WriteLine("-");
                        Console.WriteLine("|");
                        Console.WriteLine("|");
                        Console.WriteLine("|");
                        Console.WriteLine("|");
                        Console.WriteLine("|");
                        Console.WriteLine("----");
                        break;
                    case 6:
                        Console.WriteLine("-------");
                        Console.WriteLine("|");
                        Console.WriteLine("|");
                        Console.WriteLine("|");
                        Console.WriteLine("|");
                        Console.WriteLine("|");
                        Console.WriteLine("----");
                        break;
                    case 5:
                        Console.WriteLine("-------");
                        Console.WriteLine("|    |");
                        Console.WriteLine("|");
                        Console.WriteLine("|");
                        Console.WriteLine("|");
                        Console.WriteLine("|");
                        Console.WriteLine("----");
                        break;
                    case 4:
                        Console.WriteLine("-------");
                        Console.WriteLine("|    |");
                        Console.WriteLine("|    O");
                        Console.WriteLine("|");
                        Console.WriteLine("|");
                        Console.WriteLine("|");
                        Console.WriteLine("----");
                        break;
                    case 3:
                        Console.WriteLine("-------");
                        Console.WriteLine("|    |");
                        Console.WriteLine("|    O");
                        Console.WriteLine("|   /|");
                        Console.WriteLine("|");
                        Console.WriteLine("|");
                        Console.WriteLine("----");
                        break;
                    case 2:                    
                        Console.WriteLine("-------");
                        Console.WriteLine("|    |");
                        Console.WriteLine("|    O");
                        Console.WriteLine("|   /|\\");
                        Console.WriteLine("|");
                        Console.WriteLine("|");
                        Console.WriteLine("----");
                        break;
                    case 1:
                        Console.WriteLine("-------");
                        Console.WriteLine("|    |");
                        Console.WriteLine("|    O");
                        Console.WriteLine("|   /|\\");
                        Console.WriteLine("|    |");
                        Console.WriteLine("|   /");
                        Console.WriteLine("----");
                        break;
                    case 0:
                        Console.WriteLine("-------");
                        Console.WriteLine("|    |");
                        Console.WriteLine("|    O");
                        Console.WriteLine("|   /|\\");
                        Console.WriteLine("|    |");
                        Console.WriteLine("|   / \\");
                        Console.WriteLine("----");
                        break;
                }
            }

            void MostrarLetrasDescubiertas()
            {
                string nuevaPalabra = "";

                for(int i=0; i<palabraOculta.Length; i++)
                {
                    if(palabraOculta[i] == ' ' || palabraOculta[i] != letraIngresadaPorElUsuario)
                    {
                        nuevaPalabra += cadenaEnPantalla[i];
                    }
                    else
                    {
                        nuevaPalabra += letraIngresadaPorElUsuario;
                    }
                }
                cadenaEnPantalla = nuevaPalabra;

                Console.WriteLine("Palabra oculta: " + cadenaEnPantalla);
            }

            void PedirUnaLetraAlUsuarioPorConsola()
            {
                while(true)
                {
                    try
                    {
                        Console.WriteLine("Ingresa una letra: ");

                        letraIngresadaPorElUsuario = Convert.ToChar(Console.ReadLine());

                        if(letraIngresadaPorElUsuario != ' ')
                        {
                            break;
                        }
                    }
                    catch
                    {
                        Console.WriteLine("Ingrese una letra valida...");
                    }
                }
            }

            void MostrarGuionesConLaPalabraOculta()
            {
                for(int i=0; i<palabraOculta.Length; i++)
                {
                    if(palabraOculta[i] == ' ')
                    {
                        cadenaEnPantalla += ' ';
                    }
                    else
                    {
                        cadenaEnPantalla += '-';
                    }
                }
                Console.WriteLine("Palabra oculta: " + cadenaEnPantalla);
            }

        }
    } 
}