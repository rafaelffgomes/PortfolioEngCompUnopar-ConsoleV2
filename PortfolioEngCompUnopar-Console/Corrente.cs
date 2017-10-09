using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PortfolioEngCompUnopar_Console
{
    class Corrente
    {
        float tensao, resistor1, resistor2, resistor3;

        public void CalcularCorrente()
        {
            Console.Write("\nDigite a tensão de entrada no circuito: ");
            tensao = float.Parse(Console.ReadLine());
            Console.Write("\nDigite o valor do Resistor R1: ");
            resistor1 = float.Parse(Console.ReadLine());
            Console.Write("\nDigite o valor do Resistor R2: ");
            resistor2 = float.Parse(Console.ReadLine());
            Console.Write("\nDigite o valor do Resistor R3: ");
            resistor3 = float.Parse(Console.ReadLine());
            Console.WriteLine($"\nA corrente elétrica do circuito é de {tensao / (resistor1 + resistor2 + resistor3)} amperes.");
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