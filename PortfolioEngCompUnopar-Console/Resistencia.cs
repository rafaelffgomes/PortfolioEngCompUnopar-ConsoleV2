using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PortfolioEngCompUnopar_Console
{
    class Resistencia
    {
        float tensao, corrente;

        public void CalcularResistencia()
        {
            Console.Write("\nDigite a tensão de entrada no circuito: ");
            tensao = float.Parse(Console.ReadLine());
            Console.Write("\nDigite a corrente elétrica de entrada no circuito: ");
            corrente = float.Parse(Console.ReadLine());
            Console.WriteLine($"\nA resistência elétrica do circuito é de {tensao / corrente} ohms.");
            Console.WriteLine("\n\n\nDigite qualquer tecla para voltar ao menu principal, ou ESC para sair.");
            ConsoleKeyInfo keyInfo = Console.ReadKey(true);
            if (keyInfo.Key == ConsoleKey.Escape)
            {
                System.Environment.Exit(0);
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