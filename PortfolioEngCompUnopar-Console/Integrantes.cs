using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PortfolioEngCompUnopar_Console
{
    class Integrantes
    {
        string aluno1 = "RAFAEL FIGUEIREDO FERREIRA GOMES";
        string aluno2 = "JOSÉ RAIMUNDO ALVES";
        string aluno3 = "MARCOS FONSECA DE MOURA";
        string aluno4 = "JHONATA DA SILVA RAMOS";

        public void DadosCurso()
        {
            Console.WriteLine("\nPortfólio de Engenharia da Computação \nUNOPAR 5º PERÍODO");
            Console.WriteLine("\nIntegrantes do grupo:");
        }

        public void DadosIntegrantes()
        {
            Console.WriteLine($"\n{aluno1}");
            Console.WriteLine($"{aluno2}");
            Console.WriteLine($"{aluno3}");
            Console.WriteLine($"{aluno4}");
        }

        public void Continuar()
        {
            Console.WriteLine("\n\nPressione qualquer tecla para continuar ou ESC para sair...");
            ConsoleKeyInfo keyInfo = Console.ReadKey(true);
            if (keyInfo.Key == ConsoleKey.Escape)
            {
                System.Environment.Exit(0);
            }
            else
            {
                Login lgn = new Login();
                lgn.EfetuarLogin();
            }
        }
    }
}