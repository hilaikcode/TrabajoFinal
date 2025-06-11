using System.ComponentModel.Design;

namespace TrabajoFinal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string usuarioDefecto = "usuario";
            string contraseñaDefecto = "0123456789";
            string usuarioIngresado = "";
            string contraseñaIngresada = "";

            Console.WriteLine("Bienvenido al Programa");
            do
            {
                //Autentificacion
                Console.WriteLine("Ingrese el usuario: ");
                usuarioIngresado = Console.ReadLine();
                Console.WriteLine("Ingrese la contraseña: ");
                contraseñaIngresada = Console.ReadLine();
                //Menús
                byte menu = 0;
                byte menuUsuarios = 0;
                byte menuArticulos = 0;
                byte menuVentas = 0;

              

                if (usuarioIngresado == usuarioDefecto) //autentificacion
                {
                    Console.Clear();
                    Console.WriteLine("Ha Ingresado correctamente");

                    do
                    {
                        
                        Console.WriteLine("Seleccione una de las opciones");
                        Console.WriteLine("1. Gestión de usuarios");
                        Console.WriteLine("2. Gestión de artículos");
                        Console.WriteLine("3. Gestión de ventas");
                        Console.WriteLine("4. Salir del programa");
                        menu = Byte.Parse(Console.ReadLine());

                        switch (menu) // menú principal
                        {

                            case 1: // Usuarios
                                Console.Clear();

                                do
                                {
                                    Console.WriteLine("Seleccione una de las opciones: ");


                                    Console.WriteLine("1. Ver lista de usuarios");
                                    Console.WriteLine("2. Nuevo Usuario");
                                    Console.WriteLine("3. Editar Informacion de Usuario");
                                    Console.WriteLine("4. Salir de gestión de usuarios");
                                    menuUsuarios = Convert.ToByte(Console.ReadLine());


                                    switch (menuUsuarios)
                                    {
                                        case 1: //1. Ver lista de usuarios
                                            Console.Clear();
                                            break;

                                        case 2: //2. Nuevo Usuario
                                            Console.Clear();
                                        break;

                                        case 3: //3. Editar Informacion de Usuario
                                            Console.Clear();
                                        break;

                                        case 4: //4. Salir de gestión de usuarios
                                            Console.Clear();
                                        break;

                                        default:
                                            Console.WriteLine("ERROR AL SELECCIONAR");
                                            break;
                                    }

                                    } while (menuUsuarios != 4);
                                break;

                            case 2: // Artículos
                                Console.Clear();

                                do
                                {
                                    Console.WriteLine("1. Ver lista de artículos");
                                    Console.WriteLine("2. Nuevo artículo");
                                    Console.WriteLine("3. Editar Informacion de artículo");
                                    Console.WriteLine("4. Salir de gestión de artículos");
                                    menuUsuarios = Convert.ToByte(Console.ReadLine());

                                    switch (menuArticulos)
                                    {
                                        case 1: //1. Ver lista de artículos
                                            Console.Clear();
                                        break;

                                        case 2: //2. Nuevo artículo
                                            Console.Clear();
                                        break;
                                            
                                        case 3: //3. Editar Informacion de artículo
                                            Console.Clear();
                                        break; 
                                        
                                        case 4: //4. Salir de gestión de artículos
                                            Console.Clear();
                                        break; 
                                        
                                        default:
                                            Console.WriteLine("ERROR AL SELECCIONAR");
                                        break;
                                    }

                                    } while (menuArticulos != 4);    

                                break;

                            case 3: // Ventas
                                Console.Clear();
                                do
                                {
                                    Console.WriteLine("Bienvenido al módulo de gestión de ventas");
                                    Console.WriteLine("Selecciones una de las opciones");
                                    Console.WriteLine("1. Registrar venta");
                                    Console.WriteLine("2. Salir de Gestión de ventas");
                                    menuVentas = Byte.Parse(Console.ReadLine());

                                    switch (menuVentas)
                                    {
                                        case 1: //1. Registrar venta
                                            Console.Clear();
                                            break;

                                        case 2: //2. Salir de Gestión de ventas
                                            Console.Clear();
                                            break;

                                        default:
                                            Console.WriteLine("ERROR AL SELECCIONAR");
                                            break;
                                    }
                                     

                                    } while (menuArticulos != 2);

                                break;

                            case 4: // Salir del programa
                                Console.Clear();

                                break;

                            default: //error

                                Console.WriteLine("ERROR AL SELECCIONAR");

                                break;

                        }








                    } while (menu !=4);









                }
                else
                {   
                    Console.Clear();
                    Console.WriteLine("ERROR DE AUNTENTIFICACIÓN");
                }  
            }while (usuarioDefecto != usuarioIngresado);
        }
    }
}
