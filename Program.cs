using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace FPU3C_Ejemplo1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Manejo de estructuras selectivas
            #region IfCode
            //string nameUser, lastName, contactNumber, city, FBProfile, email;
            //string user, password, passwordConfirm,codeAccess;
            //byte age = 0;

            //Console.WriteLine("Ingresa tu nombre y al finalizar presiona ENTER");
            //nameUser = Console.ReadLine();
            //Console.WriteLine("Ingresa tu apellido y al finalizar presiona ENTER");
            //lastName = Console.ReadLine();

            //Console.WriteLine("Ingresa tu edad con digito y al finalizar presiona ENTER");
            //age = Convert.ToByte( Console.ReadLine());            


            ////If
            //if (age >= 18)
            //{
            //    Console.BackgroundColor = ConsoleColor.Gray;
            //    Console.ForegroundColor = ConsoleColor.DarkRed;
            //    Console.Clear();
            //    Console.WriteLine("Completa tu registgro para obtener tu código de acceso");
            //    //Codigo para completar el perfil
            //    Console.WriteLine("Ingresa tu número de teléfono celular");
            //    contactNumber = Console.ReadLine();
            //    Console.WriteLine("Ingresa tu ciudad de residencia");
            //    city = Console.ReadLine();
            //    Console.WriteLine("Ingresa tu perfil de Facebook");
            //    FBProfile = Console.ReadLine();
            //    Console.WriteLine("Ingresa tu cuemta de email");
            //    email = Console.ReadLine();

            //    //Solictar credenciales de acceso
            //    Console.WriteLine("Ingresa tu nombre de usuario");
            //    user = Console.ReadLine();
            //    Console.WriteLine("Ingresa tu contraseña");
            //    password = Console.ReadLine();
            //    Console.WriteLine("Vuelve a ingresar tu contraseña");
            //    passwordConfirm = Console.ReadLine();

            //    if (password == passwordConfirm)
            //    {
            //        //Numeros aletorios
            //        Random rnd = new Random();
            //        codeAccess = rnd.Next(1000, 9999).ToString();
            //        Console.WriteLine("Código de acceso: {0}", codeAccess);
            //    }
            //    else {
            //        Console.WriteLine("Contraseña incorrecta, vuelve a escribirla");
            //        Thread.Sleep(2000);
            //        return;
            //    }

            //}
            //else
            //{
            //    Console.WriteLine("Solo pueden entrar mayores de edad");
            //}
            #endregion

            //Estructura switch
            string nombre, carrera, categoria;
            double pagoTotal = 90, pagoPorCategoria;
            byte numeroHoras;

            //Solicitar los datos      
            Console.WriteLine("ingresa el nombre completo del maestro");
            nombre = Console.ReadLine();
            //-----
            Console.WriteLine("Selecciona la carrera de adscripción del maestro: \n ISIC \t IIND \t IGEM \t ILOG");
            carrera = Console.ReadLine();
            //-----
            Console.WriteLine("Selecciona la categoria del maestro: \n A \t B \t C ");
            categoria = Console.ReadLine();
            //-----
            Console.WriteLine("Ingresa con número las horas por semana del maestro ");
            numeroHoras = Convert.ToByte( Console.ReadLine());
            //SWITCH
            switch (categoria)
            {
                case "A":
                    pagoTotal = (pagoTotal * numeroHoras) * 1.0048;
                    Console.WriteLine(pagoTotal);
                    break;
                case "B":
                    pagoTotal = (pagoTotal * numeroHoras) * 1.0063;
                    Console.WriteLine(pagoTotal);
                    break;
                case "C":
                    pagoTotal = (pagoTotal * numeroHoras) * 1.0098;
                    Console.WriteLine(pagoTotal);
                    break;
                default:
                    break;
            }

            Console.WriteLine("Saliendo del sistema.");
            Thread.Sleep(1000);
            Console.WriteLine("Saliendo del sistema..");
            Thread.Sleep(1000);
            Console.WriteLine("Saliendo del sistema...");
            Thread.Sleep(1000);
            Console.WriteLine("Saliendo del sistema....");
            Thread.Sleep(1000);
        }
    }
}
