using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PortfolioEngCompUnopar_Console
{
    class Tensao
    {
        float corrente, resistor1, resistor2, resistor3;

        public void CalcularTensao()
        {
            Console.Write("\nDigite a corrente elétrica de entrada no circuito: ");
            corrente = float.Parse(Console.ReadLine());
            Console.Write("\nDigite o valor do Resistor R1: ");
            resistor1 = float.Parse(Console.ReadLine());
            Console.Write("\nDigite o valor do Resistor R2: ");
            resistor2 = float.Parse(Console.ReadLine());
            Console.Write("\nDigite o valor do Resistor R3: ");
            resistor3 = float.Parse(Console.ReadLine());
            Console.WriteLine($"\nA tensão elétrica do circuito é de {corrente * (resistor1 + resistor2 + resistor3)} volts.");
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