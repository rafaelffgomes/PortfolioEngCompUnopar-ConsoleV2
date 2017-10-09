using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PortfolioEngCompUnopar_Console
{
    class Login
    {
        string usuario, senha;

        public void EfetuarLogin()
        {
            Console.Clear();
            Console.WriteLine("\nLogin Padrão: admin");
            Console.WriteLine("Senha Padrão: 1234");
            Console.Write("\n\nDigite o Login: ");
            usuario = Console.ReadLine();
            Console.Write("\nDigite a Senha: ");
            senha = Console.ReadLine();
            if ((usuario != "admin") || (senha != "1234"))
            {
                Console.WriteLine("\n\nLogin e Senha não conferem.");
                Console.WriteLine("\nDigite qualquer tecla para tentar novamente, ou ESC para sair.");
                ConsoleKeyInfo keyInfo = Console.ReadKey(true);
                if (keyInfo.Key == ConsoleKey.Escape)
                {
                    System.Environment.Exit(0);
                }
                else
                {
                    EfetuarLogin();
                }
            }
            else
            {
                Console.Clear();
                Opcao opc = new Opcao();
                opc.MostrarOpcao();
            }
        }
    }
}