using Laboratorio1.Model;
using System;

namespace Laboratorio1
{
    class Login
    {
        public void menu()
        {
            Console.Clear();
            Console.WriteLine("------------------------");
            Console.WriteLine("LABORATORIO 1");
            Console.WriteLine("------------------------");
            Console.WriteLine("------------------------");
            Console.WriteLine("1. Iniciar Sesión");
            Console.WriteLine("2. Salir");
            int option = int.Parse(Console.ReadLine());
            if (option == 1)
            {
                login();
            }
            else if (option == 2)
            {
                Environment.Exit(1);
            }
            else
            {
                menu();
            }
        }

        public void login()
        {
            Console.Clear();
            Console.WriteLine("------------------------");
            Console.WriteLine("INICIAR SESION");
            Console.WriteLine("------------------------");
            Console.Write("Ingresa el usuario: ");
            string username = Console.ReadLine();
            for (int i = 0; i < User.users.Count; i++)
            {
                if (username == User.users[i].Username)
                {
                    Console.Write("Ingresa la contraseña: ");
                    string password = Console.ReadLine();
                    if (password == User.users[i].Password)
                    {
                        if (User.users[i].Role == "admin")
                        {
                            new Administrator.Administrator().menu();
                        }
                        if (User.users[i].Role == "employee")
                        {
                            new Employee.Employee().menu();
                        }
                    }
                    else
                    {
                        Console.Write("Contraseña Incorrecta");
                    }
                }
            }
            Console.Write("Usuario Inexistente");
            menu();
        }

    }
}
